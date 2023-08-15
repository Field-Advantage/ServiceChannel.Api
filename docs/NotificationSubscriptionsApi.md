# ServiceChannel.Api.Api.NotificationSubscriptionsApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetProvidersExclusionListemailNotificationTypeemailNotificationType**](NotificationSubscriptionsApi.md#getprovidersexclusionlistemailnotificationtypeemailnotificationtype) | **GET** /GetProvidersExclusionList | Get providers exclusion list |
| [**NotificationSubscriptions**](NotificationSubscriptionsApi.md#notificationsubscriptions) | **POST** /NotificationSubscriptions | Subscribe to Notification |
| [**NotificationSubscriptionsHttp**](NotificationSubscriptionsApi.md#notificationsubscriptionshttp) | **GET** /NotificationSubscriptions/Http | List existing subscriptions |
| [**NotificationSubscriptionsHttp_0**](NotificationSubscriptionsApi.md#notificationsubscriptionshttp_0) | **POST** /NotificationSubscriptions/Http | Create a subscription |
| [**NotificationSubscriptionsHttpid**](NotificationSubscriptionsApi.md#notificationsubscriptionshttpid) | **GET** /NotificationSubscriptions/Http/{id} | Get a subscription |
| [**NotificationSubscriptionsHttpid_0**](NotificationSubscriptionsApi.md#notificationsubscriptionshttpid_0) | **PUT** /NotificationSubscriptions/Http/{id} | Update a subscription |
| [**NotificationSubscriptionsHttpid_1**](NotificationSubscriptionsApi.md#notificationsubscriptionshttpid_1) | **DELETE** /NotificationSubscriptions/Http/{id} | Delete a subscription |
| [**NotificationSubscriptionsMsteamsconversationIdconversationId**](NotificationSubscriptionsApi.md#notificationsubscriptionsmsteamsconversationidconversationid) | **GET** /NotificationSubscriptions/msteams | Get MSTeams Subscription |
| [**NotificationSubscriptionsSigningKey**](NotificationSubscriptionsApi.md#notificationsubscriptionssigningkey) | **GET** /NotificationSubscriptions/SigningKey | Get a signing key |
| [**NotificationSubscriptionsSigningKey_0**](NotificationSubscriptionsApi.md#notificationsubscriptionssigningkey_0) | **PUT** /NotificationSubscriptions/SigningKey | Regenerate a signing key |
| [**NotificationSubscriptionsidtypetype**](NotificationSubscriptionsApi.md#notificationsubscriptionsidtypetype) | **DELETE** /NotificationSubscriptions/{id} | UnSubscribe |

<a id="getprovidersexclusionlistemailnotificationtypeemailnotificationtype"></a>
# **GetProvidersExclusionListemailNotificationTypeemailNotificationType**
> SCServiceChannelServicesMessagingPermissionProvidersExclusionListResponse GetProvidersExclusionListemailNotificationTypeemailNotificationType (int emailNotificationType)

Get providers exclusion list

List providers who opted out to not receive the notifications

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetProvidersExclusionListemailNotificationTypeemailNotificationTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationSubscriptionsApi(config);
            var emailNotificationType = 56;  // int | 1 - Declined WO; 2 - WO Assigned to User; 4 - ETA Missed; 5 - LNH Autocopy

            try
            {
                // Get providers exclusion list
                SCServiceChannelServicesMessagingPermissionProvidersExclusionListResponse result = apiInstance.GetProvidersExclusionListemailNotificationTypeemailNotificationType(emailNotificationType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationSubscriptionsApi.GetProvidersExclusionListemailNotificationTypeemailNotificationType: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProvidersExclusionListemailNotificationTypeemailNotificationTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get providers exclusion list
    ApiResponse<SCServiceChannelServicesMessagingPermissionProvidersExclusionListResponse> response = apiInstance.GetProvidersExclusionListemailNotificationTypeemailNotificationTypeWithHttpInfo(emailNotificationType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotificationSubscriptionsApi.GetProvidersExclusionListemailNotificationTypeemailNotificationTypeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **emailNotificationType** | **int** | 1 - Declined WO; 2 - WO Assigned to User; 4 - ETA Missed; 5 - LNH Autocopy |  |

### Return type

[**SCServiceChannelServicesMessagingPermissionProvidersExclusionListResponse**](SCServiceChannelServicesMessagingPermissionProvidersExclusionListResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested providers are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              401 — Invalid subsriber ID              804 — User has no permissions to perform this action |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **404** | The requested resource does not exist on the server. |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="notificationsubscriptions"></a>
# **NotificationSubscriptions**
> SCServiceChannelServicesMessagingNotificationsAddNotificationSubsciptionResponse NotificationSubscriptions (SCServiceChannelServicesMessagingNotificationsNotificationSubscriptionRequest request)

Subscribe to Notification

Creates a new Subscription. Returns a unique subscription ID for a successful request.              See [Event Objects](https://developer.servicechannel.com/guides/wh/event-objects/) for example notification objects and descriptions of their fields.              <br />**Example Request**                                POST /NotificationSubscriptions/Subscribe                  {                    \"Name\": \"New Subscription\",                    \"IsEnabled\": true,                    \"Type\": \"MSBot\",                    \"Content\":                     {                      \"ConversationId\":\"a:1aV4BNOWtTdqJhkdgsdfhsdfhsgjdfgjdrtydjyj\",                      \"TenantId\":\"1111111-1111-1111-1111-111111111111\",                      \"UserId\":\"29:1oTNViX5ByDxfsgdfgsdhgjlnkkli\",                      \"UserName\":\"First Last\",                      \"ServiceUrl\":\"https://smba.trafficmanager.net/amer/\"                    }                  }

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class NotificationSubscriptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationSubscriptionsApi(config);
            var request = new SCServiceChannelServicesMessagingNotificationsNotificationSubscriptionRequest(); // SCServiceChannelServicesMessagingNotificationsNotificationSubscriptionRequest | The subscription object that needs to be created.

            try
            {
                // Subscribe to Notification
                SCServiceChannelServicesMessagingNotificationsAddNotificationSubsciptionResponse result = apiInstance.NotificationSubscriptions(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationSubscriptionsApi.NotificationSubscriptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NotificationSubscriptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Subscribe to Notification
    ApiResponse<SCServiceChannelServicesMessagingNotificationsAddNotificationSubsciptionResponse> response = apiInstance.NotificationSubscriptionsWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotificationSubscriptionsApi.NotificationSubscriptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingNotificationsNotificationSubscriptionRequest**](SCServiceChannelServicesMessagingNotificationsNotificationSubscriptionRequest.md) | The subscription object that needs to be created. |  |

### Return type

[**SCServiceChannelServicesMessagingNotificationsAddNotificationSubsciptionResponse**](SCServiceChannelServicesMessagingNotificationsAddNotificationSubsciptionResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The subscription is created. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              2105 - Operation is not allowed.              503 - Required data missing or incorrect |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 - Missing or incorrect authentication credentials |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="notificationsubscriptionshttp"></a>
# **NotificationSubscriptionsHttp**
> List&lt;SCServiceChannelServicesMessagingNotificationsHttpNotificationSubscription&gt; NotificationSubscriptionsHttp ()

List existing subscriptions

Returns a list of subscriptions for the current subscriber or provider.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class NotificationSubscriptionsHttpExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationSubscriptionsApi(config);

            try
            {
                // List existing subscriptions
                List<SCServiceChannelServicesMessagingNotificationsHttpNotificationSubscription> result = apiInstance.NotificationSubscriptionsHttp();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationSubscriptionsApi.NotificationSubscriptionsHttp: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NotificationSubscriptionsHttpWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List existing subscriptions
    ApiResponse<List<SCServiceChannelServicesMessagingNotificationsHttpNotificationSubscription>> response = apiInstance.NotificationSubscriptionsHttpWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotificationSubscriptionsApi.NotificationSubscriptionsHttpWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;SCServiceChannelServicesMessagingNotificationsHttpNotificationSubscription&gt;**](SCServiceChannelServicesMessagingNotificationsHttpNotificationSubscription.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The subscriptions are in the response. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 - Missing or incorrect authentication credentials |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="notificationsubscriptionshttp_0"></a>
# **NotificationSubscriptionsHttp_0**
> SCServiceChannelServicesMessagingNotificationsAddNotificationSubsciptionResponse NotificationSubscriptionsHttp_0 (SCServiceChannelServicesMessagingNotificationsAddHttpNotificationSubscriptionRequest req)

Create a subscription

Creates a new subscription to the specified [event types](https://developer.servicechannel.com/guides/wh/types-of-events/). Returns a unique subscription ID for a successful request.              See [Event Objects](https://developer.servicechannel.com/guides/wh/event-objects/) for example notification objects and descriptions of their fields.              <br />**Example Request**                                POST /NotificationSubscriptions/Http                  {                    \"Url\": \"https://your-company.com/webhook-target-URL\",                    \"Enabled\": true,                    \"Name\": \"Subscription to new WOs\",                    \"EventTypes\": [                      \"WorkOrderCreated\"                    ],                    \"Rules\": {                      \"Trades\": [                        \"GLASS\"                      ],                      \"Categories\": [                        \"MAINTENANCE\"                      ]                    }                  }

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class NotificationSubscriptionsHttp_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationSubscriptionsApi(config);
            var req = new SCServiceChannelServicesMessagingNotificationsAddHttpNotificationSubscriptionRequest(); // SCServiceChannelServicesMessagingNotificationsAddHttpNotificationSubscriptionRequest | The subscription object that needs to be created.

            try
            {
                // Create a subscription
                SCServiceChannelServicesMessagingNotificationsAddNotificationSubsciptionResponse result = apiInstance.NotificationSubscriptionsHttp_0(req);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationSubscriptionsApi.NotificationSubscriptionsHttp_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NotificationSubscriptionsHttp_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a subscription
    ApiResponse<SCServiceChannelServicesMessagingNotificationsAddNotificationSubsciptionResponse> response = apiInstance.NotificationSubscriptionsHttp_0WithHttpInfo(req);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotificationSubscriptionsApi.NotificationSubscriptionsHttp_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **req** | [**SCServiceChannelServicesMessagingNotificationsAddHttpNotificationSubscriptionRequest**](SCServiceChannelServicesMessagingNotificationsAddHttpNotificationSubscriptionRequest.md) | The subscription object that needs to be created. |  |

### Return type

[**SCServiceChannelServicesMessagingNotificationsAddNotificationSubsciptionResponse**](SCServiceChannelServicesMessagingNotificationsAddNotificationSubsciptionResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The subscription is created. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              503 - Required data missing or incorrect |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 - Missing or incorrect authentication credentials |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="notificationsubscriptionshttpid"></a>
# **NotificationSubscriptionsHttpid**
> SCServiceChannelServicesMessagingNotificationsHttpNotificationSubscription NotificationSubscriptionsHttpid (int id)

Get a subscription

Retrieves the details of the specified subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class NotificationSubscriptionsHttpidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationSubscriptionsApi(config);
            var id = 56;  // int | The unique ID of the subscription to return.

            try
            {
                // Get a subscription
                SCServiceChannelServicesMessagingNotificationsHttpNotificationSubscription result = apiInstance.NotificationSubscriptionsHttpid(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationSubscriptionsApi.NotificationSubscriptionsHttpid: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NotificationSubscriptionsHttpidWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a subscription
    ApiResponse<SCServiceChannelServicesMessagingNotificationsHttpNotificationSubscription> response = apiInstance.NotificationSubscriptionsHttpidWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotificationSubscriptionsApi.NotificationSubscriptionsHttpidWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The unique ID of the subscription to return. |  |

### Return type

[**SCServiceChannelServicesMessagingNotificationsHttpNotificationSubscription**](SCServiceChannelServicesMessagingNotificationsHttpNotificationSubscription.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested subscription is in the response. |  -  |
| **400** | The requested data are not found.              &lt;br/&gt;Error codes:              502 - Subscription not found |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 - Missing or incorrect authentication credentials |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="notificationsubscriptionshttpid_0"></a>
# **NotificationSubscriptionsHttpid_0**
> void NotificationSubscriptionsHttpid_0 (int id, SCServiceChannelServicesMessagingNotificationsHttpNotificationSubscription req)

Update a subscription

Updates the specified subscription by setting the values of the parameters passed.              <br />**Example Request**                                PUT /NotificationSubscriptions/Http/{id}                  {                    \"Id\": 1111,                    \"Url\": \"https://your-company.com/webhook-target-URL\",                    \"Enabled\": true,                    \"Name\": \"Subscription to new WOs\",                    \"EventTypes\": [                      \"WorkOrderCreated\"                    ],                    \"Rules\": {                      \"Trades\": [                        \"GLASS\"                      ],                      \"Categories\": [                        \"MAINTENANCE\"                      ]                    }                  }

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class NotificationSubscriptionsHttpid_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationSubscriptionsApi(config);
            var id = 56;  // int | The unique ID of the subscription to update.
            var req = new SCServiceChannelServicesMessagingNotificationsHttpNotificationSubscription(); // SCServiceChannelServicesMessagingNotificationsHttpNotificationSubscription | The subscription object that needs to be updated.

            try
            {
                // Update a subscription
                apiInstance.NotificationSubscriptionsHttpid_0(id, req);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationSubscriptionsApi.NotificationSubscriptionsHttpid_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NotificationSubscriptionsHttpid_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a subscription
    apiInstance.NotificationSubscriptionsHttpid_0WithHttpInfo(id, req);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotificationSubscriptionsApi.NotificationSubscriptionsHttpid_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The unique ID of the subscription to update. |  |
| **req** | [**SCServiceChannelServicesMessagingNotificationsHttpNotificationSubscription**](SCServiceChannelServicesMessagingNotificationsHttpNotificationSubscription.md) | The subscription object that needs to be updated. |  |

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
| **204** | The subscription is updated, and the response is intentionally blank. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              502 - Subscription not found              503 - Required data missing or incorrect |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 - Missing or incorrect authentication credentials |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="notificationsubscriptionshttpid_1"></a>
# **NotificationSubscriptionsHttpid_1**
> void NotificationSubscriptionsHttpid_1 (int id)

Delete a subscription

Permanently deletes the specified subscription. It cannot be undone.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class NotificationSubscriptionsHttpid_1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationSubscriptionsApi(config);
            var id = 56;  // int | The unique ID of the subscription to delete.

            try
            {
                // Delete a subscription
                apiInstance.NotificationSubscriptionsHttpid_1(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationSubscriptionsApi.NotificationSubscriptionsHttpid_1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NotificationSubscriptionsHttpid_1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a subscription
    apiInstance.NotificationSubscriptionsHttpid_1WithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotificationSubscriptionsApi.NotificationSubscriptionsHttpid_1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The unique ID of the subscription to delete. |  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The subscription is deleted, and the response is intentionally blank. |  -  |
| **400** | The requested data are not found.              &lt;br/&gt;Error codes:              502 - Subscription not found |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 - Missing or incorrect authentication credentials |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="notificationsubscriptionsmsteamsconversationidconversationid"></a>
# **NotificationSubscriptionsMsteamsconversationIdconversationId**
> SCServiceChannelServicesMessagingNotificationsMSBotNotificationSubscriptionResponse NotificationSubscriptionsMsteamsconversationIdconversationId (string conversationId)

Get MSTeams Subscription

Retrieves the details of the specified subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class NotificationSubscriptionsMsteamsconversationIdconversationIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationSubscriptionsApi(config);
            var conversationId = "conversationId_example";  // string | Conversation Identifier.

            try
            {
                // Get MSTeams Subscription
                SCServiceChannelServicesMessagingNotificationsMSBotNotificationSubscriptionResponse result = apiInstance.NotificationSubscriptionsMsteamsconversationIdconversationId(conversationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationSubscriptionsApi.NotificationSubscriptionsMsteamsconversationIdconversationId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NotificationSubscriptionsMsteamsconversationIdconversationIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get MSTeams Subscription
    ApiResponse<SCServiceChannelServicesMessagingNotificationsMSBotNotificationSubscriptionResponse> response = apiInstance.NotificationSubscriptionsMsteamsconversationIdconversationIdWithHttpInfo(conversationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotificationSubscriptionsApi.NotificationSubscriptionsMsteamsconversationIdconversationIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **conversationId** | **string** | Conversation Identifier. |  |

### Return type

[**SCServiceChannelServicesMessagingNotificationsMSBotNotificationSubscriptionResponse**](SCServiceChannelServicesMessagingNotificationsMSBotNotificationSubscriptionResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested subscription is in the response. |  -  |
| **400** | The requested data are not found.              &lt;br/&gt;Error codes:              502 - Subscription not found |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 - Missing or incorrect authentication credentials |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="notificationsubscriptionssigningkey"></a>
# **NotificationSubscriptionsSigningKey**
> SCServiceChannelServicesMessagingNotificationsSigningKeyResponse NotificationSubscriptionsSigningKey ()

Get a signing key

Retrieves the current subscriber's or provider's signing key.              A signing key is used to generate event signatures. Use your key to [verify that notifications are sent by SC](https://developer.servicechannel.com/guides/wh/receive-events-and-respond/#verify-an-event).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class NotificationSubscriptionsSigningKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationSubscriptionsApi(config);

            try
            {
                // Get a signing key
                SCServiceChannelServicesMessagingNotificationsSigningKeyResponse result = apiInstance.NotificationSubscriptionsSigningKey();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationSubscriptionsApi.NotificationSubscriptionsSigningKey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NotificationSubscriptionsSigningKeyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a signing key
    ApiResponse<SCServiceChannelServicesMessagingNotificationsSigningKeyResponse> response = apiInstance.NotificationSubscriptionsSigningKeyWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotificationSubscriptionsApi.NotificationSubscriptionsSigningKeyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SCServiceChannelServicesMessagingNotificationsSigningKeyResponse**](SCServiceChannelServicesMessagingNotificationsSigningKeyResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The signing key is in the response. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 - Missing or incorrect authentication credentials |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="notificationsubscriptionssigningkey_0"></a>
# **NotificationSubscriptionsSigningKey_0**
> SCServiceChannelServicesMessagingNotificationsSigningKeyResponse NotificationSubscriptionsSigningKey_0 ()

Regenerate a signing key

Regenerates the current subscriber's or provider's signing key. The previous signing key becomes invalid.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class NotificationSubscriptionsSigningKey_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationSubscriptionsApi(config);

            try
            {
                // Regenerate a signing key
                SCServiceChannelServicesMessagingNotificationsSigningKeyResponse result = apiInstance.NotificationSubscriptionsSigningKey_0();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationSubscriptionsApi.NotificationSubscriptionsSigningKey_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NotificationSubscriptionsSigningKey_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Regenerate a signing key
    ApiResponse<SCServiceChannelServicesMessagingNotificationsSigningKeyResponse> response = apiInstance.NotificationSubscriptionsSigningKey_0WithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotificationSubscriptionsApi.NotificationSubscriptionsSigningKey_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SCServiceChannelServicesMessagingNotificationsSigningKeyResponse**](SCServiceChannelServicesMessagingNotificationsSigningKeyResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The new signing key is in the response. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 - Missing or incorrect authentication credentials |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="notificationsubscriptionsidtypetype"></a>
# **NotificationSubscriptionsidtypetype**
> void NotificationSubscriptionsidtypetype (int id, string type)

UnSubscribe

Permanently deletes the specified subscription. It cannot be undone.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class NotificationSubscriptionsidtypetypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationSubscriptionsApi(config);
            var id = 56;  // int | The unique ID of the subscription.
            var type = "MSTeams";  // string | type of the subscription.

            try
            {
                // UnSubscribe
                apiInstance.NotificationSubscriptionsidtypetype(id, type);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationSubscriptionsApi.NotificationSubscriptionsidtypetype: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NotificationSubscriptionsidtypetypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UnSubscribe
    apiInstance.NotificationSubscriptionsidtypetypeWithHttpInfo(id, type);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotificationSubscriptionsApi.NotificationSubscriptionsidtypetypeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The unique ID of the subscription. |  |
| **type** | **string** | type of the subscription. |  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The subscription is deleted, and the response is intentionally blank. |  -  |
| **400** | The requested data are not found.              &lt;br/&gt;Error codes:              2105 - Operation is not allowed.              502 - Subscription not found |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 - Missing or incorrect authentication credentials |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

