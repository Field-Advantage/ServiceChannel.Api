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
    public abstract class UsersApiController : ControllerBase
    { 
        /// <summary>
        /// Retrieve provider users with the specified employee ID
        /// </summary>
        /// <remarks>Returns a list of provider users with the specified employee ID. Provider admins can set an employee identifier on the **Employee Details** tab of the user profile.              &lt;br /&gt;***Note:*** This method is only available to provider users with the *Provider Automation Admin* role.</remarks>
        /// <param name="employeeId">Non-unique identifier of a provider user.</param>
        /// <response code="200">Provider users with the specified employee ID are in the response.</response>
        [HttpGet]
        [Route("/v3/employees/{employeeId}/users")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<SCServiceChannelServicesMessagingUsersUser>))]
        public abstract Task<IActionResult> EmployeesemployeeIdUsers([FromRoute (Name = "employeeId")][Required]string employeeId);

        /// <summary>
        /// Retrieve list of Users. Available for \&quot;Power User\&quot;, \&quot;Super Admin\&quot;, \&quot;SC Admin\&quot;, \&quot;Provider Power User\&quot;, \&quot;Project Manager\&quot;
        /// </summary>
        /// <remarks>&lt;para&gt;Available for \&quot;Power User\&quot;, \&quot;Super Admin\&quot;, \&quot;SC Admin\&quot;, \&quot;Provider Power User\&quot;, \&quot;Project Manager\&quot;&lt;/para&gt;</remarks>
        /// <param name="expand">Expand a navigation property.</param>
        /// <param name="select">Select a set of properties to return.</param>
        /// <param name="filter">Filter a collection of resources addressed by a request URL.</param>
        /// <param name="orderby">Order resources by the specified property in the response.</param>
        /// <param name="top">Return the specified number of items in the response.</param>
        /// <param name="skip">Skip the specified number of items in the response.</param>
        /// <param name="count">Include the count of the matching resources in the response.</param>
        /// <response code="200">Indicates that the request succeeded and that the requested information is in the response.</response>
        [HttpGet]
        [Route("/v3/odata/users")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<SCServiceChannelServicesMessagingUsersUser>))]
        public abstract Task<IActionResult> GetUsers([FromQuery (Name = "$expand")]string? expand, [FromQuery (Name = "$select")]string? select, [FromQuery (Name = "$filter")]string? filter, [FromQuery (Name = "$orderby")]string? orderby, [FromQuery (Name = "$top")]int? top, [FromQuery (Name = "$skip")]int? skip, [FromQuery (Name = "$count")]bool? count);

        /// <summary>
        /// Retrieve list of Users for specified Provider. Available for \&quot;SC Admin\&quot;
        /// </summary>
        /// <remarks>&lt;para&gt;Available for \&quot;SC Admin\&quot;&lt;/para&gt;</remarks>
        /// <param name="providerId"></param>
        /// <param name="expand">Expand a navigation property.</param>
        /// <param name="select">Select a set of properties to return.</param>
        /// <param name="filter">Filter a collection of resources addressed by a request URL.</param>
        /// <param name="orderby">Order resources by the specified property in the response.</param>
        /// <param name="top">Return the specified number of items in the response.</param>
        /// <param name="skip">Skip the specified number of items in the response.</param>
        /// <param name="count">Include the count of the matching resources in the response.</param>
        /// <response code="200">Indicates that the request succeeded and that the requested information is in the response.</response>
        [HttpGet]
        [Route("/v3/odata/providers({providerId})/users")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<SCServiceChannelServicesMessagingUsersUser>))]
        public abstract Task<IActionResult> GetUsersForProvider([FromRoute (Name = "providerId")][Required]int providerId, [FromQuery (Name = "$expand")]string? expand, [FromQuery (Name = "$select")]string? select, [FromQuery (Name = "$filter")]string? filter, [FromQuery (Name = "$orderby")]string? orderby, [FromQuery (Name = "$top")]int? top, [FromQuery (Name = "$skip")]int? skip, [FromQuery (Name = "$count")]bool? count);

        /// <summary>
        /// Retrieve list of Users for specified Subscriber. Available for \&quot;SC Admin\&quot;
        /// </summary>
        /// <remarks>&lt;para&gt;Available for \&quot;SC Admin\&quot;&lt;/para&gt;</remarks>
        /// <param name="subscriberId"></param>
        /// <param name="expand">Expand a navigation property.</param>
        /// <param name="select">Select a set of properties to return.</param>
        /// <param name="filter">Filter a collection of resources addressed by a request URL.</param>
        /// <param name="orderby">Order resources by the specified property in the response.</param>
        /// <param name="top">Return the specified number of items in the response.</param>
        /// <param name="skip">Skip the specified number of items in the response.</param>
        /// <param name="count">Include the count of the matching resources in the response.</param>
        /// <response code="200">Indicates that the request succeeded and that the requested information is in the response.</response>
        [HttpGet]
        [Route("/v3/odata/subscribers({subscriberId})/users")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<SCServiceChannelServicesMessagingUsersUser>))]
        public abstract Task<IActionResult> GetUsersForSubscriber([FromRoute (Name = "subscriberId")][Required]int subscriberId, [FromQuery (Name = "$expand")]string? expand, [FromQuery (Name = "$select")]string? select, [FromQuery (Name = "$filter")]string? filter, [FromQuery (Name = "$orderby")]string? orderby, [FromQuery (Name = "$top")]int? top, [FromQuery (Name = "$skip")]int? skip, [FromQuery (Name = "$count")]bool? count);

        /// <summary>
        /// Create a user
        /// </summary>
        /// <remarks>Creates a new user. Returns a unique user ID for a successful request.              &lt;br /&gt;***Note:*** Available for subscribers with the Admin User and Super Admin secondary roles.</remarks>
        /// <param name="request">The user object that needs to be created.</param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/v3/users")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public abstract Task<IActionResult> Users([FromBody]SCServiceChannelServicesMessagingUsersAddUserRequest request);

        /// <summary>
        /// Returns user location note restrictions object
        /// </summary>
        /// <response code="200">Indicates that the request succeeded and that the requested information is in the response.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.</response>
        /// <response code="401">Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions;</response>
        /// <response code="500">Indicates that a generic error has occurred on the server.</response>
        [HttpGet]
        [Route("/v3/users/current/locationNoteRestrictions")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<SCServiceChannelServicesMessagingUserUserLocationNoteRestrictionResponse>))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> UsersCurrentLocationNoteRestrictions();

        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">Indicates that the request succeeded and that the requested information is in the response.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.</response>
        /// <response code="401">Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions;</response>
        /// <response code="403">Indicates that the requested resource not allowed for current user.</response>
        /// <response code="404">Indicates that the requested resource does not exist on the server.              &lt;br/&gt;Error codes:              &lt;br/&gt; 502 - Users not found;</response>
        [HttpGet]
        [Route("/v3/users/current/menu")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(SCServiceChannelServicesMessagingMenuResponse))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> UsersCurrentMenu();

        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/v3/users/current/profile")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public abstract Task<IActionResult> UsersCurrentProfile();

        /// <summary>
        /// Returns user features object
        /// </summary>
        /// <response code="200">Indicates that the request succeeded and that the requested information is in the response.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.</response>
        /// <response code="401">Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions;</response>
        /// <response code="500">Indicates that a generic error has occurred on the server.</response>
        [HttpGet]
        [Route("/v3/users/features")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(SCServiceChannelServicesMessagingApplicationAccessFeatureResponse))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> UsersFeatures();

        /// <summary>
        /// Retrieve user localization settings
        /// </summary>
        /// <response code="200">User Localization settings are in the response.</response>
        [HttpGet]
        [Route("/v3/users/regionalSettings")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(SCServiceChannelServicesMessagingUserUserLocalizationSettings))]
        public abstract Task<IActionResult> UsersRegionalSettings();

        /// <summary>
        /// Retrieve a User
        /// </summary>
        /// <remarks>Returns the information of the specified user.</remarks>
        /// <param name="id">Numeric Id of the User to perform action with.</param>
        /// <response code="200">Indicates that the request succeeded and that the requested information is in the response.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.</response>
        /// <response code="404">Indicates that the requested resource does not exist on the server.              &lt;br/&gt;Error codes:              &lt;br/&gt;502 - User not found;</response>
        [HttpGet]
        [Route("/v3/users/{id}")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(SCServiceChannelServicesMessagingUsersGetUserResponse))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> Usersid([FromRoute (Name = "id")][Required]int id);

        /// <summary>
        /// Update User
        /// </summary>
        /// <remarks>Updates the information of the specified user. Returns User Id for successful request.              &lt;br /&gt;&lt;br /&gt;Available for Super Admin, SC Admin, Provider Power Users usage.</remarks>
        /// <param name="id">Numeric Id of the User to perform action with.</param>
        /// <param name="request">The request model to perform action with.</param>
        /// <response code="200">Indicates that the request succeeded and that the requested information is in the response.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.</response>
        /// <response code="401">Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions;</response>
        /// <response code="403">Indicates that the server refuses to fulfill the request.</response>
        /// <response code="500">Indicates that a generic error has occurred on the server.</response>
        [HttpPut]
        [Route("/v3/users/{id}")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 403, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> Usersid_0([FromRoute (Name = "id")][Required]int id, [FromBody]SCServiceChannelServicesMessagingUsersUpdateUserRequest request);

        /// <summary>
        /// Remove the User
        /// </summary>
        /// <remarks>Removes the User with specified id. Returns User Id for successful request.              &lt;br /&gt;&lt;br /&gt;Available for Super Admin, SC Admin, Provider Power Users usage.</remarks>
        /// <param name="id">Numeric Id of the User to perform action with.</param>
        /// <response code="200">Indicates that the request succeeded and that the requested information is in the response.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.</response>
        /// <response code="401">Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions;</response>
        /// <response code="404">Indicates that the requested resource does not exist on the server.</response>
        [HttpDelete]
        [Route("/v3/users/{id}")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> Usersid_1([FromRoute (Name = "id")][Required]int id);

        /// <summary>
        /// Patch user&#39;s info
        /// </summary>
        /// <param name="id">User identifier</param>
        /// <param name="request">Patch user&#39;s profile info model (only properties to be patched)</param>
        /// <response code="200">Indicates that the update user profile request was successful.</response>
        /// <response code="401">Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions;</response>
        /// <response code="500">Indicates that a generic error has occurred on the server.              &lt;br/&gt;Error codes:              &lt;br/&gt; 501 - Unhandled exception occurred</response>
        [HttpPatch]
        [Route("/v3/users/{id}")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> Usersid_2([FromRoute (Name = "id")][Required]int id, [FromBody]Dictionary<string, Object> request);

        /// <summary>
        /// Users Collection
        /// </summary>
        /// <remarks>Returns the list of all users of the current subscriber (the main user is also included) for successful request.              &lt;br /&gt;&lt;br /&gt;Available for subscriber usage (Power User, Super Admin, SC Admin).</remarks>
        /// <param name="subscriberId">For &#39;SC Admin&#39; users only - ability to specify subscriber. Optional</param>
        /// <param name="startIndex">Start item index. Optional, 0 by Default</param>
        /// <param name="maxCount">Items count to get. Optional, all items by Default.</param>
        /// <response code="200">Indicates that the request succeeded and that the requested information is in the response.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.</response>
        /// <response code="401">Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions;</response>
        /// <response code="404">Indicates that the requested resource does not exist on the server.              &lt;br/&gt;Error codes:              &lt;br/&gt; 502 - Users not found;</response>
        [HttpGet]
        [Route("/v3/users")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<SCServiceChannelServicesMessagingUsersUser>))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 404, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> UserssubscriberIdsubscriberIdstartIndexstartIndexmaxCountmaxCount([FromQuery (Name = "subscriberId")]int? subscriberId, [FromQuery (Name = "startIndex")]int? startIndex, [FromQuery (Name = "maxCount")]int? maxCount);

        /// <summary>
        /// Is locked
        /// </summary>
        /// <remarks>Returns true if requested user is locked.              &lt;br /&gt;&lt;br /&gt;Available for Super Admin, SC Admin users usage.</remarks>
        /// <param name="userId">Numeric Id of the User to perform action with.</param>
        /// <response code="200">Indicates that the request succeeded and that the requested information is in the response.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.</response>
        /// <response code="401">Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions;</response>
        /// <response code="500">Indicates that a generic error has occurred on the server.</response>
        [HttpGet]
        [Route("/v3/users/{userId}/islocked")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(bool))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 500, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> UsersuserIdIslocked([FromRoute (Name = "userId")][Required]int userId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/v3/users/{userId}/menu")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public abstract Task<IActionResult> UsersuserIdMenu([FromRoute (Name = "userId")][Required]int userId);
    }
}
