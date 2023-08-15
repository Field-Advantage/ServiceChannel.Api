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
    /// Object details of the added payment.
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.Invoices.AddInvoicePaymentResponse")]
    public partial class SCServiceChannelServicesMessagingInvoicesAddInvoicePaymentResponse : IEquatable<SCServiceChannelServicesMessagingInvoicesAddInvoicePaymentResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingInvoicesAddInvoicePaymentResponse" /> class.
        /// </summary>
        /// <param name="paymentDate">Date and time when the specified invoice is paid..</param>
        /// <param name="paymentId">Unique numeric invoice payment ID..</param>
        /// <param name="error">error.</param>
        /// <param name="invoiceId">Unique numeric invoice identifier..</param>
        /// <param name="paymentNumber">Number provided by a user when adding a payment record..</param>
        /// <param name="paymentAmount">Amount of the payment. Cannot exceed the total amount of the invoice. If it’s a credited invoice, a single payment is required with a minus before the payment amount..</param>
        public SCServiceChannelServicesMessagingInvoicesAddInvoicePaymentResponse(DateTime paymentDate = default(DateTime), int paymentId = default(int), SCServiceChannelServicesMessagingInvoicesResponseError error = default(SCServiceChannelServicesMessagingInvoicesResponseError), int invoiceId = default(int), string paymentNumber = default(string), double paymentAmount = default(double))
        {
            this.PaymentDate = paymentDate;
            this.PaymentId = paymentId;
            this.Error = error;
            this.InvoiceId = invoiceId;
            this.PaymentNumber = paymentNumber;
            this.PaymentAmount = paymentAmount;
        }

        /// <summary>
        /// Date and time when the specified invoice is paid.
        /// </summary>
        /// <value>Date and time when the specified invoice is paid.</value>
        [DataMember(Name = "PaymentDate", EmitDefaultValue = false)]
        public DateTime PaymentDate { get; set; }

        /// <summary>
        /// Unique numeric invoice payment ID.
        /// </summary>
        /// <value>Unique numeric invoice payment ID.</value>
        [DataMember(Name = "PaymentId", EmitDefaultValue = false)]
        public int PaymentId { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "Error", EmitDefaultValue = false)]
        public SCServiceChannelServicesMessagingInvoicesResponseError Error { get; set; }

        /// <summary>
        /// Unique numeric invoice identifier.
        /// </summary>
        /// <value>Unique numeric invoice identifier.</value>
        [DataMember(Name = "InvoiceId", EmitDefaultValue = false)]
        public int InvoiceId { get; set; }

        /// <summary>
        /// Number provided by a user when adding a payment record.
        /// </summary>
        /// <value>Number provided by a user when adding a payment record.</value>
        [DataMember(Name = "PaymentNumber", EmitDefaultValue = false)]
        public string PaymentNumber { get; set; }

        /// <summary>
        /// Amount of the payment. Cannot exceed the total amount of the invoice. If it’s a credited invoice, a single payment is required with a minus before the payment amount.
        /// </summary>
        /// <value>Amount of the payment. Cannot exceed the total amount of the invoice. If it’s a credited invoice, a single payment is required with a minus before the payment amount.</value>
        [DataMember(Name = "PaymentAmount", EmitDefaultValue = false)]
        public double PaymentAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingInvoicesAddInvoicePaymentResponse {\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
            sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
            sb.Append("  PaymentNumber: ").Append(PaymentNumber).Append("\n");
            sb.Append("  PaymentAmount: ").Append(PaymentAmount).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingInvoicesAddInvoicePaymentResponse);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingInvoicesAddInvoicePaymentResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingInvoicesAddInvoicePaymentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingInvoicesAddInvoicePaymentResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PaymentDate == input.PaymentDate ||
                    (this.PaymentDate != null &&
                    this.PaymentDate.Equals(input.PaymentDate))
                ) && 
                (
                    this.PaymentId == input.PaymentId ||
                    this.PaymentId.Equals(input.PaymentId)
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.InvoiceId == input.InvoiceId ||
                    this.InvoiceId.Equals(input.InvoiceId)
                ) && 
                (
                    this.PaymentNumber == input.PaymentNumber ||
                    (this.PaymentNumber != null &&
                    this.PaymentNumber.Equals(input.PaymentNumber))
                ) && 
                (
                    this.PaymentAmount == input.PaymentAmount ||
                    this.PaymentAmount.Equals(input.PaymentAmount)
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
                if (this.PaymentDate != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PaymentId.GetHashCode();
                if (this.Error != null)
                {
                    hashCode = (hashCode * 59) + this.Error.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InvoiceId.GetHashCode();
                if (this.PaymentNumber != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentNumber.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PaymentAmount.GetHashCode();
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
