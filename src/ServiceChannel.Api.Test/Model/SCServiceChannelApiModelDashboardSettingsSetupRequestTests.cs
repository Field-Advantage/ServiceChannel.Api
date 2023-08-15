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
    ///  Class for testing SCServiceChannelApiModelDashboardSettingsSetupRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SCServiceChannelApiModelDashboardSettingsSetupRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SCServiceChannelApiModelDashboardSettingsSetupRequest
        //private SCServiceChannelApiModelDashboardSettingsSetupRequest instance;

        public SCServiceChannelApiModelDashboardSettingsSetupRequestTests()
        {
            // TODO uncomment below to create an instance of SCServiceChannelApiModelDashboardSettingsSetupRequest
            //instance = new SCServiceChannelApiModelDashboardSettingsSetupRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SCServiceChannelApiModelDashboardSettingsSetupRequest
        /// </summary>
        [Fact]
        public void SCServiceChannelApiModelDashboardSettingsSetupRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" SCServiceChannelApiModelDashboardSettingsSetupRequest
            //Assert.IsType<SCServiceChannelApiModelDashboardSettingsSetupRequest>(instance);
        }


        /// <summary>
        /// Test the property 'SetupId'
        /// </summary>
        [Fact]
        public void SetupIdTest()
        {
            // TODO unit test for the property 'SetupId'
        }
        /// <summary>
        /// Test the property 'EnableRequestWizard'
        /// </summary>
        [Fact]
        public void EnableRequestWizardTest()
        {
            // TODO unit test for the property 'EnableRequestWizard'
        }
        /// <summary>
        /// Test the property 'ShowPrivateStoreNotes'
        /// </summary>
        [Fact]
        public void ShowPrivateStoreNotesTest()
        {
            // TODO unit test for the property 'ShowPrivateStoreNotes'
        }
        /// <summary>
        /// Test the property 'ShowProviderPhoneNumber'
        /// </summary>
        [Fact]
        public void ShowProviderPhoneNumberTest()
        {
            // TODO unit test for the property 'ShowProviderPhoneNumber'
        }
        /// <summary>
        /// Test the property 'ShowLastServiceCall'
        /// </summary>
        [Fact]
        public void ShowLastServiceCallTest()
        {
            // TODO unit test for the property 'ShowLastServiceCall'
        }
        /// <summary>
        /// Test the property 'SetOriginalVendorForRecalls'
        /// </summary>
        [Fact]
        public void SetOriginalVendorForRecallsTest()
        {
            // TODO unit test for the property 'SetOriginalVendorForRecalls'
        }
        /// <summary>
        /// Test the property 'NteToZeroForRecalls'
        /// </summary>
        [Fact]
        public void NteToZeroForRecallsTest()
        {
            // TODO unit test for the property 'NteToZeroForRecalls'
        }
        /// <summary>
        /// Test the property 'SendAlertToFM'
        /// </summary>
        [Fact]
        public void SendAlertToFMTest()
        {
            // TODO unit test for the property 'SendAlertToFM'
        }
        /// <summary>
        /// Test the property 'TurnOffDescription'
        /// </summary>
        [Fact]
        public void TurnOffDescriptionTest()
        {
            // TODO unit test for the property 'TurnOffDescription'
        }
        /// <summary>
        /// Test the property 'DaysOfHistoryToDisplay'
        /// </summary>
        [Fact]
        public void DaysOfHistoryToDisplayTest()
        {
            // TODO unit test for the property 'DaysOfHistoryToDisplay'
        }
        /// <summary>
        /// Test the property 'ShowStoreWarrantyStr'
        /// </summary>
        [Fact]
        public void ShowStoreWarrantyStrTest()
        {
            // TODO unit test for the property 'ShowStoreWarrantyStr'
        }
        /// <summary>
        /// Test the property 'ShowStoreWarranty'
        /// </summary>
        [Fact]
        public void ShowStoreWarrantyTest()
        {
            // TODO unit test for the property 'ShowStoreWarranty'
        }
        /// <summary>
        /// Test the property 'StoreWarrantyMessage'
        /// </summary>
        [Fact]
        public void StoreWarrantyMessageTest()
        {
            // TODO unit test for the property 'StoreWarrantyMessage'
        }
        /// <summary>
        /// Test the property 'ConfirmationMessage'
        /// </summary>
        [Fact]
        public void ConfirmationMessageTest()
        {
            // TODO unit test for the property 'ConfirmationMessage'
        }
        /// <summary>
        /// Test the property 'ProviderNotFoundMessage'
        /// </summary>
        [Fact]
        public void ProviderNotFoundMessageTest()
        {
            // TODO unit test for the property 'ProviderNotFoundMessage'
        }
        /// <summary>
        /// Test the property 'EnableEquipment'
        /// </summary>
        [Fact]
        public void EnableEquipmentTest()
        {
            // TODO unit test for the property 'EnableEquipment'
        }
        /// <summary>
        /// Test the property 'DuplicateFilters'
        /// </summary>
        [Fact]
        public void DuplicateFiltersTest()
        {
            // TODO unit test for the property 'DuplicateFilters'
        }
        /// <summary>
        /// Test the property 'ExcludedCategoriesOpenDup'
        /// </summary>
        [Fact]
        public void ExcludedCategoriesOpenDupTest()
        {
            // TODO unit test for the property 'ExcludedCategoriesOpenDup'
        }
        /// <summary>
        /// Test the property 'ExcludedCategoriesClosedDup'
        /// </summary>
        [Fact]
        public void ExcludedCategoriesClosedDupTest()
        {
            // TODO unit test for the property 'ExcludedCategoriesClosedDup'
        }
        /// <summary>
        /// Test the property 'ExcludedTradesOpenDup'
        /// </summary>
        [Fact]
        public void ExcludedTradesOpenDupTest()
        {
            // TODO unit test for the property 'ExcludedTradesOpenDup'
        }
        /// <summary>
        /// Test the property 'EnableEquipmentReplacementFlag'
        /// </summary>
        [Fact]
        public void EnableEquipmentReplacementFlagTest()
        {
            // TODO unit test for the property 'EnableEquipmentReplacementFlag'
        }
        /// <summary>
        /// Test the property 'EnableRequestWizardMobile'
        /// </summary>
        [Fact]
        public void EnableRequestWizardMobileTest()
        {
            // TODO unit test for the property 'EnableRequestWizardMobile'
        }
        /// <summary>
        /// Test the property 'EnableLocationNotes'
        /// </summary>
        [Fact]
        public void EnableLocationNotesTest()
        {
            // TODO unit test for the property 'EnableLocationNotes'
        }
        /// <summary>
        /// Test the property 'AlwaysShowLocationNotes'
        /// </summary>
        [Fact]
        public void AlwaysShowLocationNotesTest()
        {
            // TODO unit test for the property 'AlwaysShowLocationNotes'
        }
        /// <summary>
        /// Test the property 'SkipTroubleshootingStep'
        /// </summary>
        [Fact]
        public void SkipTroubleshootingStepTest()
        {
            // TODO unit test for the property 'SkipTroubleshootingStep'
        }
        /// <summary>
        /// Test the property 'HidePriority'
        /// </summary>
        [Fact]
        public void HidePriorityTest()
        {
            // TODO unit test for the property 'HidePriority'
        }
        /// <summary>
        /// Test the property 'EnableIssueListKeywordSearch'
        /// </summary>
        [Fact]
        public void EnableIssueListKeywordSearchTest()
        {
            // TODO unit test for the property 'EnableIssueListKeywordSearch'
        }
        /// <summary>
        /// Test the property 'AssetFirstWorkOrderCreation'
        /// </summary>
        [Fact]
        public void AssetFirstWorkOrderCreationTest()
        {
            // TODO unit test for the property 'AssetFirstWorkOrderCreation'
        }
        /// <summary>
        /// Test the property 'HideGPSRadius'
        /// </summary>
        [Fact]
        public void HideGPSRadiusTest()
        {
            // TODO unit test for the property 'HideGPSRadius'
        }
        /// <summary>
        /// Test the property 'DuplicateMessage'
        /// </summary>
        [Fact]
        public void DuplicateMessageTest()
        {
            // TODO unit test for the property 'DuplicateMessage'
        }

    }

}