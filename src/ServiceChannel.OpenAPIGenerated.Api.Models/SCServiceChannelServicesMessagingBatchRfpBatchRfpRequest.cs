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
    public class SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest : IEquatable<SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest>
    {
        /// <summary>
        /// Required, BatchCreateRfp to create the batch of Rfp&#39;s
        /// </summary>
        /// <value>Required, BatchCreateRfp to create the batch of Rfp&#39;s</value>
        [Required]
        [DataMember(Name="BatchCreateRfps", EmitDefaultValue=false)]
        public List<SCServiceChannelServicesMessagingBatchRfpBatchCreateRfp> BatchCreateRfps { get; set; }

        /// <summary>
        /// Required, URL where callback method will post the result
        /// </summary>
        /// <value>Required, URL where callback method will post the result</value>
        [Required]
        [DataMember(Name="CallbackUri", EmitDefaultValue=false)]
        public string CallbackUri { get; set; }

        /// <summary>
        /// Optional Batch Name, project module&#39;s Name from which this Rfp was created
        /// </summary>
        /// <value>Optional Batch Name, project module&#39;s Name from which this Rfp was created</value>
        [Required]
        [DataMember(Name="BatchName", EmitDefaultValue=false)]
        public string BatchName { get; set; }

        /// <summary>
        /// Optional Batch Number, project module&#39;s GUID from which this Rfp was created
        /// </summary>
        /// <value>Optional Batch Number, project module&#39;s GUID from which this Rfp was created</value>
        [Required]
        [DataMember(Name="BatchNumber", EmitDefaultValue=false)]
        public string BatchNumber { get; set; }

        /// <summary>
        /// Origin file name
        /// </summary>
        /// <value>Origin file name</value>
        [Required]
        [DataMember(Name="BatchTemplateFileName", EmitDefaultValue=false)]
        public string BatchTemplateFileName { get; set; }

        /// <summary>
        /// Path to blob
        /// </summary>
        /// <value>Path to blob</value>
        [Required]
        [DataMember(Name="BatchTemplateRemotePath", EmitDefaultValue=false)]
        public string BatchTemplateRemotePath { get; set; }

        /// <summary>
        /// Optional, Attachments.
        /// </summary>
        /// <value>Optional, Attachments.</value>
        [DataMember(Name="Attachments", EmitDefaultValue=false)]
        public List<SCServiceChannelApiModelEntitiesBatchRfpAttachment> Attachments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    BatchCreateRfps == other.BatchCreateRfps ||
                    BatchCreateRfps != null &&
                    other.BatchCreateRfps != null &&
                    BatchCreateRfps.SequenceEqual(other.BatchCreateRfps)
                ) && 
                (
                    CallbackUri == other.CallbackUri ||
                    CallbackUri != null &&
                    CallbackUri.Equals(other.CallbackUri)
                ) && 
                (
                    BatchName == other.BatchName ||
                    BatchName != null &&
                    BatchName.Equals(other.BatchName)
                ) && 
                (
                    BatchNumber == other.BatchNumber ||
                    BatchNumber != null &&
                    BatchNumber.Equals(other.BatchNumber)
                ) && 
                (
                    BatchTemplateFileName == other.BatchTemplateFileName ||
                    BatchTemplateFileName != null &&
                    BatchTemplateFileName.Equals(other.BatchTemplateFileName)
                ) && 
                (
                    BatchTemplateRemotePath == other.BatchTemplateRemotePath ||
                    BatchTemplateRemotePath != null &&
                    BatchTemplateRemotePath.Equals(other.BatchTemplateRemotePath)
                ) && 
                (
                    Attachments == other.Attachments ||
                    Attachments != null &&
                    other.Attachments != null &&
                    Attachments.SequenceEqual(other.Attachments)
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
                    if (BatchCreateRfps != null)
                    hashCode = hashCode * 59 + BatchCreateRfps.GetHashCode();
                    if (CallbackUri != null)
                    hashCode = hashCode * 59 + CallbackUri.GetHashCode();
                    if (BatchName != null)
                    hashCode = hashCode * 59 + BatchName.GetHashCode();
                    if (BatchNumber != null)
                    hashCode = hashCode * 59 + BatchNumber.GetHashCode();
                    if (BatchTemplateFileName != null)
                    hashCode = hashCode * 59 + BatchTemplateFileName.GetHashCode();
                    if (BatchTemplateRemotePath != null)
                    hashCode = hashCode * 59 + BatchTemplateRemotePath.GetHashCode();
                    if (Attachments != null)
                    hashCode = hashCode * 59 + Attachments.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest left, SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest left, SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
