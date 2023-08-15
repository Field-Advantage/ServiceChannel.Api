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
    ///  Class for testing SCServiceChannelServicesMessagingAssetsAddAssetRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SCServiceChannelServicesMessagingAssetsAddAssetRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SCServiceChannelServicesMessagingAssetsAddAssetRequest
        //private SCServiceChannelServicesMessagingAssetsAddAssetRequest instance;

        public SCServiceChannelServicesMessagingAssetsAddAssetRequestTests()
        {
            // TODO uncomment below to create an instance of SCServiceChannelServicesMessagingAssetsAddAssetRequest
            //instance = new SCServiceChannelServicesMessagingAssetsAddAssetRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SCServiceChannelServicesMessagingAssetsAddAssetRequest
        /// </summary>
        [Fact]
        public void SCServiceChannelServicesMessagingAssetsAddAssetRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" SCServiceChannelServicesMessagingAssetsAddAssetRequest
            //Assert.IsType<SCServiceChannelServicesMessagingAssetsAddAssetRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Tag'
        /// </summary>
        [Fact]
        public void TagTest()
        {
            // TODO unit test for the property 'Tag'
        }
        /// <summary>
        /// Test the property 'ParentAssetTagId'
        /// </summary>
        [Fact]
        public void ParentAssetTagIdTest()
        {
            // TODO unit test for the property 'ParentAssetTagId'
        }
        /// <summary>
        /// Test the property 'Manufacturer'
        /// </summary>
        [Fact]
        public void ManufacturerTest()
        {
            // TODO unit test for the property 'Manufacturer'
        }
        /// <summary>
        /// Test the property 'ModelNo'
        /// </summary>
        [Fact]
        public void ModelNoTest()
        {
            // TODO unit test for the property 'ModelNo'
        }
        /// <summary>
        /// Test the property 'SerialNo'
        /// </summary>
        [Fact]
        public void SerialNoTest()
        {
            // TODO unit test for the property 'SerialNo'
        }
        /// <summary>
        /// Test the property 'LocationId'
        /// </summary>
        [Fact]
        public void LocationIdTest()
        {
            // TODO unit test for the property 'LocationId'
        }
        /// <summary>
        /// Test the property 'Area'
        /// </summary>
        [Fact]
        public void AreaTest()
        {
            // TODO unit test for the property 'Area'
        }
        /// <summary>
        /// Test the property 'WorkOrderArea'
        /// </summary>
        [Fact]
        public void WorkOrderAreaTest()
        {
            // TODO unit test for the property 'WorkOrderArea'
        }
        /// <summary>
        /// Test the property 'StoreId'
        /// </summary>
        [Fact]
        public void StoreIdTest()
        {
            // TODO unit test for the property 'StoreId'
        }
        /// <summary>
        /// Test the property 'Trade'
        /// </summary>
        [Fact]
        public void TradeTest()
        {
            // TODO unit test for the property 'Trade'
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
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }
        /// <summary>
        /// Test the property 'AssetTypeId'
        /// </summary>
        [Fact]
        public void AssetTypeIdTest()
        {
            // TODO unit test for the property 'AssetTypeId'
        }
        /// <summary>
        /// Test the property 'BrandId'
        /// </summary>
        [Fact]
        public void BrandIdTest()
        {
            // TODO unit test for the property 'BrandId'
        }
        /// <summary>
        /// Test the property 'Active'
        /// </summary>
        [Fact]
        public void ActiveTest()
        {
            // TODO unit test for the property 'Active'
        }
        /// <summary>
        /// Test the property 'InstallDate'
        /// </summary>
        [Fact]
        public void InstallDateTest()
        {
            // TODO unit test for the property 'InstallDate'
        }
        /// <summary>
        /// Test the property 'PurchaseDate'
        /// </summary>
        [Fact]
        public void PurchaseDateTest()
        {
            // TODO unit test for the property 'PurchaseDate'
        }
        /// <summary>
        /// Test the property 'ManufacturedDate'
        /// </summary>
        [Fact]
        public void ManufacturedDateTest()
        {
            // TODO unit test for the property 'ManufacturedDate'
        }
        /// <summary>
        /// Test the property 'Warranty'
        /// </summary>
        [Fact]
        public void WarrantyTest()
        {
            // TODO unit test for the property 'Warranty'
        }
        /// <summary>
        /// Test the property 'UsesRefrigerant'
        /// </summary>
        [Fact]
        public void UsesRefrigerantTest()
        {
            // TODO unit test for the property 'UsesRefrigerant'
        }
        /// <summary>
        /// Test the property 'IsLeased'
        /// </summary>
        [Fact]
        public void IsLeasedTest()
        {
            // TODO unit test for the property 'IsLeased'
        }
        /// <summary>
        /// Test the property 'LifeExpectancy'
        /// </summary>
        [Fact]
        public void LifeExpectancyTest()
        {
            // TODO unit test for the property 'LifeExpectancy'
        }
        /// <summary>
        /// Test the property 'OriginalValue'
        /// </summary>
        [Fact]
        public void OriginalValueTest()
        {
            // TODO unit test for the property 'OriginalValue'
        }
        /// <summary>
        /// Test the property 'LeaseDate'
        /// </summary>
        [Fact]
        public void LeaseDateTest()
        {
            // TODO unit test for the property 'LeaseDate'
        }
        /// <summary>
        /// Test the property 'LeasePeriod'
        /// </summary>
        [Fact]
        public void LeasePeriodTest()
        {
            // TODO unit test for the property 'LeasePeriod'
        }
        /// <summary>
        /// Test the property 'Condition'
        /// </summary>
        [Fact]
        public void ConditionTest()
        {
            // TODO unit test for the property 'Condition'
        }
        /// <summary>
        /// Test the property 'EnergyEfficiency'
        /// </summary>
        [Fact]
        public void EnergyEfficiencyTest()
        {
            // TODO unit test for the property 'EnergyEfficiency'
        }
        /// <summary>
        /// Test the property 'Capacity'
        /// </summary>
        [Fact]
        public void CapacityTest()
        {
            // TODO unit test for the property 'Capacity'
        }
        /// <summary>
        /// Test the property 'HasLeakDetector'
        /// </summary>
        [Fact]
        public void HasLeakDetectorTest()
        {
            // TODO unit test for the property 'HasLeakDetector'
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
        /// Test the property 'Description'
        /// </summary>
        [Fact]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'HasComponents'
        /// </summary>
        [Fact]
        public void HasComponentsTest()
        {
            // TODO unit test for the property 'HasComponents'
        }
        /// <summary>
        /// Test the property 'HasCircuits'
        /// </summary>
        [Fact]
        public void HasCircuitsTest()
        {
            // TODO unit test for the property 'HasCircuits'
        }
        /// <summary>
        /// Test the property 'ClearAssetTag'
        /// </summary>
        [Fact]
        public void ClearAssetTagTest()
        {
            // TODO unit test for the property 'ClearAssetTag'
        }
        /// <summary>
        /// Test the property 'AssetTag'
        /// </summary>
        [Fact]
        public void AssetTagTest()
        {
            // TODO unit test for the property 'AssetTag'
        }
        /// <summary>
        /// Test the property 'IsInspection'
        /// </summary>
        [Fact]
        public void IsInspectionTest()
        {
            // TODO unit test for the property 'IsInspection'
        }
        /// <summary>
        /// Test the property 'ProcessDuplicatedAssetTag'
        /// </summary>
        [Fact]
        public void ProcessDuplicatedAssetTagTest()
        {
            // TODO unit test for the property 'ProcessDuplicatedAssetTag'
        }
        /// <summary>
        /// Test the property 'IsCarbReporting'
        /// </summary>
        [Fact]
        public void IsCarbReportingTest()
        {
            // TODO unit test for the property 'IsCarbReporting'
        }
        /// <summary>
        /// Test the property 'ApplyCustom'
        /// </summary>
        [Fact]
        public void ApplyCustomTest()
        {
            // TODO unit test for the property 'ApplyCustom'
        }
        /// <summary>
        /// Test the property 'CustomAttributes'
        /// </summary>
        [Fact]
        public void CustomAttributesTest()
        {
            // TODO unit test for the property 'CustomAttributes'
        }
        /// <summary>
        /// Test the property 'AssetUpdatesStatus'
        /// </summary>
        [Fact]
        public void AssetUpdatesStatusTest()
        {
            // TODO unit test for the property 'AssetUpdatesStatus'
        }
        /// <summary>
        /// Test the property 'LocationNoteHeader'
        /// </summary>
        [Fact]
        public void LocationNoteHeaderTest()
        {
            // TODO unit test for the property 'LocationNoteHeader'
        }
        /// <summary>
        /// Test the property 'LocationNoteValue'
        /// </summary>
        [Fact]
        public void LocationNoteValueTest()
        {
            // TODO unit test for the property 'LocationNoteValue'
        }
        /// <summary>
        /// Test the property 'Currency'
        /// </summary>
        [Fact]
        public void CurrencyTest()
        {
            // TODO unit test for the property 'Currency'
        }

    }

}
