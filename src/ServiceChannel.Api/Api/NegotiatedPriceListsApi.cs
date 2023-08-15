/*
 * ServiceChannel API - v.3
 *
 * The ServiceChannel API is a RESTful and stateless API. It accepts standard HTTP verbs and supports OAuth 2.0 for authorizing requests.      Our API returns common HTTP status codes as well as JSON encapsulated data.      See [API Overview](https://developer.servicechannel.com/basics/introduction/overview/) for the intro to ServiceChannel API.<br>      <h3>Authentication and Authorization</h3>You should have a ServiceChannel account, register your application, and obtain `access_token` to integrate with our API.      See [Authentication and Authorization](https://developer.servicechannel.com/basics/general/authentication/) for more information.      To use this API playground, click **Authorize** and sign in to ServiceChannel.<br>      <h3>Environment</h3> All calls in this API Reference point to the **SB2 environment**.      See [Environments](https://developer.servicechannel.com/basics/general/environments/) for more information.<br>      <h3>API Version</h3>The current stable version of the ServiceChannel API is `v3`. In the request URL, `v3` is a version prefix that should be present.      When you omit the version prefix, calls point to the minimum supported version of the API.      We recommend you to always specify the API version to avoid possible errors.
 *
 * The version of the OpenAPI document: 3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Client.Auth;
using ServiceChannel.Api.Model;

namespace ServiceChannel.Api.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface INegotiatedPriceListsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get negotiated pricelists
        /// </summary>
        /// <exception cref="ServiceChannel.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListName">Unique Price List Identifier (optional)</param>
        /// <param name="providerId">Unique Provider Identifier (optional)</param>
        /// <param name="locationId">Unique Location Identifier (optional)</param>
        /// <param name="applyDatesFilter">true: Current date between priceList.EffectiveDate and priceList.ExpirationDate; false: date filter is disabled (optional, default to false)</param>
        /// <param name="isReturnDeleted">Return deleted items PriceList Parts and PriceList Other Charges (optional, default to false)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList</returns>
        SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList NegotiatedpricelistsNegotiatedpricelistspriceListNamepriceListNameproviderIdproviderIdlocationIdlocationIdapplyDatesFilterapplyDatesFilterisReturnDeletedisReturnDeleted(string? priceListName = default(string?), int? providerId = default(int?), int? locationId = default(int?), bool? applyDatesFilter = default(bool?), bool? isReturnDeleted = default(bool?), int operationIndex = 0);

        /// <summary>
        /// Get negotiated pricelists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ServiceChannel.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListName">Unique Price List Identifier (optional)</param>
        /// <param name="providerId">Unique Provider Identifier (optional)</param>
        /// <param name="locationId">Unique Location Identifier (optional)</param>
        /// <param name="applyDatesFilter">true: Current date between priceList.EffectiveDate and priceList.ExpirationDate; false: date filter is disabled (optional, default to false)</param>
        /// <param name="isReturnDeleted">Return deleted items PriceList Parts and PriceList Other Charges (optional, default to false)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList</returns>
        ApiResponse<SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList> NegotiatedpricelistsNegotiatedpricelistspriceListNamepriceListNameproviderIdproviderIdlocationIdlocationIdapplyDatesFilterapplyDatesFilterisReturnDeletedisReturnDeletedWithHttpInfo(string? priceListName = default(string?), int? providerId = default(int?), int? locationId = default(int?), bool? applyDatesFilter = default(bool?), bool? isReturnDeleted = default(bool?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface INegotiatedPriceListsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get negotiated pricelists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ServiceChannel.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListName">Unique Price List Identifier (optional)</param>
        /// <param name="providerId">Unique Provider Identifier (optional)</param>
        /// <param name="locationId">Unique Location Identifier (optional)</param>
        /// <param name="applyDatesFilter">true: Current date between priceList.EffectiveDate and priceList.ExpirationDate; false: date filter is disabled (optional, default to false)</param>
        /// <param name="isReturnDeleted">Return deleted items PriceList Parts and PriceList Other Charges (optional, default to false)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList</returns>
        System.Threading.Tasks.Task<SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList> NegotiatedpricelistsNegotiatedpricelistspriceListNamepriceListNameproviderIdproviderIdlocationIdlocationIdapplyDatesFilterapplyDatesFilterisReturnDeletedisReturnDeletedAsync(string? priceListName = default(string?), int? providerId = default(int?), int? locationId = default(int?), bool? applyDatesFilter = default(bool?), bool? isReturnDeleted = default(bool?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get negotiated pricelists
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ServiceChannel.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListName">Unique Price List Identifier (optional)</param>
        /// <param name="providerId">Unique Provider Identifier (optional)</param>
        /// <param name="locationId">Unique Location Identifier (optional)</param>
        /// <param name="applyDatesFilter">true: Current date between priceList.EffectiveDate and priceList.ExpirationDate; false: date filter is disabled (optional, default to false)</param>
        /// <param name="isReturnDeleted">Return deleted items PriceList Parts and PriceList Other Charges (optional, default to false)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList)</returns>
        System.Threading.Tasks.Task<ApiResponse<SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList>> NegotiatedpricelistsNegotiatedpricelistspriceListNamepriceListNameproviderIdproviderIdlocationIdlocationIdapplyDatesFilterapplyDatesFilterisReturnDeletedisReturnDeletedWithHttpInfoAsync(string? priceListName = default(string?), int? providerId = default(int?), int? locationId = default(int?), bool? applyDatesFilter = default(bool?), bool? isReturnDeleted = default(bool?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface INegotiatedPriceListsApi : INegotiatedPriceListsApiSync, INegotiatedPriceListsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class NegotiatedPriceListsApi : INegotiatedPriceListsApi
    {
        private ServiceChannel.Api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="NegotiatedPriceListsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NegotiatedPriceListsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NegotiatedPriceListsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NegotiatedPriceListsApi(string basePath)
        {
            this.Configuration = ServiceChannel.Api.Client.Configuration.MergeConfigurations(
                ServiceChannel.Api.Client.GlobalConfiguration.Instance,
                new ServiceChannel.Api.Client.Configuration { BasePath = basePath }
            );
            this.Client = new ServiceChannel.Api.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new ServiceChannel.Api.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = ServiceChannel.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NegotiatedPriceListsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public NegotiatedPriceListsApi(ServiceChannel.Api.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = ServiceChannel.Api.Client.Configuration.MergeConfigurations(
                ServiceChannel.Api.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new ServiceChannel.Api.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new ServiceChannel.Api.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = ServiceChannel.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NegotiatedPriceListsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public NegotiatedPriceListsApi(ServiceChannel.Api.Client.ISynchronousClient client, ServiceChannel.Api.Client.IAsynchronousClient asyncClient, ServiceChannel.Api.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = ServiceChannel.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public ServiceChannel.Api.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public ServiceChannel.Api.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public ServiceChannel.Api.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ServiceChannel.Api.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Get negotiated pricelists 
        /// </summary>
        /// <exception cref="ServiceChannel.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListName">Unique Price List Identifier (optional)</param>
        /// <param name="providerId">Unique Provider Identifier (optional)</param>
        /// <param name="locationId">Unique Location Identifier (optional)</param>
        /// <param name="applyDatesFilter">true: Current date between priceList.EffectiveDate and priceList.ExpirationDate; false: date filter is disabled (optional, default to false)</param>
        /// <param name="isReturnDeleted">Return deleted items PriceList Parts and PriceList Other Charges (optional, default to false)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList</returns>
        public SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList NegotiatedpricelistsNegotiatedpricelistspriceListNamepriceListNameproviderIdproviderIdlocationIdlocationIdapplyDatesFilterapplyDatesFilterisReturnDeletedisReturnDeleted(string? priceListName = default(string?), int? providerId = default(int?), int? locationId = default(int?), bool? applyDatesFilter = default(bool?), bool? isReturnDeleted = default(bool?), int operationIndex = 0)
        {
            ServiceChannel.Api.Client.ApiResponse<SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList> localVarResponse = NegotiatedpricelistsNegotiatedpricelistspriceListNamepriceListNameproviderIdproviderIdlocationIdlocationIdapplyDatesFilterapplyDatesFilterisReturnDeletedisReturnDeletedWithHttpInfo(priceListName, providerId, locationId, applyDatesFilter, isReturnDeleted);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get negotiated pricelists 
        /// </summary>
        /// <exception cref="ServiceChannel.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListName">Unique Price List Identifier (optional)</param>
        /// <param name="providerId">Unique Provider Identifier (optional)</param>
        /// <param name="locationId">Unique Location Identifier (optional)</param>
        /// <param name="applyDatesFilter">true: Current date between priceList.EffectiveDate and priceList.ExpirationDate; false: date filter is disabled (optional, default to false)</param>
        /// <param name="isReturnDeleted">Return deleted items PriceList Parts and PriceList Other Charges (optional, default to false)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList</returns>
        public ServiceChannel.Api.Client.ApiResponse<SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList> NegotiatedpricelistsNegotiatedpricelistspriceListNamepriceListNameproviderIdproviderIdlocationIdlocationIdapplyDatesFilterapplyDatesFilterisReturnDeletedisReturnDeletedWithHttpInfo(string? priceListName = default(string?), int? providerId = default(int?), int? locationId = default(int?), bool? applyDatesFilter = default(bool?), bool? isReturnDeleted = default(bool?), int operationIndex = 0)
        {
            ServiceChannel.Api.Client.RequestOptions localVarRequestOptions = new ServiceChannel.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };

            var localVarContentType = ServiceChannel.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ServiceChannel.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (priceListName != null)
            {
                localVarRequestOptions.QueryParameters.Add(ServiceChannel.Api.Client.ClientUtils.ParameterToMultiMap("", "priceListName", priceListName));
            }
            if (providerId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ServiceChannel.Api.Client.ClientUtils.ParameterToMultiMap("", "providerId", providerId));
            }
            if (locationId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ServiceChannel.Api.Client.ClientUtils.ParameterToMultiMap("", "locationId", locationId));
            }
            if (applyDatesFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(ServiceChannel.Api.Client.ClientUtils.ParameterToMultiMap("", "applyDatesFilter", applyDatesFilter));
            }
            if (isReturnDeleted != null)
            {
                localVarRequestOptions.QueryParameters.Add(ServiceChannel.Api.Client.ClientUtils.ParameterToMultiMap("", "isReturnDeleted", isReturnDeleted));
            }

            localVarRequestOptions.Operation = "NegotiatedPriceListsApi.NegotiatedpricelistsNegotiatedpricelistspriceListNamepriceListNameproviderIdproviderIdlocationIdlocationIdapplyDatesFilterapplyDatesFilterisReturnDeletedisReturnDeleted";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (oauth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList>("/negotiatedpricelists/negotiatedpricelists", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("NegotiatedpricelistsNegotiatedpricelistspriceListNamepriceListNameproviderIdproviderIdlocationIdlocationIdapplyDatesFilterapplyDatesFilterisReturnDeletedisReturnDeleted", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get negotiated pricelists 
        /// </summary>
        /// <exception cref="ServiceChannel.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListName">Unique Price List Identifier (optional)</param>
        /// <param name="providerId">Unique Provider Identifier (optional)</param>
        /// <param name="locationId">Unique Location Identifier (optional)</param>
        /// <param name="applyDatesFilter">true: Current date between priceList.EffectiveDate and priceList.ExpirationDate; false: date filter is disabled (optional, default to false)</param>
        /// <param name="isReturnDeleted">Return deleted items PriceList Parts and PriceList Other Charges (optional, default to false)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList</returns>
        public async System.Threading.Tasks.Task<SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList> NegotiatedpricelistsNegotiatedpricelistspriceListNamepriceListNameproviderIdproviderIdlocationIdlocationIdapplyDatesFilterapplyDatesFilterisReturnDeletedisReturnDeletedAsync(string? priceListName = default(string?), int? providerId = default(int?), int? locationId = default(int?), bool? applyDatesFilter = default(bool?), bool? isReturnDeleted = default(bool?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ServiceChannel.Api.Client.ApiResponse<SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList> localVarResponse = await NegotiatedpricelistsNegotiatedpricelistspriceListNamepriceListNameproviderIdproviderIdlocationIdlocationIdapplyDatesFilterapplyDatesFilterisReturnDeletedisReturnDeletedWithHttpInfoAsync(priceListName, providerId, locationId, applyDatesFilter, isReturnDeleted, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get negotiated pricelists 
        /// </summary>
        /// <exception cref="ServiceChannel.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListName">Unique Price List Identifier (optional)</param>
        /// <param name="providerId">Unique Provider Identifier (optional)</param>
        /// <param name="locationId">Unique Location Identifier (optional)</param>
        /// <param name="applyDatesFilter">true: Current date between priceList.EffectiveDate and priceList.ExpirationDate; false: date filter is disabled (optional, default to false)</param>
        /// <param name="isReturnDeleted">Return deleted items PriceList Parts and PriceList Other Charges (optional, default to false)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList)</returns>
        public async System.Threading.Tasks.Task<ServiceChannel.Api.Client.ApiResponse<SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList>> NegotiatedpricelistsNegotiatedpricelistspriceListNamepriceListNameproviderIdproviderIdlocationIdlocationIdapplyDatesFilterapplyDatesFilterisReturnDeletedisReturnDeletedWithHttpInfoAsync(string? priceListName = default(string?), int? providerId = default(int?), int? locationId = default(int?), bool? applyDatesFilter = default(bool?), bool? isReturnDeleted = default(bool?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            ServiceChannel.Api.Client.RequestOptions localVarRequestOptions = new ServiceChannel.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };

            var localVarContentType = ServiceChannel.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ServiceChannel.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (priceListName != null)
            {
                localVarRequestOptions.QueryParameters.Add(ServiceChannel.Api.Client.ClientUtils.ParameterToMultiMap("", "priceListName", priceListName));
            }
            if (providerId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ServiceChannel.Api.Client.ClientUtils.ParameterToMultiMap("", "providerId", providerId));
            }
            if (locationId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ServiceChannel.Api.Client.ClientUtils.ParameterToMultiMap("", "locationId", locationId));
            }
            if (applyDatesFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(ServiceChannel.Api.Client.ClientUtils.ParameterToMultiMap("", "applyDatesFilter", applyDatesFilter));
            }
            if (isReturnDeleted != null)
            {
                localVarRequestOptions.QueryParameters.Add(ServiceChannel.Api.Client.ClientUtils.ParameterToMultiMap("", "isReturnDeleted", isReturnDeleted));
            }

            localVarRequestOptions.Operation = "NegotiatedPriceListsApi.NegotiatedpricelistsNegotiatedpricelistspriceListNamepriceListNameproviderIdproviderIdlocationIdlocationIdapplyDatesFilterapplyDatesFilterisReturnDeletedisReturnDeleted";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (oauth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList>("/negotiatedpricelists/negotiatedpricelists", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("NegotiatedpricelistsNegotiatedpricelistspriceListNamepriceListNameproviderIdproviderIdlocationIdlocationIdapplyDatesFilterapplyDatesFilterisReturnDeletedisReturnDeleted", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
