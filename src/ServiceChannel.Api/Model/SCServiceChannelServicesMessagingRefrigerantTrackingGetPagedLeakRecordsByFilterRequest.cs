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
    /// SCServiceChannelServicesMessagingRefrigerantTrackingGetPagedLeakRecordsByFilterRequest
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.RefrigerantTracking.GetPagedLeakRecordsByFilterRequest")]
    public partial class SCServiceChannelServicesMessagingRefrigerantTrackingGetPagedLeakRecordsByFilterRequest : IEquatable<SCServiceChannelServicesMessagingRefrigerantTrackingGetPagedLeakRecordsByFilterRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingRefrigerantTrackingGetPagedLeakRecordsByFilterRequest" /> class.
        /// </summary>
        /// <param name="equipmentTypes">equipmentTypes.</param>
        /// <param name="equipmentTags">equipmentTags.</param>
        /// <param name="locations">locations.</param>
        /// <param name="leakLocations">leakLocations.</param>
        /// <param name="trackingNumbers">trackingNumbers.</param>
        /// <param name="leakStatusId">leakStatusId.</param>
        /// <param name="index">index.</param>
        /// <param name="count">count.</param>
        /// <param name="dateRangeId">dateRangeId.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="leakAreaIds">leakAreaIds.</param>
        /// <param name="providerIds">providerIds.</param>
        /// <param name="markets">markets.</param>
        /// <param name="divisions">divisions.</param>
        /// <param name="actionCodeIds">actionCodeIds.</param>
        /// <param name="reasonCodeIds">reasonCodeIds.</param>
        /// <param name="partGroups">partGroups.</param>
        /// <param name="mOENumbers">mOENumbers.</param>
        /// <param name="unitOfMeasure">unitOfMeasure.</param>
        /// <param name="isExport">isExport (default to false).</param>
        public SCServiceChannelServicesMessagingRefrigerantTrackingGetPagedLeakRecordsByFilterRequest(List<int> equipmentTypes = default(List<int>), List<string> equipmentTags = default(List<string>), List<int> locations = default(List<int>), List<int> leakLocations = default(List<int>), List<int> trackingNumbers = default(List<int>), int leakStatusId = default(int), int index = default(int), int count = default(int), int dateRangeId = default(int), DateTime startDate = default(DateTime), DateTime endDate = default(DateTime), List<int> leakAreaIds = default(List<int>), List<int> providerIds = default(List<int>), List<string> markets = default(List<string>), List<string> divisions = default(List<string>), List<int> actionCodeIds = default(List<int>), List<int> reasonCodeIds = default(List<int>), List<int> partGroups = default(List<int>), List<string> mOENumbers = default(List<string>), byte[] unitOfMeasure = default(byte[]), bool isExport = false)
        {
            this.EquipmentTypes = equipmentTypes;
            this.EquipmentTags = equipmentTags;
            this.Locations = locations;
            this.LeakLocations = leakLocations;
            this.TrackingNumbers = trackingNumbers;
            this.LeakStatusId = leakStatusId;
            this.Index = index;
            this.Count = count;
            this.DateRangeId = dateRangeId;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.LeakAreaIds = leakAreaIds;
            this.ProviderIds = providerIds;
            this.Markets = markets;
            this.Divisions = divisions;
            this.ActionCodeIds = actionCodeIds;
            this.ReasonCodeIds = reasonCodeIds;
            this.PartGroups = partGroups;
            this.MOENumbers = mOENumbers;
            this.UnitOfMeasure = unitOfMeasure;
            this.IsExport = isExport;
        }

        /// <summary>
        /// Gets or Sets EquipmentTypes
        /// </summary>
        [DataMember(Name = "EquipmentTypes", EmitDefaultValue = false)]
        public List<int> EquipmentTypes { get; set; }

        /// <summary>
        /// Gets or Sets EquipmentTags
        /// </summary>
        [DataMember(Name = "EquipmentTags", EmitDefaultValue = false)]
        public List<string> EquipmentTags { get; set; }

        /// <summary>
        /// Gets or Sets Locations
        /// </summary>
        [DataMember(Name = "Locations", EmitDefaultValue = false)]
        public List<int> Locations { get; set; }

        /// <summary>
        /// Gets or Sets LeakLocations
        /// </summary>
        [DataMember(Name = "LeakLocations", EmitDefaultValue = false)]
        public List<int> LeakLocations { get; set; }

        /// <summary>
        /// Gets or Sets TrackingNumbers
        /// </summary>
        [DataMember(Name = "TrackingNumbers", EmitDefaultValue = false)]
        public List<int> TrackingNumbers { get; set; }

        /// <summary>
        /// Gets or Sets LeakStatusId
        /// </summary>
        [DataMember(Name = "LeakStatusId", EmitDefaultValue = false)]
        public int LeakStatusId { get; set; }

        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name = "Index", EmitDefaultValue = false)]
        public int Index { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name = "Count", EmitDefaultValue = false)]
        public int Count { get; set; }

        /// <summary>
        /// Gets or Sets DateRangeId
        /// </summary>
        [DataMember(Name = "DateRangeId", EmitDefaultValue = false)]
        public int DateRangeId { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "StartDate", EmitDefaultValue = false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name = "EndDate", EmitDefaultValue = false)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or Sets LeakAreaIds
        /// </summary>
        [DataMember(Name = "LeakAreaIds", EmitDefaultValue = false)]
        public List<int> LeakAreaIds { get; set; }

        /// <summary>
        /// Gets or Sets ProviderIds
        /// </summary>
        [DataMember(Name = "ProviderIds", EmitDefaultValue = false)]
        public List<int> ProviderIds { get; set; }

        /// <summary>
        /// Gets or Sets Markets
        /// </summary>
        [DataMember(Name = "Markets", EmitDefaultValue = false)]
        public List<string> Markets { get; set; }

        /// <summary>
        /// Gets or Sets Divisions
        /// </summary>
        [DataMember(Name = "Divisions", EmitDefaultValue = false)]
        public List<string> Divisions { get; set; }

        /// <summary>
        /// Gets or Sets ActionCodeIds
        /// </summary>
        [DataMember(Name = "ActionCodeIds", EmitDefaultValue = false)]
        public List<int> ActionCodeIds { get; set; }

        /// <summary>
        /// Gets or Sets ReasonCodeIds
        /// </summary>
        [DataMember(Name = "ReasonCodeIds", EmitDefaultValue = false)]
        public List<int> ReasonCodeIds { get; set; }

        /// <summary>
        /// Gets or Sets PartGroups
        /// </summary>
        [DataMember(Name = "PartGroups", EmitDefaultValue = false)]
        public List<int> PartGroups { get; set; }

        /// <summary>
        /// Gets or Sets MOENumbers
        /// </summary>
        [DataMember(Name = "MOENumbers", EmitDefaultValue = false)]
        public List<string> MOENumbers { get; set; }

        /// <summary>
        /// Gets or Sets UnitOfMeasure
        /// </summary>
        [DataMember(Name = "UnitOfMeasure", EmitDefaultValue = false)]
        public byte[] UnitOfMeasure { get; set; }

        /// <summary>
        /// Gets or Sets IsExport
        /// </summary>
        [DataMember(Name = "IsExport", EmitDefaultValue = true)]
        public bool IsExport { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingRefrigerantTrackingGetPagedLeakRecordsByFilterRequest {\n");
            sb.Append("  EquipmentTypes: ").Append(EquipmentTypes).Append("\n");
            sb.Append("  EquipmentTags: ").Append(EquipmentTags).Append("\n");
            sb.Append("  Locations: ").Append(Locations).Append("\n");
            sb.Append("  LeakLocations: ").Append(LeakLocations).Append("\n");
            sb.Append("  TrackingNumbers: ").Append(TrackingNumbers).Append("\n");
            sb.Append("  LeakStatusId: ").Append(LeakStatusId).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  DateRangeId: ").Append(DateRangeId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  LeakAreaIds: ").Append(LeakAreaIds).Append("\n");
            sb.Append("  ProviderIds: ").Append(ProviderIds).Append("\n");
            sb.Append("  Markets: ").Append(Markets).Append("\n");
            sb.Append("  Divisions: ").Append(Divisions).Append("\n");
            sb.Append("  ActionCodeIds: ").Append(ActionCodeIds).Append("\n");
            sb.Append("  ReasonCodeIds: ").Append(ReasonCodeIds).Append("\n");
            sb.Append("  PartGroups: ").Append(PartGroups).Append("\n");
            sb.Append("  MOENumbers: ").Append(MOENumbers).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("  IsExport: ").Append(IsExport).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingRefrigerantTrackingGetPagedLeakRecordsByFilterRequest);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingRefrigerantTrackingGetPagedLeakRecordsByFilterRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingRefrigerantTrackingGetPagedLeakRecordsByFilterRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingRefrigerantTrackingGetPagedLeakRecordsByFilterRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EquipmentTypes == input.EquipmentTypes ||
                    this.EquipmentTypes != null &&
                    input.EquipmentTypes != null &&
                    this.EquipmentTypes.SequenceEqual(input.EquipmentTypes)
                ) && 
                (
                    this.EquipmentTags == input.EquipmentTags ||
                    this.EquipmentTags != null &&
                    input.EquipmentTags != null &&
                    this.EquipmentTags.SequenceEqual(input.EquipmentTags)
                ) && 
                (
                    this.Locations == input.Locations ||
                    this.Locations != null &&
                    input.Locations != null &&
                    this.Locations.SequenceEqual(input.Locations)
                ) && 
                (
                    this.LeakLocations == input.LeakLocations ||
                    this.LeakLocations != null &&
                    input.LeakLocations != null &&
                    this.LeakLocations.SequenceEqual(input.LeakLocations)
                ) && 
                (
                    this.TrackingNumbers == input.TrackingNumbers ||
                    this.TrackingNumbers != null &&
                    input.TrackingNumbers != null &&
                    this.TrackingNumbers.SequenceEqual(input.TrackingNumbers)
                ) && 
                (
                    this.LeakStatusId == input.LeakStatusId ||
                    this.LeakStatusId.Equals(input.LeakStatusId)
                ) && 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) && 
                (
                    this.Count == input.Count ||
                    this.Count.Equals(input.Count)
                ) && 
                (
                    this.DateRangeId == input.DateRangeId ||
                    this.DateRangeId.Equals(input.DateRangeId)
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.LeakAreaIds == input.LeakAreaIds ||
                    this.LeakAreaIds != null &&
                    input.LeakAreaIds != null &&
                    this.LeakAreaIds.SequenceEqual(input.LeakAreaIds)
                ) && 
                (
                    this.ProviderIds == input.ProviderIds ||
                    this.ProviderIds != null &&
                    input.ProviderIds != null &&
                    this.ProviderIds.SequenceEqual(input.ProviderIds)
                ) && 
                (
                    this.Markets == input.Markets ||
                    this.Markets != null &&
                    input.Markets != null &&
                    this.Markets.SequenceEqual(input.Markets)
                ) && 
                (
                    this.Divisions == input.Divisions ||
                    this.Divisions != null &&
                    input.Divisions != null &&
                    this.Divisions.SequenceEqual(input.Divisions)
                ) && 
                (
                    this.ActionCodeIds == input.ActionCodeIds ||
                    this.ActionCodeIds != null &&
                    input.ActionCodeIds != null &&
                    this.ActionCodeIds.SequenceEqual(input.ActionCodeIds)
                ) && 
                (
                    this.ReasonCodeIds == input.ReasonCodeIds ||
                    this.ReasonCodeIds != null &&
                    input.ReasonCodeIds != null &&
                    this.ReasonCodeIds.SequenceEqual(input.ReasonCodeIds)
                ) && 
                (
                    this.PartGroups == input.PartGroups ||
                    this.PartGroups != null &&
                    input.PartGroups != null &&
                    this.PartGroups.SequenceEqual(input.PartGroups)
                ) && 
                (
                    this.MOENumbers == input.MOENumbers ||
                    this.MOENumbers != null &&
                    input.MOENumbers != null &&
                    this.MOENumbers.SequenceEqual(input.MOENumbers)
                ) && 
                (
                    this.UnitOfMeasure == input.UnitOfMeasure ||
                    (this.UnitOfMeasure != null &&
                    this.UnitOfMeasure.Equals(input.UnitOfMeasure))
                ) && 
                (
                    this.IsExport == input.IsExport ||
                    this.IsExport.Equals(input.IsExport)
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
                if (this.EquipmentTypes != null)
                {
                    hashCode = (hashCode * 59) + this.EquipmentTypes.GetHashCode();
                }
                if (this.EquipmentTags != null)
                {
                    hashCode = (hashCode * 59) + this.EquipmentTags.GetHashCode();
                }
                if (this.Locations != null)
                {
                    hashCode = (hashCode * 59) + this.Locations.GetHashCode();
                }
                if (this.LeakLocations != null)
                {
                    hashCode = (hashCode * 59) + this.LeakLocations.GetHashCode();
                }
                if (this.TrackingNumbers != null)
                {
                    hashCode = (hashCode * 59) + this.TrackingNumbers.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LeakStatusId.GetHashCode();
                hashCode = (hashCode * 59) + this.Index.GetHashCode();
                hashCode = (hashCode * 59) + this.Count.GetHashCode();
                hashCode = (hashCode * 59) + this.DateRangeId.GetHashCode();
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                if (this.LeakAreaIds != null)
                {
                    hashCode = (hashCode * 59) + this.LeakAreaIds.GetHashCode();
                }
                if (this.ProviderIds != null)
                {
                    hashCode = (hashCode * 59) + this.ProviderIds.GetHashCode();
                }
                if (this.Markets != null)
                {
                    hashCode = (hashCode * 59) + this.Markets.GetHashCode();
                }
                if (this.Divisions != null)
                {
                    hashCode = (hashCode * 59) + this.Divisions.GetHashCode();
                }
                if (this.ActionCodeIds != null)
                {
                    hashCode = (hashCode * 59) + this.ActionCodeIds.GetHashCode();
                }
                if (this.ReasonCodeIds != null)
                {
                    hashCode = (hashCode * 59) + this.ReasonCodeIds.GetHashCode();
                }
                if (this.PartGroups != null)
                {
                    hashCode = (hashCode * 59) + this.PartGroups.GetHashCode();
                }
                if (this.MOENumbers != null)
                {
                    hashCode = (hashCode * 59) + this.MOENumbers.GetHashCode();
                }
                if (this.UnitOfMeasure != null)
                {
                    hashCode = (hashCode * 59) + this.UnitOfMeasure.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsExport.GetHashCode();
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