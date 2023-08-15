# ServiceChannel.Api.Api.AssetTaskResponseApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**WorkordersworkOrderIdAssetTasks**](AssetTaskResponseApi.md#workordersworkorderidassettasks) | **GET** /workorders/{workOrderId}/asset-tasks | Get asset task responses for a work order. |
| [**WorkordersworkOrderIdAssetTasksEndAll**](AssetTaskResponseApi.md#workordersworkorderidassettasksendall) | **PUT** /workorders/{workOrderId}/asset-tasks/end-all | End all started task responses for work order. Automatically sets End Time. Responses will be marked as &#39;ended by system&#39;. |
| [**WorkordersworkOrderIdAssetTasks_0**](AssetTaskResponseApi.md#workordersworkorderidassettasks_0) | **POST** /workorders/{workOrderId}/asset-tasks | Create an asset task reponse. |
| [**WorkordersworkOrderIdAssetTasksresponseId**](AssetTaskResponseApi.md#workordersworkorderidassettasksresponseid) | **GET** /workorders/{workOrderId}/asset-tasks/{responseId} | Get an asset task response. |
| [**WorkordersworkOrderIdAssetTasksresponseId_0**](AssetTaskResponseApi.md#workordersworkorderidassettasksresponseid_0) | **PUT** /workorders/{workOrderId}/asset-tasks/{responseId} | Update an asset task response. Automatically sets End Time. |

<a id="workordersworkorderidassettasks"></a>
# **WorkordersworkOrderIdAssetTasks**
> void WorkordersworkOrderIdAssetTasks (int workOrderId)

Get asset task responses for a work order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkOrderIdAssetTasksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetTaskResponseApi(config);
            var workOrderId = 56;  // int | Work order id

            try
            {
                // Get asset task responses for a work order.
                apiInstance.WorkordersworkOrderIdAssetTasks(workOrderId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetTaskResponseApi.WorkordersworkOrderIdAssetTasks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkOrderIdAssetTasksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get asset task responses for a work order.
    apiInstance.WorkordersworkOrderIdAssetTasksWithHttpInfo(workOrderId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetTaskResponseApi.WorkordersworkOrderIdAssetTasksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrderId** | **int** | Work order id |  |

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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **404** | Indicates that the requested resource does not exist on the server. |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidassettasksendall"></a>
# **WorkordersworkOrderIdAssetTasksEndAll**
> void WorkordersworkOrderIdAssetTasksEndAll (int workOrderId)

End all started task responses for work order. Automatically sets End Time. Responses will be marked as 'ended by system'.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkOrderIdAssetTasksEndAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetTaskResponseApi(config);
            var workOrderId = 56;  // int | Work order id

            try
            {
                // End all started task responses for work order. Automatically sets End Time. Responses will be marked as 'ended by system'.
                apiInstance.WorkordersworkOrderIdAssetTasksEndAll(workOrderId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetTaskResponseApi.WorkordersworkOrderIdAssetTasksEndAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkOrderIdAssetTasksEndAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // End all started task responses for work order. Automatically sets End Time. Responses will be marked as 'ended by system'.
    apiInstance.WorkordersworkOrderIdAssetTasksEndAllWithHttpInfo(workOrderId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetTaskResponseApi.WorkordersworkOrderIdAssetTasksEndAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrderId** | **int** | Work order id |  |

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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **404** | Indicates that the requested resource does not exist on the server. |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidassettasks_0"></a>
# **WorkordersworkOrderIdAssetTasks_0**
> void WorkordersworkOrderIdAssetTasks_0 (int workOrderId, SCServiceChannelServicesMessagingAssetTasksCreateAssetTaskResponseRequest request)

Create an asset task reponse.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkOrderIdAssetTasks_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetTaskResponseApi(config);
            var workOrderId = 56;  // int | Work order Id
            var request = new SCServiceChannelServicesMessagingAssetTasksCreateAssetTaskResponseRequest(); // SCServiceChannelServicesMessagingAssetTasksCreateAssetTaskResponseRequest | Create request

            try
            {
                // Create an asset task reponse.
                apiInstance.WorkordersworkOrderIdAssetTasks_0(workOrderId, request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetTaskResponseApi.WorkordersworkOrderIdAssetTasks_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkOrderIdAssetTasks_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an asset task reponse.
    apiInstance.WorkordersworkOrderIdAssetTasks_0WithHttpInfo(workOrderId, request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetTaskResponseApi.WorkordersworkOrderIdAssetTasks_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrderId** | **int** | Work order Id |  |
| **request** | [**SCServiceChannelServicesMessagingAssetTasksCreateAssetTaskResponseRequest**](SCServiceChannelServicesMessagingAssetTasksCreateAssetTaskResponseRequest.md) | Create request |  |

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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **404** | Indicates that the requested resource does not exist on the server. |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidassettasksresponseid"></a>
# **WorkordersworkOrderIdAssetTasksresponseId**
> void WorkordersworkOrderIdAssetTasksresponseId (int workOrderId, int responseId)

Get an asset task response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkOrderIdAssetTasksresponseIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetTaskResponseApi(config);
            var workOrderId = 56;  // int | Work order id
            var responseId = 56;  // int | Response Id

            try
            {
                // Get an asset task response.
                apiInstance.WorkordersworkOrderIdAssetTasksresponseId(workOrderId, responseId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetTaskResponseApi.WorkordersworkOrderIdAssetTasksresponseId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkOrderIdAssetTasksresponseIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an asset task response.
    apiInstance.WorkordersworkOrderIdAssetTasksresponseIdWithHttpInfo(workOrderId, responseId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetTaskResponseApi.WorkordersworkOrderIdAssetTasksresponseIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrderId** | **int** | Work order id |  |
| **responseId** | **int** | Response Id |  |

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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **404** | Indicates that the requested resource does not exist on the server. |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidassettasksresponseid_0"></a>
# **WorkordersworkOrderIdAssetTasksresponseId_0**
> void WorkordersworkOrderIdAssetTasksresponseId_0 (int workOrderId, int responseId)

Update an asset task response. Automatically sets End Time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkOrderIdAssetTasksresponseId_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetTaskResponseApi(config);
            var workOrderId = 56;  // int | Work order id
            var responseId = 56;  // int | Response id

            try
            {
                // Update an asset task response. Automatically sets End Time.
                apiInstance.WorkordersworkOrderIdAssetTasksresponseId_0(workOrderId, responseId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetTaskResponseApi.WorkordersworkOrderIdAssetTasksresponseId_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkOrderIdAssetTasksresponseId_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an asset task response. Automatically sets End Time.
    apiInstance.WorkordersworkOrderIdAssetTasksresponseId_0WithHttpInfo(workOrderId, responseId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetTaskResponseApi.WorkordersworkOrderIdAssetTasksresponseId_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrderId** | **int** | Work order id |  |
| **responseId** | **int** | Response id |  |

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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **404** | Indicates that the requested resource does not exist on the server. |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

