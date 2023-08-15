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
    public class SCServiceChannelServicesMessagingProposalsProposalRecommendation : IEquatable<SCServiceChannelServicesMessagingProposalsProposalRecommendation>
    {

        /// <summary>
        /// Gets or Sets RecommendationType
        /// </summary>
        
        public enum RecommendationTypeEnum
        {
            
            /// <summary>
            /// Enum NoneEnum for None
            /// </summary>
            [EnumMember(Value = "None")]
            NoneEnum = 1,
            
            /// <summary>
            /// Enum StrongApproveEnum for StrongApprove
            /// </summary>
            [EnumMember(Value = "StrongApprove")]
            StrongApproveEnum = 2,
            
            /// <summary>
            /// Enum ApproveEnum for Approve
            /// </summary>
            [EnumMember(Value = "Approve")]
            ApproveEnum = 3,
            
            /// <summary>
            /// Enum RejectEnum for Reject
            /// </summary>
            [EnumMember(Value = "Reject")]
            RejectEnum = 4,
            
            /// <summary>
            /// Enum StrongRejectEnum for StrongReject
            /// </summary>
            [EnumMember(Value = "StrongReject")]
            StrongRejectEnum = 5
        }

        /// <summary>
        /// Gets or Sets RecommendationType
        /// </summary>
        [DataMember(Name="RecommendationType", EmitDefaultValue=true)]
        public RecommendationTypeEnum RecommendationType { get; set; }

        /// <summary>
        /// Gets or Sets RecommendationAmounts
        /// </summary>
        [DataMember(Name="RecommendationAmounts", EmitDefaultValue=false)]
        public List<long> RecommendationAmounts { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="Currency", EmitDefaultValue=false)]
        public string Currency { get; set; }


        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        
        public enum ScoreEnum
        {
            
            /// <summary>
            /// Enum NoneEnum for None
            /// </summary>
            [EnumMember(Value = "None")]
            NoneEnum = 1,
            
            /// <summary>
            /// Enum APlusEnum for APlus
            /// </summary>
            [EnumMember(Value = "APlus")]
            APlusEnum = 2,
            
            /// <summary>
            /// Enum AEnum for A
            /// </summary>
            [EnumMember(Value = "A")]
            AEnum = 3,
            
            /// <summary>
            /// Enum BEnum for B
            /// </summary>
            [EnumMember(Value = "B")]
            BEnum = 4,
            
            /// <summary>
            /// Enum CEnum for C
            /// </summary>
            [EnumMember(Value = "C")]
            CEnum = 5,
            
            /// <summary>
            /// Enum DEnum for D
            /// </summary>
            [EnumMember(Value = "D")]
            DEnum = 6
        }

        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name="Score", EmitDefaultValue=true)]
        public ScoreEnum Score { get; set; }

        /// <summary>
        /// Gets or Sets NegativeFeedbacksRecallsPercent
        /// </summary>
        [DataMember(Name="NegativeFeedbacksRecallsPercent", EmitDefaultValue=true)]
        public double NegativeFeedbacksRecallsPercent { get; set; }

        /// <summary>
        /// Gets or Sets ProviderCompliancePercent
        /// </summary>
        [DataMember(Name="ProviderCompliancePercent", EmitDefaultValue=true)]
        public double ProviderCompliancePercent { get; set; }

        /// <summary>
        /// Gets or Sets ProposalId
        /// </summary>
        [DataMember(Name="ProposalId", EmitDefaultValue=true)]
        public int ProposalId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingProposalsProposalRecommendation {\n");
            sb.Append("  RecommendationType: ").Append(RecommendationType).Append("\n");
            sb.Append("  RecommendationAmounts: ").Append(RecommendationAmounts).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  NegativeFeedbacksRecallsPercent: ").Append(NegativeFeedbacksRecallsPercent).Append("\n");
            sb.Append("  ProviderCompliancePercent: ").Append(ProviderCompliancePercent).Append("\n");
            sb.Append("  ProposalId: ").Append(ProposalId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingProposalsProposalRecommendation)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingProposalsProposalRecommendation instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingProposalsProposalRecommendation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingProposalsProposalRecommendation other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    RecommendationType == other.RecommendationType ||
                    
                    RecommendationType.Equals(other.RecommendationType)
                ) && 
                (
                    RecommendationAmounts == other.RecommendationAmounts ||
                    RecommendationAmounts != null &&
                    other.RecommendationAmounts != null &&
                    RecommendationAmounts.SequenceEqual(other.RecommendationAmounts)
                ) && 
                (
                    Currency == other.Currency ||
                    Currency != null &&
                    Currency.Equals(other.Currency)
                ) && 
                (
                    Score == other.Score ||
                    
                    Score.Equals(other.Score)
                ) && 
                (
                    NegativeFeedbacksRecallsPercent == other.NegativeFeedbacksRecallsPercent ||
                    
                    NegativeFeedbacksRecallsPercent.Equals(other.NegativeFeedbacksRecallsPercent)
                ) && 
                (
                    ProviderCompliancePercent == other.ProviderCompliancePercent ||
                    
                    ProviderCompliancePercent.Equals(other.ProviderCompliancePercent)
                ) && 
                (
                    ProposalId == other.ProposalId ||
                    
                    ProposalId.Equals(other.ProposalId)
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
                    
                    hashCode = hashCode * 59 + RecommendationType.GetHashCode();
                    if (RecommendationAmounts != null)
                    hashCode = hashCode * 59 + RecommendationAmounts.GetHashCode();
                    if (Currency != null)
                    hashCode = hashCode * 59 + Currency.GetHashCode();
                    
                    hashCode = hashCode * 59 + Score.GetHashCode();
                    
                    hashCode = hashCode * 59 + NegativeFeedbacksRecallsPercent.GetHashCode();
                    
                    hashCode = hashCode * 59 + ProviderCompliancePercent.GetHashCode();
                    
                    hashCode = hashCode * 59 + ProposalId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingProposalsProposalRecommendation left, SCServiceChannelServicesMessagingProposalsProposalRecommendation right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingProposalsProposalRecommendation left, SCServiceChannelServicesMessagingProposalsProposalRecommendation right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}