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
    public abstract class ScConnectorApiController : ControllerBase
    { 
        /// <summary>
        /// Called when subcontractor workorder CheckInOut
        /// </summary>
        /// <param name="checkinActivity">CheckInOut</param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/v3/ScConnector/CheckInOut")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public abstract Task<IActionResult> ScConnectorCheckInOut([FromBody]SCServiceChannelServicesWebApiModelsCheckInOutNotificationObject checkinActivity);

        /// <summary>
        /// XmlIntegration callout. Called when subcontractor workorder created
        /// </summary>
        /// <param name="msg"></param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/v3/ScConnector/SubContractorWorkorderCreated")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public abstract Task<IActionResult> ScConnectorSubContractorWorkorderCreated([FromBody]SCServiceChannelServicesWebApiControllersScConnectorControllerData msg);

        /// <summary>
        /// XmlIntegration callout. Called when subcontractor workorder updated
        /// </summary>
        /// <param name="msg"></param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/v3/ScConnector/SubContractorWorkorderUpdated")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public abstract Task<IActionResult> ScConnectorSubContractorWorkorderUpdated([FromBody]SCServiceChannelServicesWebApiControllersScConnectorControllerData msg);

        /// <summary>
        /// Connector sync asset process
        /// </summary>
        /// <param name="notificationObject"></param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/v3/ScConnector/SyncAssets")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public abstract Task<IActionResult> ScConnectorSyncAssets([FromBody]SCServiceChannelServicesMessagingWorkordersWorkorderNotificationObject notificationObject);

        /// <summary>
        /// Connector sync asset validation process
        /// </summary>
        /// <param name="notificationObject"></param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/v3/ScConnector/SyncAssetsValidation")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public abstract Task<IActionResult> ScConnectorSyncAssetsValidation([FromBody]SCServiceChannelServicesMessagingWorkordersWorkorderNotificationObject notificationObject);

        /// <summary>
        /// Connector sync notes process
        /// </summary>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/v3/ScConnector/SyncNotes")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public abstract Task<IActionResult> ScConnectorSyncNotes();

        /// <summary>
        /// Connector sync Resolution codes process
        /// </summary>
        /// <param name="notificationObject"></param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/v3/ScConnector/SyncResolutionCodes")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public abstract Task<IActionResult> ScConnectorSyncResolutionCodes([FromBody]SCServiceChannelServicesMessagingWorkordersWorkorderNotificationObject notificationObject);

        /// <summary>
        /// XmlIntegration callout. Called when workorder created
        /// </summary>
        /// <param name="msg">Created workorder</param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/v3/ScConnector/WorkorderCreated")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public abstract Task<IActionResult> ScConnectorWorkorderCreated([FromBody]SCServiceChannelServicesWebApiControllersScConnectorControllerData msg);

        /// <summary>
        /// XmlIntegration callout. Called when workorder updated
        /// </summary>
        /// <param name="msg"></param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/v3/ScConnector/WorkorderUpdated")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public abstract Task<IActionResult> ScConnectorWorkorderUpdated([FromBody]SCServiceChannelServicesWebApiControllersScConnectorControllerData msg);
    }
}
