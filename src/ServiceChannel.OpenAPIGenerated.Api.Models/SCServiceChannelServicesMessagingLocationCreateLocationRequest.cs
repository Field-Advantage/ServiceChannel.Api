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
    /// Object containing the details of a new location.
    /// </summary>
    [DataContract]
    public class SCServiceChannelServicesMessagingLocationCreateLocationRequest : IEquatable<SCServiceChannelServicesMessagingLocationCreateLocationRequest>
    {
        /// <summary>
        /// Numeric location identifier in the client’s system.
        /// </summary>
        /// <value>Numeric location identifier in the client’s system.</value>
        [Required]
        [DataMember(Name="StoreId", EmitDefaultValue=false)]
        public string StoreId { get; set; }

        /// <summary>
        /// Location name.
        /// </summary>
        /// <value>Location name.</value>
        [Required]
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Global position. Latitude.
        /// </summary>
        /// <value>Global position. Latitude.</value>
        [DataMember(Name="Latitude", EmitDefaultValue=true)]
        public double Latitude { get; set; }

        /// <summary>
        /// Global position. Longitude.
        /// </summary>
        /// <value>Global position. Longitude.</value>
        [DataMember(Name="Longitude", EmitDefaultValue=true)]
        public double Longitude { get; set; }

        /// <summary>
        /// Distance from GPS coordinates to the location.
        /// </summary>
        /// <value>Distance from GPS coordinates to the location.</value>
        [DataMember(Name="Distance", EmitDefaultValue=true)]
        public double Distance { get; set; }

        /// <summary>
        /// Additional location address.
        /// </summary>
        /// <value>Additional location address.</value>
        [DataMember(Name="Address1", EmitDefaultValue=false)]
        public string Address1 { get; set; }

        /// <summary>
        /// Main location address.
        /// </summary>
        /// <value>Main location address.</value>
        [DataMember(Name="Address2", EmitDefaultValue=false)]
        public string Address2 { get; set; }

        /// <summary>
        /// Location city.
        /// </summary>
        /// <value>Location city.</value>
        [DataMember(Name="City", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// State where the location is placed.
        /// </summary>
        /// <value>State where the location is placed.</value>
        [DataMember(Name="State", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Numeric identifier of the location’s state.
        /// </summary>
        /// <value>Numeric identifier of the location’s state.</value>
        [DataMember(Name="StateId", EmitDefaultValue=true)]
        public int StateId { get; set; }

        /// <summary>
        /// Part of the country where the location is placed.
        /// </summary>
        /// <value>Part of the country where the location is placed.</value>
        [DataMember(Name="Region", EmitDefaultValue=false)]
        public string Region { get; set; }

        /// <summary>
        /// Abbreviation of the town or country area where the location is placed.
        /// </summary>
        /// <value>Abbreviation of the town or country area where the location is placed.</value>
        [DataMember(Name="District", EmitDefaultValue=false)]
        public string District { get; set; }

        /// <summary>
        /// Postal code of the location.
        /// </summary>
        /// <value>Postal code of the location.</value>
        [DataMember(Name="Zip", EmitDefaultValue=false)]
        public string Zip { get; set; }

        /// <summary>
        /// Abbreviation of the country name where the location is placed.
        /// </summary>
        /// <value>Abbreviation of the country name where the location is placed.</value>
        [DataMember(Name="Country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Numeric identifier of the country of the location.
        /// </summary>
        /// <value>Numeric identifier of the country of the location.</value>
        [DataMember(Name="CountryId", EmitDefaultValue=true)]
        public int CountryId { get; set; }

        /// <summary>
        /// Last day when the location is open for business.
        /// </summary>
        /// <value>Last day when the location is open for business.</value>
        [DataMember(Name="ClosedDate", EmitDefaultValue=false)]
        public DateTime ClosedDate { get; set; }

        /// <summary>
        /// First day when the location is open for business.
        /// </summary>
        /// <value>First day when the location is open for business.</value>
        [DataMember(Name="OpenDate", EmitDefaultValue=false)]
        public DateTime OpenDate { get; set; }

        /// <summary>
        /// Email the location can be contacted at.
        /// </summary>
        /// <value>Email the location can be contacted at.</value>
        [DataMember(Name="Email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Contact phone number of the location.
        /// </summary>
        /// <value>Contact phone number of the location.</value>
        [DataMember(Name="Phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Name of the main person to contact at the location.
        /// </summary>
        /// <value>Name of the main person to contact at the location.</value>
        [DataMember(Name="Contact", EmitDefaultValue=false)]
        public string Contact { get; set; }

        /// <summary>
        /// Fax number the location can be contacted at.
        /// </summary>
        /// <value>Fax number the location can be contacted at.</value>
        [DataMember(Name="FaxNumber", EmitDefaultValue=false)]
        public string FaxNumber { get; set; }

        /// <summary>
        /// Numeric identifier of the location type.
        /// </summary>
        /// <value>Numeric identifier of the location type.</value>
        [DataMember(Name="LocationTypeId", EmitDefaultValue=true)]
        public int LocationTypeId { get; set; }

        /// <summary>
        /// Square value
        /// </summary>
        /// <value>Square value</value>
        [DataMember(Name="SquareValue", EmitDefaultValue=true)]
        public double SquareValue { get; set; }

        /// <summary>
        /// Square measure
        /// </summary>
        /// <value>Square measure</value>
        [DataMember(Name="SquareMeasure", EmitDefaultValue=false)]
        public string SquareMeasure { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingLocationCreateLocationRequest {\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  StateId: ").Append(StateId).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  District: ").Append(District).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  CountryId: ").Append(CountryId).Append("\n");
            sb.Append("  ClosedDate: ").Append(ClosedDate).Append("\n");
            sb.Append("  OpenDate: ").Append(OpenDate).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  FaxNumber: ").Append(FaxNumber).Append("\n");
            sb.Append("  LocationTypeId: ").Append(LocationTypeId).Append("\n");
            sb.Append("  SquareValue: ").Append(SquareValue).Append("\n");
            sb.Append("  SquareMeasure: ").Append(SquareMeasure).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingLocationCreateLocationRequest)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingLocationCreateLocationRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingLocationCreateLocationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingLocationCreateLocationRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
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
                    Latitude == other.Latitude ||
                    
                    Latitude.Equals(other.Latitude)
                ) && 
                (
                    Longitude == other.Longitude ||
                    
                    Longitude.Equals(other.Longitude)
                ) && 
                (
                    Distance == other.Distance ||
                    
                    Distance.Equals(other.Distance)
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
                    StateId == other.StateId ||
                    
                    StateId.Equals(other.StateId)
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
                    Zip == other.Zip ||
                    Zip != null &&
                    Zip.Equals(other.Zip)
                ) && 
                (
                    Country == other.Country ||
                    Country != null &&
                    Country.Equals(other.Country)
                ) && 
                (
                    CountryId == other.CountryId ||
                    
                    CountryId.Equals(other.CountryId)
                ) && 
                (
                    ClosedDate == other.ClosedDate ||
                    ClosedDate != null &&
                    ClosedDate.Equals(other.ClosedDate)
                ) && 
                (
                    OpenDate == other.OpenDate ||
                    OpenDate != null &&
                    OpenDate.Equals(other.OpenDate)
                ) && 
                (
                    Email == other.Email ||
                    Email != null &&
                    Email.Equals(other.Email)
                ) && 
                (
                    Phone == other.Phone ||
                    Phone != null &&
                    Phone.Equals(other.Phone)
                ) && 
                (
                    Contact == other.Contact ||
                    Contact != null &&
                    Contact.Equals(other.Contact)
                ) && 
                (
                    FaxNumber == other.FaxNumber ||
                    FaxNumber != null &&
                    FaxNumber.Equals(other.FaxNumber)
                ) && 
                (
                    LocationTypeId == other.LocationTypeId ||
                    
                    LocationTypeId.Equals(other.LocationTypeId)
                ) && 
                (
                    SquareValue == other.SquareValue ||
                    
                    SquareValue.Equals(other.SquareValue)
                ) && 
                (
                    SquareMeasure == other.SquareMeasure ||
                    SquareMeasure != null &&
                    SquareMeasure.Equals(other.SquareMeasure)
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
                    if (StoreId != null)
                    hashCode = hashCode * 59 + StoreId.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    
                    hashCode = hashCode * 59 + Latitude.GetHashCode();
                    
                    hashCode = hashCode * 59 + Longitude.GetHashCode();
                    
                    hashCode = hashCode * 59 + Distance.GetHashCode();
                    if (Address1 != null)
                    hashCode = hashCode * 59 + Address1.GetHashCode();
                    if (Address2 != null)
                    hashCode = hashCode * 59 + Address2.GetHashCode();
                    if (City != null)
                    hashCode = hashCode * 59 + City.GetHashCode();
                    if (State != null)
                    hashCode = hashCode * 59 + State.GetHashCode();
                    
                    hashCode = hashCode * 59 + StateId.GetHashCode();
                    if (Region != null)
                    hashCode = hashCode * 59 + Region.GetHashCode();
                    if (District != null)
                    hashCode = hashCode * 59 + District.GetHashCode();
                    if (Zip != null)
                    hashCode = hashCode * 59 + Zip.GetHashCode();
                    if (Country != null)
                    hashCode = hashCode * 59 + Country.GetHashCode();
                    
                    hashCode = hashCode * 59 + CountryId.GetHashCode();
                    if (ClosedDate != null)
                    hashCode = hashCode * 59 + ClosedDate.GetHashCode();
                    if (OpenDate != null)
                    hashCode = hashCode * 59 + OpenDate.GetHashCode();
                    if (Email != null)
                    hashCode = hashCode * 59 + Email.GetHashCode();
                    if (Phone != null)
                    hashCode = hashCode * 59 + Phone.GetHashCode();
                    if (Contact != null)
                    hashCode = hashCode * 59 + Contact.GetHashCode();
                    if (FaxNumber != null)
                    hashCode = hashCode * 59 + FaxNumber.GetHashCode();
                    
                    hashCode = hashCode * 59 + LocationTypeId.GetHashCode();
                    
                    hashCode = hashCode * 59 + SquareValue.GetHashCode();
                    if (SquareMeasure != null)
                    hashCode = hashCode * 59 + SquareMeasure.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingLocationCreateLocationRequest left, SCServiceChannelServicesMessagingLocationCreateLocationRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingLocationCreateLocationRequest left, SCServiceChannelServicesMessagingLocationCreateLocationRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
