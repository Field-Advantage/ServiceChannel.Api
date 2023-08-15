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
    ///  Class for testing SCServiceChannelServicesMessagingSiteAuditAuditIssueExternal
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SCServiceChannelServicesMessagingSiteAuditAuditIssueExternalTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SCServiceChannelServicesMessagingSiteAuditAuditIssueExternal
        //private SCServiceChannelServicesMessagingSiteAuditAuditIssueExternal instance;

        public SCServiceChannelServicesMessagingSiteAuditAuditIssueExternalTests()
        {
            // TODO uncomment below to create an instance of SCServiceChannelServicesMessagingSiteAuditAuditIssueExternal
            //instance = new SCServiceChannelServicesMessagingSiteAuditAuditIssueExternal();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SCServiceChannelServicesMessagingSiteAuditAuditIssueExternal
        /// </summary>
        [Fact]
        public void SCServiceChannelServicesMessagingSiteAuditAuditIssueExternalInstanceTest()
        {
            // TODO uncomment below to test "IsType" SCServiceChannelServicesMessagingSiteAuditAuditIssueExternal
            //Assert.IsType<SCServiceChannelServicesMessagingSiteAuditAuditIssueExternal>(instance);
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
        /// Test the property 'Description'
        /// </summary>
        [Fact]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
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
        /// Test the property 'Attachments'
        /// </summary>
        [Fact]
        public void AttachmentsTest()
        {
            // TODO unit test for the property 'Attachments'
        }
        /// <summary>
        /// Test the property 'Persistent'
        /// </summary>
        [Fact]
        public void PersistentTest()
        {
            // TODO unit test for the property 'Persistent'
        }
        /// <summary>
        /// Test the property 'UserName'
        /// </summary>
        [Fact]
        public void UserNameTest()
        {
            // TODO unit test for the property 'UserName'
        }

    }

}
