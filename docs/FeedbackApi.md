# ServiceChannel.Api.Api.FeedbackApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FeedbacksByWorkordersworkOrdersIds0workOrdersIds0workOrdersIds1workOrdersIds1subscriberIdsubscriberId**](FeedbackApi.md#feedbacksbyworkordersworkordersids0workordersids0workordersids1workordersids1subscriberidsubscriberid) | **GET** /feedbacks/byWorkorders |  |
| [**FeedbacksReviews**](FeedbackApi.md#feedbacksreviews) | **POST** /feedbacks/reviews |  |
| [**FeedbacksReviewsInfoProviderIdProviderIdSubscriberIdSubscriberId**](FeedbackApi.md#feedbacksreviewsinfoprovideridprovideridsubscriberidsubscriberid) | **GET** /feedbacks/reviews/info |  |
| [**FeedbacksReviewsProviderIdProviderIdSearchWithinSearchWithinPageSizePageSizePageOffsetPageOffsetSortBySortBySubscriberIdSubscriberId**](FeedbackApi.md#feedbacksreviewsprovideridprovideridsearchwithinsearchwithinpagesizepagesizepageoffsetpageoffsetsortbysortbysubscriberidsubscriberid) | **GET** /feedbacks/reviews |  |
| [**FeedbacksWorkordersCountlocationIdlocationIdsubscriberIdsubscriberId**](FeedbackApi.md#feedbacksworkorderscountlocationidlocationidsubscriberidsubscriberid) | **GET** /feedbacks/workorders/count |  |
| [**FeedbacksWorkordersLocationIdLocationIdSetupIdSetupIdOrderByFieldOrderByFieldOrderDirectionOrderDirectionShowMyWorkOrdersShowMyWorkOrdersSubscriberIdSubscriberId**](FeedbackApi.md#feedbacksworkorderslocationidlocationidsetupidsetupidorderbyfieldorderbyfieldorderdirectionorderdirectionshowmyworkordersshowmyworkorderssubscriberidsubscriberid) | **GET** /feedbacks/workorders |  |
| [**FeedbacksWorkordersworkorderId**](FeedbackApi.md#feedbacksworkordersworkorderid) | **POST** /feedbacks/workorders/{workorderId} |  |

<a id="feedbacksbyworkordersworkordersids0workordersids0workordersids1workordersids1subscriberidsubscriberid"></a>
# **FeedbacksByWorkordersworkOrdersIds0workOrdersIds0workOrdersIds1workOrdersIds1subscriberIdsubscriberId**
> SCServiceChannelServicesMessagingFeedbackFeedbackReviewsForWorkOrdersResponse FeedbacksByWorkordersworkOrdersIds0workOrdersIds0workOrdersIds1workOrdersIds1subscriberIdsubscriberId (List<int> workOrdersIds, int? subscriberId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class FeedbacksByWorkordersworkOrdersIds0workOrdersIds0workOrdersIds1workOrdersIds1subscriberIdsubscriberIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FeedbackApi(config);
            var workOrdersIds = new List<int>(); // List<int> | 
            var subscriberId = 56;  // int? |  (optional) 

            try
            {
                SCServiceChannelServicesMessagingFeedbackFeedbackReviewsForWorkOrdersResponse result = apiInstance.FeedbacksByWorkordersworkOrdersIds0workOrdersIds0workOrdersIds1workOrdersIds1subscriberIdsubscriberId(workOrdersIds, subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeedbackApi.FeedbacksByWorkordersworkOrdersIds0workOrdersIds0workOrdersIds1workOrdersIds1subscriberIdsubscriberId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FeedbacksByWorkordersworkOrdersIds0workOrdersIds0workOrdersIds1workOrdersIds1subscriberIdsubscriberIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SCServiceChannelServicesMessagingFeedbackFeedbackReviewsForWorkOrdersResponse> response = apiInstance.FeedbacksByWorkordersworkOrdersIds0workOrdersIds0workOrdersIds1workOrdersIds1subscriberIdsubscriberIdWithHttpInfo(workOrdersIds, subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeedbackApi.FeedbacksByWorkordersworkOrdersIds0workOrdersIds0workOrdersIds1workOrdersIds1subscriberIdsubscriberIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrdersIds** | [**List&lt;int&gt;**](int.md) |  |  |
| **subscriberId** | **int?** |  | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingFeedbackFeedbackReviewsForWorkOrdersResponse**](SCServiceChannelServicesMessagingFeedbackFeedbackReviewsForWorkOrdersResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="feedbacksreviews"></a>
# **FeedbacksReviews**
> SCServiceChannelServicesMessagingFeedbackReviewProviderRequest FeedbacksReviews (SCServiceChannelServicesMessagingFeedbackReviewProviderRequest request)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class FeedbacksReviewsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FeedbackApi(config);
            var request = new SCServiceChannelServicesMessagingFeedbackReviewProviderRequest(); // SCServiceChannelServicesMessagingFeedbackReviewProviderRequest | 

            try
            {
                SCServiceChannelServicesMessagingFeedbackReviewProviderRequest result = apiInstance.FeedbacksReviews(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeedbackApi.FeedbacksReviews: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FeedbacksReviewsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SCServiceChannelServicesMessagingFeedbackReviewProviderRequest> response = apiInstance.FeedbacksReviewsWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeedbackApi.FeedbacksReviewsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingFeedbackReviewProviderRequest**](SCServiceChannelServicesMessagingFeedbackReviewProviderRequest.md) |  |  |

### Return type

[**SCServiceChannelServicesMessagingFeedbackReviewProviderRequest**](SCServiceChannelServicesMessagingFeedbackReviewProviderRequest.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the provider review created or updated. |  -  |
| **401** | Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br&gt; 504 - API call rejected by security permissions; |  -  |
| **403** | Indicates that the requested resource requires provider rateable feature |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="feedbacksreviewsinfoprovideridprovideridsubscriberidsubscriberid"></a>
# **FeedbacksReviewsInfoProviderIdProviderIdSubscriberIdSubscriberId**
> Object FeedbacksReviewsInfoProviderIdProviderIdSubscriberIdSubscriberId (int? providerId = null, int? subscriberId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class FeedbacksReviewsInfoProviderIdProviderIdSubscriberIdSubscriberIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FeedbackApi(config);
            var providerId = 56;  // int? |  (optional) 
            var subscriberId = 56;  // int? |  (optional) 

            try
            {
                Object result = apiInstance.FeedbacksReviewsInfoProviderIdProviderIdSubscriberIdSubscriberId(providerId, subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeedbackApi.FeedbacksReviewsInfoProviderIdProviderIdSubscriberIdSubscriberId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FeedbacksReviewsInfoProviderIdProviderIdSubscriberIdSubscriberIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.FeedbacksReviewsInfoProviderIdProviderIdSubscriberIdSubscriberIdWithHttpInfo(providerId, subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeedbackApi.FeedbacksReviewsInfoProviderIdProviderIdSubscriberIdSubscriberIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **providerId** | **int?** |  | [optional]  |
| **subscriberId** | **int?** |  | [optional]  |

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
| **200** | Return info model about provider ratings |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="feedbacksreviewsprovideridprovideridsearchwithinsearchwithinpagesizepagesizepageoffsetpageoffsetsortbysortbysubscriberidsubscriberid"></a>
# **FeedbacksReviewsProviderIdProviderIdSearchWithinSearchWithinPageSizePageSizePageOffsetPageOffsetSortBySortBySubscriberIdSubscriberId**
> SCServiceChannelServicesMessagingFeedbackFeedbackReviewsForProviderResponse FeedbacksReviewsProviderIdProviderIdSearchWithinSearchWithinPageSizePageSizePageOffsetPageOffsetSortBySortBySubscriberIdSubscriberId (int? providerId = null, string? searchWithin = null, int? pageSize = null, int? pageOffset = null, string? sortBy = null, int? subscriberId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class FeedbacksReviewsProviderIdProviderIdSearchWithinSearchWithinPageSizePageSizePageOffsetPageOffsetSortBySortBySubscriberIdSubscriberIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FeedbackApi(config);
            var providerId = 56;  // int? | Provider Id (optional) 
            var searchWithin = "searchWithin_example";  // string? | Search within reviews comment (optional) 
            var pageSize = 56;  // int? | Response page size (default 10) (optional) 
            var pageOffset = 56;  // int? | Response page offset (default 0) (optional) 
            var sortBy = "Recent";  // string? | Sort by field (default by Recent) (optional) 
            var subscriberId = 56;  // int? | Subscriber Id (optional) 

            try
            {
                SCServiceChannelServicesMessagingFeedbackFeedbackReviewsForProviderResponse result = apiInstance.FeedbacksReviewsProviderIdProviderIdSearchWithinSearchWithinPageSizePageSizePageOffsetPageOffsetSortBySortBySubscriberIdSubscriberId(providerId, searchWithin, pageSize, pageOffset, sortBy, subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeedbackApi.FeedbacksReviewsProviderIdProviderIdSearchWithinSearchWithinPageSizePageSizePageOffsetPageOffsetSortBySortBySubscriberIdSubscriberId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FeedbacksReviewsProviderIdProviderIdSearchWithinSearchWithinPageSizePageSizePageOffsetPageOffsetSortBySortBySubscriberIdSubscriberIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SCServiceChannelServicesMessagingFeedbackFeedbackReviewsForProviderResponse> response = apiInstance.FeedbacksReviewsProviderIdProviderIdSearchWithinSearchWithinPageSizePageSizePageOffsetPageOffsetSortBySortBySubscriberIdSubscriberIdWithHttpInfo(providerId, searchWithin, pageSize, pageOffset, sortBy, subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeedbackApi.FeedbacksReviewsProviderIdProviderIdSearchWithinSearchWithinPageSizePageSizePageOffsetPageOffsetSortBySortBySubscriberIdSubscriberIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **providerId** | **int?** | Provider Id | [optional]  |
| **searchWithin** | **string?** | Search within reviews comment | [optional]  |
| **pageSize** | **int?** | Response page size (default 10) | [optional]  |
| **pageOffset** | **int?** | Response page offset (default 0) | [optional]  |
| **sortBy** | **string?** | Sort by field (default by Recent) | [optional]  |
| **subscriberId** | **int?** | Subscriber Id | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingFeedbackFeedbackReviewsForProviderResponse**](SCServiceChannelServicesMessagingFeedbackFeedbackReviewsForProviderResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return feedback reviews. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="feedbacksworkorderscountlocationidlocationidsubscriberidsubscriberid"></a>
# **FeedbacksWorkordersCountlocationIdlocationIdsubscriberIdsubscriberId**
> int FeedbacksWorkordersCountlocationIdlocationIdsubscriberIdsubscriberId (int? locationId = null, int? subscriberId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class FeedbacksWorkordersCountlocationIdlocationIdsubscriberIdsubscriberIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FeedbackApi(config);
            var locationId = 56;  // int? |  (optional) 
            var subscriberId = 56;  // int? |  (optional) 

            try
            {
                int result = apiInstance.FeedbacksWorkordersCountlocationIdlocationIdsubscriberIdsubscriberId(locationId, subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeedbackApi.FeedbacksWorkordersCountlocationIdlocationIdsubscriberIdsubscriberId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FeedbacksWorkordersCountlocationIdlocationIdsubscriberIdsubscriberIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<int> response = apiInstance.FeedbacksWorkordersCountlocationIdlocationIdsubscriberIdsubscriberIdWithHttpInfo(locationId, subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeedbackApi.FeedbacksWorkordersCountlocationIdlocationIdsubscriberIdsubscriberIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int?** |  | [optional]  |
| **subscriberId** | **int?** |  | [optional]  |

### Return type

**int**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return count of work orders ready for feedback. |  -  |
| **401** | Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="feedbacksworkorderslocationidlocationidsetupidsetupidorderbyfieldorderbyfieldorderdirectionorderdirectionshowmyworkordersshowmyworkorderssubscriberidsubscriberid"></a>
# **FeedbacksWorkordersLocationIdLocationIdSetupIdSetupIdOrderByFieldOrderByFieldOrderDirectionOrderDirectionShowMyWorkOrdersShowMyWorkOrdersSubscriberIdSubscriberId**
> List&lt;SCServiceChannelServicesMessagingFeedbackWorkorderFeedback&gt; FeedbacksWorkordersLocationIdLocationIdSetupIdSetupIdOrderByFieldOrderByFieldOrderDirectionOrderDirectionShowMyWorkOrdersShowMyWorkOrdersSubscriberIdSubscriberId (int? locationId = null, int? setupId = null, string? orderByField = null, string? orderDirection = null, bool? showMyWorkOrders = null, int? subscriberId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class FeedbacksWorkordersLocationIdLocationIdSetupIdSetupIdOrderByFieldOrderByFieldOrderDirectionOrderDirectionShowMyWorkOrdersShowMyWorkOrdersSubscriberIdSubscriberIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FeedbackApi(config);
            var locationId = 56;  // int? | LocationId (optional) 
            var setupId = 56;  // int? | Dashboard setupId (optional) (optional) 
            var orderByField = "TrackingNumber";  // string? | Order by field (optional) 
            var orderDirection = "Ascending";  // string? | Order direction (optional) 
            var showMyWorkOrders = false;  // bool? | Activates filter by current user id (optional)  (default to false)
            var subscriberId = 56;  // int? | Subscriber Id (optional) 

            try
            {
                List<SCServiceChannelServicesMessagingFeedbackWorkorderFeedback> result = apiInstance.FeedbacksWorkordersLocationIdLocationIdSetupIdSetupIdOrderByFieldOrderByFieldOrderDirectionOrderDirectionShowMyWorkOrdersShowMyWorkOrdersSubscriberIdSubscriberId(locationId, setupId, orderByField, orderDirection, showMyWorkOrders, subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeedbackApi.FeedbacksWorkordersLocationIdLocationIdSetupIdSetupIdOrderByFieldOrderByFieldOrderDirectionOrderDirectionShowMyWorkOrdersShowMyWorkOrdersSubscriberIdSubscriberId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FeedbacksWorkordersLocationIdLocationIdSetupIdSetupIdOrderByFieldOrderByFieldOrderDirectionOrderDirectionShowMyWorkOrdersShowMyWorkOrdersSubscriberIdSubscriberIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<SCServiceChannelServicesMessagingFeedbackWorkorderFeedback>> response = apiInstance.FeedbacksWorkordersLocationIdLocationIdSetupIdSetupIdOrderByFieldOrderByFieldOrderDirectionOrderDirectionShowMyWorkOrdersShowMyWorkOrdersSubscriberIdSubscriberIdWithHttpInfo(locationId, setupId, orderByField, orderDirection, showMyWorkOrders, subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeedbackApi.FeedbacksWorkordersLocationIdLocationIdSetupIdSetupIdOrderByFieldOrderByFieldOrderDirectionOrderDirectionShowMyWorkOrdersShowMyWorkOrdersSubscriberIdSubscriberIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int?** | LocationId | [optional]  |
| **setupId** | **int?** | Dashboard setupId (optional) | [optional]  |
| **orderByField** | **string?** | Order by field | [optional]  |
| **orderDirection** | **string?** | Order direction | [optional]  |
| **showMyWorkOrders** | **bool?** | Activates filter by current user id | [optional] [default to false] |
| **subscriberId** | **int?** | Subscriber Id | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingFeedbackWorkorderFeedback&gt;**](SCServiceChannelServicesMessagingFeedbackWorkorderFeedback.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return work orders ready for feedback. |  -  |
| **401** | Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="feedbacksworkordersworkorderid"></a>
# **FeedbacksWorkordersworkorderId**
> void FeedbacksWorkordersworkorderId (int workorderId, SCServiceChannelServicesMessagingFeedbackFeedbackRequest request)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class FeedbacksWorkordersworkorderIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FeedbackApi(config);
            var workorderId = 56;  // int | 
            var request = new SCServiceChannelServicesMessagingFeedbackFeedbackRequest(); // SCServiceChannelServicesMessagingFeedbackFeedbackRequest | 

            try
            {
                apiInstance.FeedbacksWorkordersworkorderId(workorderId, request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeedbackApi.FeedbacksWorkordersworkorderId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FeedbacksWorkordersworkorderIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.FeedbacksWorkordersworkorderIdWithHttpInfo(workorderId, request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeedbackApi.FeedbacksWorkordersworkorderIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** |  |  |
| **request** | [**SCServiceChannelServicesMessagingFeedbackFeedbackRequest**](SCServiceChannelServicesMessagingFeedbackFeedbackRequest.md) |  |  |

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
| **201** | Indicates that the request succeeded and that the feedback created. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br&gt;Error codes:              &lt;br&gt; 503 - Request is empty or null;              &lt;br&gt; 904 - Invalid work order status;              &lt;br&gt; 2601 - Invalid feedback answer;              &lt;br&gt; 2602 - Invalid work order number;              &lt;br&gt; 2602 - Invalid subscriber;              &lt;br&gt; 2603 - Invalid subscriber number;              &lt;br&gt; 2604 - Invalid feedback score;              &lt;br&gt; 2605 - Unsatisfactory answer required a comment              &lt;br&gt; 2606 - Invalid LocationId or SetupId provided |  -  |
| **401** | Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

