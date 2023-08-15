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
    /// Request object to add a payment to an invoice.
    /// </summary>
    [DataContract]
    public class SCServiceChannelServicesMessagingInvoicesInvoicePaymentRequest : IEquatable<SCServiceChannelServicesMessagingInvoicesInvoicePaymentRequest>
    {
        /// <summary>
        /// Date and time when the specified invoice is paid. Cannot be a past date.
        /// </summary>
        /// <value>Date and time when the specified invoice is paid. Cannot be a past date.</value>
        [DataMember(Name="PaymentDate", EmitDefaultValue=false)]
        public DateTime PaymentDate { get; set; }

        /// <summary>
        /// Order number of payment for the invoice.
        /// </summary>
        /// <value>Order number of payment for the invoice.</value>
        [DataMember(Name="PaymentNumber", EmitDefaultValue=false)]
        public string PaymentNumber { get; set; }

        /// <summary>
        /// Amount you want to pay. Cannot exceed the invoice total amount. If it’s a credited invoice, a single payment is required with a minus before the payment amount.
        /// </summary>
        /// <value>Amount you want to pay. Cannot exceed the invoice total amount. If it’s a credited invoice, a single payment is required with a minus before the payment amount.</value>
        [DataMember(Name="PaymentAmount", EmitDefaultValue=true)]
        public double PaymentAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingInvoicesInvoicePaymentRequest {\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
            sb.Append("  PaymentNumber: ").Append(PaymentNumber).Append("\n");
            sb.Append("  PaymentAmount: ").Append(PaymentAmount).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SCServiceChannelServicesMessagingInvoicesInvoicePaymentRequest)obj);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingInvoicesInvoicePaymentRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SCServiceChannelServicesMessagingInvoicesInvoicePaymentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingInvoicesInvoicePaymentRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    PaymentDate == other.PaymentDate ||
                    PaymentDate != null &&
                    PaymentDate.Equals(other.PaymentDate)
                ) && 
                (
                    PaymentNumber == other.PaymentNumber ||
                    PaymentNumber != null &&
                    PaymentNumber.Equals(other.PaymentNumber)
                ) && 
                (
                    PaymentAmount == other.PaymentAmount ||
                    
                    PaymentAmount.Equals(other.PaymentAmount)
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
                    if (PaymentDate != null)
                    hashCode = hashCode * 59 + PaymentDate.GetHashCode();
                    if (PaymentNumber != null)
                    hashCode = hashCode * 59 + PaymentNumber.GetHashCode();
                    
                    hashCode = hashCode * 59 + PaymentAmount.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SCServiceChannelServicesMessagingInvoicesInvoicePaymentRequest left, SCServiceChannelServicesMessagingInvoicesInvoicePaymentRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SCServiceChannelServicesMessagingInvoicesInvoicePaymentRequest left, SCServiceChannelServicesMessagingInvoicesInvoicePaymentRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
