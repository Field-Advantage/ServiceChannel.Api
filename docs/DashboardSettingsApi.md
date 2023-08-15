# ServiceChannel.Api.Api.DashboardSettingsApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DashboardsettingsFeedbacksetupsetupId**](DashboardSettingsApi.md#dashboardsettingsfeedbacksetupsetupid) | **GET** /dashboardsettings/feedbacksetup/{setupId} | Get Feedback Setup |
| [**DashboardsettingsNotesetupsetupId**](DashboardSettingsApi.md#dashboardsettingsnotesetupsetupid) | **GET** /dashboardsettings/notesetup/{setupId} | Get Dashboard Note Setup |
| [**DashboardsettingsRequestsetup**](DashboardSettingsApi.md#dashboardsettingsrequestsetup) | **POST** /dashboardsettings/requestsetup | Get List Of Dashboard Service Request Setup |
| [**DashboardsettingsRequestsetupconfirm**](DashboardSettingsApi.md#dashboardsettingsrequestsetupconfirm) | **POST** /dashboardsettings/requestsetupconfirm | Get List Of Dashboard Service Request Confirmation Setup |
| [**DashboardsettingsRequestsetupconfirmsetupId**](DashboardSettingsApi.md#dashboardsettingsrequestsetupconfirmsetupid) | **GET** /dashboardsettings/requestsetupconfirm/{setupId} | Get Dashboard Service Request Confirmation Setup |
| [**DashboardsettingsRequestsetupsetupId**](DashboardSettingsApi.md#dashboardsettingsrequestsetupsetupid) | **GET** /dashboardsettings/requestsetup/{setupId} | Get Dashboard Service Request Setup |
| [**DashboardsettingsSetupgeneralsubscriberIdsetupId**](DashboardSettingsApi.md#dashboardsettingssetupgeneralsubscriberidsetupid) | **GET** /dashboardsettings/setupgeneral/{subscriberId}/{setupId} | Get Dashboard Setup General |

<a id="dashboardsettingsfeedbacksetupsetupid"></a>
# **DashboardsettingsFeedbacksetupsetupId**
> SCServiceChannelServicesMessagingDashboardSettingsSetupFeedbackResponse DashboardsettingsFeedbacksetupsetupId (int setupId)

Get Feedback Setup

Returns a Feedback Setup for Dashboard

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class DashboardsettingsFeedbacksetupsetupIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DashboardSettingsApi(config);
            var setupId = 56;  // int | The numeric identifier of the Dashboard Setup Id.

            try
            {
                // Get Feedback Setup
                SCServiceChannelServicesMessagingDashboardSettingsSetupFeedbackResponse result = apiInstance.DashboardsettingsFeedbacksetupsetupId(setupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardSettingsApi.DashboardsettingsFeedbacksetupsetupId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DashboardsettingsFeedbacksetupsetupIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Feedback Setup
    ApiResponse<SCServiceChannelServicesMessagingDashboardSettingsSetupFeedbackResponse> response = apiInstance.DashboardsettingsFeedbacksetupsetupIdWithHttpInfo(setupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardSettingsApi.DashboardsettingsFeedbacksetupsetupIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **setupId** | **int** | The numeric identifier of the Dashboard Setup Id. |  |

### Return type

[**SCServiceChannelServicesMessagingDashboardSettingsSetupFeedbackResponse**](SCServiceChannelServicesMessagingDashboardSettingsSetupFeedbackResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              504 - API call rejected by security permissions; |  -  |
| **403** | Access denied.              &lt;br&gt;Error codes:              1000 - The setupId does not belong to the Subscriber; |  -  |
| **404** | Indicates that the requested resource does not exist on the server. |  -  |
| **500** | The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 - Unspecified internal server error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="dashboardsettingsnotesetupsetupid"></a>
# **DashboardsettingsNotesetupsetupId**
> SCServiceChannelServicesMessagingDashboardSettingsSetupNoteResponse DashboardsettingsNotesetupsetupId (int setupId)

Get Dashboard Note Setup

Returns a Note Setup for Dashboard

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class DashboardsettingsNotesetupsetupIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DashboardSettingsApi(config);
            var setupId = 56;  // int | The numeric identifier of the Dashboard Setup Id.

            try
            {
                // Get Dashboard Note Setup
                SCServiceChannelServicesMessagingDashboardSettingsSetupNoteResponse result = apiInstance.DashboardsettingsNotesetupsetupId(setupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardSettingsApi.DashboardsettingsNotesetupsetupId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DashboardsettingsNotesetupsetupIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Dashboard Note Setup
    ApiResponse<SCServiceChannelServicesMessagingDashboardSettingsSetupNoteResponse> response = apiInstance.DashboardsettingsNotesetupsetupIdWithHttpInfo(setupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardSettingsApi.DashboardsettingsNotesetupsetupIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **setupId** | **int** | The numeric identifier of the Dashboard Setup Id. |  |

### Return type

[**SCServiceChannelServicesMessagingDashboardSettingsSetupNoteResponse**](SCServiceChannelServicesMessagingDashboardSettingsSetupNoteResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              504 - API call rejected by security permissions; |  -  |
| **403** | Access denied.              &lt;br&gt;Error codes:              1000 - The setupId does not belong to the Subscriber; |  -  |
| **404** | Indicates that the requested resource does not exist on the server. |  -  |
| **500** | The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 - Unspecified internal server error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="dashboardsettingsrequestsetup"></a>
# **DashboardsettingsRequestsetup**
> List&lt;SCServiceChannelApiModelDashboardSettingsSetupRequest&gt; DashboardsettingsRequestsetup (List<int> setupIds)

Get List Of Dashboard Service Request Setup

Returns a List of Service Request Setup for Dashboard

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class DashboardsettingsRequestsetupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DashboardSettingsApi(config);
            var setupIds = new List<int>(); // List<int> | The list of numeric identifier of the Dashboard Setup Id.

            try
            {
                // Get List Of Dashboard Service Request Setup
                List<SCServiceChannelApiModelDashboardSettingsSetupRequest> result = apiInstance.DashboardsettingsRequestsetup(setupIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardSettingsApi.DashboardsettingsRequestsetup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DashboardsettingsRequestsetupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get List Of Dashboard Service Request Setup
    ApiResponse<List<SCServiceChannelApiModelDashboardSettingsSetupRequest>> response = apiInstance.DashboardsettingsRequestsetupWithHttpInfo(setupIds);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardSettingsApi.DashboardsettingsRequestsetupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **setupIds** | [**List&lt;int&gt;**](int.md) | The list of numeric identifier of the Dashboard Setup Id. |  |

### Return type

[**List&lt;SCServiceChannelApiModelDashboardSettingsSetupRequest&gt;**](SCServiceChannelApiModelDashboardSettingsSetupRequest.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              504 - API call rejected by security permissions; |  -  |
| **403** | Access denied.              &lt;br&gt;Error codes:              1000 - The setupId does not belong to the Subscriber; |  -  |
| **404** | Indicates that the requested resource does not exist on the server. |  -  |
| **500** | The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 - Unspecified internal server error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="dashboardsettingsrequestsetupconfirm"></a>
# **DashboardsettingsRequestsetupconfirm**
> List&lt;SCServiceChannelApiModelDashboardSettingsSetupRequestConfirm&gt; DashboardsettingsRequestsetupconfirm (List<int> setupIds)

Get List Of Dashboard Service Request Confirmation Setup

Returns a List of Service Request Confirmation Setup for Dashboard

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class DashboardsettingsRequestsetupconfirmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DashboardSettingsApi(config);
            var setupIds = new List<int>(); // List<int> | The list of numeric identifier of the Dashboard Setup Id.

            try
            {
                // Get List Of Dashboard Service Request Confirmation Setup
                List<SCServiceChannelApiModelDashboardSettingsSetupRequestConfirm> result = apiInstance.DashboardsettingsRequestsetupconfirm(setupIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardSettingsApi.DashboardsettingsRequestsetupconfirm: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DashboardsettingsRequestsetupconfirmWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get List Of Dashboard Service Request Confirmation Setup
    ApiResponse<List<SCServiceChannelApiModelDashboardSettingsSetupRequestConfirm>> response = apiInstance.DashboardsettingsRequestsetupconfirmWithHttpInfo(setupIds);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardSettingsApi.DashboardsettingsRequestsetupconfirmWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **setupIds** | [**List&lt;int&gt;**](int.md) | The list of numeric identifier of the Dashboard Setup Id. |  |

### Return type

[**List&lt;SCServiceChannelApiModelDashboardSettingsSetupRequestConfirm&gt;**](SCServiceChannelApiModelDashboardSettingsSetupRequestConfirm.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              504 - API call rejected by security permissions; |  -  |
| **403** | Access denied.              &lt;br&gt;Error codes:              1000 - The setupId does not belong to the Subscriber; |  -  |
| **404** | Indicates that the requested resource does not exist on the server. |  -  |
| **500** | The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 - Unspecified internal server error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="dashboardsettingsrequestsetupconfirmsetupid"></a>
# **DashboardsettingsRequestsetupconfirmsetupId**
> SCServiceChannelServicesMessagingDashboardSettingsSetupRequestConfirmResponse DashboardsettingsRequestsetupconfirmsetupId (int setupId)

Get Dashboard Service Request Confirmation Setup

Returns a Service Request Confirmation Setup for Dashboard

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class DashboardsettingsRequestsetupconfirmsetupIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DashboardSettingsApi(config);
            var setupId = 56;  // int | The numeric identifier of the Dashboard Setup Id.

            try
            {
                // Get Dashboard Service Request Confirmation Setup
                SCServiceChannelServicesMessagingDashboardSettingsSetupRequestConfirmResponse result = apiInstance.DashboardsettingsRequestsetupconfirmsetupId(setupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardSettingsApi.DashboardsettingsRequestsetupconfirmsetupId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DashboardsettingsRequestsetupconfirmsetupIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Dashboard Service Request Confirmation Setup
    ApiResponse<SCServiceChannelServicesMessagingDashboardSettingsSetupRequestConfirmResponse> response = apiInstance.DashboardsettingsRequestsetupconfirmsetupIdWithHttpInfo(setupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardSettingsApi.DashboardsettingsRequestsetupconfirmsetupIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **setupId** | **int** | The numeric identifier of the Dashboard Setup Id. |  |

### Return type

[**SCServiceChannelServicesMessagingDashboardSettingsSetupRequestConfirmResponse**](SCServiceChannelServicesMessagingDashboardSettingsSetupRequestConfirmResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              504 - API call rejected by security permissions; |  -  |
| **403** | Access denied.              &lt;br&gt;Error codes:              1000 - The setupId does not belong to the Subscriber; |  -  |
| **404** | Indicates that the requested resource does not exist on the server. |  -  |
| **500** | The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 - Unspecified internal server error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="dashboardsettingsrequestsetupsetupid"></a>
# **DashboardsettingsRequestsetupsetupId**
> SCServiceChannelServicesMessagingDashboardSettingsSetupRequestResponse DashboardsettingsRequestsetupsetupId (int setupId)

Get Dashboard Service Request Setup

Returns a Service Request Setup for Dashboard

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class DashboardsettingsRequestsetupsetupIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DashboardSettingsApi(config);
            var setupId = 56;  // int | The numeric identifier of the Dashboard Setup Id.

            try
            {
                // Get Dashboard Service Request Setup
                SCServiceChannelServicesMessagingDashboardSettingsSetupRequestResponse result = apiInstance.DashboardsettingsRequestsetupsetupId(setupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardSettingsApi.DashboardsettingsRequestsetupsetupId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DashboardsettingsRequestsetupsetupIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Dashboard Service Request Setup
    ApiResponse<SCServiceChannelServicesMessagingDashboardSettingsSetupRequestResponse> response = apiInstance.DashboardsettingsRequestsetupsetupIdWithHttpInfo(setupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardSettingsApi.DashboardsettingsRequestsetupsetupIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **setupId** | **int** | The numeric identifier of the Dashboard Setup Id. |  |

### Return type

[**SCServiceChannelServicesMessagingDashboardSettingsSetupRequestResponse**](SCServiceChannelServicesMessagingDashboardSettingsSetupRequestResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              504 - API call rejected by security permissions; |  -  |
| **403** | Access denied.              &lt;br&gt;Error codes:              1000 - The setupId does not belong to the Subscriber; |  -  |
| **404** | Indicates that the requested resource does not exist on the server. |  -  |
| **500** | The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 - Unspecified internal server error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="dashboardsettingssetupgeneralsubscriberidsetupid"></a>
# **DashboardsettingsSetupgeneralsubscriberIdsetupId**
> SCServiceChannelApiModelDashboardSettingsSetupGeneral DashboardsettingsSetupgeneralsubscriberIdsetupId (int subscriberId, int setupId)

Get Dashboard Setup General

Returns Setup General for Dashboard

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class DashboardsettingsSetupgeneralsubscriberIdsetupIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DashboardSettingsApi(config);
            var subscriberId = 56;  // int | Subscriber identifier.
            var setupId = 56;  // int | The identifier of the Dashboard Setup.

            try
            {
                // Get Dashboard Setup General
                SCServiceChannelApiModelDashboardSettingsSetupGeneral result = apiInstance.DashboardsettingsSetupgeneralsubscriberIdsetupId(subscriberId, setupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DashboardSettingsApi.DashboardsettingsSetupgeneralsubscriberIdsetupId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DashboardsettingsSetupgeneralsubscriberIdsetupIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Dashboard Setup General
    ApiResponse<SCServiceChannelApiModelDashboardSettingsSetupGeneral> response = apiInstance.DashboardsettingsSetupgeneralsubscriberIdsetupIdWithHttpInfo(subscriberId, setupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DashboardSettingsApi.DashboardsettingsSetupgeneralsubscriberIdsetupIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** | Subscriber identifier. |  |
| **setupId** | **int** | The identifier of the Dashboard Setup. |  |

### Return type

[**SCServiceChannelApiModelDashboardSettingsSetupGeneral**](SCServiceChannelApiModelDashboardSettingsSetupGeneral.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              504 - API call rejected by security permissions; |  -  |
| **404** | Indicates that the requested resource does not exist on the server. |  -  |
| **500** | The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 - Unspecified internal server error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

