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
using RadixDlt.NetworkGateway.Abstractions;
using RadixDlt.NetworkGateway.Abstractions.Model;
using RadixDlt.NetworkGateway.Abstractions.Numerics;
using RadixDlt.NetworkGateway.PostgresIntegration.Interceptors;
using RadixDlt.NetworkGateway.PostgresIntegration.Models;
using RadixDlt.NetworkGateway.PostgresIntegration.ValueConverters;

namespace RadixDlt.NetworkGateway.PostgresIntegration;

/// <summary>
/// Common DB Context for the Network Gateway database.
///
/// After updating this file, run ./generation/generate-migration.sh.
/// </summary>
internal abstract class CommonDbContext : DbContext
{
    private const string DiscriminatorColumnName = "discriminator";

    public DbSet<NetworkConfiguration> NetworkConfiguration => Set<NetworkConfiguration>();

    public DbSet<LedgerTransaction> LedgerTransactions => Set<LedgerTransaction>();

    public DbSet<LedgerTransactionMarker> LedgerTransactionMarkers => Set<LedgerTransactionMarker>();

    public DbSet<PendingTransaction> PendingTransactions => Set<PendingTransaction>();

    public DbSet<Entity> Entities => Set<Entity>();

    public DbSet<EntityMetadataHistory> EntityMetadataHistory => Set<EntityMetadataHistory>();

    public DbSet<EntityMetadataAggregateHistory> EntityMetadataAggregateHistory => Set<EntityMetadataAggregateHistory>();

    public DbSet<EntityResourceAggregateHistory> EntityResourceAggregateHistory => Set<EntityResourceAggregateHistory>();

    public DbSet<EntityResourceVaultAggregateHistory> EntityResourceVaultAggregateHistory => Set<EntityResourceVaultAggregateHistory>();

    public DbSet<EntityResourceAggregatedVaultsHistory> EntityResourceAggregatedVaultsHistory => Set<EntityResourceAggregatedVaultsHistory>();

    public DbSet<AccountDefaultDepositRuleHistory> AccountDefaultDepositRuleHistory => Set<AccountDefaultDepositRuleHistory>();

    public DbSet<AccountResourceDepositRuleHistory> AccountDepositRuleHistory => Set<AccountResourceDepositRuleHistory>();

    public DbSet<EntityVaultHistory> EntityVaultHistory => Set<EntityVaultHistory>();

    public DbSet<ResourceEntitySupplyHistory> ResourceEntitySupplyHistory => Set<ResourceEntitySupplyHistory>();

    public DbSet<NonFungibleIdData> NonFungibleIdData => Set<NonFungibleIdData>();

    public DbSet<NonFungibleIdDataHistory> NonFungibleIdDataHistory => Set<NonFungibleIdDataHistory>();

    public DbSet<NonFungibleIdStoreHistory> NonFungibleIdStoreHistory => Set<NonFungibleIdStoreHistory>();

    public DbSet<EntityStateHistory> EntityStateHistory => Set<EntityStateHistory>();

    public DbSet<ValidatorPublicKeyHistory> ValidatorKeyHistory => Set<ValidatorPublicKeyHistory>();

    public DbSet<ValidatorActiveSetHistory> ValidatorActiveSetHistory => Set<ValidatorActiveSetHistory>();

    public DbSet<EntityAccessRulesChainHistory> EntityAccessRulesChainHistory => Set<EntityAccessRulesChainHistory>();

    public DbSet<ComponentSchema> ComponentSchema => Set<ComponentSchema>();

    public CommonDbContext(DbContextOptions options)
        : base(options)
    {
    }

    // Note that PostGres doesn't have clustered indexes: all indexes are non-clustered, and operate against the heap
    // So secondary indexes might benefit from the inclusion of columns for faster lookups
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresEnum<AccountDefaultDepositRule>();
        modelBuilder.HasPostgresEnum<AccountResourceDepositRule>();
        modelBuilder.HasPostgresEnum<EntityType>();
        modelBuilder.HasPostgresEnum<LedgerTransactionStatus>();
        modelBuilder.HasPostgresEnum<LedgerTransactionType>();
        modelBuilder.HasPostgresEnum<LedgerTransactionMarkerType>();
        modelBuilder.HasPostgresEnum<LedgerTransactionMarkerEventType>();
        modelBuilder.HasPostgresEnum<LedgerTransactionMarkerOperationType>();
        modelBuilder.HasPostgresEnum<LedgerTransactionMarkerOriginType>();
        modelBuilder.HasPostgresEnum<NonFungibleIdType>();
        modelBuilder.HasPostgresEnum<PendingTransactionStatus>();
        modelBuilder.HasPostgresEnum<PublicKeyType>();
        modelBuilder.HasPostgresEnum<ResourceType>();

        HookupTransactions(modelBuilder);
        HookupPendingTransactions(modelBuilder);
        HookupEntities(modelBuilder);
        HookupHistory(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.AddInterceptors(new ForceDistinctInterceptor());
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<TokenAmount>()
            .HaveConversion<TokenAmountToBigIntegerConverter>()
            .HaveColumnType("numeric")
            .HavePrecision(1000, 0);

        configurationBuilder.Properties<RadixAddress>()
            .HaveConversion<RadixAddressToByteArrayConverter>();

        configurationBuilder.Properties<EntityAddress>()
            .HaveConversion<EntityAddressToStringConverter>();
    }

    private static void HookupTransactions(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LedgerTransaction>()
            .HasDiscriminator<LedgerTransactionType>(DiscriminatorColumnName)
            .HasValue<UserLedgerTransaction>(LedgerTransactionType.User)
            .HasValue<RoundUpdateLedgerTransaction>(LedgerTransactionType.RoundUpdate)
            .HasValue<GenesisLedgerTransaction>(LedgerTransactionType.Genesis);

        modelBuilder.Entity<UserLedgerTransaction>()
            .HasIndex(lt => lt.IntentHash)
            .HasMethod("hash")
            .HasFilter("intent_hash IS NOT NULL");

        // Because StateVersion, RoundTimestamp and (Epoch, EndOfEpochRound) are correlated with the linear
        // history of the table,  we could consider defining them as a BRIN index, using .HasMethod("brin")
        // This is a lighter (lossy) index where the indexed data is correlated with the linear order of the table
        // See also https://www.postgresql.org/docs/current/indexes-types.html

        // This index lets you quickly translate Time => StateVersion
        modelBuilder.Entity<LedgerTransaction>()
            .HasIndex(lt => lt.RoundTimestamp);

        // This index lets you quickly translate Epoch/Round => StateVersion
        modelBuilder.Entity<LedgerTransaction>()
            .HasIndex(lt => new { lt.Epoch, lt.RoundInEpoch })
            .IsUnique()
            .HasFilter("index_in_round = 0");

        modelBuilder.Entity<LedgerTransactionMarker>()
            .HasDiscriminator<LedgerTransactionMarkerType>(DiscriminatorColumnName)
            .HasValue<EventLedgerTransactionMarker>(LedgerTransactionMarkerType.Event)
            .HasValue<OriginLedgerTransactionMarker>(LedgerTransactionMarkerType.Origin)
            .HasValue<ManifestAddressLedgerTransactionMarker>(LedgerTransactionMarkerType.ManifestAddress)
            .HasValue<AffectedGlobalEntityTransactionMarker>(LedgerTransactionMarkerType.AffectedGlobalEntity);

        modelBuilder.Entity<EventLedgerTransactionMarker>()
            .HasIndex(e => new { e.EventType, e.EntityId, e.StateVersion })
            .HasFilter("discriminator = 'event'");

        modelBuilder.Entity<OriginLedgerTransactionMarker>()
            .HasIndex(e => new { e.OriginType, e.StateVersion })
            .HasFilter("discriminator = 'origin'");

        modelBuilder.Entity<ManifestAddressLedgerTransactionMarker>()
            .HasIndex(e => new { e.OperationType, e.EntityId, e.StateVersion })
            .HasFilter("discriminator = 'manifest_address'");

        modelBuilder.Entity<AffectedGlobalEntityTransactionMarker>()
            .HasIndex(e => new { e.EntityId, e.StateVersion })
            .HasFilter("discriminator = 'affected_global_entity'");
    }

    private static void HookupPendingTransactions(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PendingTransaction>()
            .HasIndex(pt => pt.Status);

        modelBuilder.Entity<PendingTransaction>()
            .HasIndex(pt => pt.PayloadHash)
            .IsUnique();

        modelBuilder.Entity<PendingTransaction>()
            .HasIndex(pt => pt.IntentHash);
    }

    private static void HookupEntities(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Entity>()
            .HasIndex(e => e.Address);

        modelBuilder.Entity<Entity>()
            .HasDiscriminator<EntityType>(DiscriminatorColumnName)
            .HasValue<GlobalConsensusManager>(EntityType.GlobalConsensusManager)
            .HasValue<GlobalFungibleResourceEntity>(EntityType.GlobalFungibleResource)
            .HasValue<GlobalNonFungibleResourceEntity>(EntityType.GlobalNonFungibleResource)
            .HasValue<GlobalGenericComponentEntity>(EntityType.GlobalGenericComponent)
            .HasValue<InternalGenericComponentEntity>(EntityType.InternalGenericComponent)
            .HasValue<InternalAccountEntity>(EntityType.InternalAccountComponent)
            .HasValue<GlobalAccountEntity>(EntityType.GlobalAccountComponent)
            .HasValue<GlobalPackageEntity>(EntityType.GlobalPackage)
            .HasValue<InternalKeyValueStoreEntity>(EntityType.InternalKeyValueStore)
            .HasValue<InternalFungibleVaultEntity>(EntityType.InternalFungibleVault)
            .HasValue<InternalNonFungibleVaultEntity>(EntityType.InternalNonFungibleVault)
            .HasValue<GlobalValidatorEntity>(EntityType.GlobalValidator)
            .HasValue<GlobalAccessControllerEntity>(EntityType.GlobalAccessController)
            .HasValue<GlobalIdentityEntity>(EntityType.GlobalIdentity);
    }

    private static void HookupHistory(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccountDefaultDepositRuleHistory>()
            .HasIndex(e => new { e.AccountEntityId, e.FromStateVersion });

        modelBuilder.Entity<AccountResourceDepositRuleHistory>()
            .HasIndex(e => new { e.AccountEntityId, e.ResourceEntityId, e.FromStateVersion });

        modelBuilder.Entity<EntityMetadataHistory>()
            .HasIndex(e => new { e.EntityId, e.Key, e.FromStateVersion });

        modelBuilder.Entity<EntityMetadataAggregateHistory>()
            .HasIndex(e => new { e.EntityId, e.FromStateVersion });

        modelBuilder.Entity<EntityResourceAggregateHistory>()
            .HasIndex(e => new { e.EntityId, e.FromStateVersion });

        modelBuilder.Entity<EntityResourceAggregatedVaultsHistory>()
            .HasDiscriminator<ResourceType>(DiscriminatorColumnName)
            .HasValue<EntityFungibleResourceAggregatedVaultsHistory>(ResourceType.Fungible)
            .HasValue<EntityNonFungibleResourceAggregatedVaultsHistory>(ResourceType.NonFungible);

        modelBuilder.Entity<EntityResourceAggregatedVaultsHistory>()
            .HasIndex(e => new { e.EntityId, e.ResourceEntityId, e.FromStateVersion });

        modelBuilder.Entity<EntityResourceVaultAggregateHistory>()
            .HasIndex(e => new { e.EntityId, e.ResourceEntityId, e.FromStateVersion });

        modelBuilder.Entity<EntityVaultHistory>()
            .HasDiscriminator<ResourceType>(DiscriminatorColumnName)
            .HasValue<EntityFungibleVaultHistory>(ResourceType.Fungible)
            .HasValue<EntityNonFungibleVaultHistory>(ResourceType.NonFungible);

        modelBuilder.Entity<EntityVaultHistory>()
            .HasIndex(e => new { e.OwnerEntityId, e.VaultEntityId, e.FromStateVersion });

        modelBuilder.Entity<EntityVaultHistory>()
            .HasIndex(e => new { e.GlobalEntityId, e.VaultEntityId, e.FromStateVersion });

        modelBuilder.Entity<ResourceEntitySupplyHistory>()
            .HasIndex(e => new { e.ResourceEntityId, e.FromStateVersion });

        modelBuilder.Entity<NonFungibleIdData>()
            .HasIndex(e => new { e.NonFungibleResourceEntityId, e.FromStateVersion });

        modelBuilder.Entity<NonFungibleIdData>()
            .HasIndex(e => new { e.NonFungibleResourceEntityId, e.NonFungibleId, e.FromStateVersion })
            .IsUnique();

        modelBuilder.Entity<NonFungibleIdDataHistory>()
            .HasIndex(e => new { e.NonFungibleIdDataId, e.FromStateVersion });

        modelBuilder.Entity<NonFungibleIdStoreHistory>()
            .HasIndex(e => new { e.NonFungibleResourceEntityId, e.FromStateVersion });

        modelBuilder.Entity<EntityStateHistory>()
            .HasIndex(e => new { e.EntityId, e.FromStateVersion });

        modelBuilder.Entity<ValidatorPublicKeyHistory>()
            .HasIndex(e => new { e.ValidatorEntityId, e.FromStateVersion });

        modelBuilder.Entity<ValidatorPublicKeyHistory>()
            .HasIndex(e => new { e.ValidatorEntityId, e.KeyType, e.Key });

        modelBuilder.Entity<ValidatorActiveSetHistory>()
            .HasIndex(e => e.FromStateVersion);

        modelBuilder.Entity<ValidatorActiveSetHistory>()
            .HasIndex(e => e.Epoch);

        modelBuilder.Entity<EntityAccessRulesChainHistory>()
            .HasIndex(e => new { e.EntityId, e.ChildBlueprintName, e.FromStateVersion });
    }
}
