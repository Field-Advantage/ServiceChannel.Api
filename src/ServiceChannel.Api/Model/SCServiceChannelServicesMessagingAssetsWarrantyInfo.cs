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
    /// SCServiceChannelServicesMessagingAssetsWarrantyInfo
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.Assets.WarrantyInfo")]
    public partial class SCServiceChannelServicesMessagingAssetsWarrantyInfo : IEquatable<SCServiceChannelServicesMessagingAssetsWarrantyInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingAssetsWarrantyInfo" /> class.
        /// </summary>
        /// <param name="nTE">Maximum amount of money to be spent on warranty services in USD. Value -1  means that the amount is not applicable..</param>
        /// <param name="priority">Defines how quickly warranty services should be provided, for example, *Emergency-4 Hours*, *Normal-48 Hours*, *7 Days*..</param>
        /// <param name="category">Warranty category, for example, *ADVISE ONLY*, *REPAIR*, *DISASTER*..</param>
        /// <param name="provider">provider.</param>
        /// <param name="expiration">expiration.</param>
        public SCServiceChannelServicesMessagingAssetsWarrantyInfo(double nTE = default(double), string priority = default(string), string category = default(string), SCServiceChannelServicesMessagingAssetsWarrantyProvider provider = default(SCServiceChannelServicesMessagingAssetsWarrantyProvider), SCServiceChannelServicesMessagingAssetsWarrantyExpiration expiration = default(SCServiceChannelServicesMessagingAssetsWarrantyExpiration))
        {
            this.NTE = nTE;
            this.Priority = priority;
            this.Category = category;
            this.Provider = provider;
            this.Expiration = expiration;
        }

        /// <summary>
        /// Maximum amount of money to be spent on warranty services in USD. Value -1  means that the amount is not applicable.
        /// </summary>
        /// <value>Maximum amount of money to be spent on warranty services in USD. Value -1  means that the amount is not applicable.</value>
        [DataMember(Name = "NTE", EmitDefaultValue = false)]
        public double NTE { get; set; }

        /// <summary>
        /// Defines how quickly warranty services should be provided, for example, *Emergency-4 Hours*, *Normal-48 Hours*, *7 Days*.
        /// </summary>
        /// <value>Defines how quickly warranty services should be provided, for example, *Emergency-4 Hours*, *Normal-48 Hours*, *7 Days*.</value>
        [DataMember(Name = "Priority", EmitDefaultValue = false)]
        public string Priority { get; set; }

        /// <summary>
        /// Warranty category, for example, *ADVISE ONLY*, *REPAIR*, *DISASTER*.
        /// </summary>
        /// <value>Warranty category, for example, *ADVISE ONLY*, *REPAIR*, *DISASTER*.</value>
        [DataMember(Name = "Category", EmitDefaultValue = false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets Provider
        /// </summary>
        [DataMember(Name = "Provider", EmitDefaultValue = false)]
        public SCServiceChannelServicesMessagingAssetsWarrantyProvider Provider { get; set; }

        /// <summary>
        /// Gets or Sets Expiration
        /// </summary>
        [DataMember(Name = "Expiration", EmitDefaultValue = false)]
        public SCServiceChannelServicesMessagingAssetsWarrantyExpiration Expiration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingAssetsWarrantyInfo {\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingAssetsWarrantyInfo);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingAssetsWarrantyInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingAssetsWarrantyInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingAssetsWarrantyInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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