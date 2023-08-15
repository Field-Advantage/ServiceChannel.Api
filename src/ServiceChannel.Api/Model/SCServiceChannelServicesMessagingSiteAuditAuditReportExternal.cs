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
    /// The site audit report object. Depending on the features enabled for your company, the object structure may differ from the example below.
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.SiteAudit.AuditReportExternal")]
    public partial class SCServiceChannelServicesMessagingSiteAuditAuditReportExternal : IEquatable<SCServiceChannelServicesMessagingSiteAuditAuditReportExternal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingSiteAuditAuditReportExternal" /> class.
        /// </summary>
        /// <param name="templateTypeName">The site audit type..</param>
        /// <param name="auditId">The numeric identifier of the site audit report..</param>
        /// <param name="storeId">The internal identifier of the subscriber’s property..</param>
        /// <param name="locationName">The name of the subscriber’s property..</param>
        /// <param name="region">The region where the property is located..</param>
        /// <param name="district">The district where the property is located..</param>
        /// <param name="areaName">The name of the audited area within the location..</param>
        /// <param name="checkListName">The name of the checklist..</param>
        /// <param name="checkListItemName">The name of the checklist item inspected by the auditor..</param>
        /// <param name="checkListItemDescription">Detailed instructions for the auditor on how to check or rate the checklist item..</param>
        /// <param name="status">This field is obsolete. Use field \&quot;Score\&quot; with \&quot;PassThreshold\&quot; and \&quot;RatingSystem\&quot; fields  please..</param>
        /// <param name="score">The score that the auditor gave on the checklist item.</param>
        /// <param name="passThreshold">Pass threshold.</param>
        /// <param name="ratingSystem">Rating system.</param>
        /// <param name="checkListItemQuantity">The quantity of the checklist item or its cost in dollars depending on the &#x60;Unit&#x60;..</param>
        /// <param name="unit">The unit of measure of the checklist item: &#x60;Quantity&#x60; or &#x60;Dollars&#x60;..</param>
        /// <param name="checkListDate">The date and time when the auditor completed the audit of the checklist item..</param>
        /// <param name="timeOffset">The UTC offset, or the difference in hours from the UTC time..</param>
        /// <param name="userName">The username of the auditor who uploaded the completed audit..</param>
        /// <param name="checkListItemId">The numeric identifier of the checklist item..</param>
        /// <param name="auditStartDate">The date and time when the auditor started the site audit..</param>
        /// <param name="auditFinishDate">The date and time when the auditor completed the site audit..</param>
        /// <param name="auditIssues">auditIssues.</param>
        public SCServiceChannelServicesMessagingSiteAuditAuditReportExternal(string templateTypeName = default(string), int auditId = default(int), string storeId = default(string), string locationName = default(string), string region = default(string), string district = default(string), string areaName = default(string), string checkListName = default(string), string checkListItemName = default(string), string checkListItemDescription = default(string), string status = default(string), int score = default(int), int passThreshold = default(int), string ratingSystem = default(string), string checkListItemQuantity = default(string), string unit = default(string), DateTime checkListDate = default(DateTime), int timeOffset = default(int), string userName = default(string), int checkListItemId = default(int), DateTime auditStartDate = default(DateTime), DateTime auditFinishDate = default(DateTime), List<SCServiceChannelServicesMessagingSiteAuditAuditReportIssueExternal> auditIssues = default(List<SCServiceChannelServicesMessagingSiteAuditAuditReportIssueExternal>))
        {
            this.TemplateTypeName = templateTypeName;
            this.AuditId = auditId;
            this.StoreId = storeId;
            this.LocationName = locationName;
            this.Region = region;
            this.District = district;
            this.AreaName = areaName;
            this.CheckListName = checkListName;
            this.CheckListItemName = checkListItemName;
            this.CheckListItemDescription = checkListItemDescription;
            this.Status = status;
            this.Score = score;
            this.PassThreshold = passThreshold;
            this.RatingSystem = ratingSystem;
            this.CheckListItemQuantity = checkListItemQuantity;
            this.Unit = unit;
            this.CheckListDate = checkListDate;
            this.TimeOffset = timeOffset;
            this.UserName = userName;
            this.CheckListItemId = checkListItemId;
            this.AuditStartDate = auditStartDate;
            this.AuditFinishDate = auditFinishDate;
            this.AuditIssues = auditIssues;
        }

        /// <summary>
        /// The site audit type.
        /// </summary>
        /// <value>The site audit type.</value>
        [DataMember(Name = "TemplateTypeName", EmitDefaultValue = false)]
        public string TemplateTypeName { get; set; }

        /// <summary>
        /// The numeric identifier of the site audit report.
        /// </summary>
        /// <value>The numeric identifier of the site audit report.</value>
        [DataMember(Name = "AuditId", EmitDefaultValue = false)]
        public int AuditId { get; set; }

        /// <summary>
        /// The internal identifier of the subscriber’s property.
        /// </summary>
        /// <value>The internal identifier of the subscriber’s property.</value>
        [DataMember(Name = "StoreId", EmitDefaultValue = false)]
        public string StoreId { get; set; }

        /// <summary>
        /// The name of the subscriber’s property.
        /// </summary>
        /// <value>The name of the subscriber’s property.</value>
        [DataMember(Name = "LocationName", EmitDefaultValue = false)]
        public string LocationName { get; set; }

        /// <summary>
        /// The region where the property is located.
        /// </summary>
        /// <value>The region where the property is located.</value>
        [DataMember(Name = "Region", EmitDefaultValue = false)]
        public string Region { get; set; }

        /// <summary>
        /// The district where the property is located.
        /// </summary>
        /// <value>The district where the property is located.</value>
        [DataMember(Name = "District", EmitDefaultValue = false)]
        public string District { get; set; }

        /// <summary>
        /// The name of the audited area within the location.
        /// </summary>
        /// <value>The name of the audited area within the location.</value>
        [DataMember(Name = "AreaName", EmitDefaultValue = false)]
        public string AreaName { get; set; }

        /// <summary>
        /// The name of the checklist.
        /// </summary>
        /// <value>The name of the checklist.</value>
        [DataMember(Name = "CheckListName", EmitDefaultValue = false)]
        public string CheckListName { get; set; }

        /// <summary>
        /// The name of the checklist item inspected by the auditor.
        /// </summary>
        /// <value>The name of the checklist item inspected by the auditor.</value>
        [DataMember(Name = "CheckListItemName", EmitDefaultValue = false)]
        public string CheckListItemName { get; set; }

        /// <summary>
        /// Detailed instructions for the auditor on how to check or rate the checklist item.
        /// </summary>
        /// <value>Detailed instructions for the auditor on how to check or rate the checklist item.</value>
        [DataMember(Name = "CheckListItemDescription", EmitDefaultValue = false)]
        public string CheckListItemDescription { get; set; }

        /// <summary>
        /// This field is obsolete. Use field \&quot;Score\&quot; with \&quot;PassThreshold\&quot; and \&quot;RatingSystem\&quot; fields  please.
        /// </summary>
        /// <value>This field is obsolete. Use field \&quot;Score\&quot; with \&quot;PassThreshold\&quot; and \&quot;RatingSystem\&quot; fields  please.</value>
        [DataMember(Name = "Status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// The score that the auditor gave on the checklist item
        /// </summary>
        /// <value>The score that the auditor gave on the checklist item</value>
        [DataMember(Name = "Score", EmitDefaultValue = false)]
        public int Score { get; set; }

        /// <summary>
        /// Pass threshold
        /// </summary>
        /// <value>Pass threshold</value>
        [DataMember(Name = "PassThreshold", EmitDefaultValue = false)]
        public int PassThreshold { get; set; }

        /// <summary>
        /// Rating system
        /// </summary>
        /// <value>Rating system</value>
        [DataMember(Name = "RatingSystem", EmitDefaultValue = false)]
        public string RatingSystem { get; set; }

        /// <summary>
        /// The quantity of the checklist item or its cost in dollars depending on the &#x60;Unit&#x60;.
        /// </summary>
        /// <value>The quantity of the checklist item or its cost in dollars depending on the &#x60;Unit&#x60;.</value>
        [DataMember(Name = "CheckListItemQuantity", EmitDefaultValue = false)]
        public string CheckListItemQuantity { get; set; }

        /// <summary>
        /// The unit of measure of the checklist item: &#x60;Quantity&#x60; or &#x60;Dollars&#x60;.
        /// </summary>
        /// <value>The unit of measure of the checklist item: &#x60;Quantity&#x60; or &#x60;Dollars&#x60;.</value>
        [DataMember(Name = "Unit", EmitDefaultValue = false)]
        public string Unit { get; set; }

        /// <summary>
        /// The date and time when the auditor completed the audit of the checklist item.
        /// </summary>
        /// <value>The date and time when the auditor completed the audit of the checklist item.</value>
        [DataMember(Name = "CheckListDate", EmitDefaultValue = false)]
        public DateTime CheckListDate { get; set; }

        /// <summary>
        /// The UTC offset, or the difference in hours from the UTC time.
        /// </summary>
        /// <value>The UTC offset, or the difference in hours from the UTC time.</value>
        [DataMember(Name = "TimeOffset", EmitDefaultValue = false)]
        public int TimeOffset { get; set; }

        /// <summary>
        /// The username of the auditor who uploaded the completed audit.
        /// </summary>
        /// <value>The username of the auditor who uploaded the completed audit.</value>
        [DataMember(Name = "UserName", EmitDefaultValue = false)]
        public string UserName { get; set; }

        /// <summary>
        /// The numeric identifier of the checklist item.
        /// </summary>
        /// <value>The numeric identifier of the checklist item.</value>
        [DataMember(Name = "CheckListItemId", EmitDefaultValue = false)]
        public int CheckListItemId { get; set; }

        /// <summary>
        /// The date and time when the auditor started the site audit.
        /// </summary>
        /// <value>The date and time when the auditor started the site audit.</value>
        [DataMember(Name = "AuditStartDate", EmitDefaultValue = false)]
        public DateTime AuditStartDate { get; set; }

        /// <summary>
        /// The date and time when the auditor completed the site audit.
        /// </summary>
        /// <value>The date and time when the auditor completed the site audit.</value>
        [DataMember(Name = "AuditFinishDate", EmitDefaultValue = false)]
        public DateTime AuditFinishDate { get; set; }

        /// <summary>
        /// Gets or Sets AuditIssues
        /// </summary>
        [DataMember(Name = "AuditIssues", EmitDefaultValue = false)]
        public List<SCServiceChannelServicesMessagingSiteAuditAuditReportIssueExternal> AuditIssues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingSiteAuditAuditReportExternal {\n");
            sb.Append("  TemplateTypeName: ").Append(TemplateTypeName).Append("\n");
            sb.Append("  AuditId: ").Append(AuditId).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  LocationName: ").Append(LocationName).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  District: ").Append(District).Append("\n");
            sb.Append("  AreaName: ").Append(AreaName).Append("\n");
            sb.Append("  CheckListName: ").Append(CheckListName).Append("\n");
            sb.Append("  CheckListItemName: ").Append(CheckListItemName).Append("\n");
            sb.Append("  CheckListItemDescription: ").Append(CheckListItemDescription).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  PassThreshold: ").Append(PassThreshold).Append("\n");
            sb.Append("  RatingSystem: ").Append(RatingSystem).Append("\n");
            sb.Append("  CheckListItemQuantity: ").Append(CheckListItemQuantity).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  CheckListDate: ").Append(CheckListDate).Append("\n");
            sb.Append("  TimeOffset: ").Append(TimeOffset).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  CheckListItemId: ").Append(CheckListItemId).Append("\n");
            sb.Append("  AuditStartDate: ").Append(AuditStartDate).Append("\n");
            sb.Append("  AuditFinishDate: ").Append(AuditFinishDate).Append("\n");
            sb.Append("  AuditIssues: ").Append(AuditIssues).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingSiteAuditAuditReportExternal);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingSiteAuditAuditReportExternal instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingSiteAuditAuditReportExternal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingSiteAuditAuditReportExternal input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TemplateTypeName == input.TemplateTypeName ||
                    (this.TemplateTypeName != null &&
                    this.TemplateTypeName.Equals(input.TemplateTypeName))
                ) && 
                (
                    this.AuditId == input.AuditId ||
                    this.AuditId.Equals(input.AuditId)
                ) && 
                (
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
                ) && 
                (
                    this.LocationName == input.LocationName ||
                    (this.LocationName != null &&
                    this.LocationName.Equals(input.LocationName))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.District == input.District ||
                    (this.District != null &&
                    this.District.Equals(input.District))
                ) && 
                (
                    this.AreaName == input.AreaName ||
                    (this.AreaName != null &&
                    this.AreaName.Equals(input.AreaName))
                ) && 
                (
                    this.CheckListName == input.CheckListName ||
                    (this.CheckListName != null &&
                    this.CheckListName.Equals(input.CheckListName))
                ) && 
                (
                    this.CheckListItemName == input.CheckListItemName ||
                    (this.CheckListItemName != null &&
                    this.CheckListItemName.Equals(input.CheckListItemName))
                ) && 
                (
                    this.CheckListItemDescription == input.CheckListItemDescription ||
                    (this.CheckListItemDescription != null &&
                    this.CheckListItemDescription.Equals(input.CheckListItemDescription))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Score == input.Score ||
                    this.Score.Equals(input.Score)
                ) && 
                (
                    this.PassThreshold == input.PassThreshold ||
                    this.PassThreshold.Equals(input.PassThreshold)
                ) && 
                (
                    this.RatingSystem == input.RatingSystem ||
                    (this.RatingSystem != null &&
                    this.RatingSystem.Equals(input.RatingSystem))
                ) && 
                (
                    this.CheckListItemQuantity == input.CheckListItemQuantity ||
                    (this.CheckListItemQuantity != null &&
                    this.CheckListItemQuantity.Equals(input.CheckListItemQuantity))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.CheckListDate == input.CheckListDate ||
                    (this.CheckListDate != null &&
                    this.CheckListDate.Equals(input.CheckListDate))
                ) && 
                (
                    this.TimeOffset == input.TimeOffset ||
                    this.TimeOffset.Equals(input.TimeOffset)
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.CheckListItemId == input.CheckListItemId ||
                    this.CheckListItemId.Equals(input.CheckListItemId)
                ) && 
                (
                    this.AuditStartDate == input.AuditStartDate ||
                    (this.AuditStartDate != null &&
                    this.AuditStartDate.Equals(input.AuditStartDate))
                ) && 
                (
                    this.AuditFinishDate == input.AuditFinishDate ||
                    (this.AuditFinishDate != null &&
                    this.AuditFinishDate.Equals(input.AuditFinishDate))
                ) && 
                (
                    this.AuditIssues == input.AuditIssues ||
                    this.AuditIssues != null &&
                    input.AuditIssues != null &&
                    this.AuditIssues.SequenceEqual(input.AuditIssues)
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
                if (this.TemplateTypeName != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateTypeName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AuditId.GetHashCode();
                if (this.StoreId != null)
                {
                    hashCode = (hashCode * 59) + this.StoreId.GetHashCode();
                }
                if (this.LocationName != null)
                {
                    hashCode = (hashCode * 59) + this.LocationName.GetHashCode();
                }
                if (this.Region != null)
                {
                    hashCode = (hashCode * 59) + this.Region.GetHashCode();
                }
                if (this.District != null)
                {
                    hashCode = (hashCode * 59) + this.District.GetHashCode();
                }
                if (this.AreaName != null)
                {
                    hashCode = (hashCode * 59) + this.AreaName.GetHashCode();
                }
                if (this.CheckListName != null)
                {
                    hashCode = (hashCode * 59) + this.CheckListName.GetHashCode();
                }
                if (this.CheckListItemName != null)
                {
                    hashCode = (hashCode * 59) + this.CheckListItemName.GetHashCode();
                }
                if (this.CheckListItemDescription != null)
                {
                    hashCode = (hashCode * 59) + this.CheckListItemDescription.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Score.GetHashCode();
                hashCode = (hashCode * 59) + this.PassThreshold.GetHashCode();
                if (this.RatingSystem != null)
                {
                    hashCode = (hashCode * 59) + this.RatingSystem.GetHashCode();
                }
                if (this.CheckListItemQuantity != null)
                {
                    hashCode = (hashCode * 59) + this.CheckListItemQuantity.GetHashCode();
                }
                if (this.Unit != null)
                {
                    hashCode = (hashCode * 59) + this.Unit.GetHashCode();
                }
                if (this.CheckListDate != null)
                {
                    hashCode = (hashCode * 59) + this.CheckListDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TimeOffset.GetHashCode();
                if (this.UserName != null)
                {
                    hashCode = (hashCode * 59) + this.UserName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CheckListItemId.GetHashCode();
                if (this.AuditStartDate != null)
                {
                    hashCode = (hashCode * 59) + this.AuditStartDate.GetHashCode();
                }
                if (this.AuditFinishDate != null)
                {
                    hashCode = (hashCode * 59) + this.AuditFinishDate.GetHashCode();
                }
                if (this.AuditIssues != null)
                {
                    hashCode = (hashCode * 59) + this.AuditIssues.GetHashCode();
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
