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
    public class SCServiceChannelServicesMessagingFilterItemSystemInt32 : IEquatable<SCServiceChannelServicesMessagingFilterItemSystemInt32>
    {

        /// <summary>
        /// Gets or Sets OperationType
        /// </summary>
        
        public enum OperationTypeEnum
        {
            
            /// <summary>
            /// Enum EqualEnum for Equal
            /// </summary>
            [EnumMember(Value = "Equal")]
            EqualEnum = 1,
            
            /// <summary>
            /// Enum NotEqualEnum for NotEqual
            /// </summary>
            [EnumMember(Value = "NotEqual")]
            NotEqualEnum = 2,
            
            /// <summary>
            /// Enum GreaterEnum for Greater
            /// </summary>
            [EnumMember(Value = "Greater")]
            GreaterEnum = 3,
            
            /// <summary>
            /// Enum LessEnum for Less
            /// </summary>
            [EnumMember(Value = "Less")]
            LessEnum = 4,
            
            /// <summary>
            /// Enum LikeEnum for Like
            /// </summary>
            [EnumMember(Value = "Like")]
            LikeEnum = 5,
            
            /// <summary>
            /// Enum StartsWithEnum for StartsWith
            /// </summary>
            [EnumMember(Value = "StartsWith")]
            StartsWithEnum = 6,
            
            /// <summary>
            /// Enum GreaterOrEqualEnum for GreaterOrEqual
            /// </summary>
            [EnumMember(Value = "GreaterOrEqual")]
            GreaterOrEqualEnum = 7,
            
            /// <summary>
            /// Enum LessOrEqualEnum for LessOrEqual
            /// </summary>
            [EnumMember(Value = "LessOrEqual")]
            LessOrEqualEnum = 8
        }

        /// <summary>
        /// Gets or Sets OperationType
        /// </summary>
        [DataMember(Name="OperationType", EmitDefaultValue=true)]
        public OperationTypeEnum OperationType { get; set; }


        /// <summary>
        /// Gets or Sets LogicalOperationType
        /// </summary>
        
        public enum LogicalOperationTypeEnum
        {
            
            /// <summary>
            /// Enum OrEnum for Or
            /// </summary>
            [EnumMember(Value = "Or")]
            OrEnum = 1,
            
            /// <summary>
            /// Enum AndEnum for And
            /// </summary>
            [EnumMember(Value = "And")]
            AndEnum = 2
        }

        /// <summary>
        /// Gets or Sets LogicalOperationType
        /// </summary>
        [DataMember(Name="LogicalOperationType", EmitDefaultValue=true)]
        public LogicalOperationTypeEnum LogicalOperationType { get; set; }

        /// <summary>
        /// Gets or Sets ConnectedFilterItemName
        /// </summary>
        [DataMember(Name="ConnectedFilterItemName", EmitDefaultValue=false)]
        public string ConnectedFilterItemName { get; set; }

        /// <summary>
        /// Gets or Sets FilterValue
        /// </summary>
        [DataMember(Name="FilterValue", EmitDefaultValue=true)]
        public int FilterValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingFilterItemSystemInt32 {\n");
            sb.Append("  OperationType: ").Append(OperationType).Append("\n");
            sb.Append("  LogicalOperationType: ").Append(LogicalOperationType).Append("\n");
            sb.Append("  ConnectedFilterItemName: ").Append(ConnectedFilterItemName).Append("\n");
            sb.Append("  FilterValue: ").Append(FilterValue).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingFilterItemSystemInt32)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingFilterItemSystemInt32 instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingFilterItemSystemInt32 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingFilterItemSystemInt32 other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    OperationType == other.OperationType ||
                    
                    OperationType.Equals(other.OperationType)
                ) && 
                (
                    LogicalOperationType == other.LogicalOperationType ||
                    
                    LogicalOperationType.Equals(other.LogicalOperationType)
                ) && 
                (
                    ConnectedFilterItemName == other.ConnectedFilterItemName ||
                    ConnectedFilterItemName != null &&
                    ConnectedFilterItemName.Equals(other.ConnectedFilterItemName)
                ) && 
                (
                    FilterValue == other.FilterValue ||
                    
                    FilterValue.Equals(other.FilterValue)
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
                    
                    hashCode = hashCode * 59 + OperationType.GetHashCode();
                    
                    hashCode = hashCode * 59 + LogicalOperationType.GetHashCode();
                    if (ConnectedFilterItemName != null)
                    hashCode = hashCode * 59 + ConnectedFilterItemName.GetHashCode();
                    
                    hashCode = hashCode * 59 + FilterValue.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingFilterItemSystemInt32 left, SCServiceChannelServicesMessagingFilterItemSystemInt32 right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingFilterItemSystemInt32 left, SCServiceChannelServicesMessagingFilterItemSystemInt32 right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
