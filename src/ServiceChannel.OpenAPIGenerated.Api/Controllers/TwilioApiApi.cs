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
    public abstract class TwilioApiApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/v3/twilio/Sms")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public abstract Task<IActionResult> TwilioSms([FromBody]SCTwilioAspNetCommonSmsRequest request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="smsSid"></param>
        /// <param name="body"></param>
        /// <param name="messageStatus"></param>
        /// <param name="accountSid"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="fromCity"></param>
        /// <param name="fromState"></param>
        /// <param name="fromZip"></param>
        /// <param name="fromCountry"></param>
        /// <param name="toCity"></param>
        /// <param name="toState"></param>
        /// <param name="toZip"></param>
        /// <param name="toCountry"></param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/v3/twilio/Sms")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public abstract Task<IActionResult> TwilioSmsSmsSidSmsSidBodyBodyMessageStatusMessageStatusAccountSidAccountSidFromFromToToFromCityFromCityFromStateFromStateFromZipFromZipFromCountryFromCountryToCityToCityToStateToStateToZipToZipToCountryToCountry([FromQuery (Name = "smsSid")]string? smsSid, [FromQuery (Name = "body")]string? body, [FromQuery (Name = "messageStatus")]string? messageStatus, [FromQuery (Name = "accountSid")]string? accountSid, [FromQuery (Name = "from")]string? from, [FromQuery (Name = "to")]string? to, [FromQuery (Name = "fromCity")]string? fromCity, [FromQuery (Name = "fromState")]string? fromState, [FromQuery (Name = "fromZip")]string? fromZip, [FromQuery (Name = "fromCountry")]string? fromCountry, [FromQuery (Name = "toCity")]string? toCity, [FromQuery (Name = "toState")]string? toState, [FromQuery (Name = "toZip")]string? toZip, [FromQuery (Name = "toCountry")]string? toCountry);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/v3/twilio/SmsStatus")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public abstract Task<IActionResult> TwilioSmsStatus([FromBody]SCTwilioAspNetCommonSmsRequest request);
    }
}
