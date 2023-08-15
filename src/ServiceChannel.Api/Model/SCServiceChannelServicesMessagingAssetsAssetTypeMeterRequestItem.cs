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
    /// Object with an asset type meter details.
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.Assets.AssetTypeMeterRequestItem")]
    public partial class SCServiceChannelServicesMessagingAssetsAssetTypeMeterRequestItem : IEquatable<SCServiceChannelServicesMessagingAssetsAssetTypeMeterRequestItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingAssetsAssetTypeMeterRequestItem" /> class.
        /// </summary>
        /// <param name="id">Unique numeric identifier of an asset type meter..</param>
        /// <param name="name">Asset type meter name given by a user..</param>
        /// <param name="maxValue">Maximum value that a user can enter when recording a meter reading on an asset..</param>
        /// <param name="notes">Comment added to a meter when creating or editing an asset type meter..</param>
        /// <param name="inactive">Defines whether a meter is active or has been deactivated. **Possible values:** *true*, *false*. Note that readings can be recorded for active meters only. (default to false).</param>
        /// <param name="editOnWO">Defines whether a user can record asset meter readings on a work order via Dashboard. **Possible values:** *true*, *false*. (default to false).</param>
        /// <param name="assetTypeId">Unique numeric identifier of an asset type..</param>
        /// <param name="unitOfMeasure">Number of the unit of measure associated with a meter. This is a sequence number of the unit of measure as it is listed in the overlay for creating a meter..</param>
        public SCServiceChannelServicesMessagingAssetsAssetTypeMeterRequestItem(int id = default(int), string name = default(string), string maxValue = default(string), string notes = default(string), bool inactive = false, bool editOnWO = false, int assetTypeId = default(int), int unitOfMeasure = default(int))
        {
            this.Id = id;
            this.Name = name;
            this.MaxValue = maxValue;
            this.Notes = notes;
            this.Inactive = inactive;
            this.EditOnWO = editOnWO;
            this.AssetTypeId = assetTypeId;
            this.UnitOfMeasure = unitOfMeasure;
        }

        /// <summary>
        /// Unique numeric identifier of an asset type meter.
        /// </summary>
        /// <value>Unique numeric identifier of an asset type meter.</value>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Asset type meter name given by a user.
        /// </summary>
        /// <value>Asset type meter name given by a user.</value>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Maximum value that a user can enter when recording a meter reading on an asset.
        /// </summary>
        /// <value>Maximum value that a user can enter when recording a meter reading on an asset.</value>
        [DataMember(Name = "MaxValue", EmitDefaultValue = false)]
        public string MaxValue { get; set; }

        /// <summary>
        /// Comment added to a meter when creating or editing an asset type meter.
        /// </summary>
        /// <value>Comment added to a meter when creating or editing an asset type meter.</value>
        [DataMember(Name = "Notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

        /// <summary>
        /// Defines whether a meter is active or has been deactivated. **Possible values:** *true*, *false*. Note that readings can be recorded for active meters only.
        /// </summary>
        /// <value>Defines whether a meter is active or has been deactivated. **Possible values:** *true*, *false*. Note that readings can be recorded for active meters only.</value>
        [DataMember(Name = "Inactive", EmitDefaultValue = true)]
        public bool Inactive { get; set; }

        /// <summary>
        /// Defines whether a user can record asset meter readings on a work order via Dashboard. **Possible values:** *true*, *false*.
        /// </summary>
        /// <value>Defines whether a user can record asset meter readings on a work order via Dashboard. **Possible values:** *true*, *false*.</value>
        [DataMember(Name = "EditOnWO", EmitDefaultValue = true)]
        public bool EditOnWO { get; set; }

        /// <summary>
        /// Unique numeric identifier of an asset type.
        /// </summary>
        /// <value>Unique numeric identifier of an asset type.</value>
        [DataMember(Name = "AssetTypeId", EmitDefaultValue = false)]
        public int AssetTypeId { get; set; }

        /// <summary>
        /// Number of the unit of measure associated with a meter. This is a sequence number of the unit of measure as it is listed in the overlay for creating a meter.
        /// </summary>
        /// <value>Number of the unit of measure associated with a meter. This is a sequence number of the unit of measure as it is listed in the overlay for creating a meter.</value>
        [DataMember(Name = "UnitOfMeasure", EmitDefaultValue = false)]
        public int UnitOfMeasure { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingAssetsAssetTypeMeterRequestItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MaxValue: ").Append(MaxValue).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Inactive: ").Append(Inactive).Append("\n");
            sb.Append("  EditOnWO: ").Append(EditOnWO).Append("\n");
            sb.Append("  AssetTypeId: ").Append(AssetTypeId).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingAssetsAssetTypeMeterRequestItem);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingAssetsAssetTypeMeterRequestItem instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingAssetsAssetTypeMeterRequestItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingAssetsAssetTypeMeterRequestItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.MaxValue == input.MaxValue ||
                    (this.MaxValue != null &&
                    this.MaxValue.Equals(input.MaxValue))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.Inactive == input.Inactive ||
                    this.Inactive.Equals(input.Inactive)
                ) && 
                (
                    this.EditOnWO == input.EditOnWO ||
                    this.EditOnWO.Equals(input.EditOnWO)
                ) && 
                (
                    this.AssetTypeId == input.AssetTypeId ||
                    this.AssetTypeId.Equals(input.AssetTypeId)
                ) && 
                (
                    this.UnitOfMeasure == input.UnitOfMeasure ||
                    this.UnitOfMeasure.Equals(input.UnitOfMeasure)
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.MaxValue != null)
                {
                    hashCode = (hashCode * 59) + this.MaxValue.GetHashCode();
                }
                if (this.Notes != null)
                {
                    hashCode = (hashCode * 59) + this.Notes.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Inactive.GetHashCode();
                hashCode = (hashCode * 59) + this.EditOnWO.GetHashCode();
                hashCode = (hashCode * 59) + this.AssetTypeId.GetHashCode();
                hashCode = (hashCode * 59) + this.UnitOfMeasure.GetHashCode();
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
