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
    /// LtsTransactionStatusResponse
    /// </summary>
    [DataContract(Name = "LtsTransactionStatusResponse")]
    public partial class LtsTransactionStatusResponse : IEquatable<LtsTransactionStatusResponse>
    {

        /// <summary>
        /// Gets or Sets IntentStatus
        /// </summary>
        [DataMember(Name = "intent_status", IsRequired = true, EmitDefaultValue = true)]
        public LtsTransactionIntentStatus IntentStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LtsTransactionStatusResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LtsTransactionStatusResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LtsTransactionStatusResponse" /> class.
        /// </summary>
        /// <param name="intentStatus">intentStatus (required).</param>
        /// <param name="statusDescription">An explanation as to why the intent status is resolved as it is.  (required).</param>
        /// <param name="committedStateVersion">An integer between &#x60;1&#x60; and &#x60;10^13&#x60;, giving the resultant state version when the transaction was committed. This is only present if the intent was committed (as a Success or Failure). This can be considered to be the auto-incrementing primary key for a committed tranasction, and can be used in (eg) to look up details on the transaction&#39;s outcome from the &#x60;/lts/stream/transaction-outcomes&#x60; endpoint. .</param>
        /// <param name="invalidFromEpoch">An integer between &#x60;0&#x60; and &#x60;10^10&#x60;, marking the epoch from which the transaction will no longer be valid, and be permanently rejected. Only present if the intent status is InMempool or Unknown and we know about a payload. .</param>
        /// <param name="knownPayloads">knownPayloads (required).</param>
        public LtsTransactionStatusResponse(LtsTransactionIntentStatus intentStatus = default(LtsTransactionIntentStatus), string statusDescription = default(string), long committedStateVersion = default(long), long invalidFromEpoch = default(long), List<LtsTransactionPayloadDetails> knownPayloads = default(List<LtsTransactionPayloadDetails>))
        {
            this.IntentStatus = intentStatus;
            // to ensure "statusDescription" is required (not null)
            if (statusDescription == null)
            {
                throw new ArgumentNullException("statusDescription is a required property for LtsTransactionStatusResponse and cannot be null");
            }
            this.StatusDescription = statusDescription;
            // to ensure "knownPayloads" is required (not null)
            if (knownPayloads == null)
            {
                throw new ArgumentNullException("knownPayloads is a required property for LtsTransactionStatusResponse and cannot be null");
            }
            this.KnownPayloads = knownPayloads;
            this.CommittedStateVersion = committedStateVersion;
            this.InvalidFromEpoch = invalidFromEpoch;
        }

        /// <summary>
        /// An explanation as to why the intent status is resolved as it is. 
        /// </summary>
        /// <value>An explanation as to why the intent status is resolved as it is. </value>
        [DataMember(Name = "status_description", IsRequired = true, EmitDefaultValue = true)]
        public string StatusDescription { get; set; }

        /// <summary>
        /// An integer between &#x60;1&#x60; and &#x60;10^13&#x60;, giving the resultant state version when the transaction was committed. This is only present if the intent was committed (as a Success or Failure). This can be considered to be the auto-incrementing primary key for a committed tranasction, and can be used in (eg) to look up details on the transaction&#39;s outcome from the &#x60;/lts/stream/transaction-outcomes&#x60; endpoint. 
        /// </summary>
        /// <value>An integer between &#x60;1&#x60; and &#x60;10^13&#x60;, giving the resultant state version when the transaction was committed. This is only present if the intent was committed (as a Success or Failure). This can be considered to be the auto-incrementing primary key for a committed tranasction, and can be used in (eg) to look up details on the transaction&#39;s outcome from the &#x60;/lts/stream/transaction-outcomes&#x60; endpoint. </value>
        [DataMember(Name = "committed_state_version", EmitDefaultValue = true)]
        public long CommittedStateVersion { get; set; }

        /// <summary>
        /// An integer between &#x60;0&#x60; and &#x60;10^10&#x60;, marking the epoch from which the transaction will no longer be valid, and be permanently rejected. Only present if the intent status is InMempool or Unknown and we know about a payload. 
        /// </summary>
        /// <value>An integer between &#x60;0&#x60; and &#x60;10^10&#x60;, marking the epoch from which the transaction will no longer be valid, and be permanently rejected. Only present if the intent status is InMempool or Unknown and we know about a payload. </value>
        [DataMember(Name = "invalid_from_epoch", EmitDefaultValue = true)]
        public long InvalidFromEpoch { get; set; }

        /// <summary>
        /// Gets or Sets KnownPayloads
        /// </summary>
        [DataMember(Name = "known_payloads", IsRequired = true, EmitDefaultValue = true)]
        public List<LtsTransactionPayloadDetails> KnownPayloads { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LtsTransactionStatusResponse {\n");
            sb.Append("  IntentStatus: ").Append(IntentStatus).Append("\n");
            sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
            sb.Append("  CommittedStateVersion: ").Append(CommittedStateVersion).Append("\n");
            sb.Append("  InvalidFromEpoch: ").Append(InvalidFromEpoch).Append("\n");
            sb.Append("  KnownPayloads: ").Append(KnownPayloads).Append("\n");
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
            return this.Equals(input as LtsTransactionStatusResponse);
        }

        /// <summary>
        /// Returns true if LtsTransactionStatusResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of LtsTransactionStatusResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LtsTransactionStatusResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IntentStatus == input.IntentStatus ||
                    this.IntentStatus.Equals(input.IntentStatus)
                ) && 
                (
                    this.StatusDescription == input.StatusDescription ||
                    (this.StatusDescription != null &&
                    this.StatusDescription.Equals(input.StatusDescription))
                ) && 
                (
                    this.CommittedStateVersion == input.CommittedStateVersion ||
                    this.CommittedStateVersion.Equals(input.CommittedStateVersion)
                ) && 
                (
                    this.InvalidFromEpoch == input.InvalidFromEpoch ||
                    this.InvalidFromEpoch.Equals(input.InvalidFromEpoch)
                ) && 
                (
                    this.KnownPayloads == input.KnownPayloads ||
                    this.KnownPayloads != null &&
                    input.KnownPayloads != null &&
                    this.KnownPayloads.SequenceEqual(input.KnownPayloads)
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
                hashCode = (hashCode * 59) + this.IntentStatus.GetHashCode();
                if (this.StatusDescription != null)
                {
                    hashCode = (hashCode * 59) + this.StatusDescription.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CommittedStateVersion.GetHashCode();
                hashCode = (hashCode * 59) + this.InvalidFromEpoch.GetHashCode();
                if (this.KnownPayloads != null)
                {
                    hashCode = (hashCode * 59) + this.KnownPayloads.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
