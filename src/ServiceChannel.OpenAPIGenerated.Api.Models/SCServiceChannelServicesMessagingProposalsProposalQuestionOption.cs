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
    public class SCServiceChannelServicesMessagingProposalsProposalQuestionOption : IEquatable<SCServiceChannelServicesMessagingProposalsProposalQuestionOption>
    {
        /// <summary>
        /// Gets or Sets IsDefault
        /// </summary>
        [DataMember(Name="IsDefault", EmitDefaultValue=true)]
        public bool IsDefault { get; set; } = false;

        /// <summary>
        /// Gets or Sets AnswerTextValue
        /// </summary>
        [DataMember(Name="AnswerTextValue", EmitDefaultValue=false)]
        public string AnswerTextValue { get; set; }

        /// <summary>
        /// Gets or Sets IsChosen
        /// </summary>
        [DataMember(Name="IsChosen", EmitDefaultValue=true)]
        public bool IsChosen { get; set; } = false;

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="IsActive", EmitDefaultValue=true)]
        public bool IsActive { get; set; } = false;

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name="SortOrder", EmitDefaultValue=true)]
        public int SortOrder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingProposalsProposalQuestionOption {\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  AnswerTextValue: ").Append(AnswerTextValue).Append("\n");
            sb.Append("  IsChosen: ").Append(IsChosen).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingProposalsProposalQuestionOption)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingProposalsProposalQuestionOption instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingProposalsProposalQuestionOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingProposalsProposalQuestionOption other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    IsDefault == other.IsDefault ||
                    
                    IsDefault.Equals(other.IsDefault)
                ) && 
                (
                    AnswerTextValue == other.AnswerTextValue ||
                    AnswerTextValue != null &&
                    AnswerTextValue.Equals(other.AnswerTextValue)
                ) && 
                (
                    IsChosen == other.IsChosen ||
                    
                    IsChosen.Equals(other.IsChosen)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    IsActive == other.IsActive ||
                    
                    IsActive.Equals(other.IsActive)
                ) && 
                (
                    SortOrder == other.SortOrder ||
                    
                    SortOrder.Equals(other.SortOrder)
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
                    
                    hashCode = hashCode * 59 + IsDefault.GetHashCode();
                    if (AnswerTextValue != null)
                    hashCode = hashCode * 59 + AnswerTextValue.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsChosen.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsActive.GetHashCode();
                    
                    hashCode = hashCode * 59 + SortOrder.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingProposalsProposalQuestionOption left, SCServiceChannelServicesMessagingProposalsProposalQuestionOption right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingProposalsProposalQuestionOption left, SCServiceChannelServicesMessagingProposalsProposalQuestionOption right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
