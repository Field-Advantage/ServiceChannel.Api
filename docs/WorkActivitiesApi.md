# ServiceChannel.Api.Api.WorkActivitiesApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ForTimeInterval**](WorkActivitiesApi.md#fortimeinterval) | **GET** /odata/workactivities/Service.ForTimeInterval(dtMin&#x3D;{dtMin}, dtMax&#x3D;{dtMax}, userId&#x3D;{userId}) | List work activities created by a provider user within the specified time period |
| [**GetWorkActivities**](WorkActivitiesApi.md#getworkactivities) | **GET** /odata/workorders({workorderId})/workactivities | List work activities of the specified work order |
| [**GetWorkActivity**](WorkActivitiesApi.md#getworkactivity) | **GET** /odata/workorders({workorderId})/workactivities({workactivityId}) | Retrieve the specified work activity of a work order |
| [**WorkordersworkorderIdWorkactivities**](WorkActivitiesApi.md#workordersworkorderidworkactivities) | **POST** /workorders/{workorderId}/workactivities | Create a work activity for the specified work order |
| [**WorkordersworkorderIdWorkactivitiesworkactivityId**](WorkActivitiesApi.md#workordersworkorderidworkactivitiesworkactivityid) | **PUT** /workorders/{workorderId}/workactivities/{workactivityId} | Update the specified work activity of a work order |
| [**WorkordersworkorderIdWorkactivitiesworkactivityIds0workactivityIds0workactivityIds1workactivityIds1**](WorkActivitiesApi.md#workordersworkorderidworkactivitiesworkactivityids0workactivityids0workactivityids1workactivityids1) | **DELETE** /workorders/{workorderId}/workactivities | Delete the specified work activities of a work order |

<a id="fortimeinterval"></a>
# **ForTimeInterval**
> List&lt;SCServiceChannelServicesMessagingWorkordersWorkActivity&gt; ForTimeInterval (int userId, DateTime dtMax, DateTime dtMin, string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

List work activities created by a provider user within the specified time period

Returns work activities created by the specified provider user within the set time period.              <br />A work activity details information about the technician’s work on a service request: the time when the technician started and finished their work, the type of activity they carried out, the number of technicians who rendered the service, and other details related to the labor performed.              <br />***Note:*** This method is only available to provider users.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ForTimeIntervalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkActivitiesApi(config);
            var userId = 56;  // int | PIN of the provider user who created work activities.
            var dtMax = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | The end date of the time period for which you want to retrieve work activities. The format is `YYYY-MM-DD`.
            var dtMin = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | The start date of the time period for which you want to retrieve work activities. The format is `YYYY-MM-DD`.
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // List work activities created by a provider user within the specified time period
                List<SCServiceChannelServicesMessagingWorkordersWorkActivity> result = apiInstance.ForTimeInterval(userId, dtMax, dtMin, expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkActivitiesApi.ForTimeInterval: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForTimeIntervalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List work activities created by a provider user within the specified time period
    ApiResponse<List<SCServiceChannelServicesMessagingWorkordersWorkActivity>> response = apiInstance.ForTimeIntervalWithHttpInfo(userId, dtMax, dtMin, expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkActivitiesApi.ForTimeIntervalWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **int** | PIN of the provider user who created work activities. |  |
| **dtMax** | **DateTime** | The end date of the time period for which you want to retrieve work activities. The format is &#x60;YYYY-MM-DD&#x60;. |  |
| **dtMin** | **DateTime** | The start date of the time period for which you want to retrieve work activities. The format is &#x60;YYYY-MM-DD&#x60;. |  |
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingWorkordersWorkActivity&gt;**](SCServiceChannelServicesMessagingWorkordersWorkActivity.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Work activities created by the specified provider user within the set time period are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              504 — User not found |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getworkactivities"></a>
# **GetWorkActivities**
> List&lt;SCServiceChannelServicesMessagingWorkordersWorkActivity&gt; GetWorkActivities (int workorderId, string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

List work activities of the specified work order

Returns work activities of the specified work order.              <br />A work activity details information about the technician's work on a service request: the time when the technician started and finished their work, the type of activity they carried out, the number of technicians who rendered the service, and other details related to the labor performed.              <br />***Note:*** Both subscribers and providers can use this method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetWorkActivitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkActivitiesApi(config);
            var workorderId = 56;  // int | The unique numeric identifier of the work order for which you want to retrieve work activities.
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // List work activities of the specified work order
                List<SCServiceChannelServicesMessagingWorkordersWorkActivity> result = apiInstance.GetWorkActivities(workorderId, expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkActivitiesApi.GetWorkActivities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkActivitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List work activities of the specified work order
    ApiResponse<List<SCServiceChannelServicesMessagingWorkordersWorkActivity>> response = apiInstance.GetWorkActivitiesWithHttpInfo(workorderId, expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkActivitiesApi.GetWorkActivitiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | The unique numeric identifier of the work order for which you want to retrieve work activities. |  |
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingWorkordersWorkActivity&gt;**](SCServiceChannelServicesMessagingWorkordersWorkActivity.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The work activities of the specified work order are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              502 — WorkOrder not found |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getworkactivity"></a>
# **GetWorkActivity**
> SCServiceChannelServicesMessagingWorkordersWorkActivity GetWorkActivity (int workactivityId, int workorderId, string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Retrieve the specified work activity of a work order

Returns the specified work activity of a work order.              <br />A work activity details information about the technician's work on a service request: the time when the technician started and finished their work, the type of activity they carried out, the number of technicians who rendered the service, and other details related to the labor performed.              <br />***Note:*** Both subscribers and providers can use this method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetWorkActivityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkActivitiesApi(config);
            var workactivityId = 56;  // int | The unique numeric identifier of the work activity to return.
            var workorderId = 56;  // int | The unique numeric identifier of the work order for which you want to retrieve a work activity.
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Retrieve the specified work activity of a work order
                SCServiceChannelServicesMessagingWorkordersWorkActivity result = apiInstance.GetWorkActivity(workactivityId, workorderId, expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkActivitiesApi.GetWorkActivity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkActivityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve the specified work activity of a work order
    ApiResponse<SCServiceChannelServicesMessagingWorkordersWorkActivity> response = apiInstance.GetWorkActivityWithHttpInfo(workactivityId, workorderId, expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkActivitiesApi.GetWorkActivityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workactivityId** | **int** | The unique numeric identifier of the work activity to return. |  |
| **workorderId** | **int** | The unique numeric identifier of the work order for which you want to retrieve a work activity. |  |
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingWorkordersWorkActivity**](SCServiceChannelServicesMessagingWorkordersWorkActivity.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested work activity of the specified work order is in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              502 — WorkOrder not found              502 — Work activity is not found |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidworkactivities"></a>
# **WorkordersworkorderIdWorkactivities**
> void WorkordersworkorderIdWorkactivities (int workorderId, SCServiceChannelServicesMessagingWorkordersWorkActivityPostRequest activityRequest)

Create a work activity for the specified work order

Creates a new work activity for the specified work order. The work activity type can be either *Travel* or *Repair*. Note that custom types may be configured for a subscriber.              <br />Before creating a work activity, please consider the following:               • You can create work activities only for work orders in the *In Progress* primary status.               • The check-in date and time cannot be greater than the check-out date and time.               • The check-in date and time cannot be earlier than the scheduled date and time of the work order.               • The time range of the work activity you are creating cannot overlap the time ranges of existing work activities of the work order.               • The name will be set to the API caller name if the `name` value is not provided.              <br />***Note:*** Both subscribers and providers can use this method.              <br />***Note:*** Only users with extended permissions can specify the technician's name while creating a work activity. The users with extended permissions are:               • Subscribers that have the *Admin* role.               • Providers that have the *Admin* role (with the *EditLaborItemsOnWoDetailsProvider* feature flag turned on).               • Providers that have the *Business Owner / Management* role (with the *EditLaborItemsOnWoDetailsProvider* feature flag turned on).              <br />Learn more about [creating a work activity](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/576258285/Updating+Service+Provider+Check-In+Out+Information) in ServiceChannel University.              <br />**Example Request**                                POST /workorders/{workorderId}/workactivities                  {                     \"WorkTypeId\": \"1\",                            \"CheckInDate\": \"2020-11-19T11:10:36.868Z\",                     \"CheckOutDate\": \"2020-11-19T12:15:36.868Z\",                     \"Name\": \"John Doe\"                  }

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdWorkactivitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkActivitiesApi(config);
            var workorderId = 56;  // int | The unique numeric identifier of the work order for which you want to create a work activity.
            var activityRequest = new SCServiceChannelServicesMessagingWorkordersWorkActivityPostRequest(); // SCServiceChannelServicesMessagingWorkordersWorkActivityPostRequest | Request to create a work activity.

            try
            {
                // Create a work activity for the specified work order
                apiInstance.WorkordersworkorderIdWorkactivities(workorderId, activityRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkActivitiesApi.WorkordersworkorderIdWorkactivities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdWorkactivitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a work activity for the specified work order
    apiInstance.WorkordersworkorderIdWorkactivitiesWithHttpInfo(workorderId, activityRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkActivitiesApi.WorkordersworkorderIdWorkactivitiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | The unique numeric identifier of the work order for which you want to create a work activity. |  |
| **activityRequest** | [**SCServiceChannelServicesMessagingWorkordersWorkActivityPostRequest**](SCServiceChannelServicesMessagingWorkordersWorkActivityPostRequest.md) | Request to create a work activity. |  |

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
| **201** | A work activity is created for the specified work order, and a unique work activity ID is returned in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              502 — WorkOrder not found              503 — Work Type Not Found              503 — Date range is incorrect              503 — Check In/Out is premature              904 — Invalid work order status              1186 — Time range is overlapped |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **403** | You are not authorized to request this resource, or the resource is unavailable for some reason.              &lt;br/&gt;Error codes:              804 — User has no permissions to perform this action |  -  |
| **406** | The request is already processed. |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidworkactivitiesworkactivityid"></a>
# **WorkordersworkorderIdWorkactivitiesworkactivityId**
> void WorkordersworkorderIdWorkactivitiesworkactivityId (int workorderId, int workactivityId, SCServiceChannelServicesMessagingWorkordersWorkActivityRequest activityRequest)

Update the specified work activity of a work order

Updates the specified work activity of a work order by setting the check-in and check-out date and time values passed in the request.              <br />Before updating a work activity, please consider the following:               • You can update work activities only for work orders in the *In Progress* primary status.               • The check-in date and time cannot be greater than the check-out date and time.               • The check-in date and time cannot be earlier than the scheduled date and time of the work order.               • The time range of the work activity you are updating cannot overlap the time ranges of existing work activities of the work order.               • The name will be set to the API caller name if the `name` value is not provided.              <br />***Note:*** Both subscribers and providers can use this method.              <br />***Note:*** Only users with extended permissions can update the work activities created by other users along with updating the `name` parameter. The users with certain permissions are:               • Subscribers that have the *Admin* role. These users can update the work activities created both by subscribers and by providers.               • Providers that have the *Admin* role (with the *EditLaborItemsOnWoDetailsProvider* feature flag turned on). These users can update the work activities created by providers only.               • Providers that have the *Business Owner / Management* role (with the *EditLaborItemsOnWoDetailsProvider* feature flag turned on). These users can update the work activities created by providers only.              <br />Learn more about [updating a work activity](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/576258285/Updating+Service+Provider+Check-In+Out+Information) in ServiceChannel University.              <br />**Example Request**                                PUT /workorders/{workorderId}/workactivities/{workactivityId}                  {                     \"CheckInDate\": \"2020-11-19T11:10:36.868Z\",                     \"CheckOutDate\": \"2020-11-19T12:30:36.868Z\",                     \"Name\": \"John Doe\"                  }

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdWorkactivitiesworkactivityIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkActivitiesApi(config);
            var workorderId = 56;  // int | The unique numeric identifier of the work order for which you want to update a work activity.
            var workactivityId = 56;  // int | The unique numeric identifier of the work activity to update.
            var activityRequest = new SCServiceChannelServicesMessagingWorkordersWorkActivityRequest(); // SCServiceChannelServicesMessagingWorkordersWorkActivityRequest | Request to update a work activity.

            try
            {
                // Update the specified work activity of a work order
                apiInstance.WorkordersworkorderIdWorkactivitiesworkactivityId(workorderId, workactivityId, activityRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkActivitiesApi.WorkordersworkorderIdWorkactivitiesworkactivityId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdWorkactivitiesworkactivityIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update the specified work activity of a work order
    apiInstance.WorkordersworkorderIdWorkactivitiesworkactivityIdWithHttpInfo(workorderId, workactivityId, activityRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkActivitiesApi.WorkordersworkorderIdWorkactivitiesworkactivityIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | The unique numeric identifier of the work order for which you want to update a work activity. |  |
| **workactivityId** | **int** | The unique numeric identifier of the work activity to update. |  |
| **activityRequest** | [**SCServiceChannelServicesMessagingWorkordersWorkActivityRequest**](SCServiceChannelServicesMessagingWorkordersWorkActivityRequest.md) | Request to update a work activity. |  |

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
| **200** | The work activity is updated, and its ID is returned in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              502 — WorkOrder not found              503 — Work activity is not found              503 — Date range is incorrect              503 — Check In/Out is premature              904 — Invalid work order status              1186 — Time range is overlapped |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **403** | You are not authorized to request this resource, or the resource is unavailable for some reason.              &lt;br/&gt;Error codes:              804 — User has no permissions to perform this action |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidworkactivitiesworkactivityids0workactivityids0workactivityids1workactivityids1"></a>
# **WorkordersworkorderIdWorkactivitiesworkactivityIds0workactivityIds0workactivityIds1workactivityIds1**
> void WorkordersworkorderIdWorkactivitiesworkactivityIds0workactivityIds0workactivityIds1workactivityIds1 (int workorderId, List<int> workactivityIds)

Delete the specified work activities of a work order

Delete one or more work activities of the specified work order. When you pass multiple work activity IDs, the request will succeed if at least one ID is valid.              <br />***Note:*** Both subscribers and providers can use this method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdWorkactivitiesworkactivityIds0workactivityIds0workactivityIds1workactivityIds1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkActivitiesApi(config);
            var workorderId = 56;  // int | The unique numeric identifier of the work order for which you want to delete work activities.
            var workactivityIds = new List<int>(); // List<int> | The unique numeric identifiers of the work activities to delete.

            try
            {
                // Delete the specified work activities of a work order
                apiInstance.WorkordersworkorderIdWorkactivitiesworkactivityIds0workactivityIds0workactivityIds1workactivityIds1(workorderId, workactivityIds);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkActivitiesApi.WorkordersworkorderIdWorkactivitiesworkactivityIds0workactivityIds0workactivityIds1workactivityIds1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdWorkactivitiesworkactivityIds0workactivityIds0workactivityIds1workactivityIds1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete the specified work activities of a work order
    apiInstance.WorkordersworkorderIdWorkactivitiesworkactivityIds0workactivityIds0workactivityIds1workactivityIds1WithHttpInfo(workorderId, workactivityIds);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkActivitiesApi.WorkordersworkorderIdWorkactivitiesworkactivityIds0workactivityIds0workactivityIds1workactivityIds1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | The unique numeric identifier of the work order for which you want to delete work activities. |  |
| **workactivityIds** | [**List&lt;int&gt;**](int.md) | The unique numeric identifiers of the work activities to delete. |  |

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
| **204** | The specified work activities are deleted, and the response is intentionally blank. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              502 — WorkOrder not found              502 — Work activities are not found              804 — User has no permissions to perform this action |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

