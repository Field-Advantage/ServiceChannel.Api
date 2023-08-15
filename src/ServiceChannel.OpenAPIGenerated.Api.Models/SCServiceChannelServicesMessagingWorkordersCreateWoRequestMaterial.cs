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
    public class SCServiceChannelServicesMessagingWorkordersCreateWoRequestMaterial : IEquatable<SCServiceChannelServicesMessagingWorkordersCreateWoRequestMaterial>
    {
        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="Quantity", EmitDefaultValue=true)]
        public float Quantity { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="Price", EmitDefaultValue=true)]
        public double Price { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="Reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or Sets SupplierPartId
        /// </summary>
        [DataMember(Name="SupplierPartId", EmitDefaultValue=false)]
        public string SupplierPartId { get; set; }

        /// <summary>
        /// Gets or Sets SupplierPartAuxiliaryId
        /// </summary>
        [DataMember(Name="SupplierPartAuxiliaryId", EmitDefaultValue=false)]
        public string SupplierPartAuxiliaryId { get; set; }

        /// <summary>
        /// Gets or Sets SupplierName
        /// </summary>
        [DataMember(Name="SupplierName", EmitDefaultValue=false)]
        public string SupplierName { get; set; }

        /// <summary>
        /// Gets or Sets NteMultiplier
        /// </summary>
        [DataMember(Name="NteMultiplier", EmitDefaultValue=true)]
        public double NteMultiplier { get; set; }

        /// <summary>
        /// Gets or Sets DefaultNte
        /// </summary>
        [DataMember(Name="DefaultNte", EmitDefaultValue=true)]
        public double DefaultNte { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingWorkordersCreateWoRequestMaterial {\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  SupplierPartId: ").Append(SupplierPartId).Append("\n");
            sb.Append("  SupplierPartAuxiliaryId: ").Append(SupplierPartAuxiliaryId).Append("\n");
            sb.Append("  SupplierName: ").Append(SupplierName).Append("\n");
            sb.Append("  NteMultiplier: ").Append(NteMultiplier).Append("\n");
            sb.Append("  DefaultNte: ").Append(DefaultNte).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingWorkordersCreateWoRequestMaterial)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingWorkordersCreateWoRequestMaterial instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingWorkordersCreateWoRequestMaterial to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingWorkordersCreateWoRequestMaterial other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Quantity == other.Quantity ||
                    
                    Quantity.Equals(other.Quantity)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    Price == other.Price ||
                    
                    Price.Equals(other.Price)
                ) && 
                (
                    Reason == other.Reason ||
                    Reason != null &&
                    Reason.Equals(other.Reason)
                ) && 
                (
                    SupplierPartId == other.SupplierPartId ||
                    SupplierPartId != null &&
                    SupplierPartId.Equals(other.SupplierPartId)
                ) && 
                (
                    SupplierPartAuxiliaryId == other.SupplierPartAuxiliaryId ||
                    SupplierPartAuxiliaryId != null &&
                    SupplierPartAuxiliaryId.Equals(other.SupplierPartAuxiliaryId)
                ) && 
                (
                    SupplierName == other.SupplierName ||
                    SupplierName != null &&
                    SupplierName.Equals(other.SupplierName)
                ) && 
                (
                    NteMultiplier == other.NteMultiplier ||
                    
                    NteMultiplier.Equals(other.NteMultiplier)
                ) && 
                (
                    DefaultNte == other.DefaultNte ||
                    
                    DefaultNte.Equals(other.DefaultNte)
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
                    
                    hashCode = hashCode * 59 + Quantity.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    
                    hashCode = hashCode * 59 + Price.GetHashCode();
                    if (Reason != null)
                    hashCode = hashCode * 59 + Reason.GetHashCode();
                    if (SupplierPartId != null)
                    hashCode = hashCode * 59 + SupplierPartId.GetHashCode();
                    if (SupplierPartAuxiliaryId != null)
                    hashCode = hashCode * 59 + SupplierPartAuxiliaryId.GetHashCode();
                    if (SupplierName != null)
                    hashCode = hashCode * 59 + SupplierName.GetHashCode();
                    
                    hashCode = hashCode * 59 + NteMultiplier.GetHashCode();
                    
                    hashCode = hashCode * 59 + DefaultNte.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingWorkordersCreateWoRequestMaterial left, SCServiceChannelServicesMessagingWorkordersCreateWoRequestMaterial right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingWorkordersCreateWoRequestMaterial left, SCServiceChannelServicesMessagingWorkordersCreateWoRequestMaterial right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
