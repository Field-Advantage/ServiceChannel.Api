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
    /// Object containing the details of the location note.
    /// </summary>
    [DataContract]
    public class SCServiceChannelServicesMessagingLocationNoteUpdateLocationNoteHeaderApiModelRequest : IEquatable<SCServiceChannelServicesMessagingLocationNoteUpdateLocationNoteHeaderApiModelRequest>
    {
        /// <summary>
        /// Name of the existing location note to add, update or delete a note for. The maximum length is 100 characters.
        /// </summary>
        /// <value>Name of the existing location note to add, update or delete a note for. The maximum length is 100 characters.</value>
        [DataMember(Name="Header", EmitDefaultValue=false)]
        public string Header { get; set; }

        /// <summary>
        /// Text of the note a user wants to replace the existing note with. The maximum length is 7000 characters including spaces.
        /// </summary>
        /// <value>Text of the note a user wants to replace the existing note with. The maximum length is 7000 characters including spaces.</value>
        [DataMember(Name="Value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingLocationNoteUpdateLocationNoteHeaderApiModelRequest {\n");
            sb.Append("  Header: ").Append(Header).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingLocationNoteUpdateLocationNoteHeaderApiModelRequest)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingLocationNoteUpdateLocationNoteHeaderApiModelRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingLocationNoteUpdateLocationNoteHeaderApiModelRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingLocationNoteUpdateLocationNoteHeaderApiModelRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Header == other.Header ||
                    Header != null &&
                    Header.Equals(other.Header)
                ) && 
                (
                    Value == other.Value ||
                    Value != null &&
                    Value.Equals(other.Value)
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
                    if (Header != null)
                    hashCode = hashCode * 59 + Header.GetHashCode();
                    if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingLocationNoteUpdateLocationNoteHeaderApiModelRequest left, SCServiceChannelServicesMessagingLocationNoteUpdateLocationNoteHeaderApiModelRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingLocationNoteUpdateLocationNoteHeaderApiModelRequest left, SCServiceChannelServicesMessagingLocationNoteUpdateLocationNoteHeaderApiModelRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
