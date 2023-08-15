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
    /// SCServiceChannelApiModelProposalsMlpRuleAction
    /// </summary>
    [DataContract(Name = "ServiceChannel.Api.Model.Proposals.MlpRuleAction")]
    public partial class SCServiceChannelApiModelProposalsMlpRuleAction : IEquatable<SCServiceChannelApiModelProposalsMlpRuleAction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelApiModelProposalsMlpRuleAction" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="limit">limit.</param>
        /// <param name="forwardTo">forwardTo.</param>
        /// <param name="forwardToLevelName">forwardToLevelName.</param>
        /// <param name="endStatus">endStatus.</param>
        /// <param name="autoEscalateInDays">autoEscalateInDays.</param>
        /// <param name="entryLevel">entryLevel (default to false).</param>
        /// <param name="codeChange">codeChange (default to false).</param>
        /// <param name="categoryChange">categoryChange (default to false).</param>
        /// <param name="levelId">levelId.</param>
        /// <param name="levelName">levelName.</param>
        /// <param name="ruleNumber">ruleNumber.</param>
        /// <param name="ruleOrder">ruleOrder.</param>
        /// <param name="id">id.</param>
        /// <param name="ruleSetId">ruleSetId.</param>
        /// <param name="_override">_override (default to false).</param>
        /// <param name="skipOverLimit">skipOverLimit (default to false).</param>
        /// <param name="actionNotification">actionNotification (default to false).</param>
        /// <param name="locationId">locationId.</param>
        /// <param name="userId">userId.</param>
        public SCServiceChannelApiModelProposalsMlpRuleAction(string name = default(string), double limit = default(double), int forwardTo = default(int), string forwardToLevelName = default(string), string endStatus = default(string), int autoEscalateInDays = default(int), bool entryLevel = false, bool codeChange = false, bool categoryChange = false, int levelId = default(int), string levelName = default(string), int ruleNumber = default(int), int ruleOrder = default(int), int id = default(int), int ruleSetId = default(int), bool _override = false, bool skipOverLimit = false, bool actionNotification = false, int locationId = default(int), int userId = default(int))
        {
            this.Name = name;
            this.Limit = limit;
            this.ForwardTo = forwardTo;
            this.ForwardToLevelName = forwardToLevelName;
            this.EndStatus = endStatus;
            this.AutoEscalateInDays = autoEscalateInDays;
            this.EntryLevel = entryLevel;
            this.CodeChange = codeChange;
            this.CategoryChange = categoryChange;
            this.LevelId = levelId;
            this.LevelName = levelName;
            this.RuleNumber = ruleNumber;
            this.RuleOrder = ruleOrder;
            this.Id = id;
            this.RuleSetId = ruleSetId;
            this.Override = _override;
            this.SkipOverLimit = skipOverLimit;
            this.ActionNotification = actionNotification;
            this.LocationId = locationId;
            this.UserId = userId;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name = "Limit", EmitDefaultValue = false)]
        public double Limit { get; set; }

        /// <summary>
        /// Gets or Sets ForwardTo
        /// </summary>
        [DataMember(Name = "ForwardTo", EmitDefaultValue = false)]
        public int ForwardTo { get; set; }

        /// <summary>
        /// Gets or Sets ForwardToLevelName
        /// </summary>
        [DataMember(Name = "ForwardToLevelName", EmitDefaultValue = false)]
        public string ForwardToLevelName { get; set; }

        /// <summary>
        /// Gets or Sets EndStatus
        /// </summary>
        [DataMember(Name = "EndStatus", EmitDefaultValue = false)]
        public string EndStatus { get; set; }

        /// <summary>
        /// Gets or Sets AutoEscalateInDays
        /// </summary>
        [DataMember(Name = "AutoEscalateInDays", EmitDefaultValue = false)]
        public int AutoEscalateInDays { get; set; }

        /// <summary>
        /// Gets or Sets EntryLevel
        /// </summary>
        [DataMember(Name = "EntryLevel", EmitDefaultValue = true)]
        public bool EntryLevel { get; set; }

        /// <summary>
        /// Gets or Sets CodeChange
        /// </summary>
        [DataMember(Name = "CodeChange", EmitDefaultValue = true)]
        public bool CodeChange { get; set; }

        /// <summary>
        /// Gets or Sets CategoryChange
        /// </summary>
        [DataMember(Name = "CategoryChange", EmitDefaultValue = true)]
        public bool CategoryChange { get; set; }

        /// <summary>
        /// Gets or Sets LevelId
        /// </summary>
        [DataMember(Name = "LevelId", EmitDefaultValue = false)]
        public int LevelId { get; set; }

        /// <summary>
        /// Gets or Sets LevelName
        /// </summary>
        [DataMember(Name = "LevelName", EmitDefaultValue = false)]
        public string LevelName { get; set; }

        /// <summary>
        /// Gets or Sets RuleNumber
        /// </summary>
        [DataMember(Name = "RuleNumber", EmitDefaultValue = false)]
        public int RuleNumber { get; set; }

        /// <summary>
        /// Gets or Sets RuleOrder
        /// </summary>
        [DataMember(Name = "RuleOrder", EmitDefaultValue = false)]
        public int RuleOrder { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets RuleSetId
        /// </summary>
        [DataMember(Name = "RuleSetId", EmitDefaultValue = false)]
        public int RuleSetId { get; set; }

        /// <summary>
        /// Gets or Sets Override
        /// </summary>
        [DataMember(Name = "Override", EmitDefaultValue = true)]
        public bool Override { get; set; }

        /// <summary>
        /// Gets or Sets SkipOverLimit
        /// </summary>
        [DataMember(Name = "SkipOverLimit", EmitDefaultValue = true)]
        public bool SkipOverLimit { get; set; }

        /// <summary>
        /// Gets or Sets ActionNotification
        /// </summary>
        [DataMember(Name = "ActionNotification", EmitDefaultValue = true)]
        public bool ActionNotification { get; set; }

        /// <summary>
        /// Gets or Sets LocationId
        /// </summary>
        [DataMember(Name = "LocationId", EmitDefaultValue = false)]
        public int LocationId { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "UserId", EmitDefaultValue = false)]
        public int UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelApiModelProposalsMlpRuleAction {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  ForwardTo: ").Append(ForwardTo).Append("\n");
            sb.Append("  ForwardToLevelName: ").Append(ForwardToLevelName).Append("\n");
            sb.Append("  EndStatus: ").Append(EndStatus).Append("\n");
            sb.Append("  AutoEscalateInDays: ").Append(AutoEscalateInDays).Append("\n");
            sb.Append("  EntryLevel: ").Append(EntryLevel).Append("\n");
            sb.Append("  CodeChange: ").Append(CodeChange).Append("\n");
            sb.Append("  CategoryChange: ").Append(CategoryChange).Append("\n");
            sb.Append("  LevelId: ").Append(LevelId).Append("\n");
            sb.Append("  LevelName: ").Append(LevelName).Append("\n");
            sb.Append("  RuleNumber: ").Append(RuleNumber).Append("\n");
            sb.Append("  RuleOrder: ").Append(RuleOrder).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RuleSetId: ").Append(RuleSetId).Append("\n");
            sb.Append("  Override: ").Append(Override).Append("\n");
            sb.Append("  SkipOverLimit: ").Append(SkipOverLimit).Append("\n");
            sb.Append("  ActionNotification: ").Append(ActionNotification).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as SCServiceChannelApiModelProposalsMlpRuleAction);
        }

        /// <summary>
        /// Returns true if SCServiceChannelApiModelProposalsMlpRuleAction instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelApiModelProposalsMlpRuleAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelApiModelProposalsMlpRuleAction input)
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
                    this.Limit == input.Limit ||
                    this.Limit.Equals(input.Limit)
                ) && 
                (
                    this.ForwardTo == input.ForwardTo ||
                    this.ForwardTo.Equals(input.ForwardTo)
                ) && 
                (
                    this.ForwardToLevelName == input.ForwardToLevelName ||
                    (this.ForwardToLevelName != null &&
                    this.ForwardToLevelName.Equals(input.ForwardToLevelName))
                ) && 
                (
                    this.EndStatus == input.EndStatus ||
                    (this.EndStatus != null &&
                    this.EndStatus.Equals(input.EndStatus))
                ) && 
                (
                    this.AutoEscalateInDays == input.AutoEscalateInDays ||
                    this.AutoEscalateInDays.Equals(input.AutoEscalateInDays)
                ) && 
                (
                    this.EntryLevel == input.EntryLevel ||
                    this.EntryLevel.Equals(input.EntryLevel)
                ) && 
                (
                    this.CodeChange == input.CodeChange ||
                    this.CodeChange.Equals(input.CodeChange)
                ) && 
                (
                    this.CategoryChange == input.CategoryChange ||
                    this.CategoryChange.Equals(input.CategoryChange)
                ) && 
                (
                    this.LevelId == input.LevelId ||
                    this.LevelId.Equals(input.LevelId)
                ) && 
                (
                    this.LevelName == input.LevelName ||
                    (this.LevelName != null &&
                    this.LevelName.Equals(input.LevelName))
                ) && 
                (
                    this.RuleNumber == input.RuleNumber ||
                    this.RuleNumber.Equals(input.RuleNumber)
                ) && 
                (
                    this.RuleOrder == input.RuleOrder ||
                    this.RuleOrder.Equals(input.RuleOrder)
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.RuleSetId == input.RuleSetId ||
                    this.RuleSetId.Equals(input.RuleSetId)
                ) && 
                (
                    this.Override == input.Override ||
                    this.Override.Equals(input.Override)
                ) && 
                (
                    this.SkipOverLimit == input.SkipOverLimit ||
                    this.SkipOverLimit.Equals(input.SkipOverLimit)
                ) && 
                (
                    this.ActionNotification == input.ActionNotification ||
                    this.ActionNotification.Equals(input.ActionNotification)
                ) && 
                (
                    this.LocationId == input.LocationId ||
                    this.LocationId.Equals(input.LocationId)
                ) && 
                (
                    this.UserId == input.UserId ||
                    this.UserId.Equals(input.UserId)
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
                hashCode = (hashCode * 59) + this.Limit.GetHashCode();
                hashCode = (hashCode * 59) + this.ForwardTo.GetHashCode();
                if (this.ForwardToLevelName != null)
                {
                    hashCode = (hashCode * 59) + this.ForwardToLevelName.GetHashCode();
                }
                if (this.EndStatus != null)
                {
                    hashCode = (hashCode * 59) + this.EndStatus.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AutoEscalateInDays.GetHashCode();
                hashCode = (hashCode * 59) + this.EntryLevel.GetHashCode();
                hashCode = (hashCode * 59) + this.CodeChange.GetHashCode();
                hashCode = (hashCode * 59) + this.CategoryChange.GetHashCode();
                hashCode = (hashCode * 59) + this.LevelId.GetHashCode();
                if (this.LevelName != null)
                {
                    hashCode = (hashCode * 59) + this.LevelName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RuleNumber.GetHashCode();
                hashCode = (hashCode * 59) + this.RuleOrder.GetHashCode();
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                hashCode = (hashCode * 59) + this.RuleSetId.GetHashCode();
                hashCode = (hashCode * 59) + this.Override.GetHashCode();
                hashCode = (hashCode * 59) + this.SkipOverLimit.GetHashCode();
                hashCode = (hashCode * 59) + this.ActionNotification.GetHashCode();
                hashCode = (hashCode * 59) + this.LocationId.GetHashCode();
                hashCode = (hashCode * 59) + this.UserId.GetHashCode();
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