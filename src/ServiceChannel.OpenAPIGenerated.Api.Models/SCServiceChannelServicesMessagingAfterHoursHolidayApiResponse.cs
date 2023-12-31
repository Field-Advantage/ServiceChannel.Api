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
    public class SCServiceChannelServicesMessagingAfterHoursHolidayApiResponse : IEquatable<SCServiceChannelServicesMessagingAfterHoursHolidayApiResponse>
    {
        /// <summary>
        /// Holiday name.
        /// </summary>
        /// <value>Holiday name.</value>
        [DataMember(Name="HolidayName", EmitDefaultValue=false)]
        public string HolidayName { get; set; }

        /// <summary>
        /// Holiday date.
        /// </summary>
        /// <value>Holiday date.</value>
        [DataMember(Name="StartDate", EmitDefaultValue=false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Location opening hours.
        /// </summary>
        /// <value>Location opening hours.</value>
        [DataMember(Name="OpenTime", EmitDefaultValue=false)]
        public string OpenTime { get; set; }

        /// <summary>
        /// Location closing hours.
        /// </summary>
        /// <value>Location closing hours.</value>
        [DataMember(Name="CloseTime", EmitDefaultValue=false)]
        public string CloseTime { get; set; }

        /// <summary>
        /// Defines whether the location is closed on the specified day.
        /// </summary>
        /// <value>Defines whether the location is closed on the specified day.</value>
        [DataMember(Name="ClosedAllDay", EmitDefaultValue=true)]
        public bool ClosedAllDay { get; set; } = false;

        /// <summary>
        /// Defines how often the holiday occurs. Valid values: Singular, Weekly, Monthly, Yearly.
        /// </summary>
        /// <value>Defines how often the holiday occurs. Valid values: Singular, Weekly, Monthly, Yearly.</value>
        [DataMember(Name="Frequency", EmitDefaultValue=false)]
        public string Frequency { get; set; }

        /// <summary>
        /// Defines intervals for the holiday to repeat. Valid values: a number from 1 to 60. Used in combination with the &#x60;Frequency&#x60; values: Yearly, Monthly, Weekly.
        /// </summary>
        /// <value>Defines intervals for the holiday to repeat. Valid values: a number from 1 to 60. Used in combination with the &#x60;Frequency&#x60; values: Yearly, Monthly, Weekly.</value>
        [RegularExpression("^(?:[A-Za-z0-9+/]{4})*(?:[A-Za-z0-9+/]{2}==|[A-Za-z0-9+/]{3}=)?$")]
        [DataMember(Name="RepeatEvery", EmitDefaultValue=false)]
        public byte[] RepeatEvery { get; set; }

        /// <summary>
        /// Defines whether the holiday repeats on days of the month or week. Valid values: DaysOfWeek, DaysOfMonth.
        /// </summary>
        /// <value>Defines whether the holiday repeats on days of the month or week. Valid values: DaysOfWeek, DaysOfMonth.</value>
        [DataMember(Name="RepeatBy", EmitDefaultValue=false)]
        public string RepeatBy { get; set; }

        /// <summary>
        /// Days when the holiday occurs. Used in combination with the &#x60;Frequency&#x60; value ‘Weekly’.
        /// </summary>
        /// <value>Days when the holiday occurs. Used in combination with the &#x60;Frequency&#x60; value ‘Weekly’.</value>
        [DataMember(Name="RepeatOnDays", EmitDefaultValue=false)]
        public List<string> RepeatOnDays { get; set; }

        /// <summary>
        /// Months when the holiday occurs. Used in combination with the &#x60;Frequency&#x60; value ‘Yearly’.
        /// </summary>
        /// <value>Months when the holiday occurs. Used in combination with the &#x60;Frequency&#x60; value ‘Yearly’.</value>
        [DataMember(Name="RepeatOnMonths", EmitDefaultValue=false)]
        public List<string> RepeatOnMonths { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingAfterHoursHolidayApiResponse {\n");
            sb.Append("  HolidayName: ").Append(HolidayName).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  OpenTime: ").Append(OpenTime).Append("\n");
            sb.Append("  CloseTime: ").Append(CloseTime).Append("\n");
            sb.Append("  ClosedAllDay: ").Append(ClosedAllDay).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  RepeatEvery: ").Append(RepeatEvery).Append("\n");
            sb.Append("  RepeatBy: ").Append(RepeatBy).Append("\n");
            sb.Append("  RepeatOnDays: ").Append(RepeatOnDays).Append("\n");
            sb.Append("  RepeatOnMonths: ").Append(RepeatOnMonths).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingAfterHoursHolidayApiResponse)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingAfterHoursHolidayApiResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingAfterHoursHolidayApiResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingAfterHoursHolidayApiResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    HolidayName == other.HolidayName ||
                    HolidayName != null &&
                    HolidayName.Equals(other.HolidayName)
                ) && 
                (
                    StartDate == other.StartDate ||
                    StartDate != null &&
                    StartDate.Equals(other.StartDate)
                ) && 
                (
                    OpenTime == other.OpenTime ||
                    OpenTime != null &&
                    OpenTime.Equals(other.OpenTime)
                ) && 
                (
                    CloseTime == other.CloseTime ||
                    CloseTime != null &&
                    CloseTime.Equals(other.CloseTime)
                ) && 
                (
                    ClosedAllDay == other.ClosedAllDay ||
                    
                    ClosedAllDay.Equals(other.ClosedAllDay)
                ) && 
                (
                    Frequency == other.Frequency ||
                    Frequency != null &&
                    Frequency.Equals(other.Frequency)
                ) && 
                (
                    RepeatEvery == other.RepeatEvery ||
                    RepeatEvery != null &&
                    RepeatEvery.Equals(other.RepeatEvery)
                ) && 
                (
                    RepeatBy == other.RepeatBy ||
                    RepeatBy != null &&
                    RepeatBy.Equals(other.RepeatBy)
                ) && 
                (
                    RepeatOnDays == other.RepeatOnDays ||
                    RepeatOnDays != null &&
                    other.RepeatOnDays != null &&
                    RepeatOnDays.SequenceEqual(other.RepeatOnDays)
                ) && 
                (
                    RepeatOnMonths == other.RepeatOnMonths ||
                    RepeatOnMonths != null &&
                    other.RepeatOnMonths != null &&
                    RepeatOnMonths.SequenceEqual(other.RepeatOnMonths)
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
                    if (HolidayName != null)
                    hashCode = hashCode * 59 + HolidayName.GetHashCode();
                    if (StartDate != null)
                    hashCode = hashCode * 59 + StartDate.GetHashCode();
                    if (OpenTime != null)
                    hashCode = hashCode * 59 + OpenTime.GetHashCode();
                    if (CloseTime != null)
                    hashCode = hashCode * 59 + CloseTime.GetHashCode();
                    
                    hashCode = hashCode * 59 + ClosedAllDay.GetHashCode();
                    if (Frequency != null)
                    hashCode = hashCode * 59 + Frequency.GetHashCode();
                    if (RepeatEvery != null)
                    hashCode = hashCode * 59 + RepeatEvery.GetHashCode();
                    if (RepeatBy != null)
                    hashCode = hashCode * 59 + RepeatBy.GetHashCode();
                    if (RepeatOnDays != null)
                    hashCode = hashCode * 59 + RepeatOnDays.GetHashCode();
                    if (RepeatOnMonths != null)
                    hashCode = hashCode * 59 + RepeatOnMonths.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingAfterHoursHolidayApiResponse left, SCServiceChannelServicesMessagingAfterHoursHolidayApiResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingAfterHoursHolidayApiResponse left, SCServiceChannelServicesMessagingAfterHoursHolidayApiResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
