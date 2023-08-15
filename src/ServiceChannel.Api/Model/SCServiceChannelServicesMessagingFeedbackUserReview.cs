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
    /// A container to hold user review information.
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.Feedback.UserReview")]
    public partial class SCServiceChannelServicesMessagingFeedbackUserReview : IEquatable<SCServiceChannelServicesMessagingFeedbackUserReview>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingFeedbackUserReview" /> class.
        /// </summary>
        /// <param name="id">Review id.</param>
        /// <param name="starScore">User&#39;s star score.</param>
        /// <param name="reviewedDate">Date of last changes of user review in database.</param>
        /// <param name="comment">Review comment.</param>
        public SCServiceChannelServicesMessagingFeedbackUserReview(int id = default(int), int starScore = default(int), DateTime reviewedDate = default(DateTime), string comment = default(string))
        {
            this.Id = id;
            this.StarScore = starScore;
            this.ReviewedDate = reviewedDate;
            this.Comment = comment;
        }

        /// <summary>
        /// Review id
        /// </summary>
        /// <value>Review id</value>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// User&#39;s star score
        /// </summary>
        /// <value>User&#39;s star score</value>
        [DataMember(Name = "StarScore", EmitDefaultValue = false)]
        public int StarScore { get; set; }

        /// <summary>
        /// Date of last changes of user review in database
        /// </summary>
        /// <value>Date of last changes of user review in database</value>
        [DataMember(Name = "ReviewedDate", EmitDefaultValue = false)]
        public DateTime ReviewedDate { get; set; }

        /// <summary>
        /// Review comment
        /// </summary>
        /// <value>Review comment</value>
        [DataMember(Name = "Comment", EmitDefaultValue = false)]
        public string Comment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingFeedbackUserReview {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StarScore: ").Append(StarScore).Append("\n");
            sb.Append("  ReviewedDate: ").Append(ReviewedDate).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingFeedbackUserReview);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingFeedbackUserReview instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingFeedbackUserReview to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingFeedbackUserReview input)
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
                    this.StarScore == input.StarScore ||
                    this.StarScore.Equals(input.StarScore)
                ) && 
                (
                    this.ReviewedDate == input.ReviewedDate ||
                    (this.ReviewedDate != null &&
                    this.ReviewedDate.Equals(input.ReviewedDate))
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
                hashCode = (hashCode * 59) + this.StarScore.GetHashCode();
                if (this.ReviewedDate != null)
                {
                    hashCode = (hashCode * 59) + this.ReviewedDate.GetHashCode();
                }
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