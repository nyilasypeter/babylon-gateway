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
    /// NetworkStatusResponse
    /// </summary>
    [DataContract(Name = "NetworkStatusResponse")]
    public partial class NetworkStatusResponse : IEquatable<NetworkStatusResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkStatusResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NetworkStatusResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkStatusResponse" /> class.
        /// </summary>
        /// <param name="preGenesisStateIdentifier">preGenesisStateIdentifier (required).</param>
        /// <param name="genesisEpochRound">genesisEpochRound.</param>
        /// <param name="postGenesisStateIdentifier">postGenesisStateIdentifier.</param>
        /// <param name="currentStateIdentifier">currentStateIdentifier.</param>
        /// <param name="currentEpochRound">currentEpochRound.</param>
        /// <param name="currentProtocolVersion">A descriptor for the current protocol version that the node is running.  (required).</param>
        public NetworkStatusResponse(CommittedStateIdentifier preGenesisStateIdentifier = default(CommittedStateIdentifier), EpochRound genesisEpochRound = default(EpochRound), CommittedStateIdentifier postGenesisStateIdentifier = default(CommittedStateIdentifier), CommittedStateIdentifier currentStateIdentifier = default(CommittedStateIdentifier), EpochRound currentEpochRound = default(EpochRound), string currentProtocolVersion = default(string))
        {
            // to ensure "preGenesisStateIdentifier" is required (not null)
            if (preGenesisStateIdentifier == null)
            {
                throw new ArgumentNullException("preGenesisStateIdentifier is a required property for NetworkStatusResponse and cannot be null");
            }
            this.PreGenesisStateIdentifier = preGenesisStateIdentifier;
            // to ensure "currentProtocolVersion" is required (not null)
            if (currentProtocolVersion == null)
            {
                throw new ArgumentNullException("currentProtocolVersion is a required property for NetworkStatusResponse and cannot be null");
            }
            this.CurrentProtocolVersion = currentProtocolVersion;
            this.GenesisEpochRound = genesisEpochRound;
            this.PostGenesisStateIdentifier = postGenesisStateIdentifier;
            this.CurrentStateIdentifier = currentStateIdentifier;
            this.CurrentEpochRound = currentEpochRound;
        }

        /// <summary>
        /// Gets or Sets PreGenesisStateIdentifier
        /// </summary>
        [DataMember(Name = "pre_genesis_state_identifier", IsRequired = true, EmitDefaultValue = true)]
        public CommittedStateIdentifier PreGenesisStateIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets GenesisEpochRound
        /// </summary>
        [DataMember(Name = "genesis_epoch_round", EmitDefaultValue = true)]
        public EpochRound GenesisEpochRound { get; set; }

        /// <summary>
        /// Gets or Sets PostGenesisStateIdentifier
        /// </summary>
        [DataMember(Name = "post_genesis_state_identifier", EmitDefaultValue = true)]
        public CommittedStateIdentifier PostGenesisStateIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets CurrentStateIdentifier
        /// </summary>
        [DataMember(Name = "current_state_identifier", EmitDefaultValue = true)]
        public CommittedStateIdentifier CurrentStateIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets CurrentEpochRound
        /// </summary>
        [DataMember(Name = "current_epoch_round", EmitDefaultValue = true)]
        public EpochRound CurrentEpochRound { get; set; }

        /// <summary>
        /// A descriptor for the current protocol version that the node is running. 
        /// </summary>
        /// <value>A descriptor for the current protocol version that the node is running. </value>
        [DataMember(Name = "current_protocol_version", IsRequired = true, EmitDefaultValue = true)]
        public string CurrentProtocolVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NetworkStatusResponse {\n");
            sb.Append("  PreGenesisStateIdentifier: ").Append(PreGenesisStateIdentifier).Append("\n");
            sb.Append("  GenesisEpochRound: ").Append(GenesisEpochRound).Append("\n");
            sb.Append("  PostGenesisStateIdentifier: ").Append(PostGenesisStateIdentifier).Append("\n");
            sb.Append("  CurrentStateIdentifier: ").Append(CurrentStateIdentifier).Append("\n");
            sb.Append("  CurrentEpochRound: ").Append(CurrentEpochRound).Append("\n");
            sb.Append("  CurrentProtocolVersion: ").Append(CurrentProtocolVersion).Append("\n");
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
            return this.Equals(input as NetworkStatusResponse);
        }

        /// <summary>
        /// Returns true if NetworkStatusResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of NetworkStatusResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkStatusResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PreGenesisStateIdentifier == input.PreGenesisStateIdentifier ||
                    (this.PreGenesisStateIdentifier != null &&
                    this.PreGenesisStateIdentifier.Equals(input.PreGenesisStateIdentifier))
                ) && 
                (
                    this.GenesisEpochRound == input.GenesisEpochRound ||
                    (this.GenesisEpochRound != null &&
                    this.GenesisEpochRound.Equals(input.GenesisEpochRound))
                ) && 
                (
                    this.PostGenesisStateIdentifier == input.PostGenesisStateIdentifier ||
                    (this.PostGenesisStateIdentifier != null &&
                    this.PostGenesisStateIdentifier.Equals(input.PostGenesisStateIdentifier))
                ) && 
                (
                    this.CurrentStateIdentifier == input.CurrentStateIdentifier ||
                    (this.CurrentStateIdentifier != null &&
                    this.CurrentStateIdentifier.Equals(input.CurrentStateIdentifier))
                ) && 
                (
                    this.CurrentEpochRound == input.CurrentEpochRound ||
                    (this.CurrentEpochRound != null &&
                    this.CurrentEpochRound.Equals(input.CurrentEpochRound))
                ) && 
                (
                    this.CurrentProtocolVersion == input.CurrentProtocolVersion ||
                    (this.CurrentProtocolVersion != null &&
                    this.CurrentProtocolVersion.Equals(input.CurrentProtocolVersion))
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
                if (this.PreGenesisStateIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.PreGenesisStateIdentifier.GetHashCode();
                }
                if (this.GenesisEpochRound != null)
                {
                    hashCode = (hashCode * 59) + this.GenesisEpochRound.GetHashCode();
                }
                if (this.PostGenesisStateIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.PostGenesisStateIdentifier.GetHashCode();
                }
                if (this.CurrentStateIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentStateIdentifier.GetHashCode();
                }
                if (this.CurrentEpochRound != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentEpochRound.GetHashCode();
                }
                if (this.CurrentProtocolVersion != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentProtocolVersion.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
