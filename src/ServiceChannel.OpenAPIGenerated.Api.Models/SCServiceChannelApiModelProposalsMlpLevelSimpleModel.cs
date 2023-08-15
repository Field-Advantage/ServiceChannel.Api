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
    public class SCServiceChannelApiModelProposalsMlpLevelSimpleModel : IEquatable<SCServiceChannelApiModelProposalsMlpLevelSimpleModel>
    {
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="UserId", EmitDefaultValue=true)]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or Sets LocationIds
        /// </summary>
        [DataMember(Name="LocationIds", EmitDefaultValue=false)]
        public List<int> LocationIds { get; set; }

        /// <summary>
        /// Gets or Sets LevelId
        /// </summary>
        [DataMember(Name="LevelId", EmitDefaultValue=true)]
        public int LevelId { get; set; }

        /// <summary>
        /// Gets or Sets LevelName
        /// </summary>
        [DataMember(Name="LevelName", EmitDefaultValue=false)]
        public string LevelName { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="Order", EmitDefaultValue=true)]
        public int Order { get; set; }

        /// <summary>
        /// Gets or Sets UsersLocations
        /// </summary>
        [DataMember(Name="UsersLocations", EmitDefaultValue=false)]
        public Dictionary<string, List<int>> UsersLocations { get; set; }

        /// <summary>
        /// Gets or Sets CategoryChange
        /// </summary>
        [DataMember(Name="CategoryChange", EmitDefaultValue=true)]
        public bool CategoryChange { get; set; } = false;

        /// <summary>
        /// Gets or Sets PriorityChange
        /// </summary>
        [DataMember(Name="PriorityChange", EmitDefaultValue=true)]
        public bool PriorityChange { get; set; } = false;

        /// <summary>
        /// Gets or Sets CodeChange
        /// </summary>
        [DataMember(Name="CodeChange", EmitDefaultValue=true)]
        public bool CodeChange { get; set; } = false;

        /// <summary>
        /// Gets or Sets DivisionId
        /// </summary>
        [DataMember(Name="DivisionId", EmitDefaultValue=true)]
        public int DivisionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelApiModelProposalsMlpLevelSimpleModel {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  LocationIds: ").Append(LocationIds).Append("\n");
            sb.Append("  LevelId: ").Append(LevelId).Append("\n");
            sb.Append("  LevelName: ").Append(LevelName).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  UsersLocations: ").Append(UsersLocations).Append("\n");
            sb.Append("  CategoryChange: ").Append(CategoryChange).Append("\n");
            sb.Append("  PriorityChange: ").Append(PriorityChange).Append("\n");
            sb.Append("  CodeChange: ").Append(CodeChange).Append("\n");
            sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelApiModelProposalsMlpLevelSimpleModel)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelApiModelProposalsMlpLevelSimpleModel instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelApiModelProposalsMlpLevelSimpleModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelApiModelProposalsMlpLevelSimpleModel other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    UserId == other.UserId ||
                    
                    UserId.Equals(other.UserId)
                ) && 
                (
                    LocationIds == other.LocationIds ||
                    LocationIds != null &&
                    other.LocationIds != null &&
                    LocationIds.SequenceEqual(other.LocationIds)
                ) && 
                (
                    LevelId == other.LevelId ||
                    
                    LevelId.Equals(other.LevelId)
                ) && 
                (
                    LevelName == other.LevelName ||
                    LevelName != null &&
                    LevelName.Equals(other.LevelName)
                ) && 
                (
                    Order == other.Order ||
                    
                    Order.Equals(other.Order)
                ) && 
                (
                    UsersLocations == other.UsersLocations ||
                    UsersLocations != null &&
                    other.UsersLocations != null &&
                    UsersLocations.SequenceEqual(other.UsersLocations)
                ) && 
                (
                    CategoryChange == other.CategoryChange ||
                    
                    CategoryChange.Equals(other.CategoryChange)
                ) && 
                (
                    PriorityChange == other.PriorityChange ||
                    
                    PriorityChange.Equals(other.PriorityChange)
                ) && 
                (
                    CodeChange == other.CodeChange ||
                    
                    CodeChange.Equals(other.CodeChange)
                ) && 
                (
                    DivisionId == other.DivisionId ||
                    
                    DivisionId.Equals(other.DivisionId)
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
                    if (LocationIds != null)
                    hashCode = hashCode * 59 + LocationIds.GetHashCode();
                    
                    hashCode = hashCode * 59 + LevelId.GetHashCode();
                    if (LevelName != null)
                    hashCode = hashCode * 59 + LevelName.GetHashCode();
                    
                    hashCode = hashCode * 59 + Order.GetHashCode();
                    if (UsersLocations != null)
                    hashCode = hashCode * 59 + UsersLocations.GetHashCode();
                    
                    hashCode = hashCode * 59 + CategoryChange.GetHashCode();
                    
                    hashCode = hashCode * 59 + PriorityChange.GetHashCode();
                    
                    hashCode = hashCode * 59 + CodeChange.GetHashCode();
                    
                    hashCode = hashCode * 59 + DivisionId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelApiModelProposalsMlpLevelSimpleModel left, SCServiceChannelApiModelProposalsMlpLevelSimpleModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelApiModelProposalsMlpLevelSimpleModel left, SCServiceChannelApiModelProposalsMlpLevelSimpleModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}