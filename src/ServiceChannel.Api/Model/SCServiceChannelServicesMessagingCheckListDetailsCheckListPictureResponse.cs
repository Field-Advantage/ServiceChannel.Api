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
    /// Object for an attachment added to a checklist response.
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.CheckListDetails.CheckListPictureResponse")]
    public partial class SCServiceChannelServicesMessagingCheckListDetailsCheckListPictureResponse : IEquatable<SCServiceChannelServicesMessagingCheckListDetailsCheckListPictureResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingCheckListDetailsCheckListPictureResponse" /> class.
        /// </summary>
        /// <param name="id">ID of the file attached to the checklist response..</param>
        /// <param name="checkListResponseId">ID of the checklist response the attachment is submitted for..</param>
        /// <param name="documentName">Attachment name..</param>
        /// <param name="documentPath">Attachment path..</param>
        /// <param name="thumbnailPath">Attachment thumbnail path..</param>
        /// <param name="hasThumbnail">Defines whether a thumbnail is available for the attachment. (default to false).</param>
        /// <param name="updatedBy">User Id..</param>
        public SCServiceChannelServicesMessagingCheckListDetailsCheckListPictureResponse(int id = default(int), int checkListResponseId = default(int), string documentName = default(string), string documentPath = default(string), string thumbnailPath = default(string), bool hasThumbnail = false, int updatedBy = default(int))
        {
            this.Id = id;
            this.CheckListResponseId = checkListResponseId;
            this.DocumentName = documentName;
            this.DocumentPath = documentPath;
            this.ThumbnailPath = thumbnailPath;
            this.HasThumbnail = hasThumbnail;
            this.UpdatedBy = updatedBy;
        }

        /// <summary>
        /// ID of the file attached to the checklist response.
        /// </summary>
        /// <value>ID of the file attached to the checklist response.</value>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// ID of the checklist response the attachment is submitted for.
        /// </summary>
        /// <value>ID of the checklist response the attachment is submitted for.</value>
        [DataMember(Name = "CheckListResponseId", EmitDefaultValue = false)]
        public int CheckListResponseId { get; set; }

        /// <summary>
        /// Attachment name.
        /// </summary>
        /// <value>Attachment name.</value>
        [DataMember(Name = "DocumentName", EmitDefaultValue = false)]
        public string DocumentName { get; set; }

        /// <summary>
        /// Attachment path.
        /// </summary>
        /// <value>Attachment path.</value>
        [DataMember(Name = "DocumentPath", EmitDefaultValue = false)]
        public string DocumentPath { get; set; }

        /// <summary>
        /// Attachment thumbnail path.
        /// </summary>
        /// <value>Attachment thumbnail path.</value>
        [DataMember(Name = "ThumbnailPath", EmitDefaultValue = false)]
        public string ThumbnailPath { get; set; }

        /// <summary>
        /// Defines whether a thumbnail is available for the attachment.
        /// </summary>
        /// <value>Defines whether a thumbnail is available for the attachment.</value>
        [DataMember(Name = "HasThumbnail", EmitDefaultValue = true)]
        public bool HasThumbnail { get; set; }

        /// <summary>
        /// User Id.
        /// </summary>
        /// <value>User Id.</value>
        [DataMember(Name = "UpdatedBy", EmitDefaultValue = false)]
        public int UpdatedBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingCheckListDetailsCheckListPictureResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CheckListResponseId: ").Append(CheckListResponseId).Append("\n");
            sb.Append("  DocumentName: ").Append(DocumentName).Append("\n");
            sb.Append("  DocumentPath: ").Append(DocumentPath).Append("\n");
            sb.Append("  ThumbnailPath: ").Append(ThumbnailPath).Append("\n");
            sb.Append("  HasThumbnail: ").Append(HasThumbnail).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingCheckListDetailsCheckListPictureResponse);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingCheckListDetailsCheckListPictureResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingCheckListDetailsCheckListPictureResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingCheckListDetailsCheckListPictureResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.CheckListResponseId == input.CheckListResponseId ||
                    this.CheckListResponseId.Equals(input.CheckListResponseId)
                ) && 
                (
                    this.DocumentName == input.DocumentName ||
                    (this.DocumentName != null &&
                    this.DocumentName.Equals(input.DocumentName))
                ) && 
                (
                    this.DocumentPath == input.DocumentPath ||
                    (this.DocumentPath != null &&
                    this.DocumentPath.Equals(input.DocumentPath))
                ) && 
                (
                    this.ThumbnailPath == input.ThumbnailPath ||
                    (this.ThumbnailPath != null &&
                    this.ThumbnailPath.Equals(input.ThumbnailPath))
                ) && 
                (
                    this.HasThumbnail == input.HasThumbnail ||
                    this.HasThumbnail.Equals(input.HasThumbnail)
                ) && 
                (
                    this.UpdatedBy == input.UpdatedBy ||
                    this.UpdatedBy.Equals(input.UpdatedBy)
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                hashCode = (hashCode * 59) + this.CheckListResponseId.GetHashCode();
                if (this.DocumentName != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentName.GetHashCode();
                }
                if (this.DocumentPath != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentPath.GetHashCode();
                }
                if (this.ThumbnailPath != null)
                {
                    hashCode = (hashCode * 59) + this.ThumbnailPath.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HasThumbnail.GetHashCode();
                hashCode = (hashCode * 59) + this.UpdatedBy.GetHashCode();
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
