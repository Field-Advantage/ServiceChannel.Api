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
    public class SCServiceChannelServicesMessagingIssueListsGetIssueChoiceSpecificRequest : IEquatable<SCServiceChannelServicesMessagingIssueListsGetIssueChoiceSpecificRequest>
    {
        /// <summary>
        /// Gets or Sets SubscriberId
        /// </summary>
        [Required]
        [DataMember(Name="SubscriberId", EmitDefaultValue=true)]
        public int SubscriberId { get; set; }

        /// <summary>
        /// Gets or Sets DashboardSetupId
        /// </summary>
        [Required]
        [DataMember(Name="DashboardSetupId", EmitDefaultValue=true)]
        public int DashboardSetupId { get; set; }

        /// <summary>
        /// Gets or Sets Trade
        /// </summary>
        [Required]
        [DataMember(Name="Trade", EmitDefaultValue=false)]
        public string Trade { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [Required]
        [DataMember(Name="Priority", EmitDefaultValue=false)]
        public string Priority { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [Required]
        [DataMember(Name="Category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingIssueListsGetIssueChoiceSpecificRequest {\n");
            sb.Append("  SubscriberId: ").Append(SubscriberId).Append("\n");
            sb.Append("  DashboardSetupId: ").Append(DashboardSetupId).Append("\n");
            sb.Append("  Trade: ").Append(Trade).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingIssueListsGetIssueChoiceSpecificRequest)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingIssueListsGetIssueChoiceSpecificRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingIssueListsGetIssueChoiceSpecificRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingIssueListsGetIssueChoiceSpecificRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    SubscriberId == other.SubscriberId ||
                    
                    SubscriberId.Equals(other.SubscriberId)
                ) && 
                (
                    DashboardSetupId == other.DashboardSetupId ||
                    
                    DashboardSetupId.Equals(other.DashboardSetupId)
                ) && 
                (
                    Trade == other.Trade ||
                    Trade != null &&
                    Trade.Equals(other.Trade)
                ) && 
                (
                    Priority == other.Priority ||
                    Priority != null &&
                    Priority.Equals(other.Priority)
                ) && 
                (
                    Category == other.Category ||
                    Category != null &&
                    Category.Equals(other.Category)
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
                    
                    hashCode = hashCode * 59 + SubscriberId.GetHashCode();
                    
                    hashCode = hashCode * 59 + DashboardSetupId.GetHashCode();
                    if (Trade != null)
                    hashCode = hashCode * 59 + Trade.GetHashCode();
                    if (Priority != null)
                    hashCode = hashCode * 59 + Priority.GetHashCode();
                    if (Category != null)
                    hashCode = hashCode * 59 + Category.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingIssueListsGetIssueChoiceSpecificRequest left, SCServiceChannelServicesMessagingIssueListsGetIssueChoiceSpecificRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingIssueListsGetIssueChoiceSpecificRequest left, SCServiceChannelServicesMessagingIssueListsGetIssueChoiceSpecificRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
