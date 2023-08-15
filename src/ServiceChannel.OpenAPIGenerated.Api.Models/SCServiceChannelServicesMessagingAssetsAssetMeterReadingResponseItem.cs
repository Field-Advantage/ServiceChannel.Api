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
    /// Asset type meter object.
    /// </summary>
    [DataContract]
    public class SCServiceChannelServicesMessagingAssetsAssetMeterReadingResponseItem : IEquatable<SCServiceChannelServicesMessagingAssetsAssetMeterReadingResponseItem>
    {
        /// <summary>
        /// Unique asset meter reading identifier.
        /// </summary>
        /// <value>Unique asset meter reading identifier.</value>
        [DataMember(Name="Id", EmitDefaultValue=true)]
        public int Id { get; set; }

        /// <summary>
        /// Unique numeric asset meter identifier.
        /// </summary>
        /// <value>Unique numeric asset meter identifier.</value>
        [DataMember(Name="AssetMeterId", EmitDefaultValue=true)]
        public int AssetMeterId { get; set; }

        /// <summary>
        /// Unique numeric identifier of the asset type meter.
        /// </summary>
        /// <value>Unique numeric identifier of the asset type meter.</value>
        [DataMember(Name="AssetTypeMeterId", EmitDefaultValue=true)]
        public int AssetTypeMeterId { get; set; }

        /// <summary>
        /// Name of an asset type meter.
        /// </summary>
        /// <value>Name of an asset type meter.</value>
        [DataMember(Name="AssetTypeMeterName", EmitDefaultValue=false)]
        public string AssetTypeMeterName { get; set; }

        /// <summary>
        /// Number of the unit of measure associated with a meter. This is a sequence number of the unit of measure as it is listed in the overlay for creating a meter.
        /// </summary>
        /// <value>Number of the unit of measure associated with a meter. This is a sequence number of the unit of measure as it is listed in the overlay for creating a meter.</value>
        [DataMember(Name="UnitOfMeasureId", EmitDefaultValue=true)]
        public int UnitOfMeasureId { get; set; }

        /// <summary>
        /// Name of a unit of measure.
        /// </summary>
        /// <value>Name of a unit of measure.</value>
        [DataMember(Name="UnitOfMeasureName", EmitDefaultValue=false)]
        public string UnitOfMeasureName { get; set; }

        /// <summary>
        /// Value that a user enters when recording a meter reading on an asset.
        /// </summary>
        /// <value>Value that a user enters when recording a meter reading on an asset.</value>
        [DataMember(Name="Value", EmitDefaultValue=true)]
        public double Value { get; set; }

        /// <summary>
        /// Tracking number of a work order an asset is assigned to.
        /// </summary>
        /// <value>Tracking number of a work order an asset is assigned to.</value>
        [DataMember(Name="TrackingNumber", EmitDefaultValue=true)]
        public int TrackingNumber { get; set; }

        /// <summary>
        /// Comment added when creating an asset meter reading.
        /// </summary>
        /// <value>Comment added when creating an asset meter reading.</value>
        [DataMember(Name="Notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// ID of a user who added an asset meter reading.
        /// </summary>
        /// <value>ID of a user who added an asset meter reading.</value>
        [DataMember(Name="UpdatedBy", EmitDefaultValue=true)]
        public int UpdatedBy { get; set; }

        /// <summary>
        /// Username of an employee who added an asset meter reading.
        /// </summary>
        /// <value>Username of an employee who added an asset meter reading.</value>
        [DataMember(Name="UpdatedByUserName", EmitDefaultValue=false)]
        public string UpdatedByUserName { get; set; }

        /// <summary>
        /// Date and time when an asset meter reading was added.
        /// </summary>
        /// <value>Date and time when an asset meter reading was added.</value>
        [DataMember(Name="UpdatedDate", EmitDefaultValue=false)]
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingAssetsAssetMeterReadingResponseItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AssetMeterId: ").Append(AssetMeterId).Append("\n");
            sb.Append("  AssetTypeMeterId: ").Append(AssetTypeMeterId).Append("\n");
            sb.Append("  AssetTypeMeterName: ").Append(AssetTypeMeterName).Append("\n");
            sb.Append("  UnitOfMeasureId: ").Append(UnitOfMeasureId).Append("\n");
            sb.Append("  UnitOfMeasureName: ").Append(UnitOfMeasureName).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  TrackingNumber: ").Append(TrackingNumber).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  UpdatedByUserName: ").Append(UpdatedByUserName).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingAssetsAssetMeterReadingResponseItem)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingAssetsAssetMeterReadingResponseItem instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingAssetsAssetMeterReadingResponseItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingAssetsAssetMeterReadingResponseItem other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    AssetMeterId == other.AssetMeterId ||
                    
                    AssetMeterId.Equals(other.AssetMeterId)
                ) && 
                (
                    AssetTypeMeterId == other.AssetTypeMeterId ||
                    
                    AssetTypeMeterId.Equals(other.AssetTypeMeterId)
                ) && 
                (
                    AssetTypeMeterName == other.AssetTypeMeterName ||
                    AssetTypeMeterName != null &&
                    AssetTypeMeterName.Equals(other.AssetTypeMeterName)
                ) && 
                (
                    UnitOfMeasureId == other.UnitOfMeasureId ||
                    
                    UnitOfMeasureId.Equals(other.UnitOfMeasureId)
                ) && 
                (
                    UnitOfMeasureName == other.UnitOfMeasureName ||
                    UnitOfMeasureName != null &&
                    UnitOfMeasureName.Equals(other.UnitOfMeasureName)
                ) && 
                (
                    Value == other.Value ||
                    
                    Value.Equals(other.Value)
                ) && 
                (
                    TrackingNumber == other.TrackingNumber ||
                    
                    TrackingNumber.Equals(other.TrackingNumber)
                ) && 
                (
                    Notes == other.Notes ||
                    Notes != null &&
                    Notes.Equals(other.Notes)
                ) && 
                (
                    UpdatedBy == other.UpdatedBy ||
                    
                    UpdatedBy.Equals(other.UpdatedBy)
                ) && 
                (
                    UpdatedByUserName == other.UpdatedByUserName ||
                    UpdatedByUserName != null &&
                    UpdatedByUserName.Equals(other.UpdatedByUserName)
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
                    
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    
                    hashCode = hashCode * 59 + AssetMeterId.GetHashCode();
                    
                    hashCode = hashCode * 59 + AssetTypeMeterId.GetHashCode();
                    if (AssetTypeMeterName != null)
                    hashCode = hashCode * 59 + AssetTypeMeterName.GetHashCode();
                    
                    hashCode = hashCode * 59 + UnitOfMeasureId.GetHashCode();
                    if (UnitOfMeasureName != null)
                    hashCode = hashCode * 59 + UnitOfMeasureName.GetHashCode();
                    
                    hashCode = hashCode * 59 + Value.GetHashCode();
                    
                    hashCode = hashCode * 59 + TrackingNumber.GetHashCode();
                    if (Notes != null)
                    hashCode = hashCode * 59 + Notes.GetHashCode();
                    
                    hashCode = hashCode * 59 + UpdatedBy.GetHashCode();
                    if (UpdatedByUserName != null)
                    hashCode = hashCode * 59 + UpdatedByUserName.GetHashCode();
                    if (UpdatedDate != null)
                    hashCode = hashCode * 59 + UpdatedDate.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingAssetsAssetMeterReadingResponseItem left, SCServiceChannelServicesMessagingAssetsAssetMeterReadingResponseItem right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingAssetsAssetMeterReadingResponseItem left, SCServiceChannelServicesMessagingAssetsAssetMeterReadingResponseItem right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
