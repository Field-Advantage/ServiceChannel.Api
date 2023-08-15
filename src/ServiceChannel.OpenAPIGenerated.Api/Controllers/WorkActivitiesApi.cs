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
    public abstract class WorkActivitiesApiController : ControllerBase
    { 
        /// <summary>
        /// List work activities created by a provider user within the specified time period
        /// </summary>
        /// <remarks>Returns work activities created by the specified provider user within the set time period.              &lt;br /&gt;A work activity details information about the technician’s work on a service request: the time when the technician started and finished their work, the type of activity they carried out, the number of technicians who rendered the service, and other details related to the labor performed.              &lt;br /&gt;***Note:*** This method is only available to provider users.</remarks>
        /// <param name="userId">PIN of the provider user who created work activities.</param>
        /// <param name="dtMax">The end date of the time period for which you want to retrieve work activities. The format is &#x60;YYYY-MM-DD&#x60;.</param>
        /// <param name="dtMin">The start date of the time period for which you want to retrieve work activities. The format is &#x60;YYYY-MM-DD&#x60;.</param>
        /// <param name="expand">Expand a navigation property.</param>
        /// <param name="select">Select a set of properties to return.</param>
        /// <param name="filter">Filter a collection of resources addressed by a request URL.</param>
        /// <param name="orderby">Order resources by the specified property in the response.</param>
        /// <param name="top">Return the specified number of items in the response.</param>
        /// <param name="skip">Skip the specified number of items in the response.</param>
        /// <param name="count">Include the count of the matching resources in the response.</param>
        /// <response code="200">Work activities created by the specified provider user within the set time period are in the response.</response>
        /// <response code="400">The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              504 — User not found</response>
        /// <response code="401">The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions</response>
        /// <response code="500">The server was unable to complete the request due to an internal error.</response>
        [HttpGet]
        [Route("/v3/odata/workactivities/Service.ForTimeInterval(dtMin={dtMin}, dtMax={dtMax}, userId={userId})")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<SCServiceChannelServicesMessagingWorkordersWorkActivity>))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> ForTimeInterval([FromRoute (Name = "userId")][Required]int userId, [FromRoute (Name = "dtMax")][Required]DateTime dtMax, [FromRoute (Name = "dtMin")][Required]DateTime dtMin, [FromQuery (Name = "$expand")]string? expand, [FromQuery (Name = "$select")]string? select, [FromQuery (Name = "$filter")]string? filter, [FromQuery (Name = "$orderby")]string? orderby, [FromQuery (Name = "$top")]int? top, [FromQuery (Name = "$skip")]int? skip, [FromQuery (Name = "$count")]bool? count);

        /// <summary>
        /// List work activities of the specified work order
        /// </summary>
        /// <remarks>Returns work activities of the specified work order.              &lt;br /&gt;A work activity details information about the technician&#39;s work on a service request: the time when the technician started and finished their work, the type of activity they carried out, the number of technicians who rendered the service, and other details related to the labor performed.              &lt;br /&gt;***Note:*** Both subscribers and providers can use this method.</remarks>
        /// <param name="workorderId">The unique numeric identifier of the work order for which you want to retrieve work activities.</param>
        /// <param name="expand">Expand a navigation property.</param>
        /// <param name="select">Select a set of properties to return.</param>
        /// <param name="filter">Filter a collection of resources addressed by a request URL.</param>
        /// <param name="orderby">Order resources by the specified property in the response.</param>
        /// <param name="top">Return the specified number of items in the response.</param>
        /// <param name="skip">Skip the specified number of items in the response.</param>
        /// <param name="count">Include the count of the matching resources in the response.</param>
        /// <response code="200">The work activities of the specified work order are in the response.</response>
        /// <response code="400">The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              502 — WorkOrder not found</response>
        /// <response code="401">The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions</response>
        /// <response code="500">The server was unable to complete the request due to an internal error.</response>
        [HttpGet]
        [Route("/v3/odata/workorders({workorderId})/workactivities")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<SCServiceChannelServicesMessagingWorkordersWorkActivity>))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> GetWorkActivities([FromRoute (Name = "workorderId")][Required]int workorderId, [FromQuery (Name = "$expand")]string? expand, [FromQuery (Name = "$select")]string? select, [FromQuery (Name = "$filter")]string? filter, [FromQuery (Name = "$orderby")]string? orderby, [FromQuery (Name = "$top")]int? top, [FromQuery (Name = "$skip")]int? skip, [FromQuery (Name = "$count")]bool? count);

        /// <summary>
        /// Retrieve the specified work activity of a work order
        /// </summary>
        /// <remarks>Returns the specified work activity of a work order.              &lt;br /&gt;A work activity details information about the technician&#39;s work on a service request: the time when the technician started and finished their work, the type of activity they carried out, the number of technicians who rendered the service, and other details related to the labor performed.              &lt;br /&gt;***Note:*** Both subscribers and providers can use this method.</remarks>
        /// <param name="workactivityId">The unique numeric identifier of the work activity to return.</param>
        /// <param name="workorderId">The unique numeric identifier of the work order for which you want to retrieve a work activity.</param>
        /// <param name="expand">Expand a navigation property.</param>
        /// <param name="select">Select a set of properties to return.</param>
        /// <param name="filter">Filter a collection of resources addressed by a request URL.</param>
        /// <param name="orderby">Order resources by the specified property in the response.</param>
        /// <param name="top">Return the specified number of items in the response.</param>
        /// <param name="skip">Skip the specified number of items in the response.</param>
        /// <param name="count">Include the count of the matching resources in the response.</param>
        /// <response code="200">The requested work activity of the specified work order is in the response.</response>
        /// <response code="400">The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              502 — WorkOrder not found              502 — Work activity is not found</response>
        /// <response code="401">The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions</response>
        /// <response code="500">The server was unable to complete the request due to an internal error.</response>
        [HttpGet]
        [Route("/v3/odata/workorders({workorderId})/workactivities({workactivityId})")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(SCServiceChannelServicesMessagingWorkordersWorkActivity))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> GetWorkActivity([FromRoute (Name = "workactivityId")][Required]int workactivityId, [FromRoute (Name = "workorderId")][Required]int workorderId, [FromQuery (Name = "$expand")]string? expand, [FromQuery (Name = "$select")]string? select, [FromQuery (Name = "$filter")]string? filter, [FromQuery (Name = "$orderby")]string? orderby, [FromQuery (Name = "$top")]int? top, [FromQuery (Name = "$skip")]int? skip, [FromQuery (Name = "$count")]bool? count);

        /// <summary>
        /// Create a work activity for the specified work order
        /// </summary>
        /// <remarks>Creates a new work activity for the specified work order. The work activity type can be either *Travel* or *Repair*. Note that custom types may be configured for a subscriber.              &lt;br /&gt;Before creating a work activity, please consider the following:               • You can create work activities only for work orders in the *In Progress* primary status.               • The check-in date and time cannot be greater than the check-out date and time.               • The check-in date and time cannot be earlier than the scheduled date and time of the work order.               • The time range of the work activity you are creating cannot overlap the time ranges of existing work activities of the work order.               • The name will be set to the API caller name if the &#x60;name&#x60; value is not provided.              &lt;br /&gt;***Note:*** Both subscribers and providers can use this method.              &lt;br /&gt;***Note:*** Only users with extended permissions can specify the technician&#39;s name while creating a work activity. The users with extended permissions are:               • Subscribers that have the *Admin* role.               • Providers that have the *Admin* role (with the *EditLaborItemsOnWoDetailsProvider* feature flag turned on).               • Providers that have the *Business Owner / Management* role (with the *EditLaborItemsOnWoDetailsProvider* feature flag turned on).              &lt;br /&gt;Learn more about [creating a work activity](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/576258285/Updating+Service+Provider+Check-In+Out+Information) in ServiceChannel University.              &lt;br /&gt;**Example Request**                                POST /workorders/{workorderId}/workactivities                  {                     \&quot;WorkTypeId\&quot;: \&quot;1\&quot;,                            \&quot;CheckInDate\&quot;: \&quot;2020-11-19T11:10:36.868Z\&quot;,                     \&quot;CheckOutDate\&quot;: \&quot;2020-11-19T12:15:36.868Z\&quot;,                     \&quot;Name\&quot;: \&quot;John Doe\&quot;                  }</remarks>
        /// <param name="workorderId">The unique numeric identifier of the work order for which you want to create a work activity.</param>
        /// <param name="activityRequest">Request to create a work activity.</param>
        /// <response code="201">A work activity is created for the specified work order, and a unique work activity ID is returned in the response.</response>
        /// <response code="400">The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              502 — WorkOrder not found              503 — Work Type Not Found              503 — Date range is incorrect              503 — Check In/Out is premature              904 — Invalid work order status              1186 — Time range is overlapped</response>
        /// <response code="401">The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions</response>
        /// <response code="403">You are not authorized to request this resource, or the resource is unavailable for some reason.              &lt;br/&gt;Error codes:              804 — User has no permissions to perform this action</response>
        /// <response code="406">The request is already processed.</response>
        /// <response code="500">The server was unable to complete the request due to an internal error.</response>
        [HttpPost]
        [Route("/v3/workorders/{workorderId}/workactivities")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 406, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> WorkordersworkorderIdWorkactivities([FromRoute (Name = "workorderId")][Required]int workorderId, [FromBody]SCServiceChannelServicesMessagingWorkordersWorkActivityPostRequest activityRequest);

        /// <summary>
        /// Update the specified work activity of a work order
        /// </summary>
        /// <remarks>Updates the specified work activity of a work order by setting the check-in and check-out date and time values passed in the request.              &lt;br /&gt;Before updating a work activity, please consider the following:               • You can update work activities only for work orders in the *In Progress* primary status.               • The check-in date and time cannot be greater than the check-out date and time.               • The check-in date and time cannot be earlier than the scheduled date and time of the work order.               • The time range of the work activity you are updating cannot overlap the time ranges of existing work activities of the work order.               • The name will be set to the API caller name if the &#x60;name&#x60; value is not provided.              &lt;br /&gt;***Note:*** Both subscribers and providers can use this method.              &lt;br /&gt;***Note:*** Only users with extended permissions can update the work activities created by other users along with updating the &#x60;name&#x60; parameter. The users with certain permissions are:               • Subscribers that have the *Admin* role. These users can update the work activities created both by subscribers and by providers.               • Providers that have the *Admin* role (with the *EditLaborItemsOnWoDetailsProvider* feature flag turned on). These users can update the work activities created by providers only.               • Providers that have the *Business Owner / Management* role (with the *EditLaborItemsOnWoDetailsProvider* feature flag turned on). These users can update the work activities created by providers only.              &lt;br /&gt;Learn more about [updating a work activity](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/576258285/Updating+Service+Provider+Check-In+Out+Information) in ServiceChannel University.              &lt;br /&gt;**Example Request**                                PUT /workorders/{workorderId}/workactivities/{workactivityId}                  {                     \&quot;CheckInDate\&quot;: \&quot;2020-11-19T11:10:36.868Z\&quot;,                     \&quot;CheckOutDate\&quot;: \&quot;2020-11-19T12:30:36.868Z\&quot;,                     \&quot;Name\&quot;: \&quot;John Doe\&quot;                  }</remarks>
        /// <param name="workorderId">The unique numeric identifier of the work order for which you want to update a work activity.</param>
        /// <param name="workactivityId">The unique numeric identifier of the work activity to update.</param>
        /// <param name="activityRequest">Request to update a work activity.</param>
        /// <response code="200">The work activity is updated, and its ID is returned in the response.</response>
        /// <response code="400">The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              502 — WorkOrder not found              503 — Work activity is not found              503 — Date range is incorrect              503 — Check In/Out is premature              904 — Invalid work order status              1186 — Time range is overlapped</response>
        /// <response code="401">The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions</response>
        /// <response code="403">You are not authorized to request this resource, or the resource is unavailable for some reason.              &lt;br/&gt;Error codes:              804 — User has no permissions to perform this action</response>
        /// <response code="500">The server was unable to complete the request due to an internal error.</response>
        [HttpPut]
        [Route("/v3/workorders/{workorderId}/workactivities/{workactivityId}")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> WorkordersworkorderIdWorkactivitiesworkactivityId([FromRoute (Name = "workorderId")][Required]int workorderId, [FromRoute (Name = "workactivityId")][Required]int workactivityId, [FromBody]SCServiceChannelServicesMessagingWorkordersWorkActivityRequest activityRequest);

        /// <summary>
        /// Delete the specified work activities of a work order
        /// </summary>
        /// <remarks>Delete one or more work activities of the specified work order. When you pass multiple work activity IDs, the request will succeed if at least one ID is valid.              &lt;br /&gt;***Note:*** Both subscribers and providers can use this method.</remarks>
        /// <param name="workorderId">The unique numeric identifier of the work order for which you want to delete work activities.</param>
        /// <param name="workactivityIds">The unique numeric identifiers of the work activities to delete.</param>
        /// <response code="204">The specified work activities are deleted, and the response is intentionally blank.</response>
        /// <response code="400">The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              502 — WorkOrder not found              502 — Work activities are not found              804 — User has no permissions to perform this action</response>
        /// <response code="401">The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions</response>
        /// <response code="500">The server was unable to complete the request due to an internal error.</response>
        [HttpDelete]
        [Route("/v3/workorders/{workorderId}/workactivities")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> WorkordersworkorderIdWorkactivitiesworkactivityIds0workactivityIds0workactivityIds1workactivityIds1([FromRoute (Name = "workorderId")][Required]int workorderId, [FromQuery (Name = "workactivityIds")][Required()]List<int> workactivityIds);
    }
}
