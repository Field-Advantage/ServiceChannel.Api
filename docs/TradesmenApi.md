# ServiceChannel.Api.Api.TradesmenApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Tradesmen**](TradesmenApi.md#tradesmen) | **POST** /tradesmen | Profile |

<a id="tradesmen"></a>
# **Tradesmen**
> void Tradesmen (SCServiceChannelServicesMessagingTradesmenCreateTradesmenProfileRequest request)

Profile

Creates Tradesman Profile. Returns Tradesman Profile Id for successful request.              <br /><br />Available for provider usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class TradesmenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TradesmenApi(config);
            var request = new SCServiceChannelServicesMessagingTradesmenCreateTradesmenProfileRequest(); // SCServiceChannelServicesMessagingTradesmenCreateTradesmenProfileRequest | A new Tradesmen Profile

            try
            {
                // Profile
                apiInstance.Tradesmen(request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradesmenApi.Tradesmen: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TradesmenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Profile
    apiInstance.TradesmenWithHttpInfo(request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TradesmenApi.TradesmenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingTradesmenCreateTradesmenProfileRequest**](SCServiceChannelServicesMessagingTradesmenCreateTradesmenProfileRequest.md) | A new Tradesmen Profile |  |

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
| **201** | Created indicates that the request resulted in a new resource created before the response was sent. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 503 - Invalid request; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **403** | Indicates that the server refuses to fulfill the request.              &lt;br/&gt;Error codes:              &lt;br/&gt; 100 - User has no rights to perform this action; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

