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
    ///  Class for testing SCServiceChannelServicesMessagingNotificationsNotificationSubscriptionsRules
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SCServiceChannelServicesMessagingNotificationsNotificationSubscriptionsRulesTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SCServiceChannelServicesMessagingNotificationsNotificationSubscriptionsRules
        //private SCServiceChannelServicesMessagingNotificationsNotificationSubscriptionsRules instance;

        public SCServiceChannelServicesMessagingNotificationsNotificationSubscriptionsRulesTests()
        {
            // TODO uncomment below to create an instance of SCServiceChannelServicesMessagingNotificationsNotificationSubscriptionsRules
            //instance = new SCServiceChannelServicesMessagingNotificationsNotificationSubscriptionsRules();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SCServiceChannelServicesMessagingNotificationsNotificationSubscriptionsRules
        /// </summary>
        [Fact]
        public void SCServiceChannelServicesMessagingNotificationsNotificationSubscriptionsRulesInstanceTest()
        {
            // TODO uncomment below to test "IsType" SCServiceChannelServicesMessagingNotificationsNotificationSubscriptionsRules
            //Assert.IsType<SCServiceChannelServicesMessagingNotificationsNotificationSubscriptionsRules>(instance);
        }


        /// <summary>
        /// Test the property 'Trades'
        /// </summary>
        [Fact]
        public void TradesTest()
        {
            // TODO unit test for the property 'Trades'
        }
        /// <summary>
        /// Test the property 'Categories'
        /// </summary>
        [Fact]
        public void CategoriesTest()
        {
            // TODO unit test for the property 'Categories'
        }
        /// <summary>
        /// Test the property 'Statuses'
        /// </summary>
        [Fact]
        public void StatusesTest()
        {
            // TODO unit test for the property 'Statuses'
        }

    }

}
