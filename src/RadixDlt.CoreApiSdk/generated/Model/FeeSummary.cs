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
using FileParameter = RadixDlt.CoreApiSdk.Client.FileParameter;
using OpenAPIDateConverter = RadixDlt.CoreApiSdk.Client.OpenAPIDateConverter;

namespace RadixDlt.CoreApiSdk.Model
{
    /// <summary>
    /// Fees paid
    /// </summary>
    [DataContract(Name = "FeeSummary")]
    public partial class FeeSummary : IEquatable<FeeSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeeSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FeeSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeeSummary" /> class.
        /// </summary>
        /// <param name="costUnitPrice">The string-encoded decimal representing the XRD price of a single cost unit. A decimal is formed of some signed integer &#x60;m&#x60; of attos (&#x60;10^(-18)&#x60;) units, where &#x60;-2^(256 - 1) &lt;&#x3D; m &lt; 2^(256 - 1)&#x60;.  (required).</param>
        /// <param name="tipPercentage">An integer between &#x60;0&#x60; and &#x60;255&#x60;, giving the validator tip as a percentage amount. A value of &#x60;1&#x60; corresponds to 1% of the fee. (required).</param>
        /// <param name="costUnitLimit">An integer between &#x60;0&#x60; and &#x60;2^32 - 1&#x60;, representing the maximum amount of cost units available for the transaction execution. (required).</param>
        /// <param name="costUnitsConsumed">An integer between &#x60;0&#x60; and &#x60;2^32 - 1&#x60;, representing the amount of cost units consumed by the transaction execution. (required).</param>
        /// <param name="costUnitExecutionBreakdown">A breakdown of where the execution cost went.  (required).</param>
        /// <param name="xrdTotalExecutionCost">The string-encoded decimal representing the total amount of XRD burned in the transaction as part of execution costs. A decimal is formed of some signed integer &#x60;m&#x60; of attos (&#x60;10^(-18)&#x60;) units, where &#x60;-2^(256 - 1) &lt;&#x3D; m &lt; 2^(256 - 1)&#x60;.  (required).</param>
        /// <param name="xrdTotalRoyaltyCost">The string-encoded decimal representing the total amount of XRD paid in royalties as part of the transaction. A decimal is formed of some signed integer &#x60;m&#x60; of attos (&#x60;10^(-18)&#x60;) units, where &#x60;-2^(256 - 1) &lt;&#x3D; m &lt; 2^(256 - 1)&#x60;.  (required).</param>
        /// <param name="xrdTotalTipped">The string-encoded decimal representing the total amount of XRD tipped to validators in the transaction. A decimal is formed of some signed integer &#x60;m&#x60; of attos (&#x60;10^(-18)&#x60;) units, where &#x60;-2^(256 - 1) &lt;&#x3D; m &lt; 2^(256 - 1)&#x60;.  (required).</param>
        /// <param name="xrdVaultPayments">A breakdown of which vaults were used to pay the fee.  (required).</param>
        /// <param name="xrdRoyaltyReceivers">A breakdown of where the royalties were paid to.  (required).</param>
        public FeeSummary(string costUnitPrice = default(string), int tipPercentage = default(int), long costUnitLimit = default(long), long costUnitsConsumed = default(long), Dictionary<string, long> costUnitExecutionBreakdown = default(Dictionary<string, long>), string xrdTotalExecutionCost = default(string), string xrdTotalRoyaltyCost = default(string), string xrdTotalTipped = default(string), List<VaultPayment> xrdVaultPayments = default(List<VaultPayment>), List<RoyaltyPayment> xrdRoyaltyReceivers = default(List<RoyaltyPayment>))
        {
            // to ensure "costUnitPrice" is required (not null)
            if (costUnitPrice == null)
            {
                throw new ArgumentNullException("costUnitPrice is a required property for FeeSummary and cannot be null");
            }
            this.CostUnitPrice = costUnitPrice;
            this.TipPercentage = tipPercentage;
            this.CostUnitLimit = costUnitLimit;
            this.CostUnitsConsumed = costUnitsConsumed;
            // to ensure "costUnitExecutionBreakdown" is required (not null)
            if (costUnitExecutionBreakdown == null)
            {
                throw new ArgumentNullException("costUnitExecutionBreakdown is a required property for FeeSummary and cannot be null");
            }
            this.CostUnitExecutionBreakdown = costUnitExecutionBreakdown;
            // to ensure "xrdTotalExecutionCost" is required (not null)
            if (xrdTotalExecutionCost == null)
            {
                throw new ArgumentNullException("xrdTotalExecutionCost is a required property for FeeSummary and cannot be null");
            }
            this.XrdTotalExecutionCost = xrdTotalExecutionCost;
            // to ensure "xrdTotalRoyaltyCost" is required (not null)
            if (xrdTotalRoyaltyCost == null)
            {
                throw new ArgumentNullException("xrdTotalRoyaltyCost is a required property for FeeSummary and cannot be null");
            }
            this.XrdTotalRoyaltyCost = xrdTotalRoyaltyCost;
            // to ensure "xrdTotalTipped" is required (not null)
            if (xrdTotalTipped == null)
            {
                throw new ArgumentNullException("xrdTotalTipped is a required property for FeeSummary and cannot be null");
            }
            this.XrdTotalTipped = xrdTotalTipped;
            // to ensure "xrdVaultPayments" is required (not null)
            if (xrdVaultPayments == null)
            {
                throw new ArgumentNullException("xrdVaultPayments is a required property for FeeSummary and cannot be null");
            }
            this.XrdVaultPayments = xrdVaultPayments;
            // to ensure "xrdRoyaltyReceivers" is required (not null)
            if (xrdRoyaltyReceivers == null)
            {
                throw new ArgumentNullException("xrdRoyaltyReceivers is a required property for FeeSummary and cannot be null");
            }
            this.XrdRoyaltyReceivers = xrdRoyaltyReceivers;
        }

        /// <summary>
        /// The string-encoded decimal representing the XRD price of a single cost unit. A decimal is formed of some signed integer &#x60;m&#x60; of attos (&#x60;10^(-18)&#x60;) units, where &#x60;-2^(256 - 1) &lt;&#x3D; m &lt; 2^(256 - 1)&#x60;. 
        /// </summary>
        /// <value>The string-encoded decimal representing the XRD price of a single cost unit. A decimal is formed of some signed integer &#x60;m&#x60; of attos (&#x60;10^(-18)&#x60;) units, where &#x60;-2^(256 - 1) &lt;&#x3D; m &lt; 2^(256 - 1)&#x60;. </value>
        [DataMember(Name = "cost_unit_price", IsRequired = true, EmitDefaultValue = true)]
        public string CostUnitPrice { get; set; }

        /// <summary>
        /// An integer between &#x60;0&#x60; and &#x60;255&#x60;, giving the validator tip as a percentage amount. A value of &#x60;1&#x60; corresponds to 1% of the fee.
        /// </summary>
        /// <value>An integer between &#x60;0&#x60; and &#x60;255&#x60;, giving the validator tip as a percentage amount. A value of &#x60;1&#x60; corresponds to 1% of the fee.</value>
        [DataMember(Name = "tip_percentage", IsRequired = true, EmitDefaultValue = true)]
        public int TipPercentage { get; set; }

        /// <summary>
        /// An integer between &#x60;0&#x60; and &#x60;2^32 - 1&#x60;, representing the maximum amount of cost units available for the transaction execution.
        /// </summary>
        /// <value>An integer between &#x60;0&#x60; and &#x60;2^32 - 1&#x60;, representing the maximum amount of cost units available for the transaction execution.</value>
        [DataMember(Name = "cost_unit_limit", IsRequired = true, EmitDefaultValue = true)]
        public long CostUnitLimit { get; set; }

        /// <summary>
        /// An integer between &#x60;0&#x60; and &#x60;2^32 - 1&#x60;, representing the amount of cost units consumed by the transaction execution.
        /// </summary>
        /// <value>An integer between &#x60;0&#x60; and &#x60;2^32 - 1&#x60;, representing the amount of cost units consumed by the transaction execution.</value>
        [DataMember(Name = "cost_units_consumed", IsRequired = true, EmitDefaultValue = true)]
        public long CostUnitsConsumed { get; set; }

        /// <summary>
        /// A breakdown of where the execution cost went. 
        /// </summary>
        /// <value>A breakdown of where the execution cost went. </value>
        [DataMember(Name = "cost_unit_execution_breakdown", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, long> CostUnitExecutionBreakdown { get; set; }

        /// <summary>
        /// The string-encoded decimal representing the total amount of XRD burned in the transaction as part of execution costs. A decimal is formed of some signed integer &#x60;m&#x60; of attos (&#x60;10^(-18)&#x60;) units, where &#x60;-2^(256 - 1) &lt;&#x3D; m &lt; 2^(256 - 1)&#x60;. 
        /// </summary>
        /// <value>The string-encoded decimal representing the total amount of XRD burned in the transaction as part of execution costs. A decimal is formed of some signed integer &#x60;m&#x60; of attos (&#x60;10^(-18)&#x60;) units, where &#x60;-2^(256 - 1) &lt;&#x3D; m &lt; 2^(256 - 1)&#x60;. </value>
        [DataMember(Name = "xrd_total_execution_cost", IsRequired = true, EmitDefaultValue = true)]
        public string XrdTotalExecutionCost { get; set; }

        /// <summary>
        /// The string-encoded decimal representing the total amount of XRD paid in royalties as part of the transaction. A decimal is formed of some signed integer &#x60;m&#x60; of attos (&#x60;10^(-18)&#x60;) units, where &#x60;-2^(256 - 1) &lt;&#x3D; m &lt; 2^(256 - 1)&#x60;. 
        /// </summary>
        /// <value>The string-encoded decimal representing the total amount of XRD paid in royalties as part of the transaction. A decimal is formed of some signed integer &#x60;m&#x60; of attos (&#x60;10^(-18)&#x60;) units, where &#x60;-2^(256 - 1) &lt;&#x3D; m &lt; 2^(256 - 1)&#x60;. </value>
        [DataMember(Name = "xrd_total_royalty_cost", IsRequired = true, EmitDefaultValue = true)]
        public string XrdTotalRoyaltyCost { get; set; }

        /// <summary>
        /// The string-encoded decimal representing the total amount of XRD tipped to validators in the transaction. A decimal is formed of some signed integer &#x60;m&#x60; of attos (&#x60;10^(-18)&#x60;) units, where &#x60;-2^(256 - 1) &lt;&#x3D; m &lt; 2^(256 - 1)&#x60;. 
        /// </summary>
        /// <value>The string-encoded decimal representing the total amount of XRD tipped to validators in the transaction. A decimal is formed of some signed integer &#x60;m&#x60; of attos (&#x60;10^(-18)&#x60;) units, where &#x60;-2^(256 - 1) &lt;&#x3D; m &lt; 2^(256 - 1)&#x60;. </value>
        [DataMember(Name = "xrd_total_tipped", IsRequired = true, EmitDefaultValue = true)]
        public string XrdTotalTipped { get; set; }

        /// <summary>
        /// A breakdown of which vaults were used to pay the fee. 
        /// </summary>
        /// <value>A breakdown of which vaults were used to pay the fee. </value>
        [DataMember(Name = "xrd_vault_payments", IsRequired = true, EmitDefaultValue = true)]
        public List<VaultPayment> XrdVaultPayments { get; set; }

        /// <summary>
        /// A breakdown of where the royalties were paid to. 
        /// </summary>
        /// <value>A breakdown of where the royalties were paid to. </value>
        [DataMember(Name = "xrd_royalty_receivers", IsRequired = true, EmitDefaultValue = true)]
        public List<RoyaltyPayment> XrdRoyaltyReceivers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FeeSummary {\n");
            sb.Append("  CostUnitPrice: ").Append(CostUnitPrice).Append("\n");
            sb.Append("  TipPercentage: ").Append(TipPercentage).Append("\n");
            sb.Append("  CostUnitLimit: ").Append(CostUnitLimit).Append("\n");
            sb.Append("  CostUnitsConsumed: ").Append(CostUnitsConsumed).Append("\n");
            sb.Append("  CostUnitExecutionBreakdown: ").Append(CostUnitExecutionBreakdown).Append("\n");
            sb.Append("  XrdTotalExecutionCost: ").Append(XrdTotalExecutionCost).Append("\n");
            sb.Append("  XrdTotalRoyaltyCost: ").Append(XrdTotalRoyaltyCost).Append("\n");
            sb.Append("  XrdTotalTipped: ").Append(XrdTotalTipped).Append("\n");
            sb.Append("  XrdVaultPayments: ").Append(XrdVaultPayments).Append("\n");
            sb.Append("  XrdRoyaltyReceivers: ").Append(XrdRoyaltyReceivers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as FeeSummary);
        }

        /// <summary>
        /// Returns true if FeeSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of FeeSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeeSummary input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CostUnitPrice == input.CostUnitPrice ||
                    (this.CostUnitPrice != null &&
                    this.CostUnitPrice.Equals(input.CostUnitPrice))
                ) && 
                (
                    this.TipPercentage == input.TipPercentage ||
                    this.TipPercentage.Equals(input.TipPercentage)
                ) && 
                (
                    this.CostUnitLimit == input.CostUnitLimit ||
                    this.CostUnitLimit.Equals(input.CostUnitLimit)
                ) && 
                (
                    this.CostUnitsConsumed == input.CostUnitsConsumed ||
                    this.CostUnitsConsumed.Equals(input.CostUnitsConsumed)
                ) && 
                (
                    this.CostUnitExecutionBreakdown == input.CostUnitExecutionBreakdown ||
                    this.CostUnitExecutionBreakdown != null &&
                    input.CostUnitExecutionBreakdown != null &&
                    this.CostUnitExecutionBreakdown.SequenceEqual(input.CostUnitExecutionBreakdown)
                ) && 
                (
                    this.XrdTotalExecutionCost == input.XrdTotalExecutionCost ||
                    (this.XrdTotalExecutionCost != null &&
                    this.XrdTotalExecutionCost.Equals(input.XrdTotalExecutionCost))
                ) && 
                (
                    this.XrdTotalRoyaltyCost == input.XrdTotalRoyaltyCost ||
                    (this.XrdTotalRoyaltyCost != null &&
                    this.XrdTotalRoyaltyCost.Equals(input.XrdTotalRoyaltyCost))
                ) && 
                (
                    this.XrdTotalTipped == input.XrdTotalTipped ||
                    (this.XrdTotalTipped != null &&
                    this.XrdTotalTipped.Equals(input.XrdTotalTipped))
                ) && 
                (
                    this.XrdVaultPayments == input.XrdVaultPayments ||
                    this.XrdVaultPayments != null &&
                    input.XrdVaultPayments != null &&
                    this.XrdVaultPayments.SequenceEqual(input.XrdVaultPayments)
                ) && 
                (
                    this.XrdRoyaltyReceivers == input.XrdRoyaltyReceivers ||
                    this.XrdRoyaltyReceivers != null &&
                    input.XrdRoyaltyReceivers != null &&
                    this.XrdRoyaltyReceivers.SequenceEqual(input.XrdRoyaltyReceivers)
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
                int hashCode = 41;
                if (this.CostUnitPrice != null)
                {
                    hashCode = (hashCode * 59) + this.CostUnitPrice.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TipPercentage.GetHashCode();
                hashCode = (hashCode * 59) + this.CostUnitLimit.GetHashCode();
                hashCode = (hashCode * 59) + this.CostUnitsConsumed.GetHashCode();
                if (this.CostUnitExecutionBreakdown != null)
                {
                    hashCode = (hashCode * 59) + this.CostUnitExecutionBreakdown.GetHashCode();
                }
                if (this.XrdTotalExecutionCost != null)
                {
                    hashCode = (hashCode * 59) + this.XrdTotalExecutionCost.GetHashCode();
                }
                if (this.XrdTotalRoyaltyCost != null)
                {
                    hashCode = (hashCode * 59) + this.XrdTotalRoyaltyCost.GetHashCode();
                }
                if (this.XrdTotalTipped != null)
                {
                    hashCode = (hashCode * 59) + this.XrdTotalTipped.GetHashCode();
                }
                if (this.XrdVaultPayments != null)
                {
                    hashCode = (hashCode * 59) + this.XrdVaultPayments.GetHashCode();
                }
                if (this.XrdRoyaltyReceivers != null)
                {
                    hashCode = (hashCode * 59) + this.XrdRoyaltyReceivers.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
