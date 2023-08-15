# ServiceChannel.Api.Api.LanguagesApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**LanguagesUpdateLanguageSetting**](LanguagesApi.md#languagesupdatelanguagesetting) | **POST** /languages/updateLanguageSetting | Set language for subscriber or provider |

<a id="languagesupdatelanguagesetting"></a>
# **LanguagesUpdateLanguageSetting**
> void LanguagesUpdateLanguageSetting (SCServiceChannelServicesMessagingLanguagesUpdateLanguagesRequest request)

Set language for subscriber or provider

Update a language setting for subscriber or provider.               <br /> ***Note***: This method is available to *Provider Directory (aka Fixxbook)* users only.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LanguagesUpdateLanguageSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LanguagesApi(config);
            var request = new SCServiceChannelServicesMessagingLanguagesUpdateLanguagesRequest(); // SCServiceChannelServicesMessagingLanguagesUpdateLanguagesRequest | 

            try
            {
                // Set language for subscriber or provider
                apiInstance.LanguagesUpdateLanguageSetting(request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LanguagesApi.LanguagesUpdateLanguageSetting: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LanguagesUpdateLanguageSettingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set language for subscriber or provider
    apiInstance.LanguagesUpdateLanguageSettingWithHttpInfo(request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LanguagesApi.LanguagesUpdateLanguageSettingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingLanguagesUpdateLanguagesRequest**](SCServiceChannelServicesMessagingLanguagesUpdateLanguagesRequest.md) |  |  |

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
| **200** | The language setting is updated. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc              &lt; br /&gt; Error codes:              101 - Invalid provider id              104 - ProviderId not found              401 — Invalid subscriber id              405 — SubscriberId not found              850 — You must set SubscriberId or ProviderId              851 — National language not found              852 — Invalid language id                  853 — LanguageId not found              854 - You should set subscriberId or providerId |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

