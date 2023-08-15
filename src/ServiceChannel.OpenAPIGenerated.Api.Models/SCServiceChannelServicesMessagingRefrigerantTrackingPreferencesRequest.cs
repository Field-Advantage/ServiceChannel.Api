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
    public class SCServiceChannelServicesMessagingRefrigerantTrackingPreferencesRequest : IEquatable<SCServiceChannelServicesMessagingRefrigerantTrackingPreferencesRequest>
    {
        /// <summary>
        /// Gets or Sets SubscriberId
        /// </summary>
        [DataMember(Name="SubscriberId", EmitDefaultValue=true)]
        public int SubscriberId { get; set; }

        /// <summary>
        /// Gets or Sets ChargeThreshold
        /// </summary>
        [DataMember(Name="ChargeThreshold", EmitDefaultValue=true)]
        public double ChargeThreshold { get; set; }

        /// <summary>
        /// Gets or Sets ComercialRefTriggerRate
        /// </summary>
        [DataMember(Name="ComercialRefTriggerRate", EmitDefaultValue=true)]
        public double ComercialRefTriggerRate { get; set; }

        /// <summary>
        /// Gets or Sets IndustrialRefTriggerRate
        /// </summary>
        [DataMember(Name="IndustrialRefTriggerRate", EmitDefaultValue=true)]
        public double IndustrialRefTriggerRate { get; set; }

        /// <summary>
        /// Gets or Sets HVACTriggerRate
        /// </summary>
        [DataMember(Name="HVACTriggerRate", EmitDefaultValue=true)]
        public double HVACTriggerRate { get; set; }

        /// <summary>
        /// Gets or Sets OthersTriggerRate
        /// </summary>
        [DataMember(Name="OthersTriggerRate", EmitDefaultValue=true)]
        public double OthersTriggerRate { get; set; }

        /// <summary>
        /// Gets or Sets CreateDate
        /// </summary>
        [DataMember(Name="CreateDate", EmitDefaultValue=false)]
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Gets or Sets CreateDateStr
        /// </summary>
        [DataMember(Name="CreateDateStr", EmitDefaultValue=false)]
        public string CreateDateStr { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="UserId", EmitDefaultValue=true)]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="UserName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or Sets MaxThreshold
        /// </summary>
        [DataMember(Name="MaxThreshold", EmitDefaultValue=false)]
        public SCServiceChannelServicesMessagingRefrigerantTrackingMaxThreshold MaxThreshold { get; set; }

        /// <summary>
        /// Gets or Sets CalculationMethod
        /// </summary>
        [RegularExpression("^(?:[A-Za-z0-9+/]{4})*(?:[A-Za-z0-9+/]{2}==|[A-Za-z0-9+/]{3}=)?$")]
        [DataMember(Name="CalculationMethod", EmitDefaultValue=false)]
        public byte[] CalculationMethod { get; set; }

        /// <summary>
        /// Gets or Sets CalculationMethods
        /// </summary>
        [DataMember(Name="CalculationMethods", EmitDefaultValue=false)]
        public Dictionary<string, string> CalculationMethods { get; set; }

        /// <summary>
        /// Gets or Sets UnitsOfMeasure
        /// </summary>
        [RegularExpression("^(?:[A-Za-z0-9+/]{4})*(?:[A-Za-z0-9+/]{2}==|[A-Za-z0-9+/]{3}=)?$")]
        [DataMember(Name="UnitsOfMeasure", EmitDefaultValue=false)]
        public byte[] UnitsOfMeasure { get; set; }

        /// <summary>
        /// Gets or Sets UnitsOfMeasures
        /// </summary>
        [DataMember(Name="UnitsOfMeasures", EmitDefaultValue=false)]
        public Dictionary<string, string> UnitsOfMeasures { get; set; }

        /// <summary>
        /// Gets or Sets InventoryLocation
        /// </summary>
        [RegularExpression("^(?:[A-Za-z0-9+/]{4})*(?:[A-Za-z0-9+/]{2}==|[A-Za-z0-9+/]{3}=)?$")]
        [DataMember(Name="InventoryLocation", EmitDefaultValue=false)]
        public byte[] InventoryLocation { get; set; }

        /// <summary>
        /// Gets or Sets InventoryLocationOptions
        /// </summary>
        [DataMember(Name="InventoryLocationOptions", EmitDefaultValue=false)]
        public Dictionary<string, string> InventoryLocationOptions { get; set; }

        /// <summary>
        /// Gets or Sets RefrigerationPriorityName
        /// </summary>
        [DataMember(Name="RefrigerationPriorityName", EmitDefaultValue=false)]
        public string RefrigerationPriorityName { get; set; }

        /// <summary>
        /// Gets or Sets RefrigerationPriorityNameOptions
        /// </summary>
        [DataMember(Name="RefrigerationPriorityNameOptions", EmitDefaultValue=false)]
        public List<string> RefrigerationPriorityNameOptions { get; set; }

        /// <summary>
        /// Gets or Sets GenerateFollowUpWorkOrders
        /// </summary>
        [DataMember(Name="GenerateFollowUpWorkOrders", EmitDefaultValue=false)]
        public Dictionary<string, string> GenerateFollowUpWorkOrders { get; set; }

        /// <summary>
        /// Gets or Sets ChargeThresholdStr
        /// </summary>
        [DataMember(Name="ChargeThresholdStr", EmitDefaultValue=false)]
        public string ChargeThresholdStr { get; set; }

        /// <summary>
        /// Gets or Sets RunCARBReport
        /// </summary>
        [DataMember(Name="RunCARBReport", EmitDefaultValue=true)]
        public bool RunCARBReport { get; set; } = false;

        /// <summary>
        /// Gets or Sets LeakInspectionNTE
        /// </summary>
        [DataMember(Name="LeakInspectionNTE", EmitDefaultValue=true)]
        public double LeakInspectionNTE { get; set; }

        /// <summary>
        /// Gets or Sets GenerateFollowUpWorkOrder
        /// </summary>
        [DataMember(Name="GenerateFollowUpWorkOrder", EmitDefaultValue=false)]
        public string GenerateFollowUpWorkOrder { get; set; }

        /// <summary>
        /// Gets or Sets MaxLocCount
        /// </summary>
        [DataMember(Name="MaxLocCount", EmitDefaultValue=true)]
        public int MaxLocCount { get; set; }

        /// <summary>
        /// Gets or Sets RtLimitedApplianceId
        /// </summary>
        [RegularExpression("^(?:[A-Za-z0-9+/]{4})*(?:[A-Za-z0-9+/]{2}==|[A-Za-z0-9+/]{3}=)?$")]
        [DataMember(Name="RtLimitedApplianceId", EmitDefaultValue=false)]
        public byte[] RtLimitedApplianceId { get; set; }

        /// <summary>
        /// Gets or Sets RtLimitedApplianceName
        /// </summary>
        [DataMember(Name="RtLimitedApplianceName", EmitDefaultValue=false)]
        public string RtLimitedApplianceName { get; set; }

        /// <summary>
        /// Gets or Sets RefrigerantTrackingProviderId
        /// </summary>
        [DataMember(Name="RefrigerantTrackingProviderId", EmitDefaultValue=true)]
        public int RefrigerantTrackingProviderId { get; set; }

        /// <summary>
        /// Gets or Sets RefrigerantTrackingProviderName
        /// </summary>
        [DataMember(Name="RefrigerantTrackingProviderName", EmitDefaultValue=false)]
        public string RefrigerantTrackingProviderName { get; set; }

        /// <summary>
        /// Gets or Sets ODSRefrigerantTypes
        /// </summary>
        [DataMember(Name="ODSRefrigerantTypes", EmitDefaultValue=false)]
        public List<int> ODSRefrigerantTypes { get; set; }

        /// <summary>
        /// Gets or Sets GenerateLeakInspectionOption
        /// </summary>
        [DataMember(Name="GenerateLeakInspectionOption", EmitDefaultValue=false)]
        public string GenerateLeakInspectionOption { get; set; }

        /// <summary>
        /// Gets or Sets CalendarStartDate
        /// </summary>
        [DataMember(Name="CalendarStartDate", EmitDefaultValue=false)]
        public DateTime CalendarStartDate { get; set; }

        /// <summary>
        /// Gets or Sets CalendarStartDateStr
        /// </summary>
        [DataMember(Name="CalendarStartDateStr", EmitDefaultValue=false)]
        public string CalendarStartDateStr { get; set; }

        /// <summary>
        /// Gets or Sets EnableCARBInspections
        /// </summary>
        [DataMember(Name="EnableCARBInspections", EmitDefaultValue=true)]
        public bool EnableCARBInspections { get; set; } = false;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingRefrigerantTrackingPreferencesRequest)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingRefrigerantTrackingPreferencesRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingRefrigerantTrackingPreferencesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingRefrigerantTrackingPreferencesRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    SubscriberId == other.SubscriberId ||
                    
                    SubscriberId.Equals(other.SubscriberId)
                ) && 
                (
                    ChargeThreshold == other.ChargeThreshold ||
                    
                    ChargeThreshold.Equals(other.ChargeThreshold)
                ) && 
                (
                    ComercialRefTriggerRate == other.ComercialRefTriggerRate ||
                    
                    ComercialRefTriggerRate.Equals(other.ComercialRefTriggerRate)
                ) && 
                (
                    IndustrialRefTriggerRate == other.IndustrialRefTriggerRate ||
                    
                    IndustrialRefTriggerRate.Equals(other.IndustrialRefTriggerRate)
                ) && 
                (
                    HVACTriggerRate == other.HVACTriggerRate ||
                    
                    HVACTriggerRate.Equals(other.HVACTriggerRate)
                ) && 
                (
                    OthersTriggerRate == other.OthersTriggerRate ||
                    
                    OthersTriggerRate.Equals(other.OthersTriggerRate)
                ) && 
                (
                    CreateDate == other.CreateDate ||
                    CreateDate != null &&
                    CreateDate.Equals(other.CreateDate)
                ) && 
                (
                    CreateDateStr == other.CreateDateStr ||
                    CreateDateStr != null &&
                    CreateDateStr.Equals(other.CreateDateStr)
                ) && 
                (
                    UserId == other.UserId ||
                    
                    UserId.Equals(other.UserId)
                ) && 
                (
                    UserName == other.UserName ||
                    UserName != null &&
                    UserName.Equals(other.UserName)
                ) && 
                (
                    MaxThreshold == other.MaxThreshold ||
                    MaxThreshold != null &&
                    MaxThreshold.Equals(other.MaxThreshold)
                ) && 
                (
                    CalculationMethod == other.CalculationMethod ||
                    CalculationMethod != null &&
                    CalculationMethod.Equals(other.CalculationMethod)
                ) && 
                (
                    CalculationMethods == other.CalculationMethods ||
                    CalculationMethods != null &&
                    other.CalculationMethods != null &&
                    CalculationMethods.SequenceEqual(other.CalculationMethods)
                ) && 
                (
                    UnitsOfMeasure == other.UnitsOfMeasure ||
                    UnitsOfMeasure != null &&
                    UnitsOfMeasure.Equals(other.UnitsOfMeasure)
                ) && 
                (
                    UnitsOfMeasures == other.UnitsOfMeasures ||
                    UnitsOfMeasures != null &&
                    other.UnitsOfMeasures != null &&
                    UnitsOfMeasures.SequenceEqual(other.UnitsOfMeasures)
                ) && 
                (
                    InventoryLocation == other.InventoryLocation ||
                    InventoryLocation != null &&
                    InventoryLocation.Equals(other.InventoryLocation)
                ) && 
                (
                    InventoryLocationOptions == other.InventoryLocationOptions ||
                    InventoryLocationOptions != null &&
                    other.InventoryLocationOptions != null &&
                    InventoryLocationOptions.SequenceEqual(other.InventoryLocationOptions)
                ) && 
                (
                    RefrigerationPriorityName == other.RefrigerationPriorityName ||
                    RefrigerationPriorityName != null &&
                    RefrigerationPriorityName.Equals(other.RefrigerationPriorityName)
                ) && 
                (
                    RefrigerationPriorityNameOptions == other.RefrigerationPriorityNameOptions ||
                    RefrigerationPriorityNameOptions != null &&
                    other.RefrigerationPriorityNameOptions != null &&
                    RefrigerationPriorityNameOptions.SequenceEqual(other.RefrigerationPriorityNameOptions)
                ) && 
                (
                    GenerateFollowUpWorkOrders == other.GenerateFollowUpWorkOrders ||
                    GenerateFollowUpWorkOrders != null &&
                    other.GenerateFollowUpWorkOrders != null &&
                    GenerateFollowUpWorkOrders.SequenceEqual(other.GenerateFollowUpWorkOrders)
                ) && 
                (
                    ChargeThresholdStr == other.ChargeThresholdStr ||
                    ChargeThresholdStr != null &&
                    ChargeThresholdStr.Equals(other.ChargeThresholdStr)
                ) && 
                (
                    RunCARBReport == other.RunCARBReport ||
                    
                    RunCARBReport.Equals(other.RunCARBReport)
                ) && 
                (
                    LeakInspectionNTE == other.LeakInspectionNTE ||
                    
                    LeakInspectionNTE.Equals(other.LeakInspectionNTE)
                ) && 
                (
                    GenerateFollowUpWorkOrder == other.GenerateFollowUpWorkOrder ||
                    GenerateFollowUpWorkOrder != null &&
                    GenerateFollowUpWorkOrder.Equals(other.GenerateFollowUpWorkOrder)
                ) && 
                (
                    MaxLocCount == other.MaxLocCount ||
                    
                    MaxLocCount.Equals(other.MaxLocCount)
                ) && 
                (
                    RtLimitedApplianceId == other.RtLimitedApplianceId ||
                    RtLimitedApplianceId != null &&
                    RtLimitedApplianceId.Equals(other.RtLimitedApplianceId)
                ) && 
                (
                    RtLimitedApplianceName == other.RtLimitedApplianceName ||
                    RtLimitedApplianceName != null &&
                    RtLimitedApplianceName.Equals(other.RtLimitedApplianceName)
                ) && 
                (
                    RefrigerantTrackingProviderId == other.RefrigerantTrackingProviderId ||
                    
                    RefrigerantTrackingProviderId.Equals(other.RefrigerantTrackingProviderId)
                ) && 
                (
                    RefrigerantTrackingProviderName == other.RefrigerantTrackingProviderName ||
                    RefrigerantTrackingProviderName != null &&
                    RefrigerantTrackingProviderName.Equals(other.RefrigerantTrackingProviderName)
                ) && 
                (
                    ODSRefrigerantTypes == other.ODSRefrigerantTypes ||
                    ODSRefrigerantTypes != null &&
                    other.ODSRefrigerantTypes != null &&
                    ODSRefrigerantTypes.SequenceEqual(other.ODSRefrigerantTypes)
                ) && 
                (
                    GenerateLeakInspectionOption == other.GenerateLeakInspectionOption ||
                    GenerateLeakInspectionOption != null &&
                    GenerateLeakInspectionOption.Equals(other.GenerateLeakInspectionOption)
                ) && 
                (
                    CalendarStartDate == other.CalendarStartDate ||
                    CalendarStartDate != null &&
                    CalendarStartDate.Equals(other.CalendarStartDate)
                ) && 
                (
                    CalendarStartDateStr == other.CalendarStartDateStr ||
                    CalendarStartDateStr != null &&
                    CalendarStartDateStr.Equals(other.CalendarStartDateStr)
                ) && 
                (
                    EnableCARBInspections == other.EnableCARBInspections ||
                    
                    EnableCARBInspections.Equals(other.EnableCARBInspections)
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
                    
                    hashCode = hashCode * 59 + SubscriberId.GetHashCode();
                    
                    hashCode = hashCode * 59 + ChargeThreshold.GetHashCode();
                    
                    hashCode = hashCode * 59 + ComercialRefTriggerRate.GetHashCode();
                    
                    hashCode = hashCode * 59 + IndustrialRefTriggerRate.GetHashCode();
                    
                    hashCode = hashCode * 59 + HVACTriggerRate.GetHashCode();
                    
                    hashCode = hashCode * 59 + OthersTriggerRate.GetHashCode();
                    if (CreateDate != null)
                    hashCode = hashCode * 59 + CreateDate.GetHashCode();
                    if (CreateDateStr != null)
                    hashCode = hashCode * 59 + CreateDateStr.GetHashCode();
                    
                    hashCode = hashCode * 59 + UserId.GetHashCode();
                    if (UserName != null)
                    hashCode = hashCode * 59 + UserName.GetHashCode();
                    if (MaxThreshold != null)
                    hashCode = hashCode * 59 + MaxThreshold.GetHashCode();
                    if (CalculationMethod != null)
                    hashCode = hashCode * 59 + CalculationMethod.GetHashCode();
                    if (CalculationMethods != null)
                    hashCode = hashCode * 59 + CalculationMethods.GetHashCode();
                    if (UnitsOfMeasure != null)
                    hashCode = hashCode * 59 + UnitsOfMeasure.GetHashCode();
                    if (UnitsOfMeasures != null)
                    hashCode = hashCode * 59 + UnitsOfMeasures.GetHashCode();
                    if (InventoryLocation != null)
                    hashCode = hashCode * 59 + InventoryLocation.GetHashCode();
                    if (InventoryLocationOptions != null)
                    hashCode = hashCode * 59 + InventoryLocationOptions.GetHashCode();
                    if (RefrigerationPriorityName != null)
                    hashCode = hashCode * 59 + RefrigerationPriorityName.GetHashCode();
                    if (RefrigerationPriorityNameOptions != null)
                    hashCode = hashCode * 59 + RefrigerationPriorityNameOptions.GetHashCode();
                    if (GenerateFollowUpWorkOrders != null)
                    hashCode = hashCode * 59 + GenerateFollowUpWorkOrders.GetHashCode();
                    if (ChargeThresholdStr != null)
                    hashCode = hashCode * 59 + ChargeThresholdStr.GetHashCode();
                    
                    hashCode = hashCode * 59 + RunCARBReport.GetHashCode();
                    
                    hashCode = hashCode * 59 + LeakInspectionNTE.GetHashCode();
                    if (GenerateFollowUpWorkOrder != null)
                    hashCode = hashCode * 59 + GenerateFollowUpWorkOrder.GetHashCode();
                    
                    hashCode = hashCode * 59 + MaxLocCount.GetHashCode();
                    if (RtLimitedApplianceId != null)
                    hashCode = hashCode * 59 + RtLimitedApplianceId.GetHashCode();
                    if (RtLimitedApplianceName != null)
                    hashCode = hashCode * 59 + RtLimitedApplianceName.GetHashCode();
                    
                    hashCode = hashCode * 59 + RefrigerantTrackingProviderId.GetHashCode();
                    if (RefrigerantTrackingProviderName != null)
                    hashCode = hashCode * 59 + RefrigerantTrackingProviderName.GetHashCode();
                    if (ODSRefrigerantTypes != null)
                    hashCode = hashCode * 59 + ODSRefrigerantTypes.GetHashCode();
                    if (GenerateLeakInspectionOption != null)
                    hashCode = hashCode * 59 + GenerateLeakInspectionOption.GetHashCode();
                    if (CalendarStartDate != null)
                    hashCode = hashCode * 59 + CalendarStartDate.GetHashCode();
                    if (CalendarStartDateStr != null)
                    hashCode = hashCode * 59 + CalendarStartDateStr.GetHashCode();
                    
                    hashCode = hashCode * 59 + EnableCARBInspections.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingRefrigerantTrackingPreferencesRequest left, SCServiceChannelServicesMessagingRefrigerantTrackingPreferencesRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingRefrigerantTrackingPreferencesRequest left, SCServiceChannelServicesMessagingRefrigerantTrackingPreferencesRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}