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
    /// AddStripeCharge request
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.Workorders.AddStripeChargeRequest")]
    public partial class SCServiceChannelServicesMessagingWorkordersAddStripeChargeRequest : IEquatable<SCServiceChannelServicesMessagingWorkordersAddStripeChargeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingWorkordersAddStripeChargeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SCServiceChannelServicesMessagingWorkordersAddStripeChargeRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingWorkordersAddStripeChargeRequest" /> class.
        /// </summary>
        /// <param name="tokenId">Id of the token returned by stripe api {!:https://stripe.com/docs/} (required).</param>
        /// <param name="amount">Amount to charge (required).</param>
        /// <param name="currency">Currency (required).</param>
        public SCServiceChannelServicesMessagingWorkordersAddStripeChargeRequest(string tokenId = default(string), double amount = default(double), string currency = default(string))
        {
            // to ensure "tokenId" is required (not null)
            if (tokenId == null)
            {
                throw new ArgumentNullException("tokenId is a required property for SCServiceChannelServicesMessagingWorkordersAddStripeChargeRequest and cannot be null");
            }
            this.TokenId = tokenId;
            this.Amount = amount;
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for SCServiceChannelServicesMessagingWorkordersAddStripeChargeRequest and cannot be null");
            }
            this.Currency = currency;
        }

        /// <summary>
        /// Id of the token returned by stripe api {!:https://stripe.com/docs/}
        /// </summary>
        /// <value>Id of the token returned by stripe api {!:https://stripe.com/docs/}</value>
        [DataMember(Name = "TokenId", IsRequired = true, EmitDefaultValue = true)]
        public string TokenId { get; set; }

        /// <summary>
        /// Amount to charge
        /// </summary>
        /// <value>Amount to charge</value>
        [DataMember(Name = "Amount", IsRequired = true, EmitDefaultValue = true)]
        public double Amount { get; set; }

        /// <summary>
        /// Currency
        /// </summary>
        /// <value>Currency</value>
        [DataMember(Name = "Currency", IsRequired = true, EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingWorkordersAddStripeChargeRequest {\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingWorkordersAddStripeChargeRequest);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingWorkordersAddStripeChargeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingWorkordersAddStripeChargeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingWorkordersAddStripeChargeRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TokenId == input.TokenId ||
                    (this.TokenId != null &&
                    this.TokenId.Equals(input.TokenId))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
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
                if (this.TokenId != null)
                {
                    hashCode = (hashCode * 59) + this.TokenId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
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