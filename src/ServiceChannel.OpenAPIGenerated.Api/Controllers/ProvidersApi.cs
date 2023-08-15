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
    public abstract class ProvidersApiController : ControllerBase
    { 
        /// <summary>
        /// Returns standing status of the provider passed
        /// </summary>
        /// <param name="providerId">A provider unique identifier</param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/v3/api/providers/GetStandingStatus")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public abstract Task<IActionResult> ApiProvidersGetStandingStatusproviderIdproviderId([FromQuery (Name = "providerId")][Required()]int providerId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/v3/api/providers/info/{id}")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public abstract Task<IActionResult> ApiProvidersInfoid([FromRoute (Name = "id")][Required]int id);

        /// <summary>
        /// Allows one to get information whether the SDIMobileInt flag is enabled.
        /// </summary>
        /// <remarks>True - if the FF is enabled for a provider and subscriber or for a provider and location.              Otherwise it returns false.</remarks>
        /// <param name="subscriberId">Subscriber id</param>
        /// <param name="locationId">Location id</param>
        /// <response code="200">The request succeeded and the information is retrieved.</response>
        [HttpGet]
        [Route("/v3/api/providers/IsSdiMobileEnabled")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public abstract Task<IActionResult> ApiProvidersIsSdiMobileEnabledsubscriberIdsubscriberIdlocationIdlocationId([FromQuery (Name = "subscriberId")]int? subscriberId, [FromQuery (Name = "locationId")]int? locationId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="providerId"></param>
        /// <param name="subscriberId"></param>
        /// <param name="dashboardId"></param>
        /// <param name="locationId"></param>
        /// <param name="areaId"></param>
        /// <param name="trade"></param>
        /// <param name="problemType"></param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/v3/api/providers/{providerId}/problemtypes")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public abstract Task<IActionResult> ApiProvidersproviderIdProblemtypessubscriberIdsubscriberIddashboardIddashboardIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemType([FromRoute (Name = "providerId")][Required]int providerId, [FromQuery (Name = "subscriberId")][Required()]int subscriberId, [FromQuery (Name = "dashboardId")][Required()]int dashboardId, [FromQuery (Name = "locationId")][Required()]int locationId, [FromQuery (Name = "areaId")][Required()]int areaId, [FromQuery (Name = "trade")][Required()]string trade, [FromQuery (Name = "problemType")][Required()]string problemType);

        /// <summary>
        /// Retrieve providers feedback rating data.
        /// </summary>
        /// <param name="days"></param>
        /// <param name="locationId"></param>
        /// <param name="expand">Expand a navigation property.</param>
        /// <param name="select">Select a set of properties to return.</param>
        /// <param name="filter">Filter a collection of resources addressed by a request URL.</param>
        /// <param name="orderby">Order resources by the specified property in the response.</param>
        /// <param name="top">Return the specified number of items in the response.</param>
        /// <param name="skip">Skip the specified number of items in the response.</param>
        /// <param name="count">Include the count of the matching resources in the response.</param>
        /// <response code="200">The request succeeded and providers are returned.</response>
        /// <response code="400">The request parameters are not valid.</response>
        /// <response code="401">An unauthorized request.</response>
        /// <response code="403">Providers cannot use this method.</response>
        /// <response code="404">The location wasn&#39;t found.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet]
        [Route("/v3/odata/locations({locationId})/providers/Service.GetLast(days={days})")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<SCServiceChannelServicesMessagingProvidersExtendedReviewedProvider>))]
        public abstract Task<IActionResult> GetLast([FromRoute (Name = "days")][Required]int days, [FromRoute (Name = "locationId")][Required]int locationId, [FromQuery (Name = "$expand")]string? expand, [FromQuery (Name = "$select")]string? select, [FromQuery (Name = "$filter")]string? filter, [FromQuery (Name = "$orderby")]string? orderby, [FromQuery (Name = "$top")]int? top, [FromQuery (Name = "$skip")]int? skip, [FromQuery (Name = "$count")]bool? count);

        /// <summary>
        /// Get provider by provider id.
        /// </summary>
        /// <param name="providerId"></param>
        /// <param name="expand">Expand a navigation property.</param>
        /// <param name="select">Select a set of properties to return.</param>
        /// <param name="filter">Filter a collection of resources addressed by a request URL.</param>
        /// <param name="orderby">Order resources by the specified property in the response.</param>
        /// <param name="top">Return the specified number of items in the response.</param>
        /// <param name="skip">Skip the specified number of items in the response.</param>
        /// <param name="count">Include the count of the matching resources in the response.</param>
        /// <response code="200">The request succeeded and the provider is returned.</response>
        /// <response code="401">Unauthorized request.</response>
        /// <response code="403">Providers cannot use this method.</response>
        /// <response code="404">The provider wasn&#39;t found.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet]
        [Route("/v3/odata/detailedProviders/Service.Get(providerId={providerId})")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(SCServiceChannelServicesMessagingProvidersDetailedProvider))]
        public abstract Task<IActionResult> GetProvider([FromRoute (Name = "providerId")][Required]int providerId, [FromQuery (Name = "$expand")]string? expand, [FromQuery (Name = "$select")]string? select, [FromQuery (Name = "$filter")]string? filter, [FromQuery (Name = "$orderby")]string? orderby, [FromQuery (Name = "$top")]int? top, [FromQuery (Name = "$skip")]int? skip, [FromQuery (Name = "$count")]bool? count);

        /// <summary>
        /// Get recent providers for the given location.              \&quot;Recent\&quot; means a provider has completed WOs for a certain time.
        /// </summary>
        /// <param name="days"></param>
        /// <param name="locationId"></param>
        /// <param name="expand">Expand a navigation property.</param>
        /// <param name="select">Select a set of properties to return.</param>
        /// <param name="filter">Filter a collection of resources addressed by a request URL.</param>
        /// <param name="orderby">Order resources by the specified property in the response.</param>
        /// <param name="top">Return the specified number of items in the response.</param>
        /// <param name="skip">Skip the specified number of items in the response.</param>
        /// <param name="count">Include the count of the matching resources in the response.</param>
        /// <response code="200">The request succeeded and providers are returned.</response>
        /// <response code="400">The request parameters are not valid.</response>
        /// <response code="401">An unauthorized request.</response>
        /// <response code="403">Providers cannot use this method.</response>
        /// <response code="404">The location wasn&#39;t found.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet]
        [Route("/v3/odata/locations({locationId})/providers/Service.GetRecent(days={days})")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<SCServiceChannelServicesMessagingProvidersReviewedProvider>))]
        public abstract Task<IActionResult> GetRecent([FromRoute (Name = "days")][Required]int days, [FromRoute (Name = "locationId")][Required]int locationId, [FromQuery (Name = "$expand")]string? expand, [FromQuery (Name = "$select")]string? select, [FromQuery (Name = "$filter")]string? filter, [FromQuery (Name = "$orderby")]string? orderby, [FromQuery (Name = "$top")]int? top, [FromQuery (Name = "$skip")]int? skip, [FromQuery (Name = "$count")]bool? count);

        /// <summary>
        /// Create blank provider
        /// </summary>
        /// <remarks>Create blank provider.</remarks>
        /// <param name="request"></param>
        /// <response code="200">Request succeeded and the requested information is in the response.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 103 - Provider already exists;              &lt;br/&gt; 802 - Invalid user name;              &lt;br/&gt; 806 - User already exists;              &lt;br/&gt; 1150 - User does not exist;</response>
        /// <response code="401">Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions;</response>
        [HttpPost]
        [Route("/v3/providers")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(SCServiceChannelServicesMessagingProvidersCreateBlankProviderResponse))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> Providers([FromBody]SCServiceChannelServicesMessagingProvidersCreateBlankProviderRequest request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/v3/providers/AccountChanged")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(string))]
        public abstract Task<IActionResult> ProvidersAccountChanged([FromBody]SCServiceChannelServicesMessagingProvidersProviderAccountChangedRequest request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="subscriberId"></param>
        /// <param name="dashboardId"></param>
        /// <param name="locationId"></param>
        /// <param name="areaId"></param>
        /// <param name="trade"></param>
        /// <param name="problemType"></param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/v3/providers/current/problemtypes")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public abstract Task<IActionResult> ProvidersCurrentProblemtypessubscriberIdsubscriberIddashboardIddashboardIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemType([FromQuery (Name = "subscriberId")][Required()]int subscriberId, [FromQuery (Name = "dashboardId")][Required()]int dashboardId, [FromQuery (Name = "locationId")][Required()]int locationId, [FromQuery (Name = "areaId")][Required()]int areaId, [FromQuery (Name = "trade")][Required()]string trade, [FromQuery (Name = "problemType")][Required()]string problemType);

        /// <summary>
        /// Receives the Electronic Signature Settings for current user (authorized provider)
        /// </summary>
        /// <param name="workOrderId">Work order id</param>
        /// <response code="200">The request succeeded and the information is retrieved.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 101 - Invalid provider id passed;              &lt;br/&gt; 401 - Invalid subscriber Id;              &lt;br/&gt; 803 - Not provider user;              &lt;br/&gt; 947 - Work order not found;              &lt;br/&gt; 2105 - Feature ReqElecSig is Off;</response>
        [HttpGet]
        [Route("/v3/providers/getESignatureSettings")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(SCServiceChannelServicesMessagingProvidersGetESignatureSettingsResponse))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> ProvidersGetESignatureSettingsworkOrderIdworkOrderId([FromQuery (Name = "workOrderId")][Required()]int workOrderId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="providerId"></param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/v3/providers/getProviderState")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public abstract Task<IActionResult> ProvidersGetProviderStateproviderIdproviderId([FromQuery (Name = "providerId")][Required()]int providerId);

        /// <summary>
        /// Providers For Subscriber User by Trade
        /// </summary>
        /// <remarks>List of Providers.</remarks>
        /// <param name="trade"></param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/v3/providers/getbytrade")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<SCServiceChannelServicesMessagingProvidersProviderInfo>))]
        public abstract Task<IActionResult> ProvidersGetbytradetradetrade([FromQuery (Name = "trade")][Required()]string trade);

        /// <summary>
        /// Delete provider of subscriber
        /// </summary>
        /// <remarks>Delete provider of subscriber.</remarks>
        /// <param name="request"></param>
        /// <response code="200">Request succeeded and the requested information is in the response.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 100 - Invalid provider id passed;              &lt;br/&gt; 400 - Invalid subscriber id passed;              &lt;br/&gt; 503 - Empty Request;              &lt;br/&gt; 500 - Provider subscriber link has not been deleted;              &lt;br/&gt; 1217 - Proccess provider subscriber link error text;</response>
        /// <response code="401">Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions;</response>
        [HttpPost]
        [Route("/v3/providers/RemoveProviderSubscriberLink")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(SCServiceChannelServicesMessagingProvidersCreateBlankProviderResponse))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> ProvidersRemoveProviderSubscriberLink([FromBody]SCServiceChannelServicesMessagingProvidersRemoveProviderSubscriberLinkRequest request);

        /// <summary>
        /// Trained Status for Providers
        /// </summary>
        /// <remarks>List Provider Trained Statuses.</remarks>
        /// <param name="request"></param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/v3/providers/trained")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(List<SCServiceChannelServicesMessagingProvidersGetTrainedProvidersResponse>))]
        public abstract Task<IActionResult> ProvidersTrained([FromBody]SCServiceChannelServicesMessagingProvidersGetTrainedProvidersRequest request);

        /// <summary>
        /// Set isDoNotDispatch value for providers
        /// </summary>
        /// <param name="updateDispatchSettingModel"></param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/v3/providers/updateDispatchSetting")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public abstract Task<IActionResult> ProvidersUpdateDispatchSetting([FromBody]SCServiceChannelServicesWebApiModelsUpdateDispatchSettingModel updateDispatchSettingModel);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="providerId"></param>
        /// <param name="request"></param>
        /// <response code="200">Indicates that the request succeeded and that the requested information is in the response.</response>
        /// <response code="400">Bad Request - the request could not be understood or was missing required parameters.</response>
        /// <response code="401">Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions;</response>
        [HttpPost]
        [Route("/v3/providers/{providerId}/feedback")]
        [Consumes("application/json", "text/json", "application/xml", "text/xml", "application/x-www-form-urlencoded")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        [ProducesResponseType(statusCode: 400, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        [ProducesResponseType(statusCode: 401, type: typeof(SCServiceChannelServicesMessagingErrorResponse))]
        public abstract Task<IActionResult> ProvidersproviderIdFeedback([FromRoute (Name = "providerId")][Required]int providerId, [FromBody]SCServiceChannelServicesMessagingProvidersProviderFeedbackRequest request);
    }
}
