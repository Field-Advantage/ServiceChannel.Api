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
    /// SCServiceChannelServicesMessagingWorkordersWorkOrderSearchRequest
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.Workorders.WorkOrderSearchRequest")]
    public partial class SCServiceChannelServicesMessagingWorkordersWorkOrderSearchRequest : IEquatable<SCServiceChannelServicesMessagingWorkordersWorkOrderSearchRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingWorkordersWorkOrderSearchRequest" /> class.
        /// </summary>
        /// <param name="otherLocationId">UID of location, exact search by default.</param>
        /// <param name="id">UID of work order, exact search by default.</param>
        /// <param name="category">Category of work order, exact search by default.</param>
        /// <param name="status">Status of work order, exact search by default.</param>
        /// <param name="extendedStatus">Extended status of work order, exact search by default.</param>
        /// <param name="number">Work order number, &#39;starts with&#39; search criteria by default.</param>
        /// <param name="serviceId">&#39;starts with&#39; search criteria by default.</param>
        /// <param name="priority">Priority of work order, exact search by default.</param>
        /// <param name="purchaseNumber">Purchase number of work order, &#39;starts with&#39; search criteria by default.</param>
        /// <param name="trade">Trade, &#39;starts with&#39; search criteria by default.</param>
        /// <param name="scheduledDate">Scheduled date.</param>
        /// <param name="expirationDate">Expiration date.</param>
        /// <param name="callDate">Call date.</param>
        /// <param name="sort">Sort resources by the specified property in the response..</param>
        /// <param name="page">Results page number..</param>
        /// <param name="pageSize">Number of objects on the results page. The default and maximum per page is 50..</param>
        public SCServiceChannelServicesMessagingWorkordersWorkOrderSearchRequest(List<SCServiceChannelServicesMessagingFilterItemSystemInt32> otherLocationId = default(List<SCServiceChannelServicesMessagingFilterItemSystemInt32>), List<SCServiceChannelServicesMessagingFilterItemSystemInt32> id = default(List<SCServiceChannelServicesMessagingFilterItemSystemInt32>), List<SCServiceChannelServicesMessagingFilterItemSystemString> category = default(List<SCServiceChannelServicesMessagingFilterItemSystemString>), List<SCServiceChannelServicesMessagingFilterItemSystemString> status = default(List<SCServiceChannelServicesMessagingFilterItemSystemString>), List<SCServiceChannelServicesMessagingFilterItemSystemString> extendedStatus = default(List<SCServiceChannelServicesMessagingFilterItemSystemString>), List<SCServiceChannelServicesMessagingFilterItemSystemString> number = default(List<SCServiceChannelServicesMessagingFilterItemSystemString>), List<SCServiceChannelServicesMessagingFilterItemSystemString> serviceId = default(List<SCServiceChannelServicesMessagingFilterItemSystemString>), List<SCServiceChannelServicesMessagingFilterItemSystemString> priority = default(List<SCServiceChannelServicesMessagingFilterItemSystemString>), List<SCServiceChannelServicesMessagingFilterItemSystemString> purchaseNumber = default(List<SCServiceChannelServicesMessagingFilterItemSystemString>), List<SCServiceChannelServicesMessagingFilterItemSystemString> trade = default(List<SCServiceChannelServicesMessagingFilterItemSystemString>), List<SCServiceChannelServicesMessagingFilterItemSystemString> scheduledDate = default(List<SCServiceChannelServicesMessagingFilterItemSystemString>), List<SCServiceChannelServicesMessagingFilterItemSystemString> expirationDate = default(List<SCServiceChannelServicesMessagingFilterItemSystemString>), List<SCServiceChannelServicesMessagingFilterItemSystemString> callDate = default(List<SCServiceChannelServicesMessagingFilterItemSystemString>), string sort = default(string), int page = default(int), int pageSize = default(int))
        {
            this.OtherLocationId = otherLocationId;
            this.Id = id;
            this.Category = category;
            this.Status = status;
            this.ExtendedStatus = extendedStatus;
            this.Number = number;
            this.ServiceId = serviceId;
            this.Priority = priority;
            this.PurchaseNumber = purchaseNumber;
            this.Trade = trade;
            this.ScheduledDate = scheduledDate;
            this.ExpirationDate = expirationDate;
            this.CallDate = callDate;
            this.Sort = sort;
            this.Page = page;
            this.PageSize = pageSize;
        }

        /// <summary>
        /// UID of location, exact search by default
        /// </summary>
        /// <value>UID of location, exact search by default</value>
        [DataMember(Name = "OtherLocationId", EmitDefaultValue = false)]
        public List<SCServiceChannelServicesMessagingFilterItemSystemInt32> OtherLocationId { get; set; }

        /// <summary>
        /// UID of work order, exact search by default
        /// </summary>
        /// <value>UID of work order, exact search by default</value>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public List<SCServiceChannelServicesMessagingFilterItemSystemInt32> Id { get; set; }

        /// <summary>
        /// Category of work order, exact search by default
        /// </summary>
        /// <value>Category of work order, exact search by default</value>
        [DataMember(Name = "Category", EmitDefaultValue = false)]
        public List<SCServiceChannelServicesMessagingFilterItemSystemString> Category { get; set; }

        /// <summary>
        /// Status of work order, exact search by default
        /// </summary>
        /// <value>Status of work order, exact search by default</value>
        [DataMember(Name = "Status", EmitDefaultValue = false)]
        public List<SCServiceChannelServicesMessagingFilterItemSystemString> Status { get; set; }

        /// <summary>
        /// Extended status of work order, exact search by default
        /// </summary>
        /// <value>Extended status of work order, exact search by default</value>
        [DataMember(Name = "ExtendedStatus", EmitDefaultValue = false)]
        public List<SCServiceChannelServicesMessagingFilterItemSystemString> ExtendedStatus { get; set; }

        /// <summary>
        /// Work order number, &#39;starts with&#39; search criteria by default
        /// </summary>
        /// <value>Work order number, &#39;starts with&#39; search criteria by default</value>
        [DataMember(Name = "Number", EmitDefaultValue = false)]
        public List<SCServiceChannelServicesMessagingFilterItemSystemString> Number { get; set; }

        /// <summary>
        /// &#39;starts with&#39; search criteria by default
        /// </summary>
        /// <value>&#39;starts with&#39; search criteria by default</value>
        [DataMember(Name = "ServiceId", EmitDefaultValue = false)]
        public List<SCServiceChannelServicesMessagingFilterItemSystemString> ServiceId { get; set; }

        /// <summary>
        /// Priority of work order, exact search by default
        /// </summary>
        /// <value>Priority of work order, exact search by default</value>
        [DataMember(Name = "Priority", EmitDefaultValue = false)]
        public List<SCServiceChannelServicesMessagingFilterItemSystemString> Priority { get; set; }

        /// <summary>
        /// Purchase number of work order, &#39;starts with&#39; search criteria by default
        /// </summary>
        /// <value>Purchase number of work order, &#39;starts with&#39; search criteria by default</value>
        [DataMember(Name = "PurchaseNumber", EmitDefaultValue = false)]
        public List<SCServiceChannelServicesMessagingFilterItemSystemString> PurchaseNumber { get; set; }

        /// <summary>
        /// Trade, &#39;starts with&#39; search criteria by default
        /// </summary>
        /// <value>Trade, &#39;starts with&#39; search criteria by default</value>
        [DataMember(Name = "Trade", EmitDefaultValue = false)]
        public List<SCServiceChannelServicesMessagingFilterItemSystemString> Trade { get; set; }

        /// <summary>
        /// Scheduled date
        /// </summary>
        /// <value>Scheduled date</value>
        [DataMember(Name = "ScheduledDate", EmitDefaultValue = false)]
        public List<SCServiceChannelServicesMessagingFilterItemSystemString> ScheduledDate { get; set; }

        /// <summary>
        /// Expiration date
        /// </summary>
        /// <value>Expiration date</value>
        [DataMember(Name = "ExpirationDate", EmitDefaultValue = false)]
        public List<SCServiceChannelServicesMessagingFilterItemSystemString> ExpirationDate { get; set; }

        /// <summary>
        /// Call date
        /// </summary>
        /// <value>Call date</value>
        [DataMember(Name = "CallDate", EmitDefaultValue = false)]
        public List<SCServiceChannelServicesMessagingFilterItemSystemString> CallDate { get; set; }

        /// <summary>
        /// Sort resources by the specified property in the response.
        /// </summary>
        /// <value>Sort resources by the specified property in the response.</value>
        [DataMember(Name = "Sort", EmitDefaultValue = false)]
        public string Sort { get; set; }

        /// <summary>
        /// Results page number.
        /// </summary>
        /// <value>Results page number.</value>
        [DataMember(Name = "Page", EmitDefaultValue = false)]
        public int Page { get; set; }

        /// <summary>
        /// Gets or Sets IsPageSizeDefault
        /// </summary>
        [DataMember(Name = "IsPageSizeDefault", EmitDefaultValue = true)]
        public bool IsPageSizeDefault { get; private set; }

        /// <summary>
        /// Returns false as IsPageSizeDefault should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsPageSizeDefault()
        {
            return false;
        }
        /// <summary>
        /// Number of objects on the results page. The default and maximum per page is 50.
        /// </summary>
        /// <value>Number of objects on the results page. The default and maximum per page is 50.</value>
        [DataMember(Name = "PageSize", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingWorkordersWorkOrderSearchRequest {\n");
            sb.Append("  OtherLocationId: ").Append(OtherLocationId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ExtendedStatus: ").Append(ExtendedStatus).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  ServiceId: ").Append(ServiceId).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  PurchaseNumber: ").Append(PurchaseNumber).Append("\n");
            sb.Append("  Trade: ").Append(Trade).Append("\n");
            sb.Append("  ScheduledDate: ").Append(ScheduledDate).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  CallDate: ").Append(CallDate).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  IsPageSizeDefault: ").Append(IsPageSizeDefault).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingWorkordersWorkOrderSearchRequest);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingWorkordersWorkOrderSearchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingWorkordersWorkOrderSearchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingWorkordersWorkOrderSearchRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OtherLocationId == input.OtherLocationId ||
                    this.OtherLocationId != null &&
                    input.OtherLocationId != null &&
                    this.OtherLocationId.SequenceEqual(input.OtherLocationId)
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id != null &&
                    input.Id != null &&
                    this.Id.SequenceEqual(input.Id)
                ) && 
                (
                    this.Category == input.Category ||
                    this.Category != null &&
                    input.Category != null &&
                    this.Category.SequenceEqual(input.Category)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status != null &&
                    input.Status != null &&
                    this.Status.SequenceEqual(input.Status)
                ) && 
                (
                    this.ExtendedStatus == input.ExtendedStatus ||
                    this.ExtendedStatus != null &&
                    input.ExtendedStatus != null &&
                    this.ExtendedStatus.SequenceEqual(input.ExtendedStatus)
                ) && 
                (
                    this.Number == input.Number ||
                    this.Number != null &&
                    input.Number != null &&
                    this.Number.SequenceEqual(input.Number)
                ) && 
                (
                    this.ServiceId == input.ServiceId ||
                    this.ServiceId != null &&
                    input.ServiceId != null &&
                    this.ServiceId.SequenceEqual(input.ServiceId)
                ) && 
                (
                    this.Priority == input.Priority ||
                    this.Priority != null &&
                    input.Priority != null &&
                    this.Priority.SequenceEqual(input.Priority)
                ) && 
                (
                    this.PurchaseNumber == input.PurchaseNumber ||
                    this.PurchaseNumber != null &&
                    input.PurchaseNumber != null &&
                    this.PurchaseNumber.SequenceEqual(input.PurchaseNumber)
                ) && 
                (
                    this.Trade == input.Trade ||
                    this.Trade != null &&
                    input.Trade != null &&
                    this.Trade.SequenceEqual(input.Trade)
                ) && 
                (
                    this.ScheduledDate == input.ScheduledDate ||
                    this.ScheduledDate != null &&
                    input.ScheduledDate != null &&
                    this.ScheduledDate.SequenceEqual(input.ScheduledDate)
                ) && 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    this.ExpirationDate != null &&
                    input.ExpirationDate != null &&
                    this.ExpirationDate.SequenceEqual(input.ExpirationDate)
                ) && 
                (
                    this.CallDate == input.CallDate ||
                    this.CallDate != null &&
                    input.CallDate != null &&
                    this.CallDate.SequenceEqual(input.CallDate)
                ) && 
                (
                    this.Sort == input.Sort ||
                    (this.Sort != null &&
                    this.Sort.Equals(input.Sort))
                ) && 
                (
                    this.Page == input.Page ||
                    this.Page.Equals(input.Page)
                ) && 
                (
                    this.IsPageSizeDefault == input.IsPageSizeDefault ||
                    this.IsPageSizeDefault.Equals(input.IsPageSizeDefault)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
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
                if (this.OtherLocationId != null)
                {
                    hashCode = (hashCode * 59) + this.OtherLocationId.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Category != null)
                {
                    hashCode = (hashCode * 59) + this.Category.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.ExtendedStatus != null)
                {
                    hashCode = (hashCode * 59) + this.ExtendedStatus.GetHashCode();
                }
                if (this.Number != null)
                {
                    hashCode = (hashCode * 59) + this.Number.GetHashCode();
                }
                if (this.ServiceId != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceId.GetHashCode();
                }
                if (this.Priority != null)
                {
                    hashCode = (hashCode * 59) + this.Priority.GetHashCode();
                }
                if (this.PurchaseNumber != null)
                {
                    hashCode = (hashCode * 59) + this.PurchaseNumber.GetHashCode();
                }
                if (this.Trade != null)
                {
                    hashCode = (hashCode * 59) + this.Trade.GetHashCode();
                }
                if (this.ScheduledDate != null)
                {
                    hashCode = (hashCode * 59) + this.ScheduledDate.GetHashCode();
                }
                if (this.ExpirationDate != null)
                {
                    hashCode = (hashCode * 59) + this.ExpirationDate.GetHashCode();
                }
                if (this.CallDate != null)
                {
                    hashCode = (hashCode * 59) + this.CallDate.GetHashCode();
                }
                if (this.Sort != null)
                {
                    hashCode = (hashCode * 59) + this.Sort.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Page.GetHashCode();
                hashCode = (hashCode * 59) + this.IsPageSizeDefault.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
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