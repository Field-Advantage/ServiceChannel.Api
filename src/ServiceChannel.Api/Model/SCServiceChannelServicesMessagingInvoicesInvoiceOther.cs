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
    /// The invoices material
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.Invoices.InvoiceOther")]
    public partial class SCServiceChannelServicesMessagingInvoicesInvoiceOther : IEquatable<SCServiceChannelServicesMessagingInvoicesInvoiceOther>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingInvoicesInvoiceOther" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="invoiceId">Invoice identifier..</param>
        /// <param name="description">Get or set description..</param>
        /// <param name="type">Get or set type of charge..</param>
        /// <param name="amount">Get or set the amount of money that is charged..</param>
        /// <param name="unitType">Get or set the unit of measure.</param>
        /// <param name="unitPrice">Get or set the price of unit.</param>
        /// <param name="quantity">Get or set the quantity.</param>
        /// <param name="agreedUnitPrice">Get or set the AgreedUnitPrice.</param>
        /// <param name="unitPriceDiscrepancyReason">UnitPriceDiscrepancyReason.</param>
        /// <param name="priceListOtherChargeId">Get or set the PriceListOtherChargeId.</param>
        /// <param name="approvalCodeGroup">approvalCodeGroup.</param>
        /// <param name="isNontaxableVATEU">isNontaxableVATEU (default to false).</param>
        public SCServiceChannelServicesMessagingInvoicesInvoiceOther(int id = default(int), int invoiceId = default(int), string description = default(string), string type = default(string), double amount = default(double), byte[] unitType = default(byte[]), double unitPrice = default(double), double quantity = default(double), double agreedUnitPrice = default(double), string unitPriceDiscrepancyReason = default(string), int priceListOtherChargeId = default(int), SCServiceChannelServicesMessagingInvoicesInvoiceApprovalCodeGroup approvalCodeGroup = default(SCServiceChannelServicesMessagingInvoicesInvoiceApprovalCodeGroup), bool isNontaxableVATEU = false)
        {
            this.Id = id;
            this.InvoiceId = invoiceId;
            this.Description = description;
            this.Type = type;
            this.Amount = amount;
            this.UnitType = unitType;
            this.UnitPrice = unitPrice;
            this.Quantity = quantity;
            this.AgreedUnitPrice = agreedUnitPrice;
            this.UnitPriceDiscrepancyReason = unitPriceDiscrepancyReason;
            this.PriceListOtherChargeId = priceListOtherChargeId;
            this.ApprovalCodeGroup = approvalCodeGroup;
            this.IsNontaxableVATEU = isNontaxableVATEU;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Invoice identifier.
        /// </summary>
        /// <value>Invoice identifier.</value>
        [DataMember(Name = "InvoiceId", EmitDefaultValue = false)]
        public int InvoiceId { get; set; }

        /// <summary>
        /// Get or set description.
        /// </summary>
        /// <value>Get or set description.</value>
        [DataMember(Name = "Description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Get or set type of charge.
        /// </summary>
        /// <value>Get or set type of charge.</value>
        [DataMember(Name = "Type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Get or set the amount of money that is charged.
        /// </summary>
        /// <value>Get or set the amount of money that is charged.</value>
        [DataMember(Name = "Amount", EmitDefaultValue = false)]
        public double Amount { get; set; }

        /// <summary>
        /// Get or set the unit of measure
        /// </summary>
        /// <value>Get or set the unit of measure</value>
        [DataMember(Name = "UnitType", EmitDefaultValue = false)]
        public byte[] UnitType { get; set; }

        /// <summary>
        /// Get or set the price of unit
        /// </summary>
        /// <value>Get or set the price of unit</value>
        [DataMember(Name = "UnitPrice", EmitDefaultValue = false)]
        public double UnitPrice { get; set; }

        /// <summary>
        /// Get or set the quantity
        /// </summary>
        /// <value>Get or set the quantity</value>
        [DataMember(Name = "Quantity", EmitDefaultValue = false)]
        public double Quantity { get; set; }

        /// <summary>
        /// Get or set the AgreedUnitPrice
        /// </summary>
        /// <value>Get or set the AgreedUnitPrice</value>
        [DataMember(Name = "AgreedUnitPrice", EmitDefaultValue = false)]
        public double AgreedUnitPrice { get; set; }

        /// <summary>
        /// UnitPriceDiscrepancyReason
        /// </summary>
        /// <value>UnitPriceDiscrepancyReason</value>
        [DataMember(Name = "UnitPriceDiscrepancyReason", EmitDefaultValue = false)]
        public string UnitPriceDiscrepancyReason { get; set; }

        /// <summary>
        /// Get or set the PriceListOtherChargeId
        /// </summary>
        /// <value>Get or set the PriceListOtherChargeId</value>
        [DataMember(Name = "PriceListOtherChargeId", EmitDefaultValue = false)]
        public int PriceListOtherChargeId { get; set; }

        /// <summary>
        /// Get IsUnitPriceDiscrepancy
        /// </summary>
        /// <value>Get IsUnitPriceDiscrepancy</value>
        [DataMember(Name = "IsUnitPriceDiscrepancy", EmitDefaultValue = true)]
        public bool IsUnitPriceDiscrepancy { get; private set; }

        /// <summary>
        /// Returns false as IsUnitPriceDiscrepancy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsUnitPriceDiscrepancy()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ApprovalCodeGroup
        /// </summary>
        [DataMember(Name = "ApprovalCodeGroup", EmitDefaultValue = false)]
        public SCServiceChannelServicesMessagingInvoicesInvoiceApprovalCodeGroup ApprovalCodeGroup { get; set; }

        /// <summary>
        /// Gets or Sets IsNontaxableVATEU
        /// </summary>
        [DataMember(Name = "isNontaxableVATEU", EmitDefaultValue = true)]
        public bool IsNontaxableVATEU { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingInvoicesInvoiceOther {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  UnitType: ").Append(UnitType).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  AgreedUnitPrice: ").Append(AgreedUnitPrice).Append("\n");
            sb.Append("  UnitPriceDiscrepancyReason: ").Append(UnitPriceDiscrepancyReason).Append("\n");
            sb.Append("  PriceListOtherChargeId: ").Append(PriceListOtherChargeId).Append("\n");
            sb.Append("  IsUnitPriceDiscrepancy: ").Append(IsUnitPriceDiscrepancy).Append("\n");
            sb.Append("  ApprovalCodeGroup: ").Append(ApprovalCodeGroup).Append("\n");
            sb.Append("  IsNontaxableVATEU: ").Append(IsNontaxableVATEU).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingInvoicesInvoiceOther);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingInvoicesInvoiceOther instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingInvoicesInvoiceOther to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingInvoicesInvoiceOther input)
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
                    this.InvoiceId == input.InvoiceId ||
                    this.InvoiceId.Equals(input.InvoiceId)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.UnitType == input.UnitType ||
                    (this.UnitType != null &&
                    this.UnitType.Equals(input.UnitType))
                ) && 
                (
                    this.UnitPrice == input.UnitPrice ||
                    this.UnitPrice.Equals(input.UnitPrice)
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.AgreedUnitPrice == input.AgreedUnitPrice ||
                    this.AgreedUnitPrice.Equals(input.AgreedUnitPrice)
                ) && 
                (
                    this.UnitPriceDiscrepancyReason == input.UnitPriceDiscrepancyReason ||
                    (this.UnitPriceDiscrepancyReason != null &&
                    this.UnitPriceDiscrepancyReason.Equals(input.UnitPriceDiscrepancyReason))
                ) && 
                (
                    this.PriceListOtherChargeId == input.PriceListOtherChargeId ||
                    this.PriceListOtherChargeId.Equals(input.PriceListOtherChargeId)
                ) && 
                (
                    this.IsUnitPriceDiscrepancy == input.IsUnitPriceDiscrepancy ||
                    this.IsUnitPriceDiscrepancy.Equals(input.IsUnitPriceDiscrepancy)
                ) && 
                (
                    this.ApprovalCodeGroup == input.ApprovalCodeGroup ||
                    (this.ApprovalCodeGroup != null &&
                    this.ApprovalCodeGroup.Equals(input.ApprovalCodeGroup))
                ) && 
                (
                    this.IsNontaxableVATEU == input.IsNontaxableVATEU ||
                    this.IsNontaxableVATEU.Equals(input.IsNontaxableVATEU)
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
                hashCode = (hashCode * 59) + this.InvoiceId.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.UnitType != null)
                {
                    hashCode = (hashCode * 59) + this.UnitType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UnitPrice.GetHashCode();
                hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
                hashCode = (hashCode * 59) + this.AgreedUnitPrice.GetHashCode();
                if (this.UnitPriceDiscrepancyReason != null)
                {
                    hashCode = (hashCode * 59) + this.UnitPriceDiscrepancyReason.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PriceListOtherChargeId.GetHashCode();
                hashCode = (hashCode * 59) + this.IsUnitPriceDiscrepancy.GetHashCode();
                if (this.ApprovalCodeGroup != null)
                {
                    hashCode = (hashCode * 59) + this.ApprovalCodeGroup.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsNontaxableVATEU.GetHashCode();
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
