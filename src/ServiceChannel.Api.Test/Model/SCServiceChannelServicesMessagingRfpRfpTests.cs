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
    ///  Class for testing SCServiceChannelServicesMessagingRfpRfp
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SCServiceChannelServicesMessagingRfpRfpTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SCServiceChannelServicesMessagingRfpRfp
        //private SCServiceChannelServicesMessagingRfpRfp instance;

        public SCServiceChannelServicesMessagingRfpRfpTests()
        {
            // TODO uncomment below to create an instance of SCServiceChannelServicesMessagingRfpRfp
            //instance = new SCServiceChannelServicesMessagingRfpRfp();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SCServiceChannelServicesMessagingRfpRfp
        /// </summary>
        [Fact]
        public void SCServiceChannelServicesMessagingRfpRfpInstanceTest()
        {
            // TODO uncomment below to test "IsType" SCServiceChannelServicesMessagingRfpRfp
            //Assert.IsType<SCServiceChannelServicesMessagingRfpRfp>(instance);
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Number'
        /// </summary>
        [Fact]
        public void NumberTest()
        {
            // TODO unit test for the property 'Number'
        }
        /// <summary>
        /// Test the property 'CreatedDate'
        /// </summary>
        [Fact]
        public void CreatedDateTest()
        {
            // TODO unit test for the property 'CreatedDate'
        }
        /// <summary>
        /// Test the property 'CreatedDateDTO'
        /// </summary>
        [Fact]
        public void CreatedDateDTOTest()
        {
            // TODO unit test for the property 'CreatedDateDTO'
        }
        /// <summary>
        /// Test the property 'Date'
        /// </summary>
        [Fact]
        public void DateTest()
        {
            // TODO unit test for the property 'Date'
        }
        /// <summary>
        /// Test the property 'DateDTO'
        /// </summary>
        [Fact]
        public void DateDTOTest()
        {
            // TODO unit test for the property 'DateDTO'
        }
        /// <summary>
        /// Test the property 'UpdatedDate'
        /// </summary>
        [Fact]
        public void UpdatedDateTest()
        {
            // TODO unit test for the property 'UpdatedDate'
        }
        /// <summary>
        /// Test the property 'UpdatedDateDTO'
        /// </summary>
        [Fact]
        public void UpdatedDateDTOTest()
        {
            // TODO unit test for the property 'UpdatedDateDTO'
        }
        /// <summary>
        /// Test the property 'UserId'
        /// </summary>
        [Fact]
        public void UserIdTest()
        {
            // TODO unit test for the property 'UserId'
        }
        /// <summary>
        /// Test the property 'WaitingForPrpEmail'
        /// </summary>
        [Fact]
        public void WaitingForPrpEmailTest()
        {
            // TODO unit test for the property 'WaitingForPrpEmail'
        }
        /// <summary>
        /// Test the property 'ProviderEmail'
        /// </summary>
        [Fact]
        public void ProviderEmailTest()
        {
            // TODO unit test for the property 'ProviderEmail'
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
        /// Test the property 'DueHrs'
        /// </summary>
        [Fact]
        public void DueHrsTest()
        {
            // TODO unit test for the property 'DueHrs'
        }
        /// <summary>
        /// Test the property 'DueDate'
        /// </summary>
        [Fact]
        public void DueDateTest()
        {
            // TODO unit test for the property 'DueDate'
        }
        /// <summary>
        /// Test the property 'DueDateDTO'
        /// </summary>
        [Fact]
        public void DueDateDTOTest()
        {
            // TODO unit test for the property 'DueDateDTO'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'Location'
        /// </summary>
        [Fact]
        public void LocationTest()
        {
            // TODO unit test for the property 'Location'
        }
        /// <summary>
        /// Test the property 'Provider'
        /// </summary>
        [Fact]
        public void ProviderTest()
        {
            // TODO unit test for the property 'Provider'
        }
        /// <summary>
        /// Test the property 'Subscriber'
        /// </summary>
        [Fact]
        public void SubscriberTest()
        {
            // TODO unit test for the property 'Subscriber'
        }
        /// <summary>
        /// Test the property 'Trade'
        /// </summary>
        [Fact]
        public void TradeTest()
        {
            // TODO unit test for the property 'Trade'
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
        /// Test the property 'WorkOrder'
        /// </summary>
        [Fact]
        public void WorkOrderTest()
        {
            // TODO unit test for the property 'WorkOrder'
        }
        /// <summary>
        /// Test the property 'Proposals'
        /// </summary>
        [Fact]
        public void ProposalsTest()
        {
            // TODO unit test for the property 'Proposals'
        }
        /// <summary>
        /// Test the property 'Attachments'
        /// </summary>
        [Fact]
        public void AttachmentsTest()
        {
            // TODO unit test for the property 'Attachments'
        }
        /// <summary>
        /// Test the property 'BatchRfpNumber'
        /// </summary>
        [Fact]
        public void BatchRfpNumberTest()
        {
            // TODO unit test for the property 'BatchRfpNumber'
        }

    }

}
