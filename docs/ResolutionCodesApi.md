# ServiceChannel.Api.Api.ResolutionCodesApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ResolutionCodes**](ResolutionCodesApi.md#resolutioncodes) | **POST** /resolutionCodes | Add or update resolution codes for a work order |
| [**ResolutionCodesRootCauses**](ResolutionCodesApi.md#resolutioncodesrootcauses) | **POST** /resolutionCodes/rootCauses | Add or update root causes for a work order |
| [**ResolutionCodesRootCausessubscriberIdsubscriberIdtradetradecategorycategorylocationIdlocationIdproviderIdproviderIdassetCategoryIds0assetCategoryIds0assetCategoryIds1assetCategoryIds1keywordkeywordpagepagepageSizepageSize**](ResolutionCodesApi.md#resolutioncodesrootcausessubscriberidsubscriberidtradetradecategorycategorylocationidlocationidprovideridprovideridassetcategoryids0assetcategoryids0assetcategoryids1assetcategoryids1keywordkeywordpagepagepagesizepagesize) | **GET** /resolutionCodes/rootCauses | Get root causes |
| [**ResolutionCodesRootCausesworkOrderIdrootCauseIdrootCauseIdrootCauseTextrootCauseText**](ResolutionCodesApi.md#resolutioncodesrootcausesworkorderidrootcauseidrootcauseidrootcausetextrootcausetext) | **POST** /resolutionCodes/rootCauses/{workOrderId} | Add or update root causes for a work order |
| [**ResolutionCodessubscriberIdsubscriberIdtradetradecategorycategorylocationIdlocationIdproviderIdproviderIdassetCategoryIds0assetCategoryIds0assetCategoryIds1assetCategoryIds1keywordkeywordpagepagepageSizepageSize**](ResolutionCodesApi.md#resolutioncodessubscriberidsubscriberidtradetradecategorycategorylocationidlocationidprovideridprovideridassetcategoryids0assetcategoryids0assetcategoryids1assetcategoryids1keywordkeywordpagepagepagesizepagesize) | **GET** /resolutionCodes | Get resolution codes |
| [**ResolutionCodesworkOrderId**](ResolutionCodesApi.md#resolutioncodesworkorderid) | **GET** /resolutionCodes/{workOrderId} | Get resolution codes and root causes for a work order |
| [**ResolutionCodesworkOrderIdAssetCategories**](ResolutionCodesApi.md#resolutioncodesworkorderidassetcategories) | **GET** /resolutionCodes/{workOrderId}/assetCategories | Retrieve asset categories for a work order |
| [**ResolutionCodesworkOrderIdAssetCategories_0**](ResolutionCodesApi.md#resolutioncodesworkorderidassetcategories_0) | **POST** /resolutionCodes/{workOrderId}/assetCategories | Add or update asset categories for a work order |

<a id="resolutioncodes"></a>
# **ResolutionCodes**
> void ResolutionCodes (SCServiceChannelServicesMessagingResolutionCodesUpdateResolutionCodesRequest request)

Add or update resolution codes for a work order

Associates resolution codes with the specified work order. If resolution codes are already added to a work order, you can change them by sending the request.              <br />Learn [how providers can add or edit resolution codes](https://servicechannel.atlassian.net/wiki/spaces/SCUCP/pages/1688502858/Resolution+and+Root+Causes+Codes+in+Provider+Automation#ResolutionandRootCausesCodesinProviderAutomation-ProcessingRRCsProcessingResolutionandRootCauseCodes) in ServiceChannel University.              <br />**Example Requests**                                  OPTION 1:                  POST /resolutionCodes                  {                     \"WorkOrderId\": 158716211,                     \"ResolutionCodeIds\": [                       2145, 2147                   ],                     \"ResolutionCodes\": []                  }                                  OPTION 2:                  POST /resolutionCodes                  {                     \"WorkOrderId\": 158716211,                     \"ResolutionCodeIds\": [],                     \"ResolutionCodes\": [                      {                       \"Key\": 2189,                       \"Text\": \"Repair wings\",                       \"AssetCategoryId\": 5                      },                      {                       \"Key\": 2146,                       \"Text\": \"\",                       \"AssetCategoryId\": 2                      }                     ]                  }

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ResolutionCodesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ResolutionCodesApi(config);
            var request = new SCServiceChannelServicesMessagingResolutionCodesUpdateResolutionCodesRequest(); // SCServiceChannelServicesMessagingResolutionCodesUpdateResolutionCodesRequest | Request to add or update resolution codes for a work order.               <br />**Required parameters:**               • `WorkOrderId`. Unique numeric identifier of the work order to add resolution codes to.               • Use one of the following collections to add resolution codes. To get resolution code IDs, send the [GET /resolutionCodes](https://developer.servicechannel.com/swagger/ui/index?version=3#/ResolutionCodes/GETv3_resolutionCodes_subscriberId__subscriberId__trade__trade__category__category__locationId__locationId__providerId__providerId__assetCategoryIds_0___assetCategoryIds_0___assetCategoryIds_1___assetCategoryIds_1___keyword__keyword__page__page__pageSize__pageSize_) request, and look for the `Key` value of the desired code in the response.                 ◦ `ResolutionCodeIds`. Enter resolution code IDs separated by commas.                ◦ `ResolutionCodes`. For each resolution code you want to add, pass an object with the following parameters: `Key`, `Text` — optional comment for resolution codes with the `HasFreeText` attribute, and `AssetCategoryId` (required if you have access to asset categories).              <br />Users who have access to asset categories should add 1–3 resolution codes for each asset category associated with a work order. Otherwise, you can specify up to 3 resolution codes for a work order.

            try
            {
                // Add or update resolution codes for a work order
                apiInstance.ResolutionCodes(request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResolutionCodesApi.ResolutionCodes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResolutionCodesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add or update resolution codes for a work order
    apiInstance.ResolutionCodesWithHttpInfo(request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResolutionCodesApi.ResolutionCodesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingResolutionCodesUpdateResolutionCodesRequest**](SCServiceChannelServicesMessagingResolutionCodesUpdateResolutionCodesRequest.md) | Request to add or update resolution codes for a work order.               &lt;br /&gt;**Required parameters:**               • &#x60;WorkOrderId&#x60;. Unique numeric identifier of the work order to add resolution codes to.               • Use one of the following collections to add resolution codes. To get resolution code IDs, send the [GET /resolutionCodes](https://developer.servicechannel.com/swagger/ui/index?version&#x3D;3#/ResolutionCodes/GETv3_resolutionCodes_subscriberId__subscriberId__trade__trade__category__category__locationId__locationId__providerId__providerId__assetCategoryIds_0___assetCategoryIds_0___assetCategoryIds_1___assetCategoryIds_1___keyword__keyword__page__page__pageSize__pageSize_) request, and look for the &#x60;Key&#x60; value of the desired code in the response.                 ◦ &#x60;ResolutionCodeIds&#x60;. Enter resolution code IDs separated by commas.                ◦ &#x60;ResolutionCodes&#x60;. For each resolution code you want to add, pass an object with the following parameters: &#x60;Key&#x60;, &#x60;Text&#x60; — optional comment for resolution codes with the &#x60;HasFreeText&#x60; attribute, and &#x60;AssetCategoryId&#x60; (required if you have access to asset categories).              &lt;br /&gt;Users who have access to asset categories should add 1–3 resolution codes for each asset category associated with a work order. Otherwise, you can specify up to 3 resolution codes for a work order. |  |

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
| **200** | Resolution codes are added to the specified work order. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              4100 — You can specify up to 3 resolution codes for a work order              4101 — You need to specify at least one resolution code              4108 — The max length of the resolution code text is exceeded              4109 — Resolution code text must be unique              4110 — Resolution code without free text must be unique              4122 — You need to specify up to 3 resolution codes per asset category for all asset categories assigned to the work order |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **403** | You are not authorized to request this resource, or the resource is unavailable for some reason.              &lt;br/&gt;Error codes:               4107 — You don&#39;t have access to set the resolution code text |  -  |
| **404** | The requested resource does not exist on the server.              &lt;br/&gt;Error codes:              502 — Data nor found |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="resolutioncodesrootcauses"></a>
# **ResolutionCodesRootCauses**
> void ResolutionCodesRootCauses (SCServiceChannelServicesMessagingResolutionCodesUpdateRootCausesRequest request)

Add or update root causes for a work order

For users who have access to asset categories, associates root causes with the specified work order. If root causes are already added to a work order, you can replace them by sending the request. You need to specify one root cause for each asset category of a work order.              <br />Get root cause IDs using the [GET /resolutionCodes/rootCauses](https://developer.servicechannel.com/swagger/ui/index?version=3#/ResolutionCodes/GETv3_resolutionCodes_rootCauses_subscriberId__subscriberId__trade__trade__category__category__locationId__locationId__providerId__providerId__assetCategoryIds_0___assetCategoryIds_0___assetCategoryIds_1___assetCategoryIds_1___keyword__keyword__page__page__pageSize__pageSize_) method. To retrieve asset category IDs, send the [GET /AssetTypes/GetAssetTypeGroups](https://developer.servicechannel.com/swagger/ui/index?version=3#/AssetTypes/GETv3_AssetTypes_GetAssetTypeGroups_subscriberId__subscriberId_) request.              <br />***Note:*** Users who don't have access to asset categories should pass the [POST /resolutionCodes/rootCauses/{workOrderId}](https://developer.servicechannel.com/swagger/ui/index?version=3#/ResolutionCodes/POSTv3_resolutionCodes_rootCauses__workOrderId__rootCauseId__rootCauseId__rootCauseText__rootCauseText_) request to add or update a root cause for a work order.              <br />Visit ServiceChannel University to find out [how providers can add or edit root causes](https://servicechannel.atlassian.net/wiki/spaces/SCUCP/pages/1688502858/Resolution+and+Root+Causes+Codes+in+Provider+Automation#ResolutionandRootCausesCodesinProviderAutomation-ProcessingRRCsProcessingResolutionandRootCauseCodes).              <br />**Example Request**                               POST /resolutionCodes/rootCauses                 {                   \"WorkOrderId\": 175444600,                   \"RootCauses\": [                    {                      \"Key\": 419,                      \"Text\": \"Accidental damage\",                      \"AssetCategoryId\": 1                    },                    {                      \"Key\": 420,                      \"Text\": \"\",                      \"AssetCategoryId\": 2                    }                  ]                 }

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ResolutionCodesRootCausesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ResolutionCodesApi(config);
            var request = new SCServiceChannelServicesMessagingResolutionCodesUpdateRootCausesRequest(); // SCServiceChannelServicesMessagingResolutionCodesUpdateRootCausesRequest | Request to add or update root causes for a work order.

            try
            {
                // Add or update root causes for a work order
                apiInstance.ResolutionCodesRootCauses(request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResolutionCodesApi.ResolutionCodesRootCauses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResolutionCodesRootCausesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add or update root causes for a work order
    apiInstance.ResolutionCodesRootCausesWithHttpInfo(request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResolutionCodesApi.ResolutionCodesRootCausesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingResolutionCodesUpdateRootCausesRequest**](SCServiceChannelServicesMessagingResolutionCodesUpdateRootCausesRequest.md) | Request to add or update root causes for a work order. |  |

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
| **200** | Root causes are added to the specified work order. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              4102 - You need to select a root cause              4105 - The max length of the root cause text is exceeded              4117 - The work order doesn&#39;t have assigned asset categories. You need to specify at least one asset category              4118 - You need to specify one root cause per asset category for all asset categories assigned to the work order              4120 - Asset category is required |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 - API call rejected by security permissions |  -  |
| **403** | You are not authorized to request this resource, or the resource is unavailable for some reason.               &lt;br/&gt;Error codes:              4104 — You don&#39;t have access to set the root cause tex              4114 — You don&#39;t have access to asset categories |  -  |
| **404** | The requested resource does not exist on the server.              &lt;br/&gt;Error codes:              502 — Data not found |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="resolutioncodesrootcausessubscriberidsubscriberidtradetradecategorycategorylocationidlocationidprovideridprovideridassetcategoryids0assetcategoryids0assetcategoryids1assetcategoryids1keywordkeywordpagepagepagesizepagesize"></a>
# **ResolutionCodesRootCausessubscriberIdsubscriberIdtradetradecategorycategorylocationIdlocationIdproviderIdproviderIdassetCategoryIds0assetCategoryIds0assetCategoryIds1assetCategoryIds1keywordkeywordpagepagepageSizepageSize**
> List&lt;SCServiceChannelServicesMessagingResolutionCodesRootCause&gt; ResolutionCodesRootCausessubscriberIdsubscriberIdtradetradecategorycategorylocationIdlocationIdproviderIdproviderIdassetCategoryIds0assetCategoryIds0assetCategoryIds1assetCategoryIds1keywordkeywordpagepagepageSizepageSize (int subscriberId, string trade, string category, int locationId, int? providerId = null, List<int>? assetCategoryIds = null, string? keyword = null, int? page = null, int? pageSize = null)

Get root causes

Returns a list of root causes. Root causes are set up for trades and describe reasons why the problem occurred to begin with.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ResolutionCodesRootCausessubscriberIdsubscriberIdtradetradecategorycategorylocationIdlocationIdproviderIdproviderIdassetCategoryIds0assetCategoryIds0assetCategoryIds1assetCategoryIds1keywordkeywordpagepagepageSizepageSizeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ResolutionCodesApi(config);
            var subscriberId = 56;  // int | Unique subscriber identifier.
            var trade = "trade_example";  // string | Trade to return root causes for. A trade is an area of work for which a service is performed, such as _HVAC_, _Refrigeration_, or _Plumbing_.
            var category = "category_example";  // string | Category to return root causes for. A category is the overall classification of a work order, such as _Maintenance_, _Repair_, or _CAPEX_.
            var locationId = 56;  // int | Unique identifier of a subscriber’s location.
            var providerId = 56;  // int? | Unique provider identifier. Should be passed by subscriber users. (optional) 
            var assetCategoryIds = new List<int>?(); // List<int>? | IDs of asset categories to return root causes for. You can specify up to 5 asset categories if you have access to this functionality. (optional) 
            var keyword = "keyword_example";  // string? | Keyword contained in root causes to perform the search by. (optional) 
            var page = 56;  // int? | Results page number. (optional) 
            var pageSize = 56;  // int? | Number of objects on the results page. The default is 10. (optional) 

            try
            {
                // Get root causes
                List<SCServiceChannelServicesMessagingResolutionCodesRootCause> result = apiInstance.ResolutionCodesRootCausessubscriberIdsubscriberIdtradetradecategorycategorylocationIdlocationIdproviderIdproviderIdassetCategoryIds0assetCategoryIds0assetCategoryIds1assetCategoryIds1keywordkeywordpagepagepageSizepageSize(subscriberId, trade, category, locationId, providerId, assetCategoryIds, keyword, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResolutionCodesApi.ResolutionCodesRootCausessubscriberIdsubscriberIdtradetradecategorycategorylocationIdlocationIdproviderIdproviderIdassetCategoryIds0assetCategoryIds0assetCategoryIds1assetCategoryIds1keywordkeywordpagepagepageSizepageSize: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResolutionCodesRootCausessubscriberIdsubscriberIdtradetradecategorycategorylocationIdlocationIdproviderIdproviderIdassetCategoryIds0assetCategoryIds0assetCategoryIds1assetCategoryIds1keywordkeywordpagepagepageSizepageSizeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get root causes
    ApiResponse<List<SCServiceChannelServicesMessagingResolutionCodesRootCause>> response = apiInstance.ResolutionCodesRootCausessubscriberIdsubscriberIdtradetradecategorycategorylocationIdlocationIdproviderIdproviderIdassetCategoryIds0assetCategoryIds0assetCategoryIds1assetCategoryIds1keywordkeywordpagepagepageSizepageSizeWithHttpInfo(subscriberId, trade, category, locationId, providerId, assetCategoryIds, keyword, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResolutionCodesApi.ResolutionCodesRootCausessubscriberIdsubscriberIdtradetradecategorycategorylocationIdlocationIdproviderIdproviderIdassetCategoryIds0assetCategoryIds0assetCategoryIds1assetCategoryIds1keywordkeywordpagepagepageSizepageSizeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** | Unique subscriber identifier. |  |
| **trade** | **string** | Trade to return root causes for. A trade is an area of work for which a service is performed, such as _HVAC_, _Refrigeration_, or _Plumbing_. |  |
| **category** | **string** | Category to return root causes for. A category is the overall classification of a work order, such as _Maintenance_, _Repair_, or _CAPEX_. |  |
| **locationId** | **int** | Unique identifier of a subscriber’s location. |  |
| **providerId** | **int?** | Unique provider identifier. Should be passed by subscriber users. | [optional]  |
| **assetCategoryIds** | [**List&lt;int&gt;?**](int.md) | IDs of asset categories to return root causes for. You can specify up to 5 asset categories if you have access to this functionality. | [optional]  |
| **keyword** | **string?** | Keyword contained in root causes to perform the search by. | [optional]  |
| **page** | **int?** | Results page number. | [optional]  |
| **pageSize** | **int?** | Number of objects on the results page. The default is 10. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingResolutionCodesRootCause&gt;**](SCServiceChannelServicesMessagingResolutionCodesRootCause.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Root causes are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              4113 — You can specify up to 5 asset categories |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **403** | You are not authorized to request this resource, or the resource is unavailable for some reason.              &lt;br/&gt;Error codes:               4114 — You don&#39;t have access to asset categories |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="resolutioncodesrootcausesworkorderidrootcauseidrootcauseidrootcausetextrootcausetext"></a>
# **ResolutionCodesRootCausesworkOrderIdrootCauseIdrootCauseIdrootCauseTextrootCauseText**
> void ResolutionCodesRootCausesworkOrderIdrootCauseIdrootCauseIdrootCauseTextrootCauseText (int workOrderId, int? rootCauseId = null, string? rootCauseText = null)

Add or update root causes for a work order

For users who don't have access to asset categories, associates a root cause with the specified work order. If a root cause is already added to a work order, you can change it by sending the request.              <br />Before adding a root cause, use the [GET /resolutionCodes/rootCauses](https://developer.servicechannel.com/swagger/ui/index?version=3#/ResolutionCodes/GETv3_resolutionCodes_rootCauses_subscriberId__subscriberId__trade__trade__category__category__locationId__locationId__providerId__providerId__assetCategoryIds_0___assetCategoryIds_0___assetCategoryIds_1___assetCategoryIds_1___keyword__keyword__page__page__pageSize__pageSize_) method to find out if root causes are configured for the work order trade. To get a root cause ID, look for the `Key` value of the desired root cause in the response.              <br /> ***Note:*** Users with access to asset categories should send the following request to add or update root causes for a work order: [POST /resolutionCodes/rootCauses](https://developer.servicechannel.com/swagger/ui/index?version=3#/ResolutionCodes/POSTv3_resolutionCodes_rootCauses).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ResolutionCodesRootCausesworkOrderIdrootCauseIdrootCauseIdrootCauseTextrootCauseTextExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ResolutionCodesApi(config);
            var workOrderId = 56;  // int | Unique numeric identifier of the work order to add, update, or delete a root cause for.
            var rootCauseId = 56;  // int? | ID of the root cause to associate with the work order. Ignore this parameter to remove the current root causes from the work order. (optional) 
            var rootCauseText = "rootCauseText_example";  // string? | Comment explaining your understanding of the root cause of the work order.<br />Enabled for root causes with the `HasFreeText` attribute. The maximum length is 100 characters. (optional) 

            try
            {
                // Add or update root causes for a work order
                apiInstance.ResolutionCodesRootCausesworkOrderIdrootCauseIdrootCauseIdrootCauseTextrootCauseText(workOrderId, rootCauseId, rootCauseText);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResolutionCodesApi.ResolutionCodesRootCausesworkOrderIdrootCauseIdrootCauseIdrootCauseTextrootCauseText: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResolutionCodesRootCausesworkOrderIdrootCauseIdrootCauseIdrootCauseTextrootCauseTextWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add or update root causes for a work order
    apiInstance.ResolutionCodesRootCausesworkOrderIdrootCauseIdrootCauseIdrootCauseTextrootCauseTextWithHttpInfo(workOrderId, rootCauseId, rootCauseText);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResolutionCodesApi.ResolutionCodesRootCausesworkOrderIdrootCauseIdrootCauseIdrootCauseTextrootCauseTextWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrderId** | **int** | Unique numeric identifier of the work order to add, update, or delete a root cause for. |  |
| **rootCauseId** | **int?** | ID of the root cause to associate with the work order. Ignore this parameter to remove the current root causes from the work order. | [optional]  |
| **rootCauseText** | **string?** | Comment explaining your understanding of the root cause of the work order.&lt;br /&gt;Enabled for root causes with the &#x60;HasFreeText&#x60; attribute. The maximum length is 100 characters. | [optional]  |

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
| **200** | The root cause is added to the specified work order. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              4102 — You need to select a root cause              4105 — The max length of the root cause text is exceeded |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **403** | You are not authorized to request this resource, or the resource is unavailable for some reason.               &lt;br/&gt;Error codes:               4104 - You don&#39;t have access to set root cause text              4121 - You must use a method to set multiple root causes when you have access to asset categories |  -  |
| **404** | The requested resource does not exist on the server.              &lt;br/&gt;Error codes:              502 — Data nor found |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="resolutioncodessubscriberidsubscriberidtradetradecategorycategorylocationidlocationidprovideridprovideridassetcategoryids0assetcategoryids0assetcategoryids1assetcategoryids1keywordkeywordpagepagepagesizepagesize"></a>
# **ResolutionCodessubscriberIdsubscriberIdtradetradecategorycategorylocationIdlocationIdproviderIdproviderIdassetCategoryIds0assetCategoryIds0assetCategoryIds1assetCategoryIds1keywordkeywordpagepagepageSizepageSize**
> List&lt;SCServiceChannelServicesMessagingResolutionCodesResolutionCode&gt; ResolutionCodessubscriberIdsubscriberIdtradetradecategorycategorylocationIdlocationIdproviderIdproviderIdassetCategoryIds0assetCategoryIds0assetCategoryIds1assetCategoryIds1keywordkeywordpagepagepageSizepageSize (int subscriberId, string trade, string category, int locationId, int? providerId = null, List<int>? assetCategoryIds = null, string? keyword = null, int? page = null, int? pageSize = null)

Get resolution codes

Returns a list of resolution codes. Resolution codes are set up for trades and describe actions that a technician takes to resolve a problem upon working on a service request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ResolutionCodessubscriberIdsubscriberIdtradetradecategorycategorylocationIdlocationIdproviderIdproviderIdassetCategoryIds0assetCategoryIds0assetCategoryIds1assetCategoryIds1keywordkeywordpagepagepageSizepageSizeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ResolutionCodesApi(config);
            var subscriberId = 56;  // int | Unique subscriber identifier.
            var trade = "trade_example";  // string | Trade to return resolution codes for. A trade is an area of work for which a service is performed, such as _HVAC_, _Refrigeration_, or _Plumbing_.
            var category = "category_example";  // string | Category to return resolution codes for. A category is the overall classification of a work order, such as _Maintenance_, _Repair_, or _CAPEX_.
            var locationId = 56;  // int | Unique identifier of a subscriber’s location.
            var providerId = 56;  // int? | Unique provider identifier. Should be passed by subscriber users. (optional) 
            var assetCategoryIds = new List<int>?(); // List<int>? | IDs of asset categories to return resolution codes for. You can specify up to 5 asset categories if you have access to this functionality. (optional) 
            var keyword = "keyword_example";  // string? | Keyword contained in resolution codes to perform the search by. (optional) 
            var page = 56;  // int? | Results page number. (optional) 
            var pageSize = 56;  // int? | Number of objects on the results page. The default is 10. (optional) 

            try
            {
                // Get resolution codes
                List<SCServiceChannelServicesMessagingResolutionCodesResolutionCode> result = apiInstance.ResolutionCodessubscriberIdsubscriberIdtradetradecategorycategorylocationIdlocationIdproviderIdproviderIdassetCategoryIds0assetCategoryIds0assetCategoryIds1assetCategoryIds1keywordkeywordpagepagepageSizepageSize(subscriberId, trade, category, locationId, providerId, assetCategoryIds, keyword, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResolutionCodesApi.ResolutionCodessubscriberIdsubscriberIdtradetradecategorycategorylocationIdlocationIdproviderIdproviderIdassetCategoryIds0assetCategoryIds0assetCategoryIds1assetCategoryIds1keywordkeywordpagepagepageSizepageSize: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResolutionCodessubscriberIdsubscriberIdtradetradecategorycategorylocationIdlocationIdproviderIdproviderIdassetCategoryIds0assetCategoryIds0assetCategoryIds1assetCategoryIds1keywordkeywordpagepagepageSizepageSizeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get resolution codes
    ApiResponse<List<SCServiceChannelServicesMessagingResolutionCodesResolutionCode>> response = apiInstance.ResolutionCodessubscriberIdsubscriberIdtradetradecategorycategorylocationIdlocationIdproviderIdproviderIdassetCategoryIds0assetCategoryIds0assetCategoryIds1assetCategoryIds1keywordkeywordpagepagepageSizepageSizeWithHttpInfo(subscriberId, trade, category, locationId, providerId, assetCategoryIds, keyword, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResolutionCodesApi.ResolutionCodessubscriberIdsubscriberIdtradetradecategorycategorylocationIdlocationIdproviderIdproviderIdassetCategoryIds0assetCategoryIds0assetCategoryIds1assetCategoryIds1keywordkeywordpagepagepageSizepageSizeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** | Unique subscriber identifier. |  |
| **trade** | **string** | Trade to return resolution codes for. A trade is an area of work for which a service is performed, such as _HVAC_, _Refrigeration_, or _Plumbing_. |  |
| **category** | **string** | Category to return resolution codes for. A category is the overall classification of a work order, such as _Maintenance_, _Repair_, or _CAPEX_. |  |
| **locationId** | **int** | Unique identifier of a subscriber’s location. |  |
| **providerId** | **int?** | Unique provider identifier. Should be passed by subscriber users. | [optional]  |
| **assetCategoryIds** | [**List&lt;int&gt;?**](int.md) | IDs of asset categories to return resolution codes for. You can specify up to 5 asset categories if you have access to this functionality. | [optional]  |
| **keyword** | **string?** | Keyword contained in resolution codes to perform the search by. | [optional]  |
| **page** | **int?** | Results page number. | [optional]  |
| **pageSize** | **int?** | Number of objects on the results page. The default is 10. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingResolutionCodesResolutionCode&gt;**](SCServiceChannelServicesMessagingResolutionCodesResolutionCode.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Resolution codes are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              4113 — You can specify up to 5 asset categories |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **403** | You are not authorized to request this resource, or the resource is unavailable for some reason.              &lt;br/&gt;Error codes:               4114 — You don&#39;t have access to asset categories |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="resolutioncodesworkorderid"></a>
# **ResolutionCodesworkOrderId**
> SCServiceChannelServicesMessagingResolutionCodesWorkOrderResolutionInfo ResolutionCodesworkOrderId (int workOrderId)

Get resolution codes and root causes for a work order

Returns resolution codes and root causes for the specified work order.               • A **resolution code** is an action that a technician takes to resolve a problem upon working on a service request.               • A **root cause** is a reason why the problem occurred to begin with.              <br />Resolution codes and root causes are set up for specific trades and are standardized. If there are resolution codes and root causes configured for a work order trade, a technician is prompted to select these properties upon [checking out of a work order](https://servicechannel.atlassian.net/wiki/spaces/SCUCP/pages/622396960/Checking+In+and+Out+of+Work+Orders+Using+SC+Provider#CheckingInandOutofWorkOrdersUsingSCProvider-CheckingOutwithResolutionandRootCauseCodes) and moving it to the _Completed_ status in ServiceChannel Provider.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ResolutionCodesworkOrderIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ResolutionCodesApi(config);
            var workOrderId = 56;  // int | Unique identifier of the work order to return resolution codes and root causes for.

            try
            {
                // Get resolution codes and root causes for a work order
                SCServiceChannelServicesMessagingResolutionCodesWorkOrderResolutionInfo result = apiInstance.ResolutionCodesworkOrderId(workOrderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResolutionCodesApi.ResolutionCodesworkOrderId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResolutionCodesworkOrderIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get resolution codes and root causes for a work order
    ApiResponse<SCServiceChannelServicesMessagingResolutionCodesWorkOrderResolutionInfo> response = apiInstance.ResolutionCodesworkOrderIdWithHttpInfo(workOrderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResolutionCodesApi.ResolutionCodesworkOrderIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrderId** | **int** | Unique identifier of the work order to return resolution codes and root causes for. |  |

### Return type

[**SCServiceChannelServicesMessagingResolutionCodesWorkOrderResolutionInfo**](SCServiceChannelServicesMessagingResolutionCodesWorkOrderResolutionInfo.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Resolution codes and root causes for the specified work order are in the response. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **404** | The requested resource does not exist on the server.              &lt;br/&gt;Error codes:              502 — Data not found |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="resolutioncodesworkorderidassetcategories"></a>
# **ResolutionCodesworkOrderIdAssetCategories**
> SCServiceChannelServicesMessagingAssetsAssetTypeCategory ResolutionCodesworkOrderIdAssetCategories (int workOrderId)

Retrieve asset categories for a work order

Returns asset categories associated with the specified work order. Asset categories represent a standardized classification of asset types.              <br />***Note:*** Only users who have access to asset categories can send this request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ResolutionCodesworkOrderIdAssetCategoriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ResolutionCodesApi(config);
            var workOrderId = 56;  // int | Unique numeric identifier of the work order to return asset categories for.

            try
            {
                // Retrieve asset categories for a work order
                SCServiceChannelServicesMessagingAssetsAssetTypeCategory result = apiInstance.ResolutionCodesworkOrderIdAssetCategories(workOrderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResolutionCodesApi.ResolutionCodesworkOrderIdAssetCategories: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResolutionCodesworkOrderIdAssetCategoriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve asset categories for a work order
    ApiResponse<SCServiceChannelServicesMessagingAssetsAssetTypeCategory> response = apiInstance.ResolutionCodesworkOrderIdAssetCategoriesWithHttpInfo(workOrderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResolutionCodesApi.ResolutionCodesworkOrderIdAssetCategoriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrderId** | **int** | Unique numeric identifier of the work order to return asset categories for. |  |

### Return type

[**SCServiceChannelServicesMessagingAssetsAssetTypeCategory**](SCServiceChannelServicesMessagingAssetsAssetTypeCategory.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Asset categories for the specified work order are in the response. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 - API call rejected by security permissions |  -  |
| **403** | You are not authorized to request this resource, or the resource is unavailable for some reason.               &lt;br/&gt;Error codes:               4114 - You don&#39;t have access to asset categories |  -  |
| **404** | The requested resource does not exist on the server.              &lt;br/&gt;Error codes:              502 — Data not found |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="resolutioncodesworkorderidassetcategories_0"></a>
# **ResolutionCodesworkOrderIdAssetCategories_0**
> void ResolutionCodesworkOrderIdAssetCategories_0 (int workOrderId, SCServiceChannelServicesMessagingResolutionCodesUpdateAssetCategoriesRequest request)

Add or update asset categories for a work order

Associates asset categories with the specified work order. Sending this request replaces the current asset categories.              <br />Asset categories represent a standardized classification of asset types. You can add no more than 5 asset categories to a work order.              <br />***Note:*** Only users who have access to asset categories can send this request.                  <br />**Example Request**                               POST /resolutionCodes/{workOrderId}/assetCategories                 {                   \"AssetCategoryIds\": [                     1, 4, 6                   ]                 }

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ResolutionCodesworkOrderIdAssetCategories_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ResolutionCodesApi(config);
            var workOrderId = 56;  // int | Unique numeric identifier of the work order to add asset categories to.
            var request = new SCServiceChannelServicesMessagingResolutionCodesUpdateAssetCategoriesRequest(); // SCServiceChannelServicesMessagingResolutionCodesUpdateAssetCategoriesRequest | Request to add or update asset categories for a work order.

            try
            {
                // Add or update asset categories for a work order
                apiInstance.ResolutionCodesworkOrderIdAssetCategories_0(workOrderId, request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ResolutionCodesApi.ResolutionCodesworkOrderIdAssetCategories_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResolutionCodesworkOrderIdAssetCategories_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add or update asset categories for a work order
    apiInstance.ResolutionCodesworkOrderIdAssetCategories_0WithHttpInfo(workOrderId, request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ResolutionCodesApi.ResolutionCodesworkOrderIdAssetCategories_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrderId** | **int** | Unique numeric identifier of the work order to add asset categories to. |  |
| **request** | [**SCServiceChannelServicesMessagingResolutionCodesUpdateAssetCategoriesRequest**](SCServiceChannelServicesMessagingResolutionCodesUpdateAssetCategoriesRequest.md) | Request to add or update asset categories for a work order. |  |

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
| **200** | Asset categories are added to the specified work order. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              4113 - You can specify up to 5 asset categories              4115 - You need to specify at least one asset category              4116 - Invalid asset category id |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 - API call rejected by security permissions |  -  |
| **403** | You are not authorized to request this resource, or the resource is unavailable for some reason.               &lt;br/&gt;Error codes:               4114 - You don&#39;t have access to asset categories |  -  |
| **404** | The requested resource does not exist on the server.              &lt;br/&gt;Error codes:              502 — Data not found |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

