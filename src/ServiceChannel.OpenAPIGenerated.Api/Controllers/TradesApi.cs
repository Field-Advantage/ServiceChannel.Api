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
    public abstract class TradesApiController : ControllerBase
    { 
        /// <summary>
        /// Trades Collection
        /// </summary>
        /// <remarks>List trades.              &lt;br /&gt;&lt;br /&gt;Available for provider and subscriber usage.</remarks>
        /// <param name="expand">Expand a navigation property.</param>
        /// <param name="select">Select a set of properties to return.</param>
        /// <param name="filter">Filter a collection of resources addressed by a request URL.</param>
        /// <param name="orderby">Order resources by the specified property in the response.</param>
        /// <param name="top">Return the specified number of items in the response.</param>
        /// <param name="skip">Skip the specified number of items in the response.</param>
        /// <param name="count">Include the count of the matching resources in the response.</param>
        /// <response code="200">Indicates that the request succeeded and that the requested information is in the response.</response>
        /// <response code="401">Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions;</response>
        /// <response code="500">Indicates that a generic error has occurred on the server.</response>
        [HttpGet]
        [Route("/v3/odata/trades")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<SCServiceChannelServicesMessagingTradeTrade>))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCAmazonRuntimeInternalErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCAmazonRuntimeInternalErrorResponse))]
        public abstract Task<IActionResult> GetTrades([FromQuery (Name = "$expand")]string? expand, [FromQuery (Name = "$select")]string? select, [FromQuery (Name = "$filter")]string? filter, [FromQuery (Name = "$orderby")]string? orderby, [FromQuery (Name = "$top")]int? top, [FromQuery (Name = "$skip")]int? skip, [FromQuery (Name = "$count")]bool? count);

        /// <summary>
        /// Location Trades
        /// </summary>
        /// <remarks>List Location Trades. Method returns trades for specified location which have providers with rank 1 and higher.              &lt;br /&gt;&lt;br /&gt;Available for subscriber and provider usage.</remarks>
        /// <param name="locationId">Numeric id of the Location to perform action with.</param>
        /// <param name="expand">Expand a navigation property.</param>
        /// <param name="select">Select a set of properties to return.</param>
        /// <param name="filter">Filter a collection of resources addressed by a request URL.</param>
        /// <param name="orderby">Order resources by the specified property in the response.</param>
        /// <param name="top">Return the specified number of items in the response.</param>
        /// <param name="skip">Skip the specified number of items in the response.</param>
        /// <param name="count">Include the count of the matching resources in the response.</param>
        /// <response code="200">Indicates that the request succeeded and that the requested information is in the response.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.</response>
        /// <response code="401">Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions;</response>
        /// <response code="500">Indicates that a generic error has occurred on the server.</response>
        [HttpGet]
        [Route("/v3/odata/locations({locationId})/trades")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<SCServiceChannelServicesMessagingTradeTrade>))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCAmazonRuntimeInternalErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCAmazonRuntimeInternalErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCAmazonRuntimeInternalErrorResponse))]
        public abstract Task<IActionResult> GetTradesByLocation([FromRoute (Name = "locationId")][Required]int locationId, [FromQuery (Name = "$expand")]string? expand, [FromQuery (Name = "$select")]string? select, [FromQuery (Name = "$filter")]string? filter, [FromQuery (Name = "$orderby")]string? orderby, [FromQuery (Name = "$top")]int? top, [FromQuery (Name = "$skip")]int? skip, [FromQuery (Name = "$count")]bool? count);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <response code="200">Indicates that the request succeeded.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.</response>
        /// <response code="401">Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions              &lt;br/&gt; 710 - Trade already exists              &lt;br/&gt; 711 - Invalid NTE</response>
        /// <response code="500">Indicates that a generic error has occurred on the server.</response>
        [HttpPost]
        [Route("/v3/trades")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(SCServiceChannelServicesMessagingTradeAddTradeRequest))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> Trades([FromBody]SCServiceChannelServicesMessagingTradeAddTradeRequest request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <response code="200">Indicates that the request succeeded.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.</response>
        /// <response code="401">Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions              &lt;br/&gt; 710 - Trade already exists              &lt;br/&gt; 711 - Invalid NTE</response>
        /// <response code="500">Indicates that a generic error has occurred on the server.</response>
        [HttpPost]
        [Route("/v3/trades/batch")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<SCServiceChannelServicesMessagingTradeAddTradeResponse>))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> TradesBatch([FromBody]List<SCServiceChannelServicesMessagingTradeAddTradeRequest> request);

        /// <summary>
        /// Get Primary Trade For Provider
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="tradeName"></param>
        /// <param name="tradeId"></param>
        /// <response code="200">Indicates that the request succeeded.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:                          &lt;br/&gt; 503 - tradeName and tradeId cannot be both empty or null and less than 1 and null respectively.              &lt;br/&gt; 401 - Invalid subscriber id</response>
        /// <response code="401">Indicates that the requested resource requires authentication.</response>
        /// <response code="404">The requested resource does not exist on the server.              &lt;br/&gt;Error codes:              &lt;br/&gt; 5010 - Trade is not found</response>
        /// <response code="500">Indicates that a generic error has occurred on the server.</response>
        [HttpPost]
        [Route("/v3/trades/GetPrimaryTrade")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(SCServiceChannelServicesMessagingTradeTradeWithPrimaryTrade))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> TradesGetPrimaryTradesubscriberIdsubscriberIdtradeNametradeNametradeIdtradeId([FromQuery (Name = "subscriberId")][Required()]int subscriberId, [FromQuery (Name = "tradeName")]string? tradeName, [FromQuery (Name = "tradeId")]int? tradeId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="tradeName"></param>
        /// <response code="200">Indicates that the request succeeded and that the requested information is in the response.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 100 - User has no permissions to perform this action. Not Allowed Subscriber Id(s): ..;..;</response>
        /// <response code="401">Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions;</response>
        /// <response code="500">Indicates that a generic error has occurred on the server.</response>
        [HttpPost]
        [Route("/v3/trades/IsRefrigerant")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<SCServiceChannelServicesMessagingTradeTrade>))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> TradesIsRefrigerantsubscriberIdsubscriberIdtradeNametradeName([FromQuery (Name = "subscriberId")][Required()]int subscriberId, [FromQuery (Name = "tradeName")][Required()]string tradeName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <response code="200">Indicates that the request succeeded.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.</response>
        /// <response code="401">Indicates that the requested resource requires authentication.</response>
        /// <response code="500">Indicates that a generic error has occurred on the server.</response>
        [HttpPost]
        [Route("/v3/trades/LocationProviderTrades")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(SCServiceChannelServicesMessagingTradeGetLocationProviderTradesRequest))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> TradesLocationProviderTrades([FromBody]SCServiceChannelServicesMessagingTradeGetLocationProviderTradesRequest request);
    }
}
