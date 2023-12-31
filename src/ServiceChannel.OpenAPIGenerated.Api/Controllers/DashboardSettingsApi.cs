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
    public abstract class DashboardSettingsApiController : ControllerBase
    { 
        /// <summary>
        /// Get Feedback Setup
        /// </summary>
        /// <remarks>Returns a Feedback Setup for Dashboard</remarks>
        /// <param name="setupId">The numeric identifier of the Dashboard Setup Id.</param>
        /// <response code="200">Indicates that the request succeeded</response>
        /// <response code="401">Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              504 - API call rejected by security permissions;</response>
        /// <response code="403">Access denied.              &lt;br&gt;Error codes:              1000 - The setupId does not belong to the Subscriber;</response>
        /// <response code="404">Indicates that the requested resource does not exist on the server.</response>
        /// <response code="500">The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 - Unspecified internal server error occurred</response>
        [HttpGet]
        [Route("/v3/dashboardsettings/feedbacksetup/{setupId}")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(SCServiceChannelServicesMessagingDashboardSettingsSetupFeedbackResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> DashboardsettingsFeedbacksetupsetupId([FromRoute (Name = "setupId")][Required]int setupId);

        /// <summary>
        /// Get Dashboard Note Setup
        /// </summary>
        /// <remarks>Returns a Note Setup for Dashboard</remarks>
        /// <param name="setupId">The numeric identifier of the Dashboard Setup Id.</param>
        /// <response code="200">Indicates that the request succeeded</response>
        /// <response code="401">Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              504 - API call rejected by security permissions;</response>
        /// <response code="403">Access denied.              &lt;br&gt;Error codes:              1000 - The setupId does not belong to the Subscriber;</response>
        /// <response code="404">Indicates that the requested resource does not exist on the server.</response>
        /// <response code="500">The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 - Unspecified internal server error occurred</response>
        [HttpGet]
        [Route("/v3/dashboardsettings/notesetup/{setupId}")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(SCServiceChannelServicesMessagingDashboardSettingsSetupNoteResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> DashboardsettingsNotesetupsetupId([FromRoute (Name = "setupId")][Required]int setupId);

        /// <summary>
        /// Get List Of Dashboard Service Request Setup
        /// </summary>
        /// <remarks>Returns a List of Service Request Setup for Dashboard</remarks>
        /// <param name="setupIds">The list of numeric identifier of the Dashboard Setup Id.</param>
        /// <response code="200">Indicates that the request succeeded</response>
        /// <response code="401">Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              504 - API call rejected by security permissions;</response>
        /// <response code="403">Access denied.              &lt;br&gt;Error codes:              1000 - The setupId does not belong to the Subscriber;</response>
        /// <response code="404">Indicates that the requested resource does not exist on the server.</response>
        /// <response code="500">The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 - Unspecified internal server error occurred</response>
        [HttpPost]
        [Route("/v3/dashboardsettings/requestsetup")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<SCServiceChannelApiModelDashboardSettingsSetupRequest>))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> DashboardsettingsRequestsetup([FromBody]List<int> setupIds);

        /// <summary>
        /// Get List Of Dashboard Service Request Confirmation Setup
        /// </summary>
        /// <remarks>Returns a List of Service Request Confirmation Setup for Dashboard</remarks>
        /// <param name="setupIds">The list of numeric identifier of the Dashboard Setup Id.</param>
        /// <response code="200">Indicates that the request succeeded</response>
        /// <response code="401">Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              504 - API call rejected by security permissions;</response>
        /// <response code="403">Access denied.              &lt;br&gt;Error codes:              1000 - The setupId does not belong to the Subscriber;</response>
        /// <response code="404">Indicates that the requested resource does not exist on the server.</response>
        /// <response code="500">The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 - Unspecified internal server error occurred</response>
        [HttpPost]
        [Route("/v3/dashboardsettings/requestsetupconfirm")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<SCServiceChannelApiModelDashboardSettingsSetupRequestConfirm>))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> DashboardsettingsRequestsetupconfirm([FromBody]List<int> setupIds);

        /// <summary>
        /// Get Dashboard Service Request Confirmation Setup
        /// </summary>
        /// <remarks>Returns a Service Request Confirmation Setup for Dashboard</remarks>
        /// <param name="setupId">The numeric identifier of the Dashboard Setup Id.</param>
        /// <response code="200">Indicates that the request succeeded</response>
        /// <response code="401">Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              504 - API call rejected by security permissions;</response>
        /// <response code="403">Access denied.              &lt;br&gt;Error codes:              1000 - The setupId does not belong to the Subscriber;</response>
        /// <response code="404">Indicates that the requested resource does not exist on the server.</response>
        /// <response code="500">The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 - Unspecified internal server error occurred</response>
        [HttpGet]
        [Route("/v3/dashboardsettings/requestsetupconfirm/{setupId}")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(SCServiceChannelServicesMessagingDashboardSettingsSetupRequestConfirmResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> DashboardsettingsRequestsetupconfirmsetupId([FromRoute (Name = "setupId")][Required]int setupId);

        /// <summary>
        /// Get Dashboard Service Request Setup
        /// </summary>
        /// <remarks>Returns a Service Request Setup for Dashboard</remarks>
        /// <param name="setupId">The numeric identifier of the Dashboard Setup Id.</param>
        /// <response code="200">Indicates that the request succeeded</response>
        /// <response code="401">Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              504 - API call rejected by security permissions;</response>
        /// <response code="403">Access denied.              &lt;br&gt;Error codes:              1000 - The setupId does not belong to the Subscriber;</response>
        /// <response code="404">Indicates that the requested resource does not exist on the server.</response>
        /// <response code="500">The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 - Unspecified internal server error occurred</response>
        [HttpGet]
        [Route("/v3/dashboardsettings/requestsetup/{setupId}")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(SCServiceChannelServicesMessagingDashboardSettingsSetupRequestResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> DashboardsettingsRequestsetupsetupId([FromRoute (Name = "setupId")][Required]int setupId);

        /// <summary>
        /// Get Dashboard Setup General
        /// </summary>
        /// <remarks>Returns Setup General for Dashboard</remarks>
        /// <param name="subscriberId">Subscriber identifier.</param>
        /// <param name="setupId">The identifier of the Dashboard Setup.</param>
        /// <response code="200">Indicates that the request succeeded</response>
        /// <response code="401">Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              504 - API call rejected by security permissions;</response>
        /// <response code="404">Indicates that the requested resource does not exist on the server.</response>
        /// <response code="500">The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 - Unspecified internal server error occurred</response>
        [HttpGet]
        [Route("/v3/dashboardsettings/setupgeneral/{subscriberId}/{setupId}")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(SCServiceChannelApiModelDashboardSettingsSetupGeneral))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> DashboardsettingsSetupgeneralsubscriberIdsetupId([FromRoute (Name = "subscriberId")][Required]int subscriberId, [FromRoute (Name = "setupId")][Required]int setupId);
    }
}
