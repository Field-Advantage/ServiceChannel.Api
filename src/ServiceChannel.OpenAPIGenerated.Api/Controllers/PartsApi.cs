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
    public abstract class PartsApiController : ControllerBase
    { 
        /// <summary>
        /// Verifies that user is associated with parts usage
        /// </summary>
        /// <param name="authUserId"></param>
        /// <param name="technicianId"></param>
        /// <param name="certificationNumber"></param>
        /// <response code="200">Indicates that the request succeeded.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.</response>
        /// <response code="401">Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br/&gt; 504 - API call rejected by security permissions;</response>
        /// <response code="500">Error while processing request.</response>
        [HttpGet]
        [Route("/v3/parts/isTechCertificationUsedOnRefrigerantTracking")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(SCServiceChannelServicesMessagingAssetsTechnicianAssociatedResponse))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> PartsIsTechCertificationUsedOnRefrigerantTrackingauthUserIdauthUserIdtechnicianIdtechnicianIdcertificationNumbercertificationNumber([FromQuery (Name = "authUserId")][Required()]long authUserId, [FromQuery (Name = "technicianId")][Required()]int technicianId, [FromQuery (Name = "certificationNumber")][Required()]string certificationNumber);

        /// <summary>
        /// Inventory part user record bulk change
        /// </summary>
        /// <param name="request"></param>
        /// <response code="200">Indicates that the request succeeded.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.</response>
        /// <response code="500">Error while processing request.</response>
        [HttpPost]
        [Route("/v3/workorders/inventory/parts/bulkPartUsage")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 400, type: typeof(string))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> WorkordersInventoryPartsBulkPartUsage([FromBody]SCServiceChannelServicesMessagingRefrigerantTrackingWorkOrderPartRefrigerantBulkChangeRequest request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="workorderId"></param>
        /// <response code="200">Indicates that the request succeeded.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.&lt;br&gt;Error codes:&lt;br&gt;502 - WorkOrder not found;</response>
        /// <response code="401">Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br/&gt; 504 - API call rejected by security permissions;</response>
        /// <response code="500">Error while processing request.</response>
        [HttpGet]
        [Route("/v3/workorders/{workorderId}/inventory/refrigerantusage")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(SCServiceChannelServicesMessagingPartsRefrigerantUsageResponse))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> WorkordersworkorderIdInventoryRefrigerantusage([FromRoute (Name = "workorderId")][Required]int workorderId);

        /// <summary>
        /// Get a Work order parts
        /// </summary>
        /// <remarks>Get a Work order parts. Returns Work order parts collection for successful request.              &lt;br /&gt;&lt;br /&gt;Available for provider and subscriber usage.</remarks>
        /// <param name="workorderId">The Work order identity</param>
        /// <response code="200">Indicates that the request succeeded and that the requested information is in the response.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.</response>
        /// <response code="401">Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions;</response>
        [HttpGet]
        [Route("/v3/workorders/{workorderId}/parts")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<SCServiceChannelServicesMessagingWorkordersWorkOrderPartResponse>))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> WorkordersworkorderIdParts([FromRoute (Name = "workorderId")][Required]int workorderId);

        /// <summary>
        /// Retrieve work order parts usage
        /// </summary>
        /// <param name="workorderId"></param>
        /// <response code="200">Indicates that the request succeeded.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.&lt;br&gt;Error codes:&lt;br&gt;502 - WorkOrder not found;</response>
        /// <response code="401">Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br/&gt; 504 - API call rejected by security permissions;</response>
        /// <response code="500">Error while processing request.</response>
        [HttpGet]
        [Route("/v3/workorders/{workorderId}/partsUsage")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<SCServiceChannelServicesMessagingRefrigerantTrackingWorkOrderPartRefrigerantResponse>))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> WorkordersworkorderIdPartsUsage([FromRoute (Name = "workorderId")][Required]int workorderId);

        /// <summary>
        /// Update Work order parts
        /// </summary>
        /// <remarks>Available only for provider.</remarks>
        /// <param name="workorderId">The Work order identity</param>
        /// <param name="request">The Work order parts collection for update</param>
        /// <response code="200">Indicates that the request succeeded.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.&lt;br&gt;Error codes:&lt;br&gt;502 - WorkOrder not found;</response>
        /// <response code="401">Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br/&gt; 504 - API call rejected by security permissions;</response>
        /// <response code="500">Error while processing request.</response>
        [HttpPut]
        [Route("/v3/workorders/{workorderId}/parts")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> WorkordersworkorderIdParts_0([FromRoute (Name = "workorderId")][Required]int workorderId, [FromBody]SCServiceChannelServicesMessagingWorkordersUpdateWorkOrderPartsCollectionRequest request);

        /// <summary>
        /// Create Work order parts
        /// </summary>
        /// <remarks>Available only for provider.</remarks>
        /// <param name="workorderId">A new Work order identity</param>
        /// <param name="requestModel">A new Work order parts collection</param>
        /// <response code="201">Indicates that the request succeeded.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.&lt;br&gt;Error codes:&lt;br&gt;502 - WorkOrder not found;</response>
        /// <response code="401">Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br/&gt; 504 - API call rejected by security permissions;</response>
        /// <response code="500">Error while processing request.</response>
        [HttpPost]
        [Route("/v3/workorders/{workorderId}/parts")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> WorkordersworkorderIdParts_1([FromRoute (Name = "workorderId")][Required]int workorderId, [FromBody]SCServiceChannelServicesMessagingWorkordersCreateWorkOrderPartsCollectionRequest requestModel);

        /// <summary>
        /// Delete Work order parts
        /// </summary>
        /// <remarks>Available only for provider.</remarks>
        /// <param name="workorderId">The Work order identity</param>
        /// <param name="ids">The Work order part identity collection for delete</param>
        /// <response code="200">Indicates that the request succeeded.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.&lt;br&gt;Error codes:&lt;br&gt;502 - WorkOrder not found;</response>
        /// <response code="401">Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br/&gt; 504 - API call rejected by security permissions;</response>
        /// <response code="500">Error while processing request.</response>
        [HttpDelete]
        [Route("/v3/workorders/{workorderId}/parts")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> WorkordersworkorderIdPartsids0ids0ids1ids1([FromRoute (Name = "workorderId")][Required]int workorderId, [FromQuery (Name = "ids")][Required()]List<int> ids);

        /// <summary>
        /// Get a Work order parts
        /// </summary>
        /// <remarks>Get a Work order parts. Returns Work order parts collection for successful request.              &lt;br /&gt;&lt;br /&gt;Available for provider and subscriber usage.</remarks>
        /// <param name="workorderId">The Work order identity</param>
        /// <param name="includeConnectorParts">Include Connector Parts</param>
        /// <response code="200">Indicates that the request succeeded and that the requested information is in the response.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.</response>
        /// <response code="401">Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions;</response>
        [HttpGet]
        [Route("/v3/workorders/{workorderId}/{includeConnectorParts}/partsV1")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<SCServiceChannelServicesMessagingWorkordersWorkOrderPartResponse>))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> WorkordersworkorderIdincludeConnectorPartsPartsV1([FromRoute (Name = "workorderId")][Required]int workorderId, [FromRoute (Name = "includeConnectorParts")][Required]bool includeConnectorParts);
    }
}
