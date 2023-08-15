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
    /// Object request to add a holiday to a location.
    /// </summary>
    [DataContract]
    public class SCServiceChannelServicesMessagingAfterHoursAddHolidayApiModelRequest : IEquatable<SCServiceChannelServicesMessagingAfterHoursAddHolidayApiModelRequest>
    {
        /// <summary>
        /// Holiday name.
        /// </summary>
        /// <value>Holiday name.</value>
        [DataMember(Name="HolidayName", EmitDefaultValue=false)]
        public string HolidayName { get; set; }

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
        
        public enum FrequencyEnum
        {
            
            /// <summary>
            /// Enum WeeklyEnum for Weekly
            /// </summary>
            [EnumMember(Value = "Weekly")]
            WeeklyEnum = 1,
            
            /// <summary>
            /// Enum MonthlyEnum for Monthly
            /// </summary>
            [EnumMember(Value = "Monthly")]
            MonthlyEnum = 2,
            
            /// <summary>
            /// Enum YearlyEnum for Yearly
            /// </summary>
            [EnumMember(Value = "Yearly")]
            YearlyEnum = 3,
            
            /// <summary>
            /// Enum SingularEnum for Singular
            /// </summary>
            [EnumMember(Value = "Singular")]
            SingularEnum = 4
        }

        /// <summary>
        /// Defines how often the holiday occurs. Valid values: Singular, Weekly, Monthly, Yearly.
        /// </summary>
        /// <value>Defines how often the holiday occurs. Valid values: Singular, Weekly, Monthly, Yearly.</value>
        [DataMember(Name="Frequency", EmitDefaultValue=true)]
        public FrequencyEnum Frequency { get; set; }

        /// <summary>
        /// Holiday date.
        /// </summary>
        /// <value>Holiday date.</value>
        [DataMember(Name="StartDate", EmitDefaultValue=false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Defines intervals for the holiday to repeat. Valid values: a number from 1 to 60. Used in combination with the &#x60;Frequency&#x60; values: Yearly, Monthly, Weekly.
        /// </summary>
        /// <value>Defines intervals for the holiday to repeat. Valid values: a number from 1 to 60. Used in combination with the &#x60;Frequency&#x60; values: Yearly, Monthly, Weekly.</value>
        [RegularExpression("^(?:[A-Za-z0-9+/]{4})*(?:[A-Za-z0-9+/]{2}==|[A-Za-z0-9+/]{3}=)?$")]
        [DataMember(Name="RepeatEvery", EmitDefaultValue=false)]
        public byte[] RepeatEvery { get; set; }


        /// <summary>
        /// Defines whether the holiday repeats on days of the month or week. Valid values: DaysOfWeek, DaysOfMonth
        /// </summary>
        /// <value>Defines whether the holiday repeats on days of the month or week. Valid values: DaysOfWeek, DaysOfMonth</value>
        
        public enum RepeatByEnum
        {
            
            /// <summary>
            /// Enum DayOfWeekEnum for DayOfWeek
            /// </summary>
            [EnumMember(Value = "DayOfWeek")]
            DayOfWeekEnum = 1,
            
            /// <summary>
            /// Enum DayOfMonthEnum for DayOfMonth
            /// </summary>
            [EnumMember(Value = "DayOfMonth")]
            DayOfMonthEnum = 2
        }

        /// <summary>
        /// Defines whether the holiday repeats on days of the month or week. Valid values: DaysOfWeek, DaysOfMonth
        /// </summary>
        /// <value>Defines whether the holiday repeats on days of the month or week. Valid values: DaysOfWeek, DaysOfMonth</value>
        [DataMember(Name="RepeatBy", EmitDefaultValue=true)]
        public RepeatByEnum RepeatBy { get; set; }


        /// <summary>
        /// Gets or Sets RepeatOnDays
        /// </summary>
        
        public enum RepeatOnDaysEnum
        {
            
            /// <summary>
            /// Enum SundayEnum for Sunday
            /// </summary>
            [EnumMember(Value = "Sunday")]
            SundayEnum = 1,
            
            /// <summary>
            /// Enum MondayEnum for Monday
            /// </summary>
            [EnumMember(Value = "Monday")]
            MondayEnum = 2,
            
            /// <summary>
            /// Enum TuesdayEnum for Tuesday
            /// </summary>
            [EnumMember(Value = "Tuesday")]
            TuesdayEnum = 3,
            
            /// <summary>
            /// Enum WednesdayEnum for Wednesday
            /// </summary>
            [EnumMember(Value = "Wednesday")]
            WednesdayEnum = 4,
            
            /// <summary>
            /// Enum ThursdayEnum for Thursday
            /// </summary>
            [EnumMember(Value = "Thursday")]
            ThursdayEnum = 5,
            
            /// <summary>
            /// Enum FridayEnum for Friday
            /// </summary>
            [EnumMember(Value = "Friday")]
            FridayEnum = 6,
            
            /// <summary>
            /// Enum SaturdayEnum for Saturday
            /// </summary>
            [EnumMember(Value = "Saturday")]
            SaturdayEnum = 7
        }

        /// <summary>
        /// Days when the holiday occurs. Used in combination with the &#x60;Frequency&#x60; value  ‘Weekly’.
        /// </summary>
        /// <value>Days when the holiday occurs. Used in combination with the &#x60;Frequency&#x60; value  ‘Weekly’.</value>
        [DataMember(Name="RepeatOnDays", EmitDefaultValue=false)]
        public List<SCServiceChannelServicesMessagingAfterHoursAddHolidayApiModelRequest.RepeatOnDaysEnum> RepeatOnDays { get; set; }


        /// <summary>
        /// Gets or Sets RepeatOnMonths
        /// </summary>
        
        public enum RepeatOnMonthsEnum
        {
            
            /// <summary>
            /// Enum JanuaryEnum for January
            /// </summary>
            [EnumMember(Value = "January")]
            JanuaryEnum = 1,
            
            /// <summary>
            /// Enum FebruaryEnum for February
            /// </summary>
            [EnumMember(Value = "February")]
            FebruaryEnum = 2,
            
            /// <summary>
            /// Enum MarchEnum for March
            /// </summary>
            [EnumMember(Value = "March")]
            MarchEnum = 3,
            
            /// <summary>
            /// Enum AprilEnum for April
            /// </summary>
            [EnumMember(Value = "April")]
            AprilEnum = 4,
            
            /// <summary>
            /// Enum MayEnum for May
            /// </summary>
            [EnumMember(Value = "May")]
            MayEnum = 5,
            
            /// <summary>
            /// Enum JuneEnum for June
            /// </summary>
            [EnumMember(Value = "June")]
            JuneEnum = 6,
            
            /// <summary>
            /// Enum JulyEnum for July
            /// </summary>
            [EnumMember(Value = "July")]
            JulyEnum = 7,
            
            /// <summary>
            /// Enum AugustEnum for August
            /// </summary>
            [EnumMember(Value = "August")]
            AugustEnum = 8,
            
            /// <summary>
            /// Enum SeptemberEnum for September
            /// </summary>
            [EnumMember(Value = "September")]
            SeptemberEnum = 9,
            
            /// <summary>
            /// Enum OctoberEnum for October
            /// </summary>
            [EnumMember(Value = "October")]
            OctoberEnum = 10,
            
            /// <summary>
            /// Enum NovemberEnum for November
            /// </summary>
            [EnumMember(Value = "November")]
            NovemberEnum = 11,
            
            /// <summary>
            /// Enum DecemberEnum for December
            /// </summary>
            [EnumMember(Value = "December")]
            DecemberEnum = 12
        }

        /// <summary>
        /// Months when the holiday occurs. Used in combination with the &#x60;Frequency&#x60; value  ‘Yearly’.
        /// </summary>
        /// <value>Months when the holiday occurs. Used in combination with the &#x60;Frequency&#x60; value  ‘Yearly’.</value>
        [DataMember(Name="RepeatOnMonths", EmitDefaultValue=false)]
        public List<SCServiceChannelServicesMessagingAfterHoursAddHolidayApiModelRequest.RepeatOnMonthsEnum> RepeatOnMonths { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingAfterHoursAddHolidayApiModelRequest {\n");
            sb.Append("  HolidayName: ").Append(HolidayName).Append("\n");
            sb.Append("  OpenTime: ").Append(OpenTime).Append("\n");
            sb.Append("  CloseTime: ").Append(CloseTime).Append("\n");
            sb.Append("  ClosedAllDay: ").Append(ClosedAllDay).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingAfterHoursAddHolidayApiModelRequest)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingAfterHoursAddHolidayApiModelRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingAfterHoursAddHolidayApiModelRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingAfterHoursAddHolidayApiModelRequest other)
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
                    
                    Frequency.Equals(other.Frequency)
                ) && 
                (
                    StartDate == other.StartDate ||
                    StartDate != null &&
                    StartDate.Equals(other.StartDate)
                ) && 
                (
                    RepeatEvery == other.RepeatEvery ||
                    RepeatEvery != null &&
                    RepeatEvery.Equals(other.RepeatEvery)
                ) && 
                (
                    RepeatBy == other.RepeatBy ||
                    
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
                    if (OpenTime != null)
                    hashCode = hashCode * 59 + OpenTime.GetHashCode();
                    if (CloseTime != null)
                    hashCode = hashCode * 59 + CloseTime.GetHashCode();
                    
                    hashCode = hashCode * 59 + ClosedAllDay.GetHashCode();
                    
                    hashCode = hashCode * 59 + Frequency.GetHashCode();
                    if (StartDate != null)
                    hashCode = hashCode * 59 + StartDate.GetHashCode();
                    if (RepeatEvery != null)
                    hashCode = hashCode * 59 + RepeatEvery.GetHashCode();
                    
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

        public static bool operator ==(SCServiceChannelServicesMessagingAfterHoursAddHolidayApiModelRequest left, SCServiceChannelServicesMessagingAfterHoursAddHolidayApiModelRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingAfterHoursAddHolidayApiModelRequest left, SCServiceChannelServicesMessagingAfterHoursAddHolidayApiModelRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
