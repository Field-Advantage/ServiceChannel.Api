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
    /// AddUserRequest class definition
    /// </summary>
    [DataContract]
    public class SCServiceChannelServicesMessagingUsersAddUserRequest : IEquatable<SCServiceChannelServicesMessagingUsersAddUserRequest>
    {
        /// <summary>
        /// Gets or sets User name.
        /// </summary>
        /// <value>Gets or sets User name.</value>
        [RegularExpression("^$|(\\A\\S+).(\\S).(\\S)\\z")]
        [DataMember(Name="UserName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// Get or set User&#39;s identifier (id)
        /// </summary>
        /// <value>Get or set User&#39;s identifier (id)</value>
        [DataMember(Name="Id", EmitDefaultValue=true)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets InfoSubscriberId.
        /// </summary>
        /// <value>Gets or sets InfoSubscriberId.</value>
        [DataMember(Name="InfoSubscriberId", EmitDefaultValue=true)]
        public int InfoSubscriberId { get; set; }

        /// <summary>
        /// Gets or sets Password.
        /// </summary>
        /// <value>Gets or sets Password.</value>
        [DataMember(Name="Password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets Email.
        /// </summary>
        /// <value>Gets or sets Email.</value>
        [DataMember(Name="Email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets LocationAccess.
        /// </summary>
        /// <value>Gets or sets LocationAccess.</value>
        [DataMember(Name="LocationAccess", EmitDefaultValue=false)]
        public string LocationAccess { get; set; }

        /// <summary>
        /// Gets or sets FeedRole.
        /// </summary>
        /// <value>Gets or sets FeedRole.</value>
        [DataMember(Name="FeedRole", EmitDefaultValue=false)]
        public string FeedRole { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="User", EmitDefaultValue=false)]
        public SCServiceChannelServicesMessagingUsersUser User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingUsersAddUserRequest {\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InfoSubscriberId: ").Append(InfoSubscriberId).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  LocationAccess: ").Append(LocationAccess).Append("\n");
            sb.Append("  FeedRole: ").Append(FeedRole).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingUsersAddUserRequest)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingUsersAddUserRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingUsersAddUserRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingUsersAddUserRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    UserName == other.UserName ||
                    UserName != null &&
                    UserName.Equals(other.UserName)
                ) && 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    InfoSubscriberId == other.InfoSubscriberId ||
                    
                    InfoSubscriberId.Equals(other.InfoSubscriberId)
                ) && 
                (
                    Password == other.Password ||
                    Password != null &&
                    Password.Equals(other.Password)
                ) && 
                (
                    Email == other.Email ||
                    Email != null &&
                    Email.Equals(other.Email)
                ) && 
                (
                    LocationAccess == other.LocationAccess ||
                    LocationAccess != null &&
                    LocationAccess.Equals(other.LocationAccess)
                ) && 
                (
                    FeedRole == other.FeedRole ||
                    FeedRole != null &&
                    FeedRole.Equals(other.FeedRole)
                ) && 
                (
                    User == other.User ||
                    User != null &&
                    User.Equals(other.User)
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
                    if (UserName != null)
                    hashCode = hashCode * 59 + UserName.GetHashCode();
                    
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    
                    hashCode = hashCode * 59 + InfoSubscriberId.GetHashCode();
                    if (Password != null)
                    hashCode = hashCode * 59 + Password.GetHashCode();
                    if (Email != null)
                    hashCode = hashCode * 59 + Email.GetHashCode();
                    if (LocationAccess != null)
                    hashCode = hashCode * 59 + LocationAccess.GetHashCode();
                    if (FeedRole != null)
                    hashCode = hashCode * 59 + FeedRole.GetHashCode();
                    if (User != null)
                    hashCode = hashCode * 59 + User.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingUsersAddUserRequest left, SCServiceChannelServicesMessagingUsersAddUserRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingUsersAddUserRequest left, SCServiceChannelServicesMessagingUsersAddUserRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
