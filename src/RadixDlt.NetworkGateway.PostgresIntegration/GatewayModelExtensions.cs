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

using Newtonsoft.Json.Linq;
using RadixDlt.NetworkGateway.Abstractions;
using RadixDlt.NetworkGateway.Abstractions.Extensions;
using RadixDlt.NetworkGateway.Abstractions.Model;
using RadixDlt.NetworkGateway.PostgresIntegration.Models;
using RadixDlt.NetworkGateway.PostgresIntegration.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using GatewayModel = RadixDlt.NetworkGateway.GatewayApiSdk.Model;

namespace RadixDlt.NetworkGateway.PostgresIntegration;

internal static class GatewayModelExtensions
{
    public static GatewayModel.NonFungibleIdType ToGatewayModel(this NonFungibleIdType nonFungibleIdType)
    {
        return nonFungibleIdType switch
        {
            NonFungibleIdType.String => GatewayModel.NonFungibleIdType.String,
            NonFungibleIdType.Integer => GatewayModel.NonFungibleIdType.Integer,
            NonFungibleIdType.Bytes => GatewayModel.NonFungibleIdType.Bytes,
            NonFungibleIdType.UUID => GatewayModel.NonFungibleIdType.Uuid,
            _ => throw new ArgumentOutOfRangeException(nameof(nonFungibleIdType), nonFungibleIdType, null),
        };
    }

    public static GatewayModel.TransactionStatus ToGatewayModel(this PendingTransactionStatus status)
    {
        return status switch
        {
            PendingTransactionStatus.SubmittedOrKnownInNodeMempool => GatewayModel.TransactionStatus.Pending,
            PendingTransactionStatus.Missing => GatewayModel.TransactionStatus.Pending,
            PendingTransactionStatus.RejectedTemporarily => GatewayModel.TransactionStatus.Pending,
            PendingTransactionStatus.RejectedPermanently => GatewayModel.TransactionStatus.Rejected,
            PendingTransactionStatus.CommittedSuccess => GatewayModel.TransactionStatus.CommittedSuccess,
            PendingTransactionStatus.CommittedFailure => GatewayModel.TransactionStatus.CommittedFailure,
            _ => throw new ArgumentOutOfRangeException(nameof(status), status, null),
        };
    }

    public static GatewayModel.PublicKey ToGatewayPublicKey(this ValidatorPublicKeyHistory validatorPublicKey)
    {
        var keyHex = validatorPublicKey.Key.ToHex();

        return validatorPublicKey.KeyType switch
        {
            PublicKeyType.EcdsaSecp256k1 => new GatewayModel.PublicKeyEcdsaSecp256k1(keyHex),
            PublicKeyType.EddsaEd25519 => new GatewayModel.PublicKeyEddsaEd25519(keyHex),
            _ => throw new UnreachableException($"Didn't expect {validatorPublicKey.KeyType} value"),
        };
    }

    public static GatewayModel.NonFungibleResourcesCollection MapToNonFungibleResourcesCollection(
        List<EntityStateQuerier.NonFungibleAggregatedPerVaultViewModel> input,
        List<EntityStateQuerier.NonFungibleIdWithOwnerDataViewModel>? nonFungibleIds,
        int vaultOffset, int vaultLimit, int resourceOffset, int resourceLimit)
    {
        var resourcesTotalCount = 0;
        var resources = new Dictionary<GlobalAddress, GatewayApiSdk.Model.NonFungibleResourcesCollectionItemVaultAggregated>();

        foreach (var vm in input)
        {
            resourcesTotalCount = vm.ResourceTotalCount;

            if (!resources.TryGetValue(vm.ResourceEntityGlobalAddress, out var existingRecord))
            {
                var vaultNextCursor = vm.VaultTotalCount > vaultLimit
                    ? new GatewayApiSdk.Model.OffsetCursor(vaultLimit).ToCursorString()
                    : null;

                existingRecord = new GatewayApiSdk.Model.NonFungibleResourcesCollectionItemVaultAggregated(
                    resourceAddress: vm.ResourceEntityGlobalAddress,
                    vaults: new GatewayApiSdk.Model.NonFungibleResourcesCollectionItemVaultAggregatedVault(
                        totalCount: vm.VaultTotalCount,
                        nextCursor: vaultNextCursor,
                        items: new List<GatewayApiSdk.Model.NonFungibleResourcesCollectionItemVaultAggregatedVaultItem>()));

                resources[vm.ResourceEntityGlobalAddress] = existingRecord;
            }

            var ids = nonFungibleIds?
                .Where(x => x.ResourceEntityId == vm.ResourceEntityId && x.VaultEntityId == vm.VaultEntityId)
                .Select(x => x.NonFungibleId).ToList();

            existingRecord.Vaults.Items.Add(new GatewayApiSdk.Model.NonFungibleResourcesCollectionItemVaultAggregatedVaultItem(
                totalCount: vm.NonFungibleIdsCount,
                vaultAddress: vm.VaultAddress,
                lastUpdatedAtStateVersion: vm.LastUpdatedAtStateVersion,
                items: ids));
        }

        var previousCursor = resourceOffset > 0
            ? new GatewayApiSdk.Model.OffsetCursor(Math.Max(resourceOffset - resourceLimit, 0)).ToCursorString()
            : null;

        var nextCursor = resourcesTotalCount > resourceLimit + resourceOffset
            ? new GatewayApiSdk.Model.OffsetCursor(resourceLimit).ToCursorString()
            : null;

        return new GatewayApiSdk.Model.NonFungibleResourcesCollection(resourcesTotalCount, previousCursor, nextCursor,
            resources.Values.Cast<GatewayApiSdk.Model.NonFungibleResourcesCollectionItem>().ToList());
    }

    public static GatewayModel.StateEntityNonFungibleResourceVaultsPageResponse MapToStateEntityNonFungibleResourceVaultsPageResponse(
        List<EntityStateQuerier.NonFungibleResourceVaultsViewModel> input,
        Dictionary<long, List<EntityStateQuerier.NonFungibleIdWithOwnerDataViewModel>>? nonFungibleIds,
        GatewayModel.LedgerState ledgerState, int offset, int limit,
        string? entityGlobalAddress, string? resourceGlobalAddress)
    {
        var mapped = input.Select(x =>
            {
                List<EntityStateQuerier.NonFungibleIdWithOwnerDataViewModel>? items = null;

                var hasItems = nonFungibleIds?.TryGetValue(x.VaultEntityId, out items);
                return new GatewayModel.NonFungibleResourcesCollectionItemVaultAggregatedVaultItem(
                    totalCount: x.NonFungibleIdsCount,
                    vaultAddress: x.VaultAddress,
                    lastUpdatedAtStateVersion: x.LastUpdatedAtStateVersion,
                    items: hasItems == true && items != null ? items.Select(x => x.NonFungibleId).ToList() : null
                );
            }
        ).ToList();

        var vaultsTotalCount = input.FirstOrDefault()?.VaultTotalCount ?? 0;

        var previousCursor = offset > 0
            ? new GatewayModel.OffsetCursor(Math.Max(offset - limit, 0)).ToCursorString()
            : null;

        var nextCursor = vaultsTotalCount > offset + limit
            ? new GatewayModel.OffsetCursor(limit).ToCursorString()
            : null;

        return new GatewayModel.StateEntityNonFungibleResourceVaultsPageResponse(ledgerState, vaultsTotalCount, previousCursor, nextCursor, mapped, entityGlobalAddress,
            resourceGlobalAddress);
    }

    public static GatewayModel.CommittedTransactionInfo ToGatewayModel(this LedgerTransaction lt, ICollection<Entity> referencedEntities, GatewayModel.TransactionCommittedDetailsOptIns optIns)
    {
        string? payloadHashHex = null;
        string? intentHashHex = null;
        string? rawHex = null;
        string? messageHex = null;

        if (lt is UserLedgerTransaction ult)
        {
            payloadHashHex = ult.PayloadHash.ToHex();
            intentHashHex = ult.IntentHash.ToHex();
            rawHex = optIns.RawHex ? ult.RawPayload.ToHex() : null;
            messageHex = ult.Message?.ToHex();
        }

        var receipt = new GatewayModel.TransactionReceipt
        {
            ErrorMessage = lt.EngineReceipt.ErrorMessage,
            Status = ToGatewayModel(lt.EngineReceipt.Status),
            Output = new JRaw(lt.EngineReceipt.Output),
            FeeSummary = optIns.ReceiptFeeSummary ? new JRaw(lt.EngineReceipt.FeeSummary) : null,
            NextEpoch = lt.EngineReceipt.NextEpoch != null ? new JRaw(lt.EngineReceipt.NextEpoch) : null,
            StateUpdates = optIns.ReceiptStateChanges ? new JRaw(lt.EngineReceipt.StateUpdates) : null,
            Events = optIns.ReceiptEvents ? new JRaw(lt.EngineReceipt.Events) : null,
        };

        return new GatewayModel.CommittedTransactionInfo(
            stateVersion: lt.StateVersion,
            epoch: lt.Epoch,
            round: lt.RoundInEpoch,
            roundTimestamp: lt.RoundTimestamp.AsUtcIsoDateWithMillisString(),
            transactionStatus: lt.EngineReceipt.Status.ToGatewayModel(),
            payloadHashHex: payloadHashHex,
            intentHashHex: intentHashHex,
            feePaid: lt.FeePaid?.ToString(),
            confirmedAt: lt.RoundTimestamp,
            errorMessage: lt.EngineReceipt.ErrorMessage,
            rawHex: rawHex,
            receipt: receipt,
            referencedGlobalEntities: referencedEntities.Where(re => re.GlobalAddress != null).Select(re => re.GlobalAddress.ToString()).ToList(),
            messageHex: messageHex
        );
    }

    public static GatewayModel.TransactionStatus ToGatewayModel(this LedgerTransactionStatus status)
    {
        return status switch
        {
            LedgerTransactionStatus.Succeeded => GatewayModel.TransactionStatus.CommittedSuccess,
            LedgerTransactionStatus.Failed => GatewayModel.TransactionStatus.CommittedFailure,
            _ => throw new UnreachableException($"Didn't expect {status} value"),
        };
    }
}
