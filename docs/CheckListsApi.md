# ServiceChannel.Api.Api.CheckListsApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ChecklistsCheckListResponse**](CheckListsApi.md#checklistschecklistresponse) | **POST** /checklists/CheckListResponse | Submit a response to a checklist question |
| [**ChecklistsDetailtradeidtradeidchecklistidchecklistidcategoryidcategoryidsubscriberIdsubscriberIdtradeNametradeNamecheckListNamecheckListNamecategoryNamecategoryNamelocationIdlocationIdstoreIdstoreIdworkOrderIdworkOrderId**](CheckListsApi.md#checklistsdetailtradeidtradeidchecklistidchecklistidcategoryidcategoryidsubscriberidsubscriberidtradenametradenamechecklistnamechecklistnamecategorynamecategorynamelocationidlocationidstoreidstoreidworkorderidworkorderid) | **GET** /checklists/detail | Get standard checklists |
| [**ChecklistsTaskslisttradeidtradeidchecklistidchecklistidcategoryidcategoryidsubscriberIdsubscriberIdtradeNametradeNamecheckListNamecheckListNamecategoryNamecategoryNamelocationIdlocationIdstoreIdstoreIdproviderIdproviderId**](CheckListsApi.md#checkliststaskslisttradeidtradeidchecklistidchecklistidcategoryidcategoryidsubscriberidsubscriberidtradenametradenamechecklistnamechecklistnamecategorynamecategorynamelocationidlocationidstoreidstoreidprovideridproviderid) | **GET** /checklists/taskslist | Get checklists with asset tasks |
| [**ChecklistsTypestradeIdtradeIdchecklistIdchecklistIdcategoryIdcategoryIdsubscriberIdsubscriberIdtradeNametradeNamechecklistNamechecklistNamecategoryNamecategoryNamelocationIdlocationIdstoreIdstoreIdproviderIdproviderId**](CheckListsApi.md#checkliststypestradeidtradeidchecklistidchecklistidcategoryidcategoryidsubscriberidsubscriberidtradenametradenamechecklistnamechecklistnamecategorynamecategorynamelocationidlocationidstoreidstoreidprovideridproviderid) | **GET** /checklists/types | Retrieve checklist types |
| [**ChecklistscheckListResponseIdCheckListResponse**](CheckListsApi.md#checklistschecklistresponseidchecklistresponse) | **PUT** /checklists/{checkListResponseId}/CheckListResponse | Update a response to a checklist question |

<a id="checklistschecklistresponse"></a>
# **ChecklistsCheckListResponse**
> SCServiceChannelServicesMessagingCheckListDetailsCheckListResponsesResponsePicture ChecklistsCheckListResponse (Object? checkListResponseRequest = null, System.IO.Stream? file = null)

Submit a response to a checklist question

Creates a response to the specified checklist question. Learn more about [submitting checklist responses](https://developer.servicechannel.com/guides/checklists/submit-a-checklist-response/).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ChecklistsCheckListResponseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CheckListsApi(config);
            var checkListResponseRequest = new Object?(); // Object? | Request to create a response to a checklist question. Retrieve checklist parameters using the [GET /checklists/detail](https://developer.servicechannel.com/swagger/ui/index?version=3#/CheckLists/GETv3_checklists_detail_tradeid__tradeid__checklistid__checklistid__categoryid__categoryid__subscriberId__subscriberId__tradeName__tradeName__checkListName__checkListName__categoryName__categoryName__locationId__locationId__storeId__storeId_) method to make sure you pass valid values.              <br />Pass the following parameters in the request:               • **CheckListQuestionId** *(Required)*: ID of the checklist question to submit a response for.               • **CheckListQuestionOptionId**: ID of the answer option configured for a checklist question of the **Selector** type.               • **ProviderId** *(Required)*: ID of the provider on whose behalf you are submitting a response.               • **TechnicianID**: ID of the technician on whose behalf you are submitting a response.               • **AuthUserId**: Single sign-on (SSO) ID of the technician on whose behalf you are submitting a response.               • **Answer**: Answer to a checklist question of the following types:                ◦ **Acknowledgement**. Valid values: `on`, `off`, `1`, `0`, `true`, `false`, `yes`, `no`.                ◦ **Text Entry**. Enter a text answer. The maximum length is 500 characters.                ◦ **Numeric Input**. Submit a number.               • **FreeTextAnswer**: Comment to an answer option with the `IsConditionalFollowUp` attribute. Answer options are configured for questions of the **Selector** type.               • **EntityId** *(Required)*: Unique ID of the work order for which you are creating a response to a checklist question.               • **Attempt** *(Required)*: Order of a technician’s on-site visit to submit a checklist response for.              <br />**Example Object for the Acknowledgement Question**                                {                    \\\"CheckListQuestionID\\\": 3834,                    \\\"ProviderID\\\": 2000090505,                    \\\"TechnicianID\\\": 270592,                    \\\"AuthUserId\\\": 141,                    \\\"Answer\\\": \\\"on\\\",                    \\\"EntityID\\\": 179826000,                    \\\"Attempt\\\": 1                  } (optional) 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream? | File to attach to the response to a checklist question. Required for questions with the `PictureFlag` parameter set to 2. (optional) 

            try
            {
                // Submit a response to a checklist question
                SCServiceChannelServicesMessagingCheckListDetailsCheckListResponsesResponsePicture result = apiInstance.ChecklistsCheckListResponse(checkListResponseRequest, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CheckListsApi.ChecklistsCheckListResponse: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChecklistsCheckListResponseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Submit a response to a checklist question
    ApiResponse<SCServiceChannelServicesMessagingCheckListDetailsCheckListResponsesResponsePicture> response = apiInstance.ChecklistsCheckListResponseWithHttpInfo(checkListResponseRequest, file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CheckListsApi.ChecklistsCheckListResponseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **checkListResponseRequest** | [**Object?**](Object?.md) | Request to create a response to a checklist question. Retrieve checklist parameters using the [GET /checklists/detail](https://developer.servicechannel.com/swagger/ui/index?version&#x3D;3#/CheckLists/GETv3_checklists_detail_tradeid__tradeid__checklistid__checklistid__categoryid__categoryid__subscriberId__subscriberId__tradeName__tradeName__checkListName__checkListName__categoryName__categoryName__locationId__locationId__storeId__storeId_) method to make sure you pass valid values.              &lt;br /&gt;Pass the following parameters in the request:               • **CheckListQuestionId** *(Required)*: ID of the checklist question to submit a response for.               • **CheckListQuestionOptionId**: ID of the answer option configured for a checklist question of the **Selector** type.               • **ProviderId** *(Required)*: ID of the provider on whose behalf you are submitting a response.               • **TechnicianID**: ID of the technician on whose behalf you are submitting a response.               • **AuthUserId**: Single sign-on (SSO) ID of the technician on whose behalf you are submitting a response.               • **Answer**: Answer to a checklist question of the following types:                ◦ **Acknowledgement**. Valid values: &#x60;on&#x60;, &#x60;off&#x60;, &#x60;1&#x60;, &#x60;0&#x60;, &#x60;true&#x60;, &#x60;false&#x60;, &#x60;yes&#x60;, &#x60;no&#x60;.                ◦ **Text Entry**. Enter a text answer. The maximum length is 500 characters.                ◦ **Numeric Input**. Submit a number.               • **FreeTextAnswer**: Comment to an answer option with the &#x60;IsConditionalFollowUp&#x60; attribute. Answer options are configured for questions of the **Selector** type.               • **EntityId** *(Required)*: Unique ID of the work order for which you are creating a response to a checklist question.               • **Attempt** *(Required)*: Order of a technician’s on-site visit to submit a checklist response for.              &lt;br /&gt;**Example Object for the Acknowledgement Question**                                {                    \\\&quot;CheckListQuestionID\\\&quot;: 3834,                    \\\&quot;ProviderID\\\&quot;: 2000090505,                    \\\&quot;TechnicianID\\\&quot;: 270592,                    \\\&quot;AuthUserId\\\&quot;: 141,                    \\\&quot;Answer\\\&quot;: \\\&quot;on\\\&quot;,                    \\\&quot;EntityID\\\&quot;: 179826000,                    \\\&quot;Attempt\\\&quot;: 1                  } | [optional]  |
| **file** | **System.IO.Stream?****System.IO.Stream?** | File to attach to the response to a checklist question. Required for questions with the &#x60;PictureFlag&#x60; parameter set to 2. | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingCheckListDetailsCheckListResponsesResponsePicture**](SCServiceChannelServicesMessagingCheckListDetailsCheckListResponsesResponsePicture.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | A response to a checklist question is created. A checklist response object and an attachment object are returned. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              502 — Work order is not found              503 — Not all required parameters were specified              503 — The FreeTextAnswer is required              503 — The picture is required              503 — Checkbox responses only support next values: on, off, 1, 0, true, false, yes, no |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="checklistsdetailtradeidtradeidchecklistidchecklistidcategoryidcategoryidsubscriberidsubscriberidtradenametradenamechecklistnamechecklistnamecategorynamecategorynamelocationidlocationidstoreidstoreidworkorderidworkorderid"></a>
# **ChecklistsDetailtradeidtradeidchecklistidchecklistidcategoryidcategoryidsubscriberIdsubscriberIdtradeNametradeNamecheckListNamecheckListNamecategoryNamecategoryNamelocationIdlocationIdstoreIdstoreIdworkOrderIdworkOrderId**
> SCServiceChannelServicesMessagingCheckListDetailsCheckListDetailExtendedResponse ChecklistsDetailtradeidtradeidchecklistidchecklistidcategoryidcategoryidsubscriberIdsubscriberIdtradeNametradeNamecheckListNamecheckListNamecategoryNamecategoryNamelocationIdlocationIdstoreIdstoreIdworkOrderIdworkOrderId (int? tradeid = null, int? checklistid = null, int? categoryid = null, int? subscriberId = null, string? tradeName = null, string? checkListName = null, string? categoryName = null, int? locationId = null, string? storeId = null, int? workOrderId = null)

Get standard checklists

[Returns standard checklists](https://developer.servicechannel.com/guides/checklists/find-and-filter-checklists/) along with their parameters, configured questions, and answer options.              <br />You can filter checklists by:               • **Trade**. Specify either `tradeid` or `tradeName`.               • **Category**. Enter either `categoryid` or `categoryName`.               • **Location**. Provide either `locationId` or `storeId` if the feature that allows creating checklists for specific locations is enabled for a subscriber.               • **Checklist**. Pass either `checklistid` or `checkListName` to get a specific checklist, and ignore other parameters.              <br />Providers should pass `subscriberId` to retrieve checklists created by the desired subscriber.              <br />Navigate to ServiceChannel University to find out [how subscribers can configure checklists](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/655425975/Configuring+Checklists).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ChecklistsDetailtradeidtradeidchecklistidchecklistidcategoryidcategoryidsubscriberIdsubscriberIdtradeNametradeNamecheckListNamecheckListNamecategoryNamecategoryNamelocationIdlocationIdstoreIdstoreIdworkOrderIdworkOrderIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CheckListsApi(config);
            var tradeid = 56;  // int? | Trade ID. To get a list of trades with their IDs, send the [GET /odata/trades](https://developer.servicechannel.com/swagger/ui/index?version=3#/Trades/Trades_GetTrades) request. (optional) 
            var checklistid = 56;  // int? | Checklist ID. (optional) 
            var categoryid = 56;  // int? | Category ID. Subscribers can retrieve category IDs using the [GET /categories](https://developer.servicechannel.com/swagger/ui/index?version=3#/Categories/GETv3_categories_subscriberIds_0___subscriberIds_0___subscriberIds_1___subscriberIds_1__) method. (optional) 
            var subscriberId = 56;  // int? | Unique ID of the subscriber who configured checklists. Should be passed by providers. (optional) 
            var tradeName = "tradeName_example";  // string? | Trade name. A trade is an area of work for which a service is performed, such as _Lighting_, _Refrigeration_, or _Plumbing_. (optional) 
            var checkListName = "checkListName_example";  // string? | Checklist name. (optional) 
            var categoryName = "categoryName_example";  // string? | Category name. A category is the overall classification of a work order, such as _Maintenance_, _Repair_, or _CAPEX_. (optional) 
            var locationId = 56;  // int? | Unique ID of a subscriber’s location. This parameter is ignored if the feature that allows creating checklists for specific locations is disabled for a subscriber. (optional) 
            var storeId = "storeId_example";  // string? | Non-unique ID of a subscriber’s location that may appear as a store number. This parameter is ignored if the feature that allows creating checklists for specific locations is disabled for a subscriber. (optional) 
            var workOrderId = 56;  // int? | Work Order ID (optional) 

            try
            {
                // Get standard checklists
                SCServiceChannelServicesMessagingCheckListDetailsCheckListDetailExtendedResponse result = apiInstance.ChecklistsDetailtradeidtradeidchecklistidchecklistidcategoryidcategoryidsubscriberIdsubscriberIdtradeNametradeNamecheckListNamecheckListNamecategoryNamecategoryNamelocationIdlocationIdstoreIdstoreIdworkOrderIdworkOrderId(tradeid, checklistid, categoryid, subscriberId, tradeName, checkListName, categoryName, locationId, storeId, workOrderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CheckListsApi.ChecklistsDetailtradeidtradeidchecklistidchecklistidcategoryidcategoryidsubscriberIdsubscriberIdtradeNametradeNamecheckListNamecheckListNamecategoryNamecategoryNamelocationIdlocationIdstoreIdstoreIdworkOrderIdworkOrderId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChecklistsDetailtradeidtradeidchecklistidchecklistidcategoryidcategoryidsubscriberIdsubscriberIdtradeNametradeNamecheckListNamecheckListNamecategoryNamecategoryNamelocationIdlocationIdstoreIdstoreIdworkOrderIdworkOrderIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get standard checklists
    ApiResponse<SCServiceChannelServicesMessagingCheckListDetailsCheckListDetailExtendedResponse> response = apiInstance.ChecklistsDetailtradeidtradeidchecklistidchecklistidcategoryidcategoryidsubscriberIdsubscriberIdtradeNametradeNamecheckListNamecheckListNamecategoryNamecategoryNamelocationIdlocationIdstoreIdstoreIdworkOrderIdworkOrderIdWithHttpInfo(tradeid, checklistid, categoryid, subscriberId, tradeName, checkListName, categoryName, locationId, storeId, workOrderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CheckListsApi.ChecklistsDetailtradeidtradeidchecklistidchecklistidcategoryidcategoryidsubscriberIdsubscriberIdtradeNametradeNamecheckListNamecheckListNamecategoryNamecategoryNamelocationIdlocationIdstoreIdstoreIdworkOrderIdworkOrderIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tradeid** | **int?** | Trade ID. To get a list of trades with their IDs, send the [GET /odata/trades](https://developer.servicechannel.com/swagger/ui/index?version&#x3D;3#/Trades/Trades_GetTrades) request. | [optional]  |
| **checklistid** | **int?** | Checklist ID. | [optional]  |
| **categoryid** | **int?** | Category ID. Subscribers can retrieve category IDs using the [GET /categories](https://developer.servicechannel.com/swagger/ui/index?version&#x3D;3#/Categories/GETv3_categories_subscriberIds_0___subscriberIds_0___subscriberIds_1___subscriberIds_1__) method. | [optional]  |
| **subscriberId** | **int?** | Unique ID of the subscriber who configured checklists. Should be passed by providers. | [optional]  |
| **tradeName** | **string?** | Trade name. A trade is an area of work for which a service is performed, such as _Lighting_, _Refrigeration_, or _Plumbing_. | [optional]  |
| **checkListName** | **string?** | Checklist name. | [optional]  |
| **categoryName** | **string?** | Category name. A category is the overall classification of a work order, such as _Maintenance_, _Repair_, or _CAPEX_. | [optional]  |
| **locationId** | **int?** | Unique ID of a subscriber’s location. This parameter is ignored if the feature that allows creating checklists for specific locations is disabled for a subscriber. | [optional]  |
| **storeId** | **string?** | Non-unique ID of a subscriber’s location that may appear as a store number. This parameter is ignored if the feature that allows creating checklists for specific locations is disabled for a subscriber. | [optional]  |
| **workOrderId** | **int?** | Work Order ID | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingCheckListDetailsCheckListDetailExtendedResponse**](SCServiceChannelServicesMessagingCheckListDetailsCheckListDetailExtendedResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested standard checklists are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              503 — Bad Request; Subscriber Id should be provided if the api method is called by provider              503 — A trade can be specified with only one parameter: either tradeId or tradeName              503 — A category can be specified with only one parameter: either categoryId or categoryName              503 — A checkList can be specified with only one parameter: either checkListId or checkListName              503 — A location can be specified with only one parameter: either locationId or storeId |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **403** | The request is not allowed.              &lt;br/&gt;Error codes:              100 — User does not have access to work order |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="checkliststaskslisttradeidtradeidchecklistidchecklistidcategoryidcategoryidsubscriberidsubscriberidtradenametradenamechecklistnamechecklistnamecategorynamecategorynamelocationidlocationidstoreidstoreidprovideridproviderid"></a>
# **ChecklistsTaskslisttradeidtradeidchecklistidchecklistidcategoryidcategoryidsubscriberIdsubscriberIdtradeNametradeNamecheckListNamecheckListNamecategoryNamecategoryNamelocationIdlocationIdstoreIdstoreIdproviderIdproviderId**
> SCServiceChannelServicesMessagingChecklistTasksCheckListWithTasksExtendedResponse ChecklistsTaskslisttradeidtradeidchecklistidchecklistidcategoryidcategoryidsubscriberIdsubscriberIdtradeNametradeNamecheckListNamecheckListNamecategoryNamecategoryNamelocationIdlocationIdstoreIdstoreIdproviderIdproviderId (int? tradeid = null, int? checklistid = null, int? categoryid = null, int? subscriberId = null, string? tradeName = null, string? checkListName = null, string? categoryName = null, int? locationId = null, string? storeId = null, int? providerId = null)

Get checklists with asset tasks

Retrieves checklists of the **Asset Task** type along with their parameters and task details. Such checklists contain asset-related tasks that a technician is prompted to complete when working on a service request.              <br />You can filter checklists by:               • **Trade**. Specify either `tradeid` or `tradeName`.               • **Category**. Enter either `categoryid` or `categoryName`.               • **Location**. Provide either `locationId` or `storeId` if the feature that allows creating checklists for specific locations is enabled for a subscriber.               • **Checklist**. Pass either `checklistid` or `checkListName` to get a specific checklist, and ignore other parameters.              <br />Providers should pass `subscriberId` to retrieve checklists created by the desired subscriber.              <br />Navigate to ServiceChannel University to find out [how subscribers can configure checklists](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/655425975/Configuring+Checklists).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ChecklistsTaskslisttradeidtradeidchecklistidchecklistidcategoryidcategoryidsubscriberIdsubscriberIdtradeNametradeNamecheckListNamecheckListNamecategoryNamecategoryNamelocationIdlocationIdstoreIdstoreIdproviderIdproviderIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CheckListsApi(config);
            var tradeid = 56;  // int? | Trade ID. To get a list of trades with their IDs, send the [GET /odata/trades](https://developer.servicechannel.com/swagger/ui/index?version=3#/Trades/Trades_GetTrades) request. (optional) 
            var checklistid = 56;  // int? | Checklist ID. (optional) 
            var categoryid = 56;  // int? | Category ID. Subscribers can retrieve category IDs using the [GET /categories](https://developer.servicechannel.com/swagger/ui/index?version=3#/Categories/GETv3_categories_subscriberIds_0___subscriberIds_0___subscriberIds_1___subscriberIds_1__) method. (optional) 
            var subscriberId = 56;  // int? | Unique ID of the subscriber who configured checklists. Should be passed by providers. (optional) 
            var tradeName = "tradeName_example";  // string? | Trade name. A trade is an area of work for which a service is performed, such as _Lighting_, _Refrigeration_, or _Plumbing_. (optional) 
            var checkListName = "checkListName_example";  // string? | Checklist name. (optional) 
            var categoryName = "categoryName_example";  // string? | Category name. A category is the overall classification of a work order, such as _Maintenance_, _Repair_, or _CAPEX_. (optional) 
            var locationId = 56;  // int? | Unique ID of a subscriber’s location. This parameter is ignored if the feature that allows creating checklists for specific locations is disabled for a subscriber. (optional) 
            var storeId = "storeId_example";  // string? | Non-unique ID of a subscriber’s location that may appear as a store number. This parameter is ignored if the feature that allows creating checklists for specific locations is disabled for a subscriber. (optional) 
            var providerId = 56;  // int? | The provider identifier. Required for sub-contractor request. [Required Special permissions] (optional) 

            try
            {
                // Get checklists with asset tasks
                SCServiceChannelServicesMessagingChecklistTasksCheckListWithTasksExtendedResponse result = apiInstance.ChecklistsTaskslisttradeidtradeidchecklistidchecklistidcategoryidcategoryidsubscriberIdsubscriberIdtradeNametradeNamecheckListNamecheckListNamecategoryNamecategoryNamelocationIdlocationIdstoreIdstoreIdproviderIdproviderId(tradeid, checklistid, categoryid, subscriberId, tradeName, checkListName, categoryName, locationId, storeId, providerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CheckListsApi.ChecklistsTaskslisttradeidtradeidchecklistidchecklistidcategoryidcategoryidsubscriberIdsubscriberIdtradeNametradeNamecheckListNamecheckListNamecategoryNamecategoryNamelocationIdlocationIdstoreIdstoreIdproviderIdproviderId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChecklistsTaskslisttradeidtradeidchecklistidchecklistidcategoryidcategoryidsubscriberIdsubscriberIdtradeNametradeNamecheckListNamecheckListNamecategoryNamecategoryNamelocationIdlocationIdstoreIdstoreIdproviderIdproviderIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get checklists with asset tasks
    ApiResponse<SCServiceChannelServicesMessagingChecklistTasksCheckListWithTasksExtendedResponse> response = apiInstance.ChecklistsTaskslisttradeidtradeidchecklistidchecklistidcategoryidcategoryidsubscriberIdsubscriberIdtradeNametradeNamecheckListNamecheckListNamecategoryNamecategoryNamelocationIdlocationIdstoreIdstoreIdproviderIdproviderIdWithHttpInfo(tradeid, checklistid, categoryid, subscriberId, tradeName, checkListName, categoryName, locationId, storeId, providerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CheckListsApi.ChecklistsTaskslisttradeidtradeidchecklistidchecklistidcategoryidcategoryidsubscriberIdsubscriberIdtradeNametradeNamecheckListNamecheckListNamecategoryNamecategoryNamelocationIdlocationIdstoreIdstoreIdproviderIdproviderIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tradeid** | **int?** | Trade ID. To get a list of trades with their IDs, send the [GET /odata/trades](https://developer.servicechannel.com/swagger/ui/index?version&#x3D;3#/Trades/Trades_GetTrades) request. | [optional]  |
| **checklistid** | **int?** | Checklist ID. | [optional]  |
| **categoryid** | **int?** | Category ID. Subscribers can retrieve category IDs using the [GET /categories](https://developer.servicechannel.com/swagger/ui/index?version&#x3D;3#/Categories/GETv3_categories_subscriberIds_0___subscriberIds_0___subscriberIds_1___subscriberIds_1__) method. | [optional]  |
| **subscriberId** | **int?** | Unique ID of the subscriber who configured checklists. Should be passed by providers. | [optional]  |
| **tradeName** | **string?** | Trade name. A trade is an area of work for which a service is performed, such as _Lighting_, _Refrigeration_, or _Plumbing_. | [optional]  |
| **checkListName** | **string?** | Checklist name. | [optional]  |
| **categoryName** | **string?** | Category name. A category is the overall classification of a work order, such as _Maintenance_, _Repair_, or _CAPEX_. | [optional]  |
| **locationId** | **int?** | Unique ID of a subscriber’s location. This parameter is ignored if the feature that allows creating checklists for specific locations is disabled for a subscriber. | [optional]  |
| **storeId** | **string?** | Non-unique ID of a subscriber’s location that may appear as a store number. This parameter is ignored if the feature that allows creating checklists for specific locations is disabled for a subscriber. | [optional]  |
| **providerId** | **int?** | The provider identifier. Required for sub-contractor request. [Required Special permissions] | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingChecklistTasksCheckListWithTasksExtendedResponse**](SCServiceChannelServicesMessagingChecklistTasksCheckListWithTasksExtendedResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested asset task checklists are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              503 — Bad Request; Subscriber Id should be provided if the api method is called by provider              503 — A trade can be specified with only one parameter: either tradeId or tradeName              503 — A category can be specified with only one parameter: either categoryId or categoryName              503 — A checkList can be specified with only one parameter: either checkListId or checkListName              503 — A location can be specified with only one parameter: either locationId or storeId |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="checkliststypestradeidtradeidchecklistidchecklistidcategoryidcategoryidsubscriberidsubscriberidtradenametradenamechecklistnamechecklistnamecategorynamecategorynamelocationidlocationidstoreidstoreidprovideridproviderid"></a>
# **ChecklistsTypestradeIdtradeIdchecklistIdchecklistIdcategoryIdcategoryIdsubscriberIdsubscriberIdtradeNametradeNamechecklistNamechecklistNamecategoryNamecategoryNamelocationIdlocationIdstoreIdstoreIdproviderIdproviderId**
> SCServiceChannelServicesMessagingChecklistsCheckListTypesExtendedResponse ChecklistsTypestradeIdtradeIdchecklistIdchecklistIdcategoryIdcategoryIdsubscriberIdsubscriberIdtradeNametradeNamechecklistNamechecklistNamecategoryNamecategoryNamelocationIdlocationIdstoreIdstoreIdproviderIdproviderId (int? tradeId = null, int? checklistId = null, int? categoryId = null, int? subscriberId = null, string? tradeName = null, string? checklistName = null, string? categoryName = null, int? locationId = null, string? storeId = null, int? providerId = null)

Retrieve checklist types

Returns the ID and type of checklists.              <br />Subscribers can create two types of checklists:               • **Standard checklist** with questions that a technician is prompted to answer when working on a service request. Send the [GET /checklists/detail](https://developer.servicechannel.com/swagger/ui/index?version=3#/CheckLists/GETv3_checklists_detail_tradeid__tradeid__checklistid__checklistid__categoryid__categoryid__subscriberId__subscriberId__tradeName__tradeName__checkListName__checkListName__categoryName__categoryName__locationId__locationId__storeId__storeId_) request to retrieve standard checklists.               • **Asset task checklist** with asset-related tasks that a technician should complete when servicing a work order. Pass [GET /checklists/taskslist](https://developer.servicechannel.com/swagger/ui/index?version=3#/CheckLists/GETv3_checklists_taskslist_tradeid__tradeid__checklistid__checklistid__categoryid__categoryid__subscriberId__subscriberId__tradeName__tradeName__checkListName__checkListName__categoryName__categoryName__locationId__locationId__storeId__storeId_) to get asset task checklists.              <br />You can filter checklists by:               • **Trade**. Specify either `tradeid` or `tradeName`.               • **Category**. Enter either `categoryid` or `categoryName`.               • **Location**. Provide either `locationId` or `storeId` if the feature that allows creating checklists for specific locations is enabled for a subscriber.               • **Checklist**. Pass either `checklistid` or `checkListName` to get a specific checklist, and ignore other parameters.              <br />Providers should pass `subscriberId` to retrieve checklists created by the desired subscriber.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ChecklistsTypestradeIdtradeIdchecklistIdchecklistIdcategoryIdcategoryIdsubscriberIdsubscriberIdtradeNametradeNamechecklistNamechecklistNamecategoryNamecategoryNamelocationIdlocationIdstoreIdstoreIdproviderIdproviderIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CheckListsApi(config);
            var tradeId = 56;  // int? | Trade ID. To get a list of trades with their IDs, send the [GET /odata/trades](https://developer.servicechannel.com/swagger/ui/index?version=3#/Trades/Trades_GetTrades) request. (optional) 
            var checklistId = 56;  // int? | Checklist ID. (optional) 
            var categoryId = 56;  // int? | Category ID. Subscribers can retrieve category IDs using the [GET /categories](https://developer.servicechannel.com/swagger/ui/index?version=3#/Categories/GETv3_categories_subscriberIds_0___subscriberIds_0___subscriberIds_1___subscriberIds_1__) method. (optional) 
            var subscriberId = 56;  // int? | Unique ID of the subscriber who configured checklists. Should be passed by providers. (optional) 
            var tradeName = "tradeName_example";  // string? | Trade name. A trade is an area of work for which a service is performed, such as _Lighting_, _Refrigeration_, or _Plumbing_. (optional) 
            var checklistName = "checklistName_example";  // string? | Checklist name. (optional) 
            var categoryName = "categoryName_example";  // string? | Category name. A category is the overall classification of a work order, such as _Maintenance_, _Repair_, or _CAPEX_. (optional) 
            var locationId = 56;  // int? | Unique ID of a subscriber’s location. This parameter is ignored if the feature that allows creating checklists for specific locations is disabled for a subscriber. (optional) 
            var storeId = "storeId_example";  // string? | Non-unique ID of a subscriber’s location that may appear as a store number. This parameter is ignored if the feature that allows creating checklists for specific locations is disabled for a subscriber. (optional) 
            var providerId = 56;  // int? | The provider identifier. Required for sub-contractor request. [Required Special permissions] (optional) 

            try
            {
                // Retrieve checklist types
                SCServiceChannelServicesMessagingChecklistsCheckListTypesExtendedResponse result = apiInstance.ChecklistsTypestradeIdtradeIdchecklistIdchecklistIdcategoryIdcategoryIdsubscriberIdsubscriberIdtradeNametradeNamechecklistNamechecklistNamecategoryNamecategoryNamelocationIdlocationIdstoreIdstoreIdproviderIdproviderId(tradeId, checklistId, categoryId, subscriberId, tradeName, checklistName, categoryName, locationId, storeId, providerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CheckListsApi.ChecklistsTypestradeIdtradeIdchecklistIdchecklistIdcategoryIdcategoryIdsubscriberIdsubscriberIdtradeNametradeNamechecklistNamechecklistNamecategoryNamecategoryNamelocationIdlocationIdstoreIdstoreIdproviderIdproviderId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChecklistsTypestradeIdtradeIdchecklistIdchecklistIdcategoryIdcategoryIdsubscriberIdsubscriberIdtradeNametradeNamechecklistNamechecklistNamecategoryNamecategoryNamelocationIdlocationIdstoreIdstoreIdproviderIdproviderIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve checklist types
    ApiResponse<SCServiceChannelServicesMessagingChecklistsCheckListTypesExtendedResponse> response = apiInstance.ChecklistsTypestradeIdtradeIdchecklistIdchecklistIdcategoryIdcategoryIdsubscriberIdsubscriberIdtradeNametradeNamechecklistNamechecklistNamecategoryNamecategoryNamelocationIdlocationIdstoreIdstoreIdproviderIdproviderIdWithHttpInfo(tradeId, checklistId, categoryId, subscriberId, tradeName, checklistName, categoryName, locationId, storeId, providerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CheckListsApi.ChecklistsTypestradeIdtradeIdchecklistIdchecklistIdcategoryIdcategoryIdsubscriberIdsubscriberIdtradeNametradeNamechecklistNamechecklistNamecategoryNamecategoryNamelocationIdlocationIdstoreIdstoreIdproviderIdproviderIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tradeId** | **int?** | Trade ID. To get a list of trades with their IDs, send the [GET /odata/trades](https://developer.servicechannel.com/swagger/ui/index?version&#x3D;3#/Trades/Trades_GetTrades) request. | [optional]  |
| **checklistId** | **int?** | Checklist ID. | [optional]  |
| **categoryId** | **int?** | Category ID. Subscribers can retrieve category IDs using the [GET /categories](https://developer.servicechannel.com/swagger/ui/index?version&#x3D;3#/Categories/GETv3_categories_subscriberIds_0___subscriberIds_0___subscriberIds_1___subscriberIds_1__) method. | [optional]  |
| **subscriberId** | **int?** | Unique ID of the subscriber who configured checklists. Should be passed by providers. | [optional]  |
| **tradeName** | **string?** | Trade name. A trade is an area of work for which a service is performed, such as _Lighting_, _Refrigeration_, or _Plumbing_. | [optional]  |
| **checklistName** | **string?** | Checklist name. | [optional]  |
| **categoryName** | **string?** | Category name. A category is the overall classification of a work order, such as _Maintenance_, _Repair_, or _CAPEX_. | [optional]  |
| **locationId** | **int?** | Unique ID of a subscriber’s location. This parameter is ignored if the feature that allows creating checklists for specific locations is disabled for a subscriber. | [optional]  |
| **storeId** | **string?** | Non-unique ID of a subscriber’s location that may appear as a store number. This parameter is ignored if the feature that allows creating checklists for specific locations is disabled for a subscriber. | [optional]  |
| **providerId** | **int?** | The provider identifier. Required for sub-contractor request. [Required Special permissions] | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingChecklistsCheckListTypesExtendedResponse**](SCServiceChannelServicesMessagingChecklistsCheckListTypesExtendedResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The ID and type of the requested checklists are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              503 — Bad Request; Subscriber Id should be provided if the api method is called by provider              503 — A trade can be specified with only one parameter: either tradeId or tradeName              503 — A category can be specified with only one parameter: either categoryId or categoryName              503 — A checkList can be specified with only one parameter: either checkListId or checkListName              503 — A location can be specified with only one parameter: either locationId or storeId |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="checklistschecklistresponseidchecklistresponse"></a>
# **ChecklistscheckListResponseIdCheckListResponse**
> SCServiceChannelServicesMessagingCheckListDetailsCheckListResponsesResponsePicture ChecklistscheckListResponseIdCheckListResponse (int checkListResponseId, Object? checkListResponsePictureId = null, Object? checkListResponseRequest = null, System.IO.Stream? file = null)

Update a response to a checklist question

[Updates the specified response](https://developer.servicechannel.com/guides/checklists/update-a-checklist-response/) to a checklist question.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ChecklistscheckListResponseIdCheckListResponseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CheckListsApi(config);
            var checkListResponseId = 56;  // int | ID of the response to a checklist question to update.              Pass the [GET /workorders/{workOrderId}/checklists-responses](https://developer.servicechannel.com/swagger/ui/index?version=3#/WorkOrders/GETv3_workorders__workOrderId__checklists_responses) request to retrieve the response ID.
            var checkListResponsePictureId = new Object?(); // Object? | ID of the file attached to the checklist response to update.              Send the [GET /workorders/{workOrderId}/checklists-responses](https://developer.servicechannel.com/swagger/ui/index?version=3#/WorkOrders/GETv3_workorders__workOrderId__checklists_responses) request, and look for the required file `Id` within `Pictures` in the response. (optional) 
            var checkListResponseRequest = new Object?(); // Object? | Request to update a response to a checklist question.              <br />Pass the following parameters in the request:               • **CheckListQuestionId** *(Required)*: ID of the checklist question to update a response for.               • **CheckListQuestionOptionId**: ID of the answer option configured for a checklist question of the **Selector** type.               • **ProviderId** *(Required)*: ID of the provider on whose behalf you are updating a response.               • **TechnicianID** *(Required)*: ID of the technician on whose behalf you are updating a response.               • **Answer**: Answer to a checklist question of the following types:                ◦ **Acknowledgement**. Valid values: `on`, `off`, `1`, `0`, `true`, `false`, `yes`, `no`.                ◦ **Text Entry**. Enter a text answer. The maximum length is 500 characters.                ◦ **Numeric Input**. Submit a number.               • **FreeTextAnswer**: Comment to an answer option with the `IsConditionalFollowUp` attribute. Answer options are configured for questions of the **Selector** type.               • **EntityId** *(Required)*: Unique ID of the work order for which you are updating a response to a checklist question.               • **Attempt** *(Required)*: Order of a technician’s on-site visit to update a checklist response for.              <br />**Example Object for the Acknowledgement Question**                                {                    \\\"CheckListQuestionID\\\": 3834,                    \\\"ProviderID\\\": 2000090505,                    \\\"TechnicianID\\\": 270592,                    \\\"Answer\\\": \\\"off\\\",                    \\\"EntityID\\\": 179826000,                    \\\"Attempt\\\": 1                  } (optional) 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream? | File to attach to the response to a checklist question. Required for questions with the `PictureFlag` parameter set to 2. (optional) 

            try
            {
                // Update a response to a checklist question
                SCServiceChannelServicesMessagingCheckListDetailsCheckListResponsesResponsePicture result = apiInstance.ChecklistscheckListResponseIdCheckListResponse(checkListResponseId, checkListResponsePictureId, checkListResponseRequest, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CheckListsApi.ChecklistscheckListResponseIdCheckListResponse: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChecklistscheckListResponseIdCheckListResponseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a response to a checklist question
    ApiResponse<SCServiceChannelServicesMessagingCheckListDetailsCheckListResponsesResponsePicture> response = apiInstance.ChecklistscheckListResponseIdCheckListResponseWithHttpInfo(checkListResponseId, checkListResponsePictureId, checkListResponseRequest, file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CheckListsApi.ChecklistscheckListResponseIdCheckListResponseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **checkListResponseId** | **int** | ID of the response to a checklist question to update.              Pass the [GET /workorders/{workOrderId}/checklists-responses](https://developer.servicechannel.com/swagger/ui/index?version&#x3D;3#/WorkOrders/GETv3_workorders__workOrderId__checklists_responses) request to retrieve the response ID. |  |
| **checkListResponsePictureId** | [**Object?**](Object?.md) | ID of the file attached to the checklist response to update.              Send the [GET /workorders/{workOrderId}/checklists-responses](https://developer.servicechannel.com/swagger/ui/index?version&#x3D;3#/WorkOrders/GETv3_workorders__workOrderId__checklists_responses) request, and look for the required file &#x60;Id&#x60; within &#x60;Pictures&#x60; in the response. | [optional]  |
| **checkListResponseRequest** | [**Object?**](Object?.md) | Request to update a response to a checklist question.              &lt;br /&gt;Pass the following parameters in the request:               • **CheckListQuestionId** *(Required)*: ID of the checklist question to update a response for.               • **CheckListQuestionOptionId**: ID of the answer option configured for a checklist question of the **Selector** type.               • **ProviderId** *(Required)*: ID of the provider on whose behalf you are updating a response.               • **TechnicianID** *(Required)*: ID of the technician on whose behalf you are updating a response.               • **Answer**: Answer to a checklist question of the following types:                ◦ **Acknowledgement**. Valid values: &#x60;on&#x60;, &#x60;off&#x60;, &#x60;1&#x60;, &#x60;0&#x60;, &#x60;true&#x60;, &#x60;false&#x60;, &#x60;yes&#x60;, &#x60;no&#x60;.                ◦ **Text Entry**. Enter a text answer. The maximum length is 500 characters.                ◦ **Numeric Input**. Submit a number.               • **FreeTextAnswer**: Comment to an answer option with the &#x60;IsConditionalFollowUp&#x60; attribute. Answer options are configured for questions of the **Selector** type.               • **EntityId** *(Required)*: Unique ID of the work order for which you are updating a response to a checklist question.               • **Attempt** *(Required)*: Order of a technician’s on-site visit to update a checklist response for.              &lt;br /&gt;**Example Object for the Acknowledgement Question**                                {                    \\\&quot;CheckListQuestionID\\\&quot;: 3834,                    \\\&quot;ProviderID\\\&quot;: 2000090505,                    \\\&quot;TechnicianID\\\&quot;: 270592,                    \\\&quot;Answer\\\&quot;: \\\&quot;off\\\&quot;,                    \\\&quot;EntityID\\\&quot;: 179826000,                    \\\&quot;Attempt\\\&quot;: 1                  } | [optional]  |
| **file** | **System.IO.Stream?****System.IO.Stream?** | File to attach to the response to a checklist question. Required for questions with the &#x60;PictureFlag&#x60; parameter set to 2. | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingCheckListDetailsCheckListResponsesResponsePicture**](SCServiceChannelServicesMessagingCheckListDetailsCheckListResponsesResponsePicture.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The specified response to a checklist question is updated. A checklist response object and an attachment object are returned. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              502 — Work order is not found              503 — Bad request              503 — Not all required parameters were specified              503 — The FreeTextAnswer is required              503 — The picture is required              503 — Checkbox responses only support next values: on, off, 1, 0, true, false, yes, no              503 — CheckListResponsePictureId (#) is not valid for CheckListResponse |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

