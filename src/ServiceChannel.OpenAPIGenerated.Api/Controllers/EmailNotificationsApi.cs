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
    public abstract class EmailNotificationsApiController : ControllerBase
    { 
        /// <summary>
        /// List existing email subscriptions
        /// </summary>
        /// <remarks>Returns a list of email subscriptions</remarks>
        /// <param name="locationId"></param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/v3/users/current/locations/{locationId}/email")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public abstract Task<IActionResult> UsersCurrentLocationslocationIdEmail([FromRoute (Name = "locationId")][Required]int locationId);

        /// <summary>
        /// Subscribe to Email Notifications
        /// </summary>
        /// <remarks>Subscribe to Email Notification.              &lt;br /&gt;&lt;br /&gt;Available for subscriber usage.</remarks>
        /// <param name="locationId">Numeric Id of the Location to perform action with.</param>
        /// <param name="request">The Subscription Email Notification request.</param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/v3/users/current/locations/{locationId}/subscribe")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public abstract Task<IActionResult> UsersCurrentLocationslocationIdSubscribe([FromRoute (Name = "locationId")][Required]int locationId, [FromBody]SCServiceChannelServicesMessagingNotificationsEmailNotificationSubscriptionRequest request);

        /// <summary>
        /// Unsubscribe from Email Notifications
        /// </summary>
        /// <remarks>Unsubscribe from Email Notifications.              &lt;br /&gt;&lt;br /&gt;Available for subscriber usage.</remarks>
        /// <param name="locationId">Numeric Id of the Location to perform action with.</param>
        /// <param name="notificationType">Notification type: Check In , ....</param>
        /// <param name="id">Numeric Id of the Subscription to perform action with.</param>
        /// <param name="languageCode">ISO 639-1 two-letter code for the language.</param>
        /// <param name="notificationRulesRules"></param>
        /// <response code="200">OK</response>
        [HttpDelete]
        [Route("/v3/users/current/locations/{locationId}/unsubscribe")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public abstract Task<IActionResult> UsersCurrentLocationslocationIdUnsubscribeidid([FromRoute (Name = "locationId")][Required]int locationId, [FromQuery (Name = "notificationType")][Required()]string notificationType, [FromQuery (Name = "id")]int? id, [FromQuery (Name = "languageCode")]string? languageCode, [FromQuery (Name = "notificationRules.rules")]List<Object>? notificationRulesRules);

        /// <summary>
        /// Unsubscribe from Email Notifications
        /// </summary>
        /// <remarks>Unsubscribe from Email Notifications.              &lt;br /&gt;&lt;br /&gt;Available for subscriber usage.</remarks>
        /// <response code="200">OK</response>
        [HttpDelete]
        [Route("/v3/users/current/unsubscribe")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public abstract Task<IActionResult> UsersCurrentUnsubscribe();
    }
}