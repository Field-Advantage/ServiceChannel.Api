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
    /// SCServiceChannelNotificationsObjectsAssetWarranty
    /// </summary>
    [DataContract(Name = "ServiceChannel.Notifications.Objects.AssetWarranty")]
    public partial class SCServiceChannelNotificationsObjectsAssetWarranty : IEquatable<SCServiceChannelNotificationsObjectsAssetWarranty>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelNotificationsObjectsAssetWarranty" /> class.
        /// </summary>
        /// <param name="expirationDate">expirationDate.</param>
        /// <param name="providerId">providerId.</param>
        /// <param name="nTE">nTE.</param>
        /// <param name="priority">priority.</param>
        /// <param name="category">category.</param>
        /// <param name="provider">provider.</param>
        /// <param name="expiration">expiration.</param>
        public SCServiceChannelNotificationsObjectsAssetWarranty(DateTime expirationDate = default(DateTime), int providerId = default(int), double nTE = default(double), string priority = default(string), string category = default(string), SCServiceChannelNotificationsObjectsAssetWarrantyProvider provider = default(SCServiceChannelNotificationsObjectsAssetWarrantyProvider), SCServiceChannelNotificationsObjectsAssetWarrantyExpiration expiration = default(SCServiceChannelNotificationsObjectsAssetWarrantyExpiration))
        {
            this.ExpirationDate = expirationDate;
            this.ProviderId = providerId;
            this.NTE = nTE;
            this.Priority = priority;
            this.Category = category;
            this.Provider = provider;
            this.Expiration = expiration;
        }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name = "ExpirationDate", EmitDefaultValue = false)]
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets ProviderId
        /// </summary>
        [DataMember(Name = "ProviderId", EmitDefaultValue = false)]
        public int ProviderId { get; set; }

        /// <summary>
        /// Gets or Sets NTE
        /// </summary>
        [DataMember(Name = "NTE", EmitDefaultValue = false)]
        public double NTE { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "Priority", EmitDefaultValue = false)]
        public string Priority { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "Category", EmitDefaultValue = false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets Provider
        /// </summary>
        [DataMember(Name = "Provider", EmitDefaultValue = false)]
        public SCServiceChannelNotificationsObjectsAssetWarrantyProvider Provider { get; set; }

        /// <summary>
        /// Gets or Sets Expiration
        /// </summary>
        [DataMember(Name = "Expiration", EmitDefaultValue = false)]
        public SCServiceChannelNotificationsObjectsAssetWarrantyExpiration Expiration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelNotificationsObjectsAssetWarranty {\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  NTE: ").Append(NTE).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
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
            return this.Equals(input as SCServiceChannelNotificationsObjectsAssetWarranty);
        }

        /// <summary>
        /// Returns true if SCServiceChannelNotificationsObjectsAssetWarranty instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelNotificationsObjectsAssetWarranty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelNotificationsObjectsAssetWarranty input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
                ) && 
                (
                    this.ProviderId == input.ProviderId ||
                    this.ProviderId.Equals(input.ProviderId)
                ) && 
                (
                    this.NTE == input.NTE ||
                    this.NTE.Equals(input.NTE)
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                    this.Provider.Equals(input.Provider))
                ) && 
                (
                    this.Expiration == input.Expiration ||
                    (this.Expiration != null &&
                    this.Expiration.Equals(input.Expiration))
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
                if (this.ExpirationDate != null)
                {
                    hashCode = (hashCode * 59) + this.ExpirationDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ProviderId.GetHashCode();
                hashCode = (hashCode * 59) + this.NTE.GetHashCode();
                if (this.Priority != null)
                {
                    hashCode = (hashCode * 59) + this.Priority.GetHashCode();
                }
                if (this.Category != null)
                {
                    hashCode = (hashCode * 59) + this.Category.GetHashCode();
                }
                if (this.Provider != null)
                {
                    hashCode = (hashCode * 59) + this.Provider.GetHashCode();
                }
                if (this.Expiration != null)
                {
                    hashCode = (hashCode * 59) + this.Expiration.GetHashCode();
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
