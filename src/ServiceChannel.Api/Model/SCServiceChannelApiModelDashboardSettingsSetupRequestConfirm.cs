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
    /// SCServiceChannelApiModelDashboardSettingsSetupRequestConfirm
    /// </summary>
    [DataContract(Name = "ServiceChannel.Api.Model.Dashboard.Settings.SetupRequestConfirm")]
    public partial class SCServiceChannelApiModelDashboardSettingsSetupRequestConfirm : IEquatable<SCServiceChannelApiModelDashboardSettingsSetupRequestConfirm>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelApiModelDashboardSettingsSetupRequestConfirm" /> class.
        /// </summary>
        /// <param name="setupId">setupId.</param>
        /// <param name="changeableCategory">changeableCategory (default to false).</param>
        /// <param name="changeablePriority">changeablePriority (default to false).</param>
        /// <param name="changeableNte">changeableNte (default to false).</param>
        /// <param name="changeableScheduledDate">changeableScheduledDate (default to false).</param>
        /// <param name="changeableProvider">changeableProvider (default to false).</param>
        /// <param name="createLinkedRequest">createLinkedRequest (default to false).</param>
        /// <param name="showRecipients">showRecipients (default to false).</param>
        /// <param name="addCopyRecipient">addCopyRecipient (default to false).</param>
        /// <param name="deleteCopyRecipients">deleteCopyRecipients (default to false).</param>
        /// <param name="enableAdditionalCodes">enableAdditionalCodes (default to false).</param>
        /// <param name="emptyProviderEmailNotification">emptyProviderEmailNotification (default to false).</param>
        /// <param name="enablePO">enablePO (default to false).</param>
        /// <param name="requirePO">requirePO (default to false).</param>
        /// <param name="enableWO">enableWO (default to false).</param>
        /// <param name="changeablePrioritySetDefault">changeablePrioritySetDefault (default to false).</param>
        /// <param name="allowChangeableCurrency">allowChangeableCurrency (default to false).</param>
        /// <param name="avoidDispatching">avoidDispatching (default to false).</param>
        /// <param name="enableLabels">enableLabels (default to false).</param>
        /// <param name="labelsAsSelectOnly">labelsAsSelectOnly (default to false).</param>
        /// <param name="editWeatherType">editWeatherType (default to false).</param>
        /// <param name="changeableGlCode">changeableGlCode (default to false).</param>
        /// <param name="maintainOrDecreasePriority">maintainOrDecreasePriority (default to false).</param>
        /// <param name="showAsset">showAsset (default to false).</param>
        /// <param name="enableAssignee">enableAssignee (default to false).</param>
        public SCServiceChannelApiModelDashboardSettingsSetupRequestConfirm(int setupId = default(int), bool changeableCategory = false, bool changeablePriority = false, bool changeableNte = false, bool changeableScheduledDate = false, bool changeableProvider = false, bool createLinkedRequest = false, bool showRecipients = false, bool addCopyRecipient = false, bool deleteCopyRecipients = false, bool enableAdditionalCodes = false, bool emptyProviderEmailNotification = false, bool enablePO = false, bool requirePO = false, bool enableWO = false, bool changeablePrioritySetDefault = false, bool allowChangeableCurrency = false, bool avoidDispatching = false, bool enableLabels = false, bool labelsAsSelectOnly = false, bool editWeatherType = false, bool changeableGlCode = false, bool maintainOrDecreasePriority = false, bool showAsset = false, bool enableAssignee = false)
        {
            this.SetupId = setupId;
            this.ChangeableCategory = changeableCategory;
            this.ChangeablePriority = changeablePriority;
            this.ChangeableNte = changeableNte;
            this.ChangeableScheduledDate = changeableScheduledDate;
            this.ChangeableProvider = changeableProvider;
            this.CreateLinkedRequest = createLinkedRequest;
            this.ShowRecipients = showRecipients;
            this.AddCopyRecipient = addCopyRecipient;
            this.DeleteCopyRecipients = deleteCopyRecipients;
            this.EnableAdditionalCodes = enableAdditionalCodes;
            this.EmptyProviderEmailNotification = emptyProviderEmailNotification;
            this.EnablePO = enablePO;
            this.RequirePO = requirePO;
            this.EnableWO = enableWO;
            this.ChangeablePrioritySetDefault = changeablePrioritySetDefault;
            this.AllowChangeableCurrency = allowChangeableCurrency;
            this.AvoidDispatching = avoidDispatching;
            this.EnableLabels = enableLabels;
            this.LabelsAsSelectOnly = labelsAsSelectOnly;
            this.EditWeatherType = editWeatherType;
            this.ChangeableGlCode = changeableGlCode;
            this.MaintainOrDecreasePriority = maintainOrDecreasePriority;
            this.ShowAsset = showAsset;
            this.EnableAssignee = enableAssignee;
        }

        /// <summary>
        /// Gets or Sets SetupId
        /// </summary>
        [DataMember(Name = "SetupId", EmitDefaultValue = false)]
        public int SetupId { get; set; }

        /// <summary>
        /// Gets or Sets ChangeableCategory
        /// </summary>
        [DataMember(Name = "ChangeableCategory", EmitDefaultValue = true)]
        public bool ChangeableCategory { get; set; }

        /// <summary>
        /// Gets or Sets ChangeablePriority
        /// </summary>
        [DataMember(Name = "ChangeablePriority", EmitDefaultValue = true)]
        public bool ChangeablePriority { get; set; }

        /// <summary>
        /// Gets or Sets ChangeableNte
        /// </summary>
        [DataMember(Name = "ChangeableNte", EmitDefaultValue = true)]
        public bool ChangeableNte { get; set; }

        /// <summary>
        /// Gets or Sets ChangeableScheduledDate
        /// </summary>
        [DataMember(Name = "ChangeableScheduledDate", EmitDefaultValue = true)]
        public bool ChangeableScheduledDate { get; set; }

        /// <summary>
        /// Gets or Sets ChangeableProvider
        /// </summary>
        [DataMember(Name = "ChangeableProvider", EmitDefaultValue = true)]
        public bool ChangeableProvider { get; set; }

        /// <summary>
        /// Gets or Sets CreateLinkedRequest
        /// </summary>
        [DataMember(Name = "CreateLinkedRequest", EmitDefaultValue = true)]
        public bool CreateLinkedRequest { get; set; }

        /// <summary>
        /// Gets or Sets ShowRecipients
        /// </summary>
        [DataMember(Name = "ShowRecipients", EmitDefaultValue = true)]
        public bool ShowRecipients { get; set; }

        /// <summary>
        /// Gets or Sets AddCopyRecipient
        /// </summary>
        [DataMember(Name = "AddCopyRecipient", EmitDefaultValue = true)]
        public bool AddCopyRecipient { get; set; }

        /// <summary>
        /// Gets or Sets DeleteCopyRecipients
        /// </summary>
        [DataMember(Name = "DeleteCopyRecipients", EmitDefaultValue = true)]
        public bool DeleteCopyRecipients { get; set; }

        /// <summary>
        /// Gets or Sets EnableAdditionalCodes
        /// </summary>
        [DataMember(Name = "EnableAdditionalCodes", EmitDefaultValue = true)]
        public bool EnableAdditionalCodes { get; set; }

        /// <summary>
        /// Gets or Sets EmptyProviderEmailNotification
        /// </summary>
        [DataMember(Name = "EmptyProviderEmailNotification", EmitDefaultValue = true)]
        public bool EmptyProviderEmailNotification { get; set; }

        /// <summary>
        /// Gets or Sets EnablePO
        /// </summary>
        [DataMember(Name = "EnablePO", EmitDefaultValue = true)]
        public bool EnablePO { get; set; }

        /// <summary>
        /// Gets or Sets RequirePO
        /// </summary>
        [DataMember(Name = "RequirePO", EmitDefaultValue = true)]
        public bool RequirePO { get; set; }

        /// <summary>
        /// Gets or Sets EnableWO
        /// </summary>
        [DataMember(Name = "EnableWO", EmitDefaultValue = true)]
        public bool EnableWO { get; set; }

        /// <summary>
        /// Gets or Sets ChangeablePrioritySetDefault
        /// </summary>
        [DataMember(Name = "ChangeablePrioritySetDefault", EmitDefaultValue = true)]
        public bool ChangeablePrioritySetDefault { get; set; }

        /// <summary>
        /// Gets or Sets AllowChangeableCurrency
        /// </summary>
        [DataMember(Name = "AllowChangeableCurrency", EmitDefaultValue = true)]
        public bool AllowChangeableCurrency { get; set; }

        /// <summary>
        /// Gets or Sets AvoidDispatching
        /// </summary>
        [DataMember(Name = "AvoidDispatching", EmitDefaultValue = true)]
        public bool AvoidDispatching { get; set; }

        /// <summary>
        /// Gets or Sets EnableLabels
        /// </summary>
        [DataMember(Name = "EnableLabels", EmitDefaultValue = true)]
        public bool EnableLabels { get; set; }

        /// <summary>
        /// Gets or Sets LabelsAsSelectOnly
        /// </summary>
        [DataMember(Name = "LabelsAsSelectOnly", EmitDefaultValue = true)]
        public bool LabelsAsSelectOnly { get; set; }

        /// <summary>
        /// Gets or Sets EditWeatherType
        /// </summary>
        [DataMember(Name = "EditWeatherType", EmitDefaultValue = true)]
        public bool EditWeatherType { get; set; }

        /// <summary>
        /// Gets or Sets ChangeableGlCode
        /// </summary>
        [DataMember(Name = "ChangeableGlCode", EmitDefaultValue = true)]
        public bool ChangeableGlCode { get; set; }

        /// <summary>
        /// Gets or Sets MaintainOrDecreasePriority
        /// </summary>
        [DataMember(Name = "MaintainOrDecreasePriority", EmitDefaultValue = true)]
        public bool MaintainOrDecreasePriority { get; set; }

        /// <summary>
        /// Gets or Sets ShowAsset
        /// </summary>
        [DataMember(Name = "ShowAsset", EmitDefaultValue = true)]
        public bool ShowAsset { get; set; }

        /// <summary>
        /// Gets or Sets EnableAssignee
        /// </summary>
        [DataMember(Name = "EnableAssignee", EmitDefaultValue = true)]
        public bool EnableAssignee { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelApiModelDashboardSettingsSetupRequestConfirm {\n");
            sb.Append("  SetupId: ").Append(SetupId).Append("\n");
            sb.Append("  ChangeableCategory: ").Append(ChangeableCategory).Append("\n");
            sb.Append("  ChangeablePriority: ").Append(ChangeablePriority).Append("\n");
            sb.Append("  ChangeableNte: ").Append(ChangeableNte).Append("\n");
            sb.Append("  ChangeableScheduledDate: ").Append(ChangeableScheduledDate).Append("\n");
            sb.Append("  ChangeableProvider: ").Append(ChangeableProvider).Append("\n");
            sb.Append("  CreateLinkedRequest: ").Append(CreateLinkedRequest).Append("\n");
            sb.Append("  ShowRecipients: ").Append(ShowRecipients).Append("\n");
            sb.Append("  AddCopyRecipient: ").Append(AddCopyRecipient).Append("\n");
            sb.Append("  DeleteCopyRecipients: ").Append(DeleteCopyRecipients).Append("\n");
            sb.Append("  EnableAdditionalCodes: ").Append(EnableAdditionalCodes).Append("\n");
            sb.Append("  EmptyProviderEmailNotification: ").Append(EmptyProviderEmailNotification).Append("\n");
            sb.Append("  EnablePO: ").Append(EnablePO).Append("\n");
            sb.Append("  RequirePO: ").Append(RequirePO).Append("\n");
            sb.Append("  EnableWO: ").Append(EnableWO).Append("\n");
            sb.Append("  ChangeablePrioritySetDefault: ").Append(ChangeablePrioritySetDefault).Append("\n");
            sb.Append("  AllowChangeableCurrency: ").Append(AllowChangeableCurrency).Append("\n");
            sb.Append("  AvoidDispatching: ").Append(AvoidDispatching).Append("\n");
            sb.Append("  EnableLabels: ").Append(EnableLabels).Append("\n");
            sb.Append("  LabelsAsSelectOnly: ").Append(LabelsAsSelectOnly).Append("\n");
            sb.Append("  EditWeatherType: ").Append(EditWeatherType).Append("\n");
            sb.Append("  ChangeableGlCode: ").Append(ChangeableGlCode).Append("\n");
            sb.Append("  MaintainOrDecreasePriority: ").Append(MaintainOrDecreasePriority).Append("\n");
            sb.Append("  ShowAsset: ").Append(ShowAsset).Append("\n");
            sb.Append("  EnableAssignee: ").Append(EnableAssignee).Append("\n");
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
            return this.Equals(input as SCServiceChannelApiModelDashboardSettingsSetupRequestConfirm);
        }

        /// <summary>
        /// Returns true if SCServiceChannelApiModelDashboardSettingsSetupRequestConfirm instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelApiModelDashboardSettingsSetupRequestConfirm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelApiModelDashboardSettingsSetupRequestConfirm input)
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
                    this.ChangeableCategory == input.ChangeableCategory ||
                    this.ChangeableCategory.Equals(input.ChangeableCategory)
                ) && 
                (
                    this.ChangeablePriority == input.ChangeablePriority ||
                    this.ChangeablePriority.Equals(input.ChangeablePriority)
                ) && 
                (
                    this.ChangeableNte == input.ChangeableNte ||
                    this.ChangeableNte.Equals(input.ChangeableNte)
                ) && 
                (
                    this.ChangeableScheduledDate == input.ChangeableScheduledDate ||
                    this.ChangeableScheduledDate.Equals(input.ChangeableScheduledDate)
                ) && 
                (
                    this.ChangeableProvider == input.ChangeableProvider ||
                    this.ChangeableProvider.Equals(input.ChangeableProvider)
                ) && 
                (
                    this.CreateLinkedRequest == input.CreateLinkedRequest ||
                    this.CreateLinkedRequest.Equals(input.CreateLinkedRequest)
                ) && 
                (
                    this.ShowRecipients == input.ShowRecipients ||
                    this.ShowRecipients.Equals(input.ShowRecipients)
                ) && 
                (
                    this.AddCopyRecipient == input.AddCopyRecipient ||
                    this.AddCopyRecipient.Equals(input.AddCopyRecipient)
                ) && 
                (
                    this.DeleteCopyRecipients == input.DeleteCopyRecipients ||
                    this.DeleteCopyRecipients.Equals(input.DeleteCopyRecipients)
                ) && 
                (
                    this.EnableAdditionalCodes == input.EnableAdditionalCodes ||
                    this.EnableAdditionalCodes.Equals(input.EnableAdditionalCodes)
                ) && 
                (
                    this.EmptyProviderEmailNotification == input.EmptyProviderEmailNotification ||
                    this.EmptyProviderEmailNotification.Equals(input.EmptyProviderEmailNotification)
                ) && 
                (
                    this.EnablePO == input.EnablePO ||
                    this.EnablePO.Equals(input.EnablePO)
                ) && 
                (
                    this.RequirePO == input.RequirePO ||
                    this.RequirePO.Equals(input.RequirePO)
                ) && 
                (
                    this.EnableWO == input.EnableWO ||
                    this.EnableWO.Equals(input.EnableWO)
                ) && 
                (
                    this.ChangeablePrioritySetDefault == input.ChangeablePrioritySetDefault ||
                    this.ChangeablePrioritySetDefault.Equals(input.ChangeablePrioritySetDefault)
                ) && 
                (
                    this.AllowChangeableCurrency == input.AllowChangeableCurrency ||
                    this.AllowChangeableCurrency.Equals(input.AllowChangeableCurrency)
                ) && 
                (
                    this.AvoidDispatching == input.AvoidDispatching ||
                    this.AvoidDispatching.Equals(input.AvoidDispatching)
                ) && 
                (
                    this.EnableLabels == input.EnableLabels ||
                    this.EnableLabels.Equals(input.EnableLabels)
                ) && 
                (
                    this.LabelsAsSelectOnly == input.LabelsAsSelectOnly ||
                    this.LabelsAsSelectOnly.Equals(input.LabelsAsSelectOnly)
                ) && 
                (
                    this.EditWeatherType == input.EditWeatherType ||
                    this.EditWeatherType.Equals(input.EditWeatherType)
                ) && 
                (
                    this.ChangeableGlCode == input.ChangeableGlCode ||
                    this.ChangeableGlCode.Equals(input.ChangeableGlCode)
                ) && 
                (
                    this.MaintainOrDecreasePriority == input.MaintainOrDecreasePriority ||
                    this.MaintainOrDecreasePriority.Equals(input.MaintainOrDecreasePriority)
                ) && 
                (
                    this.ShowAsset == input.ShowAsset ||
                    this.ShowAsset.Equals(input.ShowAsset)
                ) && 
                (
                    this.EnableAssignee == input.EnableAssignee ||
                    this.EnableAssignee.Equals(input.EnableAssignee)
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
                hashCode = (hashCode * 59) + this.ChangeableCategory.GetHashCode();
                hashCode = (hashCode * 59) + this.ChangeablePriority.GetHashCode();
                hashCode = (hashCode * 59) + this.ChangeableNte.GetHashCode();
                hashCode = (hashCode * 59) + this.ChangeableScheduledDate.GetHashCode();
                hashCode = (hashCode * 59) + this.ChangeableProvider.GetHashCode();
                hashCode = (hashCode * 59) + this.CreateLinkedRequest.GetHashCode();
                hashCode = (hashCode * 59) + this.ShowRecipients.GetHashCode();
                hashCode = (hashCode * 59) + this.AddCopyRecipient.GetHashCode();
                hashCode = (hashCode * 59) + this.DeleteCopyRecipients.GetHashCode();
                hashCode = (hashCode * 59) + this.EnableAdditionalCodes.GetHashCode();
                hashCode = (hashCode * 59) + this.EmptyProviderEmailNotification.GetHashCode();
                hashCode = (hashCode * 59) + this.EnablePO.GetHashCode();
                hashCode = (hashCode * 59) + this.RequirePO.GetHashCode();
                hashCode = (hashCode * 59) + this.EnableWO.GetHashCode();
                hashCode = (hashCode * 59) + this.ChangeablePrioritySetDefault.GetHashCode();
                hashCode = (hashCode * 59) + this.AllowChangeableCurrency.GetHashCode();
                hashCode = (hashCode * 59) + this.AvoidDispatching.GetHashCode();
                hashCode = (hashCode * 59) + this.EnableLabels.GetHashCode();
                hashCode = (hashCode * 59) + this.LabelsAsSelectOnly.GetHashCode();
                hashCode = (hashCode * 59) + this.EditWeatherType.GetHashCode();
                hashCode = (hashCode * 59) + this.ChangeableGlCode.GetHashCode();
                hashCode = (hashCode * 59) + this.MaintainOrDecreasePriority.GetHashCode();
                hashCode = (hashCode * 59) + this.ShowAsset.GetHashCode();
                hashCode = (hashCode * 59) + this.EnableAssignee.GetHashCode();
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
