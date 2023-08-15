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
    public class SCServiceChannelServicesMessagingFeedbackFeedbacksForReviewRequest : IEquatable<SCServiceChannelServicesMessagingFeedbackFeedbacksForReviewRequest>
    {
        /// <summary>
        /// LocationId
        /// </summary>
        /// <value>LocationId</value>
        [DataMember(Name="LocationId", EmitDefaultValue=true)]
        public int LocationId { get; set; }

        /// <summary>
        /// Dashboard setupId (optional)
        /// </summary>
        /// <value>Dashboard setupId (optional)</value>
        [DataMember(Name="SetupId", EmitDefaultValue=true)]
        public int SetupId { get; set; }


        /// <summary>
        /// Order by field
        /// </summary>
        /// <value>Order by field</value>
        
        public enum OrderByFieldEnum
        {
            
            /// <summary>
            /// Enum TrackingNumberEnum for TrackingNumber
            /// </summary>
            [EnumMember(Value = "TrackingNumber")]
            TrackingNumberEnum = 1,
            
            /// <summary>
            /// Enum TradeEnum for Trade
            /// </summary>
            [EnumMember(Value = "Trade")]
            TradeEnum = 2,
            
            /// <summary>
            /// Enum ScheduledDateEnum for ScheduledDate
            /// </summary>
            [EnumMember(Value = "ScheduledDate")]
            ScheduledDateEnum = 3,
            
            /// <summary>
            /// Enum VendorEnum for Vendor
            /// </summary>
            [EnumMember(Value = "Vendor")]
            VendorEnum = 4,
            
            /// <summary>
            /// Enum PriorityEnum for Priority
            /// </summary>
            [EnumMember(Value = "Priority")]
            PriorityEnum = 5,
            
            /// <summary>
            /// Enum CallerEnum for Caller
            /// </summary>
            [EnumMember(Value = "Caller")]
            CallerEnum = 6,
            
            /// <summary>
            /// Enum StatusEnum for Status
            /// </summary>
            [EnumMember(Value = "Status")]
            StatusEnum = 7,
            
            /// <summary>
            /// Enum AreaEnum for Area
            /// </summary>
            [EnumMember(Value = "Area")]
            AreaEnum = 8,
            
            /// <summary>
            /// Enum ComplitionDateEnum for ComplitionDate
            /// </summary>
            [EnumMember(Value = "ComplitionDate")]
            ComplitionDateEnum = 9,
            
            /// <summary>
            /// Enum FeedbackLeftEnum for FeedbackLeft
            /// </summary>
            [EnumMember(Value = "FeedbackLeft")]
            FeedbackLeftEnum = 10
        }

        /// <summary>
        /// Order by field
        /// </summary>
        /// <value>Order by field</value>
        [DataMember(Name="OrderByField", EmitDefaultValue=true)]
        public OrderByFieldEnum OrderByField { get; set; }


        /// <summary>
        /// Order direction
        /// </summary>
        /// <value>Order direction</value>
        
        public enum OrderDirectionEnum
        {
            
            /// <summary>
            /// Enum AscendingEnum for Ascending
            /// </summary>
            [EnumMember(Value = "Ascending")]
            AscendingEnum = 1,
            
            /// <summary>
            /// Enum DescendingEnum for Descending
            /// </summary>
            [EnumMember(Value = "Descending")]
            DescendingEnum = 2
        }

        /// <summary>
        /// Order direction
        /// </summary>
        /// <value>Order direction</value>
        [DataMember(Name="OrderDirection", EmitDefaultValue=true)]
        public OrderDirectionEnum OrderDirection { get; set; }

        /// <summary>
        /// Activates filter by current user id
        /// </summary>
        /// <value>Activates filter by current user id</value>
        [DataMember(Name="ShowMyWorkOrders", EmitDefaultValue=true)]
        public bool ShowMyWorkOrders { get; set; } = false;

        /// <summary>
        /// Subscriber Id
        /// </summary>
        /// <value>Subscriber Id</value>
        [DataMember(Name="SubscriberId", EmitDefaultValue=true)]
        public int SubscriberId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingFeedbackFeedbacksForReviewRequest {\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  SetupId: ").Append(SetupId).Append("\n");
            sb.Append("  OrderByField: ").Append(OrderByField).Append("\n");
            sb.Append("  OrderDirection: ").Append(OrderDirection).Append("\n");
            sb.Append("  ShowMyWorkOrders: ").Append(ShowMyWorkOrders).Append("\n");
            sb.Append("  SubscriberId: ").Append(SubscriberId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingFeedbackFeedbacksForReviewRequest)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingFeedbackFeedbacksForReviewRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingFeedbackFeedbacksForReviewRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingFeedbackFeedbacksForReviewRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    LocationId == other.LocationId ||
                    
                    LocationId.Equals(other.LocationId)
                ) && 
                (
                    SetupId == other.SetupId ||
                    
                    SetupId.Equals(other.SetupId)
                ) && 
                (
                    OrderByField == other.OrderByField ||
                    
                    OrderByField.Equals(other.OrderByField)
                ) && 
                (
                    OrderDirection == other.OrderDirection ||
                    
                    OrderDirection.Equals(other.OrderDirection)
                ) && 
                (
                    ShowMyWorkOrders == other.ShowMyWorkOrders ||
                    
                    ShowMyWorkOrders.Equals(other.ShowMyWorkOrders)
                ) && 
                (
                    SubscriberId == other.SubscriberId ||
                    
                    SubscriberId.Equals(other.SubscriberId)
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
                    
                    hashCode = hashCode * 59 + LocationId.GetHashCode();
                    
                    hashCode = hashCode * 59 + SetupId.GetHashCode();
                    
                    hashCode = hashCode * 59 + OrderByField.GetHashCode();
                    
                    hashCode = hashCode * 59 + OrderDirection.GetHashCode();
                    
                    hashCode = hashCode * 59 + ShowMyWorkOrders.GetHashCode();
                    
                    hashCode = hashCode * 59 + SubscriberId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingFeedbackFeedbacksForReviewRequest left, SCServiceChannelServicesMessagingFeedbackFeedbacksForReviewRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingFeedbackFeedbacksForReviewRequest left, SCServiceChannelServicesMessagingFeedbackFeedbacksForReviewRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
