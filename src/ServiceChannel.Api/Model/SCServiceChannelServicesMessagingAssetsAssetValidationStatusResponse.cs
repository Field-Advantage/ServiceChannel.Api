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
    /// SCServiceChannelServicesMessagingAssetsAssetValidationStatusResponse
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.Assets.AssetValidationStatusResponse")]
    public partial class SCServiceChannelServicesMessagingAssetsAssetValidationStatusResponse : IEquatable<SCServiceChannelServicesMessagingAssetsAssetValidationStatusResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines ValidationStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ValidationStatusEnum
        {
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 1,

            /// <summary>
            /// Enum NotAvailable for value: NotAvailable
            /// </summary>
            [EnumMember(Value = "NotAvailable")]
            NotAvailable = 2,

            /// <summary>
            /// Enum NotValidated for value: NotValidated
            /// </summary>
            [EnumMember(Value = "NotValidated")]
            NotValidated = 3,

            /// <summary>
            /// Enum PendingValidation for value: PendingValidation
            /// </summary>
            [EnumMember(Value = "PendingValidation")]
            PendingValidation = 4,

            /// <summary>
            /// Enum Validated for value: Validated
            /// </summary>
            [EnumMember(Value = "Validated")]
            Validated = 5

        }


        /// <summary>
        /// Gets or Sets ValidationStatus
        /// </summary>
        [DataMember(Name = "ValidationStatus", EmitDefaultValue = false)]
        public ValidationStatusEnum? ValidationStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingAssetsAssetValidationStatusResponse" /> class.
        /// </summary>
        /// <param name="trackingNumber">trackingNumber.</param>
        /// <param name="assetID">assetID.</param>
        /// <param name="validationStatus">validationStatus.</param>
        /// <param name="unableToValidateReason">unableToValidateReason.</param>
        public SCServiceChannelServicesMessagingAssetsAssetValidationStatusResponse(int trackingNumber = default(int), int assetID = default(int), ValidationStatusEnum? validationStatus = default(ValidationStatusEnum?), SCServiceChannelApiModelAdministrationUnableToValidateReason unableToValidateReason = default(SCServiceChannelApiModelAdministrationUnableToValidateReason))
        {
            this.TrackingNumber = trackingNumber;
            this.AssetID = assetID;
            this.ValidationStatus = validationStatus;
            this.UnableToValidateReason = unableToValidateReason;
        }

        /// <summary>
        /// Gets or Sets TrackingNumber
        /// </summary>
        [DataMember(Name = "TrackingNumber", EmitDefaultValue = false)]
        public int TrackingNumber { get; set; }

        /// <summary>
        /// Gets or Sets AssetID
        /// </summary>
        [DataMember(Name = "AssetID", EmitDefaultValue = false)]
        public int AssetID { get; set; }

        /// <summary>
        /// Gets or Sets UnableToValidateReason
        /// </summary>
        [DataMember(Name = "UnableToValidateReason", EmitDefaultValue = false)]
        public SCServiceChannelApiModelAdministrationUnableToValidateReason UnableToValidateReason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingAssetsAssetValidationStatusResponse {\n");
            sb.Append("  TrackingNumber: ").Append(TrackingNumber).Append("\n");
            sb.Append("  AssetID: ").Append(AssetID).Append("\n");
            sb.Append("  ValidationStatus: ").Append(ValidationStatus).Append("\n");
            sb.Append("  UnableToValidateReason: ").Append(UnableToValidateReason).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingAssetsAssetValidationStatusResponse);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingAssetsAssetValidationStatusResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingAssetsAssetValidationStatusResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingAssetsAssetValidationStatusResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TrackingNumber == input.TrackingNumber ||
                    this.TrackingNumber.Equals(input.TrackingNumber)
                ) && 
                (
                    this.AssetID == input.AssetID ||
                    this.AssetID.Equals(input.AssetID)
                ) && 
                (
                    this.ValidationStatus == input.ValidationStatus ||
                    this.ValidationStatus.Equals(input.ValidationStatus)
                ) && 
                (
                    this.UnableToValidateReason == input.UnableToValidateReason ||
                    (this.UnableToValidateReason != null &&
                    this.UnableToValidateReason.Equals(input.UnableToValidateReason))
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
                hashCode = (hashCode * 59) + this.TrackingNumber.GetHashCode();
                hashCode = (hashCode * 59) + this.AssetID.GetHashCode();
                hashCode = (hashCode * 59) + this.ValidationStatus.GetHashCode();
                if (this.UnableToValidateReason != null)
                {
                    hashCode = (hashCode * 59) + this.UnableToValidateReason.GetHashCode();
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
