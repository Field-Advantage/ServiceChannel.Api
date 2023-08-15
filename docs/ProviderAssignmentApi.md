# ServiceChannel.Api.Api.ProviderAssignmentApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAssigned**](ProviderAssignmentApi.md#getassigned) | **GET** /odata/providerassignment/Service.GetAssigned() | Retrieve list of providers assigned to specific subscriber |
| [**GetProviderAssignments**](ProviderAssignmentApi.md#getproviderassignments) | **GET** /odata/GetProviderAssignments | Retrieve Provider Assignments |

<a id="getassigned"></a>
# **GetAssigned**
> List&lt;SCServiceChannelServicesMessagingProvidersProviderInfo&gt; GetAssigned (string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Retrieve list of providers assigned to specific subscriber

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetAssignedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProviderAssignmentApi(config);
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Retrieve list of providers assigned to specific subscriber
                List<SCServiceChannelServicesMessagingProvidersProviderInfo> result = apiInstance.GetAssigned(expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProviderAssignmentApi.GetAssigned: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAssignedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve list of providers assigned to specific subscriber
    ApiResponse<List<SCServiceChannelServicesMessagingProvidersProviderInfo>> response = apiInstance.GetAssignedWithHttpInfo(expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProviderAssignmentApi.GetAssignedWithHttpInfo: " + e.Message);
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

[**List&lt;SCServiceChannelServicesMessagingProvidersProviderInfo&gt;**](SCServiceChannelServicesMessagingProvidersProviderInfo.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getproviderassignments"></a>
# **GetProviderAssignments**
> List&lt;SCServiceChannelServicesMessagingProviderAssignmentsProviderAssignment&gt; GetProviderAssignments (string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Retrieve Provider Assignments

Retrieve Provider Assignments.              <br />One page contains 50 items by default. To get next 50 items use the \"$skip\" parameter (for example $skip=50 and so on).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetProviderAssignmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProviderAssignmentApi(config);
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Retrieve Provider Assignments
                List<SCServiceChannelServicesMessagingProviderAssignmentsProviderAssignment> result = apiInstance.GetProviderAssignments(expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProviderAssignmentApi.GetProviderAssignments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProviderAssignmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Provider Assignments
    ApiResponse<List<SCServiceChannelServicesMessagingProviderAssignmentsProviderAssignment>> response = apiInstance.GetProviderAssignmentsWithHttpInfo(expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProviderAssignmentApi.GetProviderAssignmentsWithHttpInfo: " + e.Message);
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

[**List&lt;SCServiceChannelServicesMessagingProviderAssignmentsProviderAssignment&gt;**](SCServiceChannelServicesMessagingProviderAssignmentsProviderAssignment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

