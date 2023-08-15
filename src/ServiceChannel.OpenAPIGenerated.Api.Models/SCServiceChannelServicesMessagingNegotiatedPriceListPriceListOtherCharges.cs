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
    /// PriceListOtherCharges
    /// </summary>
    [DataContract]
    public class SCServiceChannelServicesMessagingNegotiatedPriceListPriceListOtherCharges : IEquatable<SCServiceChannelServicesMessagingNegotiatedPriceListPriceListOtherCharges>
    {
        /// <summary>
        /// Id
        /// </summary>
        /// <value>Id</value>
        [DataMember(Name="Id", EmitDefaultValue=true)]
        public int Id { get; set; }

        /// <summary>
        /// PriceListId
        /// </summary>
        /// <value>PriceListId</value>
        [DataMember(Name="PriceListId", EmitDefaultValue=true)]
        public int PriceListId { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        /// <value>Type</value>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// UnitOfMeasure
        /// </summary>
        /// <value>UnitOfMeasure</value>
        [DataMember(Name="UnitOfMeasure", EmitDefaultValue=false)]
        public string UnitOfMeasure { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        /// <value>Price</value>
        [DataMember(Name="Price", EmitDefaultValue=true)]
        public double Price { get; set; }

        /// <summary>
        /// PriceListName
        /// </summary>
        /// <value>PriceListName</value>
        [DataMember(Name="PriceListName", EmitDefaultValue=false)]
        public string PriceListName { get; set; }

        /// <summary>
        /// Is Deleted
        /// </summary>
        /// <value>Is Deleted</value>
        [DataMember(Name="IsDeleted", EmitDefaultValue=true)]
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingNegotiatedPriceListPriceListOtherCharges {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PriceListId: ").Append(PriceListId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  PriceListName: ").Append(PriceListName).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingNegotiatedPriceListPriceListOtherCharges)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingNegotiatedPriceListPriceListOtherCharges instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingNegotiatedPriceListPriceListOtherCharges to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingNegotiatedPriceListPriceListOtherCharges other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    PriceListId == other.PriceListId ||
                    
                    PriceListId.Equals(other.PriceListId)
                ) && 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    UnitOfMeasure == other.UnitOfMeasure ||
                    UnitOfMeasure != null &&
                    UnitOfMeasure.Equals(other.UnitOfMeasure)
                ) && 
                (
                    Price == other.Price ||
                    
                    Price.Equals(other.Price)
                ) && 
                (
                    PriceListName == other.PriceListName ||
                    PriceListName != null &&
                    PriceListName.Equals(other.PriceListName)
                ) && 
                (
                    IsDeleted == other.IsDeleted ||
                    
                    IsDeleted.Equals(other.IsDeleted)
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
                    
                    hashCode = hashCode * 59 + PriceListId.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (UnitOfMeasure != null)
                    hashCode = hashCode * 59 + UnitOfMeasure.GetHashCode();
                    
                    hashCode = hashCode * 59 + Price.GetHashCode();
                    if (PriceListName != null)
                    hashCode = hashCode * 59 + PriceListName.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsDeleted.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingNegotiatedPriceListPriceListOtherCharges left, SCServiceChannelServicesMessagingNegotiatedPriceListPriceListOtherCharges right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingNegotiatedPriceListPriceListOtherCharges left, SCServiceChannelServicesMessagingNegotiatedPriceListPriceListOtherCharges right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}