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
    public class SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoResponse : IEquatable<SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoResponse>
    {
        /// <summary>
        /// Gets or Sets IssueChoice
        /// </summary>
        [DataMember(Name="IssueChoice", EmitDefaultValue=false)]
        public SCServiceChannelServicesMessagingIssueListsGetIssueChoiceResponse IssueChoice { get; set; }

        /// <summary>
        /// Gets or Sets Providers
        /// </summary>
        [DataMember(Name="Providers", EmitDefaultValue=false)]
        public List<SCServiceChannelServicesMessagingProvidersServiceRequestProvider> Providers { get; set; }

        /// <summary>
        /// Gets or Sets ProvidersNotFoundMessage
        /// </summary>
        [DataMember(Name="ProvidersNotFoundMessage", EmitDefaultValue=false)]
        public string ProvidersNotFoundMessage { get; set; }

        /// <summary>
        /// Gets or Sets CallerName
        /// </summary>
        [DataMember(Name="CallerName", EmitDefaultValue=false)]
        public string CallerName { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledDateOffsetFromCallDate
        /// </summary>
        [DataMember(Name="ScheduledDateOffsetFromCallDate", EmitDefaultValue=true)]
        public long ScheduledDateOffsetFromCallDate { get; set; }

        /// <summary>
        /// Gets or Sets AssetsInfo
        /// </summary>
        [DataMember(Name="AssetsInfo", EmitDefaultValue=false)]
        public SCServiceChannelServicesMessagingAssetsAssetsInfoResponse AssetsInfo { get; set; }

        /// <summary>
        /// Gets or Sets SetupRequestConfirm
        /// </summary>
        [DataMember(Name="SetupRequestConfirm", EmitDefaultValue=false)]
        public SCServiceChannelServicesMessagingDashboardSettingsSetupRequestConfirmResponse SetupRequestConfirm { get; set; }

        /// <summary>
        /// Gets or Sets SetupRequest
        /// </summary>
        [DataMember(Name="SetupRequest", EmitDefaultValue=false)]
        public SCServiceChannelServicesMessagingDashboardSettingsSetupRequestResponse SetupRequest { get; set; }

        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name="Categories", EmitDefaultValue=false)]
        public List<SCServiceChannelServicesMessagingCategoryCategoryResponse> Categories { get; set; }

        /// <summary>
        /// Gets or Sets Priorities
        /// </summary>
        [DataMember(Name="Priorities", EmitDefaultValue=false)]
        public List<SCServiceChannelServicesMessagingPrioritiesPriorityResponse> Priorities { get; set; }

        /// <summary>
        /// Gets or Sets SetupGeneral
        /// </summary>
        [DataMember(Name="SetupGeneral", EmitDefaultValue=false)]
        public SCServiceChannelServicesMessagingDashboardSettingsSetupGeneralResponse SetupGeneral { get; set; }

        /// <summary>
        /// Gets or Sets UserSettings
        /// </summary>
        [DataMember(Name="UserSettings", EmitDefaultValue=false)]
        public SCServiceChannelServicesMessagingDashboardSettingsUserSettingsResponse UserSettings { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="Currency", EmitDefaultValue=false)]
        public SCServiceChannelServicesMessagingCurrenciesCurrency Currency { get; set; }

        /// <summary>
        /// Gets or Sets AreaId
        /// </summary>
        [DataMember(Name="AreaId", EmitDefaultValue=true)]
        public int AreaId { get; set; }

        /// <summary>
        /// Gets or Sets TradeId
        /// </summary>
        [DataMember(Name="TradeId", EmitDefaultValue=true)]
        public int TradeId { get; set; }

        /// <summary>
        /// Gets or Sets SetupId
        /// </summary>
        [DataMember(Name="SetupId", EmitDefaultValue=true)]
        public int SetupId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoResponse {\n");
            sb.Append("  IssueChoice: ").Append(IssueChoice).Append("\n");
            sb.Append("  Providers: ").Append(Providers).Append("\n");
            sb.Append("  ProvidersNotFoundMessage: ").Append(ProvidersNotFoundMessage).Append("\n");
            sb.Append("  CallerName: ").Append(CallerName).Append("\n");
            sb.Append("  ScheduledDateOffsetFromCallDate: ").Append(ScheduledDateOffsetFromCallDate).Append("\n");
            sb.Append("  AssetsInfo: ").Append(AssetsInfo).Append("\n");
            sb.Append("  SetupRequestConfirm: ").Append(SetupRequestConfirm).Append("\n");
            sb.Append("  SetupRequest: ").Append(SetupRequest).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Priorities: ").Append(Priorities).Append("\n");
            sb.Append("  SetupGeneral: ").Append(SetupGeneral).Append("\n");
            sb.Append("  UserSettings: ").Append(UserSettings).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  AreaId: ").Append(AreaId).Append("\n");
            sb.Append("  TradeId: ").Append(TradeId).Append("\n");
            sb.Append("  SetupId: ").Append(SetupId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoResponse)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    IssueChoice == other.IssueChoice ||
                    IssueChoice != null &&
                    IssueChoice.Equals(other.IssueChoice)
                ) && 
                (
                    Providers == other.Providers ||
                    Providers != null &&
                    other.Providers != null &&
                    Providers.SequenceEqual(other.Providers)
                ) && 
                (
                    ProvidersNotFoundMessage == other.ProvidersNotFoundMessage ||
                    ProvidersNotFoundMessage != null &&
                    ProvidersNotFoundMessage.Equals(other.ProvidersNotFoundMessage)
                ) && 
                (
                    CallerName == other.CallerName ||
                    CallerName != null &&
                    CallerName.Equals(other.CallerName)
                ) && 
                (
                    ScheduledDateOffsetFromCallDate == other.ScheduledDateOffsetFromCallDate ||
                    
                    ScheduledDateOffsetFromCallDate.Equals(other.ScheduledDateOffsetFromCallDate)
                ) && 
                (
                    AssetsInfo == other.AssetsInfo ||
                    AssetsInfo != null &&
                    AssetsInfo.Equals(other.AssetsInfo)
                ) && 
                (
                    SetupRequestConfirm == other.SetupRequestConfirm ||
                    SetupRequestConfirm != null &&
                    SetupRequestConfirm.Equals(other.SetupRequestConfirm)
                ) && 
                (
                    SetupRequest == other.SetupRequest ||
                    SetupRequest != null &&
                    SetupRequest.Equals(other.SetupRequest)
                ) && 
                (
                    Categories == other.Categories ||
                    Categories != null &&
                    other.Categories != null &&
                    Categories.SequenceEqual(other.Categories)
                ) && 
                (
                    Priorities == other.Priorities ||
                    Priorities != null &&
                    other.Priorities != null &&
                    Priorities.SequenceEqual(other.Priorities)
                ) && 
                (
                    SetupGeneral == other.SetupGeneral ||
                    SetupGeneral != null &&
                    SetupGeneral.Equals(other.SetupGeneral)
                ) && 
                (
                    UserSettings == other.UserSettings ||
                    UserSettings != null &&
                    UserSettings.Equals(other.UserSettings)
                ) && 
                (
                    Currency == other.Currency ||
                    Currency != null &&
                    Currency.Equals(other.Currency)
                ) && 
                (
                    AreaId == other.AreaId ||
                    
                    AreaId.Equals(other.AreaId)
                ) && 
                (
                    TradeId == other.TradeId ||
                    
                    TradeId.Equals(other.TradeId)
                ) && 
                (
                    SetupId == other.SetupId ||
                    
                    SetupId.Equals(other.SetupId)
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
                    if (IssueChoice != null)
                    hashCode = hashCode * 59 + IssueChoice.GetHashCode();
                    if (Providers != null)
                    hashCode = hashCode * 59 + Providers.GetHashCode();
                    if (ProvidersNotFoundMessage != null)
                    hashCode = hashCode * 59 + ProvidersNotFoundMessage.GetHashCode();
                    if (CallerName != null)
                    hashCode = hashCode * 59 + CallerName.GetHashCode();
                    
                    hashCode = hashCode * 59 + ScheduledDateOffsetFromCallDate.GetHashCode();
                    if (AssetsInfo != null)
                    hashCode = hashCode * 59 + AssetsInfo.GetHashCode();
                    if (SetupRequestConfirm != null)
                    hashCode = hashCode * 59 + SetupRequestConfirm.GetHashCode();
                    if (SetupRequest != null)
                    hashCode = hashCode * 59 + SetupRequest.GetHashCode();
                    if (Categories != null)
                    hashCode = hashCode * 59 + Categories.GetHashCode();
                    if (Priorities != null)
                    hashCode = hashCode * 59 + Priorities.GetHashCode();
                    if (SetupGeneral != null)
                    hashCode = hashCode * 59 + SetupGeneral.GetHashCode();
                    if (UserSettings != null)
                    hashCode = hashCode * 59 + UserSettings.GetHashCode();
                    if (Currency != null)
                    hashCode = hashCode * 59 + Currency.GetHashCode();
                    
                    hashCode = hashCode * 59 + AreaId.GetHashCode();
                    
                    hashCode = hashCode * 59 + TradeId.GetHashCode();
                    
                    hashCode = hashCode * 59 + SetupId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoResponse left, SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoResponse left, SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
