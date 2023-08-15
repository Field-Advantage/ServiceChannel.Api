# ServiceChannel.Api.Api.EmailNotificationsApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UsersCurrentLocationslocationIdEmail**](EmailNotificationsApi.md#userscurrentlocationslocationidemail) | **GET** /users/current/locations/{locationId}/email | List existing email subscriptions |
| [**UsersCurrentLocationslocationIdSubscribe**](EmailNotificationsApi.md#userscurrentlocationslocationidsubscribe) | **POST** /users/current/locations/{locationId}/subscribe | Subscribe to Email Notifications |
| [**UsersCurrentLocationslocationIdUnsubscribeidid**](EmailNotificationsApi.md#userscurrentlocationslocationidunsubscribeidid) | **DELETE** /users/current/locations/{locationId}/unsubscribe | Unsubscribe from Email Notifications |
| [**UsersCurrentUnsubscribe**](EmailNotificationsApi.md#userscurrentunsubscribe) | **DELETE** /users/current/unsubscribe | Unsubscribe from Email Notifications |

<a id="userscurrentlocationslocationidemail"></a>
# **UsersCurrentLocationslocationIdEmail**
> Object UsersCurrentLocationslocationIdEmail (int locationId)

List existing email subscriptions

Returns a list of email subscriptions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class UsersCurrentLocationslocationIdEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailNotificationsApi(config);
            var locationId = 56;  // int | 

            try
            {
                // List existing email subscriptions
                Object result = apiInstance.UsersCurrentLocationslocationIdEmail(locationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailNotificationsApi.UsersCurrentLocationslocationIdEmail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersCurrentLocationslocationIdEmailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List existing email subscriptions
    ApiResponse<Object> response = apiInstance.UsersCurrentLocationslocationIdEmailWithHttpInfo(locationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailNotificationsApi.UsersCurrentLocationslocationIdEmailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** |  |  |

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

<a id="userscurrentlocationslocationidsubscribe"></a>
# **UsersCurrentLocationslocationIdSubscribe**
> Object UsersCurrentLocationslocationIdSubscribe (int locationId, SCServiceChannelServicesMessagingNotificationsEmailNotificationSubscriptionRequest request)

Subscribe to Email Notifications

Subscribe to Email Notification.              <br /><br />Available for subscriber usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class UsersCurrentLocationslocationIdSubscribeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailNotificationsApi(config);
            var locationId = 56;  // int | Numeric Id of the Location to perform action with.
            var request = new SCServiceChannelServicesMessagingNotificationsEmailNotificationSubscriptionRequest(); // SCServiceChannelServicesMessagingNotificationsEmailNotificationSubscriptionRequest | The Subscription Email Notification request.

            try
            {
                // Subscribe to Email Notifications
                Object result = apiInstance.UsersCurrentLocationslocationIdSubscribe(locationId, request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailNotificationsApi.UsersCurrentLocationslocationIdSubscribe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersCurrentLocationslocationIdSubscribeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Subscribe to Email Notifications
    ApiResponse<Object> response = apiInstance.UsersCurrentLocationslocationIdSubscribeWithHttpInfo(locationId, request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailNotificationsApi.UsersCurrentLocationslocationIdSubscribeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | Numeric Id of the Location to perform action with. |  |
| **request** | [**SCServiceChannelServicesMessagingNotificationsEmailNotificationSubscriptionRequest**](SCServiceChannelServicesMessagingNotificationsEmailNotificationSubscriptionRequest.md) | The Subscription Email Notification request. |  |

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

<a id="userscurrentlocationslocationidunsubscribeidid"></a>
# **UsersCurrentLocationslocationIdUnsubscribeidid**
> Object UsersCurrentLocationslocationIdUnsubscribeidid (int locationId, string notificationType, int? id = null, string? languageCode = null, List<Object>? notificationRulesRules = null)

Unsubscribe from Email Notifications

Unsubscribe from Email Notifications.              <br /><br />Available for subscriber usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class UsersCurrentLocationslocationIdUnsubscribeididExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailNotificationsApi(config);
            var locationId = 56;  // int | Numeric Id of the Location to perform action with.
            var notificationType = "CheckIn";  // string | Notification type: Check In , ....
            var id = 56;  // int? | Numeric Id of the Subscription to perform action with. (optional) 
            var languageCode = "languageCode_example";  // string? | ISO 639-1 two-letter code for the language. (optional) 
            var notificationRulesRules = new List<Object>?(); // List<Object>? |  (optional) 

            try
            {
                // Unsubscribe from Email Notifications
                Object result = apiInstance.UsersCurrentLocationslocationIdUnsubscribeidid(locationId, notificationType, id, languageCode, notificationRulesRules);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailNotificationsApi.UsersCurrentLocationslocationIdUnsubscribeidid: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersCurrentLocationslocationIdUnsubscribeididWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unsubscribe from Email Notifications
    ApiResponse<Object> response = apiInstance.UsersCurrentLocationslocationIdUnsubscribeididWithHttpInfo(locationId, notificationType, id, languageCode, notificationRulesRules);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailNotificationsApi.UsersCurrentLocationslocationIdUnsubscribeididWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | Numeric Id of the Location to perform action with. |  |
| **notificationType** | **string** | Notification type: Check In , .... |  |
| **id** | **int?** | Numeric Id of the Subscription to perform action with. | [optional]  |
| **languageCode** | **string?** | ISO 639-1 two-letter code for the language. | [optional]  |
| **notificationRulesRules** | [**List&lt;Object&gt;?**](Object.md) |  | [optional]  |

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

<a id="userscurrentunsubscribe"></a>
# **UsersCurrentUnsubscribe**
> Object UsersCurrentUnsubscribe ()

Unsubscribe from Email Notifications

Unsubscribe from Email Notifications.              <br /><br />Available for subscriber usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class UsersCurrentUnsubscribeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailNotificationsApi(config);

            try
            {
                // Unsubscribe from Email Notifications
                Object result = apiInstance.UsersCurrentUnsubscribe();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailNotificationsApi.UsersCurrentUnsubscribe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersCurrentUnsubscribeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unsubscribe from Email Notifications
    ApiResponse<Object> response = apiInstance.UsersCurrentUnsubscribeWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailNotificationsApi.UsersCurrentUnsubscribeWithHttpInfo: " + e.Message);
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
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

