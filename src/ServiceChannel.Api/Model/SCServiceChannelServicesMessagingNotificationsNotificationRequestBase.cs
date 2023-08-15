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
    /// SCServiceChannelServicesMessagingNotificationsNotificationRequestBase
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.Notifications.NotificationRequestBase")]
    public partial class SCServiceChannelServicesMessagingNotificationsNotificationRequestBase : IEquatable<SCServiceChannelServicesMessagingNotificationsNotificationRequestBase>, IValidatableObject
    {
        /// <summary>
        /// Defines EventTypes
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventTypesEnum
        {
            /// <summary>
            /// Enum WorkOrderCreated for value: WorkOrderCreated
            /// </summary>
            [EnumMember(Value = "WorkOrderCreated")]
            WorkOrderCreated = 1,

            /// <summary>
            /// Enum WorkOrderNoteAdded for value: WorkOrderNoteAdded
            /// </summary>
            [EnumMember(Value = "WorkOrderNoteAdded")]
            WorkOrderNoteAdded = 2,

            /// <summary>
            /// Enum WorkOrderNotePinned for value: WorkOrderNotePinned
            /// </summary>
            [EnumMember(Value = "WorkOrderNotePinned")]
            WorkOrderNotePinned = 3,

            /// <summary>
            /// Enum WorkOrderNoteUnpinned for value: WorkOrderNoteUnpinned
            /// </summary>
            [EnumMember(Value = "WorkOrderNoteUnpinned")]
            WorkOrderNoteUnpinned = 4,

            /// <summary>
            /// Enum WorkOrderStatusChanged for value: WorkOrderStatusChanged
            /// </summary>
            [EnumMember(Value = "WorkOrderStatusChanged")]
            WorkOrderStatusChanged = 5,

            /// <summary>
            /// Enum WorkOrderAttachmentAdded for value: WorkOrderAttachmentAdded
            /// </summary>
            [EnumMember(Value = "WorkOrderAttachmentAdded")]
            WorkOrderAttachmentAdded = 6,

            /// <summary>
            /// Enum WorkOrderNumberChanged for value: WorkOrderNumberChanged
            /// </summary>
            [EnumMember(Value = "WorkOrderNumberChanged")]
            WorkOrderNumberChanged = 7,

            /// <summary>
            /// Enum WorkOrderPriorityChanged for value: WorkOrderPriorityChanged
            /// </summary>
            [EnumMember(Value = "WorkOrderPriorityChanged")]
            WorkOrderPriorityChanged = 8,

            /// <summary>
            /// Enum WorkOrderScheduledDateChanged for value: WorkOrderScheduledDateChanged
            /// </summary>
            [EnumMember(Value = "WorkOrderScheduledDateChanged")]
            WorkOrderScheduledDateChanged = 9,

            /// <summary>
            /// Enum WorkOrderTradeChanged for value: WorkOrderTradeChanged
            /// </summary>
            [EnumMember(Value = "WorkOrderTradeChanged")]
            WorkOrderTradeChanged = 10,

            /// <summary>
            /// Enum WorkOrderNteChanged for value: WorkOrderNteChanged
            /// </summary>
            [EnumMember(Value = "WorkOrderNteChanged")]
            WorkOrderNteChanged = 11,

            /// <summary>
            /// Enum WorkOrderCategoryChanged for value: WorkOrderCategoryChanged
            /// </summary>
            [EnumMember(Value = "WorkOrderCategoryChanged")]
            WorkOrderCategoryChanged = 12,

            /// <summary>
            /// Enum WorkOrderProviderChanged for value: WorkOrderProviderChanged
            /// </summary>
            [EnumMember(Value = "WorkOrderProviderChanged")]
            WorkOrderProviderChanged = 13,

            /// <summary>
            /// Enum WorkOrderDescriptionChanged for value: WorkOrderDescriptionChanged
            /// </summary>
            [EnumMember(Value = "WorkOrderDescriptionChanged")]
            WorkOrderDescriptionChanged = 14,

            /// <summary>
            /// Enum WorkOrderResolutionCreated for value: WorkOrderResolutionCreated
            /// </summary>
            [EnumMember(Value = "WorkOrderResolutionCreated")]
            WorkOrderResolutionCreated = 15,

            /// <summary>
            /// Enum RefrigerantWasUsedChanged for value: RefrigerantWasUsedChanged
            /// </summary>
            [EnumMember(Value = "RefrigerantWasUsedChanged")]
            RefrigerantWasUsedChanged = 16,

            /// <summary>
            /// Enum WorkOrderResolutionUpdated for value: WorkOrderResolutionUpdated
            /// </summary>
            [EnumMember(Value = "WorkOrderResolutionUpdated")]
            WorkOrderResolutionUpdated = 17,

            /// <summary>
            /// Enum WorkOrderResolutionCodeUpdated for value: WorkOrderResolutionCodeUpdated
            /// </summary>
            [EnumMember(Value = "WorkOrderResolutionCodeUpdated")]
            WorkOrderResolutionCodeUpdated = 18,

            /// <summary>
            /// Enum WorkOrderRootCauseCodeUpdated for value: WorkOrderRootCauseCodeUpdated
            /// </summary>
            [EnumMember(Value = "WorkOrderRootCauseCodeUpdated")]
            WorkOrderRootCauseCodeUpdated = 19,

            /// <summary>
            /// Enum WorkOrderAssetAttached for value: WorkOrderAssetAttached
            /// </summary>
            [EnumMember(Value = "WorkOrderAssetAttached")]
            WorkOrderAssetAttached = 20,

            /// <summary>
            /// Enum WorkOrderAssetDetached for value: WorkOrderAssetDetached
            /// </summary>
            [EnumMember(Value = "WorkOrderAssetDetached")]
            WorkOrderAssetDetached = 21,

            /// <summary>
            /// Enum WorkOrderAssetValidated for value: WorkOrderAssetValidated
            /// </summary>
            [EnumMember(Value = "WorkOrderAssetValidated")]
            WorkOrderAssetValidated = 22,

            /// <summary>
            /// Enum WorkOrderLabelAdded for value: WorkOrderLabelAdded
            /// </summary>
            [EnumMember(Value = "WorkOrderLabelAdded")]
            WorkOrderLabelAdded = 23,

            /// <summary>
            /// Enum WorkOrderLabelDeleted for value: WorkOrderLabelDeleted
            /// </summary>
            [EnumMember(Value = "WorkOrderLabelDeleted")]
            WorkOrderLabelDeleted = 24,

            /// <summary>
            /// Enum WorkOrderWeatherTypeChanged for value: WorkOrderWeatherTypeChanged
            /// </summary>
            [EnumMember(Value = "WorkOrderWeatherTypeChanged")]
            WorkOrderWeatherTypeChanged = 25,

            /// <summary>
            /// Enum WorkOrderIssueChoiceChanged for value: WorkOrderIssueChoiceChanged
            /// </summary>
            [EnumMember(Value = "WorkOrderIssueChoiceChanged")]
            WorkOrderIssueChoiceChanged = 26,

            /// <summary>
            /// Enum WorkOrderTechnicianAssigned for value: WorkOrderTechnicianAssigned
            /// </summary>
            [EnumMember(Value = "WorkOrderTechnicianAssigned")]
            WorkOrderTechnicianAssigned = 27,

            /// <summary>
            /// Enum WorkOrderTechnicianUnassigned for value: WorkOrderTechnicianUnassigned
            /// </summary>
            [EnumMember(Value = "WorkOrderTechnicianUnassigned")]
            WorkOrderTechnicianUnassigned = 28,

            /// <summary>
            /// Enum WorkOrderTechnicianAccepted for value: WorkOrderTechnicianAccepted
            /// </summary>
            [EnumMember(Value = "WorkOrderTechnicianAccepted")]
            WorkOrderTechnicianAccepted = 29,

            /// <summary>
            /// Enum WorkOrderTechnicianDeclined for value: WorkOrderTechnicianDeclined
            /// </summary>
            [EnumMember(Value = "WorkOrderTechnicianDeclined")]
            WorkOrderTechnicianDeclined = 30,

            /// <summary>
            /// Enum WorkOrderCertifiedTechnicianAssigned for value: WorkOrderCertifiedTechnicianAssigned
            /// </summary>
            [EnumMember(Value = "WorkOrderCertifiedTechnicianAssigned")]
            WorkOrderCertifiedTechnicianAssigned = 31,

            /// <summary>
            /// Enum WorkOrderLinksAdded for value: WorkOrderLinksAdded
            /// </summary>
            [EnumMember(Value = "WorkOrderLinksAdded")]
            WorkOrderLinksAdded = 32,

            /// <summary>
            /// Enum WorkOrderLinksDeleted for value: WorkOrderLinksDeleted
            /// </summary>
            [EnumMember(Value = "WorkOrderLinksDeleted")]
            WorkOrderLinksDeleted = 33,

            /// <summary>
            /// Enum WorkOrderStarAdded for value: WorkOrderStarAdded
            /// </summary>
            [EnumMember(Value = "WorkOrderStarAdded")]
            WorkOrderStarAdded = 34,

            /// <summary>
            /// Enum WorkOrderStarRemoved for value: WorkOrderStarRemoved
            /// </summary>
            [EnumMember(Value = "WorkOrderStarRemoved")]
            WorkOrderStarRemoved = 35,

            /// <summary>
            /// Enum WorkOrderCheckIn for value: WorkOrderCheckIn
            /// </summary>
            [EnumMember(Value = "WorkOrderCheckIn")]
            WorkOrderCheckIn = 36,

            /// <summary>
            /// Enum WorkOrderCheckOut for value: WorkOrderCheckOut
            /// </summary>
            [EnumMember(Value = "WorkOrderCheckOut")]
            WorkOrderCheckOut = 37,

            /// <summary>
            /// Enum BadgeScanRequired for value: BadgeScanRequired
            /// </summary>
            [EnumMember(Value = "BadgeScanRequired")]
            BadgeScanRequired = 38,

            /// <summary>
            /// Enum InvoiceCreated for value: InvoiceCreated
            /// </summary>
            [EnumMember(Value = "InvoiceCreated")]
            InvoiceCreated = 39,

            /// <summary>
            /// Enum InvoiceOpen for value: InvoiceOpen
            /// </summary>
            [EnumMember(Value = "InvoiceOpen")]
            InvoiceOpen = 40,

            /// <summary>
            /// Enum InvoiceApproved for value: InvoiceApproved
            /// </summary>
            [EnumMember(Value = "InvoiceApproved")]
            InvoiceApproved = 41,

            /// <summary>
            /// Enum InvoiceOnHold for value: InvoiceOnHold
            /// </summary>
            [EnumMember(Value = "InvoiceOnHold")]
            InvoiceOnHold = 42,

            /// <summary>
            /// Enum InvoiceReviewed for value: InvoiceReviewed
            /// </summary>
            [EnumMember(Value = "InvoiceReviewed")]
            InvoiceReviewed = 43,

            /// <summary>
            /// Enum InvoiceRejected for value: InvoiceRejected
            /// </summary>
            [EnumMember(Value = "InvoiceRejected")]
            InvoiceRejected = 44,

            /// <summary>
            /// Enum InvoiceApprovalCodeChanged for value: InvoiceApprovalCodeChanged
            /// </summary>
            [EnumMember(Value = "InvoiceApprovalCodeChanged")]
            InvoiceApprovalCodeChanged = 45,

            /// <summary>
            /// Enum InvoiceStarAdded for value: InvoiceStarAdded
            /// </summary>
            [EnumMember(Value = "InvoiceStarAdded")]
            InvoiceStarAdded = 46,

            /// <summary>
            /// Enum InvoiceStarRemoved for value: InvoiceStarRemoved
            /// </summary>
            [EnumMember(Value = "InvoiceStarRemoved")]
            InvoiceStarRemoved = 47,

            /// <summary>
            /// Enum InvoiceDisputed for value: InvoiceDisputed
            /// </summary>
            [EnumMember(Value = "InvoiceDisputed")]
            InvoiceDisputed = 48,

            /// <summary>
            /// Enum InvoiceVoided for value: InvoiceVoided
            /// </summary>
            [EnumMember(Value = "InvoiceVoided")]
            InvoiceVoided = 49,

            /// <summary>
            /// Enum InvoicePaid for value: InvoicePaid
            /// </summary>
            [EnumMember(Value = "InvoicePaid")]
            InvoicePaid = 50,

            /// <summary>
            /// Enum ProposalCreated for value: ProposalCreated
            /// </summary>
            [EnumMember(Value = "ProposalCreated")]
            ProposalCreated = 51,

            /// <summary>
            /// Enum ProposalOpen for value: ProposalOpen
            /// </summary>
            [EnumMember(Value = "ProposalOpen")]
            ProposalOpen = 52,

            /// <summary>
            /// Enum ProposalApproved for value: ProposalApproved
            /// </summary>
            [EnumMember(Value = "ProposalApproved")]
            ProposalApproved = 53,

            /// <summary>
            /// Enum ProposalOnHold for value: ProposalOnHold
            /// </summary>
            [EnumMember(Value = "ProposalOnHold")]
            ProposalOnHold = 54,

            /// <summary>
            /// Enum ProposalRejected for value: ProposalRejected
            /// </summary>
            [EnumMember(Value = "ProposalRejected")]
            ProposalRejected = 55,

            /// <summary>
            /// Enum ProposalReviewed for value: ProposalReviewed
            /// </summary>
            [EnumMember(Value = "ProposalReviewed")]
            ProposalReviewed = 56,

            /// <summary>
            /// Enum ProposalUserAssigned for value: ProposalUserAssigned
            /// </summary>
            [EnumMember(Value = "ProposalUserAssigned")]
            ProposalUserAssigned = 57,

            /// <summary>
            /// Enum ProposalWorkOrderAssigned for value: ProposalWorkOrderAssigned
            /// </summary>
            [EnumMember(Value = "ProposalWorkOrderAssigned")]
            ProposalWorkOrderAssigned = 58,

            /// <summary>
            /// Enum ProposalAttachmentAdded for value: ProposalAttachmentAdded
            /// </summary>
            [EnumMember(Value = "ProposalAttachmentAdded")]
            ProposalAttachmentAdded = 59,

            /// <summary>
            /// Enum ProposalScheduled for value: ProposalScheduled
            /// </summary>
            [EnumMember(Value = "ProposalScheduled")]
            ProposalScheduled = 60,

            /// <summary>
            /// Enum ProposalVoided for value: ProposalVoided
            /// </summary>
            [EnumMember(Value = "ProposalVoided")]
            ProposalVoided = 61,

            /// <summary>
            /// Enum ProposalPendingExternalApproval for value: ProposalPendingExternalApproval
            /// </summary>
            [EnumMember(Value = "ProposalPendingExternalApproval")]
            ProposalPendingExternalApproval = 62,

            /// <summary>
            /// Enum FbInvitationAccepted for value: FbInvitationAccepted
            /// </summary>
            [EnumMember(Value = "FbInvitationAccepted")]
            FbInvitationAccepted = 63,

            /// <summary>
            /// Enum CalendarIntegrationAdded for value: CalendarIntegrationAdded
            /// </summary>
            [EnumMember(Value = "CalendarIntegrationAdded")]
            CalendarIntegrationAdded = 64,

            /// <summary>
            /// Enum CalendarIntegrationUpdated for value: CalendarIntegrationUpdated
            /// </summary>
            [EnumMember(Value = "CalendarIntegrationUpdated")]
            CalendarIntegrationUpdated = 65,

            /// <summary>
            /// Enum LocationCreated for value: LocationCreated
            /// </summary>
            [EnumMember(Value = "LocationCreated")]
            LocationCreated = 66,

            /// <summary>
            /// Enum LocationUpdated for value: LocationUpdated
            /// </summary>
            [EnumMember(Value = "LocationUpdated")]
            LocationUpdated = 67,

            /// <summary>
            /// Enum LocationDeleted for value: LocationDeleted
            /// </summary>
            [EnumMember(Value = "LocationDeleted")]
            LocationDeleted = 68,

            /// <summary>
            /// Enum LocationNoteHeaderCreated for value: LocationNoteHeaderCreated
            /// </summary>
            [EnumMember(Value = "LocationNoteHeaderCreated")]
            LocationNoteHeaderCreated = 69,

            /// <summary>
            /// Enum LocationNoteHeaderUpdated for value: LocationNoteHeaderUpdated
            /// </summary>
            [EnumMember(Value = "LocationNoteHeaderUpdated")]
            LocationNoteHeaderUpdated = 70,

            /// <summary>
            /// Enum LocationNoteHeaderDeleted for value: LocationNoteHeaderDeleted
            /// </summary>
            [EnumMember(Value = "LocationNoteHeaderDeleted")]
            LocationNoteHeaderDeleted = 71,

            /// <summary>
            /// Enum LocationNotesChanged for value: LocationNotesChanged
            /// </summary>
            [EnumMember(Value = "LocationNotesChanged")]
            LocationNotesChanged = 72,

            /// <summary>
            /// Enum SubscriberTradeCreated for value: SubscriberTradeCreated
            /// </summary>
            [EnumMember(Value = "SubscriberTradeCreated")]
            SubscriberTradeCreated = 73,

            /// <summary>
            /// Enum SubscriberTradeUpdated for value: SubscriberTradeUpdated
            /// </summary>
            [EnumMember(Value = "SubscriberTradeUpdated")]
            SubscriberTradeUpdated = 74,

            /// <summary>
            /// Enum SubscriberTradeDeleted for value: SubscriberTradeDeleted
            /// </summary>
            [EnumMember(Value = "SubscriberTradeDeleted")]
            SubscriberTradeDeleted = 75,

            /// <summary>
            /// Enum SubscriberPriorityCreated for value: SubscriberPriorityCreated
            /// </summary>
            [EnumMember(Value = "SubscriberPriorityCreated")]
            SubscriberPriorityCreated = 76,

            /// <summary>
            /// Enum SubscriberPriorityUpdated for value: SubscriberPriorityUpdated
            /// </summary>
            [EnumMember(Value = "SubscriberPriorityUpdated")]
            SubscriberPriorityUpdated = 77,

            /// <summary>
            /// Enum SubscriberPriorityDeleted for value: SubscriberPriorityDeleted
            /// </summary>
            [EnumMember(Value = "SubscriberPriorityDeleted")]
            SubscriberPriorityDeleted = 78,

            /// <summary>
            /// Enum SubscriberStatusCreated for value: SubscriberStatusCreated
            /// </summary>
            [EnumMember(Value = "SubscriberStatusCreated")]
            SubscriberStatusCreated = 79,

            /// <summary>
            /// Enum SubscriberStatusUpdated for value: SubscriberStatusUpdated
            /// </summary>
            [EnumMember(Value = "SubscriberStatusUpdated")]
            SubscriberStatusUpdated = 80,

            /// <summary>
            /// Enum SubscriberStatusDeleted for value: SubscriberStatusDeleted
            /// </summary>
            [EnumMember(Value = "SubscriberStatusDeleted")]
            SubscriberStatusDeleted = 81,

            /// <summary>
            /// Enum SubscriberCategoryCreated for value: SubscriberCategoryCreated
            /// </summary>
            [EnumMember(Value = "SubscriberCategoryCreated")]
            SubscriberCategoryCreated = 82,

            /// <summary>
            /// Enum SubscriberCategoryUpdated for value: SubscriberCategoryUpdated
            /// </summary>
            [EnumMember(Value = "SubscriberCategoryUpdated")]
            SubscriberCategoryUpdated = 83,

            /// <summary>
            /// Enum SubscriberCategoryDeleted for value: SubscriberCategoryDeleted
            /// </summary>
            [EnumMember(Value = "SubscriberCategoryDeleted")]
            SubscriberCategoryDeleted = 84,

            /// <summary>
            /// Enum ProviderTradeAssigned for value: ProviderTradeAssigned
            /// </summary>
            [EnumMember(Value = "ProviderTradeAssigned")]
            ProviderTradeAssigned = 85,

            /// <summary>
            /// Enum ProviderTradeUnassigned for value: ProviderTradeUnassigned
            /// </summary>
            [EnumMember(Value = "ProviderTradeUnassigned")]
            ProviderTradeUnassigned = 86,

            /// <summary>
            /// Enum LeakRecordCreated for value: LeakRecordCreated
            /// </summary>
            [EnumMember(Value = "LeakRecordCreated")]
            LeakRecordCreated = 87,

            /// <summary>
            /// Enum LeakRecordUpdated for value: LeakRecordUpdated
            /// </summary>
            [EnumMember(Value = "LeakRecordUpdated")]
            LeakRecordUpdated = 88,

            /// <summary>
            /// Enum LeakRecordDeleted for value: LeakRecordDeleted
            /// </summary>
            [EnumMember(Value = "LeakRecordDeleted")]
            LeakRecordDeleted = 89,

            /// <summary>
            /// Enum CheckListResponseAdded for value: CheckListResponseAdded
            /// </summary>
            [EnumMember(Value = "CheckListResponseAdded")]
            CheckListResponseAdded = 90,

            /// <summary>
            /// Enum CheckListResponseUpdated for value: CheckListResponseUpdated
            /// </summary>
            [EnumMember(Value = "CheckListResponseUpdated")]
            CheckListResponseUpdated = 91,

            /// <summary>
            /// Enum CheckListCreated for value: CheckListCreated
            /// </summary>
            [EnumMember(Value = "CheckListCreated")]
            CheckListCreated = 92,

            /// <summary>
            /// Enum CheckListUpdated for value: CheckListUpdated
            /// </summary>
            [EnumMember(Value = "CheckListUpdated")]
            CheckListUpdated = 93,

            /// <summary>
            /// Enum CheckListDeleted for value: CheckListDeleted
            /// </summary>
            [EnumMember(Value = "CheckListDeleted")]
            CheckListDeleted = 94,

            /// <summary>
            /// Enum IssueListAssigned for value: IssueListAssigned
            /// </summary>
            [EnumMember(Value = "IssueListAssigned")]
            IssueListAssigned = 95,

            /// <summary>
            /// Enum AssetCreated for value: AssetCreated
            /// </summary>
            [EnumMember(Value = "AssetCreated")]
            AssetCreated = 96,

            /// <summary>
            /// Enum AssetUpdated for value: AssetUpdated
            /// </summary>
            [EnumMember(Value = "AssetUpdated")]
            AssetUpdated = 97

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingNotificationsNotificationRequestBase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SCServiceChannelServicesMessagingNotificationsNotificationRequestBase() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingNotificationsNotificationRequestBase" /> class.
        /// </summary>
        /// <param name="name">The user-friendly name for the subscription. (required).</param>
        /// <param name="eventTypes">The list of events to subscribe to. Events within one subscription should belong to one object. (required).</param>
        /// <param name="rules">rules.</param>
        public SCServiceChannelServicesMessagingNotificationsNotificationRequestBase(string name = default(string), List<EventTypesEnum> eventTypes = default(List<EventTypesEnum>), SCServiceChannelServicesMessagingNotificationsNotificationSubscriptionsRules rules = default(SCServiceChannelServicesMessagingNotificationsNotificationSubscriptionsRules))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for SCServiceChannelServicesMessagingNotificationsNotificationRequestBase and cannot be null");
            }
            this.Name = name;
            // to ensure "eventTypes" is required (not null)
            if (eventTypes == null)
            {
                throw new ArgumentNullException("eventTypes is a required property for SCServiceChannelServicesMessagingNotificationsNotificationRequestBase and cannot be null");
            }
            this.EventTypes = eventTypes;
            this.Rules = rules;
        }

        /// <summary>
        /// The user-friendly name for the subscription.
        /// </summary>
        /// <value>The user-friendly name for the subscription.</value>
        [DataMember(Name = "Name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The list of events to subscribe to. Events within one subscription should belong to one object.
        /// </summary>
        /// <value>The list of events to subscribe to. Events within one subscription should belong to one object.</value>
        [DataMember(Name = "EventTypes", IsRequired = true, EmitDefaultValue = true)]
        public List<SCServiceChannelServicesMessagingNotificationsNotificationRequestBase.EventTypesEnum> EventTypes { get; set; }

        /// <summary>
        /// Gets or Sets Rules
        /// </summary>
        [DataMember(Name = "Rules", EmitDefaultValue = false)]
        public SCServiceChannelServicesMessagingNotificationsNotificationSubscriptionsRules Rules { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingNotificationsNotificationRequestBase {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EventTypes: ").Append(EventTypes).Append("\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingNotificationsNotificationRequestBase);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingNotificationsNotificationRequestBase instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingNotificationsNotificationRequestBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingNotificationsNotificationRequestBase input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.EventTypes == input.EventTypes ||
                    this.EventTypes != null &&
                    input.EventTypes != null &&
                    this.EventTypes.SequenceEqual(input.EventTypes)
                ) && 
                (
                    this.Rules == input.Rules ||
                    (this.Rules != null &&
                    this.Rules.Equals(input.Rules))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.EventTypes != null)
                {
                    hashCode = (hashCode * 59) + this.EventTypes.GetHashCode();
                }
                if (this.Rules != null)
                {
                    hashCode = (hashCode * 59) + this.Rules.GetHashCode();
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
