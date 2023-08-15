# ServiceChannel.Api.Api.WeatherApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**WeatherEventTypessubscriberIdsubscriberId**](WeatherApi.md#weathereventtypessubscriberidsubscriberid) | **GET** /weather/eventTypes | Get list of available weather types |
| [**WeatherSubscribers**](WeatherApi.md#weathersubscribers) | **GET** /weather/subscribers | Get SubscriberIds With WeatherOverlayOnMap Feature Flag |

<a id="weathereventtypessubscriberidsubscriberid"></a>
# **WeatherEventTypessubscriberIdsubscriberId**
> List&lt;SCServiceChannelApiModelWorkordersWeatherEventType&gt; WeatherEventTypessubscriberIdsubscriberId (int? subscriberId = null)

Get list of available weather types

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WeatherEventTypessubscriberIdsubscriberIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WeatherApi(config);
            var subscriberId = 56;  // int? |  (optional) 

            try
            {
                // Get list of available weather types
                List<SCServiceChannelApiModelWorkordersWeatherEventType> result = apiInstance.WeatherEventTypessubscriberIdsubscriberId(subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WeatherApi.WeatherEventTypessubscriberIdsubscriberId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WeatherEventTypessubscriberIdsubscriberIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get list of available weather types
    ApiResponse<List<SCServiceChannelApiModelWorkordersWeatherEventType>> response = apiInstance.WeatherEventTypessubscriberIdsubscriberIdWithHttpInfo(subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WeatherApi.WeatherEventTypessubscriberIdsubscriberIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int?** |  | [optional]  |

### Return type

[**List&lt;SCServiceChannelApiModelWorkordersWeatherEventType&gt;**](SCServiceChannelApiModelWorkordersWeatherEventType.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br&gt; 504 - API call rejected by security permissions; |  -  |
| **404** | Indicates that the requested resource does not exist on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="weathersubscribers"></a>
# **WeatherSubscribers**
> Object WeatherSubscribers ()

Get SubscriberIds With WeatherOverlayOnMap Feature Flag

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WeatherSubscribersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WeatherApi(config);

            try
            {
                // Get SubscriberIds With WeatherOverlayOnMap Feature Flag
                Object result = apiInstance.WeatherSubscribers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WeatherApi.WeatherSubscribers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WeatherSubscribersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get SubscriberIds With WeatherOverlayOnMap Feature Flag
    ApiResponse<Object> response = apiInstance.WeatherSubscribersWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WeatherApi.WeatherSubscribersWithHttpInfo: " + e.Message);
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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              &lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

