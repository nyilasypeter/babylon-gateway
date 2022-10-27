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
 * Babylon Core API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.0
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
using System.ComponentModel.DataAnnotations;
using FileParameter = RadixDlt.CoreApiSdk.Client.FileParameter;
using OpenAPIDateConverter = RadixDlt.CoreApiSdk.Client.OpenAPIDateConverter;

namespace RadixDlt.CoreApiSdk.Model
{
    /// <summary>
    /// SubstateId
    /// </summary>
    [DataContract(Name = "SubstateId")]
    public partial class SubstateId : IEquatable<SubstateId>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
        [DataMember(Name = "entity_type", IsRequired = true, EmitDefaultValue = true)]
        public EntityType EntityType { get; set; }

        /// <summary>
        /// Gets or Sets SubstateType
        /// </summary>
        [DataMember(Name = "substate_type", IsRequired = true, EmitDefaultValue = true)]
        public SubstateType SubstateType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubstateId" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubstateId() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubstateId" /> class.
        /// </summary>
        /// <param name="entityType">entityType (required).</param>
        /// <param name="entityIdHex">The hex-encoded bytes of the entity id (required).</param>
        /// <param name="substateType">substateType (required).</param>
        /// <param name="substateKeyHex">The hex-encoded bytes of the substate key, under the entity (required).</param>
        public SubstateId(EntityType entityType = default(EntityType), string entityIdHex = default(string), SubstateType substateType = default(SubstateType), string substateKeyHex = default(string))
        {
            this.EntityType = entityType;
            // to ensure "entityIdHex" is required (not null)
            if (entityIdHex == null)
            {
                throw new ArgumentNullException("entityIdHex is a required property for SubstateId and cannot be null");
            }
            this.EntityIdHex = entityIdHex;
            this.SubstateType = substateType;
            // to ensure "substateKeyHex" is required (not null)
            if (substateKeyHex == null)
            {
                throw new ArgumentNullException("substateKeyHex is a required property for SubstateId and cannot be null");
            }
            this.SubstateKeyHex = substateKeyHex;
        }

        /// <summary>
        /// The hex-encoded bytes of the entity id
        /// </summary>
        /// <value>The hex-encoded bytes of the entity id</value>
        [DataMember(Name = "entity_id_hex", IsRequired = true, EmitDefaultValue = true)]
        public string EntityIdHex { get; set; }

        /// <summary>
        /// The hex-encoded bytes of the substate key, under the entity
        /// </summary>
        /// <value>The hex-encoded bytes of the substate key, under the entity</value>
        [DataMember(Name = "substate_key_hex", IsRequired = true, EmitDefaultValue = true)]
        public string SubstateKeyHex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubstateId {\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  EntityIdHex: ").Append(EntityIdHex).Append("\n");
            sb.Append("  SubstateType: ").Append(SubstateType).Append("\n");
            sb.Append("  SubstateKeyHex: ").Append(SubstateKeyHex).Append("\n");
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
            return this.Equals(input as SubstateId);
        }

        /// <summary>
        /// Returns true if SubstateId instances are equal
        /// </summary>
        /// <param name="input">Instance of SubstateId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubstateId input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EntityType == input.EntityType ||
                    this.EntityType.Equals(input.EntityType)
                ) && 
                (
                    this.EntityIdHex == input.EntityIdHex ||
                    (this.EntityIdHex != null &&
                    this.EntityIdHex.Equals(input.EntityIdHex))
                ) && 
                (
                    this.SubstateType == input.SubstateType ||
                    this.SubstateType.Equals(input.SubstateType)
                ) && 
                (
                    this.SubstateKeyHex == input.SubstateKeyHex ||
                    (this.SubstateKeyHex != null &&
                    this.SubstateKeyHex.Equals(input.SubstateKeyHex))
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
                hashCode = (hashCode * 59) + this.EntityType.GetHashCode();
                if (this.EntityIdHex != null)
                {
                    hashCode = (hashCode * 59) + this.EntityIdHex.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SubstateType.GetHashCode();
                if (this.SubstateKeyHex != null)
                {
                    hashCode = (hashCode * 59) + this.SubstateKeyHex.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
