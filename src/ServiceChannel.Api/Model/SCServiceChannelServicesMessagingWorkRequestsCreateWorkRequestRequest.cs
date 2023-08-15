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
    /// Request to create a work request
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.WorkRequests.CreateWorkRequestRequest")]
    public partial class SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest : IEquatable<SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest" /> class.
        /// </summary>
        /// <param name="subscriberId">Subscriber Id.</param>
        /// <param name="providerId">Provider Id.</param>
        /// <param name="eventId">Optional. Guid of IoT event. For example, B216E711-420F-4D32-9080-762CBFD4E732.</param>
        /// <param name="locationId">Location Id.</param>
        /// <param name="statusId">WorkRequest status Id.</param>
        /// <param name="extendedStatusId">WorkRequest extended status Id.</param>
        /// <param name="description">Description. Free text..</param>
        /// <param name="tradeId">Trade Id.</param>
        /// <param name="categoryId">Catgory Id.</param>
        /// <param name="priorityId">Priority Id.</param>
        /// <param name="caller">Optional. Caller.</param>
        /// <param name="callDate">Call date. In UTC.</param>
        /// <param name="scheduledDate">Optional. Scheduled date. In UTC.</param>
        /// <param name="assetId">Optional. Asset Id.</param>
        /// <param name="nte">nte.</param>
        /// <param name="issue">issue.</param>
        /// <param name="attachments">Optional. Attachments.</param>
        public SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest(int subscriberId = default(int), int providerId = default(int), string eventId = default(string), int locationId = default(int), int statusId = default(int), int extendedStatusId = default(int), string description = default(string), int tradeId = default(int), int categoryId = default(int), int priorityId = default(int), string caller = default(string), string callDate = default(string), string scheduledDate = default(string), int assetId = default(int), SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestNteRequest nte = default(SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestNteRequest), SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestIssueRequest issue = default(SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestIssueRequest), List<SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestAttachmentRequest> attachments = default(List<SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestAttachmentRequest>))
        {
            this.SubscriberId = subscriberId;
            this.ProviderId = providerId;
            this.EventId = eventId;
            this.LocationId = locationId;
            this.StatusId = statusId;
            this.ExtendedStatusId = extendedStatusId;
            this.Description = description;
            this.TradeId = tradeId;
            this.CategoryId = categoryId;
            this.PriorityId = priorityId;
            this.Caller = caller;
            this.CallDate = callDate;
            this.ScheduledDate = scheduledDate;
            this.AssetId = assetId;
            this.Nte = nte;
            this.Issue = issue;
            this.Attachments = attachments;
        }

        /// <summary>
        /// Subscriber Id
        /// </summary>
        /// <value>Subscriber Id</value>
        [DataMember(Name = "SubscriberId", EmitDefaultValue = false)]
        public int SubscriberId { get; set; }

        /// <summary>
        /// Provider Id
        /// </summary>
        /// <value>Provider Id</value>
        [DataMember(Name = "ProviderId", EmitDefaultValue = false)]
        public int ProviderId { get; set; }

        /// <summary>
        /// Optional. Guid of IoT event. For example, B216E711-420F-4D32-9080-762CBFD4E732
        /// </summary>
        /// <value>Optional. Guid of IoT event. For example, B216E711-420F-4D32-9080-762CBFD4E732</value>
        [DataMember(Name = "EventId", EmitDefaultValue = false)]
        public string EventId { get; set; }

        /// <summary>
        /// Location Id
        /// </summary>
        /// <value>Location Id</value>
        [DataMember(Name = "LocationId", EmitDefaultValue = false)]
        public int LocationId { get; set; }

        /// <summary>
        /// WorkRequest status Id
        /// </summary>
        /// <value>WorkRequest status Id</value>
        [DataMember(Name = "StatusId", EmitDefaultValue = false)]
        public int StatusId { get; set; }

        /// <summary>
        /// WorkRequest extended status Id
        /// </summary>
        /// <value>WorkRequest extended status Id</value>
        [DataMember(Name = "ExtendedStatusId", EmitDefaultValue = false)]
        public int ExtendedStatusId { get; set; }

        /// <summary>
        /// Description. Free text.
        /// </summary>
        /// <value>Description. Free text.</value>
        [DataMember(Name = "Description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Trade Id
        /// </summary>
        /// <value>Trade Id</value>
        [DataMember(Name = "TradeId", EmitDefaultValue = false)]
        public int TradeId { get; set; }

        /// <summary>
        /// Catgory Id
        /// </summary>
        /// <value>Catgory Id</value>
        [DataMember(Name = "CategoryId", EmitDefaultValue = false)]
        public int CategoryId { get; set; }

        /// <summary>
        /// Priority Id
        /// </summary>
        /// <value>Priority Id</value>
        [DataMember(Name = "PriorityId", EmitDefaultValue = false)]
        public int PriorityId { get; set; }

        /// <summary>
        /// Optional. Caller
        /// </summary>
        /// <value>Optional. Caller</value>
        [DataMember(Name = "Caller", EmitDefaultValue = false)]
        public string Caller { get; set; }

        /// <summary>
        /// Call date. In UTC
        /// </summary>
        /// <value>Call date. In UTC</value>
        [DataMember(Name = "CallDate", EmitDefaultValue = false)]
        public string CallDate { get; set; }

        /// <summary>
        /// Optional. Scheduled date. In UTC
        /// </summary>
        /// <value>Optional. Scheduled date. In UTC</value>
        [DataMember(Name = "ScheduledDate", EmitDefaultValue = false)]
        public string ScheduledDate { get; set; }

        /// <summary>
        /// Optional. Asset Id
        /// </summary>
        /// <value>Optional. Asset Id</value>
        [DataMember(Name = "AssetId", EmitDefaultValue = false)]
        public int AssetId { get; set; }

        /// <summary>
        /// Gets or Sets Nte
        /// </summary>
        [DataMember(Name = "Nte", EmitDefaultValue = false)]
        public SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestNteRequest Nte { get; set; }

        /// <summary>
        /// Gets or Sets Issue
        /// </summary>
        [DataMember(Name = "Issue", EmitDefaultValue = false)]
        public SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestIssueRequest Issue { get; set; }

        /// <summary>
        /// Optional. Attachments
        /// </summary>
        /// <value>Optional. Attachments</value>
        [DataMember(Name = "Attachments", EmitDefaultValue = false)]
        public List<SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestAttachmentRequest> Attachments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
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
            return this.Equals(input as SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SubscriberId == input.SubscriberId ||
                    this.SubscriberId.Equals(input.SubscriberId)
                ) && 
                (
                    this.ProviderId == input.ProviderId ||
                    this.ProviderId.Equals(input.ProviderId)
                ) && 
                (
                    this.EventId == input.EventId ||
                    (this.EventId != null &&
                    this.EventId.Equals(input.EventId))
                ) && 
                (
                    this.LocationId == input.LocationId ||
                    this.LocationId.Equals(input.LocationId)
                ) && 
                (
                    this.StatusId == input.StatusId ||
                    this.StatusId.Equals(input.StatusId)
                ) && 
                (
                    this.ExtendedStatusId == input.ExtendedStatusId ||
                    this.ExtendedStatusId.Equals(input.ExtendedStatusId)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.TradeId == input.TradeId ||
                    this.TradeId.Equals(input.TradeId)
                ) && 
                (
                    this.CategoryId == input.CategoryId ||
                    this.CategoryId.Equals(input.CategoryId)
                ) && 
                (
                    this.PriorityId == input.PriorityId ||
                    this.PriorityId.Equals(input.PriorityId)
                ) && 
                (
                    this.Caller == input.Caller ||
                    (this.Caller != null &&
                    this.Caller.Equals(input.Caller))
                ) && 
                (
                    this.CallDate == input.CallDate ||
                    (this.CallDate != null &&
                    this.CallDate.Equals(input.CallDate))
                ) && 
                (
                    this.ScheduledDate == input.ScheduledDate ||
                    (this.ScheduledDate != null &&
                    this.ScheduledDate.Equals(input.ScheduledDate))
                ) && 
                (
                    this.AssetId == input.AssetId ||
                    this.AssetId.Equals(input.AssetId)
                ) && 
                (
                    this.Nte == input.Nte ||
                    (this.Nte != null &&
                    this.Nte.Equals(input.Nte))
                ) && 
                (
                    this.Issue == input.Issue ||
                    (this.Issue != null &&
                    this.Issue.Equals(input.Issue))
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
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
                hashCode = (hashCode * 59) + this.SubscriberId.GetHashCode();
                hashCode = (hashCode * 59) + this.ProviderId.GetHashCode();
                if (this.EventId != null)
                {
                    hashCode = (hashCode * 59) + this.EventId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LocationId.GetHashCode();
                hashCode = (hashCode * 59) + this.StatusId.GetHashCode();
                hashCode = (hashCode * 59) + this.ExtendedStatusId.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TradeId.GetHashCode();
                hashCode = (hashCode * 59) + this.CategoryId.GetHashCode();
                hashCode = (hashCode * 59) + this.PriorityId.GetHashCode();
                if (this.Caller != null)
                {
                    hashCode = (hashCode * 59) + this.Caller.GetHashCode();
                }
                if (this.CallDate != null)
                {
                    hashCode = (hashCode * 59) + this.CallDate.GetHashCode();
                }
                if (this.ScheduledDate != null)
                {
                    hashCode = (hashCode * 59) + this.ScheduledDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AssetId.GetHashCode();
                if (this.Nte != null)
                {
                    hashCode = (hashCode * 59) + this.Nte.GetHashCode();
                }
                if (this.Issue != null)
                {
                    hashCode = (hashCode * 59) + this.Issue.GetHashCode();
                }
                if (this.Attachments != null)
                {
                    hashCode = (hashCode * 59) + this.Attachments.GetHashCode();
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
