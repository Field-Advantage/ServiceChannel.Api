# ServiceChannel.Api.Api.WorkOrdersApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CheckInActivity**](WorkOrdersApi.md#checkinactivity) | **GET** /odata/workorders({workorderId})/Service.CheckInActivity() | Retrieve a Work Order CheckIn Activity |
| [**Get**](WorkOrdersApi.md#get) | **GET** /odata/workorders({workorderId}) | Retrieve a Work Orders |
| [**GetDuplicateWorkOrders**](WorkOrdersApi.md#getduplicateworkorders) | **GET** /odata/locations({locationId})/workorders/Service.GetDuplicates() | Retrieve a Duplicate Work Orders |
| [**GetRecallWorkOrders**](WorkOrdersApi.md#getrecallworkorders) | **GET** /odata/locations({locationId})/workorders/Service.GetRecalls() | Retrieve Work Order Recalls |
| [**GetWorkOrders**](WorkOrdersApi.md#getworkorders) | **GET** /odata/workorders | Retrieve work orders |
| [**GetWorkOrdersForLocation**](WorkOrdersApi.md#getworkordersforlocation) | **GET** /odata/locations({locationId})/workorders | Retrieve a Work Orders |
| [**GetWorkOrdersNearBy**](WorkOrdersApi.md#getworkordersnearby) | **GET** /odata/workorders/Service.NearBy(latitude&#x3D;{latitude},longitude&#x3D;{longitude}) | Retrieve a Work Orders near by a site. |
| [**LocationsLocationIdWarningworkordersProblemCodeProblemCodeEquipmentEquipmentProblemTypeProblemTypeTradeTradeCompletedCompletedSubscriberIdSubscriberId**](WorkOrdersApi.md#locationslocationidwarningworkordersproblemcodeproblemcodeequipmentequipmentproblemtypeproblemtypetradetradecompletedcompletedsubscriberidsubscriberid) | **GET** /locations/{LocationId}/warningworkorders | Retrieve a Warning Work Orders for Location |
| [**LocationslocationIdWorkordersPriorities**](WorkOrdersApi.md#locationslocationidworkorderspriorities) | **GET** /locations/{locationId}/workorders/priorities |  |
| [**LocationslocationIdWorkordersstoreIdstoreId**](WorkOrdersApi.md#locationslocationidworkordersstoreidstoreid) | **GET** /locations/{locationId}/workorders | Search Work Orders for specified location |
| [**OdataWorkordersFilter**](WorkOrdersApi.md#odataworkordersfilter) | **POST** /odata/workorders/filter | Retrieve work orders |
| [**SubscriberssubscriberIdWorkordersworkorderIdReassign**](WorkOrdersApi.md#subscriberssubscriberidworkordersworkorderidreassign) | **PUT** /subscribers/{subscriberId}/workorders/{workorderId}/reassign |  |
| [**Workorders**](WorkOrdersApi.md#workorders) | **POST** /workorders | Create a Work order |
| [**WorkordersCategoriesSubscriberIdSubscriberIdSortExprSortExpr**](WorkOrdersApi.md#workorderscategoriessubscriberidsubscriberidsortexprsortexpr) | **GET** /workorders/categories | Categories Collection |
| [**WorkordersFeedbackListworkOrdersIds0workOrdersIds0workOrdersIds1workOrdersIds1**](WorkOrdersApi.md#workordersfeedbacklistworkordersids0workordersids0workordersids1workordersids1) | **GET** /workorders/feedback/list | Get work orders feedbacks |
| [**WorkordersHandlewocompletionforsurvey**](WorkOrdersApi.md#workordershandlewocompletionforsurvey) | **POST** /workorders/handlewocompletionforsurvey | Add Empty Survey for Work Order Completion |
| [**WorkordersIsTechnicianCertificateUsedOnWorkOrderscertificateIdcertificateId**](WorkOrdersApi.md#workordersistechniciancertificateusedonworkorderscertificateidcertificateid) | **GET** /workorders/isTechnicianCertificateUsedOnWorkOrders | Verify if refrigerant certificat is associated with WOs |
| [**WorkordersLabelkeywordkeywordpagepagepageSizepageSize**](WorkOrdersApi.md#workorderslabelkeywordkeywordpagepagepagesizepagesize) | **GET** /workorders/label | Get work orders labels. |
| [**WorkordersPriorities**](WorkOrdersApi.md#workorderspriorities) | **POST** /workorders/priorities | Create Priority |
| [**WorkordersPrioritiessubscriberIdsubscriberId**](WorkOrdersApi.md#workordersprioritiessubscriberidsubscriberid) | **GET** /workorders/priorities | Priorities Collection |
| [**WorkordersProviderforreassignmentworkorderIdworkorderIdproviderIdproviderIdlocationIdlocationIdtradetrade**](WorkOrdersApi.md#workordersproviderforreassignmentworkorderidworkorderidprovideridprovideridlocationidlocationidtradetrade) | **GET** /workorders/providerforreassignment | Retrieve a Provider |
| [**WorkordersReassignReasonssubscriberIdsubscriberId**](WorkOrdersApi.md#workordersreassignreasonssubscriberidsubscriberid) | **GET** /workorders/reassign/reasons | Work order reassignment reasons |
| [**WorkordersSolvedissue**](WorkOrdersApi.md#workorderssolvedissue) | **POST** /workorders/solvedissue | Submit solved issue during troubleshooting |
| [**WorkordersStarred**](WorkOrdersApi.md#workordersstarred) | **GET** /workorders/starred | Starred Work Order Ids Collection |
| [**WorkordersStatisticsdaysPerioddaysPeriod**](WorkOrdersApi.md#workordersstatisticsdaysperioddaysperiod) | **GET** /workorders/statistics | Statistics Collection |
| [**WorkordersStatusessubscriberIdsubscriberIdtradeIdtradeId**](WorkOrdersApi.md#workordersstatusessubscriberidsubscriberidtradeidtradeid) | **GET** /workorders/statuses | Statuses Collection |
| [**WorkorderslocationIdlocationIdstoreIdstoreId**](WorkOrdersApi.md#workorderslocationidlocationidstoreidstoreid) | **GET** /workorders | Search Work Orders |
| [**WorkordersworkOrderIdAccept**](WorkOrdersApi.md#workordersworkorderidaccept) | **PUT** /workorders/{workOrderId}/accept | Accept a work order |
| [**WorkordersworkOrderIdAnalytics**](WorkOrdersApi.md#workordersworkorderidanalytics) | **GET** /workorders/{workOrderId}/analytics | Get analytics on a work order |
| [**WorkordersworkOrderIdChecklistsResponsesgetAllgetAll**](WorkOrdersApi.md#workordersworkorderidchecklistsresponsesgetallgetall) | **GET** /workorders/{workOrderId}/checklists-responses | Get checklist responses for a work order |
| [**WorkordersworkOrderIdDecline**](WorkOrdersApi.md#workordersworkorderiddecline) | **PUT** /workorders/{workOrderId}/decline | Decline a work order |
| [**WorkordersworkOrderIdLeakWasDetected**](WorkOrdersApi.md#workordersworkorderidleakwasdetected) | **GET** /workorders/{workOrderId}/leakWasDetected | Retrieve the leak detection result in a Work Order |
| [**WorkordersworkOrderIdProjectApproval**](WorkOrdersApi.md#workordersworkorderidprojectapproval) | **PUT** /workorders/{workOrderId}/projectApproval | Update Work orders NTE project approval |
| [**WorkordersworkOrderIdProjectApproval_0**](WorkOrdersApi.md#workordersworkorderidprojectapproval_0) | **POST** /workorders/{workOrderId}/projectApproval | Create Work orders project approval |
| [**WorkordersworkOrderIdTechnicianCertificate**](WorkOrdersApi.md#workordersworkorderidtechniciancertificate) | **PUT** /workorders/{workOrderId}/technicianCertificate | Assign technician certificate to the WO |
| [**WorkordersworkOrderIdUpdateWorkOrderLeakInspectionInforefrigerantWasUsedrefrigerantWasUsedleakWasDetectedleakWasDetected**](WorkOrdersApi.md#workordersworkorderidupdateworkorderleakinspectioninforefrigerantwasusedrefrigerantwasusedleakwasdetectedleakwasdetected) | **PUT** /workorders/{workOrderId}/UpdateWorkOrderLeakInspectionInfo | Update the leak inspection info on a work order |
| [**WorkordersworkOrderIdWeatherEventsubscriberIdsubscriberId**](WorkOrdersApi.md#workordersworkorderidweathereventsubscriberidsubscriberid) | **GET** /workorders/{workOrderId}/weatherEvent | Get the Weather Event associated to a work order (if set) |
| [**WorkordersworkorderId**](WorkOrdersApi.md#workordersworkorderid) | **GET** /workorders/{workorderId} | Retrieve a Work order |
| [**WorkordersworkorderIdAddstripecharge**](WorkOrdersApi.md#workordersworkorderidaddstripecharge) | **POST** /workorders/{workorderId}/addstripecharge | Create Stripe charge |
| [**WorkordersworkorderIdCaller**](WorkOrdersApi.md#workordersworkorderidcaller) | **PUT** /workorders/{workorderId}/caller | Update Work order Caller |
| [**WorkordersworkorderIdCategory**](WorkOrdersApi.md#workordersworkorderidcategory) | **PUT** /workorders/{workorderId}/category | Update the work order category |
| [**WorkordersworkorderIdDescription**](WorkOrdersApi.md#workordersworkorderiddescription) | **PUT** /workorders/{workorderId}/description | Update Work order Description |
| [**WorkordersworkorderIdFeaturesfeatures0features0features1features1**](WorkOrdersApi.md#workordersworkorderidfeaturesfeatures0features0features1features1) | **GET** /workorders/{workorderId}/features | Checks features of Work order subscriber |
| [**WorkordersworkorderIdFeedback**](WorkOrdersApi.md#workordersworkorderidfeedback) | **POST** /workorders/{workorderId}/feedback | Leave feedback for a work order |
| [**WorkordersworkorderIdFollowers**](WorkOrdersApi.md#workordersworkorderidfollowers) | **POST** /workorders/{workorderId}/followers | Add Followers to Work order |
| [**WorkordersworkorderIdFollowersemailemail**](WorkOrdersApi.md#workordersworkorderidfollowersemailemail) | **DELETE** /workorders/{workorderId}/followers | Remove Follower from Work order |
| [**WorkordersworkorderIdGPSRadius**](WorkOrdersApi.md#workordersworkorderidgpsradius) | **GET** /workorders/{workorderId}/GPSRadius | Get GPS Radius for a WO |
| [**WorkordersworkorderIdIssueChoicesubscriberIdsubscriberIdlocationIdlocationId**](WorkOrdersApi.md#workordersworkorderidissuechoicesubscriberidsubscriberidlocationidlocationid) | **PUT** /workorders/{workorderId}/issueChoice | Update issue choice on WO |
| [**WorkordersworkorderIdLabel**](WorkOrdersApi.md#workordersworkorderidlabel) | **PUT** /workorders/{workorderId}/label | Update work order label |
| [**WorkordersworkorderIdLabel_0**](WorkOrdersApi.md#workordersworkorderidlabel_0) | **DELETE** /workorders/{workorderId}/label | Delete work order label |
| [**WorkordersworkorderIdLinkworkorderIdToLinkworkorderIdToLink**](WorkOrdersApi.md#workordersworkorderidlinkworkorderidtolinkworkorderidtolink) | **PUT** /workorders/{workorderId}/link | Creates link between two Work Orders |
| [**WorkordersworkorderIdMarkRefrigerantUserefrigerantWasUsedrefrigerantWasUsedactoractor**](WorkOrdersApi.md#workordersworkorderidmarkrefrigerantuserefrigerantwasusedrefrigerantwasusedactoractor) | **PUT** /workorders/{workorderId}/markRefrigerantUse | Update the status of refrigerant use on a work order |
| [**WorkordersworkorderIdNte**](WorkOrdersApi.md#workordersworkorderidnte) | **PUT** /workorders/{workorderId}/nte | Update Work order NTE |
| [**WorkordersworkorderIdPonumber**](WorkOrdersApi.md#workordersworkorderidponumber) | **PUT** /workorders/{workorderId}/ponumber | Update Work order Purchase Number |
| [**WorkordersworkorderIdPriority**](WorkOrdersApi.md#workordersworkorderidpriority) | **PUT** /workorders/{workorderId}/priority | Update Work order Priority |
| [**WorkordersworkorderIdProjectid**](WorkOrdersApi.md#workordersworkorderidprojectid) | **PUT** /workorders/{workorderId}/projectid | Update ProjectId |
| [**WorkordersworkorderIdProjectidUnlink**](WorkOrdersApi.md#workordersworkorderidprojectidunlink) | **PUT** /workorders/{workorderId}/projectid/unlink | Unlink ProjectId |
| [**WorkordersworkorderIdReassign**](WorkOrdersApi.md#workordersworkorderidreassign) | **PUT** /workorders/{workorderId}/reassign | Reassign Work Order |
| [**WorkordersworkorderIdRefrigerantUseStatus**](WorkOrdersApi.md#workordersworkorderidrefrigerantusestatus) | **GET** /workorders/{workorderId}/refrigerantUseStatus | Retrieve the status of refrigerant use on a work order |
| [**WorkordersworkorderIdResolution**](WorkOrdersApi.md#workordersworkorderidresolution) | **POST** /workorders/{workorderId}/resolution | Add Work order Resolution |
| [**WorkordersworkorderIdScheduledaterescheduleReasonCoderescheduleReasonCode**](WorkOrdersApi.md#workordersworkorderidscheduledatereschedulereasoncodereschedulereasoncode) | **PUT** /workorders/{workorderId}/scheduledate | Update Work order Scheduled Date |
| [**WorkordersworkorderIdServicenowid**](WorkOrdersApi.md#workordersworkorderidservicenowid) | **PUT** /workorders/{workorderId}/servicenowid | Update work order servicenowid |
| [**WorkordersworkorderIdSetMoeNumbermoeNumbermoeNumber**](WorkOrdersApi.md#workordersworkorderidsetmoenumbermoenumbermoenumber) | **PUT** /workorders/{workorderId}/SetMoeNumber | Mark if refrigerant was used |
| [**WorkordersworkorderIdStatus**](WorkOrdersApi.md#workordersworkorderidstatus) | **PUT** /workorders/{workorderId}/status | Update a Work order Status |
| [**WorkordersworkorderIdStatusessubscriberIdsubscriberIdtradeIdtradeId**](WorkOrdersApi.md#workordersworkorderidstatusessubscriberidsubscriberidtradeidtradeid) | **GET** /workorders/{workorderId}/statuses | Statuses Collection that relates to the state of work order |
| [**WorkordersworkorderIdTechniciansAssigned**](WorkOrdersApi.md#workordersworkorderidtechniciansassigned) | **GET** /workorders/{workorderId}/techniciansAssigned | Retrieve list of technicians assigned to the specified work order |
| [**WorkordersworkorderIdTrade**](WorkOrdersApi.md#workordersworkorderidtrade) | **PUT** /workorders/{workorderId}/trade | Change Work order Trade |
| [**WorkordersworkorderIdUniversalCheckIn**](WorkOrdersApi.md#workordersworkorderiduniversalcheckin) | **POST** /workorders/{workorderId}/universalCheckIn | Perform a check-in |
| [**WorkordersworkorderIdUniversalCheckOut**](WorkOrdersApi.md#workordersworkorderiduniversalcheckout) | **POST** /workorders/{workorderId}/universalCheckOut | Perform a check-out |
| [**WorkordersworkorderIdUnlinklinkedWorkorderIdlinkedWorkorderId**](WorkOrdersApi.md#workordersworkorderidunlinklinkedworkorderidlinkedworkorderid) | **PUT** /workorders/{workorderId}/unlink | Removes link between two Work Orders |
| [**WorkordersworkorderIdValidateCheckInWorkTypeIdWorkTypeIdLatitudeLatitudeLongitudeLongitude**](WorkOrdersApi.md#workordersworkorderidvalidatecheckinworktypeidworktypeidlatitudelatitudelongitudelongitude) | **GET** /workorders/{workorderId}/validateCheckIn | Validate Check-In action |
| [**WorkordersworkorderIdValidateCheckOutWorkTypeIdWorkTypeIdLatitudeLatitudeLongitudeLongitude**](WorkOrdersApi.md#workordersworkorderidvalidatecheckoutworktypeidworktypeidlatitudelatitudelongitudelongitude) | **GET** /workorders/{workorderId}/validateCheckOut | Validate Check-Out action |
| [**WorkordersworkorderIdWeatherTypeIdsubscriberIdsubscriberId**](WorkOrdersApi.md#workordersworkorderidweathertypeidsubscriberidsubscriberid) | **PUT** /workorders/{workorderId}/weatherTypeId | Update weather type |
| [**WorkordersworkorderIdWonumber**](WorkOrdersApi.md#workordersworkorderidwonumber) | **PUT** /workorders/{workorderId}/wonumber | Update Work order Number |
| [**WorktypessubscriberIdsubscriberId**](WorkOrdersApi.md#worktypessubscriberidsubscriberid) | **GET** /worktypes | Work types Collection |

<a id="checkinactivity"></a>
# **CheckInActivity**
> List&lt;SCServiceChannelServicesMessagingWorkordersCheckInIActivity&gt; CheckInActivity (int workorderId, string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Retrieve a Work Order CheckIn Activity

Retrieve a Work Order CheckIn Activity

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class CheckInActivityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | 
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Retrieve a Work Order CheckIn Activity
                List<SCServiceChannelServicesMessagingWorkordersCheckInIActivity> result = apiInstance.CheckInActivity(workorderId, expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.CheckInActivity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CheckInActivityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a Work Order CheckIn Activity
    ApiResponse<List<SCServiceChannelServicesMessagingWorkordersCheckInIActivity>> response = apiInstance.CheckInActivityWithHttpInfo(workorderId, expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.CheckInActivityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** |  |  |
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingWorkordersCheckInIActivity&gt;**](SCServiceChannelServicesMessagingWorkordersCheckInIActivity.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="get"></a>
# **Get**
> SCServiceChannelServicesMessagingWorkordersWorkOrder Get (int workorderId, string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Retrieve a Work Orders

Retrieve a Work Orders

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | 
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Retrieve a Work Orders
                SCServiceChannelServicesMessagingWorkordersWorkOrder result = apiInstance.Get(workorderId, expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a Work Orders
    ApiResponse<SCServiceChannelServicesMessagingWorkordersWorkOrder> response = apiInstance.GetWithHttpInfo(workorderId, expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** |  |  |
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingWorkordersWorkOrder**](SCServiceChannelServicesMessagingWorkordersWorkOrder.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getduplicateworkorders"></a>
# **GetDuplicateWorkOrders**
> List&lt;SCServiceChannelServicesMessagingWorkordersWorkOrder&gt; GetDuplicateWorkOrders (int locationId, string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Retrieve a Duplicate Work Orders

Retrieve a Duplicate Work Orders              <br />One page contains 50 items by default. To get next 50 items use the \"$skip\" parameter (for example $skip=50 and so on).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetDuplicateWorkOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var locationId = 56;  // int | Location identifier
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Retrieve a Duplicate Work Orders
                List<SCServiceChannelServicesMessagingWorkordersWorkOrder> result = apiInstance.GetDuplicateWorkOrders(locationId, expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.GetDuplicateWorkOrders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDuplicateWorkOrdersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a Duplicate Work Orders
    ApiResponse<List<SCServiceChannelServicesMessagingWorkordersWorkOrder>> response = apiInstance.GetDuplicateWorkOrdersWithHttpInfo(locationId, expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.GetDuplicateWorkOrdersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | Location identifier |  |
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingWorkordersWorkOrder&gt;**](SCServiceChannelServicesMessagingWorkordersWorkOrder.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrecallworkorders"></a>
# **GetRecallWorkOrders**
> List&lt;SCServiceChannelServicesMessagingWorkordersWorkOrder&gt; GetRecallWorkOrders (int locationId, string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Retrieve Work Order Recalls

Retrieve Work Order Recalls              <br />One page contains 50 items by default. To get next 50 items use the \"$skip\" parameter (for example $skip=50 and so on).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetRecallWorkOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var locationId = 56;  // int | Location identifier
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Retrieve Work Order Recalls
                List<SCServiceChannelServicesMessagingWorkordersWorkOrder> result = apiInstance.GetRecallWorkOrders(locationId, expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.GetRecallWorkOrders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRecallWorkOrdersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Work Order Recalls
    ApiResponse<List<SCServiceChannelServicesMessagingWorkordersWorkOrder>> response = apiInstance.GetRecallWorkOrdersWithHttpInfo(locationId, expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.GetRecallWorkOrdersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | Location identifier |  |
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingWorkordersWorkOrder&gt;**](SCServiceChannelServicesMessagingWorkordersWorkOrder.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getworkorders"></a>
# **GetWorkOrders**
> List&lt;SCServiceChannelServicesMessagingWorkordersWorkOrder&gt; GetWorkOrders (string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Retrieve work orders

Returns a list of work orders created within the last 90 days if not specified otherwise in `$filter`. The maximum date range between the work order `CallDate` and the current date is 365 days.               <br />The default number of work orders in the response is 50. To retrieve more work orders, use the `$skip` parameter.              <br />***Note***: You can also get a list of work orders by using one of the following methods: [GET /workorders](https://developer.servicechannel.com/swagger/ui/index?version=3#/WorkOrders/GETv3_workorders_locationId__locationId__storeId__storeId_), [POST /odata/workorders/filter](https://developer.servicechannel.com/swagger/ui/index?version=3#/WorkOrders/POSTv3_odata_workorders_filter).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetWorkOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Retrieve work orders
                List<SCServiceChannelServicesMessagingWorkordersWorkOrder> result = apiInstance.GetWorkOrders(expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.GetWorkOrders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkOrdersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve work orders
    ApiResponse<List<SCServiceChannelServicesMessagingWorkordersWorkOrder>> response = apiInstance.GetWorkOrdersWithHttpInfo(expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.GetWorkOrdersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingWorkordersWorkOrder&gt;**](SCServiceChannelServicesMessagingWorkordersWorkOrder.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of work orders is in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.&lt;br/&gt;&lt;br/&gt;The query specified in the URI is not valid. |  -  |
| **401** | The request is not authorized.&lt;br/&gt;&lt;br/&gt;Error codes:&lt;br/&gt;504 � API call rejected by security permissions |  -  |
| **502** | The server, while acting as a gateway or proxy, received an invalid response from the upstream server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getworkordersforlocation"></a>
# **GetWorkOrdersForLocation**
> List&lt;SCServiceChannelServicesMessagingWorkordersWorkOrder&gt; GetWorkOrdersForLocation (int locationId, string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Retrieve a Work Orders

Retrieve a Work Orders.              <br />One page contains 50 items by default. To get next 50 items use the \"$skip\" parameter (for example $skip=50 and so on).              <br />The filter expressions by defaul is \"$filter CallDate ge (Now+90 days)\".               <br />The maximum CallDate value is 365 days even if provided.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetWorkOrdersForLocationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
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
                // Retrieve a Work Orders
                List<SCServiceChannelServicesMessagingWorkordersWorkOrder> result = apiInstance.GetWorkOrdersForLocation(locationId, expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.GetWorkOrdersForLocation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkOrdersForLocationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a Work Orders
    ApiResponse<List<SCServiceChannelServicesMessagingWorkordersWorkOrder>> response = apiInstance.GetWorkOrdersForLocationWithHttpInfo(locationId, expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.GetWorkOrdersForLocationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** |  |  |
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingWorkordersWorkOrder&gt;**](SCServiceChannelServicesMessagingWorkordersWorkOrder.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getworkordersnearby"></a>
# **GetWorkOrdersNearBy**
> List&lt;SCServiceChannelServicesMessagingWorkordersWorkOrder&gt; GetWorkOrdersNearBy (double longitude, double latitude, string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Retrieve a Work Orders near by a site.

Retrieve a Work Orders near by a site orderred by Location distance (by default).               <br />One page contains 50 items by default. To get next 50 items use the \"$skip\" parameter (for example $skip=50 and so on).              <br />The filter expressions by defaul is \"$filter CallDate ge (Now+90 days)\".               <br />The maximum CallDate value is 365 days even if provided.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetWorkOrdersNearByExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var longitude = 1.2D;  // double | Longitude of a site
            var latitude = 1.2D;  // double | Latitude of a site
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Retrieve a Work Orders near by a site.
                List<SCServiceChannelServicesMessagingWorkordersWorkOrder> result = apiInstance.GetWorkOrdersNearBy(longitude, latitude, expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.GetWorkOrdersNearBy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkOrdersNearByWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a Work Orders near by a site.
    ApiResponse<List<SCServiceChannelServicesMessagingWorkordersWorkOrder>> response = apiInstance.GetWorkOrdersNearByWithHttpInfo(longitude, latitude, expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.GetWorkOrdersNearByWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **longitude** | **double** | Longitude of a site |  |
| **latitude** | **double** | Latitude of a site |  |
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingWorkordersWorkOrder&gt;**](SCServiceChannelServicesMessagingWorkordersWorkOrder.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="locationslocationidwarningworkordersproblemcodeproblemcodeequipmentequipmentproblemtypeproblemtypetradetradecompletedcompletedsubscriberidsubscriberid"></a>
# **LocationsLocationIdWarningworkordersProblemCodeProblemCodeEquipmentEquipmentProblemTypeProblemTypeTradeTradeCompletedCompletedSubscriberIdSubscriberId**
> List&lt;SCServiceChannelServicesMessagingWorkordersWorkOrder&gt; LocationsLocationIdWarningworkordersProblemCodeProblemCodeEquipmentEquipmentProblemTypeProblemTypeTradeTradeCompletedCompletedSubscriberIdSubscriberId (string locationId, int? locationId2 = null, string? problemCode = null, string? equipment = null, string? problemType = null, string? trade = null, bool? completed = null, int? subscriberId = null)

Retrieve a Warning Work Orders for Location

Retrieve a Warning Work Orders for Location              <br />One page contains 50 items by default (\"pageSize\"=50). To get next 50 items use the \"page\" parameter (for example page=2 and so on).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LocationsLocationIdWarningworkordersProblemCodeProblemCodeEquipmentEquipmentProblemTypeProblemTypeTradeTradeCompletedCompletedSubscriberIdSubscriberIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var locationId = "locationId_example";  // string | 
            var locationId2 = 56;  // int? |  (optional) 
            var problemCode = "problemCode_example";  // string? |  (optional) 
            var equipment = "equipment_example";  // string? |  (optional) 
            var problemType = "problemType_example";  // string? |  (optional) 
            var trade = "trade_example";  // string? |  (optional) 
            var completed = false;  // bool? |  (optional)  (default to false)
            var subscriberId = 56;  // int? |  (optional) 

            try
            {
                // Retrieve a Warning Work Orders for Location
                List<SCServiceChannelServicesMessagingWorkordersWorkOrder> result = apiInstance.LocationsLocationIdWarningworkordersProblemCodeProblemCodeEquipmentEquipmentProblemTypeProblemTypeTradeTradeCompletedCompletedSubscriberIdSubscriberId(locationId, locationId2, problemCode, equipment, problemType, trade, completed, subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.LocationsLocationIdWarningworkordersProblemCodeProblemCodeEquipmentEquipmentProblemTypeProblemTypeTradeTradeCompletedCompletedSubscriberIdSubscriberId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationsLocationIdWarningworkordersProblemCodeProblemCodeEquipmentEquipmentProblemTypeProblemTypeTradeTradeCompletedCompletedSubscriberIdSubscriberIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a Warning Work Orders for Location
    ApiResponse<List<SCServiceChannelServicesMessagingWorkordersWorkOrder>> response = apiInstance.LocationsLocationIdWarningworkordersProblemCodeProblemCodeEquipmentEquipmentProblemTypeProblemTypeTradeTradeCompletedCompletedSubscriberIdSubscriberIdWithHttpInfo(locationId, locationId2, problemCode, equipment, problemType, trade, completed, subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.LocationsLocationIdWarningworkordersProblemCodeProblemCodeEquipmentEquipmentProblemTypeProblemTypeTradeTradeCompletedCompletedSubscriberIdSubscriberIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **string** |  |  |
| **locationId2** | **int?** |  | [optional]  |
| **problemCode** | **string?** |  | [optional]  |
| **equipment** | **string?** |  | [optional]  |
| **problemType** | **string?** |  | [optional]  |
| **trade** | **string?** |  | [optional]  |
| **completed** | **bool?** |  | [optional] [default to false] |
| **subscriberId** | **int?** |  | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingWorkordersWorkOrder&gt;**](SCServiceChannelServicesMessagingWorkordersWorkOrder.md)

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

<a id="locationslocationidworkorderspriorities"></a>
# **LocationslocationIdWorkordersPriorities**
> List&lt;SCServiceChannelServicesMessagingPrioritiesPriorityResponse&gt; LocationslocationIdWorkordersPriorities (int locationId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LocationslocationIdWorkordersPrioritiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var locationId = 56;  // int | 

            try
            {
                List<SCServiceChannelServicesMessagingPrioritiesPriorityResponse> result = apiInstance.LocationslocationIdWorkordersPriorities(locationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.LocationslocationIdWorkordersPriorities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationslocationIdWorkordersPrioritiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<SCServiceChannelServicesMessagingPrioritiesPriorityResponse>> response = apiInstance.LocationslocationIdWorkordersPrioritiesWithHttpInfo(locationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.LocationslocationIdWorkordersPrioritiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** |  |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingPrioritiesPriorityResponse&gt;**](SCServiceChannelServicesMessagingPrioritiesPriorityResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 502 - Location not found;              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="locationslocationidworkordersstoreidstoreid"></a>
# **LocationslocationIdWorkordersstoreIdstoreId**
> List&lt;SCServiceChannelServicesMessagingWorkordersWorkOrder&gt; LocationslocationIdWorkordersstoreIdstoreId (int locationId, string? storeId = null, List<Object>? id = null, List<Object>? category = null, List<Object>? status = null, List<Object>? extendedStatus = null, List<Object>? number = null, List<Object>? serviceId = null, List<Object>? priority = null, List<Object>? purchaseNumber = null, List<Object>? trade = null, List<Object>? scheduledDate = null, List<Object>? expirationDate = null, List<Object>? callDate = null, string? sort = null, int? page = null, int? pageSize = null)

Search Work Orders for specified location

Performs search of workorders by specified filter expression and returns list of work orders with all details.              <br />One page contains 50 items by default (\"pageSize\"=50). To get next 50 items use the \"page\" parameter (for example page=2 and so on).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class LocationslocationIdWorkordersstoreIdstoreIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var locationId = 56;  // int | UID of location.
            var storeId = "storeId_example";  // string? | StoreId of location. Used to find location for which search will be performed. (optional) 
            var id = new List<Object>?(); // List<Object>? | UID of work order, exact search by default (optional) 
            var category = new List<Object>?(); // List<Object>? | Category of work order, exact search by default (optional) 
            var status = new List<Object>?(); // List<Object>? | Status of work order, exact search by default (optional) 
            var extendedStatus = new List<Object>?(); // List<Object>? | Extended status of work order, exact search by default (optional) 
            var number = new List<Object>?(); // List<Object>? | Work order number, 'starts with' search criteria by default (optional) 
            var serviceId = new List<Object>?(); // List<Object>? | 'starts with' search criteria by default (optional) 
            var priority = new List<Object>?(); // List<Object>? | Priority of work order, exact search by default (optional) 
            var purchaseNumber = new List<Object>?(); // List<Object>? | Purchase number of work order, 'starts with' search criteria by default (optional) 
            var trade = new List<Object>?(); // List<Object>? | Trade, 'starts with' search criteria by default (optional) 
            var scheduledDate = new List<Object>?(); // List<Object>? | Scheduled date (optional) 
            var expirationDate = new List<Object>?(); // List<Object>? | Expiration date (optional) 
            var callDate = new List<Object>?(); // List<Object>? | Call date (optional) 
            var sort = "sort_example";  // string? | Sort resources by the specified property in the response. (optional) 
            var page = 56;  // int? | Results page number. (optional) 
            var pageSize = 56;  // int? | Number of objects on the results page. The default and maximum per page is 50. (optional) 

            try
            {
                // Search Work Orders for specified location
                List<SCServiceChannelServicesMessagingWorkordersWorkOrder> result = apiInstance.LocationslocationIdWorkordersstoreIdstoreId(locationId, storeId, id, category, status, extendedStatus, number, serviceId, priority, purchaseNumber, trade, scheduledDate, expirationDate, callDate, sort, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.LocationslocationIdWorkordersstoreIdstoreId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationslocationIdWorkordersstoreIdstoreIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search Work Orders for specified location
    ApiResponse<List<SCServiceChannelServicesMessagingWorkordersWorkOrder>> response = apiInstance.LocationslocationIdWorkordersstoreIdstoreIdWithHttpInfo(locationId, storeId, id, category, status, extendedStatus, number, serviceId, priority, purchaseNumber, trade, scheduledDate, expirationDate, callDate, sort, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.LocationslocationIdWorkordersstoreIdstoreIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | UID of location. |  |
| **storeId** | **string?** | StoreId of location. Used to find location for which search will be performed. | [optional]  |
| **id** | [**List&lt;Object&gt;?**](Object.md) | UID of work order, exact search by default | [optional]  |
| **category** | [**List&lt;Object&gt;?**](Object.md) | Category of work order, exact search by default | [optional]  |
| **status** | [**List&lt;Object&gt;?**](Object.md) | Status of work order, exact search by default | [optional]  |
| **extendedStatus** | [**List&lt;Object&gt;?**](Object.md) | Extended status of work order, exact search by default | [optional]  |
| **number** | [**List&lt;Object&gt;?**](Object.md) | Work order number, &#39;starts with&#39; search criteria by default | [optional]  |
| **serviceId** | [**List&lt;Object&gt;?**](Object.md) | &#39;starts with&#39; search criteria by default | [optional]  |
| **priority** | [**List&lt;Object&gt;?**](Object.md) | Priority of work order, exact search by default | [optional]  |
| **purchaseNumber** | [**List&lt;Object&gt;?**](Object.md) | Purchase number of work order, &#39;starts with&#39; search criteria by default | [optional]  |
| **trade** | [**List&lt;Object&gt;?**](Object.md) | Trade, &#39;starts with&#39; search criteria by default | [optional]  |
| **scheduledDate** | [**List&lt;Object&gt;?**](Object.md) | Scheduled date | [optional]  |
| **expirationDate** | [**List&lt;Object&gt;?**](Object.md) | Expiration date | [optional]  |
| **callDate** | [**List&lt;Object&gt;?**](Object.md) | Call date | [optional]  |
| **sort** | **string?** | Sort resources by the specified property in the response. | [optional]  |
| **page** | **int?** | Results page number. | [optional]  |
| **pageSize** | **int?** | Number of objects on the results page. The default and maximum per page is 50. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingWorkordersWorkOrder&gt;**](SCServiceChannelServicesMessagingWorkordersWorkOrder.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 403 - Account has not been activated for GPS use;              &lt;br/&gt; 503 - Validation fails. Request is empty or null;              &lt;br/&gt; 601 - Location Id is invalid;              &lt;br/&gt; 606 - Cannot find location by StoreId;              &lt;br/&gt; 1000 - Invalid Setup Id; |  -  |
| **401** | Requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions;  |  -  |
| **500** | Indicates that a generic error has occurred on the server.              &lt;br/&gt;Error codes:              &lt;br/&gt; 501 - Timeout expired. The timeout period elapsed prior to completion of the operation or the server is not responding. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="odataworkordersfilter"></a>
# **OdataWorkordersFilter**
> List&lt;SCServiceChannelServicesMessagingWorkordersWorkOrder&gt; OdataWorkordersFilter (SCServiceChannelServicesMessagingODataRequest request)

Retrieve work orders

Returns a list of work orders created within the last 90 days if not specified otherwise in `$filter`. The maximum date range between the work order `CallDate` and the current date is 365 days.              <br />The default number of work orders in the response is 50. To retrieve more work orders, use the `$skip` parameter.              <br />***Note***: You can also get a list of work orders by using one of the following methods: [GET /odata/workorders](https://developer.servicechannel.com/swagger/ui/index?version=3#/WorkOrders/WorkOrders_GetWorkOrders), [GET /workorders](https://developer.servicechannel.com/swagger/ui/index?version=3#/WorkOrders/GETv3_workorders_locationId__locationId__storeId__storeId_).              <param name=\"request\"></param>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class OdataWorkordersFilterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var request = new SCServiceChannelServicesMessagingODataRequest(); // SCServiceChannelServicesMessagingODataRequest | 

            try
            {
                // Retrieve work orders
                List<SCServiceChannelServicesMessagingWorkordersWorkOrder> result = apiInstance.OdataWorkordersFilter(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.OdataWorkordersFilter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OdataWorkordersFilterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve work orders
    ApiResponse<List<SCServiceChannelServicesMessagingWorkordersWorkOrder>> response = apiInstance.OdataWorkordersFilterWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.OdataWorkordersFilterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingODataRequest**](SCServiceChannelServicesMessagingODataRequest.md) |  |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingWorkordersWorkOrder&gt;**](SCServiceChannelServicesMessagingWorkordersWorkOrder.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of work orders is in the response. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **406** | The request is already processed. |  -  |
| **500** | The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 — Object reference is not set to an instance of an object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscriberssubscriberidworkordersworkorderidreassign"></a>
# **SubscriberssubscriberIdWorkordersworkorderIdReassign**
> Object SubscriberssubscriberIdWorkordersworkorderIdReassign (int subscriberId, int workorderId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscriberssubscriberIdWorkordersworkorderIdReassignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var subscriberId = 56;  // int | 
            var workorderId = 56;  // int | 

            try
            {
                Object result = apiInstance.SubscriberssubscriberIdWorkordersworkorderIdReassign(subscriberId, workorderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.SubscriberssubscriberIdWorkordersworkorderIdReassign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriberssubscriberIdWorkordersworkorderIdReassignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.SubscriberssubscriberIdWorkordersworkorderIdReassignWithHttpInfo(subscriberId, workorderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.SubscriberssubscriberIdWorkordersworkorderIdReassignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** |  |  |
| **workorderId** | **int** |  |  |

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
| **404** | Indicates that the requested resource does not exist on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workorders"></a>
# **Workorders**
> void Workorders (SCServiceChannelServicesMessagingWorkordersCreateWoRequest request)

Create a Work order

Creates a new Work order. Returns Work order Id for successful request.              <br />Available for provider and subscriber usage.              <br />Additional info:              <br />Updates GL code based on passed Category param according to settings in Admin module {go to Admin =&gt; Accounting =&gt; GlCodes to see user GL codes}.              Similar logic is used when you create Work order through next path: Dashboard =&gt; Request Service.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var request = new SCServiceChannelServicesMessagingWorkordersCreateWoRequest(); // SCServiceChannelServicesMessagingWorkordersCreateWoRequest | A new Work order

            try
            {
                // Create a Work order
                apiInstance.Workorders(request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.Workorders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a Work order
    apiInstance.WorkordersWithHttpInfo(request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingWorkordersCreateWoRequest**](SCServiceChannelServicesMessagingWorkordersCreateWoRequest.md) | A new Work order |  |

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
| **201** | Created indicates that the request resulted in a new resource created before the response was sent. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 100 - No provider was found for specified location and trade;              &lt;br/&gt; 300 - Missed contract data;              &lt;br/&gt; 301 - Contract not found for specified subscribers location, provider and trade;              &lt;br/&gt; 400 - Invalid Subscriber Id specified;              &lt;br/&gt; 503 - Work order cannot be created, provider could not be determined (missing providerID or IssueRequestInfo);              &lt;br/&gt; 600 - Invalid Location Id specified;              &lt;br/&gt; 603 - Subscriber has no specified Location;              &lt;br/&gt; 700 - Invalid Trade Name specified;              &lt;br/&gt; 702 - Subscriber has no specified Trade;              &lt;br/&gt; 800 - Missed required argument &#39;UserId&#39;;              &lt;br/&gt; 801 - Missed required argument &#39;CreatedBy&#39;;              &lt;br/&gt; 900 - Missed problem description options;              &lt;br/&gt; 901 - Missed required argument &#39;ProblemSource&#39;;              &lt;br/&gt; 902 - Missed required argument &#39;Description&#39;;              &lt;br/&gt; 903 - Missed required argument &#39;ProblemCode&#39;;              &lt;br/&gt; 904 - Invalid WorkOrder status;              &lt;br/&gt; 905 - Invalid &#39;Nte&#39; value;              &lt;br/&gt; 906 - Invalid &#39;CallerName&#39; value;              &lt;br/&gt; 907 - Invalid &#39;CallDate&#39; value;              &lt;br/&gt; 908 - Invalid &#39;ScheduledDate&#39; value;              &lt;br/&gt; 909 - Invalid &#39;ScheduledDate&#39;, greater than max allowed by subscriber;              &lt;br/&gt; 910 - Missed required argument &#39;Category&#39;;              &lt;br/&gt; 911 - Invalid &#39;Category&#39;;              &lt;br/&gt; 912 - Missed required argument &#39;Priority&#39;;              &lt;br/&gt; 913 - Invalid &#39;Priority&#39;;              &lt;br/&gt; 914 - Invalid &#39;Currency&#39; value;              &lt;br/&gt; 915 - Invalid Setup Id;              &lt;br/&gt; 916 - At least one attachment required to create this WorkOrder;              &lt;br/&gt; 918 - Assets required to create this WorkOrder; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server.              &lt;br/&gt;Error codes:              &lt;br/&gt; 501 - Sequence contains no elements |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workorderscategoriessubscriberidsubscriberidsortexprsortexpr"></a>
# **WorkordersCategoriesSubscriberIdSubscriberIdSortExprSortExpr**
> List&lt;SCServiceChannelServicesMessagingCategoryCategoryResponse&gt; WorkordersCategoriesSubscriberIdSubscriberIdSortExprSortExpr (int? subscriberId = null, string? sortExpr = null)

Categories Collection

Retrieves list of all Work order categories.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersCategoriesSubscriberIdSubscriberIdSortExprSortExprExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var subscriberId = 56;  // int? | This parameter is required only for provider. (optional) 
            var sortExpr = "sortExpr_example";  // string? | Gets or sets sort expression. (optional) 

            try
            {
                // Categories Collection
                List<SCServiceChannelServicesMessagingCategoryCategoryResponse> result = apiInstance.WorkordersCategoriesSubscriberIdSubscriberIdSortExprSortExpr(subscriberId, sortExpr);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersCategoriesSubscriberIdSubscriberIdSortExprSortExpr: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersCategoriesSubscriberIdSubscriberIdSortExprSortExprWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Categories Collection
    ApiResponse<List<SCServiceChannelServicesMessagingCategoryCategoryResponse>> response = apiInstance.WorkordersCategoriesSubscriberIdSubscriberIdSortExprSortExprWithHttpInfo(subscriberId, sortExpr);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersCategoriesSubscriberIdSubscriberIdSortExprSortExprWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int?** | This parameter is required only for provider. | [optional]  |
| **sortExpr** | **string?** | Gets or sets sort expression. | [optional]  |

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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 503 - Request data is empty;              &lt;br/&gt;SubscriberId is incorrect; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersfeedbacklistworkordersids0workordersids0workordersids1workordersids1"></a>
# **WorkordersFeedbackListworkOrdersIds0workOrdersIds0workOrdersIds1workOrdersIds1**
> void WorkordersFeedbackListworkOrdersIds0workOrdersIds0workOrdersIds1workOrdersIds1 (List<int> workOrdersIds)

Get work orders feedbacks

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersFeedbackListworkOrdersIds0workOrdersIds0workOrdersIds1workOrdersIds1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workOrdersIds = new List<int>(); // List<int> | 

            try
            {
                // Get work orders feedbacks
                apiInstance.WorkordersFeedbackListworkOrdersIds0workOrdersIds0workOrdersIds1workOrdersIds1(workOrdersIds);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersFeedbackListworkOrdersIds0workOrdersIds0workOrdersIds1workOrdersIds1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersFeedbackListworkOrdersIds0workOrdersIds0workOrdersIds1workOrdersIds1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get work orders feedbacks
    apiInstance.WorkordersFeedbackListworkOrdersIds0workOrdersIds0workOrdersIds1workOrdersIds1WithHttpInfo(workOrdersIds);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersFeedbackListworkOrdersIds0workOrdersIds0workOrdersIds1workOrdersIds1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrdersIds** | [**List&lt;int&gt;**](int.md) |  |  |

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
| **200** | Indicates that the request succeeded. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordershandlewocompletionforsurvey"></a>
# **WorkordersHandlewocompletionforsurvey**
> void WorkordersHandlewocompletionforsurvey (SCServiceChannelServicesMessagingWorkordersWorkorderNotificationObject request)

Add Empty Survey for Work Order Completion

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersHandlewocompletionforsurveyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var request = new SCServiceChannelServicesMessagingWorkordersWorkorderNotificationObject(); // SCServiceChannelServicesMessagingWorkordersWorkorderNotificationObject | The request model to perform action with.

            try
            {
                // Add Empty Survey for Work Order Completion
                apiInstance.WorkordersHandlewocompletionforsurvey(request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersHandlewocompletionforsurvey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersHandlewocompletionforsurveyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Empty Survey for Work Order Completion
    apiInstance.WorkordersHandlewocompletionforsurveyWithHttpInfo(request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersHandlewocompletionforsurveyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingWorkordersWorkorderNotificationObject**](SCServiceChannelServicesMessagingWorkordersWorkorderNotificationObject.md) | The request model to perform action with. |  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Indicates that the request succeeded. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersistechniciancertificateusedonworkorderscertificateidcertificateid"></a>
# **WorkordersIsTechnicianCertificateUsedOnWorkOrderscertificateIdcertificateId**
> bool WorkordersIsTechnicianCertificateUsedOnWorkOrderscertificateIdcertificateId (int certificateId)

Verify if refrigerant certificat is associated with WOs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersIsTechnicianCertificateUsedOnWorkOrderscertificateIdcertificateIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var certificateId = 56;  // int | Numeric Id of the technician certificatite

            try
            {
                // Verify if refrigerant certificat is associated with WOs
                bool result = apiInstance.WorkordersIsTechnicianCertificateUsedOnWorkOrderscertificateIdcertificateId(certificateId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersIsTechnicianCertificateUsedOnWorkOrderscertificateIdcertificateId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersIsTechnicianCertificateUsedOnWorkOrderscertificateIdcertificateIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Verify if refrigerant certificat is associated with WOs
    ApiResponse<bool> response = apiInstance.WorkordersIsTechnicianCertificateUsedOnWorkOrderscertificateIdcertificateIdWithHttpInfo(certificateId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersIsTechnicianCertificateUsedOnWorkOrderscertificateIdcertificateIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **certificateId** | **int** | Numeric Id of the technician certificatite |  |

### Return type

**bool**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Refrigerant certification is verified. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | Something went wrong, and the server was unable to complete your request.              &lt;br/&gt;Error codes:              501 — Internal Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workorderslabelkeywordkeywordpagepagepagesizepagesize"></a>
# **WorkordersLabelkeywordkeywordpagepagepageSizepageSize**
> List&lt;SCServiceChannelServicesMessagingWorkordersGetWorkOrderLabelResponse&gt; WorkordersLabelkeywordkeywordpagepagepageSizepageSize (string? keyword = null, int? page = null, int? pageSize = null)

Get work orders labels.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersLabelkeywordkeywordpagepagepageSizepageSizeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var keyword = "keyword_example";  // string? | Keyword contained in labels to perform the search by. (optional) 
            var page = 56;  // int? | Results page number. Page number for pagination is 1-based. (optional) 
            var pageSize = 56;  // int? | Number of labels on the results page. (optional) 

            try
            {
                // Get work orders labels.
                List<SCServiceChannelServicesMessagingWorkordersGetWorkOrderLabelResponse> result = apiInstance.WorkordersLabelkeywordkeywordpagepagepageSizepageSize(keyword, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersLabelkeywordkeywordpagepagepageSizepageSize: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersLabelkeywordkeywordpagepagepageSizepageSizeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get work orders labels.
    ApiResponse<List<SCServiceChannelServicesMessagingWorkordersGetWorkOrderLabelResponse>> response = apiInstance.WorkordersLabelkeywordkeywordpagepagepageSizepageSizeWithHttpInfo(keyword, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersLabelkeywordkeywordpagepagepageSizepageSizeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **keyword** | **string?** | Keyword contained in labels to perform the search by. | [optional]  |
| **page** | **int?** | Results page number. Page number for pagination is 1-based. | [optional]  |
| **pageSize** | **int?** | Number of labels on the results page. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingWorkordersGetWorkOrderLabelResponse&gt;**](SCServiceChannelServicesMessagingWorkordersGetWorkOrderLabelResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workorderspriorities"></a>
# **WorkordersPriorities**
> List&lt;SCServiceChannelServicesMessagingPrioritiesAddPriorityResponse&gt; WorkordersPriorities (SCServiceChannelServicesMessagingPrioritiesAddPriorityRequest request)

Create Priority

Creates Priority.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersPrioritiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var request = new SCServiceChannelServicesMessagingPrioritiesAddPriorityRequest(); // SCServiceChannelServicesMessagingPrioritiesAddPriorityRequest | The request model to perform action with.

            try
            {
                // Create Priority
                List<SCServiceChannelServicesMessagingPrioritiesAddPriorityResponse> result = apiInstance.WorkordersPriorities(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersPriorities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersPrioritiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Priority
    ApiResponse<List<SCServiceChannelServicesMessagingPrioritiesAddPriorityResponse>> response = apiInstance.WorkordersPrioritiesWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersPrioritiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingPrioritiesAddPriorityRequest**](SCServiceChannelServicesMessagingPrioritiesAddPriorityRequest.md) | The request model to perform action with. |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingPrioritiesAddPriorityResponse&gt;**](SCServiceChannelServicesMessagingPrioritiesAddPriorityResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Indicates that the request succeeded. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersprioritiessubscriberidsubscriberid"></a>
# **WorkordersPrioritiessubscriberIdsubscriberId**
> List&lt;SCServiceChannelServicesMessagingPrioritiesPriorityResponse&gt; WorkordersPrioritiessubscriberIdsubscriberId (int? subscriberId = null)

Priorities Collection

Retrieves list of all Work order priorities in user settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersPrioritiessubscriberIdsubscriberIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var subscriberId = 56;  // int? | This parameter is required only for provider. (optional) 

            try
            {
                // Priorities Collection
                List<SCServiceChannelServicesMessagingPrioritiesPriorityResponse> result = apiInstance.WorkordersPrioritiessubscriberIdsubscriberId(subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersPrioritiessubscriberIdsubscriberId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersPrioritiessubscriberIdsubscriberIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Priorities Collection
    ApiResponse<List<SCServiceChannelServicesMessagingPrioritiesPriorityResponse>> response = apiInstance.WorkordersPrioritiessubscriberIdsubscriberIdWithHttpInfo(subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersPrioritiessubscriberIdsubscriberIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int?** | This parameter is required only for provider. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingPrioritiesPriorityResponse&gt;**](SCServiceChannelServicesMessagingPrioritiesPriorityResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersproviderforreassignmentworkorderidworkorderidprovideridprovideridlocationidlocationidtradetrade"></a>
# **WorkordersProviderforreassignmentworkorderIdworkorderIdproviderIdproviderIdlocationIdlocationIdtradetrade**
> void WorkordersProviderforreassignmentworkorderIdworkorderIdproviderIdproviderIdlocationIdlocationIdtradetrade (int workorderId, int providerId, int locationId, string trade)

Retrieve a Provider

A single Provider object with all its details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersProviderforreassignmentworkorderIdworkorderIdproviderIdproviderIdlocationIdlocationIdtradetradeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | Numeric Id of the Work order to perform action with.
            var providerId = 56;  // int | Numeric Id of the previously assigned Provider.
            var locationId = 56;  // int | Numeric Id of the Location.
            var trade = "trade_example";  // string | Trade.

            try
            {
                // Retrieve a Provider
                apiInstance.WorkordersProviderforreassignmentworkorderIdworkorderIdproviderIdproviderIdlocationIdlocationIdtradetrade(workorderId, providerId, locationId, trade);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersProviderforreassignmentworkorderIdworkorderIdproviderIdproviderIdlocationIdlocationIdtradetrade: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersProviderforreassignmentworkorderIdworkorderIdproviderIdproviderIdlocationIdlocationIdtradetradeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a Provider
    apiInstance.WorkordersProviderforreassignmentworkorderIdworkorderIdproviderIdproviderIdlocationIdlocationIdtradetradeWithHttpInfo(workorderId, providerId, locationId, trade);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersProviderforreassignmentworkorderIdworkorderIdproviderIdproviderIdlocationIdlocationIdtradetradeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Numeric Id of the Work order to perform action with. |  |
| **providerId** | **int** | Numeric Id of the previously assigned Provider. |  |
| **locationId** | **int** | Numeric Id of the Location. |  |
| **trade** | **string** | Trade. |  |

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
| **204** | Indicates that the request has been successfully processed and that the response is intentionally blank. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 503 - Request data is empty; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersreassignreasonssubscriberidsubscriberid"></a>
# **WorkordersReassignReasonssubscriberIdsubscriberId**
> List&lt;SCServiceChannelServicesMessagingWorkordersWorkOrderReassignmentReason&gt; WorkordersReassignReasonssubscriberIdsubscriberId (int? subscriberId = null)

Work order reassignment reasons

List Work order reassignment reasons.              <br /><br />Available for provider and subscriber usage.              <br /><br />SubscriberId is used to determine provider access to the action ('WorkOrderReassign' EffectiveProviderPermissions, calculated flag. Calculated by ProviderAuthorizationHandler)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersReassignReasonssubscriberIdsubscriberIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var subscriberId = 56;  // int? | This parameter is required only for provider. (optional) 

            try
            {
                // Work order reassignment reasons
                List<SCServiceChannelServicesMessagingWorkordersWorkOrderReassignmentReason> result = apiInstance.WorkordersReassignReasonssubscriberIdsubscriberId(subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersReassignReasonssubscriberIdsubscriberId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersReassignReasonssubscriberIdsubscriberIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Work order reassignment reasons
    ApiResponse<List<SCServiceChannelServicesMessagingWorkordersWorkOrderReassignmentReason>> response = apiInstance.WorkordersReassignReasonssubscriberIdsubscriberIdWithHttpInfo(subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersReassignReasonssubscriberIdsubscriberIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int?** | This parameter is required only for provider. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingWorkordersWorkOrderReassignmentReason&gt;**](SCServiceChannelServicesMessagingWorkordersWorkOrderReassignmentReason.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **403** | Indicates that the server refuses to fulfill the request.              &lt;br/&gt; Error codes:              &lt;br/&gt; 804 - API call rejected by lack of provider permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workorderssolvedissue"></a>
# **WorkordersSolvedissue**
> void WorkordersSolvedissue (SCServiceChannelServicesMessagingWorkordersDashboardRequestsSubmitSolvedIssueModel model)

Submit solved issue during troubleshooting

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersSolvedissueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var model = new SCServiceChannelServicesMessagingWorkordersDashboardRequestsSubmitSolvedIssueModel(); // SCServiceChannelServicesMessagingWorkordersDashboardRequestsSubmitSolvedIssueModel | 

            try
            {
                // Submit solved issue during troubleshooting
                apiInstance.WorkordersSolvedissue(model);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersSolvedissue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersSolvedissueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Submit solved issue during troubleshooting
    apiInstance.WorkordersSolvedissueWithHttpInfo(model);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersSolvedissueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **model** | [**SCServiceChannelServicesMessagingWorkordersDashboardRequestsSubmitSolvedIssueModel**](SCServiceChannelServicesMessagingWorkordersDashboardRequestsSubmitSolvedIssueModel.md) |  |  |

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
| **201** | Indicates that the request has succeeded and has led to the creation of a resource. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 503 - Request data is empty; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **404** | Indicates that the requested resource does not exist on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersstarred"></a>
# **WorkordersStarred**
> List&lt;int&gt; WorkordersStarred ()

Starred Work Order Ids Collection

Retrieves list of work order ids starred by the current user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersStarredExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);

            try
            {
                // Starred Work Order Ids Collection
                List<int> result = apiInstance.WorkordersStarred();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersStarred: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersStarredWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Starred Work Order Ids Collection
    ApiResponse<List<int>> response = apiInstance.WorkordersStarredWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersStarredWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**List<int>**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Indicates that the requested resource requires authentication.               &lt;br/&gt;Error codes:               &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersstatisticsdaysperioddaysperiod"></a>
# **WorkordersStatisticsdaysPerioddaysPeriod**
> SCServiceChannelServicesMessagingWorkordersWorkOrderStatisticsResponse WorkordersStatisticsdaysPerioddaysPeriod (int? daysPeriod = null)

Statistics Collection

Retrieves list of all Work order Statistics. Only for providers usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersStatisticsdaysPerioddaysPeriodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var daysPeriod = 56;  // int? | Days Period to perform action with (30 by default). (optional) 

            try
            {
                // Statistics Collection
                SCServiceChannelServicesMessagingWorkordersWorkOrderStatisticsResponse result = apiInstance.WorkordersStatisticsdaysPerioddaysPeriod(daysPeriod);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersStatisticsdaysPerioddaysPeriod: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersStatisticsdaysPerioddaysPeriodWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Statistics Collection
    ApiResponse<SCServiceChannelServicesMessagingWorkordersWorkOrderStatisticsResponse> response = apiInstance.WorkordersStatisticsdaysPerioddaysPeriodWithHttpInfo(daysPeriod);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersStatisticsdaysPerioddaysPeriodWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **daysPeriod** | **int?** | Days Period to perform action with (30 by default). | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingWorkordersWorkOrderStatisticsResponse**](SCServiceChannelServicesMessagingWorkordersWorkOrderStatisticsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 503 - Only for providers usage;&lt;br&gt;Request data is empty; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersstatusessubscriberidsubscriberidtradeidtradeid"></a>
# **WorkordersStatusessubscriberIdsubscriberIdtradeIdtradeId**
> List&lt;SCServiceChannelServicesMessagingWorkordersGetStatusResponse&gt; WorkordersStatusessubscriberIdsubscriberIdtradeIdtradeId (int? subscriberId = null, int? tradeId = null)

Statuses Collection

Retrieves list of available Work order statuses. Id value can be used instead of primary status name in Update Status method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersStatusessubscriberIdsubscriberIdtradeIdtradeIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var subscriberId = 56;  // int? | This parameter is required only for provider. (optional) 
            var tradeId = 56;  // int? | Optional, if LimitStatusesByTrade FF is on (optional) 

            try
            {
                // Statuses Collection
                List<SCServiceChannelServicesMessagingWorkordersGetStatusResponse> result = apiInstance.WorkordersStatusessubscriberIdsubscriberIdtradeIdtradeId(subscriberId, tradeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersStatusessubscriberIdsubscriberIdtradeIdtradeId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersStatusessubscriberIdsubscriberIdtradeIdtradeIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Statuses Collection
    ApiResponse<List<SCServiceChannelServicesMessagingWorkordersGetStatusResponse>> response = apiInstance.WorkordersStatusessubscriberIdsubscriberIdtradeIdtradeIdWithHttpInfo(subscriberId, tradeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersStatusessubscriberIdsubscriberIdtradeIdtradeIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int?** | This parameter is required only for provider. | [optional]  |
| **tradeId** | **int?** | Optional, if LimitStatusesByTrade FF is on | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingWorkordersGetStatusResponse&gt;**](SCServiceChannelServicesMessagingWorkordersGetStatusResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workorderslocationidlocationidstoreidstoreid"></a>
# **WorkorderslocationIdlocationIdstoreIdstoreId**
> List&lt;SCServiceChannelServicesMessagingWorkordersWorkOrder&gt; WorkorderslocationIdlocationIdstoreIdstoreId (int? locationId = null, string? storeId = null, List<Object>? otherLocationId = null, List<Object>? id = null, List<Object>? category = null, List<Object>? status = null, List<Object>? extendedStatus = null, List<Object>? number = null, List<Object>? serviceId = null, List<Object>? priority = null, List<Object>? purchaseNumber = null, List<Object>? trade = null, List<Object>? scheduledDate = null, List<Object>? expirationDate = null, List<Object>? callDate = null, string? sort = null, int? page = null, int? pageSize = null)

Search Work Orders

Performs search of workorders by specified filter expression and returns list of work orders with all details.              <br />One page contains 50 items by default (\"pageSize\"=50). To get next 50 items use the \"page\" parameter (for example page=2 and so on).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkorderslocationIdlocationIdstoreIdstoreIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var locationId = 56;  // int? | UID of location. (optional) 
            var storeId = "storeId_example";  // string? | StoreId of location. Used to find location for which search will be performed. (optional) 
            var otherLocationId = new List<Object>?(); // List<Object>? | UID of location, exact search by default (optional) 
            var id = new List<Object>?(); // List<Object>? | UID of work order, exact search by default (optional) 
            var category = new List<Object>?(); // List<Object>? | Category of work order, exact search by default (optional) 
            var status = new List<Object>?(); // List<Object>? | Status of work order, exact search by default (optional) 
            var extendedStatus = new List<Object>?(); // List<Object>? | Extended status of work order, exact search by default (optional) 
            var number = new List<Object>?(); // List<Object>? | Work order number, 'starts with' search criteria by default (optional) 
            var serviceId = new List<Object>?(); // List<Object>? | 'starts with' search criteria by default (optional) 
            var priority = new List<Object>?(); // List<Object>? | Priority of work order, exact search by default (optional) 
            var purchaseNumber = new List<Object>?(); // List<Object>? | Purchase number of work order, 'starts with' search criteria by default (optional) 
            var trade = new List<Object>?(); // List<Object>? | Trade, 'starts with' search criteria by default (optional) 
            var scheduledDate = new List<Object>?(); // List<Object>? | Scheduled date (optional) 
            var expirationDate = new List<Object>?(); // List<Object>? | Expiration date (optional) 
            var callDate = new List<Object>?(); // List<Object>? | Call date (optional) 
            var sort = "sort_example";  // string? | Sort resources by the specified property in the response. (optional) 
            var page = 56;  // int? | Results page number. (optional) 
            var pageSize = 56;  // int? | Number of objects on the results page. The default and maximum per page is 50. (optional) 

            try
            {
                // Search Work Orders
                List<SCServiceChannelServicesMessagingWorkordersWorkOrder> result = apiInstance.WorkorderslocationIdlocationIdstoreIdstoreId(locationId, storeId, otherLocationId, id, category, status, extendedStatus, number, serviceId, priority, purchaseNumber, trade, scheduledDate, expirationDate, callDate, sort, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkorderslocationIdlocationIdstoreIdstoreId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkorderslocationIdlocationIdstoreIdstoreIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search Work Orders
    ApiResponse<List<SCServiceChannelServicesMessagingWorkordersWorkOrder>> response = apiInstance.WorkorderslocationIdlocationIdstoreIdstoreIdWithHttpInfo(locationId, storeId, otherLocationId, id, category, status, extendedStatus, number, serviceId, priority, purchaseNumber, trade, scheduledDate, expirationDate, callDate, sort, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkorderslocationIdlocationIdstoreIdstoreIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int?** | UID of location. | [optional]  |
| **storeId** | **string?** | StoreId of location. Used to find location for which search will be performed. | [optional]  |
| **otherLocationId** | [**List&lt;Object&gt;?**](Object.md) | UID of location, exact search by default | [optional]  |
| **id** | [**List&lt;Object&gt;?**](Object.md) | UID of work order, exact search by default | [optional]  |
| **category** | [**List&lt;Object&gt;?**](Object.md) | Category of work order, exact search by default | [optional]  |
| **status** | [**List&lt;Object&gt;?**](Object.md) | Status of work order, exact search by default | [optional]  |
| **extendedStatus** | [**List&lt;Object&gt;?**](Object.md) | Extended status of work order, exact search by default | [optional]  |
| **number** | [**List&lt;Object&gt;?**](Object.md) | Work order number, &#39;starts with&#39; search criteria by default | [optional]  |
| **serviceId** | [**List&lt;Object&gt;?**](Object.md) | &#39;starts with&#39; search criteria by default | [optional]  |
| **priority** | [**List&lt;Object&gt;?**](Object.md) | Priority of work order, exact search by default | [optional]  |
| **purchaseNumber** | [**List&lt;Object&gt;?**](Object.md) | Purchase number of work order, &#39;starts with&#39; search criteria by default | [optional]  |
| **trade** | [**List&lt;Object&gt;?**](Object.md) | Trade, &#39;starts with&#39; search criteria by default | [optional]  |
| **scheduledDate** | [**List&lt;Object&gt;?**](Object.md) | Scheduled date | [optional]  |
| **expirationDate** | [**List&lt;Object&gt;?**](Object.md) | Expiration date | [optional]  |
| **callDate** | [**List&lt;Object&gt;?**](Object.md) | Call date | [optional]  |
| **sort** | **string?** | Sort resources by the specified property in the response. | [optional]  |
| **page** | **int?** | Results page number. | [optional]  |
| **pageSize** | **int?** | Number of objects on the results page. The default and maximum per page is 50. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingWorkordersWorkOrder&gt;**](SCServiceChannelServicesMessagingWorkordersWorkOrder.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 403 - Account has not been activated for GPS use;              &lt;br/&gt; 503 - Validation fails. Request is empty or null;              &lt;br/&gt; 601 - Location Id is invalid;              &lt;br/&gt; 606 - Cannot find location by StoreId;              &lt;br/&gt; 1000 - Invalid Setup Id; |  -  |
| **401** | Requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions;  |  -  |
| **500** | Indicates that a generic error has occurred on the server.              &lt;br/&gt;Error codes:              &lt;br/&gt; 501 - Timeout expired. The timeout period elapsed prior to completion of the operation or the server is not responding. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidaccept"></a>
# **WorkordersworkOrderIdAccept**
> void WorkordersworkOrderIdAccept (int workOrderId, SCServiceChannelServicesMessagingWorkordersAcceptWorkOrderRequest request)

Accept a work order

Allows a provider to accept a work order with an optional note.              <br />When a work order is successfully accepted, it changes its status from *Open* to *In Progress / Dispatch Confirmed*.               <br />***Note***: Providers only can use this method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkOrderIdAcceptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workOrderId = 56;  // int | Unique numeric identifier of the work order.
            var request = new SCServiceChannelServicesMessagingWorkordersAcceptWorkOrderRequest(); // SCServiceChannelServicesMessagingWorkordersAcceptWorkOrderRequest | Request to add a note to the work order while accepting it.

            try
            {
                // Accept a work order
                apiInstance.WorkordersworkOrderIdAccept(workOrderId, request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkOrderIdAccept: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkOrderIdAcceptWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Accept a work order
    apiInstance.WorkordersworkOrderIdAcceptWithHttpInfo(workOrderId, request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkOrderIdAcceptWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrderId** | **int** | Unique numeric identifier of the work order. |  |
| **request** | [**SCServiceChannelServicesMessagingWorkordersAcceptWorkOrderRequest**](SCServiceChannelServicesMessagingWorkordersAcceptWorkOrderRequest.md) | Request to add a note to the work order while accepting it. |  |

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
| **200** | Work order is successfully accepted. |  -  |
| **400** | The request was not accepted due to bad syntax, missing parameters, insufficient data, etc.                &lt;br/&gt;Error codes:              502 &amp;mdash; Work order is not found              804 &amp;mdash; User has no permission to perform this action               904 &amp;mdash; Work order is in status that does not allow to perform this action               5202 &amp;mdash; This work order was already accepted              5203 &amp;mdash; Acceptance of the work order failed |  -  |
| **401** | The requested resource requires authentication.              &lt;br/&gt;Error codes:              504 &amp;mdash; API call rejected by security permissions |  -  |
| **404** | Invalid work order ID. |  -  |
| **500** | Something went wrong, and the server was unable to complete your request.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidanalytics"></a>
# **WorkordersworkOrderIdAnalytics**
> SCServiceChannelServicesMessagingWorkordersWorkOrderAnalyticsResponse WorkordersworkOrderIdAnalytics (int workOrderId)

Get analytics on a work order

Retrieves analytics on the specified work order.               <br />Analytics are based on the following flags:                • **IVR**. Tracks the proper Check-In/Out process and indicates whether the work order has both Check-In and Check-Out records and completes with a Check-Out.                • **SLA**. Tracks estimated time of arrival (ETA) and indicates whether the work order met the original ETA.                • **FirstTimeCompletionFlag**. Indicates whether the work order was completed on the first visit (the work order has only one Check-In and one Check-Out records within 24 hours).               <br />***Note***: You can get analytics from any work order. However, the analytics are mostly relevant for the work orders in the **Completed** status, as these flags rest on the Check-In/Out information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkOrderIdAnalyticsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workOrderId = 56;  // int | Unique numeric identifier of the work order to get analytics from.

            try
            {
                // Get analytics on a work order
                SCServiceChannelServicesMessagingWorkordersWorkOrderAnalyticsResponse result = apiInstance.WorkordersworkOrderIdAnalytics(workOrderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkOrderIdAnalytics: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkOrderIdAnalyticsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get analytics on a work order
    ApiResponse<SCServiceChannelServicesMessagingWorkordersWorkOrderAnalyticsResponse> response = apiInstance.WorkordersworkOrderIdAnalyticsWithHttpInfo(workOrderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkOrderIdAnalyticsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrderId** | **int** | Unique numeric identifier of the work order to get analytics from. |  |

### Return type

[**SCServiceChannelServicesMessagingWorkordersWorkOrderAnalyticsResponse**](SCServiceChannelServicesMessagingWorkordersWorkOrderAnalyticsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Analytics on the specified work order are in the response. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **404** | The request URI is incorrect, or the resource does not exist.              &lt;br/&gt;Error codes:               502 — Data not found              The resource you are looking for has been removed, had its name changed, or is temporarily unavailable |  -  |
| **500** | Something went wrong, and the server was unable to complete your request.              &lt;br/&gt;Error codes:              501 — Internal Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidchecklistsresponsesgetallgetall"></a>
# **WorkordersworkOrderIdChecklistsResponsesgetAllgetAll**
> SCServiceChannelServicesMessagingCheckListDetailsGetResponsesByWorkOrderResponse WorkordersworkOrderIdChecklistsResponsesgetAllgetAll (int workOrderId, bool? getAll = null)

Get checklist responses for a work order

[Returns checklist responses](https://developer.servicechannel.com/guides/checklists/get-checklist-responses-for-a-wo/) submitted for the specified work order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkOrderIdChecklistsResponsesgetAllgetAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workOrderId = 56;  // int | Unique identifier of the work order to return checklist responses for.
            var getAll = false;  // bool? | Flag to get responses from all completed checklists. (optional)  (default to false)

            try
            {
                // Get checklist responses for a work order
                SCServiceChannelServicesMessagingCheckListDetailsGetResponsesByWorkOrderResponse result = apiInstance.WorkordersworkOrderIdChecklistsResponsesgetAllgetAll(workOrderId, getAll);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkOrderIdChecklistsResponsesgetAllgetAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkOrderIdChecklistsResponsesgetAllgetAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get checklist responses for a work order
    ApiResponse<SCServiceChannelServicesMessagingCheckListDetailsGetResponsesByWorkOrderResponse> response = apiInstance.WorkordersworkOrderIdChecklistsResponsesgetAllgetAllWithHttpInfo(workOrderId, getAll);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkOrderIdChecklistsResponsesgetAllgetAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrderId** | **int** | Unique identifier of the work order to return checklist responses for. |  |
| **getAll** | **bool?** | Flag to get responses from all completed checklists. | [optional] [default to false] |

### Return type

[**SCServiceChannelServicesMessagingCheckListDetailsGetResponsesByWorkOrderResponse**](SCServiceChannelServicesMessagingCheckListDetailsGetResponsesByWorkOrderResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Checklist responses for the specified work order are returned. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              502 — Work order is not found |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderiddecline"></a>
# **WorkordersworkOrderIdDecline**
> void WorkordersworkOrderIdDecline (int workOrderId, SCServiceChannelServicesMessagingWorkordersDeclineWorkOrderRequest request)

Decline a work order

Allows a provider to decline a work order with a note.               <br />When a provider declines a work order, the order changes its status from *Open* to *Open / Declined* or becomes automatically reassigned to another provider if the *WOMultipleAutoReassign* feature flag is turned on for the subscriber.               <br />***Note***: Providers only can use this method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkOrderIdDeclineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workOrderId = 56;  // int | Unique numeric identifier of the work order.
            var request = new SCServiceChannelServicesMessagingWorkordersDeclineWorkOrderRequest(); // SCServiceChannelServicesMessagingWorkordersDeclineWorkOrderRequest | Request to add information about the work order decline.               <br />Required parameters:                • `DeclineReasonId` (if the *DeclineHistoryWO* feature flag is on)               • `CustomDeclineReason` (if the decline reason has `AskCustomReason`=true)

            try
            {
                // Decline a work order
                apiInstance.WorkordersworkOrderIdDecline(workOrderId, request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkOrderIdDecline: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkOrderIdDeclineWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Decline a work order
    apiInstance.WorkordersworkOrderIdDeclineWithHttpInfo(workOrderId, request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkOrderIdDeclineWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrderId** | **int** | Unique numeric identifier of the work order. |  |
| **request** | [**SCServiceChannelServicesMessagingWorkordersDeclineWorkOrderRequest**](SCServiceChannelServicesMessagingWorkordersDeclineWorkOrderRequest.md) | Request to add information about the work order decline.               &lt;br /&gt;Required parameters:                • &#x60;DeclineReasonId&#x60; (if the *DeclineHistoryWO* feature flag is on)               • &#x60;CustomDeclineReason&#x60; (if the decline reason has &#x60;AskCustomReason&#x60;&#x3D;true) |  |

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
| **200** | Work order is declined. |  -  |
| **400** | The request was not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              502 &amp;mdash; Work order is not found              804 &amp;mdash; User has no permission to perform this action              904 &amp;mdash; Work order is in status that does not allow to perform this action              5201 &amp;mdash; Work order decline failed              9002 &amp;mdash; This decline reason does not allow custom text              9003 &amp;mdash; Invalid decline reason ID |  -  |
| **401** | The requested resource requires authentication.               &lt;br/&gt;Error codes:              504 &amp;mdash; API call rejected by security permissions |  -  |
| **500** | Something went wrong, and the server was unable to complete your request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidleakwasdetected"></a>
# **WorkordersworkOrderIdLeakWasDetected**
> bool WorkordersworkOrderIdLeakWasDetected (int workOrderId)

Retrieve the leak detection result in a Work Order

Return the answer to the question did you find a leak on the specified work order:               • `null`: There is no information about the detected leak.               • `true`: The answer to the question did you find a leak is Yes.               • `false`: The answer to the question did you find a leak is No.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkOrderIdLeakWasDetectedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workOrderId = 56;  // int | The unique numeric identifier of the work order.

            try
            {
                // Retrieve the leak detection result in a Work Order
                bool result = apiInstance.WorkordersworkOrderIdLeakWasDetected(workOrderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkOrderIdLeakWasDetected: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkOrderIdLeakWasDetectedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve the leak detection result in a Work Order
    ApiResponse<bool> response = apiInstance.WorkordersworkOrderIdLeakWasDetectedWithHttpInfo(workOrderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkOrderIdLeakWasDetectedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrderId** | **int** | The unique numeric identifier of the work order. |  |

### Return type

**bool**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **401** | The request is not authorized.&lt;br/&gt;&lt;br/&gt;Error codes:&lt;br/&gt;504 — API call rejected by security permissions |  -  |
| **404** | The requested resource does not exist on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidprojectapproval"></a>
# **WorkordersworkOrderIdProjectApproval**
> SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse WorkordersworkOrderIdProjectApproval (int workOrderId, SCServiceChannelServicesMessagingWorkordersUpdateWorkOrdersProjectApprovalRequest updateRequest)

Update Work orders NTE project approval

Update Work orders NTE project approval. Returns successfully updated id.              <br /><br />This method can only be used for users with 'WorkOrderFullEdit' permissions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkOrderIdProjectApprovalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workOrderId = 56;  // int | Numeric Id of the Work order to perform action with.
            var updateRequest = new SCServiceChannelServicesMessagingWorkordersUpdateWorkOrdersProjectApprovalRequest(); // SCServiceChannelServicesMessagingWorkordersUpdateWorkOrdersProjectApprovalRequest | The update request. Work orders NTE/Link project approval.

            try
            {
                // Update Work orders NTE project approval
                SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse result = apiInstance.WorkordersworkOrderIdProjectApproval(workOrderId, updateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkOrderIdProjectApproval: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkOrderIdProjectApprovalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Work orders NTE project approval
    ApiResponse<SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse> response = apiInstance.WorkordersworkOrderIdProjectApprovalWithHttpInfo(workOrderId, updateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkOrderIdProjectApprovalWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrderId** | **int** | Numeric Id of the Work order to perform action with. |  |
| **updateRequest** | [**SCServiceChannelServicesMessagingWorkordersUpdateWorkOrdersProjectApprovalRequest**](SCServiceChannelServicesMessagingWorkordersUpdateWorkOrdersProjectApprovalRequest.md) | The update request. Work orders NTE/Link project approval. |  |

### Return type

[**SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse**](SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.           &lt;br/&gt;Error codes:           &lt;br/&gt; 100 - You don&#39;t have location access to perform this operation;           &lt;br/&gt; 502 - Data not found. Returned if target Work order is not found database;           &lt;br/&gt; 503 - Request data is empty; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidprojectapproval_0"></a>
# **WorkordersworkOrderIdProjectApproval_0**
> SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse WorkordersworkOrderIdProjectApproval_0 (int workOrderId, SCServiceChannelServicesMessagingWorkordersCreateWorkOrdersProjectApprovalRequest createRequest)

Create Work orders project approval

Create Work orders project approval. Returns successfully updated id.              <br /><br />This method can only be used for users with 'WorkOrderFullEdit' permissions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkOrderIdProjectApproval_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workOrderId = 56;  // int | Numeric Id of the Work order to perform action with.
            var createRequest = new SCServiceChannelServicesMessagingWorkordersCreateWorkOrdersProjectApprovalRequest(); // SCServiceChannelServicesMessagingWorkordersCreateWorkOrdersProjectApprovalRequest | The create request. Work orders project approval.

            try
            {
                // Create Work orders project approval
                SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse result = apiInstance.WorkordersworkOrderIdProjectApproval_0(workOrderId, createRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkOrderIdProjectApproval_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkOrderIdProjectApproval_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Work orders project approval
    ApiResponse<SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse> response = apiInstance.WorkordersworkOrderIdProjectApproval_0WithHttpInfo(workOrderId, createRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkOrderIdProjectApproval_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrderId** | **int** | Numeric Id of the Work order to perform action with. |  |
| **createRequest** | [**SCServiceChannelServicesMessagingWorkordersCreateWorkOrdersProjectApprovalRequest**](SCServiceChannelServicesMessagingWorkordersCreateWorkOrdersProjectApprovalRequest.md) | The create request. Work orders project approval. |  |

### Return type

[**SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse**](SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.           &lt;br/&gt;Error codes:           &lt;br/&gt; 100 - You don&#39;t have location access to perform this operation;           &lt;br/&gt; 502 - Data not found. Returned if target Work order is not found database;           &lt;br/&gt; 503 - Request data is empty; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidtechniciancertificate"></a>
# **WorkordersworkOrderIdTechnicianCertificate**
> void WorkordersworkOrderIdTechnicianCertificate (int workOrderId, SCServiceChannelServicesMessagingWorkordersChangeWoTechnicianCertificateRequest request)

Assign technician certificate to the WO

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkOrderIdTechnicianCertificateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workOrderId = 56;  // int | Numeric Id of the Work order to perform action with.
            var request = new SCServiceChannelServicesMessagingWorkordersChangeWoTechnicianCertificateRequest(); // SCServiceChannelServicesMessagingWorkordersChangeWoTechnicianCertificateRequest | The request to perform action with

            try
            {
                // Assign technician certificate to the WO
                apiInstance.WorkordersworkOrderIdTechnicianCertificate(workOrderId, request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkOrderIdTechnicianCertificate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkOrderIdTechnicianCertificateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Assign technician certificate to the WO
    apiInstance.WorkordersworkOrderIdTechnicianCertificateWithHttpInfo(workOrderId, request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkOrderIdTechnicianCertificateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrderId** | **int** | Numeric Id of the Work order to perform action with. |  |
| **request** | [**SCServiceChannelServicesMessagingWorkordersChangeWoTechnicianCertificateRequest**](SCServiceChannelServicesMessagingWorkordersChangeWoTechnicianCertificateRequest.md) | The request to perform action with |  |

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
| **200** | Certificatite was sucsesfully assigned. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 502 - Work order is not found;              &lt;br/&gt; 601 - Invalid Location Id;              &lt;br/&gt; 701 - Invalid trade;              &lt;br/&gt; 1301 - Request data is empty;              &lt;br/&gt; 3901 - Invalid Certificate Id; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidupdateworkorderleakinspectioninforefrigerantwasusedrefrigerantwasusedleakwasdetectedleakwasdetected"></a>
# **WorkordersworkOrderIdUpdateWorkOrderLeakInspectionInforefrigerantWasUsedrefrigerantWasUsedleakWasDetectedleakWasDetected**
> void WorkordersworkOrderIdUpdateWorkOrderLeakInspectionInforefrigerantWasUsedrefrigerantWasUsedleakWasDetectedleakWasDetected (int workOrderId, bool refrigerantWasUsed, bool leakWasDetected)

Update the leak inspection info on a work order

RTMultiLeakFlow FF must be enabled for this operation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkOrderIdUpdateWorkOrderLeakInspectionInforefrigerantWasUsedrefrigerantWasUsedleakWasDetectedleakWasDetectedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workOrderId = 56;  // int | The unique numeric identifier of the work order to update the status of refrigerant use for.
            var refrigerantWasUsed = false;  // bool | Defines if refrigerant was used on the work order. (default to false)
            var leakWasDetected = false;  // bool | Defines if leak was detected on the work order. (default to false)

            try
            {
                // Update the leak inspection info on a work order
                apiInstance.WorkordersworkOrderIdUpdateWorkOrderLeakInspectionInforefrigerantWasUsedrefrigerantWasUsedleakWasDetectedleakWasDetected(workOrderId, refrigerantWasUsed, leakWasDetected);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkOrderIdUpdateWorkOrderLeakInspectionInforefrigerantWasUsedrefrigerantWasUsedleakWasDetectedleakWasDetected: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkOrderIdUpdateWorkOrderLeakInspectionInforefrigerantWasUsedrefrigerantWasUsedleakWasDetectedleakWasDetectedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update the leak inspection info on a work order
    apiInstance.WorkordersworkOrderIdUpdateWorkOrderLeakInspectionInforefrigerantWasUsedrefrigerantWasUsedleakWasDetectedleakWasDetectedWithHttpInfo(workOrderId, refrigerantWasUsed, leakWasDetected);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkOrderIdUpdateWorkOrderLeakInspectionInforefrigerantWasUsedrefrigerantWasUsedleakWasDetectedleakWasDetectedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrderId** | **int** | The unique numeric identifier of the work order to update the status of refrigerant use for. |  |
| **refrigerantWasUsed** | **bool** | Defines if refrigerant was used on the work order. | [default to false] |
| **leakWasDetected** | **bool** | Defines if leak was detected on the work order. | [default to false] |

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
| **204** | The leak inspection info on the specified work order is updated. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              &lt;br/&gt;701 - Invalid trade |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              &lt;br/&gt;504 — API call rejected by security permissions |  -  |
| **404** | The requested resource does not exist on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidweathereventsubscriberidsubscriberid"></a>
# **WorkordersworkOrderIdWeatherEventsubscriberIdsubscriberId**
> SCServiceChannelApiModelWorkordersWeatherEventType WorkordersworkOrderIdWeatherEventsubscriberIdsubscriberId (int workOrderId, int? subscriberId = null)

Get the Weather Event associated to a work order (if set)

Retrieves the set Weather Event related to a work order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkOrderIdWeatherEventsubscriberIdsubscriberIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workOrderId = 56;  // int | The Id of the work order.
            var subscriberId = 56;  // int? | This parameter is required only for provider. (optional) 

            try
            {
                // Get the Weather Event associated to a work order (if set)
                SCServiceChannelApiModelWorkordersWeatherEventType result = apiInstance.WorkordersworkOrderIdWeatherEventsubscriberIdsubscriberId(workOrderId, subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkOrderIdWeatherEventsubscriberIdsubscriberId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkOrderIdWeatherEventsubscriberIdsubscriberIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the Weather Event associated to a work order (if set)
    ApiResponse<SCServiceChannelApiModelWorkordersWeatherEventType> response = apiInstance.WorkordersworkOrderIdWeatherEventsubscriberIdsubscriberIdWithHttpInfo(workOrderId, subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkOrderIdWeatherEventsubscriberIdsubscriberIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrderId** | **int** | The Id of the work order. |  |
| **subscriberId** | **int?** | This parameter is required only for provider. | [optional]  |

### Return type

[**SCServiceChannelApiModelWorkordersWeatherEventType**](SCServiceChannelApiModelWorkordersWeatherEventType.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderid"></a>
# **WorkordersworkorderId**
> SCServiceChannelServicesMessagingWorkordersWorkOrder WorkordersworkorderId (int workorderId)

Retrieve a Work order

A single Work order object with all its details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | Numeric Id of the Work order to perform action with.

            try
            {
                // Retrieve a Work order
                SCServiceChannelServicesMessagingWorkordersWorkOrder result = apiInstance.WorkordersworkorderId(workorderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a Work order
    ApiResponse<SCServiceChannelServicesMessagingWorkordersWorkOrder> response = apiInstance.WorkordersworkorderIdWithHttpInfo(workorderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Numeric Id of the Work order to perform action with. |  |

### Return type

[**SCServiceChannelServicesMessagingWorkordersWorkOrder**](SCServiceChannelServicesMessagingWorkordersWorkOrder.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 503 - Request data is empty; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **404** | Indicates that the requested resource does not exist on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidaddstripecharge"></a>
# **WorkordersworkorderIdAddstripecharge**
> void WorkordersworkorderIdAddstripecharge (int workorderId, SCServiceChannelServicesMessagingWorkordersAddStripeChargeRequest request)

Create Stripe charge

<para>Creates charge through Stripe with provider stripe account as destination.</para>  <para>Also increases NTE by charge amount.</para>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdAddstripechargeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | Work order id
            var request = new SCServiceChannelServicesMessagingWorkordersAddStripeChargeRequest(); // SCServiceChannelServicesMessagingWorkordersAddStripeChargeRequest | request

            try
            {
                // Create Stripe charge
                apiInstance.WorkordersworkorderIdAddstripecharge(workorderId, request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdAddstripecharge: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdAddstripechargeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Stripe charge
    apiInstance.WorkordersworkorderIdAddstripechargeWithHttpInfo(workorderId, request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdAddstripechargeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Work order id |  |
| **request** | [**SCServiceChannelServicesMessagingWorkordersAddStripeChargeRequest**](SCServiceChannelServicesMessagingWorkordersAddStripeChargeRequest.md) | request |  |

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
| **200** | Indicates that the request succeeded. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.&lt;br&gt;Error codes:&lt;br&gt;502 - WorkOrder not found;&lt;br&gt;503 - Request data is empty;WO don&#39;t have provider;WorkOrder does not belong to subscriber;Amount is not positive;&lt;br&gt;904 - WorkOrder is completed;&lt;br&gt;101 - Provider don&#39;t have Stripe account;&lt;br&gt;501 - Stripe API error |  -  |
| **401** | Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Error while processing request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidcaller"></a>
# **WorkordersworkorderIdCaller**
> SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse WorkordersworkorderIdCaller (int workorderId, SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest updateRequest)

Update Work order Caller

Updates Work order Caller. Returns Work order Id for successful request.              <br /><br />This method can only be used for users with 'WorkOrderFullEdit' permissions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdCallerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | Numeric Id of the Work order to perform action with.
            var updateRequest = new SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest(); // SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest | The update request. Work order Caller.

            try
            {
                // Update Work order Caller
                SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse result = apiInstance.WorkordersworkorderIdCaller(workorderId, updateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdCaller: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdCallerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Work order Caller
    ApiResponse<SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse> response = apiInstance.WorkordersworkorderIdCallerWithHttpInfo(workorderId, updateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdCallerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Numeric Id of the Work order to perform action with. |  |
| **updateRequest** | [**SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest**](SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest.md) | The update request. Work order Caller. |  |

### Return type

[**SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse**](SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 100 - You don&#39;t have location access to perform this operation;              &lt;br/&gt; 502 - Data not found. Returned if target Work order is not found database;              &lt;br/&gt; 503 - Request data is empty;              &lt;br/&gt; 906 - Invalid Work order Caller Name specified. Returned if Caller Name exceeds max len (100 chars) or is empty;              &lt;br/&gt; 921 - Cannot update invoiced Work order; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidcategory"></a>
# **WorkordersworkorderIdCategory**
> SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse WorkordersworkorderIdCategory (int workorderId, SCServiceChannelServicesMessagingWorkordersChangeWoCategoryRequest updateRequest)

Update the work order category

Updates the category of the specified work order (WO) with the passed value. Note that you cannot update the category of an invoiced service request.              <br />If the WO category does not have a GL code mapping with the WO trade, you will get an error message listing valid categories for this trade based on existing GL codes. You can retrieve valid categories for a specific trade by sending the [GET /categories/glcodes](https://developer.servicechannel.com/swagger/ui/index?version=3#/Categories/GETv3_categories_glcodes_locationId__locationId__trade__trade_) request.              <br />***Note:*** Only users who have permission to edit work orders can use this method.              <br />**Example Request**                                PUT /workorders/{workorderId}/category                  {                     \"Value\": \"Repair\",                     \"Actor\": \"James Smith\",                     \"Id\": 12345                  }

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | Unique numeric identifier of the work order you want to update the category for.
            var updateRequest = new SCServiceChannelServicesMessagingWorkordersChangeWoCategoryRequest(); // SCServiceChannelServicesMessagingWorkordersChangeWoCategoryRequest | Request to update the work order category.

            try
            {
                // Update the work order category
                SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse result = apiInstance.WorkordersworkorderIdCategory(workorderId, updateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update the work order category
    ApiResponse<SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse> response = apiInstance.WorkordersworkorderIdCategoryWithHttpInfo(workorderId, updateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Unique numeric identifier of the work order you want to update the category for. |  |
| **updateRequest** | [**SCServiceChannelServicesMessagingWorkordersChangeWoCategoryRequest**](SCServiceChannelServicesMessagingWorkordersChangeWoCategoryRequest.md) | Request to update the work order category. |  |

### Return type

[**SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse**](SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The category of the specified work order is updated, and the unique work order ID is returned in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              100 — User has no rights to perform this action              502 — Work order is not found              921 — Cannot update invoiced work order |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderiddescription"></a>
# **WorkordersworkorderIdDescription**
> SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse WorkordersworkorderIdDescription (int workorderId, SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest updateRequest)

Update Work order Description

Updates Work Order Description. Returns Work order Id for successful request.              <br /><br />This method can only be used for users with 'WorkOrderFullEdit' permissions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdDescriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | Numeric Id of the Work order to perform action with.
            var updateRequest = new SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest(); // SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest | The update request. Work order Description.

            try
            {
                // Update Work order Description
                SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse result = apiInstance.WorkordersworkorderIdDescription(workorderId, updateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdDescription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdDescriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Work order Description
    ApiResponse<SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse> response = apiInstance.WorkordersworkorderIdDescriptionWithHttpInfo(workorderId, updateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdDescriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Numeric Id of the Work order to perform action with. |  |
| **updateRequest** | [**SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest**](SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest.md) | The update request. Work order Description. |  |

### Return type

[**SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse**](SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 100 - You don&#39;t have location access to perform this operation;              &lt;br/&gt; 502 - Data not found. Returned if target Work order is not found database;              &lt;br/&gt; 503 - Request data is empty;              &lt;br/&gt; 902 - Invalid Work order Problem Description specified. Returned if description exceeds max len (8000 chars) or is empty;              &lt;br/&gt; 921 - Cannot update invoiced Work order; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidfeaturesfeatures0features0features1features1"></a>
# **WorkordersworkorderIdFeaturesfeatures0features0features1features1**
> SCServiceChannelServicesMessagingApplicationAccessFeatureResponse WorkordersworkorderIdFeaturesfeatures0features0features1features1 (int workorderId, List<string> features)

Checks features of Work order subscriber

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdFeaturesfeatures0features0features1features1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | Numeric Id of the Work order to perform action with.
            var features = new List<string>(); // List<string> | Features to check

            try
            {
                // Checks features of Work order subscriber
                SCServiceChannelServicesMessagingApplicationAccessFeatureResponse result = apiInstance.WorkordersworkorderIdFeaturesfeatures0features0features1features1(workorderId, features);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdFeaturesfeatures0features0features1features1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdFeaturesfeatures0features0features1features1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Checks features of Work order subscriber
    ApiResponse<SCServiceChannelServicesMessagingApplicationAccessFeatureResponse> response = apiInstance.WorkordersworkorderIdFeaturesfeatures0features0features1features1WithHttpInfo(workorderId, features);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdFeaturesfeatures0features0features1features1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Numeric Id of the Work order to perform action with. |  |
| **features** | [**List&lt;string&gt;**](string.md) | Features to check |  |

### Return type

[**SCServiceChannelServicesMessagingApplicationAccessFeatureResponse**](SCServiceChannelServicesMessagingApplicationAccessFeatureResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 503 - Request data is empty; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **502** | Indicates that the requested resource was not found on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidfeedback"></a>
# **WorkordersworkorderIdFeedback**
> void WorkordersworkorderIdFeedback (int workorderId, SCServiceChannelServicesMessagingWorkordersLeaveFeedbackRequest leaveFeedbackRequest)

Leave feedback for a work order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdFeedbackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | 
            var leaveFeedbackRequest = new SCServiceChannelServicesMessagingWorkordersLeaveFeedbackRequest(); // SCServiceChannelServicesMessagingWorkordersLeaveFeedbackRequest | 

            try
            {
                // Leave feedback for a work order
                apiInstance.WorkordersworkorderIdFeedback(workorderId, leaveFeedbackRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdFeedback: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdFeedbackWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Leave feedback for a work order
    apiInstance.WorkordersworkorderIdFeedbackWithHttpInfo(workorderId, leaveFeedbackRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdFeedbackWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** |  |  |
| **leaveFeedbackRequest** | [**SCServiceChannelServicesMessagingWorkordersLeaveFeedbackRequest**](SCServiceChannelServicesMessagingWorkordersLeaveFeedbackRequest.md) |  |  |

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
| **200** | Indicates that the request succeeded. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.&lt;br/&gt;Error codes:&lt;br/&gt;           935 - Invalid Star Score;&lt;br&gt;           936 - Work Order was rated another user |  -  |
| **401** | Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidfollowers"></a>
# **WorkordersworkorderIdFollowers**
> void WorkordersworkorderIdFollowers (int workorderId, SCServiceChannelServicesMessagingWorkordersAddFollowersRequest request)

Add Followers to Work order

Add Followers to Work order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdFollowersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | Numeric Id of the Work order to perform action with.
            var request = new SCServiceChannelServicesMessagingWorkordersAddFollowersRequest(); // SCServiceChannelServicesMessagingWorkordersAddFollowersRequest | The request model to perform action with.

            try
            {
                // Add Followers to Work order
                apiInstance.WorkordersworkorderIdFollowers(workorderId, request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdFollowers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdFollowersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Followers to Work order
    apiInstance.WorkordersworkorderIdFollowersWithHttpInfo(workorderId, request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdFollowersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Numeric Id of the Work order to perform action with. |  |
| **request** | [**SCServiceChannelServicesMessagingWorkordersAddFollowersRequest**](SCServiceChannelServicesMessagingWorkordersAddFollowersRequest.md) | The request model to perform action with. |  |

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
| **201** | Created indicates that the request resulted in a new resource created before the response was sent. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt;503 - Request data is empty;              &lt;br/&gt;There is no followers in request;              &lt;br/&gt;Empty tracking number (workorder Id); |  -  |
| **404** | Indicates that the requested resource does not exist on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidfollowersemailemail"></a>
# **WorkordersworkorderIdFollowersemailemail**
> void WorkordersworkorderIdFollowersemailemail (int workorderId, string email)

Remove Follower from Work order

Remove Follower from Work order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdFollowersemailemailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | Numeric Id of the Work order to perform action with.
            var email = "email_example";  // string | The follower email address.

            try
            {
                // Remove Follower from Work order
                apiInstance.WorkordersworkorderIdFollowersemailemail(workorderId, email);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdFollowersemailemail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdFollowersemailemailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Follower from Work order
    apiInstance.WorkordersworkorderIdFollowersemailemailWithHttpInfo(workorderId, email);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdFollowersemailemailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Numeric Id of the Work order to perform action with. |  |
| **email** | **string** | The follower email address. |  |

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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt;503 - Request data is empty;              &lt;br/&gt;There is no followers in request;&lt;br/&gt;Empty tracking number (workorder Id); |  -  |
| **404** | Indicates that the requested resource does not exist on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidgpsradius"></a>
# **WorkordersworkorderIdGPSRadius**
> SCServiceChannelServicesMessagingWorkordersGetGPSRadiusResponse WorkordersworkorderIdGPSRadius (int workorderId)

Get GPS Radius for a WO

Get GPS Radius for a WO

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdGPSRadiusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | Numeric Id of the Work order to perform action with.

            try
            {
                // Get GPS Radius for a WO
                SCServiceChannelServicesMessagingWorkordersGetGPSRadiusResponse result = apiInstance.WorkordersworkorderIdGPSRadius(workorderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdGPSRadius: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdGPSRadiusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get GPS Radius for a WO
    ApiResponse<SCServiceChannelServicesMessagingWorkordersGetGPSRadiusResponse> response = apiInstance.WorkordersworkorderIdGPSRadiusWithHttpInfo(workorderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdGPSRadiusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Numeric Id of the Work order to perform action with. |  |

### Return type

[**SCServiceChannelServicesMessagingWorkordersGetGPSRadiusResponse**](SCServiceChannelServicesMessagingWorkordersGetGPSRadiusResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 502 - WorkOrder not found;                          &lt;br/&gt; 917 - Invalid Tracking Number; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidissuechoicesubscriberidsubscriberidlocationidlocationid"></a>
# **WorkordersworkorderIdIssueChoicesubscriberIdsubscriberIdlocationIdlocationId**
> void WorkordersworkorderIdIssueChoicesubscriberIdsubscriberIdlocationIdlocationId (int workorderId, int subscriberId, SCServiceChannelServicesMessagingWorkordersIssueChoiceRequest issueChoice, int? locationId = null)

Update issue choice on WO

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdIssueChoicesubscriberIdsubscriberIdlocationIdlocationIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | Numeric Id of the Work order to perform action with.
            var subscriberId = 56;  // int | The subscriber Id to use (if logged in as a provider).
            var issueChoice = new SCServiceChannelServicesMessagingWorkordersIssueChoiceRequest(); // SCServiceChannelServicesMessagingWorkordersIssueChoiceRequest | The request to perform action with.
            var locationId = 56;  // int? | UID of location (optional) 

            try
            {
                // Update issue choice on WO
                apiInstance.WorkordersworkorderIdIssueChoicesubscriberIdsubscriberIdlocationIdlocationId(workorderId, subscriberId, issueChoice, locationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdIssueChoicesubscriberIdsubscriberIdlocationIdlocationId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdIssueChoicesubscriberIdsubscriberIdlocationIdlocationIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update issue choice on WO
    apiInstance.WorkordersworkorderIdIssueChoicesubscriberIdsubscriberIdlocationIdlocationIdWithHttpInfo(workorderId, subscriberId, issueChoice, locationId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdIssueChoicesubscriberIdsubscriberIdlocationIdlocationIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Numeric Id of the Work order to perform action with. |  |
| **subscriberId** | **int** | The subscriber Id to use (if logged in as a provider). |  |
| **issueChoice** | [**SCServiceChannelServicesMessagingWorkordersIssueChoiceRequest**](SCServiceChannelServicesMessagingWorkordersIssueChoiceRequest.md) | The request to perform action with. |  |
| **locationId** | **int?** | UID of location | [optional]  |

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
| **200** | Indicates that the request succeeded. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.&lt;br/&gt;Error codes:&lt;br/&gt;           503 - Validation fails;&lt;br&gt;           1000 - Invalid setupId(dashboard) for current user; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidlabel"></a>
# **WorkordersworkorderIdLabel**
> List&lt;SCServiceChannelServicesMessagingWorkordersGetStatusResponse&gt; WorkordersworkorderIdLabel (int workorderId, SCServiceChannelServicesMessagingWorkordersWorkOrderLabelRequest workOrderLabelRequest)

Update work order label

Update work order label.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdLabelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | Work order id
            var workOrderLabelRequest = new SCServiceChannelServicesMessagingWorkordersWorkOrderLabelRequest(); // SCServiceChannelServicesMessagingWorkordersWorkOrderLabelRequest | Model for add/update label to work order

            try
            {
                // Update work order label
                List<SCServiceChannelServicesMessagingWorkordersGetStatusResponse> result = apiInstance.WorkordersworkorderIdLabel(workorderId, workOrderLabelRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdLabel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdLabelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update work order label
    ApiResponse<List<SCServiceChannelServicesMessagingWorkordersGetStatusResponse>> response = apiInstance.WorkordersworkorderIdLabelWithHttpInfo(workorderId, workOrderLabelRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdLabelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Work order id |  |
| **workOrderLabelRequest** | [**SCServiceChannelServicesMessagingWorkordersWorkOrderLabelRequest**](SCServiceChannelServicesMessagingWorkordersWorkOrderLabelRequest.md) | Model for add/update label to work order |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingWorkordersGetStatusResponse&gt;**](SCServiceChannelServicesMessagingWorkordersGetStatusResponse.md)

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

<a id="workordersworkorderidlabel_0"></a>
# **WorkordersworkorderIdLabel_0**
> List&lt;SCServiceChannelServicesMessagingWorkordersGetStatusResponse&gt; WorkordersworkorderIdLabel_0 (int workorderId, SCServiceChannelServicesMessagingWorkordersWorkOrderLabelRequest workOrderLabelRequest)

Delete work order label

Delete work order label.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdLabel_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | Work order id
            var workOrderLabelRequest = new SCServiceChannelServicesMessagingWorkordersWorkOrderLabelRequest(); // SCServiceChannelServicesMessagingWorkordersWorkOrderLabelRequest | Model for delete label from work order

            try
            {
                // Delete work order label
                List<SCServiceChannelServicesMessagingWorkordersGetStatusResponse> result = apiInstance.WorkordersworkorderIdLabel_0(workorderId, workOrderLabelRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdLabel_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdLabel_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete work order label
    ApiResponse<List<SCServiceChannelServicesMessagingWorkordersGetStatusResponse>> response = apiInstance.WorkordersworkorderIdLabel_0WithHttpInfo(workorderId, workOrderLabelRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdLabel_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Work order id |  |
| **workOrderLabelRequest** | [**SCServiceChannelServicesMessagingWorkordersWorkOrderLabelRequest**](SCServiceChannelServicesMessagingWorkordersWorkOrderLabelRequest.md) | Model for delete label from work order |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingWorkordersGetStatusResponse&gt;**](SCServiceChannelServicesMessagingWorkordersGetStatusResponse.md)

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

<a id="workordersworkorderidlinkworkorderidtolinkworkorderidtolink"></a>
# **WorkordersworkorderIdLinkworkorderIdToLinkworkorderIdToLink**
> void WorkordersworkorderIdLinkworkorderIdToLinkworkorderIdToLink (int workorderId, SCServiceChannelServicesMessagingWorkordersLinkWorkordersRequest request, int? workorderIdToLink = null)

Creates link between two Work Orders

<para>Current Work Order marked as a parent, linking Work Order marked as follow Up.</para>  <para>If you set 'workorderIdToLink' parameter then 'WorkorderIds' parameter of requested body will be ignored.</para>  <br />  <br />Available for provider and subscriber usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdLinkworkorderIdToLinkworkorderIdToLinkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | Parent Work Order id
            var request = new SCServiceChannelServicesMessagingWorkordersLinkWorkordersRequest(); // SCServiceChannelServicesMessagingWorkordersLinkWorkordersRequest | Link Workorders Request
            var workorderIdToLink = 56;  // int? | Work Order Id that links to parent. Optional. (optional) 

            try
            {
                // Creates link between two Work Orders
                apiInstance.WorkordersworkorderIdLinkworkorderIdToLinkworkorderIdToLink(workorderId, request, workorderIdToLink);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdLinkworkorderIdToLinkworkorderIdToLink: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdLinkworkorderIdToLinkworkorderIdToLinkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates link between two Work Orders
    apiInstance.WorkordersworkorderIdLinkworkorderIdToLinkworkorderIdToLinkWithHttpInfo(workorderId, request, workorderIdToLink);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdLinkworkorderIdToLinkworkorderIdToLinkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Parent Work Order id |  |
| **request** | [**SCServiceChannelServicesMessagingWorkordersLinkWorkordersRequest**](SCServiceChannelServicesMessagingWorkordersLinkWorkordersRequest.md) | Link Workorders Request |  |
| **workorderIdToLink** | **int?** | Work Order Id that links to parent. Optional. | [optional]  |

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
| **204** | Indicates that the request succeeded |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.&lt;br/&gt;Error codes:&lt;br/&gt;           917 - Wrong Parent Work Order Id;&lt;br&gt;           932 - Wrong Linked Work Order Id;&lt;br&gt;          601 - Location doesn&#39;t match |  -  |
| **401** | Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidmarkrefrigerantuserefrigerantwasusedrefrigerantwasusedactoractor"></a>
# **WorkordersworkorderIdMarkRefrigerantUserefrigerantWasUsedrefrigerantWasUsedactoractor**
> void WorkordersworkorderIdMarkRefrigerantUserefrigerantWasUsedrefrigerantWasUsedactoractor (int workorderId, bool? refrigerantWasUsed = null, string? actor = null)

Update the status of refrigerant use on a work order

Updates the status of refrigerant use on the specified work order.              <br />Set the `refrigerantWasUsed` parameter to either `true` or `false` to mark whether refrigerant was used on the service request or not.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdMarkRefrigerantUserefrigerantWasUsedrefrigerantWasUsedactoractorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | The unique numeric identifier of the work order to update the status of refrigerant use for.
            var refrigerantWasUsed = false;  // bool? | Defines if refrigerant was used on the work order. (optional)  (default to false)
            var actor = "actor_example";  // string? | Name of the person on whose behalf you are performing the action. (optional) 

            try
            {
                // Update the status of refrigerant use on a work order
                apiInstance.WorkordersworkorderIdMarkRefrigerantUserefrigerantWasUsedrefrigerantWasUsedactoractor(workorderId, refrigerantWasUsed, actor);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdMarkRefrigerantUserefrigerantWasUsedrefrigerantWasUsedactoractor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdMarkRefrigerantUserefrigerantWasUsedrefrigerantWasUsedactoractorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update the status of refrigerant use on a work order
    apiInstance.WorkordersworkorderIdMarkRefrigerantUserefrigerantWasUsedrefrigerantWasUsedactoractorWithHttpInfo(workorderId, refrigerantWasUsed, actor);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdMarkRefrigerantUserefrigerantWasUsedrefrigerantWasUsedactoractorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | The unique numeric identifier of the work order to update the status of refrigerant use for. |  |
| **refrigerantWasUsed** | **bool?** | Defines if refrigerant was used on the work order. | [optional] [default to false] |
| **actor** | **string?** | Name of the person on whose behalf you are performing the action. | [optional]  |

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
| **204** | The status of refrigerant use on the specified work order is updated. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc. |  -  |
| **401** | The request is not authorized.&lt;br/&gt;&lt;br/&gt;Error codes:&lt;br/&gt;504 — API call rejected by security permissions |  -  |
| **404** | The requested resource does not exist on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidnte"></a>
# **WorkordersworkorderIdNte**
> SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse WorkordersworkorderIdNte (int workorderId, SCServiceChannelServicesMessagingWorkordersChangeWoNteRequest updateRequest)

Update Work order NTE

Updates Work Order NTE. Returns Work order Id for successful request.              <br /><br />This method can only be used for users with 'WorkOrderFullEdit' permissions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdNteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | Numeric Id of the Work order to perform action with.
            var updateRequest = new SCServiceChannelServicesMessagingWorkordersChangeWoNteRequest(); // SCServiceChannelServicesMessagingWorkordersChangeWoNteRequest | The update request. Work order NTE.

            try
            {
                // Update Work order NTE
                SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse result = apiInstance.WorkordersworkorderIdNte(workorderId, updateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdNte: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdNteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Work order NTE
    ApiResponse<SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse> response = apiInstance.WorkordersworkorderIdNteWithHttpInfo(workorderId, updateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdNteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Numeric Id of the Work order to perform action with. |  |
| **updateRequest** | [**SCServiceChannelServicesMessagingWorkordersChangeWoNteRequest**](SCServiceChannelServicesMessagingWorkordersChangeWoNteRequest.md) | The update request. Work order NTE. |  |

### Return type

[**SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse**](SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.           &lt;br/&gt;Error codes:           &lt;br/&gt; 100 - You don&#39;t have location access to perform this operation;           &lt;br/&gt; 502 - Data not found. Returned if target Work order is not found database;           &lt;br/&gt; 503 - Request data is empty;           &lt;br/&gt; 905 - Invalid Work order NTE specified. Returned if nte exceeds user limit or its value is not a number;           &lt;br/&gt; 921 - Cannot update invoiced Work order;           &lt;br/&gt; 931 - NTE cannot be adjusted, please use subtotal and tax; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidponumber"></a>
# **WorkordersworkorderIdPonumber**
> SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse WorkordersworkorderIdPonumber (int workorderId, SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest updateRequest)

Update Work order Purchase Number

Updates Work order Purchase Number. Returns Work order Id for successful request.              <br /><br />This method can only be used for users with 'WorkOrderFullEdit' permissions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdPonumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | Numeric Id of the Work order to perform action with.
            var updateRequest = new SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest(); // SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest | The update request. Work order Purchase Number.

            try
            {
                // Update Work order Purchase Number
                SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse result = apiInstance.WorkordersworkorderIdPonumber(workorderId, updateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdPonumber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdPonumberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Work order Purchase Number
    ApiResponse<SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse> response = apiInstance.WorkordersworkorderIdPonumberWithHttpInfo(workorderId, updateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdPonumberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Numeric Id of the Work order to perform action with. |  |
| **updateRequest** | [**SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest**](SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest.md) | The update request. Work order Purchase Number. |  |

### Return type

[**SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse**](SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 100 - You don&#39;t have location access to perform this operation;              &lt;br/&gt; 502 - Data not found. Returned if target Work order is not found database;              &lt;br/&gt; 503 - Request data is empty;              &lt;br/&gt; 920 - Invalid Work order purchase number specified. Returned if duplicate PO number is found for this subscriber or if value exceeds max len (20 chars);              &lt;br/&gt; 921 - Cannot update invoiced Work order; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidpriority"></a>
# **WorkordersworkorderIdPriority**
> SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse WorkordersworkorderIdPriority (int workorderId, SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest updateRequest)

Update Work order Priority

Updates Work Order priority. Returns Work order Id for successful request.              <br /><br />This method can only be used for users with 'WorkOrderFullEdit' permissions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdPriorityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | Numeric Id of the Work order to perform action with.
            var updateRequest = new SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest(); // SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest | The update request. Work order Priority.

            try
            {
                // Update Work order Priority
                SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse result = apiInstance.WorkordersworkorderIdPriority(workorderId, updateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdPriority: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdPriorityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Work order Priority
    ApiResponse<SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse> response = apiInstance.WorkordersworkorderIdPriorityWithHttpInfo(workorderId, updateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdPriorityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Numeric Id of the Work order to perform action with. |  |
| **updateRequest** | [**SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest**](SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest.md) | The update request. Work order Priority. |  |

### Return type

[**SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse**](SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 100 - You don&#39;t have location access to perform this operation;              &lt;br/&gt; 502 - Data not found. Returned if target Work order is not found database;              &lt;br/&gt; 503 - Request data is empty;              &lt;br/&gt; 913 - Priority isn&#39;t found in user settings;              &lt;br/&gt; Priority length cannot be longer then 100 or shorter then 1 characters;              &lt;br/&gt; 921 - Cannot update invoiced Work order; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidprojectid"></a>
# **WorkordersworkorderIdProjectid**
> SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse WorkordersworkorderIdProjectid (int workorderId, SCServiceChannelServicesMessagingWorkordersChangeWoProjectIdRequest updateRequest)

Update ProjectId

Updates ProjectId.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdProjectidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | Numeric Id of the Work order to perform action with.
            var updateRequest = new SCServiceChannelServicesMessagingWorkordersChangeWoProjectIdRequest(); // SCServiceChannelServicesMessagingWorkordersChangeWoProjectIdRequest | The update request. ProjectId.

            try
            {
                // Update ProjectId
                SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse result = apiInstance.WorkordersworkorderIdProjectid(workorderId, updateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdProjectid: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdProjectidWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update ProjectId
    ApiResponse<SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse> response = apiInstance.WorkordersworkorderIdProjectidWithHttpInfo(workorderId, updateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdProjectidWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Numeric Id of the Work order to perform action with. |  |
| **updateRequest** | [**SCServiceChannelServicesMessagingWorkordersChangeWoProjectIdRequest**](SCServiceChannelServicesMessagingWorkordersChangeWoProjectIdRequest.md) | The update request. ProjectId. |  |

### Return type

[**SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse**](SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 100 - You don&#39;t have location access to perform this operation;              &lt;br/&gt; 502 - Data not found. Returned if target Work order is not found database;              &lt;br/&gt; 503 - Request data is empty;              &lt;br/&gt; 923 - Invalid Work order number specified. Returned if duplicate number is found for this provider or if value exceeds max len (20 chars);              &lt;br/&gt; 921 - Cannot update invoiced Work order; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidprojectidunlink"></a>
# **WorkordersworkorderIdProjectidUnlink**
> SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse WorkordersworkorderIdProjectidUnlink (int workorderId)

Unlink ProjectId

Unlink ProjectId.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdProjectidUnlinkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | Numeric Id of the Work order to perform action with.

            try
            {
                // Unlink ProjectId
                SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse result = apiInstance.WorkordersworkorderIdProjectidUnlink(workorderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdProjectidUnlink: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdProjectidUnlinkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unlink ProjectId
    ApiResponse<SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse> response = apiInstance.WorkordersworkorderIdProjectidUnlinkWithHttpInfo(workorderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdProjectidUnlinkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Numeric Id of the Work order to perform action with. |  |

### Return type

[**SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse**](SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 100 - You don&#39;t have location access to perform this operation;              &lt;br/&gt; 502 - Data not found. Returned if target Work order is not found database;              &lt;br/&gt; 503 - Request data is empty;              &lt;br/&gt; 923 - Invalid Work order number specified. Returned if duplicate number is found for this provider or if value exceeds max len (20 chars);              &lt;br/&gt; 921 - Cannot update invoiced Work order; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidreassign"></a>
# **WorkordersworkorderIdReassign**
> SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse WorkordersworkorderIdReassign (int workorderId, SCServiceChannelServicesMessagingWorkordersReassignWORequest request)

Reassign Work Order

Reassign Work Order to another provider. Returns Work order Id for successful request.              <br /><br />Available for provider and subscriber usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdReassignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | Numeric Id of the Work order to perform action with.
            var request = new SCServiceChannelServicesMessagingWorkordersReassignWORequest(); // SCServiceChannelServicesMessagingWorkordersReassignWORequest | The request to perform action with.

            try
            {
                // Reassign Work Order
                SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse result = apiInstance.WorkordersworkorderIdReassign(workorderId, request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdReassign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdReassignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reassign Work Order
    ApiResponse<SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse> response = apiInstance.WorkordersworkorderIdReassignWithHttpInfo(workorderId, request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdReassignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Numeric Id of the Work order to perform action with. |  |
| **request** | [**SCServiceChannelServicesMessagingWorkordersReassignWORequest**](SCServiceChannelServicesMessagingWorkordersReassignWORequest.md) | The request to perform action with. |  |

### Return type

[**SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse**](SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 1301 - Request data is empty;              &lt;br/&gt; 101 - Invalid Provider Id;              &lt;br/&gt;Provider not found for selected trade and location;              &lt;br/&gt; 503 - Invalid Work order reassignment reason;              &lt;br/&gt;Request data is empty;              &lt;br/&gt;Required provider id not found;&lt;br&gt;Work order could not be reassigned. Only &#39;OPEN&#39; and &#39;IN PROGRESS&#39; statuses allowed;              &lt;br/&gt;Provider or trade should be changed;              &lt;br/&gt; 905 - Invalid &#39;Nte&#39; value;              &lt;br/&gt;Nte value exceeds user limit;              &lt;br/&gt; 921 - Cannot update invoiced Work order; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **403** | Indicates that the server refuses to fulfill the request.              &lt;br/&gt; Error codes:              &lt;br/&gt; 804 - API call rejected by lack of provider permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidrefrigerantusestatus"></a>
# **WorkordersworkorderIdRefrigerantUseStatus**
> bool WorkordersworkorderIdRefrigerantUseStatus (int workorderId)

Retrieve the status of refrigerant use on a work order

Returns the status of refrigerant use on the specified work order:               • `null`: There is no information on the use of refrigerant.               • `true`: Refrigerant was used upon execution of the service request.               • `false`: Refrigerant wasn't used when performing work on the service request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdRefrigerantUseStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | The unique numeric identifier of the work order to return the status of refrigerant use for.

            try
            {
                // Retrieve the status of refrigerant use on a work order
                bool result = apiInstance.WorkordersworkorderIdRefrigerantUseStatus(workorderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdRefrigerantUseStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdRefrigerantUseStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve the status of refrigerant use on a work order
    ApiResponse<bool> response = apiInstance.WorkordersworkorderIdRefrigerantUseStatusWithHttpInfo(workorderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdRefrigerantUseStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | The unique numeric identifier of the work order to return the status of refrigerant use for. |  |

### Return type

**bool**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The status of refrigerant use on the specified work order is in the response. |  -  |
| **401** | The request is not authorized.&lt;br/&gt;&lt;br/&gt;Error codes:&lt;br/&gt;504 — API call rejected by security permissions |  -  |
| **404** | The requested resource does not exist on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidresolution"></a>
# **WorkordersworkorderIdResolution**
> SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse WorkordersworkorderIdResolution (int workorderId, SCServiceChannelServicesMessagingWorkordersWorkOrderResolutionRequest request)

Add Work order Resolution

Adds Resolution to Work order. Returns Resolution Id for successful request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdResolutionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | Numeric Id of the Work order to perform action with.
            var request = new SCServiceChannelServicesMessagingWorkordersWorkOrderResolutionRequest(); // SCServiceChannelServicesMessagingWorkordersWorkOrderResolutionRequest | The update request. Work order Resolution.

            try
            {
                // Add Work order Resolution
                SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse result = apiInstance.WorkordersworkorderIdResolution(workorderId, request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdResolution: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdResolutionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Work order Resolution
    ApiResponse<SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse> response = apiInstance.WorkordersworkorderIdResolutionWithHttpInfo(workorderId, request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdResolutionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Numeric Id of the Work order to perform action with. |  |
| **request** | [**SCServiceChannelServicesMessagingWorkordersWorkOrderResolutionRequest**](SCServiceChannelServicesMessagingWorkordersWorkOrderResolutionRequest.md) | The update request. Work order Resolution. |  |

### Return type

[**SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse**](SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 100 - User has no permissions to perform this action;              &lt;br/&gt; 502 - Work order is not found;              &lt;br/&gt; 503 - Request data is empty;              &lt;br/&gt; 904 - Work Order is in status that not allow to perform this action;              &lt;br/&gt; 933 - Workorder is on hold, no actions allowed; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidscheduledatereschedulereasoncodereschedulereasoncode"></a>
# **WorkordersworkorderIdScheduledaterescheduleReasonCoderescheduleReasonCode**
> SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse WorkordersworkorderIdScheduledaterescheduleReasonCoderescheduleReasonCode (int workorderId, SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest updateRequest, int? rescheduleReasonCode = null)

Update Work order Scheduled Date

Updates Work Order Scheduled Date. Returns Work order Id for successful request.              <br /><br />Available for provider and subscriber usage.              This method can only be used for users with 'WorkOrderScheduledDateChange' permissions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdScheduledaterescheduleReasonCoderescheduleReasonCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | Numeric Id of the Work order to perform action with.
            var updateRequest = new SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest(); // SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest | The update request. Work order Scheduled Date.
            var rescheduleReasonCode = 56;  // int? | Numeric reschedule reason code. Optional. (optional) 

            try
            {
                // Update Work order Scheduled Date
                SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse result = apiInstance.WorkordersworkorderIdScheduledaterescheduleReasonCoderescheduleReasonCode(workorderId, updateRequest, rescheduleReasonCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdScheduledaterescheduleReasonCoderescheduleReasonCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdScheduledaterescheduleReasonCoderescheduleReasonCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Work order Scheduled Date
    ApiResponse<SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse> response = apiInstance.WorkordersworkorderIdScheduledaterescheduleReasonCoderescheduleReasonCodeWithHttpInfo(workorderId, updateRequest, rescheduleReasonCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdScheduledaterescheduleReasonCoderescheduleReasonCodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Numeric Id of the Work order to perform action with. |  |
| **updateRequest** | [**SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest**](SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest.md) | The update request. Work order Scheduled Date. |  |
| **rescheduleReasonCode** | **int?** | Numeric reschedule reason code. Optional. | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse**](SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 100 - You don&#39;t have location access to perform this operation;              &lt;br/&gt; 502 - Data not found. Returned if target Work order is not found database;              &lt;br/&gt; 503 - Request data is empty;              &lt;br/&gt; 908 - Invalid Work order scheduled date specified. Returned if invalid date format was specified,              scheduled date is smaller then Work order CallDate or bigger then Work order ExpirationDate;              &lt;br/&gt; 921 - Cannot update invoiced Work order; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidservicenowid"></a>
# **WorkordersworkorderIdServicenowid**
> SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse WorkordersworkorderIdServicenowid (int workorderId, SCServiceChannelServicesMessagingWorkordersWorkOrderServiceNowIdRequest workOrderServiceNowIdRequest)

Update work order servicenowid

Update work order servicenowid.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdServicenowidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | Work order id
            var workOrderServiceNowIdRequest = new SCServiceChannelServicesMessagingWorkordersWorkOrderServiceNowIdRequest(); // SCServiceChannelServicesMessagingWorkordersWorkOrderServiceNowIdRequest | Model for add/update label to work order

            try
            {
                // Update work order servicenowid
                SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse result = apiInstance.WorkordersworkorderIdServicenowid(workorderId, workOrderServiceNowIdRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdServicenowid: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdServicenowidWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update work order servicenowid
    ApiResponse<SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse> response = apiInstance.WorkordersworkorderIdServicenowidWithHttpInfo(workorderId, workOrderServiceNowIdRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdServicenowidWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Work order id |  |
| **workOrderServiceNowIdRequest** | [**SCServiceChannelServicesMessagingWorkordersWorkOrderServiceNowIdRequest**](SCServiceChannelServicesMessagingWorkordersWorkOrderServiceNowIdRequest.md) | Model for add/update label to work order |  |

### Return type

[**SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse**](SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse.md)

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
| **403** | You are not authorized to request this resource, or the resource is unavailable for some reason.              &lt;br/&gt;Error codes:               804 — User has no permissions to perform this action. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidsetmoenumbermoenumbermoenumber"></a>
# **WorkordersworkorderIdSetMoeNumbermoeNumbermoeNumber**
> void WorkordersworkorderIdSetMoeNumbermoeNumbermoeNumber (int workorderId, string moeNumber)

Mark if refrigerant was used

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdSetMoeNumbermoeNumbermoeNumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | Work Order id
            var moeNumber = "moeNumber_example";  // string | MOE Number

            try
            {
                // Mark if refrigerant was used
                apiInstance.WorkordersworkorderIdSetMoeNumbermoeNumbermoeNumber(workorderId, moeNumber);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdSetMoeNumbermoeNumbermoeNumber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdSetMoeNumbermoeNumbermoeNumberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Mark if refrigerant was used
    apiInstance.WorkordersworkorderIdSetMoeNumbermoeNumbermoeNumberWithHttpInfo(workorderId, moeNumber);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdSetMoeNumbermoeNumbermoeNumberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Work Order id |  |
| **moeNumber** | **string** | MOE Number |  |

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
| **200** | Indicates that the request succeeded |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br&gt; 504 - API call rejected by security permissions; |  -  |
| **404** | Indicates that the requested resource does not exist on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidstatus"></a>
# **WorkordersworkorderIdStatus**
> SCServiceChannelServicesMessagingWorkordersChangeWorkOrderStatusResponse WorkordersworkorderIdStatus (int workorderId, SCServiceChannelServicesMessagingWorkordersChangeWoStatusRequestExt updateRequestExt)

Update a Work order Status

Updates Work Order status with optional Note. Returns Work order Id for successful request.              <br /><br />This method can only be used for users with 'WorkOrderStatusChange' permissions.              Available for provider and subscriber usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | Numeric Id of the Work order to perform action with.
            var updateRequestExt = new SCServiceChannelServicesMessagingWorkordersChangeWoStatusRequestExt(); // SCServiceChannelServicesMessagingWorkordersChangeWoStatusRequestExt | The update request. Work order Status.

            try
            {
                // Update a Work order Status
                SCServiceChannelServicesMessagingWorkordersChangeWorkOrderStatusResponse result = apiInstance.WorkordersworkorderIdStatus(workorderId, updateRequestExt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a Work order Status
    ApiResponse<SCServiceChannelServicesMessagingWorkordersChangeWorkOrderStatusResponse> response = apiInstance.WorkordersworkorderIdStatusWithHttpInfo(workorderId, updateRequestExt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Numeric Id of the Work order to perform action with. |  |
| **updateRequestExt** | [**SCServiceChannelServicesMessagingWorkordersChangeWoStatusRequestExt**](SCServiceChannelServicesMessagingWorkordersChangeWoStatusRequestExt.md) | The update request. Work order Status. |  |

### Return type

[**SCServiceChannelServicesMessagingWorkordersChangeWorkOrderStatusResponse**](SCServiceChannelServicesMessagingWorkordersChangeWorkOrderStatusResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 100 - You don&#39;t have location access to perform this operation;              &lt;br/&gt; User has no permissions to perform this action;              &lt;br/&gt; 502 - WorkOrder not found;              &lt;br/&gt; 503 - Request data is empty; User data not found;              &lt;br/&gt; 904 - Invalid WorkOrder status;              &lt;br/&gt; User has no permission to set selected status;              &lt;br/&gt; 921 - Cannot update invoiced Work order;              &lt;br/&gt; 9001 - Decline reason id is required;              &lt;br/&gt; 9002 - This decline reason doesn&#39;t allow custom text |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidstatusessubscriberidsubscriberidtradeidtradeid"></a>
# **WorkordersworkorderIdStatusessubscriberIdsubscriberIdtradeIdtradeId**
> List&lt;SCServiceChannelServicesMessagingWorkordersGetStatusResponse&gt; WorkordersworkorderIdStatusessubscriberIdsubscriberIdtradeIdtradeId (int workorderId, int? subscriberId = null, int? tradeId = null)

Statuses Collection that relates to the state of work order

Retrieves list of available Work order statuses that are related to current work order state.              Id value can be used instead of primary status name in Update Status method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdStatusessubscriberIdsubscriberIdtradeIdtradeIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | Numeric Id of the Work order to perform action with.
            var subscriberId = 56;  // int? | This parameter is required only for provider. (optional) 
            var tradeId = 56;  // int? | Optional, if LimitStatusesByTrade FF is on (optional) 

            try
            {
                // Statuses Collection that relates to the state of work order
                List<SCServiceChannelServicesMessagingWorkordersGetStatusResponse> result = apiInstance.WorkordersworkorderIdStatusessubscriberIdsubscriberIdtradeIdtradeId(workorderId, subscriberId, tradeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdStatusessubscriberIdsubscriberIdtradeIdtradeId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdStatusessubscriberIdsubscriberIdtradeIdtradeIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Statuses Collection that relates to the state of work order
    ApiResponse<List<SCServiceChannelServicesMessagingWorkordersGetStatusResponse>> response = apiInstance.WorkordersworkorderIdStatusessubscriberIdsubscriberIdtradeIdtradeIdWithHttpInfo(workorderId, subscriberId, tradeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdStatusessubscriberIdsubscriberIdtradeIdtradeIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Numeric Id of the Work order to perform action with. |  |
| **subscriberId** | **int?** | This parameter is required only for provider. | [optional]  |
| **tradeId** | **int?** | Optional, if LimitStatusesByTrade FF is on | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingWorkordersGetStatusResponse&gt;**](SCServiceChannelServicesMessagingWorkordersGetStatusResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidtechniciansassigned"></a>
# **WorkordersworkorderIdTechniciansAssigned**
> void WorkordersworkorderIdTechniciansAssigned (int workorderId)

Retrieve list of technicians assigned to the specified work order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdTechniciansAssignedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | 

            try
            {
                // Retrieve list of technicians assigned to the specified work order
                apiInstance.WorkordersworkorderIdTechniciansAssigned(workorderId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdTechniciansAssigned: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdTechniciansAssignedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve list of technicians assigned to the specified work order
    apiInstance.WorkordersworkorderIdTechniciansAssignedWithHttpInfo(workorderId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdTechniciansAssignedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** |  |  |

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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **401** | Indicates that the requested resource requires authentication.                                                       &lt;br/&gt;Error codes:                                                       &lt;br/&gt;504 - API call rejected by security permissions; |  -  |
| **403** | Indicates that the server refuses to fulfill the request.                                                       &lt;br/&gt;Error codes:                                                       &lt;br/&gt;504 - Work order doesn&#39;t belong to the current user |  -  |
| **404** | Not Found - the requested resource could not be found but may be available in the future.                                                           &lt;br/&gt;Error codes:                                                           &lt;br/&gt;502 - Work order is not found; |  -  |
| **500** | Indicates that a generic error has occurred on the server.           &lt;br/&gt;Error codes:           &lt;br/&gt;501 - Timeout expired. The timeout period elapsed prior to completion of the operation or the server is not responding. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidtrade"></a>
# **WorkordersworkorderIdTrade**
> SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse WorkordersworkorderIdTrade (int workorderId, SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest updateRequest)

Change Work order Trade

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdTradeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | 
            var updateRequest = new SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest(); // SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest | 

            try
            {
                // Change Work order Trade
                SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse result = apiInstance.WorkordersworkorderIdTrade(workorderId, updateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdTrade: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdTradeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change Work order Trade
    ApiResponse<SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse> response = apiInstance.WorkordersworkorderIdTradeWithHttpInfo(workorderId, updateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdTradeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** |  |  |
| **updateRequest** | [**SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest**](SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest.md) |  |  |

### Return type

[**SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse**](SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 100 - You don&#39;t have location access to perform this operation;              &lt;br/&gt; 502 - Data not found. Returned if target Work order is not found database;              &lt;br/&gt; 503 - Request data is empty;              &lt;br/&gt; 921 - Cannot update invoiced Work order;              &lt;br/&gt; 934 - Invalid Work order Trade specified. Returned if trade exceeds max len (50 chars) or is empty |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderiduniversalcheckin"></a>
# **WorkordersworkorderIdUniversalCheckIn**
> SCServiceChannelServicesMessagingCheckInOutCheckInOutResponse WorkordersworkorderIdUniversalCheckIn (int workorderId, SCServiceChannelServicesMessagingWorkordersCheckInRequest request)

Perform a check-in

Creates a check-in record of the indicated work type: travel, repair, or custom. Returns `MechanicId` for a successful request.              See the [Check-In/Out guide](https://developer.servicechannel.com/guides/checkin/about-check-in-out/) for code snippets and detailed instructions.              <br />***Note:*** [Special permission](https://developer.servicechannel.com/guides/checkin/before-you-start/#check-inout-permissions) is required for the Travel and Repair work types.              <br />**Example Request**                                POST /workorders/{workorderId}/universalCheckIn                  {                    \"WorkTypeId\": 1,                    \"UserId\": 1544987,                    \"TechsCount\": 2,                    \"Latitude\": 40.736618,                    \"Longitude\": -73.991806,                    \"CheckInTime\": \"2018-10-23T08:30:00Z\"                  }

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdUniversalCheckInExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | The unique ID of the work order for which you want to report a check-in.
            var request = new SCServiceChannelServicesMessagingWorkordersCheckInRequest(); // SCServiceChannelServicesMessagingWorkordersCheckInRequest | The check-in object that needs to be created.

            try
            {
                // Perform a check-in
                SCServiceChannelServicesMessagingCheckInOutCheckInOutResponse result = apiInstance.WorkordersworkorderIdUniversalCheckIn(workorderId, request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdUniversalCheckIn: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdUniversalCheckInWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Perform a check-in
    ApiResponse<SCServiceChannelServicesMessagingCheckInOutCheckInOutResponse> response = apiInstance.WorkordersworkorderIdUniversalCheckInWithHttpInfo(workorderId, request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdUniversalCheckInWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | The unique ID of the work order for which you want to report a check-in. |  |
| **request** | [**SCServiceChannelServicesMessagingWorkordersCheckInRequest**](SCServiceChannelServicesMessagingWorkordersCheckInRequest.md) | The check-in object that needs to be created. |  |

### Return type

[**SCServiceChannelServicesMessagingCheckInOutCheckInOutResponse**](SCServiceChannelServicesMessagingCheckInOutCheckInOutResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The check-in record is created. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              502 - Work order not found              503 - Required data missing or incorrect              503 - Provide your location to perform check-in or check-out              503 - Work type not found              503 - Check-in or check-out premature              503 - Check-in or check-out time should be close to current location time              503 - Check-in or check-out out of date              804 - User has no permission to perform this action              917 - Invalid WO tracking number              921 - Cannot update work order in one of the completed statuses              924 - Work order has been invoiced and cannot be changed              924 - No changes can be made to this maintenance work order because it is expired or premature              924 - Cannot check in/out of work order in … status              924 - Client not participating in GPS check-in process; use IVR              924 - Store has no GPS coordinates              941 - Can’t perform check-in or check-out: out of ... mile range |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 - Missing or incorrect authentication credentials |  -  |
| **405** | The method is not allowed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderiduniversalcheckout"></a>
# **WorkordersworkorderIdUniversalCheckOut**
> SCServiceChannelServicesMessagingCheckInOutCheckInOutResponse WorkordersworkorderIdUniversalCheckOut (int workorderId, SCServiceChannelServicesMessagingWorkordersCheckOutRequest request)

Perform a check-out

Creates a check-out record of the indicated work type: travel, repair, or custom. Returns `MechanicId` for a successful request.              See the [Check-In/Out guide](https://developer.servicechannel.com/guides/checkin/about-check-in-out/) for code snippets and detailed instructions.              <br />***Note:*** [Special permission](https://developer.servicechannel.com/guides/checkin/before-you-start/#check-inout-permissions) is required for the Travel and Repair work types.              <br />**Example Request**                                POST /workorders/{workorderId}/universalCheckOut                  {                    \"WorkTypeId\": 1,                    \"PrimaryStatus\": \"InProgress\",                    \"ExtendedStatus\": \"string\",                    \"ActionStatus\": \"Complete\",                    \"Resolution\": \"We need more time to complete this job.\",                    \"UserId\": 1544987,                    \"Latitude\": 40.736618,                    \"Longitude\": -73.991806,                    \"CheckOutTime\": \"2018-10-23T09:30:00Z\"                  }

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdUniversalCheckOutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | The unique ID of the work order for which you want to report a check-out.
            var request = new SCServiceChannelServicesMessagingWorkordersCheckOutRequest(); // SCServiceChannelServicesMessagingWorkordersCheckOutRequest | The check-out object that needs to be created.

            try
            {
                // Perform a check-out
                SCServiceChannelServicesMessagingCheckInOutCheckInOutResponse result = apiInstance.WorkordersworkorderIdUniversalCheckOut(workorderId, request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdUniversalCheckOut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdUniversalCheckOutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Perform a check-out
    ApiResponse<SCServiceChannelServicesMessagingCheckInOutCheckInOutResponse> response = apiInstance.WorkordersworkorderIdUniversalCheckOutWithHttpInfo(workorderId, request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdUniversalCheckOutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | The unique ID of the work order for which you want to report a check-out. |  |
| **request** | [**SCServiceChannelServicesMessagingWorkordersCheckOutRequest**](SCServiceChannelServicesMessagingWorkordersCheckOutRequest.md) | The check-out object that needs to be created. |  |

### Return type

[**SCServiceChannelServicesMessagingCheckInOutCheckInOutResponse**](SCServiceChannelServicesMessagingCheckInOutCheckInOutResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The check-out record is created. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              502 - Work order not found              503 - Required data missing or incorrect              503 - Provide your location to perform check-in or check-out              503 - User has not checked in              503 - Work type not found              503 - Check-in or check-out premature              503 - Check-in or check-out time should be close to current location time              503 - Check-in or check-out out of date              503 - Invalid SignatureAttachmentId              503 - Invalid UnableObtainSignatureNoteId              503 - You can set either SignatureAttachmentId or UnableObtainSignatureNoteId but not both              503 - No access to electronic signatures              804 - User has no permission to perform this action              904 - User does not have … extended status that belongs to … primary status              917 - Invalid WO tracking number              921 - Cannot update work order in one of the completed statuses              925 - Work order has been invoiced and cannot be changed              925 - No changes can be made to this maintenance work order because it is expired or premature              925 - Cannot check in/out of work order in … status              925 - Client not participating in GPS check-in process; use IVR              925 - Store has no GPS coordinates              942 - Can’t perform check-in or check-out: out of ... mile range |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 - Missing or incorrect authentication credentials |  -  |
| **405** | The method is not allowed. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidunlinklinkedworkorderidlinkedworkorderid"></a>
# **WorkordersworkorderIdUnlinklinkedWorkorderIdlinkedWorkorderId**
> void WorkordersworkorderIdUnlinklinkedWorkorderIdlinkedWorkorderId (int workorderId, SCServiceChannelServicesMessagingWorkordersUnlinkWorkordersRequest request, int? linkedWorkorderId = null)

Removes link between two Work Orders

<para>Current Work Order is parent, followUp Work Order is linked Work Order</para>  <para>If you set 'linkedWorkorderId' parameter then 'WorkorderIds' parameter of requested body will be ignored.</para>  <br />  <br />Available for provider and subscriber usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdUnlinklinkedWorkorderIdlinkedWorkorderIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | Parent Work Order id
            var request = new SCServiceChannelServicesMessagingWorkordersUnlinkWorkordersRequest(); // SCServiceChannelServicesMessagingWorkordersUnlinkWorkordersRequest | UnLink Workorders Request
            var linkedWorkorderId = 56;  // int? | Work Order Id that Unlinks from parent. Optional. (optional) 

            try
            {
                // Removes link between two Work Orders
                apiInstance.WorkordersworkorderIdUnlinklinkedWorkorderIdlinkedWorkorderId(workorderId, request, linkedWorkorderId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdUnlinklinkedWorkorderIdlinkedWorkorderId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdUnlinklinkedWorkorderIdlinkedWorkorderIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Removes link between two Work Orders
    apiInstance.WorkordersworkorderIdUnlinklinkedWorkorderIdlinkedWorkorderIdWithHttpInfo(workorderId, request, linkedWorkorderId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdUnlinklinkedWorkorderIdlinkedWorkorderIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Parent Work Order id |  |
| **request** | [**SCServiceChannelServicesMessagingWorkordersUnlinkWorkordersRequest**](SCServiceChannelServicesMessagingWorkordersUnlinkWorkordersRequest.md) | UnLink Workorders Request |  |
| **linkedWorkorderId** | **int?** | Work Order Id that Unlinks from parent. Optional. | [optional]  |

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
| **204** | Indicates that the request succeeded |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.&lt;br/&gt;Error codes:&lt;br/&gt;           917 - Wrong Parent Work Order Id;&lt;br&gt;           932 - Wrong Linked Work Order Id |  -  |
| **401** | Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidvalidatecheckinworktypeidworktypeidlatitudelatitudelongitudelongitude"></a>
# **WorkordersworkorderIdValidateCheckInWorkTypeIdWorkTypeIdLatitudeLatitudeLongitudeLongitude**
> SCServiceChannelServicesMessagingCheckInOutCheckInValidateResponse WorkordersworkorderIdValidateCheckInWorkTypeIdWorkTypeIdLatitudeLatitudeLongitudeLongitude (int workorderId, double latitude, double longitude, int? workTypeId = null)

Validate Check-In action

Validate Check-In action

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdValidateCheckInWorkTypeIdWorkTypeIdLatitudeLatitudeLongitudeLongitudeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | Numeric Id of the Work order to perform action with.
            var latitude = 1.2D;  // double | Global position. Latitude
            var longitude = 1.2D;  // double | Global position. Longitude
            var workTypeId = 56;  // int? | Optional, type work Id. 1 - 'Repair', 2 - 'Travel'              Default value is 1 ('Repair'). Supports custom types. (optional) 

            try
            {
                // Validate Check-In action
                SCServiceChannelServicesMessagingCheckInOutCheckInValidateResponse result = apiInstance.WorkordersworkorderIdValidateCheckInWorkTypeIdWorkTypeIdLatitudeLatitudeLongitudeLongitude(workorderId, latitude, longitude, workTypeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdValidateCheckInWorkTypeIdWorkTypeIdLatitudeLatitudeLongitudeLongitude: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdValidateCheckInWorkTypeIdWorkTypeIdLatitudeLatitudeLongitudeLongitudeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Validate Check-In action
    ApiResponse<SCServiceChannelServicesMessagingCheckInOutCheckInValidateResponse> response = apiInstance.WorkordersworkorderIdValidateCheckInWorkTypeIdWorkTypeIdLatitudeLatitudeLongitudeLongitudeWithHttpInfo(workorderId, latitude, longitude, workTypeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdValidateCheckInWorkTypeIdWorkTypeIdLatitudeLatitudeLongitudeLongitudeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Numeric Id of the Work order to perform action with. |  |
| **latitude** | **double** | Global position. Latitude |  |
| **longitude** | **double** | Global position. Longitude |  |
| **workTypeId** | **int?** | Optional, type work Id. 1 - &#39;Repair&#39;, 2 - &#39;Travel&#39;              Default value is 1 (&#39;Repair&#39;). Supports custom types. | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingCheckInOutCheckInValidateResponse**](SCServiceChannelServicesMessagingCheckInOutCheckInValidateResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 502 - WorkOrder not found;              &lt;br/&gt; 503 - Request data is empty;              &lt;br/&gt;Provide your location to perform checkin/checkout;              &lt;br/&gt; 917 - Invalid Tracking Number;              &lt;br/&gt; 921 - Cannot update work order in &#39;completed&#39; status;              &lt;br/&gt;Cannot update invoiced work order;              &lt;br/&gt; 924 - Work order has been invoiced and cannot be changed;              &lt;br/&gt; 941 - Can&#39;t do check in: out of ... mile range; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **405** | Indicates that the request method is not allowed on the requested resource. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidvalidatecheckoutworktypeidworktypeidlatitudelatitudelongitudelongitude"></a>
# **WorkordersworkorderIdValidateCheckOutWorkTypeIdWorkTypeIdLatitudeLatitudeLongitudeLongitude**
> SCServiceChannelServicesMessagingCheckInOutCheckInValidateResponse WorkordersworkorderIdValidateCheckOutWorkTypeIdWorkTypeIdLatitudeLatitudeLongitudeLongitude (int workorderId, double latitude, double longitude, int? workTypeId = null)

Validate Check-Out action

Validate Check-Out action

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdValidateCheckOutWorkTypeIdWorkTypeIdLatitudeLatitudeLongitudeLongitudeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | Numeric Id of the Work order to perform action with.
            var latitude = 1.2D;  // double | Global position. Latitude
            var longitude = 1.2D;  // double | Global position. Longitude
            var workTypeId = 56;  // int? | Optional, type work Id. 1 - 'Repair', 2 - 'Travel'              Default value is 1 ('Repair'). Supports custom types. (optional) 

            try
            {
                // Validate Check-Out action
                SCServiceChannelServicesMessagingCheckInOutCheckInValidateResponse result = apiInstance.WorkordersworkorderIdValidateCheckOutWorkTypeIdWorkTypeIdLatitudeLatitudeLongitudeLongitude(workorderId, latitude, longitude, workTypeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdValidateCheckOutWorkTypeIdWorkTypeIdLatitudeLatitudeLongitudeLongitude: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdValidateCheckOutWorkTypeIdWorkTypeIdLatitudeLatitudeLongitudeLongitudeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Validate Check-Out action
    ApiResponse<SCServiceChannelServicesMessagingCheckInOutCheckInValidateResponse> response = apiInstance.WorkordersworkorderIdValidateCheckOutWorkTypeIdWorkTypeIdLatitudeLatitudeLongitudeLongitudeWithHttpInfo(workorderId, latitude, longitude, workTypeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdValidateCheckOutWorkTypeIdWorkTypeIdLatitudeLatitudeLongitudeLongitudeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Numeric Id of the Work order to perform action with. |  |
| **latitude** | **double** | Global position. Latitude |  |
| **longitude** | **double** | Global position. Longitude |  |
| **workTypeId** | **int?** | Optional, type work Id. 1 - &#39;Repair&#39;, 2 - &#39;Travel&#39;              Default value is 1 (&#39;Repair&#39;). Supports custom types. | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingCheckInOutCheckInValidateResponse**](SCServiceChannelServicesMessagingCheckInOutCheckInValidateResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 502 - WorkOrder not found;              &lt;br/&gt; 503 - Request data is empty;              &lt;br/&gt;Provide your location to perform checkin/checkout;              &lt;br/&gt; 917 - Invalid Tracking Number;              &lt;br/&gt; 921 - Cannot update work order in &#39;completed&#39; status;              &lt;br/&gt;Cannot update invoiced work order;              &lt;br/&gt; 924 - Work order has been invoiced and cannot be changed;              &lt;br/&gt; 941 - Can&#39;t do check out: out of ... mile range; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **405** | Indicates that the request method is not allowed on the requested resource. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidweathertypeidsubscriberidsubscriberid"></a>
# **WorkordersworkorderIdWeatherTypeIdsubscriberIdsubscriberId**
> SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse WorkordersworkorderIdWeatherTypeIdsubscriberIdsubscriberId (int workorderId, SCServiceChannelServicesMessagingWorkordersChangeWoWeatherTypeIdRequest updateRequest, int? subscriberId = null)

Update weather type

Updates weather type.              <br /><br />This method can only be used for users with 'WorkOrderFullEdit' permissions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdWeatherTypeIdsubscriberIdsubscriberIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | Numeric Id of the Work order to perform action with.
            var updateRequest = new SCServiceChannelServicesMessagingWorkordersChangeWoWeatherTypeIdRequest(); // SCServiceChannelServicesMessagingWorkordersChangeWoWeatherTypeIdRequest | The update request. WeatherTypeId (put Value as empty to remove weather type).
            var subscriberId = 56;  // int? | The subscriber Id to use (if logged in as a provider). (optional) 

            try
            {
                // Update weather type
                SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse result = apiInstance.WorkordersworkorderIdWeatherTypeIdsubscriberIdsubscriberId(workorderId, updateRequest, subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdWeatherTypeIdsubscriberIdsubscriberId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdWeatherTypeIdsubscriberIdsubscriberIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update weather type
    ApiResponse<SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse> response = apiInstance.WorkordersworkorderIdWeatherTypeIdsubscriberIdsubscriberIdWithHttpInfo(workorderId, updateRequest, subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdWeatherTypeIdsubscriberIdsubscriberIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Numeric Id of the Work order to perform action with. |  |
| **updateRequest** | [**SCServiceChannelServicesMessagingWorkordersChangeWoWeatherTypeIdRequest**](SCServiceChannelServicesMessagingWorkordersChangeWoWeatherTypeIdRequest.md) | The update request. WeatherTypeId (put Value as empty to remove weather type). |  |
| **subscriberId** | **int?** | The subscriber Id to use (if logged in as a provider). | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse**](SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 100 - You don&#39;t have location access to perform this operation;              &lt;br/&gt; 502 - Data not found. Returned if target Work order is not found database;              &lt;br/&gt; 503 - Request data is empty;              &lt;br/&gt; 923 - Invalid Work order number specified. Returned if duplicate number is found for this provider or if value exceeds max len (20 chars);              &lt;br/&gt; 921 - Cannot update invoiced Work order; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidwonumber"></a>
# **WorkordersworkorderIdWonumber**
> SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse WorkordersworkorderIdWonumber (int workorderId, SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest updateRequest)

Update Work order Number

Updates Work order Number.              <br /><br />This method can only be used for users with 'WorkOrderFullEdit' permissions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdWonumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var workorderId = 56;  // int | Numeric Id of the Work order to perform action with.
            var updateRequest = new SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest(); // SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest | The update request. Work order Number.

            try
            {
                // Update Work order Number
                SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse result = apiInstance.WorkordersworkorderIdWonumber(workorderId, updateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdWonumber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdWonumberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Work order Number
    ApiResponse<SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse> response = apiInstance.WorkordersworkorderIdWonumberWithHttpInfo(workorderId, updateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorkordersworkorderIdWonumberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Numeric Id of the Work order to perform action with. |  |
| **updateRequest** | [**SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest**](SCServiceChannelServicesMessagingWorkordersChangeWoFieldsRequest.md) | The update request. Work order Number. |  |

### Return type

[**SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse**](SCServiceChannelServicesMessagingWorkordersChangeWorkOrderResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 100 - You don&#39;t have location access to perform this operation;              &lt;br/&gt; 502 - Data not found. Returned if target Work order is not found database;              &lt;br/&gt; 503 - Request data is empty;              &lt;br/&gt; 923 - Invalid Work order number specified. Returned if duplicate number is found for this provider or if value exceeds max len (20 chars);              &lt;br/&gt; 921 - Cannot update invoiced Work order; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="worktypessubscriberidsubscriberid"></a>
# **WorktypessubscriberIdsubscriberId**
> List&lt;SCServiceChannelServicesMessagingV4WorkordersWorkTypeResponse&gt; WorktypessubscriberIdsubscriberId (int? subscriberId = null)

Work types Collection

Retrieves list of Work types.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorktypessubscriberIdsubscriberIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkOrdersApi(config);
            var subscriberId = 56;  // int? | This parameter is required only for provider. (optional) 

            try
            {
                // Work types Collection
                List<SCServiceChannelServicesMessagingV4WorkordersWorkTypeResponse> result = apiInstance.WorktypessubscriberIdsubscriberId(subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkOrdersApi.WorktypessubscriberIdsubscriberId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorktypessubscriberIdsubscriberIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Work types Collection
    ApiResponse<List<SCServiceChannelServicesMessagingV4WorkordersWorkTypeResponse>> response = apiInstance.WorktypessubscriberIdsubscriberIdWithHttpInfo(subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkOrdersApi.WorktypessubscriberIdsubscriberIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int?** | This parameter is required only for provider. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingV4WorkordersWorkTypeResponse&gt;**](SCServiceChannelServicesMessagingV4WorkordersWorkTypeResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

