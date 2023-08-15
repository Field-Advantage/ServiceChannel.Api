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
    ///  Class for testing NotificationSubscriptionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class NotificationSubscriptionsApiTests : IDisposable
    {
        private NotificationSubscriptionsApi instance;

        public NotificationSubscriptionsApiTests()
        {
            instance = new NotificationSubscriptionsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of NotificationSubscriptionsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' NotificationSubscriptionsApi
            //Assert.IsType<NotificationSubscriptionsApi>(instance);
        }

        /// <summary>
        /// Test GetProvidersExclusionListemailNotificationTypeemailNotificationType
        /// </summary>
        [Fact]
        public void GetProvidersExclusionListemailNotificationTypeemailNotificationTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int emailNotificationType = null;
            //var response = instance.GetProvidersExclusionListemailNotificationTypeemailNotificationType(emailNotificationType);
            //Assert.IsType<SCServiceChannelServicesMessagingPermissionProvidersExclusionListResponse>(response);
        }

        /// <summary>
        /// Test NotificationSubscriptions
        /// </summary>
        [Fact]
        public void NotificationSubscriptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SCServiceChannelServicesMessagingNotificationsNotificationSubscriptionRequest request = null;
            //var response = instance.NotificationSubscriptions(request);
            //Assert.IsType<SCServiceChannelServicesMessagingNotificationsAddNotificationSubsciptionResponse>(response);
        }

        /// <summary>
        /// Test NotificationSubscriptionsHttp
        /// </summary>
        [Fact]
        public void NotificationSubscriptionsHttpTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.NotificationSubscriptionsHttp();
            //Assert.IsType<List<SCServiceChannelServicesMessagingNotificationsHttpNotificationSubscription>>(response);
        }

        /// <summary>
        /// Test NotificationSubscriptionsHttp_0
        /// </summary>
        [Fact]
        public void NotificationSubscriptionsHttp_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SCServiceChannelServicesMessagingNotificationsAddHttpNotificationSubscriptionRequest req = null;
            //var response = instance.NotificationSubscriptionsHttp_0(req);
            //Assert.IsType<SCServiceChannelServicesMessagingNotificationsAddNotificationSubsciptionResponse>(response);
        }

        /// <summary>
        /// Test NotificationSubscriptionsHttpid
        /// </summary>
        [Fact]
        public void NotificationSubscriptionsHttpidTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.NotificationSubscriptionsHttpid(id);
            //Assert.IsType<SCServiceChannelServicesMessagingNotificationsHttpNotificationSubscription>(response);
        }

        /// <summary>
        /// Test NotificationSubscriptionsHttpid_0
        /// </summary>
        [Fact]
        public void NotificationSubscriptionsHttpid_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //SCServiceChannelServicesMessagingNotificationsHttpNotificationSubscription req = null;
            //instance.NotificationSubscriptionsHttpid_0(id, req);
        }

        /// <summary>
        /// Test NotificationSubscriptionsHttpid_1
        /// </summary>
        [Fact]
        public void NotificationSubscriptionsHttpid_1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //instance.NotificationSubscriptionsHttpid_1(id);
        }

        /// <summary>
        /// Test NotificationSubscriptionsMsteamsconversationIdconversationId
        /// </summary>
        [Fact]
        public void NotificationSubscriptionsMsteamsconversationIdconversationIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string conversationId = null;
            //var response = instance.NotificationSubscriptionsMsteamsconversationIdconversationId(conversationId);
            //Assert.IsType<SCServiceChannelServicesMessagingNotificationsMSBotNotificationSubscriptionResponse>(response);
        }

        /// <summary>
        /// Test NotificationSubscriptionsSigningKey
        /// </summary>
        [Fact]
        public void NotificationSubscriptionsSigningKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.NotificationSubscriptionsSigningKey();
            //Assert.IsType<SCServiceChannelServicesMessagingNotificationsSigningKeyResponse>(response);
        }

        /// <summary>
        /// Test NotificationSubscriptionsSigningKey_0
        /// </summary>
        [Fact]
        public void NotificationSubscriptionsSigningKey_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.NotificationSubscriptionsSigningKey_0();
            //Assert.IsType<SCServiceChannelServicesMessagingNotificationsSigningKeyResponse>(response);
        }

        /// <summary>
        /// Test NotificationSubscriptionsidtypetype
        /// </summary>
        [Fact]
        public void NotificationSubscriptionsidtypetypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string type = null;
            //instance.NotificationSubscriptionsidtypetype(id, type);
        }
    }
}
