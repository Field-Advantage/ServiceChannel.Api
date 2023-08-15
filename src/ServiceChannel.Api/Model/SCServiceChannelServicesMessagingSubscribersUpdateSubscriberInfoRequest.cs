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
    /// UpdateSubscriberInfoRequest
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.Subscribers.UpdateSubscriberInfoRequest")]
    public partial class SCServiceChannelServicesMessagingSubscribersUpdateSubscriberInfoRequest : IEquatable<SCServiceChannelServicesMessagingSubscribersUpdateSubscriberInfoRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingSubscribersUpdateSubscriberInfoRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SCServiceChannelServicesMessagingSubscribersUpdateSubscriberInfoRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingSubscribersUpdateSubscriberInfoRequest" /> class.
        /// </summary>
        /// <param name="name">Required Name              Name - name of the subscriber (required).</param>
        /// <param name="address1">Optional.</param>
        /// <param name="address2">Optional.</param>
        /// <param name="country">Optional.</param>
        /// <param name="state">Optional.</param>
        /// <param name="city">Optional.</param>
        /// <param name="zip">Optional.</param>
        /// <param name="email">Email Required (required).</param>
        /// <param name="phone">Optional.</param>
        /// <param name="fax">Optional.</param>
        /// <param name="contactName">Optional.</param>
        /// <param name="timeFormat">timeFormat.</param>
        /// <param name="dateFormat">dateFormat.</param>
        /// <param name="decimalSeparator">decimalSeparator.</param>
        public SCServiceChannelServicesMessagingSubscribersUpdateSubscriberInfoRequest(string name = default(string), string address1 = default(string), string address2 = default(string), string country = default(string), string state = default(string), string city = default(string), string zip = default(string), string email = default(string), string phone = default(string), string fax = default(string), string contactName = default(string), string timeFormat = default(string), string dateFormat = default(string), string decimalSeparator = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for SCServiceChannelServicesMessagingSubscribersUpdateSubscriberInfoRequest and cannot be null");
            }
            this.Name = name;
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for SCServiceChannelServicesMessagingSubscribersUpdateSubscriberInfoRequest and cannot be null");
            }
            this.Email = email;
            this.Address1 = address1;
            this.Address2 = address2;
            this.Country = country;
            this.State = state;
            this.City = city;
            this.Zip = zip;
            this.Phone = phone;
            this.Fax = fax;
            this.ContactName = contactName;
            this.TimeFormat = timeFormat;
            this.DateFormat = dateFormat;
            this.DecimalSeparator = decimalSeparator;
        }

        /// <summary>
        /// Required Name              Name - name of the subscriber
        /// </summary>
        /// <value>Required Name              Name - name of the subscriber</value>
        [DataMember(Name = "Name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        /// <value>Optional</value>
        [DataMember(Name = "Address1", EmitDefaultValue = false)]
        public string Address1 { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        /// <value>Optional</value>
        [DataMember(Name = "Address2", EmitDefaultValue = false)]
        public string Address2 { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        /// <value>Optional</value>
        [DataMember(Name = "Country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        /// <value>Optional</value>
        [DataMember(Name = "State", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        /// <value>Optional</value>
        [DataMember(Name = "City", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        /// <value>Optional</value>
        [DataMember(Name = "Zip", EmitDefaultValue = false)]
        public string Zip { get; set; }

        /// <summary>
        /// Email Required
        /// </summary>
        /// <value>Email Required</value>
        [DataMember(Name = "Email", IsRequired = true, EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        /// <value>Optional</value>
        [DataMember(Name = "Phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        /// <value>Optional</value>
        [DataMember(Name = "Fax", EmitDefaultValue = false)]
        public string Fax { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        /// <value>Optional</value>
        [DataMember(Name = "ContactName", EmitDefaultValue = false)]
        public string ContactName { get; set; }

        /// <summary>
        /// Gets or Sets TimeFormat
        /// </summary>
        [DataMember(Name = "TimeFormat", EmitDefaultValue = false)]
        public string TimeFormat { get; set; }

        /// <summary>
        /// Gets or Sets DateFormat
        /// </summary>
        [DataMember(Name = "DateFormat", EmitDefaultValue = false)]
        public string DateFormat { get; set; }

        /// <summary>
        /// Gets or Sets DecimalSeparator
        /// </summary>
        [DataMember(Name = "DecimalSeparator", EmitDefaultValue = false)]
        public string DecimalSeparator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingSubscribersUpdateSubscriberInfoRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  ContactName: ").Append(ContactName).Append("\n");
            sb.Append("  TimeFormat: ").Append(TimeFormat).Append("\n");
            sb.Append("  DateFormat: ").Append(DateFormat).Append("\n");
            sb.Append("  DecimalSeparator: ").Append(DecimalSeparator).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingSubscribersUpdateSubscriberInfoRequest);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingSubscribersUpdateSubscriberInfoRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingSubscribersUpdateSubscriberInfoRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingSubscribersUpdateSubscriberInfoRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Address1 == input.Address1 ||
                    (this.Address1 != null &&
                    this.Address1.Equals(input.Address1))
                ) && 
                (
                    this.Address2 == input.Address2 ||
                    (this.Address2 != null &&
                    this.Address2.Equals(input.Address2))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Zip == input.Zip ||
                    (this.Zip != null &&
                    this.Zip.Equals(input.Zip))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.Fax == input.Fax ||
                    (this.Fax != null &&
                    this.Fax.Equals(input.Fax))
                ) && 
                (
                    this.ContactName == input.ContactName ||
                    (this.ContactName != null &&
                    this.ContactName.Equals(input.ContactName))
                ) && 
                (
                    this.TimeFormat == input.TimeFormat ||
                    (this.TimeFormat != null &&
                    this.TimeFormat.Equals(input.TimeFormat))
                ) && 
                (
                    this.DateFormat == input.DateFormat ||
                    (this.DateFormat != null &&
                    this.DateFormat.Equals(input.DateFormat))
                ) && 
                (
                    this.DecimalSeparator == input.DecimalSeparator ||
                    (this.DecimalSeparator != null &&
                    this.DecimalSeparator.Equals(input.DecimalSeparator))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Address1 != null)
                {
                    hashCode = (hashCode * 59) + this.Address1.GetHashCode();
                }
                if (this.Address2 != null)
                {
                    hashCode = (hashCode * 59) + this.Address2.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                if (this.Zip != null)
                {
                    hashCode = (hashCode * 59) + this.Zip.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
                }
                if (this.Fax != null)
                {
                    hashCode = (hashCode * 59) + this.Fax.GetHashCode();
                }
                if (this.ContactName != null)
                {
                    hashCode = (hashCode * 59) + this.ContactName.GetHashCode();
                }
                if (this.TimeFormat != null)
                {
                    hashCode = (hashCode * 59) + this.TimeFormat.GetHashCode();
                }
                if (this.DateFormat != null)
                {
                    hashCode = (hashCode * 59) + this.DateFormat.GetHashCode();
                }
                if (this.DecimalSeparator != null)
                {
                    hashCode = (hashCode * 59) + this.DecimalSeparator.GetHashCode();
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
