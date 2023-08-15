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
    /// SCServiceChannelServicesMessagingSiteAuditCheckListItemRequest
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.SiteAudit.CheckListItemRequest")]
    public partial class SCServiceChannelServicesMessagingSiteAuditCheckListItemRequest : IEquatable<SCServiceChannelServicesMessagingSiteAuditCheckListItemRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines System
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SystemEnum
        {
            /// <summary>
            /// Enum PassFail for value: PassFail
            /// </summary>
            [EnumMember(Value = "PassFail")]
            PassFail = 1,

            /// <summary>
            /// Enum Numeric for value: Numeric
            /// </summary>
            [EnumMember(Value = "Numeric")]
            Numeric = 2,

            /// <summary>
            /// Enum Weighted for value: Weighted
            /// </summary>
            [EnumMember(Value = "Weighted")]
            Weighted = 3,

            /// <summary>
            /// Enum Percentage for value: Percentage
            /// </summary>
            [EnumMember(Value = "Percentage")]
            Percentage = 4

        }


        /// <summary>
        /// Gets or Sets System
        /// </summary>
        [DataMember(Name = "System", EmitDefaultValue = false)]
        public SystemEnum? System { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingSiteAuditCheckListItemRequest" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="score">score.</param>
        /// <param name="system">system.</param>
        /// <param name="range">range.</param>
        /// <param name="passThreshold">passThreshold.</param>
        /// <param name="date">date.</param>
        /// <param name="unlisted">unlisted (default to false).</param>
        /// <param name="issues">issues.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="checkListItemImpact">checkListItemImpact.</param>
        /// <param name="workOrderIds">workOrderIds.</param>
        public SCServiceChannelServicesMessagingSiteAuditCheckListItemRequest(string name = default(string), string description = default(string), int score = default(int), SystemEnum? system = default(SystemEnum?), List<int> range = default(List<int>), int passThreshold = default(int), DateTime date = default(DateTime), bool unlisted = false, List<SCServiceChannelServicesMessagingSiteAuditAuditIssueExternal> issues = default(List<SCServiceChannelServicesMessagingSiteAuditAuditIssueExternal>), SCServiceChannelServicesMessagingSiteAuditQuantityExternal quantity = default(SCServiceChannelServicesMessagingSiteAuditQuantityExternal), string checkListItemImpact = default(string), List<int> workOrderIds = default(List<int>))
        {
            this.Name = name;
            this.Description = description;
            this.Score = score;
            this.System = system;
            this.Range = range;
            this.PassThreshold = passThreshold;
            this.Date = date;
            this.Unlisted = unlisted;
            this.Issues = issues;
            this.Quantity = quantity;
            this.CheckListItemImpact = checkListItemImpact;
            this.WorkOrderIds = workOrderIds;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "Description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name = "Score", EmitDefaultValue = false)]
        public int Score { get; set; }

        /// <summary>
        /// Gets or Sets Range
        /// </summary>
        [DataMember(Name = "Range", EmitDefaultValue = false)]
        public List<int> Range { get; set; }

        /// <summary>
        /// Gets or Sets PassThreshold
        /// </summary>
        [DataMember(Name = "PassThreshold", EmitDefaultValue = false)]
        public int PassThreshold { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "Date", EmitDefaultValue = false)]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or Sets Unlisted
        /// </summary>
        [DataMember(Name = "Unlisted", EmitDefaultValue = true)]
        public bool Unlisted { get; set; }

        /// <summary>
        /// Gets or Sets Issues
        /// </summary>
        [DataMember(Name = "Issues", EmitDefaultValue = false)]
        public List<SCServiceChannelServicesMessagingSiteAuditAuditIssueExternal> Issues { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "Quantity", EmitDefaultValue = false)]
        public SCServiceChannelServicesMessagingSiteAuditQuantityExternal Quantity { get; set; }

        /// <summary>
        /// Gets or Sets CheckListItemImpact
        /// </summary>
        [DataMember(Name = "CheckListItemImpact", EmitDefaultValue = false)]
        public string CheckListItemImpact { get; set; }

        /// <summary>
        /// Gets or Sets WorkOrderIds
        /// </summary>
        [DataMember(Name = "WorkOrderIds", EmitDefaultValue = false)]
        public List<int> WorkOrderIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingSiteAuditCheckListItemRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  System: ").Append(System).Append("\n");
            sb.Append("  Range: ").Append(Range).Append("\n");
            sb.Append("  PassThreshold: ").Append(PassThreshold).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Unlisted: ").Append(Unlisted).Append("\n");
            sb.Append("  Issues: ").Append(Issues).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  CheckListItemImpact: ").Append(CheckListItemImpact).Append("\n");
            sb.Append("  WorkOrderIds: ").Append(WorkOrderIds).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingSiteAuditCheckListItemRequest);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingSiteAuditCheckListItemRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingSiteAuditCheckListItemRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingSiteAuditCheckListItemRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Score == input.Score ||
                    this.Score.Equals(input.Score)
                ) && 
                (
                    this.System == input.System ||
                    this.System.Equals(input.System)
                ) && 
                (
                    this.Range == input.Range ||
                    this.Range != null &&
                    input.Range != null &&
                    this.Range.SequenceEqual(input.Range)
                ) && 
                (
                    this.PassThreshold == input.PassThreshold ||
                    this.PassThreshold.Equals(input.PassThreshold)
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Unlisted == input.Unlisted ||
                    this.Unlisted.Equals(input.Unlisted)
                ) && 
                (
                    this.Issues == input.Issues ||
                    this.Issues != null &&
                    input.Issues != null &&
                    this.Issues.SequenceEqual(input.Issues)
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.CheckListItemImpact == input.CheckListItemImpact ||
                    (this.CheckListItemImpact != null &&
                    this.CheckListItemImpact.Equals(input.CheckListItemImpact))
                ) && 
                (
                    this.WorkOrderIds == input.WorkOrderIds ||
                    this.WorkOrderIds != null &&
                    input.WorkOrderIds != null &&
                    this.WorkOrderIds.SequenceEqual(input.WorkOrderIds)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Score.GetHashCode();
                hashCode = (hashCode * 59) + this.System.GetHashCode();
                if (this.Range != null)
                {
                    hashCode = (hashCode * 59) + this.Range.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PassThreshold.GetHashCode();
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Unlisted.GetHashCode();
                if (this.Issues != null)
                {
                    hashCode = (hashCode * 59) + this.Issues.GetHashCode();
                }
                if (this.Quantity != null)
                {
                    hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
                }
                if (this.CheckListItemImpact != null)
                {
                    hashCode = (hashCode * 59) + this.CheckListItemImpact.GetHashCode();
                }
                if (this.WorkOrderIds != null)
                {
                    hashCode = (hashCode * 59) + this.WorkOrderIds.GetHashCode();
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
