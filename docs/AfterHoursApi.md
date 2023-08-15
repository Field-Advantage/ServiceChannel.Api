# ServiceChannel.Api.Api.AfterHoursApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**LocationslocationIdBusinesshours**](AfterHoursApi.md#locationslocationidbusinesshours) | **GET** /locations/{locationId}/businesshours | Retrieve Business Hours |
| [**LocationslocationIdBusinesshours_0**](AfterHoursApi.md#locationslocationidbusinesshours_0) | **POST** /locations/{locationId}/businesshours | Update business hours |
| [**LocationslocationIdHolidays**](AfterHoursApi.md#locationslocationidholidays) | **GET** /locations/{locationId}/holidays | Retrieve location holidays |
| [**LocationslocationIdHolidays_0**](AfterHoursApi.md#locationslocationidholidays_0) | **POST** /locations/{locationId}/holidays | Add a holiday |
| [**LocationslocationIdHolidaysholidayNameholidayName**](AfterHoursApi.md#locationslocationidholidaysholidaynameholidayname) | **DELETE** /locations/{locationId}/holidays | Delete a holiday |

<a id="locationslocationidbusinesshours"></a>
# **LocationslocationIdBusinesshours**
> SCServiceChannelServicesMessagingAfterHoursBusinessHoursApiResponse LocationslocationIdBusinesshours (int locationId)

Retrieve Business Hours

Returns opening and closing hours from Monday to Sunday for the specified location.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LocationslocationIdBusinesshoursExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AfterHoursApi(config);
            var locationId = 56;  // int | Unique identifier of the subscriber’s location you want to retrieve business hours for.

            try
            {
                // Retrieve Business Hours
                SCServiceChannelServicesMessagingAfterHoursBusinessHoursApiResponse result = apiInstance.LocationslocationIdBusinesshours(locationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AfterHoursApi.LocationslocationIdBusinesshours: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationslocationIdBusinesshoursWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Business Hours
    ApiResponse<SCServiceChannelServicesMessagingAfterHoursBusinessHoursApiResponse> response = apiInstance.LocationslocationIdBusinesshoursWithHttpInfo(locationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AfterHoursApi.LocationslocationIdBusinesshoursWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | Unique identifier of the subscriber’s location you want to retrieve business hours for. |  |

### Return type

[**SCServiceChannelServicesMessagingAfterHoursBusinessHoursApiResponse**](SCServiceChannelServicesMessagingAfterHoursBusinessHoursApiResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Business hours are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              601 — Location is not found |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="locationslocationidbusinesshours_0"></a>
# **LocationslocationIdBusinesshours_0**
> void LocationslocationIdBusinesshours_0 (int locationId, SCServiceChannelServicesMessagingAfterHoursUpdateLocationBusinessHoursApiModelRequest businessHoursModel)

Update business hours

Modifies the existing business hours for the specified location.              <br />Send this request [GET /locations/{locationId}/businesshours](https://developer.servicechannel.com/swagger/ui/index?version=3#/AfterHours/GETv3_locations__locationId__businesshours) to get the location business hours.              <br />Learn [how to manage business hours](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/683409418/Managing+Business+Hours+and+Holidays+for+a+Location) in ServiceChannel University.              <br />**Example Request**                                POST / locations/{locationId}/businesshours                  {                    \"businessHours\": [                      {                        \"DayOfWeek\": \"Monday\",                        \"OpenTime\": \"10:15 AM\",                        \"CloseTime\": \"06:00 PM\",                        \"ClosedAllDay\": false                      }                  }

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LocationslocationIdBusinesshours_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AfterHoursApi(config);
            var locationId = 56;  // int | Unique identifier of the subscriber’s location you want to change business hours for.
            var businessHoursModel = new SCServiceChannelServicesMessagingAfterHoursUpdateLocationBusinessHoursApiModelRequest(); // SCServiceChannelServicesMessagingAfterHoursUpdateLocationBusinessHoursApiModelRequest | Request model to update business hours.

            try
            {
                // Update business hours
                apiInstance.LocationslocationIdBusinesshours_0(locationId, businessHoursModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AfterHoursApi.LocationslocationIdBusinesshours_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationslocationIdBusinesshours_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update business hours
    apiInstance.LocationslocationIdBusinesshours_0WithHttpInfo(locationId, businessHoursModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AfterHoursApi.LocationslocationIdBusinesshours_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | Unique identifier of the subscriber’s location you want to change business hours for. |  |
| **businessHoursModel** | [**SCServiceChannelServicesMessagingAfterHoursUpdateLocationBusinessHoursApiModelRequest**](SCServiceChannelServicesMessagingAfterHoursUpdateLocationBusinessHoursApiModelRequest.md) | Request model to update business hours. |  |

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
| **200** | Business hours are updated for the specified location. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              &lt;br/&gt; 613 — Incorrect format of the Open Time or Close Time. Valid format: HH:mm or hh:mm tt (for example, 23:59 or 11:59 PM).              &lt;br/&gt; 614 — Business Hours should not overlap between days of the week              &lt;br/&gt; 615 — Incorrect format of the day of the week. Valid values: Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday.              &lt;br/&gt; 616 — Duplicate &#39;Day of the Week&#39; value;              &lt;br/&gt; 617 — Business Hours are not set for the location. For the initial setup, configure Business Hours for each day of the week.              &lt;br/&gt; 618 — Open Time or Close Time cannot be empty for a specific day of the week              &lt;br/&gt; 628 — Incorrect format of the &#x60;Close All Day&#x60; value. Valid values: true, false. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 — API call rejected by security permissions |  -  |
| **404** | The requested resource does not exist on the server.              &lt;br/&gt;Error codes:              &lt;br/&gt; 601 — Location is not found |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="locationslocationidholidays"></a>
# **LocationslocationIdHolidays**
> SCServiceChannelServicesMessagingAfterHoursHolidaysApiResponse LocationslocationIdHolidays (int locationId)

Retrieve location holidays

Returns the details of each holiday for the specified location.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LocationslocationIdHolidaysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AfterHoursApi(config);
            var locationId = 56;  // int | Unique identifier of the subscriber’s location you want to retrieve holidays for.

            try
            {
                // Retrieve location holidays
                SCServiceChannelServicesMessagingAfterHoursHolidaysApiResponse result = apiInstance.LocationslocationIdHolidays(locationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AfterHoursApi.LocationslocationIdHolidays: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationslocationIdHolidaysWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve location holidays
    ApiResponse<SCServiceChannelServicesMessagingAfterHoursHolidaysApiResponse> response = apiInstance.LocationslocationIdHolidaysWithHttpInfo(locationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AfterHoursApi.LocationslocationIdHolidaysWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | Unique identifier of the subscriber’s location you want to retrieve holidays for. |  |

### Return type

[**SCServiceChannelServicesMessagingAfterHoursHolidaysApiResponse**](SCServiceChannelServicesMessagingAfterHoursHolidaysApiResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Location holidays are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              &lt;br/&gt; 601 — Location is not found; |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 — API call rejected by security permissions |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="locationslocationidholidays_0"></a>
# **LocationslocationIdHolidays_0**
> SCServiceChannelServicesMessagingAfterHoursHolidayIdsApiResponse LocationslocationIdHolidays_0 (int locationId, SCServiceChannelServicesMessagingAfterHoursAddHolidayApiModelRequest holidayModel)

Add a holiday

Adds a holiday to the specified location.               <br />Send this request [GET /locations/{locationId}/holidays](https://developer.servicechannel.com/swagger/ui/index?version=3#/AfterHours/GETv3_locations__locationId__holidays) to get the location holidays.              <br />Learn [how to manage holidays for a location](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/683409418/Managing+Business+Hours+and+Holidays+for+a+Location) in ServiceChannel University.              <br />**Example Request**                                POST /locations/{locationId}/holidays                  {                   \"HolidayName\": \"Happy Weekend\",                   \"OpenTime\": \"10:00 AM\",                   \"CloseTime\": \"06:00 PM\",                   \"ClosedAllDay\": false,                   \"Frequency\": \"Yearly\",                   \"StartDate\": \"2021-07-03T00:10:00.308Z\",                   \"RepeatEvery\": \"1\",                   \"RepeatBy\": \"DayOfWeek\",                   \"RepeatOnDays\": [                     \"Saturday\", \"Sunday\"                   ],                   \"RepeatOnMonths\": [                     “June”, \"July\", \"August\"                   ]                  }

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LocationslocationIdHolidays_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AfterHoursApi(config);
            var locationId = 56;  // int | Unique identifier of the subscriber’s location you want to add or update holidays for.
            var holidayModel = new SCServiceChannelServicesMessagingAfterHoursAddHolidayApiModelRequest(); // SCServiceChannelServicesMessagingAfterHoursAddHolidayApiModelRequest | Request to add a holiday to the specified location.

            try
            {
                // Add a holiday
                SCServiceChannelServicesMessagingAfterHoursHolidayIdsApiResponse result = apiInstance.LocationslocationIdHolidays_0(locationId, holidayModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AfterHoursApi.LocationslocationIdHolidays_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationslocationIdHolidays_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a holiday
    ApiResponse<SCServiceChannelServicesMessagingAfterHoursHolidayIdsApiResponse> response = apiInstance.LocationslocationIdHolidays_0WithHttpInfo(locationId, holidayModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AfterHoursApi.LocationslocationIdHolidays_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | Unique identifier of the subscriber’s location you want to add or update holidays for. |  |
| **holidayModel** | [**SCServiceChannelServicesMessagingAfterHoursAddHolidayApiModelRequest**](SCServiceChannelServicesMessagingAfterHoursAddHolidayApiModelRequest.md) | Request to add a holiday to the specified location. |  |

### Return type

[**SCServiceChannelServicesMessagingAfterHoursHolidayIdsApiResponse**](SCServiceChannelServicesMessagingAfterHoursHolidayIdsApiResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The holiday is added to the specified location. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              &lt;br/&gt; 616 — Duplicate &#39;Day of the Week&#39; value              &lt;br/&gt; 619 — Incorrect format of the &#x60;Repeat by status&#x60; value. Valid values: DayOfWeek, DayOfMonth.              &lt;br/&gt; 620 — List of days cannot be empty when submitting the &#x60;Weekly&#x60; frequency              &lt;br/&gt; 621 — List of months cannot be empty when submitting the &#x60;Yearly&#x60; frequency              &lt;br/&gt; 622 — Incorrect month format. Valid values: January, February, March, April, May, June, July, August, September, October, November, December.              &lt;br/&gt; 623 — The &#x60;Holiday Name&#x60; value cannot be empty. The maximum length is 100 characters.              &lt;br/&gt; 624 — Incorrect format of the &#39;Repeat every&#39; value. The value should be a number between 1 and 60.              &lt;br/&gt; 625 — The same month is specified twice in the &#39;Month&#39; value              &lt;br/&gt; 626 — Incorrect format of the frequency. Valid values: Weekly, Monthly, Yearly, Singular.              &lt;br/&gt; 627 — Start date cannot be an empty value              &lt;br/&gt; 628 — Incorrect format of the &#x60;Close All Day&#x60; value. Valid values: true, false.              &lt;br/&gt; 3502 — The holiday name is already in use. Please suggest another name. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 — API call rejected by security permissions; |  -  |
| **404** | The requested resource does not exist on the server.              &lt;br/&gt;Error codes:              &lt;br/&gt; 601 — Location is not found |  -  |
| **500** | The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              &lt;br/&gt;501 — Object reference not set to an instance of an object; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="locationslocationidholidaysholidaynameholidayname"></a>
# **LocationslocationIdHolidaysholidayNameholidayName**
> SCServiceChannelServicesMessagingAfterHoursHolidayIdsApiResponse LocationslocationIdHolidaysholidayNameholidayName (int locationId, string holidayName)

Delete a holiday

Permanently removes a holiday from the specified location.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LocationslocationIdHolidaysholidayNameholidayNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AfterHoursApi(config);
            var locationId = 56;  // int | Unique identifier of the location to delete a holiday from.
            var holidayName = "holidayName_example";  // string | The name of the holiday you want to remove.

            try
            {
                // Delete a holiday
                SCServiceChannelServicesMessagingAfterHoursHolidayIdsApiResponse result = apiInstance.LocationslocationIdHolidaysholidayNameholidayName(locationId, holidayName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AfterHoursApi.LocationslocationIdHolidaysholidayNameholidayName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationslocationIdHolidaysholidayNameholidayNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a holiday
    ApiResponse<SCServiceChannelServicesMessagingAfterHoursHolidayIdsApiResponse> response = apiInstance.LocationslocationIdHolidaysholidayNameholidayNameWithHttpInfo(locationId, holidayName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AfterHoursApi.LocationslocationIdHolidaysholidayNameholidayNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | Unique identifier of the location to delete a holiday from. |  |
| **holidayName** | **string** | The name of the holiday you want to remove. |  |

### Return type

[**SCServiceChannelServicesMessagingAfterHoursHolidayIdsApiResponse**](SCServiceChannelServicesMessagingAfterHoursHolidayIdsApiResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ID of the deleted holiday is in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              &lt;br/&gt; 601 — Location is not found              &lt;br/&gt; 623 — The &#x60;Holiday Name&#x60; value cannot be empty. The maximum length is 100 characters.              &lt;br/&gt; 629 — The holiday doesn&#39;t exist at the location |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 — API call rejected by security permissions |  -  |
| **404** | The requested resource does not exist on the server.              &lt;br/&gt;Error codes:              &lt;br/&gt; 601 — Location is not found              &lt;br/&gt; 601 — Invalid Location Id |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

