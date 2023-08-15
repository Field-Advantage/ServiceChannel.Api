/*
 * ServiceChannel API - v.3
 *
 * The ServiceChannel API is a RESTful and stateless API. It accepts standard HTTP verbs and supports OAuth 2.0 for authorizing requests.      Our API returns common HTTP status codes as well as JSON encapsulated data.      See [API Overview](https://developer.servicechannel.com/basics/introduction/overview/) for the intro to ServiceChannel API.<br>      <h3>Authentication and Authorization</h3>You should have a ServiceChannel account, register your application, and obtain `access_token` to integrate with our API.      See [Authentication and Authorization](https://developer.servicechannel.com/basics/general/authentication/) for more information.      To use this API playground, click **Authorize** and sign in to ServiceChannel.<br>      <h3>Environment</h3> All calls in this API Reference point to the **SB2 environment**.      See [Environments](https://developer.servicechannel.com/basics/general/environments/) for more information.<br>      <h3>API Version</h3>The current stable version of the ServiceChannel API is `v3`. In the request URL, `v3` is a version prefix that should be present.      When you omit the version prefix, calls point to the minimum supported version of the API.      We recommend you to always specify the API version to avoid possible errors.
 *
 * The version of the OpenAPI document: 3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using ServiceChannel.Api.Model;
using ServiceChannel.Api.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace ServiceChannel.Api.Test.Model
{
    /// <summary>
    ///  Class for testing SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest
        //private SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest instance;

        public SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequestTests()
        {
            // TODO uncomment below to create an instance of SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest
            //instance = new SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest
        /// </summary>
        [Fact]
        public void SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest
            //Assert.IsType<SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest>(instance);
        }


        /// <summary>
        /// Test the property 'SubscriberId'
        /// </summary>
        [Fact]
        public void SubscriberIdTest()
        {
            // TODO unit test for the property 'SubscriberId'
        }
        /// <summary>
        /// Test the property 'ProviderId'
        /// </summary>
        [Fact]
        public void ProviderIdTest()
        {
            // TODO unit test for the property 'ProviderId'
        }
        /// <summary>
        /// Test the property 'EventId'
        /// </summary>
        [Fact]
        public void EventIdTest()
        {
            // TODO unit test for the property 'EventId'
        }
        /// <summary>
        /// Test the property 'LocationId'
        /// </summary>
        [Fact]
        public void LocationIdTest()
        {
            // TODO unit test for the property 'LocationId'
        }
        /// <summary>
        /// Test the property 'StatusId'
        /// </summary>
        [Fact]
        public void StatusIdTest()
        {
            // TODO unit test for the property 'StatusId'
        }
        /// <summary>
        /// Test the property 'ExtendedStatusId'
        /// </summary>
        [Fact]
        public void ExtendedStatusIdTest()
        {
            // TODO unit test for the property 'ExtendedStatusId'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Fact]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'TradeId'
        /// </summary>
        [Fact]
        public void TradeIdTest()
        {
            // TODO unit test for the property 'TradeId'
        }
        /// <summary>
        /// Test the property 'CategoryId'
        /// </summary>
        [Fact]
        public void CategoryIdTest()
        {
            // TODO unit test for the property 'CategoryId'
        }
        /// <summary>
        /// Test the property 'PriorityId'
        /// </summary>
        [Fact]
        public void PriorityIdTest()
        {
            // TODO unit test for the property 'PriorityId'
        }
        /// <summary>
        /// Test the property 'Caller'
        /// </summary>
        [Fact]
        public void CallerTest()
        {
            // TODO unit test for the property 'Caller'
        }
        /// <summary>
        /// Test the property 'CallDate'
        /// </summary>
        [Fact]
        public void CallDateTest()
        {
            // TODO unit test for the property 'CallDate'
        }
        /// <summary>
        /// Test the property 'ScheduledDate'
        /// </summary>
        [Fact]
        public void ScheduledDateTest()
        {
            // TODO unit test for the property 'ScheduledDate'
        }
        /// <summary>
        /// Test the property 'AssetId'
        /// </summary>
        [Fact]
        public void AssetIdTest()
        {
            // TODO unit test for the property 'AssetId'
        }
        /// <summary>
        /// Test the property 'Nte'
        /// </summary>
        [Fact]
        public void NteTest()
        {
            // TODO unit test for the property 'Nte'
        }
        /// <summary>
        /// Test the property 'Issue'
        /// </summary>
        [Fact]
        public void IssueTest()
        {
            // TODO unit test for the property 'Issue'
        }
        /// <summary>
        /// Test the property 'Attachments'
        /// </summary>
        [Fact]
        public void AttachmentsTest()
        {
            // TODO unit test for the property 'Attachments'
        }

    }

}