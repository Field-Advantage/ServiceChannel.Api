# ServiceChannel.Api.Api.PushNotificationsApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**LocationslocationIdPushdeviceTokendeviceToken**](PushNotificationsApi.md#locationslocationidpushdevicetokendevicetoken) | **GET** /locations/{locationId}/push | List existing email subscriptions |
| [**LocationslocationIdSubscribe**](PushNotificationsApi.md#locationslocationidsubscribe) | **POST** /locations/{locationId}/subscribe | Subscribe to Push Notifications |
| [**LocationslocationIdUnsubscribeidid**](PushNotificationsApi.md#locationslocationidunsubscribeidid) | **DELETE** /locations/{locationId}/unsubscribe | Unsubscribe from Push Notifications |
| [**UnsubscribedeviceTokendeviceToken**](PushNotificationsApi.md#unsubscribedevicetokendevicetoken) | **DELETE** /unsubscribe | Unsubscribe from Push Notifications |

<a id="locationslocationidpushdevicetokendevicetoken"></a>
# **LocationslocationIdPushdeviceTokendeviceToken**
> Object LocationslocationIdPushdeviceTokendeviceToken (int locationId, string deviceToken)

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
    public class LocationslocationIdPushdeviceTokendeviceTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PushNotificationsApi(config);
            var locationId = 56;  // int | 
            var deviceToken = "deviceToken_example";  // string | 

            try
            {
                // List existing email subscriptions
                Object result = apiInstance.LocationslocationIdPushdeviceTokendeviceToken(locationId, deviceToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PushNotificationsApi.LocationslocationIdPushdeviceTokendeviceToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationslocationIdPushdeviceTokendeviceTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List existing email subscriptions
    ApiResponse<Object> response = apiInstance.LocationslocationIdPushdeviceTokendeviceTokenWithHttpInfo(locationId, deviceToken);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PushNotificationsApi.LocationslocationIdPushdeviceTokendeviceTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** |  |  |
| **deviceToken** | **string** |  |  |

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

<a id="locationslocationidsubscribe"></a>
# **LocationslocationIdSubscribe**
> Object LocationslocationIdSubscribe (int locationId, SCServiceChannelServicesMessagingNotificationsPushNotificationSubscriptionRequest request)

Subscribe to Push Notifications

Subscribe Push Notification.              <br /><br />Available for subscriber usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LocationslocationIdSubscribeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PushNotificationsApi(config);
            var locationId = 56;  // int | Numeric Id of the Location to perform action with.
            var request = new SCServiceChannelServicesMessagingNotificationsPushNotificationSubscriptionRequest(); // SCServiceChannelServicesMessagingNotificationsPushNotificationSubscriptionRequest | The Subscription Push Notification request.

            try
            {
                // Subscribe to Push Notifications
                Object result = apiInstance.LocationslocationIdSubscribe(locationId, request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PushNotificationsApi.LocationslocationIdSubscribe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationslocationIdSubscribeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Subscribe to Push Notifications
    ApiResponse<Object> response = apiInstance.LocationslocationIdSubscribeWithHttpInfo(locationId, request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PushNotificationsApi.LocationslocationIdSubscribeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | Numeric Id of the Location to perform action with. |  |
| **request** | [**SCServiceChannelServicesMessagingNotificationsPushNotificationSubscriptionRequest**](SCServiceChannelServicesMessagingNotificationsPushNotificationSubscriptionRequest.md) | The Subscription Push Notification request. |  |

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

<a id="locationslocationidunsubscribeidid"></a>
# **LocationslocationIdUnsubscribeidid**
> Object LocationslocationIdUnsubscribeidid (int locationId, string deviceToken, string deviceType, string notificationType, string application, int? id = null, List<Object>? notificationRulesRules = null)

Unsubscribe from Push Notifications

Unsubscribe from Push Notifications.              <br /><br />Available for subscriber usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LocationslocationIdUnsubscribeididExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PushNotificationsApi(config);
            var locationId = 56;  // int | Numeric Id of the Location to perform action with.
            var deviceToken = "deviceToken_example";  // string | Required Device Token.
            var deviceType = "Android";  // string | Device type: Android, iOS, Amazon
            var notificationType = "CheckIn";  // string | Notification type: Check In , ....
            var application = "ScMobile";  // string | Application : ScMobile, FTM, ...
            var id = 56;  // int? | Numeric Id of the Subscription to perform action with. (optional) 
            var notificationRulesRules = new List<Object>?(); // List<Object>? |  (optional) 

            try
            {
                // Unsubscribe from Push Notifications
                Object result = apiInstance.LocationslocationIdUnsubscribeidid(locationId, deviceToken, deviceType, notificationType, application, id, notificationRulesRules);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PushNotificationsApi.LocationslocationIdUnsubscribeidid: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationslocationIdUnsubscribeididWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unsubscribe from Push Notifications
    ApiResponse<Object> response = apiInstance.LocationslocationIdUnsubscribeididWithHttpInfo(locationId, deviceToken, deviceType, notificationType, application, id, notificationRulesRules);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PushNotificationsApi.LocationslocationIdUnsubscribeididWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | Numeric Id of the Location to perform action with. |  |
| **deviceToken** | **string** | Required Device Token. |  |
| **deviceType** | **string** | Device type: Android, iOS, Amazon |  |
| **notificationType** | **string** | Notification type: Check In , .... |  |
| **application** | **string** | Application : ScMobile, FTM, ... |  |
| **id** | **int?** | Numeric Id of the Subscription to perform action with. | [optional]  |
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

<a id="unsubscribedevicetokendevicetoken"></a>
# **UnsubscribedeviceTokendeviceToken**
> Object UnsubscribedeviceTokendeviceToken (string deviceToken)

Unsubscribe from Push Notifications

Unsubscribe from Push Notifications.              <br /><br />Available for subscriber usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class UnsubscribedeviceTokendeviceTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PushNotificationsApi(config);
            var deviceToken = "deviceToken_example";  // string | Device token: \"35353-335345-FAC342...\"

            try
            {
                // Unsubscribe from Push Notifications
                Object result = apiInstance.UnsubscribedeviceTokendeviceToken(deviceToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PushNotificationsApi.UnsubscribedeviceTokendeviceToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnsubscribedeviceTokendeviceTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unsubscribe from Push Notifications
    ApiResponse<Object> response = apiInstance.UnsubscribedeviceTokendeviceTokenWithHttpInfo(deviceToken);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PushNotificationsApi.UnsubscribedeviceTokendeviceTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deviceToken** | **string** | Device token: \&quot;35353-335345-FAC342...\&quot; |  |

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

