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
    /// Object containing the asset meter reading details to add.
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.Assets.AddAssetMeterReadingRequestItem")]
    public partial class SCServiceChannelServicesMessagingAssetsAddAssetMeterReadingRequestItem : IEquatable<SCServiceChannelServicesMessagingAssetsAddAssetMeterReadingRequestItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingAssetsAddAssetMeterReadingRequestItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SCServiceChannelServicesMessagingAssetsAddAssetMeterReadingRequestItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingAssetsAddAssetMeterReadingRequestItem" /> class.
        /// </summary>
        /// <param name="assetId">Unique numeric asset identifier. (required).</param>
        /// <param name="assetMeterId">Unique numeric asset meter identifier..</param>
        /// <param name="assetTypeMeterId">Unique numeric asset type meter identifier..</param>
        /// <param name="value">Value that a user enters when recording a meter reading on an asset. (required).</param>
        /// <param name="notes">Comment added when creating an asset meter reading. (required).</param>
        /// <param name="trackingNumber">Tracking number of a work order an asset is assigned to..</param>
        /// <param name="updatedDate">Date and time when an asset meter reading is updated. (required).</param>
        public SCServiceChannelServicesMessagingAssetsAddAssetMeterReadingRequestItem(int assetId = default(int), int assetMeterId = default(int), int assetTypeMeterId = default(int), double value = default(double), string notes = default(string), int trackingNumber = default(int), DateTime updatedDate = default(DateTime))
        {
            this.AssetId = assetId;
            this.Value = value;
            // to ensure "notes" is required (not null)
            if (notes == null)
            {
                throw new ArgumentNullException("notes is a required property for SCServiceChannelServicesMessagingAssetsAddAssetMeterReadingRequestItem and cannot be null");
            }
            this.Notes = notes;
            this.UpdatedDate = updatedDate;
            this.AssetMeterId = assetMeterId;
            this.AssetTypeMeterId = assetTypeMeterId;
            this.TrackingNumber = trackingNumber;
        }

        /// <summary>
        /// Unique numeric asset identifier.
        /// </summary>
        /// <value>Unique numeric asset identifier.</value>
        [DataMember(Name = "AssetId", IsRequired = true, EmitDefaultValue = true)]
        public int AssetId { get; set; }

        /// <summary>
        /// Unique numeric asset meter identifier.
        /// </summary>
        /// <value>Unique numeric asset meter identifier.</value>
        [DataMember(Name = "AssetMeterId", EmitDefaultValue = false)]
        public int AssetMeterId { get; set; }

        /// <summary>
        /// Unique numeric asset type meter identifier.
        /// </summary>
        /// <value>Unique numeric asset type meter identifier.</value>
        [DataMember(Name = "AssetTypeMeterId", EmitDefaultValue = false)]
        public int AssetTypeMeterId { get; set; }

        /// <summary>
        /// Value that a user enters when recording a meter reading on an asset.
        /// </summary>
        /// <value>Value that a user enters when recording a meter reading on an asset.</value>
        [DataMember(Name = "Value", IsRequired = true, EmitDefaultValue = true)]
        public double Value { get; set; }

        /// <summary>
        /// Comment added when creating an asset meter reading.
        /// </summary>
        /// <value>Comment added when creating an asset meter reading.</value>
        [DataMember(Name = "Notes", IsRequired = true, EmitDefaultValue = true)]
        public string Notes { get; set; }

        /// <summary>
        /// Tracking number of a work order an asset is assigned to.
        /// </summary>
        /// <value>Tracking number of a work order an asset is assigned to.</value>
        [DataMember(Name = "TrackingNumber", EmitDefaultValue = false)]
        public int TrackingNumber { get; set; }

        /// <summary>
        /// Date and time when an asset meter reading is updated.
        /// </summary>
        /// <value>Date and time when an asset meter reading is updated.</value>
        [DataMember(Name = "UpdatedDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingAssetsAddAssetMeterReadingRequestItem {\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  AssetMeterId: ").Append(AssetMeterId).Append("\n");
            sb.Append("  AssetTypeMeterId: ").Append(AssetTypeMeterId).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  TrackingNumber: ").Append(TrackingNumber).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingAssetsAddAssetMeterReadingRequestItem);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingAssetsAddAssetMeterReadingRequestItem instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingAssetsAddAssetMeterReadingRequestItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingAssetsAddAssetMeterReadingRequestItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AssetId == input.AssetId ||
                    this.AssetId.Equals(input.AssetId)
                ) && 
                (
                    this.AssetMeterId == input.AssetMeterId ||
                    this.AssetMeterId.Equals(input.AssetMeterId)
                ) && 
                (
                    this.AssetTypeMeterId == input.AssetTypeMeterId ||
                    this.AssetTypeMeterId.Equals(input.AssetTypeMeterId)
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.TrackingNumber == input.TrackingNumber ||
                    this.TrackingNumber.Equals(input.TrackingNumber)
                ) && 
                (
                    this.UpdatedDate == input.UpdatedDate ||
                    (this.UpdatedDate != null &&
                    this.UpdatedDate.Equals(input.UpdatedDate))
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
                hashCode = (hashCode * 59) + this.AssetId.GetHashCode();
                hashCode = (hashCode * 59) + this.AssetMeterId.GetHashCode();
                hashCode = (hashCode * 59) + this.AssetTypeMeterId.GetHashCode();
                hashCode = (hashCode * 59) + this.Value.GetHashCode();
                if (this.Notes != null)
                {
                    hashCode = (hashCode * 59) + this.Notes.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TrackingNumber.GetHashCode();
                if (this.UpdatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedDate.GetHashCode();
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