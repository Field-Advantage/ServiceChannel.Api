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
    /// SCServiceChannelServicesMessagingApprovalCodesEditableAdditionalApprovalCode
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.ApprovalCodes.EditableAdditionalApprovalCode")]
    public partial class SCServiceChannelServicesMessagingApprovalCodesEditableAdditionalApprovalCode : IEquatable<SCServiceChannelServicesMessagingApprovalCodesEditableAdditionalApprovalCode>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingApprovalCodesEditableAdditionalApprovalCode" /> class.
        /// </summary>
        /// <param name="header">header.</param>
        /// <param name="value">value.</param>
        /// <param name="setupId">setupId.</param>
        /// <param name="locationId">locationId.</param>
        /// <param name="defaultOptionId">defaultOptionId.</param>
        /// <param name="valueFormat">valueFormat.</param>
        /// <param name="editableAtLineItemLevel">editableAtLineItemLevel.</param>
        /// <param name="options">options.</param>
        public SCServiceChannelServicesMessagingApprovalCodesEditableAdditionalApprovalCode(string header = default(string), string value = default(string), int setupId = default(int), int locationId = default(int), int defaultOptionId = default(int), int valueFormat = default(int), int editableAtLineItemLevel = default(int), List<SCServiceChannelServicesMessagingApprovalCodesAdditionalApprovalCodeOption> options = default(List<SCServiceChannelServicesMessagingApprovalCodesAdditionalApprovalCodeOption>))
        {
            this.Header = header;
            this.Value = value;
            this.SetupId = setupId;
            this.LocationId = locationId;
            this.DefaultOptionId = defaultOptionId;
            this.ValueFormat = valueFormat;
            this.EditableAtLineItemLevel = editableAtLineItemLevel;
            this.Options = options;
        }

        /// <summary>
        /// Gets or Sets Header
        /// </summary>
        [DataMember(Name = "Header", EmitDefaultValue = false)]
        public string Header { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "Value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets SetupId
        /// </summary>
        [DataMember(Name = "SetupId", EmitDefaultValue = false)]
        public int SetupId { get; set; }

        /// <summary>
        /// Gets or Sets LocationId
        /// </summary>
        [DataMember(Name = "LocationId", EmitDefaultValue = false)]
        public int LocationId { get; set; }

        /// <summary>
        /// Gets or Sets DefaultOptionId
        /// </summary>
        [DataMember(Name = "DefaultOptionId", EmitDefaultValue = false)]
        public int DefaultOptionId { get; set; }

        /// <summary>
        /// Gets or Sets ValueFormat
        /// </summary>
        [DataMember(Name = "ValueFormat", EmitDefaultValue = false)]
        public int ValueFormat { get; set; }

        /// <summary>
        /// Gets or Sets EditableAtLineItemLevel
        /// </summary>
        [DataMember(Name = "EditableAtLineItemLevel", EmitDefaultValue = false)]
        public int EditableAtLineItemLevel { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name = "Options", EmitDefaultValue = false)]
        public List<SCServiceChannelServicesMessagingApprovalCodesAdditionalApprovalCodeOption> Options { get; set; }

        /// <summary>
        /// Gets or Sets DefaultValue
        /// </summary>
        [DataMember(Name = "DefaultValue", EmitDefaultValue = false)]
        public string DefaultValue { get; private set; }

        /// <summary>
        /// Returns false as DefaultValue should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDefaultValue()
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
            sb.Append("class SCServiceChannelServicesMessagingApprovalCodesEditableAdditionalApprovalCode {\n");
            sb.Append("  Header: ").Append(Header).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  SetupId: ").Append(SetupId).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  DefaultOptionId: ").Append(DefaultOptionId).Append("\n");
            sb.Append("  ValueFormat: ").Append(ValueFormat).Append("\n");
            sb.Append("  EditableAtLineItemLevel: ").Append(EditableAtLineItemLevel).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingApprovalCodesEditableAdditionalApprovalCode);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingApprovalCodesEditableAdditionalApprovalCode instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingApprovalCodesEditableAdditionalApprovalCode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingApprovalCodesEditableAdditionalApprovalCode input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Header == input.Header ||
                    (this.Header != null &&
                    this.Header.Equals(input.Header))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.SetupId == input.SetupId ||
                    this.SetupId.Equals(input.SetupId)
                ) && 
                (
                    this.LocationId == input.LocationId ||
                    this.LocationId.Equals(input.LocationId)
                ) && 
                (
                    this.DefaultOptionId == input.DefaultOptionId ||
                    this.DefaultOptionId.Equals(input.DefaultOptionId)
                ) && 
                (
                    this.ValueFormat == input.ValueFormat ||
                    this.ValueFormat.Equals(input.ValueFormat)
                ) && 
                (
                    this.EditableAtLineItemLevel == input.EditableAtLineItemLevel ||
                    this.EditableAtLineItemLevel.Equals(input.EditableAtLineItemLevel)
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    input.Options != null &&
                    this.Options.SequenceEqual(input.Options)
                ) && 
                (
                    this.DefaultValue == input.DefaultValue ||
                    (this.DefaultValue != null &&
                    this.DefaultValue.Equals(input.DefaultValue))
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
                if (this.Header != null)
                {
                    hashCode = (hashCode * 59) + this.Header.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SetupId.GetHashCode();
                hashCode = (hashCode * 59) + this.LocationId.GetHashCode();
                hashCode = (hashCode * 59) + this.DefaultOptionId.GetHashCode();
                hashCode = (hashCode * 59) + this.ValueFormat.GetHashCode();
                hashCode = (hashCode * 59) + this.EditableAtLineItemLevel.GetHashCode();
                if (this.Options != null)
                {
                    hashCode = (hashCode * 59) + this.Options.GetHashCode();
                }
                if (this.DefaultValue != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultValue.GetHashCode();
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
