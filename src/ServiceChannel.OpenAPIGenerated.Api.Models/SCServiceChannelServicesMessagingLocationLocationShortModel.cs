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
    /// Shortened location details object.
    /// </summary>
    [DataContract]
    public class SCServiceChannelServicesMessagingLocationLocationShortModel : IEquatable<SCServiceChannelServicesMessagingLocationLocationShortModel>
    {
        /// <summary>
        /// Unique location identifier.
        /// </summary>
        /// <value>Unique location identifier.</value>
        [DataMember(Name="Id", EmitDefaultValue=true)]
        public int Id { get; set; }

        /// <summary>
        /// Alphanumeric identifier of the store in the client&#39;s system. Assigned by and unique per subscriber.
        /// </summary>
        /// <value>Alphanumeric identifier of the store in the client&#39;s system. Assigned by and unique per subscriber.</value>
        [DataMember(Name="StoreId", EmitDefaultValue=false)]
        public string StoreId { get; set; }

        /// <summary>
        /// Location name.
        /// </summary>
        /// <value>Location name.</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Main location address.
        /// </summary>
        /// <value>Main location address.</value>
        [DataMember(Name="Address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Location city.
        /// </summary>
        /// <value>Location city.</value>
        [DataMember(Name="City", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// State where the location is situated.
        /// </summary>
        /// <value>State where the location is situated.</value>
        [DataMember(Name="State", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Location ZIP or postal code.
        /// </summary>
        /// <value>Location ZIP or postal code.</value>
        [DataMember(Name="Zip", EmitDefaultValue=false)]
        public string Zip { get; set; }

        /// <summary>
        /// Contact phone number of the location.
        /// </summary>
        /// <value>Contact phone number of the location.</value>
        [DataMember(Name="Phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Part of the country where the location is situated.
        /// </summary>
        /// <value>Part of the country where the location is situated.</value>
        [DataMember(Name="Region", EmitDefaultValue=false)]
        public string Region { get; set; }

        /// <summary>
        /// Abbreviation of the town or country area where the location is situated.
        /// </summary>
        /// <value>Abbreviation of the town or country area where the location is situated.</value>
        [DataMember(Name="District", EmitDefaultValue=false)]
        public string District { get; set; }

        /// <summary>
        /// Numeric identifier of the location’s state.
        /// </summary>
        /// <value>Numeric identifier of the location’s state.</value>
        [DataMember(Name="StateId", EmitDefaultValue=true)]
        public int StateId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingLocationLocationShortModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  District: ").Append(District).Append("\n");
            sb.Append("  StateId: ").Append(StateId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingLocationLocationShortModel)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingLocationLocationShortModel instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingLocationLocationShortModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingLocationLocationShortModel other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    StoreId == other.StoreId ||
                    StoreId != null &&
                    StoreId.Equals(other.StoreId)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Address == other.Address ||
                    Address != null &&
                    Address.Equals(other.Address)
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
                    Phone == other.Phone ||
                    Phone != null &&
                    Phone.Equals(other.Phone)
                ) && 
                (
                    Region == other.Region ||
                    Region != null &&
                    Region.Equals(other.Region)
                ) && 
                (
                    District == other.District ||
                    District != null &&
                    District.Equals(other.District)
                ) && 
                (
                    StateId == other.StateId ||
                    
                    StateId.Equals(other.StateId)
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
                    if (StoreId != null)
                    hashCode = hashCode * 59 + StoreId.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Address != null)
                    hashCode = hashCode * 59 + Address.GetHashCode();
                    if (City != null)
                    hashCode = hashCode * 59 + City.GetHashCode();
                    if (State != null)
                    hashCode = hashCode * 59 + State.GetHashCode();
                    if (Zip != null)
                    hashCode = hashCode * 59 + Zip.GetHashCode();
                    if (Phone != null)
                    hashCode = hashCode * 59 + Phone.GetHashCode();
                    if (Region != null)
                    hashCode = hashCode * 59 + Region.GetHashCode();
                    if (District != null)
                    hashCode = hashCode * 59 + District.GetHashCode();
                    
                    hashCode = hashCode * 59 + StateId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingLocationLocationShortModel left, SCServiceChannelServicesMessagingLocationLocationShortModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingLocationLocationShortModel left, SCServiceChannelServicesMessagingLocationLocationShortModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}