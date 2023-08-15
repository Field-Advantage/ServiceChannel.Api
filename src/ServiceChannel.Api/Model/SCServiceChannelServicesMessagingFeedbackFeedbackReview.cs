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
    /// SCServiceChannelServicesMessagingFeedbackFeedbackReview
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.Feedback.FeedbackReview")]
    public partial class SCServiceChannelServicesMessagingFeedbackFeedbackReview : IEquatable<SCServiceChannelServicesMessagingFeedbackFeedbackReview>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingFeedbackFeedbackReview" /> class.
        /// </summary>
        /// <param name="id">Entity Id.</param>
        /// <param name="trackingNumber">Work order tracking number. For provider reviews it is null.</param>
        /// <param name="subscriberName">Subscriber display name.</param>
        /// <param name="locationName">Location name (Store Id).</param>
        /// <param name="userFullName">User name who submit a review.</param>
        /// <param name="reviewedDate">Date when user posted or updated a review.</param>
        /// <param name="starScore">Review star score. From 1 to 5.</param>
        /// <param name="comment">User comment.</param>
        public SCServiceChannelServicesMessagingFeedbackFeedbackReview(int id = default(int), int trackingNumber = default(int), string subscriberName = default(string), string locationName = default(string), string userFullName = default(string), DateTime reviewedDate = default(DateTime), int starScore = default(int), string comment = default(string))
        {
            this.Id = id;
            this.TrackingNumber = trackingNumber;
            this.SubscriberName = subscriberName;
            this.LocationName = locationName;
            this.UserFullName = userFullName;
            this.ReviewedDate = reviewedDate;
            this.StarScore = starScore;
            this.Comment = comment;
        }

        /// <summary>
        /// Entity Id
        /// </summary>
        /// <value>Entity Id</value>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Work order tracking number. For provider reviews it is null
        /// </summary>
        /// <value>Work order tracking number. For provider reviews it is null</value>
        [DataMember(Name = "TrackingNumber", EmitDefaultValue = false)]
        public int TrackingNumber { get; set; }

        /// <summary>
        /// Subscriber display name
        /// </summary>
        /// <value>Subscriber display name</value>
        [DataMember(Name = "SubscriberName", EmitDefaultValue = false)]
        public string SubscriberName { get; set; }

        /// <summary>
        /// Location name (Store Id)
        /// </summary>
        /// <value>Location name (Store Id)</value>
        [DataMember(Name = "LocationName", EmitDefaultValue = false)]
        public string LocationName { get; set; }

        /// <summary>
        /// User name who submit a review
        /// </summary>
        /// <value>User name who submit a review</value>
        [DataMember(Name = "UserFullName", EmitDefaultValue = false)]
        public string UserFullName { get; set; }

        /// <summary>
        /// Date when user posted or updated a review
        /// </summary>
        /// <value>Date when user posted or updated a review</value>
        [DataMember(Name = "ReviewedDate", EmitDefaultValue = false)]
        public DateTime ReviewedDate { get; set; }

        /// <summary>
        /// Review star score. From 1 to 5
        /// </summary>
        /// <value>Review star score. From 1 to 5</value>
        [DataMember(Name = "StarScore", EmitDefaultValue = false)]
        public int StarScore { get; set; }

        /// <summary>
        /// User comment
        /// </summary>
        /// <value>User comment</value>
        [DataMember(Name = "Comment", EmitDefaultValue = false)]
        public string Comment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingFeedbackFeedbackReview {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TrackingNumber: ").Append(TrackingNumber).Append("\n");
            sb.Append("  SubscriberName: ").Append(SubscriberName).Append("\n");
            sb.Append("  LocationName: ").Append(LocationName).Append("\n");
            sb.Append("  UserFullName: ").Append(UserFullName).Append("\n");
            sb.Append("  ReviewedDate: ").Append(ReviewedDate).Append("\n");
            sb.Append("  StarScore: ").Append(StarScore).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingFeedbackFeedbackReview);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingFeedbackFeedbackReview instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingFeedbackFeedbackReview to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingFeedbackFeedbackReview input)
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
                    this.TrackingNumber == input.TrackingNumber ||
                    this.TrackingNumber.Equals(input.TrackingNumber)
                ) && 
                (
                    this.SubscriberName == input.SubscriberName ||
                    (this.SubscriberName != null &&
                    this.SubscriberName.Equals(input.SubscriberName))
                ) && 
                (
                    this.LocationName == input.LocationName ||
                    (this.LocationName != null &&
                    this.LocationName.Equals(input.LocationName))
                ) && 
                (
                    this.UserFullName == input.UserFullName ||
                    (this.UserFullName != null &&
                    this.UserFullName.Equals(input.UserFullName))
                ) && 
                (
                    this.ReviewedDate == input.ReviewedDate ||
                    (this.ReviewedDate != null &&
                    this.ReviewedDate.Equals(input.ReviewedDate))
                ) && 
                (
                    this.StarScore == input.StarScore ||
                    this.StarScore.Equals(input.StarScore)
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
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
                hashCode = (hashCode * 59) + this.TrackingNumber.GetHashCode();
                if (this.SubscriberName != null)
                {
                    hashCode = (hashCode * 59) + this.SubscriberName.GetHashCode();
                }
                if (this.LocationName != null)
                {
                    hashCode = (hashCode * 59) + this.LocationName.GetHashCode();
                }
                if (this.UserFullName != null)
                {
                    hashCode = (hashCode * 59) + this.UserFullName.GetHashCode();
                }
                if (this.ReviewedDate != null)
                {
                    hashCode = (hashCode * 59) + this.ReviewedDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.StarScore.GetHashCode();
                if (this.Comment != null)
                {
                    hashCode = (hashCode * 59) + this.Comment.GetHashCode();
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
