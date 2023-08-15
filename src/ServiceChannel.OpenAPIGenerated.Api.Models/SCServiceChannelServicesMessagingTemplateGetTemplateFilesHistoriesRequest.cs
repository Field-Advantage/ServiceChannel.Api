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
    /// holds request
    /// </summary>
    [DataContract]
    public class SCServiceChannelServicesMessagingTemplateGetTemplateFilesHistoriesRequest : IEquatable<SCServiceChannelServicesMessagingTemplateGetTemplateFilesHistoriesRequest>
    {
        /// <summary>
        /// Gets or sets FileTypeId.
        /// </summary>
        /// <value>Gets or sets FileTypeId.</value>
        [DataMember(Name="FileTypeIds", EmitDefaultValue=false)]
        public List<int> FileTypeIds { get; set; }

        /// <summary>
        /// Sort resources by the specified property in the response.
        /// </summary>
        /// <value>Sort resources by the specified property in the response.</value>
        [DataMember(Name="Sort", EmitDefaultValue=false)]
        public string Sort { get; set; }

        /// <summary>
        /// Results page number.
        /// </summary>
        /// <value>Results page number.</value>
        [DataMember(Name="Page", EmitDefaultValue=true)]
        public int Page { get; set; }

        /// <summary>
        /// Gets or Sets IsPageSizeDefault
        /// </summary>
        [DataMember(Name="IsPageSizeDefault", EmitDefaultValue=true)]
        public bool IsPageSizeDefault { get; set; } = false;

        /// <summary>
        /// Number of objects on the results page. The default and maximum per page is 50.
        /// </summary>
        /// <value>Number of objects on the results page. The default and maximum per page is 50.</value>
        [DataMember(Name="PageSize", EmitDefaultValue=true)]
        public int PageSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingTemplateGetTemplateFilesHistoriesRequest {\n");
            sb.Append("  FileTypeIds: ").Append(FileTypeIds).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingTemplateGetTemplateFilesHistoriesRequest)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingTemplateGetTemplateFilesHistoriesRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingTemplateGetTemplateFilesHistoriesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingTemplateGetTemplateFilesHistoriesRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    FileTypeIds == other.FileTypeIds ||
                    FileTypeIds != null &&
                    other.FileTypeIds != null &&
                    FileTypeIds.SequenceEqual(other.FileTypeIds)
                ) && 
                (
                    Sort == other.Sort ||
                    Sort != null &&
                    Sort.Equals(other.Sort)
                ) && 
                (
                    Page == other.Page ||
                    
                    Page.Equals(other.Page)
                ) && 
                (
                    IsPageSizeDefault == other.IsPageSizeDefault ||
                    
                    IsPageSizeDefault.Equals(other.IsPageSizeDefault)
                ) && 
                (
                    PageSize == other.PageSize ||
                    
                    PageSize.Equals(other.PageSize)
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
                    if (FileTypeIds != null)
                    hashCode = hashCode * 59 + FileTypeIds.GetHashCode();
                    if (Sort != null)
                    hashCode = hashCode * 59 + Sort.GetHashCode();
                    
                    hashCode = hashCode * 59 + Page.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsPageSizeDefault.GetHashCode();
                    
                    hashCode = hashCode * 59 + PageSize.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingTemplateGetTemplateFilesHistoriesRequest left, SCServiceChannelServicesMessagingTemplateGetTemplateFilesHistoriesRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingTemplateGetTemplateFilesHistoriesRequest left, SCServiceChannelServicesMessagingTemplateGetTemplateFilesHistoriesRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}