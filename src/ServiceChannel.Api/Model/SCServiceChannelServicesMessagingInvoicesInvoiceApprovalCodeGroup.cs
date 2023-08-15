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
    /// SCServiceChannelServicesMessagingInvoicesInvoiceApprovalCodeGroup
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.Invoices.InvoiceApprovalCodeGroup")]
    public partial class SCServiceChannelServicesMessagingInvoicesInvoiceApprovalCodeGroup : IEquatable<SCServiceChannelServicesMessagingInvoicesInvoiceApprovalCodeGroup>, IValidatableObject
    {
        /// <summary>
        /// Defines ApprovalCodeType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ApprovalCodeTypeEnum
        {
            /// <summary>
            /// Enum Labor for value: Labor
            /// </summary>
            [EnumMember(Value = "Labor")]
            Labor = 1,

            /// <summary>
            /// Enum Travel for value: Travel
            /// </summary>
            [EnumMember(Value = "Travel")]
            Travel = 2,

            /// <summary>
            /// Enum Material for value: Material
            /// </summary>
            [EnumMember(Value = "Material")]
            Material = 3,

            /// <summary>
            /// Enum Freight for value: Freight
            /// </summary>
            [EnumMember(Value = "Freight")]
            Freight = 4,

            /// <summary>
            /// Enum Other for value: Other
            /// </summary>
            [EnumMember(Value = "Other")]
            Other = 5,

            /// <summary>
            /// Enum Tax for value: Tax
            /// </summary>
            [EnumMember(Value = "Tax")]
            Tax = 6,

            /// <summary>
            /// Enum Tax2 for value: Tax2
            /// </summary>
            [EnumMember(Value = "Tax2")]
            Tax2 = 7,

            /// <summary>
            /// Enum LineItem for value: LineItem
            /// </summary>
            [EnumMember(Value = "LineItem")]
            LineItem = 8,

            /// <summary>
            /// Enum FreightGenerated for value: FreightGenerated
            /// </summary>
            [EnumMember(Value = "FreightGenerated")]
            FreightGenerated = 9

        }


        /// <summary>
        /// Gets or Sets ApprovalCodeType
        /// </summary>
        [DataMember(Name = "ApprovalCodeType", EmitDefaultValue = false)]
        public ApprovalCodeTypeEnum? ApprovalCodeType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingInvoicesInvoiceApprovalCodeGroup" /> class.
        /// </summary>
        /// <param name="approvalCodeType">approvalCodeType.</param>
        /// <param name="approvalCode">approvalCode.</param>
        /// <param name="additionalApprovalCode">additionalApprovalCode.</param>
        /// <param name="amount">amount.</param>
        /// <param name="approvalCodes">approvalCodes.</param>
        public SCServiceChannelServicesMessagingInvoicesInvoiceApprovalCodeGroup(ApprovalCodeTypeEnum? approvalCodeType = default(ApprovalCodeTypeEnum?), string approvalCode = default(string), string additionalApprovalCode = default(string), double amount = default(double), List<SCServiceChannelServicesMessagingInvoicesInvoiceApprovalCodeChild> approvalCodes = default(List<SCServiceChannelServicesMessagingInvoicesInvoiceApprovalCodeChild>))
        {
            this.ApprovalCodeType = approvalCodeType;
            this.ApprovalCode = approvalCode;
            this.AdditionalApprovalCode = additionalApprovalCode;
            this.Amount = amount;
            this.ApprovalCodes = approvalCodes;
        }

        /// <summary>
        /// Gets or Sets ApprovalCode
        /// </summary>
        [DataMember(Name = "ApprovalCode", EmitDefaultValue = false)]
        public string ApprovalCode { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalApprovalCode
        /// </summary>
        [DataMember(Name = "AdditionalApprovalCode", EmitDefaultValue = false)]
        public string AdditionalApprovalCode { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "Amount", EmitDefaultValue = false)]
        public double Amount { get; set; }

        /// <summary>
        /// Gets or Sets ApprovalCodes
        /// </summary>
        [DataMember(Name = "ApprovalCodes", EmitDefaultValue = false)]
        public List<SCServiceChannelServicesMessagingInvoicesInvoiceApprovalCodeChild> ApprovalCodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingInvoicesInvoiceApprovalCodeGroup {\n");
            sb.Append("  ApprovalCodeType: ").Append(ApprovalCodeType).Append("\n");
            sb.Append("  ApprovalCode: ").Append(ApprovalCode).Append("\n");
            sb.Append("  AdditionalApprovalCode: ").Append(AdditionalApprovalCode).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ApprovalCodes: ").Append(ApprovalCodes).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingInvoicesInvoiceApprovalCodeGroup);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingInvoicesInvoiceApprovalCodeGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingInvoicesInvoiceApprovalCodeGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingInvoicesInvoiceApprovalCodeGroup input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApprovalCodeType == input.ApprovalCodeType ||
                    this.ApprovalCodeType.Equals(input.ApprovalCodeType)
                ) && 
                (
                    this.ApprovalCode == input.ApprovalCode ||
                    (this.ApprovalCode != null &&
                    this.ApprovalCode.Equals(input.ApprovalCode))
                ) && 
                (
                    this.AdditionalApprovalCode == input.AdditionalApprovalCode ||
                    (this.AdditionalApprovalCode != null &&
                    this.AdditionalApprovalCode.Equals(input.AdditionalApprovalCode))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.ApprovalCodes == input.ApprovalCodes ||
                    this.ApprovalCodes != null &&
                    input.ApprovalCodes != null &&
                    this.ApprovalCodes.SequenceEqual(input.ApprovalCodes)
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
                hashCode = (hashCode * 59) + this.ApprovalCodeType.GetHashCode();
                if (this.ApprovalCode != null)
                {
                    hashCode = (hashCode * 59) + this.ApprovalCode.GetHashCode();
                }
                if (this.AdditionalApprovalCode != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalApprovalCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.ApprovalCodes != null)
                {
                    hashCode = (hashCode * 59) + this.ApprovalCodes.GetHashCode();
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
