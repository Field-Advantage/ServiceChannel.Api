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
    /// SCServiceChannelApiModelDashboardSettingsSetupRequest
    /// </summary>
    [DataContract(Name = "ServiceChannel.Api.Model.Dashboard.Settings.SetupRequest")]
    public partial class SCServiceChannelApiModelDashboardSettingsSetupRequest : IEquatable<SCServiceChannelApiModelDashboardSettingsSetupRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines ShowStoreWarranty
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShowStoreWarrantyEnum
        {
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,

            /// <summary>
            /// Enum Show for value: Show
            /// </summary>
            [EnumMember(Value = "Show")]
            Show = 2,

            /// <summary>
            /// Enum Stop for value: Stop
            /// </summary>
            [EnumMember(Value = "Stop")]
            Stop = 3

        }


        /// <summary>
        /// Gets or Sets ShowStoreWarranty
        /// </summary>
        [DataMember(Name = "ShowStoreWarranty", EmitDefaultValue = false)]
        public ShowStoreWarrantyEnum? ShowStoreWarranty { get; set; }

        /// <summary>
        /// Returns false as ShowStoreWarranty should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeShowStoreWarranty()
        {
            return false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelApiModelDashboardSettingsSetupRequest" /> class.
        /// </summary>
        /// <param name="setupId">setupId.</param>
        /// <param name="enableRequestWizard">enableRequestWizard (default to false).</param>
        /// <param name="showPrivateStoreNotes">showPrivateStoreNotes (default to false).</param>
        /// <param name="showProviderPhoneNumber">showProviderPhoneNumber (default to false).</param>
        /// <param name="showLastServiceCall">showLastServiceCall (default to false).</param>
        /// <param name="setOriginalVendorForRecalls">setOriginalVendorForRecalls (default to false).</param>
        /// <param name="nteToZeroForRecalls">nteToZeroForRecalls (default to false).</param>
        /// <param name="sendAlertToFM">sendAlertToFM (default to false).</param>
        /// <param name="turnOffDescription">turnOffDescription (default to false).</param>
        /// <param name="daysOfHistoryToDisplay">daysOfHistoryToDisplay.</param>
        /// <param name="showStoreWarrantyStr">showStoreWarrantyStr.</param>
        /// <param name="storeWarrantyMessage">storeWarrantyMessage.</param>
        /// <param name="confirmationMessage">confirmationMessage.</param>
        /// <param name="providerNotFoundMessage">providerNotFoundMessage.</param>
        /// <param name="enableEquipment">enableEquipment (default to false).</param>
        /// <param name="duplicateFilters">duplicateFilters.</param>
        /// <param name="excludedCategoriesOpenDup">excludedCategoriesOpenDup.</param>
        /// <param name="excludedCategoriesClosedDup">excludedCategoriesClosedDup.</param>
        /// <param name="excludedTradesOpenDup">excludedTradesOpenDup.</param>
        /// <param name="enableEquipmentReplacementFlag">enableEquipmentReplacementFlag (default to false).</param>
        /// <param name="enableRequestWizardMobile">enableRequestWizardMobile (default to false).</param>
        /// <param name="enableLocationNotes">enableLocationNotes (default to false).</param>
        /// <param name="alwaysShowLocationNotes">alwaysShowLocationNotes (default to false).</param>
        /// <param name="skipTroubleshootingStep">skipTroubleshootingStep (default to false).</param>
        /// <param name="hidePriority">hidePriority (default to false).</param>
        /// <param name="enableIssueListKeywordSearch">enableIssueListKeywordSearch (default to false).</param>
        /// <param name="assetFirstWorkOrderCreation">assetFirstWorkOrderCreation (default to false).</param>
        /// <param name="hideGPSRadius">hideGPSRadius (default to false).</param>
        /// <param name="duplicateMessage">duplicateMessage.</param>
        public SCServiceChannelApiModelDashboardSettingsSetupRequest(int setupId = default(int), bool enableRequestWizard = false, bool showPrivateStoreNotes = false, bool showProviderPhoneNumber = false, bool showLastServiceCall = false, bool setOriginalVendorForRecalls = false, bool nteToZeroForRecalls = false, bool sendAlertToFM = false, bool turnOffDescription = false, int daysOfHistoryToDisplay = default(int), string showStoreWarrantyStr = default(string), string storeWarrantyMessage = default(string), string confirmationMessage = default(string), string providerNotFoundMessage = default(string), bool enableEquipment = false, List<string> duplicateFilters = default(List<string>), List<string> excludedCategoriesOpenDup = default(List<string>), List<string> excludedCategoriesClosedDup = default(List<string>), List<string> excludedTradesOpenDup = default(List<string>), bool enableEquipmentReplacementFlag = false, bool enableRequestWizardMobile = false, bool enableLocationNotes = false, bool alwaysShowLocationNotes = false, bool skipTroubleshootingStep = false, bool hidePriority = false, bool enableIssueListKeywordSearch = false, bool assetFirstWorkOrderCreation = false, bool hideGPSRadius = false, string duplicateMessage = default(string))
        {
            this.SetupId = setupId;
            this.EnableRequestWizard = enableRequestWizard;
            this.ShowPrivateStoreNotes = showPrivateStoreNotes;
            this.ShowProviderPhoneNumber = showProviderPhoneNumber;
            this.ShowLastServiceCall = showLastServiceCall;
            this.SetOriginalVendorForRecalls = setOriginalVendorForRecalls;
            this.NteToZeroForRecalls = nteToZeroForRecalls;
            this.SendAlertToFM = sendAlertToFM;
            this.TurnOffDescription = turnOffDescription;
            this.DaysOfHistoryToDisplay = daysOfHistoryToDisplay;
            this.ShowStoreWarrantyStr = showStoreWarrantyStr;
            this.StoreWarrantyMessage = storeWarrantyMessage;
            this.ConfirmationMessage = confirmationMessage;
            this.ProviderNotFoundMessage = providerNotFoundMessage;
            this.EnableEquipment = enableEquipment;
            this.DuplicateFilters = duplicateFilters;
            this.ExcludedCategoriesOpenDup = excludedCategoriesOpenDup;
            this.ExcludedCategoriesClosedDup = excludedCategoriesClosedDup;
            this.ExcludedTradesOpenDup = excludedTradesOpenDup;
            this.EnableEquipmentReplacementFlag = enableEquipmentReplacementFlag;
            this.EnableRequestWizardMobile = enableRequestWizardMobile;
            this.EnableLocationNotes = enableLocationNotes;
            this.AlwaysShowLocationNotes = alwaysShowLocationNotes;
            this.SkipTroubleshootingStep = skipTroubleshootingStep;
            this.HidePriority = hidePriority;
            this.EnableIssueListKeywordSearch = enableIssueListKeywordSearch;
            this.AssetFirstWorkOrderCreation = assetFirstWorkOrderCreation;
            this.HideGPSRadius = hideGPSRadius;
            this.DuplicateMessage = duplicateMessage;
        }

        /// <summary>
        /// Gets or Sets SetupId
        /// </summary>
        [DataMember(Name = "SetupId", EmitDefaultValue = false)]
        public int SetupId { get; set; }

        /// <summary>
        /// Gets or Sets EnableRequestWizard
        /// </summary>
        [DataMember(Name = "EnableRequestWizard", EmitDefaultValue = true)]
        public bool EnableRequestWizard { get; set; }

        /// <summary>
        /// Gets or Sets ShowPrivateStoreNotes
        /// </summary>
        [DataMember(Name = "ShowPrivateStoreNotes", EmitDefaultValue = true)]
        public bool ShowPrivateStoreNotes { get; set; }

        /// <summary>
        /// Gets or Sets ShowProviderPhoneNumber
        /// </summary>
        [DataMember(Name = "ShowProviderPhoneNumber", EmitDefaultValue = true)]
        public bool ShowProviderPhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets ShowLastServiceCall
        /// </summary>
        [DataMember(Name = "ShowLastServiceCall", EmitDefaultValue = true)]
        public bool ShowLastServiceCall { get; set; }

        /// <summary>
        /// Gets or Sets SetOriginalVendorForRecalls
        /// </summary>
        [DataMember(Name = "SetOriginalVendorForRecalls", EmitDefaultValue = true)]
        public bool SetOriginalVendorForRecalls { get; set; }

        /// <summary>
        /// Gets or Sets NteToZeroForRecalls
        /// </summary>
        [DataMember(Name = "NteToZeroForRecalls", EmitDefaultValue = true)]
        public bool NteToZeroForRecalls { get; set; }

        /// <summary>
        /// Gets or Sets SendAlertToFM
        /// </summary>
        [DataMember(Name = "SendAlertToFM", EmitDefaultValue = true)]
        public bool SendAlertToFM { get; set; }

        /// <summary>
        /// Gets or Sets TurnOffDescription
        /// </summary>
        [DataMember(Name = "TurnOffDescription", EmitDefaultValue = true)]
        public bool TurnOffDescription { get; set; }

        /// <summary>
        /// Gets or Sets DaysOfHistoryToDisplay
        /// </summary>
        [DataMember(Name = "DaysOfHistoryToDisplay", EmitDefaultValue = false)]
        public int DaysOfHistoryToDisplay { get; set; }

        /// <summary>
        /// Gets or Sets ShowStoreWarrantyStr
        /// </summary>
        [DataMember(Name = "ShowStoreWarrantyStr", EmitDefaultValue = false)]
        public string ShowStoreWarrantyStr { get; set; }

        /// <summary>
        /// Gets or Sets StoreWarrantyMessage
        /// </summary>
        [DataMember(Name = "StoreWarrantyMessage", EmitDefaultValue = false)]
        public string StoreWarrantyMessage { get; set; }

        /// <summary>
        /// Gets or Sets ConfirmationMessage
        /// </summary>
        [DataMember(Name = "ConfirmationMessage", EmitDefaultValue = false)]
        public string ConfirmationMessage { get; set; }

        /// <summary>
        /// Gets or Sets ProviderNotFoundMessage
        /// </summary>
        [DataMember(Name = "ProviderNotFoundMessage", EmitDefaultValue = false)]
        public string ProviderNotFoundMessage { get; set; }

        /// <summary>
        /// Gets or Sets EnableEquipment
        /// </summary>
        [DataMember(Name = "EnableEquipment", EmitDefaultValue = true)]
        public bool EnableEquipment { get; set; }

        /// <summary>
        /// Gets or Sets DuplicateFilters
        /// </summary>
        [DataMember(Name = "DuplicateFilters", EmitDefaultValue = false)]
        public List<string> DuplicateFilters { get; set; }

        /// <summary>
        /// Gets or Sets ExcludedCategoriesOpenDup
        /// </summary>
        [DataMember(Name = "ExcludedCategoriesOpenDup", EmitDefaultValue = false)]
        public List<string> ExcludedCategoriesOpenDup { get; set; }

        /// <summary>
        /// Gets or Sets ExcludedCategoriesClosedDup
        /// </summary>
        [DataMember(Name = "ExcludedCategoriesClosedDup", EmitDefaultValue = false)]
        public List<string> ExcludedCategoriesClosedDup { get; set; }

        /// <summary>
        /// Gets or Sets ExcludedTradesOpenDup
        /// </summary>
        [DataMember(Name = "ExcludedTradesOpenDup", EmitDefaultValue = false)]
        public List<string> ExcludedTradesOpenDup { get; set; }

        /// <summary>
        /// Gets or Sets EnableEquipmentReplacementFlag
        /// </summary>
        [DataMember(Name = "EnableEquipmentReplacementFlag", EmitDefaultValue = true)]
        public bool EnableEquipmentReplacementFlag { get; set; }

        /// <summary>
        /// Gets or Sets EnableRequestWizardMobile
        /// </summary>
        [DataMember(Name = "EnableRequestWizardMobile", EmitDefaultValue = true)]
        public bool EnableRequestWizardMobile { get; set; }

        /// <summary>
        /// Gets or Sets EnableLocationNotes
        /// </summary>
        [DataMember(Name = "EnableLocationNotes", EmitDefaultValue = true)]
        public bool EnableLocationNotes { get; set; }

        /// <summary>
        /// Gets or Sets AlwaysShowLocationNotes
        /// </summary>
        [DataMember(Name = "AlwaysShowLocationNotes", EmitDefaultValue = true)]
        public bool AlwaysShowLocationNotes { get; set; }

        /// <summary>
        /// Gets or Sets SkipTroubleshootingStep
        /// </summary>
        [DataMember(Name = "SkipTroubleshootingStep", EmitDefaultValue = true)]
        public bool SkipTroubleshootingStep { get; set; }

        /// <summary>
        /// Gets or Sets HidePriority
        /// </summary>
        [DataMember(Name = "HidePriority", EmitDefaultValue = true)]
        public bool HidePriority { get; set; }

        /// <summary>
        /// Gets or Sets EnableIssueListKeywordSearch
        /// </summary>
        [DataMember(Name = "EnableIssueListKeywordSearch", EmitDefaultValue = true)]
        public bool EnableIssueListKeywordSearch { get; set; }

        /// <summary>
        /// Gets or Sets AssetFirstWorkOrderCreation
        /// </summary>
        [DataMember(Name = "AssetFirstWorkOrderCreation", EmitDefaultValue = true)]
        public bool AssetFirstWorkOrderCreation { get; set; }

        /// <summary>
        /// Gets or Sets HideGPSRadius
        /// </summary>
        [DataMember(Name = "HideGPSRadius", EmitDefaultValue = true)]
        public bool HideGPSRadius { get; set; }

        /// <summary>
        /// Gets or Sets DuplicateMessage
        /// </summary>
        [DataMember(Name = "DuplicateMessage", EmitDefaultValue = false)]
        public string DuplicateMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelApiModelDashboardSettingsSetupRequest {\n");
            sb.Append("  SetupId: ").Append(SetupId).Append("\n");
            sb.Append("  EnableRequestWizard: ").Append(EnableRequestWizard).Append("\n");
            sb.Append("  ShowPrivateStoreNotes: ").Append(ShowPrivateStoreNotes).Append("\n");
            sb.Append("  ShowProviderPhoneNumber: ").Append(ShowProviderPhoneNumber).Append("\n");
            sb.Append("  ShowLastServiceCall: ").Append(ShowLastServiceCall).Append("\n");
            sb.Append("  SetOriginalVendorForRecalls: ").Append(SetOriginalVendorForRecalls).Append("\n");
            sb.Append("  NteToZeroForRecalls: ").Append(NteToZeroForRecalls).Append("\n");
            sb.Append("  SendAlertToFM: ").Append(SendAlertToFM).Append("\n");
            sb.Append("  TurnOffDescription: ").Append(TurnOffDescription).Append("\n");
            sb.Append("  DaysOfHistoryToDisplay: ").Append(DaysOfHistoryToDisplay).Append("\n");
            sb.Append("  ShowStoreWarrantyStr: ").Append(ShowStoreWarrantyStr).Append("\n");
            sb.Append("  ShowStoreWarranty: ").Append(ShowStoreWarranty).Append("\n");
            sb.Append("  StoreWarrantyMessage: ").Append(StoreWarrantyMessage).Append("\n");
            sb.Append("  ConfirmationMessage: ").Append(ConfirmationMessage).Append("\n");
            sb.Append("  ProviderNotFoundMessage: ").Append(ProviderNotFoundMessage).Append("\n");
            sb.Append("  EnableEquipment: ").Append(EnableEquipment).Append("\n");
            sb.Append("  DuplicateFilters: ").Append(DuplicateFilters).Append("\n");
            sb.Append("  ExcludedCategoriesOpenDup: ").Append(ExcludedCategoriesOpenDup).Append("\n");
            sb.Append("  ExcludedCategoriesClosedDup: ").Append(ExcludedCategoriesClosedDup).Append("\n");
            sb.Append("  ExcludedTradesOpenDup: ").Append(ExcludedTradesOpenDup).Append("\n");
            sb.Append("  EnableEquipmentReplacementFlag: ").Append(EnableEquipmentReplacementFlag).Append("\n");
            sb.Append("  EnableRequestWizardMobile: ").Append(EnableRequestWizardMobile).Append("\n");
            sb.Append("  EnableLocationNotes: ").Append(EnableLocationNotes).Append("\n");
            sb.Append("  AlwaysShowLocationNotes: ").Append(AlwaysShowLocationNotes).Append("\n");
            sb.Append("  SkipTroubleshootingStep: ").Append(SkipTroubleshootingStep).Append("\n");
            sb.Append("  HidePriority: ").Append(HidePriority).Append("\n");
            sb.Append("  EnableIssueListKeywordSearch: ").Append(EnableIssueListKeywordSearch).Append("\n");
            sb.Append("  AssetFirstWorkOrderCreation: ").Append(AssetFirstWorkOrderCreation).Append("\n");
            sb.Append("  HideGPSRadius: ").Append(HideGPSRadius).Append("\n");
            sb.Append("  DuplicateMessage: ").Append(DuplicateMessage).Append("\n");
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
            return this.Equals(input as SCServiceChannelApiModelDashboardSettingsSetupRequest);
        }

        /// <summary>
        /// Returns true if SCServiceChannelApiModelDashboardSettingsSetupRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelApiModelDashboardSettingsSetupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelApiModelDashboardSettingsSetupRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SetupId == input.SetupId ||
                    this.SetupId.Equals(input.SetupId)
                ) && 
                (
                    this.EnableRequestWizard == input.EnableRequestWizard ||
                    this.EnableRequestWizard.Equals(input.EnableRequestWizard)
                ) && 
                (
                    this.ShowPrivateStoreNotes == input.ShowPrivateStoreNotes ||
                    this.ShowPrivateStoreNotes.Equals(input.ShowPrivateStoreNotes)
                ) && 
                (
                    this.ShowProviderPhoneNumber == input.ShowProviderPhoneNumber ||
                    this.ShowProviderPhoneNumber.Equals(input.ShowProviderPhoneNumber)
                ) && 
                (
                    this.ShowLastServiceCall == input.ShowLastServiceCall ||
                    this.ShowLastServiceCall.Equals(input.ShowLastServiceCall)
                ) && 
                (
                    this.SetOriginalVendorForRecalls == input.SetOriginalVendorForRecalls ||
                    this.SetOriginalVendorForRecalls.Equals(input.SetOriginalVendorForRecalls)
                ) && 
                (
                    this.NteToZeroForRecalls == input.NteToZeroForRecalls ||
                    this.NteToZeroForRecalls.Equals(input.NteToZeroForRecalls)
                ) && 
                (
                    this.SendAlertToFM == input.SendAlertToFM ||
                    this.SendAlertToFM.Equals(input.SendAlertToFM)
                ) && 
                (
                    this.TurnOffDescription == input.TurnOffDescription ||
                    this.TurnOffDescription.Equals(input.TurnOffDescription)
                ) && 
                (
                    this.DaysOfHistoryToDisplay == input.DaysOfHistoryToDisplay ||
                    this.DaysOfHistoryToDisplay.Equals(input.DaysOfHistoryToDisplay)
                ) && 
                (
                    this.ShowStoreWarrantyStr == input.ShowStoreWarrantyStr ||
                    (this.ShowStoreWarrantyStr != null &&
                    this.ShowStoreWarrantyStr.Equals(input.ShowStoreWarrantyStr))
                ) && 
                (
                    this.ShowStoreWarranty == input.ShowStoreWarranty ||
                    this.ShowStoreWarranty.Equals(input.ShowStoreWarranty)
                ) && 
                (
                    this.StoreWarrantyMessage == input.StoreWarrantyMessage ||
                    (this.StoreWarrantyMessage != null &&
                    this.StoreWarrantyMessage.Equals(input.StoreWarrantyMessage))
                ) && 
                (
                    this.ConfirmationMessage == input.ConfirmationMessage ||
                    (this.ConfirmationMessage != null &&
                    this.ConfirmationMessage.Equals(input.ConfirmationMessage))
                ) && 
                (
                    this.ProviderNotFoundMessage == input.ProviderNotFoundMessage ||
                    (this.ProviderNotFoundMessage != null &&
                    this.ProviderNotFoundMessage.Equals(input.ProviderNotFoundMessage))
                ) && 
                (
                    this.EnableEquipment == input.EnableEquipment ||
                    this.EnableEquipment.Equals(input.EnableEquipment)
                ) && 
                (
                    this.DuplicateFilters == input.DuplicateFilters ||
                    this.DuplicateFilters != null &&
                    input.DuplicateFilters != null &&
                    this.DuplicateFilters.SequenceEqual(input.DuplicateFilters)
                ) && 
                (
                    this.ExcludedCategoriesOpenDup == input.ExcludedCategoriesOpenDup ||
                    this.ExcludedCategoriesOpenDup != null &&
                    input.ExcludedCategoriesOpenDup != null &&
                    this.ExcludedCategoriesOpenDup.SequenceEqual(input.ExcludedCategoriesOpenDup)
                ) && 
                (
                    this.ExcludedCategoriesClosedDup == input.ExcludedCategoriesClosedDup ||
                    this.ExcludedCategoriesClosedDup != null &&
                    input.ExcludedCategoriesClosedDup != null &&
                    this.ExcludedCategoriesClosedDup.SequenceEqual(input.ExcludedCategoriesClosedDup)
                ) && 
                (
                    this.ExcludedTradesOpenDup == input.ExcludedTradesOpenDup ||
                    this.ExcludedTradesOpenDup != null &&
                    input.ExcludedTradesOpenDup != null &&
                    this.ExcludedTradesOpenDup.SequenceEqual(input.ExcludedTradesOpenDup)
                ) && 
                (
                    this.EnableEquipmentReplacementFlag == input.EnableEquipmentReplacementFlag ||
                    this.EnableEquipmentReplacementFlag.Equals(input.EnableEquipmentReplacementFlag)
                ) && 
                (
                    this.EnableRequestWizardMobile == input.EnableRequestWizardMobile ||
                    this.EnableRequestWizardMobile.Equals(input.EnableRequestWizardMobile)
                ) && 
                (
                    this.EnableLocationNotes == input.EnableLocationNotes ||
                    this.EnableLocationNotes.Equals(input.EnableLocationNotes)
                ) && 
                (
                    this.AlwaysShowLocationNotes == input.AlwaysShowLocationNotes ||
                    this.AlwaysShowLocationNotes.Equals(input.AlwaysShowLocationNotes)
                ) && 
                (
                    this.SkipTroubleshootingStep == input.SkipTroubleshootingStep ||
                    this.SkipTroubleshootingStep.Equals(input.SkipTroubleshootingStep)
                ) && 
                (
                    this.HidePriority == input.HidePriority ||
                    this.HidePriority.Equals(input.HidePriority)
                ) && 
                (
                    this.EnableIssueListKeywordSearch == input.EnableIssueListKeywordSearch ||
                    this.EnableIssueListKeywordSearch.Equals(input.EnableIssueListKeywordSearch)
                ) && 
                (
                    this.AssetFirstWorkOrderCreation == input.AssetFirstWorkOrderCreation ||
                    this.AssetFirstWorkOrderCreation.Equals(input.AssetFirstWorkOrderCreation)
                ) && 
                (
                    this.HideGPSRadius == input.HideGPSRadius ||
                    this.HideGPSRadius.Equals(input.HideGPSRadius)
                ) && 
                (
                    this.DuplicateMessage == input.DuplicateMessage ||
                    (this.DuplicateMessage != null &&
                    this.DuplicateMessage.Equals(input.DuplicateMessage))
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
                hashCode = (hashCode * 59) + this.SetupId.GetHashCode();
                hashCode = (hashCode * 59) + this.EnableRequestWizard.GetHashCode();
                hashCode = (hashCode * 59) + this.ShowPrivateStoreNotes.GetHashCode();
                hashCode = (hashCode * 59) + this.ShowProviderPhoneNumber.GetHashCode();
                hashCode = (hashCode * 59) + this.ShowLastServiceCall.GetHashCode();
                hashCode = (hashCode * 59) + this.SetOriginalVendorForRecalls.GetHashCode();
                hashCode = (hashCode * 59) + this.NteToZeroForRecalls.GetHashCode();
                hashCode = (hashCode * 59) + this.SendAlertToFM.GetHashCode();
                hashCode = (hashCode * 59) + this.TurnOffDescription.GetHashCode();
                hashCode = (hashCode * 59) + this.DaysOfHistoryToDisplay.GetHashCode();
                if (this.ShowStoreWarrantyStr != null)
                {
                    hashCode = (hashCode * 59) + this.ShowStoreWarrantyStr.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ShowStoreWarranty.GetHashCode();
                if (this.StoreWarrantyMessage != null)
                {
                    hashCode = (hashCode * 59) + this.StoreWarrantyMessage.GetHashCode();
                }
                if (this.ConfirmationMessage != null)
                {
                    hashCode = (hashCode * 59) + this.ConfirmationMessage.GetHashCode();
                }
                if (this.ProviderNotFoundMessage != null)
                {
                    hashCode = (hashCode * 59) + this.ProviderNotFoundMessage.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EnableEquipment.GetHashCode();
                if (this.DuplicateFilters != null)
                {
                    hashCode = (hashCode * 59) + this.DuplicateFilters.GetHashCode();
                }
                if (this.ExcludedCategoriesOpenDup != null)
                {
                    hashCode = (hashCode * 59) + this.ExcludedCategoriesOpenDup.GetHashCode();
                }
                if (this.ExcludedCategoriesClosedDup != null)
                {
                    hashCode = (hashCode * 59) + this.ExcludedCategoriesClosedDup.GetHashCode();
                }
                if (this.ExcludedTradesOpenDup != null)
                {
                    hashCode = (hashCode * 59) + this.ExcludedTradesOpenDup.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EnableEquipmentReplacementFlag.GetHashCode();
                hashCode = (hashCode * 59) + this.EnableRequestWizardMobile.GetHashCode();
                hashCode = (hashCode * 59) + this.EnableLocationNotes.GetHashCode();
                hashCode = (hashCode * 59) + this.AlwaysShowLocationNotes.GetHashCode();
                hashCode = (hashCode * 59) + this.SkipTroubleshootingStep.GetHashCode();
                hashCode = (hashCode * 59) + this.HidePriority.GetHashCode();
                hashCode = (hashCode * 59) + this.EnableIssueListKeywordSearch.GetHashCode();
                hashCode = (hashCode * 59) + this.AssetFirstWorkOrderCreation.GetHashCode();
                hashCode = (hashCode * 59) + this.HideGPSRadius.GetHashCode();
                if (this.DuplicateMessage != null)
                {
                    hashCode = (hashCode * 59) + this.DuplicateMessage.GetHashCode();
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
