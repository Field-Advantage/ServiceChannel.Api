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
    public class SCServiceChannelServicesMessagingWorkordersCreateWoNoteRequest : IEquatable<SCServiceChannelServicesMessagingWorkordersCreateWoNoteRequest>
    {
        /// <summary>
        /// Required, Note text
        /// </summary>
        /// <value>Required, Note text</value>
        [Required]
        [DataMember(Name="Note", EmitDefaultValue=false)]
        public string Note { get; set; }

        /// <summary>
        /// E-mail address(es)
        /// </summary>
        /// <value>E-mail address(es)</value>
        [DataMember(Name="MailedTo", EmitDefaultValue=false)]
        public string MailedTo { get; set; }

        /// <summary>
        /// Action requred flag
        /// </summary>
        /// <value>Action requred flag</value>
        [DataMember(Name="ActionRequired", EmitDefaultValue=true)]
        public bool ActionRequired { get; set; } = false;

        /// <summary>
        /// Scheduled Date and Time
        /// </summary>
        /// <value>Scheduled Date and Time</value>
        [DataMember(Name="ScheduledDate", EmitDefaultValue=false)]
        public DateTime ScheduledDate { get; set; }

        /// <summary>
        /// Gets or Sets FollowUpDate
        /// </summary>
        [DataMember(Name="FollowUpDate", EmitDefaultValue=false)]
        public DateTime FollowUpDate { get; set; }

        /// <summary>
        /// Gets or Sets IsFollowUpDateChanged
        /// </summary>
        [DataMember(Name="IsFollowUpDateChanged", EmitDefaultValue=true)]
        public bool IsFollowUpDateChanged { get; set; } = false;

        /// <summary>
        /// Gets or Sets AttachmentsIds
        /// </summary>
        [DataMember(Name="AttachmentsIds", EmitDefaultValue=false)]
        public List<int> AttachmentsIds { get; set; }

        /// <summary>
        /// Defines which parties can view the note. Visibility also works in Universal Connector where there are three primary parties: Subscriber, External Subscriber, and Provider.               Possible values:              &#x60;0&#x60; — Visible to everyone (Subscriber, External Subscriber, Provider),              &#x60;1&#x60; — Not visible to External Subscriber. Visible to Subscriber and Provider,              &#x60;2&#x60; — Not visible to Provider. Visible to Subscriber and External Subscriber.              &#x60;3&#x60; — Visible to Subscriber only.
        /// </summary>
        /// <value>Defines which parties can view the note. Visibility also works in Universal Connector where there are three primary parties: Subscriber, External Subscriber, and Provider.               Possible values:              &#x60;0&#x60; — Visible to everyone (Subscriber, External Subscriber, Provider),              &#x60;1&#x60; — Not visible to External Subscriber. Visible to Subscriber and Provider,              &#x60;2&#x60; — Not visible to Provider. Visible to Subscriber and External Subscriber.              &#x60;3&#x60; — Visible to Subscriber only.</value>
        [DataMember(Name="Visibility", EmitDefaultValue=true)]
        public int Visibility { get; set; }

        /// <summary>
        /// Actor
        /// </summary>
        /// <value>Actor</value>
        [DataMember(Name="Actor", EmitDefaultValue=false)]
        public string Actor { get; set; }

        /// <summary>
        /// If true email alert will be sent to WO Followers
        /// </summary>
        /// <value>If true email alert will be sent to WO Followers</value>
        [DataMember(Name="NotifyFollowers", EmitDefaultValue=true)]
        public bool NotifyFollowers { get; set; } = false;

        /// <summary>
        /// Gets or Sets DoNotSendEmail
        /// </summary>
        [DataMember(Name="DoNotSendEmail", EmitDefaultValue=true)]
        public bool DoNotSendEmail { get; set; } = false;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingWorkordersCreateWoNoteRequest {\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  MailedTo: ").Append(MailedTo).Append("\n");
            sb.Append("  ActionRequired: ").Append(ActionRequired).Append("\n");
            sb.Append("  ScheduledDate: ").Append(ScheduledDate).Append("\n");
            sb.Append("  FollowUpDate: ").Append(FollowUpDate).Append("\n");
            sb.Append("  IsFollowUpDateChanged: ").Append(IsFollowUpDateChanged).Append("\n");
            sb.Append("  AttachmentsIds: ").Append(AttachmentsIds).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
            sb.Append("  Actor: ").Append(Actor).Append("\n");
            sb.Append("  NotifyFollowers: ").Append(NotifyFollowers).Append("\n");
            sb.Append("  DoNotSendEmail: ").Append(DoNotSendEmail).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingWorkordersCreateWoNoteRequest)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingWorkordersCreateWoNoteRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingWorkordersCreateWoNoteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingWorkordersCreateWoNoteRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Note == other.Note ||
                    Note != null &&
                    Note.Equals(other.Note)
                ) && 
                (
                    MailedTo == other.MailedTo ||
                    MailedTo != null &&
                    MailedTo.Equals(other.MailedTo)
                ) && 
                (
                    ActionRequired == other.ActionRequired ||
                    
                    ActionRequired.Equals(other.ActionRequired)
                ) && 
                (
                    ScheduledDate == other.ScheduledDate ||
                    ScheduledDate != null &&
                    ScheduledDate.Equals(other.ScheduledDate)
                ) && 
                (
                    FollowUpDate == other.FollowUpDate ||
                    FollowUpDate != null &&
                    FollowUpDate.Equals(other.FollowUpDate)
                ) && 
                (
                    IsFollowUpDateChanged == other.IsFollowUpDateChanged ||
                    
                    IsFollowUpDateChanged.Equals(other.IsFollowUpDateChanged)
                ) && 
                (
                    AttachmentsIds == other.AttachmentsIds ||
                    AttachmentsIds != null &&
                    other.AttachmentsIds != null &&
                    AttachmentsIds.SequenceEqual(other.AttachmentsIds)
                ) && 
                (
                    Visibility == other.Visibility ||
                    
                    Visibility.Equals(other.Visibility)
                ) && 
                (
                    Actor == other.Actor ||
                    Actor != null &&
                    Actor.Equals(other.Actor)
                ) && 
                (
                    NotifyFollowers == other.NotifyFollowers ||
                    
                    NotifyFollowers.Equals(other.NotifyFollowers)
                ) && 
                (
                    DoNotSendEmail == other.DoNotSendEmail ||
                    
                    DoNotSendEmail.Equals(other.DoNotSendEmail)
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
                    if (Note != null)
                    hashCode = hashCode * 59 + Note.GetHashCode();
                    if (MailedTo != null)
                    hashCode = hashCode * 59 + MailedTo.GetHashCode();
                    
                    hashCode = hashCode * 59 + ActionRequired.GetHashCode();
                    if (ScheduledDate != null)
                    hashCode = hashCode * 59 + ScheduledDate.GetHashCode();
                    if (FollowUpDate != null)
                    hashCode = hashCode * 59 + FollowUpDate.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsFollowUpDateChanged.GetHashCode();
                    if (AttachmentsIds != null)
                    hashCode = hashCode * 59 + AttachmentsIds.GetHashCode();
                    
                    hashCode = hashCode * 59 + Visibility.GetHashCode();
                    if (Actor != null)
                    hashCode = hashCode * 59 + Actor.GetHashCode();
                    
                    hashCode = hashCode * 59 + NotifyFollowers.GetHashCode();
                    
                    hashCode = hashCode * 59 + DoNotSendEmail.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingWorkordersCreateWoNoteRequest left, SCServiceChannelServicesMessagingWorkordersCreateWoNoteRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingWorkordersCreateWoNoteRequest left, SCServiceChannelServicesMessagingWorkordersCreateWoNoteRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}