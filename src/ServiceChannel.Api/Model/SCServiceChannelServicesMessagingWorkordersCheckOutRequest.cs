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
    /// Check-out request
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.Workorders.CheckOutRequest")]
    public partial class SCServiceChannelServicesMessagingWorkordersCheckOutRequest : IEquatable<SCServiceChannelServicesMessagingWorkordersCheckOutRequest>, IValidatableObject
    {
        /// <summary>
        /// The status that is set for the WO when checking out.              Required for the Repair type. Ignored for the Travel and custom types as well when &#x60;ActionStatus&#x60; &#x3D; &#x60;Cancel&#x60;.              **Default value:** NoStatusChange.
        /// </summary>
        /// <value>The status that is set for the WO when checking out.              Required for the Repair type. Ignored for the Travel and custom types as well when &#x60;ActionStatus&#x60; &#x3D; &#x60;Cancel&#x60;.              **Default value:** NoStatusChange.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PrimaryStatusEnum
        {
            /// <summary>
            /// Enum NoStatusChange for value: NoStatusChange
            /// </summary>
            [EnumMember(Value = "NoStatusChange")]
            NoStatusChange = 1,

            /// <summary>
            /// Enum InProgress for value: InProgress
            /// </summary>
            [EnumMember(Value = "InProgress")]
            InProgress = 2,

            /// <summary>
            /// Enum Completed for value: Completed
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed = 3,

            /// <summary>
            /// Enum WaitingForQuote for value: WaitingForQuote
            /// </summary>
            [EnumMember(Value = "WaitingForQuote")]
            WaitingForQuote = 4,

            /// <summary>
            /// Enum PartsOnOrder for value: PartsOnOrder
            /// </summary>
            [EnumMember(Value = "PartsOnOrder")]
            PartsOnOrder = 5,

            /// <summary>
            /// Enum Incomplete for value: Incomplete
            /// </summary>
            [EnumMember(Value = "Incomplete")]
            Incomplete = 6

        }


        /// <summary>
        /// The status that is set for the WO when checking out.              Required for the Repair type. Ignored for the Travel and custom types as well when &#x60;ActionStatus&#x60; &#x3D; &#x60;Cancel&#x60;.              **Default value:** NoStatusChange.
        /// </summary>
        /// <value>The status that is set for the WO when checking out.              Required for the Repair type. Ignored for the Travel and custom types as well when &#x60;ActionStatus&#x60; &#x3D; &#x60;Cancel&#x60;.              **Default value:** NoStatusChange.</value>
        [DataMember(Name = "PrimaryStatus", EmitDefaultValue = false)]
        public PrimaryStatusEnum? PrimaryStatus { get; set; }
        /// <summary>
        /// The status of the activity.              **Possible values:** &#x60;Complete&#x60;, &#x60;Cancel&#x60;. Both values result in recording a check-out.              &#x60;Complete&#x60; means that the technician has finished the activity. &#x60;Cancel&#x60; means the technician needs to pause the activity, for example, to have a break outside of the location. GPS coordinates are not required.              **Default value:** Complete.
        /// </summary>
        /// <value>The status of the activity.              **Possible values:** &#x60;Complete&#x60;, &#x60;Cancel&#x60;. Both values result in recording a check-out.              &#x60;Complete&#x60; means that the technician has finished the activity. &#x60;Cancel&#x60; means the technician needs to pause the activity, for example, to have a break outside of the location. GPS coordinates are not required.              **Default value:** Complete.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionStatusEnum
        {
            /// <summary>
            /// Enum Complete for value: Complete
            /// </summary>
            [EnumMember(Value = "Complete")]
            Complete = 1,

            /// <summary>
            /// Enum Cancel for value: Cancel
            /// </summary>
            [EnumMember(Value = "Cancel")]
            Cancel = 2

        }


        /// <summary>
        /// The status of the activity.              **Possible values:** &#x60;Complete&#x60;, &#x60;Cancel&#x60;. Both values result in recording a check-out.              &#x60;Complete&#x60; means that the technician has finished the activity. &#x60;Cancel&#x60; means the technician needs to pause the activity, for example, to have a break outside of the location. GPS coordinates are not required.              **Default value:** Complete.
        /// </summary>
        /// <value>The status of the activity.              **Possible values:** &#x60;Complete&#x60;, &#x60;Cancel&#x60;. Both values result in recording a check-out.              &#x60;Complete&#x60; means that the technician has finished the activity. &#x60;Cancel&#x60; means the technician needs to pause the activity, for example, to have a break outside of the location. GPS coordinates are not required.              **Default value:** Complete.</value>
        [DataMember(Name = "ActionStatus", EmitDefaultValue = false)]
        public ActionStatusEnum? ActionStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingWorkordersCheckOutRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SCServiceChannelServicesMessagingWorkordersCheckOutRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingWorkordersCheckOutRequest" /> class.
        /// </summary>
        /// <param name="workTypeId">The unique ID of the work type.              **Possible values:** &#x60;1&#x60; — Repair, &#x60;2&#x60; — Travel. Other values are possible when custom types are set up for the subscriber.              **Default value:** 1..</param>
        /// <param name="primaryStatus">The status that is set for the WO when checking out.              Required for the Repair type. Ignored for the Travel and custom types as well when &#x60;ActionStatus&#x60; &#x3D; &#x60;Cancel&#x60;.              **Default value:** NoStatusChange..</param>
        /// <param name="extendedStatus">The extended status that is set for the WO when checking out.              Optional for the Repair type. Ignored for the Travel and custom types, when &#x60;ActionStatus&#x60; &#x3D; &#x60;Cancel&#x60;, and for &#39;Completed&#39; PrimaryStatus (generated automatically).              Refrigerant WO with &#39;Completed&#39; PrimaryStatus — special case by RefrigerationTracking feature..</param>
        /// <param name="actionStatus">The status of the activity.              **Possible values:** &#x60;Complete&#x60;, &#x60;Cancel&#x60;. Both values result in recording a check-out.              &#x60;Complete&#x60; means that the technician has finished the activity. &#x60;Cancel&#x60; means the technician needs to pause the activity, for example, to have a break outside of the location. GPS coordinates are not required.              **Default value:** Complete..</param>
        /// <param name="resolution">The comment entered when checking out. Usually describes what was done during the recorded time. Ignored for the Travel and custom types as well as when &#x60;ActionStatus&#x60; &#x3D; &#x60;Cancel&#x60;.              **Default value:** empty..</param>
        /// <param name="userId">The user ID of the technician that is checking out. Use the same &#x60;UserId&#x60; for one pair of check-in and check-out records.              **Default value:** ID of the current user..</param>
        /// <param name="techsCount">The number of technicians that are checking out.              **Default value:** 1..</param>
        /// <param name="latitude">The latitude of the technician’s current position.              Required for the Repair and Travel type. Not required for custom types, for the Repair and Travel types when the [XML check-in/out permission](https://developer.servicechannel.com/guides/checkin/before-you-start/#xml-check-inout-permission) is enabled, and when &#x60;ActionStatus&#x60; &#x3D; &#x60;Cancel&#x60;. (required).</param>
        /// <param name="longitude">The longitude of the technician’s current position.              Required for the Repair and Travel type. Not required for custom types, for the Repair and Travel types when the [XML check-in/out permission](https://developer.servicechannel.com/guides/checkin/before-you-start/#xml-check-inout-permission) is enabled, and when &#x60;ActionStatus&#x60; &#x3D; &#x60;Cancel&#x60;. (required).</param>
        /// <param name="checkOutTime">The date and time of the check-out. Either indicate in UTC or pass the current time and add the UTC offset.              You can pass this value only when the [XML check-in/out permission](https://developer.servicechannel.com/guides/checkin/before-you-start/#xml-check-inout-permission) is enabled.              **Default value:** current date and time..</param>
        /// <param name="checkoutAll">checkoutAll (default to false).</param>
        /// <param name="actor">Optional, Actor.</param>
        /// <param name="signatureAttachmentId">Optional, SignatureAttachmentId              **Default value:** null.</param>
        /// <param name="unableObtainSignatureNoteId">Optional, UnableObtainSignatureNoteId              **Default value:** null.</param>
        public SCServiceChannelServicesMessagingWorkordersCheckOutRequest(int workTypeId = default(int), PrimaryStatusEnum? primaryStatus = default(PrimaryStatusEnum?), string extendedStatus = default(string), ActionStatusEnum? actionStatus = default(ActionStatusEnum?), string resolution = default(string), int userId = default(int), int techsCount = default(int), double latitude = default(double), double longitude = default(double), DateTime checkOutTime = default(DateTime), bool checkoutAll = false, string actor = default(string), int signatureAttachmentId = default(int), int unableObtainSignatureNoteId = default(int))
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.WorkTypeId = workTypeId;
            this.PrimaryStatus = primaryStatus;
            this.ExtendedStatus = extendedStatus;
            this.ActionStatus = actionStatus;
            this.Resolution = resolution;
            this.UserId = userId;
            this.TechsCount = techsCount;
            this.CheckOutTime = checkOutTime;
            this.CheckoutAll = checkoutAll;
            this.Actor = actor;
            this.SignatureAttachmentId = signatureAttachmentId;
            this.UnableObtainSignatureNoteId = unableObtainSignatureNoteId;
        }

        /// <summary>
        /// The unique ID of the work type.              **Possible values:** &#x60;1&#x60; — Repair, &#x60;2&#x60; — Travel. Other values are possible when custom types are set up for the subscriber.              **Default value:** 1.
        /// </summary>
        /// <value>The unique ID of the work type.              **Possible values:** &#x60;1&#x60; — Repair, &#x60;2&#x60; — Travel. Other values are possible when custom types are set up for the subscriber.              **Default value:** 1.</value>
        [DataMember(Name = "WorkTypeId", EmitDefaultValue = false)]
        public int WorkTypeId { get; set; }

        /// <summary>
        /// The extended status that is set for the WO when checking out.              Optional for the Repair type. Ignored for the Travel and custom types, when &#x60;ActionStatus&#x60; &#x3D; &#x60;Cancel&#x60;, and for &#39;Completed&#39; PrimaryStatus (generated automatically).              Refrigerant WO with &#39;Completed&#39; PrimaryStatus — special case by RefrigerationTracking feature.
        /// </summary>
        /// <value>The extended status that is set for the WO when checking out.              Optional for the Repair type. Ignored for the Travel and custom types, when &#x60;ActionStatus&#x60; &#x3D; &#x60;Cancel&#x60;, and for &#39;Completed&#39; PrimaryStatus (generated automatically).              Refrigerant WO with &#39;Completed&#39; PrimaryStatus — special case by RefrigerationTracking feature.</value>
        [DataMember(Name = "ExtendedStatus", EmitDefaultValue = false)]
        public string ExtendedStatus { get; set; }

        /// <summary>
        /// The comment entered when checking out. Usually describes what was done during the recorded time. Ignored for the Travel and custom types as well as when &#x60;ActionStatus&#x60; &#x3D; &#x60;Cancel&#x60;.              **Default value:** empty.
        /// </summary>
        /// <value>The comment entered when checking out. Usually describes what was done during the recorded time. Ignored for the Travel and custom types as well as when &#x60;ActionStatus&#x60; &#x3D; &#x60;Cancel&#x60;.              **Default value:** empty.</value>
        [DataMember(Name = "Resolution", EmitDefaultValue = false)]
        public string Resolution { get; set; }

        /// <summary>
        /// The user ID of the technician that is checking out. Use the same &#x60;UserId&#x60; for one pair of check-in and check-out records.              **Default value:** ID of the current user.
        /// </summary>
        /// <value>The user ID of the technician that is checking out. Use the same &#x60;UserId&#x60; for one pair of check-in and check-out records.              **Default value:** ID of the current user.</value>
        [DataMember(Name = "UserId", EmitDefaultValue = false)]
        public int UserId { get; set; }

        /// <summary>
        /// The number of technicians that are checking out.              **Default value:** 1.
        /// </summary>
        /// <value>The number of technicians that are checking out.              **Default value:** 1.</value>
        [DataMember(Name = "TechsCount", EmitDefaultValue = false)]
        public int TechsCount { get; set; }

        /// <summary>
        /// The latitude of the technician’s current position.              Required for the Repair and Travel type. Not required for custom types, for the Repair and Travel types when the [XML check-in/out permission](https://developer.servicechannel.com/guides/checkin/before-you-start/#xml-check-inout-permission) is enabled, and when &#x60;ActionStatus&#x60; &#x3D; &#x60;Cancel&#x60;.
        /// </summary>
        /// <value>The latitude of the technician’s current position.              Required for the Repair and Travel type. Not required for custom types, for the Repair and Travel types when the [XML check-in/out permission](https://developer.servicechannel.com/guides/checkin/before-you-start/#xml-check-inout-permission) is enabled, and when &#x60;ActionStatus&#x60; &#x3D; &#x60;Cancel&#x60;.</value>
        [DataMember(Name = "Latitude", IsRequired = true, EmitDefaultValue = true)]
        public double Latitude { get; set; }

        /// <summary>
        /// The longitude of the technician’s current position.              Required for the Repair and Travel type. Not required for custom types, for the Repair and Travel types when the [XML check-in/out permission](https://developer.servicechannel.com/guides/checkin/before-you-start/#xml-check-inout-permission) is enabled, and when &#x60;ActionStatus&#x60; &#x3D; &#x60;Cancel&#x60;.
        /// </summary>
        /// <value>The longitude of the technician’s current position.              Required for the Repair and Travel type. Not required for custom types, for the Repair and Travel types when the [XML check-in/out permission](https://developer.servicechannel.com/guides/checkin/before-you-start/#xml-check-inout-permission) is enabled, and when &#x60;ActionStatus&#x60; &#x3D; &#x60;Cancel&#x60;.</value>
        [DataMember(Name = "Longitude", IsRequired = true, EmitDefaultValue = true)]
        public double Longitude { get; set; }

        /// <summary>
        /// The date and time of the check-out. Either indicate in UTC or pass the current time and add the UTC offset.              You can pass this value only when the [XML check-in/out permission](https://developer.servicechannel.com/guides/checkin/before-you-start/#xml-check-inout-permission) is enabled.              **Default value:** current date and time.
        /// </summary>
        /// <value>The date and time of the check-out. Either indicate in UTC or pass the current time and add the UTC offset.              You can pass this value only when the [XML check-in/out permission](https://developer.servicechannel.com/guides/checkin/before-you-start/#xml-check-inout-permission) is enabled.              **Default value:** current date and time.</value>
        [DataMember(Name = "CheckOutTime", EmitDefaultValue = false)]
        public DateTime CheckOutTime { get; set; }

        /// <summary>
        /// Gets or Sets CheckoutAll
        /// </summary>
        [DataMember(Name = "CheckoutAll", EmitDefaultValue = true)]
        public bool CheckoutAll { get; set; }

        /// <summary>
        /// Optional, Actor
        /// </summary>
        /// <value>Optional, Actor</value>
        [DataMember(Name = "Actor", EmitDefaultValue = false)]
        public string Actor { get; set; }

        /// <summary>
        /// Optional, SignatureAttachmentId              **Default value:** null
        /// </summary>
        /// <value>Optional, SignatureAttachmentId              **Default value:** null</value>
        [DataMember(Name = "SignatureAttachmentId", EmitDefaultValue = false)]
        public int SignatureAttachmentId { get; set; }

        /// <summary>
        /// Optional, UnableObtainSignatureNoteId              **Default value:** null
        /// </summary>
        /// <value>Optional, UnableObtainSignatureNoteId              **Default value:** null</value>
        [DataMember(Name = "UnableObtainSignatureNoteId", EmitDefaultValue = false)]
        public int UnableObtainSignatureNoteId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingWorkordersCheckOutRequest {\n");
            sb.Append("  WorkTypeId: ").Append(WorkTypeId).Append("\n");
            sb.Append("  PrimaryStatus: ").Append(PrimaryStatus).Append("\n");
            sb.Append("  ExtendedStatus: ").Append(ExtendedStatus).Append("\n");
            sb.Append("  ActionStatus: ").Append(ActionStatus).Append("\n");
            sb.Append("  Resolution: ").Append(Resolution).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  TechsCount: ").Append(TechsCount).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  CheckOutTime: ").Append(CheckOutTime).Append("\n");
            sb.Append("  CheckoutAll: ").Append(CheckoutAll).Append("\n");
            sb.Append("  Actor: ").Append(Actor).Append("\n");
            sb.Append("  SignatureAttachmentId: ").Append(SignatureAttachmentId).Append("\n");
            sb.Append("  UnableObtainSignatureNoteId: ").Append(UnableObtainSignatureNoteId).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingWorkordersCheckOutRequest);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingWorkordersCheckOutRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingWorkordersCheckOutRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingWorkordersCheckOutRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.WorkTypeId == input.WorkTypeId ||
                    this.WorkTypeId.Equals(input.WorkTypeId)
                ) && 
                (
                    this.PrimaryStatus == input.PrimaryStatus ||
                    this.PrimaryStatus.Equals(input.PrimaryStatus)
                ) && 
                (
                    this.ExtendedStatus == input.ExtendedStatus ||
                    (this.ExtendedStatus != null &&
                    this.ExtendedStatus.Equals(input.ExtendedStatus))
                ) && 
                (
                    this.ActionStatus == input.ActionStatus ||
                    this.ActionStatus.Equals(input.ActionStatus)
                ) && 
                (
                    this.Resolution == input.Resolution ||
                    (this.Resolution != null &&
                    this.Resolution.Equals(input.Resolution))
                ) && 
                (
                    this.UserId == input.UserId ||
                    this.UserId.Equals(input.UserId)
                ) && 
                (
                    this.TechsCount == input.TechsCount ||
                    this.TechsCount.Equals(input.TechsCount)
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    this.Latitude.Equals(input.Latitude)
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    this.Longitude.Equals(input.Longitude)
                ) && 
                (
                    this.CheckOutTime == input.CheckOutTime ||
                    (this.CheckOutTime != null &&
                    this.CheckOutTime.Equals(input.CheckOutTime))
                ) && 
                (
                    this.CheckoutAll == input.CheckoutAll ||
                    this.CheckoutAll.Equals(input.CheckoutAll)
                ) && 
                (
                    this.Actor == input.Actor ||
                    (this.Actor != null &&
                    this.Actor.Equals(input.Actor))
                ) && 
                (
                    this.SignatureAttachmentId == input.SignatureAttachmentId ||
                    this.SignatureAttachmentId.Equals(input.SignatureAttachmentId)
                ) && 
                (
                    this.UnableObtainSignatureNoteId == input.UnableObtainSignatureNoteId ||
                    this.UnableObtainSignatureNoteId.Equals(input.UnableObtainSignatureNoteId)
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
                hashCode = (hashCode * 59) + this.WorkTypeId.GetHashCode();
                hashCode = (hashCode * 59) + this.PrimaryStatus.GetHashCode();
                if (this.ExtendedStatus != null)
                {
                    hashCode = (hashCode * 59) + this.ExtendedStatus.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ActionStatus.GetHashCode();
                if (this.Resolution != null)
                {
                    hashCode = (hashCode * 59) + this.Resolution.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                hashCode = (hashCode * 59) + this.TechsCount.GetHashCode();
                hashCode = (hashCode * 59) + this.Latitude.GetHashCode();
                hashCode = (hashCode * 59) + this.Longitude.GetHashCode();
                if (this.CheckOutTime != null)
                {
                    hashCode = (hashCode * 59) + this.CheckOutTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CheckoutAll.GetHashCode();
                if (this.Actor != null)
                {
                    hashCode = (hashCode * 59) + this.Actor.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SignatureAttachmentId.GetHashCode();
                hashCode = (hashCode * 59) + this.UnableObtainSignatureNoteId.GetHashCode();
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