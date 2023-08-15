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
    /// SCServiceChannelNotificationsObjectsNote
    /// </summary>
    [DataContract(Name = "ServiceChannel.Notifications.Objects.Note")]
    public partial class SCServiceChannelNotificationsObjectsNote : IEquatable<SCServiceChannelNotificationsObjectsNote>, IValidatableObject
    {
        /// <summary>
        /// Defines NoteType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NoteTypeEnum
        {
            /// <summary>
            /// Enum SystemNote for value: SystemNote
            /// </summary>
            [EnumMember(Value = "SystemNote")]
            SystemNote = 1,

            /// <summary>
            /// Enum UsersNote for value: UsersNote
            /// </summary>
            [EnumMember(Value = "UsersNote")]
            UsersNote = 2

        }


        /// <summary>
        /// Gets or Sets NoteType
        /// </summary>
        [DataMember(Name = "NoteType", EmitDefaultValue = false)]
        public NoteTypeEnum? NoteType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelNotificationsObjectsNote" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="noteType">noteType.</param>
        /// <param name="number">number.</param>
        /// <param name="noteData">noteData.</param>
        /// <param name="dateCreated">dateCreated.</param>
        /// <param name="scheduledDate">scheduledDate.</param>
        /// <param name="followUpDate">followUpDate.</param>
        /// <param name="actionRequired">actionRequired (default to false).</param>
        /// <param name="mailedTo">mailedTo.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="createdByUser">createdByUser.</param>
        /// <param name="visibility">visibility.</param>
        /// <param name="dateCreatedDTO">dateCreatedDTO.</param>
        public SCServiceChannelNotificationsObjectsNote(int id = default(int), NoteTypeEnum? noteType = default(NoteTypeEnum?), int number = default(int), string noteData = default(string), DateTime dateCreated = default(DateTime), DateTime scheduledDate = default(DateTime), DateTime followUpDate = default(DateTime), bool actionRequired = false, string mailedTo = default(string), string createdBy = default(string), SCServiceChannelNotificationsObjectsUser createdByUser = default(SCServiceChannelNotificationsObjectsUser), int visibility = default(int), DateTime dateCreatedDTO = default(DateTime))
        {
            this.Id = id;
            this.NoteType = noteType;
            this.Number = number;
            this.NoteData = noteData;
            this.DateCreated = dateCreated;
            this.ScheduledDate = scheduledDate;
            this.FollowUpDate = followUpDate;
            this.ActionRequired = actionRequired;
            this.MailedTo = mailedTo;
            this.CreatedBy = createdBy;
            this.CreatedByUser = createdByUser;
            this.Visibility = visibility;
            this.DateCreatedDTO = dateCreatedDTO;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name = "Number", EmitDefaultValue = false)]
        public int Number { get; set; }

        /// <summary>
        /// Gets or Sets NoteData
        /// </summary>
        [DataMember(Name = "NoteData", EmitDefaultValue = false)]
        public string NoteData { get; set; }

        /// <summary>
        /// Gets or Sets DateCreated
        /// </summary>
        [DataMember(Name = "DateCreated", EmitDefaultValue = false)]
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledDate
        /// </summary>
        [DataMember(Name = "ScheduledDate", EmitDefaultValue = false)]
        public DateTime ScheduledDate { get; set; }

        /// <summary>
        /// Gets or Sets FollowUpDate
        /// </summary>
        [DataMember(Name = "FollowUpDate", EmitDefaultValue = false)]
        public DateTime FollowUpDate { get; set; }

        /// <summary>
        /// Gets or Sets ActionRequired
        /// </summary>
        [DataMember(Name = "ActionRequired", EmitDefaultValue = true)]
        public bool ActionRequired { get; set; }

        /// <summary>
        /// Gets or Sets MailedTo
        /// </summary>
        [DataMember(Name = "MailedTo", EmitDefaultValue = false)]
        public string MailedTo { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "CreatedBy", EmitDefaultValue = false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets CreatedByUser
        /// </summary>
        [DataMember(Name = "CreatedByUser", EmitDefaultValue = false)]
        public SCServiceChannelNotificationsObjectsUser CreatedByUser { get; set; }

        /// <summary>
        /// Gets or Sets Visibility
        /// </summary>
        [DataMember(Name = "Visibility", EmitDefaultValue = false)]
        public int Visibility { get; set; }

        /// <summary>
        /// Gets or Sets DateCreatedDTO
        /// </summary>
        [DataMember(Name = "DateCreated_DTO", EmitDefaultValue = false)]
        public DateTime DateCreatedDTO { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelNotificationsObjectsNote {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  NoteType: ").Append(NoteType).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  NoteData: ").Append(NoteData).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  ScheduledDate: ").Append(ScheduledDate).Append("\n");
            sb.Append("  FollowUpDate: ").Append(FollowUpDate).Append("\n");
            sb.Append("  ActionRequired: ").Append(ActionRequired).Append("\n");
            sb.Append("  MailedTo: ").Append(MailedTo).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedByUser: ").Append(CreatedByUser).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
            sb.Append("  DateCreatedDTO: ").Append(DateCreatedDTO).Append("\n");
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
            return this.Equals(input as SCServiceChannelNotificationsObjectsNote);
        }

        /// <summary>
        /// Returns true if SCServiceChannelNotificationsObjectsNote instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelNotificationsObjectsNote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelNotificationsObjectsNote input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.NoteType == input.NoteType ||
                    this.NoteType.Equals(input.NoteType)
                ) && 
                (
                    this.Number == input.Number ||
                    this.Number.Equals(input.Number)
                ) && 
                (
                    this.NoteData == input.NoteData ||
                    (this.NoteData != null &&
                    this.NoteData.Equals(input.NoteData))
                ) && 
                (
                    this.DateCreated == input.DateCreated ||
                    (this.DateCreated != null &&
                    this.DateCreated.Equals(input.DateCreated))
                ) && 
                (
                    this.ScheduledDate == input.ScheduledDate ||
                    (this.ScheduledDate != null &&
                    this.ScheduledDate.Equals(input.ScheduledDate))
                ) && 
                (
                    this.FollowUpDate == input.FollowUpDate ||
                    (this.FollowUpDate != null &&
                    this.FollowUpDate.Equals(input.FollowUpDate))
                ) && 
                (
                    this.ActionRequired == input.ActionRequired ||
                    this.ActionRequired.Equals(input.ActionRequired)
                ) && 
                (
                    this.MailedTo == input.MailedTo ||
                    (this.MailedTo != null &&
                    this.MailedTo.Equals(input.MailedTo))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.CreatedByUser == input.CreatedByUser ||
                    (this.CreatedByUser != null &&
                    this.CreatedByUser.Equals(input.CreatedByUser))
                ) && 
                (
                    this.Visibility == input.Visibility ||
                    this.Visibility.Equals(input.Visibility)
                ) && 
                (
                    this.DateCreatedDTO == input.DateCreatedDTO ||
                    (this.DateCreatedDTO != null &&
                    this.DateCreatedDTO.Equals(input.DateCreatedDTO))
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                hashCode = (hashCode * 59) + this.NoteType.GetHashCode();
                hashCode = (hashCode * 59) + this.Number.GetHashCode();
                if (this.NoteData != null)
                {
                    hashCode = (hashCode * 59) + this.NoteData.GetHashCode();
                }
                if (this.DateCreated != null)
                {
                    hashCode = (hashCode * 59) + this.DateCreated.GetHashCode();
                }
                if (this.ScheduledDate != null)
                {
                    hashCode = (hashCode * 59) + this.ScheduledDate.GetHashCode();
                }
                if (this.FollowUpDate != null)
                {
                    hashCode = (hashCode * 59) + this.FollowUpDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ActionRequired.GetHashCode();
                if (this.MailedTo != null)
                {
                    hashCode = (hashCode * 59) + this.MailedTo.GetHashCode();
                }
                if (this.CreatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedBy.GetHashCode();
                }
                if (this.CreatedByUser != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedByUser.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Visibility.GetHashCode();
                if (this.DateCreatedDTO != null)
                {
                    hashCode = (hashCode * 59) + this.DateCreatedDTO.GetHashCode();
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
