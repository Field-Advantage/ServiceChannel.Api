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
    /// SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.BatchRfp.BatchRfpRequest")]
    public partial class SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest : IEquatable<SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest" /> class.
        /// </summary>
        /// <param name="batchCreateRfps">Required, BatchCreateRfp to create the batch of Rfp&#39;s (required).</param>
        /// <param name="callbackUri">Required, URL where callback method will post the result (required).</param>
        /// <param name="batchName">Optional Batch Name, project module&#39;s Name from which this Rfp was created (required).</param>
        /// <param name="batchNumber">Optional Batch Number, project module&#39;s GUID from which this Rfp was created (required).</param>
        /// <param name="batchTemplateFileName">Origin file name (required).</param>
        /// <param name="batchTemplateRemotePath">Path to blob (required).</param>
        /// <param name="attachments">Optional, Attachments..</param>
        public SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest(List<SCServiceChannelServicesMessagingBatchRfpBatchCreateRfp> batchCreateRfps = default(List<SCServiceChannelServicesMessagingBatchRfpBatchCreateRfp>), string callbackUri = default(string), string batchName = default(string), string batchNumber = default(string), string batchTemplateFileName = default(string), string batchTemplateRemotePath = default(string), List<SCServiceChannelApiModelEntitiesBatchRfpAttachment> attachments = default(List<SCServiceChannelApiModelEntitiesBatchRfpAttachment>))
        {
            // to ensure "batchCreateRfps" is required (not null)
            if (batchCreateRfps == null)
            {
                throw new ArgumentNullException("batchCreateRfps is a required property for SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest and cannot be null");
            }
            this.BatchCreateRfps = batchCreateRfps;
            // to ensure "callbackUri" is required (not null)
            if (callbackUri == null)
            {
                throw new ArgumentNullException("callbackUri is a required property for SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest and cannot be null");
            }
            this.CallbackUri = callbackUri;
            // to ensure "batchName" is required (not null)
            if (batchName == null)
            {
                throw new ArgumentNullException("batchName is a required property for SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest and cannot be null");
            }
            this.BatchName = batchName;
            // to ensure "batchNumber" is required (not null)
            if (batchNumber == null)
            {
                throw new ArgumentNullException("batchNumber is a required property for SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest and cannot be null");
            }
            this.BatchNumber = batchNumber;
            // to ensure "batchTemplateFileName" is required (not null)
            if (batchTemplateFileName == null)
            {
                throw new ArgumentNullException("batchTemplateFileName is a required property for SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest and cannot be null");
            }
            this.BatchTemplateFileName = batchTemplateFileName;
            // to ensure "batchTemplateRemotePath" is required (not null)
            if (batchTemplateRemotePath == null)
            {
                throw new ArgumentNullException("batchTemplateRemotePath is a required property for SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest and cannot be null");
            }
            this.BatchTemplateRemotePath = batchTemplateRemotePath;
            this.Attachments = attachments;
        }

        /// <summary>
        /// Required, BatchCreateRfp to create the batch of Rfp&#39;s
        /// </summary>
        /// <value>Required, BatchCreateRfp to create the batch of Rfp&#39;s</value>
        [DataMember(Name = "BatchCreateRfps", IsRequired = true, EmitDefaultValue = true)]
        public List<SCServiceChannelServicesMessagingBatchRfpBatchCreateRfp> BatchCreateRfps { get; set; }

        /// <summary>
        /// Required, URL where callback method will post the result
        /// </summary>
        /// <value>Required, URL where callback method will post the result</value>
        [DataMember(Name = "CallbackUri", IsRequired = true, EmitDefaultValue = true)]
        public string CallbackUri { get; set; }

        /// <summary>
        /// Optional Batch Name, project module&#39;s Name from which this Rfp was created
        /// </summary>
        /// <value>Optional Batch Name, project module&#39;s Name from which this Rfp was created</value>
        [DataMember(Name = "BatchName", IsRequired = true, EmitDefaultValue = true)]
        public string BatchName { get; set; }

        /// <summary>
        /// Optional Batch Number, project module&#39;s GUID from which this Rfp was created
        /// </summary>
        /// <value>Optional Batch Number, project module&#39;s GUID from which this Rfp was created</value>
        [DataMember(Name = "BatchNumber", IsRequired = true, EmitDefaultValue = true)]
        public string BatchNumber { get; set; }

        /// <summary>
        /// Origin file name
        /// </summary>
        /// <value>Origin file name</value>
        [DataMember(Name = "BatchTemplateFileName", IsRequired = true, EmitDefaultValue = true)]
        public string BatchTemplateFileName { get; set; }

        /// <summary>
        /// Path to blob
        /// </summary>
        /// <value>Path to blob</value>
        [DataMember(Name = "BatchTemplateRemotePath", IsRequired = true, EmitDefaultValue = true)]
        public string BatchTemplateRemotePath { get; set; }

        /// <summary>
        /// Optional, Attachments.
        /// </summary>
        /// <value>Optional, Attachments.</value>
        [DataMember(Name = "Attachments", EmitDefaultValue = false)]
        public List<SCServiceChannelApiModelEntitiesBatchRfpAttachment> Attachments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest {\n");
            sb.Append("  BatchCreateRfps: ").Append(BatchCreateRfps).Append("\n");
            sb.Append("  CallbackUri: ").Append(CallbackUri).Append("\n");
            sb.Append("  BatchName: ").Append(BatchName).Append("\n");
            sb.Append("  BatchNumber: ").Append(BatchNumber).Append("\n");
            sb.Append("  BatchTemplateFileName: ").Append(BatchTemplateFileName).Append("\n");
            sb.Append("  BatchTemplateRemotePath: ").Append(BatchTemplateRemotePath).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BatchCreateRfps == input.BatchCreateRfps ||
                    this.BatchCreateRfps != null &&
                    input.BatchCreateRfps != null &&
                    this.BatchCreateRfps.SequenceEqual(input.BatchCreateRfps)
                ) && 
                (
                    this.CallbackUri == input.CallbackUri ||
                    (this.CallbackUri != null &&
                    this.CallbackUri.Equals(input.CallbackUri))
                ) && 
                (
                    this.BatchName == input.BatchName ||
                    (this.BatchName != null &&
                    this.BatchName.Equals(input.BatchName))
                ) && 
                (
                    this.BatchNumber == input.BatchNumber ||
                    (this.BatchNumber != null &&
                    this.BatchNumber.Equals(input.BatchNumber))
                ) && 
                (
                    this.BatchTemplateFileName == input.BatchTemplateFileName ||
                    (this.BatchTemplateFileName != null &&
                    this.BatchTemplateFileName.Equals(input.BatchTemplateFileName))
                ) && 
                (
                    this.BatchTemplateRemotePath == input.BatchTemplateRemotePath ||
                    (this.BatchTemplateRemotePath != null &&
                    this.BatchTemplateRemotePath.Equals(input.BatchTemplateRemotePath))
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
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
                if (this.BatchCreateRfps != null)
                {
                    hashCode = (hashCode * 59) + this.BatchCreateRfps.GetHashCode();
                }
                if (this.CallbackUri != null)
                {
                    hashCode = (hashCode * 59) + this.CallbackUri.GetHashCode();
                }
                if (this.BatchName != null)
                {
                    hashCode = (hashCode * 59) + this.BatchName.GetHashCode();
                }
                if (this.BatchNumber != null)
                {
                    hashCode = (hashCode * 59) + this.BatchNumber.GetHashCode();
                }
                if (this.BatchTemplateFileName != null)
                {
                    hashCode = (hashCode * 59) + this.BatchTemplateFileName.GetHashCode();
                }
                if (this.BatchTemplateRemotePath != null)
                {
                    hashCode = (hashCode * 59) + this.BatchTemplateRemotePath.GetHashCode();
                }
                if (this.Attachments != null)
                {
                    hashCode = (hashCode * 59) + this.Attachments.GetHashCode();
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