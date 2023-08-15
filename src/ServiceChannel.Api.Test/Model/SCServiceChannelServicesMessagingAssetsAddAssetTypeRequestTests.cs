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
    ///  Class for testing SCServiceChannelServicesMessagingAssetsAddAssetTypeRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SCServiceChannelServicesMessagingAssetsAddAssetTypeRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SCServiceChannelServicesMessagingAssetsAddAssetTypeRequest
        //private SCServiceChannelServicesMessagingAssetsAddAssetTypeRequest instance;

        public SCServiceChannelServicesMessagingAssetsAddAssetTypeRequestTests()
        {
            // TODO uncomment below to create an instance of SCServiceChannelServicesMessagingAssetsAddAssetTypeRequest
            //instance = new SCServiceChannelServicesMessagingAssetsAddAssetTypeRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SCServiceChannelServicesMessagingAssetsAddAssetTypeRequest
        /// </summary>
        [Fact]
        public void SCServiceChannelServicesMessagingAssetsAddAssetTypeRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" SCServiceChannelServicesMessagingAssetsAddAssetTypeRequest
            //Assert.IsType<SCServiceChannelServicesMessagingAssetsAddAssetTypeRequest>(instance);
        }


        /// <summary>
        /// Test the property 'ValidateTradeByName'
        /// </summary>
        [Fact]
        public void ValidateTradeByNameTest()
        {
            // TODO unit test for the property 'ValidateTradeByName'
        }
        /// <summary>
        /// Test the property 'AllowAdditionalTradesOnInheritance'
        /// </summary>
        [Fact]
        public void AllowAdditionalTradesOnInheritanceTest()
        {
            // TODO unit test for the property 'AllowAdditionalTradesOnInheritance'
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
        /// Test the property 'PrimaryTrade'
        /// </summary>
        [Fact]
        public void PrimaryTradeTest()
        {
            // TODO unit test for the property 'PrimaryTrade'
        }
        /// <summary>
        /// Test the property 'TradeId'
        /// </summary>
        [Fact]
        public void TradeIdTest()
        {
            // TODO unit test for the property 'TradeId'
        }
        /// <summary>
        /// Test the property 'ParentId'
        /// </summary>
        [Fact]
        public void ParentIdTest()
        {
            // TODO unit test for the property 'ParentId'
        }
        /// <summary>
        /// Test the property 'RefrigerantPurposeId'
        /// </summary>
        [Fact]
        public void RefrigerantPurposeIdTest()
        {
            // TODO unit test for the property 'RefrigerantPurposeId'
        }
        /// <summary>
        /// Test the property 'RefrigerantPurposeName'
        /// </summary>
        [Fact]
        public void RefrigerantPurposeNameTest()
        {
            // TODO unit test for the property 'RefrigerantPurposeName'
        }
        /// <summary>
        /// Test the property 'AdditionalTrades'
        /// </summary>
        [Fact]
        public void AdditionalTradesTest()
        {
            // TODO unit test for the property 'AdditionalTrades'
        }
        /// <summary>
        /// Test the property 'AdditionalTradesIds'
        /// </summary>
        [Fact]
        public void AdditionalTradesIdsTest()
        {
            // TODO unit test for the property 'AdditionalTradesIds'
        }
        /// <summary>
        /// Test the property 'IsCircuit'
        /// </summary>
        [Fact]
        public void IsCircuitTest()
        {
            // TODO unit test for the property 'IsCircuit'
        }
        /// <summary>
        /// Test the property 'UserId'
        /// </summary>
        [Fact]
        public void UserIdTest()
        {
            // TODO unit test for the property 'UserId'
        }
        /// <summary>
        /// Test the property 'AssetTypeGroupId'
        /// </summary>
        [Fact]
        public void AssetTypeGroupIdTest()
        {
            // TODO unit test for the property 'AssetTypeGroupId'
        }
        /// <summary>
        /// Test the property 'PrimaryAssetTypeId'
        /// </summary>
        [Fact]
        public void PrimaryAssetTypeIdTest()
        {
            // TODO unit test for the property 'PrimaryAssetTypeId'
        }
        /// <summary>
        /// Test the property 'BrandIds'
        /// </summary>
        [Fact]
        public void BrandIdsTest()
        {
            // TODO unit test for the property 'BrandIds'
        }

    }

}
