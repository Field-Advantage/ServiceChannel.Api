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
    public class SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoRequest : IEquatable<SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoRequest>
    {
        /// <summary>
        /// Name of the area
        /// </summary>
        /// <value>Name of the area</value>
        [DataMember(Name="AreaName", EmitDefaultValue=false)]
        public string AreaName { get; set; }

        /// <summary>
        /// Problem type
        /// </summary>
        /// <value>Problem type</value>
        [DataMember(Name="ProblemType", EmitDefaultValue=false)]
        public string ProblemType { get; set; }

        /// <summary>
        /// Equipment type
        /// </summary>
        /// <value>Equipment type</value>
        [DataMember(Name="EquipmentType", EmitDefaultValue=false)]
        public string EquipmentType { get; set; }

        /// <summary>
        /// Problem name
        /// </summary>
        /// <value>Problem name</value>
        [DataMember(Name="ProblemCode", EmitDefaultValue=false)]
        public string ProblemCode { get; set; }

        /// <summary>
        /// ID of a location
        /// </summary>
        /// <value>ID of a location</value>
        [DataMember(Name="LocationId", EmitDefaultValue=true)]
        public int LocationId { get; set; }

        /// <summary>
        /// SetupId
        /// </summary>
        /// <value>SetupId</value>
        [DataMember(Name="SetupId", EmitDefaultValue=true)]
        public int SetupId { get; set; }

        /// <summary>
        /// Call Date
        /// </summary>
        /// <value>Call Date</value>
        [DataMember(Name="CallDate", EmitDefaultValue=false)]
        public DateTime CallDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoRequest)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AreaName == other.AreaName ||
                    AreaName != null &&
                    AreaName.Equals(other.AreaName)
                ) && 
                (
                    ProblemType == other.ProblemType ||
                    ProblemType != null &&
                    ProblemType.Equals(other.ProblemType)
                ) && 
                (
                    EquipmentType == other.EquipmentType ||
                    EquipmentType != null &&
                    EquipmentType.Equals(other.EquipmentType)
                ) && 
                (
                    ProblemCode == other.ProblemCode ||
                    ProblemCode != null &&
                    ProblemCode.Equals(other.ProblemCode)
                ) && 
                (
                    LocationId == other.LocationId ||
                    
                    LocationId.Equals(other.LocationId)
                ) && 
                (
                    SetupId == other.SetupId ||
                    
                    SetupId.Equals(other.SetupId)
                ) && 
                (
                    CallDate == other.CallDate ||
                    CallDate != null &&
                    CallDate.Equals(other.CallDate)
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
                    if (AreaName != null)
                    hashCode = hashCode * 59 + AreaName.GetHashCode();
                    if (ProblemType != null)
                    hashCode = hashCode * 59 + ProblemType.GetHashCode();
                    if (EquipmentType != null)
                    hashCode = hashCode * 59 + EquipmentType.GetHashCode();
                    if (ProblemCode != null)
                    hashCode = hashCode * 59 + ProblemCode.GetHashCode();
                    
                    hashCode = hashCode * 59 + LocationId.GetHashCode();
                    
                    hashCode = hashCode * 59 + SetupId.GetHashCode();
                    if (CallDate != null)
                    hashCode = hashCode * 59 + CallDate.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoRequest left, SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoRequest left, SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}