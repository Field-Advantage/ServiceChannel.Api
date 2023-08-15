# ServiceChannel.Api.Api.ProvidersApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiProvidersGetStandingStatusproviderIdproviderId**](ProvidersApi.md#apiprovidersgetstandingstatusprovideridproviderid) | **GET** /api/providers/GetStandingStatus | Returns standing status of the provider passed |
| [**ApiProvidersInfoid**](ProvidersApi.md#apiprovidersinfoid) | **GET** /api/providers/info/{id} |  |
| [**ApiProvidersIsSdiMobileEnabledsubscriberIdsubscriberIdlocationIdlocationId**](ProvidersApi.md#apiprovidersissdimobileenabledsubscriberidsubscriberidlocationidlocationid) | **GET** /api/providers/IsSdiMobileEnabled | Allows one to get information whether the SDIMobileInt flag is enabled. |
| [**ApiProvidersproviderIdProblemtypessubscriberIdsubscriberIddashboardIddashboardIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemType**](ProvidersApi.md#apiprovidersprovideridproblemtypessubscriberidsubscriberiddashboardiddashboardidlocationidlocationidareaidareaidtradetradeproblemtypeproblemtype) | **GET** /api/providers/{providerId}/problemtypes |  |
| [**GetLast**](ProvidersApi.md#getlast) | **GET** /odata/locations({locationId})/providers/Service.GetLast(days&#x3D;{days}) | Retrieve providers feedback rating data. |
| [**GetProvider**](ProvidersApi.md#getprovider) | **GET** /odata/detailedProviders/Service.Get(providerId&#x3D;{providerId}) | Get provider by provider id. |
| [**GetRecent**](ProvidersApi.md#getrecent) | **GET** /odata/locations({locationId})/providers/Service.GetRecent(days&#x3D;{days}) | Get recent providers for the given location.              \&quot;Recent\&quot; means a provider has completed WOs for a certain time. |
| [**Providers**](ProvidersApi.md#providers) | **POST** /providers | Create blank provider |
| [**ProvidersAccountChanged**](ProvidersApi.md#providersaccountchanged) | **POST** /providers/AccountChanged |  |
| [**ProvidersCurrentProblemtypessubscriberIdsubscriberIddashboardIddashboardIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemType**](ProvidersApi.md#providerscurrentproblemtypessubscriberidsubscriberiddashboardiddashboardidlocationidlocationidareaidareaidtradetradeproblemtypeproblemtype) | **GET** /providers/current/problemtypes |  |
| [**ProvidersGetESignatureSettingsworkOrderIdworkOrderId**](ProvidersApi.md#providersgetesignaturesettingsworkorderidworkorderid) | **GET** /providers/getESignatureSettings | Receives the Electronic Signature Settings for current user (authorized provider) |
| [**ProvidersGetProviderStateproviderIdproviderId**](ProvidersApi.md#providersgetproviderstateprovideridproviderid) | **GET** /providers/getProviderState |  |
| [**ProvidersGetbytradetradetrade**](ProvidersApi.md#providersgetbytradetradetrade) | **GET** /providers/getbytrade | Providers For Subscriber User by Trade |
| [**ProvidersRemoveProviderSubscriberLink**](ProvidersApi.md#providersremoveprovidersubscriberlink) | **POST** /providers/RemoveProviderSubscriberLink | Delete provider of subscriber |
| [**ProvidersTrained**](ProvidersApi.md#providerstrained) | **POST** /providers/trained | Trained Status for Providers |
| [**ProvidersUpdateDispatchSetting**](ProvidersApi.md#providersupdatedispatchsetting) | **POST** /providers/updateDispatchSetting | Set isDoNotDispatch value for providers |
| [**ProvidersproviderIdFeedback**](ProvidersApi.md#providersprovideridfeedback) | **POST** /providers/{providerId}/feedback |  |

<a id="apiprovidersgetstandingstatusprovideridproviderid"></a>
# **ApiProvidersGetStandingStatusproviderIdproviderId**
> Object ApiProvidersGetStandingStatusproviderIdproviderId (int providerId)

Returns standing status of the provider passed

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ApiProvidersGetStandingStatusproviderIdproviderIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProvidersApi(config);
            var providerId = 56;  // int | A provider unique identifier

            try
            {
                // Returns standing status of the provider passed
                Object result = apiInstance.ApiProvidersGetStandingStatusproviderIdproviderId(providerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvidersApi.ApiProvidersGetStandingStatusproviderIdproviderId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiProvidersGetStandingStatusproviderIdproviderIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns standing status of the provider passed
    ApiResponse<Object> response = apiInstance.ApiProvidersGetStandingStatusproviderIdproviderIdWithHttpInfo(providerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvidersApi.ApiProvidersGetStandingStatusproviderIdproviderIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **providerId** | **int** | A provider unique identifier |  |

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

<a id="apiprovidersinfoid"></a>
# **ApiProvidersInfoid**
> Object ApiProvidersInfoid (int id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ApiProvidersInfoidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProvidersApi(config);
            var id = 56;  // int | 

            try
            {
                Object result = apiInstance.ApiProvidersInfoid(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvidersApi.ApiProvidersInfoid: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiProvidersInfoidWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.ApiProvidersInfoidWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvidersApi.ApiProvidersInfoidWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

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

<a id="apiprovidersissdimobileenabledsubscriberidsubscriberidlocationidlocationid"></a>
# **ApiProvidersIsSdiMobileEnabledsubscriberIdsubscriberIdlocationIdlocationId**
> Object ApiProvidersIsSdiMobileEnabledsubscriberIdsubscriberIdlocationIdlocationId (int? subscriberId = null, int? locationId = null)

Allows one to get information whether the SDIMobileInt flag is enabled.

True - if the FF is enabled for a provider and subscriber or for a provider and location.              Otherwise it returns false.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ApiProvidersIsSdiMobileEnabledsubscriberIdsubscriberIdlocationIdlocationIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProvidersApi(config);
            var subscriberId = 56;  // int? | Subscriber id (optional) 
            var locationId = 56;  // int? | Location id (optional) 

            try
            {
                // Allows one to get information whether the SDIMobileInt flag is enabled.
                Object result = apiInstance.ApiProvidersIsSdiMobileEnabledsubscriberIdsubscriberIdlocationIdlocationId(subscriberId, locationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvidersApi.ApiProvidersIsSdiMobileEnabledsubscriberIdsubscriberIdlocationIdlocationId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiProvidersIsSdiMobileEnabledsubscriberIdsubscriberIdlocationIdlocationIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Allows one to get information whether the SDIMobileInt flag is enabled.
    ApiResponse<Object> response = apiInstance.ApiProvidersIsSdiMobileEnabledsubscriberIdsubscriberIdlocationIdlocationIdWithHttpInfo(subscriberId, locationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvidersApi.ApiProvidersIsSdiMobileEnabledsubscriberIdsubscriberIdlocationIdlocationIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int?** | Subscriber id | [optional]  |
| **locationId** | **int?** | Location id | [optional]  |

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
| **200** | The request succeeded and the information is retrieved. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiprovidersprovideridproblemtypessubscriberidsubscriberiddashboardiddashboardidlocationidlocationidareaidareaidtradetradeproblemtypeproblemtype"></a>
# **ApiProvidersproviderIdProblemtypessubscriberIdsubscriberIddashboardIddashboardIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemType**
> Object ApiProvidersproviderIdProblemtypessubscriberIdsubscriberIddashboardIddashboardIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemType (int providerId, int subscriberId, int dashboardId, int locationId, int areaId, string trade, string problemType)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ApiProvidersproviderIdProblemtypessubscriberIdsubscriberIddashboardIddashboardIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProvidersApi(config);
            var providerId = 56;  // int | 
            var subscriberId = 56;  // int | 
            var dashboardId = 56;  // int | 
            var locationId = 56;  // int | 
            var areaId = 56;  // int | 
            var trade = "trade_example";  // string | 
            var problemType = "problemType_example";  // string | 

            try
            {
                Object result = apiInstance.ApiProvidersproviderIdProblemtypessubscriberIdsubscriberIddashboardIddashboardIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemType(providerId, subscriberId, dashboardId, locationId, areaId, trade, problemType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvidersApi.ApiProvidersproviderIdProblemtypessubscriberIdsubscriberIddashboardIddashboardIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemType: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiProvidersproviderIdProblemtypessubscriberIdsubscriberIddashboardIddashboardIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.ApiProvidersproviderIdProblemtypessubscriberIdsubscriberIddashboardIddashboardIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemTypeWithHttpInfo(providerId, subscriberId, dashboardId, locationId, areaId, trade, problemType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvidersApi.ApiProvidersproviderIdProblemtypessubscriberIdsubscriberIddashboardIddashboardIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemTypeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **providerId** | **int** |  |  |
| **subscriberId** | **int** |  |  |
| **dashboardId** | **int** |  |  |
| **locationId** | **int** |  |  |
| **areaId** | **int** |  |  |
| **trade** | **string** |  |  |
| **problemType** | **string** |  |  |

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

<a id="getlast"></a>
# **GetLast**
> List&lt;SCServiceChannelServicesMessagingProvidersExtendedReviewedProvider&gt; GetLast (int days, int locationId, string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Retrieve providers feedback rating data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetLastExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProvidersApi(config);
            var days = 56;  // int | 
            var locationId = 56;  // int | 
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Retrieve providers feedback rating data.
                List<SCServiceChannelServicesMessagingProvidersExtendedReviewedProvider> result = apiInstance.GetLast(days, locationId, expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvidersApi.GetLast: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLastWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve providers feedback rating data.
    ApiResponse<List<SCServiceChannelServicesMessagingProvidersExtendedReviewedProvider>> response = apiInstance.GetLastWithHttpInfo(days, locationId, expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvidersApi.GetLastWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **days** | **int** |  |  |
| **locationId** | **int** |  |  |
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingProvidersExtendedReviewedProvider&gt;**](SCServiceChannelServicesMessagingProvidersExtendedReviewedProvider.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request succeeded and providers are returned. |  -  |
| **400** | The request parameters are not valid. |  -  |
| **401** | An unauthorized request. |  -  |
| **403** | Providers cannot use this method. |  -  |
| **404** | The location wasn&#39;t found. |  -  |
| **500** | Something went wrong. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getprovider"></a>
# **GetProvider**
> SCServiceChannelServicesMessagingProvidersDetailedProvider GetProvider (int providerId, string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Get provider by provider id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetProviderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProvidersApi(config);
            var providerId = 56;  // int | 
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Get provider by provider id.
                SCServiceChannelServicesMessagingProvidersDetailedProvider result = apiInstance.GetProvider(providerId, expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvidersApi.GetProvider: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProviderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get provider by provider id.
    ApiResponse<SCServiceChannelServicesMessagingProvidersDetailedProvider> response = apiInstance.GetProviderWithHttpInfo(providerId, expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvidersApi.GetProviderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **providerId** | **int** |  |  |
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingProvidersDetailedProvider**](SCServiceChannelServicesMessagingProvidersDetailedProvider.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request succeeded and the provider is returned. |  -  |
| **401** | Unauthorized request. |  -  |
| **403** | Providers cannot use this method. |  -  |
| **404** | The provider wasn&#39;t found. |  -  |
| **500** | Something went wrong. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrecent"></a>
# **GetRecent**
> List&lt;SCServiceChannelServicesMessagingProvidersReviewedProvider&gt; GetRecent (int days, int locationId, string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Get recent providers for the given location.              \"Recent\" means a provider has completed WOs for a certain time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetRecentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProvidersApi(config);
            var days = 56;  // int | 
            var locationId = 56;  // int | 
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Get recent providers for the given location.              \"Recent\" means a provider has completed WOs for a certain time.
                List<SCServiceChannelServicesMessagingProvidersReviewedProvider> result = apiInstance.GetRecent(days, locationId, expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvidersApi.GetRecent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRecentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get recent providers for the given location.              \"Recent\" means a provider has completed WOs for a certain time.
    ApiResponse<List<SCServiceChannelServicesMessagingProvidersReviewedProvider>> response = apiInstance.GetRecentWithHttpInfo(days, locationId, expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvidersApi.GetRecentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **days** | **int** |  |  |
| **locationId** | **int** |  |  |
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingProvidersReviewedProvider&gt;**](SCServiceChannelServicesMessagingProvidersReviewedProvider.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request succeeded and providers are returned. |  -  |
| **400** | The request parameters are not valid. |  -  |
| **401** | An unauthorized request. |  -  |
| **403** | Providers cannot use this method. |  -  |
| **404** | The location wasn&#39;t found. |  -  |
| **500** | Something went wrong. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="providers"></a>
# **Providers**
> SCServiceChannelServicesMessagingProvidersCreateBlankProviderResponse Providers (SCServiceChannelServicesMessagingProvidersCreateBlankProviderRequest request)

Create blank provider

Create blank provider.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProvidersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProvidersApi(config);
            var request = new SCServiceChannelServicesMessagingProvidersCreateBlankProviderRequest(); // SCServiceChannelServicesMessagingProvidersCreateBlankProviderRequest | 

            try
            {
                // Create blank provider
                SCServiceChannelServicesMessagingProvidersCreateBlankProviderResponse result = apiInstance.Providers(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvidersApi.Providers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProvidersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create blank provider
    ApiResponse<SCServiceChannelServicesMessagingProvidersCreateBlankProviderResponse> response = apiInstance.ProvidersWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvidersApi.ProvidersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingProvidersCreateBlankProviderRequest**](SCServiceChannelServicesMessagingProvidersCreateBlankProviderRequest.md) |  |  |

### Return type

[**SCServiceChannelServicesMessagingProvidersCreateBlankProviderResponse**](SCServiceChannelServicesMessagingProvidersCreateBlankProviderResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 103 - Provider already exists;              &lt;br/&gt; 802 - Invalid user name;              &lt;br/&gt; 806 - User already exists;              &lt;br/&gt; 1150 - User does not exist; |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="providersaccountchanged"></a>
# **ProvidersAccountChanged**
> string ProvidersAccountChanged (SCServiceChannelServicesMessagingProvidersProviderAccountChangedRequest request)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProvidersAccountChangedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProvidersApi(config);
            var request = new SCServiceChannelServicesMessagingProvidersProviderAccountChangedRequest(); // SCServiceChannelServicesMessagingProvidersProviderAccountChangedRequest | 

            try
            {
                string result = apiInstance.ProvidersAccountChanged(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvidersApi.ProvidersAccountChanged: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProvidersAccountChangedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.ProvidersAccountChangedWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvidersApi.ProvidersAccountChangedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingProvidersProviderAccountChangedRequest**](SCServiceChannelServicesMessagingProvidersProviderAccountChangedRequest.md) |  |  |

### Return type

**string**

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

<a id="providerscurrentproblemtypessubscriberidsubscriberiddashboardiddashboardidlocationidlocationidareaidareaidtradetradeproblemtypeproblemtype"></a>
# **ProvidersCurrentProblemtypessubscriberIdsubscriberIddashboardIddashboardIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemType**
> Object ProvidersCurrentProblemtypessubscriberIdsubscriberIddashboardIddashboardIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemType (int subscriberId, int dashboardId, int locationId, int areaId, string trade, string problemType)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProvidersCurrentProblemtypessubscriberIdsubscriberIddashboardIddashboardIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProvidersApi(config);
            var subscriberId = 56;  // int | 
            var dashboardId = 56;  // int | 
            var locationId = 56;  // int | 
            var areaId = 56;  // int | 
            var trade = "trade_example";  // string | 
            var problemType = "problemType_example";  // string | 

            try
            {
                Object result = apiInstance.ProvidersCurrentProblemtypessubscriberIdsubscriberIddashboardIddashboardIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemType(subscriberId, dashboardId, locationId, areaId, trade, problemType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvidersApi.ProvidersCurrentProblemtypessubscriberIdsubscriberIddashboardIddashboardIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemType: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProvidersCurrentProblemtypessubscriberIdsubscriberIddashboardIddashboardIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.ProvidersCurrentProblemtypessubscriberIdsubscriberIddashboardIddashboardIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemTypeWithHttpInfo(subscriberId, dashboardId, locationId, areaId, trade, problemType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvidersApi.ProvidersCurrentProblemtypessubscriberIdsubscriberIddashboardIddashboardIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemTypeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** |  |  |
| **dashboardId** | **int** |  |  |
| **locationId** | **int** |  |  |
| **areaId** | **int** |  |  |
| **trade** | **string** |  |  |
| **problemType** | **string** |  |  |

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

<a id="providersgetesignaturesettingsworkorderidworkorderid"></a>
# **ProvidersGetESignatureSettingsworkOrderIdworkOrderId**
> SCServiceChannelServicesMessagingProvidersGetESignatureSettingsResponse ProvidersGetESignatureSettingsworkOrderIdworkOrderId (int workOrderId)

Receives the Electronic Signature Settings for current user (authorized provider)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProvidersGetESignatureSettingsworkOrderIdworkOrderIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProvidersApi(config);
            var workOrderId = 56;  // int | Work order id

            try
            {
                // Receives the Electronic Signature Settings for current user (authorized provider)
                SCServiceChannelServicesMessagingProvidersGetESignatureSettingsResponse result = apiInstance.ProvidersGetESignatureSettingsworkOrderIdworkOrderId(workOrderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvidersApi.ProvidersGetESignatureSettingsworkOrderIdworkOrderId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProvidersGetESignatureSettingsworkOrderIdworkOrderIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Receives the Electronic Signature Settings for current user (authorized provider)
    ApiResponse<SCServiceChannelServicesMessagingProvidersGetESignatureSettingsResponse> response = apiInstance.ProvidersGetESignatureSettingsworkOrderIdworkOrderIdWithHttpInfo(workOrderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvidersApi.ProvidersGetESignatureSettingsworkOrderIdworkOrderIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrderId** | **int** | Work order id |  |

### Return type

[**SCServiceChannelServicesMessagingProvidersGetESignatureSettingsResponse**](SCServiceChannelServicesMessagingProvidersGetESignatureSettingsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request succeeded and the information is retrieved. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 101 - Invalid provider id passed;              &lt;br/&gt; 401 - Invalid subscriber Id;              &lt;br/&gt; 803 - Not provider user;              &lt;br/&gt; 947 - Work order not found;              &lt;br/&gt; 2105 - Feature ReqElecSig is Off; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="providersgetproviderstateprovideridproviderid"></a>
# **ProvidersGetProviderStateproviderIdproviderId**
> Object ProvidersGetProviderStateproviderIdproviderId (int providerId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProvidersGetProviderStateproviderIdproviderIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProvidersApi(config);
            var providerId = 56;  // int | 

            try
            {
                Object result = apiInstance.ProvidersGetProviderStateproviderIdproviderId(providerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvidersApi.ProvidersGetProviderStateproviderIdproviderId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProvidersGetProviderStateproviderIdproviderIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.ProvidersGetProviderStateproviderIdproviderIdWithHttpInfo(providerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvidersApi.ProvidersGetProviderStateproviderIdproviderIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **providerId** | **int** |  |  |

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

<a id="providersgetbytradetradetrade"></a>
# **ProvidersGetbytradetradetrade**
> List&lt;SCServiceChannelServicesMessagingProvidersProviderInfo&gt; ProvidersGetbytradetradetrade (string trade)

Providers For Subscriber User by Trade

List of Providers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProvidersGetbytradetradetradeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProvidersApi(config);
            var trade = "trade_example";  // string | 

            try
            {
                // Providers For Subscriber User by Trade
                List<SCServiceChannelServicesMessagingProvidersProviderInfo> result = apiInstance.ProvidersGetbytradetradetrade(trade);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvidersApi.ProvidersGetbytradetradetrade: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProvidersGetbytradetradetradeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Providers For Subscriber User by Trade
    ApiResponse<List<SCServiceChannelServicesMessagingProvidersProviderInfo>> response = apiInstance.ProvidersGetbytradetradetradeWithHttpInfo(trade);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvidersApi.ProvidersGetbytradetradetradeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **trade** | **string** |  |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingProvidersProviderInfo&gt;**](SCServiceChannelServicesMessagingProvidersProviderInfo.md)

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

<a id="providersremoveprovidersubscriberlink"></a>
# **ProvidersRemoveProviderSubscriberLink**
> SCServiceChannelServicesMessagingProvidersCreateBlankProviderResponse ProvidersRemoveProviderSubscriberLink (SCServiceChannelServicesMessagingProvidersRemoveProviderSubscriberLinkRequest request)

Delete provider of subscriber

Delete provider of subscriber.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProvidersRemoveProviderSubscriberLinkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProvidersApi(config);
            var request = new SCServiceChannelServicesMessagingProvidersRemoveProviderSubscriberLinkRequest(); // SCServiceChannelServicesMessagingProvidersRemoveProviderSubscriberLinkRequest | 

            try
            {
                // Delete provider of subscriber
                SCServiceChannelServicesMessagingProvidersCreateBlankProviderResponse result = apiInstance.ProvidersRemoveProviderSubscriberLink(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvidersApi.ProvidersRemoveProviderSubscriberLink: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProvidersRemoveProviderSubscriberLinkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete provider of subscriber
    ApiResponse<SCServiceChannelServicesMessagingProvidersCreateBlankProviderResponse> response = apiInstance.ProvidersRemoveProviderSubscriberLinkWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvidersApi.ProvidersRemoveProviderSubscriberLinkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingProvidersRemoveProviderSubscriberLinkRequest**](SCServiceChannelServicesMessagingProvidersRemoveProviderSubscriberLinkRequest.md) |  |  |

### Return type

[**SCServiceChannelServicesMessagingProvidersCreateBlankProviderResponse**](SCServiceChannelServicesMessagingProvidersCreateBlankProviderResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 100 - Invalid provider id passed;              &lt;br/&gt; 400 - Invalid subscriber id passed;              &lt;br/&gt; 503 - Empty Request;              &lt;br/&gt; 500 - Provider subscriber link has not been deleted;              &lt;br/&gt; 1217 - Proccess provider subscriber link error text; |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="providerstrained"></a>
# **ProvidersTrained**
> List&lt;SCServiceChannelServicesMessagingProvidersGetTrainedProvidersResponse&gt; ProvidersTrained (SCServiceChannelServicesMessagingProvidersGetTrainedProvidersRequest request)

Trained Status for Providers

List Provider Trained Statuses.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProvidersTrainedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProvidersApi(config);
            var request = new SCServiceChannelServicesMessagingProvidersGetTrainedProvidersRequest(); // SCServiceChannelServicesMessagingProvidersGetTrainedProvidersRequest | 

            try
            {
                // Trained Status for Providers
                List<SCServiceChannelServicesMessagingProvidersGetTrainedProvidersResponse> result = apiInstance.ProvidersTrained(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvidersApi.ProvidersTrained: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProvidersTrainedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Trained Status for Providers
    ApiResponse<List<SCServiceChannelServicesMessagingProvidersGetTrainedProvidersResponse>> response = apiInstance.ProvidersTrainedWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvidersApi.ProvidersTrainedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingProvidersGetTrainedProvidersRequest**](SCServiceChannelServicesMessagingProvidersGetTrainedProvidersRequest.md) |  |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingProvidersGetTrainedProvidersResponse&gt;**](SCServiceChannelServicesMessagingProvidersGetTrainedProvidersResponse.md)

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

<a id="providersupdatedispatchsetting"></a>
# **ProvidersUpdateDispatchSetting**
> Object ProvidersUpdateDispatchSetting (SCServiceChannelServicesWebApiModelsUpdateDispatchSettingModel updateDispatchSettingModel)

Set isDoNotDispatch value for providers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProvidersUpdateDispatchSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProvidersApi(config);
            var updateDispatchSettingModel = new SCServiceChannelServicesWebApiModelsUpdateDispatchSettingModel(); // SCServiceChannelServicesWebApiModelsUpdateDispatchSettingModel | 

            try
            {
                // Set isDoNotDispatch value for providers
                Object result = apiInstance.ProvidersUpdateDispatchSetting(updateDispatchSettingModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvidersApi.ProvidersUpdateDispatchSetting: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProvidersUpdateDispatchSettingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set isDoNotDispatch value for providers
    ApiResponse<Object> response = apiInstance.ProvidersUpdateDispatchSettingWithHttpInfo(updateDispatchSettingModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvidersApi.ProvidersUpdateDispatchSettingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateDispatchSettingModel** | [**SCServiceChannelServicesWebApiModelsUpdateDispatchSettingModel**](SCServiceChannelServicesWebApiModelsUpdateDispatchSettingModel.md) |  |  |

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

<a id="providersprovideridfeedback"></a>
# **ProvidersproviderIdFeedback**
> Object ProvidersproviderIdFeedback (int providerId, SCServiceChannelServicesMessagingProvidersProviderFeedbackRequest request)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProvidersproviderIdFeedbackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProvidersApi(config);
            var providerId = 56;  // int | 
            var request = new SCServiceChannelServicesMessagingProvidersProviderFeedbackRequest(); // SCServiceChannelServicesMessagingProvidersProviderFeedbackRequest | 

            try
            {
                Object result = apiInstance.ProvidersproviderIdFeedback(providerId, request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvidersApi.ProvidersproviderIdFeedback: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProvidersproviderIdFeedbackWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.ProvidersproviderIdFeedbackWithHttpInfo(providerId, request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvidersApi.ProvidersproviderIdFeedbackWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **providerId** | **int** |  |  |
| **request** | [**SCServiceChannelServicesMessagingProvidersProviderFeedbackRequest**](SCServiceChannelServicesMessagingProvidersProviderFeedbackRequest.md) |  |  |

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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

