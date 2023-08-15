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
    ///  Class for testing SCServiceChannelServicesMessagingProposalsMlpWoRecommendationRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SCServiceChannelServicesMessagingProposalsMlpWoRecommendationRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SCServiceChannelServicesMessagingProposalsMlpWoRecommendationRequest
        //private SCServiceChannelServicesMessagingProposalsMlpWoRecommendationRequest instance;

        public SCServiceChannelServicesMessagingProposalsMlpWoRecommendationRequestTests()
        {
            // TODO uncomment below to create an instance of SCServiceChannelServicesMessagingProposalsMlpWoRecommendationRequest
            //instance = new SCServiceChannelServicesMessagingProposalsMlpWoRecommendationRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SCServiceChannelServicesMessagingProposalsMlpWoRecommendationRequest
        /// </summary>
        [Fact]
        public void SCServiceChannelServicesMessagingProposalsMlpWoRecommendationRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" SCServiceChannelServicesMessagingProposalsMlpWoRecommendationRequest
            //Assert.IsType<SCServiceChannelServicesMessagingProposalsMlpWoRecommendationRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Action'
        /// </summary>
        [Fact]
        public void ActionTest()
        {
            // TODO unit test for the property 'Action'
        }
        /// <summary>
        /// Test the property 'WoType'
        /// </summary>
        [Fact]
        public void WoTypeTest()
        {
            // TODO unit test for the property 'WoType'
        }
        /// <summary>
        /// Test the property 'TrackingNumber'
        /// </summary>
        [Fact]
        public void TrackingNumberTest()
        {
            // TODO unit test for the property 'TrackingNumber'
        }
        /// <summary>
        /// Test the property 'PoNumber'
        /// </summary>
        [Fact]
        public void PoNumberTest()
        {
            // TODO unit test for the property 'PoNumber'
        }
        /// <summary>
        /// Test the property 'ExistingPoNumber'
        /// </summary>
        [Fact]
        public void ExistingPoNumberTest()
        {
            // TODO unit test for the property 'ExistingPoNumber'
        }
        /// <summary>
        /// Test the property 'Category'
        /// </summary>
        [Fact]
        public void CategoryTest()
        {
            // TODO unit test for the property 'Category'
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
        /// Test the property 'ApprovalCode'
        /// </summary>
        [Fact]
        public void ApprovalCodeTest()
        {
            // TODO unit test for the property 'ApprovalCode'
        }
        /// <summary>
        /// Test the property 'Priority'
        /// </summary>
        [Fact]
        public void PriorityTest()
        {
            // TODO unit test for the property 'Priority'
        }
        /// <summary>
        /// Test the property 'Comment'
        /// </summary>
        [Fact]
        public void CommentTest()
        {
            // TODO unit test for the property 'Comment'
        }
        /// <summary>
        /// Test the property 'RejectReasonCodeId'
        /// </summary>
        [Fact]
        public void RejectReasonCodeIdTest()
        {
            // TODO unit test for the property 'RejectReasonCodeId'
        }
        /// <summary>
        /// Test the property 'ReasonString'
        /// </summary>
        [Fact]
        public void ReasonStringTest()
        {
            // TODO unit test for the property 'ReasonString'
        }
        /// <summary>
        /// Test the property 'EmailsToNotify'
        /// </summary>
        [Fact]
        public void EmailsToNotifyTest()
        {
            // TODO unit test for the property 'EmailsToNotify'
        }
        /// <summary>
        /// Test the property 'EmailMyself'
        /// </summary>
        [Fact]
        public void EmailMyselfTest()
        {
            // TODO unit test for the property 'EmailMyself'
        }
        /// <summary>
        /// Test the property 'MyEmail'
        /// </summary>
        [Fact]
        public void MyEmailTest()
        {
            // TODO unit test for the property 'MyEmail'
        }
        /// <summary>
        /// Test the property 'ProposalId'
        /// </summary>
        [Fact]
        public void ProposalIdTest()
        {
            // TODO unit test for the property 'ProposalId'
        }
        /// <summary>
        /// Test the property 'WorkOrderLabel'
        /// </summary>
        [Fact]
        public void WorkOrderLabelTest()
        {
            // TODO unit test for the property 'WorkOrderLabel'
        }
        /// <summary>
        /// Test the property 'DeleteLabel'
        /// </summary>
        [Fact]
        public void DeleteLabelTest()
        {
            // TODO unit test for the property 'DeleteLabel'
        }
        /// <summary>
        /// Test the property 'Actor'
        /// </summary>
        [Fact]
        public void ActorTest()
        {
            // TODO unit test for the property 'Actor'
        }
        /// <summary>
        /// Test the property 'AdditionalApprovalCodes'
        /// </summary>
        [Fact]
        public void AdditionalApprovalCodesTest()
        {
            // TODO unit test for the property 'AdditionalApprovalCodes'
        }

    }

}