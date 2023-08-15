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
    /// Work Request Issue
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.WorkRequests.WorkRequestIssue")]
    public partial class SCServiceChannelServicesMessagingWorkRequestsWorkRequestIssue : IEquatable<SCServiceChannelServicesMessagingWorkRequestsWorkRequestIssue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingWorkRequestsWorkRequestIssue" /> class.
        /// </summary>
        /// <param name="areaId">Area Id.</param>
        /// <param name="areaName">Area Name.</param>
        /// <param name="problemType">Problem Type.</param>
        /// <param name="equipment">Equipment.</param>
        /// <param name="problemCode">Problem Code.</param>
        /// <param name="setupId">Setup Id.</param>
        public SCServiceChannelServicesMessagingWorkRequestsWorkRequestIssue(int areaId = default(int), string areaName = default(string), string problemType = default(string), string equipment = default(string), string problemCode = default(string), int setupId = default(int))
        {
            this.AreaId = areaId;
            this.AreaName = areaName;
            this.ProblemType = problemType;
            this.Equipment = equipment;
            this.ProblemCode = problemCode;
            this.SetupId = setupId;
        }

        /// <summary>
        /// Area Id
        /// </summary>
        /// <value>Area Id</value>
        [DataMember(Name = "AreaId", EmitDefaultValue = false)]
        public int AreaId { get; set; }

        /// <summary>
        /// Area Name
        /// </summary>
        /// <value>Area Name</value>
        [DataMember(Name = "AreaName", EmitDefaultValue = false)]
        public string AreaName { get; set; }

        /// <summary>
        /// Problem Type
        /// </summary>
        /// <value>Problem Type</value>
        [DataMember(Name = "ProblemType", EmitDefaultValue = false)]
        public string ProblemType { get; set; }

        /// <summary>
        /// Equipment
        /// </summary>
        /// <value>Equipment</value>
        [DataMember(Name = "Equipment", EmitDefaultValue = false)]
        public string Equipment { get; set; }

        /// <summary>
        /// Problem Code
        /// </summary>
        /// <value>Problem Code</value>
        [DataMember(Name = "ProblemCode", EmitDefaultValue = false)]
        public string ProblemCode { get; set; }

        /// <summary>
        /// Setup Id
        /// </summary>
        /// <value>Setup Id</value>
        [DataMember(Name = "SetupId", EmitDefaultValue = false)]
        public int SetupId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingWorkRequestsWorkRequestIssue {\n");
            sb.Append("  AreaId: ").Append(AreaId).Append("\n");
            sb.Append("  AreaName: ").Append(AreaName).Append("\n");
            sb.Append("  ProblemType: ").Append(ProblemType).Append("\n");
            sb.Append("  Equipment: ").Append(Equipment).Append("\n");
            sb.Append("  ProblemCode: ").Append(ProblemCode).Append("\n");
            sb.Append("  SetupId: ").Append(SetupId).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingWorkRequestsWorkRequestIssue);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingWorkRequestsWorkRequestIssue instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingWorkRequestsWorkRequestIssue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingWorkRequestsWorkRequestIssue input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AreaId == input.AreaId ||
                    this.AreaId.Equals(input.AreaId)
                ) && 
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
                    this.Equipment == input.Equipment ||
                    (this.Equipment != null &&
                    this.Equipment.Equals(input.Equipment))
                ) && 
                (
                    this.ProblemCode == input.ProblemCode ||
                    (this.ProblemCode != null &&
                    this.ProblemCode.Equals(input.ProblemCode))
                ) && 
                (
                    this.SetupId == input.SetupId ||
                    this.SetupId.Equals(input.SetupId)
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
                hashCode = (hashCode * 59) + this.AreaId.GetHashCode();
                if (this.AreaName != null)
                {
                    hashCode = (hashCode * 59) + this.AreaName.GetHashCode();
                }
                if (this.ProblemType != null)
                {
                    hashCode = (hashCode * 59) + this.ProblemType.GetHashCode();
                }
                if (this.Equipment != null)
                {
                    hashCode = (hashCode * 59) + this.Equipment.GetHashCode();
                }
                if (this.ProblemCode != null)
                {
                    hashCode = (hashCode * 59) + this.ProblemCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SetupId.GetHashCode();
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
