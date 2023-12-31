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
    public class SCServiceChannelServicesMessagingAssetsAssetType : IEquatable<SCServiceChannelServicesMessagingAssetsAssetType>
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=true)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="IsActive", EmitDefaultValue=true)]
        public bool IsActive { get; set; } = false;

        /// <summary>
        /// Gets or Sets SubscriberId
        /// </summary>
        [DataMember(Name="SubscriberId", EmitDefaultValue=true)]
        public int SubscriberId { get; set; }

        /// <summary>
        /// Gets or Sets Parent
        /// </summary>
        [DataMember(Name="Parent", EmitDefaultValue=false)]
        public SCServiceChannelServicesMessagingAssetsAssetType Parent { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryTrade
        /// </summary>
        [DataMember(Name="PrimaryTrade", EmitDefaultValue=false)]
        public string PrimaryTrade { get; set; }

        /// <summary>
        /// Gets or Sets TradeId
        /// </summary>
        [DataMember(Name="TradeId", EmitDefaultValue=true)]
        public int TradeId { get; set; }

        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        [DataMember(Name="ParentId", EmitDefaultValue=true)]
        public int ParentId { get; set; }

        /// <summary>
        /// Gets or Sets RefrigerantPurposeId
        /// </summary>
        [DataMember(Name="RefrigerantPurposeId", EmitDefaultValue=true)]
        public int RefrigerantPurposeId { get; set; }

        /// <summary>
        /// Gets or Sets RefrigerantPurposeName
        /// </summary>
        [DataMember(Name="RefrigerantPurposeName", EmitDefaultValue=false)]
        public string RefrigerantPurposeName { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalTrades
        /// </summary>
        [DataMember(Name="AdditionalTrades", EmitDefaultValue=false)]
        public List<string> AdditionalTrades { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalTradesIds
        /// </summary>
        [DataMember(Name="AdditionalTradesIds", EmitDefaultValue=false)]
        public List<int> AdditionalTradesIds { get; set; }

        /// <summary>
        /// Gets or Sets IsCircuit
        /// </summary>
        [DataMember(Name="IsCircuit", EmitDefaultValue=true)]
        public bool IsCircuit { get; set; } = false;

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="UserId", EmitDefaultValue=true)]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or Sets AssetTypeGroupId
        /// </summary>
        [DataMember(Name="AssetTypeGroupId", EmitDefaultValue=true)]
        public int AssetTypeGroupId { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryAssetTypeId
        /// </summary>
        [DataMember(Name="PrimaryAssetTypeId", EmitDefaultValue=true)]
        public int PrimaryAssetTypeId { get; set; }

        /// <summary>
        /// Gets or Sets BrandIds
        /// </summary>
        [DataMember(Name="BrandIds", EmitDefaultValue=false)]
        public List<int> BrandIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingAssetsAssetType)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingAssetsAssetType instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingAssetsAssetType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingAssetsAssetType other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    IsActive == other.IsActive ||
                    
                    IsActive.Equals(other.IsActive)
                ) && 
                (
                    SubscriberId == other.SubscriberId ||
                    
                    SubscriberId.Equals(other.SubscriberId)
                ) && 
                (
                    Parent == other.Parent ||
                    Parent != null &&
                    Parent.Equals(other.Parent)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    PrimaryTrade == other.PrimaryTrade ||
                    PrimaryTrade != null &&
                    PrimaryTrade.Equals(other.PrimaryTrade)
                ) && 
                (
                    TradeId == other.TradeId ||
                    
                    TradeId.Equals(other.TradeId)
                ) && 
                (
                    ParentId == other.ParentId ||
                    
                    ParentId.Equals(other.ParentId)
                ) && 
                (
                    RefrigerantPurposeId == other.RefrigerantPurposeId ||
                    
                    RefrigerantPurposeId.Equals(other.RefrigerantPurposeId)
                ) && 
                (
                    RefrigerantPurposeName == other.RefrigerantPurposeName ||
                    RefrigerantPurposeName != null &&
                    RefrigerantPurposeName.Equals(other.RefrigerantPurposeName)
                ) && 
                (
                    AdditionalTrades == other.AdditionalTrades ||
                    AdditionalTrades != null &&
                    other.AdditionalTrades != null &&
                    AdditionalTrades.SequenceEqual(other.AdditionalTrades)
                ) && 
                (
                    AdditionalTradesIds == other.AdditionalTradesIds ||
                    AdditionalTradesIds != null &&
                    other.AdditionalTradesIds != null &&
                    AdditionalTradesIds.SequenceEqual(other.AdditionalTradesIds)
                ) && 
                (
                    IsCircuit == other.IsCircuit ||
                    
                    IsCircuit.Equals(other.IsCircuit)
                ) && 
                (
                    UserId == other.UserId ||
                    
                    UserId.Equals(other.UserId)
                ) && 
                (
                    AssetTypeGroupId == other.AssetTypeGroupId ||
                    
                    AssetTypeGroupId.Equals(other.AssetTypeGroupId)
                ) && 
                (
                    PrimaryAssetTypeId == other.PrimaryAssetTypeId ||
                    
                    PrimaryAssetTypeId.Equals(other.PrimaryAssetTypeId)
                ) && 
                (
                    BrandIds == other.BrandIds ||
                    BrandIds != null &&
                    other.BrandIds != null &&
                    BrandIds.SequenceEqual(other.BrandIds)
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
                    
                    hashCode = hashCode * 59 + IsActive.GetHashCode();
                    
                    hashCode = hashCode * 59 + SubscriberId.GetHashCode();
                    if (Parent != null)
                    hashCode = hashCode * 59 + Parent.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (PrimaryTrade != null)
                    hashCode = hashCode * 59 + PrimaryTrade.GetHashCode();
                    
                    hashCode = hashCode * 59 + TradeId.GetHashCode();
                    
                    hashCode = hashCode * 59 + ParentId.GetHashCode();
                    
                    hashCode = hashCode * 59 + RefrigerantPurposeId.GetHashCode();
                    if (RefrigerantPurposeName != null)
                    hashCode = hashCode * 59 + RefrigerantPurposeName.GetHashCode();
                    if (AdditionalTrades != null)
                    hashCode = hashCode * 59 + AdditionalTrades.GetHashCode();
                    if (AdditionalTradesIds != null)
                    hashCode = hashCode * 59 + AdditionalTradesIds.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsCircuit.GetHashCode();
                    
                    hashCode = hashCode * 59 + UserId.GetHashCode();
                    
                    hashCode = hashCode * 59 + AssetTypeGroupId.GetHashCode();
                    
                    hashCode = hashCode * 59 + PrimaryAssetTypeId.GetHashCode();
                    if (BrandIds != null)
                    hashCode = hashCode * 59 + BrandIds.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingAssetsAssetType left, SCServiceChannelServicesMessagingAssetsAssetType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingAssetsAssetType left, SCServiceChannelServicesMessagingAssetsAssetType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
