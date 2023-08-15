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
    /// SCServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrderCheckInOut
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Broker.Models.Contexts.Request.BrokerWorkOrderCheckInOut")]
    public partial class SCServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrderCheckInOut : IEquatable<SCServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrderCheckInOut>, IValidatableObject
    {
        /// <summary>
        /// Defines CheckinAction
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CheckinActionEnum
        {
            /// <summary>
            /// Enum CheckIn for value: CheckIn
            /// </summary>
            [EnumMember(Value = "CheckIn")]
            CheckIn = 1,

            /// <summary>
            /// Enum CheckOut for value: CheckOut
            /// </summary>
            [EnumMember(Value = "CheckOut")]
            CheckOut = 2

        }


        /// <summary>
        /// Gets or Sets CheckinAction
        /// </summary>
        [DataMember(Name = "CheckinAction", EmitDefaultValue = false)]
        public CheckinActionEnum? CheckinAction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrderCheckInOut" /> class.
        /// </summary>
        /// <param name="checkInNotes">checkInNotes.</param>
        /// <param name="id">id.</param>
        /// <param name="subscriberId">subscriberId.</param>
        /// <param name="providerId">providerId.</param>
        /// <param name="locationId">locationId.</param>
        /// <param name="checkinAction">checkinAction.</param>
        /// <param name="workOrderId">workOrderId.</param>
        /// <param name="date">date.</param>
        /// <param name="dateDTO">dateDTO.</param>
        /// <param name="user">user.</param>
        /// <param name="callerId">callerId.</param>
        /// <param name="action">action.</param>
        /// <param name="workType">workType.</param>
        /// <param name="workorderStatus">workorderStatus.</param>
        /// <param name="providerName">providerName.</param>
        /// <param name="trade">trade.</param>
        /// <param name="category">category.</param>
        /// <param name="source">source.</param>
        /// <param name="tradeId">tradeId.</param>
        /// <param name="techsCount">techsCount.</param>
        /// <param name="location">location.</param>
        public SCServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrderCheckInOut(Dictionary<string, string> checkInNotes = default(Dictionary<string, string>), int id = default(int), int subscriberId = default(int), int providerId = default(int), int locationId = default(int), CheckinActionEnum? checkinAction = default(CheckinActionEnum?), int workOrderId = default(int), DateTime date = default(DateTime), DateTime dateDTO = default(DateTime), SCServiceChannelNotificationsObjectsUser user = default(SCServiceChannelNotificationsObjectsUser), string callerId = default(string), string action = default(string), string workType = default(string), SCServiceChannelNotificationsObjectsWorkorderStatusDescriptor workorderStatus = default(SCServiceChannelNotificationsObjectsWorkorderStatusDescriptor), string providerName = default(string), string trade = default(string), string category = default(string), string source = default(string), int tradeId = default(int), int techsCount = default(int), SCServiceChannelNotificationsObjectsLocation location = default(SCServiceChannelNotificationsObjectsLocation))
        {
            this.CheckInNotes = checkInNotes;
            this.Id = id;
            this.SubscriberId = subscriberId;
            this.ProviderId = providerId;
            this.LocationId = locationId;
            this.CheckinAction = checkinAction;
            this.WorkOrderId = workOrderId;
            this.Date = date;
            this.DateDTO = dateDTO;
            this.User = user;
            this.CallerId = callerId;
            this.Action = action;
            this.WorkType = workType;
            this.WorkorderStatus = workorderStatus;
            this.ProviderName = providerName;
            this.Trade = trade;
            this.Category = category;
            this.Source = source;
            this.TradeId = tradeId;
            this.TechsCount = techsCount;
            this.Location = location;
        }

        /// <summary>
        /// Gets or Sets CheckInNotes
        /// </summary>
        [DataMember(Name = "CheckInNotes", EmitDefaultValue = false)]
        public Dictionary<string, string> CheckInNotes { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets SubscriberId
        /// </summary>
        [DataMember(Name = "SubscriberId", EmitDefaultValue = false)]
        public int SubscriberId { get; set; }

        /// <summary>
        /// Gets or Sets ProviderId
        /// </summary>
        [DataMember(Name = "ProviderId", EmitDefaultValue = false)]
        public int ProviderId { get; set; }

        /// <summary>
        /// Gets or Sets LocationId
        /// </summary>
        [DataMember(Name = "LocationId", EmitDefaultValue = false)]
        public int LocationId { get; set; }

        /// <summary>
        /// Gets or Sets WorkOrderId
        /// </summary>
        [DataMember(Name = "WorkOrderId", EmitDefaultValue = false)]
        public int WorkOrderId { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "Date", EmitDefaultValue = false)]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or Sets DateDTO
        /// </summary>
        [DataMember(Name = "DateDTO", EmitDefaultValue = false)]
        public DateTime DateDTO { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "User", EmitDefaultValue = false)]
        public SCServiceChannelNotificationsObjectsUser User { get; set; }

        /// <summary>
        /// Gets or Sets CallerId
        /// </summary>
        [DataMember(Name = "CallerId", EmitDefaultValue = false)]
        public string CallerId { get; set; }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name = "Action", EmitDefaultValue = false)]
        public string Action { get; set; }

        /// <summary>
        /// Gets or Sets WorkType
        /// </summary>
        [DataMember(Name = "WorkType", EmitDefaultValue = false)]
        public string WorkType { get; set; }

        /// <summary>
        /// Gets or Sets WorkorderStatus
        /// </summary>
        [DataMember(Name = "WorkorderStatus", EmitDefaultValue = false)]
        public SCServiceChannelNotificationsObjectsWorkorderStatusDescriptor WorkorderStatus { get; set; }

        /// <summary>
        /// Gets or Sets ProviderName
        /// </summary>
        [DataMember(Name = "ProviderName", EmitDefaultValue = false)]
        public string ProviderName { get; set; }

        /// <summary>
        /// Gets or Sets Trade
        /// </summary>
        [DataMember(Name = "Trade", EmitDefaultValue = false)]
        public string Trade { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "Category", EmitDefaultValue = false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "Source", EmitDefaultValue = false)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or Sets TradeId
        /// </summary>
        [DataMember(Name = "TradeId", EmitDefaultValue = false)]
        public int TradeId { get; set; }

        /// <summary>
        /// Gets or Sets TechsCount
        /// </summary>
        [DataMember(Name = "TechsCount", EmitDefaultValue = false)]
        public int TechsCount { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "Location", EmitDefaultValue = false)]
        public SCServiceChannelNotificationsObjectsLocation Location { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrderCheckInOut {\n");
            sb.Append("  CheckInNotes: ").Append(CheckInNotes).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SubscriberId: ").Append(SubscriberId).Append("\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  CheckinAction: ").Append(CheckinAction).Append("\n");
            sb.Append("  WorkOrderId: ").Append(WorkOrderId).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  DateDTO: ").Append(DateDTO).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  CallerId: ").Append(CallerId).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  WorkType: ").Append(WorkType).Append("\n");
            sb.Append("  WorkorderStatus: ").Append(WorkorderStatus).Append("\n");
            sb.Append("  ProviderName: ").Append(ProviderName).Append("\n");
            sb.Append("  Trade: ").Append(Trade).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  TradeId: ").Append(TradeId).Append("\n");
            sb.Append("  TechsCount: ").Append(TechsCount).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrderCheckInOut);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrderCheckInOut instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrderCheckInOut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrderCheckInOut input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CheckInNotes == input.CheckInNotes ||
                    this.CheckInNotes != null &&
                    input.CheckInNotes != null &&
                    this.CheckInNotes.SequenceEqual(input.CheckInNotes)
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.SubscriberId == input.SubscriberId ||
                    this.SubscriberId.Equals(input.SubscriberId)
                ) && 
                (
                    this.ProviderId == input.ProviderId ||
                    this.ProviderId.Equals(input.ProviderId)
                ) && 
                (
                    this.LocationId == input.LocationId ||
                    this.LocationId.Equals(input.LocationId)
                ) && 
                (
                    this.CheckinAction == input.CheckinAction ||
                    this.CheckinAction.Equals(input.CheckinAction)
                ) && 
                (
                    this.WorkOrderId == input.WorkOrderId ||
                    this.WorkOrderId.Equals(input.WorkOrderId)
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.DateDTO == input.DateDTO ||
                    (this.DateDTO != null &&
                    this.DateDTO.Equals(input.DateDTO))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.CallerId == input.CallerId ||
                    (this.CallerId != null &&
                    this.CallerId.Equals(input.CallerId))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.WorkType == input.WorkType ||
                    (this.WorkType != null &&
                    this.WorkType.Equals(input.WorkType))
                ) && 
                (
                    this.WorkorderStatus == input.WorkorderStatus ||
                    (this.WorkorderStatus != null &&
                    this.WorkorderStatus.Equals(input.WorkorderStatus))
                ) && 
                (
                    this.ProviderName == input.ProviderName ||
                    (this.ProviderName != null &&
                    this.ProviderName.Equals(input.ProviderName))
                ) && 
                (
                    this.Trade == input.Trade ||
                    (this.Trade != null &&
                    this.Trade.Equals(input.Trade))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.TradeId == input.TradeId ||
                    this.TradeId.Equals(input.TradeId)
                ) && 
                (
                    this.TechsCount == input.TechsCount ||
                    this.TechsCount.Equals(input.TechsCount)
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
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
                if (this.CheckInNotes != null)
                {
                    hashCode = (hashCode * 59) + this.CheckInNotes.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                hashCode = (hashCode * 59) + this.SubscriberId.GetHashCode();
                hashCode = (hashCode * 59) + this.ProviderId.GetHashCode();
                hashCode = (hashCode * 59) + this.LocationId.GetHashCode();
                hashCode = (hashCode * 59) + this.CheckinAction.GetHashCode();
                hashCode = (hashCode * 59) + this.WorkOrderId.GetHashCode();
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
                }
                if (this.DateDTO != null)
                {
                    hashCode = (hashCode * 59) + this.DateDTO.GetHashCode();
                }
                if (this.User != null)
                {
                    hashCode = (hashCode * 59) + this.User.GetHashCode();
                }
                if (this.CallerId != null)
                {
                    hashCode = (hashCode * 59) + this.CallerId.GetHashCode();
                }
                if (this.Action != null)
                {
                    hashCode = (hashCode * 59) + this.Action.GetHashCode();
                }
                if (this.WorkType != null)
                {
                    hashCode = (hashCode * 59) + this.WorkType.GetHashCode();
                }
                if (this.WorkorderStatus != null)
                {
                    hashCode = (hashCode * 59) + this.WorkorderStatus.GetHashCode();
                }
                if (this.ProviderName != null)
                {
                    hashCode = (hashCode * 59) + this.ProviderName.GetHashCode();
                }
                if (this.Trade != null)
                {
                    hashCode = (hashCode * 59) + this.Trade.GetHashCode();
                }
                if (this.Category != null)
                {
                    hashCode = (hashCode * 59) + this.Category.GetHashCode();
                }
                if (this.Source != null)
                {
                    hashCode = (hashCode * 59) + this.Source.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TradeId.GetHashCode();
                hashCode = (hashCode * 59) + this.TechsCount.GetHashCode();
                if (this.Location != null)
                {
                    hashCode = (hashCode * 59) + this.Location.GetHashCode();
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