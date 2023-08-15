# ServiceChannel.Api.Api.LocationSupplyApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Locationsupply**](LocationSupplyApi.md#locationsupply) | **POST** /locationsupply |  |
| [**LocationsupplyLocationIdLocationIdTruckIdTruckId**](LocationSupplyApi.md#locationsupplylocationidlocationidtruckidtruckid) | **GET** /locationsupply |  |
| [**LocationsupplyLocationIdLocationIdTruckIdTruckId_0**](LocationSupplyApi.md#locationsupplylocationidlocationidtruckidtruckid_0) | **PUT** /locationsupply |  |
| [**LocationsupplyLocationIdLocationIdTruckIdTruckId_1**](LocationSupplyApi.md#locationsupplylocationidlocationidtruckidtruckid_1) | **DELETE** /locationsupply |  |

<a id="locationsupply"></a>
# **Locationsupply**
> Object Locationsupply (SCServiceChannelApiModelLocationSupplyLocationSupply locationSupply)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LocationsupplyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationSupplyApi(config);
            var locationSupply = new SCServiceChannelApiModelLocationSupplyLocationSupply(); // SCServiceChannelApiModelLocationSupplyLocationSupply | 

            try
            {
                Object result = apiInstance.Locationsupply(locationSupply);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationSupplyApi.Locationsupply: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationsupplyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.LocationsupplyWithHttpInfo(locationSupply);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationSupplyApi.LocationsupplyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationSupply** | [**SCServiceChannelApiModelLocationSupplyLocationSupply**](SCServiceChannelApiModelLocationSupplyLocationSupply.md) |  |  |

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="locationsupplylocationidlocationidtruckidtruckid"></a>
# **LocationsupplyLocationIdLocationIdTruckIdTruckId**
> Object LocationsupplyLocationIdLocationIdTruckIdTruckId (int? locationId = null, int? truckId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LocationsupplyLocationIdLocationIdTruckIdTruckIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationSupplyApi(config);
            var locationId = 56;  // int? |  (optional) 
            var truckId = 56;  // int? |  (optional) 

            try
            {
                Object result = apiInstance.LocationsupplyLocationIdLocationIdTruckIdTruckId(locationId, truckId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationSupplyApi.LocationsupplyLocationIdLocationIdTruckIdTruckId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationsupplyLocationIdLocationIdTruckIdTruckIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.LocationsupplyLocationIdLocationIdTruckIdTruckIdWithHttpInfo(locationId, truckId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationSupplyApi.LocationsupplyLocationIdLocationIdTruckIdTruckIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int?** |  | [optional]  |
| **truckId** | **int?** |  | [optional]  |

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

<a id="locationsupplylocationidlocationidtruckidtruckid_0"></a>
# **LocationsupplyLocationIdLocationIdTruckIdTruckId_0**
> Object LocationsupplyLocationIdLocationIdTruckIdTruckId_0 (List<SCServiceChannelApiModelLocationSupplyLocation> supplyLocations, int? locationId = null, int? truckId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LocationsupplyLocationIdLocationIdTruckIdTruckId_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationSupplyApi(config);
            var supplyLocations = new List<SCServiceChannelApiModelLocationSupplyLocation>(); // List<SCServiceChannelApiModelLocationSupplyLocation> | 
            var locationId = 56;  // int? |  (optional) 
            var truckId = 56;  // int? |  (optional) 

            try
            {
                Object result = apiInstance.LocationsupplyLocationIdLocationIdTruckIdTruckId_0(supplyLocations, locationId, truckId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationSupplyApi.LocationsupplyLocationIdLocationIdTruckIdTruckId_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationsupplyLocationIdLocationIdTruckIdTruckId_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.LocationsupplyLocationIdLocationIdTruckIdTruckId_0WithHttpInfo(supplyLocations, locationId, truckId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationSupplyApi.LocationsupplyLocationIdLocationIdTruckIdTruckId_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **supplyLocations** | [**List&lt;SCServiceChannelApiModelLocationSupplyLocation&gt;**](SCServiceChannelApiModelLocationSupplyLocation.md) |  |  |
| **locationId** | **int?** |  | [optional]  |
| **truckId** | **int?** |  | [optional]  |

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="locationsupplylocationidlocationidtruckidtruckid_1"></a>
# **LocationsupplyLocationIdLocationIdTruckIdTruckId_1**
> Object LocationsupplyLocationIdLocationIdTruckIdTruckId_1 (int? locationId = null, int? truckId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LocationsupplyLocationIdLocationIdTruckIdTruckId_1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationSupplyApi(config);
            var locationId = 56;  // int? |  (optional) 
            var truckId = 56;  // int? |  (optional) 

            try
            {
                Object result = apiInstance.LocationsupplyLocationIdLocationIdTruckIdTruckId_1(locationId, truckId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationSupplyApi.LocationsupplyLocationIdLocationIdTruckIdTruckId_1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationsupplyLocationIdLocationIdTruckIdTruckId_1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.LocationsupplyLocationIdLocationIdTruckIdTruckId_1WithHttpInfo(locationId, truckId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationSupplyApi.LocationsupplyLocationIdLocationIdTruckIdTruckId_1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int?** |  | [optional]  |
| **truckId** | **int?** |  | [optional]  |

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

