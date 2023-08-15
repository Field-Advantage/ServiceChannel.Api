/*
 * ServiceChannel API - v.3
 *
 * The ServiceChannel API is a RESTful and stateless API. It accepts standard HTTP verbs and supports OAuth 2.0 for authorizing requests.      Our API returns common HTTP status codes as well as JSON encapsulated data.      See [API Overview](https://developer.servicechannel.com/basics/introduction/overview/) for the intro to ServiceChannel API.<br>      <h3>Authentication and Authorization</h3>You should have a ServiceChannel account, register your application, and obtain `access_token` to integrate with our API.      See [Authentication and Authorization](https://developer.servicechannel.com/basics/general/authentication/) for more information.      To use this API playground, click **Authorize** and sign in to ServiceChannel.<br>      <h3>Environment</h3> All calls in this API Reference point to the **SB2 environment**.      See [Environments](https://developer.servicechannel.com/basics/general/environments/) for more information.<br>      <h3>API Version</h3>The current stable version of the ServiceChannel API is `v3`. In the request URL, `v3` is a version prefix that should be present.      When you omit the version prefix, calls point to the minimum supported version of the API.      We recommend you to always specify the API version to avoid possible errors.
 *
 * The version of the OpenAPI document: 3
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
using OpenAPIDateConverter = ServiceChannel.Api.Client.OpenAPIDateConverter;

namespace ServiceChannel.Api.Model
{
    /// <summary>
    /// SCServiceChannelServicesMessagingProposalsProposalStatus
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.Proposals.ProposalStatus")]
    public partial class SCServiceChannelServicesMessagingProposalsProposalStatus : IEquatable<SCServiceChannelServicesMessagingProposalsProposalStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingProposalsProposalStatus" /> class.
        /// </summary>
        /// <param name="primary">primary.</param>
        /// <param name="extended">extended.</param>
        /// <param name="modifiedDate">modifiedDate.</param>
        /// <param name="modifiedDateDto">modifiedDateDto.</param>
        /// <param name="modifiedBy">modifiedBy.</param>
        public SCServiceChannelServicesMessagingProposalsProposalStatus(string primary = default(string), string extended = default(string), DateTime modifiedDate = default(DateTime), DateTime modifiedDateDto = default(DateTime), string modifiedBy = default(string))
        {
            this.Primary = primary;
            this.Extended = extended;
            this.ModifiedDate = modifiedDate;
            this.ModifiedDateDto = modifiedDateDto;
            this.ModifiedBy = modifiedBy;
        }

        /// <summary>
        /// Gets or Sets Primary
        /// </summary>
        [DataMember(Name = "Primary", EmitDefaultValue = false)]
        public string Primary { get; set; }

        /// <summary>
        /// Gets or Sets Extended
        /// </summary>
        [DataMember(Name = "Extended", EmitDefaultValue = false)]
        public string Extended { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name = "ModifiedDate", EmitDefaultValue = false)]
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDateDto
        /// </summary>
        [DataMember(Name = "ModifiedDate_dto", EmitDefaultValue = false)]
        public DateTime ModifiedDateDto { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name = "ModifiedBy", EmitDefaultValue = false)]
        public string ModifiedBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingProposalsProposalStatus {\n");
            sb.Append("  Primary: ").Append(Primary).Append("\n");
            sb.Append("  Extended: ").Append(Extended).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  ModifiedDateDto: ").Append(ModifiedDateDto).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingProposalsProposalStatus);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingProposalsProposalStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingProposalsProposalStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingProposalsProposalStatus input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Primary == input.Primary ||
                    (this.Primary != null &&
                    this.Primary.Equals(input.Primary))
                ) && 
                (
                    this.Extended == input.Extended ||
                    (this.Extended != null &&
                    this.Extended.Equals(input.Extended))
                ) && 
                (
                    this.ModifiedDate == input.ModifiedDate ||
                    (this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(input.ModifiedDate))
                ) && 
                (
                    this.ModifiedDateDto == input.ModifiedDateDto ||
                    (this.ModifiedDateDto != null &&
                    this.ModifiedDateDto.Equals(input.ModifiedDateDto))
                ) && 
                (
                    this.ModifiedBy == input.ModifiedBy ||
                    (this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(input.ModifiedBy))
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
                if (this.Primary != null)
                {
                    hashCode = (hashCode * 59) + this.Primary.GetHashCode();
                }
                if (this.Extended != null)
                {
                    hashCode = (hashCode * 59) + this.Extended.GetHashCode();
                }
                if (this.ModifiedDate != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedDate.GetHashCode();
                }
                if (this.ModifiedDateDto != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedDateDto.GetHashCode();
                }
                if (this.ModifiedBy != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedBy.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
