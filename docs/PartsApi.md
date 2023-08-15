# ServiceChannel.Api.Api.PartsApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PartsIsTechCertificationUsedOnRefrigerantTrackingauthUserIdauthUserIdtechnicianIdtechnicianIdcertificationNumbercertificationNumber**](PartsApi.md#partsistechcertificationusedonrefrigeranttrackingauthuseridauthuseridtechnicianidtechnicianidcertificationnumbercertificationnumber) | **GET** /parts/isTechCertificationUsedOnRefrigerantTracking | Verifies that user is associated with parts usage |
| [**WorkordersInventoryPartsBulkPartUsage**](PartsApi.md#workordersinventorypartsbulkpartusage) | **POST** /workorders/inventory/parts/bulkPartUsage | Inventory part user record bulk change |
| [**WorkordersworkorderIdInventoryRefrigerantusage**](PartsApi.md#workordersworkorderidinventoryrefrigerantusage) | **GET** /workorders/{workorderId}/inventory/refrigerantusage |  |
| [**WorkordersworkorderIdParts**](PartsApi.md#workordersworkorderidparts) | **GET** /workorders/{workorderId}/parts | Get a Work order parts |
| [**WorkordersworkorderIdPartsUsage**](PartsApi.md#workordersworkorderidpartsusage) | **GET** /workorders/{workorderId}/partsUsage | Retrieve work order parts usage |
| [**WorkordersworkorderIdParts_0**](PartsApi.md#workordersworkorderidparts_0) | **PUT** /workorders/{workorderId}/parts | Update Work order parts |
| [**WorkordersworkorderIdParts_1**](PartsApi.md#workordersworkorderidparts_1) | **POST** /workorders/{workorderId}/parts | Create Work order parts |
| [**WorkordersworkorderIdPartsids0ids0ids1ids1**](PartsApi.md#workordersworkorderidpartsids0ids0ids1ids1) | **DELETE** /workorders/{workorderId}/parts | Delete Work order parts |
| [**WorkordersworkorderIdincludeConnectorPartsPartsV1**](PartsApi.md#workordersworkorderidincludeconnectorpartspartsv1) | **GET** /workorders/{workorderId}/{includeConnectorParts}/partsV1 | Get a Work order parts |

<a id="partsistechcertificationusedonrefrigeranttrackingauthuseridauthuseridtechnicianidtechnicianidcertificationnumbercertificationnumber"></a>
# **PartsIsTechCertificationUsedOnRefrigerantTrackingauthUserIdauthUserIdtechnicianIdtechnicianIdcertificationNumbercertificationNumber**
> SCServiceChannelServicesMessagingAssetsTechnicianAssociatedResponse PartsIsTechCertificationUsedOnRefrigerantTrackingauthUserIdauthUserIdtechnicianIdtechnicianIdcertificationNumbercertificationNumber (long authUserId, int technicianId, string certificationNumber)

Verifies that user is associated with parts usage

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class PartsIsTechCertificationUsedOnRefrigerantTrackingauthUserIdauthUserIdtechnicianIdtechnicianIdcertificationNumbercertificationNumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PartsApi(config);
            var authUserId = 789L;  // long | 
            var technicianId = 56;  // int | 
            var certificationNumber = "certificationNumber_example";  // string | 

            try
            {
                // Verifies that user is associated with parts usage
                SCServiceChannelServicesMessagingAssetsTechnicianAssociatedResponse result = apiInstance.PartsIsTechCertificationUsedOnRefrigerantTrackingauthUserIdauthUserIdtechnicianIdtechnicianIdcertificationNumbercertificationNumber(authUserId, technicianId, certificationNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PartsApi.PartsIsTechCertificationUsedOnRefrigerantTrackingauthUserIdauthUserIdtechnicianIdtechnicianIdcertificationNumbercertificationNumber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PartsIsTechCertificationUsedOnRefrigerantTrackingauthUserIdauthUserIdtechnicianIdtechnicianIdcertificationNumbercertificationNumberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Verifies that user is associated with parts usage
    ApiResponse<SCServiceChannelServicesMessagingAssetsTechnicianAssociatedResponse> response = apiInstance.PartsIsTechCertificationUsedOnRefrigerantTrackingauthUserIdauthUserIdtechnicianIdtechnicianIdcertificationNumbercertificationNumberWithHttpInfo(authUserId, technicianId, certificationNumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PartsApi.PartsIsTechCertificationUsedOnRefrigerantTrackingauthUserIdauthUserIdtechnicianIdtechnicianIdcertificationNumbercertificationNumberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authUserId** | **long** |  |  |
| **technicianId** | **int** |  |  |
| **certificationNumber** | **string** |  |  |

### Return type

[**SCServiceChannelServicesMessagingAssetsTechnicianAssociatedResponse**](SCServiceChannelServicesMessagingAssetsTechnicianAssociatedResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Error while processing request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersinventorypartsbulkpartusage"></a>
# **WorkordersInventoryPartsBulkPartUsage**
> void WorkordersInventoryPartsBulkPartUsage (SCServiceChannelServicesMessagingRefrigerantTrackingWorkOrderPartRefrigerantBulkChangeRequest request)

Inventory part user record bulk change

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersInventoryPartsBulkPartUsageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PartsApi(config);
            var request = new SCServiceChannelServicesMessagingRefrigerantTrackingWorkOrderPartRefrigerantBulkChangeRequest(); // SCServiceChannelServicesMessagingRefrigerantTrackingWorkOrderPartRefrigerantBulkChangeRequest | 

            try
            {
                // Inventory part user record bulk change
                apiInstance.WorkordersInventoryPartsBulkPartUsage(request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PartsApi.WorkordersInventoryPartsBulkPartUsage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersInventoryPartsBulkPartUsageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Inventory part user record bulk change
    apiInstance.WorkordersInventoryPartsBulkPartUsageWithHttpInfo(request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PartsApi.WorkordersInventoryPartsBulkPartUsageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingRefrigerantTrackingWorkOrderPartRefrigerantBulkChangeRequest**](SCServiceChannelServicesMessagingRefrigerantTrackingWorkOrderPartRefrigerantBulkChangeRequest.md) |  |  |

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
| **200** | Indicates that the request succeeded. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **500** | Error while processing request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidinventoryrefrigerantusage"></a>
# **WorkordersworkorderIdInventoryRefrigerantusage**
> SCServiceChannelServicesMessagingPartsRefrigerantUsageResponse WorkordersworkorderIdInventoryRefrigerantusage (int workorderId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdInventoryRefrigerantusageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PartsApi(config);
            var workorderId = 56;  // int | 

            try
            {
                SCServiceChannelServicesMessagingPartsRefrigerantUsageResponse result = apiInstance.WorkordersworkorderIdInventoryRefrigerantusage(workorderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PartsApi.WorkordersworkorderIdInventoryRefrigerantusage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdInventoryRefrigerantusageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SCServiceChannelServicesMessagingPartsRefrigerantUsageResponse> response = apiInstance.WorkordersworkorderIdInventoryRefrigerantusageWithHttpInfo(workorderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PartsApi.WorkordersworkorderIdInventoryRefrigerantusageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** |  |  |

### Return type

[**SCServiceChannelServicesMessagingPartsRefrigerantUsageResponse**](SCServiceChannelServicesMessagingPartsRefrigerantUsageResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.&lt;br&gt;Error codes:&lt;br&gt;502 - WorkOrder not found; |  -  |
| **401** | Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Error while processing request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidparts"></a>
# **WorkordersworkorderIdParts**
> List&lt;SCServiceChannelServicesMessagingWorkordersWorkOrderPartResponse&gt; WorkordersworkorderIdParts (int workorderId)

Get a Work order parts

Get a Work order parts. Returns Work order parts collection for successful request.              <br /><br />Available for provider and subscriber usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdPartsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PartsApi(config);
            var workorderId = 56;  // int | The Work order identity

            try
            {
                // Get a Work order parts
                List<SCServiceChannelServicesMessagingWorkordersWorkOrderPartResponse> result = apiInstance.WorkordersworkorderIdParts(workorderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PartsApi.WorkordersworkorderIdParts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdPartsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a Work order parts
    ApiResponse<List<SCServiceChannelServicesMessagingWorkordersWorkOrderPartResponse>> response = apiInstance.WorkordersworkorderIdPartsWithHttpInfo(workorderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PartsApi.WorkordersworkorderIdPartsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | The Work order identity |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingWorkordersWorkOrderPartResponse&gt;**](SCServiceChannelServicesMessagingWorkordersWorkOrderPartResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidpartsusage"></a>
# **WorkordersworkorderIdPartsUsage**
> List&lt;SCServiceChannelServicesMessagingRefrigerantTrackingWorkOrderPartRefrigerantResponse&gt; WorkordersworkorderIdPartsUsage (int workorderId)

Retrieve work order parts usage

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdPartsUsageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PartsApi(config);
            var workorderId = 56;  // int | 

            try
            {
                // Retrieve work order parts usage
                List<SCServiceChannelServicesMessagingRefrigerantTrackingWorkOrderPartRefrigerantResponse> result = apiInstance.WorkordersworkorderIdPartsUsage(workorderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PartsApi.WorkordersworkorderIdPartsUsage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdPartsUsageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve work order parts usage
    ApiResponse<List<SCServiceChannelServicesMessagingRefrigerantTrackingWorkOrderPartRefrigerantResponse>> response = apiInstance.WorkordersworkorderIdPartsUsageWithHttpInfo(workorderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PartsApi.WorkordersworkorderIdPartsUsageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** |  |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingRefrigerantTrackingWorkOrderPartRefrigerantResponse&gt;**](SCServiceChannelServicesMessagingRefrigerantTrackingWorkOrderPartRefrigerantResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.&lt;br&gt;Error codes:&lt;br&gt;502 - WorkOrder not found; |  -  |
| **401** | Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Error while processing request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidparts_0"></a>
# **WorkordersworkorderIdParts_0**
> void WorkordersworkorderIdParts_0 (int workorderId, SCServiceChannelServicesMessagingWorkordersUpdateWorkOrderPartsCollectionRequest request)

Update Work order parts

Available only for provider.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdParts_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PartsApi(config);
            var workorderId = 56;  // int | The Work order identity
            var request = new SCServiceChannelServicesMessagingWorkordersUpdateWorkOrderPartsCollectionRequest(); // SCServiceChannelServicesMessagingWorkordersUpdateWorkOrderPartsCollectionRequest | The Work order parts collection for update

            try
            {
                // Update Work order parts
                apiInstance.WorkordersworkorderIdParts_0(workorderId, request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PartsApi.WorkordersworkorderIdParts_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdParts_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Work order parts
    apiInstance.WorkordersworkorderIdParts_0WithHttpInfo(workorderId, request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PartsApi.WorkordersworkorderIdParts_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | The Work order identity |  |
| **request** | [**SCServiceChannelServicesMessagingWorkordersUpdateWorkOrderPartsCollectionRequest**](SCServiceChannelServicesMessagingWorkordersUpdateWorkOrderPartsCollectionRequest.md) | The Work order parts collection for update |  |

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
| **200** | Indicates that the request succeeded. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.&lt;br&gt;Error codes:&lt;br&gt;502 - WorkOrder not found; |  -  |
| **401** | Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Error while processing request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidparts_1"></a>
# **WorkordersworkorderIdParts_1**
> void WorkordersworkorderIdParts_1 (int workorderId, SCServiceChannelServicesMessagingWorkordersCreateWorkOrderPartsCollectionRequest requestModel)

Create Work order parts

Available only for provider.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdParts_1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PartsApi(config);
            var workorderId = 56;  // int | A new Work order identity
            var requestModel = new SCServiceChannelServicesMessagingWorkordersCreateWorkOrderPartsCollectionRequest(); // SCServiceChannelServicesMessagingWorkordersCreateWorkOrderPartsCollectionRequest | A new Work order parts collection

            try
            {
                // Create Work order parts
                apiInstance.WorkordersworkorderIdParts_1(workorderId, requestModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PartsApi.WorkordersworkorderIdParts_1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdParts_1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Work order parts
    apiInstance.WorkordersworkorderIdParts_1WithHttpInfo(workorderId, requestModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PartsApi.WorkordersworkorderIdParts_1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | A new Work order identity |  |
| **requestModel** | [**SCServiceChannelServicesMessagingWorkordersCreateWorkOrderPartsCollectionRequest**](SCServiceChannelServicesMessagingWorkordersCreateWorkOrderPartsCollectionRequest.md) | A new Work order parts collection |  |

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
| **201** | Indicates that the request succeeded. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.&lt;br&gt;Error codes:&lt;br&gt;502 - WorkOrder not found; |  -  |
| **401** | Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Error while processing request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidpartsids0ids0ids1ids1"></a>
# **WorkordersworkorderIdPartsids0ids0ids1ids1**
> void WorkordersworkorderIdPartsids0ids0ids1ids1 (int workorderId, List<int> ids)

Delete Work order parts

Available only for provider.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdPartsids0ids0ids1ids1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PartsApi(config);
            var workorderId = 56;  // int | The Work order identity
            var ids = new List<int>(); // List<int> | The Work order part identity collection for delete

            try
            {
                // Delete Work order parts
                apiInstance.WorkordersworkorderIdPartsids0ids0ids1ids1(workorderId, ids);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PartsApi.WorkordersworkorderIdPartsids0ids0ids1ids1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdPartsids0ids0ids1ids1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Work order parts
    apiInstance.WorkordersworkorderIdPartsids0ids0ids1ids1WithHttpInfo(workorderId, ids);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PartsApi.WorkordersworkorderIdPartsids0ids0ids1ids1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | The Work order identity |  |
| **ids** | [**List&lt;int&gt;**](int.md) | The Work order part identity collection for delete |  |

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
| **200** | Indicates that the request succeeded. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.&lt;br&gt;Error codes:&lt;br&gt;502 - WorkOrder not found; |  -  |
| **401** | Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Error while processing request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidincludeconnectorpartspartsv1"></a>
# **WorkordersworkorderIdincludeConnectorPartsPartsV1**
> List&lt;SCServiceChannelServicesMessagingWorkordersWorkOrderPartResponse&gt; WorkordersworkorderIdincludeConnectorPartsPartsV1 (int workorderId, bool includeConnectorParts)

Get a Work order parts

Get a Work order parts. Returns Work order parts collection for successful request.              <br /><br />Available for provider and subscriber usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdincludeConnectorPartsPartsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PartsApi(config);
            var workorderId = 56;  // int | The Work order identity
            var includeConnectorParts = false;  // bool | Include Connector Parts (default to false)

            try
            {
                // Get a Work order parts
                List<SCServiceChannelServicesMessagingWorkordersWorkOrderPartResponse> result = apiInstance.WorkordersworkorderIdincludeConnectorPartsPartsV1(workorderId, includeConnectorParts);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PartsApi.WorkordersworkorderIdincludeConnectorPartsPartsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdincludeConnectorPartsPartsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a Work order parts
    ApiResponse<List<SCServiceChannelServicesMessagingWorkordersWorkOrderPartResponse>> response = apiInstance.WorkordersworkorderIdincludeConnectorPartsPartsV1WithHttpInfo(workorderId, includeConnectorParts);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PartsApi.WorkordersworkorderIdincludeConnectorPartsPartsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | The Work order identity |  |
| **includeConnectorParts** | **bool** | Include Connector Parts | [default to false] |

### Return type

[**List&lt;SCServiceChannelServicesMessagingWorkordersWorkOrderPartResponse&gt;**](SCServiceChannelServicesMessagingWorkordersWorkOrderPartResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

