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
    ///  Class for testing UsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UsersApiTests : IDisposable
    {
        private UsersApi instance;

        public UsersApiTests()
        {
            instance = new UsersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UsersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UsersApi
            //Assert.IsType<UsersApi>(instance);
        }

        /// <summary>
        /// Test EmployeesemployeeIdUsers
        /// </summary>
        [Fact]
        public void EmployeesemployeeIdUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string employeeId = null;
            //var response = instance.EmployeesemployeeIdUsers(employeeId);
            //Assert.IsType<List<SCServiceChannelServicesMessagingUsersUser>>(response);
        }

        /// <summary>
        /// Test GetUsers
        /// </summary>
        [Fact]
        public void GetUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? expand = null;
            //string? select = null;
            //string? filter = null;
            //string? orderby = null;
            //int? top = null;
            //int? skip = null;
            //bool? count = null;
            //var response = instance.GetUsers(expand, select, filter, orderby, top, skip, count);
            //Assert.IsType<List<SCServiceChannelServicesMessagingUsersUser>>(response);
        }

        /// <summary>
        /// Test GetUsersForProvider
        /// </summary>
        [Fact]
        public void GetUsersForProviderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int providerId = null;
            //string? expand = null;
            //string? select = null;
            //string? filter = null;
            //string? orderby = null;
            //int? top = null;
            //int? skip = null;
            //bool? count = null;
            //var response = instance.GetUsersForProvider(providerId, expand, select, filter, orderby, top, skip, count);
            //Assert.IsType<List<SCServiceChannelServicesMessagingUsersUser>>(response);
        }

        /// <summary>
        /// Test GetUsersForSubscriber
        /// </summary>
        [Fact]
        public void GetUsersForSubscriberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int subscriberId = null;
            //string? expand = null;
            //string? select = null;
            //string? filter = null;
            //string? orderby = null;
            //int? top = null;
            //int? skip = null;
            //bool? count = null;
            //var response = instance.GetUsersForSubscriber(subscriberId, expand, select, filter, orderby, top, skip, count);
            //Assert.IsType<List<SCServiceChannelServicesMessagingUsersUser>>(response);
        }

        /// <summary>
        /// Test Users
        /// </summary>
        [Fact]
        public void UsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SCServiceChannelServicesMessagingUsersAddUserRequest request = null;
            //var response = instance.Users(request);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test UsersCurrentLocationNoteRestrictions
        /// </summary>
        [Fact]
        public void UsersCurrentLocationNoteRestrictionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.UsersCurrentLocationNoteRestrictions();
            //Assert.IsType<List<SCServiceChannelServicesMessagingUserUserLocationNoteRestrictionResponse>>(response);
        }

        /// <summary>
        /// Test UsersCurrentMenu
        /// </summary>
        [Fact]
        public void UsersCurrentMenuTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.UsersCurrentMenu();
            //Assert.IsType<SCServiceChannelServicesMessagingMenuResponse>(response);
        }

        /// <summary>
        /// Test UsersCurrentProfile
        /// </summary>
        [Fact]
        public void UsersCurrentProfileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.UsersCurrentProfile();
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test UsersFeatures
        /// </summary>
        [Fact]
        public void UsersFeaturesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.UsersFeatures();
            //Assert.IsType<SCServiceChannelServicesMessagingApplicationAccessFeatureResponse>(response);
        }

        /// <summary>
        /// Test UsersRegionalSettings
        /// </summary>
        [Fact]
        public void UsersRegionalSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.UsersRegionalSettings();
            //Assert.IsType<SCServiceChannelServicesMessagingUserUserLocalizationSettings>(response);
        }

        /// <summary>
        /// Test Usersid
        /// </summary>
        [Fact]
        public void UsersidTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.Usersid(id);
            //Assert.IsType<SCServiceChannelServicesMessagingUsersGetUserResponse>(response);
        }

        /// <summary>
        /// Test Usersid_0
        /// </summary>
        [Fact]
        public void Usersid_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //SCServiceChannelServicesMessagingUsersUpdateUserRequest request = null;
            //var response = instance.Usersid_0(id, request);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test Usersid_1
        /// </summary>
        [Fact]
        public void Usersid_1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.Usersid_1(id);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test Usersid_2
        /// </summary>
        [Fact]
        public void Usersid_2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //Dictionary<string, Object> request = null;
            //var response = instance.Usersid_2(id, request);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test UserssubscriberIdsubscriberIdstartIndexstartIndexmaxCountmaxCount
        /// </summary>
        [Fact]
        public void UserssubscriberIdsubscriberIdstartIndexstartIndexmaxCountmaxCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? subscriberId = null;
            //int? startIndex = null;
            //int? maxCount = null;
            //var response = instance.UserssubscriberIdsubscriberIdstartIndexstartIndexmaxCountmaxCount(subscriberId, startIndex, maxCount);
            //Assert.IsType<List<SCServiceChannelServicesMessagingUsersUser>>(response);
        }

        /// <summary>
        /// Test UsersuserIdIslocked
        /// </summary>
        [Fact]
        public void UsersuserIdIslockedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int userId = null;
            //var response = instance.UsersuserIdIslocked(userId);
            //Assert.IsType<bool>(response);
        }

        /// <summary>
        /// Test UsersuserIdMenu
        /// </summary>
        [Fact]
        public void UsersuserIdMenuTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int userId = null;
            //var response = instance.UsersuserIdMenu(userId);
            //Assert.IsType<Object>(response);
        }
    }
}
