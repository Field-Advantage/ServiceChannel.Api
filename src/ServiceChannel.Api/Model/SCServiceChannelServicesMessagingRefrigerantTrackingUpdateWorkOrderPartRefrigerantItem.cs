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
    /// SCServiceChannelServicesMessagingRefrigerantTrackingUpdateWorkOrderPartRefrigerantItem
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.RefrigerantTracking.UpdateWorkOrderPartRefrigerantItem")]
    public partial class SCServiceChannelServicesMessagingRefrigerantTrackingUpdateWorkOrderPartRefrigerantItem : IEquatable<SCServiceChannelServicesMessagingRefrigerantTrackingUpdateWorkOrderPartRefrigerantItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingRefrigerantTrackingUpdateWorkOrderPartRefrigerantItem" /> class.
        /// </summary>
        /// <param name="partId">partId.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="unitCost">unitCost.</param>
        /// <param name="isRefrigerant">isRefrigerant (default to false).</param>
        /// <param name="isInventoryPart">isInventoryPart (default to false).</param>
        /// <param name="useDate">useDate.</param>
        /// <param name="useDateStr">useDateStr.</param>
        /// <param name="reasonCode">reasonCode.</param>
        /// <param name="reasonCodeId">reasonCodeId.</param>
        /// <param name="partNumber">partNumber.</param>
        /// <param name="partName">partName.</param>
        /// <param name="partGroup">partGroup.</param>
        /// <param name="supplierName">supplierName.</param>
        /// <param name="description">description.</param>
        /// <param name="refrigerantChargeOptionsId">refrigerantChargeOptionsId.</param>
        /// <param name="refrigerantChargeVendor">refrigerantChargeVendor.</param>
        /// <param name="inventoryLocationId">inventoryLocationId.</param>
        /// <param name="inventoryLocationGuid">GUID of the inventory location.</param>
        /// <param name="inventoryPartId">inventoryPartId.</param>
        /// <param name="refrigerantUseReason">refrigerantUseReason.</param>
        /// <param name="submitMoeQtyExceeded">submitMoeQtyExceeded (default to false).</param>
        /// <param name="moeNumber">moeNumber.</param>
        /// <param name="recId">recId.</param>
        public SCServiceChannelServicesMessagingRefrigerantTrackingUpdateWorkOrderPartRefrigerantItem(int partId = default(int), double quantity = default(double), double unitCost = default(double), bool isRefrigerant = false, bool isInventoryPart = false, DateTime useDate = default(DateTime), string useDateStr = default(string), int reasonCode = default(int), int reasonCodeId = default(int), string partNumber = default(string), string partName = default(string), string partGroup = default(string), string supplierName = default(string), string description = default(string), int refrigerantChargeOptionsId = default(int), string refrigerantChargeVendor = default(string), int inventoryLocationId = default(int), string inventoryLocationGuid = default(string), int inventoryPartId = default(int), SCServiceChannelServicesMessagingRefrigerantTrackingRefrigerantUseReasonCode refrigerantUseReason = default(SCServiceChannelServicesMessagingRefrigerantTrackingRefrigerantUseReasonCode), bool submitMoeQtyExceeded = false, string moeNumber = default(string), int recId = default(int))
        {
            this.PartId = partId;
            this.Quantity = quantity;
            this.UnitCost = unitCost;
            this.IsRefrigerant = isRefrigerant;
            this.IsInventoryPart = isInventoryPart;
            this.UseDate = useDate;
            this.UseDateStr = useDateStr;
            this.ReasonCode = reasonCode;
            this.ReasonCodeId = reasonCodeId;
            this.PartNumber = partNumber;
            this.PartName = partName;
            this.PartGroup = partGroup;
            this.SupplierName = supplierName;
            this.Description = description;
            this.RefrigerantChargeOptionsId = refrigerantChargeOptionsId;
            this.RefrigerantChargeVendor = refrigerantChargeVendor;
            this.InventoryLocationId = inventoryLocationId;
            this.InventoryLocationGuid = inventoryLocationGuid;
            this.InventoryPartId = inventoryPartId;
            this.RefrigerantUseReason = refrigerantUseReason;
            this.SubmitMoeQtyExceeded = submitMoeQtyExceeded;
            this.MoeNumber = moeNumber;
            this.RecId = recId;
        }

        /// <summary>
        /// Gets or Sets PartId
        /// </summary>
        [DataMember(Name = "PartId", EmitDefaultValue = false)]
        public int PartId { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "Quantity", EmitDefaultValue = false)]
        public double Quantity { get; set; }

        /// <summary>
        /// Gets or Sets UnitCost
        /// </summary>
        [DataMember(Name = "UnitCost", EmitDefaultValue = false)]
        public double UnitCost { get; set; }

        /// <summary>
        /// Gets or Sets IsRefrigerant
        /// </summary>
        [DataMember(Name = "IsRefrigerant", EmitDefaultValue = true)]
        public bool IsRefrigerant { get; set; }

        /// <summary>
        /// Gets or Sets IsInventoryPart
        /// </summary>
        [DataMember(Name = "IsInventoryPart", EmitDefaultValue = true)]
        public bool IsInventoryPart { get; set; }

        /// <summary>
        /// Gets or Sets UseDate
        /// </summary>
        [DataMember(Name = "UseDate", EmitDefaultValue = false)]
        public DateTime UseDate { get; set; }

        /// <summary>
        /// Gets or Sets UseDateStr
        /// </summary>
        [DataMember(Name = "UseDateStr", EmitDefaultValue = false)]
        public string UseDateStr { get; set; }

        /// <summary>
        /// Gets or Sets ReasonCode
        /// </summary>
        [DataMember(Name = "ReasonCode", EmitDefaultValue = false)]
        public int ReasonCode { get; set; }

        /// <summary>
        /// Gets or Sets ReasonCodeId
        /// </summary>
        [DataMember(Name = "ReasonCodeId", EmitDefaultValue = false)]
        public int ReasonCodeId { get; set; }

        /// <summary>
        /// Gets or Sets PartNumber
        /// </summary>
        [DataMember(Name = "PartNumber", EmitDefaultValue = false)]
        public string PartNumber { get; set; }

        /// <summary>
        /// Gets or Sets PartName
        /// </summary>
        [DataMember(Name = "PartName", EmitDefaultValue = false)]
        public string PartName { get; set; }

        /// <summary>
        /// Gets or Sets PartGroup
        /// </summary>
        [DataMember(Name = "PartGroup", EmitDefaultValue = false)]
        public string PartGroup { get; set; }

        /// <summary>
        /// Gets or Sets SupplierName
        /// </summary>
        [DataMember(Name = "SupplierName", EmitDefaultValue = false)]
        public string SupplierName { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "Description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets RefrigerantChargeOptionsId
        /// </summary>
        [DataMember(Name = "RefrigerantChargeOptionsId", EmitDefaultValue = false)]
        public int RefrigerantChargeOptionsId { get; set; }

        /// <summary>
        /// Gets or Sets RefrigerantChargeVendor
        /// </summary>
        [DataMember(Name = "RefrigerantChargeVendor", EmitDefaultValue = false)]
        public string RefrigerantChargeVendor { get; set; }

        /// <summary>
        /// Gets or Sets InventoryLocationId
        /// </summary>
        [DataMember(Name = "InventoryLocationId", EmitDefaultValue = false)]
        public int InventoryLocationId { get; set; }

        /// <summary>
        /// GUID of the inventory location
        /// </summary>
        /// <value>GUID of the inventory location</value>
        [DataMember(Name = "InventoryLocationGuid", EmitDefaultValue = false)]
        public string InventoryLocationGuid { get; set; }

        /// <summary>
        /// Gets or Sets InventoryPartId
        /// </summary>
        [DataMember(Name = "InventoryPartId", EmitDefaultValue = false)]
        public int InventoryPartId { get; set; }

        /// <summary>
        /// Gets or Sets RefrigerantUseReason
        /// </summary>
        [DataMember(Name = "RefrigerantUseReason", EmitDefaultValue = false)]
        public SCServiceChannelServicesMessagingRefrigerantTrackingRefrigerantUseReasonCode RefrigerantUseReason { get; set; }

        /// <summary>
        /// Gets or Sets SubmitMoeQtyExceeded
        /// </summary>
        [DataMember(Name = "SubmitMoeQtyExceeded", EmitDefaultValue = true)]
        public bool SubmitMoeQtyExceeded { get; set; }

        /// <summary>
        /// Gets or Sets MoeNumber
        /// </summary>
        [DataMember(Name = "MoeNumber", EmitDefaultValue = false)]
        public string MoeNumber { get; set; }

        /// <summary>
        /// Gets or Sets RecId
        /// </summary>
        [DataMember(Name = "RecId", EmitDefaultValue = false)]
        public int RecId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingRefrigerantTrackingUpdateWorkOrderPartRefrigerantItem {\n");
            sb.Append("  PartId: ").Append(PartId).Append("\n");
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
            sb.Append("  SupplierName: ").Append(SupplierName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  RefrigerantChargeOptionsId: ").Append(RefrigerantChargeOptionsId).Append("\n");
            sb.Append("  RefrigerantChargeVendor: ").Append(RefrigerantChargeVendor).Append("\n");
            sb.Append("  InventoryLocationId: ").Append(InventoryLocationId).Append("\n");
            sb.Append("  InventoryLocationGuid: ").Append(InventoryLocationGuid).Append("\n");
            sb.Append("  InventoryPartId: ").Append(InventoryPartId).Append("\n");
            sb.Append("  RefrigerantUseReason: ").Append(RefrigerantUseReason).Append("\n");
            sb.Append("  SubmitMoeQtyExceeded: ").Append(SubmitMoeQtyExceeded).Append("\n");
            sb.Append("  MoeNumber: ").Append(MoeNumber).Append("\n");
            sb.Append("  RecId: ").Append(RecId).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingRefrigerantTrackingUpdateWorkOrderPartRefrigerantItem);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingRefrigerantTrackingUpdateWorkOrderPartRefrigerantItem instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingRefrigerantTrackingUpdateWorkOrderPartRefrigerantItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingRefrigerantTrackingUpdateWorkOrderPartRefrigerantItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PartId == input.PartId ||
                    this.PartId.Equals(input.PartId)
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.UnitCost == input.UnitCost ||
                    this.UnitCost.Equals(input.UnitCost)
                ) && 
                (
                    this.IsRefrigerant == input.IsRefrigerant ||
                    this.IsRefrigerant.Equals(input.IsRefrigerant)
                ) && 
                (
                    this.IsInventoryPart == input.IsInventoryPart ||
                    this.IsInventoryPart.Equals(input.IsInventoryPart)
                ) && 
                (
                    this.UseDate == input.UseDate ||
                    (this.UseDate != null &&
                    this.UseDate.Equals(input.UseDate))
                ) && 
                (
                    this.UseDateStr == input.UseDateStr ||
                    (this.UseDateStr != null &&
                    this.UseDateStr.Equals(input.UseDateStr))
                ) && 
                (
                    this.ReasonCode == input.ReasonCode ||
                    this.ReasonCode.Equals(input.ReasonCode)
                ) && 
                (
                    this.ReasonCodeId == input.ReasonCodeId ||
                    this.ReasonCodeId.Equals(input.ReasonCodeId)
                ) && 
                (
                    this.PartNumber == input.PartNumber ||
                    (this.PartNumber != null &&
                    this.PartNumber.Equals(input.PartNumber))
                ) && 
                (
                    this.PartName == input.PartName ||
                    (this.PartName != null &&
                    this.PartName.Equals(input.PartName))
                ) && 
                (
                    this.PartGroup == input.PartGroup ||
                    (this.PartGroup != null &&
                    this.PartGroup.Equals(input.PartGroup))
                ) && 
                (
                    this.SupplierName == input.SupplierName ||
                    (this.SupplierName != null &&
                    this.SupplierName.Equals(input.SupplierName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.RefrigerantChargeOptionsId == input.RefrigerantChargeOptionsId ||
                    this.RefrigerantChargeOptionsId.Equals(input.RefrigerantChargeOptionsId)
                ) && 
                (
                    this.RefrigerantChargeVendor == input.RefrigerantChargeVendor ||
                    (this.RefrigerantChargeVendor != null &&
                    this.RefrigerantChargeVendor.Equals(input.RefrigerantChargeVendor))
                ) && 
                (
                    this.InventoryLocationId == input.InventoryLocationId ||
                    this.InventoryLocationId.Equals(input.InventoryLocationId)
                ) && 
                (
                    this.InventoryLocationGuid == input.InventoryLocationGuid ||
                    (this.InventoryLocationGuid != null &&
                    this.InventoryLocationGuid.Equals(input.InventoryLocationGuid))
                ) && 
                (
                    this.InventoryPartId == input.InventoryPartId ||
                    this.InventoryPartId.Equals(input.InventoryPartId)
                ) && 
                (
                    this.RefrigerantUseReason == input.RefrigerantUseReason ||
                    (this.RefrigerantUseReason != null &&
                    this.RefrigerantUseReason.Equals(input.RefrigerantUseReason))
                ) && 
                (
                    this.SubmitMoeQtyExceeded == input.SubmitMoeQtyExceeded ||
                    this.SubmitMoeQtyExceeded.Equals(input.SubmitMoeQtyExceeded)
                ) && 
                (
                    this.MoeNumber == input.MoeNumber ||
                    (this.MoeNumber != null &&
                    this.MoeNumber.Equals(input.MoeNumber))
                ) && 
                (
                    this.RecId == input.RecId ||
                    this.RecId.Equals(input.RecId)
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
                hashCode = (hashCode * 59) + this.PartId.GetHashCode();
                hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
                hashCode = (hashCode * 59) + this.UnitCost.GetHashCode();
                hashCode = (hashCode * 59) + this.IsRefrigerant.GetHashCode();
                hashCode = (hashCode * 59) + this.IsInventoryPart.GetHashCode();
                if (this.UseDate != null)
                {
                    hashCode = (hashCode * 59) + this.UseDate.GetHashCode();
                }
                if (this.UseDateStr != null)
                {
                    hashCode = (hashCode * 59) + this.UseDateStr.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ReasonCode.GetHashCode();
                hashCode = (hashCode * 59) + this.ReasonCodeId.GetHashCode();
                if (this.PartNumber != null)
                {
                    hashCode = (hashCode * 59) + this.PartNumber.GetHashCode();
                }
                if (this.PartName != null)
                {
                    hashCode = (hashCode * 59) + this.PartName.GetHashCode();
                }
                if (this.PartGroup != null)
                {
                    hashCode = (hashCode * 59) + this.PartGroup.GetHashCode();
                }
                if (this.SupplierName != null)
                {
                    hashCode = (hashCode * 59) + this.SupplierName.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RefrigerantChargeOptionsId.GetHashCode();
                if (this.RefrigerantChargeVendor != null)
                {
                    hashCode = (hashCode * 59) + this.RefrigerantChargeVendor.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InventoryLocationId.GetHashCode();
                if (this.InventoryLocationGuid != null)
                {
                    hashCode = (hashCode * 59) + this.InventoryLocationGuid.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InventoryPartId.GetHashCode();
                if (this.RefrigerantUseReason != null)
                {
                    hashCode = (hashCode * 59) + this.RefrigerantUseReason.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SubmitMoeQtyExceeded.GetHashCode();
                if (this.MoeNumber != null)
                {
                    hashCode = (hashCode * 59) + this.MoeNumber.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RecId.GetHashCode();
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