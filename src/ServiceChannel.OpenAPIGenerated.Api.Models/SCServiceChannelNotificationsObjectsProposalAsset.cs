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
    public class SCServiceChannelNotificationsObjectsProposalAsset : IEquatable<SCServiceChannelNotificationsObjectsProposalAsset>
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="Action", EmitDefaultValue=false)]
        public string Action { get; set; }

        /// <summary>
        /// Gets or Sets Area
        /// </summary>
        [DataMember(Name="Area", EmitDefaultValue=false)]
        public string Area { get; set; }

        /// <summary>
        /// Gets or Sets BrandId
        /// </summary>
        [DataMember(Name="BrandId", EmitDefaultValue=false)]
        public string BrandId { get; set; }

        /// <summary>
        /// Gets or Sets TypeId
        /// </summary>
        [DataMember(Name="TypeId", EmitDefaultValue=false)]
        public string TypeId { get; set; }

        /// <summary>
        /// Gets or Sets IsNew
        /// </summary>
        [DataMember(Name="IsNew", EmitDefaultValue=true)]
        public bool IsNew { get; set; } = false;

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="Attributes", EmitDefaultValue=false)]
        public List<SCServiceChannelNotificationsObjectsProposalAssetAttribute> Attributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelNotificationsObjectsProposalAsset {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Area: ").Append(Area).Append("\n");
            sb.Append("  BrandId: ").Append(BrandId).Append("\n");
            sb.Append("  TypeId: ").Append(TypeId).Append("\n");
            sb.Append("  IsNew: ").Append(IsNew).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelNotificationsObjectsProposalAsset)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelNotificationsObjectsProposalAsset instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelNotificationsObjectsProposalAsset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelNotificationsObjectsProposalAsset other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Action == other.Action ||
                    Action != null &&
                    Action.Equals(other.Action)
                ) && 
                (
                    Area == other.Area ||
                    Area != null &&
                    Area.Equals(other.Area)
                ) && 
                (
                    BrandId == other.BrandId ||
                    BrandId != null &&
                    BrandId.Equals(other.BrandId)
                ) && 
                (
                    TypeId == other.TypeId ||
                    TypeId != null &&
                    TypeId.Equals(other.TypeId)
                ) && 
                (
                    IsNew == other.IsNew ||
                    
                    IsNew.Equals(other.IsNew)
                ) && 
                (
                    Attributes == other.Attributes ||
                    Attributes != null &&
                    other.Attributes != null &&
                    Attributes.SequenceEqual(other.Attributes)
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
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Action != null)
                    hashCode = hashCode * 59 + Action.GetHashCode();
                    if (Area != null)
                    hashCode = hashCode * 59 + Area.GetHashCode();
                    if (BrandId != null)
                    hashCode = hashCode * 59 + BrandId.GetHashCode();
                    if (TypeId != null)
                    hashCode = hashCode * 59 + TypeId.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsNew.GetHashCode();
                    if (Attributes != null)
                    hashCode = hashCode * 59 + Attributes.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelNotificationsObjectsProposalAsset left, SCServiceChannelNotificationsObjectsProposalAsset right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelNotificationsObjectsProposalAsset left, SCServiceChannelNotificationsObjectsProposalAsset right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
