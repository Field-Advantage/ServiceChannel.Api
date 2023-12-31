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
    public class SCServiceChannelServicesMessagingPartsRefrigerantUsageResponse : IEquatable<SCServiceChannelServicesMessagingPartsRefrigerantUsageResponse>
    {
        /// <summary>
        /// Gets or Sets TriggerQuantity
        /// </summary>
        [DataMember(Name="TriggerQuantity", EmitDefaultValue=true)]
        public double TriggerQuantity { get; set; }

        /// <summary>
        /// Gets or Sets LeakRate
        /// </summary>
        [DataMember(Name="LeakRate", EmitDefaultValue=true)]
        public double LeakRate { get; set; }

        /// <summary>
        /// Gets or Sets Charge
        /// </summary>
        [DataMember(Name="Charge", EmitDefaultValue=true)]
        public double Charge { get; set; }

        /// <summary>
        /// Gets or Sets CalculationMethod
        /// </summary>
        [RegularExpression("^(?:[A-Za-z0-9+/]{4})*(?:[A-Za-z0-9+/]{2}==|[A-Za-z0-9+/]{3}=)?$")]
        [DataMember(Name="CalculationMethod", EmitDefaultValue=false)]
        public byte[] CalculationMethod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingPartsRefrigerantUsageResponse {\n");
            sb.Append("  TriggerQuantity: ").Append(TriggerQuantity).Append("\n");
            sb.Append("  LeakRate: ").Append(LeakRate).Append("\n");
            sb.Append("  Charge: ").Append(Charge).Append("\n");
            sb.Append("  CalculationMethod: ").Append(CalculationMethod).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingPartsRefrigerantUsageResponse)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingPartsRefrigerantUsageResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingPartsRefrigerantUsageResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingPartsRefrigerantUsageResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TriggerQuantity == other.TriggerQuantity ||
                    
                    TriggerQuantity.Equals(other.TriggerQuantity)
                ) && 
                (
                    LeakRate == other.LeakRate ||
                    
                    LeakRate.Equals(other.LeakRate)
                ) && 
                (
                    Charge == other.Charge ||
                    
                    Charge.Equals(other.Charge)
                ) && 
                (
                    CalculationMethod == other.CalculationMethod ||
                    CalculationMethod != null &&
                    CalculationMethod.Equals(other.CalculationMethod)
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
                    
                    hashCode = hashCode * 59 + TriggerQuantity.GetHashCode();
                    
                    hashCode = hashCode * 59 + LeakRate.GetHashCode();
                    
                    hashCode = hashCode * 59 + Charge.GetHashCode();
                    if (CalculationMethod != null)
                    hashCode = hashCode * 59 + CalculationMethod.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingPartsRefrigerantUsageResponse left, SCServiceChannelServicesMessagingPartsRefrigerantUsageResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingPartsRefrigerantUsageResponse left, SCServiceChannelServicesMessagingPartsRefrigerantUsageResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
