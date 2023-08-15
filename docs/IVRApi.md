# ServiceChannel.Api.Api.IVRApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**IvrMessageMessageIdMessageIdLanguageLanguageSetupPhoneIdSetupPhoneId**](IVRApi.md#ivrmessagemessageidmessageidlanguagelanguagesetupphoneidsetupphoneid) | **GET** /ivr/message |  |
| [**OutboundGetphonesenvironmentenvironmentoutboundEventoutboundEvent**](IVRApi.md#outboundgetphonesenvironmentenvironmentoutboundeventoutboundevent) | **GET** /outbound/getphones |  |
| [**WorkordersworkorderIdLeakPartUseAvailableAmount**](IVRApi.md#workordersworkorderidleakpartuseavailableamount) | **GET** /workorders/{workorderId}/leakPartUseAvailableAmount |  |

<a id="ivrmessagemessageidmessageidlanguagelanguagesetupphoneidsetupphoneid"></a>
# **IvrMessageMessageIdMessageIdLanguageLanguageSetupPhoneIdSetupPhoneId**
> SCServiceChannelServicesMessagingIVRIvrMessageResponse IvrMessageMessageIdMessageIdLanguageLanguageSetupPhoneIdSetupPhoneId (string messageId, string language, int setupPhoneId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class IvrMessageMessageIdMessageIdLanguageLanguageSetupPhoneIdSetupPhoneIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IVRApi(config);
            var messageId = "messageId_example";  // string | 
            var language = "language_example";  // string | 
            var setupPhoneId = 56;  // int | 

            try
            {
                SCServiceChannelServicesMessagingIVRIvrMessageResponse result = apiInstance.IvrMessageMessageIdMessageIdLanguageLanguageSetupPhoneIdSetupPhoneId(messageId, language, setupPhoneId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IVRApi.IvrMessageMessageIdMessageIdLanguageLanguageSetupPhoneIdSetupPhoneId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IvrMessageMessageIdMessageIdLanguageLanguageSetupPhoneIdSetupPhoneIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SCServiceChannelServicesMessagingIVRIvrMessageResponse> response = apiInstance.IvrMessageMessageIdMessageIdLanguageLanguageSetupPhoneIdSetupPhoneIdWithHttpInfo(messageId, language, setupPhoneId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IVRApi.IvrMessageMessageIdMessageIdLanguageLanguageSetupPhoneIdSetupPhoneIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **string** |  |  |
| **language** | **string** |  |  |
| **setupPhoneId** | **int** |  |  |

### Return type

[**SCServiceChannelServicesMessagingIVRIvrMessageResponse**](SCServiceChannelServicesMessagingIVRIvrMessageResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.&lt;br&gt;Error codes:&lt;br&gt; 503 - Empty tracking number; |  -  |
| **401** | Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="outboundgetphonesenvironmentenvironmentoutboundeventoutboundevent"></a>
# **OutboundGetphonesenvironmentenvironmentoutboundEventoutboundEvent**
> Object OutboundGetphonesenvironmentenvironmentoutboundEventoutboundEvent (string environment, string outboundEvent)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class OutboundGetphonesenvironmentenvironmentoutboundEventoutboundEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IVRApi(config);
            var environment = "Prod";  // string | 
            var outboundEvent = "Unknown";  // string | 

            try
            {
                Object result = apiInstance.OutboundGetphonesenvironmentenvironmentoutboundEventoutboundEvent(environment, outboundEvent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IVRApi.OutboundGetphonesenvironmentenvironmentoutboundEventoutboundEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OutboundGetphonesenvironmentenvironmentoutboundEventoutboundEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.OutboundGetphonesenvironmentenvironmentoutboundEventoutboundEventWithHttpInfo(environment, outboundEvent);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IVRApi.OutboundGetphonesenvironmentenvironmentoutboundEventoutboundEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **environment** | **string** |  |  |
| **outboundEvent** | **string** |  |  |

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

<a id="workordersworkorderidleakpartuseavailableamount"></a>
# **WorkordersworkorderIdLeakPartUseAvailableAmount**
> SCServiceChannelServicesMessagingIVRIvrBaseResponse WorkordersworkorderIdLeakPartUseAvailableAmount (int workorderId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdLeakPartUseAvailableAmountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IVRApi(config);
            var workorderId = 56;  // int | 

            try
            {
                SCServiceChannelServicesMessagingIVRIvrBaseResponse result = apiInstance.WorkordersworkorderIdLeakPartUseAvailableAmount(workorderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IVRApi.WorkordersworkorderIdLeakPartUseAvailableAmount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdLeakPartUseAvailableAmountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SCServiceChannelServicesMessagingIVRIvrBaseResponse> response = apiInstance.WorkordersworkorderIdLeakPartUseAvailableAmountWithHttpInfo(workorderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IVRApi.WorkordersworkorderIdLeakPartUseAvailableAmountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** |  |  |

### Return type

[**SCServiceChannelServicesMessagingIVRIvrBaseResponse**](SCServiceChannelServicesMessagingIVRIvrBaseResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.&lt;br&gt;Error codes:&lt;br&gt; 503 - Empty tracking number; |  -  |
| **401** | Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

