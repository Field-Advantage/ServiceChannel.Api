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
    /// Check-In Validate Response
    /// </summary>
    [DataContract]
    public class SCServiceChannelServicesMessagingCheckInOutCheckInValidateResponse : IEquatable<SCServiceChannelServicesMessagingCheckInOutCheckInValidateResponse>
    {
        /// <summary>
        /// Is Badge Scan Required
        /// </summary>
        /// <value>Is Badge Scan Required</value>
        [DataMember(Name="IsBadgeScanRequired", EmitDefaultValue=true)]
        public bool IsBadgeScanRequired { get; set; } = false;

        /// <summary>
        /// Is Current Login type Allowed to perform check-in action
        /// </summary>
        /// <value>Is Current Login type Allowed to perform check-in action</value>
        [DataMember(Name="IsLoginTypeAllowed", EmitDefaultValue=true)]
        public bool IsLoginTypeAllowed { get; set; } = false;

        /// <summary>
        /// Is Outside Acceptable Timeframe
        /// </summary>
        /// <value>Is Outside Acceptable Timeframe</value>
        [DataMember(Name="IsOutsideAcceptableTimeframe", EmitDefaultValue=true)]
        public bool IsOutsideAcceptableTimeframe { get; set; } = false;

        /// <summary>
        /// Is Outside Geolocation
        /// </summary>
        /// <value>Is Outside Geolocation</value>
        [DataMember(Name="IsOutsideGeolocation", EmitDefaultValue=true)]
        public bool IsOutsideGeolocation { get; set; } = false;

        /// <summary>
        /// Outside Operational Hours Message
        /// </summary>
        /// <value>Outside Operational Hours Message</value>
        [DataMember(Name="OutsideOperationalHoursMessage", EmitDefaultValue=false)]
        public string OutsideOperationalHoursMessage { get; set; }

        /// <summary>
        /// Is Mask Required
        /// </summary>
        /// <value>Is Mask Required</value>
        [DataMember(Name="IsMaskRequired", EmitDefaultValue=true)]
        public bool IsMaskRequired { get; set; } = false;

        /// <summary>
        /// Is Check In Outside Geolocation Radius Allowed
        /// </summary>
        /// <value>Is Check In Outside Geolocation Radius Allowed</value>
        [DataMember(Name="CheckInOutsideGPSAllowed", EmitDefaultValue=true)]
        public bool CheckInOutsideGPSAllowed { get; set; } = false;

        /// <summary>
        /// Is Check Out Outside Geolocation Radius Allowed
        /// </summary>
        /// <value>Is Check Out Outside Geolocation Radius Allowed</value>
        [DataMember(Name="CheckOutOutsideGPSAllowed", EmitDefaultValue=true)]
        public bool CheckOutOutsideGPSAllowed { get; set; } = false;

        /// <summary>
        /// Is Compliant Non-Compliant Check In/Out Enabled
        /// </summary>
        /// <value>Is Compliant Non-Compliant Check In/Out Enabled</value>
        [DataMember(Name="IsCompliantNonCompliantCheckInEnabled", EmitDefaultValue=true)]
        public bool IsCompliantNonCompliantCheckInEnabled { get; set; } = false;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingCheckInOutCheckInValidateResponse {\n");
            sb.Append("  IsBadgeScanRequired: ").Append(IsBadgeScanRequired).Append("\n");
            sb.Append("  IsLoginTypeAllowed: ").Append(IsLoginTypeAllowed).Append("\n");
            sb.Append("  IsOutsideAcceptableTimeframe: ").Append(IsOutsideAcceptableTimeframe).Append("\n");
            sb.Append("  IsOutsideGeolocation: ").Append(IsOutsideGeolocation).Append("\n");
            sb.Append("  OutsideOperationalHoursMessage: ").Append(OutsideOperationalHoursMessage).Append("\n");
            sb.Append("  IsMaskRequired: ").Append(IsMaskRequired).Append("\n");
            sb.Append("  CheckInOutsideGPSAllowed: ").Append(CheckInOutsideGPSAllowed).Append("\n");
            sb.Append("  CheckOutOutsideGPSAllowed: ").Append(CheckOutOutsideGPSAllowed).Append("\n");
            sb.Append("  IsCompliantNonCompliantCheckInEnabled: ").Append(IsCompliantNonCompliantCheckInEnabled).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingCheckInOutCheckInValidateResponse)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingCheckInOutCheckInValidateResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingCheckInOutCheckInValidateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingCheckInOutCheckInValidateResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    IsBadgeScanRequired == other.IsBadgeScanRequired ||
                    
                    IsBadgeScanRequired.Equals(other.IsBadgeScanRequired)
                ) && 
                (
                    IsLoginTypeAllowed == other.IsLoginTypeAllowed ||
                    
                    IsLoginTypeAllowed.Equals(other.IsLoginTypeAllowed)
                ) && 
                (
                    IsOutsideAcceptableTimeframe == other.IsOutsideAcceptableTimeframe ||
                    
                    IsOutsideAcceptableTimeframe.Equals(other.IsOutsideAcceptableTimeframe)
                ) && 
                (
                    IsOutsideGeolocation == other.IsOutsideGeolocation ||
                    
                    IsOutsideGeolocation.Equals(other.IsOutsideGeolocation)
                ) && 
                (
                    OutsideOperationalHoursMessage == other.OutsideOperationalHoursMessage ||
                    OutsideOperationalHoursMessage != null &&
                    OutsideOperationalHoursMessage.Equals(other.OutsideOperationalHoursMessage)
                ) && 
                (
                    IsMaskRequired == other.IsMaskRequired ||
                    
                    IsMaskRequired.Equals(other.IsMaskRequired)
                ) && 
                (
                    CheckInOutsideGPSAllowed == other.CheckInOutsideGPSAllowed ||
                    
                    CheckInOutsideGPSAllowed.Equals(other.CheckInOutsideGPSAllowed)
                ) && 
                (
                    CheckOutOutsideGPSAllowed == other.CheckOutOutsideGPSAllowed ||
                    
                    CheckOutOutsideGPSAllowed.Equals(other.CheckOutOutsideGPSAllowed)
                ) && 
                (
                    IsCompliantNonCompliantCheckInEnabled == other.IsCompliantNonCompliantCheckInEnabled ||
                    
                    IsCompliantNonCompliantCheckInEnabled.Equals(other.IsCompliantNonCompliantCheckInEnabled)
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
                    
                    hashCode = hashCode * 59 + IsBadgeScanRequired.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsLoginTypeAllowed.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsOutsideAcceptableTimeframe.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsOutsideGeolocation.GetHashCode();
                    if (OutsideOperationalHoursMessage != null)
                    hashCode = hashCode * 59 + OutsideOperationalHoursMessage.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsMaskRequired.GetHashCode();
                    
                    hashCode = hashCode * 59 + CheckInOutsideGPSAllowed.GetHashCode();
                    
                    hashCode = hashCode * 59 + CheckOutOutsideGPSAllowed.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsCompliantNonCompliantCheckInEnabled.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingCheckInOutCheckInValidateResponse left, SCServiceChannelServicesMessagingCheckInOutCheckInValidateResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingCheckInOutCheckInValidateResponse left, SCServiceChannelServicesMessagingCheckInOutCheckInValidateResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}