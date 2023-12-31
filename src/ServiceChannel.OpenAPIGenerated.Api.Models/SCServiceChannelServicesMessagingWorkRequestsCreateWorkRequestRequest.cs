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
    /// Request to create a work request
    /// </summary>
    [DataContract]
    public class SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest : IEquatable<SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest>
    {
        /// <summary>
        /// Subscriber Id
        /// </summary>
        /// <value>Subscriber Id</value>
        [DataMember(Name="SubscriberId", EmitDefaultValue=true)]
        public int SubscriberId { get; set; }

        /// <summary>
        /// Provider Id
        /// </summary>
        /// <value>Provider Id</value>
        [DataMember(Name="ProviderId", EmitDefaultValue=true)]
        public int ProviderId { get; set; }

        /// <summary>
        /// Optional. Guid of IoT event. For example, B216E711-420F-4D32-9080-762CBFD4E732
        /// </summary>
        /// <value>Optional. Guid of IoT event. For example, B216E711-420F-4D32-9080-762CBFD4E732</value>
        [DataMember(Name="EventId", EmitDefaultValue=false)]
        public string EventId { get; set; }

        /// <summary>
        /// Location Id
        /// </summary>
        /// <value>Location Id</value>
        [DataMember(Name="LocationId", EmitDefaultValue=true)]
        public int LocationId { get; set; }

        /// <summary>
        /// WorkRequest status Id
        /// </summary>
        /// <value>WorkRequest status Id</value>
        [DataMember(Name="StatusId", EmitDefaultValue=true)]
        public int StatusId { get; set; }

        /// <summary>
        /// WorkRequest extended status Id
        /// </summary>
        /// <value>WorkRequest extended status Id</value>
        [DataMember(Name="ExtendedStatusId", EmitDefaultValue=true)]
        public int ExtendedStatusId { get; set; }

        /// <summary>
        /// Description. Free text.
        /// </summary>
        /// <value>Description. Free text.</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Trade Id
        /// </summary>
        /// <value>Trade Id</value>
        [DataMember(Name="TradeId", EmitDefaultValue=true)]
        public int TradeId { get; set; }

        /// <summary>
        /// Catgory Id
        /// </summary>
        /// <value>Catgory Id</value>
        [DataMember(Name="CategoryId", EmitDefaultValue=true)]
        public int CategoryId { get; set; }

        /// <summary>
        /// Priority Id
        /// </summary>
        /// <value>Priority Id</value>
        [DataMember(Name="PriorityId", EmitDefaultValue=true)]
        public int PriorityId { get; set; }

        /// <summary>
        /// Optional. Caller
        /// </summary>
        /// <value>Optional. Caller</value>
        [DataMember(Name="Caller", EmitDefaultValue=false)]
        public string Caller { get; set; }

        /// <summary>
        /// Call date. In UTC
        /// </summary>
        /// <value>Call date. In UTC</value>
        [DataMember(Name="CallDate", EmitDefaultValue=false)]
        public string CallDate { get; set; }

        /// <summary>
        /// Optional. Scheduled date. In UTC
        /// </summary>
        /// <value>Optional. Scheduled date. In UTC</value>
        [DataMember(Name="ScheduledDate", EmitDefaultValue=false)]
        public string ScheduledDate { get; set; }

        /// <summary>
        /// Optional. Asset Id
        /// </summary>
        /// <value>Optional. Asset Id</value>
        [DataMember(Name="AssetId", EmitDefaultValue=true)]
        public int AssetId { get; set; }

        /// <summary>
        /// Gets or Sets Nte
        /// </summary>
        [DataMember(Name="Nte", EmitDefaultValue=false)]
        public SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestNteRequest Nte { get; set; }

        /// <summary>
        /// Gets or Sets Issue
        /// </summary>
        [DataMember(Name="Issue", EmitDefaultValue=false)]
        public SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestIssueRequest Issue { get; set; }

        /// <summary>
        /// Optional. Attachments
        /// </summary>
        /// <value>Optional. Attachments</value>
        [DataMember(Name="Attachments", EmitDefaultValue=false)]
        public List<SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestAttachmentRequest> Attachments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest {\n");
            sb.Append("  SubscriberId: ").Append(SubscriberId).Append("\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  StatusId: ").Append(StatusId).Append("\n");
            sb.Append("  ExtendedStatusId: ").Append(ExtendedStatusId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  TradeId: ").Append(TradeId).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  PriorityId: ").Append(PriorityId).Append("\n");
            sb.Append("  Caller: ").Append(Caller).Append("\n");
            sb.Append("  CallDate: ").Append(CallDate).Append("\n");
            sb.Append("  ScheduledDate: ").Append(ScheduledDate).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  Nte: ").Append(Nte).Append("\n");
            sb.Append("  Issue: ").Append(Issue).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    SubscriberId == other.SubscriberId ||
                    
                    SubscriberId.Equals(other.SubscriberId)
                ) && 
                (
                    ProviderId == other.ProviderId ||
                    
                    ProviderId.Equals(other.ProviderId)
                ) && 
                (
                    EventId == other.EventId ||
                    EventId != null &&
                    EventId.Equals(other.EventId)
                ) && 
                (
                    LocationId == other.LocationId ||
                    
                    LocationId.Equals(other.LocationId)
                ) && 
                (
                    StatusId == other.StatusId ||
                    
                    StatusId.Equals(other.StatusId)
                ) && 
                (
                    ExtendedStatusId == other.ExtendedStatusId ||
                    
                    ExtendedStatusId.Equals(other.ExtendedStatusId)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    TradeId == other.TradeId ||
                    
                    TradeId.Equals(other.TradeId)
                ) && 
                (
                    CategoryId == other.CategoryId ||
                    
                    CategoryId.Equals(other.CategoryId)
                ) && 
                (
                    PriorityId == other.PriorityId ||
                    
                    PriorityId.Equals(other.PriorityId)
                ) && 
                (
                    Caller == other.Caller ||
                    Caller != null &&
                    Caller.Equals(other.Caller)
                ) && 
                (
                    CallDate == other.CallDate ||
                    CallDate != null &&
                    CallDate.Equals(other.CallDate)
                ) && 
                (
                    ScheduledDate == other.ScheduledDate ||
                    ScheduledDate != null &&
                    ScheduledDate.Equals(other.ScheduledDate)
                ) && 
                (
                    AssetId == other.AssetId ||
                    
                    AssetId.Equals(other.AssetId)
                ) && 
                (
                    Nte == other.Nte ||
                    Nte != null &&
                    Nte.Equals(other.Nte)
                ) && 
                (
                    Issue == other.Issue ||
                    Issue != null &&
                    Issue.Equals(other.Issue)
                ) && 
                (
                    Attachments == other.Attachments ||
                    Attachments != null &&
                    other.Attachments != null &&
                    Attachments.SequenceEqual(other.Attachments)
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
                    
                    hashCode = hashCode * 59 + ProviderId.GetHashCode();
                    if (EventId != null)
                    hashCode = hashCode * 59 + EventId.GetHashCode();
                    
                    hashCode = hashCode * 59 + LocationId.GetHashCode();
                    
                    hashCode = hashCode * 59 + StatusId.GetHashCode();
                    
                    hashCode = hashCode * 59 + ExtendedStatusId.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    
                    hashCode = hashCode * 59 + TradeId.GetHashCode();
                    
                    hashCode = hashCode * 59 + CategoryId.GetHashCode();
                    
                    hashCode = hashCode * 59 + PriorityId.GetHashCode();
                    if (Caller != null)
                    hashCode = hashCode * 59 + Caller.GetHashCode();
                    if (CallDate != null)
                    hashCode = hashCode * 59 + CallDate.GetHashCode();
                    if (ScheduledDate != null)
                    hashCode = hashCode * 59 + ScheduledDate.GetHashCode();
                    
                    hashCode = hashCode * 59 + AssetId.GetHashCode();
                    if (Nte != null)
                    hashCode = hashCode * 59 + Nte.GetHashCode();
                    if (Issue != null)
                    hashCode = hashCode * 59 + Issue.GetHashCode();
                    if (Attachments != null)
                    hashCode = hashCode * 59 + Attachments.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest left, SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest left, SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
