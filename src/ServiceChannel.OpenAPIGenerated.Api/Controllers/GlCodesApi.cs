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
    public abstract class GlCodesApiController : ControllerBase
    { 
        /// <summary>
        /// Add a GL Code
        /// </summary>
        /// <remarks>Creates a GL Code with a new trade, category, or location.              &lt;br /&gt;Send the [GET /GlCodes/RetrieveGlCodes](https://developer.servicechannel.com/swagger/ui/index?version&#x3D;3#/GlCodes/GETv3_GlCodes_RetrieveGlCodes_trade__trade__category__category__location__location_) request to get the list of GL Codes.</remarks>
        /// <param name="glCode">Numeric identifier of a GL Code.</param>
        /// <param name="trade">Trade name. A trade is an area of work for which a service is performed, such as LIGHTING, ALARMS, or ELECTRICAL. Maximum is 80 characters.</param>
        /// <param name="category">Category name. A category is the overall classification of a work order, such as MAINTENANCE, REPAIR, or WARRANTY. Maximum is 50 characters.</param>
        /// <param name="location">Store ID. The numeric identifier of the store in the client&#39;s system. Assigned by and unique per subscriber.</param>
        /// <response code="201">The created GL Code ID is in the response.</response>
        /// <response code="400">The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              401 — Invalid subsriber ID              606 — Location is not found              704 — Invalid trade value for the subscriber              705 — Invalid category value for the subscriber              706 — GL Code already exists</response>
        /// <response code="401">The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions</response>
        /// <response code="500">The server was unable to complete the request due to an internal error.</response>
        [HttpPost]
        [Route("/v3/GlCodes/CreateGlCode")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 201, type: typeof(Object))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> GlCodesCreateGlCodeglCodeglCodetradetradecategorycategorylocationlocation([FromQuery (Name = "glCode")][Required()]string glCode, [FromQuery (Name = "trade")]string? trade, [FromQuery (Name = "category")]string? category, [FromQuery (Name = "location")]string? location);

        /// <summary>
        /// Delete a GL Code
        /// </summary>
        /// <remarks>Removes the specified GL Code from the subscriber’s system. You need to specify all code parameters to delete it.</remarks>
        /// <param name="glCode">Numeric identifier of a GL Code.</param>
        /// <param name="trade">Trade name. A trade is an area of work for which a service is performed, such as LIGHTING, ALARMS, or ELECTRICAL. Maximum is 80 characters.</param>
        /// <param name="category">Category name. A category is the overall classification of a work order, such as MAINTENANCE, REPAIR, or WARRANTY. Maximum is 50 characters.</param>
        /// <param name="location">Store ID. The numeric identifier of the store in the client&#39;s system. Assigned by and unique per subscriber.</param>
        /// <response code="200">The deleted GL Code ID is in the response.</response>
        /// <response code="400">The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              401 — Invalid subsriber ID              606 — Location is not found              704 — Invalid trade value for the subscriber              705 — Invalid category value for the subscriber              707 — GL Code does not exist</response>
        /// <response code="401">The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions</response>
        /// <response code="500">The server was unable to complete the request due to an internal error.</response>
        [HttpDelete]
        [Route("/v3/GlCodes/DeleteGlCode")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> GlCodesDeleteGlCodeglCodeglCodetradetradecategorycategorylocationlocation([FromQuery (Name = "glCode")][Required()]string glCode, [FromQuery (Name = "trade")]string? trade, [FromQuery (Name = "category")]string? category, [FromQuery (Name = "location")]string? location);

        /// <summary>
        /// Get Approval codes
        /// </summary>
        /// <remarks>Gets the list of approval codes.</remarks>
        /// <param name="locationId">Location Id. Numeric id of location.</param>
        /// <param name="category">Category name. A category is the overall classification of a work order, such as MAINTENANCE, REPAIR, or WARRANTY. Maximum is 50 characters.</param>
        /// <response code="200">Indicates that the request succeeded and that the requested information is in the response.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 503 - Request is empty or null.</response>
        /// <response code="401">Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions;</response>
        /// <response code="500">Indicates that a generic error has occurred on the server.</response>
        [HttpGet]
        [Route("/v3/GlCodes/GetApprovalCodes")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(SCServiceChannelServicesMessagingApprovalCodesGetApprovalCodesWithOptionsResponse))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> GlCodesGetApprovalCodeslocationIdlocationIdcategorycategory([FromQuery (Name = "locationId")][Required()]int locationId, [FromQuery (Name = "category")][Required()]string category);

        /// <summary>
        /// Get a GL Code
        /// </summary>
        /// <remarks>Get a gl code from trade, category, location id.</remarks>
        /// <param name="locationId">Location ID. Numeric id of location.</param>
        /// <param name="trade">Trade name. A trade is an area of work for which a service is performed, such as LIGHTING, ALARMS, or ELECTRICAL. Maximum is 80 characters.</param>
        /// <param name="category">Category name. A category is the overall classification of a work order, such as MAINTENANCE, REPAIR, or WARRANTY. Maximum is 50 characters.</param>
        /// <response code="200">Indicates that the request succeeded and that the requested information is in the response.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 503 - Request is empty or null.              &lt;br/&gt; 601 — Invalid Location id.</response>
        /// <response code="401">Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions;</response>
        /// <response code="500">Indicates that a generic error has occurred on the server.</response>
        [HttpGet]
        [Route("/v3/GlCodes/GetGlCode")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(SCServiceChannelServicesMessagingGlCodeGetGlCodeResponseMessage))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> GlCodesGetGlCodelocationIdlocationIdtradetradecategorycategory([FromQuery (Name = "locationId")][Required()]int locationId, [FromQuery (Name = "trade")][Required()]string trade, [FromQuery (Name = "category")][Required()]string category);

        /// <summary>
        /// Retrieve Gl Codes
        /// </summary>
        /// <remarks>Returns GL Codes for the authorized subscriber.              &lt;br /&gt;You can filter the codes by &#x60;trade&#x60;, &#x60;category&#x60;, and &#x60;location&#x60;.              &lt;br /&gt;Navigate to ServiceChannel University to find out [how to manage GL Codes](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/557645834/Managing+GL+Codes).</remarks>
        /// <param name="trade">Trade name. A trade is an area of work for which a service is performed, such as LIGHTING, ALARMS, or ELECTRICAL. Maximum is 80 characters.</param>
        /// <param name="category">Category name. A category is the overall classification of a work order, such as MAINTENANCE, REPAIR, or WARRANTY. Maximum is 50 characters.</param>
        /// <param name="location">Store ID. The numeric identifier of the store in the client&#39;s system. Assigned by and unique per subscriber.</param>
        /// <response code="200">The requested Gl Codes are in the response.</response>
        /// <response code="400">The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              401 — Invalid subsriber ID</response>
        /// <response code="401">The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions</response>
        /// <response code="404">The requested resource does not exist on the server.              &lt;br/&gt;Error codes:              502 — Not Found              502 — No GL Code exists for the query</response>
        /// <response code="500">The server was unable to complete the request due to an internal error.</response>
        [HttpGet]
        [Route("/v3/GlCodes/RetrieveGlCodes")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(SCServiceChannelServicesMessagingGlCodeRetrieveGlCodesResponse))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> GlCodesRetrieveGlCodestradetradecategorycategorylocationlocation([FromQuery (Name = "trade")]string? trade, [FromQuery (Name = "category")]string? category, [FromQuery (Name = "location")]string? location);

        /// <summary>
        /// Update a GL Code
        /// </summary>
        /// <remarks>Updates a GL Code number leaving the trade, category, and/or location of the code unchanged. You need to specify all code parameters to update it.              &lt;br /&gt;Use the [POST /GlCodes/CreateGlCode](https://developer.servicechannel.com/swagger/ui/index?version&#x3D;3#/GlCodes/POSTv3_GlCodes_CreateGlCode_glCode__glCode__trade__trade__category__category__location__location_) method to create a new GL Code.</remarks>
        /// <param name="glCode">Numeric identifier of a GL Code.</param>
        /// <param name="trade">Trade name. A trade is an area of work for which a service is performed, such as LIGHTING, ALARMS, or ELECTRICAL. Maximum is 80 characters.</param>
        /// <param name="category">Category name. A category is the overall classification of a work order, such as MAINTENANCE, REPAIR, or WARRANTY. Maximum is 50 characters.</param>
        /// <param name="location">Store ID. The numeric identifier of the store in the client&#39;s system. Assigned by and unique per subscriber.</param>
        /// <response code="200">The updated GL Code ID is in the response.</response>
        /// <response code="400">The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              401 — Invalid subsriber ID              606 — Location is not found              704 — Invalid trade value for the subscriber              705 — Invalid category value for the subscriber              707 — GL Code does not exist              708 — At least one field trade/category/location is required</response>
        /// <response code="401">The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions</response>
        /// <response code="500">The server was unable to complete the request due to an internal error.</response>
        [HttpPut]
        [Route("/v3/GlCodes/UpdateGlCode")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> GlCodesUpdateGlCodeglCodeglCodetradetradecategorycategorylocationlocation([FromQuery (Name = "glCode")][Required()]string glCode, [FromQuery (Name = "trade")]string? trade, [FromQuery (Name = "category")]string? category, [FromQuery (Name = "location")]string? location);
    }
}
