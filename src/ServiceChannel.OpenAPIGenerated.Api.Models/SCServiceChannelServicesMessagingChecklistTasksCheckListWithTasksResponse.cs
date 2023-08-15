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
    /// Parameters of a checklist with asset tasks.
    /// </summary>
    [DataContract]
    public class SCServiceChannelServicesMessagingChecklistTasksCheckListWithTasksResponse : IEquatable<SCServiceChannelServicesMessagingChecklistTasksCheckListWithTasksResponse>
    {
        /// <summary>
        /// Checklist name.
        /// </summary>
        /// <value>Checklist name.</value>
        [DataMember(Name="ChecklistName", EmitDefaultValue=false)]
        public string ChecklistName { get; set; }

        /// <summary>
        /// Checklist ID.
        /// </summary>
        /// <value>Checklist ID.</value>
        [DataMember(Name="Id", EmitDefaultValue=true)]
        public int Id { get; set; }

        /// <summary>
        /// Defines whether the checklist is active or not.
        /// </summary>
        /// <value>Defines whether the checklist is active or not.</value>
        [DataMember(Name="IsActive", EmitDefaultValue=true)]
        public bool IsActive { get; set; } = false;

        /// <summary>
        /// Date and time when the checklist was created.
        /// </summary>
        /// <value>Date and time when the checklist was created.</value>
        [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Date and time when the checklist was last updated.
        /// </summary>
        /// <value>Date and time when the checklist was last updated.</value>
        [DataMember(Name="UpdatedDate", EmitDefaultValue=false)]
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// User ID of the employee who created the checklist.
        /// </summary>
        /// <value>User ID of the employee who created the checklist.</value>
        [DataMember(Name="CreatedBy", EmitDefaultValue=true)]
        public int CreatedBy { get; set; }

        /// <summary>
        /// User ID of the employee who last updated the checklist.
        /// </summary>
        /// <value>User ID of the employee who last updated the checklist.</value>
        [DataMember(Name="UpdatedBy", EmitDefaultValue=true)]
        public int UpdatedBy { get; set; }

        /// <summary>
        /// A list of asset-related tasks configured for the checklist.
        /// </summary>
        /// <value>A list of asset-related tasks configured for the checklist.</value>
        [DataMember(Name="Tasks", EmitDefaultValue=false)]
        public List<SCServiceChannelServicesMessagingChecklistTasksChecklistTaskResponse> Tasks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingChecklistTasksCheckListWithTasksResponse {\n");
            sb.Append("  ChecklistName: ").Append(ChecklistName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  Tasks: ").Append(Tasks).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingChecklistTasksCheckListWithTasksResponse)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingChecklistTasksCheckListWithTasksResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingChecklistTasksCheckListWithTasksResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingChecklistTasksCheckListWithTasksResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ChecklistName == other.ChecklistName ||
                    ChecklistName != null &&
                    ChecklistName.Equals(other.ChecklistName)
                ) && 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    IsActive == other.IsActive ||
                    
                    IsActive.Equals(other.IsActive)
                ) && 
                (
                    CreatedDate == other.CreatedDate ||
                    CreatedDate != null &&
                    CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    UpdatedDate == other.UpdatedDate ||
                    UpdatedDate != null &&
                    UpdatedDate.Equals(other.UpdatedDate)
                ) && 
                (
                    CreatedBy == other.CreatedBy ||
                    
                    CreatedBy.Equals(other.CreatedBy)
                ) && 
                (
                    UpdatedBy == other.UpdatedBy ||
                    
                    UpdatedBy.Equals(other.UpdatedBy)
                ) && 
                (
                    Tasks == other.Tasks ||
                    Tasks != null &&
                    other.Tasks != null &&
                    Tasks.SequenceEqual(other.Tasks)
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
                    if (ChecklistName != null)
                    hashCode = hashCode * 59 + ChecklistName.GetHashCode();
                    
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsActive.GetHashCode();
                    if (CreatedDate != null)
                    hashCode = hashCode * 59 + CreatedDate.GetHashCode();
                    if (UpdatedDate != null)
                    hashCode = hashCode * 59 + UpdatedDate.GetHashCode();
                    
                    hashCode = hashCode * 59 + CreatedBy.GetHashCode();
                    
                    hashCode = hashCode * 59 + UpdatedBy.GetHashCode();
                    if (Tasks != null)
                    hashCode = hashCode * 59 + Tasks.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingChecklistTasksCheckListWithTasksResponse left, SCServiceChannelServicesMessagingChecklistTasksCheckListWithTasksResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingChecklistTasksCheckListWithTasksResponse left, SCServiceChannelServicesMessagingChecklistTasksCheckListWithTasksResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
