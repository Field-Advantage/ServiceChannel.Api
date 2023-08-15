# ServiceChannel.Api.Api.TrucksApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetTrucks**](TrucksApi.md#gettrucks) | **GET** /odata/trucks |  |
| [**Trucks**](TrucksApi.md#trucks) | **POST** /trucks |  |
| [**TrucksTechnician**](TrucksApi.md#truckstechnician) | **POST** /trucks/technician |  |
| [**TrucksTechnicianauthTechId**](TrucksApi.md#truckstechnicianauthtechid) | **GET** /trucks/technician/{authTechId} |  |
| [**TrucksTechnicianauthTechId_0**](TrucksApi.md#truckstechnicianauthtechid_0) | **PUT** /trucks/technician/{authTechId} |  |
| [**TrucksTechnicianauthTechId_1**](TrucksApi.md#truckstechnicianauthtechid_1) | **DELETE** /trucks/technician/{authTechId} |  |
| [**Trucksid**](TrucksApi.md#trucksid) | **GET** /trucks/{id} |  |
| [**Trucksid_0**](TrucksApi.md#trucksid_0) | **PUT** /trucks/{id} |  |
| [**Trucksid_1**](TrucksApi.md#trucksid_1) | **DELETE** /trucks/{id} |  |

<a id="gettrucks"></a>
# **GetTrucks**
> Object GetTrucks (string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetTrucksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TrucksApi(config);
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                Object result = apiInstance.GetTrucks(expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrucksApi.GetTrucks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTrucksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.GetTrucksWithHttpInfo(expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrucksApi.GetTrucksWithHttpInfo: " + e.Message);
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

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="trucks"></a>
# **Trucks**
> Object Trucks (SCServiceChannelServicesMessagingTrucksTruckRequest truckRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class TrucksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TrucksApi(config);
            var truckRequest = new SCServiceChannelServicesMessagingTrucksTruckRequest(); // SCServiceChannelServicesMessagingTrucksTruckRequest | 

            try
            {
                Object result = apiInstance.Trucks(truckRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrucksApi.Trucks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TrucksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.TrucksWithHttpInfo(truckRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrucksApi.TrucksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **truckRequest** | [**SCServiceChannelServicesMessagingTrucksTruckRequest**](SCServiceChannelServicesMessagingTrucksTruckRequest.md) |  |  |

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

<a id="truckstechnician"></a>
# **TrucksTechnician**
> Object TrucksTechnician (SCServiceChannelServicesMessagingTrucksTechTruckRequest techTruckCreate)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class TrucksTechnicianExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TrucksApi(config);
            var techTruckCreate = new SCServiceChannelServicesMessagingTrucksTechTruckRequest(); // SCServiceChannelServicesMessagingTrucksTechTruckRequest | 

            try
            {
                Object result = apiInstance.TrucksTechnician(techTruckCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrucksApi.TrucksTechnician: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TrucksTechnicianWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.TrucksTechnicianWithHttpInfo(techTruckCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrucksApi.TrucksTechnicianWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **techTruckCreate** | [**SCServiceChannelServicesMessagingTrucksTechTruckRequest**](SCServiceChannelServicesMessagingTrucksTechTruckRequest.md) |  |  |

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

<a id="truckstechnicianauthtechid"></a>
# **TrucksTechnicianauthTechId**
> Object TrucksTechnicianauthTechId (long authTechId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class TrucksTechnicianauthTechIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TrucksApi(config);
            var authTechId = 789L;  // long | 

            try
            {
                Object result = apiInstance.TrucksTechnicianauthTechId(authTechId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrucksApi.TrucksTechnicianauthTechId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TrucksTechnicianauthTechIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.TrucksTechnicianauthTechIdWithHttpInfo(authTechId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrucksApi.TrucksTechnicianauthTechIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authTechId** | **long** |  |  |

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

<a id="truckstechnicianauthtechid_0"></a>
# **TrucksTechnicianauthTechId_0**
> Object TrucksTechnicianauthTechId_0 (long authTechId, SCServiceChannelServicesMessagingTrucksTechTruckRequest techTruck)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class TrucksTechnicianauthTechId_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TrucksApi(config);
            var authTechId = 789L;  // long | 
            var techTruck = new SCServiceChannelServicesMessagingTrucksTechTruckRequest(); // SCServiceChannelServicesMessagingTrucksTechTruckRequest | 

            try
            {
                Object result = apiInstance.TrucksTechnicianauthTechId_0(authTechId, techTruck);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrucksApi.TrucksTechnicianauthTechId_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TrucksTechnicianauthTechId_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.TrucksTechnicianauthTechId_0WithHttpInfo(authTechId, techTruck);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrucksApi.TrucksTechnicianauthTechId_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authTechId** | **long** |  |  |
| **techTruck** | [**SCServiceChannelServicesMessagingTrucksTechTruckRequest**](SCServiceChannelServicesMessagingTrucksTechTruckRequest.md) |  |  |

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

<a id="truckstechnicianauthtechid_1"></a>
# **TrucksTechnicianauthTechId_1**
> Object TrucksTechnicianauthTechId_1 (long authTechId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class TrucksTechnicianauthTechId_1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TrucksApi(config);
            var authTechId = 789L;  // long | 

            try
            {
                Object result = apiInstance.TrucksTechnicianauthTechId_1(authTechId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrucksApi.TrucksTechnicianauthTechId_1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TrucksTechnicianauthTechId_1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.TrucksTechnicianauthTechId_1WithHttpInfo(authTechId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrucksApi.TrucksTechnicianauthTechId_1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authTechId** | **long** |  |  |

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

<a id="trucksid"></a>
# **Trucksid**
> Object Trucksid (int id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class TrucksidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TrucksApi(config);
            var id = 56;  // int | 

            try
            {
                Object result = apiInstance.Trucksid(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrucksApi.Trucksid: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TrucksidWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.TrucksidWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrucksApi.TrucksidWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

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

<a id="trucksid_0"></a>
# **Trucksid_0**
> Object Trucksid_0 (int id, SCServiceChannelServicesMessagingTrucksTruckRequest truckRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class Trucksid_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TrucksApi(config);
            var id = 56;  // int | 
            var truckRequest = new SCServiceChannelServicesMessagingTrucksTruckRequest(); // SCServiceChannelServicesMessagingTrucksTruckRequest | 

            try
            {
                Object result = apiInstance.Trucksid_0(id, truckRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrucksApi.Trucksid_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Trucksid_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.Trucksid_0WithHttpInfo(id, truckRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrucksApi.Trucksid_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **truckRequest** | [**SCServiceChannelServicesMessagingTrucksTruckRequest**](SCServiceChannelServicesMessagingTrucksTruckRequest.md) |  |  |

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

<a id="trucksid_1"></a>
# **Trucksid_1**
> Object Trucksid_1 (int id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class Trucksid_1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TrucksApi(config);
            var id = 56;  // int | 

            try
            {
                Object result = apiInstance.Trucksid_1(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrucksApi.Trucksid_1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Trucksid_1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.Trucksid_1WithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrucksApi.Trucksid_1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

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

