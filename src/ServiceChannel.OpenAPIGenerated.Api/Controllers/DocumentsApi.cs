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
    public abstract class DocumentsApiController : ControllerBase
    { 
        /// <summary>
        /// GET example: https://localhost:1871/api/s3?attachmentId&#x3D;tests/S3Test/ef7031654d5b4259b260586300660352.txt
        /// </summary>
        /// <param name="attachmentId">The attachment Id.</param>
        /// <param name="overrideFileName">The override file name.</param>
        /// <param name="signature">The override file name.</param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/v3/api/documents/GetTempLink")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public abstract Task<IActionResult> ApiDocumentsGetTempLinkattachmentIdattachmentIdoverrideFileNameoverrideFileNamesignaturesignature([FromQuery (Name = "attachmentId")][Required()]string attachmentId, [FromQuery (Name = "overrideFileName")]string? overrideFileName, [FromQuery (Name = "signature")]string? signature);

        /// <summary>
        /// GET example: https://localhost:1871/api/s3?attachmentId&#x3D;tests/S3Test/ef7031654d5b4259b260586300660352.txt
        /// </summary>
        /// <param name="attachmentId">The attachment Id.</param>
        /// <param name="overrideFileName">The override file name.</param>
        /// <param name="signature">The override file name.</param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/v3/documents/GetTempLink")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public abstract Task<IActionResult> DocumentsGetTempLinkattachmentIdattachmentIdoverrideFileNameoverrideFileNamesignaturesignature([FromQuery (Name = "attachmentId")][Required()]string attachmentId, [FromQuery (Name = "overrideFileName")]string? overrideFileName, [FromQuery (Name = "signature")]string? signature);
    }
}
