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
    /// Invoice number requirements object.
    /// </summary>
    [DataContract]
    public class SCServiceChannelServicesMessagingInvoicesInvoiceNumberRequirement : IEquatable<SCServiceChannelServicesMessagingInvoicesInvoiceNumberRequirement>
    {
        /// <summary>
        /// ID of the regular expression pattern used to validate the numbers of invoices created manually.
        /// </summary>
        /// <value>ID of the regular expression pattern used to validate the numbers of invoices created manually.</value>
        [DataMember(Name="Id", EmitDefaultValue=true)]
        public int Id { get; set; }

        /// <summary>
        /// Unique ID of the subscriber whose invoice number requirements are returned.
        /// </summary>
        /// <value>Unique ID of the subscriber whose invoice number requirements are returned.</value>
        [DataMember(Name="SubscriberId", EmitDefaultValue=true)]
        public int SubscriberId { get; set; }

        /// <summary>
        /// Regular expression pattern used to validate the numbers of invoices created manually.&lt;br /&gt;A value is returned even if the selected &#x60;RestrictionType&#x60; is &#x60;0&#x60; — *None*. In this case, it’s the last pattern entered in the field.
        /// </summary>
        /// <value>Regular expression pattern used to validate the numbers of invoices created manually.&lt;br /&gt;A value is returned even if the selected &#x60;RestrictionType&#x60; is &#x60;0&#x60; — *None*. In this case, it’s the last pattern entered in the field.</value>
        [DataMember(Name="Pattern", EmitDefaultValue=false)]
        public string Pattern { get; set; }

        /// <summary>
        /// Comment on the invoice number format displayed to a provider user in a tooltip when they try to submit an invoice whose number does not meet the specified restrictions. Invoice numbers are validated by the regular expression pattern specified in &#x60;Pattern&#x60;.&lt;br /&gt;A value is returned even if the selected &#x60;RestrictionType&#x60; is &#x60;0&#x60; — *None*. In this case, it’s the last comment entered in the field.
        /// </summary>
        /// <value>Comment on the invoice number format displayed to a provider user in a tooltip when they try to submit an invoice whose number does not meet the specified restrictions. Invoice numbers are validated by the regular expression pattern specified in &#x60;Pattern&#x60;.&lt;br /&gt;A value is returned even if the selected &#x60;RestrictionType&#x60; is &#x60;0&#x60; — *None*. In this case, it’s the last comment entered in the field.</value>
        [DataMember(Name="Comment", EmitDefaultValue=false)]
        public string Comment { get; set; }


        /// <summary>
        /// Selected restriction for the numbers of invoices created manually. See `RestrictionTypesSelect` to identify which number (`Value`) corresponds to which restriction type.
        /// </summary>
        /// <value>Selected restriction for the numbers of invoices created manually. See `RestrictionTypesSelect` to identify which number (`Value`) corresponds to which restriction type.</value>
        
        public enum RestrictionTypeEnum
        {
            
            /// <summary>
            /// Enum NoneEnum for None
            /// </summary>
            [EnumMember(Value = "None")]
            NoneEnum = 1,
            
            /// <summary>
            /// Enum CustomEnum for Custom
            /// </summary>
            [EnumMember(Value = "Custom")]
            CustomEnum = 2,
            
            /// <summary>
            /// Enum DigitsOnlyEnum for DigitsOnly
            /// </summary>
            [EnumMember(Value = "DigitsOnly")]
            DigitsOnlyEnum = 3,
            
            /// <summary>
            /// Enum AlphaNumericOnlyEnum for AlphaNumericOnly
            /// </summary>
            [EnumMember(Value = "AlphaNumericOnly")]
            AlphaNumericOnlyEnum = 4
        }

        /// <summary>
        /// Selected restriction for the numbers of invoices created manually. See &#x60;RestrictionTypesSelect&#x60; to identify which number (&#x60;Value&#x60;) corresponds to which restriction type.
        /// </summary>
        /// <value>Selected restriction for the numbers of invoices created manually. See &#x60;RestrictionTypesSelect&#x60; to identify which number (&#x60;Value&#x60;) corresponds to which restriction type.</value>
        [DataMember(Name="RestrictionType", EmitDefaultValue=true)]
        public RestrictionTypeEnum RestrictionType { get; set; }


        /// <summary>
        /// Selected rule for the numbers of invoices generated automatically. See `AutoGenerationTypesSelect` to identify which number (`Value`) corresponds to which rule.
        /// </summary>
        /// <value>Selected rule for the numbers of invoices generated automatically. See `AutoGenerationTypesSelect` to identify which number (`Value`) corresponds to which rule.</value>
        
        public enum AutoGenerationTypeEnum
        {
            
            /// <summary>
            /// Enum NoneEnum for None
            /// </summary>
            [EnumMember(Value = "None")]
            NoneEnum = 1,
            
            /// <summary>
            /// Enum CurrentDateEnum for CurrentDate
            /// </summary>
            [EnumMember(Value = "CurrentDate")]
            CurrentDateEnum = 2
        }

        /// <summary>
        /// Selected rule for the numbers of invoices generated automatically. See &#x60;AutoGenerationTypesSelect&#x60; to identify which number (&#x60;Value&#x60;) corresponds to which rule.
        /// </summary>
        /// <value>Selected rule for the numbers of invoices generated automatically. See &#x60;AutoGenerationTypesSelect&#x60; to identify which number (&#x60;Value&#x60;) corresponds to which rule.</value>
        [DataMember(Name="AutoGenerationType", EmitDefaultValue=true)]
        public AutoGenerationTypeEnum AutoGenerationType { get; set; }

        /// <summary>
        /// Date and time when the invoice number requirements were created.
        /// </summary>
        /// <value>Date and time when the invoice number requirements were created.</value>
        [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Date and time when the invoice number requirements were last updated.
        /// </summary>
        /// <value>Date and time when the invoice number requirements were last updated.</value>
        [DataMember(Name="UpdatedDate", EmitDefaultValue=false)]
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// Unique ID of the subscriber admin user who created the invoice number requirements.
        /// </summary>
        /// <value>Unique ID of the subscriber admin user who created the invoice number requirements.</value>
        [DataMember(Name="CreatedByUserId", EmitDefaultValue=true)]
        public int CreatedByUserId { get; set; }

        /// <summary>
        /// Unique ID of the subscriber admin user who last updated the invoice number requirements.
        /// </summary>
        /// <value>Unique ID of the subscriber admin user who last updated the invoice number requirements.</value>
        [DataMember(Name="UpdatedByUserId", EmitDefaultValue=true)]
        public int UpdatedByUserId { get; set; }

        /// <summary>
        /// Username of the subscriber admin who created the invoice number requirements.
        /// </summary>
        /// <value>Username of the subscriber admin who created the invoice number requirements.</value>
        [DataMember(Name="CreatedByUser", EmitDefaultValue=false)]
        public string CreatedByUser { get; set; }

        /// <summary>
        /// Username of the subscriber admin who last updated the invoice number requirements. The username appears in the **Invoice Number** section next to **Last modified**.
        /// </summary>
        /// <value>Username of the subscriber admin who last updated the invoice number requirements. The username appears in the **Invoice Number** section next to **Last modified**.</value>
        [DataMember(Name="UpdatedByUser", EmitDefaultValue=false)]
        public string UpdatedByUser { get; set; }

        /// <summary>
        /// Reuse invoice number
        /// </summary>
        /// <value>Reuse invoice number</value>
        [RegularExpression("^(?:[A-Za-z0-9+/]{4})*(?:[A-Za-z0-9+/]{2}==|[A-Za-z0-9+/]{3}=)?$")]
        [DataMember(Name="ReuseInvoiceNumber", EmitDefaultValue=false)]
        public byte[] ReuseInvoiceNumber { get; set; }

        /// <summary>
        /// Defines whether a default restriction pattern is used.
        /// </summary>
        /// <value>Defines whether a default restriction pattern is used.</value>
        [DataMember(Name="IsNew", EmitDefaultValue=true)]
        public bool IsNew { get; set; } = false;

        /// <summary>
        /// Date when the invoice number requirements were created.
        /// </summary>
        /// <value>Date when the invoice number requirements were created.</value>
        [DataMember(Name="CreatedDateString", EmitDefaultValue=false)]
        public string CreatedDateString { get; set; }

        /// <summary>
        /// Date when the invoice number requirements were last updated. The date appears in the **Invoice Number** section next to **Last modified**.
        /// </summary>
        /// <value>Date when the invoice number requirements were last updated. The date appears in the **Invoice Number** section next to **Last modified**.</value>
        [DataMember(Name="UpdatedDateString", EmitDefaultValue=false)]
        public string UpdatedDateString { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingInvoicesInvoiceNumberRequirement {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SubscriberId: ").Append(SubscriberId).Append("\n");
            sb.Append("  Pattern: ").Append(Pattern).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  RestrictionType: ").Append(RestrictionType).Append("\n");
            sb.Append("  AutoGenerationType: ").Append(AutoGenerationType).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
            sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
            sb.Append("  UpdatedByUserId: ").Append(UpdatedByUserId).Append("\n");
            sb.Append("  CreatedByUser: ").Append(CreatedByUser).Append("\n");
            sb.Append("  UpdatedByUser: ").Append(UpdatedByUser).Append("\n");
            sb.Append("  ReuseInvoiceNumber: ").Append(ReuseInvoiceNumber).Append("\n");
            sb.Append("  IsNew: ").Append(IsNew).Append("\n");
            sb.Append("  CreatedDateString: ").Append(CreatedDateString).Append("\n");
            sb.Append("  UpdatedDateString: ").Append(UpdatedDateString).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingInvoicesInvoiceNumberRequirement)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingInvoicesInvoiceNumberRequirement instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingInvoicesInvoiceNumberRequirement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingInvoicesInvoiceNumberRequirement other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    SubscriberId == other.SubscriberId ||
                    
                    SubscriberId.Equals(other.SubscriberId)
                ) && 
                (
                    Pattern == other.Pattern ||
                    Pattern != null &&
                    Pattern.Equals(other.Pattern)
                ) && 
                (
                    Comment == other.Comment ||
                    Comment != null &&
                    Comment.Equals(other.Comment)
                ) && 
                (
                    RestrictionType == other.RestrictionType ||
                    
                    RestrictionType.Equals(other.RestrictionType)
                ) && 
                (
                    AutoGenerationType == other.AutoGenerationType ||
                    
                    AutoGenerationType.Equals(other.AutoGenerationType)
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
                    CreatedByUserId == other.CreatedByUserId ||
                    
                    CreatedByUserId.Equals(other.CreatedByUserId)
                ) && 
                (
                    UpdatedByUserId == other.UpdatedByUserId ||
                    
                    UpdatedByUserId.Equals(other.UpdatedByUserId)
                ) && 
                (
                    CreatedByUser == other.CreatedByUser ||
                    CreatedByUser != null &&
                    CreatedByUser.Equals(other.CreatedByUser)
                ) && 
                (
                    UpdatedByUser == other.UpdatedByUser ||
                    UpdatedByUser != null &&
                    UpdatedByUser.Equals(other.UpdatedByUser)
                ) && 
                (
                    ReuseInvoiceNumber == other.ReuseInvoiceNumber ||
                    ReuseInvoiceNumber != null &&
                    ReuseInvoiceNumber.Equals(other.ReuseInvoiceNumber)
                ) && 
                (
                    IsNew == other.IsNew ||
                    
                    IsNew.Equals(other.IsNew)
                ) && 
                (
                    CreatedDateString == other.CreatedDateString ||
                    CreatedDateString != null &&
                    CreatedDateString.Equals(other.CreatedDateString)
                ) && 
                (
                    UpdatedDateString == other.UpdatedDateString ||
                    UpdatedDateString != null &&
                    UpdatedDateString.Equals(other.UpdatedDateString)
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
                    
                    hashCode = hashCode * 59 + SubscriberId.GetHashCode();
                    if (Pattern != null)
                    hashCode = hashCode * 59 + Pattern.GetHashCode();
                    if (Comment != null)
                    hashCode = hashCode * 59 + Comment.GetHashCode();
                    
                    hashCode = hashCode * 59 + RestrictionType.GetHashCode();
                    
                    hashCode = hashCode * 59 + AutoGenerationType.GetHashCode();
                    if (CreatedDate != null)
                    hashCode = hashCode * 59 + CreatedDate.GetHashCode();
                    if (UpdatedDate != null)
                    hashCode = hashCode * 59 + UpdatedDate.GetHashCode();
                    
                    hashCode = hashCode * 59 + CreatedByUserId.GetHashCode();
                    
                    hashCode = hashCode * 59 + UpdatedByUserId.GetHashCode();
                    if (CreatedByUser != null)
                    hashCode = hashCode * 59 + CreatedByUser.GetHashCode();
                    if (UpdatedByUser != null)
                    hashCode = hashCode * 59 + UpdatedByUser.GetHashCode();
                    if (ReuseInvoiceNumber != null)
                    hashCode = hashCode * 59 + ReuseInvoiceNumber.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsNew.GetHashCode();
                    if (CreatedDateString != null)
                    hashCode = hashCode * 59 + CreatedDateString.GetHashCode();
                    if (UpdatedDateString != null)
                    hashCode = hashCode * 59 + UpdatedDateString.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingInvoicesInvoiceNumberRequirement left, SCServiceChannelServicesMessagingInvoicesInvoiceNumberRequirement right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingInvoicesInvoiceNumberRequirement left, SCServiceChannelServicesMessagingInvoicesInvoiceNumberRequirement right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}