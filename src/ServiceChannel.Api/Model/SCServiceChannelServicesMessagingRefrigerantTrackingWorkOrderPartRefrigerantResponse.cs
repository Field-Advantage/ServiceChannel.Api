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
    /// SCServiceChannelServicesMessagingRefrigerantTrackingWorkOrderPartRefrigerantResponse
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.RefrigerantTracking.WorkOrderPartRefrigerantResponse")]
    public partial class SCServiceChannelServicesMessagingRefrigerantTrackingWorkOrderPartRefrigerantResponse : IEquatable<SCServiceChannelServicesMessagingRefrigerantTrackingWorkOrderPartRefrigerantResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingRefrigerantTrackingWorkOrderPartRefrigerantResponse" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="assetId">assetId.</param>
        /// <param name="tagId">tagId.</param>
        /// <param name="recId">recId.</param>
        /// <param name="certifiedTechnicianId">certifiedTechnicianId.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="quantityMetrics">quantityMetrics.</param>
        /// <param name="quantityStr">quantityStr.</param>
        /// <param name="unitCost">unitCost.</param>
        /// <param name="isRefrigerant">isRefrigerant (default to false).</param>
        /// <param name="isInventoryPart">isInventoryPart (default to false).</param>
        /// <param name="useDate">useDate.</param>
        /// <param name="reasonCode">reasonCode.</param>
        /// <param name="reasonCodeId">reasonCodeId.</param>
        /// <param name="partNumber">partNumber.</param>
        /// <param name="description">description.</param>
        /// <param name="wOStatus">wOStatus.</param>
        /// <param name="problemType">problemType.</param>
        /// <param name="inventoryLocationId">inventoryLocationId.</param>
        /// <param name="inventoryLocationGuid">GUID of inventory part location.</param>
        /// <param name="inventoryLocationName">inventoryLocationName.</param>
        /// <param name="inventoryPartId">inventoryPartId.</param>
        /// <param name="partName">partName.</param>
        /// <param name="partGroup">partGroup.</param>
        /// <param name="supplierName">supplierName.</param>
        /// <param name="refrigerantChargeOptionsId">refrigerantChargeOptionsId.</param>
        /// <param name="refrigerantChargeVendor">refrigerantChargeVendor.</param>
        /// <param name="reasonCodeStr">reasonCodeStr.</param>
        /// <param name="refrigerantUsePurpose">refrigerantUsePurpose.</param>
        /// <param name="refrigerantTypeName">refrigerantTypeName.</param>
        /// <param name="refrigerantTypeId">refrigerantTypeId.</param>
        /// <param name="isSupplierPart">isSupplierPart (default to false).</param>
        /// <param name="isConnectorWOPart">isConnectorWOPart (default to false).</param>
        /// <param name="subscriberTrackingNumber">subscriberTrackingNumber.</param>
        /// <param name="subscriberAssetId">subscriberAssetId.</param>
        /// <param name="createdByUserId">createdByUserId.</param>
        /// <param name="modifiedByUserId">modifiedByUserId.</param>
        /// <param name="isRetrofit">isRetrofit.</param>
        /// <param name="refrigerantPartNumber">refrigerantPartNumber.</param>
        /// <param name="inventoryLocations">inventoryLocations.</param>
        /// <param name="supplierPartId">supplierPartId.</param>
        public SCServiceChannelServicesMessagingRefrigerantTrackingWorkOrderPartRefrigerantResponse(int id = default(int), int assetId = default(int), string tagId = default(string), int recId = default(int), int certifiedTechnicianId = default(int), double quantity = default(double), double quantityMetrics = default(double), string quantityStr = default(string), double unitCost = default(double), bool isRefrigerant = false, bool isInventoryPart = false, DateTime useDate = default(DateTime), int reasonCode = default(int), int reasonCodeId = default(int), string partNumber = default(string), string description = default(string), string wOStatus = default(string), string problemType = default(string), int inventoryLocationId = default(int), string inventoryLocationGuid = default(string), string inventoryLocationName = default(string), int inventoryPartId = default(int), string partName = default(string), string partGroup = default(string), string supplierName = default(string), int refrigerantChargeOptionsId = default(int), string refrigerantChargeVendor = default(string), string reasonCodeStr = default(string), int refrigerantUsePurpose = default(int), string refrigerantTypeName = default(string), int refrigerantTypeId = default(int), bool isSupplierPart = false, bool isConnectorWOPart = false, int subscriberTrackingNumber = default(int), int subscriberAssetId = default(int), string createdByUserId = default(string), string modifiedByUserId = default(string), byte[] isRetrofit = default(byte[]), string refrigerantPartNumber = default(string), List<SCServiceChannelServicesMessagingInventoryInventoryLocation> inventoryLocations = default(List<SCServiceChannelServicesMessagingInventoryInventoryLocation>), string supplierPartId = default(string))
        {
            this.Id = id;
            this.AssetId = assetId;
            this.TagId = tagId;
            this.RecId = recId;
            this.CertifiedTechnicianId = certifiedTechnicianId;
            this.Quantity = quantity;
            this.QuantityMetrics = quantityMetrics;
            this.QuantityStr = quantityStr;
            this.UnitCost = unitCost;
            this.IsRefrigerant = isRefrigerant;
            this.IsInventoryPart = isInventoryPart;
            this.UseDate = useDate;
            this.ReasonCode = reasonCode;
            this.ReasonCodeId = reasonCodeId;
            this.PartNumber = partNumber;
            this.Description = description;
            this.WOStatus = wOStatus;
            this.ProblemType = problemType;
            this.InventoryLocationId = inventoryLocationId;
            this.InventoryLocationGuid = inventoryLocationGuid;
            this.InventoryLocationName = inventoryLocationName;
            this.InventoryPartId = inventoryPartId;
            this.PartName = partName;
            this.PartGroup = partGroup;
            this.SupplierName = supplierName;
            this.RefrigerantChargeOptionsId = refrigerantChargeOptionsId;
            this.RefrigerantChargeVendor = refrigerantChargeVendor;
            this.ReasonCodeStr = reasonCodeStr;
            this.RefrigerantUsePurpose = refrigerantUsePurpose;
            this.RefrigerantTypeName = refrigerantTypeName;
            this.RefrigerantTypeId = refrigerantTypeId;
            this.IsSupplierPart = isSupplierPart;
            this.IsConnectorWOPart = isConnectorWOPart;
            this.SubscriberTrackingNumber = subscriberTrackingNumber;
            this.SubscriberAssetId = subscriberAssetId;
            this.CreatedByUserId = createdByUserId;
            this.ModifiedByUserId = modifiedByUserId;
            this.IsRetrofit = isRetrofit;
            this.RefrigerantPartNumber = refrigerantPartNumber;
            this.InventoryLocations = inventoryLocations;
            this.SupplierPartId = supplierPartId;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets AssetId
        /// </summary>
        [DataMember(Name = "AssetId", EmitDefaultValue = false)]
        public int AssetId { get; set; }

        /// <summary>
        /// Gets or Sets TagId
        /// </summary>
        [DataMember(Name = "TagId", EmitDefaultValue = false)]
        public string TagId { get; set; }

        /// <summary>
        /// Gets or Sets RecId
        /// </summary>
        [DataMember(Name = "RecId", EmitDefaultValue = false)]
        public int RecId { get; set; }

        /// <summary>
        /// Gets or Sets CertifiedTechnicianId
        /// </summary>
        [DataMember(Name = "CertifiedTechnicianId", EmitDefaultValue = false)]
        public int CertifiedTechnicianId { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "Quantity", EmitDefaultValue = false)]
        public double Quantity { get; set; }

        /// <summary>
        /// Gets or Sets QuantityMetrics
        /// </summary>
        [DataMember(Name = "QuantityMetrics", EmitDefaultValue = false)]
        public double QuantityMetrics { get; set; }

        /// <summary>
        /// Gets or Sets QuantityStr
        /// </summary>
        [DataMember(Name = "QuantityStr", EmitDefaultValue = false)]
        public string QuantityStr { get; set; }

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
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "Description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets WOStatus
        /// </summary>
        [DataMember(Name = "WOStatus", EmitDefaultValue = false)]
        public string WOStatus { get; set; }

        /// <summary>
        /// Gets or Sets ProblemType
        /// </summary>
        [DataMember(Name = "ProblemType", EmitDefaultValue = false)]
        public string ProblemType { get; set; }

        /// <summary>
        /// Gets or Sets InventoryLocationId
        /// </summary>
        [DataMember(Name = "InventoryLocationId", EmitDefaultValue = false)]
        public int InventoryLocationId { get; set; }

        /// <summary>
        /// GUID of inventory part location
        /// </summary>
        /// <value>GUID of inventory part location</value>
        [DataMember(Name = "InventoryLocationGuid", EmitDefaultValue = false)]
        public string InventoryLocationGuid { get; set; }

        /// <summary>
        /// Gets or Sets InventoryLocationName
        /// </summary>
        [DataMember(Name = "InventoryLocationName", EmitDefaultValue = false)]
        public string InventoryLocationName { get; set; }

        /// <summary>
        /// Gets or Sets InventoryPartId
        /// </summary>
        [DataMember(Name = "InventoryPartId", EmitDefaultValue = false)]
        public int InventoryPartId { get; set; }

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
        /// Gets or Sets ReasonCodeStr
        /// </summary>
        [DataMember(Name = "ReasonCodeStr", EmitDefaultValue = false)]
        public string ReasonCodeStr { get; set; }

        /// <summary>
        /// Gets or Sets RefrigerantUsePurpose
        /// </summary>
        [DataMember(Name = "RefrigerantUsePurpose", EmitDefaultValue = false)]
        public int RefrigerantUsePurpose { get; set; }

        /// <summary>
        /// Gets or Sets RefrigerantTypeName
        /// </summary>
        [DataMember(Name = "RefrigerantTypeName", EmitDefaultValue = false)]
        public string RefrigerantTypeName { get; set; }

        /// <summary>
        /// Gets or Sets RefrigerantTypeId
        /// </summary>
        [DataMember(Name = "RefrigerantTypeId", EmitDefaultValue = false)]
        public int RefrigerantTypeId { get; set; }

        /// <summary>
        /// Gets or Sets IsSupplierPart
        /// </summary>
        [DataMember(Name = "IsSupplierPart", EmitDefaultValue = true)]
        public bool IsSupplierPart { get; set; }

        /// <summary>
        /// Gets or Sets IsConnectorWOPart
        /// </summary>
        [DataMember(Name = "IsConnectorWOPart", EmitDefaultValue = true)]
        public bool IsConnectorWOPart { get; set; }

        /// <summary>
        /// Gets or Sets SubscriberTrackingNumber
        /// </summary>
        [DataMember(Name = "SubscriberTrackingNumber", EmitDefaultValue = false)]
        public int SubscriberTrackingNumber { get; set; }

        /// <summary>
        /// Gets or Sets SubscriberAssetId
        /// </summary>
        [DataMember(Name = "SubscriberAssetId", EmitDefaultValue = false)]
        public int SubscriberAssetId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedByUserId
        /// </summary>
        [DataMember(Name = "CreatedByUserId", EmitDefaultValue = false)]
        public string CreatedByUserId { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedByUserId
        /// </summary>
        [DataMember(Name = "ModifiedByUserId", EmitDefaultValue = false)]
        public string ModifiedByUserId { get; set; }

        /// <summary>
        /// Gets or Sets IsRetrofit
        /// </summary>
        [DataMember(Name = "IsRetrofit", EmitDefaultValue = false)]
        public byte[] IsRetrofit { get; set; }

        /// <summary>
        /// Gets or Sets RefrigerantPartNumber
        /// </summary>
        [DataMember(Name = "RefrigerantPartNumber", EmitDefaultValue = false)]
        public string RefrigerantPartNumber { get; set; }

        /// <summary>
        /// Gets or Sets InventoryLocations
        /// </summary>
        [DataMember(Name = "InventoryLocations", EmitDefaultValue = false)]
        public List<SCServiceChannelServicesMessagingInventoryInventoryLocation> InventoryLocations { get; set; }

        /// <summary>
        /// Gets or Sets SupplierPartId
        /// </summary>
        [DataMember(Name = "SupplierPartId", EmitDefaultValue = false)]
        public string SupplierPartId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingRefrigerantTrackingWorkOrderPartRefrigerantResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  TagId: ").Append(TagId).Append("\n");
            sb.Append("  RecId: ").Append(RecId).Append("\n");
            sb.Append("  CertifiedTechnicianId: ").Append(CertifiedTechnicianId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  QuantityMetrics: ").Append(QuantityMetrics).Append("\n");
            sb.Append("  QuantityStr: ").Append(QuantityStr).Append("\n");
            sb.Append("  UnitCost: ").Append(UnitCost).Append("\n");
            sb.Append("  IsRefrigerant: ").Append(IsRefrigerant).Append("\n");
            sb.Append("  IsInventoryPart: ").Append(IsInventoryPart).Append("\n");
            sb.Append("  UseDate: ").Append(UseDate).Append("\n");
            sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
            sb.Append("  ReasonCodeId: ").Append(ReasonCodeId).Append("\n");
            sb.Append("  PartNumber: ").Append(PartNumber).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  WOStatus: ").Append(WOStatus).Append("\n");
            sb.Append("  ProblemType: ").Append(ProblemType).Append("\n");
            sb.Append("  InventoryLocationId: ").Append(InventoryLocationId).Append("\n");
            sb.Append("  InventoryLocationGuid: ").Append(InventoryLocationGuid).Append("\n");
            sb.Append("  InventoryLocationName: ").Append(InventoryLocationName).Append("\n");
            sb.Append("  InventoryPartId: ").Append(InventoryPartId).Append("\n");
            sb.Append("  PartName: ").Append(PartName).Append("\n");
            sb.Append("  PartGroup: ").Append(PartGroup).Append("\n");
            sb.Append("  SupplierName: ").Append(SupplierName).Append("\n");
            sb.Append("  RefrigerantChargeOptionsId: ").Append(RefrigerantChargeOptionsId).Append("\n");
            sb.Append("  RefrigerantChargeVendor: ").Append(RefrigerantChargeVendor).Append("\n");
            sb.Append("  ReasonCodeStr: ").Append(ReasonCodeStr).Append("\n");
            sb.Append("  RefrigerantUsePurpose: ").Append(RefrigerantUsePurpose).Append("\n");
            sb.Append("  RefrigerantTypeName: ").Append(RefrigerantTypeName).Append("\n");
            sb.Append("  RefrigerantTypeId: ").Append(RefrigerantTypeId).Append("\n");
            sb.Append("  IsSupplierPart: ").Append(IsSupplierPart).Append("\n");
            sb.Append("  IsConnectorWOPart: ").Append(IsConnectorWOPart).Append("\n");
            sb.Append("  SubscriberTrackingNumber: ").Append(SubscriberTrackingNumber).Append("\n");
            sb.Append("  SubscriberAssetId: ").Append(SubscriberAssetId).Append("\n");
            sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
            sb.Append("  ModifiedByUserId: ").Append(ModifiedByUserId).Append("\n");
            sb.Append("  IsRetrofit: ").Append(IsRetrofit).Append("\n");
            sb.Append("  RefrigerantPartNumber: ").Append(RefrigerantPartNumber).Append("\n");
            sb.Append("  InventoryLocations: ").Append(InventoryLocations).Append("\n");
            sb.Append("  SupplierPartId: ").Append(SupplierPartId).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingRefrigerantTrackingWorkOrderPartRefrigerantResponse);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingRefrigerantTrackingWorkOrderPartRefrigerantResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingRefrigerantTrackingWorkOrderPartRefrigerantResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingRefrigerantTrackingWorkOrderPartRefrigerantResponse input)
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
                    this.AssetId == input.AssetId ||
                    this.AssetId.Equals(input.AssetId)
                ) && 
                (
                    this.TagId == input.TagId ||
                    (this.TagId != null &&
                    this.TagId.Equals(input.TagId))
                ) && 
                (
                    this.RecId == input.RecId ||
                    this.RecId.Equals(input.RecId)
                ) && 
                (
                    this.CertifiedTechnicianId == input.CertifiedTechnicianId ||
                    this.CertifiedTechnicianId.Equals(input.CertifiedTechnicianId)
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.QuantityMetrics == input.QuantityMetrics ||
                    this.QuantityMetrics.Equals(input.QuantityMetrics)
                ) && 
                (
                    this.QuantityStr == input.QuantityStr ||
                    (this.QuantityStr != null &&
                    this.QuantityStr.Equals(input.QuantityStr))
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.WOStatus == input.WOStatus ||
                    (this.WOStatus != null &&
                    this.WOStatus.Equals(input.WOStatus))
                ) && 
                (
                    this.ProblemType == input.ProblemType ||
                    (this.ProblemType != null &&
                    this.ProblemType.Equals(input.ProblemType))
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
                    this.InventoryLocationName == input.InventoryLocationName ||
                    (this.InventoryLocationName != null &&
                    this.InventoryLocationName.Equals(input.InventoryLocationName))
                ) && 
                (
                    this.InventoryPartId == input.InventoryPartId ||
                    this.InventoryPartId.Equals(input.InventoryPartId)
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
                    this.RefrigerantChargeOptionsId == input.RefrigerantChargeOptionsId ||
                    this.RefrigerantChargeOptionsId.Equals(input.RefrigerantChargeOptionsId)
                ) && 
                (
                    this.RefrigerantChargeVendor == input.RefrigerantChargeVendor ||
                    (this.RefrigerantChargeVendor != null &&
                    this.RefrigerantChargeVendor.Equals(input.RefrigerantChargeVendor))
                ) && 
                (
                    this.ReasonCodeStr == input.ReasonCodeStr ||
                    (this.ReasonCodeStr != null &&
                    this.ReasonCodeStr.Equals(input.ReasonCodeStr))
                ) && 
                (
                    this.RefrigerantUsePurpose == input.RefrigerantUsePurpose ||
                    this.RefrigerantUsePurpose.Equals(input.RefrigerantUsePurpose)
                ) && 
                (
                    this.RefrigerantTypeName == input.RefrigerantTypeName ||
                    (this.RefrigerantTypeName != null &&
                    this.RefrigerantTypeName.Equals(input.RefrigerantTypeName))
                ) && 
                (
                    this.RefrigerantTypeId == input.RefrigerantTypeId ||
                    this.RefrigerantTypeId.Equals(input.RefrigerantTypeId)
                ) && 
                (
                    this.IsSupplierPart == input.IsSupplierPart ||
                    this.IsSupplierPart.Equals(input.IsSupplierPart)
                ) && 
                (
                    this.IsConnectorWOPart == input.IsConnectorWOPart ||
                    this.IsConnectorWOPart.Equals(input.IsConnectorWOPart)
                ) && 
                (
                    this.SubscriberTrackingNumber == input.SubscriberTrackingNumber ||
                    this.SubscriberTrackingNumber.Equals(input.SubscriberTrackingNumber)
                ) && 
                (
                    this.SubscriberAssetId == input.SubscriberAssetId ||
                    this.SubscriberAssetId.Equals(input.SubscriberAssetId)
                ) && 
                (
                    this.CreatedByUserId == input.CreatedByUserId ||
                    (this.CreatedByUserId != null &&
                    this.CreatedByUserId.Equals(input.CreatedByUserId))
                ) && 
                (
                    this.ModifiedByUserId == input.ModifiedByUserId ||
                    (this.ModifiedByUserId != null &&
                    this.ModifiedByUserId.Equals(input.ModifiedByUserId))
                ) && 
                (
                    this.IsRetrofit == input.IsRetrofit ||
                    (this.IsRetrofit != null &&
                    this.IsRetrofit.Equals(input.IsRetrofit))
                ) && 
                (
                    this.RefrigerantPartNumber == input.RefrigerantPartNumber ||
                    (this.RefrigerantPartNumber != null &&
                    this.RefrigerantPartNumber.Equals(input.RefrigerantPartNumber))
                ) && 
                (
                    this.InventoryLocations == input.InventoryLocations ||
                    this.InventoryLocations != null &&
                    input.InventoryLocations != null &&
                    this.InventoryLocations.SequenceEqual(input.InventoryLocations)
                ) && 
                (
                    this.SupplierPartId == input.SupplierPartId ||
                    (this.SupplierPartId != null &&
                    this.SupplierPartId.Equals(input.SupplierPartId))
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
                hashCode = (hashCode * 59) + this.AssetId.GetHashCode();
                if (this.TagId != null)
                {
                    hashCode = (hashCode * 59) + this.TagId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RecId.GetHashCode();
                hashCode = (hashCode * 59) + this.CertifiedTechnicianId.GetHashCode();
                hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
                hashCode = (hashCode * 59) + this.QuantityMetrics.GetHashCode();
                if (this.QuantityStr != null)
                {
                    hashCode = (hashCode * 59) + this.QuantityStr.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UnitCost.GetHashCode();
                hashCode = (hashCode * 59) + this.IsRefrigerant.GetHashCode();
                hashCode = (hashCode * 59) + this.IsInventoryPart.GetHashCode();
                if (this.UseDate != null)
                {
                    hashCode = (hashCode * 59) + this.UseDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ReasonCode.GetHashCode();
                hashCode = (hashCode * 59) + this.ReasonCodeId.GetHashCode();
                if (this.PartNumber != null)
                {
                    hashCode = (hashCode * 59) + this.PartNumber.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.WOStatus != null)
                {
                    hashCode = (hashCode * 59) + this.WOStatus.GetHashCode();
                }
                if (this.ProblemType != null)
                {
                    hashCode = (hashCode * 59) + this.ProblemType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InventoryLocationId.GetHashCode();
                if (this.InventoryLocationGuid != null)
                {
                    hashCode = (hashCode * 59) + this.InventoryLocationGuid.GetHashCode();
                }
                if (this.InventoryLocationName != null)
                {
                    hashCode = (hashCode * 59) + this.InventoryLocationName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InventoryPartId.GetHashCode();
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
                hashCode = (hashCode * 59) + this.RefrigerantChargeOptionsId.GetHashCode();
                if (this.RefrigerantChargeVendor != null)
                {
                    hashCode = (hashCode * 59) + this.RefrigerantChargeVendor.GetHashCode();
                }
                if (this.ReasonCodeStr != null)
                {
                    hashCode = (hashCode * 59) + this.ReasonCodeStr.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RefrigerantUsePurpose.GetHashCode();
                if (this.RefrigerantTypeName != null)
                {
                    hashCode = (hashCode * 59) + this.RefrigerantTypeName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RefrigerantTypeId.GetHashCode();
                hashCode = (hashCode * 59) + this.IsSupplierPart.GetHashCode();
                hashCode = (hashCode * 59) + this.IsConnectorWOPart.GetHashCode();
                hashCode = (hashCode * 59) + this.SubscriberTrackingNumber.GetHashCode();
                hashCode = (hashCode * 59) + this.SubscriberAssetId.GetHashCode();
                if (this.CreatedByUserId != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedByUserId.GetHashCode();
                }
                if (this.ModifiedByUserId != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedByUserId.GetHashCode();
                }
                if (this.IsRetrofit != null)
                {
                    hashCode = (hashCode * 59) + this.IsRetrofit.GetHashCode();
                }
                if (this.RefrigerantPartNumber != null)
                {
                    hashCode = (hashCode * 59) + this.RefrigerantPartNumber.GetHashCode();
                }
                if (this.InventoryLocations != null)
                {
                    hashCode = (hashCode * 59) + this.InventoryLocations.GetHashCode();
                }
                if (this.SupplierPartId != null)
                {
                    hashCode = (hashCode * 59) + this.SupplierPartId.GetHashCode();
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