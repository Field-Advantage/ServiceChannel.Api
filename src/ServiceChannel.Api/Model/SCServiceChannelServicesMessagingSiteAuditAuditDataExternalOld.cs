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
    /// SCServiceChannelServicesMessagingSiteAuditAuditDataExternalOld
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.SiteAudit.AuditDataExternalOld")]
    public partial class SCServiceChannelServicesMessagingSiteAuditAuditDataExternalOld : IEquatable<SCServiceChannelServicesMessagingSiteAuditAuditDataExternalOld>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingSiteAuditAuditDataExternalOld" /> class.
        /// </summary>
        /// <param name="startDate">startDate.</param>
        /// <param name="finishDate">finishDate.</param>
        /// <param name="areas">areas.</param>
        /// <param name="workOrderIds">workOrderIds.</param>
        /// <param name="emails">emails.</param>
        /// <param name="sendEmails">sendEmails (default to false).</param>
        public SCServiceChannelServicesMessagingSiteAuditAuditDataExternalOld(DateTime startDate = default(DateTime), DateTime finishDate = default(DateTime), List<SCServiceChannelServicesMessagingSiteAuditAuditAreaExternalOld> areas = default(List<SCServiceChannelServicesMessagingSiteAuditAuditAreaExternalOld>), List<int> workOrderIds = default(List<int>), string emails = default(string), bool sendEmails = false)
        {
            this.StartDate = startDate;
            this.FinishDate = finishDate;
            this.Areas = areas;
            this.WorkOrderIds = workOrderIds;
            this.Emails = emails;
            this.SendEmails = sendEmails;
        }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "StartDate", EmitDefaultValue = false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or Sets FinishDate
        /// </summary>
        [DataMember(Name = "FinishDate", EmitDefaultValue = false)]
        public DateTime FinishDate { get; set; }

        /// <summary>
        /// Gets or Sets Areas
        /// </summary>
        [DataMember(Name = "Areas", EmitDefaultValue = false)]
        public List<SCServiceChannelServicesMessagingSiteAuditAuditAreaExternalOld> Areas { get; set; }

        /// <summary>
        /// Gets or Sets WorkOrderIds
        /// </summary>
        [DataMember(Name = "WorkOrderIds", EmitDefaultValue = false)]
        public List<int> WorkOrderIds { get; set; }

        /// <summary>
        /// Gets or Sets Emails
        /// </summary>
        [DataMember(Name = "Emails", EmitDefaultValue = false)]
        public string Emails { get; set; }

        /// <summary>
        /// Gets or Sets SendEmails
        /// </summary>
        [DataMember(Name = "SendEmails", EmitDefaultValue = true)]
        public bool SendEmails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingSiteAuditAuditDataExternalOld {\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  FinishDate: ").Append(FinishDate).Append("\n");
            sb.Append("  Areas: ").Append(Areas).Append("\n");
            sb.Append("  WorkOrderIds: ").Append(WorkOrderIds).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  SendEmails: ").Append(SendEmails).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingSiteAuditAuditDataExternalOld);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingSiteAuditAuditDataExternalOld instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingSiteAuditAuditDataExternalOld to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingSiteAuditAuditDataExternalOld input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.FinishDate == input.FinishDate ||
                    (this.FinishDate != null &&
                    this.FinishDate.Equals(input.FinishDate))
                ) && 
                (
                    this.Areas == input.Areas ||
                    this.Areas != null &&
                    input.Areas != null &&
                    this.Areas.SequenceEqual(input.Areas)
                ) && 
                (
                    this.WorkOrderIds == input.WorkOrderIds ||
                    this.WorkOrderIds != null &&
                    input.WorkOrderIds != null &&
                    this.WorkOrderIds.SequenceEqual(input.WorkOrderIds)
                ) && 
                (
                    this.Emails == input.Emails ||
                    (this.Emails != null &&
                    this.Emails.Equals(input.Emails))
                ) && 
                (
                    this.SendEmails == input.SendEmails ||
                    this.SendEmails.Equals(input.SendEmails)
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
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.FinishDate != null)
                {
                    hashCode = (hashCode * 59) + this.FinishDate.GetHashCode();
                }
                if (this.Areas != null)
                {
                    hashCode = (hashCode * 59) + this.Areas.GetHashCode();
                }
                if (this.WorkOrderIds != null)
                {
                    hashCode = (hashCode * 59) + this.WorkOrderIds.GetHashCode();
                }
                if (this.Emails != null)
                {
                    hashCode = (hashCode * 59) + this.Emails.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SendEmails.GetHashCode();
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