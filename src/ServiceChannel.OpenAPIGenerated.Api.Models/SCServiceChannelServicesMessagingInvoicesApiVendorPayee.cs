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
    public class SCServiceChannelServicesMessagingInvoicesApiVendorPayee : IEquatable<SCServiceChannelServicesMessagingInvoicesApiVendorPayee>
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=true)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets VendorNumber
        /// </summary>
        [DataMember(Name="VendorNumber", EmitDefaultValue=false)]
        public string VendorNumber { get; set; }

        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name="FullName", EmitDefaultValue=false)]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or Sets Address1
        /// </summary>
        [DataMember(Name="Address1", EmitDefaultValue=false)]
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or Sets Address2
        /// </summary>
        [DataMember(Name="Address2", EmitDefaultValue=false)]
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="City", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="State", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets Zip
        /// </summary>
        [DataMember(Name="Zip", EmitDefaultValue=false)]
        public string Zip { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="Country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingInvoicesApiVendorPayee {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  VendorNumber: ").Append(VendorNumber).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingInvoicesApiVendorPayee)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingInvoicesApiVendorPayee instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingInvoicesApiVendorPayee to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingInvoicesApiVendorPayee other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    VendorNumber == other.VendorNumber ||
                    VendorNumber != null &&
                    VendorNumber.Equals(other.VendorNumber)
                ) && 
                (
                    FullName == other.FullName ||
                    FullName != null &&
                    FullName.Equals(other.FullName)
                ) && 
                (
                    Address1 == other.Address1 ||
                    Address1 != null &&
                    Address1.Equals(other.Address1)
                ) && 
                (
                    Address2 == other.Address2 ||
                    Address2 != null &&
                    Address2.Equals(other.Address2)
                ) && 
                (
                    City == other.City ||
                    City != null &&
                    City.Equals(other.City)
                ) && 
                (
                    State == other.State ||
                    State != null &&
                    State.Equals(other.State)
                ) && 
                (
                    Zip == other.Zip ||
                    Zip != null &&
                    Zip.Equals(other.Zip)
                ) && 
                (
                    Country == other.Country ||
                    Country != null &&
                    Country.Equals(other.Country)
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
                    if (VendorNumber != null)
                    hashCode = hashCode * 59 + VendorNumber.GetHashCode();
                    if (FullName != null)
                    hashCode = hashCode * 59 + FullName.GetHashCode();
                    if (Address1 != null)
                    hashCode = hashCode * 59 + Address1.GetHashCode();
                    if (Address2 != null)
                    hashCode = hashCode * 59 + Address2.GetHashCode();
                    if (City != null)
                    hashCode = hashCode * 59 + City.GetHashCode();
                    if (State != null)
                    hashCode = hashCode * 59 + State.GetHashCode();
                    if (Zip != null)
                    hashCode = hashCode * 59 + Zip.GetHashCode();
                    if (Country != null)
                    hashCode = hashCode * 59 + Country.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingInvoicesApiVendorPayee left, SCServiceChannelServicesMessagingInvoicesApiVendorPayee right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingInvoicesApiVendorPayee left, SCServiceChannelServicesMessagingInvoicesApiVendorPayee right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
