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
    /// SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoRequest
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.Workorders.GetServiceRequestInfoRequest")]
    public partial class SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoRequest : IEquatable<SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoRequest" /> class.
        /// </summary>
        /// <param name="areaName">Name of the area.</param>
        /// <param name="problemType">Problem type.</param>
        /// <param name="equipmentType">Equipment type.</param>
        /// <param name="problemCode">Problem name.</param>
        /// <param name="locationId">ID of a location.</param>
        /// <param name="setupId">SetupId.</param>
        /// <param name="callDate">Call Date.</param>
        public SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoRequest(string areaName = default(string), string problemType = default(string), string equipmentType = default(string), string problemCode = default(string), int locationId = default(int), int setupId = default(int), DateTime callDate = default(DateTime))
        {
            this.AreaName = areaName;
            this.ProblemType = problemType;
            this.EquipmentType = equipmentType;
            this.ProblemCode = problemCode;
            this.LocationId = locationId;
            this.SetupId = setupId;
            this.CallDate = callDate;
        }

        /// <summary>
        /// Name of the area
        /// </summary>
        /// <value>Name of the area</value>
        [DataMember(Name = "AreaName", EmitDefaultValue = false)]
        public string AreaName { get; set; }

        /// <summary>
        /// Problem type
        /// </summary>
        /// <value>Problem type</value>
        [DataMember(Name = "ProblemType", EmitDefaultValue = false)]
        public string ProblemType { get; set; }

        /// <summary>
        /// Equipment type
        /// </summary>
        /// <value>Equipment type</value>
        [DataMember(Name = "EquipmentType", EmitDefaultValue = false)]
        public string EquipmentType { get; set; }

        /// <summary>
        /// Problem name
        /// </summary>
        /// <value>Problem name</value>
        [DataMember(Name = "ProblemCode", EmitDefaultValue = false)]
        public string ProblemCode { get; set; }

        /// <summary>
        /// ID of a location
        /// </summary>
        /// <value>ID of a location</value>
        [DataMember(Name = "LocationId", EmitDefaultValue = false)]
        public int LocationId { get; set; }

        /// <summary>
        /// SetupId
        /// </summary>
        /// <value>SetupId</value>
        [DataMember(Name = "SetupId", EmitDefaultValue = false)]
        public int SetupId { get; set; }

        /// <summary>
        /// Call Date
        /// </summary>
        /// <value>Call Date</value>
        [DataMember(Name = "CallDate", EmitDefaultValue = false)]
        public DateTime CallDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoRequest {\n");
            sb.Append("  AreaName: ").Append(AreaName).Append("\n");
            sb.Append("  ProblemType: ").Append(ProblemType).Append("\n");
            sb.Append("  EquipmentType: ").Append(EquipmentType).Append("\n");
            sb.Append("  ProblemCode: ").Append(ProblemCode).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  SetupId: ").Append(SetupId).Append("\n");
            sb.Append("  CallDate: ").Append(CallDate).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoRequest);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AreaName == input.AreaName ||
                    (this.AreaName != null &&
                    this.AreaName.Equals(input.AreaName))
                ) && 
                (
                    this.ProblemType == input.ProblemType ||
                    (this.ProblemType != null &&
                    this.ProblemType.Equals(input.ProblemType))
                ) && 
                (
                    this.EquipmentType == input.EquipmentType ||
                    (this.EquipmentType != null &&
                    this.EquipmentType.Equals(input.EquipmentType))
                ) && 
                (
                    this.ProblemCode == input.ProblemCode ||
                    (this.ProblemCode != null &&
                    this.ProblemCode.Equals(input.ProblemCode))
                ) && 
                (
                    this.LocationId == input.LocationId ||
                    this.LocationId.Equals(input.LocationId)
                ) && 
                (
                    this.SetupId == input.SetupId ||
                    this.SetupId.Equals(input.SetupId)
                ) && 
                (
                    this.CallDate == input.CallDate ||
                    (this.CallDate != null &&
                    this.CallDate.Equals(input.CallDate))
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
                if (this.AreaName != null)
                {
                    hashCode = (hashCode * 59) + this.AreaName.GetHashCode();
                }
                if (this.ProblemType != null)
                {
                    hashCode = (hashCode * 59) + this.ProblemType.GetHashCode();
                }
                if (this.EquipmentType != null)
                {
                    hashCode = (hashCode * 59) + this.EquipmentType.GetHashCode();
                }
                if (this.ProblemCode != null)
                {
                    hashCode = (hashCode * 59) + this.ProblemCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LocationId.GetHashCode();
                hashCode = (hashCode * 59) + this.SetupId.GetHashCode();
                if (this.CallDate != null)
                {
                    hashCode = (hashCode * 59) + this.CallDate.GetHashCode();
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