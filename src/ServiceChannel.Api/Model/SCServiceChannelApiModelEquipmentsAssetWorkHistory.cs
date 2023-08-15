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
    /// SCServiceChannelApiModelEquipmentsAssetWorkHistory
    /// </summary>
    [DataContract(Name = "ServiceChannel.Api.Model.Equipments.AssetWorkHistory")]
    public partial class SCServiceChannelApiModelEquipmentsAssetWorkHistory : IEquatable<SCServiceChannelApiModelEquipmentsAssetWorkHistory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelApiModelEquipmentsAssetWorkHistory" /> class.
        /// </summary>
        /// <param name="date">date.</param>
        /// <param name="wO">wO.</param>
        /// <param name="wOStatusExtended">wOStatusExtended.</param>
        /// <param name="wOStatusPrimary">wOStatusPrimary.</param>
        /// <param name="problemCode">problemCode.</param>
        /// <param name="technician">technician.</param>
        /// <param name="recId">recId.</param>
        /// <param name="providerId">providerId.</param>
        /// <param name="scheduledDate">scheduledDate.</param>
        /// <param name="completedDate">completedDate.</param>
        public SCServiceChannelApiModelEquipmentsAssetWorkHistory(DateTime date = default(DateTime), string wO = default(string), string wOStatusExtended = default(string), string wOStatusPrimary = default(string), string problemCode = default(string), string technician = default(string), int recId = default(int), int providerId = default(int), DateTime scheduledDate = default(DateTime), DateTime completedDate = default(DateTime))
        {
            this.Date = date;
            this.WO = wO;
            this.WOStatusExtended = wOStatusExtended;
            this.WOStatusPrimary = wOStatusPrimary;
            this.ProblemCode = problemCode;
            this.Technician = technician;
            this.RecId = recId;
            this.ProviderId = providerId;
            this.ScheduledDate = scheduledDate;
            this.CompletedDate = completedDate;
        }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "Date", EmitDefaultValue = false)]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or Sets WO
        /// </summary>
        [DataMember(Name = "WO", EmitDefaultValue = false)]
        public string WO { get; set; }

        /// <summary>
        /// Gets or Sets WOStatusExtended
        /// </summary>
        [DataMember(Name = "WOStatusExtended", EmitDefaultValue = false)]
        public string WOStatusExtended { get; set; }

        /// <summary>
        /// Gets or Sets WOStatusPrimary
        /// </summary>
        [DataMember(Name = "WOStatusPrimary", EmitDefaultValue = false)]
        public string WOStatusPrimary { get; set; }

        /// <summary>
        /// Gets or Sets ProblemCode
        /// </summary>
        [DataMember(Name = "ProblemCode", EmitDefaultValue = false)]
        public string ProblemCode { get; set; }

        /// <summary>
        /// Gets or Sets Technician
        /// </summary>
        [DataMember(Name = "Technician", EmitDefaultValue = false)]
        public string Technician { get; set; }

        /// <summary>
        /// Gets or Sets RecId
        /// </summary>
        [DataMember(Name = "RecId", EmitDefaultValue = false)]
        public int RecId { get; set; }

        /// <summary>
        /// Gets or Sets ProviderId
        /// </summary>
        [DataMember(Name = "ProviderId", EmitDefaultValue = false)]
        public int ProviderId { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledDate
        /// </summary>
        [DataMember(Name = "ScheduledDate", EmitDefaultValue = false)]
        public DateTime ScheduledDate { get; set; }

        /// <summary>
        /// Gets or Sets CompletedDate
        /// </summary>
        [DataMember(Name = "CompletedDate", EmitDefaultValue = false)]
        public DateTime CompletedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelApiModelEquipmentsAssetWorkHistory {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  WO: ").Append(WO).Append("\n");
            sb.Append("  WOStatusExtended: ").Append(WOStatusExtended).Append("\n");
            sb.Append("  WOStatusPrimary: ").Append(WOStatusPrimary).Append("\n");
            sb.Append("  ProblemCode: ").Append(ProblemCode).Append("\n");
            sb.Append("  Technician: ").Append(Technician).Append("\n");
            sb.Append("  RecId: ").Append(RecId).Append("\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  ScheduledDate: ").Append(ScheduledDate).Append("\n");
            sb.Append("  CompletedDate: ").Append(CompletedDate).Append("\n");
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
            return this.Equals(input as SCServiceChannelApiModelEquipmentsAssetWorkHistory);
        }

        /// <summary>
        /// Returns true if SCServiceChannelApiModelEquipmentsAssetWorkHistory instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelApiModelEquipmentsAssetWorkHistory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelApiModelEquipmentsAssetWorkHistory input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.WO == input.WO ||
                    (this.WO != null &&
                    this.WO.Equals(input.WO))
                ) && 
                (
                    this.WOStatusExtended == input.WOStatusExtended ||
                    (this.WOStatusExtended != null &&
                    this.WOStatusExtended.Equals(input.WOStatusExtended))
                ) && 
                (
                    this.WOStatusPrimary == input.WOStatusPrimary ||
                    (this.WOStatusPrimary != null &&
                    this.WOStatusPrimary.Equals(input.WOStatusPrimary))
                ) && 
                (
                    this.ProblemCode == input.ProblemCode ||
                    (this.ProblemCode != null &&
                    this.ProblemCode.Equals(input.ProblemCode))
                ) && 
                (
                    this.Technician == input.Technician ||
                    (this.Technician != null &&
                    this.Technician.Equals(input.Technician))
                ) && 
                (
                    this.RecId == input.RecId ||
                    this.RecId.Equals(input.RecId)
                ) && 
                (
                    this.ProviderId == input.ProviderId ||
                    this.ProviderId.Equals(input.ProviderId)
                ) && 
                (
                    this.ScheduledDate == input.ScheduledDate ||
                    (this.ScheduledDate != null &&
                    this.ScheduledDate.Equals(input.ScheduledDate))
                ) && 
                (
                    this.CompletedDate == input.CompletedDate ||
                    (this.CompletedDate != null &&
                    this.CompletedDate.Equals(input.CompletedDate))
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
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
                }
                if (this.WO != null)
                {
                    hashCode = (hashCode * 59) + this.WO.GetHashCode();
                }
                if (this.WOStatusExtended != null)
                {
                    hashCode = (hashCode * 59) + this.WOStatusExtended.GetHashCode();
                }
                if (this.WOStatusPrimary != null)
                {
                    hashCode = (hashCode * 59) + this.WOStatusPrimary.GetHashCode();
                }
                if (this.ProblemCode != null)
                {
                    hashCode = (hashCode * 59) + this.ProblemCode.GetHashCode();
                }
                if (this.Technician != null)
                {
                    hashCode = (hashCode * 59) + this.Technician.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RecId.GetHashCode();
                hashCode = (hashCode * 59) + this.ProviderId.GetHashCode();
                if (this.ScheduledDate != null)
                {
                    hashCode = (hashCode * 59) + this.ScheduledDate.GetHashCode();
                }
                if (this.CompletedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CompletedDate.GetHashCode();
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