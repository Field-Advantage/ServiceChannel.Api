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
    /// SCServiceChannelServicesMessagingAssetsAssetType
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.Assets.AssetType")]
    public partial class SCServiceChannelServicesMessagingAssetsAssetType : IEquatable<SCServiceChannelServicesMessagingAssetsAssetType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingAssetsAssetType" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="isActive">isActive (default to false).</param>
        /// <param name="subscriberId">subscriberId.</param>
        /// <param name="parent">parent.</param>
        /// <param name="name">name.</param>
        /// <param name="primaryTrade">primaryTrade.</param>
        /// <param name="tradeId">tradeId.</param>
        /// <param name="parentId">parentId.</param>
        /// <param name="refrigerantPurposeId">refrigerantPurposeId.</param>
        /// <param name="refrigerantPurposeName">refrigerantPurposeName.</param>
        /// <param name="additionalTrades">additionalTrades.</param>
        /// <param name="additionalTradesIds">additionalTradesIds.</param>
        /// <param name="isCircuit">isCircuit (default to false).</param>
        /// <param name="userId">userId.</param>
        /// <param name="assetTypeGroupId">assetTypeGroupId.</param>
        /// <param name="primaryAssetTypeId">primaryAssetTypeId.</param>
        /// <param name="brandIds">brandIds.</param>
        public SCServiceChannelServicesMessagingAssetsAssetType(int id = default(int), bool isActive = false, int subscriberId = default(int), SCServiceChannelServicesMessagingAssetsAssetType parent = default(SCServiceChannelServicesMessagingAssetsAssetType), string name = default(string), string primaryTrade = default(string), int tradeId = default(int), int parentId = default(int), int refrigerantPurposeId = default(int), string refrigerantPurposeName = default(string), List<string> additionalTrades = default(List<string>), List<int> additionalTradesIds = default(List<int>), bool isCircuit = false, int userId = default(int), int assetTypeGroupId = default(int), int primaryAssetTypeId = default(int), List<int> brandIds = default(List<int>))
        {
            this.Id = id;
            this.IsActive = isActive;
            this.SubscriberId = subscriberId;
            this.Parent = parent;
            this.Name = name;
            this.PrimaryTrade = primaryTrade;
            this.TradeId = tradeId;
            this.ParentId = parentId;
            this.RefrigerantPurposeId = refrigerantPurposeId;
            this.RefrigerantPurposeName = refrigerantPurposeName;
            this.AdditionalTrades = additionalTrades;
            this.AdditionalTradesIds = additionalTradesIds;
            this.IsCircuit = isCircuit;
            this.UserId = userId;
            this.AssetTypeGroupId = assetTypeGroupId;
            this.PrimaryAssetTypeId = primaryAssetTypeId;
            this.BrandIds = brandIds;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name = "IsActive", EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or Sets SubscriberId
        /// </summary>
        [DataMember(Name = "SubscriberId", EmitDefaultValue = false)]
        public int SubscriberId { get; set; }

        /// <summary>
        /// Gets or Sets Parent
        /// </summary>
        [DataMember(Name = "Parent", EmitDefaultValue = false)]
        public SCServiceChannelServicesMessagingAssetsAssetType Parent { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryTrade
        /// </summary>
        [DataMember(Name = "PrimaryTrade", EmitDefaultValue = false)]
        public string PrimaryTrade { get; set; }

        /// <summary>
        /// Gets or Sets TradeId
        /// </summary>
        [DataMember(Name = "TradeId", EmitDefaultValue = false)]
        public int TradeId { get; set; }

        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        [DataMember(Name = "ParentId", EmitDefaultValue = false)]
        public int ParentId { get; set; }

        /// <summary>
        /// Gets or Sets RefrigerantPurposeId
        /// </summary>
        [DataMember(Name = "RefrigerantPurposeId", EmitDefaultValue = false)]
        public int RefrigerantPurposeId { get; set; }

        /// <summary>
        /// Gets or Sets RefrigerantPurposeName
        /// </summary>
        [DataMember(Name = "RefrigerantPurposeName", EmitDefaultValue = false)]
        public string RefrigerantPurposeName { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalTrades
        /// </summary>
        [DataMember(Name = "AdditionalTrades", EmitDefaultValue = false)]
        public List<string> AdditionalTrades { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalTradesIds
        /// </summary>
        [DataMember(Name = "AdditionalTradesIds", EmitDefaultValue = false)]
        public List<int> AdditionalTradesIds { get; set; }

        /// <summary>
        /// Gets or Sets IsCircuit
        /// </summary>
        [DataMember(Name = "IsCircuit", EmitDefaultValue = true)]
        public bool IsCircuit { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "UserId", EmitDefaultValue = false)]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or Sets AssetTypeGroupId
        /// </summary>
        [DataMember(Name = "AssetTypeGroupId", EmitDefaultValue = false)]
        public int AssetTypeGroupId { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryAssetTypeId
        /// </summary>
        [DataMember(Name = "PrimaryAssetTypeId", EmitDefaultValue = false)]
        public int PrimaryAssetTypeId { get; set; }

        /// <summary>
        /// Gets or Sets BrandIds
        /// </summary>
        [DataMember(Name = "BrandIds", EmitDefaultValue = false)]
        public List<int> BrandIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingAssetsAssetType {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  SubscriberId: ").Append(SubscriberId).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PrimaryTrade: ").Append(PrimaryTrade).Append("\n");
            sb.Append("  TradeId: ").Append(TradeId).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  RefrigerantPurposeId: ").Append(RefrigerantPurposeId).Append("\n");
            sb.Append("  RefrigerantPurposeName: ").Append(RefrigerantPurposeName).Append("\n");
            sb.Append("  AdditionalTrades: ").Append(AdditionalTrades).Append("\n");
            sb.Append("  AdditionalTradesIds: ").Append(AdditionalTradesIds).Append("\n");
            sb.Append("  IsCircuit: ").Append(IsCircuit).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  AssetTypeGroupId: ").Append(AssetTypeGroupId).Append("\n");
            sb.Append("  PrimaryAssetTypeId: ").Append(PrimaryAssetTypeId).Append("\n");
            sb.Append("  BrandIds: ").Append(BrandIds).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingAssetsAssetType);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingAssetsAssetType instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingAssetsAssetType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingAssetsAssetType input)
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
                    this.IsActive == input.IsActive ||
                    this.IsActive.Equals(input.IsActive)
                ) && 
                (
                    this.SubscriberId == input.SubscriberId ||
                    this.SubscriberId.Equals(input.SubscriberId)
                ) && 
                (
                    this.Parent == input.Parent ||
                    (this.Parent != null &&
                    this.Parent.Equals(input.Parent))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PrimaryTrade == input.PrimaryTrade ||
                    (this.PrimaryTrade != null &&
                    this.PrimaryTrade.Equals(input.PrimaryTrade))
                ) && 
                (
                    this.TradeId == input.TradeId ||
                    this.TradeId.Equals(input.TradeId)
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    this.ParentId.Equals(input.ParentId)
                ) && 
                (
                    this.RefrigerantPurposeId == input.RefrigerantPurposeId ||
                    this.RefrigerantPurposeId.Equals(input.RefrigerantPurposeId)
                ) && 
                (
                    this.RefrigerantPurposeName == input.RefrigerantPurposeName ||
                    (this.RefrigerantPurposeName != null &&
                    this.RefrigerantPurposeName.Equals(input.RefrigerantPurposeName))
                ) && 
                (
                    this.AdditionalTrades == input.AdditionalTrades ||
                    this.AdditionalTrades != null &&
                    input.AdditionalTrades != null &&
                    this.AdditionalTrades.SequenceEqual(input.AdditionalTrades)
                ) && 
                (
                    this.AdditionalTradesIds == input.AdditionalTradesIds ||
                    this.AdditionalTradesIds != null &&
                    input.AdditionalTradesIds != null &&
                    this.AdditionalTradesIds.SequenceEqual(input.AdditionalTradesIds)
                ) && 
                (
                    this.IsCircuit == input.IsCircuit ||
                    this.IsCircuit.Equals(input.IsCircuit)
                ) && 
                (
                    this.UserId == input.UserId ||
                    this.UserId.Equals(input.UserId)
                ) && 
                (
                    this.AssetTypeGroupId == input.AssetTypeGroupId ||
                    this.AssetTypeGroupId.Equals(input.AssetTypeGroupId)
                ) && 
                (
                    this.PrimaryAssetTypeId == input.PrimaryAssetTypeId ||
                    this.PrimaryAssetTypeId.Equals(input.PrimaryAssetTypeId)
                ) && 
                (
                    this.BrandIds == input.BrandIds ||
                    this.BrandIds != null &&
                    input.BrandIds != null &&
                    this.BrandIds.SequenceEqual(input.BrandIds)
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
                hashCode = (hashCode * 59) + this.IsActive.GetHashCode();
                hashCode = (hashCode * 59) + this.SubscriberId.GetHashCode();
                if (this.Parent != null)
                {
                    hashCode = (hashCode * 59) + this.Parent.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.PrimaryTrade != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryTrade.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TradeId.GetHashCode();
                hashCode = (hashCode * 59) + this.ParentId.GetHashCode();
                hashCode = (hashCode * 59) + this.RefrigerantPurposeId.GetHashCode();
                if (this.RefrigerantPurposeName != null)
                {
                    hashCode = (hashCode * 59) + this.RefrigerantPurposeName.GetHashCode();
                }
                if (this.AdditionalTrades != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalTrades.GetHashCode();
                }
                if (this.AdditionalTradesIds != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalTradesIds.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsCircuit.GetHashCode();
                hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                hashCode = (hashCode * 59) + this.AssetTypeGroupId.GetHashCode();
                hashCode = (hashCode * 59) + this.PrimaryAssetTypeId.GetHashCode();
                if (this.BrandIds != null)
                {
                    hashCode = (hashCode * 59) + this.BrandIds.GetHashCode();
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
