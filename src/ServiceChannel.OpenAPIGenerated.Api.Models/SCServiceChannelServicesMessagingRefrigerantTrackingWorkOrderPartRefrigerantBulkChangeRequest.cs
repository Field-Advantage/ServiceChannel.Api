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
    public class SCServiceChannelServicesMessagingRefrigerantTrackingWorkOrderPartRefrigerantBulkChangeRequest : IEquatable<SCServiceChannelServicesMessagingRefrigerantTrackingWorkOrderPartRefrigerantBulkChangeRequest>
    {
        /// <summary>
        /// Gets or Sets AddItems
        /// </summary>
        [DataMember(Name="AddItems", EmitDefaultValue=false)]
        public List<SCServiceChannelServicesMessagingRefrigerantTrackingAddWorkOrderPartRefrigerantItem> AddItems { get; set; }

        /// <summary>
        /// Gets or Sets UpdateItems
        /// </summary>
        [DataMember(Name="UpdateItems", EmitDefaultValue=false)]
        public List<SCServiceChannelServicesMessagingRefrigerantTrackingUpdateWorkOrderPartRefrigerantItem> UpdateItems { get; set; }

        /// <summary>
        /// Gets or Sets DeleteItems
        /// </summary>
        [DataMember(Name="DeleteItems", EmitDefaultValue=false)]
        public List<SCServiceChannelServicesMessagingRefrigerantTrackingDeleteWorkOrderPartRefrigerantItem> DeleteItems { get; set; }

        /// <summary>
        /// Gets or Sets IsLocalTime
        /// </summary>
        [DataMember(Name="IsLocalTime", EmitDefaultValue=true)]
        public bool IsLocalTime { get; set; } = false;

        /// <summary>
        /// Gets or Sets SubmitQuantityExceeded
        /// </summary>
        [DataMember(Name="SubmitQuantityExceeded", EmitDefaultValue=true)]
        public bool SubmitQuantityExceeded { get; set; } = false;

        /// <summary>
        /// Gets or Sets SubmitMoeQtyExceeded
        /// </summary>
        [DataMember(Name="SubmitMoeQtyExceeded", EmitDefaultValue=true)]
        public bool SubmitMoeQtyExceeded { get; set; } = false;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingRefrigerantTrackingWorkOrderPartRefrigerantBulkChangeRequest {\n");
            sb.Append("  AddItems: ").Append(AddItems).Append("\n");
            sb.Append("  UpdateItems: ").Append(UpdateItems).Append("\n");
            sb.Append("  DeleteItems: ").Append(DeleteItems).Append("\n");
            sb.Append("  IsLocalTime: ").Append(IsLocalTime).Append("\n");
            sb.Append("  SubmitQuantityExceeded: ").Append(SubmitQuantityExceeded).Append("\n");
            sb.Append("  SubmitMoeQtyExceeded: ").Append(SubmitMoeQtyExceeded).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingRefrigerantTrackingWorkOrderPartRefrigerantBulkChangeRequest)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingRefrigerantTrackingWorkOrderPartRefrigerantBulkChangeRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingRefrigerantTrackingWorkOrderPartRefrigerantBulkChangeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingRefrigerantTrackingWorkOrderPartRefrigerantBulkChangeRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AddItems == other.AddItems ||
                    AddItems != null &&
                    other.AddItems != null &&
                    AddItems.SequenceEqual(other.AddItems)
                ) && 
                (
                    UpdateItems == other.UpdateItems ||
                    UpdateItems != null &&
                    other.UpdateItems != null &&
                    UpdateItems.SequenceEqual(other.UpdateItems)
                ) && 
                (
                    DeleteItems == other.DeleteItems ||
                    DeleteItems != null &&
                    other.DeleteItems != null &&
                    DeleteItems.SequenceEqual(other.DeleteItems)
                ) && 
                (
                    IsLocalTime == other.IsLocalTime ||
                    
                    IsLocalTime.Equals(other.IsLocalTime)
                ) && 
                (
                    SubmitQuantityExceeded == other.SubmitQuantityExceeded ||
                    
                    SubmitQuantityExceeded.Equals(other.SubmitQuantityExceeded)
                ) && 
                (
                    SubmitMoeQtyExceeded == other.SubmitMoeQtyExceeded ||
                    
                    SubmitMoeQtyExceeded.Equals(other.SubmitMoeQtyExceeded)
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
                    if (AddItems != null)
                    hashCode = hashCode * 59 + AddItems.GetHashCode();
                    if (UpdateItems != null)
                    hashCode = hashCode * 59 + UpdateItems.GetHashCode();
                    if (DeleteItems != null)
                    hashCode = hashCode * 59 + DeleteItems.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsLocalTime.GetHashCode();
                    
                    hashCode = hashCode * 59 + SubmitQuantityExceeded.GetHashCode();
                    
                    hashCode = hashCode * 59 + SubmitMoeQtyExceeded.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingRefrigerantTrackingWorkOrderPartRefrigerantBulkChangeRequest left, SCServiceChannelServicesMessagingRefrigerantTrackingWorkOrderPartRefrigerantBulkChangeRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingRefrigerantTrackingWorkOrderPartRefrigerantBulkChangeRequest left, SCServiceChannelServicesMessagingRefrigerantTrackingWorkOrderPartRefrigerantBulkChangeRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
