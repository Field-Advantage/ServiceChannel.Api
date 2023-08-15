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
    public abstract class TestApiController : ControllerBase
    { 
        /// <summary>
        /// Get Encrypted Password
        /// </summary>
        /// <remarks>Get Encrypted Password (Rijndael)              &lt;br /&gt;&lt;br /&gt;This method can only be used for users with &#39;MasterAdminRole&#39; permissions.</remarks>
        /// <param name="data"></param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/v3/test/encrypt")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public abstract Task<IActionResult> TestEncryptdatadata([FromQuery (Name = "data")][Required()]string data);

        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/v3/test/notifications1")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public abstract Task<IActionResult> TestNotifications1();

        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/v3/test/notifications2")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public abstract Task<IActionResult> TestNotifications2();

        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/v3/test/notifications3")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public abstract Task<IActionResult> TestNotifications3();

        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/v3/test/notificationsDelay")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public abstract Task<IActionResult> TestNotificationsDelay();

        /// <summary>
        /// Ping a target URL
        /// </summary>
        /// <remarks>Tests the URL for receiving events. Delivers a [test event](https://developer.servicechannel.com/guides/wh/test-your-webhook-url/) to the target URL for a successful request.</remarks>
        /// <param name="request">The request object containing the URL that needs to be tested.</param>
        /// <response code="201">The test event is sent.</response>
        /// <response code="400">The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              503 - Failed to send POST request to specified URL, or your server responded with invalid status code</response>
        /// <response code="401">The request is not authorized.              &lt;br/&gt;Error codes:              504 - Missing or incorrect authentication credentials</response>
        [HttpPost]
        [Route("/v3/test/webhooks/notifications")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> TestWebhooksNotifications([FromBody]SCServiceChannelServicesMessagingNotificationsTestNotificationRequest request);
    }
}