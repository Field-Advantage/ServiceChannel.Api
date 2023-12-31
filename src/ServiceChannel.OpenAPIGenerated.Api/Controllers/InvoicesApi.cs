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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ServiceChannel.OpenAPIGenerated.Api.Attributes;
using ServiceChannel.OpenAPIGenerated.Api.Models;

namespace ServiceChannel.OpenAPIGenerated.Api.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public abstract class InvoicesApiController : ControllerBase
    { 
        /// <summary>
        /// Retrieve Invoices
        /// </summary>
        /// <remarks>Returns a list of invoices posted within the last 90 days if not specified otherwise in &#x60;$filter&#x60;. The maximum date range between the invoice &#x60;PostedDate&#x60; and the current date is 365 days.</remarks>
        /// <param name="expand">Expand a navigation property.</param>
        /// <param name="select">Select a set of properties to return.</param>
        /// <param name="filter">Filter a collection of resources addressed by a request URL.</param>
        /// <param name="orderby">Order resources by the specified property in the response.</param>
        /// <param name="top">Return the specified number of items in the response.</param>
        /// <param name="skip">Skip the specified number of items in the response.</param>
        /// <param name="count">Include the count of the matching resources in the response.</param>
        /// <response code="200">The requested invoices are in the response.</response>
        [HttpGet]
        [Route("/v3/odata/invoices")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<SCServiceChannelServicesMessagingInvoicesInvoice>))]
        public abstract Task<IActionResult> GetInvoices([FromQuery (Name = "$expand")]string? expand, [FromQuery (Name = "$select")]string? select, [FromQuery (Name = "$filter")]string? filter, [FromQuery (Name = "$orderby")]string? orderby, [FromQuery (Name = "$top")]int? top, [FromQuery (Name = "$skip")]int? skip, [FromQuery (Name = "$count")]bool? count);

        /// <summary>
        /// Add an invoice to a work order
        /// </summary>
        /// <remarks>Creates an invoice in the *Open* status for the specified work order.              &lt;br /&gt;Find out more about [creating an invoice](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/2205811424/Creating+an+Invoice) in ServiceChannel University.</remarks>
        /// <param name="request">Request model to create an invoice for the specified work order.              &lt;br /&gt;**Required parameters**:               • **InvoiceNumber**. Invoice number created by a user.               • **WoIdentifier**. Unique work order identifier (can be *TrackingNumber* or *WorkOrderNumber* for Contractor and *TrackingNumber* or *PurchaseNumber* for Client).              &lt;br /&gt;If there is no need to specify any details in *Labors*, *Materials*, *Travels*, and *Others* objects, you can send the request without them.               &lt;br /&gt;**Note**: Work Order should be in the *Completed* status to successfully create an invoice.</param>
        /// <response code="201">The ID of the created invoice is in the response.</response>
        /// <response code="400">The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              503 — Request should not be null              601 — Location not found              607 — Empty Location State              904 — Invalid WO Status. WO must be in &#39;COMPLETED&#39; status with empty extended status or &#39;COMPLETED&#39; status with &#39;CONFIRMED&#39; extended status              914 — Invalid &#39;Currency&#39; value              917 — Invalid Tracking Number              1100 — Invalid Other Amount Description              1101 — Invalid Tax2 name              1103 — Invalid Total              1104 — Invoice Total &gt; NTE              1105 — Invoice exists              1106 — Invoice Creation Error              1107 — Duplicate Invoice number              1108 — Total is null              1109 — Completed Date is null              1110 — Invoice Date &lt; Completed Date              1111 — This invoice is set to auto-invoice              1112 — Electronic Signature Agreement Required              1113 — Work order not found              1114 — Wrong Work Order currency              1115 — Work order currency not found              1116 — Invoicing is disabled. Invoicing might be disabled if your company account is currently in an inactive state in Fixxbook              1117 — Invoice creation Unexpected Result              1119 — Invoice labor amount is not equals summary labor items               1120 — Invoice material amount is not equals summary material items amounts              1121 — Invoice Date is older than X day(s) from today              1122 — Invoice Date is greater than X day(s) from today              1123 — Invoice material description length overflow              1124 — Invoice material part number length overflow              1125 — Tax validation error: X              1126 — Sales Tax should be 0 - X location              1127 — Invalid Invoice Number              1135 — Locations can&#39;t have GST tax              1136 — Locations can&#39;t have tax2. Only Canadian or European Location can have the Tax2Details array. Tax2Details is only applicable for locations in countries that have some form of a value-added tax              1145 — You have an outstanding balance with ServiceChannel.  In order to invoice, please login to Fixxbook.com and update your Payment Method.  Once your payment Method is updated you will be able to invoice.;              1146 — Invoice doesn&#39;t have Taxes Breakdown              1147 — Invoice Taxes Breakdown has incorrect sum              1151 — Labor Line Items Required              1152 — Material Line Items Required              1159 — Invoice material unit type is invalid (should be from 1 to 7)              1163 — Resolution text required in Invoice Text field              1180 — Invoice Number is not correct              1194 - Invoice labor skill level is invalid (should be from 1 to 3)              1195 — Invoice labor type is invalid (should be from 1 to 3)              1196 — Invoice technician quantity is invalid (should be &gt; 0)              1198 — The explanation of Dispute status is empty</response>
        /// <response code="401">The request is not authorized.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions;</response>
        [HttpPost]
        [Route("/v3/invoices")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> Invoices([FromBody]SCServiceChannelServicesMessagingInvoicesCreateInvoiceRequest request);

        /// <summary>
        /// Add payment records to invoices
        /// </summary>
        /// <remarks>Creates payment records for the invoices in the *Approved* status in bulk.               &lt;br /&gt;**Note**: Method is available to users with the *SC Admin*, *Master Admin*, or *Invoice Admin* roles and with the *InvoiceChangeToPaid* feature flag enabled.               &lt;br /&gt;**Example Request**                                  POST /invoices/{invoiceId}/Payment                   {                     \&quot;Payments\&quot;: [                       {                         \&quot;InvoiceId\&quot;: 96814318,                         \&quot;PaymentDate\&quot;: \&quot;2021-12-13T06:12:22.820Z\&quot;,                         \&quot;PaymentNumber\&quot;: \&quot;456858\&quot;,                         \&quot;PaymentAmount\&quot;: 756                       },                       {                         \&quot;InvoiceId\&quot;: 4988659,                         \&quot;PaymentDate\&quot;: \&quot;2021-12-13T06:12:22.820Z\&quot;,                         \&quot;PaymentNumber\&quot;: \&quot;97027818\&quot;,                         \&quot;PaymentAmount\&quot;: 1250.55                       }                       ]                   }</remarks>
        /// <param name="request">Request model to add payment records in bulk.</param>
        /// <response code="201">The payments are successfully added.              &lt;br/&gt;Error codes:              503 — Request is invalid              1178 — Invoice cannot be paid before the invoice creation date              1178 — Invoice has already been paid              1178 — No invoice ID              1178 — Only approved invoices may be paid              1178 — Payment amount exceeds the actual invoice amount              1178 — Payment amount should be more than zero              1178 — Payment is not allowed for this subscriber              1178 — Payment number cannot exceed 100 characters</response>
        /// <response code="400">The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              503 — Request is empty or null</response>
        /// <response code="401">The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions</response>
        /// <response code="403">You are not authorized to request this resource, or the resource is unavailable for some reason.              &lt;br/&gt;Error codes:              100 — User has no permissions to perform this action</response>
        /// <response code="500">The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 — Error updating invoices payments in bulk mode</response>
        [HttpPost]
        [Route("/v3/invoices/Payments")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 201, type: typeof(SCServiceChannelServicesMessagingInvoicesInvoicePaymentBulkResponse))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> InvoicesPayments([FromBody]SCServiceChannelServicesMessagingInvoicesInvoicePaymentBulkRequest request);

        /// <summary>
        /// Checks state of a service for invoice.
        /// </summary>
        /// <remarks>The method allow check some service for invoice for availability state.&lt;br /&gt;Responses: &#39;Success&#39; or &#39;Fail&#39;.</remarks>
        /// <param name="serviceName">Service Name identifier: The value of parameter is &#39;TWUtilityManager&#39; or &#39;TWCalculationManager&#39;  in currently.</param>
        /// <response code="200">Indicates that the request succeeded. Specified service is available.</response>
        /// <response code="400">Indicates that the request failed. Action parameter is mismatched or missed.</response>
        /// <response code="401">An unauthorized request.</response>
        /// <response code="503">Indicates that the request failed. Specified service is unavailable.</response>
        [HttpGet]
        [Route("/v3/invoices/ping/{serviceName}")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        [ProducesResponseType(statusCode: 400, type: typeof(Object))]
        public abstract Task<IActionResult> InvoicesPingserviceName([FromRoute (Name = "serviceName")][Required]string serviceName);

        /// <summary>
        /// Retrieve statistics of all invoices
        /// </summary>
        /// <remarks>Retrieves statistics of all invoices. Returns the statistics of all invoices for successful request.              &lt;br /&gt;&lt;br /&gt;Only for providers usage.</remarks>
        /// <param name="daysPeriod">Period in days, last X days for which Invoices statistics was collected (30 by Default).</param>
        /// <param name="approvedInThePastDaysPeriod">Period in days, last X days during which Invoices are approved (3 by Default).</param>
        /// <response code="200">Indicates that the request succeeded and that the requested information is in the response.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 503 - Only for providers usage;</response>
        /// <response code="401">Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions;</response>
        [HttpGet]
        [Route("/v3/invoices/statistics")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(SCServiceChannelServicesMessagingInvoicesInvoiceStatisticsResponse))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> InvoicesStatisticsdaysPerioddaysPeriodapprovedInThePastDaysPeriodapprovedInThePastDaysPeriod([FromQuery (Name = "daysPeriod")]int? daysPeriod, [FromQuery (Name = "approvedInThePastDaysPeriod")]int? approvedInThePastDaysPeriod);

        /// <summary>
        /// Add a payment record to an invoice by a tracking number
        /// </summary>
        /// <remarks>Creates a payment record for the invoice in the *Approved* status by specifying the tracking number of the work order the invoice was created for.              &lt;br /&gt;Learn [how subscribers can mark invoices as paid](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/621936646/Marking+Invoices+as+Paid) in ServiceChannel University.</remarks>
        /// <param name="trackingNumber">Tracking number of the work order you want to add the invoice payment record for.</param>
        /// <param name="payment">Invoice payment record request model.</param>
        /// <response code="204">The payment record is added to a particular invoice created for the specified work order. </response>
        /// <response code="400">The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt; Error codes:              503 — Request is invalid              1178 — Invoice cannot be paid before invoice dates              1178 — Invoice has already  paid              1178 — Only approved invoices may pay              1178 — Payment amount exceeds the actual amount              1178 — Payment amount should be more than zero              1178 — Pay not allowed for this subscriber              2602 — Invalid WO Tracking Number</response>
        /// <response code="401">The request is not authorized.              &lt;br/&gt; Error codes:              504 — API call rejected by security permissions</response>
        /// <response code="403">You are not authorized to request this resource, or the resource is unavailable for some reason.              &lt;br/&gt; Error codes:              100 — User has no rights to perform this action</response>
        [HttpPost]
        [Route("/v3/invoices/Workorders/{trackingNumber}/Payment")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> InvoicesWorkorderstrackingNumberPayment([FromRoute (Name = "trackingNumber")][Required]int trackingNumber, [FromBody]SCServiceChannelServicesMessagingInvoicesInvoicePaymentRequest payment);

        /// <summary>
        /// Get an invoice
        /// </summary>
        /// <remarks>Returns the details of the specified invoice.</remarks>
        /// <param name="invoiceId">Numeric identifier of the invoice to get the details for.</param>
        /// <response code="200">The specified invoice is in the response.</response>
        /// <response code="400">The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.</response>
        /// <response code="401">The request is not authorized.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 — API call rejected by security permissions</response>
        /// <response code="404">The requested resource does not exist on the server.</response>
        [HttpGet]
        [Route("/v3/invoices/{invoiceId}")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(SCServiceChannelServicesMessagingInvoicesApiGetInvoiceResponse))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> InvoicesinvoiceId([FromRoute (Name = "invoiceId")][Required]int invoiceId);

        /// <summary>
        /// Allows approve non-MLI(Multilevel Invoice Approval) invoice
        /// </summary>
        /// <remarks>&lt;para&gt;Allows approve non-MLI(Multilevel Invoice Approval) invoice&lt;/para&gt;</remarks>
        /// <param name="invoiceId">Invoice Identifier</param>
        /// <param name="approvalCode">Approval Code</param>
        /// <param name="comments">Comments</param>
        /// <param name="category">Category</param>
        /// <response code="204">Indicates that the request succeeded</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 502 - Wrong Invoice Id              &lt;br/&gt; 503 - MLI(Multilevel Invoice Approval) enabled</response>
        /// <response code="401">Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br&gt; 504 - API call rejected by security permissions;</response>
        [HttpPut]
        [Route("/v3/invoices/{invoiceId}/approve")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> InvoicesinvoiceIdApproveapprovalCodeapprovalCodecommentscommentscategorycategory([FromRoute (Name = "invoiceId")][Required]int invoiceId, [FromQuery (Name = "approvalCode")][Required()]string approvalCode, [FromQuery (Name = "comments")][Required()]string comments, [FromQuery (Name = "category")][Required()]string category);

        /// <summary>
        /// Get rates discrepancy
        /// </summary>
        /// <remarks>Retrieves Invoice rates discrepancy information. Returns the labor list with rates discrepancy for the specified invoice.</remarks>
        /// <param name="invoiceId">Invoice identifier.</param>
        /// <response code="200">Indicates that the request succeeded and that the requested information is in the response.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.</response>
        /// <response code="401">Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions;</response>
        /// <response code="404">Indicates that the requested resource does not exist on the server.</response>
        [HttpGet]
        [Route("/v3/invoices/{invoiceId}/discrepancy")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<SCServiceChannelServicesMessagingInvoicesRateDiscrepancy>))]
        [ProducesResponseType(statusCode: 400, type: typeof(List<SCServiceChannelServicesMessagingInvoicesRateDiscrepancy>))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> InvoicesinvoiceIdDiscrepancy([FromRoute (Name = "invoiceId")][Required]int invoiceId);

        /// <summary>
        /// Get rates discrepancy
        /// </summary>
        /// <remarks>Retrieves Invoice rates discrepancy information. Returns the labor list with rates discrepancy for the specified invoice.</remarks>
        /// <param name="invoiceId">Invoice identifier.</param>
        /// <response code="200">Indicates that the request succeeded and that the requested information is in the response.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.</response>
        /// <response code="401">Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions;</response>
        /// <response code="404">Indicates that the requested resource does not exist on the server.</response>
        [HttpGet]
        [Route("/v3/invoices/{invoiceId}/discrepancyExtended")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(SCServiceChannelServicesMessagingInvoicesInvoiceDiscrepancy))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingInvoicesInvoiceDiscrepancy))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> InvoicesinvoiceIdDiscrepancyExtended([FromRoute (Name = "invoiceId")][Required]int invoiceId);

        /// <summary>
        /// Allows put invoice on hold for non-MLI(Multilevel Invoice Approval) invoice
        /// </summary>
        /// <remarks>&lt;para&gt;Allows put invoice on hold for non-MLI(Multilevel Invoice Approval) invoice&lt;/para&gt;</remarks>
        /// <param name="invoiceId">Invoice Identifier</param>
        /// <param name="comments">Comments</param>
        /// <response code="204">Indicates that the request succeeded</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 502 - Wrong Invoice Id               &lt;br/&gt; 503 - MLI(Multilevel Invoice Approval) enabled</response>
        /// <response code="401">Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions;</response>
        [HttpPut]
        [Route("/v3/invoices/{invoiceId}/onhold")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> InvoicesinvoiceIdOnholdcommentscomments([FromRoute (Name = "invoiceId")][Required]int invoiceId, [FromQuery (Name = "comments")][Required()]string comments);

        /// <summary>
        /// Add a payment to an invoice
        /// </summary>
        /// <remarks>Creates a payment record for the specified invoice in the *Approved* status.              &lt;br /&gt;Send this request [GET/odata/invoices](https://developer.servicechannel.com/swagger/ui/index?version&#x3D;3#/Invoices/Invoices_GetInvoices) to get the invoice ID.              &lt;br /&gt;Learn [how subscribers can mark invoices as paid](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/621936646/Marking+Invoices+as+Paid) in ServiceChannel University.              &lt;br /&gt;**Example Request**                                POST /invoices/{invoiceId}/Payment                  {                   \&quot;PaymentDate\&quot;: \&quot;2021-06-10T07:40:47.881Z\&quot;,                   \&quot;PaymentNumber\&quot;: \&quot;25469833\&quot;,                   \&quot;PaymentAmount\&quot;: 850                  }</remarks>
        /// <param name="invoiceId">Unique numeric identifier of the invoice to add a payment to.</param>
        /// <param name="payment">Request to add a payment to the specified invoice.</param>
        /// <response code="204">A payment record is added to the specified invoice. </response>
        /// <response code="400">The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt; Error codes:              503 — Request is invalid              1178 — Invoice cannot be paid before invoice dates              1178 — Invoice has already  paid              1178 — Only approved invoices may pay              1178 — Payment amount exceeds the actual amount              1178 — Payment amount should be more than zero              1178 — Pay not allowed for this subscriber</response>
        /// <response code="401">The request is not authorized.              &lt;br/&gt; Error codes:              504 — API call rejected by security permissions</response>
        /// <response code="403">You are not authorized to request this resource, or the resource is unavailable for some reason.              &lt;br/&gt; Error codes:              100 — User has no rights to perform this action</response>
        [HttpPost]
        [Route("/v3/invoices/{invoiceId}/Payment")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> InvoicesinvoiceIdPayment([FromRoute (Name = "invoiceId")][Required]int invoiceId, [FromBody]SCServiceChannelServicesMessagingInvoicesInvoicePaymentRequest payment);

        /// <summary>
        /// Allows reject non-MLI(Multilevel Invoice Approval) invoice
        /// </summary>
        /// <remarks>&lt;para&gt;Allows reject non-MLI(Multilevel Invoice Approval) invoice&lt;/para&gt;</remarks>
        /// <param name="invoiceId">Invoice Identifier</param>
        /// <param name="comments">Comments</param>
        /// <response code="204">Indicates that the request succeeded</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 502 - Wrong Invoice Id               &lt;br/&gt; 503 - MLI(Multilevel Invoice Approval) enabled</response>
        /// <response code="401">Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions;</response>
        [HttpPut]
        [Route("/v3/invoices/{invoiceId}/reject")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> InvoicesinvoiceIdRejectcommentscomments([FromRoute (Name = "invoiceId")][Required]int invoiceId, [FromQuery (Name = "comments")][Required()]string comments);

        /// <summary>
        /// Retrieve invoice rejection reasons for a subscriber
        /// </summary>
        /// <remarks>Returns invoice rejection reasons for a subscriber              &lt;br /&gt;Both subscribers and providers can use this method.               • **Subscribers** should enter their subscriber ID.               • **Providers** need to pass the ID of the subscriber they have a contract with.</remarks>
        /// <param name="subscriberId">Unique numeric identifier of the subscriber to return invoice rejection reasons for.</param>
        /// <response code="200">Invoice rejection reasons for the specified subscriber are in the response.</response>
        /// <response code="400">The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              503 — The provider has no contract with the requested subscriber              503 — No access. Please check if the SubscriberId is valid</response>
        /// <response code="401">The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions</response>
        [HttpGet]
        [Route("/v3/invoices/{subscriberId}/InvoiceRejectionReasons")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<SCServiceChannelServicesMessagingInvoicesInvoiceRejectionReasonResponse>))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> InvoicessubscriberIdInvoiceRejectionReasons([FromRoute (Name = "subscriberId")][Required]int subscriberId);

        /// <summary>
        /// Retrieve general invoice settings for a subscriber
        /// </summary>
        /// <remarks>Returns general invoice settings for the specified subscriber.              &lt;br /&gt;Both subscribers and providers can use this method.               • **Subscribers** should enter their subscriber ID.               • **Providers** need to pass the ID of the subscriber they have a contract with.              &lt;br /&gt;Subscriber users with the *Super Admin* secondary role set up general invoice parameters in **Admin** &amp;gt; **Invoices** &amp;gt; **General**, where they configure when invoices can be created, if providers should enter a resolution before submitting invoices, and whether any restrictions should apply to invoice numbers. Other parameters may be available if the corresponding features are turned on for the subscriber. Learn more about [configuring general invoice settings](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/557220138/General+Invoice+Configuration) in ServiceChannel University.</remarks>
        /// <param name="subscriberId">Unique numeric identifier of the subscriber to return general invoice settings for.</param>
        /// <response code="200">General invoice settings for the specified subscriber are in the response.</response>
        /// <response code="400">The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              503 — The provider has no contract with the requested subscriber              503 — No access. Please check if the SubscriberId is valid</response>
        /// <response code="401">The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions</response>
        [HttpGet]
        [Route("/v3/invoices/{subscriberId}/InvoiceRequirements")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(SCServiceChannelServicesMessagingInvoicesInvoiceSettingsGeneral))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> InvoicessubscriberIdInvoiceRequirements([FromRoute (Name = "subscriberId")][Required]int subscriberId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="invoiceId"></param>
        /// <param name="userId"></param>
        /// <param name="approvalCode"></param>
        /// <param name="organizationPermissionId"></param>
        /// <param name="subscriberId"></param>
        /// <param name="category"></param>
        /// <param name="comment"></param>
        /// <param name="overrideUserId"></param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/v3/subscribers/{subscriberId}/invoices/{invoiceId}/approve")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(string))]
        public abstract Task<IActionResult> SubscriberssubscriberIdInvoicesinvoiceIdApproveorderIdorderIduserIduserIdapprovalCodeapprovalCodeorganizationPermissionIdorganizationPermissionIdcategorycategorycommentcommentoverrideUserIdoverrideUserId([FromQuery (Name = "orderId")][Required()]int orderId, [FromRoute (Name = "invoiceId")][Required]int invoiceId, [FromQuery (Name = "userId")][Required()]int userId, [FromQuery (Name = "approvalCode")][Required()]string approvalCode, [FromQuery (Name = "organizationPermissionId")][Required()]int organizationPermissionId, [FromRoute (Name = "subscriberId")][Required]int subscriberId, [FromQuery (Name = "category")]string? category, [FromQuery (Name = "comment")]string? comment, [FromQuery (Name = "overrideUserId")]int? overrideUserId);
    }
}
