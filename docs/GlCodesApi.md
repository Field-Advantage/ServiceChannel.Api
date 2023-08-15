# ServiceChannel.Api.Api.GlCodesApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GlCodesCreateGlCodeglCodeglCodetradetradecategorycategorylocationlocation**](GlCodesApi.md#glcodescreateglcodeglcodeglcodetradetradecategorycategorylocationlocation) | **POST** /GlCodes/CreateGlCode | Add a GL Code |
| [**GlCodesDeleteGlCodeglCodeglCodetradetradecategorycategorylocationlocation**](GlCodesApi.md#glcodesdeleteglcodeglcodeglcodetradetradecategorycategorylocationlocation) | **DELETE** /GlCodes/DeleteGlCode | Delete a GL Code |
| [**GlCodesGetApprovalCodeslocationIdlocationIdcategorycategory**](GlCodesApi.md#glcodesgetapprovalcodeslocationidlocationidcategorycategory) | **GET** /GlCodes/GetApprovalCodes | Get Approval codes |
| [**GlCodesGetGlCodelocationIdlocationIdtradetradecategorycategory**](GlCodesApi.md#glcodesgetglcodelocationidlocationidtradetradecategorycategory) | **GET** /GlCodes/GetGlCode | Get a GL Code |
| [**GlCodesRetrieveGlCodestradetradecategorycategorylocationlocation**](GlCodesApi.md#glcodesretrieveglcodestradetradecategorycategorylocationlocation) | **GET** /GlCodes/RetrieveGlCodes | Retrieve Gl Codes |
| [**GlCodesUpdateGlCodeglCodeglCodetradetradecategorycategorylocationlocation**](GlCodesApi.md#glcodesupdateglcodeglcodeglcodetradetradecategorycategorylocationlocation) | **PUT** /GlCodes/UpdateGlCode | Update a GL Code |

<a id="glcodescreateglcodeglcodeglcodetradetradecategorycategorylocationlocation"></a>
# **GlCodesCreateGlCodeglCodeglCodetradetradecategorycategorylocationlocation**
> Object GlCodesCreateGlCodeglCodeglCodetradetradecategorycategorylocationlocation (string glCode, string? trade = null, string? category = null, string? location = null)

Add a GL Code

Creates a GL Code with a new trade, category, or location.              <br />Send the [GET /GlCodes/RetrieveGlCodes](https://developer.servicechannel.com/swagger/ui/index?version=3#/GlCodes/GETv3_GlCodes_RetrieveGlCodes_trade__trade__category__category__location__location_) request to get the list of GL Codes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GlCodesCreateGlCodeglCodeglCodetradetradecategorycategorylocationlocationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GlCodesApi(config);
            var glCode = "glCode_example";  // string | Numeric identifier of a GL Code.
            var trade = "trade_example";  // string? | Trade name. A trade is an area of work for which a service is performed, such as LIGHTING, ALARMS, or ELECTRICAL. Maximum is 80 characters. (optional) 
            var category = "category_example";  // string? | Category name. A category is the overall classification of a work order, such as MAINTENANCE, REPAIR, or WARRANTY. Maximum is 50 characters. (optional) 
            var location = "location_example";  // string? | Store ID. The numeric identifier of the store in the client's system. Assigned by and unique per subscriber. (optional) 

            try
            {
                // Add a GL Code
                Object result = apiInstance.GlCodesCreateGlCodeglCodeglCodetradetradecategorycategorylocationlocation(glCode, trade, category, location);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GlCodesApi.GlCodesCreateGlCodeglCodeglCodetradetradecategorycategorylocationlocation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GlCodesCreateGlCodeglCodeglCodetradetradecategorycategorylocationlocationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a GL Code
    ApiResponse<Object> response = apiInstance.GlCodesCreateGlCodeglCodeglCodetradetradecategorycategorylocationlocationWithHttpInfo(glCode, trade, category, location);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GlCodesApi.GlCodesCreateGlCodeglCodeglCodetradetradecategorycategorylocationlocationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **glCode** | **string** | Numeric identifier of a GL Code. |  |
| **trade** | **string?** | Trade name. A trade is an area of work for which a service is performed, such as LIGHTING, ALARMS, or ELECTRICAL. Maximum is 80 characters. | [optional]  |
| **category** | **string?** | Category name. A category is the overall classification of a work order, such as MAINTENANCE, REPAIR, or WARRANTY. Maximum is 50 characters. | [optional]  |
| **location** | **string?** | Store ID. The numeric identifier of the store in the client&#39;s system. Assigned by and unique per subscriber. | [optional]  |

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
| **201** | The created GL Code ID is in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              401 — Invalid subsriber ID              606 — Location is not found              704 — Invalid trade value for the subscriber              705 — Invalid category value for the subscriber              706 — GL Code already exists |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="glcodesdeleteglcodeglcodeglcodetradetradecategorycategorylocationlocation"></a>
# **GlCodesDeleteGlCodeglCodeglCodetradetradecategorycategorylocationlocation**
> Object GlCodesDeleteGlCodeglCodeglCodetradetradecategorycategorylocationlocation (string glCode, string? trade = null, string? category = null, string? location = null)

Delete a GL Code

Removes the specified GL Code from the subscriber’s system. You need to specify all code parameters to delete it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GlCodesDeleteGlCodeglCodeglCodetradetradecategorycategorylocationlocationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GlCodesApi(config);
            var glCode = "glCode_example";  // string | Numeric identifier of a GL Code.
            var trade = "trade_example";  // string? | Trade name. A trade is an area of work for which a service is performed, such as LIGHTING, ALARMS, or ELECTRICAL. Maximum is 80 characters. (optional) 
            var category = "category_example";  // string? | Category name. A category is the overall classification of a work order, such as MAINTENANCE, REPAIR, or WARRANTY. Maximum is 50 characters. (optional) 
            var location = "location_example";  // string? | Store ID. The numeric identifier of the store in the client's system. Assigned by and unique per subscriber. (optional) 

            try
            {
                // Delete a GL Code
                Object result = apiInstance.GlCodesDeleteGlCodeglCodeglCodetradetradecategorycategorylocationlocation(glCode, trade, category, location);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GlCodesApi.GlCodesDeleteGlCodeglCodeglCodetradetradecategorycategorylocationlocation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GlCodesDeleteGlCodeglCodeglCodetradetradecategorycategorylocationlocationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a GL Code
    ApiResponse<Object> response = apiInstance.GlCodesDeleteGlCodeglCodeglCodetradetradecategorycategorylocationlocationWithHttpInfo(glCode, trade, category, location);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GlCodesApi.GlCodesDeleteGlCodeglCodeglCodetradetradecategorycategorylocationlocationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **glCode** | **string** | Numeric identifier of a GL Code. |  |
| **trade** | **string?** | Trade name. A trade is an area of work for which a service is performed, such as LIGHTING, ALARMS, or ELECTRICAL. Maximum is 80 characters. | [optional]  |
| **category** | **string?** | Category name. A category is the overall classification of a work order, such as MAINTENANCE, REPAIR, or WARRANTY. Maximum is 50 characters. | [optional]  |
| **location** | **string?** | Store ID. The numeric identifier of the store in the client&#39;s system. Assigned by and unique per subscriber. | [optional]  |

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
| **200** | The deleted GL Code ID is in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              401 — Invalid subsriber ID              606 — Location is not found              704 — Invalid trade value for the subscriber              705 — Invalid category value for the subscriber              707 — GL Code does not exist |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="glcodesgetapprovalcodeslocationidlocationidcategorycategory"></a>
# **GlCodesGetApprovalCodeslocationIdlocationIdcategorycategory**
> SCServiceChannelServicesMessagingApprovalCodesGetApprovalCodesWithOptionsResponse GlCodesGetApprovalCodeslocationIdlocationIdcategorycategory (int locationId, string category)

Get Approval codes

Gets the list of approval codes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GlCodesGetApprovalCodeslocationIdlocationIdcategorycategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GlCodesApi(config);
            var locationId = 56;  // int | Location Id. Numeric id of location.
            var category = "category_example";  // string | Category name. A category is the overall classification of a work order, such as MAINTENANCE, REPAIR, or WARRANTY. Maximum is 50 characters.

            try
            {
                // Get Approval codes
                SCServiceChannelServicesMessagingApprovalCodesGetApprovalCodesWithOptionsResponse result = apiInstance.GlCodesGetApprovalCodeslocationIdlocationIdcategorycategory(locationId, category);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GlCodesApi.GlCodesGetApprovalCodeslocationIdlocationIdcategorycategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GlCodesGetApprovalCodeslocationIdlocationIdcategorycategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Approval codes
    ApiResponse<SCServiceChannelServicesMessagingApprovalCodesGetApprovalCodesWithOptionsResponse> response = apiInstance.GlCodesGetApprovalCodeslocationIdlocationIdcategorycategoryWithHttpInfo(locationId, category);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GlCodesApi.GlCodesGetApprovalCodeslocationIdlocationIdcategorycategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | Location Id. Numeric id of location. |  |
| **category** | **string** | Category name. A category is the overall classification of a work order, such as MAINTENANCE, REPAIR, or WARRANTY. Maximum is 50 characters. |  |

### Return type

[**SCServiceChannelServicesMessagingApprovalCodesGetApprovalCodesWithOptionsResponse**](SCServiceChannelServicesMessagingApprovalCodesGetApprovalCodesWithOptionsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 503 - Request is empty or null. |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="glcodesgetglcodelocationidlocationidtradetradecategorycategory"></a>
# **GlCodesGetGlCodelocationIdlocationIdtradetradecategorycategory**
> SCServiceChannelServicesMessagingGlCodeGetGlCodeResponseMessage GlCodesGetGlCodelocationIdlocationIdtradetradecategorycategory (int locationId, string trade, string category)

Get a GL Code

Get a gl code from trade, category, location id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GlCodesGetGlCodelocationIdlocationIdtradetradecategorycategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GlCodesApi(config);
            var locationId = 56;  // int | Location ID. Numeric id of location.
            var trade = "trade_example";  // string | Trade name. A trade is an area of work for which a service is performed, such as LIGHTING, ALARMS, or ELECTRICAL. Maximum is 80 characters.
            var category = "category_example";  // string | Category name. A category is the overall classification of a work order, such as MAINTENANCE, REPAIR, or WARRANTY. Maximum is 50 characters.

            try
            {
                // Get a GL Code
                SCServiceChannelServicesMessagingGlCodeGetGlCodeResponseMessage result = apiInstance.GlCodesGetGlCodelocationIdlocationIdtradetradecategorycategory(locationId, trade, category);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GlCodesApi.GlCodesGetGlCodelocationIdlocationIdtradetradecategorycategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GlCodesGetGlCodelocationIdlocationIdtradetradecategorycategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a GL Code
    ApiResponse<SCServiceChannelServicesMessagingGlCodeGetGlCodeResponseMessage> response = apiInstance.GlCodesGetGlCodelocationIdlocationIdtradetradecategorycategoryWithHttpInfo(locationId, trade, category);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GlCodesApi.GlCodesGetGlCodelocationIdlocationIdtradetradecategorycategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | Location ID. Numeric id of location. |  |
| **trade** | **string** | Trade name. A trade is an area of work for which a service is performed, such as LIGHTING, ALARMS, or ELECTRICAL. Maximum is 80 characters. |  |
| **category** | **string** | Category name. A category is the overall classification of a work order, such as MAINTENANCE, REPAIR, or WARRANTY. Maximum is 50 characters. |  |

### Return type

[**SCServiceChannelServicesMessagingGlCodeGetGlCodeResponseMessage**](SCServiceChannelServicesMessagingGlCodeGetGlCodeResponseMessage.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 503 - Request is empty or null.              &lt;br/&gt; 601 — Invalid Location id. |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="glcodesretrieveglcodestradetradecategorycategorylocationlocation"></a>
# **GlCodesRetrieveGlCodestradetradecategorycategorylocationlocation**
> SCServiceChannelServicesMessagingGlCodeRetrieveGlCodesResponse GlCodesRetrieveGlCodestradetradecategorycategorylocationlocation (string? trade = null, string? category = null, string? location = null)

Retrieve Gl Codes

Returns GL Codes for the authorized subscriber.              <br />You can filter the codes by `trade`, `category`, and `location`.              <br />Navigate to ServiceChannel University to find out [how to manage GL Codes](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/557645834/Managing+GL+Codes).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GlCodesRetrieveGlCodestradetradecategorycategorylocationlocationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GlCodesApi(config);
            var trade = "trade_example";  // string? | Trade name. A trade is an area of work for which a service is performed, such as LIGHTING, ALARMS, or ELECTRICAL. Maximum is 80 characters. (optional) 
            var category = "category_example";  // string? | Category name. A category is the overall classification of a work order, such as MAINTENANCE, REPAIR, or WARRANTY. Maximum is 50 characters. (optional) 
            var location = "location_example";  // string? | Store ID. The numeric identifier of the store in the client's system. Assigned by and unique per subscriber. (optional) 

            try
            {
                // Retrieve Gl Codes
                SCServiceChannelServicesMessagingGlCodeRetrieveGlCodesResponse result = apiInstance.GlCodesRetrieveGlCodestradetradecategorycategorylocationlocation(trade, category, location);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GlCodesApi.GlCodesRetrieveGlCodestradetradecategorycategorylocationlocation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GlCodesRetrieveGlCodestradetradecategorycategorylocationlocationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Gl Codes
    ApiResponse<SCServiceChannelServicesMessagingGlCodeRetrieveGlCodesResponse> response = apiInstance.GlCodesRetrieveGlCodestradetradecategorycategorylocationlocationWithHttpInfo(trade, category, location);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GlCodesApi.GlCodesRetrieveGlCodestradetradecategorycategorylocationlocationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **trade** | **string?** | Trade name. A trade is an area of work for which a service is performed, such as LIGHTING, ALARMS, or ELECTRICAL. Maximum is 80 characters. | [optional]  |
| **category** | **string?** | Category name. A category is the overall classification of a work order, such as MAINTENANCE, REPAIR, or WARRANTY. Maximum is 50 characters. | [optional]  |
| **location** | **string?** | Store ID. The numeric identifier of the store in the client&#39;s system. Assigned by and unique per subscriber. | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingGlCodeRetrieveGlCodesResponse**](SCServiceChannelServicesMessagingGlCodeRetrieveGlCodesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Gl Codes are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              401 — Invalid subsriber ID |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **404** | The requested resource does not exist on the server.              &lt;br/&gt;Error codes:              502 — Not Found              502 — No GL Code exists for the query |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="glcodesupdateglcodeglcodeglcodetradetradecategorycategorylocationlocation"></a>
# **GlCodesUpdateGlCodeglCodeglCodetradetradecategorycategorylocationlocation**
> Object GlCodesUpdateGlCodeglCodeglCodetradetradecategorycategorylocationlocation (string glCode, string? trade = null, string? category = null, string? location = null)

Update a GL Code

Updates a GL Code number leaving the trade, category, and/or location of the code unchanged. You need to specify all code parameters to update it.              <br />Use the [POST /GlCodes/CreateGlCode](https://developer.servicechannel.com/swagger/ui/index?version=3#/GlCodes/POSTv3_GlCodes_CreateGlCode_glCode__glCode__trade__trade__category__category__location__location_) method to create a new GL Code.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GlCodesUpdateGlCodeglCodeglCodetradetradecategorycategorylocationlocationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GlCodesApi(config);
            var glCode = "glCode_example";  // string | Numeric identifier of a GL Code.
            var trade = "trade_example";  // string? | Trade name. A trade is an area of work for which a service is performed, such as LIGHTING, ALARMS, or ELECTRICAL. Maximum is 80 characters. (optional) 
            var category = "category_example";  // string? | Category name. A category is the overall classification of a work order, such as MAINTENANCE, REPAIR, or WARRANTY. Maximum is 50 characters. (optional) 
            var location = "location_example";  // string? | Store ID. The numeric identifier of the store in the client's system. Assigned by and unique per subscriber. (optional) 

            try
            {
                // Update a GL Code
                Object result = apiInstance.GlCodesUpdateGlCodeglCodeglCodetradetradecategorycategorylocationlocation(glCode, trade, category, location);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GlCodesApi.GlCodesUpdateGlCodeglCodeglCodetradetradecategorycategorylocationlocation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GlCodesUpdateGlCodeglCodeglCodetradetradecategorycategorylocationlocationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a GL Code
    ApiResponse<Object> response = apiInstance.GlCodesUpdateGlCodeglCodeglCodetradetradecategorycategorylocationlocationWithHttpInfo(glCode, trade, category, location);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GlCodesApi.GlCodesUpdateGlCodeglCodeglCodetradetradecategorycategorylocationlocationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **glCode** | **string** | Numeric identifier of a GL Code. |  |
| **trade** | **string?** | Trade name. A trade is an area of work for which a service is performed, such as LIGHTING, ALARMS, or ELECTRICAL. Maximum is 80 characters. | [optional]  |
| **category** | **string?** | Category name. A category is the overall classification of a work order, such as MAINTENANCE, REPAIR, or WARRANTY. Maximum is 50 characters. | [optional]  |
| **location** | **string?** | Store ID. The numeric identifier of the store in the client&#39;s system. Assigned by and unique per subscriber. | [optional]  |

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
| **200** | The updated GL Code ID is in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              401 — Invalid subsriber ID              606 — Location is not found              704 — Invalid trade value for the subscriber              705 — Invalid category value for the subscriber              707 — GL Code does not exist              708 — At least one field trade/category/location is required |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

