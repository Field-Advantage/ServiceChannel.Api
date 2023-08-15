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
    ///  Class for testing ProviderAssignmentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProviderAssignmentApiTests : IDisposable
    {
        private ProviderAssignmentApi instance;

        public ProviderAssignmentApiTests()
        {
            instance = new ProviderAssignmentApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProviderAssignmentApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ProviderAssignmentApi
            //Assert.IsType<ProviderAssignmentApi>(instance);
        }

        /// <summary>
        /// Test GetAssigned
        /// </summary>
        [Fact]
        public void GetAssignedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? expand = null;
            //string? select = null;
            //string? filter = null;
            //string? orderby = null;
            //int? top = null;
            //int? skip = null;
            //bool? count = null;
            //var response = instance.GetAssigned(expand, select, filter, orderby, top, skip, count);
            //Assert.IsType<List<SCServiceChannelServicesMessagingProvidersProviderInfo>>(response);
        }

        /// <summary>
        /// Test GetProviderAssignments
        /// </summary>
        [Fact]
        public void GetProviderAssignmentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? expand = null;
            //string? select = null;
            //string? filter = null;
            //string? orderby = null;
            //int? top = null;
            //int? skip = null;
            //bool? count = null;
            //var response = instance.GetProviderAssignments(expand, select, filter, orderby, top, skip, count);
            //Assert.IsType<List<SCServiceChannelServicesMessagingProviderAssignmentsProviderAssignment>>(response);
        }
    }
}
