# ServiceChannel.Api.Api.BrokerApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BrokerClientAccessProvidersproviderId**](BrokerApi.md#brokerclientaccessprovidersproviderid) | **GET** /broker/client/access/providers/{providerId} | Validates if external client has access to the specified provider |

<a id="brokerclientaccessprovidersproviderid"></a>
# **BrokerClientAccessProvidersproviderId**
> SCServiceChannelServicesBrokerCommonApiModelsAccessDto BrokerClientAccessProvidersproviderId (int providerId)

Validates if external client has access to the specified provider

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class BrokerClientAccessProvidersproviderIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BrokerApi(config);
            var providerId = 56;  // int | Provider Id

            try
            {
                // Validates if external client has access to the specified provider
                SCServiceChannelServicesBrokerCommonApiModelsAccessDto result = apiInstance.BrokerClientAccessProvidersproviderId(providerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrokerApi.BrokerClientAccessProvidersproviderId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BrokerClientAccessProvidersproviderIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Validates if external client has access to the specified provider
    ApiResponse<SCServiceChannelServicesBrokerCommonApiModelsAccessDto> response = apiInstance.BrokerClientAccessProvidersproviderIdWithHttpInfo(providerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BrokerApi.BrokerClientAccessProvidersproviderIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **providerId** | **int** | Provider Id |  |

### Return type

[**SCServiceChannelServicesBrokerCommonApiModelsAccessDto**](SCServiceChannelServicesBrokerCommonApiModelsAccessDto.md)

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
| **401** | The request is not authorized. |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

