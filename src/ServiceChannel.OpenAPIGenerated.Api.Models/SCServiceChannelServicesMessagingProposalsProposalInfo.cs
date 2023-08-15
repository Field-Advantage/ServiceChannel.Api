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
    public class SCServiceChannelServicesMessagingProposalsProposalInfo : IEquatable<SCServiceChannelServicesMessagingProposalsProposalInfo>
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=true)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name="Number", EmitDefaultValue=false)]
        public string Number { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Description2
        /// </summary>
        [DataMember(Name="Description2", EmitDefaultValue=false)]
        public string Description2 { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="Comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="Location", EmitDefaultValue=false)]
        public SCServiceChannelServicesMessagingLocationLocation Location { get; set; }

        /// <summary>
        /// Gets or Sets Provider
        /// </summary>
        [DataMember(Name="Provider", EmitDefaultValue=false)]
        public SCServiceChannelServicesMessagingProvidersProvider Provider { get; set; }

        /// <summary>
        /// Gets or Sets Subscriber
        /// </summary>
        [DataMember(Name="Subscriber", EmitDefaultValue=false)]
        public SCServiceChannelServicesMessagingSubscribersSubscriber Subscriber { get; set; }

        /// <summary>
        /// Gets or Sets Trade
        /// </summary>
        [DataMember(Name="Trade", EmitDefaultValue=false)]
        public SCServiceChannelServicesMessagingTradeTrade Trade { get; set; }

        /// <summary>
        /// Gets or Sets WorkOrder
        /// </summary>
        [DataMember(Name="WorkOrder", EmitDefaultValue=false)]
        public SCServiceChannelServicesMessagingWorkordersWorkOrder WorkOrder { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="Currency", EmitDefaultValue=false)]
        public SCServiceChannelServicesMessagingCurrenciesCurrency Currency { get; set; }

        /// <summary>
        /// Gets or Sets RFP
        /// </summary>
        [DataMember(Name="RFP", EmitDefaultValue=false)]
        public SCServiceChannelServicesMessagingRfpRfp RFP { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDateDto
        /// </summary>
        [DataMember(Name="CreatedDate_dto", EmitDefaultValue=false)]
        public DateTime CreatedDateDto { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="CreatedBy", EmitDefaultValue=false)]
        public SCServiceChannelServicesMessagingUsersUserInfo CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets SubmittedTo
        /// </summary>
        [DataMember(Name="SubmittedTo", EmitDefaultValue=false)]
        public string SubmittedTo { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public SCServiceChannelServicesMessagingProposalsProposalStatus Status { get; set; }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name="Attachments", EmitDefaultValue=false)]
        public List<SCServiceChannelServicesMessagingAttachmentsAttachment> Attachments { get; set; }

        /// <summary>
        /// Gets or Sets AssignedTo
        /// </summary>
        [DataMember(Name="AssignedTo", EmitDefaultValue=false)]
        public SCServiceChannelServicesMessagingUsersUserInfo AssignedTo { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledDate
        /// </summary>
        [DataMember(Name="ScheduledDate", EmitDefaultValue=false)]
        public DateTime ScheduledDate { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledDateDto
        /// </summary>
        [DataMember(Name="ScheduledDateDto", EmitDefaultValue=false)]
        public DateTime ScheduledDateDto { get; set; }

        /// <summary>
        /// Gets or Sets AmountCategories
        /// </summary>
        [DataMember(Name="AmountCategories", EmitDefaultValue=false)]
        public List<SCServiceChannelServicesMessagingProposalsProposalCategoryInfo> AmountCategories { get; set; }

        /// <summary>
        /// Updated Date
        /// </summary>
        /// <value>Updated Date</value>
        [DataMember(Name="UpdatedDate", EmitDefaultValue=false)]
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedDateDto
        /// </summary>
        [DataMember(Name="UpdatedDateDto", EmitDefaultValue=false)]
        public DateTime UpdatedDateDto { get; set; }

        /// <summary>
        /// Gets or Sets Recommendation
        /// </summary>
        [DataMember(Name="Recommendation", EmitDefaultValue=false)]
        public SCServiceChannelServicesMessagingProposalsProposalRecommendation Recommendation { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="Amount", EmitDefaultValue=true)]
        public double Amount { get; set; }

        /// <summary>
        /// Gets or Sets AssignedFromLevel
        /// </summary>
        [DataMember(Name="AssignedFromLevel", EmitDefaultValue=false)]
        public string AssignedFromLevel { get; set; }

        /// <summary>
        /// Gets or Sets AssignedToLevel
        /// </summary>
        [DataMember(Name="AssignedToLevel", EmitDefaultValue=false)]
        public string AssignedToLevel { get; set; }

        /// <summary>
        /// Gets or Sets LevelsEscalateTo
        /// </summary>
        [DataMember(Name="LevelsEscalateTo", EmitDefaultValue=false)]
        public List<SCServiceChannelServicesMessagingProposalsEscalateTo> LevelsEscalateTo { get; set; }

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="Actions", EmitDefaultValue=false)]
        public List<string> Actions { get; set; }

        /// <summary>
        /// Gets or Sets MlpRecommendations
        /// </summary>
        [DataMember(Name="MlpRecommendations", EmitDefaultValue=false)]
        public List<SCServiceChannelApiModelProposalsMlpRecommendation> MlpRecommendations { get; set; }

        /// <summary>
        /// Gets or Sets MlpRecommendation
        /// </summary>
        [DataMember(Name="MlpRecommendation", EmitDefaultValue=false)]
        public SCServiceChannelApiModelProposalsMlpRecommendation MlpRecommendation { get; set; }

        /// <summary>
        /// Gets or Sets CurrentProposalMlpRuleSetId
        /// </summary>
        [DataMember(Name="CurrentProposalMlpRuleSetId", EmitDefaultValue=true)]
        public int CurrentProposalMlpRuleSetId { get; set; }

        /// <summary>
        /// Gets or Sets CurrentProposalMlpRuleSetName
        /// </summary>
        [DataMember(Name="CurrentProposalMlpRuleSetName", EmitDefaultValue=false)]
        public string CurrentProposalMlpRuleSetName { get; set; }

        /// <summary>
        /// Gets or Sets CurrentProposalMlpLevelId
        /// </summary>
        [DataMember(Name="CurrentProposalMlpLevelId", EmitDefaultValue=true)]
        public int CurrentProposalMlpLevelId { get; set; }

        /// <summary>
        /// Gets or Sets CurrentProposalMlpLevelName
        /// </summary>
        [DataMember(Name="CurrentProposalMlpLevelName", EmitDefaultValue=false)]
        public string CurrentProposalMlpLevelName { get; set; }

        /// <summary>
        /// Gets or Sets PoNumber
        /// </summary>
        [DataMember(Name="PoNumber", EmitDefaultValue=false)]
        public string PoNumber { get; set; }

        /// <summary>
        /// Gets or Sets IsMlpLimitOverrun
        /// </summary>
        [DataMember(Name="IsMlpLimitOverrun", EmitDefaultValue=true)]
        public bool IsMlpLimitOverrun { get; set; } = false;

        /// <summary>
        /// Gets or Sets NextLevelEmpty
        /// </summary>
        [DataMember(Name="NextLevelEmpty", EmitDefaultValue=true)]
        public bool NextLevelEmpty { get; set; } = false;

        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="Project", EmitDefaultValue=false)]
        public SCServiceChannelApiModelProposalsProposalProjectSimpleModel Project { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingProposalsProposalInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Description2: ").Append(Description2).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Subscriber: ").Append(Subscriber).Append("\n");
            sb.Append("  Trade: ").Append(Trade).Append("\n");
            sb.Append("  WorkOrder: ").Append(WorkOrder).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  RFP: ").Append(RFP).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  CreatedDateDto: ").Append(CreatedDateDto).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  SubmittedTo: ").Append(SubmittedTo).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  AssignedTo: ").Append(AssignedTo).Append("\n");
            sb.Append("  ScheduledDate: ").Append(ScheduledDate).Append("\n");
            sb.Append("  ScheduledDateDto: ").Append(ScheduledDateDto).Append("\n");
            sb.Append("  AmountCategories: ").Append(AmountCategories).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
            sb.Append("  UpdatedDateDto: ").Append(UpdatedDateDto).Append("\n");
            sb.Append("  Recommendation: ").Append(Recommendation).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  AssignedFromLevel: ").Append(AssignedFromLevel).Append("\n");
            sb.Append("  AssignedToLevel: ").Append(AssignedToLevel).Append("\n");
            sb.Append("  LevelsEscalateTo: ").Append(LevelsEscalateTo).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  MlpRecommendations: ").Append(MlpRecommendations).Append("\n");
            sb.Append("  MlpRecommendation: ").Append(MlpRecommendation).Append("\n");
            sb.Append("  CurrentProposalMlpRuleSetId: ").Append(CurrentProposalMlpRuleSetId).Append("\n");
            sb.Append("  CurrentProposalMlpRuleSetName: ").Append(CurrentProposalMlpRuleSetName).Append("\n");
            sb.Append("  CurrentProposalMlpLevelId: ").Append(CurrentProposalMlpLevelId).Append("\n");
            sb.Append("  CurrentProposalMlpLevelName: ").Append(CurrentProposalMlpLevelName).Append("\n");
            sb.Append("  PoNumber: ").Append(PoNumber).Append("\n");
            sb.Append("  IsMlpLimitOverrun: ").Append(IsMlpLimitOverrun).Append("\n");
            sb.Append("  NextLevelEmpty: ").Append(NextLevelEmpty).Append("\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingProposalsProposalInfo)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingProposalsProposalInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingProposalsProposalInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingProposalsProposalInfo other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    Number == other.Number ||
                    Number != null &&
                    Number.Equals(other.Number)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    Description2 == other.Description2 ||
                    Description2 != null &&
                    Description2.Equals(other.Description2)
                ) && 
                (
                    Comments == other.Comments ||
                    Comments != null &&
                    Comments.Equals(other.Comments)
                ) && 
                (
                    Location == other.Location ||
                    Location != null &&
                    Location.Equals(other.Location)
                ) && 
                (
                    Provider == other.Provider ||
                    Provider != null &&
                    Provider.Equals(other.Provider)
                ) && 
                (
                    Subscriber == other.Subscriber ||
                    Subscriber != null &&
                    Subscriber.Equals(other.Subscriber)
                ) && 
                (
                    Trade == other.Trade ||
                    Trade != null &&
                    Trade.Equals(other.Trade)
                ) && 
                (
                    WorkOrder == other.WorkOrder ||
                    WorkOrder != null &&
                    WorkOrder.Equals(other.WorkOrder)
                ) && 
                (
                    Currency == other.Currency ||
                    Currency != null &&
                    Currency.Equals(other.Currency)
                ) && 
                (
                    RFP == other.RFP ||
                    RFP != null &&
                    RFP.Equals(other.RFP)
                ) && 
                (
                    CreatedDate == other.CreatedDate ||
                    CreatedDate != null &&
                    CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    CreatedDateDto == other.CreatedDateDto ||
                    CreatedDateDto != null &&
                    CreatedDateDto.Equals(other.CreatedDateDto)
                ) && 
                (
                    CreatedBy == other.CreatedBy ||
                    CreatedBy != null &&
                    CreatedBy.Equals(other.CreatedBy)
                ) && 
                (
                    SubmittedTo == other.SubmittedTo ||
                    SubmittedTo != null &&
                    SubmittedTo.Equals(other.SubmittedTo)
                ) && 
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
                ) && 
                (
                    Attachments == other.Attachments ||
                    Attachments != null &&
                    other.Attachments != null &&
                    Attachments.SequenceEqual(other.Attachments)
                ) && 
                (
                    AssignedTo == other.AssignedTo ||
                    AssignedTo != null &&
                    AssignedTo.Equals(other.AssignedTo)
                ) && 
                (
                    ScheduledDate == other.ScheduledDate ||
                    ScheduledDate != null &&
                    ScheduledDate.Equals(other.ScheduledDate)
                ) && 
                (
                    ScheduledDateDto == other.ScheduledDateDto ||
                    ScheduledDateDto != null &&
                    ScheduledDateDto.Equals(other.ScheduledDateDto)
                ) && 
                (
                    AmountCategories == other.AmountCategories ||
                    AmountCategories != null &&
                    other.AmountCategories != null &&
                    AmountCategories.SequenceEqual(other.AmountCategories)
                ) && 
                (
                    UpdatedDate == other.UpdatedDate ||
                    UpdatedDate != null &&
                    UpdatedDate.Equals(other.UpdatedDate)
                ) && 
                (
                    UpdatedDateDto == other.UpdatedDateDto ||
                    UpdatedDateDto != null &&
                    UpdatedDateDto.Equals(other.UpdatedDateDto)
                ) && 
                (
                    Recommendation == other.Recommendation ||
                    Recommendation != null &&
                    Recommendation.Equals(other.Recommendation)
                ) && 
                (
                    Amount == other.Amount ||
                    
                    Amount.Equals(other.Amount)
                ) && 
                (
                    AssignedFromLevel == other.AssignedFromLevel ||
                    AssignedFromLevel != null &&
                    AssignedFromLevel.Equals(other.AssignedFromLevel)
                ) && 
                (
                    AssignedToLevel == other.AssignedToLevel ||
                    AssignedToLevel != null &&
                    AssignedToLevel.Equals(other.AssignedToLevel)
                ) && 
                (
                    LevelsEscalateTo == other.LevelsEscalateTo ||
                    LevelsEscalateTo != null &&
                    other.LevelsEscalateTo != null &&
                    LevelsEscalateTo.SequenceEqual(other.LevelsEscalateTo)
                ) && 
                (
                    Actions == other.Actions ||
                    Actions != null &&
                    other.Actions != null &&
                    Actions.SequenceEqual(other.Actions)
                ) && 
                (
                    MlpRecommendations == other.MlpRecommendations ||
                    MlpRecommendations != null &&
                    other.MlpRecommendations != null &&
                    MlpRecommendations.SequenceEqual(other.MlpRecommendations)
                ) && 
                (
                    MlpRecommendation == other.MlpRecommendation ||
                    MlpRecommendation != null &&
                    MlpRecommendation.Equals(other.MlpRecommendation)
                ) && 
                (
                    CurrentProposalMlpRuleSetId == other.CurrentProposalMlpRuleSetId ||
                    
                    CurrentProposalMlpRuleSetId.Equals(other.CurrentProposalMlpRuleSetId)
                ) && 
                (
                    CurrentProposalMlpRuleSetName == other.CurrentProposalMlpRuleSetName ||
                    CurrentProposalMlpRuleSetName != null &&
                    CurrentProposalMlpRuleSetName.Equals(other.CurrentProposalMlpRuleSetName)
                ) && 
                (
                    CurrentProposalMlpLevelId == other.CurrentProposalMlpLevelId ||
                    
                    CurrentProposalMlpLevelId.Equals(other.CurrentProposalMlpLevelId)
                ) && 
                (
                    CurrentProposalMlpLevelName == other.CurrentProposalMlpLevelName ||
                    CurrentProposalMlpLevelName != null &&
                    CurrentProposalMlpLevelName.Equals(other.CurrentProposalMlpLevelName)
                ) && 
                (
                    PoNumber == other.PoNumber ||
                    PoNumber != null &&
                    PoNumber.Equals(other.PoNumber)
                ) && 
                (
                    IsMlpLimitOverrun == other.IsMlpLimitOverrun ||
                    
                    IsMlpLimitOverrun.Equals(other.IsMlpLimitOverrun)
                ) && 
                (
                    NextLevelEmpty == other.NextLevelEmpty ||
                    
                    NextLevelEmpty.Equals(other.NextLevelEmpty)
                ) && 
                (
                    Project == other.Project ||
                    Project != null &&
                    Project.Equals(other.Project)
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
                    if (Number != null)
                    hashCode = hashCode * 59 + Number.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (Description2 != null)
                    hashCode = hashCode * 59 + Description2.GetHashCode();
                    if (Comments != null)
                    hashCode = hashCode * 59 + Comments.GetHashCode();
                    if (Location != null)
                    hashCode = hashCode * 59 + Location.GetHashCode();
                    if (Provider != null)
                    hashCode = hashCode * 59 + Provider.GetHashCode();
                    if (Subscriber != null)
                    hashCode = hashCode * 59 + Subscriber.GetHashCode();
                    if (Trade != null)
                    hashCode = hashCode * 59 + Trade.GetHashCode();
                    if (WorkOrder != null)
                    hashCode = hashCode * 59 + WorkOrder.GetHashCode();
                    if (Currency != null)
                    hashCode = hashCode * 59 + Currency.GetHashCode();
                    if (RFP != null)
                    hashCode = hashCode * 59 + RFP.GetHashCode();
                    if (CreatedDate != null)
                    hashCode = hashCode * 59 + CreatedDate.GetHashCode();
                    if (CreatedDateDto != null)
                    hashCode = hashCode * 59 + CreatedDateDto.GetHashCode();
                    if (CreatedBy != null)
                    hashCode = hashCode * 59 + CreatedBy.GetHashCode();
                    if (SubmittedTo != null)
                    hashCode = hashCode * 59 + SubmittedTo.GetHashCode();
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (Attachments != null)
                    hashCode = hashCode * 59 + Attachments.GetHashCode();
                    if (AssignedTo != null)
                    hashCode = hashCode * 59 + AssignedTo.GetHashCode();
                    if (ScheduledDate != null)
                    hashCode = hashCode * 59 + ScheduledDate.GetHashCode();
                    if (ScheduledDateDto != null)
                    hashCode = hashCode * 59 + ScheduledDateDto.GetHashCode();
                    if (AmountCategories != null)
                    hashCode = hashCode * 59 + AmountCategories.GetHashCode();
                    if (UpdatedDate != null)
                    hashCode = hashCode * 59 + UpdatedDate.GetHashCode();
                    if (UpdatedDateDto != null)
                    hashCode = hashCode * 59 + UpdatedDateDto.GetHashCode();
                    if (Recommendation != null)
                    hashCode = hashCode * 59 + Recommendation.GetHashCode();
                    
                    hashCode = hashCode * 59 + Amount.GetHashCode();
                    if (AssignedFromLevel != null)
                    hashCode = hashCode * 59 + AssignedFromLevel.GetHashCode();
                    if (AssignedToLevel != null)
                    hashCode = hashCode * 59 + AssignedToLevel.GetHashCode();
                    if (LevelsEscalateTo != null)
                    hashCode = hashCode * 59 + LevelsEscalateTo.GetHashCode();
                    if (Actions != null)
                    hashCode = hashCode * 59 + Actions.GetHashCode();
                    if (MlpRecommendations != null)
                    hashCode = hashCode * 59 + MlpRecommendations.GetHashCode();
                    if (MlpRecommendation != null)
                    hashCode = hashCode * 59 + MlpRecommendation.GetHashCode();
                    
                    hashCode = hashCode * 59 + CurrentProposalMlpRuleSetId.GetHashCode();
                    if (CurrentProposalMlpRuleSetName != null)
                    hashCode = hashCode * 59 + CurrentProposalMlpRuleSetName.GetHashCode();
                    
                    hashCode = hashCode * 59 + CurrentProposalMlpLevelId.GetHashCode();
                    if (CurrentProposalMlpLevelName != null)
                    hashCode = hashCode * 59 + CurrentProposalMlpLevelName.GetHashCode();
                    if (PoNumber != null)
                    hashCode = hashCode * 59 + PoNumber.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsMlpLimitOverrun.GetHashCode();
                    
                    hashCode = hashCode * 59 + NextLevelEmpty.GetHashCode();
                    if (Project != null)
                    hashCode = hashCode * 59 + Project.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingProposalsProposalInfo left, SCServiceChannelServicesMessagingProposalsProposalInfo right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingProposalsProposalInfo left, SCServiceChannelServicesMessagingProposalsProposalInfo right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}