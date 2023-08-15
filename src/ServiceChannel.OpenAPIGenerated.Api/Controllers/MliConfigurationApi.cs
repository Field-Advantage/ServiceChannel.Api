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
    public abstract class MliConfigurationApiController : ControllerBase
    { 
        /// <summary>
        /// Get MLI levels
        /// </summary>
        /// <remarks>Returns IDs and names of all MLI levels of the current subscriber.              &lt;br /&gt;Learn more about [MLI levels configuration](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/601555312/Configuring+MLI+Levels) in ServiceChannel University.</remarks>
        /// <response code="200">MLI levels are in the response.</response>
        /// <response code="401">The request is not authorized.              &lt;br/&gt; Error codes:              504 — API call rejected by security permissions</response>
        [HttpGet]
        [Route("/v3/mliConfiguration/Levels")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<SCServiceChannelServicesMessagingMliConfigurationApiMLILevel>))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> MliConfigurationLevels();

        /// <summary>
        /// Get MLI level users
        /// </summary>
        /// <remarks>Returns the users assigned to the specified level. The response body is empty if no user has been assigned to this level.              &lt;br /&gt;You can use the [GET /mliConfiguration/Levels](https://developer.servicechannel.com/swagger/ui/index?version&#x3D;3#/MliConfiguration/GETv3_mliConfiguration_Levels) method to get the MLI levels IDs. Send the [POST /MliConfiguration/Levels/{levelId}/Users/{userId}](https://developer.servicechannel.com/swagger/ui/index?version&#x3D;3#/MliConfiguration/POSTv3_MliConfiguration_Levels__levelId__Users__userId_) request to assign users to the MLI level.</remarks>
        /// <param name="levelId">Numeric identifier of the MLI level.</param>
        /// <response code="200">The users assigned to the specified MLI level are in the response.</response>
        /// <response code="400">The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt; Error codes:              1128 — Approval levels getting error</response>
        /// <response code="401">The request is not authorized.              &lt;br/&gt; Error codes:              504 — API call rejected by security permissions</response>
        [HttpGet]
        [Route("/v3/mliConfiguration/Levels/{levelId}/Users")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<SCServiceChannelServicesMessagingUserApiAssignedUser>))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> MliConfigurationLevelslevelIdUsers([FromRoute (Name = "levelId")][Required]int levelId);

        /// <summary>
        /// Add a user to an MLI level
        /// </summary>
        /// <remarks>Assigns a user to an existing MLI level. Get users’ IDs by sending the [GET /users](https://developer.servicechannel.com/swagger/ui/index?version&#x3D;3#/Users/GETv3_users_subscriberId__subscriberId__startIndex__startIndex__maxCount__maxCount_) request.              &lt;br /&gt;You can assign a user to an existing location by using the [POST /MliConfiguration/Levels/{levelId}/Users/{userId}/Locations/{locationId}](https://developer.servicechannel.com/swagger/ui/index?version&#x3D;3#/MliConfiguration/POSTv3_MliConfiguration_Levels__levelId__Users__userId__Locations__locationId_) method.              &lt;br /&gt;***Note***: Each user can be added to only one MLI level. If a user should be assigned to another MLI level, you first need to [remove this user from the MLI level](https://developer.servicechannel.com/swagger/ui/index?version&#x3D;3#/MliConfiguration/DELETEv3_mliConfiguration_Levels__levelId__Users__userId_) they currently belong to.</remarks>
        /// <param name="levelId">Numeric identifier of the MLI level.</param>
        /// <param name="userId">Unique numeric identifier of the user.</param>
        /// <response code="200">Returns the created user ID from table dat_Division_User.</response>
        /// <response code="400">The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt; Error codes:              1129 — Err: failed to assign users              1131 — Err: Approval level doesn’t exist              1149 — User has already been assigned to another level              1150 — User does not exist</response>
        /// <response code="401">The request is not authorized.              &lt;br/&gt; Error codes:              504 — API call rejected by security permissions</response>
        /// <response code="403">You are not authorized to request this resource, or the resource is unavailable for some reason.              &lt;br/&gt; Error codes:              100 — User has no rights to perform this action</response>
        [HttpPost]
        [Route("/v3/MliConfiguration/Levels/{levelId}/Users/{userId}")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> MliConfigurationLevelslevelIdUsersuserId([FromRoute (Name = "levelId")][Required]int levelId, [FromRoute (Name = "userId")][Required]int userId);

        /// <summary>
        /// Add a location to a user’s MLI level
        /// </summary>
        /// <remarks>Assigns the specified location to a particular user and user’s MLI level. A location can be removed from a user by sending the [DELETE /MliConfiguration/Levels/{levelId}/Users/{userId}/Locations/{locationId}](https://developer.servicechannel.com/swagger/ui/index?version&#x3D;3#/MliConfiguration/DELETEv3_MliConfiguration_Levels__levelId__Users__userId__Locations__locationId_) request.</remarks>
        /// <param name="levelId">Numeric identifier of the MLI level.</param>
        /// <param name="userId">Unique numeric identifier of the user.</param>
        /// <param name="locationId">Unique numeric identifier of the location.</param>
        /// <response code="200">Returns the created location ID from table dat_Location_Division.</response>
        /// <response code="400">The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt; Error codes:              1128 — Err: Approval level doesn’t exist              1130 — Failed to assign the location to the user              1130 — User is not assigned to the level              1130 — Err: Failed to assign locations to the approval level              1130 — Location doesn’t exist for the current subscriber              1150 — User does not exist              1301 — Request parameters are empty</response>
        /// <response code="401">The request is not authorized.              &lt;br/&gt; Error codes:              504 — API call rejected by security permissions</response>
        /// <response code="403">You are not authorized to request this resource, or the resource is unavailable for some reason.              &lt;br/&gt; Error codes:              100 — User has no rights to perform this action</response>
        [HttpPost]
        [Route("/v3/MliConfiguration/Levels/{levelId}/Users/{userId}/Locations/{locationId}")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> MliConfigurationLevelslevelIdUsersuserIdLocationslocationId([FromRoute (Name = "levelId")][Required]int levelId, [FromRoute (Name = "userId")][Required]int userId, [FromRoute (Name = "locationId")][Required]int locationId);

        /// <summary>
        /// Remove a location from a user’s MLI level
        /// </summary>
        /// <remarks>Removes the specified location from a particular user and MLI level. To assign a location to a user and MLI level, send the [POST /MliConfiguration/Levels/{levelId}/Users/{userId}/Locations/{locationId}](https://developer.servicechannel.com/swagger/ui/index?version&#x3D;3#/MliConfiguration/POSTv3_MliConfiguration_Levels__levelId__Users__userId__Locations__locationId_) request.</remarks>
        /// <param name="levelId">Numeric identifier of the MLI level.</param>
        /// <param name="userId">Unique numeric identifier of the user.</param>
        /// <param name="locationId">Unique numeric identifier of the location.</param>
        /// <response code="204">The specified location is successfully removed from the user’s MLI level.</response>
        /// <response code="400">The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt; Error codes:              1130 — Location is not assigned to the user              1130 — Approval level doesn’t exist              1130 — User is not assigned to the level              1130 — Location doesn’t exist for the current subscriber              1150 — User doesn’t exist              1301 — Request parameters are empty</response>
        /// <response code="401">The request is not authorized.              &lt;br/&gt; Error codes:              504 — API call rejected by security permissions</response>
        /// <response code="403">You are not authorized to request this resource, or the resource is unavailable for some reason.              &lt;br/&gt; Error codes:              100 — User has no rights to perform this action</response>
        [HttpDelete]
        [Route("/v3/MliConfiguration/Levels/{levelId}/Users/{userId}/Locations/{locationId}")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> MliConfigurationLevelslevelIdUsersuserIdLocationslocationId_0([FromRoute (Name = "levelId")][Required]int levelId, [FromRoute (Name = "userId")][Required]int userId, [FromRoute (Name = "locationId")][Required]int locationId);

        /// <summary>
        /// Remove a user from an MLI level
        /// </summary>
        /// <remarks>Removes the specified user from a particular MLI level. To unassign a user from an existing location, send the [DELETE /MliConfiguration/Levels/{levelId}/Users/{userId}/Locations/{locationId}](https://developer.servicechannel.com/swagger/ui/index?version&#x3D;3#/MliConfiguration/DELETEv3_MliConfiguration_Levels__levelId__Users__userId__Locations__locationId_) request.</remarks>
        /// <param name="levelId">Numeric identifier of the MLI level.</param>
        /// <param name="userId">Unique numeric identifier of the user.</param>
        /// <response code="204">The specified user is successfully removed from the MLI level.</response>
        /// <response code="400">The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt; Error codes:              1130 — Err: Approval level doesn’t exist              1130 — User is not assigned to the level              1150 — User does not exist</response>
        /// <response code="401">The request is not authorized.              &lt;br/&gt; Error codes:              504 — API call rejected by security permissions</response>
        /// <response code="403">You are not authorized to request this resource, or the resource is unavailable for some reason.              &lt;br/&gt; Error codes:              100 — User has no rights to perform this action</response>
        [HttpDelete]
        [Route("/v3/mliConfiguration/Levels/{levelId}/Users/{userId}")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> MliConfigurationLevelslevelIdUsersuserId_0([FromRoute (Name = "levelId")][Required]int levelId, [FromRoute (Name = "userId")][Required]int userId);
    }
}
