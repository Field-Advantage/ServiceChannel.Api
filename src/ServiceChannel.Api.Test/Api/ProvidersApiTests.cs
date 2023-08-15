/*
 * ServiceChannel API - v.3
 *
 * The ServiceChannel API is a RESTful and stateless API. It accepts standard HTTP verbs and supports OAuth 2.0 for authorizing requests.      Our API returns common HTTP status codes as well as JSON encapsulated data.      See [API Overview](https://developer.servicechannel.com/basics/introduction/overview/) for the intro to ServiceChannel API.<br>      <h3>Authentication and Authorization</h3>You should have a ServiceChannel account, register your application, and obtain `access_token` to integrate with our API.      See [Authentication and Authorization](https://developer.servicechannel.com/basics/general/authentication/) for more information.      To use this API playground, click **Authorize** and sign in to ServiceChannel.<br>      <h3>Environment</h3> All calls in this API Reference point to the **SB2 environment**.      See [Environments](https://developer.servicechannel.com/basics/general/environments/) for more information.<br>      <h3>API Version</h3>The current stable version of the ServiceChannel API is `v3`. In the request URL, `v3` is a version prefix that should be present.      When you omit the version prefix, calls point to the minimum supported version of the API.      We recommend you to always specify the API version to avoid possible errors.
 *
 * The version of the OpenAPI document: 3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using ServiceChannel.Api.Client;
using ServiceChannel.Api.Api;
// uncomment below to import models
//using ServiceChannel.Api.Model;

namespace ServiceChannel.Api.Test.Api
{
    /// <summary>
    ///  Class for testing ProvidersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProvidersApiTests : IDisposable
    {
        private ProvidersApi instance;

        public ProvidersApiTests()
        {
            instance = new ProvidersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProvidersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ProvidersApi
            //Assert.IsType<ProvidersApi>(instance);
        }

        /// <summary>
        /// Test ApiProvidersGetStandingStatusproviderIdproviderId
        /// </summary>
        [Fact]
        public void ApiProvidersGetStandingStatusproviderIdproviderIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int providerId = null;
            //var response = instance.ApiProvidersGetStandingStatusproviderIdproviderId(providerId);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test ApiProvidersInfoid
        /// </summary>
        [Fact]
        public void ApiProvidersInfoidTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.ApiProvidersInfoid(id);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test ApiProvidersIsSdiMobileEnabledsubscriberIdsubscriberIdlocationIdlocationId
        /// </summary>
        [Fact]
        public void ApiProvidersIsSdiMobileEnabledsubscriberIdsubscriberIdlocationIdlocationIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? subscriberId = null;
            //int? locationId = null;
            //var response = instance.ApiProvidersIsSdiMobileEnabledsubscriberIdsubscriberIdlocationIdlocationId(subscriberId, locationId);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test ApiProvidersproviderIdProblemtypessubscriberIdsubscriberIddashboardIddashboardIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemType
        /// </summary>
        [Fact]
        public void ApiProvidersproviderIdProblemtypessubscriberIdsubscriberIddashboardIddashboardIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int providerId = null;
            //int subscriberId = null;
            //int dashboardId = null;
            //int locationId = null;
            //int areaId = null;
            //string trade = null;
            //string problemType = null;
            //var response = instance.ApiProvidersproviderIdProblemtypessubscriberIdsubscriberIddashboardIddashboardIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemType(providerId, subscriberId, dashboardId, locationId, areaId, trade, problemType);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetLast
        /// </summary>
        [Fact]
        public void GetLastTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int days = null;
            //int locationId = null;
            //string? expand = null;
            //string? select = null;
            //string? filter = null;
            //string? orderby = null;
            //int? top = null;
            //int? skip = null;
            //bool? count = null;
            //var response = instance.GetLast(days, locationId, expand, select, filter, orderby, top, skip, count);
            //Assert.IsType<List<SCServiceChannelServicesMessagingProvidersExtendedReviewedProvider>>(response);
        }

        /// <summary>
        /// Test GetProvider
        /// </summary>
        [Fact]
        public void GetProviderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int providerId = null;
            //string? expand = null;
            //string? select = null;
            //string? filter = null;
            //string? orderby = null;
            //int? top = null;
            //int? skip = null;
            //bool? count = null;
            //var response = instance.GetProvider(providerId, expand, select, filter, orderby, top, skip, count);
            //Assert.IsType<SCServiceChannelServicesMessagingProvidersDetailedProvider>(response);
        }

        /// <summary>
        /// Test GetRecent
        /// </summary>
        [Fact]
        public void GetRecentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int days = null;
            //int locationId = null;
            //string? expand = null;
            //string? select = null;
            //string? filter = null;
            //string? orderby = null;
            //int? top = null;
            //int? skip = null;
            //bool? count = null;
            //var response = instance.GetRecent(days, locationId, expand, select, filter, orderby, top, skip, count);
            //Assert.IsType<List<SCServiceChannelServicesMessagingProvidersReviewedProvider>>(response);
        }

        /// <summary>
        /// Test Providers
        /// </summary>
        [Fact]
        public void ProvidersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SCServiceChannelServicesMessagingProvidersCreateBlankProviderRequest request = null;
            //var response = instance.Providers(request);
            //Assert.IsType<SCServiceChannelServicesMessagingProvidersCreateBlankProviderResponse>(response);
        }

        /// <summary>
        /// Test ProvidersAccountChanged
        /// </summary>
        [Fact]
        public void ProvidersAccountChangedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SCServiceChannelServicesMessagingProvidersProviderAccountChangedRequest request = null;
            //var response = instance.ProvidersAccountChanged(request);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test ProvidersCurrentProblemtypessubscriberIdsubscriberIddashboardIddashboardIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemType
        /// </summary>
        [Fact]
        public void ProvidersCurrentProblemtypessubscriberIdsubscriberIddashboardIddashboardIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int subscriberId = null;
            //int dashboardId = null;
            //int locationId = null;
            //int areaId = null;
            //string trade = null;
            //string problemType = null;
            //var response = instance.ProvidersCurrentProblemtypessubscriberIdsubscriberIddashboardIddashboardIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemType(subscriberId, dashboardId, locationId, areaId, trade, problemType);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test ProvidersGetESignatureSettingsworkOrderIdworkOrderId
        /// </summary>
        [Fact]
        public void ProvidersGetESignatureSettingsworkOrderIdworkOrderIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int workOrderId = null;
            //var response = instance.ProvidersGetESignatureSettingsworkOrderIdworkOrderId(workOrderId);
            //Assert.IsType<SCServiceChannelServicesMessagingProvidersGetESignatureSettingsResponse>(response);
        }

        /// <summary>
        /// Test ProvidersGetProviderStateproviderIdproviderId
        /// </summary>
        [Fact]
        public void ProvidersGetProviderStateproviderIdproviderIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int providerId = null;
            //var response = instance.ProvidersGetProviderStateproviderIdproviderId(providerId);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test ProvidersGetbytradetradetrade
        /// </summary>
        [Fact]
        public void ProvidersGetbytradetradetradeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string trade = null;
            //var response = instance.ProvidersGetbytradetradetrade(trade);
            //Assert.IsType<List<SCServiceChannelServicesMessagingProvidersProviderInfo>>(response);
        }

        /// <summary>
        /// Test ProvidersRemoveProviderSubscriberLink
        /// </summary>
        [Fact]
        public void ProvidersRemoveProviderSubscriberLinkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SCServiceChannelServicesMessagingProvidersRemoveProviderSubscriberLinkRequest request = null;
            //var response = instance.ProvidersRemoveProviderSubscriberLink(request);
            //Assert.IsType<SCServiceChannelServicesMessagingProvidersCreateBlankProviderResponse>(response);
        }

        /// <summary>
        /// Test ProvidersTrained
        /// </summary>
        [Fact]
        public void ProvidersTrainedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SCServiceChannelServicesMessagingProvidersGetTrainedProvidersRequest request = null;
            //var response = instance.ProvidersTrained(request);
            //Assert.IsType<List<SCServiceChannelServicesMessagingProvidersGetTrainedProvidersResponse>>(response);
        }

        /// <summary>
        /// Test ProvidersUpdateDispatchSetting
        /// </summary>
        [Fact]
        public void ProvidersUpdateDispatchSettingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SCServiceChannelServicesWebApiModelsUpdateDispatchSettingModel updateDispatchSettingModel = null;
            //var response = instance.ProvidersUpdateDispatchSetting(updateDispatchSettingModel);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test ProvidersproviderIdFeedback
        /// </summary>
        [Fact]
        public void ProvidersproviderIdFeedbackTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int providerId = null;
            //SCServiceChannelServicesMessagingProvidersProviderFeedbackRequest request = null;
            //var response = instance.ProvidersproviderIdFeedback(providerId, request);
            //Assert.IsType<Object>(response);
        }
    }
}
