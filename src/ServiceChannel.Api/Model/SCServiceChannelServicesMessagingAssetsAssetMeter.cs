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
    /// Asset meter object.
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.Assets.AssetMeter")]
    public partial class SCServiceChannelServicesMessagingAssetsAssetMeter : IEquatable<SCServiceChannelServicesMessagingAssetsAssetMeter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingAssetsAssetMeter" /> class.
        /// </summary>
        /// <param name="id">Unique numeric identifier of an asset meter..</param>
        /// <param name="assetTypeMeterId">Unique numeric identifier of the asset type meter..</param>
        /// <param name="assetId">Unique numeric asset identifier..</param>
        /// <param name="meterTypeName">Name of an asset type meter..</param>
        public SCServiceChannelServicesMessagingAssetsAssetMeter(int id = default(int), int assetTypeMeterId = default(int), int assetId = default(int), string meterTypeName = default(string))
        {
            this.Id = id;
            this.AssetTypeMeterId = assetTypeMeterId;
            this.AssetId = assetId;
            this.MeterTypeName = meterTypeName;
        }

        /// <summary>
        /// Unique numeric identifier of an asset meter.
        /// </summary>
        /// <value>Unique numeric identifier of an asset meter.</value>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Unique numeric identifier of the asset type meter.
        /// </summary>
        /// <value>Unique numeric identifier of the asset type meter.</value>
        [DataMember(Name = "AssetTypeMeterId", EmitDefaultValue = false)]
        public int AssetTypeMeterId { get; set; }

        /// <summary>
        /// Unique numeric asset identifier.
        /// </summary>
        /// <value>Unique numeric asset identifier.</value>
        [DataMember(Name = "AssetId", EmitDefaultValue = false)]
        public int AssetId { get; set; }

        /// <summary>
        /// Name of an asset type meter.
        /// </summary>
        /// <value>Name of an asset type meter.</value>
        [DataMember(Name = "MeterTypeName", EmitDefaultValue = false)]
        public string MeterTypeName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingAssetsAssetMeter {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AssetTypeMeterId: ").Append(AssetTypeMeterId).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  MeterTypeName: ").Append(MeterTypeName).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingAssetsAssetMeter);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingAssetsAssetMeter instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingAssetsAssetMeter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingAssetsAssetMeter input)
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
                    this.AssetTypeMeterId == input.AssetTypeMeterId ||
                    this.AssetTypeMeterId.Equals(input.AssetTypeMeterId)
                ) && 
                (
                    this.AssetId == input.AssetId ||
                    this.AssetId.Equals(input.AssetId)
                ) && 
                (
                    this.MeterTypeName == input.MeterTypeName ||
                    (this.MeterTypeName != null &&
                    this.MeterTypeName.Equals(input.MeterTypeName))
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
                hashCode = (hashCode * 59) + this.AssetTypeMeterId.GetHashCode();
                hashCode = (hashCode * 59) + this.AssetId.GetHashCode();
                if (this.MeterTypeName != null)
                {
                    hashCode = (hashCode * 59) + this.MeterTypeName.GetHashCode();
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
