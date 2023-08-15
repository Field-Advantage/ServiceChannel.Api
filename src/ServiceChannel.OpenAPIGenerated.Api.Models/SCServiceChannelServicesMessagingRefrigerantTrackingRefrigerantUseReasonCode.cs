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
    public class SCServiceChannelServicesMessagingRefrigerantTrackingRefrigerantUseReasonCode : IEquatable<SCServiceChannelServicesMessagingRefrigerantTrackingRefrigerantUseReasonCode>
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=true)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="Order", EmitDefaultValue=true)]
        public int Order { get; set; }

        /// <summary>
        /// Gets or Sets Purpose
        /// </summary>
        [DataMember(Name="Purpose", EmitDefaultValue=true)]
        public int Purpose { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets SubscriberId
        /// </summary>
        [DataMember(Name="SubscriberId", EmitDefaultValue=true)]
        public int SubscriberId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingRefrigerantTrackingRefrigerantUseReasonCode {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SubscriberId: ").Append(SubscriberId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingRefrigerantTrackingRefrigerantUseReasonCode)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingRefrigerantTrackingRefrigerantUseReasonCode instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingRefrigerantTrackingRefrigerantUseReasonCode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingRefrigerantTrackingRefrigerantUseReasonCode other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    Order == other.Order ||
                    
                    Order.Equals(other.Order)
                ) && 
                (
                    Purpose == other.Purpose ||
                    
                    Purpose.Equals(other.Purpose)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    SubscriberId == other.SubscriberId ||
                    
                    SubscriberId.Equals(other.SubscriberId)
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
                    
                    hashCode = hashCode * 59 + Order.GetHashCode();
                    
                    hashCode = hashCode * 59 + Purpose.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    
                    hashCode = hashCode * 59 + SubscriberId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingRefrigerantTrackingRefrigerantUseReasonCode left, SCServiceChannelServicesMessagingRefrigerantTrackingRefrigerantUseReasonCode right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingRefrigerantTrackingRefrigerantUseReasonCode left, SCServiceChannelServicesMessagingRefrigerantTrackingRefrigerantUseReasonCode right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
