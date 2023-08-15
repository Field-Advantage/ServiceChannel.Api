/*
 * ServiceChannel API - v.3
 *
 * The ServiceChannel API is a RESTful and stateless API. It accepts standard HTTP verbs and supports OAuth 2.0 for authorizing requests.      Our API returns common HTTP status codes as well as JSON encapsulated data.      See [API Overview](https://developer.servicechannel.com/basics/introduction/overview/) for the intro to ServiceChannel API.<br>      <h3>Authentication and Authorization</h3>You should have a ServiceChannel account, register your application, and obtain `access_token` to integrate with our API.      See [Authentication and Authorization](https://developer.servicechannel.com/basics/general/authentication/) for more information.      To use this API playground, click **Authorize** and sign in to ServiceChannel.<br>      <h3>Environment</h3> All calls in this API Reference point to the **SB2 environment**.      See [Environments](https://developer.servicechannel.com/basics/general/environments/) for more information.<br>      <h3>API Version</h3>The current stable version of the ServiceChannel API is `v3`. In the request URL, `v3` is a version prefix that should be present.      When you omit the version prefix, calls point to the minimum supported version of the API.      We recommend you to always specify the API version to avoid possible errors.
 *
 * The version of the OpenAPI document: 3
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json;
using ServiceChannel.OpenAPIGenerated.Api.Converters;

namespace ServiceChannel.OpenAPIGenerated.Api.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class SCServiceChannelNotificationsObjectsAssetTagScanAuditRecord : IEquatable<SCServiceChannelNotificationsObjectsAssetTagScanAuditRecord>
    {
        /// <summary>
        /// Gets or Sets AssetTagStatus
        /// </summary>
        [DataMember(Name="AssetTagStatus", EmitDefaultValue=false)]
        public string AssetTagStatus { get; set; }

        /// <summary>
        /// Gets or Sets ManuallyEntered
        /// </summary>
        [DataMember(Name="ManuallyEntered", EmitDefaultValue=true)]
        public bool ManuallyEntered { get; set; } = false;

        /// <summary>
        /// Gets or Sets AssetTagNotScannedReason
        /// </summary>
        [DataMember(Name="AssetTagNotScannedReason", EmitDefaultValue=false)]
        public string AssetTagNotScannedReason { get; set; }

        /// <summary>
        /// Gets or Sets UnableToValidateReasonId
        /// </summary>
        [DataMember(Name="UnableToValidateReasonId", EmitDefaultValue=true)]
        public int UnableToValidateReasonId { get; set; }

        /// <summary>
        /// Gets or Sets OtherReason
        /// </summary>
        [DataMember(Name="OtherReason", EmitDefaultValue=false)]
        public string OtherReason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
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
        public string ToJson()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            return JsonSerializer.Serialize(this, options);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((SCServiceChannelNotificationsObjectsAssetTagScanAuditRecord)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelNotificationsObjectsAssetTagScanAuditRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelNotificationsObjectsAssetTagScanAuditRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelNotificationsObjectsAssetTagScanAuditRecord other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AssetTagStatus == other.AssetTagStatus ||
                    AssetTagStatus != null &&
                    AssetTagStatus.Equals(other.AssetTagStatus)
                ) && 
                (
                    ManuallyEntered == other.ManuallyEntered ||
                    
                    ManuallyEntered.Equals(other.ManuallyEntered)
                ) && 
                (
                    AssetTagNotScannedReason == other.AssetTagNotScannedReason ||
                    AssetTagNotScannedReason != null &&
                    AssetTagNotScannedReason.Equals(other.AssetTagNotScannedReason)
                ) && 
                (
                    UnableToValidateReasonId == other.UnableToValidateReasonId ||
                    
                    UnableToValidateReasonId.Equals(other.UnableToValidateReasonId)
                ) && 
                (
                    OtherReason == other.OtherReason ||
                    OtherReason != null &&
                    OtherReason.Equals(other.OtherReason)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (AssetTagStatus != null)
                    hashCode = hashCode * 59 + AssetTagStatus.GetHashCode();
                    
                    hashCode = hashCode * 59 + ManuallyEntered.GetHashCode();
                    if (AssetTagNotScannedReason != null)
                    hashCode = hashCode * 59 + AssetTagNotScannedReason.GetHashCode();
                    
                    hashCode = hashCode * 59 + UnableToValidateReasonId.GetHashCode();
                    if (OtherReason != null)
                    hashCode = hashCode * 59 + OtherReason.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelNotificationsObjectsAssetTagScanAuditRecord left, SCServiceChannelNotificationsObjectsAssetTagScanAuditRecord right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelNotificationsObjectsAssetTagScanAuditRecord left, SCServiceChannelNotificationsObjectsAssetTagScanAuditRecord right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}