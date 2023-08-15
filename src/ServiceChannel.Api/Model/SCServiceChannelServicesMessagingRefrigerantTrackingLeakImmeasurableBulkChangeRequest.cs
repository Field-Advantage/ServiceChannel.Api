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
    /// SCServiceChannelServicesMessagingRefrigerantTrackingLeakImmeasurableBulkChangeRequest
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.RefrigerantTracking.LeakImmeasurableBulkChangeRequest")]
    public partial class SCServiceChannelServicesMessagingRefrigerantTrackingLeakImmeasurableBulkChangeRequest : IEquatable<SCServiceChannelServicesMessagingRefrigerantTrackingLeakImmeasurableBulkChangeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingRefrigerantTrackingLeakImmeasurableBulkChangeRequest" /> class.
        /// </summary>
        /// <param name="addItems">addItems.</param>
        /// <param name="updateItems">updateItems.</param>
        /// <param name="deleteItems">deleteItems.</param>
        /// <param name="recId">recId.</param>
        /// <param name="assetId">assetId.</param>
        public SCServiceChannelServicesMessagingRefrigerantTrackingLeakImmeasurableBulkChangeRequest(List<SCServiceChannelServicesMessagingRefrigerantTrackingAddLeakImmeasurableRequest> addItems = default(List<SCServiceChannelServicesMessagingRefrigerantTrackingAddLeakImmeasurableRequest>), List<SCServiceChannelServicesMessagingRefrigerantTrackingUpdateLeakImmeasurable> updateItems = default(List<SCServiceChannelServicesMessagingRefrigerantTrackingUpdateLeakImmeasurable>), List<int> deleteItems = default(List<int>), int recId = default(int), int assetId = default(int))
        {
            this.AddItems = addItems;
            this.UpdateItems = updateItems;
            this.DeleteItems = deleteItems;
            this.RecId = recId;
            this.AssetId = assetId;
        }

        /// <summary>
        /// Gets or Sets AddItems
        /// </summary>
        [DataMember(Name = "AddItems", EmitDefaultValue = false)]
        public List<SCServiceChannelServicesMessagingRefrigerantTrackingAddLeakImmeasurableRequest> AddItems { get; set; }

        /// <summary>
        /// Gets or Sets UpdateItems
        /// </summary>
        [DataMember(Name = "UpdateItems", EmitDefaultValue = false)]
        public List<SCServiceChannelServicesMessagingRefrigerantTrackingUpdateLeakImmeasurable> UpdateItems { get; set; }

        /// <summary>
        /// Gets or Sets DeleteItems
        /// </summary>
        [DataMember(Name = "DeleteItems", EmitDefaultValue = false)]
        public List<int> DeleteItems { get; set; }

        /// <summary>
        /// Gets or Sets RecId
        /// </summary>
        [DataMember(Name = "RecId", EmitDefaultValue = false)]
        public int RecId { get; set; }

        /// <summary>
        /// Gets or Sets AssetId
        /// </summary>
        [DataMember(Name = "AssetId", EmitDefaultValue = false)]
        public int AssetId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingRefrigerantTrackingLeakImmeasurableBulkChangeRequest {\n");
            sb.Append("  AddItems: ").Append(AddItems).Append("\n");
            sb.Append("  UpdateItems: ").Append(UpdateItems).Append("\n");
            sb.Append("  DeleteItems: ").Append(DeleteItems).Append("\n");
            sb.Append("  RecId: ").Append(RecId).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingRefrigerantTrackingLeakImmeasurableBulkChangeRequest);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingRefrigerantTrackingLeakImmeasurableBulkChangeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingRefrigerantTrackingLeakImmeasurableBulkChangeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingRefrigerantTrackingLeakImmeasurableBulkChangeRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AddItems == input.AddItems ||
                    this.AddItems != null &&
                    input.AddItems != null &&
                    this.AddItems.SequenceEqual(input.AddItems)
                ) && 
                (
                    this.UpdateItems == input.UpdateItems ||
                    this.UpdateItems != null &&
                    input.UpdateItems != null &&
                    this.UpdateItems.SequenceEqual(input.UpdateItems)
                ) && 
                (
                    this.DeleteItems == input.DeleteItems ||
                    this.DeleteItems != null &&
                    input.DeleteItems != null &&
                    this.DeleteItems.SequenceEqual(input.DeleteItems)
                ) && 
                (
                    this.RecId == input.RecId ||
                    this.RecId.Equals(input.RecId)
                ) && 
                (
                    this.AssetId == input.AssetId ||
                    this.AssetId.Equals(input.AssetId)
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
                if (this.AddItems != null)
                {
                    hashCode = (hashCode * 59) + this.AddItems.GetHashCode();
                }
                if (this.UpdateItems != null)
                {
                    hashCode = (hashCode * 59) + this.UpdateItems.GetHashCode();
                }
                if (this.DeleteItems != null)
                {
                    hashCode = (hashCode * 59) + this.DeleteItems.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RecId.GetHashCode();
                hashCode = (hashCode * 59) + this.AssetId.GetHashCode();
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