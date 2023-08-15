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
    /// Object containing the details of a refrigerant certification.
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.ContractorTools.ExtendedRefrigerantCertificationDTO")]
    public partial class SCServiceChannelServicesMessagingContractorToolsExtendedRefrigerantCertificationDTO : IEquatable<SCServiceChannelServicesMessagingContractorToolsExtendedRefrigerantCertificationDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingContractorToolsExtendedRefrigerantCertificationDTO" /> class.
        /// </summary>
        /// <param name="id">Numeric identifier of the certificate in the system..</param>
        /// <param name="certificationNumber">Unique certificate number given by the party that granted the certificate..</param>
        /// <param name="certificationExpirationDateTime">Date and time when the certificate expires..</param>
        /// <param name="description">Comment added to the attached file..</param>
        /// <param name="fileUrl">Path of the attached file..</param>
        /// <param name="fileName">Name of the attached file..</param>
        /// <param name="technicianFullName">First and last name of the technician who received the refrigerant certification..</param>
        /// <param name="authUserId">Single sign-on (SSO) ID of the technician who received the refrigerant certification..</param>
        /// <param name="certificationDateTime">Date and time when the refrigerant certification becomes valid..</param>
        /// <param name="certificationLevelId">Type ID of EPA 608 Technician Certification. Possible values: 1 - Type I, 2 - Type II , 3 - Type III, 4 - Universal..</param>
        /// <param name="certificationLevel">Type of EPA Section 608 Technician Certification. Possible values: Type Ⅰ - service of small appliances containing 5 lbs or less of refrigerant; Type Ⅱ - service or disposal of high- or very high-pressure appliances (containing more than 5 lbs of refrigerant); Type Ⅲ - service or disposal of low-pressure appliances; Universal - service of refrigerated appliances of all types..</param>
        public SCServiceChannelServicesMessagingContractorToolsExtendedRefrigerantCertificationDTO(int id = default(int), string certificationNumber = default(string), DateTime certificationExpirationDateTime = default(DateTime), string description = default(string), string fileUrl = default(string), string fileName = default(string), string technicianFullName = default(string), long authUserId = default(long), DateTime certificationDateTime = default(DateTime), int certificationLevelId = default(int), string certificationLevel = default(string))
        {
            this.Id = id;
            this.CertificationNumber = certificationNumber;
            this.CertificationExpirationDateTime = certificationExpirationDateTime;
            this.Description = description;
            this.FileUrl = fileUrl;
            this.FileName = fileName;
            this.TechnicianFullName = technicianFullName;
            this.AuthUserId = authUserId;
            this.CertificationDateTime = certificationDateTime;
            this.CertificationLevelId = certificationLevelId;
            this.CertificationLevel = certificationLevel;
        }

        /// <summary>
        /// Numeric identifier of the certificate in the system.
        /// </summary>
        /// <value>Numeric identifier of the certificate in the system.</value>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Unique certificate number given by the party that granted the certificate.
        /// </summary>
        /// <value>Unique certificate number given by the party that granted the certificate.</value>
        [DataMember(Name = "CertificationNumber", EmitDefaultValue = false)]
        public string CertificationNumber { get; set; }

        /// <summary>
        /// Date and time when the certificate expires.
        /// </summary>
        /// <value>Date and time when the certificate expires.</value>
        [DataMember(Name = "CertificationExpirationDateTime", EmitDefaultValue = false)]
        public DateTime CertificationExpirationDateTime { get; set; }

        /// <summary>
        /// Comment added to the attached file.
        /// </summary>
        /// <value>Comment added to the attached file.</value>
        [DataMember(Name = "Description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Path of the attached file.
        /// </summary>
        /// <value>Path of the attached file.</value>
        [DataMember(Name = "FileUrl", EmitDefaultValue = false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// Name of the attached file.
        /// </summary>
        /// <value>Name of the attached file.</value>
        [DataMember(Name = "FileName", EmitDefaultValue = false)]
        public string FileName { get; set; }

        /// <summary>
        /// First and last name of the technician who received the refrigerant certification.
        /// </summary>
        /// <value>First and last name of the technician who received the refrigerant certification.</value>
        [DataMember(Name = "TechnicianFullName", EmitDefaultValue = false)]
        public string TechnicianFullName { get; set; }

        /// <summary>
        /// Single sign-on (SSO) ID of the technician who received the refrigerant certification.
        /// </summary>
        /// <value>Single sign-on (SSO) ID of the technician who received the refrigerant certification.</value>
        [DataMember(Name = "AuthUserId", EmitDefaultValue = false)]
        public long AuthUserId { get; set; }

        /// <summary>
        /// Date and time when the refrigerant certification becomes valid.
        /// </summary>
        /// <value>Date and time when the refrigerant certification becomes valid.</value>
        [DataMember(Name = "CertificationDateTime", EmitDefaultValue = false)]
        public DateTime CertificationDateTime { get; set; }

        /// <summary>
        /// Type ID of EPA 608 Technician Certification. Possible values: 1 - Type I, 2 - Type II , 3 - Type III, 4 - Universal.
        /// </summary>
        /// <value>Type ID of EPA 608 Technician Certification. Possible values: 1 - Type I, 2 - Type II , 3 - Type III, 4 - Universal.</value>
        [DataMember(Name = "CertificationLevelId", EmitDefaultValue = false)]
        public int CertificationLevelId { get; set; }

        /// <summary>
        /// Type of EPA Section 608 Technician Certification. Possible values: Type Ⅰ - service of small appliances containing 5 lbs or less of refrigerant; Type Ⅱ - service or disposal of high- or very high-pressure appliances (containing more than 5 lbs of refrigerant); Type Ⅲ - service or disposal of low-pressure appliances; Universal - service of refrigerated appliances of all types.
        /// </summary>
        /// <value>Type of EPA Section 608 Technician Certification. Possible values: Type Ⅰ - service of small appliances containing 5 lbs or less of refrigerant; Type Ⅱ - service or disposal of high- or very high-pressure appliances (containing more than 5 lbs of refrigerant); Type Ⅲ - service or disposal of low-pressure appliances; Universal - service of refrigerated appliances of all types.</value>
        [DataMember(Name = "CertificationLevel", EmitDefaultValue = false)]
        public string CertificationLevel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingContractorToolsExtendedRefrigerantCertificationDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CertificationNumber: ").Append(CertificationNumber).Append("\n");
            sb.Append("  CertificationExpirationDateTime: ").Append(CertificationExpirationDateTime).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FileUrl: ").Append(FileUrl).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  TechnicianFullName: ").Append(TechnicianFullName).Append("\n");
            sb.Append("  AuthUserId: ").Append(AuthUserId).Append("\n");
            sb.Append("  CertificationDateTime: ").Append(CertificationDateTime).Append("\n");
            sb.Append("  CertificationLevelId: ").Append(CertificationLevelId).Append("\n");
            sb.Append("  CertificationLevel: ").Append(CertificationLevel).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingContractorToolsExtendedRefrigerantCertificationDTO);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingContractorToolsExtendedRefrigerantCertificationDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingContractorToolsExtendedRefrigerantCertificationDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingContractorToolsExtendedRefrigerantCertificationDTO input)
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
                    this.CertificationNumber == input.CertificationNumber ||
                    (this.CertificationNumber != null &&
                    this.CertificationNumber.Equals(input.CertificationNumber))
                ) && 
                (
                    this.CertificationExpirationDateTime == input.CertificationExpirationDateTime ||
                    (this.CertificationExpirationDateTime != null &&
                    this.CertificationExpirationDateTime.Equals(input.CertificationExpirationDateTime))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.FileUrl == input.FileUrl ||
                    (this.FileUrl != null &&
                    this.FileUrl.Equals(input.FileUrl))
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.TechnicianFullName == input.TechnicianFullName ||
                    (this.TechnicianFullName != null &&
                    this.TechnicianFullName.Equals(input.TechnicianFullName))
                ) && 
                (
                    this.AuthUserId == input.AuthUserId ||
                    this.AuthUserId.Equals(input.AuthUserId)
                ) && 
                (
                    this.CertificationDateTime == input.CertificationDateTime ||
                    (this.CertificationDateTime != null &&
                    this.CertificationDateTime.Equals(input.CertificationDateTime))
                ) && 
                (
                    this.CertificationLevelId == input.CertificationLevelId ||
                    this.CertificationLevelId.Equals(input.CertificationLevelId)
                ) && 
                (
                    this.CertificationLevel == input.CertificationLevel ||
                    (this.CertificationLevel != null &&
                    this.CertificationLevel.Equals(input.CertificationLevel))
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
                if (this.CertificationNumber != null)
                {
                    hashCode = (hashCode * 59) + this.CertificationNumber.GetHashCode();
                }
                if (this.CertificationExpirationDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.CertificationExpirationDateTime.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.FileUrl != null)
                {
                    hashCode = (hashCode * 59) + this.FileUrl.GetHashCode();
                }
                if (this.FileName != null)
                {
                    hashCode = (hashCode * 59) + this.FileName.GetHashCode();
                }
                if (this.TechnicianFullName != null)
                {
                    hashCode = (hashCode * 59) + this.TechnicianFullName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AuthUserId.GetHashCode();
                if (this.CertificationDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.CertificationDateTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CertificationLevelId.GetHashCode();
                if (this.CertificationLevel != null)
                {
                    hashCode = (hashCode * 59) + this.CertificationLevel.GetHashCode();
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
