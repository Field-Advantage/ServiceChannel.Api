# ServiceChannel.Api.Api.CategoriesApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Categories**](CategoriesApi.md#categories) | **POST** /categories | Create a new category |
| [**CategoriesGlcodeslocationIdlocationIdtradetrade**](CategoriesApi.md#categoriesglcodeslocationidlocationidtradetrade) | **GET** /categories/glcodes | List categories that have a GL code mapping with a trade |
| [**CategoriesPrimary**](CategoriesApi.md#categoriesprimary) | **GET** /categories/primary | Retrieve primary categories |
| [**CategoriessubscriberIds0subscriberIds0subscriberIds1subscriberIds1**](CategoriesApi.md#categoriessubscriberids0subscriberids0subscriberids1subscriberids1) | **GET** /categories | Retrieve categories |

<a id="categories"></a>
# **Categories**
> SCServiceChannelServicesMessagingCategoryAddCategoryResponse Categories (SCServiceChannelServicesMessagingCategoryAddCategoryRequest request)

Create a new category

Creates a new work order category within a primary category.              <br />For more information, refer to [Managing categories](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/556302506/Managing+Categories) in ServiceChannel University.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class CategoriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesApi(config);
            var request = new SCServiceChannelServicesMessagingCategoryAddCategoryRequest(); // SCServiceChannelServicesMessagingCategoryAddCategoryRequest | Request to create a new category within a primary category. To get the primary category ID, use the [GET /categories/primary](https://developer.servicechannel.com/swagger/ui/index?version=3#/Categories/GETv3_categories_primary) method.

            try
            {
                // Create a new category
                SCServiceChannelServicesMessagingCategoryAddCategoryResponse result = apiInstance.Categories(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.Categories: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CategoriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new category
    ApiResponse<SCServiceChannelServicesMessagingCategoryAddCategoryResponse> response = apiInstance.CategoriesWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoriesApi.CategoriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingCategoryAddCategoryRequest**](SCServiceChannelServicesMessagingCategoryAddCategoryRequest.md) | Request to create a new category within a primary category. To get the primary category ID, use the [GET /categories/primary](https://developer.servicechannel.com/swagger/ui/index?version&#x3D;3#/Categories/GETv3_categories_primary) method. |  |

### Return type

[**SCServiceChannelServicesMessagingCategoryAddCategoryResponse**](SCServiceChannelServicesMessagingCategoryAddCategoryResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The new category has been created. |  -  |
| **403** | You are not authorized to request this resource, or the resource is unavailable for some reason.              &lt;br/&gt;Error codes:              100 — User has no rights to perform this action |  -  |
| **500** | The server was unable to complete the request due to an internal error.              &lt;br/&gt; Error codes:              501 — Category already exists              501 — Object reference is not set to an instance of an object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="categoriesglcodeslocationidlocationidtradetrade"></a>
# **CategoriesGlcodeslocationIdlocationIdtradetrade**
> List&lt;SCServiceChannelApiModelProposalsCategoryGLCode&gt; CategoriesGlcodeslocationIdlocationIdtradetrade (int locationId, string trade)

List categories that have a GL code mapping with a trade

Returns categories that have GL codes associated with the specified trade. Learn more about [managing GL codes](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/557645834/Managing+GL+Codes) in ServiceChannel University.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class CategoriesGlcodeslocationIdlocationIdtradetradeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesApi(config);
            var locationId = 56;  // int | Unique numeric identifier of the location for which you want to retrieve categories that have a GL code mapping with the trade.
            var trade = "trade_example";  // string | Trade to retrieve categories with their associated GL codes for.

            try
            {
                // List categories that have a GL code mapping with a trade
                List<SCServiceChannelApiModelProposalsCategoryGLCode> result = apiInstance.CategoriesGlcodeslocationIdlocationIdtradetrade(locationId, trade);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.CategoriesGlcodeslocationIdlocationIdtradetrade: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CategoriesGlcodeslocationIdlocationIdtradetradeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List categories that have a GL code mapping with a trade
    ApiResponse<List<SCServiceChannelApiModelProposalsCategoryGLCode>> response = apiInstance.CategoriesGlcodeslocationIdlocationIdtradetradeWithHttpInfo(locationId, trade);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoriesApi.CategoriesGlcodeslocationIdlocationIdtradetradeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | Unique numeric identifier of the location for which you want to retrieve categories that have a GL code mapping with the trade. |  |
| **trade** | **string** | Trade to retrieve categories with their associated GL codes for. |  |

### Return type

[**List&lt;SCServiceChannelApiModelProposalsCategoryGLCode&gt;**](SCServiceChannelApiModelProposalsCategoryGLCode.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Categories with GL codes for the specified trade and location are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              &lt;br/&gt;504 — API call rejected by security permissions              &lt;br/&gt;601 — Location is not found              &lt;br/&gt;701 — Invalid trade |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="categoriesprimary"></a>
# **CategoriesPrimary**
> SCServiceChannelServicesMessagingCategoryPrimaryCategoryResponse CategoriesPrimary ()

Retrieve primary categories

Returns a list of available primary categories of the current subscriber.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class CategoriesPrimaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesApi(config);

            try
            {
                // Retrieve primary categories
                SCServiceChannelServicesMessagingCategoryPrimaryCategoryResponse result = apiInstance.CategoriesPrimary();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.CategoriesPrimary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CategoriesPrimaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve primary categories
    ApiResponse<SCServiceChannelServicesMessagingCategoryPrimaryCategoryResponse> response = apiInstance.CategoriesPrimaryWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoriesApi.CategoriesPrimaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SCServiceChannelServicesMessagingCategoryPrimaryCategoryResponse**](SCServiceChannelServicesMessagingCategoryPrimaryCategoryResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested list of primary categories is in the response. |  -  |
| **403** | You are not authorized to request this resource, or the resource is unavailable for some reason.              &lt;br/&gt;Error codes:               100 — User has no rights to perform this action |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="categoriessubscriberids0subscriberids0subscriberids1subscriberids1"></a>
# **CategoriessubscriberIds0subscriberIds0subscriberIds1subscriberIds1**
> List&lt;SCServiceChannelServicesMessagingCategoryCategoryResponse&gt; CategoriessubscriberIds0subscriberIds0subscriberIds1subscriberIds1 (List<int>? subscriberIds = null)

Retrieve categories

Returns a list of available work order categories for one or several subscribers. Only a parent subscriber can get categories for child subscribers.              <br />You can create a new category via the [POST /categories](https://developer.servicechannel.com/swagger/ui/index#/Categories/POSTv3_categories) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class CategoriessubscriberIds0subscriberIds0subscriberIds1subscriberIds1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CategoriesApi(config);
            var subscriberIds = new List<int>?(); // List<int>? | Unique numeric ID of the subscriber you want to retrieve categories for. By default, the current subscriber ID is set. (optional) 

            try
            {
                // Retrieve categories
                List<SCServiceChannelServicesMessagingCategoryCategoryResponse> result = apiInstance.CategoriessubscriberIds0subscriberIds0subscriberIds1subscriberIds1(subscriberIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.CategoriessubscriberIds0subscriberIds0subscriberIds1subscriberIds1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CategoriessubscriberIds0subscriberIds0subscriberIds1subscriberIds1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve categories
    ApiResponse<List<SCServiceChannelServicesMessagingCategoryCategoryResponse>> response = apiInstance.CategoriessubscriberIds0subscriberIds0subscriberIds1subscriberIds1WithHttpInfo(subscriberIds);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoriesApi.CategoriessubscriberIds0subscriberIds0subscriberIds1subscriberIds1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberIds** | [**List&lt;int&gt;?**](int.md) | Unique numeric ID of the subscriber you want to retrieve categories for. By default, the current subscriber ID is set. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingCategoryCategoryResponse&gt;**](SCServiceChannelServicesMessagingCategoryCategoryResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested list of categories is in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              401 — Invalid subscriber ID |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **403** | You are not authorized to request this resource, or the resource is unavailable for some reason.              &lt;br/&gt;Error codes:               100 — User has no rights to perform this action |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

