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
    /// Object containing the list of the invoice charges.
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.Invoices.InvoiceAmountsDetails")]
    public partial class SCServiceChannelServicesMessagingInvoicesInvoiceAmountsDetails : IEquatable<SCServiceChannelServicesMessagingInvoicesInvoiceAmountsDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingInvoicesInvoiceAmountsDetails" /> class.
        /// </summary>
        /// <param name="laborAmount">Amount of the labor charge. Must equal &#x60;Labors.Amount&#x60;..</param>
        /// <param name="materialAmount">Amount of the material charge. Must equal &#x60;Materials.Amount&#x60;..</param>
        /// <param name="travelAmount">Amount of the trip charge..</param>
        /// <param name="freightAmount">Amount of the freight charge..</param>
        /// <param name="otherAmount">Amount of other charges. When you add this parameter, also specify &#x60;InvoiceAmountsDetails.OtherDescription&#x60;..</param>
        /// <param name="otherDescription">otherDescription.</param>
        public SCServiceChannelServicesMessagingInvoicesInvoiceAmountsDetails(double laborAmount = default(double), double materialAmount = default(double), double travelAmount = default(double), double freightAmount = default(double), double otherAmount = default(double), string otherDescription = default(string))
        {
            this.LaborAmount = laborAmount;
            this.MaterialAmount = materialAmount;
            this.TravelAmount = travelAmount;
            this.FreightAmount = freightAmount;
            this.OtherAmount = otherAmount;
            this.OtherDescription = otherDescription;
        }

        /// <summary>
        /// Amount of the labor charge. Must equal &#x60;Labors.Amount&#x60;.
        /// </summary>
        /// <value>Amount of the labor charge. Must equal &#x60;Labors.Amount&#x60;.</value>
        [DataMember(Name = "LaborAmount", EmitDefaultValue = false)]
        public double LaborAmount { get; set; }

        /// <summary>
        /// Amount of the material charge. Must equal &#x60;Materials.Amount&#x60;.
        /// </summary>
        /// <value>Amount of the material charge. Must equal &#x60;Materials.Amount&#x60;.</value>
        [DataMember(Name = "MaterialAmount", EmitDefaultValue = false)]
        public double MaterialAmount { get; set; }

        /// <summary>
        /// Amount of the trip charge.
        /// </summary>
        /// <value>Amount of the trip charge.</value>
        [DataMember(Name = "TravelAmount", EmitDefaultValue = false)]
        public double TravelAmount { get; set; }

        /// <summary>
        /// Amount of the freight charge.
        /// </summary>
        /// <value>Amount of the freight charge.</value>
        [DataMember(Name = "FreightAmount", EmitDefaultValue = false)]
        public double FreightAmount { get; set; }

        /// <summary>
        /// Amount of other charges. When you add this parameter, also specify &#x60;InvoiceAmountsDetails.OtherDescription&#x60;.
        /// </summary>
        /// <value>Amount of other charges. When you add this parameter, also specify &#x60;InvoiceAmountsDetails.OtherDescription&#x60;.</value>
        [DataMember(Name = "OtherAmount", EmitDefaultValue = false)]
        public double OtherAmount { get; set; }

        /// <summary>
        /// Gets or Sets OtherDescription
        /// </summary>
        [DataMember(Name = "OtherDescription", EmitDefaultValue = false)]
        public string OtherDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingInvoicesInvoiceAmountsDetails {\n");
            sb.Append("  LaborAmount: ").Append(LaborAmount).Append("\n");
            sb.Append("  MaterialAmount: ").Append(MaterialAmount).Append("\n");
            sb.Append("  TravelAmount: ").Append(TravelAmount).Append("\n");
            sb.Append("  FreightAmount: ").Append(FreightAmount).Append("\n");
            sb.Append("  OtherAmount: ").Append(OtherAmount).Append("\n");
            sb.Append("  OtherDescription: ").Append(OtherDescription).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingInvoicesInvoiceAmountsDetails);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingInvoicesInvoiceAmountsDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingInvoicesInvoiceAmountsDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingInvoicesInvoiceAmountsDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LaborAmount == input.LaborAmount ||
                    this.LaborAmount.Equals(input.LaborAmount)
                ) && 
                (
                    this.MaterialAmount == input.MaterialAmount ||
                    this.MaterialAmount.Equals(input.MaterialAmount)
                ) && 
                (
                    this.TravelAmount == input.TravelAmount ||
                    this.TravelAmount.Equals(input.TravelAmount)
                ) && 
                (
                    this.FreightAmount == input.FreightAmount ||
                    this.FreightAmount.Equals(input.FreightAmount)
                ) && 
                (
                    this.OtherAmount == input.OtherAmount ||
                    this.OtherAmount.Equals(input.OtherAmount)
                ) && 
                (
                    this.OtherDescription == input.OtherDescription ||
                    (this.OtherDescription != null &&
                    this.OtherDescription.Equals(input.OtherDescription))
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
                hashCode = (hashCode * 59) + this.LaborAmount.GetHashCode();
                hashCode = (hashCode * 59) + this.MaterialAmount.GetHashCode();
                hashCode = (hashCode * 59) + this.TravelAmount.GetHashCode();
                hashCode = (hashCode * 59) + this.FreightAmount.GetHashCode();
                hashCode = (hashCode * 59) + this.OtherAmount.GetHashCode();
                if (this.OtherDescription != null)
                {
                    hashCode = (hashCode * 59) + this.OtherDescription.GetHashCode();
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