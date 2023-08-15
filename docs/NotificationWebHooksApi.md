# ServiceChannel.Api.Api.NotificationWebHooksApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**NotificationWebHooks**](NotificationWebHooksApi.md#notificationwebhooks) | **GET** /NotificationWebHooks | List existing webhooks |
| [**NotificationWebHooks_0**](NotificationWebHooksApi.md#notificationwebhooks_0) | **POST** /NotificationWebHooks | Create a webhook |
| [**NotificationWebHooksid**](NotificationWebHooksApi.md#notificationwebhooksid) | **GET** /NotificationWebHooks/{id} | Get a webhook |
| [**NotificationWebHooksid_0**](NotificationWebHooksApi.md#notificationwebhooksid_0) | **PUT** /NotificationWebHooks/{id} | Update a webhook |
| [**NotificationWebHooksid_1**](NotificationWebHooksApi.md#notificationwebhooksid_1) | **DELETE** /NotificationWebHooks/{id} | Delete a webhook |

<a id="notificationwebhooks"></a>
# **NotificationWebHooks**
> List&lt;SCServiceChannelServicesMessagingNotificationsWebHooksWebHook&gt; NotificationWebHooks ()

List existing webhooks

Returns a list of webhooks for the current subscriber or provider.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class NotificationWebHooksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationWebHooksApi(config);

            try
            {
                // List existing webhooks
                List<SCServiceChannelServicesMessagingNotificationsWebHooksWebHook> result = apiInstance.NotificationWebHooks();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationWebHooksApi.NotificationWebHooks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NotificationWebHooksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List existing webhooks
    ApiResponse<List<SCServiceChannelServicesMessagingNotificationsWebHooksWebHook>> response = apiInstance.NotificationWebHooksWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotificationWebHooksApi.NotificationWebHooksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;SCServiceChannelServicesMessagingNotificationsWebHooksWebHook&gt;**](SCServiceChannelServicesMessagingNotificationsWebHooksWebHook.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The webhooks are in the response. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 - Missing or incorrect authentication credentials |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="notificationwebhooks_0"></a>
# **NotificationWebHooks_0**
> SCServiceChannelServicesMessagingNotificationsWebHooksAddWebHookResponse NotificationWebHooks_0 (SCServiceChannelServicesMessagingNotificationsWebHooksAddWebHookRequest req)

Create a webhook

Creates a new webhook for the specified [event types](https://developer.servicechannel.com/guides/wh/types-of-events/). Returns a unique webhook ID for a successful request.              See [Event Objects](https://developer.servicechannel.com/guides/wh/event-objects/) for example notification objects and descriptions of their fields.              <br />***Note:*** You can create webhooks using API or via the [Service Automation Admin](https://developer.servicechannel.com/guides/wh/create-and-manage-webhooks-in-UI/).              <br />**Example Request**                                POST /NotificationWebHooks                  {                    \"Subscriptions\": [                      {                        \"Name\": \"Subscription to new WOs\",                        \"EventTypes\": [                          \"WorkOrderCreated\"                        ],                        \"Rules\": {                          \"Trades\": [                            \"GLASS\"                          ],                          \"Categories\": [                            \"MAINTENANCE\"                          ],                          \"Statuses\": [                            \"COMPLETED/CONFIRMED\"                          ]                        }                      }                    ],                    \"Enabled\": true,                    \"Name\": \"New WO webhook\",                    \"Description\": \"I want to receive notifications when new WOs of GLASS trade and MAINTENANCE category are created.\",                    \"Url\": \"https://your-company.com/webhook-target-URL\"                  }

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class NotificationWebHooks_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationWebHooksApi(config);
            var req = new SCServiceChannelServicesMessagingNotificationsWebHooksAddWebHookRequest(); // SCServiceChannelServicesMessagingNotificationsWebHooksAddWebHookRequest | The webhook object that needs to be created.

            try
            {
                // Create a webhook
                SCServiceChannelServicesMessagingNotificationsWebHooksAddWebHookResponse result = apiInstance.NotificationWebHooks_0(req);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationWebHooksApi.NotificationWebHooks_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NotificationWebHooks_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a webhook
    ApiResponse<SCServiceChannelServicesMessagingNotificationsWebHooksAddWebHookResponse> response = apiInstance.NotificationWebHooks_0WithHttpInfo(req);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotificationWebHooksApi.NotificationWebHooks_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **req** | [**SCServiceChannelServicesMessagingNotificationsWebHooksAddWebHookRequest**](SCServiceChannelServicesMessagingNotificationsWebHooksAddWebHookRequest.md) | The webhook object that needs to be created. |  |

### Return type

[**SCServiceChannelServicesMessagingNotificationsWebHooksAddWebHookResponse**](SCServiceChannelServicesMessagingNotificationsWebHooksAddWebHookResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The webhook is created. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              503 - Required data missing or incorrect |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 - Missing or incorrect authentication credentials |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="notificationwebhooksid"></a>
# **NotificationWebHooksid**
> SCServiceChannelServicesMessagingNotificationsWebHooksWebHook NotificationWebHooksid (int id)

Get a webhook

Retrieves the details of the specified webhook.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class NotificationWebHooksidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationWebHooksApi(config);
            var id = 56;  // int | The unique ID of the webhook to return.

            try
            {
                // Get a webhook
                SCServiceChannelServicesMessagingNotificationsWebHooksWebHook result = apiInstance.NotificationWebHooksid(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationWebHooksApi.NotificationWebHooksid: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NotificationWebHooksidWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a webhook
    ApiResponse<SCServiceChannelServicesMessagingNotificationsWebHooksWebHook> response = apiInstance.NotificationWebHooksidWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotificationWebHooksApi.NotificationWebHooksidWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The unique ID of the webhook to return. |  |

### Return type

[**SCServiceChannelServicesMessagingNotificationsWebHooksWebHook**](SCServiceChannelServicesMessagingNotificationsWebHooksWebHook.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested webhook is in the response. |  -  |
| **400** | The requested data are not found.              &lt;br/&gt;Error codes:              502 - Webhook not found |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 - Missing or incorrect authentication credentials |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="notificationwebhooksid_0"></a>
# **NotificationWebHooksid_0**
> void NotificationWebHooksid_0 (int id, SCServiceChannelServicesMessagingNotificationsWebHooksWebHook req)

Update a webhook

Updates the specified webhook by setting the values of the parameters passed.              <br />**Example Request**                                PUT /NotificationWebHooks/{id}                  {                    \"Subscriptions\": [                      {                        \"Id\": 1111,                        \"Name\": \"Subscription to new WOs\",                        \"EventTypes\": [                          \"WorkOrderCreated\"                        ],                        \"Rules\": {                          \"Trades\": [                            \"GLASS\"                          ],                          \"Categories\": [                            \"MAINTENANCE\"                          ],                          \"Statuses\": [                            \"COMPLETED/CONFIRMED\"                          ]                        }                      }                    ],                    \"Id\": 1,                    \"Enabled\": true,                    \"Name\": \"New WO webhook\",                    \"Description\": \"I want to receive notifications when new WOs of GLASS trade and MAINTENANCE category are created.\",                    \"Url\": \"https://your-company.com/webhook-target-URL\"                  }

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class NotificationWebHooksid_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationWebHooksApi(config);
            var id = 56;  // int | The unique ID of the webhook to update.
            var req = new SCServiceChannelServicesMessagingNotificationsWebHooksWebHook(); // SCServiceChannelServicesMessagingNotificationsWebHooksWebHook | The webhook object that needs to be updated.

            try
            {
                // Update a webhook
                apiInstance.NotificationWebHooksid_0(id, req);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationWebHooksApi.NotificationWebHooksid_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NotificationWebHooksid_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a webhook
    apiInstance.NotificationWebHooksid_0WithHttpInfo(id, req);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotificationWebHooksApi.NotificationWebHooksid_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The unique ID of the webhook to update. |  |
| **req** | [**SCServiceChannelServicesMessagingNotificationsWebHooksWebHook**](SCServiceChannelServicesMessagingNotificationsWebHooksWebHook.md) | The webhook object that needs to be updated. |  |

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
| **204** | The webhook is updated, and the response is intentionally blank. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              502 - Webhook not found              503 - Required data missing or incorrect |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 - Missing or incorrect authentication credentials |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="notificationwebhooksid_1"></a>
# **NotificationWebHooksid_1**
> void NotificationWebHooksid_1 (int id)

Delete a webhook

Permanently deletes the specified webhook. It cannot be undone.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class NotificationWebHooksid_1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationWebHooksApi(config);
            var id = 56;  // int | The unique ID of the webhook to delete.

            try
            {
                // Delete a webhook
                apiInstance.NotificationWebHooksid_1(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationWebHooksApi.NotificationWebHooksid_1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NotificationWebHooksid_1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a webhook
    apiInstance.NotificationWebHooksid_1WithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotificationWebHooksApi.NotificationWebHooksid_1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The unique ID of the webhook to delete. |  |

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
| **204** | The webhook is deleted, and the response is intentionally blank. |  -  |
| **400** | The requested data are not found.              &lt;br/&gt;Error codes:              502 - Webhook not found |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 - Missing or incorrect authentication credentials |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

