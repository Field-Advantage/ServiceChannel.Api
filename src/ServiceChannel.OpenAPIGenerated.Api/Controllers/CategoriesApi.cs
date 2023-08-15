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
    public abstract class CategoriesApiController : ControllerBase
    { 
        /// <summary>
        /// Create a new category
        /// </summary>
        /// <remarks>Creates a new work order category within a primary category.              &lt;br /&gt;For more information, refer to [Managing categories](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/556302506/Managing+Categories) in ServiceChannel University.</remarks>
        /// <param name="request">Request to create a new category within a primary category. To get the primary category ID, use the [GET /categories/primary](https://developer.servicechannel.com/swagger/ui/index?version&#x3D;3#/Categories/GETv3_categories_primary) method.</param>
        /// <response code="201">The new category has been created.</response>
        /// <response code="403">You are not authorized to request this resource, or the resource is unavailable for some reason.              &lt;br/&gt;Error codes:              100 — User has no rights to perform this action</response>
        /// <response code="500">The server was unable to complete the request due to an internal error.              &lt;br/&gt; Error codes:              501 — Category already exists              501 — Object reference is not set to an instance of an object</response>
        [HttpPost]
        [Route("/v3/categories")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 201, type: typeof(SCServiceChannelServicesMessagingCategoryAddCategoryResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> Categories([FromBody]SCServiceChannelServicesMessagingCategoryAddCategoryRequest request);

        /// <summary>
        /// List categories that have a GL code mapping with a trade
        /// </summary>
        /// <remarks>Returns categories that have GL codes associated with the specified trade. Learn more about [managing GL codes](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/557645834/Managing+GL+Codes) in ServiceChannel University.</remarks>
        /// <param name="locationId">Unique numeric identifier of the location for which you want to retrieve categories that have a GL code mapping with the trade.</param>
        /// <param name="trade">Trade to retrieve categories with their associated GL codes for.</param>
        /// <response code="200">Categories with GL codes for the specified trade and location are in the response.</response>
        /// <response code="400">The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.</response>
        /// <response code="401">The request is not authorized.              &lt;br/&gt;Error codes:              &lt;br/&gt;504 — API call rejected by security permissions              &lt;br/&gt;601 — Location is not found              &lt;br/&gt;701 — Invalid trade</response>
        [HttpGet]
        [Route("/v3/categories/glcodes")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<SCServiceChannelApiModelProposalsCategoryGLCode>))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> CategoriesGlcodeslocationIdlocationIdtradetrade([FromQuery (Name = "locationId")][Required()]int locationId, [FromQuery (Name = "trade")][Required()]string trade);

        /// <summary>
        /// Retrieve primary categories
        /// </summary>
        /// <remarks>Returns a list of available primary categories of the current subscriber.</remarks>
        /// <response code="200">The requested list of primary categories is in the response.</response>
        /// <response code="403">You are not authorized to request this resource, or the resource is unavailable for some reason.              &lt;br/&gt;Error codes:               100 — User has no rights to perform this action</response>
        /// <response code="500">The server was unable to complete the request due to an internal error.</response>
        [HttpGet]
        [Route("/v3/categories/primary")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(SCServiceChannelServicesMessagingCategoryPrimaryCategoryResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> CategoriesPrimary();

        /// <summary>
        /// Retrieve categories
        /// </summary>
        /// <remarks>Returns a list of available work order categories for one or several subscribers. Only a parent subscriber can get categories for child subscribers.              &lt;br /&gt;You can create a new category via the [POST /categories](https://developer.servicechannel.com/swagger/ui/index#/Categories/POSTv3_categories) method.</remarks>
        /// <param name="subscriberIds">Unique numeric ID of the subscriber you want to retrieve categories for. By default, the current subscriber ID is set.</param>
        /// <response code="200">The requested list of categories is in the response.</response>
        /// <response code="400">The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              401 — Invalid subscriber ID</response>
        /// <response code="401">The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions</response>
        /// <response code="403">You are not authorized to request this resource, or the resource is unavailable for some reason.              &lt;br/&gt;Error codes:               100 — User has no rights to perform this action</response>
        /// <response code="500">The server was unable to complete the request due to an internal error.</response>
        [HttpGet]
        [Route("/v3/categories")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<SCServiceChannelServicesMessagingCategoryCategoryResponse>))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> CategoriessubscriberIds0subscriberIds0subscriberIds1subscriberIds1([FromQuery (Name = "subscriberIds")]List<int>? subscriberIds);
    }
}