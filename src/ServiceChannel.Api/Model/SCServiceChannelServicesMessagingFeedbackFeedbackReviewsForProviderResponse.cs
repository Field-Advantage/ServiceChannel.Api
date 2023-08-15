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
    /// SCServiceChannelServicesMessagingFeedbackFeedbackReviewsForProviderResponse
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.Feedback.FeedbackReviewsForProviderResponse")]
    public partial class SCServiceChannelServicesMessagingFeedbackFeedbackReviewsForProviderResponse : IEquatable<SCServiceChannelServicesMessagingFeedbackFeedbackReviewsForProviderResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingFeedbackFeedbackReviewsForProviderResponse" /> class.
        /// </summary>
        /// <param name="reviews">User reviews for work orders or providers.</param>
        /// <param name="totalCount">totalCount.</param>
        /// <param name="totalFilteredCount">totalFilteredCount.</param>
        /// <param name="pageSize">pageSize.</param>
        /// <param name="pageOffset">pageOffset.</param>
        public SCServiceChannelServicesMessagingFeedbackFeedbackReviewsForProviderResponse(List<SCServiceChannelServicesMessagingFeedbackFeedbackReview> reviews = default(List<SCServiceChannelServicesMessagingFeedbackFeedbackReview>), int totalCount = default(int), int totalFilteredCount = default(int), int pageSize = default(int), int pageOffset = default(int))
        {
            this.Reviews = reviews;
            this.TotalCount = totalCount;
            this.TotalFilteredCount = totalFilteredCount;
            this.PageSize = pageSize;
            this.PageOffset = pageOffset;
        }

        /// <summary>
        /// User reviews for work orders or providers
        /// </summary>
        /// <value>User reviews for work orders or providers</value>
        [DataMember(Name = "Reviews", EmitDefaultValue = false)]
        public List<SCServiceChannelServicesMessagingFeedbackFeedbackReview> Reviews { get; set; }

        /// <summary>
        /// Gets or Sets TotalCount
        /// </summary>
        [DataMember(Name = "TotalCount", EmitDefaultValue = false)]
        public int TotalCount { get; set; }

        /// <summary>
        /// Gets or Sets TotalFilteredCount
        /// </summary>
        [DataMember(Name = "TotalFilteredCount", EmitDefaultValue = false)]
        public int TotalFilteredCount { get; set; }

        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name = "PageSize", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or Sets PageOffset
        /// </summary>
        [DataMember(Name = "PageOffset", EmitDefaultValue = false)]
        public int PageOffset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingFeedbackFeedbackReviewsForProviderResponse {\n");
            sb.Append("  Reviews: ").Append(Reviews).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  TotalFilteredCount: ").Append(TotalFilteredCount).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageOffset: ").Append(PageOffset).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingFeedbackFeedbackReviewsForProviderResponse);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingFeedbackFeedbackReviewsForProviderResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingFeedbackFeedbackReviewsForProviderResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingFeedbackFeedbackReviewsForProviderResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Reviews == input.Reviews ||
                    this.Reviews != null &&
                    input.Reviews != null &&
                    this.Reviews.SequenceEqual(input.Reviews)
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    this.TotalCount.Equals(input.TotalCount)
                ) && 
                (
                    this.TotalFilteredCount == input.TotalFilteredCount ||
                    this.TotalFilteredCount.Equals(input.TotalFilteredCount)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.PageOffset == input.PageOffset ||
                    this.PageOffset.Equals(input.PageOffset)
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
                if (this.Reviews != null)
                {
                    hashCode = (hashCode * 59) + this.Reviews.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalCount.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalFilteredCount.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                hashCode = (hashCode * 59) + this.PageOffset.GetHashCode();
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