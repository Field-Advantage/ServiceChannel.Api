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
    /// Object for details of a resolution code to add to a work order.
    /// </summary>
    [DataContract]
    public class SCServiceChannelServicesMessagingResolutionCodesCreateWorkOrderResolutionCodeRequest : IEquatable<SCServiceChannelServicesMessagingResolutionCodesCreateWorkOrderResolutionCodeRequest>
    {
        /// <summary>
        /// ID of the resolution code to associate with the work order.
        /// </summary>
        /// <value>ID of the resolution code to associate with the work order.</value>
        [DataMember(Name="Key", EmitDefaultValue=true)]
        public int Key { get; set; }

        /// <summary>
        /// Comment explaining your understanding of the resolution code of the work order.               Enabled for resolution codes with the &#x60;HasFreeText&#x60; attribute. The maximum length is 100 characters.
        /// </summary>
        /// <value>Comment explaining your understanding of the resolution code of the work order.               Enabled for resolution codes with the &#x60;HasFreeText&#x60; attribute. The maximum length is 100 characters.</value>
        [DataMember(Name="Text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Asset category ID to be passed by users with access to asset categories.
        /// </summary>
        /// <value>Asset category ID to be passed by users with access to asset categories.</value>
        [DataMember(Name="AssetCategoryId", EmitDefaultValue=true)]
        public int AssetCategoryId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingResolutionCodesCreateWorkOrderResolutionCodeRequest {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  AssetCategoryId: ").Append(AssetCategoryId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingResolutionCodesCreateWorkOrderResolutionCodeRequest)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingResolutionCodesCreateWorkOrderResolutionCodeRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingResolutionCodesCreateWorkOrderResolutionCodeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingResolutionCodesCreateWorkOrderResolutionCodeRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Key == other.Key ||
                    
                    Key.Equals(other.Key)
                ) && 
                (
                    Text == other.Text ||
                    Text != null &&
                    Text.Equals(other.Text)
                ) && 
                (
                    AssetCategoryId == other.AssetCategoryId ||
                    
                    AssetCategoryId.Equals(other.AssetCategoryId)
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
                    
                    hashCode = hashCode * 59 + Key.GetHashCode();
                    if (Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();
                    
                    hashCode = hashCode * 59 + AssetCategoryId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingResolutionCodesCreateWorkOrderResolutionCodeRequest left, SCServiceChannelServicesMessagingResolutionCodesCreateWorkOrderResolutionCodeRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingResolutionCodesCreateWorkOrderResolutionCodeRequest left, SCServiceChannelServicesMessagingResolutionCodesCreateWorkOrderResolutionCodeRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
