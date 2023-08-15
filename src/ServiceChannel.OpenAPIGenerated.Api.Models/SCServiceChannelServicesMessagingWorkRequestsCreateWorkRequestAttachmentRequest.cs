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
    /// Request to add attachments to a work request
    /// </summary>
    [DataContract]
    public class SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestAttachmentRequest : IEquatable<SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestAttachmentRequest>
    {
        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// File name of a uploaded attachment. For example, #workorders/0DD13443-EAF4-4A1D-930B-992EFC8ED3E0
        /// </summary>
        /// <value>File name of a uploaded attachment. For example, #workorders/0DD13443-EAF4-4A1D-930B-992EFC8ED3E0</value>
        [DataMember(Name="FileName", EmitDefaultValue=false)]
        public string FileName { get; set; }

        /// <summary>
        /// Original file name. For example, my-file.pdf
        /// </summary>
        /// <value>Original file name. For example, my-file.pdf</value>
        [DataMember(Name="OriginalName", EmitDefaultValue=false)]
        public string OriginalName { get; set; }

        /// <summary>
        /// Visibility
        /// </summary>
        /// <value>Visibility</value>
        [DataMember(Name="Visibility", EmitDefaultValue=true)]
        public int Visibility { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestAttachmentRequest {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  OriginalName: ").Append(OriginalName).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestAttachmentRequest)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestAttachmentRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestAttachmentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestAttachmentRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    FileName == other.FileName ||
                    FileName != null &&
                    FileName.Equals(other.FileName)
                ) && 
                (
                    OriginalName == other.OriginalName ||
                    OriginalName != null &&
                    OriginalName.Equals(other.OriginalName)
                ) && 
                (
                    Visibility == other.Visibility ||
                    
                    Visibility.Equals(other.Visibility)
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
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (FileName != null)
                    hashCode = hashCode * 59 + FileName.GetHashCode();
                    if (OriginalName != null)
                    hashCode = hashCode * 59 + OriginalName.GetHashCode();
                    
                    hashCode = hashCode * 59 + Visibility.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestAttachmentRequest left, SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestAttachmentRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestAttachmentRequest left, SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestAttachmentRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
