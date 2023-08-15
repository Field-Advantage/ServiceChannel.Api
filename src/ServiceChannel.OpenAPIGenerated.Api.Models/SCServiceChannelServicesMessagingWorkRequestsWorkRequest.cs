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
    /// Work Request
    /// </summary>
    [DataContract]
    public class SCServiceChannelServicesMessagingWorkRequestsWorkRequest : IEquatable<SCServiceChannelServicesMessagingWorkRequestsWorkRequest>
    {
        /// <summary>
        /// Id
        /// </summary>
        /// <value>Id</value>
        [DataMember(Name="Id", EmitDefaultValue=true)]
        public int Id { get; set; }

        /// <summary>
        /// Subscriber Id
        /// </summary>
        /// <value>Subscriber Id</value>
        [DataMember(Name="SubscriberId", EmitDefaultValue=true)]
        public int SubscriberId { get; set; }

        /// <summary>
        /// Subscriber Short Name
        /// </summary>
        /// <value>Subscriber Short Name</value>
        [DataMember(Name="SubscriberShortName", EmitDefaultValue=false)]
        public string SubscriberShortName { get; set; }

        /// <summary>
        /// Provider Id
        /// </summary>
        /// <value>Provider Id</value>
        [DataMember(Name="ProviderId", EmitDefaultValue=true)]
        public int ProviderId { get; set; }

        /// <summary>
        /// Provider Short Name
        /// </summary>
        /// <value>Provider Short Name</value>
        [DataMember(Name="ProviderShortName", EmitDefaultValue=false)]
        public string ProviderShortName { get; set; }

        /// <summary>
        /// Location Id
        /// </summary>
        /// <value>Location Id</value>
        [DataMember(Name="LocationId", EmitDefaultValue=true)]
        public int LocationId { get; set; }

        /// <summary>
        /// Location Store Id
        /// </summary>
        /// <value>Location Store Id</value>
        [DataMember(Name="LocationStoreId", EmitDefaultValue=false)]
        public string LocationStoreId { get; set; }

        /// <summary>
        /// Event Id
        /// </summary>
        /// <value>Event Id</value>
        [DataMember(Name="EventId", EmitDefaultValue=false)]
        public string EventId { get; set; }

        /// <summary>
        /// Status Id
        /// </summary>
        /// <value>Status Id</value>
        [DataMember(Name="StatusId", EmitDefaultValue=true)]
        public int StatusId { get; set; }

        /// <summary>
        /// Status Name
        /// </summary>
        /// <value>Status Name</value>
        [DataMember(Name="StatusName", EmitDefaultValue=false)]
        public string StatusName { get; set; }

        /// <summary>
        /// Extended Status Id
        /// </summary>
        /// <value>Extended Status Id</value>
        [DataMember(Name="ExtendedStatusId", EmitDefaultValue=true)]
        public int ExtendedStatusId { get; set; }

        /// <summary>
        /// Extended Status Name
        /// </summary>
        /// <value>Extended Status Name</value>
        [DataMember(Name="ExtendedStatusName", EmitDefaultValue=false)]
        public string ExtendedStatusName { get; set; }

        /// <summary>
        /// Closed Reason Id
        /// </summary>
        /// <value>Closed Reason Id</value>
        [DataMember(Name="ClosedReasonId", EmitDefaultValue=true)]
        public int ClosedReasonId { get; set; }

        /// <summary>
        /// Closed Reason Name
        /// </summary>
        /// <value>Closed Reason Name</value>
        [DataMember(Name="ClosedReasonName", EmitDefaultValue=false)]
        public string ClosedReasonName { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Trade Id
        /// </summary>
        /// <value>Trade Id</value>
        [DataMember(Name="TradeId", EmitDefaultValue=true)]
        public int TradeId { get; set; }

        /// <summary>
        /// Trade Name
        /// </summary>
        /// <value>Trade Name</value>
        [DataMember(Name="TradeName", EmitDefaultValue=false)]
        public string TradeName { get; set; }

        /// <summary>
        /// Category Id
        /// </summary>
        /// <value>Category Id</value>
        [DataMember(Name="CategoryId", EmitDefaultValue=true)]
        public int CategoryId { get; set; }

        /// <summary>
        /// Category Name
        /// </summary>
        /// <value>Category Name</value>
        [DataMember(Name="CategoryName", EmitDefaultValue=false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// Priority Id
        /// </summary>
        /// <value>Priority Id</value>
        [DataMember(Name="PriorityId", EmitDefaultValue=true)]
        public int PriorityId { get; set; }

        /// <summary>
        /// Priority Name
        /// </summary>
        /// <value>Priority Name</value>
        [DataMember(Name="PriorityName", EmitDefaultValue=false)]
        public string PriorityName { get; set; }

        /// <summary>
        /// Caller
        /// </summary>
        /// <value>Caller</value>
        [DataMember(Name="Caller", EmitDefaultValue=false)]
        public string Caller { get; set; }

        /// <summary>
        /// Call Date
        /// </summary>
        /// <value>Call Date</value>
        [DataMember(Name="CallDate", EmitDefaultValue=false)]
        public DateTime CallDate { get; set; }

        /// <summary>
        /// Closed Date
        /// </summary>
        /// <value>Closed Date</value>
        [DataMember(Name="ClosedDate", EmitDefaultValue=false)]
        public DateTime ClosedDate { get; set; }

        /// <summary>
        /// Scheduled Date
        /// </summary>
        /// <value>Scheduled Date</value>
        [DataMember(Name="ScheduledDate", EmitDefaultValue=false)]
        public DateTime ScheduledDate { get; set; }

        /// <summary>
        /// Work Order Id
        /// </summary>
        /// <value>Work Order Id</value>
        [DataMember(Name="WorkOrderId", EmitDefaultValue=true)]
        public int WorkOrderId { get; set; }

        /// <summary>
        /// Asset Id
        /// </summary>
        /// <value>Asset Id</value>
        [DataMember(Name="AssetId", EmitDefaultValue=true)]
        public int AssetId { get; set; }

        /// <summary>
        /// Gets or Sets Nte
        /// </summary>
        [DataMember(Name="Nte", EmitDefaultValue=false)]
        public SCServiceChannelServicesMessagingWorkRequestsWorkRequestNte Nte { get; set; }

        /// <summary>
        /// Gets or Sets Issue
        /// </summary>
        [DataMember(Name="Issue", EmitDefaultValue=false)]
        public SCServiceChannelServicesMessagingWorkRequestsWorkRequestIssue Issue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingWorkRequestsWorkRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SubscriberId: ").Append(SubscriberId).Append("\n");
            sb.Append("  SubscriberShortName: ").Append(SubscriberShortName).Append("\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  ProviderShortName: ").Append(ProviderShortName).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  LocationStoreId: ").Append(LocationStoreId).Append("\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  StatusId: ").Append(StatusId).Append("\n");
            sb.Append("  StatusName: ").Append(StatusName).Append("\n");
            sb.Append("  ExtendedStatusId: ").Append(ExtendedStatusId).Append("\n");
            sb.Append("  ExtendedStatusName: ").Append(ExtendedStatusName).Append("\n");
            sb.Append("  ClosedReasonId: ").Append(ClosedReasonId).Append("\n");
            sb.Append("  ClosedReasonName: ").Append(ClosedReasonName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  TradeId: ").Append(TradeId).Append("\n");
            sb.Append("  TradeName: ").Append(TradeName).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  CategoryName: ").Append(CategoryName).Append("\n");
            sb.Append("  PriorityId: ").Append(PriorityId).Append("\n");
            sb.Append("  PriorityName: ").Append(PriorityName).Append("\n");
            sb.Append("  Caller: ").Append(Caller).Append("\n");
            sb.Append("  CallDate: ").Append(CallDate).Append("\n");
            sb.Append("  ClosedDate: ").Append(ClosedDate).Append("\n");
            sb.Append("  ScheduledDate: ").Append(ScheduledDate).Append("\n");
            sb.Append("  WorkOrderId: ").Append(WorkOrderId).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  Nte: ").Append(Nte).Append("\n");
            sb.Append("  Issue: ").Append(Issue).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingWorkRequestsWorkRequest)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingWorkRequestsWorkRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingWorkRequestsWorkRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingWorkRequestsWorkRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    SubscriberId == other.SubscriberId ||
                    
                    SubscriberId.Equals(other.SubscriberId)
                ) && 
                (
                    SubscriberShortName == other.SubscriberShortName ||
                    SubscriberShortName != null &&
                    SubscriberShortName.Equals(other.SubscriberShortName)
                ) && 
                (
                    ProviderId == other.ProviderId ||
                    
                    ProviderId.Equals(other.ProviderId)
                ) && 
                (
                    ProviderShortName == other.ProviderShortName ||
                    ProviderShortName != null &&
                    ProviderShortName.Equals(other.ProviderShortName)
                ) && 
                (
                    LocationId == other.LocationId ||
                    
                    LocationId.Equals(other.LocationId)
                ) && 
                (
                    LocationStoreId == other.LocationStoreId ||
                    LocationStoreId != null &&
                    LocationStoreId.Equals(other.LocationStoreId)
                ) && 
                (
                    EventId == other.EventId ||
                    EventId != null &&
                    EventId.Equals(other.EventId)
                ) && 
                (
                    StatusId == other.StatusId ||
                    
                    StatusId.Equals(other.StatusId)
                ) && 
                (
                    StatusName == other.StatusName ||
                    StatusName != null &&
                    StatusName.Equals(other.StatusName)
                ) && 
                (
                    ExtendedStatusId == other.ExtendedStatusId ||
                    
                    ExtendedStatusId.Equals(other.ExtendedStatusId)
                ) && 
                (
                    ExtendedStatusName == other.ExtendedStatusName ||
                    ExtendedStatusName != null &&
                    ExtendedStatusName.Equals(other.ExtendedStatusName)
                ) && 
                (
                    ClosedReasonId == other.ClosedReasonId ||
                    
                    ClosedReasonId.Equals(other.ClosedReasonId)
                ) && 
                (
                    ClosedReasonName == other.ClosedReasonName ||
                    ClosedReasonName != null &&
                    ClosedReasonName.Equals(other.ClosedReasonName)
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
                    TradeName == other.TradeName ||
                    TradeName != null &&
                    TradeName.Equals(other.TradeName)
                ) && 
                (
                    CategoryId == other.CategoryId ||
                    
                    CategoryId.Equals(other.CategoryId)
                ) && 
                (
                    CategoryName == other.CategoryName ||
                    CategoryName != null &&
                    CategoryName.Equals(other.CategoryName)
                ) && 
                (
                    PriorityId == other.PriorityId ||
                    
                    PriorityId.Equals(other.PriorityId)
                ) && 
                (
                    PriorityName == other.PriorityName ||
                    PriorityName != null &&
                    PriorityName.Equals(other.PriorityName)
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
                    ClosedDate == other.ClosedDate ||
                    ClosedDate != null &&
                    ClosedDate.Equals(other.ClosedDate)
                ) && 
                (
                    ScheduledDate == other.ScheduledDate ||
                    ScheduledDate != null &&
                    ScheduledDate.Equals(other.ScheduledDate)
                ) && 
                (
                    WorkOrderId == other.WorkOrderId ||
                    
                    WorkOrderId.Equals(other.WorkOrderId)
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
                    
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    
                    hashCode = hashCode * 59 + SubscriberId.GetHashCode();
                    if (SubscriberShortName != null)
                    hashCode = hashCode * 59 + SubscriberShortName.GetHashCode();
                    
                    hashCode = hashCode * 59 + ProviderId.GetHashCode();
                    if (ProviderShortName != null)
                    hashCode = hashCode * 59 + ProviderShortName.GetHashCode();
                    
                    hashCode = hashCode * 59 + LocationId.GetHashCode();
                    if (LocationStoreId != null)
                    hashCode = hashCode * 59 + LocationStoreId.GetHashCode();
                    if (EventId != null)
                    hashCode = hashCode * 59 + EventId.GetHashCode();
                    
                    hashCode = hashCode * 59 + StatusId.GetHashCode();
                    if (StatusName != null)
                    hashCode = hashCode * 59 + StatusName.GetHashCode();
                    
                    hashCode = hashCode * 59 + ExtendedStatusId.GetHashCode();
                    if (ExtendedStatusName != null)
                    hashCode = hashCode * 59 + ExtendedStatusName.GetHashCode();
                    
                    hashCode = hashCode * 59 + ClosedReasonId.GetHashCode();
                    if (ClosedReasonName != null)
                    hashCode = hashCode * 59 + ClosedReasonName.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    
                    hashCode = hashCode * 59 + TradeId.GetHashCode();
                    if (TradeName != null)
                    hashCode = hashCode * 59 + TradeName.GetHashCode();
                    
                    hashCode = hashCode * 59 + CategoryId.GetHashCode();
                    if (CategoryName != null)
                    hashCode = hashCode * 59 + CategoryName.GetHashCode();
                    
                    hashCode = hashCode * 59 + PriorityId.GetHashCode();
                    if (PriorityName != null)
                    hashCode = hashCode * 59 + PriorityName.GetHashCode();
                    if (Caller != null)
                    hashCode = hashCode * 59 + Caller.GetHashCode();
                    if (CallDate != null)
                    hashCode = hashCode * 59 + CallDate.GetHashCode();
                    if (ClosedDate != null)
                    hashCode = hashCode * 59 + ClosedDate.GetHashCode();
                    if (ScheduledDate != null)
                    hashCode = hashCode * 59 + ScheduledDate.GetHashCode();
                    
                    hashCode = hashCode * 59 + WorkOrderId.GetHashCode();
                    
                    hashCode = hashCode * 59 + AssetId.GetHashCode();
                    if (Nte != null)
                    hashCode = hashCode * 59 + Nte.GetHashCode();
                    if (Issue != null)
                    hashCode = hashCode * 59 + Issue.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingWorkRequestsWorkRequest left, SCServiceChannelServicesMessagingWorkRequestsWorkRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingWorkRequestsWorkRequest left, SCServiceChannelServicesMessagingWorkRequestsWorkRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
