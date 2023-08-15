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
    ///  Class for testing SCServiceChannelServicesMessagingTemplateTemplateFilesHistory
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SCServiceChannelServicesMessagingTemplateTemplateFilesHistoryTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SCServiceChannelServicesMessagingTemplateTemplateFilesHistory
        //private SCServiceChannelServicesMessagingTemplateTemplateFilesHistory instance;

        public SCServiceChannelServicesMessagingTemplateTemplateFilesHistoryTests()
        {
            // TODO uncomment below to create an instance of SCServiceChannelServicesMessagingTemplateTemplateFilesHistory
            //instance = new SCServiceChannelServicesMessagingTemplateTemplateFilesHistory();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SCServiceChannelServicesMessagingTemplateTemplateFilesHistory
        /// </summary>
        [Fact]
        public void SCServiceChannelServicesMessagingTemplateTemplateFilesHistoryInstanceTest()
        {
            // TODO uncomment below to test "IsType" SCServiceChannelServicesMessagingTemplateTemplateFilesHistory
            //Assert.IsType<SCServiceChannelServicesMessagingTemplateTemplateFilesHistory>(instance);
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
        /// Test the property 'FilePath'
        /// </summary>
        [Fact]
        public void FilePathTest()
        {
            // TODO unit test for the property 'FilePath'
        }
        /// <summary>
        /// Test the property 'FileName'
        /// </summary>
        [Fact]
        public void FileNameTest()
        {
            // TODO unit test for the property 'FileName'
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
        /// Test the property 'ErrorMessage'
        /// </summary>
        [Fact]
        public void ErrorMessageTest()
        {
            // TODO unit test for the property 'ErrorMessage'
        }
        /// <summary>
        /// Test the property 'FileStatus'
        /// </summary>
        [Fact]
        public void FileStatusTest()
        {
            // TODO unit test for the property 'FileStatus'
        }
        /// <summary>
        /// Test the property 'FileType'
        /// </summary>
        [Fact]
        public void FileTypeTest()
        {
            // TODO unit test for the property 'FileType'
        }
        /// <summary>
        /// Test the property 'ModifiedDate'
        /// </summary>
        [Fact]
        public void ModifiedDateTest()
        {
            // TODO unit test for the property 'ModifiedDate'
        }
        /// <summary>
        /// Test the property 'ModifiedBy'
        /// </summary>
        [Fact]
        public void ModifiedByTest()
        {
            // TODO unit test for the property 'ModifiedBy'
        }
        /// <summary>
        /// Test the property 'CreatedRecords'
        /// </summary>
        [Fact]
        public void CreatedRecordsTest()
        {
            // TODO unit test for the property 'CreatedRecords'
        }
        /// <summary>
        /// Test the property 'UpdatedRecords'
        /// </summary>
        [Fact]
        public void UpdatedRecordsTest()
        {
            // TODO unit test for the property 'UpdatedRecords'
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
        /// Test the property 'DeletedRecords'
        /// </summary>
        [Fact]
        public void DeletedRecordsTest()
        {
            // TODO unit test for the property 'DeletedRecords'
        }

    }

}