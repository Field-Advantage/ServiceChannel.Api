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
    public class SCServiceChannelServicesMessagingWorkordersGetStatusResponse : IEquatable<SCServiceChannelServicesMessagingWorkordersGetStatusResponse>
    {

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        
        public enum IdEnum
        {
            
            /// <summary>
            /// Enum NotSetEnum for NotSet
            /// </summary>
            [EnumMember(Value = "NotSet")]
            NotSetEnum = 1,
            
            /// <summary>
            /// Enum OpenEnum for Open
            /// </summary>
            [EnumMember(Value = "Open")]
            OpenEnum = 2,
            
            /// <summary>
            /// Enum InProgressEnum for InProgress
            /// </summary>
            [EnumMember(Value = "InProgress")]
            InProgressEnum = 3,
            
            /// <summary>
            /// Enum CompletedEnum for Completed
            /// </summary>
            [EnumMember(Value = "Completed")]
            CompletedEnum = 4,
            
            /// <summary>
            /// Enum IncompleteEnum for Incomplete
            /// </summary>
            [EnumMember(Value = "Incomplete")]
            IncompleteEnum = 5
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=true)]
        public IdEnum Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Extended status value
        /// </summary>
        /// <value>Extended status value</value>
        [DataMember(Name="Extended", EmitDefaultValue=false)]
        public List<string> Extended { get; set; }

        /// <summary>
        /// Gets or Sets ExtendedStatuses
        /// </summary>
        [DataMember(Name="ExtendedStatuses", EmitDefaultValue=false)]
        public List<SCServiceChannelServicesMessagingWorkordersWorkorderExtendedStatus> ExtendedStatuses { get; set; }

        /// <summary>
        /// Gets or Sets Constraints
        /// </summary>
        [DataMember(Name="Constraints", EmitDefaultValue=false)]
        public List<SCServiceChannelServicesMessagingWorkordersWorkorderStatusConstraints> Constraints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingWorkordersGetStatusResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Extended: ").Append(Extended).Append("\n");
            sb.Append("  ExtendedStatuses: ").Append(ExtendedStatuses).Append("\n");
            sb.Append("  Constraints: ").Append(Constraints).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingWorkordersGetStatusResponse)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingWorkordersGetStatusResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingWorkordersGetStatusResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingWorkordersGetStatusResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Extended == other.Extended ||
                    Extended != null &&
                    other.Extended != null &&
                    Extended.SequenceEqual(other.Extended)
                ) && 
                (
                    ExtendedStatuses == other.ExtendedStatuses ||
                    ExtendedStatuses != null &&
                    other.ExtendedStatuses != null &&
                    ExtendedStatuses.SequenceEqual(other.ExtendedStatuses)
                ) && 
                (
                    Constraints == other.Constraints ||
                    Constraints != null &&
                    other.Constraints != null &&
                    Constraints.SequenceEqual(other.Constraints)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Extended != null)
                    hashCode = hashCode * 59 + Extended.GetHashCode();
                    if (ExtendedStatuses != null)
                    hashCode = hashCode * 59 + ExtendedStatuses.GetHashCode();
                    if (Constraints != null)
                    hashCode = hashCode * 59 + Constraints.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingWorkordersGetStatusResponse left, SCServiceChannelServicesMessagingWorkordersGetStatusResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingWorkordersGetStatusResponse left, SCServiceChannelServicesMessagingWorkordersGetStatusResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
