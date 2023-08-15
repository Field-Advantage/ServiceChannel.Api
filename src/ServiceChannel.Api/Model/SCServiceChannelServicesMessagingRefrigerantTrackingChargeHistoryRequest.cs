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
    /// SCServiceChannelServicesMessagingRefrigerantTrackingChargeHistoryRequest
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.RefrigerantTracking.ChargeHistoryRequest")]
    public partial class SCServiceChannelServicesMessagingRefrigerantTrackingChargeHistoryRequest : IEquatable<SCServiceChannelServicesMessagingRefrigerantTrackingChargeHistoryRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingRefrigerantTrackingChargeHistoryRequest" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="assetId">assetId.</param>
        /// <param name="tagId">tagId.</param>
        /// <param name="totalCharge">totalCharge.</param>
        /// <param name="totalChargeStr">totalChargeStr.</param>
        /// <param name="providerName">providerName.</param>
        /// <param name="effectiveDate">effectiveDate.</param>
        /// <param name="initialCharge">initialCharge (default to false).</param>
        /// <param name="refrigerantChargeOptionsId">refrigerantChargeOptionsId.</param>
        /// <param name="totalRows">totalRows.</param>
        /// <param name="refrigerantPartNumber">refrigerantPartNumber.</param>
        /// <param name="partNumberId">partNumberId.</param>
        /// <param name="totalChargeMetrics">totalChargeMetrics.</param>
        public SCServiceChannelServicesMessagingRefrigerantTrackingChargeHistoryRequest(int id = default(int), int assetId = default(int), string tagId = default(string), double totalCharge = default(double), string totalChargeStr = default(string), string providerName = default(string), DateTime effectiveDate = default(DateTime), bool initialCharge = false, int refrigerantChargeOptionsId = default(int), int totalRows = default(int), string refrigerantPartNumber = default(string), int partNumberId = default(int), double totalChargeMetrics = default(double))
        {
            this.Id = id;
            this.AssetId = assetId;
            this.TagId = tagId;
            this.TotalCharge = totalCharge;
            this.TotalChargeStr = totalChargeStr;
            this.ProviderName = providerName;
            this.EffectiveDate = effectiveDate;
            this.InitialCharge = initialCharge;
            this.RefrigerantChargeOptionsId = refrigerantChargeOptionsId;
            this.TotalRows = totalRows;
            this.RefrigerantPartNumber = refrigerantPartNumber;
            this.PartNumberId = partNumberId;
            this.TotalChargeMetrics = totalChargeMetrics;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets AssetId
        /// </summary>
        [DataMember(Name = "AssetId", EmitDefaultValue = false)]
        public int AssetId { get; set; }

        /// <summary>
        /// Gets or Sets TagId
        /// </summary>
        [DataMember(Name = "TagId", EmitDefaultValue = false)]
        public string TagId { get; set; }

        /// <summary>
        /// Gets or Sets TotalCharge
        /// </summary>
        [DataMember(Name = "TotalCharge", EmitDefaultValue = false)]
        public double TotalCharge { get; set; }

        /// <summary>
        /// Gets or Sets TotalChargeStr
        /// </summary>
        [DataMember(Name = "TotalChargeStr", EmitDefaultValue = false)]
        public string TotalChargeStr { get; set; }

        /// <summary>
        /// Gets or Sets ProviderName
        /// </summary>
        [DataMember(Name = "ProviderName", EmitDefaultValue = false)]
        public string ProviderName { get; set; }

        /// <summary>
        /// Gets or Sets EffectiveDate
        /// </summary>
        [DataMember(Name = "EffectiveDate", EmitDefaultValue = false)]
        public DateTime EffectiveDate { get; set; }

        /// <summary>
        /// Gets or Sets InitialCharge
        /// </summary>
        [DataMember(Name = "InitialCharge", EmitDefaultValue = true)]
        public bool InitialCharge { get; set; }

        /// <summary>
        /// Gets or Sets RefrigerantChargeOptionsId
        /// </summary>
        [DataMember(Name = "RefrigerantChargeOptionsId", EmitDefaultValue = false)]
        public int RefrigerantChargeOptionsId { get; set; }

        /// <summary>
        /// Gets or Sets TotalRows
        /// </summary>
        [DataMember(Name = "TotalRows", EmitDefaultValue = false)]
        public int TotalRows { get; set; }

        /// <summary>
        /// Gets or Sets RefrigerantPartNumber
        /// </summary>
        [DataMember(Name = "RefrigerantPartNumber", EmitDefaultValue = false)]
        public string RefrigerantPartNumber { get; set; }

        /// <summary>
        /// Gets or Sets PartNumberId
        /// </summary>
        [DataMember(Name = "PartNumberId", EmitDefaultValue = false)]
        public int PartNumberId { get; set; }

        /// <summary>
        /// Gets or Sets TotalChargeMetrics
        /// </summary>
        [DataMember(Name = "TotalChargeMetrics", EmitDefaultValue = false)]
        public double TotalChargeMetrics { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingRefrigerantTrackingChargeHistoryRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  TagId: ").Append(TagId).Append("\n");
            sb.Append("  TotalCharge: ").Append(TotalCharge).Append("\n");
            sb.Append("  TotalChargeStr: ").Append(TotalChargeStr).Append("\n");
            sb.Append("  ProviderName: ").Append(ProviderName).Append("\n");
            sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
            sb.Append("  InitialCharge: ").Append(InitialCharge).Append("\n");
            sb.Append("  RefrigerantChargeOptionsId: ").Append(RefrigerantChargeOptionsId).Append("\n");
            sb.Append("  TotalRows: ").Append(TotalRows).Append("\n");
            sb.Append("  RefrigerantPartNumber: ").Append(RefrigerantPartNumber).Append("\n");
            sb.Append("  PartNumberId: ").Append(PartNumberId).Append("\n");
            sb.Append("  TotalChargeMetrics: ").Append(TotalChargeMetrics).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingRefrigerantTrackingChargeHistoryRequest);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingRefrigerantTrackingChargeHistoryRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingRefrigerantTrackingChargeHistoryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingRefrigerantTrackingChargeHistoryRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.AssetId == input.AssetId ||
                    this.AssetId.Equals(input.AssetId)
                ) && 
                (
                    this.TagId == input.TagId ||
                    (this.TagId != null &&
                    this.TagId.Equals(input.TagId))
                ) && 
                (
                    this.TotalCharge == input.TotalCharge ||
                    this.TotalCharge.Equals(input.TotalCharge)
                ) && 
                (
                    this.TotalChargeStr == input.TotalChargeStr ||
                    (this.TotalChargeStr != null &&
                    this.TotalChargeStr.Equals(input.TotalChargeStr))
                ) && 
                (
                    this.ProviderName == input.ProviderName ||
                    (this.ProviderName != null &&
                    this.ProviderName.Equals(input.ProviderName))
                ) && 
                (
                    this.EffectiveDate == input.EffectiveDate ||
                    (this.EffectiveDate != null &&
                    this.EffectiveDate.Equals(input.EffectiveDate))
                ) && 
                (
                    this.InitialCharge == input.InitialCharge ||
                    this.InitialCharge.Equals(input.InitialCharge)
                ) && 
                (
                    this.RefrigerantChargeOptionsId == input.RefrigerantChargeOptionsId ||
                    this.RefrigerantChargeOptionsId.Equals(input.RefrigerantChargeOptionsId)
                ) && 
                (
                    this.TotalRows == input.TotalRows ||
                    this.TotalRows.Equals(input.TotalRows)
                ) && 
                (
                    this.RefrigerantPartNumber == input.RefrigerantPartNumber ||
                    (this.RefrigerantPartNumber != null &&
                    this.RefrigerantPartNumber.Equals(input.RefrigerantPartNumber))
                ) && 
                (
                    this.PartNumberId == input.PartNumberId ||
                    this.PartNumberId.Equals(input.PartNumberId)
                ) && 
                (
                    this.TotalChargeMetrics == input.TotalChargeMetrics ||
                    this.TotalChargeMetrics.Equals(input.TotalChargeMetrics)
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                hashCode = (hashCode * 59) + this.AssetId.GetHashCode();
                if (this.TagId != null)
                {
                    hashCode = (hashCode * 59) + this.TagId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalCharge.GetHashCode();
                if (this.TotalChargeStr != null)
                {
                    hashCode = (hashCode * 59) + this.TotalChargeStr.GetHashCode();
                }
                if (this.ProviderName != null)
                {
                    hashCode = (hashCode * 59) + this.ProviderName.GetHashCode();
                }
                if (this.EffectiveDate != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InitialCharge.GetHashCode();
                hashCode = (hashCode * 59) + this.RefrigerantChargeOptionsId.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalRows.GetHashCode();
                if (this.RefrigerantPartNumber != null)
                {
                    hashCode = (hashCode * 59) + this.RefrigerantPartNumber.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PartNumberId.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalChargeMetrics.GetHashCode();
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
