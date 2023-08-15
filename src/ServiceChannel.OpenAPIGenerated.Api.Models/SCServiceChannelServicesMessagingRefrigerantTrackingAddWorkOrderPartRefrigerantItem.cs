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
    public class SCServiceChannelServicesMessagingRefrigerantTrackingAddWorkOrderPartRefrigerantItem : IEquatable<SCServiceChannelServicesMessagingRefrigerantTrackingAddWorkOrderPartRefrigerantItem>
    {
        /// <summary>
        /// Gets or Sets AssetId
        /// </summary>
        [DataMember(Name="AssetId", EmitDefaultValue=true)]
        public int AssetId { get; set; }

        /// <summary>
        /// Gets or Sets RecId
        /// </summary>
        [DataMember(Name="RecId", EmitDefaultValue=true)]
        public int RecId { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="Quantity", EmitDefaultValue=true)]
        public double Quantity { get; set; }

        /// <summary>
        /// Gets or Sets UnitCost
        /// </summary>
        [DataMember(Name="UnitCost", EmitDefaultValue=true)]
        public double UnitCost { get; set; }

        /// <summary>
        /// Gets or Sets IsRefrigerant
        /// </summary>
        [DataMember(Name="IsRefrigerant", EmitDefaultValue=true)]
        public bool IsRefrigerant { get; set; } = false;

        /// <summary>
        /// Gets or Sets IsInventoryPart
        /// </summary>
        [DataMember(Name="IsInventoryPart", EmitDefaultValue=true)]
        public bool IsInventoryPart { get; set; } = false;

        /// <summary>
        /// Gets or Sets UseDate
        /// </summary>
        [DataMember(Name="UseDate", EmitDefaultValue=false)]
        public DateTime UseDate { get; set; }

        /// <summary>
        /// Gets or Sets UseDateStr
        /// </summary>
        [DataMember(Name="UseDateStr", EmitDefaultValue=false)]
        public string UseDateStr { get; set; }

        /// <summary>
        /// Gets or Sets ReasonCode
        /// </summary>
        [DataMember(Name="ReasonCode", EmitDefaultValue=true)]
        public int ReasonCode { get; set; }

        /// <summary>
        /// Gets or Sets ReasonCodeId
        /// </summary>
        [DataMember(Name="ReasonCodeId", EmitDefaultValue=true)]
        public int ReasonCodeId { get; set; }

        /// <summary>
        /// Gets or Sets PartNumber
        /// </summary>
        [DataMember(Name="PartNumber", EmitDefaultValue=false)]
        public string PartNumber { get; set; }

        /// <summary>
        /// Gets or Sets PartName
        /// </summary>
        [DataMember(Name="PartName", EmitDefaultValue=false)]
        public string PartName { get; set; }

        /// <summary>
        /// Gets or Sets PartGroup
        /// </summary>
        [DataMember(Name="PartGroup", EmitDefaultValue=false)]
        public string PartGroup { get; set; }

        /// <summary>
        /// Gets or Sets PartGroupId
        /// </summary>
        [DataMember(Name="PartGroupId", EmitDefaultValue=true)]
        public int PartGroupId { get; set; }

        /// <summary>
        /// Gets or Sets SupplierName
        /// </summary>
        [DataMember(Name="SupplierName", EmitDefaultValue=false)]
        public string SupplierName { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets RefrigerantChargeOptionsId
        /// </summary>
        [DataMember(Name="RefrigerantChargeOptionsId", EmitDefaultValue=true)]
        public int RefrigerantChargeOptionsId { get; set; }

        /// <summary>
        /// Gets or Sets RefrigerantChargeVendor
        /// </summary>
        [DataMember(Name="RefrigerantChargeVendor", EmitDefaultValue=false)]
        public string RefrigerantChargeVendor { get; set; }

        /// <summary>
        /// Gets or Sets InventoryLocationId
        /// </summary>
        [DataMember(Name="InventoryLocationId", EmitDefaultValue=true)]
        public int InventoryLocationId { get; set; }

        /// <summary>
        /// GUID of the inventory location
        /// </summary>
        /// <value>GUID of the inventory location</value>
        [DataMember(Name="InventoryLocationGuid", EmitDefaultValue=false)]
        public string InventoryLocationGuid { get; set; }

        /// <summary>
        /// Gets or Sets InventoryPartId
        /// </summary>
        [DataMember(Name="InventoryPartId", EmitDefaultValue=true)]
        public int InventoryPartId { get; set; }

        /// <summary>
        /// Gets or Sets RefrigerantUseReason
        /// </summary>
        [DataMember(Name="RefrigerantUseReason", EmitDefaultValue=false)]
        public SCServiceChannelServicesMessagingRefrigerantTrackingRefrigerantUseReasonCode RefrigerantUseReason { get; set; }


        /// <summary>
        /// Gets or Sets RefrigerantRemovalStatus
        /// </summary>
        
        public enum RefrigerantRemovalStatusEnum
        {
            
            /// <summary>
            /// Enum DestroyedEnum for Destroyed
            /// </summary>
            [EnumMember(Value = "Destroyed")]
            DestroyedEnum = 1,
            
            /// <summary>
            /// Enum ReusedEnum for Reused
            /// </summary>
            [EnumMember(Value = "Reused")]
            ReusedEnum = 2,
            
            /// <summary>
            /// Enum ReclaimedEnum for Reclaimed
            /// </summary>
            [EnumMember(Value = "Reclaimed")]
            ReclaimedEnum = 3,
            
            /// <summary>
            /// Enum BankedEnum for Banked
            /// </summary>
            [EnumMember(Value = "Banked")]
            BankedEnum = 4,
            
            /// <summary>
            /// Enum ChargeLostEnum for ChargeLost
            /// </summary>
            [EnumMember(Value = "ChargeLost")]
            ChargeLostEnum = 5
        }

        /// <summary>
        /// Gets or Sets RefrigerantRemovalStatus
        /// </summary>
        [DataMember(Name="RefrigerantRemovalStatus", EmitDefaultValue=true)]
        public RefrigerantRemovalStatusEnum RefrigerantRemovalStatus { get; set; }

        /// <summary>
        /// Gets or Sets RefrigerantTypeId
        /// </summary>
        [DataMember(Name="RefrigerantTypeId", EmitDefaultValue=true)]
        public int RefrigerantTypeId { get; set; }

        /// <summary>
        /// Gets or Sets RefrigerantTypeName
        /// </summary>
        [DataMember(Name="RefrigerantTypeName", EmitDefaultValue=false)]
        public string RefrigerantTypeName { get; set; }

        /// <summary>
        /// Gets or Sets SubmitMoeQtyExceeded
        /// </summary>
        [DataMember(Name="SubmitMoeQtyExceeded", EmitDefaultValue=true)]
        public bool SubmitMoeQtyExceeded { get; set; } = false;

        /// <summary>
        /// Gets or Sets MoeNumber
        /// </summary>
        [DataMember(Name="MoeNumber", EmitDefaultValue=false)]
        public string MoeNumber { get; set; }

        /// <summary>
        /// Gets or Sets IsRetrofit
        /// </summary>
        [RegularExpression("^(?:[A-Za-z0-9+/]{4})*(?:[A-Za-z0-9+/]{2}==|[A-Za-z0-9+/]{3}=)?$")]
        [DataMember(Name="IsRetrofit", EmitDefaultValue=false)]
        public byte[] IsRetrofit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingRefrigerantTrackingAddWorkOrderPartRefrigerantItem {\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  RecId: ").Append(RecId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  UnitCost: ").Append(UnitCost).Append("\n");
            sb.Append("  IsRefrigerant: ").Append(IsRefrigerant).Append("\n");
            sb.Append("  IsInventoryPart: ").Append(IsInventoryPart).Append("\n");
            sb.Append("  UseDate: ").Append(UseDate).Append("\n");
            sb.Append("  UseDateStr: ").Append(UseDateStr).Append("\n");
            sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
            sb.Append("  ReasonCodeId: ").Append(ReasonCodeId).Append("\n");
            sb.Append("  PartNumber: ").Append(PartNumber).Append("\n");
            sb.Append("  PartName: ").Append(PartName).Append("\n");
            sb.Append("  PartGroup: ").Append(PartGroup).Append("\n");
            sb.Append("  PartGroupId: ").Append(PartGroupId).Append("\n");
            sb.Append("  SupplierName: ").Append(SupplierName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  RefrigerantChargeOptionsId: ").Append(RefrigerantChargeOptionsId).Append("\n");
            sb.Append("  RefrigerantChargeVendor: ").Append(RefrigerantChargeVendor).Append("\n");
            sb.Append("  InventoryLocationId: ").Append(InventoryLocationId).Append("\n");
            sb.Append("  InventoryLocationGuid: ").Append(InventoryLocationGuid).Append("\n");
            sb.Append("  InventoryPartId: ").Append(InventoryPartId).Append("\n");
            sb.Append("  RefrigerantUseReason: ").Append(RefrigerantUseReason).Append("\n");
            sb.Append("  RefrigerantRemovalStatus: ").Append(RefrigerantRemovalStatus).Append("\n");
            sb.Append("  RefrigerantTypeId: ").Append(RefrigerantTypeId).Append("\n");
            sb.Append("  RefrigerantTypeName: ").Append(RefrigerantTypeName).Append("\n");
            sb.Append("  SubmitMoeQtyExceeded: ").Append(SubmitMoeQtyExceeded).Append("\n");
            sb.Append("  MoeNumber: ").Append(MoeNumber).Append("\n");
            sb.Append("  IsRetrofit: ").Append(IsRetrofit).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingRefrigerantTrackingAddWorkOrderPartRefrigerantItem)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingRefrigerantTrackingAddWorkOrderPartRefrigerantItem instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingRefrigerantTrackingAddWorkOrderPartRefrigerantItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingRefrigerantTrackingAddWorkOrderPartRefrigerantItem other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AssetId == other.AssetId ||
                    
                    AssetId.Equals(other.AssetId)
                ) && 
                (
                    RecId == other.RecId ||
                    
                    RecId.Equals(other.RecId)
                ) && 
                (
                    Quantity == other.Quantity ||
                    
                    Quantity.Equals(other.Quantity)
                ) && 
                (
                    UnitCost == other.UnitCost ||
                    
                    UnitCost.Equals(other.UnitCost)
                ) && 
                (
                    IsRefrigerant == other.IsRefrigerant ||
                    
                    IsRefrigerant.Equals(other.IsRefrigerant)
                ) && 
                (
                    IsInventoryPart == other.IsInventoryPart ||
                    
                    IsInventoryPart.Equals(other.IsInventoryPart)
                ) && 
                (
                    UseDate == other.UseDate ||
                    UseDate != null &&
                    UseDate.Equals(other.UseDate)
                ) && 
                (
                    UseDateStr == other.UseDateStr ||
                    UseDateStr != null &&
                    UseDateStr.Equals(other.UseDateStr)
                ) && 
                (
                    ReasonCode == other.ReasonCode ||
                    
                    ReasonCode.Equals(other.ReasonCode)
                ) && 
                (
                    ReasonCodeId == other.ReasonCodeId ||
                    
                    ReasonCodeId.Equals(other.ReasonCodeId)
                ) && 
                (
                    PartNumber == other.PartNumber ||
                    PartNumber != null &&
                    PartNumber.Equals(other.PartNumber)
                ) && 
                (
                    PartName == other.PartName ||
                    PartName != null &&
                    PartName.Equals(other.PartName)
                ) && 
                (
                    PartGroup == other.PartGroup ||
                    PartGroup != null &&
                    PartGroup.Equals(other.PartGroup)
                ) && 
                (
                    PartGroupId == other.PartGroupId ||
                    
                    PartGroupId.Equals(other.PartGroupId)
                ) && 
                (
                    SupplierName == other.SupplierName ||
                    SupplierName != null &&
                    SupplierName.Equals(other.SupplierName)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    RefrigerantChargeOptionsId == other.RefrigerantChargeOptionsId ||
                    
                    RefrigerantChargeOptionsId.Equals(other.RefrigerantChargeOptionsId)
                ) && 
                (
                    RefrigerantChargeVendor == other.RefrigerantChargeVendor ||
                    RefrigerantChargeVendor != null &&
                    RefrigerantChargeVendor.Equals(other.RefrigerantChargeVendor)
                ) && 
                (
                    InventoryLocationId == other.InventoryLocationId ||
                    
                    InventoryLocationId.Equals(other.InventoryLocationId)
                ) && 
                (
                    InventoryLocationGuid == other.InventoryLocationGuid ||
                    InventoryLocationGuid != null &&
                    InventoryLocationGuid.Equals(other.InventoryLocationGuid)
                ) && 
                (
                    InventoryPartId == other.InventoryPartId ||
                    
                    InventoryPartId.Equals(other.InventoryPartId)
                ) && 
                (
                    RefrigerantUseReason == other.RefrigerantUseReason ||
                    RefrigerantUseReason != null &&
                    RefrigerantUseReason.Equals(other.RefrigerantUseReason)
                ) && 
                (
                    RefrigerantRemovalStatus == other.RefrigerantRemovalStatus ||
                    
                    RefrigerantRemovalStatus.Equals(other.RefrigerantRemovalStatus)
                ) && 
                (
                    RefrigerantTypeId == other.RefrigerantTypeId ||
                    
                    RefrigerantTypeId.Equals(other.RefrigerantTypeId)
                ) && 
                (
                    RefrigerantTypeName == other.RefrigerantTypeName ||
                    RefrigerantTypeName != null &&
                    RefrigerantTypeName.Equals(other.RefrigerantTypeName)
                ) && 
                (
                    SubmitMoeQtyExceeded == other.SubmitMoeQtyExceeded ||
                    
                    SubmitMoeQtyExceeded.Equals(other.SubmitMoeQtyExceeded)
                ) && 
                (
                    MoeNumber == other.MoeNumber ||
                    MoeNumber != null &&
                    MoeNumber.Equals(other.MoeNumber)
                ) && 
                (
                    IsRetrofit == other.IsRetrofit ||
                    IsRetrofit != null &&
                    IsRetrofit.Equals(other.IsRetrofit)
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
                    
                    hashCode = hashCode * 59 + AssetId.GetHashCode();
                    
                    hashCode = hashCode * 59 + RecId.GetHashCode();
                    
                    hashCode = hashCode * 59 + Quantity.GetHashCode();
                    
                    hashCode = hashCode * 59 + UnitCost.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsRefrigerant.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsInventoryPart.GetHashCode();
                    if (UseDate != null)
                    hashCode = hashCode * 59 + UseDate.GetHashCode();
                    if (UseDateStr != null)
                    hashCode = hashCode * 59 + UseDateStr.GetHashCode();
                    
                    hashCode = hashCode * 59 + ReasonCode.GetHashCode();
                    
                    hashCode = hashCode * 59 + ReasonCodeId.GetHashCode();
                    if (PartNumber != null)
                    hashCode = hashCode * 59 + PartNumber.GetHashCode();
                    if (PartName != null)
                    hashCode = hashCode * 59 + PartName.GetHashCode();
                    if (PartGroup != null)
                    hashCode = hashCode * 59 + PartGroup.GetHashCode();
                    
                    hashCode = hashCode * 59 + PartGroupId.GetHashCode();
                    if (SupplierName != null)
                    hashCode = hashCode * 59 + SupplierName.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    
                    hashCode = hashCode * 59 + RefrigerantChargeOptionsId.GetHashCode();
                    if (RefrigerantChargeVendor != null)
                    hashCode = hashCode * 59 + RefrigerantChargeVendor.GetHashCode();
                    
                    hashCode = hashCode * 59 + InventoryLocationId.GetHashCode();
                    if (InventoryLocationGuid != null)
                    hashCode = hashCode * 59 + InventoryLocationGuid.GetHashCode();
                    
                    hashCode = hashCode * 59 + InventoryPartId.GetHashCode();
                    if (RefrigerantUseReason != null)
                    hashCode = hashCode * 59 + RefrigerantUseReason.GetHashCode();
                    
                    hashCode = hashCode * 59 + RefrigerantRemovalStatus.GetHashCode();
                    
                    hashCode = hashCode * 59 + RefrigerantTypeId.GetHashCode();
                    if (RefrigerantTypeName != null)
                    hashCode = hashCode * 59 + RefrigerantTypeName.GetHashCode();
                    
                    hashCode = hashCode * 59 + SubmitMoeQtyExceeded.GetHashCode();
                    if (MoeNumber != null)
                    hashCode = hashCode * 59 + MoeNumber.GetHashCode();
                    if (IsRetrofit != null)
                    hashCode = hashCode * 59 + IsRetrofit.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingRefrigerantTrackingAddWorkOrderPartRefrigerantItem left, SCServiceChannelServicesMessagingRefrigerantTrackingAddWorkOrderPartRefrigerantItem right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingRefrigerantTrackingAddWorkOrderPartRefrigerantItem left, SCServiceChannelServicesMessagingRefrigerantTrackingAddWorkOrderPartRefrigerantItem right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}