# ServiceChannel.Api.Api.IssueListApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiSubscriberssubscriberIdIssuelistHeaders**](IssueListApi.md#apisubscriberssubscriberidissuelistheaders) | **GET** /api/subscribers/{subscriberId}/issuelist/headers |  |
| [**ApiSubscriberssubscriberIdIssuelists**](IssueListApi.md#apisubscriberssubscriberidissuelists) | **POST** /api/subscribers/{subscriberId}/issuelists | The post. |
| [**ApiSubscriberssubscriberIdIssuelistsHistorypageIndexpageIndexpageSizepageSize**](IssueListApi.md#apisubscriberssubscriberidissuelistshistorypageindexpageindexpagesizepagesize) | **GET** /api/subscribers/{subscriberId}/issuelists/history | The get issue list history. |
| [**ApiSubscriberssubscriberIdIssuelistspageIndexpageIndexpageSizepageSize**](IssueListApi.md#apisubscriberssubscriberidissuelistspageindexpageindexpagesizepagesize) | **GET** /api/subscribers/{subscriberId}/issuelists | The post. |
| [**ApiSubscriberssubscriberIdStoredashboardsIssuelistItemsequipmentTypeequipmentTypelocationIdlocationIdsetupIdsetupId**](IssueListApi.md#apisubscriberssubscriberidstoredashboardsissuelistitemsequipmenttypeequipmenttypelocationidlocationidsetupidsetupid) | **GET** /api/subscribers/{subscriberId}/storedashboards/issuelist/items | The get. |
| [**ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelist**](IssueListApi.md#apisubscriberssubscriberidstoredashboardsdashboardidissuelist) | **GET** /api/subscribers/{subscriberId}/storedashboards/{dashboardId}/issuelist | The get. |
| [**ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistAreasareaIdItemsproblemTypeproblemTypelocationIdlocationId**](IssueListApi.md#apisubscriberssubscriberidstoredashboardsdashboardidissuelistareasareaiditemsproblemtypeproblemtypelocationidlocationid) | **GET** /api/subscribers/{subscriberId}/storedashboards/{dashboardId}/issuelist/areas/{areaId}/items | The get items filtered by area type and location. |
| [**ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistAreasareaIdProblemsproblemTypeproblemTypeitemitem**](IssueListApi.md#apisubscriberssubscriberidstoredashboardsdashboardidissuelistareasareaidproblemsproblemtypeproblemtypeitemitem) | **GET** /api/subscribers/{subscriberId}/storedashboards/{dashboardId}/issuelist/areas/{areaId}/problems | The get problems filtered by area type and location. |
| [**ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistAreasareaIdProblemtypes**](IssueListApi.md#apisubscriberssubscriberidstoredashboardsdashboardidissuelistareasareaidproblemtypes) | **GET** /api/subscribers/{subscriberId}/storedashboards/{dashboardId}/issuelist/areas/{areaId}/problemtypes | The get problem types. |
| [**ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistFields**](IssueListApi.md#apisubscriberssubscriberidstoredashboardsdashboardidissuelistfields) | **GET** /api/subscribers/{subscriberId}/storedashboards/{dashboardId}/issuelist/fields | The get global fields. |
| [**ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistIssuechoice**](IssueListApi.md#apisubscriberssubscriberidstoredashboardsdashboardidissuelistissuechoice) | **GET** /api/subscribers/{subscriberId}/storedashboards/{dashboardId}/issuelist/issuechoice | The get issue choice. |
| [**ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistIssuechoiceFieldsproblemTypeproblemTypeitemitemproblemproblem**](IssueListApi.md#apisubscriberssubscriberidstoredashboardsdashboardidissuelistissuechoicefieldsproblemtypeproblemtypeitemitemproblemproblem) | **GET** /api/subscribers/{subscriberId}/storedashboards/{dashboardId}/issuelist/issuechoice/fields | The get issue choice fiels. |
| [**ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistissueListId**](IssueListApi.md#apisubscriberssubscriberidstoredashboardsdashboardidissuelistissuelistid) | **PUT** /api/subscribers/{subscriberId}/storedashboards/{dashboardId}/issuelist/{issueListId} | The set issue list for dashboard. |
| [**IssuelistAreaslocationIdlocationIdsetupIdsetupId**](IssueListApi.md#issuelistareaslocationidlocationidsetupidsetupid) | **GET** /issuelist/areas | Get Areas |
| [**IssuelistFieldididsetupIdsetupId**](IssueListApi.md#issuelistfieldididsetupidsetupid) | **GET** /issuelist/field |  |
| [**IssuelistGlobalfieldslocationIdlocationIdsubscriberIdsubscriberIdsetupIdsetupId**](IssueListApi.md#issuelistglobalfieldslocationidlocationidsubscriberidsubscriberidsetupidsetupid) | **GET** /issuelist/globalfields | The get global fields. Authorized version of &#39;storedashboards/{dashboardId:int}/issuelist/fields&#39; |
| [**IssuelistIssuechoiceinfotrackingNumber**](IssueListApi.md#issuelistissuechoiceinfotrackingnumber) | **GET** /issuelist/issuechoiceinfo/{trackingNumber} | The get issue choice info. |
| [**IssuelistIssuechoiceproblemTypeproblemTypeequipmentTypeequipmentTypeproblemCodeproblemCodelocationIdlocationIdsetupIdsetupId**](IssueListApi.md#issuelistissuechoiceproblemtypeproblemtypeequipmenttypeequipmenttypeproblemcodeproblemcodelocationidlocationidsetupidsetupid) | **GET** /issuelist/issuechoice |  |
| [**IssuelistItemslocationIdlocationIdareaIdareaIdproblemTypeproblemTypesetupIdsetupId**](IssueListApi.md#issuelistitemslocationidlocationidareaidareaidproblemtypeproblemtypesetupidsetupid) | **GET** /issuelist/items | Get Equipment items |
| [**IssuelistProblemsareaIdareaIdproblemTypeproblemTypeequipmentTypeequipmentTypelocationIdlocationIdsetupIdsetupId**](IssueListApi.md#issuelistproblemsareaidareaidproblemtypeproblemtypeequipmenttypeequipmenttypelocationidlocationidsetupidsetupid) | **GET** /issuelist/problems | Get Problem codes |
| [**IssuelistProblemtypesareaIdareaIdlocationIdlocationIdsetupIdsetupIdsubscriberIdsubscriberId**](IssueListApi.md#issuelistproblemtypesareaidareaidlocationidlocationidsetupidsetupidsubscriberidsubscriberid) | **GET** /issuelist/problemtypes | Get Problem types |
| [**ProvidersCurrentApplicationissuelistAreasareaIdProblemtypeslocationIdlocationIdsetupIdsetupIdsubscriberIdsubscriberId**](IssueListApi.md#providerscurrentapplicationissuelistareasareaidproblemtypeslocationidlocationidsetupidsetupidsubscriberidsubscriberid) | **GET** /providers/current/applicationissuelist/areas/{areaId}/problemtypes | Get Problem types |
| [**ProvidersCurrentApplicationissuelistIssueitemssubscriberIdsubscriberIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemType**](IssueListApi.md#providerscurrentapplicationissuelistissueitemssubscriberidsubscriberidlocationidlocationidareaidareaidtradetradeproblemtypeproblemtype) | **GET** /providers/current/applicationissuelist/issueitems |  |
| [**ProvidersCurrentSubscriberssubscriberIdApplicationissuelistAreaslocationIdlocationId**](IssueListApi.md#providerscurrentsubscriberssubscriberidapplicationissuelistareaslocationidlocationid) | **GET** /providers/current/subscribers/{subscriberId}/applicationissuelist/areas | Get Areas |
| [**ProvidersCurrentSubscriberssubscriberIdApplicationissuelistGlobalfieldslocationIdlocationId**](IssueListApi.md#providerscurrentsubscriberssubscriberidapplicationissuelistglobalfieldslocationidlocationid) | **GET** /providers/current/subscribers/{subscriberId}/applicationissuelist/globalfields | The get global fields. Authorized version of &#39;storedashboards/{dashboardId:int}/issuelist/fields&#39; |
| [**ProvidersCurrentSubscriberssubscriberIdApplicationissuelistItemslocationIdlocationIdareaIdareaIdproblemTypeproblemType**](IssueListApi.md#providerscurrentsubscriberssubscriberidapplicationissuelistitemslocationidlocationidareaidareaidproblemtypeproblemtype) | **GET** /providers/current/subscribers/{subscriberId}/applicationissuelist/items | Get Equipment items |
| [**ProvidersCurrentSubscriberssubscriberIdApplicationissuelistProblemsareaIdareaIdproblemTypeproblemTypeequipmentTypeequipmentTypelocationIdlocationId**](IssueListApi.md#providerscurrentsubscriberssubscriberidapplicationissuelistproblemsareaidareaidproblemtypeproblemtypeequipmenttypeequipmenttypelocationidlocationid) | **GET** /providers/current/subscribers/{subscriberId}/applicationissuelist/problems | Get Problem codes |
| [**ProvidersCurrentSubscriberssubscriberIdIssuelistassetIdassetIdlocationIdlocationId**](IssueListApi.md#providerscurrentsubscriberssubscriberidissuelistassetidassetidlocationidlocationid) | **GET** /providers/current/subscribers/{subscriberId}/issuelist | Retrieves the issue list for a FTM provider |
| [**ProvidersCurrentSubscribersubscriberIdLocationlocationIdApplicationissuelistProblemtypes**](IssueListApi.md#providerscurrentsubscribersubscriberidlocationlocationidapplicationissuelistproblemtypes) | **GET** /providers/current/subscriber/{subscriberId}/location/{locationId}/applicationissuelist/problemtypes |  |
| [**SubscribersCurrentDashboardsetupIdIssuelistEquipmenttypesareaIdareaIdproblemTypeproblemType**](IssueListApi.md#subscriberscurrentdashboardsetupidissuelistequipmenttypesareaidareaidproblemtypeproblemtype) | **GET** /subscribers/current/dashboard/{setupId}/issuelist/equipmenttypes | Get Equipment items not filtered by location. |
| [**SubscribersCurrentStoredashboardsCurrentIssuelistAreasareaIdEquipmenttypeslocationIdlocationIdproblemTypeproblemTypesetupIdsetupId**](IssueListApi.md#subscriberscurrentstoredashboardscurrentissuelistareasareaidequipmenttypeslocationidlocationidproblemtypeproblemtypesetupidsetupid) | **GET** /subscribers/current/storedashboards/current/issuelist/areas/{areaId}/equipmenttypes | Get Equipment items |
| [**SubscribersCurrentStoredashboardsCurrentIssuelistAreasareaIdProblemcodesproblemTypeproblemTypeequipmentTypeequipmentTypelocationIdlocationIdsetupIdsetupId**](IssueListApi.md#subscriberscurrentstoredashboardscurrentissuelistareasareaidproblemcodesproblemtypeproblemtypeequipmenttypeequipmenttypelocationidlocationidsetupidsetupid) | **GET** /subscribers/current/storedashboards/current/issuelist/areas/{areaId}/problemcodes | Get Problem codes |
| [**SubscribersCurrentStoredashboardsCurrentIssuelistAreasareaIdProblemtypeslocationIdlocationIdsetupIdsetupIdsubscriberIdsubscriberId**](IssueListApi.md#subscriberscurrentstoredashboardscurrentissuelistareasareaidproblemtypeslocationidlocationidsetupidsetupidsubscriberidsubscriberid) | **GET** /subscribers/current/storedashboards/current/issuelist/areas/{areaId}/problemtypes | Get Problem types |
| [**SubscribersCurrentStoredashboardsCurrentIssuelistAreaslocationIdlocationIdsetupIdsetupId**](IssueListApi.md#subscriberscurrentstoredashboardscurrentissuelistareaslocationidlocationidsetupidsetupid) | **GET** /subscribers/current/storedashboards/current/issuelist/areas | Get Areas |
| [**SubscribersCurrentStoredashboardsCurrentIssuelistFieldididsetupIdsetupId**](IssueListApi.md#subscriberscurrentstoredashboardscurrentissuelistfieldididsetupidsetupid) | **GET** /subscribers/current/storedashboards/current/issuelist/field |  |
| [**SubscribersCurrentStoredashboardsCurrentIssuelistIssuechoiceproblemTypeproblemTypeequipmentTypeequipmentTypeproblemCodeproblemCodelocationIdlocationIdsetupIdsetupId**](IssueListApi.md#subscriberscurrentstoredashboardscurrentissuelistissuechoiceproblemtypeproblemtypeequipmenttypeequipmenttypeproblemcodeproblemcodelocationidlocationidsetupidsetupid) | **GET** /subscribers/current/storedashboards/current/issuelist/issuechoice |  |
| [**SubscribersCurrentStoredashboardsCurrentIssuelistSpecificIssuechoiceSubscriberIdSubscriberIdDashboardSetupIdDashboardSetupIdTradeTradePriorityPriorityCategoryCategory**](IssueListApi.md#subscriberscurrentstoredashboardscurrentissuelistspecificissuechoicesubscriberidsubscriberiddashboardsetupiddashboardsetupidtradetradepriorityprioritycategorycategory) | **GET** /subscribers/current/storedashboards/current/issuelist/specific/issuechoice | Get specific issue choice |

<a id="apisubscriberssubscriberidissuelistheaders"></a>
# **ApiSubscriberssubscriberIdIssuelistHeaders**
> Object ApiSubscriberssubscriberIdIssuelistHeaders (int subscriberId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ApiSubscriberssubscriberIdIssuelistHeadersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var subscriberId = 56;  // int | 

            try
            {
                Object result = apiInstance.ApiSubscriberssubscriberIdIssuelistHeaders(subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.ApiSubscriberssubscriberIdIssuelistHeaders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSubscriberssubscriberIdIssuelistHeadersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.ApiSubscriberssubscriberIdIssuelistHeadersWithHttpInfo(subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.ApiSubscriberssubscriberIdIssuelistHeadersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** |  |  |

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

<a id="apisubscriberssubscriberidissuelists"></a>
# **ApiSubscriberssubscriberIdIssuelists**
> Object ApiSubscriberssubscriberIdIssuelists (string subscriberId, SCServiceChannelServicesMessagingIssueListsPostIssueListRequest request)

The post.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ApiSubscriberssubscriberIdIssuelistsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var subscriberId = "subscriberId_example";  // string | 
            var request = new SCServiceChannelServicesMessagingIssueListsPostIssueListRequest(); // SCServiceChannelServicesMessagingIssueListsPostIssueListRequest | The request.

            try
            {
                // The post.
                Object result = apiInstance.ApiSubscriberssubscriberIdIssuelists(subscriberId, request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.ApiSubscriberssubscriberIdIssuelists: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSubscriberssubscriberIdIssuelistsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The post.
    ApiResponse<Object> response = apiInstance.ApiSubscriberssubscriberIdIssuelistsWithHttpInfo(subscriberId, request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.ApiSubscriberssubscriberIdIssuelistsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **string** |  |  |
| **request** | [**SCServiceChannelServicesMessagingIssueListsPostIssueListRequest**](SCServiceChannelServicesMessagingIssueListsPostIssueListRequest.md) | The request. |  |

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

<a id="apisubscriberssubscriberidissuelistshistorypageindexpageindexpagesizepagesize"></a>
# **ApiSubscriberssubscriberIdIssuelistsHistorypageIndexpageIndexpageSizepageSize**
> Object ApiSubscriberssubscriberIdIssuelistsHistorypageIndexpageIndexpageSizepageSize (int subscriberId, int? pageIndex = null, int? pageSize = null)

The get issue list history.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ApiSubscriberssubscriberIdIssuelistsHistorypageIndexpageIndexpageSizepageSizeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var subscriberId = 56;  // int | The subscriber id.
            var pageIndex = 56;  // int? | The page index. (optional) 
            var pageSize = 56;  // int? | The page size. (optional) 

            try
            {
                // The get issue list history.
                Object result = apiInstance.ApiSubscriberssubscriberIdIssuelistsHistorypageIndexpageIndexpageSizepageSize(subscriberId, pageIndex, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.ApiSubscriberssubscriberIdIssuelistsHistorypageIndexpageIndexpageSizepageSize: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSubscriberssubscriberIdIssuelistsHistorypageIndexpageIndexpageSizepageSizeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The get issue list history.
    ApiResponse<Object> response = apiInstance.ApiSubscriberssubscriberIdIssuelistsHistorypageIndexpageIndexpageSizepageSizeWithHttpInfo(subscriberId, pageIndex, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.ApiSubscriberssubscriberIdIssuelistsHistorypageIndexpageIndexpageSizepageSizeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** | The subscriber id. |  |
| **pageIndex** | **int?** | The page index. | [optional]  |
| **pageSize** | **int?** | The page size. | [optional]  |

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

<a id="apisubscriberssubscriberidissuelistspageindexpageindexpagesizepagesize"></a>
# **ApiSubscriberssubscriberIdIssuelistspageIndexpageIndexpageSizepageSize**
> Object ApiSubscriberssubscriberIdIssuelistspageIndexpageIndexpageSizepageSize (int subscriberId, int? pageIndex = null, int? pageSize = null)

The post.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ApiSubscriberssubscriberIdIssuelistspageIndexpageIndexpageSizepageSizeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var subscriberId = 56;  // int | The subscriber Id.
            var pageIndex = 56;  // int? | The page index. (optional) 
            var pageSize = 56;  // int? | The page size. (optional) 

            try
            {
                // The post.
                Object result = apiInstance.ApiSubscriberssubscriberIdIssuelistspageIndexpageIndexpageSizepageSize(subscriberId, pageIndex, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.ApiSubscriberssubscriberIdIssuelistspageIndexpageIndexpageSizepageSize: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSubscriberssubscriberIdIssuelistspageIndexpageIndexpageSizepageSizeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The post.
    ApiResponse<Object> response = apiInstance.ApiSubscriberssubscriberIdIssuelistspageIndexpageIndexpageSizepageSizeWithHttpInfo(subscriberId, pageIndex, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.ApiSubscriberssubscriberIdIssuelistspageIndexpageIndexpageSizepageSizeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** | The subscriber Id. |  |
| **pageIndex** | **int?** | The page index. | [optional]  |
| **pageSize** | **int?** | The page size. | [optional]  |

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

<a id="apisubscriberssubscriberidstoredashboardsissuelistitemsequipmenttypeequipmenttypelocationidlocationidsetupidsetupid"></a>
# **ApiSubscriberssubscriberIdStoredashboardsIssuelistItemsequipmentTypeequipmentTypelocationIdlocationIdsetupIdsetupId**
> Object ApiSubscriberssubscriberIdStoredashboardsIssuelistItemsequipmentTypeequipmentTypelocationIdlocationIdsetupIdsetupId (int subscriberId, string equipmentType, int? locationId = null, int? setupId = null)

The get.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ApiSubscriberssubscriberIdStoredashboardsIssuelistItemsequipmentTypeequipmentTypelocationIdlocationIdsetupIdsetupIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var subscriberId = 56;  // int | The subscriber id.
            var equipmentType = "equipmentType_example";  // string | The Equipment Type.
            var locationId = 56;  // int? | The location id. (optional) 
            var setupId = 56;  // int? |  (optional) 

            try
            {
                // The get.
                Object result = apiInstance.ApiSubscriberssubscriberIdStoredashboardsIssuelistItemsequipmentTypeequipmentTypelocationIdlocationIdsetupIdsetupId(subscriberId, equipmentType, locationId, setupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.ApiSubscriberssubscriberIdStoredashboardsIssuelistItemsequipmentTypeequipmentTypelocationIdlocationIdsetupIdsetupId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSubscriberssubscriberIdStoredashboardsIssuelistItemsequipmentTypeequipmentTypelocationIdlocationIdsetupIdsetupIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The get.
    ApiResponse<Object> response = apiInstance.ApiSubscriberssubscriberIdStoredashboardsIssuelistItemsequipmentTypeequipmentTypelocationIdlocationIdsetupIdsetupIdWithHttpInfo(subscriberId, equipmentType, locationId, setupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.ApiSubscriberssubscriberIdStoredashboardsIssuelistItemsequipmentTypeequipmentTypelocationIdlocationIdsetupIdsetupIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** | The subscriber id. |  |
| **equipmentType** | **string** | The Equipment Type. |  |
| **locationId** | **int?** | The location id. | [optional]  |
| **setupId** | **int?** |  | [optional]  |

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

<a id="apisubscriberssubscriberidstoredashboardsdashboardidissuelist"></a>
# **ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelist**
> Object ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelist (int subscriberId, int dashboardId)

The get.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var subscriberId = 56;  // int | The subscriber id.
            var dashboardId = 56;  // int | The dashboard id.

            try
            {
                // The get.
                Object result = apiInstance.ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelist(subscriberId, dashboardId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelist: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The get.
    ApiResponse<Object> response = apiInstance.ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistWithHttpInfo(subscriberId, dashboardId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** | The subscriber id. |  |
| **dashboardId** | **int** | The dashboard id. |  |

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

<a id="apisubscriberssubscriberidstoredashboardsdashboardidissuelistareasareaiditemsproblemtypeproblemtypelocationidlocationid"></a>
# **ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistAreasareaIdItemsproblemTypeproblemTypelocationIdlocationId**
> Object ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistAreasareaIdItemsproblemTypeproblemTypelocationIdlocationId (int subscriberId, int dashboardId, int areaId, string problemType, int locationId)

The get items filtered by area type and location.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistAreasareaIdItemsproblemTypeproblemTypelocationIdlocationIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var subscriberId = 56;  // int | The subsriber id.
            var dashboardId = 56;  // int | The dashboard id.
            var areaId = 56;  // int | The area Id.
            var problemType = "problemType_example";  // string | The problem type.
            var locationId = 56;  // int | The location id.

            try
            {
                // The get items filtered by area type and location.
                Object result = apiInstance.ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistAreasareaIdItemsproblemTypeproblemTypelocationIdlocationId(subscriberId, dashboardId, areaId, problemType, locationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistAreasareaIdItemsproblemTypeproblemTypelocationIdlocationId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistAreasareaIdItemsproblemTypeproblemTypelocationIdlocationIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The get items filtered by area type and location.
    ApiResponse<Object> response = apiInstance.ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistAreasareaIdItemsproblemTypeproblemTypelocationIdlocationIdWithHttpInfo(subscriberId, dashboardId, areaId, problemType, locationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistAreasareaIdItemsproblemTypeproblemTypelocationIdlocationIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** | The subsriber id. |  |
| **dashboardId** | **int** | The dashboard id. |  |
| **areaId** | **int** | The area Id. |  |
| **problemType** | **string** | The problem type. |  |
| **locationId** | **int** | The location id. |  |

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

<a id="apisubscriberssubscriberidstoredashboardsdashboardidissuelistareasareaidproblemsproblemtypeproblemtypeitemitem"></a>
# **ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistAreasareaIdProblemsproblemTypeproblemTypeitemitem**
> Object ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistAreasareaIdProblemsproblemTypeproblemTypeitemitem (int subscriberId, int dashboardId, int areaId, string problemType, string item)

The get problems filtered by area type and location.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistAreasareaIdProblemsproblemTypeproblemTypeitemitemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var subscriberId = 56;  // int | The subsriber id.
            var dashboardId = 56;  // int | The dashboard id.
            var areaId = 56;  // int | The area id.
            var problemType = "problemType_example";  // string | The problem type.
            var item = "item_example";  // string | The item.

            try
            {
                // The get problems filtered by area type and location.
                Object result = apiInstance.ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistAreasareaIdProblemsproblemTypeproblemTypeitemitem(subscriberId, dashboardId, areaId, problemType, item);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistAreasareaIdProblemsproblemTypeproblemTypeitemitem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistAreasareaIdProblemsproblemTypeproblemTypeitemitemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The get problems filtered by area type and location.
    ApiResponse<Object> response = apiInstance.ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistAreasareaIdProblemsproblemTypeproblemTypeitemitemWithHttpInfo(subscriberId, dashboardId, areaId, problemType, item);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistAreasareaIdProblemsproblemTypeproblemTypeitemitemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** | The subsriber id. |  |
| **dashboardId** | **int** | The dashboard id. |  |
| **areaId** | **int** | The area id. |  |
| **problemType** | **string** | The problem type. |  |
| **item** | **string** | The item. |  |

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

<a id="apisubscriberssubscriberidstoredashboardsdashboardidissuelistareasareaidproblemtypes"></a>
# **ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistAreasareaIdProblemtypes**
> Object ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistAreasareaIdProblemtypes (int subscriberId, int dashboardId, int areaId)

The get problem types.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistAreasareaIdProblemtypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var subscriberId = 56;  // int | The subscriber id.
            var dashboardId = 56;  // int | The dashboard id.
            var areaId = 56;  // int | The area id.

            try
            {
                // The get problem types.
                Object result = apiInstance.ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistAreasareaIdProblemtypes(subscriberId, dashboardId, areaId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistAreasareaIdProblemtypes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistAreasareaIdProblemtypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The get problem types.
    ApiResponse<Object> response = apiInstance.ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistAreasareaIdProblemtypesWithHttpInfo(subscriberId, dashboardId, areaId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistAreasareaIdProblemtypesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** | The subscriber id. |  |
| **dashboardId** | **int** | The dashboard id. |  |
| **areaId** | **int** | The area id. |  |

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

<a id="apisubscriberssubscriberidstoredashboardsdashboardidissuelistfields"></a>
# **ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistFields**
> Object ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistFields (int subscriberId, int dashboardId)

The get global fields.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistFieldsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var subscriberId = 56;  // int | The subscriber id.
            var dashboardId = 56;  // int | The dashboard id.

            try
            {
                // The get global fields.
                Object result = apiInstance.ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistFields(subscriberId, dashboardId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistFields: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistFieldsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The get global fields.
    ApiResponse<Object> response = apiInstance.ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistFieldsWithHttpInfo(subscriberId, dashboardId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistFieldsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** | The subscriber id. |  |
| **dashboardId** | **int** | The dashboard id. |  |

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

<a id="apisubscriberssubscriberidstoredashboardsdashboardidissuelistissuechoice"></a>
# **ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistIssuechoice**
> Object ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistIssuechoice (string subscriberId, string dashboardId, SCServiceChannelServicesMessagingIssueListsGetIssueChoiceRequest request)

The get issue choice.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistIssuechoiceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var subscriberId = "subscriberId_example";  // string | 
            var dashboardId = "dashboardId_example";  // string | 
            var request = new SCServiceChannelServicesMessagingIssueListsGetIssueChoiceRequest(); // SCServiceChannelServicesMessagingIssueListsGetIssueChoiceRequest | Get Issue Choice request

            try
            {
                // The get issue choice.
                Object result = apiInstance.ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistIssuechoice(subscriberId, dashboardId, request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistIssuechoice: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistIssuechoiceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The get issue choice.
    ApiResponse<Object> response = apiInstance.ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistIssuechoiceWithHttpInfo(subscriberId, dashboardId, request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistIssuechoiceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **string** |  |  |
| **dashboardId** | **string** |  |  |
| **request** | [**SCServiceChannelServicesMessagingIssueListsGetIssueChoiceRequest**](SCServiceChannelServicesMessagingIssueListsGetIssueChoiceRequest.md) | Get Issue Choice request |  |

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

<a id="apisubscriberssubscriberidstoredashboardsdashboardidissuelistissuechoicefieldsproblemtypeproblemtypeitemitemproblemproblem"></a>
# **ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistIssuechoiceFieldsproblemTypeproblemTypeitemitemproblemproblem**
> Object ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistIssuechoiceFieldsproblemTypeproblemTypeitemitemproblemproblem (int subscriberId, int dashboardId, string problemType, string item, string problem)

The get issue choice fiels.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistIssuechoiceFieldsproblemTypeproblemTypeitemitemproblemproblemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var subscriberId = 56;  // int | The subscriber id.
            var dashboardId = 56;  // int | The dashboard id.
            var problemType = "problemType_example";  // string | The problem type.
            var item = "item_example";  // string | The item.
            var problem = "problem_example";  // string | The problem.

            try
            {
                // The get issue choice fiels.
                Object result = apiInstance.ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistIssuechoiceFieldsproblemTypeproblemTypeitemitemproblemproblem(subscriberId, dashboardId, problemType, item, problem);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistIssuechoiceFieldsproblemTypeproblemTypeitemitemproblemproblem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistIssuechoiceFieldsproblemTypeproblemTypeitemitemproblemproblemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The get issue choice fiels.
    ApiResponse<Object> response = apiInstance.ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistIssuechoiceFieldsproblemTypeproblemTypeitemitemproblemproblemWithHttpInfo(subscriberId, dashboardId, problemType, item, problem);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistIssuechoiceFieldsproblemTypeproblemTypeitemitemproblemproblemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** | The subscriber id. |  |
| **dashboardId** | **int** | The dashboard id. |  |
| **problemType** | **string** | The problem type. |  |
| **item** | **string** | The item. |  |
| **problem** | **string** | The problem. |  |

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

<a id="apisubscriberssubscriberidstoredashboardsdashboardidissuelistissuelistid"></a>
# **ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistissueListId**
> Object ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistissueListId (string subscriberId, string dashboardId, string issueListId, SCServiceChannelServicesMessagingIssueListsSetIssueListForDashboardRequest request)

The set issue list for dashboard.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistissueListIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var subscriberId = "subscriberId_example";  // string | 
            var dashboardId = "dashboardId_example";  // string | 
            var issueListId = "issueListId_example";  // string | 
            var request = new SCServiceChannelServicesMessagingIssueListsSetIssueListForDashboardRequest(); // SCServiceChannelServicesMessagingIssueListsSetIssueListForDashboardRequest | The request.

            try
            {
                // The set issue list for dashboard.
                Object result = apiInstance.ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistissueListId(subscriberId, dashboardId, issueListId, request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistissueListId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistissueListIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The set issue list for dashboard.
    ApiResponse<Object> response = apiInstance.ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistissueListIdWithHttpInfo(subscriberId, dashboardId, issueListId, request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.ApiSubscriberssubscriberIdStoredashboardsdashboardIdIssuelistissueListIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **string** |  |  |
| **dashboardId** | **string** |  |  |
| **issueListId** | **string** |  |  |
| **request** | [**SCServiceChannelServicesMessagingIssueListsSetIssueListForDashboardRequest**](SCServiceChannelServicesMessagingIssueListsSetIssueListForDashboardRequest.md) | The request. |  |

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

<a id="issuelistareaslocationidlocationidsetupidsetupid"></a>
# **IssuelistAreaslocationIdlocationIdsetupIdsetupId**
> SCServiceChannelServicesMessagingIssueListsGetIssueAreasResponse IssuelistAreaslocationIdlocationIdsetupIdsetupId (int? locationId = null, int? setupId = null)

Get Areas

List Issue Areas. Returns Issue Areas for successful request.              <br /><br />Available for subscriber usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class IssuelistAreaslocationIdlocationIdsetupIdsetupIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var locationId = 56;  // int? | selected locationId. (optional) 
            var setupId = 56;  // int? | Numeric id of the Store Dashboard setup. (optional) 

            try
            {
                // Get Areas
                SCServiceChannelServicesMessagingIssueListsGetIssueAreasResponse result = apiInstance.IssuelistAreaslocationIdlocationIdsetupIdsetupId(locationId, setupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.IssuelistAreaslocationIdlocationIdsetupIdsetupId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssuelistAreaslocationIdlocationIdsetupIdsetupIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Areas
    ApiResponse<SCServiceChannelServicesMessagingIssueListsGetIssueAreasResponse> response = apiInstance.IssuelistAreaslocationIdlocationIdsetupIdsetupIdWithHttpInfo(locationId, setupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.IssuelistAreaslocationIdlocationIdsetupIdsetupIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int?** | selected locationId. | [optional]  |
| **setupId** | **int?** | Numeric id of the Store Dashboard setup. | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingIssueListsGetIssueAreasResponse**](SCServiceChannelServicesMessagingIssueListsGetIssueAreasResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 1000 - Invalid setupId(dashboard) for current user; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuelistfieldididsetupidsetupid"></a>
# **IssuelistFieldididsetupIdsetupId**
> Object IssuelistFieldididsetupIdsetupId (string id, int? setupId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class IssuelistFieldididsetupIdsetupIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var id = "id_example";  // string | 
            var setupId = 56;  // int? |  (optional) 

            try
            {
                Object result = apiInstance.IssuelistFieldididsetupIdsetupId(id, setupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.IssuelistFieldididsetupIdsetupId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssuelistFieldididsetupIdsetupIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.IssuelistFieldididsetupIdsetupIdWithHttpInfo(id, setupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.IssuelistFieldididsetupIdsetupIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **setupId** | **int?** |  | [optional]  |

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

<a id="issuelistglobalfieldslocationidlocationidsubscriberidsubscriberidsetupidsetupid"></a>
# **IssuelistGlobalfieldslocationIdlocationIdsubscriberIdsubscriberIdsetupIdsetupId**
> Object IssuelistGlobalfieldslocationIdlocationIdsubscriberIdsubscriberIdsetupIdsetupId (int? locationId = null, int? subscriberId = null, int? setupId = null)

The get global fields. Authorized version of 'storedashboards/{dashboardId:int}/issuelist/fields'

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class IssuelistGlobalfieldslocationIdlocationIdsubscriberIdsubscriberIdsetupIdsetupIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var locationId = 56;  // int? |  (optional) 
            var subscriberId = 56;  // int? |  (optional) 
            var setupId = 56;  // int? |  (optional) 

            try
            {
                // The get global fields. Authorized version of 'storedashboards/{dashboardId:int}/issuelist/fields'
                Object result = apiInstance.IssuelistGlobalfieldslocationIdlocationIdsubscriberIdsubscriberIdsetupIdsetupId(locationId, subscriberId, setupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.IssuelistGlobalfieldslocationIdlocationIdsubscriberIdsubscriberIdsetupIdsetupId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssuelistGlobalfieldslocationIdlocationIdsubscriberIdsubscriberIdsetupIdsetupIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The get global fields. Authorized version of 'storedashboards/{dashboardId:int}/issuelist/fields'
    ApiResponse<Object> response = apiInstance.IssuelistGlobalfieldslocationIdlocationIdsubscriberIdsubscriberIdsetupIdsetupIdWithHttpInfo(locationId, subscriberId, setupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.IssuelistGlobalfieldslocationIdlocationIdsubscriberIdsubscriberIdsetupIdsetupIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int?** |  | [optional]  |
| **subscriberId** | **int?** |  | [optional]  |
| **setupId** | **int?** |  | [optional]  |

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

<a id="issuelistissuechoiceinfotrackingnumber"></a>
# **IssuelistIssuechoiceinfotrackingNumber**
> Object IssuelistIssuechoiceinfotrackingNumber (int trackingNumber)

The get issue choice info.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class IssuelistIssuechoiceinfotrackingNumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var trackingNumber = 56;  // int | The Tracking Number.

            try
            {
                // The get issue choice info.
                Object result = apiInstance.IssuelistIssuechoiceinfotrackingNumber(trackingNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.IssuelistIssuechoiceinfotrackingNumber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssuelistIssuechoiceinfotrackingNumberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The get issue choice info.
    ApiResponse<Object> response = apiInstance.IssuelistIssuechoiceinfotrackingNumberWithHttpInfo(trackingNumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.IssuelistIssuechoiceinfotrackingNumberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **trackingNumber** | **int** | The Tracking Number. |  |

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

<a id="issuelistissuechoiceproblemtypeproblemtypeequipmenttypeequipmenttypeproblemcodeproblemcodelocationidlocationidsetupidsetupid"></a>
# **IssuelistIssuechoiceproblemTypeproblemTypeequipmentTypeequipmentTypeproblemCodeproblemCodelocationIdlocationIdsetupIdsetupId**
> Object IssuelistIssuechoiceproblemTypeproblemTypeequipmentTypeequipmentTypeproblemCodeproblemCodelocationIdlocationIdsetupIdsetupId (string problemType, string equipmentType, string problemCode, int locationId, int? setupId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class IssuelistIssuechoiceproblemTypeproblemTypeequipmentTypeequipmentTypeproblemCodeproblemCodelocationIdlocationIdsetupIdsetupIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var problemType = "problemType_example";  // string | 
            var equipmentType = "equipmentType_example";  // string | 
            var problemCode = "problemCode_example";  // string | 
            var locationId = 56;  // int | 
            var setupId = 56;  // int? |  (optional) 

            try
            {
                Object result = apiInstance.IssuelistIssuechoiceproblemTypeproblemTypeequipmentTypeequipmentTypeproblemCodeproblemCodelocationIdlocationIdsetupIdsetupId(problemType, equipmentType, problemCode, locationId, setupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.IssuelistIssuechoiceproblemTypeproblemTypeequipmentTypeequipmentTypeproblemCodeproblemCodelocationIdlocationIdsetupIdsetupId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssuelistIssuechoiceproblemTypeproblemTypeequipmentTypeequipmentTypeproblemCodeproblemCodelocationIdlocationIdsetupIdsetupIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.IssuelistIssuechoiceproblemTypeproblemTypeequipmentTypeequipmentTypeproblemCodeproblemCodelocationIdlocationIdsetupIdsetupIdWithHttpInfo(problemType, equipmentType, problemCode, locationId, setupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.IssuelistIssuechoiceproblemTypeproblemTypeequipmentTypeequipmentTypeproblemCodeproblemCodelocationIdlocationIdsetupIdsetupIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **problemType** | **string** |  |  |
| **equipmentType** | **string** |  |  |
| **problemCode** | **string** |  |  |
| **locationId** | **int** |  |  |
| **setupId** | **int?** |  | [optional]  |

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

<a id="issuelistitemslocationidlocationidareaidareaidproblemtypeproblemtypesetupidsetupid"></a>
# **IssuelistItemslocationIdlocationIdareaIdareaIdproblemTypeproblemTypesetupIdsetupId**
> SCServiceChannelServicesMessagingIssueListsGetIssueEquipmentTypesResponse IssuelistItemslocationIdlocationIdareaIdareaIdproblemTypeproblemTypesetupIdsetupId (int locationId, int areaId, string problemType, int? setupId = null)

Get Equipment items

List equipment items.              <br /><br />Available for subscriber usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class IssuelistItemslocationIdlocationIdareaIdareaIdproblemTypeproblemTypesetupIdsetupIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var locationId = 56;  // int | Numeric id of the Location.
            var areaId = 56;  // int | Numeric id of the Location Area.
            var problemType = "problemType_example";  // string | Problem type.
            var setupId = 56;  // int? | Numeric id of the Store Dashboard setup. (optional) 

            try
            {
                // Get Equipment items
                SCServiceChannelServicesMessagingIssueListsGetIssueEquipmentTypesResponse result = apiInstance.IssuelistItemslocationIdlocationIdareaIdareaIdproblemTypeproblemTypesetupIdsetupId(locationId, areaId, problemType, setupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.IssuelistItemslocationIdlocationIdareaIdareaIdproblemTypeproblemTypesetupIdsetupId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssuelistItemslocationIdlocationIdareaIdareaIdproblemTypeproblemTypesetupIdsetupIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Equipment items
    ApiResponse<SCServiceChannelServicesMessagingIssueListsGetIssueEquipmentTypesResponse> response = apiInstance.IssuelistItemslocationIdlocationIdareaIdareaIdproblemTypeproblemTypesetupIdsetupIdWithHttpInfo(locationId, areaId, problemType, setupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.IssuelistItemslocationIdlocationIdareaIdareaIdproblemTypeproblemTypesetupIdsetupIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | Numeric id of the Location. |  |
| **areaId** | **int** | Numeric id of the Location Area. |  |
| **problemType** | **string** | Problem type. |  |
| **setupId** | **int?** | Numeric id of the Store Dashboard setup. | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingIssueListsGetIssueEquipmentTypesResponse**](SCServiceChannelServicesMessagingIssueListsGetIssueEquipmentTypesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 1000 - Invalid setupId(dashboard) for current user;              &lt;br/&gt; 1001 - No issue list is available, please load it through issue list converter; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuelistproblemsareaidareaidproblemtypeproblemtypeequipmenttypeequipmenttypelocationidlocationidsetupidsetupid"></a>
# **IssuelistProblemsareaIdareaIdproblemTypeproblemTypeequipmentTypeequipmentTypelocationIdlocationIdsetupIdsetupId**
> SCServiceChannelServicesMessagingIssueListsGetProblemsFilteredByAreaTypeAndLocationResponse IssuelistProblemsareaIdareaIdproblemTypeproblemTypeequipmentTypeequipmentTypelocationIdlocationIdsetupIdsetupId (int areaId, string problemType, string equipmentType, int? locationId = null, int? setupId = null)

Get Problem codes

List problem codes.              <br /><br />Available for subscriber usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class IssuelistProblemsareaIdareaIdproblemTypeproblemTypeequipmentTypeequipmentTypelocationIdlocationIdsetupIdsetupIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var areaId = 56;  // int | Numeric id of the Location Area.
            var problemType = "problemType_example";  // string | Problem type.
            var equipmentType = "equipmentType_example";  // string | Equipment type.
            var locationId = 56;  // int? | selected locationId. (optional) 
            var setupId = 56;  // int? | Numeric id of the Store Dashboard setup. (optional) 

            try
            {
                // Get Problem codes
                SCServiceChannelServicesMessagingIssueListsGetProblemsFilteredByAreaTypeAndLocationResponse result = apiInstance.IssuelistProblemsareaIdareaIdproblemTypeproblemTypeequipmentTypeequipmentTypelocationIdlocationIdsetupIdsetupId(areaId, problemType, equipmentType, locationId, setupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.IssuelistProblemsareaIdareaIdproblemTypeproblemTypeequipmentTypeequipmentTypelocationIdlocationIdsetupIdsetupId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssuelistProblemsareaIdareaIdproblemTypeproblemTypeequipmentTypeequipmentTypelocationIdlocationIdsetupIdsetupIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Problem codes
    ApiResponse<SCServiceChannelServicesMessagingIssueListsGetProblemsFilteredByAreaTypeAndLocationResponse> response = apiInstance.IssuelistProblemsareaIdareaIdproblemTypeproblemTypeequipmentTypeequipmentTypelocationIdlocationIdsetupIdsetupIdWithHttpInfo(areaId, problemType, equipmentType, locationId, setupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.IssuelistProblemsareaIdareaIdproblemTypeproblemTypeequipmentTypeequipmentTypelocationIdlocationIdsetupIdsetupIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **areaId** | **int** | Numeric id of the Location Area. |  |
| **problemType** | **string** | Problem type. |  |
| **equipmentType** | **string** | Equipment type. |  |
| **locationId** | **int?** | selected locationId. | [optional]  |
| **setupId** | **int?** | Numeric id of the Store Dashboard setup. | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingIssueListsGetProblemsFilteredByAreaTypeAndLocationResponse**](SCServiceChannelServicesMessagingIssueListsGetProblemsFilteredByAreaTypeAndLocationResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 1000 - Invalid setupId(dashboard) for current user;              &lt;br/&gt; 1001 - No issue list is available, please load it through issue list converter; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuelistproblemtypesareaidareaidlocationidlocationidsetupidsetupidsubscriberidsubscriberid"></a>
# **IssuelistProblemtypesareaIdareaIdlocationIdlocationIdsetupIdsetupIdsubscriberIdsubscriberId**
> SCServiceChannelServicesMessagingIssueListsGetProblemTypesResponse IssuelistProblemtypesareaIdareaIdlocationIdlocationIdsetupIdsetupIdsubscriberIdsubscriberId (int areaId, int? locationId = null, int? setupId = null, int? subscriberId = null)

Get Problem types

List Problem types. Returns Problem types for successful request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class IssuelistProblemtypesareaIdareaIdlocationIdlocationIdsetupIdsetupIdsubscriberIdsubscriberIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var areaId = 56;  // int | Numeric id of the Location Area.
            var locationId = 56;  // int? | Numeric id of location. (optional) 
            var setupId = 56;  // int? | Numeric id of the Store Dashboard setup. (optional) 
            var subscriberId = 56;  // int? | Numeric id of subscriber. (optional) 

            try
            {
                // Get Problem types
                SCServiceChannelServicesMessagingIssueListsGetProblemTypesResponse result = apiInstance.IssuelistProblemtypesareaIdareaIdlocationIdlocationIdsetupIdsetupIdsubscriberIdsubscriberId(areaId, locationId, setupId, subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.IssuelistProblemtypesareaIdareaIdlocationIdlocationIdsetupIdsetupIdsubscriberIdsubscriberId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssuelistProblemtypesareaIdareaIdlocationIdlocationIdsetupIdsetupIdsubscriberIdsubscriberIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Problem types
    ApiResponse<SCServiceChannelServicesMessagingIssueListsGetProblemTypesResponse> response = apiInstance.IssuelistProblemtypesareaIdareaIdlocationIdlocationIdsetupIdsetupIdsubscriberIdsubscriberIdWithHttpInfo(areaId, locationId, setupId, subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.IssuelistProblemtypesareaIdareaIdlocationIdlocationIdsetupIdsetupIdsubscriberIdsubscriberIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **areaId** | **int** | Numeric id of the Location Area. |  |
| **locationId** | **int?** | Numeric id of location. | [optional]  |
| **setupId** | **int?** | Numeric id of the Store Dashboard setup. | [optional]  |
| **subscriberId** | **int?** | Numeric id of subscriber. | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingIssueListsGetProblemTypesResponse**](SCServiceChannelServicesMessagingIssueListsGetProblemTypesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 1000 - Invalid setupId(dashboard) for current user;              &lt;br/&gt; 1001 - No issue list is available, please load it through issue list converter; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="providerscurrentapplicationissuelistareasareaidproblemtypeslocationidlocationidsetupidsetupidsubscriberidsubscriberid"></a>
# **ProvidersCurrentApplicationissuelistAreasareaIdProblemtypeslocationIdlocationIdsetupIdsetupIdsubscriberIdsubscriberId**
> SCServiceChannelServicesMessagingIssueListsGetProblemTypesResponse ProvidersCurrentApplicationissuelistAreasareaIdProblemtypeslocationIdlocationIdsetupIdsetupIdsubscriberIdsubscriberId (int areaId, int? locationId = null, int? setupId = null, int? subscriberId = null)

Get Problem types

List Problem types. Returns Problem types for successful request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProvidersCurrentApplicationissuelistAreasareaIdProblemtypeslocationIdlocationIdsetupIdsetupIdsubscriberIdsubscriberIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var areaId = 56;  // int | Numeric id of the Location Area.
            var locationId = 56;  // int? | Numeric id of location. (optional) 
            var setupId = 56;  // int? | Numeric id of the Store Dashboard setup. (optional) 
            var subscriberId = 56;  // int? | Numeric id of subscriber. (optional) 

            try
            {
                // Get Problem types
                SCServiceChannelServicesMessagingIssueListsGetProblemTypesResponse result = apiInstance.ProvidersCurrentApplicationissuelistAreasareaIdProblemtypeslocationIdlocationIdsetupIdsetupIdsubscriberIdsubscriberId(areaId, locationId, setupId, subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.ProvidersCurrentApplicationissuelistAreasareaIdProblemtypeslocationIdlocationIdsetupIdsetupIdsubscriberIdsubscriberId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProvidersCurrentApplicationissuelistAreasareaIdProblemtypeslocationIdlocationIdsetupIdsetupIdsubscriberIdsubscriberIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Problem types
    ApiResponse<SCServiceChannelServicesMessagingIssueListsGetProblemTypesResponse> response = apiInstance.ProvidersCurrentApplicationissuelistAreasareaIdProblemtypeslocationIdlocationIdsetupIdsetupIdsubscriberIdsubscriberIdWithHttpInfo(areaId, locationId, setupId, subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.ProvidersCurrentApplicationissuelistAreasareaIdProblemtypeslocationIdlocationIdsetupIdsetupIdsubscriberIdsubscriberIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **areaId** | **int** | Numeric id of the Location Area. |  |
| **locationId** | **int?** | Numeric id of location. | [optional]  |
| **setupId** | **int?** | Numeric id of the Store Dashboard setup. | [optional]  |
| **subscriberId** | **int?** | Numeric id of subscriber. | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingIssueListsGetProblemTypesResponse**](SCServiceChannelServicesMessagingIssueListsGetProblemTypesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 1000 - Invalid setupId(dashboard) for current user;              &lt;br/&gt; 1001 - No issue list is available, please load it through issue list converter; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="providerscurrentapplicationissuelistissueitemssubscriberidsubscriberidlocationidlocationidareaidareaidtradetradeproblemtypeproblemtype"></a>
# **ProvidersCurrentApplicationissuelistIssueitemssubscriberIdsubscriberIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemType**
> Object ProvidersCurrentApplicationissuelistIssueitemssubscriberIdsubscriberIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemType (int subscriberId, int locationId, int areaId, string trade, string problemType)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProvidersCurrentApplicationissuelistIssueitemssubscriberIdsubscriberIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var subscriberId = 56;  // int | 
            var locationId = 56;  // int | 
            var areaId = 56;  // int | 
            var trade = "trade_example";  // string | 
            var problemType = "problemType_example";  // string | 

            try
            {
                Object result = apiInstance.ProvidersCurrentApplicationissuelistIssueitemssubscriberIdsubscriberIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemType(subscriberId, locationId, areaId, trade, problemType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.ProvidersCurrentApplicationissuelistIssueitemssubscriberIdsubscriberIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemType: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProvidersCurrentApplicationissuelistIssueitemssubscriberIdsubscriberIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.ProvidersCurrentApplicationissuelistIssueitemssubscriberIdsubscriberIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemTypeWithHttpInfo(subscriberId, locationId, areaId, trade, problemType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.ProvidersCurrentApplicationissuelistIssueitemssubscriberIdsubscriberIdlocationIdlocationIdareaIdareaIdtradetradeproblemTypeproblemTypeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** |  |  |
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

<a id="providerscurrentsubscriberssubscriberidapplicationissuelistareaslocationidlocationid"></a>
# **ProvidersCurrentSubscriberssubscriberIdApplicationissuelistAreaslocationIdlocationId**
> SCServiceChannelServicesMessagingIssueListsGetIssueAreasResponse ProvidersCurrentSubscriberssubscriberIdApplicationissuelistAreaslocationIdlocationId (int subscriberId, int? locationId = null)

Get Areas

List Issue Areas. Returns Issue Areas for successful request.              <br /><br />Available for provider usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProvidersCurrentSubscriberssubscriberIdApplicationissuelistAreaslocationIdlocationIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var subscriberId = 56;  // int | The subscriber id is required.
            var locationId = 56;  // int? | Numeric id of location. (optional) 

            try
            {
                // Get Areas
                SCServiceChannelServicesMessagingIssueListsGetIssueAreasResponse result = apiInstance.ProvidersCurrentSubscriberssubscriberIdApplicationissuelistAreaslocationIdlocationId(subscriberId, locationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.ProvidersCurrentSubscriberssubscriberIdApplicationissuelistAreaslocationIdlocationId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProvidersCurrentSubscriberssubscriberIdApplicationissuelistAreaslocationIdlocationIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Areas
    ApiResponse<SCServiceChannelServicesMessagingIssueListsGetIssueAreasResponse> response = apiInstance.ProvidersCurrentSubscriberssubscriberIdApplicationissuelistAreaslocationIdlocationIdWithHttpInfo(subscriberId, locationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.ProvidersCurrentSubscriberssubscriberIdApplicationissuelistAreaslocationIdlocationIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** | The subscriber id is required. |  |
| **locationId** | **int?** | Numeric id of location. | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingIssueListsGetIssueAreasResponse**](SCServiceChannelServicesMessagingIssueListsGetIssueAreasResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 1000 - Invalid setupId(dashboard) for current user; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="providerscurrentsubscriberssubscriberidapplicationissuelistglobalfieldslocationidlocationid"></a>
# **ProvidersCurrentSubscriberssubscriberIdApplicationissuelistGlobalfieldslocationIdlocationId**
> Object ProvidersCurrentSubscriberssubscriberIdApplicationissuelistGlobalfieldslocationIdlocationId (int subscriberId, int? locationId = null)

The get global fields. Authorized version of 'storedashboards/{dashboardId:int}/issuelist/fields'

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProvidersCurrentSubscriberssubscriberIdApplicationissuelistGlobalfieldslocationIdlocationIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var subscriberId = 56;  // int | The subscriber id is required.
            var locationId = 56;  // int? | Numeric id of location. (optional) 

            try
            {
                // The get global fields. Authorized version of 'storedashboards/{dashboardId:int}/issuelist/fields'
                Object result = apiInstance.ProvidersCurrentSubscriberssubscriberIdApplicationissuelistGlobalfieldslocationIdlocationId(subscriberId, locationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.ProvidersCurrentSubscriberssubscriberIdApplicationissuelistGlobalfieldslocationIdlocationId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProvidersCurrentSubscriberssubscriberIdApplicationissuelistGlobalfieldslocationIdlocationIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The get global fields. Authorized version of 'storedashboards/{dashboardId:int}/issuelist/fields'
    ApiResponse<Object> response = apiInstance.ProvidersCurrentSubscriberssubscriberIdApplicationissuelistGlobalfieldslocationIdlocationIdWithHttpInfo(subscriberId, locationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.ProvidersCurrentSubscriberssubscriberIdApplicationissuelistGlobalfieldslocationIdlocationIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** | The subscriber id is required. |  |
| **locationId** | **int?** | Numeric id of location. | [optional]  |

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

<a id="providerscurrentsubscriberssubscriberidapplicationissuelistitemslocationidlocationidareaidareaidproblemtypeproblemtype"></a>
# **ProvidersCurrentSubscriberssubscriberIdApplicationissuelistItemslocationIdlocationIdareaIdareaIdproblemTypeproblemType**
> SCServiceChannelServicesMessagingIssueListsGetIssueEquipmentTypesResponse ProvidersCurrentSubscriberssubscriberIdApplicationissuelistItemslocationIdlocationIdareaIdareaIdproblemTypeproblemType (int subscriberId, int locationId, int areaId, string problemType)

Get Equipment items

List equipment items.              <br /><br />Available for provider usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProvidersCurrentSubscriberssubscriberIdApplicationissuelistItemslocationIdlocationIdareaIdareaIdproblemTypeproblemTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var subscriberId = 56;  // int | This parameter is required.
            var locationId = 56;  // int | Numeric id of the Location.
            var areaId = 56;  // int | Numeric id of the Location Area.
            var problemType = "problemType_example";  // string | Problem type.

            try
            {
                // Get Equipment items
                SCServiceChannelServicesMessagingIssueListsGetIssueEquipmentTypesResponse result = apiInstance.ProvidersCurrentSubscriberssubscriberIdApplicationissuelistItemslocationIdlocationIdareaIdareaIdproblemTypeproblemType(subscriberId, locationId, areaId, problemType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.ProvidersCurrentSubscriberssubscriberIdApplicationissuelistItemslocationIdlocationIdareaIdareaIdproblemTypeproblemType: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProvidersCurrentSubscriberssubscriberIdApplicationissuelistItemslocationIdlocationIdareaIdareaIdproblemTypeproblemTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Equipment items
    ApiResponse<SCServiceChannelServicesMessagingIssueListsGetIssueEquipmentTypesResponse> response = apiInstance.ProvidersCurrentSubscriberssubscriberIdApplicationissuelistItemslocationIdlocationIdareaIdareaIdproblemTypeproblemTypeWithHttpInfo(subscriberId, locationId, areaId, problemType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.ProvidersCurrentSubscriberssubscriberIdApplicationissuelistItemslocationIdlocationIdareaIdareaIdproblemTypeproblemTypeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** | This parameter is required. |  |
| **locationId** | **int** | Numeric id of the Location. |  |
| **areaId** | **int** | Numeric id of the Location Area. |  |
| **problemType** | **string** | Problem type. |  |

### Return type

[**SCServiceChannelServicesMessagingIssueListsGetIssueEquipmentTypesResponse**](SCServiceChannelServicesMessagingIssueListsGetIssueEquipmentTypesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 1000 - Invalid setupId(dashboard) for current user;              &lt;br/&gt; 1001 - No issue list is available, please load it through issue list converter; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="providerscurrentsubscriberssubscriberidapplicationissuelistproblemsareaidareaidproblemtypeproblemtypeequipmenttypeequipmenttypelocationidlocationid"></a>
# **ProvidersCurrentSubscriberssubscriberIdApplicationissuelistProblemsareaIdareaIdproblemTypeproblemTypeequipmentTypeequipmentTypelocationIdlocationId**
> SCServiceChannelServicesMessagingIssueListsGetProblemsFilteredByAreaTypeAndLocationResponse ProvidersCurrentSubscriberssubscriberIdApplicationissuelistProblemsareaIdareaIdproblemTypeproblemTypeequipmentTypeequipmentTypelocationIdlocationId (int subscriberId, int areaId, string problemType, string equipmentType, int? locationId = null)

Get Problem codes

List problem codes.              <br /><br />Available for provider usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProvidersCurrentSubscriberssubscriberIdApplicationissuelistProblemsareaIdareaIdproblemTypeproblemTypeequipmentTypeequipmentTypelocationIdlocationIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var subscriberId = 56;  // int | This parametr is required.
            var areaId = 56;  // int | Numeric id of the Location Area.
            var problemType = "problemType_example";  // string | Problem type.
            var equipmentType = "equipmentType_example";  // string | Equipment type.
            var locationId = 56;  // int? | Numeric id of location. (optional) 

            try
            {
                // Get Problem codes
                SCServiceChannelServicesMessagingIssueListsGetProblemsFilteredByAreaTypeAndLocationResponse result = apiInstance.ProvidersCurrentSubscriberssubscriberIdApplicationissuelistProblemsareaIdareaIdproblemTypeproblemTypeequipmentTypeequipmentTypelocationIdlocationId(subscriberId, areaId, problemType, equipmentType, locationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.ProvidersCurrentSubscriberssubscriberIdApplicationissuelistProblemsareaIdareaIdproblemTypeproblemTypeequipmentTypeequipmentTypelocationIdlocationId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProvidersCurrentSubscriberssubscriberIdApplicationissuelistProblemsareaIdareaIdproblemTypeproblemTypeequipmentTypeequipmentTypelocationIdlocationIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Problem codes
    ApiResponse<SCServiceChannelServicesMessagingIssueListsGetProblemsFilteredByAreaTypeAndLocationResponse> response = apiInstance.ProvidersCurrentSubscriberssubscriberIdApplicationissuelistProblemsareaIdareaIdproblemTypeproblemTypeequipmentTypeequipmentTypelocationIdlocationIdWithHttpInfo(subscriberId, areaId, problemType, equipmentType, locationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.ProvidersCurrentSubscriberssubscriberIdApplicationissuelistProblemsareaIdareaIdproblemTypeproblemTypeequipmentTypeequipmentTypelocationIdlocationIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** | This parametr is required. |  |
| **areaId** | **int** | Numeric id of the Location Area. |  |
| **problemType** | **string** | Problem type. |  |
| **equipmentType** | **string** | Equipment type. |  |
| **locationId** | **int?** | Numeric id of location. | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingIssueListsGetProblemsFilteredByAreaTypeAndLocationResponse**](SCServiceChannelServicesMessagingIssueListsGetProblemsFilteredByAreaTypeAndLocationResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 1000 - Invalid setupId(dashboard) for current user;              &lt;br/&gt; 1001 - No issue list is available, please load it through issue list converter; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="providerscurrentsubscriberssubscriberidissuelistassetidassetidlocationidlocationid"></a>
# **ProvidersCurrentSubscriberssubscriberIdIssuelistassetIdassetIdlocationIdlocationId**
> Object ProvidersCurrentSubscriberssubscriberIdIssuelistassetIdassetIdlocationIdlocationId (int subscriberId, int? assetId = null, int? locationId = null)

Retrieves the issue list for a FTM provider

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProvidersCurrentSubscriberssubscriberIdIssuelistassetIdassetIdlocationIdlocationIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var subscriberId = 56;  // int | 
            var assetId = 56;  // int? | Optional asset ID (optional) 
            var locationId = 56;  // int? | Optional location ID (optional) 

            try
            {
                // Retrieves the issue list for a FTM provider
                Object result = apiInstance.ProvidersCurrentSubscriberssubscriberIdIssuelistassetIdassetIdlocationIdlocationId(subscriberId, assetId, locationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.ProvidersCurrentSubscriberssubscriberIdIssuelistassetIdassetIdlocationIdlocationId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProvidersCurrentSubscriberssubscriberIdIssuelistassetIdassetIdlocationIdlocationIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves the issue list for a FTM provider
    ApiResponse<Object> response = apiInstance.ProvidersCurrentSubscriberssubscriberIdIssuelistassetIdassetIdlocationIdlocationIdWithHttpInfo(subscriberId, assetId, locationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.ProvidersCurrentSubscriberssubscriberIdIssuelistassetIdassetIdlocationIdlocationIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** |  |  |
| **assetId** | **int?** | Optional asset ID | [optional]  |
| **locationId** | **int?** | Optional location ID | [optional]  |

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

<a id="providerscurrentsubscribersubscriberidlocationlocationidapplicationissuelistproblemtypes"></a>
# **ProvidersCurrentSubscribersubscriberIdLocationlocationIdApplicationissuelistProblemtypes**
> Object ProvidersCurrentSubscribersubscriberIdLocationlocationIdApplicationissuelistProblemtypes (int subscriberId, int locationId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProvidersCurrentSubscribersubscriberIdLocationlocationIdApplicationissuelistProblemtypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var subscriberId = 56;  // int | 
            var locationId = 56;  // int | 

            try
            {
                Object result = apiInstance.ProvidersCurrentSubscribersubscriberIdLocationlocationIdApplicationissuelistProblemtypes(subscriberId, locationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.ProvidersCurrentSubscribersubscriberIdLocationlocationIdApplicationissuelistProblemtypes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProvidersCurrentSubscribersubscriberIdLocationlocationIdApplicationissuelistProblemtypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.ProvidersCurrentSubscribersubscriberIdLocationlocationIdApplicationissuelistProblemtypesWithHttpInfo(subscriberId, locationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.ProvidersCurrentSubscribersubscriberIdLocationlocationIdApplicationissuelistProblemtypesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** |  |  |
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

<a id="subscriberscurrentdashboardsetupidissuelistequipmenttypesareaidareaidproblemtypeproblemtype"></a>
# **SubscribersCurrentDashboardsetupIdIssuelistEquipmenttypesareaIdareaIdproblemTypeproblemType**
> SCServiceChannelServicesMessagingIssueListsGetIssueEquipmentTypesResponse SubscribersCurrentDashboardsetupIdIssuelistEquipmenttypesareaIdareaIdproblemTypeproblemType (int setupId, int areaId, string problemType)

Get Equipment items not filtered by location.

List equipment items not filtered by location.              <br /><br />Available for subscriber usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscribersCurrentDashboardsetupIdIssuelistEquipmenttypesareaIdareaIdproblemTypeproblemTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var setupId = 56;  // int | Numeric id of the Store Dashboard setup.
            var areaId = 56;  // int | Numeric id of the Location Area.
            var problemType = "problemType_example";  // string | Problem type.

            try
            {
                // Get Equipment items not filtered by location.
                SCServiceChannelServicesMessagingIssueListsGetIssueEquipmentTypesResponse result = apiInstance.SubscribersCurrentDashboardsetupIdIssuelistEquipmenttypesareaIdareaIdproblemTypeproblemType(setupId, areaId, problemType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.SubscribersCurrentDashboardsetupIdIssuelistEquipmenttypesareaIdareaIdproblemTypeproblemType: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribersCurrentDashboardsetupIdIssuelistEquipmenttypesareaIdareaIdproblemTypeproblemTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Equipment items not filtered by location.
    ApiResponse<SCServiceChannelServicesMessagingIssueListsGetIssueEquipmentTypesResponse> response = apiInstance.SubscribersCurrentDashboardsetupIdIssuelistEquipmenttypesareaIdareaIdproblemTypeproblemTypeWithHttpInfo(setupId, areaId, problemType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.SubscribersCurrentDashboardsetupIdIssuelistEquipmenttypesareaIdareaIdproblemTypeproblemTypeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **setupId** | **int** | Numeric id of the Store Dashboard setup. |  |
| **areaId** | **int** | Numeric id of the Location Area. |  |
| **problemType** | **string** | Problem type. |  |

### Return type

[**SCServiceChannelServicesMessagingIssueListsGetIssueEquipmentTypesResponse**](SCServiceChannelServicesMessagingIssueListsGetIssueEquipmentTypesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 1000 - Invalid setupId(dashboard) for current user;              &lt;br/&gt; 1001 - No issue list is available, please load it through issue list converter; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscriberscurrentstoredashboardscurrentissuelistareasareaidequipmenttypeslocationidlocationidproblemtypeproblemtypesetupidsetupid"></a>
# **SubscribersCurrentStoredashboardsCurrentIssuelistAreasareaIdEquipmenttypeslocationIdlocationIdproblemTypeproblemTypesetupIdsetupId**
> SCServiceChannelServicesMessagingIssueListsGetIssueEquipmentTypesResponse SubscribersCurrentStoredashboardsCurrentIssuelistAreasareaIdEquipmenttypeslocationIdlocationIdproblemTypeproblemTypesetupIdsetupId (int locationId, int areaId, string problemType, int? setupId = null)

Get Equipment items

List equipment items.              <br /><br />Available for subscriber usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscribersCurrentStoredashboardsCurrentIssuelistAreasareaIdEquipmenttypeslocationIdlocationIdproblemTypeproblemTypesetupIdsetupIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var locationId = 56;  // int | Numeric id of the Location.
            var areaId = 56;  // int | Numeric id of the Location Area.
            var problemType = "problemType_example";  // string | Problem type.
            var setupId = 56;  // int? | Numeric id of the Store Dashboard setup. (optional) 

            try
            {
                // Get Equipment items
                SCServiceChannelServicesMessagingIssueListsGetIssueEquipmentTypesResponse result = apiInstance.SubscribersCurrentStoredashboardsCurrentIssuelistAreasareaIdEquipmenttypeslocationIdlocationIdproblemTypeproblemTypesetupIdsetupId(locationId, areaId, problemType, setupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.SubscribersCurrentStoredashboardsCurrentIssuelistAreasareaIdEquipmenttypeslocationIdlocationIdproblemTypeproblemTypesetupIdsetupId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribersCurrentStoredashboardsCurrentIssuelistAreasareaIdEquipmenttypeslocationIdlocationIdproblemTypeproblemTypesetupIdsetupIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Equipment items
    ApiResponse<SCServiceChannelServicesMessagingIssueListsGetIssueEquipmentTypesResponse> response = apiInstance.SubscribersCurrentStoredashboardsCurrentIssuelistAreasareaIdEquipmenttypeslocationIdlocationIdproblemTypeproblemTypesetupIdsetupIdWithHttpInfo(locationId, areaId, problemType, setupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.SubscribersCurrentStoredashboardsCurrentIssuelistAreasareaIdEquipmenttypeslocationIdlocationIdproblemTypeproblemTypesetupIdsetupIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | Numeric id of the Location. |  |
| **areaId** | **int** | Numeric id of the Location Area. |  |
| **problemType** | **string** | Problem type. |  |
| **setupId** | **int?** | Numeric id of the Store Dashboard setup. | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingIssueListsGetIssueEquipmentTypesResponse**](SCServiceChannelServicesMessagingIssueListsGetIssueEquipmentTypesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 1000 - Invalid setupId(dashboard) for current user;              &lt;br/&gt; 1001 - No issue list is available, please load it through issue list converter; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscriberscurrentstoredashboardscurrentissuelistareasareaidproblemcodesproblemtypeproblemtypeequipmenttypeequipmenttypelocationidlocationidsetupidsetupid"></a>
# **SubscribersCurrentStoredashboardsCurrentIssuelistAreasareaIdProblemcodesproblemTypeproblemTypeequipmentTypeequipmentTypelocationIdlocationIdsetupIdsetupId**
> SCServiceChannelServicesMessagingIssueListsGetProblemsFilteredByAreaTypeAndLocationResponse SubscribersCurrentStoredashboardsCurrentIssuelistAreasareaIdProblemcodesproblemTypeproblemTypeequipmentTypeequipmentTypelocationIdlocationIdsetupIdsetupId (int areaId, string problemType, string equipmentType, int? locationId = null, int? setupId = null)

Get Problem codes

List problem codes.              <br /><br />Available for subscriber usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscribersCurrentStoredashboardsCurrentIssuelistAreasareaIdProblemcodesproblemTypeproblemTypeequipmentTypeequipmentTypelocationIdlocationIdsetupIdsetupIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var areaId = 56;  // int | Numeric id of the Location Area.
            var problemType = "problemType_example";  // string | Problem type.
            var equipmentType = "equipmentType_example";  // string | Equipment type.
            var locationId = 56;  // int? | selected locationId. (optional) 
            var setupId = 56;  // int? | Numeric id of the Store Dashboard setup. (optional) 

            try
            {
                // Get Problem codes
                SCServiceChannelServicesMessagingIssueListsGetProblemsFilteredByAreaTypeAndLocationResponse result = apiInstance.SubscribersCurrentStoredashboardsCurrentIssuelistAreasareaIdProblemcodesproblemTypeproblemTypeequipmentTypeequipmentTypelocationIdlocationIdsetupIdsetupId(areaId, problemType, equipmentType, locationId, setupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.SubscribersCurrentStoredashboardsCurrentIssuelistAreasareaIdProblemcodesproblemTypeproblemTypeequipmentTypeequipmentTypelocationIdlocationIdsetupIdsetupId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribersCurrentStoredashboardsCurrentIssuelistAreasareaIdProblemcodesproblemTypeproblemTypeequipmentTypeequipmentTypelocationIdlocationIdsetupIdsetupIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Problem codes
    ApiResponse<SCServiceChannelServicesMessagingIssueListsGetProblemsFilteredByAreaTypeAndLocationResponse> response = apiInstance.SubscribersCurrentStoredashboardsCurrentIssuelistAreasareaIdProblemcodesproblemTypeproblemTypeequipmentTypeequipmentTypelocationIdlocationIdsetupIdsetupIdWithHttpInfo(areaId, problemType, equipmentType, locationId, setupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.SubscribersCurrentStoredashboardsCurrentIssuelistAreasareaIdProblemcodesproblemTypeproblemTypeequipmentTypeequipmentTypelocationIdlocationIdsetupIdsetupIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **areaId** | **int** | Numeric id of the Location Area. |  |
| **problemType** | **string** | Problem type. |  |
| **equipmentType** | **string** | Equipment type. |  |
| **locationId** | **int?** | selected locationId. | [optional]  |
| **setupId** | **int?** | Numeric id of the Store Dashboard setup. | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingIssueListsGetProblemsFilteredByAreaTypeAndLocationResponse**](SCServiceChannelServicesMessagingIssueListsGetProblemsFilteredByAreaTypeAndLocationResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 1000 - Invalid setupId(dashboard) for current user;              &lt;br/&gt; 1001 - No issue list is available, please load it through issue list converter; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscriberscurrentstoredashboardscurrentissuelistareasareaidproblemtypeslocationidlocationidsetupidsetupidsubscriberidsubscriberid"></a>
# **SubscribersCurrentStoredashboardsCurrentIssuelistAreasareaIdProblemtypeslocationIdlocationIdsetupIdsetupIdsubscriberIdsubscriberId**
> SCServiceChannelServicesMessagingIssueListsGetProblemTypesResponse SubscribersCurrentStoredashboardsCurrentIssuelistAreasareaIdProblemtypeslocationIdlocationIdsetupIdsetupIdsubscriberIdsubscriberId (int areaId, int? locationId = null, int? setupId = null, int? subscriberId = null)

Get Problem types

List Problem types. Returns Problem types for successful request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscribersCurrentStoredashboardsCurrentIssuelistAreasareaIdProblemtypeslocationIdlocationIdsetupIdsetupIdsubscriberIdsubscriberIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var areaId = 56;  // int | Numeric id of the Location Area.
            var locationId = 56;  // int? | Numeric id of location. (optional) 
            var setupId = 56;  // int? | Numeric id of the Store Dashboard setup. (optional) 
            var subscriberId = 56;  // int? | Numeric id of subscriber. (optional) 

            try
            {
                // Get Problem types
                SCServiceChannelServicesMessagingIssueListsGetProblemTypesResponse result = apiInstance.SubscribersCurrentStoredashboardsCurrentIssuelistAreasareaIdProblemtypeslocationIdlocationIdsetupIdsetupIdsubscriberIdsubscriberId(areaId, locationId, setupId, subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.SubscribersCurrentStoredashboardsCurrentIssuelistAreasareaIdProblemtypeslocationIdlocationIdsetupIdsetupIdsubscriberIdsubscriberId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribersCurrentStoredashboardsCurrentIssuelistAreasareaIdProblemtypeslocationIdlocationIdsetupIdsetupIdsubscriberIdsubscriberIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Problem types
    ApiResponse<SCServiceChannelServicesMessagingIssueListsGetProblemTypesResponse> response = apiInstance.SubscribersCurrentStoredashboardsCurrentIssuelistAreasareaIdProblemtypeslocationIdlocationIdsetupIdsetupIdsubscriberIdsubscriberIdWithHttpInfo(areaId, locationId, setupId, subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.SubscribersCurrentStoredashboardsCurrentIssuelistAreasareaIdProblemtypeslocationIdlocationIdsetupIdsetupIdsubscriberIdsubscriberIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **areaId** | **int** | Numeric id of the Location Area. |  |
| **locationId** | **int?** | Numeric id of location. | [optional]  |
| **setupId** | **int?** | Numeric id of the Store Dashboard setup. | [optional]  |
| **subscriberId** | **int?** | Numeric id of subscriber. | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingIssueListsGetProblemTypesResponse**](SCServiceChannelServicesMessagingIssueListsGetProblemTypesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 1000 - Invalid setupId(dashboard) for current user;              &lt;br/&gt; 1001 - No issue list is available, please load it through issue list converter; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscriberscurrentstoredashboardscurrentissuelistareaslocationidlocationidsetupidsetupid"></a>
# **SubscribersCurrentStoredashboardsCurrentIssuelistAreaslocationIdlocationIdsetupIdsetupId**
> SCServiceChannelServicesMessagingIssueListsGetIssueAreasResponse SubscribersCurrentStoredashboardsCurrentIssuelistAreaslocationIdlocationIdsetupIdsetupId (int? locationId = null, int? setupId = null)

Get Areas

List Issue Areas. Returns Issue Areas for successful request.              <br /><br />Available for subscriber usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscribersCurrentStoredashboardsCurrentIssuelistAreaslocationIdlocationIdsetupIdsetupIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var locationId = 56;  // int? | selected locationId. (optional) 
            var setupId = 56;  // int? | Numeric id of the Store Dashboard setup. (optional) 

            try
            {
                // Get Areas
                SCServiceChannelServicesMessagingIssueListsGetIssueAreasResponse result = apiInstance.SubscribersCurrentStoredashboardsCurrentIssuelistAreaslocationIdlocationIdsetupIdsetupId(locationId, setupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.SubscribersCurrentStoredashboardsCurrentIssuelistAreaslocationIdlocationIdsetupIdsetupId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribersCurrentStoredashboardsCurrentIssuelistAreaslocationIdlocationIdsetupIdsetupIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Areas
    ApiResponse<SCServiceChannelServicesMessagingIssueListsGetIssueAreasResponse> response = apiInstance.SubscribersCurrentStoredashboardsCurrentIssuelistAreaslocationIdlocationIdsetupIdsetupIdWithHttpInfo(locationId, setupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.SubscribersCurrentStoredashboardsCurrentIssuelistAreaslocationIdlocationIdsetupIdsetupIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int?** | selected locationId. | [optional]  |
| **setupId** | **int?** | Numeric id of the Store Dashboard setup. | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingIssueListsGetIssueAreasResponse**](SCServiceChannelServicesMessagingIssueListsGetIssueAreasResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 1000 - Invalid setupId(dashboard) for current user; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscriberscurrentstoredashboardscurrentissuelistfieldididsetupidsetupid"></a>
# **SubscribersCurrentStoredashboardsCurrentIssuelistFieldididsetupIdsetupId**
> Object SubscribersCurrentStoredashboardsCurrentIssuelistFieldididsetupIdsetupId (string id, int? setupId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscribersCurrentStoredashboardsCurrentIssuelistFieldididsetupIdsetupIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var id = "id_example";  // string | 
            var setupId = 56;  // int? |  (optional) 

            try
            {
                Object result = apiInstance.SubscribersCurrentStoredashboardsCurrentIssuelistFieldididsetupIdsetupId(id, setupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.SubscribersCurrentStoredashboardsCurrentIssuelistFieldididsetupIdsetupId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribersCurrentStoredashboardsCurrentIssuelistFieldididsetupIdsetupIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.SubscribersCurrentStoredashboardsCurrentIssuelistFieldididsetupIdsetupIdWithHttpInfo(id, setupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.SubscribersCurrentStoredashboardsCurrentIssuelistFieldididsetupIdsetupIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **setupId** | **int?** |  | [optional]  |

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

<a id="subscriberscurrentstoredashboardscurrentissuelistissuechoiceproblemtypeproblemtypeequipmenttypeequipmenttypeproblemcodeproblemcodelocationidlocationidsetupidsetupid"></a>
# **SubscribersCurrentStoredashboardsCurrentIssuelistIssuechoiceproblemTypeproblemTypeequipmentTypeequipmentTypeproblemCodeproblemCodelocationIdlocationIdsetupIdsetupId**
> Object SubscribersCurrentStoredashboardsCurrentIssuelistIssuechoiceproblemTypeproblemTypeequipmentTypeequipmentTypeproblemCodeproblemCodelocationIdlocationIdsetupIdsetupId (string problemType, string equipmentType, string problemCode, int locationId, int? setupId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscribersCurrentStoredashboardsCurrentIssuelistIssuechoiceproblemTypeproblemTypeequipmentTypeequipmentTypeproblemCodeproblemCodelocationIdlocationIdsetupIdsetupIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var problemType = "problemType_example";  // string | 
            var equipmentType = "equipmentType_example";  // string | 
            var problemCode = "problemCode_example";  // string | 
            var locationId = 56;  // int | 
            var setupId = 56;  // int? |  (optional) 

            try
            {
                Object result = apiInstance.SubscribersCurrentStoredashboardsCurrentIssuelistIssuechoiceproblemTypeproblemTypeequipmentTypeequipmentTypeproblemCodeproblemCodelocationIdlocationIdsetupIdsetupId(problemType, equipmentType, problemCode, locationId, setupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.SubscribersCurrentStoredashboardsCurrentIssuelistIssuechoiceproblemTypeproblemTypeequipmentTypeequipmentTypeproblemCodeproblemCodelocationIdlocationIdsetupIdsetupId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribersCurrentStoredashboardsCurrentIssuelistIssuechoiceproblemTypeproblemTypeequipmentTypeequipmentTypeproblemCodeproblemCodelocationIdlocationIdsetupIdsetupIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.SubscribersCurrentStoredashboardsCurrentIssuelistIssuechoiceproblemTypeproblemTypeequipmentTypeequipmentTypeproblemCodeproblemCodelocationIdlocationIdsetupIdsetupIdWithHttpInfo(problemType, equipmentType, problemCode, locationId, setupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.SubscribersCurrentStoredashboardsCurrentIssuelistIssuechoiceproblemTypeproblemTypeequipmentTypeequipmentTypeproblemCodeproblemCodelocationIdlocationIdsetupIdsetupIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **problemType** | **string** |  |  |
| **equipmentType** | **string** |  |  |
| **problemCode** | **string** |  |  |
| **locationId** | **int** |  |  |
| **setupId** | **int?** |  | [optional]  |

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

<a id="subscriberscurrentstoredashboardscurrentissuelistspecificissuechoicesubscriberidsubscriberiddashboardsetupiddashboardsetupidtradetradepriorityprioritycategorycategory"></a>
# **SubscribersCurrentStoredashboardsCurrentIssuelistSpecificIssuechoiceSubscriberIdSubscriberIdDashboardSetupIdDashboardSetupIdTradeTradePriorityPriorityCategoryCategory**
> Object SubscribersCurrentStoredashboardsCurrentIssuelistSpecificIssuechoiceSubscriberIdSubscriberIdDashboardSetupIdDashboardSetupIdTradeTradePriorityPriorityCategoryCategory (int subscriberId, int dashboardSetupId, string trade, string priority, string category)

Get specific issue choice

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscribersCurrentStoredashboardsCurrentIssuelistSpecificIssuechoiceSubscriberIdSubscriberIdDashboardSetupIdDashboardSetupIdTradeTradePriorityPriorityCategoryCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IssueListApi(config);
            var subscriberId = 56;  // int | 
            var dashboardSetupId = 56;  // int | 
            var trade = "trade_example";  // string | 
            var priority = "priority_example";  // string | 
            var category = "category_example";  // string | 

            try
            {
                // Get specific issue choice
                Object result = apiInstance.SubscribersCurrentStoredashboardsCurrentIssuelistSpecificIssuechoiceSubscriberIdSubscriberIdDashboardSetupIdDashboardSetupIdTradeTradePriorityPriorityCategoryCategory(subscriberId, dashboardSetupId, trade, priority, category);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueListApi.SubscribersCurrentStoredashboardsCurrentIssuelistSpecificIssuechoiceSubscriberIdSubscriberIdDashboardSetupIdDashboardSetupIdTradeTradePriorityPriorityCategoryCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribersCurrentStoredashboardsCurrentIssuelistSpecificIssuechoiceSubscriberIdSubscriberIdDashboardSetupIdDashboardSetupIdTradeTradePriorityPriorityCategoryCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get specific issue choice
    ApiResponse<Object> response = apiInstance.SubscribersCurrentStoredashboardsCurrentIssuelistSpecificIssuechoiceSubscriberIdSubscriberIdDashboardSetupIdDashboardSetupIdTradeTradePriorityPriorityCategoryCategoryWithHttpInfo(subscriberId, dashboardSetupId, trade, priority, category);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueListApi.SubscribersCurrentStoredashboardsCurrentIssuelistSpecificIssuechoiceSubscriberIdSubscriberIdDashboardSetupIdDashboardSetupIdTradeTradePriorityPriorityCategoryCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** |  |  |
| **dashboardSetupId** | **int** |  |  |
| **trade** | **string** |  |  |
| **priority** | **string** |  |  |
| **category** | **string** |  |  |

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

