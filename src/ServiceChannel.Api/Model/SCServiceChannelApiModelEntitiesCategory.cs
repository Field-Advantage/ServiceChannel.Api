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
    /// SCServiceChannelApiModelEntitiesCategory
    /// </summary>
    [DataContract(Name = "ServiceChannel.Api.Model.Entities.Category")]
    public partial class SCServiceChannelApiModelEntitiesCategory : IEquatable<SCServiceChannelApiModelEntitiesCategory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelApiModelEntitiesCategory" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="hasDependency">hasDependency (default to false).</param>
        /// <param name="primaryCategory">primaryCategory.</param>
        /// <param name="id">id.</param>
        /// <param name="subscriberId">subscriberId.</param>
        /// <param name="userId">userId.</param>
        public SCServiceChannelApiModelEntitiesCategory(string name = default(string), bool hasDependency = false, SCServiceChannelApiModelEntitiesPrimaryCategory primaryCategory = default(SCServiceChannelApiModelEntitiesPrimaryCategory), int id = default(int), int subscriberId = default(int), int userId = default(int))
        {
            this.Name = name;
            this.HasDependency = hasDependency;
            this.PrimaryCategory = primaryCategory;
            this.Id = id;
            this.SubscriberId = subscriberId;
            this.UserId = userId;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets HasDependency
        /// </summary>
        [DataMember(Name = "HasDependency", EmitDefaultValue = true)]
        public bool HasDependency { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryCategory
        /// </summary>
        [DataMember(Name = "PrimaryCategory", EmitDefaultValue = false)]
        public SCServiceChannelApiModelEntitiesPrimaryCategory PrimaryCategory { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets SubscriberId
        /// </summary>
        [DataMember(Name = "SubscriberId", EmitDefaultValue = false)]
        public int SubscriberId { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "UserId", EmitDefaultValue = false)]
        public int UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelApiModelEntitiesCategory {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  HasDependency: ").Append(HasDependency).Append("\n");
            sb.Append("  PrimaryCategory: ").Append(PrimaryCategory).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SubscriberId: ").Append(SubscriberId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as SCServiceChannelApiModelEntitiesCategory);
        }

        /// <summary>
        /// Returns true if SCServiceChannelApiModelEntitiesCategory instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelApiModelEntitiesCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelApiModelEntitiesCategory input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.HasDependency == input.HasDependency ||
                    this.HasDependency.Equals(input.HasDependency)
                ) && 
                (
                    this.PrimaryCategory == input.PrimaryCategory ||
                    (this.PrimaryCategory != null &&
                    this.PrimaryCategory.Equals(input.PrimaryCategory))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.SubscriberId == input.SubscriberId ||
                    this.SubscriberId.Equals(input.SubscriberId)
                ) && 
                (
                    this.UserId == input.UserId ||
                    this.UserId.Equals(input.UserId)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HasDependency.GetHashCode();
                if (this.PrimaryCategory != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryCategory.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                hashCode = (hashCode * 59) + this.SubscriberId.GetHashCode();
                hashCode = (hashCode * 59) + this.UserId.GetHashCode();
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
