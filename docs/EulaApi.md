# ServiceChannel.Api.Api.EulaApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EulaAccept**](EulaApi.md#eulaaccept) | **POST** /eula/accept | Method to accept the EULA agreement |
| [**EulaAgreement**](EulaApi.md#eulaagreement) | **GET** /eula/agreement | Method to retrieve the EULA agreement |

<a id="eulaaccept"></a>
# **EulaAccept**
> void EulaAccept ()

Method to accept the EULA agreement

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class EulaAcceptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EulaApi(config);

            try
            {
                // Method to accept the EULA agreement
                apiInstance.EulaAccept();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EulaApi.EulaAccept: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EulaAcceptWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Method to accept the EULA agreement
    apiInstance.EulaAcceptWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EulaApi.EulaAcceptWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request succeeded and the eula agreement is accepted. |  -  |
| **403** | The user doesn&#39;t have permissions to accept the agreement. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="eulaagreement"></a>
# **EulaAgreement**
> SCServiceChannelServicesMessagingEulaEulaAgreement EulaAgreement ()

Method to retrieve the EULA agreement

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class EulaAgreementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EulaApi(config);

            try
            {
                // Method to retrieve the EULA agreement
                SCServiceChannelServicesMessagingEulaEulaAgreement result = apiInstance.EulaAgreement();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EulaApi.EulaAgreement: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EulaAgreementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Method to retrieve the EULA agreement
    ApiResponse<SCServiceChannelServicesMessagingEulaEulaAgreement> response = apiInstance.EulaAgreementWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EulaApi.EulaAgreementWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SCServiceChannelServicesMessagingEulaEulaAgreement**](SCServiceChannelServicesMessagingEulaEulaAgreement.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request succeeded and the eula agreement is returned. |  -  |
| **403** | The user doesn&#39;t have permissions to view the agreement text. |  -  |
| **502** | No agreement was found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

