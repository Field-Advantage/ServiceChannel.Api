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
    /// SCServiceChannelNotificationsObjectsAssetTagScanAuditRecord
    /// </summary>
    [DataContract(Name = "ServiceChannel.Notifications.Objects.AssetTagScanAuditRecord")]
    public partial class SCServiceChannelNotificationsObjectsAssetTagScanAuditRecord : IEquatable<SCServiceChannelNotificationsObjectsAssetTagScanAuditRecord>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelNotificationsObjectsAssetTagScanAuditRecord" /> class.
        /// </summary>
        /// <param name="assetTagStatus">assetTagStatus.</param>
        /// <param name="manuallyEntered">manuallyEntered (default to false).</param>
        /// <param name="assetTagNotScannedReason">assetTagNotScannedReason.</param>
        /// <param name="unableToValidateReasonId">unableToValidateReasonId.</param>
        /// <param name="otherReason">otherReason.</param>
        public SCServiceChannelNotificationsObjectsAssetTagScanAuditRecord(string assetTagStatus = default(string), bool manuallyEntered = false, string assetTagNotScannedReason = default(string), int unableToValidateReasonId = default(int), string otherReason = default(string))
        {
            this.AssetTagStatus = assetTagStatus;
            this.ManuallyEntered = manuallyEntered;
            this.AssetTagNotScannedReason = assetTagNotScannedReason;
            this.UnableToValidateReasonId = unableToValidateReasonId;
            this.OtherReason = otherReason;
        }

        /// <summary>
        /// Gets or Sets AssetTagStatus
        /// </summary>
        [DataMember(Name = "AssetTagStatus", EmitDefaultValue = false)]
        public string AssetTagStatus { get; set; }

        /// <summary>
        /// Gets or Sets ManuallyEntered
        /// </summary>
        [DataMember(Name = "ManuallyEntered", EmitDefaultValue = true)]
        public bool ManuallyEntered { get; set; }

        /// <summary>
        /// Gets or Sets AssetTagNotScannedReason
        /// </summary>
        [DataMember(Name = "AssetTagNotScannedReason", EmitDefaultValue = false)]
        public string AssetTagNotScannedReason { get; set; }

        /// <summary>
        /// Gets or Sets UnableToValidateReasonId
        /// </summary>
        [DataMember(Name = "UnableToValidateReasonId", EmitDefaultValue = false)]
        public int UnableToValidateReasonId { get; set; }

        /// <summary>
        /// Gets or Sets OtherReason
        /// </summary>
        [DataMember(Name = "OtherReason", EmitDefaultValue = false)]
        public string OtherReason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelNotificationsObjectsAssetTagScanAuditRecord {\n");
            sb.Append("  AssetTagStatus: ").Append(AssetTagStatus).Append("\n");
            sb.Append("  ManuallyEntered: ").Append(ManuallyEntered).Append("\n");
            sb.Append("  AssetTagNotScannedReason: ").Append(AssetTagNotScannedReason).Append("\n");
            sb.Append("  UnableToValidateReasonId: ").Append(UnableToValidateReasonId).Append("\n");
            sb.Append("  OtherReason: ").Append(OtherReason).Append("\n");
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
            return this.Equals(input as SCServiceChannelNotificationsObjectsAssetTagScanAuditRecord);
        }

        /// <summary>
        /// Returns true if SCServiceChannelNotificationsObjectsAssetTagScanAuditRecord instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelNotificationsObjectsAssetTagScanAuditRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelNotificationsObjectsAssetTagScanAuditRecord input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AssetTagStatus == input.AssetTagStatus ||
                    (this.AssetTagStatus != null &&
                    this.AssetTagStatus.Equals(input.AssetTagStatus))
                ) && 
                (
                    this.ManuallyEntered == input.ManuallyEntered ||
                    this.ManuallyEntered.Equals(input.ManuallyEntered)
                ) && 
                (
                    this.AssetTagNotScannedReason == input.AssetTagNotScannedReason ||
                    (this.AssetTagNotScannedReason != null &&
                    this.AssetTagNotScannedReason.Equals(input.AssetTagNotScannedReason))
                ) && 
                (
                    this.UnableToValidateReasonId == input.UnableToValidateReasonId ||
                    this.UnableToValidateReasonId.Equals(input.UnableToValidateReasonId)
                ) && 
                (
                    this.OtherReason == input.OtherReason ||
                    (this.OtherReason != null &&
                    this.OtherReason.Equals(input.OtherReason))
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
                if (this.AssetTagStatus != null)
                {
                    hashCode = (hashCode * 59) + this.AssetTagStatus.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ManuallyEntered.GetHashCode();
                if (this.AssetTagNotScannedReason != null)
                {
                    hashCode = (hashCode * 59) + this.AssetTagNotScannedReason.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UnableToValidateReasonId.GetHashCode();
                if (this.OtherReason != null)
                {
                    hashCode = (hashCode * 59) + this.OtherReason.GetHashCode();
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
