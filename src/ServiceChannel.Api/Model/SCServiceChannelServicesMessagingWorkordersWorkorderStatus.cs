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
    /// SCServiceChannelServicesMessagingWorkordersWorkorderStatus
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.Workorders.WorkorderStatus")]
    public partial class SCServiceChannelServicesMessagingWorkordersWorkorderStatus : IEquatable<SCServiceChannelServicesMessagingWorkordersWorkorderStatus>, IValidatableObject
    {
        /// <summary>
        /// Required, primary work order status value
        /// </summary>
        /// <value>Required, primary work order status value</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PrimaryEnum
        {
            /// <summary>
            /// Enum NotSet for value: NotSet
            /// </summary>
            [EnumMember(Value = "NotSet")]
            NotSet = 1,

            /// <summary>
            /// Enum Open for value: Open
            /// </summary>
            [EnumMember(Value = "Open")]
            Open = 2,

            /// <summary>
            /// Enum InProgress for value: InProgress
            /// </summary>
            [EnumMember(Value = "InProgress")]
            InProgress = 3,

            /// <summary>
            /// Enum Completed for value: Completed
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed = 4,

            /// <summary>
            /// Enum Incomplete for value: Incomplete
            /// </summary>
            [EnumMember(Value = "Incomplete")]
            Incomplete = 5

        }


        /// <summary>
        /// Required, primary work order status value
        /// </summary>
        /// <value>Required, primary work order status value</value>
        [DataMember(Name = "Primary", IsRequired = true, EmitDefaultValue = true)]
        public PrimaryEnum Primary { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingWorkordersWorkorderStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SCServiceChannelServicesMessagingWorkordersWorkorderStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingWorkordersWorkorderStatus" /> class.
        /// </summary>
        /// <param name="primary">Required, primary work order status value (required).</param>
        /// <param name="extended">Required, but can be empty. Extended status value (required).</param>
        public SCServiceChannelServicesMessagingWorkordersWorkorderStatus(PrimaryEnum primary = default(PrimaryEnum), string extended = default(string))
        {
            this.Primary = primary;
            // to ensure "extended" is required (not null)
            if (extended == null)
            {
                throw new ArgumentNullException("extended is a required property for SCServiceChannelServicesMessagingWorkordersWorkorderStatus and cannot be null");
            }
            this.Extended = extended;
        }

        /// <summary>
        /// Required, but can be empty. Extended status value
        /// </summary>
        /// <value>Required, but can be empty. Extended status value</value>
        [DataMember(Name = "Extended", IsRequired = true, EmitDefaultValue = true)]
        public string Extended { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryStatusValue
        /// </summary>
        [DataMember(Name = "PrimaryStatusValue", EmitDefaultValue = false)]
        public string PrimaryStatusValue { get; private set; }

        /// <summary>
        /// Returns false as PrimaryStatusValue should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePrimaryStatusValue()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingWorkordersWorkorderStatus {\n");
            sb.Append("  Primary: ").Append(Primary).Append("\n");
            sb.Append("  Extended: ").Append(Extended).Append("\n");
            sb.Append("  PrimaryStatusValue: ").Append(PrimaryStatusValue).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingWorkordersWorkorderStatus);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingWorkordersWorkorderStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingWorkordersWorkorderStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingWorkordersWorkorderStatus input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Primary == input.Primary ||
                    this.Primary.Equals(input.Primary)
                ) && 
                (
                    this.Extended == input.Extended ||
                    (this.Extended != null &&
                    this.Extended.Equals(input.Extended))
                ) && 
                (
                    this.PrimaryStatusValue == input.PrimaryStatusValue ||
                    (this.PrimaryStatusValue != null &&
                    this.PrimaryStatusValue.Equals(input.PrimaryStatusValue))
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
                hashCode = (hashCode * 59) + this.Primary.GetHashCode();
                if (this.Extended != null)
                {
                    hashCode = (hashCode * 59) + this.Extended.GetHashCode();
                }
                if (this.PrimaryStatusValue != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryStatusValue.GetHashCode();
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
