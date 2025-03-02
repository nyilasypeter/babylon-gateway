/* Copyright 2021 Radix Publishing Ltd incorporated in Jersey (Channel Islands).
 *
 * Licensed under the Radix License, Version 1.0 (the "License"); you may not use this
 * file except in compliance with the License. You may obtain a copy of the License at:
 *
 * radixfoundation.org/licenses/LICENSE-v1
 *
 * The Licensor hereby grants permission for the Canonical version of the Work to be
 * published, distributed and used under or by reference to the Licensor’s trademark
 * Radix ® and use of any unregistered trade names, logos or get-up.
 *
 * The Licensor provides the Work (and each Contributor provides its Contributions) on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied,
 * including, without limitation, any warranties or conditions of TITLE, NON-INFRINGEMENT,
 * MERCHANTABILITY, or FITNESS FOR A PARTICULAR PURPOSE.
 *
 * Whilst the Work is capable of being deployed, used and adopted (instantiated) to create
 * a distributed ledger it is your responsibility to test and validate the code, together
 * with all logic and performance of that code under all foreseeable scenarios.
 *
 * The Licensor does not make or purport to make and hereby excludes liability for all
 * and any representation, warranty or undertaking in any form whatsoever, whether express
 * or implied, to any entity or person, including any representation, warranty or
 * undertaking, as to the functionality security use, value or other characteristics of
 * any distributed ledger nor in respect the functioning or value of any tokens which may
 * be created stored or transferred using the Work. The Licensor does not warrant that the
 * Work or any use of the Work complies with any law or regulation in any territory where
 * it may be implemented or used or that it will be appropriate for any specific purpose.
 *
 * Neither the licensor nor any current or former employees, officers, directors, partners,
 * trustees, representatives, agents, advisors, contractors, or volunteers of the Licensor
 * shall be liable for any direct or indirect, special, incidental, consequential or other
 * losses of any kind, in tort, contract or otherwise (including but not limited to loss
 * of revenue, income or profits, or loss of use or data, or loss of reputation, or loss
 * of any economic or other opportunity of whatsoever nature or howsoever arising), arising
 * out of or in connection with (without limitation of any use, misuse, of any ledger system
 * or use made or its functionality or any performance or operation of any code or protocol
 * caused by bugs or programming or logic errors or otherwise);
 *
 * A. any offer, purchase, holding, use, sale, exchange or transmission of any
 * cryptographic keys, tokens or assets created, exchanged, stored or arising from any
 * interaction with the Work;
 *
 * B. any failure in a transmission or loss of any token or assets keys or other digital
 * artefacts due to errors in transmission;
 *
 * C. bugs, hacks, logic errors or faults in the Work or any communication;
 *
 * D. system software or apparatus including but not limited to losses caused by errors
 * in holding or transmitting tokens by any third-party;
 *
 * E. breaches or failure of security including hacker attacks, loss or disclosure of
 * password, loss of private key, unauthorised use or misuse of such passwords or keys;
 *
 * F. any losses including loss of anticipated savings or other benefits resulting from
 * use of the Work or any changes to the Work (however implemented).
 *
 * You are solely responsible for; testing, validating and evaluation of all operation
 * logic, functionality, security and appropriateness of using the Work for any commercial
 * or non-commercial purpose and for any reproduction or redistribution by You of the
 * Work. You assume all risks associated with Your use of the Work and the exercise of
 * permissions under this License.
 */

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RadixDlt.NetworkGateway.Abstractions;
using RadixDlt.NetworkGateway.Abstractions.Extensions;
using RadixDlt.NetworkGateway.Abstractions.Model;
using RadixDlt.NetworkGateway.DataAggregator.Configuration;
using RadixDlt.NetworkGateway.DataAggregator.Monitoring;
using RadixDlt.NetworkGateway.DataAggregator.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RadixDlt.NetworkGateway.PostgresIntegration.Services;

internal class PendingTransactionPrunerService : IPendingTransactionPrunerService
{
    private readonly IDbContextFactory<ReadWriteDbContext> _dbContextFactory;
    private readonly IOptionsMonitor<MempoolOptions> _mempoolOptionsMonitor;
    private readonly ISystemStatusService _systemStatusService;
    private readonly ILogger<PendingTransactionPrunerService> _logger;
    private readonly IEnumerable<IPendingTransactionPrunerServiceObserver> _observers;
    private readonly IClock _clock;

    public PendingTransactionPrunerService(
        IDbContextFactory<ReadWriteDbContext> dbContextFactory,
        IOptionsMonitor<MempoolOptions> mempoolOptionsMonitor,
        ISystemStatusService systemStatusService,
        ILogger<PendingTransactionPrunerService> logger,
        IEnumerable<IPendingTransactionPrunerServiceObserver> observers,
        IClock clock)
    {
        _dbContextFactory = dbContextFactory;
        _mempoolOptionsMonitor = mempoolOptionsMonitor;
        _systemStatusService = systemStatusService;
        _logger = logger;
        _observers = observers;
        _clock = clock;
    }

    public async Task PrunePendingTransactions(CancellationToken token = default)
    {
        await using var dbContext = await _dbContextFactory.CreateDbContextAsync(token);

        var rawCountByStatus = await dbContext.PendingTransactions
            .GroupBy(t => t.Status)
            .Select(g => new { Status = g.Key, Count = g.Count() })
            .ToListAsync(token);

        var countByStatus = rawCountByStatus
            .Select(g => new PendingTransactionStatusCount(g.Status, g.Count))
            .ToList();

        await _observers.ForEachAsync(x => x.PrePendingTransactionPrune(countByStatus));

        var mempoolConfiguration = _mempoolOptionsMonitor.CurrentValue;

        var currTime = _clock.UtcNow;
        var pruneIfCommittedBefore = currTime - mempoolConfiguration.PruneCommittedAfter;
        var pruneIfLastGatewaySubmissionBefore = currTime - mempoolConfiguration.PruneMissingTransactionsAfterTimeSinceLastGatewaySubmission;
        var pruneIfFirstSeenBefore = currTime - mempoolConfiguration.PruneMissingTransactionsAfterTimeSinceFirstSeen;
        var pruneIfNotSeenSince = currTime - mempoolConfiguration.PruneRequiresMissingFromMempoolFor;

        var aggregatorIsSyncedUpEnoughToRemoveCommittedTransactions = _systemStatusService.GivenClockDriftBoundIsTopOfDbLedgerValidatorCommitTimestampConfidentlyAfter(
            mempoolConfiguration.AssumedBoundOnNetworkLedgerDataAggregatorClockDrift,
            pruneIfCommittedBefore
        );

        var transactionsToPrune = await dbContext.PendingTransactions
            .Where(mt =>
                (
                    /* For committed transactions, remove from the mempool if we're synced up (as a committed transaction will be on ledger) */
                    (mt.Status == PendingTransactionStatus.CommittedSuccess || mt.Status == PendingTransactionStatus.CommittedFailure)
                    && aggregatorIsSyncedUpEnoughToRemoveCommittedTransactions
                    && mt.CommitTimestamp!.Value < pruneIfCommittedBefore
                )
                ||
                (
                    /* For those submitted by this gateway, prune if it was submitted a while ago and was not seen in the mempool recently */
                    mt.SubmittedByThisGateway
                    && mt.LastSubmittedToGatewayTimestamp!.Value < pruneIfLastGatewaySubmissionBefore
                    && (mt.LastDroppedOutOfMempoolTimestamp != null && mt.LastDroppedOutOfMempoolTimestamp < pruneIfNotSeenSince)
                )
                ||
                (
                    /* For those not submitted by this gateway, prune if it first appeared a while ago and was not seen in the mempool recently */
                    !mt.SubmittedByThisGateway
                    && mt.FirstSeenInMempoolTimestamp!.Value < pruneIfFirstSeenBefore
                    && (mt.LastDroppedOutOfMempoolTimestamp != null && mt.LastDroppedOutOfMempoolTimestamp < pruneIfNotSeenSince)
                )
            )
            .ToListAsync(token);

        if (transactionsToPrune.Count > 0)
        {
            _logger.LogInformation(
                "Pruning {PrunedCount} transactions from the pending list, of which {PrunedCommittedCount} were committed",
                transactionsToPrune.Count,
                transactionsToPrune.Count(t => t.Status is PendingTransactionStatus.CommittedSuccess or PendingTransactionStatus.CommittedFailure)
            );

            await _observers.ForEachAsync(x => x.PreMempoolTransactionPruned(transactionsToPrune.Count));

            dbContext.PendingTransactions.RemoveRange(transactionsToPrune);
            await dbContext.SaveChangesAsync(token);
        }
    }
}
