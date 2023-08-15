# ServiceChannel.Api.Api.AlpApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AlpSubscribersubscriberIdPreference**](AlpApi.md#alpsubscribersubscriberidpreference) | **POST** /alp/subscriber/{subscriberId}/preference |  |
| [**AlpUseruserIdData**](AlpApi.md#alpuseruseriddata) | **GET** /alp/user/{userId}/data | User data |

<a id="alpsubscribersubscriberidpreference"></a>
# **AlpSubscribersubscriberIdPreference**
> Object AlpSubscribersubscriberIdPreference (string subscriberId, SCServiceChannelServicesMessagingLandingUpdateSubscriberLandingPreferenceRequest request)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AlpSubscribersubscriberIdPreferenceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AlpApi(config);
            var subscriberId = "subscriberId_example";  // string | 
            var request = new SCServiceChannelServicesMessagingLandingUpdateSubscriberLandingPreferenceRequest(); // SCServiceChannelServicesMessagingLandingUpdateSubscriberLandingPreferenceRequest | 

            try
            {
                Object result = apiInstance.AlpSubscribersubscriberIdPreference(subscriberId, request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlpApi.AlpSubscribersubscriberIdPreference: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AlpSubscribersubscriberIdPreferenceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.AlpSubscribersubscriberIdPreferenceWithHttpInfo(subscriberId, request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlpApi.AlpSubscribersubscriberIdPreferenceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **string** |  |  |
| **request** | [**SCServiceChannelServicesMessagingLandingUpdateSubscriberLandingPreferenceRequest**](SCServiceChannelServicesMessagingLandingUpdateSubscriberLandingPreferenceRequest.md) |  |  |

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

<a id="alpuseruseriddata"></a>
# **AlpUseruserIdData**
> SCServiceChannelServicesMessagingLandingUserLandingData AlpUseruserIdData (int userId)

User data

Returns user data from cache if presents or from db if cache doesn't contain user data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AlpUseruserIdDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AlpApi(config);
            var userId = 56;  // int | Numeric id of user.

            try
            {
                // User data
                SCServiceChannelServicesMessagingLandingUserLandingData result = apiInstance.AlpUseruserIdData(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlpApi.AlpUseruserIdData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AlpUseruserIdDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // User data
    ApiResponse<SCServiceChannelServicesMessagingLandingUserLandingData> response = apiInstance.AlpUseruserIdDataWithHttpInfo(userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlpApi.AlpUseruserIdDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **int** | Numeric id of user. |  |

### Return type

[**SCServiceChannelServicesMessagingLandingUserLandingData**](SCServiceChannelServicesMessagingLandingUserLandingData.md)

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
| **500** | Indicates that a generic error has occurred on the server.              &lt;br/&gt;Error codes:              &lt;br/&gt; 501 - AlpCacheKeyFormat is empty or undefined in configuration; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

