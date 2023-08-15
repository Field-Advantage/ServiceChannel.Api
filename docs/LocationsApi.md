# ServiceChannel.Api.Api.LocationsApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Filter**](LocationsApi.md#filter) | **POST** /filter | Retrieve Locations by location ids |
| [**GetFilteredLocations**](LocationsApi.md#getfilteredlocations) | **POST** /GetFilteredLocations | Get locations by filters |
| [**GetLocationDistrictspagepagepageSizepageSizesearchExpressionsearchExpression**](LocationsApi.md#getlocationdistrictspagepagepagesizepagesizesearchexpressionsearchexpression) | **GET** /GetLocationDistricts | Get location districts |
| [**GetLocations**](LocationsApi.md#getlocations) | **GET** /odata/locations | Retrieve locations |
| [**GetLocationsMobilepagepagepageSizepageSizelatitudelatitudelongitudelongitudesearchExpressionsearchExpressiononlyOpenedonlyOpened**](LocationsApi.md#getlocationsmobilepagepagepagesizepagesizelatitudelatitudelongitudelongitudesearchexpressionsearchexpressiononlyopenedonlyopened) | **GET** /GetLocationsMobile | Get Locations |
| [**GetLocationsNearMe**](LocationsApi.md#getlocationsnearme) | **GET** /odata/locations/Service.NearBy(latitude&#x3D;{latitude},longitude&#x3D;{longitude}) | Get locations by geographic coordinates |
| [**GetServiceRequestLocations**](LocationsApi.md#getservicerequestlocations) | **GET** /odata/locations/Service.ForServiceRequest() | Retrieve locations |
| [**LandlordResponsibilities**](LocationsApi.md#landlordresponsibilities) | **PUT** /landlord-responsibilities | Update Landlord Responsibility |
| [**LandlordResponsibilities_0**](LocationsApi.md#landlordresponsibilities_0) | **POST** /landlord-responsibilities | Create landlord responsibility |
| [**LandlordResponsibilitiesresponsibilityId**](LocationsApi.md#landlordresponsibilitiesresponsibilityid) | **DELETE** /landlord-responsibilities/{responsibilityId} | Delete Landlord Responsibility |
| [**LandlordResponsibilitiesstoreIdstoreId**](LocationsApi.md#landlordresponsibilitiesstoreidstoreid) | **GET** /landlord-responsibilities | Get landlord responsibilities |
| [**Locations**](LocationsApi.md#locations) | **POST** /locations | Add a location |
| [**LocationsAddressformatsc0c0c1c1id0id0id1id1**](LocationsApi.md#locationsaddressformatsc0c0c1c1id0id0id1id1) | **GET** /locations/addressformats | Retrieve address format pattern per list of country ISO codes or per list of address types Ids |
| [**LocationsCheckIfLocationIsOpenlocationIdlocationIdcheckTimecheckTime**](LocationsApi.md#locationscheckiflocationisopenlocationidlocationidchecktimechecktime) | **GET** /locations/CheckIfLocationIsOpen | Check whether the location is open or closed. |
| [**LocationsGetLocationsByFilterColumns**](LocationsApi.md#locationsgetlocationsbyfiltercolumns) | **POST** /locations/GetLocationsByFilterColumns | Retrieve locations by filters |
| [**LocationsIdIdstoreIdentifierstoreIdentifierNameNameSortSortPagePagePageSizePageSize**](LocationsApi.md#locationsididstoreidentifierstoreidentifiernamenamesortsortpagepagepagesizepagesize) | **GET** /locations | Retrieve stores |
| [**LocationsLocationWithNotes**](LocationsApi.md#locationslocationwithnotes) | **POST** /locations/LocationWithNotes | Create a location with location notes |
| [**LocationsUnassignedContracts**](LocationsApi.md#locationsunassignedcontracts) | **GET** /locations/UnassignedContracts | Get unassigned contracts |
| [**LocationslocationId**](LocationsApi.md#locationslocationid) | **GET** /locations/{locationId} | Retrieve a location |
| [**LocationslocationIdEvacuationmaps**](LocationsApi.md#locationslocationidevacuationmaps) | **GET** /locations/{locationId}/evacuationmaps | Get an evacuation plan map of a location |
| [**LocationslocationIdNotes**](LocationsApi.md#locationslocationidnotes) | **POST** /locations/{locationId}/notes | Add a location note |
| [**LocationslocationIdNotesprivateNotesprivateNotes**](LocationsApi.md#locationslocationidnotesprivatenotesprivatenotes) | **GET** /locations/{locationId}/notes | Retrieve location notes |
| [**LocationslocationId_0**](LocationsApi.md#locationslocationid_0) | **PUT** /locations/{locationId} | Update a location |
| [**LocationslocationId_1**](LocationsApi.md#locationslocationid_1) | **DELETE** /locations/{locationId} | Delete a location |
| [**LocationsstoreIdAttachments**](LocationsApi.md#locationsstoreidattachments) | **GET** /locations/{storeId}/attachments | Get a Location’s Attachments |
| [**LocationsstoreIdAttachmentsattachmentId**](LocationsApi.md#locationsstoreidattachmentsattachmentid) | **DELETE** /locations/{storeId}/attachments/{attachmentId} | Delete a Location Attachment |
| [**LocationsstoreIdAttachmentsfileDescriptionfileDescriptionisEvacuationPlanisEvacuationPlan**](LocationsApi.md#locationsstoreidattachmentsfiledescriptionfiledescriptionisevacuationplanisevacuationplan) | **POST** /locations/{storeId}/attachments | Create a Location Attachment |
| [**LocationsstoreIdUpdateNotes**](LocationsApi.md#locationsstoreidupdatenotes) | **POST** /locations/{storeId}/updateNotes | Add location notes |
| [**ProvidersGetPrimaryLocationAssignmentsForProviderIdsproviderIds0providerIds0providerIds1providerIds1dateFromdateFromdateTodateTo**](LocationsApi.md#providersgetprimarylocationassignmentsforprovideridsproviderids0providerids0providerids1providerids1datefromdatefromdatetodateto) | **GET** /providers/GetPrimaryLocationAssignmentsForProviderIds | Get provider primary location assignments by Provider Ids |
| [**ProvidersGetProviderAssignmentsForLocationsAndTrades**](LocationsApi.md#providersgetproviderassignmentsforlocationsandtrades) | **POST** /providers/GetProviderAssignmentsForLocationsAndTrades | Retrieve Provider Assignments by locations and trades |
| [**ProvidersGetProviderLocationAssignments**](LocationsApi.md#providersgetproviderlocationassignments) | **GET** /providers/GetProviderLocationAssignments | Get provider location assignments |
| [**StoresIdIdstoreIdentifierstoreIdentifierNameNameSortSortPagePagePageSizePageSize**](LocationsApi.md#storesididstoreidentifierstoreidentifiernamenamesortsortpagepagepagesizepagesize) | **GET** /stores | Retrieve stores |
| [**SubscribersCurrentUsersCurrentStores**](LocationsApi.md#subscriberscurrentuserscurrentstores) | **GET** /subscribers/current/users/current/stores | Get stores |
| [**SubscriberssubscriberIdLocationsinfofilterTypefilterTypesearchStringsearchString**](LocationsApi.md#subscriberssubscriberidlocationsinfofiltertypefiltertypesearchstringsearchstring) | **GET** /subscribers/{subscriberId}/locationsinfo | Retrieve location information |

<a id="filter"></a>
# **Filter**
> SCServiceChannelServicesMessagingLocationGetApiLocationResponse Filter (SCServiceChannelServicesMessagingLocationGetLocationsByFilterRequest locationFilter)

Retrieve Locations by location ids

Returns a list of locations.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class FilterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);
            var locationFilter = new SCServiceChannelServicesMessagingLocationGetLocationsByFilterRequest(); // SCServiceChannelServicesMessagingLocationGetLocationsByFilterRequest | Request parameters to filter the response.

            try
            {
                // Retrieve Locations by location ids
                SCServiceChannelServicesMessagingLocationGetApiLocationResponse result = apiInstance.Filter(locationFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.Filter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FilterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Locations by location ids
    ApiResponse<SCServiceChannelServicesMessagingLocationGetApiLocationResponse> response = apiInstance.FilterWithHttpInfo(locationFilter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.FilterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationFilter** | [**SCServiceChannelServicesMessagingLocationGetLocationsByFilterRequest**](SCServiceChannelServicesMessagingLocationGetLocationsByFilterRequest.md) | Request parameters to filter the response. |  |

### Return type

[**SCServiceChannelServicesMessagingLocationGetApiLocationResponse**](SCServiceChannelServicesMessagingLocationGetApiLocationResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested locations are in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              655 — Location Ids List is empty or null. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfilteredlocations"></a>
# **GetFilteredLocations**
> List&lt;SCServiceChannelServicesMessagingLocationLocationShortModel&gt; GetFilteredLocations (SCServiceChannelServicesMessagingLocationGetFilteredLocationsRequest request)

Get locations by filters

Returns locations based on the filters applied.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetFilteredLocationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);
            var request = new SCServiceChannelServicesMessagingLocationGetFilteredLocationsRequest(); // SCServiceChannelServicesMessagingLocationGetFilteredLocationsRequest | Request parameters to filter the response. Parameters can be used separately, as a combination of several parameters, or all at once. For the `LocationIds` and `StateIds` parameters, several values can be entered separated with a comma.              <br />**Example Request**                                POST /GetFilteredLocations                  {                   \"ProviderId\": 2000069665,                   \"LocationIds\": [                     2005862796, 2005901195                   ],                   \"StateIds\": [                     30, 32                   ]                  }

            try
            {
                // Get locations by filters
                List<SCServiceChannelServicesMessagingLocationLocationShortModel> result = apiInstance.GetFilteredLocations(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.GetFilteredLocations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFilteredLocationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get locations by filters
    ApiResponse<List<SCServiceChannelServicesMessagingLocationLocationShortModel>> response = apiInstance.GetFilteredLocationsWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.GetFilteredLocationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingLocationGetFilteredLocationsRequest**](SCServiceChannelServicesMessagingLocationGetFilteredLocationsRequest.md) | Request parameters to filter the response. Parameters can be used separately, as a combination of several parameters, or all at once. For the &#x60;LocationIds&#x60; and &#x60;StateIds&#x60; parameters, several values can be entered separated with a comma.              &lt;br /&gt;**Example Request**                                POST /GetFilteredLocations                  {                   \&quot;ProviderId\&quot;: 2000069665,                   \&quot;LocationIds\&quot;: [                     2005862796, 2005901195                   ],                   \&quot;StateIds\&quot;: [                     30, 32                   ]                  } |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingLocationLocationShortModel&gt;**](SCServiceChannelServicesMessagingLocationLocationShortModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The filtered locations are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:               502 — Subscriber not found |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **403** | You are not authorized to request this resource, or the resource is unavailable for some reason.              &lt;br/&gt;Error codes:              100 — User has no rights to perform this action |  -  |
| **500** | The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 — Object reference not set to an instance of an object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getlocationdistrictspagepagepagesizepagesizesearchexpressionsearchexpression"></a>
# **GetLocationDistrictspagepagepageSizepageSizesearchExpressionsearchExpression**
> SCServiceChannelServicesMessagingLocationGetLocationDistrictsResponse GetLocationDistrictspagepagepageSizepageSizesearchExpressionsearchExpression (int page, int pageSize, string? searchExpression = null)

Get location districts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetLocationDistrictspagepagepageSizepageSizesearchExpressionsearchExpressionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);
            var page = 56;  // int | Number of the current page
            var pageSize = 56;  // int | Limit to return items
            var searchExpression = "searchExpression_example";  // string? | User input text (optional) 

            try
            {
                // Get location districts
                SCServiceChannelServicesMessagingLocationGetLocationDistrictsResponse result = apiInstance.GetLocationDistrictspagepagepageSizepageSizesearchExpressionsearchExpression(page, pageSize, searchExpression);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.GetLocationDistrictspagepagepageSizepageSizesearchExpressionsearchExpression: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLocationDistrictspagepagepageSizepageSizesearchExpressionsearchExpressionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get location districts
    ApiResponse<SCServiceChannelServicesMessagingLocationGetLocationDistrictsResponse> response = apiInstance.GetLocationDistrictspagepagepageSizepageSizesearchExpressionsearchExpressionWithHttpInfo(page, pageSize, searchExpression);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.GetLocationDistrictspagepagepageSizepageSizesearchExpressionsearchExpressionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | Number of the current page |  |
| **pageSize** | **int** | Limit to return items |  |
| **searchExpression** | **string?** | User input text | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingLocationGetLocationDistrictsResponse**](SCServiceChannelServicesMessagingLocationGetLocationDistrictsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested districts are in the response. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              401 — User has no permissions to perform this action |  -  |
| **500** | The server was unable to complete the request due to an internal error.               &lt;br/&gt;Error codes:              501 — Value of pageSize or page is less than 1 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getlocations"></a>
# **GetLocations**
> List&lt;SCServiceChannelServicesMessagingLocationLocation&gt; GetLocations (string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Retrieve locations

Returns a list of locations. You can use filter parameters to make your request more specific.              <br /> You can also get a list of locations by using one of the following methods: [GET /stores](https://developer.servicechannel.com/swagger/ui/index?version=3#/Locations/GETv3_stores_Id__Id__storeIdentifier__storeIdentifier__Name__Name__Sort__Sort__Page__Page__PageSize__PageSize_), [GET /locations](https://developer.servicechannel.com/swagger/ui/index?version=3#/Locations/GETv3_locations_Id__Id__storeIdentifier__storeIdentifier__Name__Name__Sort__Sort__Page__Page__PageSize__PageSize_).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetLocationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Retrieve locations
                List<SCServiceChannelServicesMessagingLocationLocation> result = apiInstance.GetLocations(expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.GetLocations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLocationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve locations
    ApiResponse<List<SCServiceChannelServicesMessagingLocationLocation>> response = apiInstance.GetLocationsWithHttpInfo(expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.GetLocationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingLocationLocation&gt;**](SCServiceChannelServicesMessagingLocationLocation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of locations is in the response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getlocationsmobilepagepagepagesizepagesizelatitudelatitudelongitudelongitudesearchexpressionsearchexpressiononlyopenedonlyopened"></a>
# **GetLocationsMobilepagepagepageSizepageSizelatitudelatitudelongitudelongitudesearchExpressionsearchExpressiononlyOpenedonlyOpened**
> SCServiceChannelServicesMessagingLocationGetLocationsMobileResponse GetLocationsMobilepagepagepageSizepageSizelatitudelatitudelongitudelongitudesearchExpressionsearchExpressiononlyOpenedonlyOpened (int page, int pageSize, double? latitude = null, double? longitude = null, string? searchExpression = null, bool? onlyOpened = null)

Get Locations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetLocationsMobilepagepagepageSizepageSizelatitudelatitudelongitudelongitudesearchExpressionsearchExpressiononlyOpenedonlyOpenedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);
            var page = 56;  // int | Number of the current page
            var pageSize = 56;  // int | Limit to return items
            var latitude = 1.2D;  // double? | The latitude of the user location (optional) 
            var longitude = 1.2D;  // double? | The longitude of the user location (optional) 
            var searchExpression = "searchExpression_example";  // string? | User input text (optional) 
            var onlyOpened = false;  // bool? | Include only open locations (optional)  (default to false)

            try
            {
                // Get Locations
                SCServiceChannelServicesMessagingLocationGetLocationsMobileResponse result = apiInstance.GetLocationsMobilepagepagepageSizepageSizelatitudelatitudelongitudelongitudesearchExpressionsearchExpressiononlyOpenedonlyOpened(page, pageSize, latitude, longitude, searchExpression, onlyOpened);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.GetLocationsMobilepagepagepageSizepageSizelatitudelatitudelongitudelongitudesearchExpressionsearchExpressiononlyOpenedonlyOpened: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLocationsMobilepagepagepageSizepageSizelatitudelatitudelongitudelongitudesearchExpressionsearchExpressiononlyOpenedonlyOpenedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Locations
    ApiResponse<SCServiceChannelServicesMessagingLocationGetLocationsMobileResponse> response = apiInstance.GetLocationsMobilepagepagepageSizepageSizelatitudelatitudelongitudelongitudesearchExpressionsearchExpressiononlyOpenedonlyOpenedWithHttpInfo(page, pageSize, latitude, longitude, searchExpression, onlyOpened);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.GetLocationsMobilepagepagepageSizepageSizelatitudelatitudelongitudelongitudesearchExpressionsearchExpressiononlyOpenedonlyOpenedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | Number of the current page |  |
| **pageSize** | **int** | Limit to return items |  |
| **latitude** | **double?** | The latitude of the user location | [optional]  |
| **longitude** | **double?** | The longitude of the user location | [optional]  |
| **searchExpression** | **string?** | User input text | [optional]  |
| **onlyOpened** | **bool?** | Include only open locations | [optional] [default to false] |

### Return type

[**SCServiceChannelServicesMessagingLocationGetLocationsMobileResponse**](SCServiceChannelServicesMessagingLocationGetLocationsMobileResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested locations are in the response. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              401 — User has no permissions to perform this action |  -  |
| **500** | The server was unable to complete the request due to an internal error.               &lt;br/&gt;Error codes:              501 — Value of pageSize or page is less than 1 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getlocationsnearme"></a>
# **GetLocationsNearMe**
> List&lt;SCServiceChannelServicesMessagingLocationLocation&gt; GetLocationsNearMe (double longitude, double latitude, string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Get locations by geographic coordinates

Returns locations that are near the longitude and latitude specified in the request. Use the filter parameters to make the request more specific.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetLocationsNearMeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);
            var longitude = 1.2D;  // double | Location’s global position. Longitude.
            var latitude = 1.2D;  // double | Location’s global position. Latitude.
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Get locations by geographic coordinates
                List<SCServiceChannelServicesMessagingLocationLocation> result = apiInstance.GetLocationsNearMe(longitude, latitude, expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.GetLocationsNearMe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLocationsNearMeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get locations by geographic coordinates
    ApiResponse<List<SCServiceChannelServicesMessagingLocationLocation>> response = apiInstance.GetLocationsNearMeWithHttpInfo(longitude, latitude, expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.GetLocationsNearMeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **longitude** | **double** | Location’s global position. Longitude. |  |
| **latitude** | **double** | Location’s global position. Latitude. |  |
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingLocationLocation&gt;**](SCServiceChannelServicesMessagingLocationLocation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested locations are in the response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getservicerequestlocations"></a>
# **GetServiceRequestLocations**
> List&lt;SCServiceChannelServicesMessagingLocationLocation&gt; GetServiceRequestLocations (string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Retrieve locations

Returns a list of locations of a service request. You can use filter parameters to make the request more specific.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetServiceRequestLocationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Retrieve locations
                List<SCServiceChannelServicesMessagingLocationLocation> result = apiInstance.GetServiceRequestLocations(expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.GetServiceRequestLocations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetServiceRequestLocationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve locations
    ApiResponse<List<SCServiceChannelServicesMessagingLocationLocation>> response = apiInstance.GetServiceRequestLocationsWithHttpInfo(expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.GetServiceRequestLocationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingLocationLocation&gt;**](SCServiceChannelServicesMessagingLocationLocation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested locations are in the response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="landlordresponsibilities"></a>
# **LandlordResponsibilities**
> void LandlordResponsibilities (SCServiceChannelServicesMessagingLocationUpdateLandlordResponsibilityApiRequest apiRequest)

Update Landlord Responsibility

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LandlordResponsibilitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);
            var apiRequest = new SCServiceChannelServicesMessagingLocationUpdateLandlordResponsibilityApiRequest(); // SCServiceChannelServicesMessagingLocationUpdateLandlordResponsibilityApiRequest | 

            try
            {
                // Update Landlord Responsibility
                apiInstance.LandlordResponsibilities(apiRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.LandlordResponsibilities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LandlordResponsibilitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Landlord Responsibility
    apiInstance.LandlordResponsibilitiesWithHttpInfo(apiRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.LandlordResponsibilitiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiRequest** | [**SCServiceChannelServicesMessagingLocationUpdateLandlordResponsibilityApiRequest**](SCServiceChannelServicesMessagingLocationUpdateLandlordResponsibilityApiRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The Landlord Responsibility are updated. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.                  &lt;br/&gt;Error codes:                  1301 — Request is empty or null                  503 — Failed to create landlord responsibility                  655 — Landlord responsibility is not found                  656 — The combination of Location Trade and Category must be unique                  659 — Invalid Trade name                  660 — Invalid Category name                  661 — Invalid Override Category name                  662 — Invalid Override Priority name                  663 — Lease Note can not exceed 200 characters                  664 — Invalid override provider rank                  665 — Invalid override NTE |  -  |
| **403** | User is not assigned to Location                   &lt;br/&gt;Error codes:                  804 — User is not assigned to Location. |  -  |
| **404** | Invalid Store Id                  &lt;br/&gt;Error codes:                  606 — Invalid Store Id. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="landlordresponsibilities_0"></a>
# **LandlordResponsibilities_0**
> SCServiceChannelServicesMessagingLocationLandlordResponsibilityModel LandlordResponsibilities_0 (SCServiceChannelServicesMessagingLocationCreateLandlordResponsibilityApiRequest apiRequest)

Create landlord responsibility

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LandlordResponsibilities_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);
            var apiRequest = new SCServiceChannelServicesMessagingLocationCreateLandlordResponsibilityApiRequest(); // SCServiceChannelServicesMessagingLocationCreateLandlordResponsibilityApiRequest | 

            try
            {
                // Create landlord responsibility
                SCServiceChannelServicesMessagingLocationLandlordResponsibilityModel result = apiInstance.LandlordResponsibilities_0(apiRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.LandlordResponsibilities_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LandlordResponsibilities_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create landlord responsibility
    ApiResponse<SCServiceChannelServicesMessagingLocationLandlordResponsibilityModel> response = apiInstance.LandlordResponsibilities_0WithHttpInfo(apiRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.LandlordResponsibilities_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiRequest** | [**SCServiceChannelServicesMessagingLocationCreateLandlordResponsibilityApiRequest**](SCServiceChannelServicesMessagingLocationCreateLandlordResponsibilityApiRequest.md) |  |  |

### Return type

[**SCServiceChannelServicesMessagingLocationLandlordResponsibilityModel**](SCServiceChannelServicesMessagingLocationLandlordResponsibilityModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The Landlord Responsibility are created. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.                  &lt;br/&gt;Error codes:                  1301 — Request is empty or null                  503 — Failed to create landlord responsibility                  656 — The combination of Location Trade and Category must be unique                  659 — Invalid Trade Id                  660 — Invalid Category Id                  661 — Invalid Override Category Id                  662 — Invalid Override PriorityId                  663 — Lease Note can not exceed 200 characters                  664 — Invalid override provider rank                  665 — Invalid override NTE |  -  |
| **403** | User is not assigned to Location                   &lt;br/&gt;Error codes:                  804 — User is not assigned to Location. |  -  |
| **404** | Invalid Store Id                  &lt;br/&gt;Error codes:                  606 — Invalid Store Id. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="landlordresponsibilitiesresponsibilityid"></a>
# **LandlordResponsibilitiesresponsibilityId**
> void LandlordResponsibilitiesresponsibilityId (int responsibilityId)

Delete Landlord Responsibility

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LandlordResponsibilitiesresponsibilityIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);
            var responsibilityId = 56;  // int | 

            try
            {
                // Delete Landlord Responsibility
                apiInstance.LandlordResponsibilitiesresponsibilityId(responsibilityId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.LandlordResponsibilitiesresponsibilityId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LandlordResponsibilitiesresponsibilityIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Landlord Responsibility
    apiInstance.LandlordResponsibilitiesresponsibilityIdWithHttpInfo(responsibilityId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.LandlordResponsibilitiesresponsibilityIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **responsibilityId** | **int** |  |  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The landlord responsibility is deleted. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.                  &lt;br/&gt;Error codes:                  655 — Landlord responsibility is not found |  -  |
| **401** | Indicates that the requested resource requires authentication. |  -  |
| **403** | User is not assigned to Location                   &lt;br/&gt;Error codes:                  804 — User is not assigned to Location. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="landlordresponsibilitiesstoreidstoreid"></a>
# **LandlordResponsibilitiesstoreIdstoreId**
> SCServiceChannelServicesMessagingLocationGetLandlordResponsibilityResponse LandlordResponsibilitiesstoreIdstoreId (string? storeId = null)

Get landlord responsibilities

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LandlordResponsibilitiesstoreIdstoreIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);
            var storeId = "storeId_example";  // string? |  (optional) 

            try
            {
                // Get landlord responsibilities
                SCServiceChannelServicesMessagingLocationGetLandlordResponsibilityResponse result = apiInstance.LandlordResponsibilitiesstoreIdstoreId(storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.LandlordResponsibilitiesstoreIdstoreId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LandlordResponsibilitiesstoreIdstoreIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get landlord responsibilities
    ApiResponse<SCServiceChannelServicesMessagingLocationGetLandlordResponsibilityResponse> response = apiInstance.LandlordResponsibilitiesstoreIdstoreIdWithHttpInfo(storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.LandlordResponsibilitiesstoreIdstoreIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **storeId** | **string?** |  | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingLocationGetLandlordResponsibilityResponse**](SCServiceChannelServicesMessagingLocationGetLandlordResponsibilityResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested locations are in the response. |  -  |
| **403** | User is not assigned to Location                   &lt;br/&gt;Error codes:                  100 — User has no permissions to perform this action. |  -  |
| **404** | Location is not found                  &lt;br/&gt;Error codes:                  651 — Location is not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="locations"></a>
# **Locations**
> void Locations (SCServiceChannelServicesMessagingLocationCreateLocationRequest request)

Add a location

Creates a location for the authorized subscriber.              <br />**Note:** Method is available for users with the *Super Admin* or *Admin User* permissions, or the *SC Admin* role.              <br />Learn [how subscribers can create inventory locations](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/1209106525/Creating+Inventory+Locations) in ServiceChannel University.              <br />**Example request**                                PUT / locations/{locationId}                  {                   \"StoreId\":\"34\",                   \"Name\": \"CSR Flagship\",                   \"Latitude\": 40.736601,                   \"Longitude\": -73.991795,                   \"Distance\": null,                   \"Address1\": \"3rd Floor, Innovation Center\",                   \"Address2\": \"18 E. 16th Street\",                   \"City\": \"New York\",                   \"State\": \"NY\",                   \"StateId\": 1,                   \"Region\": \"Northeast\",                   \"District\": \"NYC/LI\",                   \"Zip\": \"10003\",                   \"Country\": \"US\",                   \"CountryId\": 1,                   \"ClosedDate\": \"\",                   \"OpenDate\": \"2021-07-03T00:10:00.308Z\",                   \"Email\": \"csrflagship@gmail.com\",                   \"Phone\": \"212-555-1212\",                   \"Contact\": \"\",                   \"FaxNumber\": \"\",                   \"LocationTypeId\": null,                   \"SquareValue\": 20.21                   \"SquareMeasure\": \"ft or foot\" or \"m or metre\"                  }

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LocationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);
            var request = new SCServiceChannelServicesMessagingLocationCreateLocationRequest(); // SCServiceChannelServicesMessagingLocationCreateLocationRequest | Request to add a new location.

            try
            {
                // Add a location
                apiInstance.Locations(request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.Locations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a location
    apiInstance.LocationsWithHttpInfo(request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.LocationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingLocationCreateLocationRequest**](SCServiceChannelServicesMessagingLocationCreateLocationRequest.md) | Request to add a new location. |  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | A new location is created. The location ID is in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              503 — Request is empty              503 — Request is empty or null              605 — Location with Store Id already exists              606 — The &#x60;StoreId&#x60; value cannot be empty. The maximum length is 50 characters.              631 — The &#x60;City&#x60; value cannot be empty. The maximum length is 50 characters.              632 — The &#x60;Zip&#x60; value cannot be empty. The maximum length is 12 characters.              633 — Latitude value should be between &#39;-90&#39; and &#39;90&#39;.              634 — Longitude value should be between &#39;-180&#39; and &#39;180&#39;.              635 — Invalid Email.              636 — The &#x60;Name&#x60; value cannot be empty. The maximum length is 100 characters.              637 — Invalid &#x60;State&#x60; format. The maximum length is 2 characters.              638 — Invalid &#x60;Address1&#x60; format. The maximum length is 500 characters.              639 — Invalid &#x60;Address2&#x60; format. The maximum length is 500 characters.              640 — The &#x60;Country&#x60; value cannot be empty. The maximum length is 20 characters.              641 — Invalid &#x60;Region&#x60; format. The maximum length is 50 characters.              642 — Invalid &#x60;District&#x60; format. The maximum length is 50 characters.              643 — Invalid &#x60;Phone&#x60; format. The maximum length is 22 characters.              644 — Invalid &#x60;Contact&#x60; format. The maximum length is 50 characters.              645 — Invalid &#x60;FaxNumber&#x60; format. The maximum length is 22 characters.              647 — Location &#39;state&#39; not found.              651 — Location &#39;stateId&#39; not found.              652 — Incorrect combination of &#39;State&#39; and &#39;StateId&#39;              1254 — Invalid square measure |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 — Object reference not set to an instance of an object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="locationsaddressformatsc0c0c1c1id0id0id1id1"></a>
# **LocationsAddressformatsc0c0c1c1id0id0id1id1**
> List&lt;SCServiceChannelServicesMessagingLocationAddressType&gt; LocationsAddressformatsc0c0c1c1id0id0id1id1 (List<string> c, List<int> id)

Retrieve address format pattern per list of country ISO codes or per list of address types Ids

Returns a list of address types (Id, Pattern).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LocationsAddressformatsc0c0c1c1id0id0id1id1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);
            var c = new List<string>(); // List<string> | 
            var id = new List<int>(); // List<int> | 

            try
            {
                // Retrieve address format pattern per list of country ISO codes or per list of address types Ids
                List<SCServiceChannelServicesMessagingLocationAddressType> result = apiInstance.LocationsAddressformatsc0c0c1c1id0id0id1id1(c, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.LocationsAddressformatsc0c0c1c1id0id0id1id1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationsAddressformatsc0c0c1c1id0id0id1id1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve address format pattern per list of country ISO codes or per list of address types Ids
    ApiResponse<List<SCServiceChannelServicesMessagingLocationAddressType>> response = apiInstance.LocationsAddressformatsc0c0c1c1id0id0id1id1WithHttpInfo(c, id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.LocationsAddressformatsc0c0c1c1id0id0id1id1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **c** | [**List&lt;string&gt;**](string.md) |  |  |
| **id** | [**List&lt;int&gt;**](int.md) |  |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingLocationAddressType&gt;**](SCServiceChannelServicesMessagingLocationAddressType.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested address types with patterns are in the response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="locationscheckiflocationisopenlocationidlocationidchecktimechecktime"></a>
# **LocationsCheckIfLocationIsOpenlocationIdlocationIdcheckTimecheckTime**
> SCServiceChannelServicesMessagingAfterHoursCheckIfLocationIsOpenResponse LocationsCheckIfLocationIsOpenlocationIdlocationIdcheckTimecheckTime (int locationId, DateTime? checkTime = null)

Check whether the location is open or closed.

Returns information on the specified location if it is open or closed now. If the `checkTime` parameter is not provided, the location is checked at the current time.              <br /> Learn about [managing business hours](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/683507788/Managing+Business+Hours) in ServiceChannel University.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LocationsCheckIfLocationIsOpenlocationIdlocationIdcheckTimecheckTimeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);
            var locationId = 56;  // int | Unique location identifier
            var checkTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Date and time to check if the location is open (optional) 

            try
            {
                // Check whether the location is open or closed.
                SCServiceChannelServicesMessagingAfterHoursCheckIfLocationIsOpenResponse result = apiInstance.LocationsCheckIfLocationIsOpenlocationIdlocationIdcheckTimecheckTime(locationId, checkTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.LocationsCheckIfLocationIsOpenlocationIdlocationIdcheckTimecheckTime: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationsCheckIfLocationIsOpenlocationIdlocationIdcheckTimecheckTimeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check whether the location is open or closed.
    ApiResponse<SCServiceChannelServicesMessagingAfterHoursCheckIfLocationIsOpenResponse> response = apiInstance.LocationsCheckIfLocationIsOpenlocationIdlocationIdcheckTimecheckTimeWithHttpInfo(locationId, checkTime);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.LocationsCheckIfLocationIsOpenlocationIdlocationIdcheckTimecheckTimeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | Unique location identifier |  |
| **checkTime** | **DateTime?** | Date and time to check if the location is open | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingAfterHoursCheckIfLocationIsOpenResponse**](SCServiceChannelServicesMessagingAfterHoursCheckIfLocationIsOpenResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The location opening status is in the response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="locationsgetlocationsbyfiltercolumns"></a>
# **LocationsGetLocationsByFilterColumns**
> void LocationsGetLocationsByFilterColumns (SCServiceChannelApiModelLocationsLocationFilterColumns locationFilterColumns)

Retrieve locations by filters

Performs search of locations based on the filters specified in the request and returns a list of locations with all details for the specified subscriber.              <br /> ***Note***: This method is available to *Provider Directory (aka Fixxbook)* users only.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LocationsGetLocationsByFilterColumnsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);
            var locationFilterColumns = new SCServiceChannelApiModelLocationsLocationFilterColumns(); // SCServiceChannelApiModelLocationsLocationFilterColumns | Request parameters to filter the response. The `SubscriberId` parameter is required. For the rest of the parameters, except for `Page`, `CountPerPage`, several values can be added separated with a comma.

            try
            {
                // Retrieve locations by filters
                apiInstance.LocationsGetLocationsByFilterColumns(locationFilterColumns);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.LocationsGetLocationsByFilterColumns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationsGetLocationsByFilterColumnsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve locations by filters
    apiInstance.LocationsGetLocationsByFilterColumnsWithHttpInfo(locationFilterColumns);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.LocationsGetLocationsByFilterColumnsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationFilterColumns** | [**SCServiceChannelApiModelLocationsLocationFilterColumns**](SCServiceChannelApiModelLocationsLocationFilterColumns.md) | Request parameters to filter the response. The &#x60;SubscriberId&#x60; parameter is required. For the rest of the parameters, except for &#x60;Page&#x60;, &#x60;CountPerPage&#x60;, several values can be added separated with a comma. |  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested locations are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              100 — User has no rights to perform this action              502 — The server, while acting as a gateway or proxy, received an invalid response from the upstream server |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 - API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="locationsididstoreidentifierstoreidentifiernamenamesortsortpagepagepagesizepagesize"></a>
# **LocationsIdIdstoreIdentifierstoreIdentifierNameNameSortSortPagePagePageSizePageSize**
> SCServiceChannelServicesMessagingLocationGetLocationsWithTotalResponse LocationsIdIdstoreIdentifierstoreIdentifierNameNameSortSortPagePagePageSizePageSize (int? id = null, string? storeIdentifier = null, string? name = null, string? sort = null, int? page = null, int? pageSize = null)

Retrieve stores

Returns a list of all Locations, also called Stores, if neither of the filters is used. You can get the details for a certain store by specifying any of the following parameters: `Id`, `storeIdentifier`, `name`.              <br /> You can use either of these methods to get a list of the subscriber’s locations: [GET /locations](https://developer.servicechannel.com/swagger/ui/index?version=3#/Locations/GETv3_locations_Id__Id__storeIdentifier__storeIdentifier__Name__Name__Sort__Sort__Page__Page__PageSize__PageSize_), [GET /stores](https://developer.servicechannel.com/swagger/ui/index?version=3#/Locations/GETv3_stores_Id__Id__storeIdentifier__storeIdentifier__Name__Name__Sort__Sort__Page__Page__PageSize__PageSize_).              <br /> Visit ServiceChannel University to find out more about [locations and provider assignments](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/556105830/Locations+Provider+Assignments).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LocationsIdIdstoreIdentifierstoreIdentifierNameNameSortSortPagePagePageSizePageSizeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);
            var id = 56;  // int? | Unique location identifier. (optional) 
            var storeIdentifier = "storeIdentifier_example";  // string? | Alphanumeric location identifier in the client’s system. Assigned by and unique per subscriber. (optional) 
            var name = "name_example";  // string? | Location name. (optional) 
            var sort = "sort_example";  // string? | Sort resources by the specified property in the response. (optional) 
            var page = 56;  // int? | Results page number. (optional) 
            var pageSize = 56;  // int? | Number of objects on the results page. The default and maximum per page is 50. (optional) 

            try
            {
                // Retrieve stores
                SCServiceChannelServicesMessagingLocationGetLocationsWithTotalResponse result = apiInstance.LocationsIdIdstoreIdentifierstoreIdentifierNameNameSortSortPagePagePageSizePageSize(id, storeIdentifier, name, sort, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.LocationsIdIdstoreIdentifierstoreIdentifierNameNameSortSortPagePagePageSizePageSize: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationsIdIdstoreIdentifierstoreIdentifierNameNameSortSortPagePagePageSizePageSizeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve stores
    ApiResponse<SCServiceChannelServicesMessagingLocationGetLocationsWithTotalResponse> response = apiInstance.LocationsIdIdstoreIdentifierstoreIdentifierNameNameSortSortPagePagePageSizePageSizeWithHttpInfo(id, storeIdentifier, name, sort, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.LocationsIdIdstoreIdentifierstoreIdentifierNameNameSortSortPagePagePageSizePageSizeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int?** | Unique location identifier. | [optional]  |
| **storeIdentifier** | **string?** | Alphanumeric location identifier in the client’s system. Assigned by and unique per subscriber. | [optional]  |
| **name** | **string?** | Location name. | [optional]  |
| **sort** | **string?** | Sort resources by the specified property in the response. | [optional]  |
| **page** | **int?** | Results page number. | [optional]  |
| **pageSize** | **int?** | Number of objects on the results page. The default and maximum per page is 50. | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingLocationGetLocationsWithTotalResponse**](SCServiceChannelServicesMessagingLocationGetLocationsWithTotalResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested locations are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc              &lt;br/&gt;Error codes:               502 — Subscriber not found |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 - API call rejected by security permissions              100 — User has no permissions to perform this action |  -  |
| **500** | The server was unable to complete the request due to an internal error.               &lt;br/&gt;Error codes:              501 — “Location ID” is not a valid value for Int32               |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="locationslocationwithnotes"></a>
# **LocationsLocationWithNotes**
> SCServiceChannelServicesMessagingLocationAddUpdateLocationResponse LocationsLocationWithNotes (Dictionary<string, Object> locationWithNotes)

Create a location with location notes

Create or update a location along with location notes.              <br />**Note:** Method takes a dynamic list of parameters as input.              <br />**Example request**                                POST /locations/LocationWithNotes                  {                   \"StoreId\":\"TestStore\",                   \"Name\": \"CSR Flagship\",                   \"MainAddress\": \"18 E. 16th Street\",                   \"AddlAddress\": \"3rd Floor, Innovation Center\",                   \"Latitude\": 40.736601,                   \"Longitude\": -73.991795,                   \"City\": \"New York\",                   \"State\": \"NY\",                   \"Region\": \"Northeast\",                   \"District\": \"NYC/LI\",                   \"Zip\": \"10003\",                   \"Country\": \"US\",                   \"OpenDate\": \"2021-07-03T00:10:00.308Z\",                   \"ClosedDate\": \"\",                   \"Email\": \"csrflagship@gmail.com\",                   \"Phone\": \"212-555-1212\",                   \"Contact\": \"\",                   \"FaxNumber\": \"\",                   \"YourLocationNoteHeader1\": \"Value1\",                   \"YourLocationNoteHeader2\": \"Value2\",                   \"YourLocationNoteHeaderN\": \"ValueN\"                  }

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LocationsLocationWithNotesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);
            var locationWithNotes = new Dictionary<string, Object>(); // Dictionary<string, Object> | Request to create or update a location with location notes.

            try
            {
                // Create a location with location notes
                SCServiceChannelServicesMessagingLocationAddUpdateLocationResponse result = apiInstance.LocationsLocationWithNotes(locationWithNotes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.LocationsLocationWithNotes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationsLocationWithNotesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a location with location notes
    ApiResponse<SCServiceChannelServicesMessagingLocationAddUpdateLocationResponse> response = apiInstance.LocationsLocationWithNotesWithHttpInfo(locationWithNotes);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.LocationsLocationWithNotesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationWithNotes** | [**Dictionary&lt;string, Object&gt;**](Object.md) | Request to create or update a location with location notes. |  |

### Return type

[**SCServiceChannelServicesMessagingLocationAddUpdateLocationResponse**](SCServiceChannelServicesMessagingLocationAddUpdateLocationResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A new location is created or an existing one is updated. The location ID is in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              606 — The &#x60;StoreId&#x60; value cannot be empty. The maximum length is 50 characters.              611 — The location note header does not exist on the subscriber instance.              612 — The user does not have access to update a protected location note header.              630 — Incorrect format of the &#39;ParameterName&#39;.              631 — The &#x60;City&#x60; value cannot be empty. The maximum length is 50 characters.              632 — The &#x60;Zip&#x60; value cannot be empty. The maximum length is 12 characters.              633 — Latitude value should be between &#39;-90&#39; and &#39;90&#39;.              634 — Longitude value should be between &#39;-180&#39; and &#39;180&#39;.              635 — Invalid Email.              636 — The &#x60;Name&#x60; value cannot be empty. The maximum length is 100 characters.              637 — Invalid &#x60;State&#x60; format. The maximum length is 2 characters.              638 — Invalid &#x60;AddlAddress&#x60; format. The maximum length is 500 characters.              639 — Invalid &#x60;MainAddress&#x60; format. The maximum length is 500 characters.              640 — The &#x60;Country&#x60; value cannot be empty. The maximum length is 20 characters.              641 — Invalid &#x60;Region&#x60; format. The maximum length is 50 characters.              642 — Invalid &#x60;District&#x60; format. The maximum length is 50 characters.              643 — Invalid &#x60;Phone&#x60; format. The maximum length is 22 characters.              644 — Invalid &#x60;Contact&#x60; format. The maximum length is 50 characters.              645 — Invalid &#x60;FaxNumber&#x60; format. The maximum length is 22 characters.              646 — The country doesn&#39;t exist.              647 — The state doesn&#39;t exist in the country.              648 — The city doesn&#39;t exist in the country.              650 — Invalid &#x60;Email&#x60; format. The maximum length is 200 characters.              1301 — Request is empty or null. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="locationsunassignedcontracts"></a>
# **LocationsUnassignedContracts**
> SCServiceChannelServicesMessagingLocationGetProviderAssignmentExtendedLocationsResponse LocationsUnassignedContracts ()

Get unassigned contracts

Returns subscriber’s locations with open trades that have unassigned providers.              <br /> ***Note***: Method could be outdated causing faulty results.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LocationsUnassignedContractsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);

            try
            {
                // Get unassigned contracts
                SCServiceChannelServicesMessagingLocationGetProviderAssignmentExtendedLocationsResponse result = apiInstance.LocationsUnassignedContracts();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.LocationsUnassignedContracts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationsUnassignedContractsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get unassigned contracts
    ApiResponse<SCServiceChannelServicesMessagingLocationGetProviderAssignmentExtendedLocationsResponse> response = apiInstance.LocationsUnassignedContractsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.LocationsUnassignedContractsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SCServiceChannelServicesMessagingLocationGetProviderAssignmentExtendedLocationsResponse**](SCServiceChannelServicesMessagingLocationGetProviderAssignmentExtendedLocationsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested locations are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **404** | The requested resource does not exist on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="locationslocationid"></a>
# **LocationslocationId**
> SCServiceChannelServicesMessagingLocationLocationWithTimezoneName LocationslocationId (int locationId)

Retrieve a location

Returns the details for the specified location.              <br /> To receive details of several locations, use one of these methods: [GET /stores](https://developer.servicechannel.com/swagger/ui/index?version=3#/Locations/GETv3_stores_Id__Id__storeIdentifier__storeIdentifier__Name__Name__Sort__Sort__Page__Page__PageSize__PageSize_), [GET /locations](https://developer.servicechannel.com/swagger/ui/index?version=3#/Locations/GETv3_locations_Id__Id__storeIdentifier__storeIdentifier__Name__Name__Sort__Sort__Page__Page__PageSize__PageSize_), [GET /odata/locations](https://developer.servicechannel.com/swagger/ui/index?version=3#/Locations/Locations_GetLocations).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LocationslocationIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);
            var locationId = 56;  // int | Unique numeric identifier of the location to return the details for.

            try
            {
                // Retrieve a location
                SCServiceChannelServicesMessagingLocationLocationWithTimezoneName result = apiInstance.LocationslocationId(locationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.LocationslocationId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationslocationIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a location
    ApiResponse<SCServiceChannelServicesMessagingLocationLocationWithTimezoneName> response = apiInstance.LocationslocationIdWithHttpInfo(locationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.LocationslocationIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | Unique numeric identifier of the location to return the details for. |  |

### Return type

[**SCServiceChannelServicesMessagingLocationLocationWithTimezoneName**](SCServiceChannelServicesMessagingLocationLocationWithTimezoneName.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The specified location details are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              601 — Location is not found |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="locationslocationidevacuationmaps"></a>
# **LocationslocationIdEvacuationmaps**
> SCServiceChannelServicesMessagingLocationGetLocationAttachmentsResponse LocationslocationIdEvacuationmaps (int locationId)

Get an evacuation plan map of a location

Returns evacuation plan map attachments details for the specified location.              <br /> Visit ServiceChannel University to learn about [Location Emergency Evacuation Plan Map(s)](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/710312376/Location+Emergency+Evacuation+Plan+Map+s).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LocationslocationIdEvacuationmapsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);
            var locationId = 56;  // int | Unique numeric identifier of the location to return the details for.

            try
            {
                // Get an evacuation plan map of a location
                SCServiceChannelServicesMessagingLocationGetLocationAttachmentsResponse result = apiInstance.LocationslocationIdEvacuationmaps(locationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.LocationslocationIdEvacuationmaps: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationslocationIdEvacuationmapsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an evacuation plan map of a location
    ApiResponse<SCServiceChannelServicesMessagingLocationGetLocationAttachmentsResponse> response = apiInstance.LocationslocationIdEvacuationmapsWithHttpInfo(locationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.LocationslocationIdEvacuationmapsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | Unique numeric identifier of the location to return the details for. |  |

### Return type

[**SCServiceChannelServicesMessagingLocationGetLocationAttachmentsResponse**](SCServiceChannelServicesMessagingLocationGetLocationAttachmentsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Location evacuation plan maps are in the response. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="locationslocationidnotes"></a>
# **LocationslocationIdNotes**
> void LocationslocationIdNotes (int locationId, SCServiceChannelServicesMessagingLocationNoteUpdateLocationNoteHeaderApiModelRequest locNoteHeader)

Add a location note

Adds a location note for the specified location. If a note is already added, you can change it by sending the request, or leave the `Value` parameter empty to delete the note.              <br /> To retrieve location IDs along with the location notes, send either of these requests: [GET/stores](https://developer.servicechannel.com/swagger/ui/index?version=3#/Locations/GETv3_stores_Id__Id__storeIdentifier__storeIdentifier__Name__Name__Sort__Sort__Page__Page__PageSize__PageSize_), [GET/locations](https://developer.servicechannel.com/swagger/ui/index?version=3#/Locations/GETv3_locations_Id__Id__storeIdentifier__storeIdentifier__Name__Name__Sort__Sort__Page__Page__PageSize__PageSize_).              Get location notes separately for the specified location by sending the [GET/locations/{locationId}/notes](https://developer.servicechannel.com/swagger/ui/index?version=3#/Locations/GETv3_locations__locationId__notes) request.              <br />***Note***: Method is available for users with the *Super Admin* or *Admin* roles, or the *Location Admin* permission.              <br /> **Example request**                                POST /locations/{locationId}/notes                  {                    \"Header\": \"Location Manager\",                    \"Value\": \"John Smith\"                  }

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LocationslocationIdNotesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);
            var locationId = 56;  // int | Unique ID of the location you want to update a note for.
            var locNoteHeader = new SCServiceChannelServicesMessagingLocationNoteUpdateLocationNoteHeaderApiModelRequest(); // SCServiceChannelServicesMessagingLocationNoteUpdateLocationNoteHeaderApiModelRequest | Request to add, update or delete a location note header for a location.

            try
            {
                // Add a location note
                apiInstance.LocationslocationIdNotes(locationId, locNoteHeader);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.LocationslocationIdNotes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationslocationIdNotesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a location note
    apiInstance.LocationslocationIdNotesWithHttpInfo(locationId, locNoteHeader);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.LocationslocationIdNotesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | Unique ID of the location you want to update a note for. |  |
| **locNoteHeader** | [**SCServiceChannelServicesMessagingLocationNoteUpdateLocationNoteHeaderApiModelRequest**](SCServiceChannelServicesMessagingLocationNoteUpdateLocationNoteHeaderApiModelRequest.md) | Request to add, update or delete a location note header for a location. |  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The note is added to the specified location. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              601 — Location is not found              1301 — Request is empty or null |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **403** | You are not authorized to request this resource, or the resource is unavailable for some reason.              &lt;br/&gt;Error codes:              100 — User has no rights to perform this action              612 — The user does not have access to update a protected location note header |  -  |
| **404** | The requested resource does not exist on the server.              &lt;br/&gt;Error codes:              611 — The location note header does not exist on the subscriber instance |  -  |
| **500** | The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 — Object reference not set to an instance of an object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="locationslocationidnotesprivatenotesprivatenotes"></a>
# **LocationslocationIdNotesprivateNotesprivateNotes**
> SCServiceChannelServicesMessagingLocationNoteLocationNote LocationslocationIdNotesprivateNotesprivateNotes (int locationId, bool? privateNotes = null)

Retrieve location notes

Returns the location notes for the specified location.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LocationslocationIdNotesprivateNotesprivateNotesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);
            var locationId = 56;  // int | Unique ID of the location you want to receive notes for.
            var privateNotes = false;  // bool? | Should privateNotes be included. Settings from dashboardSetup by default (optional)  (default to false)

            try
            {
                // Retrieve location notes
                SCServiceChannelServicesMessagingLocationNoteLocationNote result = apiInstance.LocationslocationIdNotesprivateNotesprivateNotes(locationId, privateNotes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.LocationslocationIdNotesprivateNotesprivateNotes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationslocationIdNotesprivateNotesprivateNotesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve location notes
    ApiResponse<SCServiceChannelServicesMessagingLocationNoteLocationNote> response = apiInstance.LocationslocationIdNotesprivateNotesprivateNotesWithHttpInfo(locationId, privateNotes);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.LocationslocationIdNotesprivateNotesprivateNotesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | Unique ID of the location you want to receive notes for. |  |
| **privateNotes** | **bool?** | Should privateNotes be included. Settings from dashboardSetup by default | [optional] [default to false] |

### Return type

[**SCServiceChannelServicesMessagingLocationNoteLocationNote**](SCServiceChannelServicesMessagingLocationNoteLocationNote.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Location notes are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              601 — Location not found |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 - API call rejected by security permissions |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="locationslocationid_0"></a>
# **LocationslocationId_0**
> void LocationslocationId_0 (int locationId, SCServiceChannelServicesMessagingLocationUpdateLocationExRequest request)

Update a location

Modifies information of the existing location.You can use either of the following methods to retrieve location details: [GET/stores](https://developer.servicechannel.com/swagger/ui/index?version=3#/Locations/GETv3_stores_Id__Id__storeIdentifier__storeIdentifier__Name__Name__Sort__Sort__Page__Page__PageSize__PageSize_), [GET/locations](https://developer.servicechannel.com/swagger/ui/index?version=3#/Locations/GETv3_locations_Id__Id__storeIdentifier__storeIdentifier__Name__Name__Sort__Sort__Page__Page__PageSize__PageSize_).              <br />***Note:*** Method is available for subscribers with the *Super Admin* permission or *SC Admin* role.              <br />Visit ServiceChannel University to find out [how subscribers can update location details](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/708936009/Updating+Location+Details).              <br />**Example request**                                PUT / locations/{locationId}                  {                   \"StoreId\": \"34\",                   \"Name\": \"CSR Flagship\",                   \"Latitude\": 40.736601,                   \"Longitude\": -73.991795,                   \"Distance\": null,                   \"Address1\": \"3rd Floor, Innovation Center\",                   \"Address2\": \"18 E. 16th Street\",                   \"City\": \"New York\",                   \"State\": \"NY\",                   \"StateId\": 1,                   \"Region\": \"Northeast\",                   \"District\": \"NYC/LI\",                   \"Zip\": \"10003\",                   \"Country\": \"US\",                   \"CountryId\": 1,                   \"ClosedDate\": \"null\",                   \"OpenDate\": \"2021-07-05T07:05:04.991Z\",                   \"Email\": \"flagship@gmail.com\",                   \"Phone\": \"212-555-1212\",                   \"Contact\": \"\",                   \"FaxNumber\": \"\",                   \"LocationTypeId\": null,                   \"SquareValue\": 20.21                   \"SquareMeasure\": \"ft or foot\" or \"m or metre\"                  }

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LocationslocationId_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);
            var locationId = 56;  // int | Unique identifier of the subscriber’s location which information you want to update.
            var request = new SCServiceChannelServicesMessagingLocationUpdateLocationExRequest(); // SCServiceChannelServicesMessagingLocationUpdateLocationExRequest | Request to change the location details. Leaving a parameter empty or excluding it from the request model erases the already existing data.

            try
            {
                // Update a location
                apiInstance.LocationslocationId_0(locationId, request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.LocationslocationId_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationslocationId_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a location
    apiInstance.LocationslocationId_0WithHttpInfo(locationId, request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.LocationslocationId_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | Unique identifier of the subscriber’s location which information you want to update. |  |
| **request** | [**SCServiceChannelServicesMessagingLocationUpdateLocationExRequest**](SCServiceChannelServicesMessagingLocationUpdateLocationExRequest.md) | Request to change the location details. Leaving a parameter empty or excluding it from the request model erases the already existing data. |  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The location details are updated. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              601 — Location not found              1254 — Invalid square measure |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="locationslocationid_1"></a>
# **LocationslocationId_1**
> void LocationslocationId_1 (int locationId)

Delete a location

Permanently removes a location.              <br />***Note***: Method is available for users with the *Super Admin* or *Admin User* permissions, or the *SC Admin* role.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LocationslocationId_1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);
            var locationId = 56;  // int | Unique identifier of the subscriber’s location to delete.

            try
            {
                // Delete a location
                apiInstance.LocationslocationId_1(locationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.LocationslocationId_1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationslocationId_1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a location
    apiInstance.LocationslocationId_1WithHttpInfo(locationId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.LocationslocationId_1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | Unique identifier of the subscriber’s location to delete. |  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The location is deleted, and the response is intentionally blank. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:               502 — Data not found |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions              804 — User has no permissions to perform this action |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="locationsstoreidattachments"></a>
# **LocationsstoreIdAttachments**
> List&lt;SCServiceChannelServicesMessagingLocationLocationAttachment&gt; LocationsstoreIdAttachments (string storeId)

Get a Location’s Attachments

Returns a list of attachments.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LocationsstoreIdAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);
            var storeId = "storeId_example";  // string | 

            try
            {
                // Get a Location’s Attachments
                List<SCServiceChannelServicesMessagingLocationLocationAttachment> result = apiInstance.LocationsstoreIdAttachments(storeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.LocationsstoreIdAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationsstoreIdAttachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a Location’s Attachments
    ApiResponse<List<SCServiceChannelServicesMessagingLocationLocationAttachment>> response = apiInstance.LocationsstoreIdAttachmentsWithHttpInfo(storeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.LocationsstoreIdAttachmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **storeId** | **string** |  |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingLocationLocationAttachment&gt;**](SCServiceChannelServicesMessagingLocationLocationAttachment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested attachments are in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters |  -  |
| **401** | Indicates that the requested resource requires authentication. |  -  |
| **403** | User is not assigned to Location                   &lt;br/&gt;Error codes:                  804 — User is not assigned to Location. |  -  |
| **404** | Invalid StoreID                  &lt;br/&gt;Error codes:                  606 — Invalid StoreID. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="locationsstoreidattachmentsattachmentid"></a>
# **LocationsstoreIdAttachmentsattachmentId**
> void LocationsstoreIdAttachmentsattachmentId (string storeId, int attachmentId)

Delete a Location Attachment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LocationsstoreIdAttachmentsattachmentIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);
            var storeId = "storeId_example";  // string | 
            var attachmentId = 56;  // int | 

            try
            {
                // Delete a Location Attachment
                apiInstance.LocationsstoreIdAttachmentsattachmentId(storeId, attachmentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.LocationsstoreIdAttachmentsattachmentId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationsstoreIdAttachmentsattachmentIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a Location Attachment
    apiInstance.LocationsstoreIdAttachmentsattachmentIdWithHttpInfo(storeId, attachmentId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.LocationsstoreIdAttachmentsattachmentIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **storeId** | **string** |  |  |
| **attachmentId** | **int** |  |  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The attachment is deleted. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters |  -  |
| **401** | Indicates that the requested resource requires authentication. |  -  |
| **403** | User is not assigned to Location                   &lt;br/&gt;Error codes:                  804 — User is not assigned to Location. |  -  |
| **404** | Invalid StoreID                  &lt;br/&gt;Error codes:                  606 — Invalid StoreID. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="locationsstoreidattachmentsfiledescriptionfiledescriptionisevacuationplanisevacuationplan"></a>
# **LocationsstoreIdAttachmentsfileDescriptionfileDescriptionisEvacuationPlanisEvacuationPlan**
> SCServiceChannelServicesMessagingLocationLocationAttachment LocationsstoreIdAttachmentsfileDescriptionfileDescriptionisEvacuationPlanisEvacuationPlan (string storeId, System.IO.Stream file, string? fileDescription = null, bool? isEvacuationPlan = null)

Create a Location Attachment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LocationsstoreIdAttachmentsfileDescriptionfileDescriptionisEvacuationPlanisEvacuationPlanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);
            var storeId = "storeId_example";  // string | 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | File to attach to the location.
            var fileDescription = "fileDescription_example";  // string? |  (optional) 
            var isEvacuationPlan = false;  // bool? |  (optional)  (default to false)

            try
            {
                // Create a Location Attachment
                SCServiceChannelServicesMessagingLocationLocationAttachment result = apiInstance.LocationsstoreIdAttachmentsfileDescriptionfileDescriptionisEvacuationPlanisEvacuationPlan(storeId, file, fileDescription, isEvacuationPlan);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.LocationsstoreIdAttachmentsfileDescriptionfileDescriptionisEvacuationPlanisEvacuationPlan: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationsstoreIdAttachmentsfileDescriptionfileDescriptionisEvacuationPlanisEvacuationPlanWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a Location Attachment
    ApiResponse<SCServiceChannelServicesMessagingLocationLocationAttachment> response = apiInstance.LocationsstoreIdAttachmentsfileDescriptionfileDescriptionisEvacuationPlanisEvacuationPlanWithHttpInfo(storeId, file, fileDescription, isEvacuationPlan);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.LocationsstoreIdAttachmentsfileDescriptionfileDescriptionisEvacuationPlanisEvacuationPlanWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **storeId** | **string** |  |  |
| **file** | **System.IO.Stream****System.IO.Stream** | File to attach to the location. |  |
| **fileDescription** | **string?** |  | [optional]  |
| **isEvacuationPlan** | **bool?** |  | [optional] [default to false] |

### Return type

[**SCServiceChannelServicesMessagingLocationLocationAttachment**](SCServiceChannelServicesMessagingLocationLocationAttachment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created indicates that the attachment created before the response was sent. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **403** | User is not assigned to Location                   &lt;br/&gt;Error codes:                  804 — User is not assigned to Location. |  -  |
| **404** | Invalid StoreID                  &lt;br/&gt;Error codes:                  606 — Invalid StoreID. |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="locationsstoreidupdatenotes"></a>
# **LocationsstoreIdUpdateNotes**
> void LocationsstoreIdUpdateNotes (string storeId, SCServiceChannelServicesMessagingLocationNoteUpdateLocationNoteHeadersApiModelRequest locNoteHeaders)

Add location notes

Add location notes for the specified location. If a note is already added, you can change it by sending the request, or leave the `Value` parameter empty to delete the note.              <br /> ***Note***: To retrieve store IDs along with the location notes, send either of these requests: [GET/stores](https://developer.servicechannel.com/swagger/ui/index?version=3#/Locations/GETv3_stores_Id__Id__storeIdentifier__storeIdentifier__Name__Name__Sort__Sort__Page__Page__PageSize__PageSize_), [GET/locations](https://developer.servicechannel.com/swagger/ui/index?version=3#/Locations/GETv3_locations_Id__Id__storeIdentifier__storeIdentifier__Name__Name__Sort__Sort__Page__Page__PageSize__PageSize_).              Get location notes separately for the specified location by sending the [GET/locations/{locationId}/notes](https://developer.servicechannel.com/swagger/ui/index?version=3#/Locations/GETv3_locations__locationId__notes) request.              <br /> **Example request**                                POST /locations/{storeId}/updateNotes                  {                     \"Notes\": [                         {                             \"Header\": \"Note1\",                             \"Value\": \"1\"                         },                         {                             \"Header\": \"Note2\",                             \"Value\": \"2\"                         }                     ]                  }

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LocationsstoreIdUpdateNotesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);
            var storeId = "storeId_example";  // string | Unique storeId of the location you want to update a note for.
            var locNoteHeaders = new SCServiceChannelServicesMessagingLocationNoteUpdateLocationNoteHeadersApiModelRequest(); // SCServiceChannelServicesMessagingLocationNoteUpdateLocationNoteHeadersApiModelRequest | Request to add, update or delete a location note headers for a location.

            try
            {
                // Add location notes
                apiInstance.LocationsstoreIdUpdateNotes(storeId, locNoteHeaders);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.LocationsstoreIdUpdateNotes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationsstoreIdUpdateNotesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add location notes
    apiInstance.LocationsstoreIdUpdateNotesWithHttpInfo(storeId, locNoteHeaders);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.LocationsstoreIdUpdateNotesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **storeId** | **string** | Unique storeId of the location you want to update a note for. |  |
| **locNoteHeaders** | [**SCServiceChannelServicesMessagingLocationNoteUpdateLocationNoteHeadersApiModelRequest**](SCServiceChannelServicesMessagingLocationNoteUpdateLocationNoteHeadersApiModelRequest.md) | Request to add, update or delete a location note headers for a location. |  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The note is added to the specified location. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              601 — Location is not found              1301 — Request is empty or null |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **403** | You are not authorized to request this resource, or the resource is unavailable for some reason.              &lt;br/&gt;Error codes:              100 — User has no rights to perform this action              612 — The user does not have access to update a protected location note header |  -  |
| **404** | The requested resource does not exist on the server.              &lt;br/&gt;Error codes:              611 — The location note header does not exist on the subscriber instance |  -  |
| **500** | The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 — Object reference not set to an instance of an object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="providersgetprimarylocationassignmentsforprovideridsproviderids0providerids0providerids1providerids1datefromdatefromdatetodateto"></a>
# **ProvidersGetPrimaryLocationAssignmentsForProviderIdsproviderIds0providerIds0providerIds1providerIds1dateFromdateFromdateTodateTo**
> void ProvidersGetPrimaryLocationAssignmentsForProviderIdsproviderIds0providerIds0providerIds1providerIds1dateFromdateFromdateTodateTo (List<int> providerIds, DateTime dateFrom, DateTime dateTo)

Get provider primary location assignments by Provider Ids

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProvidersGetPrimaryLocationAssignmentsForProviderIdsproviderIds0providerIds0providerIds1providerIds1dateFromdateFromdateTodateToExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);
            var providerIds = new List<int>(); // List<int> | An array of Provider Ids.
            var dateFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | The start date of the time period for which you want to retrieve location assignments. The format is `YYYY-MM-DDThh:mm:ss.ssZ`.
            var dateTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | The end date of the time period for which you want to retrieve location assignments. The format is `YYYY-MM-DDThh:mm:ss.ssZ`

            try
            {
                // Get provider primary location assignments by Provider Ids
                apiInstance.ProvidersGetPrimaryLocationAssignmentsForProviderIdsproviderIds0providerIds0providerIds1providerIds1dateFromdateFromdateTodateTo(providerIds, dateFrom, dateTo);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.ProvidersGetPrimaryLocationAssignmentsForProviderIdsproviderIds0providerIds0providerIds1providerIds1dateFromdateFromdateTodateTo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProvidersGetPrimaryLocationAssignmentsForProviderIdsproviderIds0providerIds0providerIds1providerIds1dateFromdateFromdateTodateToWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get provider primary location assignments by Provider Ids
    apiInstance.ProvidersGetPrimaryLocationAssignmentsForProviderIdsproviderIds0providerIds0providerIds1providerIds1dateFromdateFromdateTodateToWithHttpInfo(providerIds, dateFrom, dateTo);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.ProvidersGetPrimaryLocationAssignmentsForProviderIdsproviderIds0providerIds0providerIds1providerIds1dateFromdateFromdateTodateToWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **providerIds** | [**List&lt;int&gt;**](int.md) | An array of Provider Ids. |  |
| **dateFrom** | **DateTime** | The start date of the time period for which you want to retrieve location assignments. The format is &#x60;YYYY-MM-DDThh:mm:ss.ssZ&#x60;. |  |
| **dateTo** | **DateTime** | The end date of the time period for which you want to retrieve location assignments. The format is &#x60;YYYY-MM-DDThh:mm:ss.ssZ&#x60; |  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The providers location assignments are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="providersgetproviderassignmentsforlocationsandtrades"></a>
# **ProvidersGetProviderAssignmentsForLocationsAndTrades**
> List&lt;SCServiceChannelServicesMessagingLocationLocationProviderAssignmentsResponse&gt; ProvidersGetProviderAssignmentsForLocationsAndTrades (SCServiceChannelApiModelLocationsLocationProviderAssignmentsFilter assignmentsFilter)

Retrieve Provider Assignments by locations and trades

Returns a list of provider assignments.              <br />The method is available to subscribers only.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProvidersGetProviderAssignmentsForLocationsAndTradesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);
            var assignmentsFilter = new SCServiceChannelApiModelLocationsLocationProviderAssignmentsFilter(); // SCServiceChannelApiModelLocationsLocationProviderAssignmentsFilter | Request parameters to filter the response (maximum number of locations: 200, maximum number of trades: 30).

            try
            {
                // Retrieve Provider Assignments by locations and trades
                List<SCServiceChannelServicesMessagingLocationLocationProviderAssignmentsResponse> result = apiInstance.ProvidersGetProviderAssignmentsForLocationsAndTrades(assignmentsFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.ProvidersGetProviderAssignmentsForLocationsAndTrades: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProvidersGetProviderAssignmentsForLocationsAndTradesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Provider Assignments by locations and trades
    ApiResponse<List<SCServiceChannelServicesMessagingLocationLocationProviderAssignmentsResponse>> response = apiInstance.ProvidersGetProviderAssignmentsForLocationsAndTradesWithHttpInfo(assignmentsFilter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.ProvidersGetProviderAssignmentsForLocationsAndTradesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assignmentsFilter** | [**SCServiceChannelApiModelLocationsLocationProviderAssignmentsFilter**](SCServiceChannelApiModelLocationsLocationProviderAssignmentsFilter.md) | Request parameters to filter the response (maximum number of locations: 200, maximum number of trades: 30). |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingLocationLocationProviderAssignmentsResponse&gt;**](SCServiceChannelServicesMessagingLocationLocationProviderAssignmentsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested locations are in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              1301 — Request is empty or null.              1302 — Too many parameters.              1303 — The list of location ids or the list of trade names is empty. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="providersgetproviderlocationassignments"></a>
# **ProvidersGetProviderLocationAssignments**
> void ProvidersGetProviderLocationAssignments ()

Get provider location assignments

Returns a list of stores with the LocationIDs and StoreIds, along with the first contract (assignment) created date and whether the location is primary or not.              <br />The method is available to providers only.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProvidersGetProviderLocationAssignmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);

            try
            {
                // Get provider location assignments
                apiInstance.ProvidersGetProviderLocationAssignments();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.ProvidersGetProviderLocationAssignments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProvidersGetProviderLocationAssignmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get provider location assignments
    apiInstance.ProvidersGetProviderLocationAssignmentsWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.ProvidersGetProviderLocationAssignmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The provider location assignments are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="storesididstoreidentifierstoreidentifiernamenamesortsortpagepagepagesizepagesize"></a>
# **StoresIdIdstoreIdentifierstoreIdentifierNameNameSortSortPagePagePageSizePageSize**
> SCServiceChannelServicesMessagingLocationGetLocationsWithTotalResponse StoresIdIdstoreIdentifierstoreIdentifierNameNameSortSortPagePagePageSizePageSize (int? id = null, string? storeIdentifier = null, string? name = null, string? sort = null, int? page = null, int? pageSize = null)

Retrieve stores

Returns a list of all Locations, also called Stores, if neither of the filters is used. You can get the details for a certain store by specifying any of the following parameters: `Id`, `storeIdentifier`, `name`.              <br /> You can use either of these methods to get a list of the subscriber’s locations: [GET /locations](https://developer.servicechannel.com/swagger/ui/index?version=3#/Locations/GETv3_locations_Id__Id__storeIdentifier__storeIdentifier__Name__Name__Sort__Sort__Page__Page__PageSize__PageSize_), [GET /stores](https://developer.servicechannel.com/swagger/ui/index?version=3#/Locations/GETv3_stores_Id__Id__storeIdentifier__storeIdentifier__Name__Name__Sort__Sort__Page__Page__PageSize__PageSize_).              <br /> Visit ServiceChannel University to find out more about [locations and provider assignments](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/556105830/Locations+Provider+Assignments).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class StoresIdIdstoreIdentifierstoreIdentifierNameNameSortSortPagePagePageSizePageSizeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);
            var id = 56;  // int? | Unique location identifier. (optional) 
            var storeIdentifier = "storeIdentifier_example";  // string? | Alphanumeric location identifier in the client’s system. Assigned by and unique per subscriber. (optional) 
            var name = "name_example";  // string? | Location name. (optional) 
            var sort = "sort_example";  // string? | Sort resources by the specified property in the response. (optional) 
            var page = 56;  // int? | Results page number. (optional) 
            var pageSize = 56;  // int? | Number of objects on the results page. The default and maximum per page is 50. (optional) 

            try
            {
                // Retrieve stores
                SCServiceChannelServicesMessagingLocationGetLocationsWithTotalResponse result = apiInstance.StoresIdIdstoreIdentifierstoreIdentifierNameNameSortSortPagePagePageSizePageSize(id, storeIdentifier, name, sort, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.StoresIdIdstoreIdentifierstoreIdentifierNameNameSortSortPagePagePageSizePageSize: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StoresIdIdstoreIdentifierstoreIdentifierNameNameSortSortPagePagePageSizePageSizeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve stores
    ApiResponse<SCServiceChannelServicesMessagingLocationGetLocationsWithTotalResponse> response = apiInstance.StoresIdIdstoreIdentifierstoreIdentifierNameNameSortSortPagePagePageSizePageSizeWithHttpInfo(id, storeIdentifier, name, sort, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.StoresIdIdstoreIdentifierstoreIdentifierNameNameSortSortPagePagePageSizePageSizeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int?** | Unique location identifier. | [optional]  |
| **storeIdentifier** | **string?** | Alphanumeric location identifier in the client’s system. Assigned by and unique per subscriber. | [optional]  |
| **name** | **string?** | Location name. | [optional]  |
| **sort** | **string?** | Sort resources by the specified property in the response. | [optional]  |
| **page** | **int?** | Results page number. | [optional]  |
| **pageSize** | **int?** | Number of objects on the results page. The default and maximum per page is 50. | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingLocationGetLocationsWithTotalResponse**](SCServiceChannelServicesMessagingLocationGetLocationsWithTotalResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested locations are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc              &lt;br/&gt;Error codes:               502 — Subscriber not found |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 - API call rejected by security permissions              100 — User has no permissions to perform this action |  -  |
| **500** | The server was unable to complete the request due to an internal error.               &lt;br/&gt;Error codes:              501 — “Location ID” is not a valid value for Int32               |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscriberscurrentuserscurrentstores"></a>
# **SubscribersCurrentUsersCurrentStores**
> Object SubscribersCurrentUsersCurrentStores ()

Get stores

Returns a list of stores with the LocationIDs and subscriber IDs, along with the location address details. The method is available to subscribers only.              <br /> To get more detailed information, use one of these methods: [GET /stores](https://developer.servicechannel.com/swagger/ui/index?version=3#/Locations/GETv3_stores_Id__Id__storeIdentifier__storeIdentifier__Name__Name__Sort__Sort__Page__Page__PageSize__PageSize_), [GET /locations](https://developer.servicechannel.com/swagger/ui/index?version=3#/Locations/GETv3_locations_Id__Id__storeIdentifier__storeIdentifier__Name__Name__Sort__Sort__Page__Page__PageSize__PageSize_), [GET /odata/locations](https://developer.servicechannel.com/swagger/ui/index?version=3#/Locations/Locations_GetLocations).              <br /> Learn about updating [location details](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/708936009/Updating+Location+Details) in ServiceChannel University.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscribersCurrentUsersCurrentStoresExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);

            try
            {
                // Get stores
                Object result = apiInstance.SubscribersCurrentUsersCurrentStores();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.SubscribersCurrentUsersCurrentStores: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribersCurrentUsersCurrentStoresWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get stores
    ApiResponse<Object> response = apiInstance.SubscribersCurrentUsersCurrentStoresWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.SubscribersCurrentUsersCurrentStoresWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscriberssubscriberidlocationsinfofiltertypefiltertypesearchstringsearchstring"></a>
# **SubscriberssubscriberIdLocationsinfofilterTypefilterTypesearchStringsearchString**
> void SubscriberssubscriberIdLocationsinfofilterTypefilterTypesearchStringsearchString (int subscriberId, string? filterType = null, string? searchString = null)

Retrieve location information

Performs search of locations based on the specified filters and returns a list of locations with all details for the specified subscriber.               <br /> ***Note***: This method is available to *Provider Directory (aka Fixxbook)* users only.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscriberssubscriberIdLocationsinfofilterTypefilterTypesearchStringsearchStringExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationsApi(config);
            var subscriberId = 56;  // int | Unique subscriber identifier.
            var filterType = "StoreId";  // string? | Filters a collection of resources by their type. (optional) 
            var searchString = "searchString_example";  // string? | Returns resources based on the provided query string. (optional) 

            try
            {
                // Retrieve location information
                apiInstance.SubscriberssubscriberIdLocationsinfofilterTypefilterTypesearchStringsearchString(subscriberId, filterType, searchString);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.SubscriberssubscriberIdLocationsinfofilterTypefilterTypesearchStringsearchString: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriberssubscriberIdLocationsinfofilterTypefilterTypesearchStringsearchStringWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve location information
    apiInstance.SubscriberssubscriberIdLocationsinfofilterTypefilterTypesearchStringsearchStringWithHttpInfo(subscriberId, filterType, searchString);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.SubscriberssubscriberIdLocationsinfofilterTypefilterTypesearchStringsearchStringWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** | Unique subscriber identifier. |  |
| **filterType** | **string?** | Filters a collection of resources by their type. | [optional]  |
| **searchString** | **string?** | Returns resources based on the provided query string. | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The location details are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

