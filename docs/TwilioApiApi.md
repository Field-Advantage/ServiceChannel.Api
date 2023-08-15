# ServiceChannel.Api.Api.TwilioApiApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TwilioSms**](TwilioApiApi.md#twiliosms) | **POST** /twilio/Sms |  |
| [**TwilioSmsSmsSidSmsSidBodyBodyMessageStatusMessageStatusAccountSidAccountSidFromFromToToFromCityFromCityFromStateFromStateFromZipFromZipFromCountryFromCountryToCityToCityToStateToStateToZipToZipToCountryToCountry**](TwilioApiApi.md#twiliosmssmssidsmssidbodybodymessagestatusmessagestatusaccountsidaccountsidfromfromtotofromcityfromcityfromstatefromstatefromzipfromzipfromcountryfromcountrytocitytocitytostatetostatetoziptoziptocountrytocountry) | **GET** /twilio/Sms |  |
| [**TwilioSmsStatus**](TwilioApiApi.md#twiliosmsstatus) | **POST** /twilio/SmsStatus |  |

<a id="twiliosms"></a>
# **TwilioSms**
> Object TwilioSms (SCTwilioAspNetCommonSmsRequest request)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class TwilioSmsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TwilioApiApi(config);
            var request = new SCTwilioAspNetCommonSmsRequest(); // SCTwilioAspNetCommonSmsRequest | 

            try
            {
                Object result = apiInstance.TwilioSms(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwilioApiApi.TwilioSms: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TwilioSmsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.TwilioSmsWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TwilioApiApi.TwilioSmsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCTwilioAspNetCommonSmsRequest**](SCTwilioAspNetCommonSmsRequest.md) |  |  |

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

<a id="twiliosmssmssidsmssidbodybodymessagestatusmessagestatusaccountsidaccountsidfromfromtotofromcityfromcityfromstatefromstatefromzipfromzipfromcountryfromcountrytocitytocitytostatetostatetoziptoziptocountrytocountry"></a>
# **TwilioSmsSmsSidSmsSidBodyBodyMessageStatusMessageStatusAccountSidAccountSidFromFromToToFromCityFromCityFromStateFromStateFromZipFromZipFromCountryFromCountryToCityToCityToStateToStateToZipToZipToCountryToCountry**
> Object TwilioSmsSmsSidSmsSidBodyBodyMessageStatusMessageStatusAccountSidAccountSidFromFromToToFromCityFromCityFromStateFromStateFromZipFromZipFromCountryFromCountryToCityToCityToStateToStateToZipToZipToCountryToCountry (string? smsSid = null, string? body = null, string? messageStatus = null, string? accountSid = null, string? from = null, string? to = null, string? fromCity = null, string? fromState = null, string? fromZip = null, string? fromCountry = null, string? toCity = null, string? toState = null, string? toZip = null, string? toCountry = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class TwilioSmsSmsSidSmsSidBodyBodyMessageStatusMessageStatusAccountSidAccountSidFromFromToToFromCityFromCityFromStateFromStateFromZipFromZipFromCountryFromCountryToCityToCityToStateToStateToZipToZipToCountryToCountryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TwilioApiApi(config);
            var smsSid = "smsSid_example";  // string? |  (optional) 
            var body = "body_example";  // string? |  (optional) 
            var messageStatus = "messageStatus_example";  // string? |  (optional) 
            var accountSid = "accountSid_example";  // string? |  (optional) 
            var from = "from_example";  // string? |  (optional) 
            var to = "to_example";  // string? |  (optional) 
            var fromCity = "fromCity_example";  // string? |  (optional) 
            var fromState = "fromState_example";  // string? |  (optional) 
            var fromZip = "fromZip_example";  // string? |  (optional) 
            var fromCountry = "fromCountry_example";  // string? |  (optional) 
            var toCity = "toCity_example";  // string? |  (optional) 
            var toState = "toState_example";  // string? |  (optional) 
            var toZip = "toZip_example";  // string? |  (optional) 
            var toCountry = "toCountry_example";  // string? |  (optional) 

            try
            {
                Object result = apiInstance.TwilioSmsSmsSidSmsSidBodyBodyMessageStatusMessageStatusAccountSidAccountSidFromFromToToFromCityFromCityFromStateFromStateFromZipFromZipFromCountryFromCountryToCityToCityToStateToStateToZipToZipToCountryToCountry(smsSid, body, messageStatus, accountSid, from, to, fromCity, fromState, fromZip, fromCountry, toCity, toState, toZip, toCountry);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwilioApiApi.TwilioSmsSmsSidSmsSidBodyBodyMessageStatusMessageStatusAccountSidAccountSidFromFromToToFromCityFromCityFromStateFromStateFromZipFromZipFromCountryFromCountryToCityToCityToStateToStateToZipToZipToCountryToCountry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TwilioSmsSmsSidSmsSidBodyBodyMessageStatusMessageStatusAccountSidAccountSidFromFromToToFromCityFromCityFromStateFromStateFromZipFromZipFromCountryFromCountryToCityToCityToStateToStateToZipToZipToCountryToCountryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.TwilioSmsSmsSidSmsSidBodyBodyMessageStatusMessageStatusAccountSidAccountSidFromFromToToFromCityFromCityFromStateFromStateFromZipFromZipFromCountryFromCountryToCityToCityToStateToStateToZipToZipToCountryToCountryWithHttpInfo(smsSid, body, messageStatus, accountSid, from, to, fromCity, fromState, fromZip, fromCountry, toCity, toState, toZip, toCountry);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TwilioApiApi.TwilioSmsSmsSidSmsSidBodyBodyMessageStatusMessageStatusAccountSidAccountSidFromFromToToFromCityFromCityFromStateFromStateFromZipFromZipFromCountryFromCountryToCityToCityToStateToStateToZipToZipToCountryToCountryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **smsSid** | **string?** |  | [optional]  |
| **body** | **string?** |  | [optional]  |
| **messageStatus** | **string?** |  | [optional]  |
| **accountSid** | **string?** |  | [optional]  |
| **from** | **string?** |  | [optional]  |
| **to** | **string?** |  | [optional]  |
| **fromCity** | **string?** |  | [optional]  |
| **fromState** | **string?** |  | [optional]  |
| **fromZip** | **string?** |  | [optional]  |
| **fromCountry** | **string?** |  | [optional]  |
| **toCity** | **string?** |  | [optional]  |
| **toState** | **string?** |  | [optional]  |
| **toZip** | **string?** |  | [optional]  |
| **toCountry** | **string?** |  | [optional]  |

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

<a id="twiliosmsstatus"></a>
# **TwilioSmsStatus**
> Object TwilioSmsStatus (SCTwilioAspNetCommonSmsRequest request)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class TwilioSmsStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TwilioApiApi(config);
            var request = new SCTwilioAspNetCommonSmsRequest(); // SCTwilioAspNetCommonSmsRequest | 

            try
            {
                Object result = apiInstance.TwilioSmsStatus(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TwilioApiApi.TwilioSmsStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TwilioSmsStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.TwilioSmsStatusWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TwilioApiApi.TwilioSmsStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCTwilioAspNetCommonSmsRequest**](SCTwilioAspNetCommonSmsRequest.md) |  |  |

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

