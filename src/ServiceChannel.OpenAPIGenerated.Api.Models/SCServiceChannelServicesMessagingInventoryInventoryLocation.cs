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
    public class SCServiceChannelServicesMessagingInventoryInventoryLocation : IEquatable<SCServiceChannelServicesMessagingInventoryInventoryLocation>
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=true)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets LocationId
        /// </summary>
        [DataMember(Name="LocationId", EmitDefaultValue=true)]
        public int LocationId { get; set; }

        /// <summary>
        /// Gets or Sets PartId
        /// </summary>
        [DataMember(Name="PartId", EmitDefaultValue=true)]
        public int PartId { get; set; }

        /// <summary>
        /// Gets or Sets Qty
        /// </summary>
        [DataMember(Name="Qty", EmitDefaultValue=true)]
        public double Qty { get; set; }

        /// <summary>
        /// Gets or Sets UnitPrice
        /// </summary>
        [DataMember(Name="UnitPrice", EmitDefaultValue=true)]
        public double UnitPrice { get; set; }

        /// <summary>
        /// Gets or Sets LocationName
        /// </summary>
        [DataMember(Name="LocationName", EmitDefaultValue=false)]
        public string LocationName { get; set; }

        /// <summary>
        /// Gets or Sets StoreId
        /// </summary>
        [DataMember(Name="StoreId", EmitDefaultValue=false)]
        public string StoreId { get; set; }

        /// <summary>
        /// Gets or Sets LocationGuid
        /// </summary>
        [DataMember(Name="LocationGuid", EmitDefaultValue=false)]
        public string LocationGuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingInventoryInventoryLocation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  PartId: ").Append(PartId).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  LocationName: ").Append(LocationName).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  LocationGuid: ").Append(LocationGuid).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingInventoryInventoryLocation)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingInventoryInventoryLocation instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingInventoryInventoryLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingInventoryInventoryLocation other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    LocationId == other.LocationId ||
                    
                    LocationId.Equals(other.LocationId)
                ) && 
                (
                    PartId == other.PartId ||
                    
                    PartId.Equals(other.PartId)
                ) && 
                (
                    Qty == other.Qty ||
                    
                    Qty.Equals(other.Qty)
                ) && 
                (
                    UnitPrice == other.UnitPrice ||
                    
                    UnitPrice.Equals(other.UnitPrice)
                ) && 
                (
                    LocationName == other.LocationName ||
                    LocationName != null &&
                    LocationName.Equals(other.LocationName)
                ) && 
                (
                    StoreId == other.StoreId ||
                    StoreId != null &&
                    StoreId.Equals(other.StoreId)
                ) && 
                (
                    LocationGuid == other.LocationGuid ||
                    LocationGuid != null &&
                    LocationGuid.Equals(other.LocationGuid)
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
                    
                    hashCode = hashCode * 59 + LocationId.GetHashCode();
                    
                    hashCode = hashCode * 59 + PartId.GetHashCode();
                    
                    hashCode = hashCode * 59 + Qty.GetHashCode();
                    
                    hashCode = hashCode * 59 + UnitPrice.GetHashCode();
                    if (LocationName != null)
                    hashCode = hashCode * 59 + LocationName.GetHashCode();
                    if (StoreId != null)
                    hashCode = hashCode * 59 + StoreId.GetHashCode();
                    if (LocationGuid != null)
                    hashCode = hashCode * 59 + LocationGuid.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingInventoryInventoryLocation left, SCServiceChannelServicesMessagingInventoryInventoryLocation right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingInventoryInventoryLocation left, SCServiceChannelServicesMessagingInventoryInventoryLocation right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}