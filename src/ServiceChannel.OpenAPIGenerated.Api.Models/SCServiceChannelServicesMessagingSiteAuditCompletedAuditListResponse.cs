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
    public class SCServiceChannelServicesMessagingSiteAuditCompletedAuditListResponse : IEquatable<SCServiceChannelServicesMessagingSiteAuditCompletedAuditListResponse>
    {
        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="UserName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or Sets Locations
        /// </summary>
        [DataMember(Name="Locations", EmitDefaultValue=false)]
        public List<SCServiceChannelServicesMessagingSiteAuditLocationExternal> Locations { get; set; }

        /// <summary>
        /// Gets or Sets TemplateTypes
        /// </summary>
        [DataMember(Name="TemplateTypes", EmitDefaultValue=false)]
        public List<SCServiceChannelServicesMessagingSiteAuditAuditTypeExternal> TemplateTypes { get; set; }

        /// <summary>
        /// Gets or Sets CompletedAudits
        /// </summary>
        [DataMember(Name="CompletedAudits", EmitDefaultValue=false)]
        public List<SCServiceChannelServicesMessagingSiteAuditAuditInfoExternal> CompletedAudits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingSiteAuditCompletedAuditListResponse {\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  Locations: ").Append(Locations).Append("\n");
            sb.Append("  TemplateTypes: ").Append(TemplateTypes).Append("\n");
            sb.Append("  CompletedAudits: ").Append(CompletedAudits).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingSiteAuditCompletedAuditListResponse)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingSiteAuditCompletedAuditListResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingSiteAuditCompletedAuditListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingSiteAuditCompletedAuditListResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    UserName == other.UserName ||
                    UserName != null &&
                    UserName.Equals(other.UserName)
                ) && 
                (
                    Locations == other.Locations ||
                    Locations != null &&
                    other.Locations != null &&
                    Locations.SequenceEqual(other.Locations)
                ) && 
                (
                    TemplateTypes == other.TemplateTypes ||
                    TemplateTypes != null &&
                    other.TemplateTypes != null &&
                    TemplateTypes.SequenceEqual(other.TemplateTypes)
                ) && 
                (
                    CompletedAudits == other.CompletedAudits ||
                    CompletedAudits != null &&
                    other.CompletedAudits != null &&
                    CompletedAudits.SequenceEqual(other.CompletedAudits)
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
                    if (UserName != null)
                    hashCode = hashCode * 59 + UserName.GetHashCode();
                    if (Locations != null)
                    hashCode = hashCode * 59 + Locations.GetHashCode();
                    if (TemplateTypes != null)
                    hashCode = hashCode * 59 + TemplateTypes.GetHashCode();
                    if (CompletedAudits != null)
                    hashCode = hashCode * 59 + CompletedAudits.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingSiteAuditCompletedAuditListResponse left, SCServiceChannelServicesMessagingSiteAuditCompletedAuditListResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingSiteAuditCompletedAuditListResponse left, SCServiceChannelServicesMessagingSiteAuditCompletedAuditListResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
