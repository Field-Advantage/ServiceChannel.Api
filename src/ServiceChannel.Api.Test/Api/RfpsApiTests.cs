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
    ///  Class for testing RfpsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RfpsApiTests : IDisposable
    {
        private RfpsApi instance;

        public RfpsApiTests()
        {
            instance = new RfpsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RfpsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' RfpsApi
            //Assert.IsType<RfpsApi>(instance);
        }

        /// <summary>
        /// Test GetRfp
        /// </summary>
        [Fact]
        public void GetRfpTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int rfpId = null;
            //string? expand = null;
            //string? select = null;
            //string? filter = null;
            //string? orderby = null;
            //int? top = null;
            //int? skip = null;
            //bool? count = null;
            //var response = instance.GetRfp(rfpId, expand, select, filter, orderby, top, skip, count);
            //Assert.IsType<List<SCServiceChannelServicesMessagingRfpRfp>>(response);
        }

        /// <summary>
        /// Test GetRfps
        /// </summary>
        [Fact]
        public void GetRfpsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? expand = null;
            //string? select = null;
            //string? filter = null;
            //string? orderby = null;
            //int? top = null;
            //int? skip = null;
            //bool? count = null;
            //var response = instance.GetRfps(expand, select, filter, orderby, top, skip, count);
            //Assert.IsType<List<SCServiceChannelServicesMessagingRfpRfp>>(response);
        }

        /// <summary>
        /// Test Rfps
        /// </summary>
        [Fact]
        public void RfpsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SCServiceChannelServicesMessagingRfpCreateRfpRequest request = null;
            //instance.Rfps(request);
        }

        /// <summary>
        /// Test Rfpsid
        /// </summary>
        [Fact]
        public void RfpsidTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //instance.Rfpsid(id);
        }

        /// <summary>
        /// Test RfpsnumberLocationslocationId
        /// </summary>
        [Fact]
        public void RfpsnumberLocationslocationIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string number = null;
            //int locationId = null;
            //instance.RfpsnumberLocationslocationId(number, locationId);
        }

        /// <summary>
        /// Test RfpsrfpIdAssign
        /// </summary>
        [Fact]
        public void RfpsrfpIdAssignTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int rfpId = null;
            //SCServiceChannelServicesMessagingRfpAssignRfpRequest request = null;
            //instance.RfpsrfpIdAssign(rfpId, request);
        }
    }
}