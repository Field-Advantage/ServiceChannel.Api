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
    public class SCServiceChannelServicesMessagingProposalsProposalCategoryRow : IEquatable<SCServiceChannelServicesMessagingProposalsProposalCategoryRow>
    {
        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        [DataMember(Name="Required", EmitDefaultValue=true)]
        public bool Required { get; set; } = false;

        /// <summary>
        /// Gets or Sets HideDetails
        /// </summary>
        [DataMember(Name="HideDetails", EmitDefaultValue=true)]
        public bool HideDetails { get; set; } = false;

        /// <summary>
        /// Gets or Sets TotalCost
        /// </summary>
        [DataMember(Name="TotalCost", EmitDefaultValue=true)]
        public double TotalCost { get; set; }

        /// <summary>
        /// Gets or Sets ServiceType
        /// </summary>
        [DataMember(Name="ServiceType", EmitDefaultValue=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="IsActive", EmitDefaultValue=true)]
        public bool IsActive { get; set; } = false;

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name="SortOrder", EmitDefaultValue=true)]
        public int SortOrder { get; set; }

        /// <summary>
        /// Gets or Sets Quantity1
        /// </summary>
        [DataMember(Name="Quantity1", EmitDefaultValue=true)]
        public double Quantity1 { get; set; }

        /// <summary>
        /// Gets or Sets Quantity2
        /// </summary>
        [DataMember(Name="Quantity2", EmitDefaultValue=true)]
        public int Quantity2 { get; set; }

        /// <summary>
        /// Gets or Sets UnitCost
        /// </summary>
        [DataMember(Name="UnitCost", EmitDefaultValue=true)]
        public double UnitCost { get; set; }

        /// <summary>
        /// Gets or Sets UnitOfMeasure
        /// </summary>
        [DataMember(Name="UnitOfMeasure", EmitDefaultValue=false)]
        public string UnitOfMeasure { get; set; }

        /// <summary>
        /// Gets or Sets ExtendedCost
        /// </summary>
        [DataMember(Name="ExtendedCost", EmitDefaultValue=true)]
        public double ExtendedCost { get; set; }

        /// <summary>
        /// Gets or Sets Craft
        /// </summary>
        [DataMember(Name="Craft", EmitDefaultValue=false)]
        public string Craft { get; set; }

        /// <summary>
        /// Gets or Sets RepairCategory
        /// </summary>
        [DataMember(Name="RepairCategory", EmitDefaultValue=false)]
        public string RepairCategory { get; set; }

        /// <summary>
        /// Gets or Sets RepairType
        /// </summary>
        [DataMember(Name="RepairType", EmitDefaultValue=false)]
        public string RepairType { get; set; }

        /// <summary>
        /// Gets or Sets MaterialThickness
        /// </summary>
        [DataMember(Name="MaterialThickness", EmitDefaultValue=false)]
        public string MaterialThickness { get; set; }

        /// <summary>
        /// Gets or Sets Markup
        /// </summary>
        [DataMember(Name="Markup", EmitDefaultValue=true)]
        public double Markup { get; set; }

        /// <summary>
        /// Gets or Sets PriceList
        /// </summary>
        [DataMember(Name="PriceList", EmitDefaultValue=false)]
        public string PriceList { get; set; }

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
        /// Gets or Sets VAT
        /// </summary>
        [DataMember(Name="VAT", EmitDefaultValue=false)]
        public string VAT { get; set; }

        /// <summary>
        /// Gets or Sets FeesType
        /// </summary>
        [DataMember(Name="FeesType", EmitDefaultValue=false)]
        public string FeesType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingProposalsProposalCategoryRow {\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  HideDetails: ").Append(HideDetails).Append("\n");
            sb.Append("  TotalCost: ").Append(TotalCost).Append("\n");
            sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  Quantity1: ").Append(Quantity1).Append("\n");
            sb.Append("  Quantity2: ").Append(Quantity2).Append("\n");
            sb.Append("  UnitCost: ").Append(UnitCost).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("  ExtendedCost: ").Append(ExtendedCost).Append("\n");
            sb.Append("  Craft: ").Append(Craft).Append("\n");
            sb.Append("  RepairCategory: ").Append(RepairCategory).Append("\n");
            sb.Append("  RepairType: ").Append(RepairType).Append("\n");
            sb.Append("  MaterialThickness: ").Append(MaterialThickness).Append("\n");
            sb.Append("  Markup: ").Append(Markup).Append("\n");
            sb.Append("  PriceList: ").Append(PriceList).Append("\n");
            sb.Append("  PartNumber: ").Append(PartNumber).Append("\n");
            sb.Append("  PartName: ").Append(PartName).Append("\n");
            sb.Append("  VAT: ").Append(VAT).Append("\n");
            sb.Append("  FeesType: ").Append(FeesType).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingProposalsProposalCategoryRow)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingProposalsProposalCategoryRow instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingProposalsProposalCategoryRow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingProposalsProposalCategoryRow other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Required == other.Required ||
                    
                    Required.Equals(other.Required)
                ) && 
                (
                    HideDetails == other.HideDetails ||
                    
                    HideDetails.Equals(other.HideDetails)
                ) && 
                (
                    TotalCost == other.TotalCost ||
                    
                    TotalCost.Equals(other.TotalCost)
                ) && 
                (
                    ServiceType == other.ServiceType ||
                    ServiceType != null &&
                    ServiceType.Equals(other.ServiceType)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    IsActive == other.IsActive ||
                    
                    IsActive.Equals(other.IsActive)
                ) && 
                (
                    SortOrder == other.SortOrder ||
                    
                    SortOrder.Equals(other.SortOrder)
                ) && 
                (
                    Quantity1 == other.Quantity1 ||
                    
                    Quantity1.Equals(other.Quantity1)
                ) && 
                (
                    Quantity2 == other.Quantity2 ||
                    
                    Quantity2.Equals(other.Quantity2)
                ) && 
                (
                    UnitCost == other.UnitCost ||
                    
                    UnitCost.Equals(other.UnitCost)
                ) && 
                (
                    UnitOfMeasure == other.UnitOfMeasure ||
                    UnitOfMeasure != null &&
                    UnitOfMeasure.Equals(other.UnitOfMeasure)
                ) && 
                (
                    ExtendedCost == other.ExtendedCost ||
                    
                    ExtendedCost.Equals(other.ExtendedCost)
                ) && 
                (
                    Craft == other.Craft ||
                    Craft != null &&
                    Craft.Equals(other.Craft)
                ) && 
                (
                    RepairCategory == other.RepairCategory ||
                    RepairCategory != null &&
                    RepairCategory.Equals(other.RepairCategory)
                ) && 
                (
                    RepairType == other.RepairType ||
                    RepairType != null &&
                    RepairType.Equals(other.RepairType)
                ) && 
                (
                    MaterialThickness == other.MaterialThickness ||
                    MaterialThickness != null &&
                    MaterialThickness.Equals(other.MaterialThickness)
                ) && 
                (
                    Markup == other.Markup ||
                    
                    Markup.Equals(other.Markup)
                ) && 
                (
                    PriceList == other.PriceList ||
                    PriceList != null &&
                    PriceList.Equals(other.PriceList)
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
                    VAT == other.VAT ||
                    VAT != null &&
                    VAT.Equals(other.VAT)
                ) && 
                (
                    FeesType == other.FeesType ||
                    FeesType != null &&
                    FeesType.Equals(other.FeesType)
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
                    
                    hashCode = hashCode * 59 + Required.GetHashCode();
                    
                    hashCode = hashCode * 59 + HideDetails.GetHashCode();
                    
                    hashCode = hashCode * 59 + TotalCost.GetHashCode();
                    if (ServiceType != null)
                    hashCode = hashCode * 59 + ServiceType.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsActive.GetHashCode();
                    
                    hashCode = hashCode * 59 + SortOrder.GetHashCode();
                    
                    hashCode = hashCode * 59 + Quantity1.GetHashCode();
                    
                    hashCode = hashCode * 59 + Quantity2.GetHashCode();
                    
                    hashCode = hashCode * 59 + UnitCost.GetHashCode();
                    if (UnitOfMeasure != null)
                    hashCode = hashCode * 59 + UnitOfMeasure.GetHashCode();
                    
                    hashCode = hashCode * 59 + ExtendedCost.GetHashCode();
                    if (Craft != null)
                    hashCode = hashCode * 59 + Craft.GetHashCode();
                    if (RepairCategory != null)
                    hashCode = hashCode * 59 + RepairCategory.GetHashCode();
                    if (RepairType != null)
                    hashCode = hashCode * 59 + RepairType.GetHashCode();
                    if (MaterialThickness != null)
                    hashCode = hashCode * 59 + MaterialThickness.GetHashCode();
                    
                    hashCode = hashCode * 59 + Markup.GetHashCode();
                    if (PriceList != null)
                    hashCode = hashCode * 59 + PriceList.GetHashCode();
                    if (PartNumber != null)
                    hashCode = hashCode * 59 + PartNumber.GetHashCode();
                    if (PartName != null)
                    hashCode = hashCode * 59 + PartName.GetHashCode();
                    if (VAT != null)
                    hashCode = hashCode * 59 + VAT.GetHashCode();
                    if (FeesType != null)
                    hashCode = hashCode * 59 + FeesType.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingProposalsProposalCategoryRow left, SCServiceChannelServicesMessagingProposalsProposalCategoryRow right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingProposalsProposalCategoryRow left, SCServiceChannelServicesMessagingProposalsProposalCategoryRow right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
