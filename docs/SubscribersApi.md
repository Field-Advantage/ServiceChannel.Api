# ServiceChannel.Api.Api.SubscribersApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Subscribers**](SubscribersApi.md#subscribers) | **POST** /subscribers | Create Subscriber |
| [**SubscribersCurrentDashboardssubscriberIdsubscriberId**](SubscribersApi.md#subscriberscurrentdashboardssubscriberidsubscriberid) | **GET** /subscribers/current/dashboards | Returns list of subscriber(current or specified) dashboards |
| [**SubscribersCurrentSubsidiaries**](SubscribersApi.md#subscriberscurrentsubsidiaries) | **GET** /subscribers/current/subsidiaries |  |
| [**SubscribersGetSubscribersRegionalSettings**](SubscribersApi.md#subscribersgetsubscribersregionalsettings) | **POST** /subscribers/GetSubscribersRegionalSettings | Returns regional settings for subscribers |
| [**SubscribersRulessubscriberIdsubscriberId**](SubscribersApi.md#subscribersrulessubscriberidsubscriberid) | **GET** /subscribers/rules | Returns list of subscriber properties |
| [**SubscribersTrades**](SubscribersApi.md#subscriberstrades) | **GET** /subscribers/trades | Retrieve Trades |
| [**SubscriberssubscriberId**](SubscribersApi.md#subscriberssubscriberid) | **GET** /subscribers/{subscriberId} | Get Subscriber by Id |
| [**SubscriberssubscriberIdDashboards**](SubscribersApi.md#subscriberssubscriberiddashboards) | **GET** /subscribers/{subscriberId}/dashboards | Returns list of subscriber(current or specified) dashboards |
| [**SubscriberssubscriberIdPrimarytrades**](SubscribersApi.md#subscriberssubscriberidprimarytrades) | **GET** /subscribers/{subscriberId}/primarytrades | Retrieve Trades |
| [**SubscriberssubscriberIdRules**](SubscribersApi.md#subscriberssubscriberidrules) | **GET** /subscribers/{subscriberId}/rules | Returns list of subscriber properties |
| [**SubscriberssubscriberIdSecurityrules**](SubscribersApi.md#subscriberssubscriberidsecurityrules) | **GET** /subscribers/{subscriberId}/securityrules | Security rules |
| [**SubscriberssubscriberIdTrades**](SubscribersApi.md#subscriberssubscriberidtrades) | **GET** /subscribers/{subscriberId}/trades | Retrieve Trades |
| [**SubscriberssubscriberIdValidatepasswordsecuritypassword**](SubscribersApi.md#subscriberssubscriberidvalidatepasswordsecuritypassword) | **GET** /subscribers/{subscriberId}/validatepasswordsecurity/{password} | Password security |
| [**SubscriberssubscriberIdWorkOrderRescheduleReasons**](SubscribersApi.md#subscriberssubscriberidworkorderreschedulereasons) | **GET** /subscribers/{subscriberId}/workOrderRescheduleReasons | Returns list of reschedule reasons |
| [**SubscriberssubscriberId_0**](SubscribersApi.md#subscriberssubscriberid_0) | **PUT** /subscribers/{subscriberId} | Update subscriber info |

<a id="subscribers"></a>
# **Subscribers**
> void Subscribers (SCServiceChannelServicesMessagingSubscribersRegisterSubscriberRequest registerSubscriberRequest)

Create Subscriber

Returns success result

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscribersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscribersApi(config);
            var registerSubscriberRequest = new SCServiceChannelServicesMessagingSubscribersRegisterSubscriberRequest(); // SCServiceChannelServicesMessagingSubscribersRegisterSubscriberRequest | Request for creation of new Subscriber

            try
            {
                // Create Subscriber
                apiInstance.Subscribers(registerSubscriberRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscribersApi.Subscribers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Subscriber
    apiInstance.SubscribersWithHttpInfo(registerSubscriberRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscribersApi.SubscribersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **registerSubscriberRequest** | [**SCServiceChannelServicesMessagingSubscribersRegisterSubscriberRequest**](SCServiceChannelServicesMessagingSubscribersRegisterSubscriberRequest.md) | Request for creation of new Subscriber |  |

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
| **201** | Indicates that the request succeeded and that a new Subscriber is created. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that an error has occured wile creation of a new Subscriber. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscriberscurrentdashboardssubscriberidsubscriberid"></a>
# **SubscribersCurrentDashboardssubscriberIdsubscriberId**
> List&lt;SCServiceChannelServicesMessagingSubscribersDashboardInfo&gt; SubscribersCurrentDashboardssubscriberIdsubscriberId (int? subscriberId = null)

Returns list of subscriber(current or specified) dashboards

Available for subscriber users. Returns list of subscriber dashboards (current or specified subscriber if allowed)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscribersCurrentDashboardssubscriberIdsubscriberIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscribersApi(config);
            var subscriberId = 56;  // int? | Subscriber identifier (optional) 

            try
            {
                // Returns list of subscriber(current or specified) dashboards
                List<SCServiceChannelServicesMessagingSubscribersDashboardInfo> result = apiInstance.SubscribersCurrentDashboardssubscriberIdsubscriberId(subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscribersApi.SubscribersCurrentDashboardssubscriberIdsubscriberId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribersCurrentDashboardssubscriberIdsubscriberIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns list of subscriber(current or specified) dashboards
    ApiResponse<List<SCServiceChannelServicesMessagingSubscribersDashboardInfo>> response = apiInstance.SubscribersCurrentDashboardssubscriberIdsubscriberIdWithHttpInfo(subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscribersApi.SubscribersCurrentDashboardssubscriberIdsubscriberIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int?** | Subscriber identifier | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingSubscribersDashboardInfo&gt;**](SCServiceChannelServicesMessagingSubscribersDashboardInfo.md)

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
| **401** | Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br&gt; 504 - API call rejected by security permissions; |  -  |
| **403** | Indicates that the requested resource not allowed for current user |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscriberscurrentsubsidiaries"></a>
# **SubscribersCurrentSubsidiaries**
> Object SubscribersCurrentSubsidiaries ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscribersCurrentSubsidiariesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscribersApi(config);

            try
            {
                Object result = apiInstance.SubscribersCurrentSubsidiaries();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscribersApi.SubscribersCurrentSubsidiaries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribersCurrentSubsidiariesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.SubscribersCurrentSubsidiariesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscribersApi.SubscribersCurrentSubsidiariesWithHttpInfo: " + e.Message);
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

<a id="subscribersgetsubscribersregionalsettings"></a>
# **SubscribersGetSubscribersRegionalSettings**
> SCServiceChannelServicesMessagingSubscribersGetSubscribersRegionalSettingsResponse SubscribersGetSubscribersRegionalSettings (SCServiceChannelServicesMessagingSubscribersGetSubscribersRegionalSettingsRequest request)

Returns regional settings for subscribers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscribersGetSubscribersRegionalSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscribersApi(config);
            var request = new SCServiceChannelServicesMessagingSubscribersGetSubscribersRegionalSettingsRequest(); // SCServiceChannelServicesMessagingSubscribersGetSubscribersRegionalSettingsRequest | list of subscriber

            try
            {
                // Returns regional settings for subscribers
                SCServiceChannelServicesMessagingSubscribersGetSubscribersRegionalSettingsResponse result = apiInstance.SubscribersGetSubscribersRegionalSettings(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscribersApi.SubscribersGetSubscribersRegionalSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribersGetSubscribersRegionalSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns regional settings for subscribers
    ApiResponse<SCServiceChannelServicesMessagingSubscribersGetSubscribersRegionalSettingsResponse> response = apiInstance.SubscribersGetSubscribersRegionalSettingsWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscribersApi.SubscribersGetSubscribersRegionalSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingSubscribersGetSubscribersRegionalSettingsRequest**](SCServiceChannelServicesMessagingSubscribersGetSubscribersRegionalSettingsRequest.md) | list of subscriber |  |

### Return type

[**SCServiceChannelServicesMessagingSubscribersGetSubscribersRegionalSettingsResponse**](SCServiceChannelServicesMessagingSubscribersGetSubscribersRegionalSettingsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              &lt;br&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server.              &lt;br/&gt;Error codes:              &lt;br/&gt; 501 - Unhandled exception occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscribersrulessubscriberidsubscriberid"></a>
# **SubscribersRulessubscriberIdsubscriberId**
> SCServiceChannelServicesMessagingSubscribersGetSubscriberPropertyResponse SubscribersRulessubscriberIdsubscriberId (int? subscriberId = null)

Returns list of subscriber properties

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscribersRulessubscriberIdsubscriberIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscribersApi(config);
            var subscriberId = 56;  // int? | subscriber identifier (optional) 

            try
            {
                // Returns list of subscriber properties
                SCServiceChannelServicesMessagingSubscribersGetSubscriberPropertyResponse result = apiInstance.SubscribersRulessubscriberIdsubscriberId(subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscribersApi.SubscribersRulessubscriberIdsubscriberId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribersRulessubscriberIdsubscriberIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns list of subscriber properties
    ApiResponse<SCServiceChannelServicesMessagingSubscribersGetSubscriberPropertyResponse> response = apiInstance.SubscribersRulessubscriberIdsubscriberIdWithHttpInfo(subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscribersApi.SubscribersRulessubscriberIdsubscriberIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int?** | subscriber identifier | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingSubscribersGetSubscriberPropertyResponse**](SCServiceChannelServicesMessagingSubscribersGetSubscriberPropertyResponse.md)

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
| **401** | Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscriberstrades"></a>
# **SubscribersTrades**
> SCServiceChannelServicesMessagingTradeGetSubscriberTradesResponse SubscribersTrades ()

Retrieve Trades

Returns the current subscriber's trade list ( IDs ).              <br /><br />This method can only be used for subscriber's users.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscribersTradesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscribersApi(config);

            try
            {
                // Retrieve Trades
                SCServiceChannelServicesMessagingTradeGetSubscriberTradesResponse result = apiInstance.SubscribersTrades();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscribersApi.SubscribersTrades: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribersTradesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Trades
    ApiResponse<SCServiceChannelServicesMessagingTradeGetSubscriberTradesResponse> response = apiInstance.SubscribersTradesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscribersApi.SubscribersTradesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SCServiceChannelServicesMessagingTradeGetSubscriberTradesResponse**](SCServiceChannelServicesMessagingTradeGetSubscriberTradesResponse.md)

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

<a id="subscriberssubscriberid"></a>
# **SubscriberssubscriberId**
> void SubscriberssubscriberId (int subscriberId)

Get Subscriber by Id

Returns success result

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscriberssubscriberIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscribersApi(config);
            var subscriberId = 56;  // int | 

            try
            {
                // Get Subscriber by Id
                apiInstance.SubscriberssubscriberId(subscriberId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscribersApi.SubscriberssubscriberId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriberssubscriberIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Subscriber by Id
    apiInstance.SubscriberssubscriberIdWithHttpInfo(subscriberId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscribersApi.SubscriberssubscriberIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** |  |  |

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
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscriberssubscriberiddashboards"></a>
# **SubscriberssubscriberIdDashboards**
> List&lt;SCServiceChannelServicesMessagingSubscribersDashboardInfo&gt; SubscriberssubscriberIdDashboards (int subscriberId)

Returns list of subscriber(current or specified) dashboards

Available for subscriber users. Returns list of subscriber dashboards (current or specified subscriber if allowed)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscriberssubscriberIdDashboardsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscribersApi(config);
            var subscriberId = 56;  // int | Subscriber identifier

            try
            {
                // Returns list of subscriber(current or specified) dashboards
                List<SCServiceChannelServicesMessagingSubscribersDashboardInfo> result = apiInstance.SubscriberssubscriberIdDashboards(subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscribersApi.SubscriberssubscriberIdDashboards: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriberssubscriberIdDashboardsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns list of subscriber(current or specified) dashboards
    ApiResponse<List<SCServiceChannelServicesMessagingSubscribersDashboardInfo>> response = apiInstance.SubscriberssubscriberIdDashboardsWithHttpInfo(subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscribersApi.SubscriberssubscriberIdDashboardsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** | Subscriber identifier |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingSubscribersDashboardInfo&gt;**](SCServiceChannelServicesMessagingSubscribersDashboardInfo.md)

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
| **401** | Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br&gt; 504 - API call rejected by security permissions; |  -  |
| **403** | Indicates that the requested resource not allowed for current user |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscriberssubscriberidprimarytrades"></a>
# **SubscriberssubscriberIdPrimarytrades**
> void SubscriberssubscriberIdPrimarytrades (int subscriberId)

Retrieve Trades

Returns trade list of requested subscriber.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscriberssubscriberIdPrimarytradesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscribersApi(config);
            var subscriberId = 56;  // int | Numeric id of subscriber to perform action with.

            try
            {
                // Retrieve Trades
                apiInstance.SubscriberssubscriberIdPrimarytrades(subscriberId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscribersApi.SubscriberssubscriberIdPrimarytrades: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriberssubscriberIdPrimarytradesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Trades
    apiInstance.SubscriberssubscriberIdPrimarytradesWithHttpInfo(subscriberId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscribersApi.SubscriberssubscriberIdPrimarytradesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** | Numeric id of subscriber to perform action with. |  |

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
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscriberssubscriberidrules"></a>
# **SubscriberssubscriberIdRules**
> SCServiceChannelServicesMessagingSubscribersGetSubscriberPropertyResponse SubscriberssubscriberIdRules (int subscriberId)

Returns list of subscriber properties

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscriberssubscriberIdRulesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscribersApi(config);
            var subscriberId = 56;  // int | subscriber identifier

            try
            {
                // Returns list of subscriber properties
                SCServiceChannelServicesMessagingSubscribersGetSubscriberPropertyResponse result = apiInstance.SubscriberssubscriberIdRules(subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscribersApi.SubscriberssubscriberIdRules: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriberssubscriberIdRulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns list of subscriber properties
    ApiResponse<SCServiceChannelServicesMessagingSubscribersGetSubscriberPropertyResponse> response = apiInstance.SubscriberssubscriberIdRulesWithHttpInfo(subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscribersApi.SubscriberssubscriberIdRulesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** | subscriber identifier |  |

### Return type

[**SCServiceChannelServicesMessagingSubscribersGetSubscriberPropertyResponse**](SCServiceChannelServicesMessagingSubscribersGetSubscriberPropertyResponse.md)

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
| **401** | Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscriberssubscriberidsecurityrules"></a>
# **SubscriberssubscriberIdSecurityrules**
> Object SubscriberssubscriberIdSecurityrules (int subscriberId)

Security rules

Get security rules

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscriberssubscriberIdSecurityrulesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscribersApi(config);
            var subscriberId = 56;  // int | Numeric id of subscriber.

            try
            {
                // Security rules
                Object result = apiInstance.SubscriberssubscriberIdSecurityrules(subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscribersApi.SubscriberssubscriberIdSecurityrules: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriberssubscriberIdSecurityrulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Security rules
    ApiResponse<Object> response = apiInstance.SubscriberssubscriberIdSecurityrulesWithHttpInfo(subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscribersApi.SubscriberssubscriberIdSecurityrulesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** | Numeric id of subscriber. |  |

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

<a id="subscriberssubscriberidtrades"></a>
# **SubscriberssubscriberIdTrades**
> SCServiceChannelServicesMessagingTradeGetSubscriberTradesResponse SubscriberssubscriberIdTrades (int subscriberId)

Retrieve Trades

Returns trade list ( IDs ) of requested subscriber.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscriberssubscriberIdTradesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscribersApi(config);
            var subscriberId = 56;  // int | Numeric id of subscriber to perform action with.

            try
            {
                // Retrieve Trades
                SCServiceChannelServicesMessagingTradeGetSubscriberTradesResponse result = apiInstance.SubscriberssubscriberIdTrades(subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscribersApi.SubscriberssubscriberIdTrades: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriberssubscriberIdTradesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Trades
    ApiResponse<SCServiceChannelServicesMessagingTradeGetSubscriberTradesResponse> response = apiInstance.SubscriberssubscriberIdTradesWithHttpInfo(subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscribersApi.SubscriberssubscriberIdTradesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** | Numeric id of subscriber to perform action with. |  |

### Return type

[**SCServiceChannelServicesMessagingTradeGetSubscriberTradesResponse**](SCServiceChannelServicesMessagingTradeGetSubscriberTradesResponse.md)

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

<a id="subscriberssubscriberidvalidatepasswordsecuritypassword"></a>
# **SubscriberssubscriberIdValidatepasswordsecuritypassword**
> Object SubscriberssubscriberIdValidatepasswordsecuritypassword (int subscriberId, string password)

Password security

Validate password security

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscriberssubscriberIdValidatepasswordsecuritypasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscribersApi(config);
            var subscriberId = 56;  // int | Numeric id of subscriber.
            var password = "password_example";  // string | Password to be checked.

            try
            {
                // Password security
                Object result = apiInstance.SubscriberssubscriberIdValidatepasswordsecuritypassword(subscriberId, password);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscribersApi.SubscriberssubscriberIdValidatepasswordsecuritypassword: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriberssubscriberIdValidatepasswordsecuritypasswordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Password security
    ApiResponse<Object> response = apiInstance.SubscriberssubscriberIdValidatepasswordsecuritypasswordWithHttpInfo(subscriberId, password);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscribersApi.SubscriberssubscriberIdValidatepasswordsecuritypasswordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** | Numeric id of subscriber. |  |
| **password** | **string** | Password to be checked. |  |

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

<a id="subscriberssubscriberidworkorderreschedulereasons"></a>
# **SubscriberssubscriberIdWorkOrderRescheduleReasons**
> Dictionary&lt;string, string&gt; SubscriberssubscriberIdWorkOrderRescheduleReasons (int subscriberId)

Returns list of reschedule reasons

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscriberssubscriberIdWorkOrderRescheduleReasonsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscribersApi(config);
            var subscriberId = 56;  // int | subscriber identifier

            try
            {
                // Returns list of reschedule reasons
                Dictionary<string, string> result = apiInstance.SubscriberssubscriberIdWorkOrderRescheduleReasons(subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscribersApi.SubscriberssubscriberIdWorkOrderRescheduleReasons: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriberssubscriberIdWorkOrderRescheduleReasonsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns list of reschedule reasons
    ApiResponse<Dictionary<string, string>> response = apiInstance.SubscriberssubscriberIdWorkOrderRescheduleReasonsWithHttpInfo(subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscribersApi.SubscriberssubscriberIdWorkOrderRescheduleReasonsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** | subscriber identifier |  |

### Return type

**Dictionary<string, string>**

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
| **401** | Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscriberssubscriberid_0"></a>
# **SubscriberssubscriberId_0**
> void SubscriberssubscriberId_0 (int subscriberId, SCServiceChannelServicesMessagingSubscribersUpdateSubscriberInfoRequest subscriberInfo)

Update subscriber info

Acceptable values for DateFormat are: \"MMM d, yyyy\" or \"d, MMM yyyy\". Acceptable values for TimeFormat are: \"H:mm\" or \"h:mm\". Default values are \"MMM d, yyyy\" and \"H:mm\" correspondingly.              Acceptable valuer for DecimalSeparator are: \".\" or \",\". Default value is point.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscriberssubscriberId_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscribersApi(config);
            var subscriberId = 56;  // int | Subscriber identifier
            var subscriberInfo = new SCServiceChannelServicesMessagingSubscribersUpdateSubscriberInfoRequest(); // SCServiceChannelServicesMessagingSubscribersUpdateSubscriberInfoRequest | Subscriber info

            try
            {
                // Update subscriber info
                apiInstance.SubscriberssubscriberId_0(subscriberId, subscriberInfo);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscribersApi.SubscriberssubscriberId_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriberssubscriberId_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update subscriber info
    apiInstance.SubscriberssubscriberId_0WithHttpInfo(subscriberId, subscriberInfo);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscribersApi.SubscriberssubscriberId_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** | Subscriber identifier |  |
| **subscriberInfo** | [**SCServiceChannelServicesMessagingSubscribersUpdateSubscriberInfoRequest**](SCServiceChannelServicesMessagingSubscribersUpdateSubscriberInfoRequest.md) | Subscriber info |  |

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
| **200** | Indicates that the request succeeded |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

