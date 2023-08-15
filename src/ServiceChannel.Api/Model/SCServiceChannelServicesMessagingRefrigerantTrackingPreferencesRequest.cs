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
    /// SCServiceChannelServicesMessagingRefrigerantTrackingPreferencesRequest
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.RefrigerantTracking.PreferencesRequest")]
    public partial class SCServiceChannelServicesMessagingRefrigerantTrackingPreferencesRequest : IEquatable<SCServiceChannelServicesMessagingRefrigerantTrackingPreferencesRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingRefrigerantTrackingPreferencesRequest" /> class.
        /// </summary>
        /// <param name="subscriberId">subscriberId.</param>
        /// <param name="chargeThreshold">chargeThreshold.</param>
        /// <param name="comercialRefTriggerRate">comercialRefTriggerRate.</param>
        /// <param name="industrialRefTriggerRate">industrialRefTriggerRate.</param>
        /// <param name="hVACTriggerRate">hVACTriggerRate.</param>
        /// <param name="othersTriggerRate">othersTriggerRate.</param>
        /// <param name="createDate">createDate.</param>
        /// <param name="userId">userId.</param>
        /// <param name="userName">userName.</param>
        /// <param name="maxThreshold">maxThreshold.</param>
        /// <param name="calculationMethod">calculationMethod.</param>
        /// <param name="calculationMethods">calculationMethods.</param>
        /// <param name="unitsOfMeasure">unitsOfMeasure.</param>
        /// <param name="unitsOfMeasures">unitsOfMeasures.</param>
        /// <param name="inventoryLocation">inventoryLocation.</param>
        /// <param name="inventoryLocationOptions">inventoryLocationOptions.</param>
        /// <param name="refrigerationPriorityName">refrigerationPriorityName.</param>
        /// <param name="refrigerationPriorityNameOptions">refrigerationPriorityNameOptions.</param>
        /// <param name="generateFollowUpWorkOrders">generateFollowUpWorkOrders.</param>
        /// <param name="runCARBReport">runCARBReport (default to false).</param>
        /// <param name="leakInspectionNTE">leakInspectionNTE.</param>
        /// <param name="generateFollowUpWorkOrder">generateFollowUpWorkOrder.</param>
        /// <param name="maxLocCount">maxLocCount.</param>
        /// <param name="rtLimitedApplianceId">rtLimitedApplianceId.</param>
        /// <param name="rtLimitedApplianceName">rtLimitedApplianceName.</param>
        /// <param name="refrigerantTrackingProviderId">refrigerantTrackingProviderId.</param>
        /// <param name="refrigerantTrackingProviderName">refrigerantTrackingProviderName.</param>
        /// <param name="oDSRefrigerantTypes">oDSRefrigerantTypes.</param>
        /// <param name="generateLeakInspectionOption">generateLeakInspectionOption.</param>
        /// <param name="calendarStartDate">calendarStartDate.</param>
        /// <param name="enableCARBInspections">enableCARBInspections (default to false).</param>
        public SCServiceChannelServicesMessagingRefrigerantTrackingPreferencesRequest(int subscriberId = default(int), double chargeThreshold = default(double), double comercialRefTriggerRate = default(double), double industrialRefTriggerRate = default(double), double hVACTriggerRate = default(double), double othersTriggerRate = default(double), DateTime createDate = default(DateTime), int userId = default(int), string userName = default(string), SCServiceChannelServicesMessagingRefrigerantTrackingMaxThreshold maxThreshold = default(SCServiceChannelServicesMessagingRefrigerantTrackingMaxThreshold), byte[] calculationMethod = default(byte[]), Dictionary<string, string> calculationMethods = default(Dictionary<string, string>), byte[] unitsOfMeasure = default(byte[]), Dictionary<string, string> unitsOfMeasures = default(Dictionary<string, string>), byte[] inventoryLocation = default(byte[]), Dictionary<string, string> inventoryLocationOptions = default(Dictionary<string, string>), string refrigerationPriorityName = default(string), List<string> refrigerationPriorityNameOptions = default(List<string>), Dictionary<string, string> generateFollowUpWorkOrders = default(Dictionary<string, string>), bool runCARBReport = false, double leakInspectionNTE = default(double), string generateFollowUpWorkOrder = default(string), int maxLocCount = default(int), byte[] rtLimitedApplianceId = default(byte[]), string rtLimitedApplianceName = default(string), int refrigerantTrackingProviderId = default(int), string refrigerantTrackingProviderName = default(string), List<int> oDSRefrigerantTypes = default(List<int>), string generateLeakInspectionOption = default(string), DateTime calendarStartDate = default(DateTime), bool enableCARBInspections = false)
        {
            this.SubscriberId = subscriberId;
            this.ChargeThreshold = chargeThreshold;
            this.ComercialRefTriggerRate = comercialRefTriggerRate;
            this.IndustrialRefTriggerRate = industrialRefTriggerRate;
            this.HVACTriggerRate = hVACTriggerRate;
            this.OthersTriggerRate = othersTriggerRate;
            this.CreateDate = createDate;
            this.UserId = userId;
            this.UserName = userName;
            this.MaxThreshold = maxThreshold;
            this.CalculationMethod = calculationMethod;
            this.CalculationMethods = calculationMethods;
            this.UnitsOfMeasure = unitsOfMeasure;
            this.UnitsOfMeasures = unitsOfMeasures;
            this.InventoryLocation = inventoryLocation;
            this.InventoryLocationOptions = inventoryLocationOptions;
            this.RefrigerationPriorityName = refrigerationPriorityName;
            this.RefrigerationPriorityNameOptions = refrigerationPriorityNameOptions;
            this.GenerateFollowUpWorkOrders = generateFollowUpWorkOrders;
            this.RunCARBReport = runCARBReport;
            this.LeakInspectionNTE = leakInspectionNTE;
            this.GenerateFollowUpWorkOrder = generateFollowUpWorkOrder;
            this.MaxLocCount = maxLocCount;
            this.RtLimitedApplianceId = rtLimitedApplianceId;
            this.RtLimitedApplianceName = rtLimitedApplianceName;
            this.RefrigerantTrackingProviderId = refrigerantTrackingProviderId;
            this.RefrigerantTrackingProviderName = refrigerantTrackingProviderName;
            this.ODSRefrigerantTypes = oDSRefrigerantTypes;
            this.GenerateLeakInspectionOption = generateLeakInspectionOption;
            this.CalendarStartDate = calendarStartDate;
            this.EnableCARBInspections = enableCARBInspections;
        }

        /// <summary>
        /// Gets or Sets SubscriberId
        /// </summary>
        [DataMember(Name = "SubscriberId", EmitDefaultValue = false)]
        public int SubscriberId { get; set; }

        /// <summary>
        /// Gets or Sets ChargeThreshold
        /// </summary>
        [DataMember(Name = "ChargeThreshold", EmitDefaultValue = false)]
        public double ChargeThreshold { get; set; }

        /// <summary>
        /// Gets or Sets ComercialRefTriggerRate
        /// </summary>
        [DataMember(Name = "ComercialRefTriggerRate", EmitDefaultValue = false)]
        public double ComercialRefTriggerRate { get; set; }

        /// <summary>
        /// Gets or Sets IndustrialRefTriggerRate
        /// </summary>
        [DataMember(Name = "IndustrialRefTriggerRate", EmitDefaultValue = false)]
        public double IndustrialRefTriggerRate { get; set; }

        /// <summary>
        /// Gets or Sets HVACTriggerRate
        /// </summary>
        [DataMember(Name = "HVACTriggerRate", EmitDefaultValue = false)]
        public double HVACTriggerRate { get; set; }

        /// <summary>
        /// Gets or Sets OthersTriggerRate
        /// </summary>
        [DataMember(Name = "OthersTriggerRate", EmitDefaultValue = false)]
        public double OthersTriggerRate { get; set; }

        /// <summary>
        /// Gets or Sets CreateDate
        /// </summary>
        [DataMember(Name = "CreateDate", EmitDefaultValue = false)]
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Gets or Sets CreateDateStr
        /// </summary>
        [DataMember(Name = "CreateDateStr", EmitDefaultValue = false)]
        public string CreateDateStr { get; private set; }

        /// <summary>
        /// Returns false as CreateDateStr should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreateDateStr()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "UserId", EmitDefaultValue = false)]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name = "UserName", EmitDefaultValue = false)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or Sets MaxThreshold
        /// </summary>
        [DataMember(Name = "MaxThreshold", EmitDefaultValue = false)]
        public SCServiceChannelServicesMessagingRefrigerantTrackingMaxThreshold MaxThreshold { get; set; }

        /// <summary>
        /// Gets or Sets CalculationMethod
        /// </summary>
        [DataMember(Name = "CalculationMethod", EmitDefaultValue = false)]
        public byte[] CalculationMethod { get; set; }

        /// <summary>
        /// Gets or Sets CalculationMethods
        /// </summary>
        [DataMember(Name = "CalculationMethods", EmitDefaultValue = false)]
        public Dictionary<string, string> CalculationMethods { get; set; }

        /// <summary>
        /// Gets or Sets UnitsOfMeasure
        /// </summary>
        [DataMember(Name = "UnitsOfMeasure", EmitDefaultValue = false)]
        public byte[] UnitsOfMeasure { get; set; }

        /// <summary>
        /// Gets or Sets UnitsOfMeasures
        /// </summary>
        [DataMember(Name = "UnitsOfMeasures", EmitDefaultValue = false)]
        public Dictionary<string, string> UnitsOfMeasures { get; set; }

        /// <summary>
        /// Gets or Sets InventoryLocation
        /// </summary>
        [DataMember(Name = "InventoryLocation", EmitDefaultValue = false)]
        public byte[] InventoryLocation { get; set; }

        /// <summary>
        /// Gets or Sets InventoryLocationOptions
        /// </summary>
        [DataMember(Name = "InventoryLocationOptions", EmitDefaultValue = false)]
        public Dictionary<string, string> InventoryLocationOptions { get; set; }

        /// <summary>
        /// Gets or Sets RefrigerationPriorityName
        /// </summary>
        [DataMember(Name = "RefrigerationPriorityName", EmitDefaultValue = false)]
        public string RefrigerationPriorityName { get; set; }

        /// <summary>
        /// Gets or Sets RefrigerationPriorityNameOptions
        /// </summary>
        [DataMember(Name = "RefrigerationPriorityNameOptions", EmitDefaultValue = false)]
        public List<string> RefrigerationPriorityNameOptions { get; set; }

        /// <summary>
        /// Gets or Sets GenerateFollowUpWorkOrders
        /// </summary>
        [DataMember(Name = "GenerateFollowUpWorkOrders", EmitDefaultValue = false)]
        public Dictionary<string, string> GenerateFollowUpWorkOrders { get; set; }

        /// <summary>
        /// Gets or Sets ChargeThresholdStr
        /// </summary>
        [DataMember(Name = "ChargeThresholdStr", EmitDefaultValue = false)]
        public string ChargeThresholdStr { get; private set; }

        /// <summary>
        /// Returns false as ChargeThresholdStr should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeChargeThresholdStr()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets RunCARBReport
        /// </summary>
        [DataMember(Name = "RunCARBReport", EmitDefaultValue = true)]
        public bool RunCARBReport { get; set; }

        /// <summary>
        /// Gets or Sets LeakInspectionNTE
        /// </summary>
        [DataMember(Name = "LeakInspectionNTE", EmitDefaultValue = false)]
        public double LeakInspectionNTE { get; set; }

        /// <summary>
        /// Gets or Sets GenerateFollowUpWorkOrder
        /// </summary>
        [DataMember(Name = "GenerateFollowUpWorkOrder", EmitDefaultValue = false)]
        public string GenerateFollowUpWorkOrder { get; set; }

        /// <summary>
        /// Gets or Sets MaxLocCount
        /// </summary>
        [DataMember(Name = "MaxLocCount", EmitDefaultValue = false)]
        public int MaxLocCount { get; set; }

        /// <summary>
        /// Gets or Sets RtLimitedApplianceId
        /// </summary>
        [DataMember(Name = "RtLimitedApplianceId", EmitDefaultValue = false)]
        public byte[] RtLimitedApplianceId { get; set; }

        /// <summary>
        /// Gets or Sets RtLimitedApplianceName
        /// </summary>
        [DataMember(Name = "RtLimitedApplianceName", EmitDefaultValue = false)]
        public string RtLimitedApplianceName { get; set; }

        /// <summary>
        /// Gets or Sets RefrigerantTrackingProviderId
        /// </summary>
        [DataMember(Name = "RefrigerantTrackingProviderId", EmitDefaultValue = false)]
        public int RefrigerantTrackingProviderId { get; set; }

        /// <summary>
        /// Gets or Sets RefrigerantTrackingProviderName
        /// </summary>
        [DataMember(Name = "RefrigerantTrackingProviderName", EmitDefaultValue = false)]
        public string RefrigerantTrackingProviderName { get; set; }

        /// <summary>
        /// Gets or Sets ODSRefrigerantTypes
        /// </summary>
        [DataMember(Name = "ODSRefrigerantTypes", EmitDefaultValue = false)]
        public List<int> ODSRefrigerantTypes { get; set; }

        /// <summary>
        /// Gets or Sets GenerateLeakInspectionOption
        /// </summary>
        [DataMember(Name = "GenerateLeakInspectionOption", EmitDefaultValue = false)]
        public string GenerateLeakInspectionOption { get; set; }

        /// <summary>
        /// Gets or Sets CalendarStartDate
        /// </summary>
        [DataMember(Name = "CalendarStartDate", EmitDefaultValue = false)]
        public DateTime CalendarStartDate { get; set; }

        /// <summary>
        /// Gets or Sets CalendarStartDateStr
        /// </summary>
        [DataMember(Name = "CalendarStartDateStr", EmitDefaultValue = false)]
        public string CalendarStartDateStr { get; private set; }

        /// <summary>
        /// Returns false as CalendarStartDateStr should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCalendarStartDateStr()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets EnableCARBInspections
        /// </summary>
        [DataMember(Name = "EnableCARBInspections", EmitDefaultValue = true)]
        public bool EnableCARBInspections { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingRefrigerantTrackingPreferencesRequest {\n");
            sb.Append("  SubscriberId: ").Append(SubscriberId).Append("\n");
            sb.Append("  ChargeThreshold: ").Append(ChargeThreshold).Append("\n");
            sb.Append("  ComercialRefTriggerRate: ").Append(ComercialRefTriggerRate).Append("\n");
            sb.Append("  IndustrialRefTriggerRate: ").Append(IndustrialRefTriggerRate).Append("\n");
            sb.Append("  HVACTriggerRate: ").Append(HVACTriggerRate).Append("\n");
            sb.Append("  OthersTriggerRate: ").Append(OthersTriggerRate).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  CreateDateStr: ").Append(CreateDateStr).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  MaxThreshold: ").Append(MaxThreshold).Append("\n");
            sb.Append("  CalculationMethod: ").Append(CalculationMethod).Append("\n");
            sb.Append("  CalculationMethods: ").Append(CalculationMethods).Append("\n");
            sb.Append("  UnitsOfMeasure: ").Append(UnitsOfMeasure).Append("\n");
            sb.Append("  UnitsOfMeasures: ").Append(UnitsOfMeasures).Append("\n");
            sb.Append("  InventoryLocation: ").Append(InventoryLocation).Append("\n");
            sb.Append("  InventoryLocationOptions: ").Append(InventoryLocationOptions).Append("\n");
            sb.Append("  RefrigerationPriorityName: ").Append(RefrigerationPriorityName).Append("\n");
            sb.Append("  RefrigerationPriorityNameOptions: ").Append(RefrigerationPriorityNameOptions).Append("\n");
            sb.Append("  GenerateFollowUpWorkOrders: ").Append(GenerateFollowUpWorkOrders).Append("\n");
            sb.Append("  ChargeThresholdStr: ").Append(ChargeThresholdStr).Append("\n");
            sb.Append("  RunCARBReport: ").Append(RunCARBReport).Append("\n");
            sb.Append("  LeakInspectionNTE: ").Append(LeakInspectionNTE).Append("\n");
            sb.Append("  GenerateFollowUpWorkOrder: ").Append(GenerateFollowUpWorkOrder).Append("\n");
            sb.Append("  MaxLocCount: ").Append(MaxLocCount).Append("\n");
            sb.Append("  RtLimitedApplianceId: ").Append(RtLimitedApplianceId).Append("\n");
            sb.Append("  RtLimitedApplianceName: ").Append(RtLimitedApplianceName).Append("\n");
            sb.Append("  RefrigerantTrackingProviderId: ").Append(RefrigerantTrackingProviderId).Append("\n");
            sb.Append("  RefrigerantTrackingProviderName: ").Append(RefrigerantTrackingProviderName).Append("\n");
            sb.Append("  ODSRefrigerantTypes: ").Append(ODSRefrigerantTypes).Append("\n");
            sb.Append("  GenerateLeakInspectionOption: ").Append(GenerateLeakInspectionOption).Append("\n");
            sb.Append("  CalendarStartDate: ").Append(CalendarStartDate).Append("\n");
            sb.Append("  CalendarStartDateStr: ").Append(CalendarStartDateStr).Append("\n");
            sb.Append("  EnableCARBInspections: ").Append(EnableCARBInspections).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingRefrigerantTrackingPreferencesRequest);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingRefrigerantTrackingPreferencesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingRefrigerantTrackingPreferencesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingRefrigerantTrackingPreferencesRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SubscriberId == input.SubscriberId ||
                    this.SubscriberId.Equals(input.SubscriberId)
                ) && 
                (
                    this.ChargeThreshold == input.ChargeThreshold ||
                    this.ChargeThreshold.Equals(input.ChargeThreshold)
                ) && 
                (
                    this.ComercialRefTriggerRate == input.ComercialRefTriggerRate ||
                    this.ComercialRefTriggerRate.Equals(input.ComercialRefTriggerRate)
                ) && 
                (
                    this.IndustrialRefTriggerRate == input.IndustrialRefTriggerRate ||
                    this.IndustrialRefTriggerRate.Equals(input.IndustrialRefTriggerRate)
                ) && 
                (
                    this.HVACTriggerRate == input.HVACTriggerRate ||
                    this.HVACTriggerRate.Equals(input.HVACTriggerRate)
                ) && 
                (
                    this.OthersTriggerRate == input.OthersTriggerRate ||
                    this.OthersTriggerRate.Equals(input.OthersTriggerRate)
                ) && 
                (
                    this.CreateDate == input.CreateDate ||
                    (this.CreateDate != null &&
                    this.CreateDate.Equals(input.CreateDate))
                ) && 
                (
                    this.CreateDateStr == input.CreateDateStr ||
                    (this.CreateDateStr != null &&
                    this.CreateDateStr.Equals(input.CreateDateStr))
                ) && 
                (
                    this.UserId == input.UserId ||
                    this.UserId.Equals(input.UserId)
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.MaxThreshold == input.MaxThreshold ||
                    (this.MaxThreshold != null &&
                    this.MaxThreshold.Equals(input.MaxThreshold))
                ) && 
                (
                    this.CalculationMethod == input.CalculationMethod ||
                    (this.CalculationMethod != null &&
                    this.CalculationMethod.Equals(input.CalculationMethod))
                ) && 
                (
                    this.CalculationMethods == input.CalculationMethods ||
                    this.CalculationMethods != null &&
                    input.CalculationMethods != null &&
                    this.CalculationMethods.SequenceEqual(input.CalculationMethods)
                ) && 
                (
                    this.UnitsOfMeasure == input.UnitsOfMeasure ||
                    (this.UnitsOfMeasure != null &&
                    this.UnitsOfMeasure.Equals(input.UnitsOfMeasure))
                ) && 
                (
                    this.UnitsOfMeasures == input.UnitsOfMeasures ||
                    this.UnitsOfMeasures != null &&
                    input.UnitsOfMeasures != null &&
                    this.UnitsOfMeasures.SequenceEqual(input.UnitsOfMeasures)
                ) && 
                (
                    this.InventoryLocation == input.InventoryLocation ||
                    (this.InventoryLocation != null &&
                    this.InventoryLocation.Equals(input.InventoryLocation))
                ) && 
                (
                    this.InventoryLocationOptions == input.InventoryLocationOptions ||
                    this.InventoryLocationOptions != null &&
                    input.InventoryLocationOptions != null &&
                    this.InventoryLocationOptions.SequenceEqual(input.InventoryLocationOptions)
                ) && 
                (
                    this.RefrigerationPriorityName == input.RefrigerationPriorityName ||
                    (this.RefrigerationPriorityName != null &&
                    this.RefrigerationPriorityName.Equals(input.RefrigerationPriorityName))
                ) && 
                (
                    this.RefrigerationPriorityNameOptions == input.RefrigerationPriorityNameOptions ||
                    this.RefrigerationPriorityNameOptions != null &&
                    input.RefrigerationPriorityNameOptions != null &&
                    this.RefrigerationPriorityNameOptions.SequenceEqual(input.RefrigerationPriorityNameOptions)
                ) && 
                (
                    this.GenerateFollowUpWorkOrders == input.GenerateFollowUpWorkOrders ||
                    this.GenerateFollowUpWorkOrders != null &&
                    input.GenerateFollowUpWorkOrders != null &&
                    this.GenerateFollowUpWorkOrders.SequenceEqual(input.GenerateFollowUpWorkOrders)
                ) && 
                (
                    this.ChargeThresholdStr == input.ChargeThresholdStr ||
                    (this.ChargeThresholdStr != null &&
                    this.ChargeThresholdStr.Equals(input.ChargeThresholdStr))
                ) && 
                (
                    this.RunCARBReport == input.RunCARBReport ||
                    this.RunCARBReport.Equals(input.RunCARBReport)
                ) && 
                (
                    this.LeakInspectionNTE == input.LeakInspectionNTE ||
                    this.LeakInspectionNTE.Equals(input.LeakInspectionNTE)
                ) && 
                (
                    this.GenerateFollowUpWorkOrder == input.GenerateFollowUpWorkOrder ||
                    (this.GenerateFollowUpWorkOrder != null &&
                    this.GenerateFollowUpWorkOrder.Equals(input.GenerateFollowUpWorkOrder))
                ) && 
                (
                    this.MaxLocCount == input.MaxLocCount ||
                    this.MaxLocCount.Equals(input.MaxLocCount)
                ) && 
                (
                    this.RtLimitedApplianceId == input.RtLimitedApplianceId ||
                    (this.RtLimitedApplianceId != null &&
                    this.RtLimitedApplianceId.Equals(input.RtLimitedApplianceId))
                ) && 
                (
                    this.RtLimitedApplianceName == input.RtLimitedApplianceName ||
                    (this.RtLimitedApplianceName != null &&
                    this.RtLimitedApplianceName.Equals(input.RtLimitedApplianceName))
                ) && 
                (
                    this.RefrigerantTrackingProviderId == input.RefrigerantTrackingProviderId ||
                    this.RefrigerantTrackingProviderId.Equals(input.RefrigerantTrackingProviderId)
                ) && 
                (
                    this.RefrigerantTrackingProviderName == input.RefrigerantTrackingProviderName ||
                    (this.RefrigerantTrackingProviderName != null &&
                    this.RefrigerantTrackingProviderName.Equals(input.RefrigerantTrackingProviderName))
                ) && 
                (
                    this.ODSRefrigerantTypes == input.ODSRefrigerantTypes ||
                    this.ODSRefrigerantTypes != null &&
                    input.ODSRefrigerantTypes != null &&
                    this.ODSRefrigerantTypes.SequenceEqual(input.ODSRefrigerantTypes)
                ) && 
                (
                    this.GenerateLeakInspectionOption == input.GenerateLeakInspectionOption ||
                    (this.GenerateLeakInspectionOption != null &&
                    this.GenerateLeakInspectionOption.Equals(input.GenerateLeakInspectionOption))
                ) && 
                (
                    this.CalendarStartDate == input.CalendarStartDate ||
                    (this.CalendarStartDate != null &&
                    this.CalendarStartDate.Equals(input.CalendarStartDate))
                ) && 
                (
                    this.CalendarStartDateStr == input.CalendarStartDateStr ||
                    (this.CalendarStartDateStr != null &&
                    this.CalendarStartDateStr.Equals(input.CalendarStartDateStr))
                ) && 
                (
                    this.EnableCARBInspections == input.EnableCARBInspections ||
                    this.EnableCARBInspections.Equals(input.EnableCARBInspections)
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
                hashCode = (hashCode * 59) + this.SubscriberId.GetHashCode();
                hashCode = (hashCode * 59) + this.ChargeThreshold.GetHashCode();
                hashCode = (hashCode * 59) + this.ComercialRefTriggerRate.GetHashCode();
                hashCode = (hashCode * 59) + this.IndustrialRefTriggerRate.GetHashCode();
                hashCode = (hashCode * 59) + this.HVACTriggerRate.GetHashCode();
                hashCode = (hashCode * 59) + this.OthersTriggerRate.GetHashCode();
                if (this.CreateDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreateDate.GetHashCode();
                }
                if (this.CreateDateStr != null)
                {
                    hashCode = (hashCode * 59) + this.CreateDateStr.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                if (this.UserName != null)
                {
                    hashCode = (hashCode * 59) + this.UserName.GetHashCode();
                }
                if (this.MaxThreshold != null)
                {
                    hashCode = (hashCode * 59) + this.MaxThreshold.GetHashCode();
                }
                if (this.CalculationMethod != null)
                {
                    hashCode = (hashCode * 59) + this.CalculationMethod.GetHashCode();
                }
                if (this.CalculationMethods != null)
                {
                    hashCode = (hashCode * 59) + this.CalculationMethods.GetHashCode();
                }
                if (this.UnitsOfMeasure != null)
                {
                    hashCode = (hashCode * 59) + this.UnitsOfMeasure.GetHashCode();
                }
                if (this.UnitsOfMeasures != null)
                {
                    hashCode = (hashCode * 59) + this.UnitsOfMeasures.GetHashCode();
                }
                if (this.InventoryLocation != null)
                {
                    hashCode = (hashCode * 59) + this.InventoryLocation.GetHashCode();
                }
                if (this.InventoryLocationOptions != null)
                {
                    hashCode = (hashCode * 59) + this.InventoryLocationOptions.GetHashCode();
                }
                if (this.RefrigerationPriorityName != null)
                {
                    hashCode = (hashCode * 59) + this.RefrigerationPriorityName.GetHashCode();
                }
                if (this.RefrigerationPriorityNameOptions != null)
                {
                    hashCode = (hashCode * 59) + this.RefrigerationPriorityNameOptions.GetHashCode();
                }
                if (this.GenerateFollowUpWorkOrders != null)
                {
                    hashCode = (hashCode * 59) + this.GenerateFollowUpWorkOrders.GetHashCode();
                }
                if (this.ChargeThresholdStr != null)
                {
                    hashCode = (hashCode * 59) + this.ChargeThresholdStr.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RunCARBReport.GetHashCode();
                hashCode = (hashCode * 59) + this.LeakInspectionNTE.GetHashCode();
                if (this.GenerateFollowUpWorkOrder != null)
                {
                    hashCode = (hashCode * 59) + this.GenerateFollowUpWorkOrder.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MaxLocCount.GetHashCode();
                if (this.RtLimitedApplianceId != null)
                {
                    hashCode = (hashCode * 59) + this.RtLimitedApplianceId.GetHashCode();
                }
                if (this.RtLimitedApplianceName != null)
                {
                    hashCode = (hashCode * 59) + this.RtLimitedApplianceName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RefrigerantTrackingProviderId.GetHashCode();
                if (this.RefrigerantTrackingProviderName != null)
                {
                    hashCode = (hashCode * 59) + this.RefrigerantTrackingProviderName.GetHashCode();
                }
                if (this.ODSRefrigerantTypes != null)
                {
                    hashCode = (hashCode * 59) + this.ODSRefrigerantTypes.GetHashCode();
                }
                if (this.GenerateLeakInspectionOption != null)
                {
                    hashCode = (hashCode * 59) + this.GenerateLeakInspectionOption.GetHashCode();
                }
                if (this.CalendarStartDate != null)
                {
                    hashCode = (hashCode * 59) + this.CalendarStartDate.GetHashCode();
                }
                if (this.CalendarStartDateStr != null)
                {
                    hashCode = (hashCode * 59) + this.CalendarStartDateStr.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EnableCARBInspections.GetHashCode();
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