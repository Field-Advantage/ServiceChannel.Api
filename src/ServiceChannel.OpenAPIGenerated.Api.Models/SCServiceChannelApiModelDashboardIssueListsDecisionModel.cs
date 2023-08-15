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
    public class SCServiceChannelApiModelDashboardIssueListsDecisionModel : IEquatable<SCServiceChannelApiModelDashboardIssueListsDecisionModel>
    {
        /// <summary>
        /// Gets or Sets OptionValue
        /// </summary>
        [DataMember(Name="OptionValue", EmitDefaultValue=false)]
        public string OptionValue { get; set; }

        /// <summary>
        /// Gets or Sets NextQuestion
        /// </summary>
        [DataMember(Name="NextQuestion", EmitDefaultValue=false)]
        public string NextQuestion { get; set; }

        /// <summary>
        /// Gets or Sets TradeOverride
        /// </summary>
        [DataMember(Name="TradeOverride", EmitDefaultValue=false)]
        public string TradeOverride { get; set; }

        /// <summary>
        /// Gets or Sets CategoryOverride
        /// </summary>
        [DataMember(Name="CategoryOverride", EmitDefaultValue=false)]
        public string CategoryOverride { get; set; }

        /// <summary>
        /// Gets or Sets PriorityOverride
        /// </summary>
        [DataMember(Name="PriorityOverride", EmitDefaultValue=false)]
        public string PriorityOverride { get; set; }

        /// <summary>
        /// Gets or Sets NTEOverride
        /// </summary>
        [DataMember(Name="NTEOverride", EmitDefaultValue=false)]
        public string NTEOverride { get; set; }

        /// <summary>
        /// Gets or Sets ProviderRankOverride
        /// </summary>
        [DataMember(Name="ProviderRankOverride", EmitDefaultValue=false)]
        public string ProviderRankOverride { get; set; }

        /// <summary>
        /// Gets or Sets WoLabelOverride
        /// </summary>
        [DataMember(Name="WoLabelOverride", EmitDefaultValue=false)]
        public string WoLabelOverride { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelApiModelDashboardIssueListsDecisionModel {\n");
            sb.Append("  OptionValue: ").Append(OptionValue).Append("\n");
            sb.Append("  NextQuestion: ").Append(NextQuestion).Append("\n");
            sb.Append("  TradeOverride: ").Append(TradeOverride).Append("\n");
            sb.Append("  CategoryOverride: ").Append(CategoryOverride).Append("\n");
            sb.Append("  PriorityOverride: ").Append(PriorityOverride).Append("\n");
            sb.Append("  NTEOverride: ").Append(NTEOverride).Append("\n");
            sb.Append("  ProviderRankOverride: ").Append(ProviderRankOverride).Append("\n");
            sb.Append("  WoLabelOverride: ").Append(WoLabelOverride).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelApiModelDashboardIssueListsDecisionModel)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelApiModelDashboardIssueListsDecisionModel instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelApiModelDashboardIssueListsDecisionModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelApiModelDashboardIssueListsDecisionModel other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    OptionValue == other.OptionValue ||
                    OptionValue != null &&
                    OptionValue.Equals(other.OptionValue)
                ) && 
                (
                    NextQuestion == other.NextQuestion ||
                    NextQuestion != null &&
                    NextQuestion.Equals(other.NextQuestion)
                ) && 
                (
                    TradeOverride == other.TradeOverride ||
                    TradeOverride != null &&
                    TradeOverride.Equals(other.TradeOverride)
                ) && 
                (
                    CategoryOverride == other.CategoryOverride ||
                    CategoryOverride != null &&
                    CategoryOverride.Equals(other.CategoryOverride)
                ) && 
                (
                    PriorityOverride == other.PriorityOverride ||
                    PriorityOverride != null &&
                    PriorityOverride.Equals(other.PriorityOverride)
                ) && 
                (
                    NTEOverride == other.NTEOverride ||
                    NTEOverride != null &&
                    NTEOverride.Equals(other.NTEOverride)
                ) && 
                (
                    ProviderRankOverride == other.ProviderRankOverride ||
                    ProviderRankOverride != null &&
                    ProviderRankOverride.Equals(other.ProviderRankOverride)
                ) && 
                (
                    WoLabelOverride == other.WoLabelOverride ||
                    WoLabelOverride != null &&
                    WoLabelOverride.Equals(other.WoLabelOverride)
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
                    if (OptionValue != null)
                    hashCode = hashCode * 59 + OptionValue.GetHashCode();
                    if (NextQuestion != null)
                    hashCode = hashCode * 59 + NextQuestion.GetHashCode();
                    if (TradeOverride != null)
                    hashCode = hashCode * 59 + TradeOverride.GetHashCode();
                    if (CategoryOverride != null)
                    hashCode = hashCode * 59 + CategoryOverride.GetHashCode();
                    if (PriorityOverride != null)
                    hashCode = hashCode * 59 + PriorityOverride.GetHashCode();
                    if (NTEOverride != null)
                    hashCode = hashCode * 59 + NTEOverride.GetHashCode();
                    if (ProviderRankOverride != null)
                    hashCode = hashCode * 59 + ProviderRankOverride.GetHashCode();
                    if (WoLabelOverride != null)
                    hashCode = hashCode * 59 + WoLabelOverride.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelApiModelDashboardIssueListsDecisionModel left, SCServiceChannelApiModelDashboardIssueListsDecisionModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelApiModelDashboardIssueListsDecisionModel left, SCServiceChannelApiModelDashboardIssueListsDecisionModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}