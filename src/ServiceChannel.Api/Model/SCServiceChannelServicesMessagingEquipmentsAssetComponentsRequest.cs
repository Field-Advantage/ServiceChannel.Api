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
    /// SCServiceChannelServicesMessagingEquipmentsAssetComponentsRequest
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.Equipments.AssetComponentsRequest")]
    public partial class SCServiceChannelServicesMessagingEquipmentsAssetComponentsRequest : IEquatable<SCServiceChannelServicesMessagingEquipmentsAssetComponentsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingEquipmentsAssetComponentsRequest" /> class.
        /// </summary>
        /// <param name="parentIds">parentIds.</param>
        /// <param name="onlyRefrigerantTrackingAssets">onlyRefrigerantTrackingAssets (default to false).</param>
        public SCServiceChannelServicesMessagingEquipmentsAssetComponentsRequest(List<int> parentIds = default(List<int>), bool onlyRefrigerantTrackingAssets = false)
        {
            this.ParentIds = parentIds;
            this.OnlyRefrigerantTrackingAssets = onlyRefrigerantTrackingAssets;
        }

        /// <summary>
        /// Gets or Sets ParentIds
        /// </summary>
        [DataMember(Name = "ParentIds", EmitDefaultValue = false)]
        public List<int> ParentIds { get; set; }

        /// <summary>
        /// Gets or Sets OnlyRefrigerantTrackingAssets
        /// </summary>
        [DataMember(Name = "OnlyRefrigerantTrackingAssets", EmitDefaultValue = true)]
        public bool OnlyRefrigerantTrackingAssets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingEquipmentsAssetComponentsRequest {\n");
            sb.Append("  ParentIds: ").Append(ParentIds).Append("\n");
            sb.Append("  OnlyRefrigerantTrackingAssets: ").Append(OnlyRefrigerantTrackingAssets).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingEquipmentsAssetComponentsRequest);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingEquipmentsAssetComponentsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingEquipmentsAssetComponentsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingEquipmentsAssetComponentsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ParentIds == input.ParentIds ||
                    this.ParentIds != null &&
                    input.ParentIds != null &&
                    this.ParentIds.SequenceEqual(input.ParentIds)
                ) && 
                (
                    this.OnlyRefrigerantTrackingAssets == input.OnlyRefrigerantTrackingAssets ||
                    this.OnlyRefrigerantTrackingAssets.Equals(input.OnlyRefrigerantTrackingAssets)
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
                if (this.ParentIds != null)
                {
                    hashCode = (hashCode * 59) + this.ParentIds.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OnlyRefrigerantTrackingAssets.GetHashCode();
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