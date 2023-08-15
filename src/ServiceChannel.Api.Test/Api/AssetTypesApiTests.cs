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
    ///  Class for testing AssetTypesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AssetTypesApiTests : IDisposable
    {
        private AssetTypesApi instance;

        public AssetTypesApiTests()
        {
            instance = new AssetTypesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AssetTypesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AssetTypesApi
            //Assert.IsType<AssetTypesApi>(instance);
        }

        /// <summary>
        /// Test AssetTypes
        /// </summary>
        [Fact]
        public void AssetTypesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.AssetTypes();
            //Assert.IsType<List<SCServiceChannelServicesMessagingAssetsAssetType>>(response);
        }

        /// <summary>
        /// Test AssetTypesAsettypesAssetTypesForCreatetradeIdtradeId
        /// </summary>
        [Fact]
        public void AssetTypesAsettypesAssetTypesForCreatetradeIdtradeIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int tradeId = null;
            //var response = instance.AssetTypesAsettypesAssetTypesForCreatetradeIdtradeId(tradeId);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test AssetTypesAsettypesGetAssetTypeBrandsAsyncassetTypeId
        /// </summary>
        [Fact]
        public void AssetTypesAsettypesGetAssetTypeBrandsAsyncassetTypeIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int assetTypeId = null;
            //var response = instance.AssetTypesAsettypesGetAssetTypeBrandsAsyncassetTypeId(assetTypeId);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test AssetTypesAsettypesGetAssetTypesWithCreatePermissionsubscriberIdsubscriberIdtradeIdtradeId
        /// </summary>
        [Fact]
        public void AssetTypesAsettypesGetAssetTypesWithCreatePermissionsubscriberIdsubscriberIdtradeIdtradeIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int subscriberId = null;
            //int? tradeId = null;
            //var response = instance.AssetTypesAsettypesGetAssetTypesWithCreatePermissionsubscriberIdsubscriberIdtradeIdtradeId(subscriberId, tradeId);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test AssetTypesAsettypesGetPrimaryAssetTypeBrandsAsyncprimaryAssetTypeId
        /// </summary>
        [Fact]
        public void AssetTypesAsettypesGetPrimaryAssetTypeBrandsAsyncprimaryAssetTypeIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int primaryAssetTypeId = null;
            //var response = instance.AssetTypesAsettypesGetPrimaryAssetTypeBrandsAsyncprimaryAssetTypeId(primaryAssetTypeId);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test AssetTypesAsettypesGetPrimaryAssetTypesAsync
        /// </summary>
        [Fact]
        public void AssetTypesAsettypesGetPrimaryAssetTypesAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.AssetTypesAsettypesGetPrimaryAssetTypesAsync();
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test AssetTypesAssetTypeMeter
        /// </summary>
        [Fact]
        public void AssetTypesAssetTypeMeterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SCServiceChannelServicesMessagingAssetsAssetTypeMeterRequestItem request = null;
            //instance.AssetTypesAssetTypeMeter(request);
        }

        /// <summary>
        /// Test AssetTypesAssetTypeMeter_0
        /// </summary>
        [Fact]
        public void AssetTypesAssetTypeMeter_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SCServiceChannelServicesMessagingAssetsAssetTypeMeterRequestItem request = null;
            //instance.AssetTypesAssetTypeMeter_0(request);
        }

        /// <summary>
        /// Test AssetTypesAssetTypeMeterassetTypeMeterId
        /// </summary>
        [Fact]
        public void AssetTypesAssetTypeMeterassetTypeMeterIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int assetTypeMeterId = null;
            //var response = instance.AssetTypesAssetTypeMeterassetTypeMeterId(assetTypeMeterId);
            //Assert.IsType<SCServiceChannelServicesMessagingAssetsAssetTypeMeterResponseItem>(response);
        }

        /// <summary>
        /// Test AssetTypesAssetTypeMetersassetTypeId
        /// </summary>
        [Fact]
        public void AssetTypesAssetTypeMetersassetTypeIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int assetTypeId = null;
            //var response = instance.AssetTypesAssetTypeMetersassetTypeId(assetTypeId);
            //Assert.IsType<List<SCServiceChannelServicesMessagingAssetsAssetTypeMeterResponseItem>>(response);
        }

        /// <summary>
        /// Test AssetTypesAssetTypesAssetCategoriesByTradeIdtradeId
        /// </summary>
        [Fact]
        public void AssetTypesAssetTypesAssetCategoriesByTradeIdtradeIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int tradeId = null;
            //var response = instance.AssetTypesAssetTypesAssetCategoriesByTradeIdtradeId(tradeId);
            //Assert.IsType<List<SCServiceChannelServicesMessagingAssetsAssetTypeCategory>>(response);
        }

        /// <summary>
        /// Test AssetTypesAssetsassetGroupIdGroupattachments
        /// </summary>
        [Fact]
        public void AssetTypesAssetsassetGroupIdGroupattachmentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int assetGroupId = null;
            //System.IO.Stream file = null;
            //var response = instance.AssetTypesAssetsassetGroupIdGroupattachments(assetGroupId, file);
            //Assert.IsType<SCServiceChannelServicesMessagingAssetsAddAssetTypeGroupAttachmentResponse>(response);
        }

        /// <summary>
        /// Test AssetTypesByidsids0ids0ids1ids1
        /// </summary>
        [Fact]
        public void AssetTypesByidsids0ids0ids1ids1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int> ids = null;
            //var response = instance.AssetTypesByidsids0ids0ids1ids1(ids);
            //Assert.IsType<SCServiceChannelServicesMessagingAssetsAssetType>(response);
        }

        /// <summary>
        /// Test AssetTypesGetAssetTypeAttributesassetTypeId
        /// </summary>
        [Fact]
        public void AssetTypesGetAssetTypeAttributesassetTypeIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int assetTypeId = null;
            //var response = instance.AssetTypesGetAssetTypeAttributesassetTypeId(assetTypeId);
            //Assert.IsType<List<SCServiceChannelServicesMessagingAssetsAssetTypeAttributeExternal>>(response);
        }

        /// <summary>
        /// Test AssetTypesGetAssetTypeCategoriesByAssetIds
        /// </summary>
        [Fact]
        public void AssetTypesGetAssetTypeCategoriesByAssetIdsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SCServiceChannelServicesMessagingGetByIdsRequest request = null;
            //var response = instance.AssetTypesGetAssetTypeCategoriesByAssetIds(request);
            //Assert.IsType<Dictionary<string, SCServiceChannelServicesMessagingAssetsAssetTypeCategory>>(response);
        }

        /// <summary>
        /// Test AssetTypesGetAssetTypeCategoriesByIds
        /// </summary>
        [Fact]
        public void AssetTypesGetAssetTypeCategoriesByIdsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SCServiceChannelServicesMessagingGetByIdsRequest request = null;
            //var response = instance.AssetTypesGetAssetTypeCategoriesByIds(request);
            //Assert.IsType<SCServiceChannelServicesMessagingAssetsAssetTypeCategory>(response);
        }

        /// <summary>
        /// Test AssetTypesGetAssetTypeGroupssubscriberIdsubscriberId
        /// </summary>
        [Fact]
        public void AssetTypesGetAssetTypeGroupssubscriberIdsubscriberIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? subscriberId = null;
            //var response = instance.AssetTypesGetAssetTypeGroupssubscriberIdsubscriberId(subscriberId);
            //Assert.IsType<List<SCServiceChannelServicesMessagingAssetTypesAssetTypeGroup>>(response);
        }

        /// <summary>
        /// Test AssetTypesGetAssetTypeTradesassetTypeId
        /// </summary>
        [Fact]
        public void AssetTypesGetAssetTypeTradesassetTypeIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int assetTypeId = null;
            //var response = instance.AssetTypesGetAssetTypeTradesassetTypeId(assetTypeId);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test AssetTypesGetAssetTypesAvailableForSubscribersubscriberIdtradeIdtradeId
        /// </summary>
        [Fact]
        public void AssetTypesGetAssetTypesAvailableForSubscribersubscriberIdtradeIdtradeIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int subscriberId = null;
            //int? tradeId = null;
            //var response = instance.AssetTypesGetAssetTypesAvailableForSubscribersubscriberIdtradeIdtradeId(subscriberId, tradeId);
            //Assert.IsType<List<SCServiceChannelServicesMessagingAssetsAssetType>>(response);
        }

        /// <summary>
        /// Test AssetTypesGetAssetTypesByLocation
        /// </summary>
        [Fact]
        public void AssetTypesGetAssetTypesByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SCServiceChannelServicesCoreInternalRequestsAssetsGetAssetTypesByLocationRequestInternal request = null;
            //var response = instance.AssetTypesGetAssetTypesByLocation(request);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test AssetTypesGetSubscriberAssetTypeCategories
        /// </summary>
        [Fact]
        public void AssetTypesGetSubscriberAssetTypeCategoriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SCServiceChannelServicesMessagingAssetsGetSubscriberAssetCategoriesRequest request = null;
            //var response = instance.AssetTypesGetSubscriberAssetTypeCategories(request);
            //Assert.IsType<SCServiceChannelServicesMessagingAssetsAssetTypeCategory>(response);
        }

        /// <summary>
        /// Test AssetTypes_0
        /// </summary>
        [Fact]
        public void AssetTypes_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SCServiceChannelServicesMessagingAssetsAddAssetTypeRequest req = null;
            //var response = instance.AssetTypes_0(req);
            //Assert.IsType<SCServiceChannelServicesMessagingAssetsAddAssetTypeResponse>(response);
        }

        /// <summary>
        /// Test AssetTypesassetTypeId
        /// </summary>
        [Fact]
        public void AssetTypesassetTypeIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int assetTypeId = null;
            //var response = instance.AssetTypesassetTypeId(assetTypeId);
            //Assert.IsType<SCServiceChannelServicesMessagingAssetsAssetType>(response);
        }

        /// <summary>
        /// Test AssetTypesassetTypeId_0
        /// </summary>
        [Fact]
        public void AssetTypesassetTypeId_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int assetTypeId = null;
            //SCServiceChannelServicesMessagingAssetsAssetType type = null;
            //instance.AssetTypesassetTypeId_0(assetTypeId, type);
        }

        /// <summary>
        /// Test AssetTypesassetTypeId_1
        /// </summary>
        [Fact]
        public void AssetTypesassetTypeId_1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int assetTypeId = null;
            //instance.AssetTypesassetTypeId_1(assetTypeId);
        }
    }
}