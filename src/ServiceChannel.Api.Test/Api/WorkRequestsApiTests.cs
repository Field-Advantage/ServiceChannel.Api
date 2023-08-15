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
    ///  Class for testing WorkRequestsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WorkRequestsApiTests : IDisposable
    {
        private WorkRequestsApi instance;

        public WorkRequestsApiTests()
        {
            instance = new WorkRequestsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WorkRequestsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' WorkRequestsApi
            //Assert.IsType<WorkRequestsApi>(instance);
        }

        /// <summary>
        /// Test Workrequests
        /// </summary>
        [Fact]
        public void WorkrequestsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest request = null;
            //var response = instance.Workrequests(request);
            //Assert.IsType<SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestResponse>(response);
        }

        /// <summary>
        /// Test WorkrequestsProvidersforreassignmentworkRequestIdworkRequestId
        /// </summary>
        [Fact]
        public void WorkrequestsProvidersforreassignmentworkRequestIdworkRequestIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int workRequestId = null;
            //var response = instance.WorkrequestsProvidersforreassignmentworkRequestIdworkRequestId(workRequestId);
            //Assert.IsType<SCServiceChannelServicesMessagingProvidersServiceRequestProvider>(response);
        }

        /// <summary>
        /// Test WorkrequestsSearch
        /// </summary>
        [Fact]
        public void WorkrequestsSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SCServiceChannelServicesMessagingWorkRequestsSearchWorkRequestRequest request = null;
            //var response = instance.WorkrequestsSearch(request);
            //Assert.IsType<List<SCServiceChannelServicesMessagingWorkRequestsWorkRequest>>(response);
        }

        /// <summary>
        /// Test Workrequestsid
        /// </summary>
        [Fact]
        public void WorkrequestsidTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.Workrequestsid(id);
            //Assert.IsType<SCServiceChannelServicesMessagingWorkRequestsWorkRequest>(response);
        }

        /// <summary>
        /// Test Workrequestsid_0
        /// </summary>
        [Fact]
        public void Workrequestsid_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //instance.Workrequestsid_0(id);
        }

        /// <summary>
        /// Test WorkrequestsworkRequestId
        /// </summary>
        [Fact]
        public void WorkrequestsworkRequestIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int workRequestId = null;
            //SCServiceChannelServicesMessagingWorkRequestsUpdateWorkRequestRequest updateRequest = null;
            //instance.WorkrequestsworkRequestId(workRequestId, updateRequest);
        }

        /// <summary>
        /// Test WorkrequestsworkRequestIdCategorycategoryIdcategoryId
        /// </summary>
        [Fact]
        public void WorkrequestsworkRequestIdCategorycategoryIdcategoryIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int workRequestId = null;
            //int categoryId = null;
            //instance.WorkrequestsworkRequestIdCategorycategoryIdcategoryId(workRequestId, categoryId);
        }

        /// <summary>
        /// Test WorkrequestsworkRequestIdDescription
        /// </summary>
        [Fact]
        public void WorkrequestsworkRequestIdDescriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int workRequestId = null;
            //SCServiceChannelServicesMessagingWorkRequestsChangeWorkRequestStringFieldsRequest updateRequest = null;
            //instance.WorkrequestsworkRequestIdDescription(workRequestId, updateRequest);
        }

        /// <summary>
        /// Test WorkrequestsworkRequestIdNte
        /// </summary>
        [Fact]
        public void WorkrequestsworkRequestIdNteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int workRequestId = null;
            //SCServiceChannelServicesMessagingWorkRequestsChangeWorkRequestNteRequest updateRequest = null;
            //instance.WorkrequestsworkRequestIdNte(workRequestId, updateRequest);
        }

        /// <summary>
        /// Test WorkrequestsworkRequestIdPrioritypriorityIdpriorityId
        /// </summary>
        [Fact]
        public void WorkrequestsworkRequestIdPrioritypriorityIdpriorityIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int workRequestId = null;
            //int priorityId = null;
            //instance.WorkrequestsworkRequestIdPrioritypriorityIdpriorityId(workRequestId, priorityId);
        }

        /// <summary>
        /// Test WorkrequestsworkRequestIdReassign
        /// </summary>
        [Fact]
        public void WorkrequestsworkRequestIdReassignTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int workRequestId = null;
            //SCServiceChannelServicesMessagingWorkRequestsReassignWorkRequestRequest reassignRequest = null;
            //instance.WorkrequestsworkRequestIdReassign(workRequestId, reassignRequest);
        }

        /// <summary>
        /// Test WorkrequestsworkRequestIdScheduledatescheduledDatescheduledDate
        /// </summary>
        [Fact]
        public void WorkrequestsworkRequestIdScheduledatescheduledDatescheduledDateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int workRequestId = null;
            //string scheduledDate = null;
            //instance.WorkrequestsworkRequestIdScheduledatescheduledDatescheduledDate(workRequestId, scheduledDate);
        }

        /// <summary>
        /// Test WorkrequestsworkRequestIdStatus
        /// </summary>
        [Fact]
        public void WorkrequestsworkRequestIdStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int workRequestId = null;
            //SCServiceChannelServicesMessagingWorkRequestsChangeWorkRequestStatusRequest updateRequest = null;
            //instance.WorkrequestsworkRequestIdStatus(workRequestId, updateRequest);
        }

        /// <summary>
        /// Test WorkrequestsworkRequestIdTradetradeIdtradeId
        /// </summary>
        [Fact]
        public void WorkrequestsworkRequestIdTradetradeIdtradeIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int workRequestId = null;
            //int tradeId = null;
            //instance.WorkrequestsworkRequestIdTradetradeIdtradeId(workRequestId, tradeId);
        }
    }
}
