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
    public class SCServiceChannelServicesMessagingBatchRfpBatchCreateRfp : IEquatable<SCServiceChannelServicesMessagingBatchRfpBatchCreateRfp>
    {
        /// <summary>
        /// The non-unique RFP identifier. The value is generated automatically if not provided. It cannot be modified.
        /// </summary>
        /// <value>The non-unique RFP identifier. The value is generated automatically if not provided. It cannot be modified.</value>
        [DataMember(Name="RfpNumber", EmitDefaultValue=false)]
        public string RfpNumber { get; set; }

        /// <summary>
        /// The unique trade identifier.
        /// </summary>
        /// <value>The unique trade identifier.</value>
        [Required]
        [DataMember(Name="TradeId", EmitDefaultValue=true)]
        public int TradeId { get; set; }

        /// <summary>
        /// RFP description.
        /// </summary>
        /// <value>RFP description.</value>
        [Required]
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The RFP creation date and time. The format is &#x60;YYYY-MM-DDThh:mm:ss.sssZ&#x60;. The default is the current date and time.
        /// </summary>
        /// <value>The RFP creation date and time. The format is &#x60;YYYY-MM-DDThh:mm:ss.sssZ&#x60;. The default is the current date and time.</value>
        [DataMember(Name="Date", EmitDefaultValue=false)]
        public DateTime Date { get; set; }

        /// <summary>
        /// Due time in hours for the provider to respond to the RFP and submit a proposal. The default is 48 hours unless a different value is specified in the &#x60;UiCreationRfpDefaultTime&#x60; settings group.
        /// </summary>
        /// <value>Due time in hours for the provider to respond to the RFP and submit a proposal. The default is 48 hours unless a different value is specified in the &#x60;UiCreationRfpDefaultTime&#x60; settings group.</value>
        [DataMember(Name="DueHrs", EmitDefaultValue=true)]
        public double DueHrs { get; set; }

        /// <summary>
        /// Due date and time for the provider to respond to the RFP and submit a proposal. The format is &#x60;YYYY-MM-DDThh:mm:ss.sssZ&#x60;. If &#x60;DueHrs&#x60; is passed, the &#x60;DueDate&#x60; value is &#x60;Date&#x60; plus &#x60;DueHrs&#x60;.              The default is the current date and time plus 48 hours unless a different value is specified in the &#x60;UiCreationRfpDefaultTime&#x60; settings group.
        /// </summary>
        /// <value>Due date and time for the provider to respond to the RFP and submit a proposal. The format is &#x60;YYYY-MM-DDThh:mm:ss.sssZ&#x60;. If &#x60;DueHrs&#x60; is passed, the &#x60;DueDate&#x60; value is &#x60;Date&#x60; plus &#x60;DueHrs&#x60;.              The default is the current date and time plus 48 hours unless a different value is specified in the &#x60;UiCreationRfpDefaultTime&#x60; settings group.</value>
        [DataMember(Name="DueDate", EmitDefaultValue=false)]
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Location identifier
        /// </summary>
        /// <value>Location identifier</value>
        [Required]
        [DataMember(Name="LocationId", EmitDefaultValue=true)]
        public int LocationId { get; set; }

        /// <summary>
        /// Create Request Id from project module
        /// </summary>
        /// <value>Create Request Id from project module</value>
        [DataMember(Name="CreateRequestId", EmitDefaultValue=false)]
        public string CreateRequestId { get; set; }

        /// <summary>
        /// Store ID
        /// </summary>
        /// <value>Store ID</value>
        [Required]
        [DataMember(Name="LocationName", EmitDefaultValue=false)]
        public string LocationName { get; set; }

        /// <summary>
        /// The unique provider identifier.
        /// </summary>
        /// <value>The unique provider identifier.</value>
        [Required]
        [DataMember(Name="ProviderId", EmitDefaultValue=true)]
        public int ProviderId { get; set; }

        /// <summary>
        /// The unique project identifier.
        /// </summary>
        /// <value>The unique project identifier.</value>
        [DataMember(Name="ProjectId", EmitDefaultValue=true)]
        public int ProjectId { get; set; }

        /// <summary>
        /// The Purchase Order.
        /// </summary>
        /// <value>The Purchase Order.</value>
        [DataMember(Name="PurchaseOrder", EmitDefaultValue=false)]
        public string PurchaseOrder { get; set; }

        /// <summary>
        /// Provider&#39;s email
        /// </summary>
        /// <value>Provider&#39;s email</value>
        [DataMember(Name="ProviderEmail", EmitDefaultValue=false)]
        public string ProviderEmail { get; set; }

        /// <summary>
        /// User&#39;s email
        /// </summary>
        /// <value>User&#39;s email</value>
        [DataMember(Name="WaitingForPrpEmail", EmitDefaultValue=false)]
        public string WaitingForPrpEmail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingBatchRfpBatchCreateRfp {\n");
            sb.Append("  RfpNumber: ").Append(RfpNumber).Append("\n");
            sb.Append("  TradeId: ").Append(TradeId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  DueHrs: ").Append(DueHrs).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  CreateRequestId: ").Append(CreateRequestId).Append("\n");
            sb.Append("  LocationName: ").Append(LocationName).Append("\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  PurchaseOrder: ").Append(PurchaseOrder).Append("\n");
            sb.Append("  ProviderEmail: ").Append(ProviderEmail).Append("\n");
            sb.Append("  WaitingForPrpEmail: ").Append(WaitingForPrpEmail).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingBatchRfpBatchCreateRfp)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingBatchRfpBatchCreateRfp instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingBatchRfpBatchCreateRfp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingBatchRfpBatchCreateRfp other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    RfpNumber == other.RfpNumber ||
                    RfpNumber != null &&
                    RfpNumber.Equals(other.RfpNumber)
                ) && 
                (
                    TradeId == other.TradeId ||
                    
                    TradeId.Equals(other.TradeId)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    Date == other.Date ||
                    Date != null &&
                    Date.Equals(other.Date)
                ) && 
                (
                    DueHrs == other.DueHrs ||
                    
                    DueHrs.Equals(other.DueHrs)
                ) && 
                (
                    DueDate == other.DueDate ||
                    DueDate != null &&
                    DueDate.Equals(other.DueDate)
                ) && 
                (
                    LocationId == other.LocationId ||
                    
                    LocationId.Equals(other.LocationId)
                ) && 
                (
                    CreateRequestId == other.CreateRequestId ||
                    CreateRequestId != null &&
                    CreateRequestId.Equals(other.CreateRequestId)
                ) && 
                (
                    LocationName == other.LocationName ||
                    LocationName != null &&
                    LocationName.Equals(other.LocationName)
                ) && 
                (
                    ProviderId == other.ProviderId ||
                    
                    ProviderId.Equals(other.ProviderId)
                ) && 
                (
                    ProjectId == other.ProjectId ||
                    
                    ProjectId.Equals(other.ProjectId)
                ) && 
                (
                    PurchaseOrder == other.PurchaseOrder ||
                    PurchaseOrder != null &&
                    PurchaseOrder.Equals(other.PurchaseOrder)
                ) && 
                (
                    ProviderEmail == other.ProviderEmail ||
                    ProviderEmail != null &&
                    ProviderEmail.Equals(other.ProviderEmail)
                ) && 
                (
                    WaitingForPrpEmail == other.WaitingForPrpEmail ||
                    WaitingForPrpEmail != null &&
                    WaitingForPrpEmail.Equals(other.WaitingForPrpEmail)
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
                    if (RfpNumber != null)
                    hashCode = hashCode * 59 + RfpNumber.GetHashCode();
                    
                    hashCode = hashCode * 59 + TradeId.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (Date != null)
                    hashCode = hashCode * 59 + Date.GetHashCode();
                    
                    hashCode = hashCode * 59 + DueHrs.GetHashCode();
                    if (DueDate != null)
                    hashCode = hashCode * 59 + DueDate.GetHashCode();
                    
                    hashCode = hashCode * 59 + LocationId.GetHashCode();
                    if (CreateRequestId != null)
                    hashCode = hashCode * 59 + CreateRequestId.GetHashCode();
                    if (LocationName != null)
                    hashCode = hashCode * 59 + LocationName.GetHashCode();
                    
                    hashCode = hashCode * 59 + ProviderId.GetHashCode();
                    
                    hashCode = hashCode * 59 + ProjectId.GetHashCode();
                    if (PurchaseOrder != null)
                    hashCode = hashCode * 59 + PurchaseOrder.GetHashCode();
                    if (ProviderEmail != null)
                    hashCode = hashCode * 59 + ProviderEmail.GetHashCode();
                    if (WaitingForPrpEmail != null)
                    hashCode = hashCode * 59 + WaitingForPrpEmail.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingBatchRfpBatchCreateRfp left, SCServiceChannelServicesMessagingBatchRfpBatchCreateRfp right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingBatchRfpBatchCreateRfp left, SCServiceChannelServicesMessagingBatchRfpBatchCreateRfp right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}