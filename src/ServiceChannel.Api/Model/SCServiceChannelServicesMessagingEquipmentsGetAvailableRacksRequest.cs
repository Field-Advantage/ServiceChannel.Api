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
    /// SCServiceChannelServicesMessagingEquipmentsGetAvailableRacksRequest
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.Equipments.GetAvailableRacksRequest")]
    public partial class SCServiceChannelServicesMessagingEquipmentsGetAvailableRacksRequest : IEquatable<SCServiceChannelServicesMessagingEquipmentsGetAvailableRacksRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingEquipmentsGetAvailableRacksRequest" /> class.
        /// </summary>
        /// <param name="subscriberId">subscriberId.</param>
        /// <param name="locationId">locationId.</param>
        /// <param name="includeInactive">includeInactive (default to false).</param>
        /// <param name="selectInactiveRackId">selectInactiveRackId.</param>
        public SCServiceChannelServicesMessagingEquipmentsGetAvailableRacksRequest(int subscriberId = default(int), int locationId = default(int), bool includeInactive = false, int selectInactiveRackId = default(int))
        {
            this.SubscriberId = subscriberId;
            this.LocationId = locationId;
            this.IncludeInactive = includeInactive;
            this.SelectInactiveRackId = selectInactiveRackId;
        }

        /// <summary>
        /// Gets or Sets SubscriberId
        /// </summary>
        [DataMember(Name = "SubscriberId", EmitDefaultValue = false)]
        public int SubscriberId { get; set; }

        /// <summary>
        /// Gets or Sets LocationId
        /// </summary>
        [DataMember(Name = "LocationId", EmitDefaultValue = false)]
        public int LocationId { get; set; }

        /// <summary>
        /// Gets or Sets IncludeInactive
        /// </summary>
        [DataMember(Name = "IncludeInactive", EmitDefaultValue = true)]
        public bool IncludeInactive { get; set; }

        /// <summary>
        /// Gets or Sets SelectInactiveRackId
        /// </summary>
        [DataMember(Name = "SelectInactiveRackId", EmitDefaultValue = false)]
        public int SelectInactiveRackId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingEquipmentsGetAvailableRacksRequest {\n");
            sb.Append("  SubscriberId: ").Append(SubscriberId).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  IncludeInactive: ").Append(IncludeInactive).Append("\n");
            sb.Append("  SelectInactiveRackId: ").Append(SelectInactiveRackId).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingEquipmentsGetAvailableRacksRequest);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingEquipmentsGetAvailableRacksRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingEquipmentsGetAvailableRacksRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingEquipmentsGetAvailableRacksRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SubscriberId == input.SubscriberId ||
                    this.SubscriberId.Equals(input.SubscriberId)
                ) && 
                (
                    this.LocationId == input.LocationId ||
                    this.LocationId.Equals(input.LocationId)
                ) && 
                (
                    this.IncludeInactive == input.IncludeInactive ||
                    this.IncludeInactive.Equals(input.IncludeInactive)
                ) && 
                (
                    this.SelectInactiveRackId == input.SelectInactiveRackId ||
                    this.SelectInactiveRackId.Equals(input.SelectInactiveRackId)
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
                hashCode = (hashCode * 59) + this.SubscriberId.GetHashCode();
                hashCode = (hashCode * 59) + this.LocationId.GetHashCode();
                hashCode = (hashCode * 59) + this.IncludeInactive.GetHashCode();
                hashCode = (hashCode * 59) + this.SelectInactiveRackId.GetHashCode();
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