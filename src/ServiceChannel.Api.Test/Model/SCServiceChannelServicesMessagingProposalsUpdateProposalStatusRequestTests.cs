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
    ///  Class for testing SCServiceChannelServicesMessagingProposalsUpdateProposalStatusRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SCServiceChannelServicesMessagingProposalsUpdateProposalStatusRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SCServiceChannelServicesMessagingProposalsUpdateProposalStatusRequest
        //private SCServiceChannelServicesMessagingProposalsUpdateProposalStatusRequest instance;

        public SCServiceChannelServicesMessagingProposalsUpdateProposalStatusRequestTests()
        {
            // TODO uncomment below to create an instance of SCServiceChannelServicesMessagingProposalsUpdateProposalStatusRequest
            //instance = new SCServiceChannelServicesMessagingProposalsUpdateProposalStatusRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SCServiceChannelServicesMessagingProposalsUpdateProposalStatusRequest
        /// </summary>
        [Fact]
        public void SCServiceChannelServicesMessagingProposalsUpdateProposalStatusRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" SCServiceChannelServicesMessagingProposalsUpdateProposalStatusRequest
            //Assert.IsType<SCServiceChannelServicesMessagingProposalsUpdateProposalStatusRequest>(instance);
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
        /// Test the property 'ProviderEmail'
        /// </summary>
        [Fact]
        public void ProviderEmailTest()
        {
            // TODO unit test for the property 'ProviderEmail'
        }
        /// <summary>
        /// Test the property 'UserEmail'
        /// </summary>
        [Fact]
        public void UserEmailTest()
        {
            // TODO unit test for the property 'UserEmail'
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
        /// Test the property 'ActionSource'
        /// </summary>
        [Fact]
        public void ActionSourceTest()
        {
            // TODO unit test for the property 'ActionSource'
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
        /// Test the property 'Actor'
        /// </summary>
        [Fact]
        public void ActorTest()
        {
            // TODO unit test for the property 'Actor'
        }

    }

}