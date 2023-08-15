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
    /// SCServiceChannelServicesMessagingLocationCreateLandlordResponsibilityApiRequest
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.Location.CreateLandlordResponsibilityApiRequest")]
    public partial class SCServiceChannelServicesMessagingLocationCreateLandlordResponsibilityApiRequest : IEquatable<SCServiceChannelServicesMessagingLocationCreateLandlordResponsibilityApiRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingLocationCreateLandlordResponsibilityApiRequest" /> class.
        /// </summary>
        /// <param name="storeId">storeId.</param>
        /// <param name="tradeName">tradeName.</param>
        /// <param name="categoryName">categoryName.</param>
        /// <param name="overridePriorityName">overridePriorityName.</param>
        /// <param name="overrideCategoryName">overrideCategoryName.</param>
        /// <param name="overrideProviderRank">overrideProviderRank.</param>
        /// <param name="overrideNTE">overrideNTE.</param>
        /// <param name="leaseNote">leaseNote.</param>
        public SCServiceChannelServicesMessagingLocationCreateLandlordResponsibilityApiRequest(string storeId = default(string), string tradeName = default(string), string categoryName = default(string), string overridePriorityName = default(string), string overrideCategoryName = default(string), string overrideProviderRank = default(string), string overrideNTE = default(string), string leaseNote = default(string))
        {
            this.StoreId = storeId;
            this.TradeName = tradeName;
            this.CategoryName = categoryName;
            this.OverridePriorityName = overridePriorityName;
            this.OverrideCategoryName = overrideCategoryName;
            this.OverrideProviderRank = overrideProviderRank;
            this.OverrideNTE = overrideNTE;
            this.LeaseNote = leaseNote;
        }

        /// <summary>
        /// Gets or Sets StoreId
        /// </summary>
        [DataMember(Name = "StoreId", EmitDefaultValue = false)]
        public string StoreId { get; set; }

        /// <summary>
        /// Gets or Sets TradeName
        /// </summary>
        [DataMember(Name = "TradeName", EmitDefaultValue = false)]
        public string TradeName { get; set; }

        /// <summary>
        /// Gets or Sets CategoryName
        /// </summary>
        [DataMember(Name = "CategoryName", EmitDefaultValue = false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// Gets or Sets OverridePriorityName
        /// </summary>
        [DataMember(Name = "OverridePriorityName", EmitDefaultValue = false)]
        public string OverridePriorityName { get; set; }

        /// <summary>
        /// Gets or Sets OverrideCategoryName
        /// </summary>
        [DataMember(Name = "OverrideCategoryName", EmitDefaultValue = false)]
        public string OverrideCategoryName { get; set; }

        /// <summary>
        /// Gets or Sets OverrideProviderRank
        /// </summary>
        [DataMember(Name = "OverrideProviderRank", EmitDefaultValue = false)]
        public string OverrideProviderRank { get; set; }

        /// <summary>
        /// Gets or Sets OverrideNTE
        /// </summary>
        [DataMember(Name = "OverrideNTE", EmitDefaultValue = false)]
        public string OverrideNTE { get; set; }

        /// <summary>
        /// Gets or Sets LeaseNote
        /// </summary>
        [DataMember(Name = "LeaseNote", EmitDefaultValue = false)]
        public string LeaseNote { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingLocationCreateLandlordResponsibilityApiRequest {\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  TradeName: ").Append(TradeName).Append("\n");
            sb.Append("  CategoryName: ").Append(CategoryName).Append("\n");
            sb.Append("  OverridePriorityName: ").Append(OverridePriorityName).Append("\n");
            sb.Append("  OverrideCategoryName: ").Append(OverrideCategoryName).Append("\n");
            sb.Append("  OverrideProviderRank: ").Append(OverrideProviderRank).Append("\n");
            sb.Append("  OverrideNTE: ").Append(OverrideNTE).Append("\n");
            sb.Append("  LeaseNote: ").Append(LeaseNote).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingLocationCreateLandlordResponsibilityApiRequest);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingLocationCreateLandlordResponsibilityApiRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingLocationCreateLandlordResponsibilityApiRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingLocationCreateLandlordResponsibilityApiRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
                ) && 
                (
                    this.TradeName == input.TradeName ||
                    (this.TradeName != null &&
                    this.TradeName.Equals(input.TradeName))
                ) && 
                (
                    this.CategoryName == input.CategoryName ||
                    (this.CategoryName != null &&
                    this.CategoryName.Equals(input.CategoryName))
                ) && 
                (
                    this.OverridePriorityName == input.OverridePriorityName ||
                    (this.OverridePriorityName != null &&
                    this.OverridePriorityName.Equals(input.OverridePriorityName))
                ) && 
                (
                    this.OverrideCategoryName == input.OverrideCategoryName ||
                    (this.OverrideCategoryName != null &&
                    this.OverrideCategoryName.Equals(input.OverrideCategoryName))
                ) && 
                (
                    this.OverrideProviderRank == input.OverrideProviderRank ||
                    (this.OverrideProviderRank != null &&
                    this.OverrideProviderRank.Equals(input.OverrideProviderRank))
                ) && 
                (
                    this.OverrideNTE == input.OverrideNTE ||
                    (this.OverrideNTE != null &&
                    this.OverrideNTE.Equals(input.OverrideNTE))
                ) && 
                (
                    this.LeaseNote == input.LeaseNote ||
                    (this.LeaseNote != null &&
                    this.LeaseNote.Equals(input.LeaseNote))
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
                if (this.StoreId != null)
                {
                    hashCode = (hashCode * 59) + this.StoreId.GetHashCode();
                }
                if (this.TradeName != null)
                {
                    hashCode = (hashCode * 59) + this.TradeName.GetHashCode();
                }
                if (this.CategoryName != null)
                {
                    hashCode = (hashCode * 59) + this.CategoryName.GetHashCode();
                }
                if (this.OverridePriorityName != null)
                {
                    hashCode = (hashCode * 59) + this.OverridePriorityName.GetHashCode();
                }
                if (this.OverrideCategoryName != null)
                {
                    hashCode = (hashCode * 59) + this.OverrideCategoryName.GetHashCode();
                }
                if (this.OverrideProviderRank != null)
                {
                    hashCode = (hashCode * 59) + this.OverrideProviderRank.GetHashCode();
                }
                if (this.OverrideNTE != null)
                {
                    hashCode = (hashCode * 59) + this.OverrideNTE.GetHashCode();
                }
                if (this.LeaseNote != null)
                {
                    hashCode = (hashCode * 59) + this.LeaseNote.GetHashCode();
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
