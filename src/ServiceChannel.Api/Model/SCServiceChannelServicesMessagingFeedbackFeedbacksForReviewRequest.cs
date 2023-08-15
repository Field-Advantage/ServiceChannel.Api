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
    /// SCServiceChannelServicesMessagingFeedbackFeedbacksForReviewRequest
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.Feedback.FeedbacksForReviewRequest")]
    public partial class SCServiceChannelServicesMessagingFeedbackFeedbacksForReviewRequest : IEquatable<SCServiceChannelServicesMessagingFeedbackFeedbacksForReviewRequest>, IValidatableObject
    {
        /// <summary>
        /// Order by field
        /// </summary>
        /// <value>Order by field</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrderByFieldEnum
        {
            /// <summary>
            /// Enum TrackingNumber for value: TrackingNumber
            /// </summary>
            [EnumMember(Value = "TrackingNumber")]
            TrackingNumber = 1,

            /// <summary>
            /// Enum Trade for value: Trade
            /// </summary>
            [EnumMember(Value = "Trade")]
            Trade = 2,

            /// <summary>
            /// Enum ScheduledDate for value: ScheduledDate
            /// </summary>
            [EnumMember(Value = "ScheduledDate")]
            ScheduledDate = 3,

            /// <summary>
            /// Enum Vendor for value: Vendor
            /// </summary>
            [EnumMember(Value = "Vendor")]
            Vendor = 4,

            /// <summary>
            /// Enum Priority for value: Priority
            /// </summary>
            [EnumMember(Value = "Priority")]
            Priority = 5,

            /// <summary>
            /// Enum Caller for value: Caller
            /// </summary>
            [EnumMember(Value = "Caller")]
            Caller = 6,

            /// <summary>
            /// Enum Status for value: Status
            /// </summary>
            [EnumMember(Value = "Status")]
            Status = 7,

            /// <summary>
            /// Enum Area for value: Area
            /// </summary>
            [EnumMember(Value = "Area")]
            Area = 8,

            /// <summary>
            /// Enum ComplitionDate for value: ComplitionDate
            /// </summary>
            [EnumMember(Value = "ComplitionDate")]
            ComplitionDate = 9,

            /// <summary>
            /// Enum FeedbackLeft for value: FeedbackLeft
            /// </summary>
            [EnumMember(Value = "FeedbackLeft")]
            FeedbackLeft = 10

        }


        /// <summary>
        /// Order by field
        /// </summary>
        /// <value>Order by field</value>
        [DataMember(Name = "OrderByField", EmitDefaultValue = false)]
        public OrderByFieldEnum? OrderByField { get; set; }
        /// <summary>
        /// Order direction
        /// </summary>
        /// <value>Order direction</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrderDirectionEnum
        {
            /// <summary>
            /// Enum Ascending for value: Ascending
            /// </summary>
            [EnumMember(Value = "Ascending")]
            Ascending = 1,

            /// <summary>
            /// Enum Descending for value: Descending
            /// </summary>
            [EnumMember(Value = "Descending")]
            Descending = 2

        }


        /// <summary>
        /// Order direction
        /// </summary>
        /// <value>Order direction</value>
        [DataMember(Name = "OrderDirection", EmitDefaultValue = false)]
        public OrderDirectionEnum? OrderDirection { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingFeedbackFeedbacksForReviewRequest" /> class.
        /// </summary>
        /// <param name="locationId">LocationId.</param>
        /// <param name="setupId">Dashboard setupId (optional).</param>
        /// <param name="orderByField">Order by field.</param>
        /// <param name="orderDirection">Order direction.</param>
        /// <param name="showMyWorkOrders">Activates filter by current user id (default to false).</param>
        /// <param name="subscriberId">Subscriber Id.</param>
        public SCServiceChannelServicesMessagingFeedbackFeedbacksForReviewRequest(int locationId = default(int), int setupId = default(int), OrderByFieldEnum? orderByField = default(OrderByFieldEnum?), OrderDirectionEnum? orderDirection = default(OrderDirectionEnum?), bool showMyWorkOrders = false, int subscriberId = default(int))
        {
            this.LocationId = locationId;
            this.SetupId = setupId;
            this.OrderByField = orderByField;
            this.OrderDirection = orderDirection;
            this.ShowMyWorkOrders = showMyWorkOrders;
            this.SubscriberId = subscriberId;
        }

        /// <summary>
        /// LocationId
        /// </summary>
        /// <value>LocationId</value>
        [DataMember(Name = "LocationId", EmitDefaultValue = false)]
        public int LocationId { get; set; }

        /// <summary>
        /// Dashboard setupId (optional)
        /// </summary>
        /// <value>Dashboard setupId (optional)</value>
        [DataMember(Name = "SetupId", EmitDefaultValue = false)]
        public int SetupId { get; set; }

        /// <summary>
        /// Activates filter by current user id
        /// </summary>
        /// <value>Activates filter by current user id</value>
        [DataMember(Name = "ShowMyWorkOrders", EmitDefaultValue = true)]
        public bool ShowMyWorkOrders { get; set; }

        /// <summary>
        /// Subscriber Id
        /// </summary>
        /// <value>Subscriber Id</value>
        [DataMember(Name = "SubscriberId", EmitDefaultValue = false)]
        public int SubscriberId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingFeedbackFeedbacksForReviewRequest {\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  SetupId: ").Append(SetupId).Append("\n");
            sb.Append("  OrderByField: ").Append(OrderByField).Append("\n");
            sb.Append("  OrderDirection: ").Append(OrderDirection).Append("\n");
            sb.Append("  ShowMyWorkOrders: ").Append(ShowMyWorkOrders).Append("\n");
            sb.Append("  SubscriberId: ").Append(SubscriberId).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingFeedbackFeedbacksForReviewRequest);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingFeedbackFeedbacksForReviewRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingFeedbackFeedbacksForReviewRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingFeedbackFeedbacksForReviewRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LocationId == input.LocationId ||
                    this.LocationId.Equals(input.LocationId)
                ) && 
                (
                    this.SetupId == input.SetupId ||
                    this.SetupId.Equals(input.SetupId)
                ) && 
                (
                    this.OrderByField == input.OrderByField ||
                    this.OrderByField.Equals(input.OrderByField)
                ) && 
                (
                    this.OrderDirection == input.OrderDirection ||
                    this.OrderDirection.Equals(input.OrderDirection)
                ) && 
                (
                    this.ShowMyWorkOrders == input.ShowMyWorkOrders ||
                    this.ShowMyWorkOrders.Equals(input.ShowMyWorkOrders)
                ) && 
                (
                    this.SubscriberId == input.SubscriberId ||
                    this.SubscriberId.Equals(input.SubscriberId)
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
                hashCode = (hashCode * 59) + this.LocationId.GetHashCode();
                hashCode = (hashCode * 59) + this.SetupId.GetHashCode();
                hashCode = (hashCode * 59) + this.OrderByField.GetHashCode();
                hashCode = (hashCode * 59) + this.OrderDirection.GetHashCode();
                hashCode = (hashCode * 59) + this.ShowMyWorkOrders.GetHashCode();
                hashCode = (hashCode * 59) + this.SubscriberId.GetHashCode();
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
