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
    /// Business hours object.
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.AfterHours.BusinessHoursApiResponse")]
    public partial class SCServiceChannelServicesMessagingAfterHoursBusinessHoursApiResponse : IEquatable<SCServiceChannelServicesMessagingAfterHoursBusinessHoursApiResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingAfterHoursBusinessHoursApiResponse" /> class.
        /// </summary>
        /// <param name="timeZoneShortDescription">Location’s timezone abbreviation..</param>
        /// <param name="businessHours">businessHours.</param>
        public SCServiceChannelServicesMessagingAfterHoursBusinessHoursApiResponse(string timeZoneShortDescription = default(string), List<SCServiceChannelServicesMessagingAfterHoursBusinessHourApiResponse> businessHours = default(List<SCServiceChannelServicesMessagingAfterHoursBusinessHourApiResponse>))
        {
            this.TimeZoneShortDescription = timeZoneShortDescription;
            this.BusinessHours = businessHours;
        }

        /// <summary>
        /// Location’s timezone abbreviation.
        /// </summary>
        /// <value>Location’s timezone abbreviation.</value>
        [DataMember(Name = "TimeZoneShortDescription", EmitDefaultValue = false)]
        public string TimeZoneShortDescription { get; set; }

        /// <summary>
        /// Gets or Sets BusinessHours
        /// </summary>
        [DataMember(Name = "BusinessHours", EmitDefaultValue = false)]
        public List<SCServiceChannelServicesMessagingAfterHoursBusinessHourApiResponse> BusinessHours { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingAfterHoursBusinessHoursApiResponse {\n");
            sb.Append("  TimeZoneShortDescription: ").Append(TimeZoneShortDescription).Append("\n");
            sb.Append("  BusinessHours: ").Append(BusinessHours).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingAfterHoursBusinessHoursApiResponse);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingAfterHoursBusinessHoursApiResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingAfterHoursBusinessHoursApiResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingAfterHoursBusinessHoursApiResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TimeZoneShortDescription == input.TimeZoneShortDescription ||
                    (this.TimeZoneShortDescription != null &&
                    this.TimeZoneShortDescription.Equals(input.TimeZoneShortDescription))
                ) && 
                (
                    this.BusinessHours == input.BusinessHours ||
                    this.BusinessHours != null &&
                    input.BusinessHours != null &&
                    this.BusinessHours.SequenceEqual(input.BusinessHours)
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
                if (this.TimeZoneShortDescription != null)
                {
                    hashCode = (hashCode * 59) + this.TimeZoneShortDescription.GetHashCode();
                }
                if (this.BusinessHours != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessHours.GetHashCode();
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
