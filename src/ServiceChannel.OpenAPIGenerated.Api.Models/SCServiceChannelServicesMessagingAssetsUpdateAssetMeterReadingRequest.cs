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
    /// Object containing the asset meter reading details to update.
    /// </summary>
    [DataContract]
    public class SCServiceChannelServicesMessagingAssetsUpdateAssetMeterReadingRequest : IEquatable<SCServiceChannelServicesMessagingAssetsUpdateAssetMeterReadingRequest>
    {
        /// <summary>
        /// Unique asset meter reading identifier.
        /// </summary>
        /// <value>Unique asset meter reading identifier.</value>
        [DataMember(Name="AssetMeterReadingId", EmitDefaultValue=true)]
        public int AssetMeterReadingId { get; set; }

        /// <summary>
        /// Value that a user enters when recording a meter reading on an asset.
        /// </summary>
        /// <value>Value that a user enters when recording a meter reading on an asset.</value>
        [DataMember(Name="Value", EmitDefaultValue=true)]
        public double Value { get; set; }

        /// <summary>
        /// Comment added when creating an asset meter reading.
        /// </summary>
        /// <value>Comment added when creating an asset meter reading.</value>
        [DataMember(Name="Notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Date and time when an asset meter reading is updated.
        /// </summary>
        /// <value>Date and time when an asset meter reading is updated.</value>
        [DataMember(Name="UpdatedDate", EmitDefaultValue=false)]
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingAssetsUpdateAssetMeterReadingRequest {\n");
            sb.Append("  AssetMeterReadingId: ").Append(AssetMeterReadingId).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingAssetsUpdateAssetMeterReadingRequest)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingAssetsUpdateAssetMeterReadingRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingAssetsUpdateAssetMeterReadingRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingAssetsUpdateAssetMeterReadingRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AssetMeterReadingId == other.AssetMeterReadingId ||
                    
                    AssetMeterReadingId.Equals(other.AssetMeterReadingId)
                ) && 
                (
                    Value == other.Value ||
                    
                    Value.Equals(other.Value)
                ) && 
                (
                    Notes == other.Notes ||
                    Notes != null &&
                    Notes.Equals(other.Notes)
                ) && 
                (
                    UpdatedDate == other.UpdatedDate ||
                    UpdatedDate != null &&
                    UpdatedDate.Equals(other.UpdatedDate)
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
                    
                    hashCode = hashCode * 59 + AssetMeterReadingId.GetHashCode();
                    
                    hashCode = hashCode * 59 + Value.GetHashCode();
                    if (Notes != null)
                    hashCode = hashCode * 59 + Notes.GetHashCode();
                    if (UpdatedDate != null)
                    hashCode = hashCode * 59 + UpdatedDate.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingAssetsUpdateAssetMeterReadingRequest left, SCServiceChannelServicesMessagingAssetsUpdateAssetMeterReadingRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingAssetsUpdateAssetMeterReadingRequest left, SCServiceChannelServicesMessagingAssetsUpdateAssetMeterReadingRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
