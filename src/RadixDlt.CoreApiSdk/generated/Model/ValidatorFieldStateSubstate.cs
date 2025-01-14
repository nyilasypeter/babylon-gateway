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

/*
 * Babylon Core API - RCnet V2
 *
 * This API is exposed by the Babylon Radix node to give clients access to the Radix Engine, Mempool and State in the node.  It is intended for use by node-runners on a private network, and is not intended to be exposed publicly. Very heavy load may impact the node's function.  This API exposes queries against the node's current state (see `/lts/state/` or `/state/`), and streams of transaction history (under `/lts/stream/` or `/stream`).  If you require queries against snapshots of historical ledger state, you may also wish to consider using the [Gateway API](https://docs-babylon.radixdlt.com/).  ## Integration and forward compatibility guarantees  This version of the Core API belongs to the first release candidate of the Radix Babylon network (\"RCnet-V1\").  Integrators (such as exchanges) are recommended to use the `/lts/` endpoints - they have been designed to be clear and simple for integrators wishing to create and monitor transactions involving fungible transfers to/from accounts.  All endpoints under `/lts/` are guaranteed to be forward compatible to Babylon mainnet launch (and beyond). We may add new fields, but existing fields will not be changed. Assuming the integrating code uses a permissive JSON parser which ignores unknown fields, any additions will not affect existing code.  We give no guarantees that other endpoints will not change before Babylon mainnet launch, although changes are expected to be minimal. 
 *
 * The version of the OpenAPI document: 0.4.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using JsonSubTypes;
using FileParameter = RadixDlt.CoreApiSdk.Client.FileParameter;
using OpenAPIDateConverter = RadixDlt.CoreApiSdk.Client.OpenAPIDateConverter;

namespace RadixDlt.CoreApiSdk.Model
{
    /// <summary>
    /// ValidatorFieldStateSubstate
    /// </summary>
    [DataContract(Name = "ValidatorFieldStateSubstate")]
    [JsonConverter(typeof(JsonSubtypes), "substate_type")]
    [JsonSubtypes.KnownSubType(typeof(AccessControllerFieldStateSubstate), "AccessControllerFieldState")]
    [JsonSubtypes.KnownSubType(typeof(AccessRulesModuleFieldAccessRulesSubstate), "AccessRulesModuleFieldAccessRules")]
    [JsonSubtypes.KnownSubType(typeof(AccountDepositRuleIndexEntrySubstate), "AccountDepositRuleIndexEntry")]
    [JsonSubtypes.KnownSubType(typeof(AccountFieldStateSubstate), "AccountFieldState")]
    [JsonSubtypes.KnownSubType(typeof(AccountVaultIndexEntrySubstate), "AccountVaultIndexEntry")]
    [JsonSubtypes.KnownSubType(typeof(ConsensusManagerFieldConfigSubstate), "ConsensusManagerFieldConfig")]
    [JsonSubtypes.KnownSubType(typeof(ConsensusManagerFieldCurrentProposalStatisticSubstate), "ConsensusManagerFieldCurrentProposalStatistic")]
    [JsonSubtypes.KnownSubType(typeof(ConsensusManagerCurrentTimeSubstate), "ConsensusManagerFieldCurrentTime")]
    [JsonSubtypes.KnownSubType(typeof(ConsensusManagerCurrentTimeRoundedToMinutesSubstate), "ConsensusManagerFieldCurrentTimeRoundedToMinutes")]
    [JsonSubtypes.KnownSubType(typeof(ConsensusManagerFieldCurrentValidatorSetSubstate), "ConsensusManagerFieldCurrentValidatorSet")]
    [JsonSubtypes.KnownSubType(typeof(ConsensusManagerFieldStateSubstate), "ConsensusManagerFieldState")]
    [JsonSubtypes.KnownSubType(typeof(ConsensusManagerRegisteredValidatorsByStakeIndexEntrySubstate), "ConsensusManagerRegisteredValidatorsByStakeIndexEntry")]
    [JsonSubtypes.KnownSubType(typeof(FungibleResourceManagerFieldDivisibilitySubstate), "FungibleResourceManagerFieldDivisibility")]
    [JsonSubtypes.KnownSubType(typeof(FungibleResourceManagerFieldTotalSupplySubstate), "FungibleResourceManagerFieldTotalSupply")]
    [JsonSubtypes.KnownSubType(typeof(FungibleVaultFieldBalanceSubstate), "FungibleVaultFieldBalance")]
    [JsonSubtypes.KnownSubType(typeof(GenericKeyValueStoreEntrySubstate), "GenericKeyValueStoreEntry")]
    [JsonSubtypes.KnownSubType(typeof(GenericScryptoComponentFieldStateSubstate), "GenericScryptoComponentFieldState")]
    [JsonSubtypes.KnownSubType(typeof(MetadataModuleEntrySubstate), "MetadataModuleEntry")]
    [JsonSubtypes.KnownSubType(typeof(NonFungibleResourceManagerDataEntrySubstate), "NonFungibleResourceManagerDataEntry")]
    [JsonSubtypes.KnownSubType(typeof(NonFungibleResourceManagerFieldIdTypeSubstate), "NonFungibleResourceManagerFieldIdType")]
    [JsonSubtypes.KnownSubType(typeof(NonFungibleResourceManagerFieldMutableFieldsSubstate), "NonFungibleResourceManagerFieldMutableFields")]
    [JsonSubtypes.KnownSubType(typeof(NonFungibleResourceManagerFieldTotalSupplySubstate), "NonFungibleResourceManagerFieldTotalSupply")]
    [JsonSubtypes.KnownSubType(typeof(NonFungibleVaultContentsIndexEntrySubstate), "NonFungibleVaultContentsIndexEntry")]
    [JsonSubtypes.KnownSubType(typeof(NonFungibleVaultFieldBalanceSubstate), "NonFungibleVaultFieldBalance")]
    [JsonSubtypes.KnownSubType(typeof(PackageFieldCodeSubstate), "PackageFieldCode")]
    [JsonSubtypes.KnownSubType(typeof(PackageFieldCodeTypeSubstate), "PackageFieldCodeType")]
    [JsonSubtypes.KnownSubType(typeof(PackageFieldFunctionAccessRulesSubstate), "PackageFieldFunctionAccessRules")]
    [JsonSubtypes.KnownSubType(typeof(PackageFieldInfoSubstate), "PackageFieldInfo")]
    [JsonSubtypes.KnownSubType(typeof(PackageFieldRoyaltySubstate), "PackageFieldRoyalty")]
    [JsonSubtypes.KnownSubType(typeof(RoyaltyModuleFieldAccumulatorSubstate), "RoyaltyModuleFieldAccumulator")]
    [JsonSubtypes.KnownSubType(typeof(RoyaltyModuleFieldConfigSubstate), "RoyaltyModuleFieldConfig")]
    [JsonSubtypes.KnownSubType(typeof(TypeInfoModuleFieldTypeInfoSubstate), "TypeInfoModuleFieldTypeInfo")]
    [JsonSubtypes.KnownSubType(typeof(ValidatorFieldStateSubstate), "ValidatorFieldState")]
    public partial class ValidatorFieldStateSubstate : Substate, IEquatable<ValidatorFieldStateSubstate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidatorFieldStateSubstate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ValidatorFieldStateSubstate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidatorFieldStateSubstate" /> class.
        /// </summary>
        /// <param name="sortedKey">sortedKey.</param>
        /// <param name="publicKey">publicKey (required).</param>
        /// <param name="isRegistered">isRegistered (required).</param>
        /// <param name="validatorFeeFactor">A string-encoded fixed-precision decimal to 18 decimal places. A decimal is formed of some signed integer &#x60;m&#x60; of attos (&#x60;10^(-18)&#x60;) units, where &#x60;-2^(256 - 1) &lt;&#x3D; m &lt; 2^(256 - 1)&#x60;.  (required).</param>
        /// <param name="validatorFeeChangeRequest">validatorFeeChangeRequest.</param>
        /// <param name="stakeUnitResourceAddress">The Bech32m-encoded human readable version of the resource address (required).</param>
        /// <param name="stakeXrdVault">stakeXrdVault (required).</param>
        /// <param name="unstakeClaimTokenResourceAddress">The Bech32m-encoded human readable version of the resource address (required).</param>
        /// <param name="pendingXrdWithdrawVault">pendingXrdWithdrawVault (required).</param>
        /// <param name="lockedOwnerStakeUnitVault">lockedOwnerStakeUnitVault (required).</param>
        /// <param name="pendingOwnerStakeUnitUnlockVault">pendingOwnerStakeUnitUnlockVault (required).</param>
        /// <param name="pendingOwnerStakeUnitWithdrawals">pendingOwnerStakeUnitWithdrawals (required).</param>
        /// <param name="alreadyUnlockedOwnerStakeUnitAmount">A string-encoded fixed-precision decimal to 18 decimal places. A decimal is formed of some signed integer &#x60;m&#x60; of attos (&#x60;10^(-18)&#x60;) units, where &#x60;-2^(256 - 1) &lt;&#x3D; m &lt; 2^(256 - 1)&#x60;.  (required).</param>
        /// <param name="substateType">substateType (required) (default to SubstateType.ValidatorFieldState).</param>
        public ValidatorFieldStateSubstate(SubstateKey sortedKey = default(SubstateKey), EcdsaSecp256k1PublicKey publicKey = default(EcdsaSecp256k1PublicKey), bool isRegistered = default(bool), string validatorFeeFactor = default(string), ValidatorFeeChangeRequest validatorFeeChangeRequest = default(ValidatorFeeChangeRequest), string stakeUnitResourceAddress = default(string), EntityReference stakeXrdVault = default(EntityReference), string unstakeClaimTokenResourceAddress = default(string), EntityReference pendingXrdWithdrawVault = default(EntityReference), EntityReference lockedOwnerStakeUnitVault = default(EntityReference), EntityReference pendingOwnerStakeUnitUnlockVault = default(EntityReference), List<PendingOwnerStakeWithdrawal> pendingOwnerStakeUnitWithdrawals = default(List<PendingOwnerStakeWithdrawal>), string alreadyUnlockedOwnerStakeUnitAmount = default(string), SubstateType substateType = SubstateType.ValidatorFieldState) : base(substateType)
        {
            // to ensure "publicKey" is required (not null)
            if (publicKey == null)
            {
                throw new ArgumentNullException("publicKey is a required property for ValidatorFieldStateSubstate and cannot be null");
            }
            this.PublicKey = publicKey;
            this.IsRegistered = isRegistered;
            // to ensure "validatorFeeFactor" is required (not null)
            if (validatorFeeFactor == null)
            {
                throw new ArgumentNullException("validatorFeeFactor is a required property for ValidatorFieldStateSubstate and cannot be null");
            }
            this.ValidatorFeeFactor = validatorFeeFactor;
            // to ensure "stakeUnitResourceAddress" is required (not null)
            if (stakeUnitResourceAddress == null)
            {
                throw new ArgumentNullException("stakeUnitResourceAddress is a required property for ValidatorFieldStateSubstate and cannot be null");
            }
            this.StakeUnitResourceAddress = stakeUnitResourceAddress;
            // to ensure "stakeXrdVault" is required (not null)
            if (stakeXrdVault == null)
            {
                throw new ArgumentNullException("stakeXrdVault is a required property for ValidatorFieldStateSubstate and cannot be null");
            }
            this.StakeXrdVault = stakeXrdVault;
            // to ensure "unstakeClaimTokenResourceAddress" is required (not null)
            if (unstakeClaimTokenResourceAddress == null)
            {
                throw new ArgumentNullException("unstakeClaimTokenResourceAddress is a required property for ValidatorFieldStateSubstate and cannot be null");
            }
            this.UnstakeClaimTokenResourceAddress = unstakeClaimTokenResourceAddress;
            // to ensure "pendingXrdWithdrawVault" is required (not null)
            if (pendingXrdWithdrawVault == null)
            {
                throw new ArgumentNullException("pendingXrdWithdrawVault is a required property for ValidatorFieldStateSubstate and cannot be null");
            }
            this.PendingXrdWithdrawVault = pendingXrdWithdrawVault;
            // to ensure "lockedOwnerStakeUnitVault" is required (not null)
            if (lockedOwnerStakeUnitVault == null)
            {
                throw new ArgumentNullException("lockedOwnerStakeUnitVault is a required property for ValidatorFieldStateSubstate and cannot be null");
            }
            this.LockedOwnerStakeUnitVault = lockedOwnerStakeUnitVault;
            // to ensure "pendingOwnerStakeUnitUnlockVault" is required (not null)
            if (pendingOwnerStakeUnitUnlockVault == null)
            {
                throw new ArgumentNullException("pendingOwnerStakeUnitUnlockVault is a required property for ValidatorFieldStateSubstate and cannot be null");
            }
            this.PendingOwnerStakeUnitUnlockVault = pendingOwnerStakeUnitUnlockVault;
            // to ensure "pendingOwnerStakeUnitWithdrawals" is required (not null)
            if (pendingOwnerStakeUnitWithdrawals == null)
            {
                throw new ArgumentNullException("pendingOwnerStakeUnitWithdrawals is a required property for ValidatorFieldStateSubstate and cannot be null");
            }
            this.PendingOwnerStakeUnitWithdrawals = pendingOwnerStakeUnitWithdrawals;
            // to ensure "alreadyUnlockedOwnerStakeUnitAmount" is required (not null)
            if (alreadyUnlockedOwnerStakeUnitAmount == null)
            {
                throw new ArgumentNullException("alreadyUnlockedOwnerStakeUnitAmount is a required property for ValidatorFieldStateSubstate and cannot be null");
            }
            this.AlreadyUnlockedOwnerStakeUnitAmount = alreadyUnlockedOwnerStakeUnitAmount;
            this.SortedKey = sortedKey;
            this.ValidatorFeeChangeRequest = validatorFeeChangeRequest;
        }

        /// <summary>
        /// Gets or Sets SortedKey
        /// </summary>
        [DataMember(Name = "sorted_key", EmitDefaultValue = true)]
        public SubstateKey SortedKey { get; set; }

        /// <summary>
        /// Gets or Sets PublicKey
        /// </summary>
        [DataMember(Name = "public_key", IsRequired = true, EmitDefaultValue = true)]
        public EcdsaSecp256k1PublicKey PublicKey { get; set; }

        /// <summary>
        /// Gets or Sets IsRegistered
        /// </summary>
        [DataMember(Name = "is_registered", IsRequired = true, EmitDefaultValue = true)]
        public bool IsRegistered { get; set; }

        /// <summary>
        /// A string-encoded fixed-precision decimal to 18 decimal places. A decimal is formed of some signed integer &#x60;m&#x60; of attos (&#x60;10^(-18)&#x60;) units, where &#x60;-2^(256 - 1) &lt;&#x3D; m &lt; 2^(256 - 1)&#x60;. 
        /// </summary>
        /// <value>A string-encoded fixed-precision decimal to 18 decimal places. A decimal is formed of some signed integer &#x60;m&#x60; of attos (&#x60;10^(-18)&#x60;) units, where &#x60;-2^(256 - 1) &lt;&#x3D; m &lt; 2^(256 - 1)&#x60;. </value>
        [DataMember(Name = "validator_fee_factor", IsRequired = true, EmitDefaultValue = true)]
        public string ValidatorFeeFactor { get; set; }

        /// <summary>
        /// Gets or Sets ValidatorFeeChangeRequest
        /// </summary>
        [DataMember(Name = "validator_fee_change_request", EmitDefaultValue = true)]
        public ValidatorFeeChangeRequest ValidatorFeeChangeRequest { get; set; }

        /// <summary>
        /// The Bech32m-encoded human readable version of the resource address
        /// </summary>
        /// <value>The Bech32m-encoded human readable version of the resource address</value>
        [DataMember(Name = "stake_unit_resource_address", IsRequired = true, EmitDefaultValue = true)]
        public string StakeUnitResourceAddress { get; set; }

        /// <summary>
        /// Gets or Sets StakeXrdVault
        /// </summary>
        [DataMember(Name = "stake_xrd_vault", IsRequired = true, EmitDefaultValue = true)]
        public EntityReference StakeXrdVault { get; set; }

        /// <summary>
        /// The Bech32m-encoded human readable version of the resource address
        /// </summary>
        /// <value>The Bech32m-encoded human readable version of the resource address</value>
        [DataMember(Name = "unstake_claim_token_resource_address", IsRequired = true, EmitDefaultValue = true)]
        public string UnstakeClaimTokenResourceAddress { get; set; }

        /// <summary>
        /// Gets or Sets PendingXrdWithdrawVault
        /// </summary>
        [DataMember(Name = "pending_xrd_withdraw_vault", IsRequired = true, EmitDefaultValue = true)]
        public EntityReference PendingXrdWithdrawVault { get; set; }

        /// <summary>
        /// Gets or Sets LockedOwnerStakeUnitVault
        /// </summary>
        [DataMember(Name = "locked_owner_stake_unit_vault", IsRequired = true, EmitDefaultValue = true)]
        public EntityReference LockedOwnerStakeUnitVault { get; set; }

        /// <summary>
        /// Gets or Sets PendingOwnerStakeUnitUnlockVault
        /// </summary>
        [DataMember(Name = "pending_owner_stake_unit_unlock_vault", IsRequired = true, EmitDefaultValue = true)]
        public EntityReference PendingOwnerStakeUnitUnlockVault { get; set; }

        /// <summary>
        /// Gets or Sets PendingOwnerStakeUnitWithdrawals
        /// </summary>
        [DataMember(Name = "pending_owner_stake_unit_withdrawals", IsRequired = true, EmitDefaultValue = true)]
        public List<PendingOwnerStakeWithdrawal> PendingOwnerStakeUnitWithdrawals { get; set; }

        /// <summary>
        /// A string-encoded fixed-precision decimal to 18 decimal places. A decimal is formed of some signed integer &#x60;m&#x60; of attos (&#x60;10^(-18)&#x60;) units, where &#x60;-2^(256 - 1) &lt;&#x3D; m &lt; 2^(256 - 1)&#x60;. 
        /// </summary>
        /// <value>A string-encoded fixed-precision decimal to 18 decimal places. A decimal is formed of some signed integer &#x60;m&#x60; of attos (&#x60;10^(-18)&#x60;) units, where &#x60;-2^(256 - 1) &lt;&#x3D; m &lt; 2^(256 - 1)&#x60;. </value>
        [DataMember(Name = "already_unlocked_owner_stake_unit_amount", IsRequired = true, EmitDefaultValue = true)]
        public string AlreadyUnlockedOwnerStakeUnitAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ValidatorFieldStateSubstate {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  SortedKey: ").Append(SortedKey).Append("\n");
            sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
            sb.Append("  IsRegistered: ").Append(IsRegistered).Append("\n");
            sb.Append("  ValidatorFeeFactor: ").Append(ValidatorFeeFactor).Append("\n");
            sb.Append("  ValidatorFeeChangeRequest: ").Append(ValidatorFeeChangeRequest).Append("\n");
            sb.Append("  StakeUnitResourceAddress: ").Append(StakeUnitResourceAddress).Append("\n");
            sb.Append("  StakeXrdVault: ").Append(StakeXrdVault).Append("\n");
            sb.Append("  UnstakeClaimTokenResourceAddress: ").Append(UnstakeClaimTokenResourceAddress).Append("\n");
            sb.Append("  PendingXrdWithdrawVault: ").Append(PendingXrdWithdrawVault).Append("\n");
            sb.Append("  LockedOwnerStakeUnitVault: ").Append(LockedOwnerStakeUnitVault).Append("\n");
            sb.Append("  PendingOwnerStakeUnitUnlockVault: ").Append(PendingOwnerStakeUnitUnlockVault).Append("\n");
            sb.Append("  PendingOwnerStakeUnitWithdrawals: ").Append(PendingOwnerStakeUnitWithdrawals).Append("\n");
            sb.Append("  AlreadyUnlockedOwnerStakeUnitAmount: ").Append(AlreadyUnlockedOwnerStakeUnitAmount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ValidatorFieldStateSubstate);
        }

        /// <summary>
        /// Returns true if ValidatorFieldStateSubstate instances are equal
        /// </summary>
        /// <param name="input">Instance of ValidatorFieldStateSubstate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidatorFieldStateSubstate input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.SortedKey == input.SortedKey ||
                    (this.SortedKey != null &&
                    this.SortedKey.Equals(input.SortedKey))
                ) && base.Equals(input) && 
                (
                    this.PublicKey == input.PublicKey ||
                    (this.PublicKey != null &&
                    this.PublicKey.Equals(input.PublicKey))
                ) && base.Equals(input) && 
                (
                    this.IsRegistered == input.IsRegistered ||
                    this.IsRegistered.Equals(input.IsRegistered)
                ) && base.Equals(input) && 
                (
                    this.ValidatorFeeFactor == input.ValidatorFeeFactor ||
                    (this.ValidatorFeeFactor != null &&
                    this.ValidatorFeeFactor.Equals(input.ValidatorFeeFactor))
                ) && base.Equals(input) && 
                (
                    this.ValidatorFeeChangeRequest == input.ValidatorFeeChangeRequest ||
                    (this.ValidatorFeeChangeRequest != null &&
                    this.ValidatorFeeChangeRequest.Equals(input.ValidatorFeeChangeRequest))
                ) && base.Equals(input) && 
                (
                    this.StakeUnitResourceAddress == input.StakeUnitResourceAddress ||
                    (this.StakeUnitResourceAddress != null &&
                    this.StakeUnitResourceAddress.Equals(input.StakeUnitResourceAddress))
                ) && base.Equals(input) && 
                (
                    this.StakeXrdVault == input.StakeXrdVault ||
                    (this.StakeXrdVault != null &&
                    this.StakeXrdVault.Equals(input.StakeXrdVault))
                ) && base.Equals(input) && 
                (
                    this.UnstakeClaimTokenResourceAddress == input.UnstakeClaimTokenResourceAddress ||
                    (this.UnstakeClaimTokenResourceAddress != null &&
                    this.UnstakeClaimTokenResourceAddress.Equals(input.UnstakeClaimTokenResourceAddress))
                ) && base.Equals(input) && 
                (
                    this.PendingXrdWithdrawVault == input.PendingXrdWithdrawVault ||
                    (this.PendingXrdWithdrawVault != null &&
                    this.PendingXrdWithdrawVault.Equals(input.PendingXrdWithdrawVault))
                ) && base.Equals(input) && 
                (
                    this.LockedOwnerStakeUnitVault == input.LockedOwnerStakeUnitVault ||
                    (this.LockedOwnerStakeUnitVault != null &&
                    this.LockedOwnerStakeUnitVault.Equals(input.LockedOwnerStakeUnitVault))
                ) && base.Equals(input) && 
                (
                    this.PendingOwnerStakeUnitUnlockVault == input.PendingOwnerStakeUnitUnlockVault ||
                    (this.PendingOwnerStakeUnitUnlockVault != null &&
                    this.PendingOwnerStakeUnitUnlockVault.Equals(input.PendingOwnerStakeUnitUnlockVault))
                ) && base.Equals(input) && 
                (
                    this.PendingOwnerStakeUnitWithdrawals == input.PendingOwnerStakeUnitWithdrawals ||
                    this.PendingOwnerStakeUnitWithdrawals != null &&
                    input.PendingOwnerStakeUnitWithdrawals != null &&
                    this.PendingOwnerStakeUnitWithdrawals.SequenceEqual(input.PendingOwnerStakeUnitWithdrawals)
                ) && base.Equals(input) && 
                (
                    this.AlreadyUnlockedOwnerStakeUnitAmount == input.AlreadyUnlockedOwnerStakeUnitAmount ||
                    (this.AlreadyUnlockedOwnerStakeUnitAmount != null &&
                    this.AlreadyUnlockedOwnerStakeUnitAmount.Equals(input.AlreadyUnlockedOwnerStakeUnitAmount))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.SortedKey != null)
                {
                    hashCode = (hashCode * 59) + this.SortedKey.GetHashCode();
                }
                if (this.PublicKey != null)
                {
                    hashCode = (hashCode * 59) + this.PublicKey.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsRegistered.GetHashCode();
                if (this.ValidatorFeeFactor != null)
                {
                    hashCode = (hashCode * 59) + this.ValidatorFeeFactor.GetHashCode();
                }
                if (this.ValidatorFeeChangeRequest != null)
                {
                    hashCode = (hashCode * 59) + this.ValidatorFeeChangeRequest.GetHashCode();
                }
                if (this.StakeUnitResourceAddress != null)
                {
                    hashCode = (hashCode * 59) + this.StakeUnitResourceAddress.GetHashCode();
                }
                if (this.StakeXrdVault != null)
                {
                    hashCode = (hashCode * 59) + this.StakeXrdVault.GetHashCode();
                }
                if (this.UnstakeClaimTokenResourceAddress != null)
                {
                    hashCode = (hashCode * 59) + this.UnstakeClaimTokenResourceAddress.GetHashCode();
                }
                if (this.PendingXrdWithdrawVault != null)
                {
                    hashCode = (hashCode * 59) + this.PendingXrdWithdrawVault.GetHashCode();
                }
                if (this.LockedOwnerStakeUnitVault != null)
                {
                    hashCode = (hashCode * 59) + this.LockedOwnerStakeUnitVault.GetHashCode();
                }
                if (this.PendingOwnerStakeUnitUnlockVault != null)
                {
                    hashCode = (hashCode * 59) + this.PendingOwnerStakeUnitUnlockVault.GetHashCode();
                }
                if (this.PendingOwnerStakeUnitWithdrawals != null)
                {
                    hashCode = (hashCode * 59) + this.PendingOwnerStakeUnitWithdrawals.GetHashCode();
                }
                if (this.AlreadyUnlockedOwnerStakeUnitAmount != null)
                {
                    hashCode = (hashCode * 59) + this.AlreadyUnlockedOwnerStakeUnitAmount.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
