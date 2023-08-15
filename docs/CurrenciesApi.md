# ServiceChannel.Api.Api.CurrenciesApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CurrenciesCurrencyalphabeticcodecurrencyIdcurrencyId**](CurrenciesApi.md#currenciescurrencyalphabeticcodecurrencyidcurrencyid) | **GET** /currencies/currencyalphabeticcode | Get currency alphabetic code |

<a id="currenciescurrencyalphabeticcodecurrencyidcurrencyid"></a>
# **CurrenciesCurrencyalphabeticcodecurrencyIdcurrencyId**
> SCServiceChannelServicesMessagingCurrenciesGetAlphabeticalCodeResponse CurrenciesCurrencyalphabeticcodecurrencyIdcurrencyId (int currencyId)

Get currency alphabetic code

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class CurrenciesCurrencyalphabeticcodecurrencyIdcurrencyIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CurrenciesApi(config);
            var currencyId = 56;  // int | Unique Currency Identifier

            try
            {
                // Get currency alphabetic code
                SCServiceChannelServicesMessagingCurrenciesGetAlphabeticalCodeResponse result = apiInstance.CurrenciesCurrencyalphabeticcodecurrencyIdcurrencyId(currencyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CurrenciesApi.CurrenciesCurrencyalphabeticcodecurrencyIdcurrencyId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CurrenciesCurrencyalphabeticcodecurrencyIdcurrencyIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get currency alphabetic code
    ApiResponse<SCServiceChannelServicesMessagingCurrenciesGetAlphabeticalCodeResponse> response = apiInstance.CurrenciesCurrencyalphabeticcodecurrencyIdcurrencyIdWithHttpInfo(currencyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CurrenciesApi.CurrenciesCurrencyalphabeticcodecurrencyIdcurrencyIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **currencyId** | **int** | Unique Currency Identifier |  |

### Return type

[**SCServiceChannelServicesMessagingCurrenciesGetAlphabeticalCodeResponse**](SCServiceChannelServicesMessagingCurrenciesGetAlphabeticalCodeResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              503 — Invalid request |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **404** | The requested resource does not exist on the server. |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

