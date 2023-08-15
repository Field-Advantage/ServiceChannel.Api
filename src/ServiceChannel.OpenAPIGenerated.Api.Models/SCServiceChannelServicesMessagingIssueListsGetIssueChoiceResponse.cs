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
    public class SCServiceChannelServicesMessagingIssueListsGetIssueChoiceResponse : IEquatable<SCServiceChannelServicesMessagingIssueListsGetIssueChoiceResponse>
    {
        /// <summary>
        /// Gets or Sets ProblemType
        /// </summary>
        [DataMember(Name="ProblemType", EmitDefaultValue=false)]
        public string ProblemType { get; set; }

        /// <summary>
        /// Gets or Sets EquipmentType
        /// </summary>
        [DataMember(Name="EquipmentType", EmitDefaultValue=false)]
        public string EquipmentType { get; set; }

        /// <summary>
        /// Gets or Sets ProblemCode
        /// </summary>
        [DataMember(Name="ProblemCode", EmitDefaultValue=false)]
        public string ProblemCode { get; set; }

        /// <summary>
        /// Gets or Sets Trade
        /// </summary>
        [DataMember(Name="Trade", EmitDefaultValue=false)]
        public string Trade { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name="Priority", EmitDefaultValue=false)]
        public string Priority { get; set; }

        /// <summary>
        /// Gets or Sets RequireAttachment
        /// </summary>
        [DataMember(Name="RequireAttachment", EmitDefaultValue=true)]
        public bool RequireAttachment { get; set; } = false;

        /// <summary>
        /// Gets or Sets EquipmentId
        /// </summary>
        [DataMember(Name="EquipmentId", EmitDefaultValue=false)]
        public string EquipmentId { get; set; }

        /// <summary>
        /// Gets or Sets EquipmentEntry
        /// </summary>
        [DataMember(Name="EquipmentEntry", EmitDefaultValue=false)]
        public string EquipmentEntry { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="Category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="Comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets TroubleshootingMessage
        /// </summary>
        [DataMember(Name="TroubleshootingMessage", EmitDefaultValue=false)]
        public string TroubleshootingMessage { get; set; }

        /// <summary>
        /// Gets or Sets ProviderRank
        /// </summary>
        [DataMember(Name="ProviderRank", EmitDefaultValue=true)]
        public int ProviderRank { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="Currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets ApprovalCode
        /// </summary>
        [DataMember(Name="ApprovalCode", EmitDefaultValue=false)]
        public string ApprovalCode { get; set; }

        /// <summary>
        /// Gets or Sets LinkToMedia
        /// </summary>
        [DataMember(Name="LinkToMedia", EmitDefaultValue=false)]
        public string LinkToMedia { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalFields
        /// </summary>
        [DataMember(Name="AdditionalFields", EmitDefaultValue=false)]
        public List<SCServiceChannelServicesMessagingIssueListsIssueFieldResponse> AdditionalFields { get; set; }

        /// <summary>
        /// Gets or Sets AllAdditionalFields
        /// </summary>
        [DataMember(Name="AllAdditionalFields", EmitDefaultValue=false)]
        public List<SCServiceChannelServicesMessagingIssueListsIssueFieldResponse> AllAdditionalFields { get; set; }

        /// <summary>
        /// Gets or Sets IsNewIssueList
        /// </summary>
        [DataMember(Name="IsNewIssueList", EmitDefaultValue=true)]
        public bool IsNewIssueList { get; set; } = false;

        /// <summary>
        /// Gets or Sets DashOverrideApplied
        /// </summary>
        [DataMember(Name="DashOverrideApplied", EmitDefaultValue=true)]
        public bool DashOverrideApplied { get; set; } = false;

        /// <summary>
        /// Gets or Sets Nte
        /// </summary>
        [DataMember(Name="Nte", EmitDefaultValue=false)]
        public string Nte { get; set; }

        /// <summary>
        /// Gets or Sets WoLabel
        /// </summary>
        [DataMember(Name="WoLabel", EmitDefaultValue=false)]
        public string WoLabel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingIssueListsGetIssueChoiceResponse {\n");
            sb.Append("  ProblemType: ").Append(ProblemType).Append("\n");
            sb.Append("  EquipmentType: ").Append(EquipmentType).Append("\n");
            sb.Append("  ProblemCode: ").Append(ProblemCode).Append("\n");
            sb.Append("  Trade: ").Append(Trade).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  RequireAttachment: ").Append(RequireAttachment).Append("\n");
            sb.Append("  EquipmentId: ").Append(EquipmentId).Append("\n");
            sb.Append("  EquipmentEntry: ").Append(EquipmentEntry).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  TroubleshootingMessage: ").Append(TroubleshootingMessage).Append("\n");
            sb.Append("  ProviderRank: ").Append(ProviderRank).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  ApprovalCode: ").Append(ApprovalCode).Append("\n");
            sb.Append("  LinkToMedia: ").Append(LinkToMedia).Append("\n");
            sb.Append("  AdditionalFields: ").Append(AdditionalFields).Append("\n");
            sb.Append("  AllAdditionalFields: ").Append(AllAdditionalFields).Append("\n");
            sb.Append("  IsNewIssueList: ").Append(IsNewIssueList).Append("\n");
            sb.Append("  DashOverrideApplied: ").Append(DashOverrideApplied).Append("\n");
            sb.Append("  Nte: ").Append(Nte).Append("\n");
            sb.Append("  WoLabel: ").Append(WoLabel).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingIssueListsGetIssueChoiceResponse)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingIssueListsGetIssueChoiceResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingIssueListsGetIssueChoiceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingIssueListsGetIssueChoiceResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ProblemType == other.ProblemType ||
                    ProblemType != null &&
                    ProblemType.Equals(other.ProblemType)
                ) && 
                (
                    EquipmentType == other.EquipmentType ||
                    EquipmentType != null &&
                    EquipmentType.Equals(other.EquipmentType)
                ) && 
                (
                    ProblemCode == other.ProblemCode ||
                    ProblemCode != null &&
                    ProblemCode.Equals(other.ProblemCode)
                ) && 
                (
                    Trade == other.Trade ||
                    Trade != null &&
                    Trade.Equals(other.Trade)
                ) && 
                (
                    Priority == other.Priority ||
                    Priority != null &&
                    Priority.Equals(other.Priority)
                ) && 
                (
                    RequireAttachment == other.RequireAttachment ||
                    
                    RequireAttachment.Equals(other.RequireAttachment)
                ) && 
                (
                    EquipmentId == other.EquipmentId ||
                    EquipmentId != null &&
                    EquipmentId.Equals(other.EquipmentId)
                ) && 
                (
                    EquipmentEntry == other.EquipmentEntry ||
                    EquipmentEntry != null &&
                    EquipmentEntry.Equals(other.EquipmentEntry)
                ) && 
                (
                    Category == other.Category ||
                    Category != null &&
                    Category.Equals(other.Category)
                ) && 
                (
                    Comments == other.Comments ||
                    Comments != null &&
                    Comments.Equals(other.Comments)
                ) && 
                (
                    TroubleshootingMessage == other.TroubleshootingMessage ||
                    TroubleshootingMessage != null &&
                    TroubleshootingMessage.Equals(other.TroubleshootingMessage)
                ) && 
                (
                    ProviderRank == other.ProviderRank ||
                    
                    ProviderRank.Equals(other.ProviderRank)
                ) && 
                (
                    Currency == other.Currency ||
                    Currency != null &&
                    Currency.Equals(other.Currency)
                ) && 
                (
                    ApprovalCode == other.ApprovalCode ||
                    ApprovalCode != null &&
                    ApprovalCode.Equals(other.ApprovalCode)
                ) && 
                (
                    LinkToMedia == other.LinkToMedia ||
                    LinkToMedia != null &&
                    LinkToMedia.Equals(other.LinkToMedia)
                ) && 
                (
                    AdditionalFields == other.AdditionalFields ||
                    AdditionalFields != null &&
                    other.AdditionalFields != null &&
                    AdditionalFields.SequenceEqual(other.AdditionalFields)
                ) && 
                (
                    AllAdditionalFields == other.AllAdditionalFields ||
                    AllAdditionalFields != null &&
                    other.AllAdditionalFields != null &&
                    AllAdditionalFields.SequenceEqual(other.AllAdditionalFields)
                ) && 
                (
                    IsNewIssueList == other.IsNewIssueList ||
                    
                    IsNewIssueList.Equals(other.IsNewIssueList)
                ) && 
                (
                    DashOverrideApplied == other.DashOverrideApplied ||
                    
                    DashOverrideApplied.Equals(other.DashOverrideApplied)
                ) && 
                (
                    Nte == other.Nte ||
                    Nte != null &&
                    Nte.Equals(other.Nte)
                ) && 
                (
                    WoLabel == other.WoLabel ||
                    WoLabel != null &&
                    WoLabel.Equals(other.WoLabel)
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
                    if (ProblemType != null)
                    hashCode = hashCode * 59 + ProblemType.GetHashCode();
                    if (EquipmentType != null)
                    hashCode = hashCode * 59 + EquipmentType.GetHashCode();
                    if (ProblemCode != null)
                    hashCode = hashCode * 59 + ProblemCode.GetHashCode();
                    if (Trade != null)
                    hashCode = hashCode * 59 + Trade.GetHashCode();
                    if (Priority != null)
                    hashCode = hashCode * 59 + Priority.GetHashCode();
                    
                    hashCode = hashCode * 59 + RequireAttachment.GetHashCode();
                    if (EquipmentId != null)
                    hashCode = hashCode * 59 + EquipmentId.GetHashCode();
                    if (EquipmentEntry != null)
                    hashCode = hashCode * 59 + EquipmentEntry.GetHashCode();
                    if (Category != null)
                    hashCode = hashCode * 59 + Category.GetHashCode();
                    if (Comments != null)
                    hashCode = hashCode * 59 + Comments.GetHashCode();
                    if (TroubleshootingMessage != null)
                    hashCode = hashCode * 59 + TroubleshootingMessage.GetHashCode();
                    
                    hashCode = hashCode * 59 + ProviderRank.GetHashCode();
                    if (Currency != null)
                    hashCode = hashCode * 59 + Currency.GetHashCode();
                    if (ApprovalCode != null)
                    hashCode = hashCode * 59 + ApprovalCode.GetHashCode();
                    if (LinkToMedia != null)
                    hashCode = hashCode * 59 + LinkToMedia.GetHashCode();
                    if (AdditionalFields != null)
                    hashCode = hashCode * 59 + AdditionalFields.GetHashCode();
                    if (AllAdditionalFields != null)
                    hashCode = hashCode * 59 + AllAdditionalFields.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsNewIssueList.GetHashCode();
                    
                    hashCode = hashCode * 59 + DashOverrideApplied.GetHashCode();
                    if (Nte != null)
                    hashCode = hashCode * 59 + Nte.GetHashCode();
                    if (WoLabel != null)
                    hashCode = hashCode * 59 + WoLabel.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingIssueListsGetIssueChoiceResponse left, SCServiceChannelServicesMessagingIssueListsGetIssueChoiceResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingIssueListsGetIssueChoiceResponse left, SCServiceChannelServicesMessagingIssueListsGetIssueChoiceResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}