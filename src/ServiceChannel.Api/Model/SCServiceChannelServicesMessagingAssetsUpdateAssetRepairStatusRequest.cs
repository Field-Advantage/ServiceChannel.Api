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
    /// SCServiceChannelServicesMessagingAssetsUpdateAssetRepairStatusRequest
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.Assets.UpdateAssetRepairStatusRequest")]
    public partial class SCServiceChannelServicesMessagingAssetsUpdateAssetRepairStatusRequest : IEquatable<SCServiceChannelServicesMessagingAssetsUpdateAssetRepairStatusRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum InUse for value: InUse
            /// </summary>
            [EnumMember(Value = "InUse")]
            InUse = 1,

            /// <summary>
            /// Enum OutForRepair for value: OutForRepair
            /// </summary>
            [EnumMember(Value = "OutForRepair")]
            OutForRepair = 2,

            /// <summary>
            /// Enum ReplacementRecommended for value: ReplacementRecommended
            /// </summary>
            [EnumMember(Value = "ReplacementRecommended")]
            ReplacementRecommended = 3,

            /// <summary>
            /// Enum Repaired for value: Repaired
            /// </summary>
            [EnumMember(Value = "Repaired")]
            Repaired = 4

        }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "Status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingAssetsUpdateAssetRepairStatusRequest" /> class.
        /// </summary>
        /// <param name="assetId">assetId.</param>
        /// <param name="status">status.</param>
        /// <param name="description">description.</param>
        /// <param name="updatedByApplication">updatedByApplication.</param>
        /// <param name="replacedByEquipmentId">replacedByEquipmentId.</param>
        /// <param name="assetForReplacement">assetForReplacement.</param>
        public SCServiceChannelServicesMessagingAssetsUpdateAssetRepairStatusRequest(int assetId = default(int), StatusEnum? status = default(StatusEnum?), string description = default(string), byte[] updatedByApplication = default(byte[]), int replacedByEquipmentId = default(int), SCServiceChannelServicesMessagingAssetsAssetForReplacement assetForReplacement = default(SCServiceChannelServicesMessagingAssetsAssetForReplacement))
        {
            this.AssetId = assetId;
            this.Status = status;
            this.Description = description;
            this.UpdatedByApplication = updatedByApplication;
            this.ReplacedByEquipmentId = replacedByEquipmentId;
            this.AssetForReplacement = assetForReplacement;
        }

        /// <summary>
        /// Gets or Sets AssetId
        /// </summary>
        [DataMember(Name = "AssetId", EmitDefaultValue = false)]
        public int AssetId { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "Description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedByApplication
        /// </summary>
        [DataMember(Name = "UpdatedByApplication", EmitDefaultValue = false)]
        public byte[] UpdatedByApplication { get; set; }

        /// <summary>
        /// Gets or Sets ReplacedByEquipmentId
        /// </summary>
        [DataMember(Name = "ReplacedByEquipmentId", EmitDefaultValue = false)]
        public int ReplacedByEquipmentId { get; set; }

        /// <summary>
        /// Gets or Sets AssetForReplacement
        /// </summary>
        [DataMember(Name = "AssetForReplacement", EmitDefaultValue = false)]
        public SCServiceChannelServicesMessagingAssetsAssetForReplacement AssetForReplacement { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingAssetsUpdateAssetRepairStatusRequest {\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  UpdatedByApplication: ").Append(UpdatedByApplication).Append("\n");
            sb.Append("  ReplacedByEquipmentId: ").Append(ReplacedByEquipmentId).Append("\n");
            sb.Append("  AssetForReplacement: ").Append(AssetForReplacement).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingAssetsUpdateAssetRepairStatusRequest);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingAssetsUpdateAssetRepairStatusRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingAssetsUpdateAssetRepairStatusRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingAssetsUpdateAssetRepairStatusRequest input)
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
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.UpdatedByApplication == input.UpdatedByApplication ||
                    (this.UpdatedByApplication != null &&
                    this.UpdatedByApplication.Equals(input.UpdatedByApplication))
                ) && 
                (
                    this.ReplacedByEquipmentId == input.ReplacedByEquipmentId ||
                    this.ReplacedByEquipmentId.Equals(input.ReplacedByEquipmentId)
                ) && 
                (
                    this.AssetForReplacement == input.AssetForReplacement ||
                    (this.AssetForReplacement != null &&
                    this.AssetForReplacement.Equals(input.AssetForReplacement))
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
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.UpdatedByApplication != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedByApplication.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ReplacedByEquipmentId.GetHashCode();
                if (this.AssetForReplacement != null)
                {
                    hashCode = (hashCode * 59) + this.AssetForReplacement.GetHashCode();
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