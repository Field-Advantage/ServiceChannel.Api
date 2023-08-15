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
    /// SCAmazonRuntimeInternalErrorResponse
    /// </summary>
    [DataContract(Name = "Amazon.Runtime.Internal.ErrorResponse")]
    public partial class SCAmazonRuntimeInternalErrorResponse : IEquatable<SCAmazonRuntimeInternalErrorResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Sender for value: Sender
            /// </summary>
            [EnumMember(Value = "Sender")]
            Sender = 1,

            /// <summary>
            /// Enum Receiver for value: Receiver
            /// </summary>
            [EnumMember(Value = "Receiver")]
            Receiver = 2,

            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 3

        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "Type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Defines StatusCode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusCodeEnum
        {
            /// <summary>
            /// Enum Continue for value: Continue
            /// </summary>
            [EnumMember(Value = "Continue")]
            Continue = 1,

            /// <summary>
            /// Enum SwitchingProtocols for value: SwitchingProtocols
            /// </summary>
            [EnumMember(Value = "SwitchingProtocols")]
            SwitchingProtocols = 2,

            /// <summary>
            /// Enum OK for value: OK
            /// </summary>
            [EnumMember(Value = "OK")]
            OK = 3,

            /// <summary>
            /// Enum Created for value: Created
            /// </summary>
            [EnumMember(Value = "Created")]
            Created = 4,

            /// <summary>
            /// Enum Accepted for value: Accepted
            /// </summary>
            [EnumMember(Value = "Accepted")]
            Accepted = 5,

            /// <summary>
            /// Enum NonAuthoritativeInformation for value: NonAuthoritativeInformation
            /// </summary>
            [EnumMember(Value = "NonAuthoritativeInformation")]
            NonAuthoritativeInformation = 6,

            /// <summary>
            /// Enum NoContent for value: NoContent
            /// </summary>
            [EnumMember(Value = "NoContent")]
            NoContent = 7,

            /// <summary>
            /// Enum ResetContent for value: ResetContent
            /// </summary>
            [EnumMember(Value = "ResetContent")]
            ResetContent = 8,

            /// <summary>
            /// Enum PartialContent for value: PartialContent
            /// </summary>
            [EnumMember(Value = "PartialContent")]
            PartialContent = 9,

            /// <summary>
            /// Enum MultipleChoices for value: MultipleChoices
            /// </summary>
            [EnumMember(Value = "MultipleChoices")]
            MultipleChoices = 10,

            /// <summary>
            /// Enum Ambiguous for value: Ambiguous
            /// </summary>
            [EnumMember(Value = "Ambiguous")]
            Ambiguous = 11,

            /// <summary>
            /// Enum MovedPermanently for value: MovedPermanently
            /// </summary>
            [EnumMember(Value = "MovedPermanently")]
            MovedPermanently = 12,

            /// <summary>
            /// Enum Moved for value: Moved
            /// </summary>
            [EnumMember(Value = "Moved")]
            Moved = 13,

            /// <summary>
            /// Enum Found for value: Found
            /// </summary>
            [EnumMember(Value = "Found")]
            Found = 14,

            /// <summary>
            /// Enum Redirect for value: Redirect
            /// </summary>
            [EnumMember(Value = "Redirect")]
            Redirect = 15,

            /// <summary>
            /// Enum SeeOther for value: SeeOther
            /// </summary>
            [EnumMember(Value = "SeeOther")]
            SeeOther = 16,

            /// <summary>
            /// Enum RedirectMethod for value: RedirectMethod
            /// </summary>
            [EnumMember(Value = "RedirectMethod")]
            RedirectMethod = 17,

            /// <summary>
            /// Enum NotModified for value: NotModified
            /// </summary>
            [EnumMember(Value = "NotModified")]
            NotModified = 18,

            /// <summary>
            /// Enum UseProxy for value: UseProxy
            /// </summary>
            [EnumMember(Value = "UseProxy")]
            UseProxy = 19,

            /// <summary>
            /// Enum Unused for value: Unused
            /// </summary>
            [EnumMember(Value = "Unused")]
            Unused = 20,

            /// <summary>
            /// Enum TemporaryRedirect for value: TemporaryRedirect
            /// </summary>
            [EnumMember(Value = "TemporaryRedirect")]
            TemporaryRedirect = 21,

            /// <summary>
            /// Enum RedirectKeepVerb for value: RedirectKeepVerb
            /// </summary>
            [EnumMember(Value = "RedirectKeepVerb")]
            RedirectKeepVerb = 22,

            /// <summary>
            /// Enum BadRequest for value: BadRequest
            /// </summary>
            [EnumMember(Value = "BadRequest")]
            BadRequest = 23,

            /// <summary>
            /// Enum Unauthorized for value: Unauthorized
            /// </summary>
            [EnumMember(Value = "Unauthorized")]
            Unauthorized = 24,

            /// <summary>
            /// Enum PaymentRequired for value: PaymentRequired
            /// </summary>
            [EnumMember(Value = "PaymentRequired")]
            PaymentRequired = 25,

            /// <summary>
            /// Enum Forbidden for value: Forbidden
            /// </summary>
            [EnumMember(Value = "Forbidden")]
            Forbidden = 26,

            /// <summary>
            /// Enum NotFound for value: NotFound
            /// </summary>
            [EnumMember(Value = "NotFound")]
            NotFound = 27,

            /// <summary>
            /// Enum MethodNotAllowed for value: MethodNotAllowed
            /// </summary>
            [EnumMember(Value = "MethodNotAllowed")]
            MethodNotAllowed = 28,

            /// <summary>
            /// Enum NotAcceptable for value: NotAcceptable
            /// </summary>
            [EnumMember(Value = "NotAcceptable")]
            NotAcceptable = 29,

            /// <summary>
            /// Enum ProxyAuthenticationRequired for value: ProxyAuthenticationRequired
            /// </summary>
            [EnumMember(Value = "ProxyAuthenticationRequired")]
            ProxyAuthenticationRequired = 30,

            /// <summary>
            /// Enum RequestTimeout for value: RequestTimeout
            /// </summary>
            [EnumMember(Value = "RequestTimeout")]
            RequestTimeout = 31,

            /// <summary>
            /// Enum Conflict for value: Conflict
            /// </summary>
            [EnumMember(Value = "Conflict")]
            Conflict = 32,

            /// <summary>
            /// Enum Gone for value: Gone
            /// </summary>
            [EnumMember(Value = "Gone")]
            Gone = 33,

            /// <summary>
            /// Enum LengthRequired for value: LengthRequired
            /// </summary>
            [EnumMember(Value = "LengthRequired")]
            LengthRequired = 34,

            /// <summary>
            /// Enum PreconditionFailed for value: PreconditionFailed
            /// </summary>
            [EnumMember(Value = "PreconditionFailed")]
            PreconditionFailed = 35,

            /// <summary>
            /// Enum RequestEntityTooLarge for value: RequestEntityTooLarge
            /// </summary>
            [EnumMember(Value = "RequestEntityTooLarge")]
            RequestEntityTooLarge = 36,

            /// <summary>
            /// Enum RequestUriTooLong for value: RequestUriTooLong
            /// </summary>
            [EnumMember(Value = "RequestUriTooLong")]
            RequestUriTooLong = 37,

            /// <summary>
            /// Enum UnsupportedMediaType for value: UnsupportedMediaType
            /// </summary>
            [EnumMember(Value = "UnsupportedMediaType")]
            UnsupportedMediaType = 38,

            /// <summary>
            /// Enum RequestedRangeNotSatisfiable for value: RequestedRangeNotSatisfiable
            /// </summary>
            [EnumMember(Value = "RequestedRangeNotSatisfiable")]
            RequestedRangeNotSatisfiable = 39,

            /// <summary>
            /// Enum ExpectationFailed for value: ExpectationFailed
            /// </summary>
            [EnumMember(Value = "ExpectationFailed")]
            ExpectationFailed = 40,

            /// <summary>
            /// Enum UpgradeRequired for value: UpgradeRequired
            /// </summary>
            [EnumMember(Value = "UpgradeRequired")]
            UpgradeRequired = 41,

            /// <summary>
            /// Enum InternalServerError for value: InternalServerError
            /// </summary>
            [EnumMember(Value = "InternalServerError")]
            InternalServerError = 42,

            /// <summary>
            /// Enum NotImplemented for value: NotImplemented
            /// </summary>
            [EnumMember(Value = "NotImplemented")]
            NotImplemented = 43,

            /// <summary>
            /// Enum BadGateway for value: BadGateway
            /// </summary>
            [EnumMember(Value = "BadGateway")]
            BadGateway = 44,

            /// <summary>
            /// Enum ServiceUnavailable for value: ServiceUnavailable
            /// </summary>
            [EnumMember(Value = "ServiceUnavailable")]
            ServiceUnavailable = 45,

            /// <summary>
            /// Enum GatewayTimeout for value: GatewayTimeout
            /// </summary>
            [EnumMember(Value = "GatewayTimeout")]
            GatewayTimeout = 46,

            /// <summary>
            /// Enum HttpVersionNotSupported for value: HttpVersionNotSupported
            /// </summary>
            [EnumMember(Value = "HttpVersionNotSupported")]
            HttpVersionNotSupported = 47

        }


        /// <summary>
        /// Gets or Sets StatusCode
        /// </summary>
        [DataMember(Name = "StatusCode", EmitDefaultValue = false)]
        public StatusCodeEnum? StatusCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SCAmazonRuntimeInternalErrorResponse" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="code">code.</param>
        /// <param name="message">message.</param>
        /// <param name="requestId">requestId.</param>
        /// <param name="innerException">innerException.</param>
        /// <param name="statusCode">statusCode.</param>
        public SCAmazonRuntimeInternalErrorResponse(TypeEnum? type = default(TypeEnum?), string code = default(string), string message = default(string), string requestId = default(string), Object innerException = default(Object), StatusCodeEnum? statusCode = default(StatusCodeEnum?))
        {
            this.Type = type;
            this.Code = code;
            this.Message = message;
            this.RequestId = requestId;
            this.InnerException = innerException;
            this.StatusCode = statusCode;
        }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "Code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "Message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets RequestId
        /// </summary>
        [DataMember(Name = "RequestId", EmitDefaultValue = false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Gets or Sets InnerException
        /// </summary>
        [DataMember(Name = "InnerException", EmitDefaultValue = false)]
        public Object InnerException { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCAmazonRuntimeInternalErrorResponse {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  InnerException: ").Append(InnerException).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
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
            return this.Equals(input as SCAmazonRuntimeInternalErrorResponse);
        }

        /// <summary>
        /// Returns true if SCAmazonRuntimeInternalErrorResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SCAmazonRuntimeInternalErrorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCAmazonRuntimeInternalErrorResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.InnerException == input.InnerException ||
                    (this.InnerException != null &&
                    this.InnerException.Equals(input.InnerException))
                ) && 
                (
                    this.StatusCode == input.StatusCode ||
                    this.StatusCode.Equals(input.StatusCode)
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.RequestId != null)
                {
                    hashCode = (hashCode * 59) + this.RequestId.GetHashCode();
                }
                if (this.InnerException != null)
                {
                    hashCode = (hashCode * 59) + this.InnerException.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.StatusCode.GetHashCode();
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