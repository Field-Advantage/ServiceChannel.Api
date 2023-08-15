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
    ///  Class for testing SCServiceChannelApiModelLocationsLocationFilterColumns
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SCServiceChannelApiModelLocationsLocationFilterColumnsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SCServiceChannelApiModelLocationsLocationFilterColumns
        //private SCServiceChannelApiModelLocationsLocationFilterColumns instance;

        public SCServiceChannelApiModelLocationsLocationFilterColumnsTests()
        {
            // TODO uncomment below to create an instance of SCServiceChannelApiModelLocationsLocationFilterColumns
            //instance = new SCServiceChannelApiModelLocationsLocationFilterColumns();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SCServiceChannelApiModelLocationsLocationFilterColumns
        /// </summary>
        [Fact]
        public void SCServiceChannelApiModelLocationsLocationFilterColumnsInstanceTest()
        {
            // TODO uncomment below to test "IsType" SCServiceChannelApiModelLocationsLocationFilterColumns
            //Assert.IsType<SCServiceChannelApiModelLocationsLocationFilterColumns>(instance);
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
        /// Test the property 'LocationIds'
        /// </summary>
        [Fact]
        public void LocationIdsTest()
        {
            // TODO unit test for the property 'LocationIds'
        }
        /// <summary>
        /// Test the property 'CountryIds'
        /// </summary>
        [Fact]
        public void CountryIdsTest()
        {
            // TODO unit test for the property 'CountryIds'
        }
        /// <summary>
        /// Test the property 'Regions'
        /// </summary>
        [Fact]
        public void RegionsTest()
        {
            // TODO unit test for the property 'Regions'
        }
        /// <summary>
        /// Test the property 'Districts'
        /// </summary>
        [Fact]
        public void DistrictsTest()
        {
            // TODO unit test for the property 'Districts'
        }
        /// <summary>
        /// Test the property 'States'
        /// </summary>
        [Fact]
        public void StatesTest()
        {
            // TODO unit test for the property 'States'
        }
        /// <summary>
        /// Test the property 'Counties'
        /// </summary>
        [Fact]
        public void CountiesTest()
        {
            // TODO unit test for the property 'Counties'
        }
        /// <summary>
        /// Test the property 'Cities'
        /// </summary>
        [Fact]
        public void CitiesTest()
        {
            // TODO unit test for the property 'Cities'
        }
        /// <summary>
        /// Test the property 'Page'
        /// </summary>
        [Fact]
        public void PageTest()
        {
            // TODO unit test for the property 'Page'
        }
        /// <summary>
        /// Test the property 'CountPerPage'
        /// </summary>
        [Fact]
        public void CountPerPageTest()
        {
            // TODO unit test for the property 'CountPerPage'
        }

    }

}