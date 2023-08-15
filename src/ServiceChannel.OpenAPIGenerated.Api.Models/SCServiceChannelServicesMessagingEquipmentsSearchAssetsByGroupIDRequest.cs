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
    public class SCServiceChannelServicesMessagingEquipmentsSearchAssetsByGroupIDRequest : IEquatable<SCServiceChannelServicesMessagingEquipmentsSearchAssetsByGroupIDRequest>
    {
        /// <summary>
        /// Gets or Sets SubscriberId
        /// </summary>
        [DataMember(Name="SubscriberId", EmitDefaultValue=true)]
        public int SubscriberId { get; set; }

        /// <summary>
        /// Gets or Sets LocationId
        /// </summary>
        [DataMember(Name="LocationId", EmitDefaultValue=true)]
        public int LocationId { get; set; }

        /// <summary>
        /// Gets or Sets SearchByText
        /// </summary>
        [DataMember(Name="SearchByText", EmitDefaultValue=false)]
        public string SearchByText { get; set; }

        /// <summary>
        /// Gets or Sets AssetTypeGroupIds
        /// </summary>
        [DataMember(Name="AssetTypeGroupIds", EmitDefaultValue=false)]
        public List<int> AssetTypeGroupIds { get; set; }

        /// <summary>
        /// Gets or Sets AssetTypes
        /// </summary>
        [DataMember(Name="AssetTypes", EmitDefaultValue=false)]
        public List<int> AssetTypes { get; set; }

        /// <summary>
        /// Gets or Sets StartIndex
        /// </summary>
        [DataMember(Name="StartIndex", EmitDefaultValue=true)]
        public int StartIndex { get; set; }

        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name="PageSize", EmitDefaultValue=true)]
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or Sets UncategorizedOnly
        /// </summary>
        [DataMember(Name="UncategorizedOnly", EmitDefaultValue=true)]
        public bool UncategorizedOnly { get; set; } = false;

        /// <summary>
        /// Gets or Sets IncludeTotalCostOfOwnership
        /// </summary>
        [DataMember(Name="IncludeTotalCostOfOwnership", EmitDefaultValue=true)]
        public bool IncludeTotalCostOfOwnership { get; set; } = false;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingEquipmentsSearchAssetsByGroupIDRequest)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingEquipmentsSearchAssetsByGroupIDRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingEquipmentsSearchAssetsByGroupIDRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingEquipmentsSearchAssetsByGroupIDRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    SubscriberId == other.SubscriberId ||
                    
                    SubscriberId.Equals(other.SubscriberId)
                ) && 
                (
                    LocationId == other.LocationId ||
                    
                    LocationId.Equals(other.LocationId)
                ) && 
                (
                    SearchByText == other.SearchByText ||
                    SearchByText != null &&
                    SearchByText.Equals(other.SearchByText)
                ) && 
                (
                    AssetTypeGroupIds == other.AssetTypeGroupIds ||
                    AssetTypeGroupIds != null &&
                    other.AssetTypeGroupIds != null &&
                    AssetTypeGroupIds.SequenceEqual(other.AssetTypeGroupIds)
                ) && 
                (
                    AssetTypes == other.AssetTypes ||
                    AssetTypes != null &&
                    other.AssetTypes != null &&
                    AssetTypes.SequenceEqual(other.AssetTypes)
                ) && 
                (
                    StartIndex == other.StartIndex ||
                    
                    StartIndex.Equals(other.StartIndex)
                ) && 
                (
                    PageSize == other.PageSize ||
                    
                    PageSize.Equals(other.PageSize)
                ) && 
                (
                    UncategorizedOnly == other.UncategorizedOnly ||
                    
                    UncategorizedOnly.Equals(other.UncategorizedOnly)
                ) && 
                (
                    IncludeTotalCostOfOwnership == other.IncludeTotalCostOfOwnership ||
                    
                    IncludeTotalCostOfOwnership.Equals(other.IncludeTotalCostOfOwnership)
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
                    
                    hashCode = hashCode * 59 + SubscriberId.GetHashCode();
                    
                    hashCode = hashCode * 59 + LocationId.GetHashCode();
                    if (SearchByText != null)
                    hashCode = hashCode * 59 + SearchByText.GetHashCode();
                    if (AssetTypeGroupIds != null)
                    hashCode = hashCode * 59 + AssetTypeGroupIds.GetHashCode();
                    if (AssetTypes != null)
                    hashCode = hashCode * 59 + AssetTypes.GetHashCode();
                    
                    hashCode = hashCode * 59 + StartIndex.GetHashCode();
                    
                    hashCode = hashCode * 59 + PageSize.GetHashCode();
                    
                    hashCode = hashCode * 59 + UncategorizedOnly.GetHashCode();
                    
                    hashCode = hashCode * 59 + IncludeTotalCostOfOwnership.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingEquipmentsSearchAssetsByGroupIDRequest left, SCServiceChannelServicesMessagingEquipmentsSearchAssetsByGroupIDRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingEquipmentsSearchAssetsByGroupIDRequest left, SCServiceChannelServicesMessagingEquipmentsSearchAssetsByGroupIDRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
