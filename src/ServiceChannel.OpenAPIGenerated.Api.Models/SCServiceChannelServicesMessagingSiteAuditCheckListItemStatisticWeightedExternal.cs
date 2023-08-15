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
    public class SCServiceChannelServicesMessagingSiteAuditCheckListItemStatisticWeightedExternal : IEquatable<SCServiceChannelServicesMessagingSiteAuditCheckListItemStatisticWeightedExternal>
    {
        /// <summary>
        /// Gets or Sets CheckListItemId
        /// </summary>
        [DataMember(Name="CheckListItemId", EmitDefaultValue=true)]
        public int CheckListItemId { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="Date", EmitDefaultValue=false)]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name="Score", EmitDefaultValue=true)]
        public int Score { get; set; }

        /// <summary>
        /// Gets or Sets System
        /// </summary>
        [DataMember(Name="System", EmitDefaultValue=true)]
        public int System { get; set; }

        /// <summary>
        /// Gets or Sets Range
        /// </summary>
        [DataMember(Name="Range", EmitDefaultValue=false)]
        public List<int> Range { get; set; }

        /// <summary>
        /// Gets or Sets WorkOrdersCount
        /// </summary>
        [DataMember(Name="WorkOrdersCount", EmitDefaultValue=true)]
        public int WorkOrdersCount { get; set; }

        /// <summary>
        /// Gets or Sets CommentsCount
        /// </summary>
        [DataMember(Name="CommentsCount", EmitDefaultValue=true)]
        public int CommentsCount { get; set; }

        /// <summary>
        /// Gets or Sets AttachmentsCount
        /// </summary>
        [DataMember(Name="AttachmentsCount", EmitDefaultValue=true)]
        public int AttachmentsCount { get; set; }

        /// <summary>
        /// Gets or Sets QuantityCount
        /// </summary>
        [DataMember(Name="QuantityCount", EmitDefaultValue=true)]
        public int QuantityCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingSiteAuditCheckListItemStatisticWeightedExternal {\n");
            sb.Append("  CheckListItemId: ").Append(CheckListItemId).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  System: ").Append(System).Append("\n");
            sb.Append("  Range: ").Append(Range).Append("\n");
            sb.Append("  WorkOrdersCount: ").Append(WorkOrdersCount).Append("\n");
            sb.Append("  CommentsCount: ").Append(CommentsCount).Append("\n");
            sb.Append("  AttachmentsCount: ").Append(AttachmentsCount).Append("\n");
            sb.Append("  QuantityCount: ").Append(QuantityCount).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingSiteAuditCheckListItemStatisticWeightedExternal)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingSiteAuditCheckListItemStatisticWeightedExternal instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingSiteAuditCheckListItemStatisticWeightedExternal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingSiteAuditCheckListItemStatisticWeightedExternal other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CheckListItemId == other.CheckListItemId ||
                    
                    CheckListItemId.Equals(other.CheckListItemId)
                ) && 
                (
                    Date == other.Date ||
                    Date != null &&
                    Date.Equals(other.Date)
                ) && 
                (
                    Score == other.Score ||
                    
                    Score.Equals(other.Score)
                ) && 
                (
                    System == other.System ||
                    
                    System.Equals(other.System)
                ) && 
                (
                    Range == other.Range ||
                    Range != null &&
                    other.Range != null &&
                    Range.SequenceEqual(other.Range)
                ) && 
                (
                    WorkOrdersCount == other.WorkOrdersCount ||
                    
                    WorkOrdersCount.Equals(other.WorkOrdersCount)
                ) && 
                (
                    CommentsCount == other.CommentsCount ||
                    
                    CommentsCount.Equals(other.CommentsCount)
                ) && 
                (
                    AttachmentsCount == other.AttachmentsCount ||
                    
                    AttachmentsCount.Equals(other.AttachmentsCount)
                ) && 
                (
                    QuantityCount == other.QuantityCount ||
                    
                    QuantityCount.Equals(other.QuantityCount)
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
                    
                    hashCode = hashCode * 59 + CheckListItemId.GetHashCode();
                    if (Date != null)
                    hashCode = hashCode * 59 + Date.GetHashCode();
                    
                    hashCode = hashCode * 59 + Score.GetHashCode();
                    
                    hashCode = hashCode * 59 + System.GetHashCode();
                    if (Range != null)
                    hashCode = hashCode * 59 + Range.GetHashCode();
                    
                    hashCode = hashCode * 59 + WorkOrdersCount.GetHashCode();
                    
                    hashCode = hashCode * 59 + CommentsCount.GetHashCode();
                    
                    hashCode = hashCode * 59 + AttachmentsCount.GetHashCode();
                    
                    hashCode = hashCode * 59 + QuantityCount.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingSiteAuditCheckListItemStatisticWeightedExternal left, SCServiceChannelServicesMessagingSiteAuditCheckListItemStatisticWeightedExternal right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingSiteAuditCheckListItemStatisticWeightedExternal left, SCServiceChannelServicesMessagingSiteAuditCheckListItemStatisticWeightedExternal right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}