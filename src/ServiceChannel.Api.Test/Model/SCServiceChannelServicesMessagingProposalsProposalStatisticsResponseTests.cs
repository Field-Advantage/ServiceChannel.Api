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
    ///  Class for testing SCServiceChannelServicesMessagingProposalsProposalStatisticsResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SCServiceChannelServicesMessagingProposalsProposalStatisticsResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SCServiceChannelServicesMessagingProposalsProposalStatisticsResponse
        //private SCServiceChannelServicesMessagingProposalsProposalStatisticsResponse instance;

        public SCServiceChannelServicesMessagingProposalsProposalStatisticsResponseTests()
        {
            // TODO uncomment below to create an instance of SCServiceChannelServicesMessagingProposalsProposalStatisticsResponse
            //instance = new SCServiceChannelServicesMessagingProposalsProposalStatisticsResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SCServiceChannelServicesMessagingProposalsProposalStatisticsResponse
        /// </summary>
        [Fact]
        public void SCServiceChannelServicesMessagingProposalsProposalStatisticsResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" SCServiceChannelServicesMessagingProposalsProposalStatisticsResponse
            //Assert.IsType<SCServiceChannelServicesMessagingProposalsProposalStatisticsResponse>(instance);
        }


        /// <summary>
        /// Test the property 'DaysPeriod'
        /// </summary>
        [Fact]
        public void DaysPeriodTest()
        {
            // TODO unit test for the property 'DaysPeriod'
        }
        /// <summary>
        /// Test the property 'RFPsWaitingForApproval'
        /// </summary>
        [Fact]
        public void RFPsWaitingForApprovalTest()
        {
            // TODO unit test for the property 'RFPsWaitingForApproval'
        }
        /// <summary>
        /// Test the property 'OpenProposals'
        /// </summary>
        [Fact]
        public void OpenProposalsTest()
        {
            // TODO unit test for the property 'OpenProposals'
        }
        /// <summary>
        /// Test the property 'ApprovedProposalsDaysPeriod'
        /// </summary>
        [Fact]
        public void ApprovedProposalsDaysPeriodTest()
        {
            // TODO unit test for the property 'ApprovedProposalsDaysPeriod'
        }
        /// <summary>
        /// Test the property 'ApprovedProposals'
        /// </summary>
        [Fact]
        public void ApprovedProposalsTest()
        {
            // TODO unit test for the property 'ApprovedProposals'
        }
        /// <summary>
        /// Test the property 'WaitingReviewProposals'
        /// </summary>
        [Fact]
        public void WaitingReviewProposalsTest()
        {
            // TODO unit test for the property 'WaitingReviewProposals'
        }
        /// <summary>
        /// Test the property 'RejectedProposals'
        /// </summary>
        [Fact]
        public void RejectedProposalsTest()
        {
            // TODO unit test for the property 'RejectedProposals'
        }

    }

}