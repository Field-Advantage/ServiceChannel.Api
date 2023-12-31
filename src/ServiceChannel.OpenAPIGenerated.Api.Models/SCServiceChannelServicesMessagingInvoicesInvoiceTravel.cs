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
    /// Information on the trip.
    /// </summary>
    [DataContract]
    public class SCServiceChannelServicesMessagingInvoicesInvoiceTravel : IEquatable<SCServiceChannelServicesMessagingInvoicesInvoiceTravel>
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=true)]
        public int Id { get; set; }

        /// <summary>
        /// Invoice identifier.
        /// </summary>
        /// <value>Invoice identifier.</value>
        [DataMember(Name="InvoiceId", EmitDefaultValue=true)]
        public int InvoiceId { get; set; }

        /// <summary>
        /// Description of the trip.
        /// </summary>
        /// <value>Description of the trip.</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Unit of measurement.
        /// </summary>
        /// <value>Unit of measurement.</value>
        [RegularExpression("^(?:[A-Za-z0-9+/]{4})*(?:[A-Za-z0-9+/]{2}==|[A-Za-z0-9+/]{3}=)?$")]
        [DataMember(Name="UnitType", EmitDefaultValue=false)]
        public byte[] UnitType { get; set; }

        /// <summary>
        /// Price per unit.
        /// </summary>
        /// <value>Price per unit.</value>
        [DataMember(Name="UnitPrice", EmitDefaultValue=true)]
        public double UnitPrice { get; set; }

        /// <summary>
        /// Quantity.
        /// </summary>
        /// <value>Quantity.</value>
        [DataMember(Name="Quantity", EmitDefaultValue=true)]
        public double Quantity { get; set; }

        /// <summary>
        /// The amount of the trip cost. The sum of all &#x60;Amount&#x60; parameters in the &#x60;Travels&#x60; array must equal &#x60;InvoiceAmountsDetails.TravelAmount&#x60;.
        /// </summary>
        /// <value>The amount of the trip cost. The sum of all &#x60;Amount&#x60; parameters in the &#x60;Travels&#x60; array must equal &#x60;InvoiceAmountsDetails.TravelAmount&#x60;.</value>
        [DataMember(Name="Amount", EmitDefaultValue=true)]
        public double Amount { get; set; }

        /// <summary>
        /// Type of the shore (&#x60;1&#x60; - Onshore, &#x60;2&#x60; - Offshore).
        /// </summary>
        /// <value>Type of the shore (&#x60;1&#x60; - Onshore, &#x60;2&#x60; - Offshore).</value>
        [DataMember(Name="IsOffShore", EmitDefaultValue=true)]
        public bool IsOffShore { get; set; } = false;

        /// <summary>
        /// Gets or Sets ApprovalCodeGroup
        /// </summary>
        [DataMember(Name="ApprovalCodeGroup", EmitDefaultValue=false)]
        public SCServiceChannelServicesMessagingInvoicesInvoiceApprovalCodeGroup ApprovalCodeGroup { get; set; }

        /// <summary>
        /// Gets or Sets IsNontaxableVATEU
        /// </summary>
        [DataMember(Name="isNontaxableVATEU", EmitDefaultValue=true)]
        public bool IsNontaxableVATEU { get; set; } = false;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingInvoicesInvoiceTravel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  UnitType: ").Append(UnitType).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  IsOffShore: ").Append(IsOffShore).Append("\n");
            sb.Append("  ApprovalCodeGroup: ").Append(ApprovalCodeGroup).Append("\n");
            sb.Append("  IsNontaxableVATEU: ").Append(IsNontaxableVATEU).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingInvoicesInvoiceTravel)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingInvoicesInvoiceTravel instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingInvoicesInvoiceTravel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingInvoicesInvoiceTravel other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    InvoiceId == other.InvoiceId ||
                    
                    InvoiceId.Equals(other.InvoiceId)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    UnitType == other.UnitType ||
                    UnitType != null &&
                    UnitType.Equals(other.UnitType)
                ) && 
                (
                    UnitPrice == other.UnitPrice ||
                    
                    UnitPrice.Equals(other.UnitPrice)
                ) && 
                (
                    Quantity == other.Quantity ||
                    
                    Quantity.Equals(other.Quantity)
                ) && 
                (
                    Amount == other.Amount ||
                    
                    Amount.Equals(other.Amount)
                ) && 
                (
                    IsOffShore == other.IsOffShore ||
                    
                    IsOffShore.Equals(other.IsOffShore)
                ) && 
                (
                    ApprovalCodeGroup == other.ApprovalCodeGroup ||
                    ApprovalCodeGroup != null &&
                    ApprovalCodeGroup.Equals(other.ApprovalCodeGroup)
                ) && 
                (
                    IsNontaxableVATEU == other.IsNontaxableVATEU ||
                    
                    IsNontaxableVATEU.Equals(other.IsNontaxableVATEU)
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
                    
                    hashCode = hashCode * 59 + InvoiceId.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (UnitType != null)
                    hashCode = hashCode * 59 + UnitType.GetHashCode();
                    
                    hashCode = hashCode * 59 + UnitPrice.GetHashCode();
                    
                    hashCode = hashCode * 59 + Quantity.GetHashCode();
                    
                    hashCode = hashCode * 59 + Amount.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsOffShore.GetHashCode();
                    if (ApprovalCodeGroup != null)
                    hashCode = hashCode * 59 + ApprovalCodeGroup.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsNontaxableVATEU.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingInvoicesInvoiceTravel left, SCServiceChannelServicesMessagingInvoicesInvoiceTravel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingInvoicesInvoiceTravel left, SCServiceChannelServicesMessagingInvoicesInvoiceTravel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
