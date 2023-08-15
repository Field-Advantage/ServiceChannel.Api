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
    /// Notification message
    /// </summary>
    [DataContract]
    public class SCServiceChannelServicesMessagingNotificationMessageServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrderCheckInOut : IEquatable<SCServiceChannelServicesMessagingNotificationMessageServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrderCheckInOut>
    {
        /// <summary>
        /// Gets or Sets VarObject
        /// </summary>
        [DataMember(Name="Object", EmitDefaultValue=false)]
        public SCServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrderCheckInOut VarObject { get; set; }


        /// <summary>
        /// Notification message event type
        /// </summary>
        /// <value>Notification message event type</value>
        
        public enum EventTypeEnum
        {
            
            /// <summary>
            /// Enum WorkOrderCreatedEnum for WorkOrderCreated
            /// </summary>
            [EnumMember(Value = "WorkOrderCreated")]
            WorkOrderCreatedEnum = 1,
            
            /// <summary>
            /// Enum WorkOrderNoteAddedEnum for WorkOrderNoteAdded
            /// </summary>
            [EnumMember(Value = "WorkOrderNoteAdded")]
            WorkOrderNoteAddedEnum = 2,
            
            /// <summary>
            /// Enum WorkOrderNotePinnedEnum for WorkOrderNotePinned
            /// </summary>
            [EnumMember(Value = "WorkOrderNotePinned")]
            WorkOrderNotePinnedEnum = 3,
            
            /// <summary>
            /// Enum WorkOrderNoteUnpinnedEnum for WorkOrderNoteUnpinned
            /// </summary>
            [EnumMember(Value = "WorkOrderNoteUnpinned")]
            WorkOrderNoteUnpinnedEnum = 4,
            
            /// <summary>
            /// Enum WorkOrderStatusChangedEnum for WorkOrderStatusChanged
            /// </summary>
            [EnumMember(Value = "WorkOrderStatusChanged")]
            WorkOrderStatusChangedEnum = 5,
            
            /// <summary>
            /// Enum WorkOrderAttachmentAddedEnum for WorkOrderAttachmentAdded
            /// </summary>
            [EnumMember(Value = "WorkOrderAttachmentAdded")]
            WorkOrderAttachmentAddedEnum = 6,
            
            /// <summary>
            /// Enum WorkOrderNumberChangedEnum for WorkOrderNumberChanged
            /// </summary>
            [EnumMember(Value = "WorkOrderNumberChanged")]
            WorkOrderNumberChangedEnum = 7,
            
            /// <summary>
            /// Enum WorkOrderPriorityChangedEnum for WorkOrderPriorityChanged
            /// </summary>
            [EnumMember(Value = "WorkOrderPriorityChanged")]
            WorkOrderPriorityChangedEnum = 8,
            
            /// <summary>
            /// Enum WorkOrderScheduledDateChangedEnum for WorkOrderScheduledDateChanged
            /// </summary>
            [EnumMember(Value = "WorkOrderScheduledDateChanged")]
            WorkOrderScheduledDateChangedEnum = 9,
            
            /// <summary>
            /// Enum WorkOrderTradeChangedEnum for WorkOrderTradeChanged
            /// </summary>
            [EnumMember(Value = "WorkOrderTradeChanged")]
            WorkOrderTradeChangedEnum = 10,
            
            /// <summary>
            /// Enum WorkOrderNteChangedEnum for WorkOrderNteChanged
            /// </summary>
            [EnumMember(Value = "WorkOrderNteChanged")]
            WorkOrderNteChangedEnum = 11,
            
            /// <summary>
            /// Enum WorkOrderCategoryChangedEnum for WorkOrderCategoryChanged
            /// </summary>
            [EnumMember(Value = "WorkOrderCategoryChanged")]
            WorkOrderCategoryChangedEnum = 12,
            
            /// <summary>
            /// Enum WorkOrderProviderChangedEnum for WorkOrderProviderChanged
            /// </summary>
            [EnumMember(Value = "WorkOrderProviderChanged")]
            WorkOrderProviderChangedEnum = 13,
            
            /// <summary>
            /// Enum WorkOrderDescriptionChangedEnum for WorkOrderDescriptionChanged
            /// </summary>
            [EnumMember(Value = "WorkOrderDescriptionChanged")]
            WorkOrderDescriptionChangedEnum = 14,
            
            /// <summary>
            /// Enum WorkOrderResolutionCreatedEnum for WorkOrderResolutionCreated
            /// </summary>
            [EnumMember(Value = "WorkOrderResolutionCreated")]
            WorkOrderResolutionCreatedEnum = 15,
            
            /// <summary>
            /// Enum RefrigerantWasUsedChangedEnum for RefrigerantWasUsedChanged
            /// </summary>
            [EnumMember(Value = "RefrigerantWasUsedChanged")]
            RefrigerantWasUsedChangedEnum = 16,
            
            /// <summary>
            /// Enum WorkOrderResolutionUpdatedEnum for WorkOrderResolutionUpdated
            /// </summary>
            [EnumMember(Value = "WorkOrderResolutionUpdated")]
            WorkOrderResolutionUpdatedEnum = 17,
            
            /// <summary>
            /// Enum WorkOrderResolutionCodeUpdatedEnum for WorkOrderResolutionCodeUpdated
            /// </summary>
            [EnumMember(Value = "WorkOrderResolutionCodeUpdated")]
            WorkOrderResolutionCodeUpdatedEnum = 18,
            
            /// <summary>
            /// Enum WorkOrderRootCauseCodeUpdatedEnum for WorkOrderRootCauseCodeUpdated
            /// </summary>
            [EnumMember(Value = "WorkOrderRootCauseCodeUpdated")]
            WorkOrderRootCauseCodeUpdatedEnum = 19,
            
            /// <summary>
            /// Enum WorkOrderAssetAttachedEnum for WorkOrderAssetAttached
            /// </summary>
            [EnumMember(Value = "WorkOrderAssetAttached")]
            WorkOrderAssetAttachedEnum = 20,
            
            /// <summary>
            /// Enum WorkOrderAssetDetachedEnum for WorkOrderAssetDetached
            /// </summary>
            [EnumMember(Value = "WorkOrderAssetDetached")]
            WorkOrderAssetDetachedEnum = 21,
            
            /// <summary>
            /// Enum WorkOrderAssetValidatedEnum for WorkOrderAssetValidated
            /// </summary>
            [EnumMember(Value = "WorkOrderAssetValidated")]
            WorkOrderAssetValidatedEnum = 22,
            
            /// <summary>
            /// Enum WorkOrderLabelAddedEnum for WorkOrderLabelAdded
            /// </summary>
            [EnumMember(Value = "WorkOrderLabelAdded")]
            WorkOrderLabelAddedEnum = 23,
            
            /// <summary>
            /// Enum WorkOrderLabelDeletedEnum for WorkOrderLabelDeleted
            /// </summary>
            [EnumMember(Value = "WorkOrderLabelDeleted")]
            WorkOrderLabelDeletedEnum = 24,
            
            /// <summary>
            /// Enum WorkOrderWeatherTypeChangedEnum for WorkOrderWeatherTypeChanged
            /// </summary>
            [EnumMember(Value = "WorkOrderWeatherTypeChanged")]
            WorkOrderWeatherTypeChangedEnum = 25,
            
            /// <summary>
            /// Enum WorkOrderIssueChoiceChangedEnum for WorkOrderIssueChoiceChanged
            /// </summary>
            [EnumMember(Value = "WorkOrderIssueChoiceChanged")]
            WorkOrderIssueChoiceChangedEnum = 26,
            
            /// <summary>
            /// Enum WorkOrderTechnicianAssignedEnum for WorkOrderTechnicianAssigned
            /// </summary>
            [EnumMember(Value = "WorkOrderTechnicianAssigned")]
            WorkOrderTechnicianAssignedEnum = 27,
            
            /// <summary>
            /// Enum WorkOrderTechnicianUnassignedEnum for WorkOrderTechnicianUnassigned
            /// </summary>
            [EnumMember(Value = "WorkOrderTechnicianUnassigned")]
            WorkOrderTechnicianUnassignedEnum = 28,
            
            /// <summary>
            /// Enum WorkOrderTechnicianAcceptedEnum for WorkOrderTechnicianAccepted
            /// </summary>
            [EnumMember(Value = "WorkOrderTechnicianAccepted")]
            WorkOrderTechnicianAcceptedEnum = 29,
            
            /// <summary>
            /// Enum WorkOrderTechnicianDeclinedEnum for WorkOrderTechnicianDeclined
            /// </summary>
            [EnumMember(Value = "WorkOrderTechnicianDeclined")]
            WorkOrderTechnicianDeclinedEnum = 30,
            
            /// <summary>
            /// Enum WorkOrderCertifiedTechnicianAssignedEnum for WorkOrderCertifiedTechnicianAssigned
            /// </summary>
            [EnumMember(Value = "WorkOrderCertifiedTechnicianAssigned")]
            WorkOrderCertifiedTechnicianAssignedEnum = 31,
            
            /// <summary>
            /// Enum WorkOrderLinksAddedEnum for WorkOrderLinksAdded
            /// </summary>
            [EnumMember(Value = "WorkOrderLinksAdded")]
            WorkOrderLinksAddedEnum = 32,
            
            /// <summary>
            /// Enum WorkOrderLinksDeletedEnum for WorkOrderLinksDeleted
            /// </summary>
            [EnumMember(Value = "WorkOrderLinksDeleted")]
            WorkOrderLinksDeletedEnum = 33,
            
            /// <summary>
            /// Enum WorkOrderStarAddedEnum for WorkOrderStarAdded
            /// </summary>
            [EnumMember(Value = "WorkOrderStarAdded")]
            WorkOrderStarAddedEnum = 34,
            
            /// <summary>
            /// Enum WorkOrderStarRemovedEnum for WorkOrderStarRemoved
            /// </summary>
            [EnumMember(Value = "WorkOrderStarRemoved")]
            WorkOrderStarRemovedEnum = 35,
            
            /// <summary>
            /// Enum WorkOrderCheckInEnum for WorkOrderCheckIn
            /// </summary>
            [EnumMember(Value = "WorkOrderCheckIn")]
            WorkOrderCheckInEnum = 36,
            
            /// <summary>
            /// Enum WorkOrderCheckOutEnum for WorkOrderCheckOut
            /// </summary>
            [EnumMember(Value = "WorkOrderCheckOut")]
            WorkOrderCheckOutEnum = 37,
            
            /// <summary>
            /// Enum BadgeScanRequiredEnum for BadgeScanRequired
            /// </summary>
            [EnumMember(Value = "BadgeScanRequired")]
            BadgeScanRequiredEnum = 38,
            
            /// <summary>
            /// Enum InvoiceCreatedEnum for InvoiceCreated
            /// </summary>
            [EnumMember(Value = "InvoiceCreated")]
            InvoiceCreatedEnum = 39,
            
            /// <summary>
            /// Enum InvoiceOpenEnum for InvoiceOpen
            /// </summary>
            [EnumMember(Value = "InvoiceOpen")]
            InvoiceOpenEnum = 40,
            
            /// <summary>
            /// Enum InvoiceApprovedEnum for InvoiceApproved
            /// </summary>
            [EnumMember(Value = "InvoiceApproved")]
            InvoiceApprovedEnum = 41,
            
            /// <summary>
            /// Enum InvoiceOnHoldEnum for InvoiceOnHold
            /// </summary>
            [EnumMember(Value = "InvoiceOnHold")]
            InvoiceOnHoldEnum = 42,
            
            /// <summary>
            /// Enum InvoiceReviewedEnum for InvoiceReviewed
            /// </summary>
            [EnumMember(Value = "InvoiceReviewed")]
            InvoiceReviewedEnum = 43,
            
            /// <summary>
            /// Enum InvoiceRejectedEnum for InvoiceRejected
            /// </summary>
            [EnumMember(Value = "InvoiceRejected")]
            InvoiceRejectedEnum = 44,
            
            /// <summary>
            /// Enum InvoiceApprovalCodeChangedEnum for InvoiceApprovalCodeChanged
            /// </summary>
            [EnumMember(Value = "InvoiceApprovalCodeChanged")]
            InvoiceApprovalCodeChangedEnum = 45,
            
            /// <summary>
            /// Enum InvoiceStarAddedEnum for InvoiceStarAdded
            /// </summary>
            [EnumMember(Value = "InvoiceStarAdded")]
            InvoiceStarAddedEnum = 46,
            
            /// <summary>
            /// Enum InvoiceStarRemovedEnum for InvoiceStarRemoved
            /// </summary>
            [EnumMember(Value = "InvoiceStarRemoved")]
            InvoiceStarRemovedEnum = 47,
            
            /// <summary>
            /// Enum InvoiceDisputedEnum for InvoiceDisputed
            /// </summary>
            [EnumMember(Value = "InvoiceDisputed")]
            InvoiceDisputedEnum = 48,
            
            /// <summary>
            /// Enum InvoiceVoidedEnum for InvoiceVoided
            /// </summary>
            [EnumMember(Value = "InvoiceVoided")]
            InvoiceVoidedEnum = 49,
            
            /// <summary>
            /// Enum InvoicePaidEnum for InvoicePaid
            /// </summary>
            [EnumMember(Value = "InvoicePaid")]
            InvoicePaidEnum = 50,
            
            /// <summary>
            /// Enum ProposalCreatedEnum for ProposalCreated
            /// </summary>
            [EnumMember(Value = "ProposalCreated")]
            ProposalCreatedEnum = 51,
            
            /// <summary>
            /// Enum ProposalOpenEnum for ProposalOpen
            /// </summary>
            [EnumMember(Value = "ProposalOpen")]
            ProposalOpenEnum = 52,
            
            /// <summary>
            /// Enum ProposalApprovedEnum for ProposalApproved
            /// </summary>
            [EnumMember(Value = "ProposalApproved")]
            ProposalApprovedEnum = 53,
            
            /// <summary>
            /// Enum ProposalOnHoldEnum for ProposalOnHold
            /// </summary>
            [EnumMember(Value = "ProposalOnHold")]
            ProposalOnHoldEnum = 54,
            
            /// <summary>
            /// Enum ProposalRejectedEnum for ProposalRejected
            /// </summary>
            [EnumMember(Value = "ProposalRejected")]
            ProposalRejectedEnum = 55,
            
            /// <summary>
            /// Enum ProposalReviewedEnum for ProposalReviewed
            /// </summary>
            [EnumMember(Value = "ProposalReviewed")]
            ProposalReviewedEnum = 56,
            
            /// <summary>
            /// Enum ProposalUserAssignedEnum for ProposalUserAssigned
            /// </summary>
            [EnumMember(Value = "ProposalUserAssigned")]
            ProposalUserAssignedEnum = 57,
            
            /// <summary>
            /// Enum ProposalWorkOrderAssignedEnum for ProposalWorkOrderAssigned
            /// </summary>
            [EnumMember(Value = "ProposalWorkOrderAssigned")]
            ProposalWorkOrderAssignedEnum = 58,
            
            /// <summary>
            /// Enum ProposalAttachmentAddedEnum for ProposalAttachmentAdded
            /// </summary>
            [EnumMember(Value = "ProposalAttachmentAdded")]
            ProposalAttachmentAddedEnum = 59,
            
            /// <summary>
            /// Enum ProposalScheduledEnum for ProposalScheduled
            /// </summary>
            [EnumMember(Value = "ProposalScheduled")]
            ProposalScheduledEnum = 60,
            
            /// <summary>
            /// Enum ProposalVoidedEnum for ProposalVoided
            /// </summary>
            [EnumMember(Value = "ProposalVoided")]
            ProposalVoidedEnum = 61,
            
            /// <summary>
            /// Enum ProposalPendingExternalApprovalEnum for ProposalPendingExternalApproval
            /// </summary>
            [EnumMember(Value = "ProposalPendingExternalApproval")]
            ProposalPendingExternalApprovalEnum = 62,
            
            /// <summary>
            /// Enum FbInvitationAcceptedEnum for FbInvitationAccepted
            /// </summary>
            [EnumMember(Value = "FbInvitationAccepted")]
            FbInvitationAcceptedEnum = 63,
            
            /// <summary>
            /// Enum CalendarIntegrationAddedEnum for CalendarIntegrationAdded
            /// </summary>
            [EnumMember(Value = "CalendarIntegrationAdded")]
            CalendarIntegrationAddedEnum = 64,
            
            /// <summary>
            /// Enum CalendarIntegrationUpdatedEnum for CalendarIntegrationUpdated
            /// </summary>
            [EnumMember(Value = "CalendarIntegrationUpdated")]
            CalendarIntegrationUpdatedEnum = 65,
            
            /// <summary>
            /// Enum LocationCreatedEnum for LocationCreated
            /// </summary>
            [EnumMember(Value = "LocationCreated")]
            LocationCreatedEnum = 66,
            
            /// <summary>
            /// Enum LocationUpdatedEnum for LocationUpdated
            /// </summary>
            [EnumMember(Value = "LocationUpdated")]
            LocationUpdatedEnum = 67,
            
            /// <summary>
            /// Enum LocationDeletedEnum for LocationDeleted
            /// </summary>
            [EnumMember(Value = "LocationDeleted")]
            LocationDeletedEnum = 68,
            
            /// <summary>
            /// Enum LocationNoteHeaderCreatedEnum for LocationNoteHeaderCreated
            /// </summary>
            [EnumMember(Value = "LocationNoteHeaderCreated")]
            LocationNoteHeaderCreatedEnum = 69,
            
            /// <summary>
            /// Enum LocationNoteHeaderUpdatedEnum for LocationNoteHeaderUpdated
            /// </summary>
            [EnumMember(Value = "LocationNoteHeaderUpdated")]
            LocationNoteHeaderUpdatedEnum = 70,
            
            /// <summary>
            /// Enum LocationNoteHeaderDeletedEnum for LocationNoteHeaderDeleted
            /// </summary>
            [EnumMember(Value = "LocationNoteHeaderDeleted")]
            LocationNoteHeaderDeletedEnum = 71,
            
            /// <summary>
            /// Enum LocationNotesChangedEnum for LocationNotesChanged
            /// </summary>
            [EnumMember(Value = "LocationNotesChanged")]
            LocationNotesChangedEnum = 72,
            
            /// <summary>
            /// Enum SubscriberTradeCreatedEnum for SubscriberTradeCreated
            /// </summary>
            [EnumMember(Value = "SubscriberTradeCreated")]
            SubscriberTradeCreatedEnum = 73,
            
            /// <summary>
            /// Enum SubscriberTradeUpdatedEnum for SubscriberTradeUpdated
            /// </summary>
            [EnumMember(Value = "SubscriberTradeUpdated")]
            SubscriberTradeUpdatedEnum = 74,
            
            /// <summary>
            /// Enum SubscriberTradeDeletedEnum for SubscriberTradeDeleted
            /// </summary>
            [EnumMember(Value = "SubscriberTradeDeleted")]
            SubscriberTradeDeletedEnum = 75,
            
            /// <summary>
            /// Enum SubscriberPriorityCreatedEnum for SubscriberPriorityCreated
            /// </summary>
            [EnumMember(Value = "SubscriberPriorityCreated")]
            SubscriberPriorityCreatedEnum = 76,
            
            /// <summary>
            /// Enum SubscriberPriorityUpdatedEnum for SubscriberPriorityUpdated
            /// </summary>
            [EnumMember(Value = "SubscriberPriorityUpdated")]
            SubscriberPriorityUpdatedEnum = 77,
            
            /// <summary>
            /// Enum SubscriberPriorityDeletedEnum for SubscriberPriorityDeleted
            /// </summary>
            [EnumMember(Value = "SubscriberPriorityDeleted")]
            SubscriberPriorityDeletedEnum = 78,
            
            /// <summary>
            /// Enum SubscriberStatusCreatedEnum for SubscriberStatusCreated
            /// </summary>
            [EnumMember(Value = "SubscriberStatusCreated")]
            SubscriberStatusCreatedEnum = 79,
            
            /// <summary>
            /// Enum SubscriberStatusUpdatedEnum for SubscriberStatusUpdated
            /// </summary>
            [EnumMember(Value = "SubscriberStatusUpdated")]
            SubscriberStatusUpdatedEnum = 80,
            
            /// <summary>
            /// Enum SubscriberStatusDeletedEnum for SubscriberStatusDeleted
            /// </summary>
            [EnumMember(Value = "SubscriberStatusDeleted")]
            SubscriberStatusDeletedEnum = 81,
            
            /// <summary>
            /// Enum SubscriberCategoryCreatedEnum for SubscriberCategoryCreated
            /// </summary>
            [EnumMember(Value = "SubscriberCategoryCreated")]
            SubscriberCategoryCreatedEnum = 82,
            
            /// <summary>
            /// Enum SubscriberCategoryUpdatedEnum for SubscriberCategoryUpdated
            /// </summary>
            [EnumMember(Value = "SubscriberCategoryUpdated")]
            SubscriberCategoryUpdatedEnum = 83,
            
            /// <summary>
            /// Enum SubscriberCategoryDeletedEnum for SubscriberCategoryDeleted
            /// </summary>
            [EnumMember(Value = "SubscriberCategoryDeleted")]
            SubscriberCategoryDeletedEnum = 84,
            
            /// <summary>
            /// Enum ProviderTradeAssignedEnum for ProviderTradeAssigned
            /// </summary>
            [EnumMember(Value = "ProviderTradeAssigned")]
            ProviderTradeAssignedEnum = 85,
            
            /// <summary>
            /// Enum ProviderTradeUnassignedEnum for ProviderTradeUnassigned
            /// </summary>
            [EnumMember(Value = "ProviderTradeUnassigned")]
            ProviderTradeUnassignedEnum = 86,
            
            /// <summary>
            /// Enum LeakRecordCreatedEnum for LeakRecordCreated
            /// </summary>
            [EnumMember(Value = "LeakRecordCreated")]
            LeakRecordCreatedEnum = 87,
            
            /// <summary>
            /// Enum LeakRecordUpdatedEnum for LeakRecordUpdated
            /// </summary>
            [EnumMember(Value = "LeakRecordUpdated")]
            LeakRecordUpdatedEnum = 88,
            
            /// <summary>
            /// Enum LeakRecordDeletedEnum for LeakRecordDeleted
            /// </summary>
            [EnumMember(Value = "LeakRecordDeleted")]
            LeakRecordDeletedEnum = 89,
            
            /// <summary>
            /// Enum CheckListResponseAddedEnum for CheckListResponseAdded
            /// </summary>
            [EnumMember(Value = "CheckListResponseAdded")]
            CheckListResponseAddedEnum = 90,
            
            /// <summary>
            /// Enum CheckListResponseUpdatedEnum for CheckListResponseUpdated
            /// </summary>
            [EnumMember(Value = "CheckListResponseUpdated")]
            CheckListResponseUpdatedEnum = 91,
            
            /// <summary>
            /// Enum CheckListCreatedEnum for CheckListCreated
            /// </summary>
            [EnumMember(Value = "CheckListCreated")]
            CheckListCreatedEnum = 92,
            
            /// <summary>
            /// Enum CheckListUpdatedEnum for CheckListUpdated
            /// </summary>
            [EnumMember(Value = "CheckListUpdated")]
            CheckListUpdatedEnum = 93,
            
            /// <summary>
            /// Enum CheckListDeletedEnum for CheckListDeleted
            /// </summary>
            [EnumMember(Value = "CheckListDeleted")]
            CheckListDeletedEnum = 94,
            
            /// <summary>
            /// Enum IssueListAssignedEnum for IssueListAssigned
            /// </summary>
            [EnumMember(Value = "IssueListAssigned")]
            IssueListAssignedEnum = 95,
            
            /// <summary>
            /// Enum AssetCreatedEnum for AssetCreated
            /// </summary>
            [EnumMember(Value = "AssetCreated")]
            AssetCreatedEnum = 96,
            
            /// <summary>
            /// Enum AssetUpdatedEnum for AssetUpdated
            /// </summary>
            [EnumMember(Value = "AssetUpdated")]
            AssetUpdatedEnum = 97
        }

        /// <summary>
        /// Notification message event type
        /// </summary>
        /// <value>Notification message event type</value>
        [DataMember(Name="EventType", EmitDefaultValue=true)]
        public EventTypeEnum EventType { get; set; }

        /// <summary>
        /// Notification message format version
        /// </summary>
        /// <value>Notification message format version</value>
        [DataMember(Name="Version", EmitDefaultValue=true)]
        public int VarVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingNotificationMessageServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrderCheckInOut {\n");
            sb.Append("  VarObject: ").Append(VarObject).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingNotificationMessageServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrderCheckInOut)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingNotificationMessageServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrderCheckInOut instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingNotificationMessageServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrderCheckInOut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingNotificationMessageServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrderCheckInOut other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    VarObject == other.VarObject ||
                    VarObject != null &&
                    VarObject.Equals(other.VarObject)
                ) && 
                (
                    EventType == other.EventType ||
                    
                    EventType.Equals(other.EventType)
                ) && 
                (
                    VarVersion == other.VarVersion ||
                    
                    VarVersion.Equals(other.VarVersion)
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
                    if (VarObject != null)
                    hashCode = hashCode * 59 + VarObject.GetHashCode();
                    
                    hashCode = hashCode * 59 + EventType.GetHashCode();
                    
                    hashCode = hashCode * 59 + VarVersion.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingNotificationMessageServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrderCheckInOut left, SCServiceChannelServicesMessagingNotificationMessageServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrderCheckInOut right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingNotificationMessageServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrderCheckInOut left, SCServiceChannelServicesMessagingNotificationMessageServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrderCheckInOut right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
