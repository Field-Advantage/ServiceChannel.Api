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
    public class SCServiceChannelServicesMessagingAssetsAssetAttachment : IEquatable<SCServiceChannelServicesMessagingAssetsAssetAttachment>
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=true)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets AssetId
        /// </summary>
        [DataMember(Name="AssetId", EmitDefaultValue=true)]
        public int AssetId { get; set; }

        /// <summary>
        /// Gets or Sets FileName
        /// </summary>
        [DataMember(Name="FileName", EmitDefaultValue=false)]
        public string FileName { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="Comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="Date", EmitDefaultValue=false)]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or Sets FilePath
        /// </summary>
        [DataMember(Name="FilePath", EmitDefaultValue=false)]
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or Sets IsPrimary
        /// </summary>
        [DataMember(Name="IsPrimary", EmitDefaultValue=true)]
        public bool IsPrimary { get; set; } = false;

        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name="Uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or Sets ThumbnailPath
        /// </summary>
        [DataMember(Name="ThumbnailPath", EmitDefaultValue=false)]
        public string ThumbnailPath { get; set; }

        /// <summary>
        /// Gets or Sets ThumbnailUri
        /// </summary>
        [DataMember(Name="ThumbnailUri", EmitDefaultValue=false)]
        public string ThumbnailUri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingAssetsAssetAttachment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  FilePath: ").Append(FilePath).Append("\n");
            sb.Append("  IsPrimary: ").Append(IsPrimary).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  ThumbnailPath: ").Append(ThumbnailPath).Append("\n");
            sb.Append("  ThumbnailUri: ").Append(ThumbnailUri).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingAssetsAssetAttachment)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingAssetsAssetAttachment instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingAssetsAssetAttachment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingAssetsAssetAttachment other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    AssetId == other.AssetId ||
                    
                    AssetId.Equals(other.AssetId)
                ) && 
                (
                    FileName == other.FileName ||
                    FileName != null &&
                    FileName.Equals(other.FileName)
                ) && 
                (
                    Comment == other.Comment ||
                    Comment != null &&
                    Comment.Equals(other.Comment)
                ) && 
                (
                    Date == other.Date ||
                    Date != null &&
                    Date.Equals(other.Date)
                ) && 
                (
                    FilePath == other.FilePath ||
                    FilePath != null &&
                    FilePath.Equals(other.FilePath)
                ) && 
                (
                    IsPrimary == other.IsPrimary ||
                    
                    IsPrimary.Equals(other.IsPrimary)
                ) && 
                (
                    Uri == other.Uri ||
                    Uri != null &&
                    Uri.Equals(other.Uri)
                ) && 
                (
                    ThumbnailPath == other.ThumbnailPath ||
                    ThumbnailPath != null &&
                    ThumbnailPath.Equals(other.ThumbnailPath)
                ) && 
                (
                    ThumbnailUri == other.ThumbnailUri ||
                    ThumbnailUri != null &&
                    ThumbnailUri.Equals(other.ThumbnailUri)
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
                    
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    
                    hashCode = hashCode * 59 + AssetId.GetHashCode();
                    if (FileName != null)
                    hashCode = hashCode * 59 + FileName.GetHashCode();
                    if (Comment != null)
                    hashCode = hashCode * 59 + Comment.GetHashCode();
                    if (Date != null)
                    hashCode = hashCode * 59 + Date.GetHashCode();
                    if (FilePath != null)
                    hashCode = hashCode * 59 + FilePath.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsPrimary.GetHashCode();
                    if (Uri != null)
                    hashCode = hashCode * 59 + Uri.GetHashCode();
                    if (ThumbnailPath != null)
                    hashCode = hashCode * 59 + ThumbnailPath.GetHashCode();
                    if (ThumbnailUri != null)
                    hashCode = hashCode * 59 + ThumbnailUri.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingAssetsAssetAttachment left, SCServiceChannelServicesMessagingAssetsAssetAttachment right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingAssetsAssetAttachment left, SCServiceChannelServicesMessagingAssetsAssetAttachment right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
