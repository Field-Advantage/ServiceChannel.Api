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
    /// NegotiatedPriceLists
    /// </summary>
    [DataContract]
    public class SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList : IEquatable<SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList>
    {
        /// <summary>
        /// Id
        /// </summary>
        /// <value>Id</value>
        [DataMember(Name="Id", EmitDefaultValue=true)]
        public int Id { get; set; }

        /// <summary>
        /// PriceListName
        /// </summary>
        /// <value>PriceListName</value>
        [DataMember(Name="PriceListName", EmitDefaultValue=false)]
        public string PriceListName { get; set; }

        /// <summary>
        /// EffectiveDate
        /// </summary>
        /// <value>EffectiveDate</value>
        [DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
        public DateTime EffectiveDate { get; set; }

        /// <summary>
        /// ExpirationDate
        /// </summary>
        /// <value>ExpirationDate</value>
        [DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// ProviderId
        /// </summary>
        /// <value>ProviderId</value>
        [DataMember(Name="ProviderId", EmitDefaultValue=true)]
        public int ProviderId { get; set; }

        /// <summary>
        /// ProviderName
        /// </summary>
        /// <value>ProviderName</value>
        [DataMember(Name="ProviderName", EmitDefaultValue=false)]
        public string ProviderName { get; set; }

        /// <summary>
        /// SubscriberId
        /// </summary>
        /// <value>SubscriberId</value>
        [DataMember(Name="SubscriberId", EmitDefaultValue=true)]
        public int SubscriberId { get; set; }

        /// <summary>
        /// PriceListParts
        /// </summary>
        /// <value>PriceListParts</value>
        [DataMember(Name="PriceListParts", EmitDefaultValue=false)]
        public List<SCServiceChannelServicesMessagingNegotiatedPriceListPriceListPart> PriceListParts { get; set; }

        /// <summary>
        /// Gets or Sets PriceListFile
        /// </summary>
        [DataMember(Name="PriceListFile", EmitDefaultValue=false)]
        public SCServiceChannelServicesMessagingNegotiatedPriceListPriceListFile PriceListFile { get; set; }

        /// <summary>
        /// Regions
        /// </summary>
        /// <value>Regions</value>
        [DataMember(Name="Regions", EmitDefaultValue=false)]
        public List<string> Regions { get; set; }

        /// <summary>
        /// Districts
        /// </summary>
        /// <value>Districts</value>
        [DataMember(Name="Districts", EmitDefaultValue=false)]
        public List<string> Districts { get; set; }

        /// <summary>
        /// LocationIds
        /// </summary>
        /// <value>LocationIds</value>
        [DataMember(Name="LocationIds", EmitDefaultValue=false)]
        public List<string> LocationIds { get; set; }

        /// <summary>
        /// Created Date
        /// </summary>
        /// <value>Created Date</value>
        [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Updated Date
        /// </summary>
        /// <value>Updated Date</value>
        [DataMember(Name="UpdatedDate", EmitDefaultValue=false)]
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// Created By
        /// </summary>
        /// <value>Created By</value>
        [DataMember(Name="CreatedBy", EmitDefaultValue=true)]
        public int CreatedBy { get; set; }

        /// <summary>
        /// UserName
        /// </summary>
        /// <value>UserName</value>
        [DataMember(Name="UserName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// Updated By
        /// </summary>
        /// <value>Updated By</value>
        [DataMember(Name="UpdatedBy", EmitDefaultValue=true)]
        public int UpdatedBy { get; set; }

        /// <summary>
        /// LNHName
        /// </summary>
        /// <value>LNHName</value>
        [DataMember(Name="LNHName", EmitDefaultValue=false)]
        public string LNHName { get; set; }

        /// <summary>
        /// LNHValues
        /// </summary>
        /// <value>LNHValues</value>
        [DataMember(Name="LNHValues", EmitDefaultValue=false)]
        public List<string> LNHValues { get; set; }

        /// <summary>
        /// PriceListOtherCharges
        /// </summary>
        /// <value>PriceListOtherCharges</value>
        [DataMember(Name="PriceListOtherCharges", EmitDefaultValue=false)]
        public List<SCServiceChannelServicesMessagingNegotiatedPriceListPriceListOtherCharges> PriceListOtherCharges { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PriceListName: ").Append(PriceListName).Append("\n");
            sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  ProviderName: ").Append(ProviderName).Append("\n");
            sb.Append("  SubscriberId: ").Append(SubscriberId).Append("\n");
            sb.Append("  PriceListParts: ").Append(PriceListParts).Append("\n");
            sb.Append("  PriceListFile: ").Append(PriceListFile).Append("\n");
            sb.Append("  Regions: ").Append(Regions).Append("\n");
            sb.Append("  Districts: ").Append(Districts).Append("\n");
            sb.Append("  LocationIds: ").Append(LocationIds).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  LNHName: ").Append(LNHName).Append("\n");
            sb.Append("  LNHValues: ").Append(LNHValues).Append("\n");
            sb.Append("  PriceListOtherCharges: ").Append(PriceListOtherCharges).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    PriceListName == other.PriceListName ||
                    PriceListName != null &&
                    PriceListName.Equals(other.PriceListName)
                ) && 
                (
                    EffectiveDate == other.EffectiveDate ||
                    EffectiveDate != null &&
                    EffectiveDate.Equals(other.EffectiveDate)
                ) && 
                (
                    ExpirationDate == other.ExpirationDate ||
                    ExpirationDate != null &&
                    ExpirationDate.Equals(other.ExpirationDate)
                ) && 
                (
                    ProviderId == other.ProviderId ||
                    
                    ProviderId.Equals(other.ProviderId)
                ) && 
                (
                    ProviderName == other.ProviderName ||
                    ProviderName != null &&
                    ProviderName.Equals(other.ProviderName)
                ) && 
                (
                    SubscriberId == other.SubscriberId ||
                    
                    SubscriberId.Equals(other.SubscriberId)
                ) && 
                (
                    PriceListParts == other.PriceListParts ||
                    PriceListParts != null &&
                    other.PriceListParts != null &&
                    PriceListParts.SequenceEqual(other.PriceListParts)
                ) && 
                (
                    PriceListFile == other.PriceListFile ||
                    PriceListFile != null &&
                    PriceListFile.Equals(other.PriceListFile)
                ) && 
                (
                    Regions == other.Regions ||
                    Regions != null &&
                    other.Regions != null &&
                    Regions.SequenceEqual(other.Regions)
                ) && 
                (
                    Districts == other.Districts ||
                    Districts != null &&
                    other.Districts != null &&
                    Districts.SequenceEqual(other.Districts)
                ) && 
                (
                    LocationIds == other.LocationIds ||
                    LocationIds != null &&
                    other.LocationIds != null &&
                    LocationIds.SequenceEqual(other.LocationIds)
                ) && 
                (
                    CreatedDate == other.CreatedDate ||
                    CreatedDate != null &&
                    CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    UpdatedDate == other.UpdatedDate ||
                    UpdatedDate != null &&
                    UpdatedDate.Equals(other.UpdatedDate)
                ) && 
                (
                    CreatedBy == other.CreatedBy ||
                    
                    CreatedBy.Equals(other.CreatedBy)
                ) && 
                (
                    UserName == other.UserName ||
                    UserName != null &&
                    UserName.Equals(other.UserName)
                ) && 
                (
                    UpdatedBy == other.UpdatedBy ||
                    
                    UpdatedBy.Equals(other.UpdatedBy)
                ) && 
                (
                    LNHName == other.LNHName ||
                    LNHName != null &&
                    LNHName.Equals(other.LNHName)
                ) && 
                (
                    LNHValues == other.LNHValues ||
                    LNHValues != null &&
                    other.LNHValues != null &&
                    LNHValues.SequenceEqual(other.LNHValues)
                ) && 
                (
                    PriceListOtherCharges == other.PriceListOtherCharges ||
                    PriceListOtherCharges != null &&
                    other.PriceListOtherCharges != null &&
                    PriceListOtherCharges.SequenceEqual(other.PriceListOtherCharges)
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
                    if (PriceListName != null)
                    hashCode = hashCode * 59 + PriceListName.GetHashCode();
                    if (EffectiveDate != null)
                    hashCode = hashCode * 59 + EffectiveDate.GetHashCode();
                    if (ExpirationDate != null)
                    hashCode = hashCode * 59 + ExpirationDate.GetHashCode();
                    
                    hashCode = hashCode * 59 + ProviderId.GetHashCode();
                    if (ProviderName != null)
                    hashCode = hashCode * 59 + ProviderName.GetHashCode();
                    
                    hashCode = hashCode * 59 + SubscriberId.GetHashCode();
                    if (PriceListParts != null)
                    hashCode = hashCode * 59 + PriceListParts.GetHashCode();
                    if (PriceListFile != null)
                    hashCode = hashCode * 59 + PriceListFile.GetHashCode();
                    if (Regions != null)
                    hashCode = hashCode * 59 + Regions.GetHashCode();
                    if (Districts != null)
                    hashCode = hashCode * 59 + Districts.GetHashCode();
                    if (LocationIds != null)
                    hashCode = hashCode * 59 + LocationIds.GetHashCode();
                    if (CreatedDate != null)
                    hashCode = hashCode * 59 + CreatedDate.GetHashCode();
                    if (UpdatedDate != null)
                    hashCode = hashCode * 59 + UpdatedDate.GetHashCode();
                    
                    hashCode = hashCode * 59 + CreatedBy.GetHashCode();
                    if (UserName != null)
                    hashCode = hashCode * 59 + UserName.GetHashCode();
                    
                    hashCode = hashCode * 59 + UpdatedBy.GetHashCode();
                    if (LNHName != null)
                    hashCode = hashCode * 59 + LNHName.GetHashCode();
                    if (LNHValues != null)
                    hashCode = hashCode * 59 + LNHValues.GetHashCode();
                    if (PriceListOtherCharges != null)
                    hashCode = hashCode * 59 + PriceListOtherCharges.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList left, SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList left, SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
