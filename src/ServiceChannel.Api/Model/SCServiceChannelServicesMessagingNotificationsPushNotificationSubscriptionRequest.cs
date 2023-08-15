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
    /// Subscribe Push Notification Request model
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.Notifications.PushNotificationSubscriptionRequest")]
    public partial class SCServiceChannelServicesMessagingNotificationsPushNotificationSubscriptionRequest : IEquatable<SCServiceChannelServicesMessagingNotificationsPushNotificationSubscriptionRequest>, IValidatableObject
    {
        /// <summary>
        /// Device type: Android, iOS, Amazon
        /// </summary>
        /// <value>Device type: Android, iOS, Amazon</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeviceTypeEnum
        {
            /// <summary>
            /// Enum Android for value: Android
            /// </summary>
            [EnumMember(Value = "Android")]
            Android = 1,

            /// <summary>
            /// Enum IOS for value: iOS
            /// </summary>
            [EnumMember(Value = "iOS")]
            IOS = 2,

            /// <summary>
            /// Enum Amazon for value: Amazon
            /// </summary>
            [EnumMember(Value = "Amazon")]
            Amazon = 3

        }


        /// <summary>
        /// Device type: Android, iOS, Amazon
        /// </summary>
        /// <value>Device type: Android, iOS, Amazon</value>
        [DataMember(Name = "DeviceType", IsRequired = true, EmitDefaultValue = true)]
        public DeviceTypeEnum DeviceType { get; set; }
        /// <summary>
        /// Notification type: Check In , ....
        /// </summary>
        /// <value>Notification type: Check In , ....</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NotificationTypeEnum
        {
            /// <summary>
            /// Enum CheckIn for value: CheckIn
            /// </summary>
            [EnumMember(Value = "CheckIn")]
            CheckIn = 1,

            /// <summary>
            /// Enum CheckOut for value: CheckOut
            /// </summary>
            [EnumMember(Value = "CheckOut")]
            CheckOut = 2,

            /// <summary>
            /// Enum BadgeScanRequired for value: BadgeScanRequired
            /// </summary>
            [EnumMember(Value = "BadgeScanRequired")]
            BadgeScanRequired = 3

        }


        /// <summary>
        /// Notification type: Check In , ....
        /// </summary>
        /// <value>Notification type: Check In , ....</value>
        [DataMember(Name = "NotificationType", IsRequired = true, EmitDefaultValue = true)]
        public NotificationTypeEnum NotificationType { get; set; }
        /// <summary>
        /// Application : ScMobile, FTM, ...
        /// </summary>
        /// <value>Application : ScMobile, FTM, ...</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ApplicationEnum
        {
            /// <summary>
            /// Enum ScMobile for value: ScMobile
            /// </summary>
            [EnumMember(Value = "ScMobile")]
            ScMobile = 1

        }


        /// <summary>
        /// Application : ScMobile, FTM, ...
        /// </summary>
        /// <value>Application : ScMobile, FTM, ...</value>
        [DataMember(Name = "Application", IsRequired = true, EmitDefaultValue = true)]
        public ApplicationEnum Application { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingNotificationsPushNotificationSubscriptionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SCServiceChannelServicesMessagingNotificationsPushNotificationSubscriptionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingNotificationsPushNotificationSubscriptionRequest" /> class.
        /// </summary>
        /// <param name="deviceToken">Required Device Token. (required).</param>
        /// <param name="deviceType">Device type: Android, iOS, Amazon (required).</param>
        /// <param name="notificationType">Notification type: Check In , .... (required).</param>
        /// <param name="application">Application : ScMobile, FTM, ... (required).</param>
        /// <param name="notificationRules">notificationRules.</param>
        public SCServiceChannelServicesMessagingNotificationsPushNotificationSubscriptionRequest(string deviceToken = default(string), DeviceTypeEnum deviceType = default(DeviceTypeEnum), NotificationTypeEnum notificationType = default(NotificationTypeEnum), ApplicationEnum application = default(ApplicationEnum), SCServiceChannelServicesMessagingNotificationsNotificationRulesRequest notificationRules = default(SCServiceChannelServicesMessagingNotificationsNotificationRulesRequest))
        {
            // to ensure "deviceToken" is required (not null)
            if (deviceToken == null)
            {
                throw new ArgumentNullException("deviceToken is a required property for SCServiceChannelServicesMessagingNotificationsPushNotificationSubscriptionRequest and cannot be null");
            }
            this.DeviceToken = deviceToken;
            this.DeviceType = deviceType;
            this.NotificationType = notificationType;
            this.Application = application;
            this.NotificationRules = notificationRules;
        }

        /// <summary>
        /// Required Device Token.
        /// </summary>
        /// <value>Required Device Token.</value>
        [DataMember(Name = "DeviceToken", IsRequired = true, EmitDefaultValue = true)]
        public string DeviceToken { get; set; }

        /// <summary>
        /// Gets or Sets NotificationRules
        /// </summary>
        [DataMember(Name = "NotificationRules", EmitDefaultValue = false)]
        public SCServiceChannelServicesMessagingNotificationsNotificationRulesRequest NotificationRules { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingNotificationsPushNotificationSubscriptionRequest {\n");
            sb.Append("  DeviceToken: ").Append(DeviceToken).Append("\n");
            sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
            sb.Append("  NotificationType: ").Append(NotificationType).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  NotificationRules: ").Append(NotificationRules).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingNotificationsPushNotificationSubscriptionRequest);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingNotificationsPushNotificationSubscriptionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingNotificationsPushNotificationSubscriptionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingNotificationsPushNotificationSubscriptionRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DeviceToken == input.DeviceToken ||
                    (this.DeviceToken != null &&
                    this.DeviceToken.Equals(input.DeviceToken))
                ) && 
                (
                    this.DeviceType == input.DeviceType ||
                    this.DeviceType.Equals(input.DeviceType)
                ) && 
                (
                    this.NotificationType == input.NotificationType ||
                    this.NotificationType.Equals(input.NotificationType)
                ) && 
                (
                    this.Application == input.Application ||
                    this.Application.Equals(input.Application)
                ) && 
                (
                    this.NotificationRules == input.NotificationRules ||
                    (this.NotificationRules != null &&
                    this.NotificationRules.Equals(input.NotificationRules))
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
                if (this.DeviceToken != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceToken.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DeviceType.GetHashCode();
                hashCode = (hashCode * 59) + this.NotificationType.GetHashCode();
                hashCode = (hashCode * 59) + this.Application.GetHashCode();
                if (this.NotificationRules != null)
                {
                    hashCode = (hashCode * 59) + this.NotificationRules.GetHashCode();
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
