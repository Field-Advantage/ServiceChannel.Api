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
    /// SCServiceChannelServicesMessagingInvoicesInvoiceDiscrepancy
    /// </summary>
    [DataContract(Name = "ServiceChannel.Services.Messaging.Invoices.InvoiceDiscrepancy")]
    public partial class SCServiceChannelServicesMessagingInvoicesInvoiceDiscrepancy : IEquatable<SCServiceChannelServicesMessagingInvoicesInvoiceDiscrepancy>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCServiceChannelServicesMessagingInvoicesInvoiceDiscrepancy" /> class.
        /// </summary>
        /// <param name="laborRateDiscrepancies">laborRateDiscrepancies.</param>
        /// <param name="materialMarkupDiscrepancies">materialMarkupDiscrepancies.</param>
        /// <param name="otherPriceDiscrepancies">Get or set OtherPriceDiscrepancies.</param>
        public SCServiceChannelServicesMessagingInvoicesInvoiceDiscrepancy(List<SCServiceChannelServicesMessagingInvoicesRateDiscrepancy> laborRateDiscrepancies = default(List<SCServiceChannelServicesMessagingInvoicesRateDiscrepancy>), List<SCServiceChannelServicesMessagingInvoicesMaterialMarkupDiscrepancy> materialMarkupDiscrepancies = default(List<SCServiceChannelServicesMessagingInvoicesMaterialMarkupDiscrepancy>), List<SCServiceChannelServicesMessagingInvoicesOtherPriceDiscrepancy> otherPriceDiscrepancies = default(List<SCServiceChannelServicesMessagingInvoicesOtherPriceDiscrepancy>))
        {
            this.LaborRateDiscrepancies = laborRateDiscrepancies;
            this.MaterialMarkupDiscrepancies = materialMarkupDiscrepancies;
            this.OtherPriceDiscrepancies = otherPriceDiscrepancies;
        }

        /// <summary>
        /// Gets or Sets LaborRateDiscrepancies
        /// </summary>
        [DataMember(Name = "LaborRateDiscrepancies", EmitDefaultValue = false)]
        public List<SCServiceChannelServicesMessagingInvoicesRateDiscrepancy> LaborRateDiscrepancies { get; set; }

        /// <summary>
        /// Gets or Sets MaterialMarkupDiscrepancies
        /// </summary>
        [DataMember(Name = "MaterialMarkupDiscrepancies", EmitDefaultValue = false)]
        public List<SCServiceChannelServicesMessagingInvoicesMaterialMarkupDiscrepancy> MaterialMarkupDiscrepancies { get; set; }

        /// <summary>
        /// Get or set OtherPriceDiscrepancies
        /// </summary>
        /// <value>Get or set OtherPriceDiscrepancies</value>
        [DataMember(Name = "OtherPriceDiscrepancies", EmitDefaultValue = false)]
        public List<SCServiceChannelServicesMessagingInvoicesOtherPriceDiscrepancy> OtherPriceDiscrepancies { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SCServiceChannelServicesMessagingInvoicesInvoiceDiscrepancy {\n");
            sb.Append("  LaborRateDiscrepancies: ").Append(LaborRateDiscrepancies).Append("\n");
            sb.Append("  MaterialMarkupDiscrepancies: ").Append(MaterialMarkupDiscrepancies).Append("\n");
            sb.Append("  OtherPriceDiscrepancies: ").Append(OtherPriceDiscrepancies).Append("\n");
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
            return this.Equals(input as SCServiceChannelServicesMessagingInvoicesInvoiceDiscrepancy);
        }

        /// <summary>
        /// Returns true if SCServiceChannelServicesMessagingInvoicesInvoiceDiscrepancy instances are equal
        /// </summary>
        /// <param name="input">Instance of SCServiceChannelServicesMessagingInvoicesInvoiceDiscrepancy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SCServiceChannelServicesMessagingInvoicesInvoiceDiscrepancy input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LaborRateDiscrepancies == input.LaborRateDiscrepancies ||
                    this.LaborRateDiscrepancies != null &&
                    input.LaborRateDiscrepancies != null &&
                    this.LaborRateDiscrepancies.SequenceEqual(input.LaborRateDiscrepancies)
                ) && 
                (
                    this.MaterialMarkupDiscrepancies == input.MaterialMarkupDiscrepancies ||
                    this.MaterialMarkupDiscrepancies != null &&
                    input.MaterialMarkupDiscrepancies != null &&
                    this.MaterialMarkupDiscrepancies.SequenceEqual(input.MaterialMarkupDiscrepancies)
                ) && 
                (
                    this.OtherPriceDiscrepancies == input.OtherPriceDiscrepancies ||
                    this.OtherPriceDiscrepancies != null &&
                    input.OtherPriceDiscrepancies != null &&
                    this.OtherPriceDiscrepancies.SequenceEqual(input.OtherPriceDiscrepancies)
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
                if (this.LaborRateDiscrepancies != null)
                {
                    hashCode = (hashCode * 59) + this.LaborRateDiscrepancies.GetHashCode();
                }
                if (this.MaterialMarkupDiscrepancies != null)
                {
                    hashCode = (hashCode * 59) + this.MaterialMarkupDiscrepancies.GetHashCode();
                }
                if (this.OtherPriceDiscrepancies != null)
                {
                    hashCode = (hashCode * 59) + this.OtherPriceDiscrepancies.GetHashCode();
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