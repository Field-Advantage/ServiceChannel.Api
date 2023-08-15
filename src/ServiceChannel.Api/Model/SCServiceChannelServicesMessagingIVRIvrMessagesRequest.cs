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
    /// SCServiceChannelServicesMessagingIVRIvrMessagesRequest
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.IVR.IvrMessagesRequest")]
    public partial class SCServiceChannelServicesMessagingIVRIvrMessagesRequest : IEquatable<SCServiceChannelServicesMessagingIVRIvrMessagesRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingIVRIvrMessagesRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SCServiceChannelServicesMessagingIVRIvrMessagesRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingIVRIvrMessagesRequest" /> class.
        /// </summary>
        /// <param name="messageId">messageId (required).</param>
        /// <param name="language">language (required).</param>
        /// <param name="setupPhoneId">setupPhoneId (required).</param>
        public SCServiceChannelServicesMessagingIVRIvrMessagesRequest(string messageId = default(string), string language = default(string), int setupPhoneId = default(int))
        {
            // to ensure "messageId" is required (not null)
            if (messageId == null)
            {
                throw new ArgumentNullException("messageId is a required property for SCServiceChannelServicesMessagingIVRIvrMessagesRequest and cannot be null");
            }
            this.MessageId = messageId;
            // to ensure "language" is required (not null)
            if (language == null)
            {
                throw new ArgumentNullException("language is a required property for SCServiceChannelServicesMessagingIVRIvrMessagesRequest and cannot be null");
            }
            this.Language = language;
            this.SetupPhoneId = setupPhoneId;
        }

        /// <summary>
        /// Gets or Sets MessageId
        /// </summary>
        [DataMember(Name = "MessageId", IsRequired = true, EmitDefaultValue = true)]
        public string MessageId { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name = "Language", IsRequired = true, EmitDefaultValue = true)]
        public string Language { get; set; }

        /// <summary>
        /// Gets or Sets SetupPhoneId
        /// </summary>
        [DataMember(Name = "SetupPhoneId", IsRequired = true, EmitDefaultValue = true)]
        public int SetupPhoneId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingIVRIvrMessagesRequest {\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  SetupPhoneId: ").Append(SetupPhoneId).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingIVRIvrMessagesRequest);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingIVRIvrMessagesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingIVRIvrMessagesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingIVRIvrMessagesRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.SetupPhoneId == input.SetupPhoneId ||
                    this.SetupPhoneId.Equals(input.SetupPhoneId)
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
                if (this.MessageId != null)
                {
                    hashCode = (hashCode * 59) + this.MessageId.GetHashCode();
                }
                if (this.Language != null)
                {
                    hashCode = (hashCode * 59) + this.Language.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SetupPhoneId.GetHashCode();
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