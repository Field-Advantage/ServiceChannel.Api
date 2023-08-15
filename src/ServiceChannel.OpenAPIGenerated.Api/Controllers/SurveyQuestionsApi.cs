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
    public abstract class SurveyQuestionsApiController : ControllerBase
    { 
        /// <summary>
        /// Submit answered questions.
        /// </summary>
        /// <param name="locationId"></param>
        /// <param name="surveyAnsweredQuestions"></param>
        /// <response code="201">Indicates that the request succeeded and that new Answers are added.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.</response>
        /// <response code="401">Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br&gt; 504 - API call rejected by security permissions;</response>
        /// <response code="500">Indicates that an error has occured wile creation of a new Subscriber.</response>
        [HttpPost]
        [Route("/v3/surveyquestions/addanswers/{locationId}")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> SurveyquestionsAddanswerslocationId([FromRoute (Name = "locationId")][Required]int locationId, [FromBody]List<SCServiceChannelApiModelEntitiesSurveyQuestionsSurveyAnsweredQuestion> surveyAnsweredQuestions);

        /// <summary>
        /// Get questions with possible answers for specific location
        /// </summary>
        /// <param name="locationId"></param>
        /// <response code="200">Indicates that the request succeeded and that the requested information is in the response.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.</response>
        /// <response code="401">Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions;</response>
        [HttpGet]
        [Route("/v3/surveyquestions/getwithanswers/{locationId}")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<SCServiceChannelApiModelEntitiesSurveyQuestionsSurveyQuestionWithAnswers>))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> SurveyquestionsGetwithanswerslocationId([FromRoute (Name = "locationId")][Required]int locationId);

        /// <summary>
        /// Get workorder survey answers with questions.
        /// </summary>
        /// <param name="workOrderId"></param>
        /// <response code="200">Indicates that the request succeeded and that the requested information is in the response.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.</response>
        /// <response code="401">Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions;</response>
        [HttpGet]
        [Route("/v3/surveyquestions/workorderanswers/{workOrderId}")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<SCServiceChannelServicesMessagingSurveyQuestionWorkorderAnsweredQuestionResponse>))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> SurveyquestionsWorkorderanswersworkOrderId([FromRoute (Name = "workOrderId")][Required]int workOrderId);
    }
}
