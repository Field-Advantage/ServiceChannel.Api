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
    public class SCServiceChannelServicesMessagingLandingUpdateSubscriberLandingPreferenceRequest : IEquatable<SCServiceChannelServicesMessagingLandingUpdateSubscriberLandingPreferenceRequest>
    {
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="UserId", EmitDefaultValue=true)]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or Sets SubscriberId
        /// </summary>
        [DataMember(Name="SubscriberId", EmitDefaultValue=true)]
        public int SubscriberId { get; set; }

        /// <summary>
        /// Gets or Sets SelectedLocationNoteHeaderIds
        /// </summary>
        [DataMember(Name="SelectedLocationNoteHeaderIds", EmitDefaultValue=false)]
        public string SelectedLocationNoteHeaderIds { get; set; }

        /// <summary>
        /// Gets or Sets ThresholdEDispatchNotConfirmed
        /// </summary>
        [DataMember(Name="ThresholdEDispatchNotConfirmed", EmitDefaultValue=true)]
        public int ThresholdEDispatchNotConfirmed { get; set; }

        /// <summary>
        /// Gets or Sets ThresholdEDispatchDeclined
        /// </summary>
        [DataMember(Name="ThresholdEDispatchDeclined", EmitDefaultValue=true)]
        public int ThresholdEDispatchDeclined { get; set; }

        /// <summary>
        /// Gets or Sets ThresholdELateToArrive
        /// </summary>
        [DataMember(Name="ThresholdELateToArrive", EmitDefaultValue=true)]
        public int ThresholdELateToArrive { get; set; }

        /// <summary>
        /// Gets or Sets ThresholdEWaitingForQuote
        /// </summary>
        [DataMember(Name="ThresholdEWaitingForQuote", EmitDefaultValue=true)]
        public int ThresholdEWaitingForQuote { get; set; }

        /// <summary>
        /// Gets or Sets ThresholdEPendingApproval
        /// </summary>
        [DataMember(Name="ThresholdEPendingApproval", EmitDefaultValue=true)]
        public int ThresholdEPendingApproval { get; set; }

        /// <summary>
        /// Gets or Sets ThresholdEPartsOnOrder
        /// </summary>
        [DataMember(Name="ThresholdEPartsOnOrder", EmitDefaultValue=true)]
        public int ThresholdEPartsOnOrder { get; set; }

        /// <summary>
        /// Gets or Sets ThresholdNeDispatchNotConfirmed
        /// </summary>
        [DataMember(Name="ThresholdNeDispatchNotConfirmed", EmitDefaultValue=true)]
        public int ThresholdNeDispatchNotConfirmed { get; set; }

        /// <summary>
        /// Gets or Sets ThresholdNeDispatchDeclined
        /// </summary>
        [DataMember(Name="ThresholdNeDispatchDeclined", EmitDefaultValue=true)]
        public int ThresholdNeDispatchDeclined { get; set; }

        /// <summary>
        /// Gets or Sets ThresholdNeLateToArrive
        /// </summary>
        [DataMember(Name="ThresholdNeLateToArrive", EmitDefaultValue=true)]
        public int ThresholdNeLateToArrive { get; set; }

        /// <summary>
        /// Gets or Sets ThresholdNeWaitingForQuote
        /// </summary>
        [DataMember(Name="ThresholdNeWaitingForQuote", EmitDefaultValue=true)]
        public int ThresholdNeWaitingForQuote { get; set; }

        /// <summary>
        /// Gets or Sets ThresholdNePendingApproval
        /// </summary>
        [DataMember(Name="ThresholdNePendingApproval", EmitDefaultValue=true)]
        public int ThresholdNePendingApproval { get; set; }

        /// <summary>
        /// Gets or Sets ThresholdNePartsOnOrder
        /// </summary>
        [DataMember(Name="ThresholdNePartsOnOrder", EmitDefaultValue=true)]
        public int ThresholdNePartsOnOrder { get; set; }

        /// <summary>
        /// Gets or Sets ThresholdCompletedNotInvoiced
        /// </summary>
        [DataMember(Name="ThresholdCompletedNotInvoiced", EmitDefaultValue=true)]
        public int ThresholdCompletedNotInvoiced { get; set; }

        /// <summary>
        /// Gets or Sets PriorityId
        /// </summary>
        [DataMember(Name="PriorityId", EmitDefaultValue=true)]
        public int PriorityId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingLandingUpdateSubscriberLandingPreferenceRequest {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  SubscriberId: ").Append(SubscriberId).Append("\n");
            sb.Append("  SelectedLocationNoteHeaderIds: ").Append(SelectedLocationNoteHeaderIds).Append("\n");
            sb.Append("  ThresholdEDispatchNotConfirmed: ").Append(ThresholdEDispatchNotConfirmed).Append("\n");
            sb.Append("  ThresholdEDispatchDeclined: ").Append(ThresholdEDispatchDeclined).Append("\n");
            sb.Append("  ThresholdELateToArrive: ").Append(ThresholdELateToArrive).Append("\n");
            sb.Append("  ThresholdEWaitingForQuote: ").Append(ThresholdEWaitingForQuote).Append("\n");
            sb.Append("  ThresholdEPendingApproval: ").Append(ThresholdEPendingApproval).Append("\n");
            sb.Append("  ThresholdEPartsOnOrder: ").Append(ThresholdEPartsOnOrder).Append("\n");
            sb.Append("  ThresholdNeDispatchNotConfirmed: ").Append(ThresholdNeDispatchNotConfirmed).Append("\n");
            sb.Append("  ThresholdNeDispatchDeclined: ").Append(ThresholdNeDispatchDeclined).Append("\n");
            sb.Append("  ThresholdNeLateToArrive: ").Append(ThresholdNeLateToArrive).Append("\n");
            sb.Append("  ThresholdNeWaitingForQuote: ").Append(ThresholdNeWaitingForQuote).Append("\n");
            sb.Append("  ThresholdNePendingApproval: ").Append(ThresholdNePendingApproval).Append("\n");
            sb.Append("  ThresholdNePartsOnOrder: ").Append(ThresholdNePartsOnOrder).Append("\n");
            sb.Append("  ThresholdCompletedNotInvoiced: ").Append(ThresholdCompletedNotInvoiced).Append("\n");
            sb.Append("  PriorityId: ").Append(PriorityId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingLandingUpdateSubscriberLandingPreferenceRequest)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingLandingUpdateSubscriberLandingPreferenceRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingLandingUpdateSubscriberLandingPreferenceRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingLandingUpdateSubscriberLandingPreferenceRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    UserId == other.UserId ||
                    
                    UserId.Equals(other.UserId)
                ) && 
                (
                    SubscriberId == other.SubscriberId ||
                    
                    SubscriberId.Equals(other.SubscriberId)
                ) && 
                (
                    SelectedLocationNoteHeaderIds == other.SelectedLocationNoteHeaderIds ||
                    SelectedLocationNoteHeaderIds != null &&
                    SelectedLocationNoteHeaderIds.Equals(other.SelectedLocationNoteHeaderIds)
                ) && 
                (
                    ThresholdEDispatchNotConfirmed == other.ThresholdEDispatchNotConfirmed ||
                    
                    ThresholdEDispatchNotConfirmed.Equals(other.ThresholdEDispatchNotConfirmed)
                ) && 
                (
                    ThresholdEDispatchDeclined == other.ThresholdEDispatchDeclined ||
                    
                    ThresholdEDispatchDeclined.Equals(other.ThresholdEDispatchDeclined)
                ) && 
                (
                    ThresholdELateToArrive == other.ThresholdELateToArrive ||
                    
                    ThresholdELateToArrive.Equals(other.ThresholdELateToArrive)
                ) && 
                (
                    ThresholdEWaitingForQuote == other.ThresholdEWaitingForQuote ||
                    
                    ThresholdEWaitingForQuote.Equals(other.ThresholdEWaitingForQuote)
                ) && 
                (
                    ThresholdEPendingApproval == other.ThresholdEPendingApproval ||
                    
                    ThresholdEPendingApproval.Equals(other.ThresholdEPendingApproval)
                ) && 
                (
                    ThresholdEPartsOnOrder == other.ThresholdEPartsOnOrder ||
                    
                    ThresholdEPartsOnOrder.Equals(other.ThresholdEPartsOnOrder)
                ) && 
                (
                    ThresholdNeDispatchNotConfirmed == other.ThresholdNeDispatchNotConfirmed ||
                    
                    ThresholdNeDispatchNotConfirmed.Equals(other.ThresholdNeDispatchNotConfirmed)
                ) && 
                (
                    ThresholdNeDispatchDeclined == other.ThresholdNeDispatchDeclined ||
                    
                    ThresholdNeDispatchDeclined.Equals(other.ThresholdNeDispatchDeclined)
                ) && 
                (
                    ThresholdNeLateToArrive == other.ThresholdNeLateToArrive ||
                    
                    ThresholdNeLateToArrive.Equals(other.ThresholdNeLateToArrive)
                ) && 
                (
                    ThresholdNeWaitingForQuote == other.ThresholdNeWaitingForQuote ||
                    
                    ThresholdNeWaitingForQuote.Equals(other.ThresholdNeWaitingForQuote)
                ) && 
                (
                    ThresholdNePendingApproval == other.ThresholdNePendingApproval ||
                    
                    ThresholdNePendingApproval.Equals(other.ThresholdNePendingApproval)
                ) && 
                (
                    ThresholdNePartsOnOrder == other.ThresholdNePartsOnOrder ||
                    
                    ThresholdNePartsOnOrder.Equals(other.ThresholdNePartsOnOrder)
                ) && 
                (
                    ThresholdCompletedNotInvoiced == other.ThresholdCompletedNotInvoiced ||
                    
                    ThresholdCompletedNotInvoiced.Equals(other.ThresholdCompletedNotInvoiced)
                ) && 
                (
                    PriorityId == other.PriorityId ||
                    
                    PriorityId.Equals(other.PriorityId)
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
                    
                    hashCode = hashCode * 59 + SubscriberId.GetHashCode();
                    if (SelectedLocationNoteHeaderIds != null)
                    hashCode = hashCode * 59 + SelectedLocationNoteHeaderIds.GetHashCode();
                    
                    hashCode = hashCode * 59 + ThresholdEDispatchNotConfirmed.GetHashCode();
                    
                    hashCode = hashCode * 59 + ThresholdEDispatchDeclined.GetHashCode();
                    
                    hashCode = hashCode * 59 + ThresholdELateToArrive.GetHashCode();
                    
                    hashCode = hashCode * 59 + ThresholdEWaitingForQuote.GetHashCode();
                    
                    hashCode = hashCode * 59 + ThresholdEPendingApproval.GetHashCode();
                    
                    hashCode = hashCode * 59 + ThresholdEPartsOnOrder.GetHashCode();
                    
                    hashCode = hashCode * 59 + ThresholdNeDispatchNotConfirmed.GetHashCode();
                    
                    hashCode = hashCode * 59 + ThresholdNeDispatchDeclined.GetHashCode();
                    
                    hashCode = hashCode * 59 + ThresholdNeLateToArrive.GetHashCode();
                    
                    hashCode = hashCode * 59 + ThresholdNeWaitingForQuote.GetHashCode();
                    
                    hashCode = hashCode * 59 + ThresholdNePendingApproval.GetHashCode();
                    
                    hashCode = hashCode * 59 + ThresholdNePartsOnOrder.GetHashCode();
                    
                    hashCode = hashCode * 59 + ThresholdCompletedNotInvoiced.GetHashCode();
                    
                    hashCode = hashCode * 59 + PriorityId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingLandingUpdateSubscriberLandingPreferenceRequest left, SCServiceChannelServicesMessagingLandingUpdateSubscriberLandingPreferenceRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingLandingUpdateSubscriberLandingPreferenceRequest left, SCServiceChannelServicesMessagingLandingUpdateSubscriberLandingPreferenceRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
