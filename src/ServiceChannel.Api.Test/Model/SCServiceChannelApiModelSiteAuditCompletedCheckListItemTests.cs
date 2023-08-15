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
    ///  Class for testing SCServiceChannelApiModelSiteAuditCompletedCheckListItem
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SCServiceChannelApiModelSiteAuditCompletedCheckListItemTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SCServiceChannelApiModelSiteAuditCompletedCheckListItem
        //private SCServiceChannelApiModelSiteAuditCompletedCheckListItem instance;

        public SCServiceChannelApiModelSiteAuditCompletedCheckListItemTests()
        {
            // TODO uncomment below to create an instance of SCServiceChannelApiModelSiteAuditCompletedCheckListItem
            //instance = new SCServiceChannelApiModelSiteAuditCompletedCheckListItem();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SCServiceChannelApiModelSiteAuditCompletedCheckListItem
        /// </summary>
        [Fact]
        public void SCServiceChannelApiModelSiteAuditCompletedCheckListItemInstanceTest()
        {
            // TODO uncomment below to test "IsType" SCServiceChannelApiModelSiteAuditCompletedCheckListItem
            //Assert.IsType<SCServiceChannelApiModelSiteAuditCompletedCheckListItem>(instance);
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
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
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
        /// Test the property 'Score'
        /// </summary>
        [Fact]
        public void ScoreTest()
        {
            // TODO unit test for the property 'Score'
        }
        /// <summary>
        /// Test the property 'System'
        /// </summary>
        [Fact]
        public void SystemTest()
        {
            // TODO unit test for the property 'System'
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
        /// Test the property 'Unlisted'
        /// </summary>
        [Fact]
        public void UnlistedTest()
        {
            // TODO unit test for the property 'Unlisted'
        }
        /// <summary>
        /// Test the property 'CheckListItemImpact'
        /// </summary>
        [Fact]
        public void CheckListItemImpactTest()
        {
            // TODO unit test for the property 'CheckListItemImpact'
        }
        /// <summary>
        /// Test the property 'UseNumericRatingSystem'
        /// </summary>
        [Fact]
        public void UseNumericRatingSystemTest()
        {
            // TODO unit test for the property 'UseNumericRatingSystem'
        }
        /// <summary>
        /// Test the property 'PassThreshold'
        /// </summary>
        [Fact]
        public void PassThresholdTest()
        {
            // TODO unit test for the property 'PassThreshold'
        }
        /// <summary>
        /// Test the property 'Range'
        /// </summary>
        [Fact]
        public void RangeTest()
        {
            // TODO unit test for the property 'Range'
        }
        /// <summary>
        /// Test the property 'Issues'
        /// </summary>
        [Fact]
        public void IssuesTest()
        {
            // TODO unit test for the property 'Issues'
        }
        /// <summary>
        /// Test the property 'WorkOrderIds'
        /// </summary>
        [Fact]
        public void WorkOrderIdsTest()
        {
            // TODO unit test for the property 'WorkOrderIds'
        }
        /// <summary>
        /// Test the property 'Quantity'
        /// </summary>
        [Fact]
        public void QuantityTest()
        {
            // TODO unit test for the property 'Quantity'
        }

    }

}
