# ServiceChannel.Api.Api.BatchRfpApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BatchRfpCreate**](BatchRfpApi.md#batchrfpcreate) | **POST** /BatchRfp/Create | CreateBatchRfpAsync |

<a id="batchrfpcreate"></a>
# **BatchRfpCreate**
> SCServiceChannelServicesMessagingBatchWorkOrderBatchCreateRfpResponse BatchRfpCreate (SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest batchRfpRequest)

CreateBatchRfpAsync

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class BatchRfpCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BatchRfpApi(config);
            var batchRfpRequest = new SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest(); // SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest | 

            try
            {
                // CreateBatchRfpAsync
                SCServiceChannelServicesMessagingBatchWorkOrderBatchCreateRfpResponse result = apiInstance.BatchRfpCreate(batchRfpRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchRfpApi.BatchRfpCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchRfpCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CreateBatchRfpAsync
    ApiResponse<SCServiceChannelServicesMessagingBatchWorkOrderBatchCreateRfpResponse> response = apiInstance.BatchRfpCreateWithHttpInfo(batchRfpRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchRfpApi.BatchRfpCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchRfpRequest** | [**SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest**](SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest.md) |  |  |

### Return type

[**SCServiceChannelServicesMessagingBatchWorkOrderBatchCreateRfpResponse**](SCServiceChannelServicesMessagingBatchWorkOrderBatchCreateRfpResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 502 - BatchNumber is empty;              &lt;br/&gt; 503 - Validation fails. Request is empty or null; |  -  |
| **401** | Requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions;  |  -  |
| **500** | Indicates that a generic error has occurred on the server.              &lt;br/&gt;Error codes:              &lt;br/&gt; 501 - Timeout expired. The timeout period elapsed prior to completion of the operation or the server is not responding. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

