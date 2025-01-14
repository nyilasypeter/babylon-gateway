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
 * Babylon Gateway API - RCnet V2
 *
 * This API is exposed by the Babylon Radix Gateway to enable clients to efficiently query current and historic state on the RadixDLT ledger, and intelligently handle transaction submission.  It is designed for use by wallets and explorers. For simple use cases, you can typically use the Core API on a Node. A Gateway is only needed for reading historic snapshots of ledger states or a more robust set-up.  The Gateway API is implemented by the [Network Gateway](https://github.com/radixdlt/babylon-gateway), which is configured to read from [full node(s)](https://github.com/radixdlt/babylon-node) to extract and index data from the network.  This document is an API reference documentation, visit [User Guide](https://docs-babylon.radixdlt.com/) to learn more about how to run a Gateway of your own.  ## Integration and forward compatibility guarantees  We give no guarantees that other endpoints will not change before Babylon mainnet launch, although changes are expected to be minimal. 
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
using FileParameter = RadixDlt.NetworkGateway.GatewayApiSdk.Client.FileParameter;
using OpenAPIDateConverter = RadixDlt.NetworkGateway.GatewayApiSdk.Client.OpenAPIDateConverter;

namespace RadixDlt.NetworkGateway.GatewayApiSdk.Model
{
    /// <summary>
    /// CommittedTransactionInfo
    /// </summary>
    [DataContract(Name = "CommittedTransactionInfo")]
    public partial class CommittedTransactionInfo : IEquatable<CommittedTransactionInfo>
    {

        /// <summary>
        /// Gets or Sets TransactionStatus
        /// </summary>
        [DataMember(Name = "transaction_status", IsRequired = true, EmitDefaultValue = true)]
        public TransactionStatus TransactionStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommittedTransactionInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommittedTransactionInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommittedTransactionInfo" /> class.
        /// </summary>
        /// <param name="stateVersion">stateVersion (required).</param>
        /// <param name="epoch">epoch (required).</param>
        /// <param name="round">round (required).</param>
        /// <param name="roundTimestamp">roundTimestamp (required).</param>
        /// <param name="transactionStatus">transactionStatus (required).</param>
        /// <param name="payloadHashHex">Hex-encoded SHA-256 hash..</param>
        /// <param name="intentHashHex">Hex-encoded SHA-256 hash..</param>
        /// <param name="feePaid">String-encoded decimal representing the amount of a related fungible resource..</param>
        /// <param name="affectedGlobalEntities">affectedGlobalEntities.</param>
        /// <param name="confirmedAt">confirmedAt.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="rawHex">Hex-encoded binary blob..</param>
        /// <param name="receipt">receipt.</param>
        /// <param name="messageHex">Hex-encoded binary blob..</param>
        public CommittedTransactionInfo(long stateVersion = default(long), long epoch = default(long), long round = default(long), string roundTimestamp = default(string), TransactionStatus transactionStatus = default(TransactionStatus), string payloadHashHex = default(string), string intentHashHex = default(string), string feePaid = default(string), List<string> affectedGlobalEntities = default(List<string>), DateTime? confirmedAt = default(DateTime?), string errorMessage = default(string), string rawHex = default(string), TransactionReceipt receipt = default(TransactionReceipt), string messageHex = default(string))
        {
            this.StateVersion = stateVersion;
            this.Epoch = epoch;
            this.Round = round;
            // to ensure "roundTimestamp" is required (not null)
            if (roundTimestamp == null)
            {
                throw new ArgumentNullException("roundTimestamp is a required property for CommittedTransactionInfo and cannot be null");
            }
            this.RoundTimestamp = roundTimestamp;
            this.TransactionStatus = transactionStatus;
            this.PayloadHashHex = payloadHashHex;
            this.IntentHashHex = intentHashHex;
            this.FeePaid = feePaid;
            this.AffectedGlobalEntities = affectedGlobalEntities;
            this.ConfirmedAt = confirmedAt;
            this.ErrorMessage = errorMessage;
            this.RawHex = rawHex;
            this.Receipt = receipt;
            this.MessageHex = messageHex;
        }

        /// <summary>
        /// Gets or Sets StateVersion
        /// </summary>
        [DataMember(Name = "state_version", IsRequired = true, EmitDefaultValue = true)]
        public long StateVersion { get; set; }

        /// <summary>
        /// Gets or Sets Epoch
        /// </summary>
        [DataMember(Name = "epoch", IsRequired = true, EmitDefaultValue = true)]
        public long Epoch { get; set; }

        /// <summary>
        /// Gets or Sets Round
        /// </summary>
        [DataMember(Name = "round", IsRequired = true, EmitDefaultValue = true)]
        public long Round { get; set; }

        /// <summary>
        /// Gets or Sets RoundTimestamp
        /// </summary>
        [DataMember(Name = "round_timestamp", IsRequired = true, EmitDefaultValue = true)]
        public string RoundTimestamp { get; set; }

        /// <summary>
        /// Hex-encoded SHA-256 hash.
        /// </summary>
        /// <value>Hex-encoded SHA-256 hash.</value>
        [DataMember(Name = "payload_hash_hex", EmitDefaultValue = true)]
        public string PayloadHashHex { get; set; }

        /// <summary>
        /// Hex-encoded SHA-256 hash.
        /// </summary>
        /// <value>Hex-encoded SHA-256 hash.</value>
        [DataMember(Name = "intent_hash_hex", EmitDefaultValue = true)]
        public string IntentHashHex { get; set; }

        /// <summary>
        /// String-encoded decimal representing the amount of a related fungible resource.
        /// </summary>
        /// <value>String-encoded decimal representing the amount of a related fungible resource.</value>
        [DataMember(Name = "fee_paid", EmitDefaultValue = true)]
        public string FeePaid { get; set; }

        /// <summary>
        /// Gets or Sets AffectedGlobalEntities
        /// </summary>
        [DataMember(Name = "affected_global_entities", EmitDefaultValue = true)]
        public List<string> AffectedGlobalEntities { get; set; }

        /// <summary>
        /// Gets or Sets ConfirmedAt
        /// </summary>
        [DataMember(Name = "confirmed_at", EmitDefaultValue = true)]
        public DateTime? ConfirmedAt { get; set; }

        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name = "error_message", EmitDefaultValue = true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Hex-encoded binary blob.
        /// </summary>
        /// <value>Hex-encoded binary blob.</value>
        [DataMember(Name = "raw_hex", EmitDefaultValue = true)]
        public string RawHex { get; set; }

        /// <summary>
        /// Gets or Sets Receipt
        /// </summary>
        [DataMember(Name = "receipt", EmitDefaultValue = true)]
        public TransactionReceipt Receipt { get; set; }

        /// <summary>
        /// Hex-encoded binary blob.
        /// </summary>
        /// <value>Hex-encoded binary blob.</value>
        [DataMember(Name = "message_hex", EmitDefaultValue = true)]
        public string MessageHex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CommittedTransactionInfo {\n");
            sb.Append("  StateVersion: ").Append(StateVersion).Append("\n");
            sb.Append("  Epoch: ").Append(Epoch).Append("\n");
            sb.Append("  Round: ").Append(Round).Append("\n");
            sb.Append("  RoundTimestamp: ").Append(RoundTimestamp).Append("\n");
            sb.Append("  TransactionStatus: ").Append(TransactionStatus).Append("\n");
            sb.Append("  PayloadHashHex: ").Append(PayloadHashHex).Append("\n");
            sb.Append("  IntentHashHex: ").Append(IntentHashHex).Append("\n");
            sb.Append("  FeePaid: ").Append(FeePaid).Append("\n");
            sb.Append("  AffectedGlobalEntities: ").Append(AffectedGlobalEntities).Append("\n");
            sb.Append("  ConfirmedAt: ").Append(ConfirmedAt).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  RawHex: ").Append(RawHex).Append("\n");
            sb.Append("  Receipt: ").Append(Receipt).Append("\n");
            sb.Append("  MessageHex: ").Append(MessageHex).Append("\n");
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
            return this.Equals(input as CommittedTransactionInfo);
        }

        /// <summary>
        /// Returns true if CommittedTransactionInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CommittedTransactionInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommittedTransactionInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StateVersion == input.StateVersion ||
                    this.StateVersion.Equals(input.StateVersion)
                ) && 
                (
                    this.Epoch == input.Epoch ||
                    this.Epoch.Equals(input.Epoch)
                ) && 
                (
                    this.Round == input.Round ||
                    this.Round.Equals(input.Round)
                ) && 
                (
                    this.RoundTimestamp == input.RoundTimestamp ||
                    (this.RoundTimestamp != null &&
                    this.RoundTimestamp.Equals(input.RoundTimestamp))
                ) && 
                (
                    this.TransactionStatus == input.TransactionStatus ||
                    this.TransactionStatus.Equals(input.TransactionStatus)
                ) && 
                (
                    this.PayloadHashHex == input.PayloadHashHex ||
                    (this.PayloadHashHex != null &&
                    this.PayloadHashHex.Equals(input.PayloadHashHex))
                ) && 
                (
                    this.IntentHashHex == input.IntentHashHex ||
                    (this.IntentHashHex != null &&
                    this.IntentHashHex.Equals(input.IntentHashHex))
                ) && 
                (
                    this.FeePaid == input.FeePaid ||
                    (this.FeePaid != null &&
                    this.FeePaid.Equals(input.FeePaid))
                ) && 
                (
                    this.AffectedGlobalEntities == input.AffectedGlobalEntities ||
                    this.AffectedGlobalEntities != null &&
                    input.AffectedGlobalEntities != null &&
                    this.AffectedGlobalEntities.SequenceEqual(input.AffectedGlobalEntities)
                ) && 
                (
                    this.ConfirmedAt == input.ConfirmedAt ||
                    (this.ConfirmedAt != null &&
                    this.ConfirmedAt.Equals(input.ConfirmedAt))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.RawHex == input.RawHex ||
                    (this.RawHex != null &&
                    this.RawHex.Equals(input.RawHex))
                ) && 
                (
                    this.Receipt == input.Receipt ||
                    (this.Receipt != null &&
                    this.Receipt.Equals(input.Receipt))
                ) && 
                (
                    this.MessageHex == input.MessageHex ||
                    (this.MessageHex != null &&
                    this.MessageHex.Equals(input.MessageHex))
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
                hashCode = (hashCode * 59) + this.StateVersion.GetHashCode();
                hashCode = (hashCode * 59) + this.Epoch.GetHashCode();
                hashCode = (hashCode * 59) + this.Round.GetHashCode();
                if (this.RoundTimestamp != null)
                {
                    hashCode = (hashCode * 59) + this.RoundTimestamp.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TransactionStatus.GetHashCode();
                if (this.PayloadHashHex != null)
                {
                    hashCode = (hashCode * 59) + this.PayloadHashHex.GetHashCode();
                }
                if (this.IntentHashHex != null)
                {
                    hashCode = (hashCode * 59) + this.IntentHashHex.GetHashCode();
                }
                if (this.FeePaid != null)
                {
                    hashCode = (hashCode * 59) + this.FeePaid.GetHashCode();
                }
                if (this.AffectedGlobalEntities != null)
                {
                    hashCode = (hashCode * 59) + this.AffectedGlobalEntities.GetHashCode();
                }
                if (this.ConfirmedAt != null)
                {
                    hashCode = (hashCode * 59) + this.ConfirmedAt.GetHashCode();
                }
                if (this.ErrorMessage != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorMessage.GetHashCode();
                }
                if (this.RawHex != null)
                {
                    hashCode = (hashCode * 59) + this.RawHex.GetHashCode();
                }
                if (this.Receipt != null)
                {
                    hashCode = (hashCode * 59) + this.Receipt.GetHashCode();
                }
                if (this.MessageHex != null)
                {
                    hashCode = (hashCode * 59) + this.MessageHex.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
