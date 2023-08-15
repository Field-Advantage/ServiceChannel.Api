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
    ///  Class for testing SCServiceChannelServicesMessagingLocationLocationWithTimezoneName
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SCServiceChannelServicesMessagingLocationLocationWithTimezoneNameTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SCServiceChannelServicesMessagingLocationLocationWithTimezoneName
        //private SCServiceChannelServicesMessagingLocationLocationWithTimezoneName instance;

        public SCServiceChannelServicesMessagingLocationLocationWithTimezoneNameTests()
        {
            // TODO uncomment below to create an instance of SCServiceChannelServicesMessagingLocationLocationWithTimezoneName
            //instance = new SCServiceChannelServicesMessagingLocationLocationWithTimezoneName();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SCServiceChannelServicesMessagingLocationLocationWithTimezoneName
        /// </summary>
        [Fact]
        public void SCServiceChannelServicesMessagingLocationLocationWithTimezoneNameInstanceTest()
        {
            // TODO uncomment below to test "IsType" SCServiceChannelServicesMessagingLocationLocationWithTimezoneName
            //Assert.IsType<SCServiceChannelServicesMessagingLocationLocationWithTimezoneName>(instance);
        }


        /// <summary>
        /// Test the property 'TimezoneName'
        /// </summary>
        [Fact]
        public void TimezoneNameTest()
        {
            // TODO unit test for the property 'TimezoneName'
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
        /// Test the property 'SubscriberName'
        /// </summary>
        [Fact]
        public void SubscriberNameTest()
        {
            // TODO unit test for the property 'SubscriberName'
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
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
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
        /// Test the property 'Distance'
        /// </summary>
        [Fact]
        public void DistanceTest()
        {
            // TODO unit test for the property 'Distance'
        }
        /// <summary>
        /// Test the property 'Radius'
        /// </summary>
        [Fact]
        public void RadiusTest()
        {
            // TODO unit test for the property 'Radius'
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
        /// Test the property 'StateId'
        /// </summary>
        [Fact]
        public void StateIdTest()
        {
            // TODO unit test for the property 'StateId'
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
        /// Test the property 'CountryId'
        /// </summary>
        [Fact]
        public void CountryIdTest()
        {
            // TODO unit test for the property 'CountryId'
        }
        /// <summary>
        /// Test the property 'ClosedDate'
        /// </summary>
        [Fact]
        public void ClosedDateTest()
        {
            // TODO unit test for the property 'ClosedDate'
        }
        /// <summary>
        /// Test the property 'OpenDate'
        /// </summary>
        [Fact]
        public void OpenDateTest()
        {
            // TODO unit test for the property 'OpenDate'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
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
        /// Test the property 'FaxNumber'
        /// </summary>
        [Fact]
        public void FaxNumberTest()
        {
            // TODO unit test for the property 'FaxNumber'
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
        /// Test the property 'Contact'
        /// </summary>
        [Fact]
        public void ContactTest()
        {
            // TODO unit test for the property 'Contact'
        }
        /// <summary>
        /// Test the property 'HasInventory'
        /// </summary>
        [Fact]
        public void HasInventoryTest()
        {
            // TODO unit test for the property 'HasInventory'
        }
        /// <summary>
        /// Test the property 'SquareValue'
        /// </summary>
        [Fact]
        public void SquareValueTest()
        {
            // TODO unit test for the property 'SquareValue'
        }
        /// <summary>
        /// Test the property 'SquareMeasure'
        /// </summary>
        [Fact]
        public void SquareMeasureTest()
        {
            // TODO unit test for the property 'SquareMeasure'
        }
        /// <summary>
        /// Test the property 'TimeZoneInfoId'
        /// </summary>
        [Fact]
        public void TimeZoneInfoIdTest()
        {
            // TODO unit test for the property 'TimeZoneInfoId'
        }
        /// <summary>
        /// Test the property 'TimeZoneShortDescription'
        /// </summary>
        [Fact]
        public void TimeZoneShortDescriptionTest()
        {
            // TODO unit test for the property 'TimeZoneShortDescription'
        }
        /// <summary>
        /// Test the property 'TimeZoneMsName'
        /// </summary>
        [Fact]
        public void TimeZoneMsNameTest()
        {
            // TODO unit test for the property 'TimeZoneMsName'
        }
        /// <summary>
        /// Test the property 'TimeZoneIanaName'
        /// </summary>
        [Fact]
        public void TimeZoneIanaNameTest()
        {
            // TODO unit test for the property 'TimeZoneIanaName'
        }
        /// <summary>
        /// Test the property 'TypeLabel'
        /// </summary>
        [Fact]
        public void TypeLabelTest()
        {
            // TODO unit test for the property 'TypeLabel'
        }
        /// <summary>
        /// Test the property 'Supplier'
        /// </summary>
        [Fact]
        public void SupplierTest()
        {
            // TODO unit test for the property 'Supplier'
        }
        /// <summary>
        /// Test the property 'CountyId'
        /// </summary>
        [Fact]
        public void CountyIdTest()
        {
            // TODO unit test for the property 'CountyId'
        }
        /// <summary>
        /// Test the property 'Notes'
        /// </summary>
        [Fact]
        public void NotesTest()
        {
            // TODO unit test for the property 'Notes'
        }
        /// <summary>
        /// Test the property 'TimeShiftToEST'
        /// </summary>
        [Fact]
        public void TimeShiftToESTTest()
        {
            // TODO unit test for the property 'TimeShiftToEST'
        }
        /// <summary>
        /// Test the property 'AddressTypeId'
        /// </summary>
        [Fact]
        public void AddressTypeIdTest()
        {
            // TODO unit test for the property 'AddressTypeId'
        }
        /// <summary>
        /// Test the property 'FormattedAddress'
        /// </summary>
        [Fact]
        public void FormattedAddressTest()
        {
            // TODO unit test for the property 'FormattedAddress'
        }
        /// <summary>
        /// Test the property 'LocationFormattedAddressTail'
        /// </summary>
        [Fact]
        public void LocationFormattedAddressTailTest()
        {
            // TODO unit test for the property 'LocationFormattedAddressTail'
        }

    }

}
