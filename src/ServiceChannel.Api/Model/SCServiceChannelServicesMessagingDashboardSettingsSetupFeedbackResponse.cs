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
    /// SCServiceChannelServicesMessagingDashboardSettingsSetupFeedbackResponse
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.DashboardSettings.SetupFeedbackResponse")]
    public partial class SCServiceChannelServicesMessagingDashboardSettingsSetupFeedbackResponse : IEquatable<SCServiceChannelServicesMessagingDashboardSettingsSetupFeedbackResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingDashboardSettingsSetupFeedbackResponse" /> class.
        /// </summary>
        /// <param name="setupId">setupId.</param>
        /// <param name="enableFeedback">enableFeedback (default to false).</param>
        /// <param name="emailHeader">emailHeader.</param>
        /// <param name="customUnsatisfactoryMessage">customUnsatisfactoryMessage.</param>
        /// <param name="enableNegativeFeedback">enableNegativeFeedback (default to false).</param>
        /// <param name="enablePositiveFeedback">enablePositiveFeedback (default to false).</param>
        /// <param name="showDays">showDays.</param>
        /// <param name="showCompletedDate">showCompletedDate (default to false).</param>
        /// <param name="showResolution">showResolution (default to false).</param>
        /// <param name="enableNegFeedNotification">enableNegFeedNotification (default to false).</param>
        /// <param name="enableAutoConfirm">enableAutoConfirm (default to false).</param>
        /// <param name="daysPeriod">daysPeriod.</param>
        /// <param name="customMessage">customMessage.</param>
        /// <param name="statuses">statuses.</param>
        /// <param name="enableScheduledDate">enableScheduledDate (default to false).</param>
        /// <param name="skipUnsatisfactoryAlertsToProviders">skipUnsatisfactoryAlertsToProviders (default to false).</param>
        /// <param name="unsatisfactorySubmitAttemptsNotification">unsatisfactorySubmitAttemptsNotification (default to false).</param>
        /// <param name="sendFeedbackToCreatedByUser">sendFeedbackToCreatedByUser (default to false).</param>
        /// <param name="enableSupplyManagerEmailConfirmation">enableSupplyManagerEmailConfirmation (default to false).</param>
        /// <param name="supplyManagerEmailConfirmationHoursAfter">supplyManagerEmailConfirmationHoursAfter.</param>
        /// <param name="supplyManagerEmailConfirmationCustomNotificationMessage">supplyManagerEmailConfirmationCustomNotificationMessage.</param>
        /// <param name="answeringCustomQuestionOptional">answeringCustomQuestionOptional (default to false).</param>
        public SCServiceChannelServicesMessagingDashboardSettingsSetupFeedbackResponse(int setupId = default(int), bool enableFeedback = false, string emailHeader = default(string), string customUnsatisfactoryMessage = default(string), bool enableNegativeFeedback = false, bool enablePositiveFeedback = false, int showDays = default(int), bool showCompletedDate = false, bool showResolution = false, bool enableNegFeedNotification = false, bool enableAutoConfirm = false, int daysPeriod = default(int), string customMessage = default(string), List<string> statuses = default(List<string>), bool enableScheduledDate = false, bool skipUnsatisfactoryAlertsToProviders = false, bool unsatisfactorySubmitAttemptsNotification = false, bool sendFeedbackToCreatedByUser = false, bool enableSupplyManagerEmailConfirmation = false, int supplyManagerEmailConfirmationHoursAfter = default(int), string supplyManagerEmailConfirmationCustomNotificationMessage = default(string), bool answeringCustomQuestionOptional = false)
        {
            this.SetupId = setupId;
            this.EnableFeedback = enableFeedback;
            this.EmailHeader = emailHeader;
            this.CustomUnsatisfactoryMessage = customUnsatisfactoryMessage;
            this.EnableNegativeFeedback = enableNegativeFeedback;
            this.EnablePositiveFeedback = enablePositiveFeedback;
            this.ShowDays = showDays;
            this.ShowCompletedDate = showCompletedDate;
            this.ShowResolution = showResolution;
            this.EnableNegFeedNotification = enableNegFeedNotification;
            this.EnableAutoConfirm = enableAutoConfirm;
            this.DaysPeriod = daysPeriod;
            this.CustomMessage = customMessage;
            this.Statuses = statuses;
            this.EnableScheduledDate = enableScheduledDate;
            this.SkipUnsatisfactoryAlertsToProviders = skipUnsatisfactoryAlertsToProviders;
            this.UnsatisfactorySubmitAttemptsNotification = unsatisfactorySubmitAttemptsNotification;
            this.SendFeedbackToCreatedByUser = sendFeedbackToCreatedByUser;
            this.EnableSupplyManagerEmailConfirmation = enableSupplyManagerEmailConfirmation;
            this.SupplyManagerEmailConfirmationHoursAfter = supplyManagerEmailConfirmationHoursAfter;
            this.SupplyManagerEmailConfirmationCustomNotificationMessage = supplyManagerEmailConfirmationCustomNotificationMessage;
            this.AnsweringCustomQuestionOptional = answeringCustomQuestionOptional;
        }

        /// <summary>
        /// Gets or Sets SetupId
        /// </summary>
        [DataMember(Name = "SetupId", EmitDefaultValue = false)]
        public int SetupId { get; set; }

        /// <summary>
        /// Gets or Sets EnableFeedback
        /// </summary>
        [DataMember(Name = "EnableFeedback", EmitDefaultValue = true)]
        public bool EnableFeedback { get; set; }

        /// <summary>
        /// Gets or Sets EmailHeader
        /// </summary>
        [DataMember(Name = "EmailHeader", EmitDefaultValue = false)]
        public string EmailHeader { get; set; }

        /// <summary>
        /// Gets or Sets CustomUnsatisfactoryMessage
        /// </summary>
        [DataMember(Name = "CustomUnsatisfactoryMessage", EmitDefaultValue = false)]
        public string CustomUnsatisfactoryMessage { get; set; }

        /// <summary>
        /// Gets or Sets EnableNegativeFeedback
        /// </summary>
        [DataMember(Name = "EnableNegativeFeedback", EmitDefaultValue = true)]
        public bool EnableNegativeFeedback { get; set; }

        /// <summary>
        /// Gets or Sets EnablePositiveFeedback
        /// </summary>
        [DataMember(Name = "EnablePositiveFeedback", EmitDefaultValue = true)]
        public bool EnablePositiveFeedback { get; set; }

        /// <summary>
        /// Gets or Sets ShowDays
        /// </summary>
        [DataMember(Name = "ShowDays", EmitDefaultValue = false)]
        public int ShowDays { get; set; }

        /// <summary>
        /// Gets or Sets ShowCompletedDate
        /// </summary>
        [DataMember(Name = "ShowCompletedDate", EmitDefaultValue = true)]
        public bool ShowCompletedDate { get; set; }

        /// <summary>
        /// Gets or Sets ShowResolution
        /// </summary>
        [DataMember(Name = "ShowResolution", EmitDefaultValue = true)]
        public bool ShowResolution { get; set; }

        /// <summary>
        /// Gets or Sets EnableNegFeedNotification
        /// </summary>
        [DataMember(Name = "EnableNegFeedNotification", EmitDefaultValue = true)]
        public bool EnableNegFeedNotification { get; set; }

        /// <summary>
        /// Gets or Sets EnableAutoConfirm
        /// </summary>
        [DataMember(Name = "EnableAutoConfirm", EmitDefaultValue = true)]
        public bool EnableAutoConfirm { get; set; }

        /// <summary>
        /// Gets or Sets DaysPeriod
        /// </summary>
        [DataMember(Name = "DaysPeriod", EmitDefaultValue = false)]
        public int DaysPeriod { get; set; }

        /// <summary>
        /// Gets or Sets CustomMessage
        /// </summary>
        [DataMember(Name = "CustomMessage", EmitDefaultValue = false)]
        public string CustomMessage { get; set; }

        /// <summary>
        /// Gets or Sets Statuses
        /// </summary>
        [DataMember(Name = "Statuses", EmitDefaultValue = false)]
        public List<string> Statuses { get; set; }

        /// <summary>
        /// Gets or Sets EnableScheduledDate
        /// </summary>
        [DataMember(Name = "EnableScheduledDate", EmitDefaultValue = true)]
        public bool EnableScheduledDate { get; set; }

        /// <summary>
        /// Gets or Sets SkipUnsatisfactoryAlertsToProviders
        /// </summary>
        [DataMember(Name = "SkipUnsatisfactoryAlertsToProviders", EmitDefaultValue = true)]
        public bool SkipUnsatisfactoryAlertsToProviders { get; set; }

        /// <summary>
        /// Gets or Sets UnsatisfactorySubmitAttemptsNotification
        /// </summary>
        [DataMember(Name = "UnsatisfactorySubmitAttemptsNotification", EmitDefaultValue = true)]
        public bool UnsatisfactorySubmitAttemptsNotification { get; set; }

        /// <summary>
        /// Gets or Sets SendFeedbackToCreatedByUser
        /// </summary>
        [DataMember(Name = "SendFeedbackToCreatedByUser", EmitDefaultValue = true)]
        public bool SendFeedbackToCreatedByUser { get; set; }

        /// <summary>
        /// Gets or Sets EnableSupplyManagerEmailConfirmation
        /// </summary>
        [DataMember(Name = "EnableSupplyManagerEmailConfirmation", EmitDefaultValue = true)]
        public bool EnableSupplyManagerEmailConfirmation { get; set; }

        /// <summary>
        /// Gets or Sets SupplyManagerEmailConfirmationHoursAfter
        /// </summary>
        [DataMember(Name = "SupplyManagerEmailConfirmationHoursAfter", EmitDefaultValue = false)]
        public int SupplyManagerEmailConfirmationHoursAfter { get; set; }

        /// <summary>
        /// Gets or Sets SupplyManagerEmailConfirmationCustomNotificationMessage
        /// </summary>
        [DataMember(Name = "SupplyManagerEmailConfirmationCustomNotificationMessage", EmitDefaultValue = false)]
        public string SupplyManagerEmailConfirmationCustomNotificationMessage { get; set; }

        /// <summary>
        /// Gets or Sets AnsweringCustomQuestionOptional
        /// </summary>
        [DataMember(Name = "AnsweringCustomQuestionOptional", EmitDefaultValue = true)]
        public bool AnsweringCustomQuestionOptional { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingDashboardSettingsSetupFeedbackResponse {\n");
            sb.Append("  SetupId: ").Append(SetupId).Append("\n");
            sb.Append("  EnableFeedback: ").Append(EnableFeedback).Append("\n");
            sb.Append("  EmailHeader: ").Append(EmailHeader).Append("\n");
            sb.Append("  CustomUnsatisfactoryMessage: ").Append(CustomUnsatisfactoryMessage).Append("\n");
            sb.Append("  EnableNegativeFeedback: ").Append(EnableNegativeFeedback).Append("\n");
            sb.Append("  EnablePositiveFeedback: ").Append(EnablePositiveFeedback).Append("\n");
            sb.Append("  ShowDays: ").Append(ShowDays).Append("\n");
            sb.Append("  ShowCompletedDate: ").Append(ShowCompletedDate).Append("\n");
            sb.Append("  ShowResolution: ").Append(ShowResolution).Append("\n");
            sb.Append("  EnableNegFeedNotification: ").Append(EnableNegFeedNotification).Append("\n");
            sb.Append("  EnableAutoConfirm: ").Append(EnableAutoConfirm).Append("\n");
            sb.Append("  DaysPeriod: ").Append(DaysPeriod).Append("\n");
            sb.Append("  CustomMessage: ").Append(CustomMessage).Append("\n");
            sb.Append("  Statuses: ").Append(Statuses).Append("\n");
            sb.Append("  EnableScheduledDate: ").Append(EnableScheduledDate).Append("\n");
            sb.Append("  SkipUnsatisfactoryAlertsToProviders: ").Append(SkipUnsatisfactoryAlertsToProviders).Append("\n");
            sb.Append("  UnsatisfactorySubmitAttemptsNotification: ").Append(UnsatisfactorySubmitAttemptsNotification).Append("\n");
            sb.Append("  SendFeedbackToCreatedByUser: ").Append(SendFeedbackToCreatedByUser).Append("\n");
            sb.Append("  EnableSupplyManagerEmailConfirmation: ").Append(EnableSupplyManagerEmailConfirmation).Append("\n");
            sb.Append("  SupplyManagerEmailConfirmationHoursAfter: ").Append(SupplyManagerEmailConfirmationHoursAfter).Append("\n");
            sb.Append("  SupplyManagerEmailConfirmationCustomNotificationMessage: ").Append(SupplyManagerEmailConfirmationCustomNotificationMessage).Append("\n");
            sb.Append("  AnsweringCustomQuestionOptional: ").Append(AnsweringCustomQuestionOptional).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingDashboardSettingsSetupFeedbackResponse);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingDashboardSettingsSetupFeedbackResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingDashboardSettingsSetupFeedbackResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingDashboardSettingsSetupFeedbackResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SetupId == input.SetupId ||
                    this.SetupId.Equals(input.SetupId)
                ) && 
                (
                    this.EnableFeedback == input.EnableFeedback ||
                    this.EnableFeedback.Equals(input.EnableFeedback)
                ) && 
                (
                    this.EmailHeader == input.EmailHeader ||
                    (this.EmailHeader != null &&
                    this.EmailHeader.Equals(input.EmailHeader))
                ) && 
                (
                    this.CustomUnsatisfactoryMessage == input.CustomUnsatisfactoryMessage ||
                    (this.CustomUnsatisfactoryMessage != null &&
                    this.CustomUnsatisfactoryMessage.Equals(input.CustomUnsatisfactoryMessage))
                ) && 
                (
                    this.EnableNegativeFeedback == input.EnableNegativeFeedback ||
                    this.EnableNegativeFeedback.Equals(input.EnableNegativeFeedback)
                ) && 
                (
                    this.EnablePositiveFeedback == input.EnablePositiveFeedback ||
                    this.EnablePositiveFeedback.Equals(input.EnablePositiveFeedback)
                ) && 
                (
                    this.ShowDays == input.ShowDays ||
                    this.ShowDays.Equals(input.ShowDays)
                ) && 
                (
                    this.ShowCompletedDate == input.ShowCompletedDate ||
                    this.ShowCompletedDate.Equals(input.ShowCompletedDate)
                ) && 
                (
                    this.ShowResolution == input.ShowResolution ||
                    this.ShowResolution.Equals(input.ShowResolution)
                ) && 
                (
                    this.EnableNegFeedNotification == input.EnableNegFeedNotification ||
                    this.EnableNegFeedNotification.Equals(input.EnableNegFeedNotification)
                ) && 
                (
                    this.EnableAutoConfirm == input.EnableAutoConfirm ||
                    this.EnableAutoConfirm.Equals(input.EnableAutoConfirm)
                ) && 
                (
                    this.DaysPeriod == input.DaysPeriod ||
                    this.DaysPeriod.Equals(input.DaysPeriod)
                ) && 
                (
                    this.CustomMessage == input.CustomMessage ||
                    (this.CustomMessage != null &&
                    this.CustomMessage.Equals(input.CustomMessage))
                ) && 
                (
                    this.Statuses == input.Statuses ||
                    this.Statuses != null &&
                    input.Statuses != null &&
                    this.Statuses.SequenceEqual(input.Statuses)
                ) && 
                (
                    this.EnableScheduledDate == input.EnableScheduledDate ||
                    this.EnableScheduledDate.Equals(input.EnableScheduledDate)
                ) && 
                (
                    this.SkipUnsatisfactoryAlertsToProviders == input.SkipUnsatisfactoryAlertsToProviders ||
                    this.SkipUnsatisfactoryAlertsToProviders.Equals(input.SkipUnsatisfactoryAlertsToProviders)
                ) && 
                (
                    this.UnsatisfactorySubmitAttemptsNotification == input.UnsatisfactorySubmitAttemptsNotification ||
                    this.UnsatisfactorySubmitAttemptsNotification.Equals(input.UnsatisfactorySubmitAttemptsNotification)
                ) && 
                (
                    this.SendFeedbackToCreatedByUser == input.SendFeedbackToCreatedByUser ||
                    this.SendFeedbackToCreatedByUser.Equals(input.SendFeedbackToCreatedByUser)
                ) && 
                (
                    this.EnableSupplyManagerEmailConfirmation == input.EnableSupplyManagerEmailConfirmation ||
                    this.EnableSupplyManagerEmailConfirmation.Equals(input.EnableSupplyManagerEmailConfirmation)
                ) && 
                (
                    this.SupplyManagerEmailConfirmationHoursAfter == input.SupplyManagerEmailConfirmationHoursAfter ||
                    this.SupplyManagerEmailConfirmationHoursAfter.Equals(input.SupplyManagerEmailConfirmationHoursAfter)
                ) && 
                (
                    this.SupplyManagerEmailConfirmationCustomNotificationMessage == input.SupplyManagerEmailConfirmationCustomNotificationMessage ||
                    (this.SupplyManagerEmailConfirmationCustomNotificationMessage != null &&
                    this.SupplyManagerEmailConfirmationCustomNotificationMessage.Equals(input.SupplyManagerEmailConfirmationCustomNotificationMessage))
                ) && 
                (
                    this.AnsweringCustomQuestionOptional == input.AnsweringCustomQuestionOptional ||
                    this.AnsweringCustomQuestionOptional.Equals(input.AnsweringCustomQuestionOptional)
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
                hashCode = (hashCode * 59) + this.SetupId.GetHashCode();
                hashCode = (hashCode * 59) + this.EnableFeedback.GetHashCode();
                if (this.EmailHeader != null)
                {
                    hashCode = (hashCode * 59) + this.EmailHeader.GetHashCode();
                }
                if (this.CustomUnsatisfactoryMessage != null)
                {
                    hashCode = (hashCode * 59) + this.CustomUnsatisfactoryMessage.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EnableNegativeFeedback.GetHashCode();
                hashCode = (hashCode * 59) + this.EnablePositiveFeedback.GetHashCode();
                hashCode = (hashCode * 59) + this.ShowDays.GetHashCode();
                hashCode = (hashCode * 59) + this.ShowCompletedDate.GetHashCode();
                hashCode = (hashCode * 59) + this.ShowResolution.GetHashCode();
                hashCode = (hashCode * 59) + this.EnableNegFeedNotification.GetHashCode();
                hashCode = (hashCode * 59) + this.EnableAutoConfirm.GetHashCode();
                hashCode = (hashCode * 59) + this.DaysPeriod.GetHashCode();
                if (this.CustomMessage != null)
                {
                    hashCode = (hashCode * 59) + this.CustomMessage.GetHashCode();
                }
                if (this.Statuses != null)
                {
                    hashCode = (hashCode * 59) + this.Statuses.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EnableScheduledDate.GetHashCode();
                hashCode = (hashCode * 59) + this.SkipUnsatisfactoryAlertsToProviders.GetHashCode();
                hashCode = (hashCode * 59) + this.UnsatisfactorySubmitAttemptsNotification.GetHashCode();
                hashCode = (hashCode * 59) + this.SendFeedbackToCreatedByUser.GetHashCode();
                hashCode = (hashCode * 59) + this.EnableSupplyManagerEmailConfirmation.GetHashCode();
                hashCode = (hashCode * 59) + this.SupplyManagerEmailConfirmationHoursAfter.GetHashCode();
                if (this.SupplyManagerEmailConfirmationCustomNotificationMessage != null)
                {
                    hashCode = (hashCode * 59) + this.SupplyManagerEmailConfirmationCustomNotificationMessage.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AnsweringCustomQuestionOptional.GetHashCode();
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