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
    ///  Class for testing SCServiceChannelServicesMessagingProvidersProvider
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SCServiceChannelServicesMessagingProvidersProviderTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SCServiceChannelServicesMessagingProvidersProvider
        //private SCServiceChannelServicesMessagingProvidersProvider instance;

        public SCServiceChannelServicesMessagingProvidersProviderTests()
        {
            // TODO uncomment below to create an instance of SCServiceChannelServicesMessagingProvidersProvider
            //instance = new SCServiceChannelServicesMessagingProvidersProvider();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SCServiceChannelServicesMessagingProvidersProvider
        /// </summary>
        [Fact]
        public void SCServiceChannelServicesMessagingProvidersProviderInstanceTest()
        {
            // TODO uncomment below to test "IsType" SCServiceChannelServicesMessagingProvidersProvider
            //Assert.IsType<SCServiceChannelServicesMessagingProvidersProvider>(instance);
        }


        /// <summary>
        /// Test the property 'Phone'
        /// </summary>
        [Fact]
        public void PhoneTest()
        {
            // TODO unit test for the property 'Phone'
        }
        /// <summary>
        /// Test the property 'FullName'
        /// </summary>
        [Fact]
        public void FullNameTest()
        {
            // TODO unit test for the property 'FullName'
        }
        /// <summary>
        /// Test the property 'Address1'
        /// </summary>
        [Fact]
        public void Address1Test()
        {
            // TODO unit test for the property 'Address1'
        }
        /// <summary>
        /// Test the property 'Address2'
        /// </summary>
        [Fact]
        public void Address2Test()
        {
            // TODO unit test for the property 'Address2'
        }
        /// <summary>
        /// Test the property 'City'
        /// </summary>
        [Fact]
        public void CityTest()
        {
            // TODO unit test for the property 'City'
        }
        /// <summary>
        /// Test the property 'State'
        /// </summary>
        [Fact]
        public void StateTest()
        {
            // TODO unit test for the property 'State'
        }
        /// <summary>
        /// Test the property 'Zip'
        /// </summary>
        [Fact]
        public void ZipTest()
        {
            // TODO unit test for the property 'Zip'
        }
        /// <summary>
        /// Test the property 'Country'
        /// </summary>
        [Fact]
        public void CountryTest()
        {
            // TODO unit test for the property 'Country'
        }
        /// <summary>
        /// Test the property 'MainContact'
        /// </summary>
        [Fact]
        public void MainContactTest()
        {
            // TODO unit test for the property 'MainContact'
        }
        /// <summary>
        /// Test the property 'DateCreated'
        /// </summary>
        [Fact]
        public void DateCreatedTest()
        {
            // TODO unit test for the property 'DateCreated'
        }
        /// <summary>
        /// Test the property 'LastUserDate'
        /// </summary>
        [Fact]
        public void LastUserDateTest()
        {
            // TODO unit test for the property 'LastUserDate'
        }
        /// <summary>
        /// Test the property 'SuperUser'
        /// </summary>
        [Fact]
        public void SuperUserTest()
        {
            // TODO unit test for the property 'SuperUser'
        }
        /// <summary>
        /// Test the property 'WebSite'
        /// </summary>
        [Fact]
        public void WebSiteTest()
        {
            // TODO unit test for the property 'WebSite'
        }
        /// <summary>
        /// Test the property 'Email'
        /// </summary>
        [Fact]
        public void EmailTest()
        {
            // TODO unit test for the property 'Email'
        }
        /// <summary>
        /// Test the property 'TaxId'
        /// </summary>
        [Fact]
        public void TaxIdTest()
        {
            // TODO unit test for the property 'TaxId'
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
        /// Test the property 'ProcessingEmail'
        /// </summary>
        [Fact]
        public void ProcessingEmailTest()
        {
            // TODO unit test for the property 'ProcessingEmail'
        }
        /// <summary>
        /// Test the property 'FaxNumber'
        /// </summary>
        [Fact]
        public void FaxNumberTest()
        {
            // TODO unit test for the property 'FaxNumber'
        }
        /// <summary>
        /// Test the property 'SuiteFloor'
        /// </summary>
        [Fact]
        public void SuiteFloorTest()
        {
            // TODO unit test for the property 'SuiteFloor'
        }
        /// <summary>
        /// Test the property 'MailInfo'
        /// </summary>
        [Fact]
        public void MailInfoTest()
        {
            // TODO unit test for the property 'MailInfo'
        }
        /// <summary>
        /// Test the property 'ImageFile'
        /// </summary>
        [Fact]
        public void ImageFileTest()
        {
            // TODO unit test for the property 'ImageFile'
        }
        /// <summary>
        /// Test the property 'ReturnMail'
        /// </summary>
        [Fact]
        public void ReturnMailTest()
        {
            // TODO unit test for the property 'ReturnMail'
        }
        /// <summary>
        /// Test the property 'MailFrequency'
        /// </summary>
        [Fact]
        public void MailFrequencyTest()
        {
            // TODO unit test for the property 'MailFrequency'
        }
        /// <summary>
        /// Test the property 'FormId'
        /// </summary>
        [Fact]
        public void FormIdTest()
        {
            // TODO unit test for the property 'FormId'
        }
        /// <summary>
        /// Test the property 'Pager'
        /// </summary>
        [Fact]
        public void PagerTest()
        {
            // TODO unit test for the property 'Pager'
        }
        /// <summary>
        /// Test the property 'NightRequest'
        /// </summary>
        [Fact]
        public void NightRequestTest()
        {
            // TODO unit test for the property 'NightRequest'
        }
        /// <summary>
        /// Test the property 'ShortFormatEmail'
        /// </summary>
        [Fact]
        public void ShortFormatEmailTest()
        {
            // TODO unit test for the property 'ShortFormatEmail'
        }
        /// <summary>
        /// Test the property 'LastTrainingDate'
        /// </summary>
        [Fact]
        public void LastTrainingDateTest()
        {
            // TODO unit test for the property 'LastTrainingDate'
        }
        /// <summary>
        /// Test the property 'LastTrainingDateStr'
        /// </summary>
        [Fact]
        public void LastTrainingDateStrTest()
        {
            // TODO unit test for the property 'LastTrainingDateStr'
        }
        /// <summary>
        /// Test the property 'IsInternal'
        /// </summary>
        [Fact]
        public void IsInternalTest()
        {
            // TODO unit test for the property 'IsInternal'
        }
        /// <summary>
        /// Test the property 'IsOnOffShoreFeatureEnabled'
        /// </summary>
        [Fact]
        public void IsOnOffShoreFeatureEnabledTest()
        {
            // TODO unit test for the property 'IsOnOffShoreFeatureEnabled'
        }
        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
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
        /// Test the property 'DoNotDispatch'
        /// </summary>
        [Fact]
        public void DoNotDispatchTest()
        {
            // TODO unit test for the property 'DoNotDispatch'
        }

    }

}
