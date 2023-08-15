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
    /// The request object to assign a proposal to a user.
    /// </summary>
    [DataContract]
    public class SCServiceChannelServicesMessagingProposalsAssignUserToProposalRequest : IEquatable<SCServiceChannelServicesMessagingProposalsAssignUserToProposalRequest>
    {
        /// <summary>
        /// The unique numeric identifier of the user to assign the proposal to.
        /// </summary>
        /// <value>The unique numeric identifier of the user to assign the proposal to.</value>
        [Required]
        [DataMember(Name="UserId", EmitDefaultValue=true)]
        public int UserId { get; set; }

        /// <summary>
        /// Your comment describing why you are assigning or reassigning the proposal to the specified user.
        /// </summary>
        /// <value>Your comment describing why you are assigning or reassigning the proposal to the specified user.</value>
        [DataMember(Name="Comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// The email address to send a notification about the assigned proposal to. The default is the email address of the user who is assigned the proposal.
        /// </summary>
        /// <value>The email address to send a notification about the assigned proposal to. The default is the email address of the user who is assigned the proposal.</value>
        [DataMember(Name="UserEmail", EmitDefaultValue=false)]
        public string UserEmail { get; set; }

        /// <summary>
        /// Reason for approving the proposal. Don’t pass when assigning the proposal to a user.
        /// </summary>
        /// <value>Reason for approving the proposal. Don’t pass when assigning the proposal to a user.</value>
        [DataMember(Name="ReasonString", EmitDefaultValue=false)]
        public string ReasonString { get; set; }

        /// <summary>
        /// Note added upon assigning or reassigning the proposal.
        /// </summary>
        /// <value>Note added upon assigning or reassigning the proposal.</value>
        [DataMember(Name="Note", EmitDefaultValue=false)]
        public string Note { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingProposalsAssignUserToProposalRequest {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  UserEmail: ").Append(UserEmail).Append("\n");
            sb.Append("  ReasonString: ").Append(ReasonString).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingProposalsAssignUserToProposalRequest)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingProposalsAssignUserToProposalRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingProposalsAssignUserToProposalRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingProposalsAssignUserToProposalRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    UserId == other.UserId ||
                    
                    UserId.Equals(other.UserId)
                ) && 
                (
                    Comments == other.Comments ||
                    Comments != null &&
                    Comments.Equals(other.Comments)
                ) && 
                (
                    UserEmail == other.UserEmail ||
                    UserEmail != null &&
                    UserEmail.Equals(other.UserEmail)
                ) && 
                (
                    ReasonString == other.ReasonString ||
                    ReasonString != null &&
                    ReasonString.Equals(other.ReasonString)
                ) && 
                (
                    Note == other.Note ||
                    Note != null &&
                    Note.Equals(other.Note)
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
                    
                    hashCode = hashCode * 59 + UserId.GetHashCode();
                    if (Comments != null)
                    hashCode = hashCode * 59 + Comments.GetHashCode();
                    if (UserEmail != null)
                    hashCode = hashCode * 59 + UserEmail.GetHashCode();
                    if (ReasonString != null)
                    hashCode = hashCode * 59 + ReasonString.GetHashCode();
                    if (Note != null)
                    hashCode = hashCode * 59 + Note.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingProposalsAssignUserToProposalRequest left, SCServiceChannelServicesMessagingProposalsAssignUserToProposalRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingProposalsAssignUserToProposalRequest left, SCServiceChannelServicesMessagingProposalsAssignUserToProposalRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}