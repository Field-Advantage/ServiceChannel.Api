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
    public class SCServiceChannelApiModelEntitiesUserAnnouncement : IEquatable<SCServiceChannelApiModelEntitiesUserAnnouncement>
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=true)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="Title", EmitDefaultValue=false)]
        public string Title { get; set; }


        /// <summary>
        /// Gets or Sets AnnouncementType
        /// </summary>
        
        public enum AnnouncementTypeEnum
        {
            
            /// <summary>
            /// Enum NonModalEnum for NonModal
            /// </summary>
            [EnumMember(Value = "NonModal")]
            NonModalEnum = 1,
            
            /// <summary>
            /// Enum ModalEnum for Modal
            /// </summary>
            [EnumMember(Value = "Modal")]
            ModalEnum = 2,
            
            /// <summary>
            /// Enum SCProviderMobileEnum for SCProviderMobile
            /// </summary>
            [EnumMember(Value = "SCProviderMobile")]
            SCProviderMobileEnum = 3
        }

        /// <summary>
        /// Gets or Sets AnnouncementType
        /// </summary>
        [DataMember(Name="AnnouncementType", EmitDefaultValue=true)]
        public AnnouncementTypeEnum AnnouncementType { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets CreatedById
        /// </summary>
        [DataMember(Name="CreatedById", EmitDefaultValue=true)]
        public int CreatedById { get; set; }

        /// <summary>
        /// Gets or Sets MessageBody
        /// </summary>
        [DataMember(Name="MessageBody", EmitDefaultValue=false)]
        public string MessageBody { get; set; }

        /// <summary>
        /// Gets or Sets CallToAction
        /// </summary>
        [DataMember(Name="CallToAction", EmitDefaultValue=false)]
        public string CallToAction { get; set; }

        /// <summary>
        /// Gets or Sets ImageLink
        /// </summary>
        [DataMember(Name="ImageLink", EmitDefaultValue=false)]
        public string ImageLink { get; set; }

        /// <summary>
        /// Gets or Sets UrlLink
        /// </summary>
        [DataMember(Name="UrlLink", EmitDefaultValue=false)]
        public string UrlLink { get; set; }

        /// <summary>
        /// Gets or Sets ImageName
        /// </summary>
        [DataMember(Name="ImageName", EmitDefaultValue=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelApiModelEntitiesUserAnnouncement {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  AnnouncementType: ").Append(AnnouncementType).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  MessageBody: ").Append(MessageBody).Append("\n");
            sb.Append("  CallToAction: ").Append(CallToAction).Append("\n");
            sb.Append("  ImageLink: ").Append(ImageLink).Append("\n");
            sb.Append("  UrlLink: ").Append(UrlLink).Append("\n");
            sb.Append("  ImageName: ").Append(ImageName).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelApiModelEntitiesUserAnnouncement)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelApiModelEntitiesUserAnnouncement instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelApiModelEntitiesUserAnnouncement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelApiModelEntitiesUserAnnouncement other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    Title == other.Title ||
                    Title != null &&
                    Title.Equals(other.Title)
                ) && 
                (
                    AnnouncementType == other.AnnouncementType ||
                    
                    AnnouncementType.Equals(other.AnnouncementType)
                ) && 
                (
                    CreatedDate == other.CreatedDate ||
                    CreatedDate != null &&
                    CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    CreatedById == other.CreatedById ||
                    
                    CreatedById.Equals(other.CreatedById)
                ) && 
                (
                    MessageBody == other.MessageBody ||
                    MessageBody != null &&
                    MessageBody.Equals(other.MessageBody)
                ) && 
                (
                    CallToAction == other.CallToAction ||
                    CallToAction != null &&
                    CallToAction.Equals(other.CallToAction)
                ) && 
                (
                    ImageLink == other.ImageLink ||
                    ImageLink != null &&
                    ImageLink.Equals(other.ImageLink)
                ) && 
                (
                    UrlLink == other.UrlLink ||
                    UrlLink != null &&
                    UrlLink.Equals(other.UrlLink)
                ) && 
                (
                    ImageName == other.ImageName ||
                    ImageName != null &&
                    ImageName.Equals(other.ImageName)
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
                    if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                    
                    hashCode = hashCode * 59 + AnnouncementType.GetHashCode();
                    if (CreatedDate != null)
                    hashCode = hashCode * 59 + CreatedDate.GetHashCode();
                    
                    hashCode = hashCode * 59 + CreatedById.GetHashCode();
                    if (MessageBody != null)
                    hashCode = hashCode * 59 + MessageBody.GetHashCode();
                    if (CallToAction != null)
                    hashCode = hashCode * 59 + CallToAction.GetHashCode();
                    if (ImageLink != null)
                    hashCode = hashCode * 59 + ImageLink.GetHashCode();
                    if (UrlLink != null)
                    hashCode = hashCode * 59 + UrlLink.GetHashCode();
                    if (ImageName != null)
                    hashCode = hashCode * 59 + ImageName.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelApiModelEntitiesUserAnnouncement left, SCServiceChannelApiModelEntitiesUserAnnouncement right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelApiModelEntitiesUserAnnouncement left, SCServiceChannelApiModelEntitiesUserAnnouncement right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}