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
    ///  Class for testing SCServiceChannelNotificationsObjectsLocation
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SCServiceChannelNotificationsObjectsLocationTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SCServiceChannelNotificationsObjectsLocation
        //private SCServiceChannelNotificationsObjectsLocation instance;

        public SCServiceChannelNotificationsObjectsLocationTests()
        {
            // TODO uncomment below to create an instance of SCServiceChannelNotificationsObjectsLocation
            //instance = new SCServiceChannelNotificationsObjectsLocation();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SCServiceChannelNotificationsObjectsLocation
        /// </summary>
        [Fact]
        public void SCServiceChannelNotificationsObjectsLocationInstanceTest()
        {
            // TODO uncomment below to test "IsType" SCServiceChannelNotificationsObjectsLocation
            //Assert.IsType<SCServiceChannelNotificationsObjectsLocation>(instance);
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
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
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
        /// Test the property 'ShortName'
        /// </summary>
        [Fact]
        public void ShortNameTest()
        {
            // TODO unit test for the property 'ShortName'
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
        /// Test the property 'Region'
        /// </summary>
        [Fact]
        public void RegionTest()
        {
            // TODO unit test for the property 'Region'
        }
        /// <summary>
        /// Test the property 'District'
        /// </summary>
        [Fact]
        public void DistrictTest()
        {
            // TODO unit test for the property 'District'
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
        /// Test the property 'Country'
        /// </summary>
        [Fact]
        public void CountryTest()
        {
            // TODO unit test for the property 'Country'
        }
        /// <summary>
        /// Test the property 'StoreOpen'
        /// </summary>
        [Fact]
        public void StoreOpenTest()
        {
            // TODO unit test for the property 'StoreOpen'
        }
        /// <summary>
        /// Test the property 'StoreClose'
        /// </summary>
        [Fact]
        public void StoreCloseTest()
        {
            // TODO unit test for the property 'StoreClose'
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
        /// Test the property 'MainContact'
        /// </summary>
        [Fact]
        public void MainContactTest()
        {
            // TODO unit test for the property 'MainContact'
        }
        /// <summary>
        /// Test the property 'PhoneNumber'
        /// </summary>
        [Fact]
        public void PhoneNumberTest()
        {
            // TODO unit test for the property 'PhoneNumber'
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
        /// Test the property 'FacilityManager'
        /// </summary>
        [Fact]
        public void FacilityManagerTest()
        {
            // TODO unit test for the property 'FacilityManager'
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
        /// Test the property 'NotesCount'
        /// </summary>
        [Fact]
        public void NotesCountTest()
        {
            // TODO unit test for the property 'NotesCount'
        }
        /// <summary>
        /// Test the property 'LocationTypeId'
        /// </summary>
        [Fact]
        public void LocationTypeIdTest()
        {
            // TODO unit test for the property 'LocationTypeId'
        }
        /// <summary>
        /// Test the property 'LocationType'
        /// </summary>
        [Fact]
        public void LocationTypeTest()
        {
            // TODO unit test for the property 'LocationType'
        }
        /// <summary>
        /// Test the property 'Latitude'
        /// </summary>
        [Fact]
        public void LatitudeTest()
        {
            // TODO unit test for the property 'Latitude'
        }
        /// <summary>
        /// Test the property 'Longitude'
        /// </summary>
        [Fact]
        public void LongitudeTest()
        {
            // TODO unit test for the property 'Longitude'
        }
        /// <summary>
        /// Test the property 'TimeZoneId'
        /// </summary>
        [Fact]
        public void TimeZoneIdTest()
        {
            // TODO unit test for the property 'TimeZoneId'
        }
        /// <summary>
        /// Test the property 'RetiredAllProvidersDate'
        /// </summary>
        [Fact]
        public void RetiredAllProvidersDateTest()
        {
            // TODO unit test for the property 'RetiredAllProvidersDate'
        }
        /// <summary>
        /// Test the property 'RetiredLogin'
        /// </summary>
        [Fact]
        public void RetiredLoginTest()
        {
            // TODO unit test for the property 'RetiredLogin'
        }
        /// <summary>
        /// Test the property 'UpdatedUserName'
        /// </summary>
        [Fact]
        public void UpdatedUserNameTest()
        {
            // TODO unit test for the property 'UpdatedUserName'
        }
        /// <summary>
        /// Test the property 'UpdatedDate'
        /// </summary>
        [Fact]
        public void UpdatedDateTest()
        {
            // TODO unit test for the property 'UpdatedDate'
        }
        /// <summary>
        /// Test the property 'UpdatedLocationNotesUserName'
        /// </summary>
        [Fact]
        public void UpdatedLocationNotesUserNameTest()
        {
            // TODO unit test for the property 'UpdatedLocationNotesUserName'
        }
        /// <summary>
        /// Test the property 'UpdatedLocationNotesDate'
        /// </summary>
        [Fact]
        public void UpdatedLocationNotesDateTest()
        {
            // TODO unit test for the property 'UpdatedLocationNotesDate'
        }

    }

}