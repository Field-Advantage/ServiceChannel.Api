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
    public class SCServiceChannelServicesMessagingRefrigerantTrackingEditAssetRefrigerantRequest : IEquatable<SCServiceChannelServicesMessagingRefrigerantTrackingEditAssetRefrigerantRequest>
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=true)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets AssetId
        /// </summary>
        [DataMember(Name="AssetId", EmitDefaultValue=true)]
        public int AssetId { get; set; }

        /// <summary>
        /// Gets or Sets RefrigerantUsageType
        /// </summary>
        [DataMember(Name="RefrigerantUsageType", EmitDefaultValue=true)]
        public int RefrigerantUsageType { get; set; }

        /// <summary>
        /// Gets or Sets RackId
        /// </summary>
        [DataMember(Name="RackId", EmitDefaultValue=false)]
        public string RackId { get; set; }

        /// <summary>
        /// Gets or Sets RackEntityId
        /// </summary>
        [DataMember(Name="RackEntityId", EmitDefaultValue=true)]
        public int RackEntityId { get; set; }

        /// <summary>
        /// Gets or Sets CarbID
        /// </summary>
        [DataMember(Name="CarbID", EmitDefaultValue=false)]
        public string CarbID { get; set; }

        /// <summary>
        /// Gets or Sets IsCarbReporting
        /// </summary>
        [DataMember(Name="IsCarbReporting", EmitDefaultValue=true)]
        public bool IsCarbReporting { get; set; } = false;

        /// <summary>
        /// Gets or Sets SystemLocation
        /// </summary>
        [RegularExpression("^(?:[A-Za-z0-9+/]{4})*(?:[A-Za-z0-9+/]{2}==|[A-Za-z0-9+/]{3}=)?$")]
        [DataMember(Name="SystemLocation", EmitDefaultValue=false)]
        public byte[] SystemLocation { get; set; }

        /// <summary>
        /// Gets or Sets OperationalStatus
        /// </summary>
        [RegularExpression("^(?:[A-Za-z0-9+/]{4})*(?:[A-Za-z0-9+/]{2}==|[A-Za-z0-9+/]{3}=)?$")]
        [DataMember(Name="OperationalStatus", EmitDefaultValue=false)]
        public byte[] OperationalStatus { get; set; }

        /// <summary>
        /// Gets or Sets PartNumberId
        /// </summary>
        [DataMember(Name="PartNumberId", EmitDefaultValue=true)]
        public int PartNumberId { get; set; }

        /// <summary>
        /// Gets or Sets RackTypeId
        /// </summary>
        [DataMember(Name="RackTypeId", EmitDefaultValue=true)]
        public int RackTypeId { get; set; }

        /// <summary>
        /// Gets or Sets CurrentCharge
        /// </summary>
        [DataMember(Name="CurrentCharge", EmitDefaultValue=true)]
        public double CurrentCharge { get; set; }

        /// <summary>
        /// Gets or Sets CurrentChargeOunces
        /// </summary>
        [DataMember(Name="CurrentChargeOunces", EmitDefaultValue=true)]
        public double CurrentChargeOunces { get; set; }

        /// <summary>
        /// Gets or Sets ChargeDescriptionId
        /// </summary>
        [DataMember(Name="ChargeDescriptionId", EmitDefaultValue=true)]
        public int ChargeDescriptionId { get; set; }

        /// <summary>
        /// Gets or Sets ChargeProviderName
        /// </summary>
        [DataMember(Name="ChargeProviderName", EmitDefaultValue=false)]
        public string ChargeProviderName { get; set; }

        /// <summary>
        /// Gets or Sets EffectiveChargeDate
        /// </summary>
        [DataMember(Name="EffectiveChargeDate", EmitDefaultValue=false)]
        public DateTime EffectiveChargeDate { get; set; }

        /// <summary>
        /// Gets or Sets HasLeakDetector
        /// </summary>
        [DataMember(Name="HasLeakDetector", EmitDefaultValue=true)]
        public bool HasLeakDetector { get; set; } = false;

        /// <summary>
        /// Gets or Sets AssetLeakDetectorId
        /// </summary>
        [DataMember(Name="AssetLeakDetectorId", EmitDefaultValue=true)]
        public int AssetLeakDetectorId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingRefrigerantTrackingEditAssetRefrigerantRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  RefrigerantUsageType: ").Append(RefrigerantUsageType).Append("\n");
            sb.Append("  RackId: ").Append(RackId).Append("\n");
            sb.Append("  RackEntityId: ").Append(RackEntityId).Append("\n");
            sb.Append("  CarbID: ").Append(CarbID).Append("\n");
            sb.Append("  IsCarbReporting: ").Append(IsCarbReporting).Append("\n");
            sb.Append("  SystemLocation: ").Append(SystemLocation).Append("\n");
            sb.Append("  OperationalStatus: ").Append(OperationalStatus).Append("\n");
            sb.Append("  PartNumberId: ").Append(PartNumberId).Append("\n");
            sb.Append("  RackTypeId: ").Append(RackTypeId).Append("\n");
            sb.Append("  CurrentCharge: ").Append(CurrentCharge).Append("\n");
            sb.Append("  CurrentChargeOunces: ").Append(CurrentChargeOunces).Append("\n");
            sb.Append("  ChargeDescriptionId: ").Append(ChargeDescriptionId).Append("\n");
            sb.Append("  ChargeProviderName: ").Append(ChargeProviderName).Append("\n");
            sb.Append("  EffectiveChargeDate: ").Append(EffectiveChargeDate).Append("\n");
            sb.Append("  HasLeakDetector: ").Append(HasLeakDetector).Append("\n");
            sb.Append("  AssetLeakDetectorId: ").Append(AssetLeakDetectorId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingRefrigerantTrackingEditAssetRefrigerantRequest)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingRefrigerantTrackingEditAssetRefrigerantRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingRefrigerantTrackingEditAssetRefrigerantRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingRefrigerantTrackingEditAssetRefrigerantRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    AssetId == other.AssetId ||
                    
                    AssetId.Equals(other.AssetId)
                ) && 
                (
                    RefrigerantUsageType == other.RefrigerantUsageType ||
                    
                    RefrigerantUsageType.Equals(other.RefrigerantUsageType)
                ) && 
                (
                    RackId == other.RackId ||
                    RackId != null &&
                    RackId.Equals(other.RackId)
                ) && 
                (
                    RackEntityId == other.RackEntityId ||
                    
                    RackEntityId.Equals(other.RackEntityId)
                ) && 
                (
                    CarbID == other.CarbID ||
                    CarbID != null &&
                    CarbID.Equals(other.CarbID)
                ) && 
                (
                    IsCarbReporting == other.IsCarbReporting ||
                    
                    IsCarbReporting.Equals(other.IsCarbReporting)
                ) && 
                (
                    SystemLocation == other.SystemLocation ||
                    SystemLocation != null &&
                    SystemLocation.Equals(other.SystemLocation)
                ) && 
                (
                    OperationalStatus == other.OperationalStatus ||
                    OperationalStatus != null &&
                    OperationalStatus.Equals(other.OperationalStatus)
                ) && 
                (
                    PartNumberId == other.PartNumberId ||
                    
                    PartNumberId.Equals(other.PartNumberId)
                ) && 
                (
                    RackTypeId == other.RackTypeId ||
                    
                    RackTypeId.Equals(other.RackTypeId)
                ) && 
                (
                    CurrentCharge == other.CurrentCharge ||
                    
                    CurrentCharge.Equals(other.CurrentCharge)
                ) && 
                (
                    CurrentChargeOunces == other.CurrentChargeOunces ||
                    
                    CurrentChargeOunces.Equals(other.CurrentChargeOunces)
                ) && 
                (
                    ChargeDescriptionId == other.ChargeDescriptionId ||
                    
                    ChargeDescriptionId.Equals(other.ChargeDescriptionId)
                ) && 
                (
                    ChargeProviderName == other.ChargeProviderName ||
                    ChargeProviderName != null &&
                    ChargeProviderName.Equals(other.ChargeProviderName)
                ) && 
                (
                    EffectiveChargeDate == other.EffectiveChargeDate ||
                    EffectiveChargeDate != null &&
                    EffectiveChargeDate.Equals(other.EffectiveChargeDate)
                ) && 
                (
                    HasLeakDetector == other.HasLeakDetector ||
                    
                    HasLeakDetector.Equals(other.HasLeakDetector)
                ) && 
                (
                    AssetLeakDetectorId == other.AssetLeakDetectorId ||
                    
                    AssetLeakDetectorId.Equals(other.AssetLeakDetectorId)
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
                    
                    hashCode = hashCode * 59 + AssetId.GetHashCode();
                    
                    hashCode = hashCode * 59 + RefrigerantUsageType.GetHashCode();
                    if (RackId != null)
                    hashCode = hashCode * 59 + RackId.GetHashCode();
                    
                    hashCode = hashCode * 59 + RackEntityId.GetHashCode();
                    if (CarbID != null)
                    hashCode = hashCode * 59 + CarbID.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsCarbReporting.GetHashCode();
                    if (SystemLocation != null)
                    hashCode = hashCode * 59 + SystemLocation.GetHashCode();
                    if (OperationalStatus != null)
                    hashCode = hashCode * 59 + OperationalStatus.GetHashCode();
                    
                    hashCode = hashCode * 59 + PartNumberId.GetHashCode();
                    
                    hashCode = hashCode * 59 + RackTypeId.GetHashCode();
                    
                    hashCode = hashCode * 59 + CurrentCharge.GetHashCode();
                    
                    hashCode = hashCode * 59 + CurrentChargeOunces.GetHashCode();
                    
                    hashCode = hashCode * 59 + ChargeDescriptionId.GetHashCode();
                    if (ChargeProviderName != null)
                    hashCode = hashCode * 59 + ChargeProviderName.GetHashCode();
                    if (EffectiveChargeDate != null)
                    hashCode = hashCode * 59 + EffectiveChargeDate.GetHashCode();
                    
                    hashCode = hashCode * 59 + HasLeakDetector.GetHashCode();
                    
                    hashCode = hashCode * 59 + AssetLeakDetectorId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingRefrigerantTrackingEditAssetRefrigerantRequest left, SCServiceChannelServicesMessagingRefrigerantTrackingEditAssetRefrigerantRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingRefrigerantTrackingEditAssetRefrigerantRequest left, SCServiceChannelServicesMessagingRefrigerantTrackingEditAssetRefrigerantRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}