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
    /// SCServiceChannelServicesMessagingLocationGetLocationsSimpleRequest
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.Location.GetLocationsSimpleRequest")]
    public partial class SCServiceChannelServicesMessagingLocationGetLocationsSimpleRequest : IEquatable<SCServiceChannelServicesMessagingLocationGetLocationsSimpleRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingLocationGetLocationsSimpleRequest" /> class.
        /// </summary>
        /// <param name="id">Unique location identifier..</param>
        /// <param name="storeIdentifier">Alphanumeric location identifier in the client’s system. Assigned by and unique per subscriber..</param>
        /// <param name="name">Location name..</param>
        /// <param name="sort">Sort resources by the specified property in the response..</param>
        /// <param name="page">Results page number..</param>
        /// <param name="pageSize">Number of objects on the results page. The default and maximum per page is 50..</param>
        public SCServiceChannelServicesMessagingLocationGetLocationsSimpleRequest(int id = default(int), string storeIdentifier = default(string), string name = default(string), string sort = default(string), int page = default(int), int pageSize = default(int))
        {
            this.Id = id;
            this.StoreIdentifier = storeIdentifier;
            this.Name = name;
            this.Sort = sort;
            this.Page = page;
            this.PageSize = pageSize;
        }

        /// <summary>
        /// Unique location identifier.
        /// </summary>
        /// <value>Unique location identifier.</value>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Alphanumeric location identifier in the client’s system. Assigned by and unique per subscriber.
        /// </summary>
        /// <value>Alphanumeric location identifier in the client’s system. Assigned by and unique per subscriber.</value>
        [DataMember(Name = "storeIdentifier", EmitDefaultValue = false)]
        public string StoreIdentifier { get; set; }

        /// <summary>
        /// Location name.
        /// </summary>
        /// <value>Location name.</value>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The unique store ID in the ServiceClick system
        /// </summary>
        /// <value>The unique store ID in the ServiceClick system</value>
        [DataMember(Name = "LocationId", EmitDefaultValue = false)]
        public List<SCServiceChannelServicesMessagingFilterItemSystemInt32> LocationId { get; private set; }

        /// <summary>
        /// Returns false as LocationId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLocationId()
        {
            return false;
        }
        /// <summary>
        /// Name of the location
        /// </summary>
        /// <value>Name of the location</value>
        [DataMember(Name = "LocationName", EmitDefaultValue = false)]
        public List<SCServiceChannelServicesMessagingFilterItemSystemString> LocationName { get; private set; }

        /// <summary>
        /// Returns false as LocationName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLocationName()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets StoreId
        /// </summary>
        [DataMember(Name = "StoreId", EmitDefaultValue = false)]
        public List<SCServiceChannelServicesMessagingFilterItemSystemString> StoreId { get; private set; }

        /// <summary>
        /// Returns false as StoreId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStoreId()
        {
            return false;
        }
        /// <summary>
        /// Sort resources by the specified property in the response.
        /// </summary>
        /// <value>Sort resources by the specified property in the response.</value>
        [DataMember(Name = "Sort", EmitDefaultValue = false)]
        public string Sort { get; set; }

        /// <summary>
        /// Results page number.
        /// </summary>
        /// <value>Results page number.</value>
        [DataMember(Name = "Page", EmitDefaultValue = false)]
        public int Page { get; set; }

        /// <summary>
        /// Gets or Sets IsPageSizeDefault
        /// </summary>
        [DataMember(Name = "IsPageSizeDefault", EmitDefaultValue = true)]
        public bool IsPageSizeDefault { get; private set; }

        /// <summary>
        /// Returns false as IsPageSizeDefault should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsPageSizeDefault()
        {
            return false;
        }
        /// <summary>
        /// Number of objects on the results page. The default and maximum per page is 50.
        /// </summary>
        /// <value>Number of objects on the results page. The default and maximum per page is 50.</value>
        [DataMember(Name = "PageSize", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingLocationGetLocationsSimpleRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StoreIdentifier: ").Append(StoreIdentifier).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  LocationName: ").Append(LocationName).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  IsPageSizeDefault: ").Append(IsPageSizeDefault).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingLocationGetLocationsSimpleRequest);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingLocationGetLocationsSimpleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingLocationGetLocationsSimpleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingLocationGetLocationsSimpleRequest input)
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
                    this.StoreIdentifier == input.StoreIdentifier ||
                    (this.StoreIdentifier != null &&
                    this.StoreIdentifier.Equals(input.StoreIdentifier))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.LocationId == input.LocationId ||
                    this.LocationId != null &&
                    input.LocationId != null &&
                    this.LocationId.SequenceEqual(input.LocationId)
                ) && 
                (
                    this.LocationName == input.LocationName ||
                    this.LocationName != null &&
                    input.LocationName != null &&
                    this.LocationName.SequenceEqual(input.LocationName)
                ) && 
                (
                    this.StoreId == input.StoreId ||
                    this.StoreId != null &&
                    input.StoreId != null &&
                    this.StoreId.SequenceEqual(input.StoreId)
                ) && 
                (
                    this.Sort == input.Sort ||
                    (this.Sort != null &&
                    this.Sort.Equals(input.Sort))
                ) && 
                (
                    this.Page == input.Page ||
                    this.Page.Equals(input.Page)
                ) && 
                (
                    this.IsPageSizeDefault == input.IsPageSizeDefault ||
                    this.IsPageSizeDefault.Equals(input.IsPageSizeDefault)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
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
                if (this.StoreIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.StoreIdentifier.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.LocationId != null)
                {
                    hashCode = (hashCode * 59) + this.LocationId.GetHashCode();
                }
                if (this.LocationName != null)
                {
                    hashCode = (hashCode * 59) + this.LocationName.GetHashCode();
                }
                if (this.StoreId != null)
                {
                    hashCode = (hashCode * 59) + this.StoreId.GetHashCode();
                }
                if (this.Sort != null)
                {
                    hashCode = (hashCode * 59) + this.Sort.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Page.GetHashCode();
                hashCode = (hashCode * 59) + this.IsPageSizeDefault.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
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
