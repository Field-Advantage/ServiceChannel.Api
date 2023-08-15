# ServiceChannel.Api.Api.WorkRequestsApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Workrequests**](WorkRequestsApi.md#workrequests) | **POST** /workrequests | Creates a work request |
| [**WorkrequestsProvidersforreassignmentworkRequestIdworkRequestId**](WorkRequestsApi.md#workrequestsprovidersforreassignmentworkrequestidworkrequestid) | **GET** /workrequests/providersforreassignment | Get providers available for reassign |
| [**WorkrequestsSearch**](WorkRequestsApi.md#workrequestssearch) | **POST** /workrequests/search | Performs search of work requests by specified filter expression.                One page contains 50 items by default (\&quot;PageSize\&quot;&#x3D;50).               To get next 50 items use the “Page” parameter (for example Page&#x3D;2 and so on). |
| [**Workrequestsid**](WorkRequestsApi.md#workrequestsid) | **GET** /workrequests/{id} | Retrieve a work request |
| [**Workrequestsid_0**](WorkRequestsApi.md#workrequestsid_0) | **DELETE** /workrequests/{id} | Delete a work request |
| [**WorkrequestsworkRequestId**](WorkRequestsApi.md#workrequestsworkrequestid) | **PUT** /workrequests/{workRequestId} | Update a work request |
| [**WorkrequestsworkRequestIdCategorycategoryIdcategoryId**](WorkRequestsApi.md#workrequestsworkrequestidcategorycategoryidcategoryid) | **PUT** /workrequests/{workRequestId}/category | Update work request category |
| [**WorkrequestsworkRequestIdDescription**](WorkRequestsApi.md#workrequestsworkrequestiddescription) | **PUT** /workrequests/{workRequestId}/description | Update work request description |
| [**WorkrequestsworkRequestIdNte**](WorkRequestsApi.md#workrequestsworkrequestidnte) | **PUT** /workrequests/{workRequestId}/nte | Update work request NTE |
| [**WorkrequestsworkRequestIdPrioritypriorityIdpriorityId**](WorkRequestsApi.md#workrequestsworkrequestidprioritypriorityidpriorityid) | **PUT** /workrequests/{workRequestId}/priority | Update work request priority |
| [**WorkrequestsworkRequestIdReassign**](WorkRequestsApi.md#workrequestsworkrequestidreassign) | **PUT** /workrequests/{workRequestId}/reassign | Reassign work request to another provider |
| [**WorkrequestsworkRequestIdScheduledatescheduledDatescheduledDate**](WorkRequestsApi.md#workrequestsworkrequestidscheduledatescheduleddatescheduleddate) | **PUT** /workrequests/{workRequestId}/scheduledate | Update work request schedule date |
| [**WorkrequestsworkRequestIdStatus**](WorkRequestsApi.md#workrequestsworkrequestidstatus) | **PUT** /workrequests/{workRequestId}/status | Update a work request status |
| [**WorkrequestsworkRequestIdTradetradeIdtradeId**](WorkRequestsApi.md#workrequestsworkrequestidtradetradeidtradeid) | **PUT** /workrequests/{workRequestId}/trade | Update work request trade |

<a id="workrequests"></a>
# **Workrequests**
> SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestResponse Workrequests (SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest request)

Creates a work request

*In limited availability phase.*

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkrequestsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkRequestsApi(config);
            var request = new SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest(); // SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest | 

            try
            {
                // Creates a work request
                SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestResponse result = apiInstance.Workrequests(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkRequestsApi.Workrequests: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkrequestsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a work request
    ApiResponse<SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestResponse> response = apiInstance.WorkrequestsWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkRequestsApi.WorkrequestsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest**](SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest.md) |  |  |

### Return type

[**SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestResponse**](SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created indicates that the request resulted in a new resource created before the response was sent. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              101 - Invalid provider id              301 - Contract not found for specified subscribers location, provider and trade              401 - Invalid subscriber              601 - Location is not found              701 - Invalid trade              8001 — Description is required              8002 — Call Date is required              8003 — Issue is required              8005 - CallDate has wrong format              8006 - ScheduledDate has wrong format              8007 - Invalid status              8008 - Invalid extended status              8009 - Invalid category              8010 - Invalid priority              8011 - Invalid currency              8012 - Invalid setup              8013 - Invalid area              8014 - Invalid asset              8017 - ProblemCode is required              8018 - ProblemType is required              8019 - ScheduledDate must be greater than CallDate |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | Indicates that a generic error has occurred on the server.              &lt;br/&gt;Error codes:              501 - Internal Error code |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workrequestsprovidersforreassignmentworkrequestidworkrequestid"></a>
# **WorkrequestsProvidersforreassignmentworkRequestIdworkRequestId**
> SCServiceChannelServicesMessagingProvidersServiceRequestProvider WorkrequestsProvidersforreassignmentworkRequestIdworkRequestId (int workRequestId)

Get providers available for reassign

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkrequestsProvidersforreassignmentworkRequestIdworkRequestIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkRequestsApi(config);
            var workRequestId = 56;  // int | Work request id

            try
            {
                // Get providers available for reassign
                SCServiceChannelServicesMessagingProvidersServiceRequestProvider result = apiInstance.WorkrequestsProvidersforreassignmentworkRequestIdworkRequestId(workRequestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkRequestsApi.WorkrequestsProvidersforreassignmentworkRequestIdworkRequestId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkrequestsProvidersforreassignmentworkRequestIdworkRequestIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get providers available for reassign
    ApiResponse<SCServiceChannelServicesMessagingProvidersServiceRequestProvider> response = apiInstance.WorkrequestsProvidersforreassignmentworkRequestIdworkRequestIdWithHttpInfo(workRequestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkRequestsApi.WorkrequestsProvidersforreassignmentworkRequestIdworkRequestIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workRequestId** | **int** | Work request id |  |

### Return type

[**SCServiceChannelServicesMessagingProvidersServiceRequestProvider**](SCServiceChannelServicesMessagingProvidersServiceRequestProvider.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created indicates that the request resulted in a new resource created before the response was sent. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:                         503 - Invalid Equipment Id              503 - Invalid Location Id              804 - API call rejected by lack of provider permissions              502 - We could not find the service provider for the problem you have indicated |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **404** | The requested resource does not exist on the server.              &lt;br/&gt;Error codes:              502 — We could not find the service provider for the problem you have indicated |  -  |
| **500** | Indicates that a generic error has occurred on the server.              &lt;br/&gt;Error codes:              501 - Internal Error code |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workrequestssearch"></a>
# **WorkrequestsSearch**
> List&lt;SCServiceChannelServicesMessagingWorkRequestsWorkRequest&gt; WorkrequestsSearch (SCServiceChannelServicesMessagingWorkRequestsSearchWorkRequestRequest request)

Performs search of work requests by specified filter expression.                One page contains 50 items by default (\"PageSize\"=50).               To get next 50 items use the “Page” parameter (for example Page=2 and so on).

*In limited availability phase.*

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkrequestsSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkRequestsApi(config);
            var request = new SCServiceChannelServicesMessagingWorkRequestsSearchWorkRequestRequest(); // SCServiceChannelServicesMessagingWorkRequestsSearchWorkRequestRequest | 

            try
            {
                // Performs search of work requests by specified filter expression.                One page contains 50 items by default (\"PageSize\"=50).               To get next 50 items use the “Page” parameter (for example Page=2 and so on).
                List<SCServiceChannelServicesMessagingWorkRequestsWorkRequest> result = apiInstance.WorkrequestsSearch(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkRequestsApi.WorkrequestsSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkrequestsSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Performs search of work requests by specified filter expression.                One page contains 50 items by default (\"PageSize\"=50).               To get next 50 items use the “Page” parameter (for example Page=2 and so on).
    ApiResponse<List<SCServiceChannelServicesMessagingWorkRequestsWorkRequest>> response = apiInstance.WorkrequestsSearchWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkRequestsApi.WorkrequestsSearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingWorkRequestsSearchWorkRequestRequest**](SCServiceChannelServicesMessagingWorkRequestsSearchWorkRequestRequest.md) |  |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingWorkRequestsWorkRequest&gt;**](SCServiceChannelServicesMessagingWorkRequestsWorkRequest.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Work requests are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:                         8100 - CallDateFrom has wrong format              8101 - CallDateTo has wrong format              8102 - ScheduledDateFrom has wrong format              8103 - ScheduledDateTo has wrong format              8104 - CloseDateFrom has wrong format              8105 - CloseDateTo has wrong format |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workrequestsid"></a>
# **Workrequestsid**
> SCServiceChannelServicesMessagingWorkRequestsWorkRequest Workrequestsid (int id)

Retrieve a work request

*In limited availability phase.*

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkrequestsidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkRequestsApi(config);
            var id = 56;  // int | Numeric Id of the work request to perform action with.

            try
            {
                // Retrieve a work request
                SCServiceChannelServicesMessagingWorkRequestsWorkRequest result = apiInstance.Workrequestsid(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkRequestsApi.Workrequestsid: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkrequestsidWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a work request
    ApiResponse<SCServiceChannelServicesMessagingWorkRequestsWorkRequest> response = apiInstance.WorkrequestsidWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkRequestsApi.WorkrequestsidWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Numeric Id of the work request to perform action with. |  |

### Return type

[**SCServiceChannelServicesMessagingWorkRequestsWorkRequest**](SCServiceChannelServicesMessagingWorkRequestsWorkRequest.md)

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
| **404** | The requested resource does not exist on the server.              &lt;br/&gt;Error codes:              502 — Data not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workrequestsid_0"></a>
# **Workrequestsid_0**
> void Workrequestsid_0 (int id)

Delete a work request

*In limited availability phase.*

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class Workrequestsid_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkRequestsApi(config);
            var id = 56;  // int | Numeric Id of the work request to perform action with.

            try
            {
                // Delete a work request
                apiInstance.Workrequestsid_0(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkRequestsApi.Workrequestsid_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Workrequestsid_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a work request
    apiInstance.Workrequestsid_0WithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkRequestsApi.Workrequestsid_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Numeric Id of the work request to perform action with. |  |

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
| **404** | The requested resource does not exist on the server.              &lt;br/&gt;Error codes:              502 — Data not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workrequestsworkrequestid"></a>
# **WorkrequestsworkRequestId**
> void WorkrequestsworkRequestId (int workRequestId, SCServiceChannelServicesMessagingWorkRequestsUpdateWorkRequestRequest updateRequest)

Update a work request

*In limited availability phase.*

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkrequestsworkRequestIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkRequestsApi(config);
            var workRequestId = 56;  // int | Numeric Id of the work request to perform action with.
            var updateRequest = new SCServiceChannelServicesMessagingWorkRequestsUpdateWorkRequestRequest(); // SCServiceChannelServicesMessagingWorkRequestsUpdateWorkRequestRequest | The update request.

            try
            {
                // Update a work request
                apiInstance.WorkrequestsworkRequestId(workRequestId, updateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkRequestsApi.WorkrequestsworkRequestId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkrequestsworkRequestIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a work request
    apiInstance.WorkrequestsworkRequestIdWithHttpInfo(workRequestId, updateRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkRequestsApi.WorkrequestsworkRequestIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workRequestId** | **int** | Numeric Id of the work request to perform action with. |  |
| **updateRequest** | [**SCServiceChannelServicesMessagingWorkRequestsUpdateWorkRequestRequest**](SCServiceChannelServicesMessagingWorkRequestsUpdateWorkRequestRequest.md) | The update request. |  |

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
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              301 - Contract not found for specified subscribers location, provider and trade              502 - WorkRequest not found              701 - Invalid trade              8006 - ScheduledDate has wrong format              8007 - Invalid status              8008 - Invalid extended status              8009 - Invalid category              8010 - Invalid priority                   8011 - Invalid currency              8019 - ScheduledDate must be greater than CallDate              8107 - Work request is closed              8108 - Closed reason is required for Closed status              8109 - Work order id is required for this closed reason              8110 - Invalid closed reason              8111 - Closed reason could be set only for Closed status              8112 - Invalid work order id              8113 - Work order id could be set only for Closed status              8114 - Work order id could be set only for &amp;apos;Work order created&amp;apos; reason |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | Indicates that a generic error has occurred on the server.              &lt;br/&gt;Error codes:              501 - Internal Error code |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workrequestsworkrequestidcategorycategoryidcategoryid"></a>
# **WorkrequestsworkRequestIdCategorycategoryIdcategoryId**
> void WorkrequestsworkRequestIdCategorycategoryIdcategoryId (int workRequestId, int categoryId)

Update work request category

*In limited availability phase.*

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkrequestsworkRequestIdCategorycategoryIdcategoryIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkRequestsApi(config);
            var workRequestId = 56;  // int | Numeric Id of the work request to perform action with.
            var categoryId = 56;  // int | Category Id.

            try
            {
                // Update work request category
                apiInstance.WorkrequestsworkRequestIdCategorycategoryIdcategoryId(workRequestId, categoryId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkRequestsApi.WorkrequestsworkRequestIdCategorycategoryIdcategoryId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkrequestsworkRequestIdCategorycategoryIdcategoryIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update work request category
    apiInstance.WorkrequestsworkRequestIdCategorycategoryIdcategoryIdWithHttpInfo(workRequestId, categoryId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkRequestsApi.WorkrequestsworkRequestIdCategorycategoryIdcategoryIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workRequestId** | **int** | Numeric Id of the work request to perform action with. |  |
| **categoryId** | **int** | Category Id. |  |

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
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              502 - WorkRequest not found              8009 - Invalid category |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | Indicates that a generic error has occurred on the server.              &lt;br/&gt;Error codes:              501 - Internal Error code |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workrequestsworkrequestiddescription"></a>
# **WorkrequestsworkRequestIdDescription**
> void WorkrequestsworkRequestIdDescription (int workRequestId, SCServiceChannelServicesMessagingWorkRequestsChangeWorkRequestStringFieldsRequest updateRequest)

Update work request description

*In limited availability phase.*

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkrequestsworkRequestIdDescriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkRequestsApi(config);
            var workRequestId = 56;  // int | Numeric Id of the work request to perform action with.
            var updateRequest = new SCServiceChannelServicesMessagingWorkRequestsChangeWorkRequestStringFieldsRequest(); // SCServiceChannelServicesMessagingWorkRequestsChangeWorkRequestStringFieldsRequest | The update request. Work request description.

            try
            {
                // Update work request description
                apiInstance.WorkrequestsworkRequestIdDescription(workRequestId, updateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkRequestsApi.WorkrequestsworkRequestIdDescription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkrequestsworkRequestIdDescriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update work request description
    apiInstance.WorkrequestsworkRequestIdDescriptionWithHttpInfo(workRequestId, updateRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkRequestsApi.WorkrequestsworkRequestIdDescriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workRequestId** | **int** | Numeric Id of the work request to perform action with. |  |
| **updateRequest** | [**SCServiceChannelServicesMessagingWorkRequestsChangeWorkRequestStringFieldsRequest**](SCServiceChannelServicesMessagingWorkRequestsChangeWorkRequestStringFieldsRequest.md) | The update request. Work request description. |  |

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
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              502 - WorkRequest not found |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | Indicates that a generic error has occurred on the server.              &lt;br/&gt;Error codes:              501 - Internal Error code |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workrequestsworkrequestidnte"></a>
# **WorkrequestsworkRequestIdNte**
> void WorkrequestsworkRequestIdNte (int workRequestId, SCServiceChannelServicesMessagingWorkRequestsChangeWorkRequestNteRequest updateRequest)

Update work request NTE

*In limited availability phase.*

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkrequestsworkRequestIdNteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkRequestsApi(config);
            var workRequestId = 56;  // int | Numeric Id of the work request to perform action with.
            var updateRequest = new SCServiceChannelServicesMessagingWorkRequestsChangeWorkRequestNteRequest(); // SCServiceChannelServicesMessagingWorkRequestsChangeWorkRequestNteRequest | The update request. Work request NTE.

            try
            {
                // Update work request NTE
                apiInstance.WorkrequestsworkRequestIdNte(workRequestId, updateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkRequestsApi.WorkrequestsworkRequestIdNte: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkrequestsworkRequestIdNteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update work request NTE
    apiInstance.WorkrequestsworkRequestIdNteWithHttpInfo(workRequestId, updateRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkRequestsApi.WorkrequestsworkRequestIdNteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workRequestId** | **int** | Numeric Id of the work request to perform action with. |  |
| **updateRequest** | [**SCServiceChannelServicesMessagingWorkRequestsChangeWorkRequestNteRequest**](SCServiceChannelServicesMessagingWorkRequestsChangeWorkRequestNteRequest.md) | The update request. Work request NTE. |  |

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
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              502 - WorkRequest not found              8011 - Invalid currency |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | Indicates that a generic error has occurred on the server.              &lt;br/&gt;Error codes:              501 - Internal Error code |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workrequestsworkrequestidprioritypriorityidpriorityid"></a>
# **WorkrequestsworkRequestIdPrioritypriorityIdpriorityId**
> void WorkrequestsworkRequestIdPrioritypriorityIdpriorityId (int workRequestId, int priorityId)

Update work request priority

*In limited availability phase.*

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkrequestsworkRequestIdPrioritypriorityIdpriorityIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkRequestsApi(config);
            var workRequestId = 56;  // int | Numeric Id of the work request to perform action with.
            var priorityId = 56;  // int | Priority Id.

            try
            {
                // Update work request priority
                apiInstance.WorkrequestsworkRequestIdPrioritypriorityIdpriorityId(workRequestId, priorityId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkRequestsApi.WorkrequestsworkRequestIdPrioritypriorityIdpriorityId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkrequestsworkRequestIdPrioritypriorityIdpriorityIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update work request priority
    apiInstance.WorkrequestsworkRequestIdPrioritypriorityIdpriorityIdWithHttpInfo(workRequestId, priorityId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkRequestsApi.WorkrequestsworkRequestIdPrioritypriorityIdpriorityIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workRequestId** | **int** | Numeric Id of the work request to perform action with. |  |
| **priorityId** | **int** | Priority Id. |  |

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
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              502 - WorkRequest not found              8010 - Invalid priority |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | Indicates that a generic error has occurred on the server.              &lt;br/&gt;Error codes:              501 - Internal Error code |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workrequestsworkrequestidreassign"></a>
# **WorkrequestsworkRequestIdReassign**
> void WorkrequestsworkRequestIdReassign (int workRequestId, SCServiceChannelServicesMessagingWorkRequestsReassignWorkRequestRequest reassignRequest)

Reassign work request to another provider

*In limited availability phase.*

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkrequestsworkRequestIdReassignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkRequestsApi(config);
            var workRequestId = 56;  // int | Numeric Id of the work request to perform action with.
            var reassignRequest = new SCServiceChannelServicesMessagingWorkRequestsReassignWorkRequestRequest(); // SCServiceChannelServicesMessagingWorkRequestsReassignWorkRequestRequest | The request to perform action with.

            try
            {
                // Reassign work request to another provider
                apiInstance.WorkrequestsworkRequestIdReassign(workRequestId, reassignRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkRequestsApi.WorkrequestsworkRequestIdReassign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkrequestsworkRequestIdReassignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reassign work request to another provider
    apiInstance.WorkrequestsworkRequestIdReassignWithHttpInfo(workRequestId, reassignRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkRequestsApi.WorkrequestsworkRequestIdReassignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workRequestId** | **int** | Numeric Id of the work request to perform action with. |  |
| **reassignRequest** | [**SCServiceChannelServicesMessagingWorkRequestsReassignWorkRequestRequest**](SCServiceChannelServicesMessagingWorkRequestsReassignWorkRequestRequest.md) | The request to perform action with. |  |

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
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              100 - Invalid provider id passed              301 - Contract not found for specified subscribers location, provider and trade              502 - WorkRequest not found              503 - Provider should be changed              701 - Invalid trade              8006 - ScheduledDate has wrong format              8009 - Invalid category              8010 - Invalid priority              8011 - Invalid currency              8019 - ScheduledDate must be greater than CallDate |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | Indicates that a generic error has occurred on the server.              &lt;br/&gt;Error codes:              501 - Internal Error code |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workrequestsworkrequestidscheduledatescheduleddatescheduleddate"></a>
# **WorkrequestsworkRequestIdScheduledatescheduledDatescheduledDate**
> void WorkrequestsworkRequestIdScheduledatescheduledDatescheduledDate (int workRequestId, string scheduledDate)

Update work request schedule date

*In limited availability phase.*

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkrequestsworkRequestIdScheduledatescheduledDatescheduledDateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkRequestsApi(config);
            var workRequestId = 56;  // int | Numeric Id of the work request to perform action with.
            var scheduledDate = "scheduledDate_example";  // string | Scheduled date.

            try
            {
                // Update work request schedule date
                apiInstance.WorkrequestsworkRequestIdScheduledatescheduledDatescheduledDate(workRequestId, scheduledDate);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkRequestsApi.WorkrequestsworkRequestIdScheduledatescheduledDatescheduledDate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkrequestsworkRequestIdScheduledatescheduledDatescheduledDateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update work request schedule date
    apiInstance.WorkrequestsworkRequestIdScheduledatescheduledDatescheduledDateWithHttpInfo(workRequestId, scheduledDate);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkRequestsApi.WorkrequestsworkRequestIdScheduledatescheduledDatescheduledDateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workRequestId** | **int** | Numeric Id of the work request to perform action with. |  |
| **scheduledDate** | **string** | Scheduled date. |  |

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
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              502 - WorkRequest not found              8006 - ScheduledDate has wrong format              8019 - ScheduledDate must be greater than CallDate |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | Indicates that a generic error has occurred on the server.              &lt;br/&gt;Error codes:              501 - Internal Error code |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workrequestsworkrequestidstatus"></a>
# **WorkrequestsworkRequestIdStatus**
> void WorkrequestsworkRequestIdStatus (int workRequestId, SCServiceChannelServicesMessagingWorkRequestsChangeWorkRequestStatusRequest updateRequest)

Update a work request status

*In limited availability phase.*

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkrequestsworkRequestIdStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkRequestsApi(config);
            var workRequestId = 56;  // int | Numeric Id of the work request to perform action with.
            var updateRequest = new SCServiceChannelServicesMessagingWorkRequestsChangeWorkRequestStatusRequest(); // SCServiceChannelServicesMessagingWorkRequestsChangeWorkRequestStatusRequest | The update request. Work request Status.

            try
            {
                // Update a work request status
                apiInstance.WorkrequestsworkRequestIdStatus(workRequestId, updateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkRequestsApi.WorkrequestsworkRequestIdStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkrequestsworkRequestIdStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a work request status
    apiInstance.WorkrequestsworkRequestIdStatusWithHttpInfo(workRequestId, updateRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkRequestsApi.WorkrequestsworkRequestIdStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workRequestId** | **int** | Numeric Id of the work request to perform action with. |  |
| **updateRequest** | [**SCServiceChannelServicesMessagingWorkRequestsChangeWorkRequestStatusRequest**](SCServiceChannelServicesMessagingWorkRequestsChangeWorkRequestStatusRequest.md) | The update request. Work request Status. |  |

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
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              502 - WorkRequest not found              8007 - Invalid status              8008 - Invalid extended status |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | Indicates that a generic error has occurred on the server.              &lt;br/&gt;Error codes:              501 - Internal Error code |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workrequestsworkrequestidtradetradeidtradeid"></a>
# **WorkrequestsworkRequestIdTradetradeIdtradeId**
> void WorkrequestsworkRequestIdTradetradeIdtradeId (int workRequestId, int tradeId)

Update work request trade

*In limited availability phase.*

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkrequestsworkRequestIdTradetradeIdtradeIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkRequestsApi(config);
            var workRequestId = 56;  // int | Numeric Id of the Work request to perform action with.
            var tradeId = 56;  // int | Trade id.

            try
            {
                // Update work request trade
                apiInstance.WorkrequestsworkRequestIdTradetradeIdtradeId(workRequestId, tradeId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkRequestsApi.WorkrequestsworkRequestIdTradetradeIdtradeId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkrequestsworkRequestIdTradetradeIdtradeIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update work request trade
    apiInstance.WorkrequestsworkRequestIdTradetradeIdtradeIdWithHttpInfo(workRequestId, tradeId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkRequestsApi.WorkrequestsworkRequestIdTradetradeIdtradeIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workRequestId** | **int** | Numeric Id of the Work request to perform action with. |  |
| **tradeId** | **int** | Trade id. |  |

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
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              301 - Contract not found for specified subscribers location, provider and trade              502 - WorkRequest not found              701 - Invalid trade |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | Indicates that a generic error has occurred on the server.              &lt;br/&gt;Error codes:              501 - Internal Error code |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

