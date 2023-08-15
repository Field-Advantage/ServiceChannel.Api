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
    ///  Class for testing SCServiceChannelServicesMessagingProposalsProposalCategoryRow
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SCServiceChannelServicesMessagingProposalsProposalCategoryRowTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SCServiceChannelServicesMessagingProposalsProposalCategoryRow
        //private SCServiceChannelServicesMessagingProposalsProposalCategoryRow instance;

        public SCServiceChannelServicesMessagingProposalsProposalCategoryRowTests()
        {
            // TODO uncomment below to create an instance of SCServiceChannelServicesMessagingProposalsProposalCategoryRow
            //instance = new SCServiceChannelServicesMessagingProposalsProposalCategoryRow();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SCServiceChannelServicesMessagingProposalsProposalCategoryRow
        /// </summary>
        [Fact]
        public void SCServiceChannelServicesMessagingProposalsProposalCategoryRowInstanceTest()
        {
            // TODO uncomment below to test "IsType" SCServiceChannelServicesMessagingProposalsProposalCategoryRow
            //Assert.IsType<SCServiceChannelServicesMessagingProposalsProposalCategoryRow>(instance);
        }


        /// <summary>
        /// Test the property 'Required'
        /// </summary>
        [Fact]
        public void RequiredTest()
        {
            // TODO unit test for the property 'Required'
        }
        /// <summary>
        /// Test the property 'HideDetails'
        /// </summary>
        [Fact]
        public void HideDetailsTest()
        {
            // TODO unit test for the property 'HideDetails'
        }
        /// <summary>
        /// Test the property 'TotalCost'
        /// </summary>
        [Fact]
        public void TotalCostTest()
        {
            // TODO unit test for the property 'TotalCost'
        }
        /// <summary>
        /// Test the property 'ServiceType'
        /// </summary>
        [Fact]
        public void ServiceTypeTest()
        {
            // TODO unit test for the property 'ServiceType'
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
        /// Test the property 'IsActive'
        /// </summary>
        [Fact]
        public void IsActiveTest()
        {
            // TODO unit test for the property 'IsActive'
        }
        /// <summary>
        /// Test the property 'SortOrder'
        /// </summary>
        [Fact]
        public void SortOrderTest()
        {
            // TODO unit test for the property 'SortOrder'
        }
        /// <summary>
        /// Test the property 'Quantity1'
        /// </summary>
        [Fact]
        public void Quantity1Test()
        {
            // TODO unit test for the property 'Quantity1'
        }
        /// <summary>
        /// Test the property 'Quantity2'
        /// </summary>
        [Fact]
        public void Quantity2Test()
        {
            // TODO unit test for the property 'Quantity2'
        }
        /// <summary>
        /// Test the property 'UnitCost'
        /// </summary>
        [Fact]
        public void UnitCostTest()
        {
            // TODO unit test for the property 'UnitCost'
        }
        /// <summary>
        /// Test the property 'UnitOfMeasure'
        /// </summary>
        [Fact]
        public void UnitOfMeasureTest()
        {
            // TODO unit test for the property 'UnitOfMeasure'
        }
        /// <summary>
        /// Test the property 'ExtendedCost'
        /// </summary>
        [Fact]
        public void ExtendedCostTest()
        {
            // TODO unit test for the property 'ExtendedCost'
        }
        /// <summary>
        /// Test the property 'Craft'
        /// </summary>
        [Fact]
        public void CraftTest()
        {
            // TODO unit test for the property 'Craft'
        }
        /// <summary>
        /// Test the property 'RepairCategory'
        /// </summary>
        [Fact]
        public void RepairCategoryTest()
        {
            // TODO unit test for the property 'RepairCategory'
        }
        /// <summary>
        /// Test the property 'RepairType'
        /// </summary>
        [Fact]
        public void RepairTypeTest()
        {
            // TODO unit test for the property 'RepairType'
        }
        /// <summary>
        /// Test the property 'MaterialThickness'
        /// </summary>
        [Fact]
        public void MaterialThicknessTest()
        {
            // TODO unit test for the property 'MaterialThickness'
        }
        /// <summary>
        /// Test the property 'Markup'
        /// </summary>
        [Fact]
        public void MarkupTest()
        {
            // TODO unit test for the property 'Markup'
        }
        /// <summary>
        /// Test the property 'PriceList'
        /// </summary>
        [Fact]
        public void PriceListTest()
        {
            // TODO unit test for the property 'PriceList'
        }
        /// <summary>
        /// Test the property 'PartNumber'
        /// </summary>
        [Fact]
        public void PartNumberTest()
        {
            // TODO unit test for the property 'PartNumber'
        }
        /// <summary>
        /// Test the property 'PartName'
        /// </summary>
        [Fact]
        public void PartNameTest()
        {
            // TODO unit test for the property 'PartName'
        }
        /// <summary>
        /// Test the property 'VAT'
        /// </summary>
        [Fact]
        public void VATTest()
        {
            // TODO unit test for the property 'VAT'
        }
        /// <summary>
        /// Test the property 'FeesType'
        /// </summary>
        [Fact]
        public void FeesTypeTest()
        {
            // TODO unit test for the property 'FeesType'
        }

    }

}