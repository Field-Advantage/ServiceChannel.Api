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
    /// SCServiceChannelServicesMessagingEquipmentsSearchAssetsByGroupIDRequest
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.Equipments.SearchAssetsByGroupIDRequest")]
    public partial class SCServiceChannelServicesMessagingEquipmentsSearchAssetsByGroupIDRequest : IEquatable<SCServiceChannelServicesMessagingEquipmentsSearchAssetsByGroupIDRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingEquipmentsSearchAssetsByGroupIDRequest" /> class.
        /// </summary>
        /// <param name="subscriberId">subscriberId.</param>
        /// <param name="locationId">locationId.</param>
        /// <param name="searchByText">searchByText.</param>
        /// <param name="assetTypeGroupIds">assetTypeGroupIds.</param>
        /// <param name="assetTypes">assetTypes.</param>
        /// <param name="startIndex">startIndex.</param>
        /// <param name="pageSize">pageSize.</param>
        /// <param name="uncategorizedOnly">uncategorizedOnly (default to false).</param>
        /// <param name="includeTotalCostOfOwnership">includeTotalCostOfOwnership (default to false).</param>
        public SCServiceChannelServicesMessagingEquipmentsSearchAssetsByGroupIDRequest(int subscriberId = default(int), int locationId = default(int), string searchByText = default(string), List<int> assetTypeGroupIds = default(List<int>), List<int> assetTypes = default(List<int>), int startIndex = default(int), int pageSize = default(int), bool uncategorizedOnly = false, bool includeTotalCostOfOwnership = false)
        {
            this.SubscriberId = subscriberId;
            this.LocationId = locationId;
            this.SearchByText = searchByText;
            this.AssetTypeGroupIds = assetTypeGroupIds;
            this.AssetTypes = assetTypes;
            this.StartIndex = startIndex;
            this.PageSize = pageSize;
            this.UncategorizedOnly = uncategorizedOnly;
            this.IncludeTotalCostOfOwnership = includeTotalCostOfOwnership;
        }

        /// <summary>
        /// Gets or Sets SubscriberId
        /// </summary>
        [DataMember(Name = "SubscriberId", EmitDefaultValue = false)]
        public int SubscriberId { get; set; }

        /// <summary>
        /// Gets or Sets LocationId
        /// </summary>
        [DataMember(Name = "LocationId", EmitDefaultValue = false)]
        public int LocationId { get; set; }

        /// <summary>
        /// Gets or Sets SearchByText
        /// </summary>
        [DataMember(Name = "SearchByText", EmitDefaultValue = false)]
        public string SearchByText { get; set; }

        /// <summary>
        /// Gets or Sets AssetTypeGroupIds
        /// </summary>
        [DataMember(Name = "AssetTypeGroupIds", EmitDefaultValue = false)]
        public List<int> AssetTypeGroupIds { get; set; }

        /// <summary>
        /// Gets or Sets AssetTypes
        /// </summary>
        [DataMember(Name = "AssetTypes", EmitDefaultValue = false)]
        public List<int> AssetTypes { get; set; }

        /// <summary>
        /// Gets or Sets StartIndex
        /// </summary>
        [DataMember(Name = "StartIndex", EmitDefaultValue = false)]
        public int StartIndex { get; set; }

        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name = "PageSize", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or Sets UncategorizedOnly
        /// </summary>
        [DataMember(Name = "UncategorizedOnly", EmitDefaultValue = true)]
        public bool UncategorizedOnly { get; set; }

        /// <summary>
        /// Gets or Sets IncludeTotalCostOfOwnership
        /// </summary>
        [DataMember(Name = "IncludeTotalCostOfOwnership", EmitDefaultValue = true)]
        public bool IncludeTotalCostOfOwnership { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingEquipmentsSearchAssetsByGroupIDRequest {\n");
            sb.Append("  SubscriberId: ").Append(SubscriberId).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  SearchByText: ").Append(SearchByText).Append("\n");
            sb.Append("  AssetTypeGroupIds: ").Append(AssetTypeGroupIds).Append("\n");
            sb.Append("  AssetTypes: ").Append(AssetTypes).Append("\n");
            sb.Append("  StartIndex: ").Append(StartIndex).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  UncategorizedOnly: ").Append(UncategorizedOnly).Append("\n");
            sb.Append("  IncludeTotalCostOfOwnership: ").Append(IncludeTotalCostOfOwnership).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingEquipmentsSearchAssetsByGroupIDRequest);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingEquipmentsSearchAssetsByGroupIDRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingEquipmentsSearchAssetsByGroupIDRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingEquipmentsSearchAssetsByGroupIDRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SubscriberId == input.SubscriberId ||
                    this.SubscriberId.Equals(input.SubscriberId)
                ) && 
                (
                    this.LocationId == input.LocationId ||
                    this.LocationId.Equals(input.LocationId)
                ) && 
                (
                    this.SearchByText == input.SearchByText ||
                    (this.SearchByText != null &&
                    this.SearchByText.Equals(input.SearchByText))
                ) && 
                (
                    this.AssetTypeGroupIds == input.AssetTypeGroupIds ||
                    this.AssetTypeGroupIds != null &&
                    input.AssetTypeGroupIds != null &&
                    this.AssetTypeGroupIds.SequenceEqual(input.AssetTypeGroupIds)
                ) && 
                (
                    this.AssetTypes == input.AssetTypes ||
                    this.AssetTypes != null &&
                    input.AssetTypes != null &&
                    this.AssetTypes.SequenceEqual(input.AssetTypes)
                ) && 
                (
                    this.StartIndex == input.StartIndex ||
                    this.StartIndex.Equals(input.StartIndex)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.UncategorizedOnly == input.UncategorizedOnly ||
                    this.UncategorizedOnly.Equals(input.UncategorizedOnly)
                ) && 
                (
                    this.IncludeTotalCostOfOwnership == input.IncludeTotalCostOfOwnership ||
                    this.IncludeTotalCostOfOwnership.Equals(input.IncludeTotalCostOfOwnership)
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
                hashCode = (hashCode * 59) + this.SubscriberId.GetHashCode();
                hashCode = (hashCode * 59) + this.LocationId.GetHashCode();
                if (this.SearchByText != null)
                {
                    hashCode = (hashCode * 59) + this.SearchByText.GetHashCode();
                }
                if (this.AssetTypeGroupIds != null)
                {
                    hashCode = (hashCode * 59) + this.AssetTypeGroupIds.GetHashCode();
                }
                if (this.AssetTypes != null)
                {
                    hashCode = (hashCode * 59) + this.AssetTypes.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.StartIndex.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                hashCode = (hashCode * 59) + this.UncategorizedOnly.GetHashCode();
                hashCode = (hashCode * 59) + this.IncludeTotalCostOfOwnership.GetHashCode();
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