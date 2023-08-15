# ServiceChannel.Api.Api.RefrigerantTrackingApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Refrigeranttracking**](RefrigerantTrackingApi.md#refrigeranttracking) | **PUT** /refrigeranttracking | Update/Insert Leak Tracking Preferences |
| [**RefrigeranttrackingAddLeakDetectorAudit**](RefrigerantTrackingApi.md#refrigeranttrackingaddleakdetectoraudit) | **POST** /refrigeranttracking/addLeakDetectorAudit | Add leak detector audit |
| [**RefrigeranttrackingAddOrUpdateRefrigerationTypes**](RefrigerantTrackingApi.md#refrigeranttrackingaddorupdaterefrigerationtypes) | **POST** /refrigeranttracking/AddOrUpdateRefrigerationTypes |  |
| [**RefrigeranttrackingAddUpdateRefrigerationDetailsequipmentIdequipmentId**](RefrigerantTrackingApi.md#refrigeranttrackingaddupdaterefrigerationdetailsequipmentidequipmentid) | **POST** /refrigeranttracking/addUpdateRefrigerationDetails | Add Update Refrigeration Details |
| [**RefrigeranttrackingBulkLeakrecords**](RefrigerantTrackingApi.md#refrigeranttrackingbulkleakrecords) | **POST** /refrigeranttracking/BulkLeakrecords | BulkLeakrecords |
| [**RefrigeranttrackingChargeDescriptions**](RefrigerantTrackingApi.md#refrigeranttrackingchargedescriptions) | **GET** /refrigeranttracking/ChargeDescriptions | Get Charge Descriptions |
| [**RefrigeranttrackingCheckRefrigerantTrackingAvailable**](RefrigerantTrackingApi.md#refrigeranttrackingcheckrefrigeranttrackingavailable) | **POST** /refrigeranttracking/CheckRefrigerantTrackingAvailable | Check if Refrigerant Tracking Available for list of locations |
| [**RefrigeranttrackingCheckRefrigerantTrackingAvailableV1**](RefrigerantTrackingApi.md#refrigeranttrackingcheckrefrigeranttrackingavailablev1) | **POST** /refrigeranttracking/CheckRefrigerantTrackingAvailable_v1 | Check if Refrigerant Tracking Available for list of locations |
| [**RefrigeranttrackingCreateChargeHistory**](RefrigerantTrackingApi.md#refrigeranttrackingcreatechargehistory) | **POST** /refrigeranttracking/createChargeHistory | Create Charge History |
| [**RefrigeranttrackingCreateLeakRecordFollowupWoleakRecordIdleakRecordIdcurrentTrackingNumbercurrentTrackingNumber**](RefrigerantTrackingApi.md#refrigeranttrackingcreateleakrecordfollowupwoleakrecordidleakrecordidcurrenttrackingnumbercurrenttrackingnumber) | **POST** /refrigeranttracking/CreateLeakRecordFollowupWo | Creates Follow Up wo for non-closed leak records |
| [**RefrigeranttrackingDeleteLeakRecordImmeasurableidid**](RefrigerantTrackingApi.md#refrigeranttrackingdeleteleakrecordimmeasurableidid) | **DELETE** /refrigeranttracking/DeleteLeakRecordImmeasurable | Deactivated LeakImmeasurable |
| [**RefrigeranttrackingGetLeakDetectorLastAuditassetIdassetIdrecIdrecId**](RefrigerantTrackingApi.md#refrigeranttrackinggetleakdetectorlastauditassetidassetidrecidrecid) | **GET** /refrigeranttracking/getLeakDetectorLastAudit | get leak detector last audit |
| [**RefrigeranttrackingGetRackTypeListItems**](RefrigerantTrackingApi.md#refrigeranttrackinggetracktypelistitems) | **GET** /refrigeranttracking/GetRackTypeListItems | Get Rack Type List Items |
| [**RefrigeranttrackingIsRefrigerantTrackingAvailablelocationId**](RefrigerantTrackingApi.md#refrigeranttrackingisrefrigeranttrackingavailablelocationid) | **GET** /refrigeranttracking/isRefrigerantTrackingAvailable/{locationId} |  |
| [**RefrigeranttrackingLeakInspectionComplianceAcknowledgement**](RefrigerantTrackingApi.md#refrigeranttrackingleakinspectioncomplianceacknowledgement) | **POST** /refrigeranttracking/LeakInspectionComplianceAcknowledgement | Add Leak Inspection Compliance Acknowledgement |
| [**RefrigeranttrackingLeakNote**](RefrigerantTrackingApi.md#refrigeranttrackingleaknote) | **POST** /refrigeranttracking/leakNote | Add leak note |
| [**RefrigeranttrackingLeakRecordActionCodes**](RefrigerantTrackingApi.md#refrigeranttrackingleakrecordactioncodes) | **GET** /refrigeranttracking/leakRecord/actionCodes | Retrieve leak record action codes |
| [**RefrigeranttrackingLeakRecordFaultCodes**](RefrigerantTrackingApi.md#refrigeranttrackingleakrecordfaultcodes) | **GET** /refrigeranttracking/leakRecord/faultCodes | Retrieve leak record fault codes |
| [**RefrigeranttrackingLeakRecordImmearusable**](RefrigerantTrackingApi.md#refrigeranttrackingleakrecordimmearusable) | **PUT** /refrigeranttracking/LeakRecordImmearusable | Update entity to RT_LeakImmeasurable |
| [**RefrigeranttrackingLeakRecordImmearusable_0**](RefrigerantTrackingApi.md#refrigeranttrackingleakrecordimmearusable_0) | **POST** /refrigeranttracking/LeakRecordImmearusable | Add entity to RT_LeakImmeasurable |
| [**RefrigeranttrackingLeakRecordImmearusabletrackingNumberassetidassetid**](RefrigerantTrackingApi.md#refrigeranttrackingleakrecordimmearusabletrackingnumberassetidassetid) | **GET** /refrigeranttracking/LeakRecordImmearusable/{trackingNumber} | Get LeakImmeasurable by recId and assetID |
| [**RefrigeranttrackingLeakVerificationMethods**](RefrigerantTrackingApi.md#refrigeranttrackingleakverificationmethods) | **GET** /refrigeranttracking/LeakVerificationMethods | Get Leak Verification Methods |
| [**RefrigeranttrackingLeakareas**](RefrigerantTrackingApi.md#refrigeranttrackingleakareas) | **GET** /refrigeranttracking/leakareas | Get leak areas |
| [**RefrigeranttrackingLeakrecord**](RefrigerantTrackingApi.md#refrigeranttrackingleakrecord) | **PUT** /refrigeranttracking/leakrecord | UpdateLeakRecord |
| [**RefrigeranttrackingLeakrecordV1**](RefrigerantTrackingApi.md#refrigeranttrackingleakrecordv1) | **PUT** /refrigeranttracking/leakrecordV1 | UpdateLeakRecord With Returns Detail Operation Result |
| [**RefrigeranttrackingLeakrecords**](RefrigerantTrackingApi.md#refrigeranttrackingleakrecords) | **POST** /refrigeranttracking/leakrecords | Retrieve leak records by filter |
| [**RefrigeranttrackingLeakrecordstrackingNumber**](RefrigerantTrackingApi.md#refrigeranttrackingleakrecordstrackingnumber) | **GET** /refrigeranttracking/leakrecords/{trackingNumber} | Get LeakRecords with LeakImmeasurable |
| [**RefrigeranttrackingOperationalStatuses**](RefrigerantTrackingApi.md#refrigeranttrackingoperationalstatuses) | **GET** /refrigeranttracking/OperationalStatuses | Get Operational Statuses |
| [**RefrigeranttrackingRack**](RefrigerantTrackingApi.md#refrigeranttrackingrack) | **POST** /refrigeranttracking/rack | Create/Update Rack Connection |
| [**RefrigeranttrackingRackidid**](RefrigerantTrackingApi.md#refrigeranttrackingrackidid) | **GET** /refrigeranttracking/rack | Get Rack Connection |
| [**RefrigeranttrackingRefrigerantTypessubscriberIdsubscriberId**](RefrigerantTrackingApi.md#refrigeranttrackingrefrigeranttypessubscriberidsubscriberid) | **GET** /refrigeranttracking/RefrigerantTypes | Get refrigerant types |
| [**RefrigeranttrackingRetireretrofitplans**](RefrigerantTrackingApi.md#refrigeranttrackingretireretrofitplans) | **POST** /refrigeranttracking/retireretrofitplans | Retrieve retire retrofit plans |
| [**RefrigeranttrackingSaveRefrigerationDetails**](RefrigerantTrackingApi.md#refrigeranttrackingsaverefrigerationdetails) | **POST** /refrigeranttracking/SaveRefrigerationDetails | Add/Update Refrigeration Details for an asset |
| [**RefrigeranttrackingSubscribers**](RefrigerantTrackingApi.md#refrigeranttrackingsubscribers) | **GET** /refrigeranttracking/subscribers | Get SubscriberIds With RefrigerantTracking Feature Flag |
| [**RefrigeranttrackingSystemLocations**](RefrigerantTrackingApi.md#refrigeranttrackingsystemlocations) | **GET** /refrigeranttracking/SystemLocations | Get System Locations |
| [**RefrigeranttrackingWOLeakVerification**](RefrigerantTrackingApi.md#refrigeranttrackingwoleakverification) | **PUT** /refrigeranttracking/WOLeakVerification | Update WOLeakVerification |
| [**RefrigeranttrackingWOLeakVerification_0**](RefrigerantTrackingApi.md#refrigeranttrackingwoleakverification_0) | **POST** /refrigeranttracking/WOLeakVerification | Add WOLeakVerification |
| [**RefrigeranttrackingWOLeakVerificationtrackingNumber**](RefrigerantTrackingApi.md#refrigeranttrackingwoleakverificationtrackingnumber) | **GET** /refrigeranttracking/WOLeakVerification/{trackingNumber} | Get WOLeakVerification by tracking number and assetId |
| [**Refrigeranttracking_0**](RefrigerantTrackingApi.md#refrigeranttracking_0) | **POST** /refrigeranttracking | Get Rack Equipment |
| [**RefrigeranttrackingassetIdRefrigerantusagesummary**](RefrigerantTrackingApi.md#refrigeranttrackingassetidrefrigerantusagesummary) | **GET** /refrigeranttracking/{assetId}/refrigerantusagesummary | Get refrigerant usage summary |
| [**RefrigeranttrackingassetTypeIdGetRefrigerantUseTypes**](RefrigerantTrackingApi.md#refrigeranttrackingassettypeidgetrefrigerantusetypes) | **GET** /refrigeranttracking/{assetTypeId}/getRefrigerantUseTypes | Get refrigerant use types for equipment |
| [**RefrigeranttrackinglocationIdGetRefrigerantSettings**](RefrigerantTrackingApi.md#refrigeranttrackinglocationidgetrefrigerantsettings) | **GET** /refrigeranttracking/{locationId}/GetRefrigerantSettings | Get Refrigerant settings by locationId |
| [**RefrigeranttrackingsubscriberIdGetRefrigerantUseReasonCodes**](RefrigerantTrackingApi.md#refrigeranttrackingsubscriberidgetrefrigerantusereasoncodes) | **GET** /refrigeranttracking/{subscriberId}/GetRefrigerantUseReasonCodes | Get Refrigerant Use Reason Codes |
| [**RefrigeranttrackingsubscriberIdLeaklocations**](RefrigerantTrackingApi.md#refrigeranttrackingsubscriberidleaklocations) | **GET** /refrigeranttracking/{subscriberId}/leaklocations | Get leak locations |
| [**RefrigeranttrackingsubscriberIdsubscriberId**](RefrigerantTrackingApi.md#refrigeranttrackingsubscriberidsubscriberid) | **GET** /refrigeranttracking | Get Leak Tracking Preferences |
| [**RefrigeranttrackingtrackingNumberLeakRecord**](RefrigerantTrackingApi.md#refrigeranttrackingtrackingnumberleakrecord) | **GET** /refrigeranttracking/{trackingNumber}/leakRecord | Retrieve leak record by tracking number |
| [**RefrigeranttrackingworkOrderIdCheckRefrigerantWasUsedIsValidForInvoiceableStatusesrefrigerantWasUsedrefrigerantWasUsed**](RefrigerantTrackingApi.md#refrigeranttrackingworkorderidcheckrefrigerantwasusedisvalidforinvoiceablestatusesrefrigerantwasusedrefrigerantwasused) | **GET** /refrigeranttracking/{workOrderId}/checkRefrigerantWasUsedIsValidForInvoiceableStatuses | Check If Used Refrigerant Is Valid For Invoiceble Statuses |
| [**RefrigeranttrackingworkOrderIdCreateLeakRecordFollowUpWoForStatusUpdate**](RefrigerantTrackingApi.md#refrigeranttrackingworkorderidcreateleakrecordfollowupwoforstatusupdate) | **POST** /refrigeranttracking/{workOrderId}/createLeakRecordFollowUpWoForStatusUpdate | Create Leak Record Follow Up WorkOrder |
| [**RefrigeranttrackingworkOrderIdIsCompletedStatusesLimitedByRTSetup**](RefrigerantTrackingApi.md#refrigeranttrackingworkorderidiscompletedstatuseslimitedbyrtsetup) | **GET** /refrigeranttracking/{workOrderId}/isCompletedStatusesLimitedByRTSetup | Check If WO Status Is Limited By RTSetup |

<a id="refrigeranttracking"></a>
# **Refrigeranttracking**
> Object Refrigeranttracking (SCServiceChannelServicesMessagingRefrigerantTrackingPreferencesRequest request)

Update/Insert Leak Tracking Preferences

Update/Insert Leak Tracking Preferences. Returns Success/NoSuccess request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var request = new SCServiceChannelServicesMessagingRefrigerantTrackingPreferencesRequest(); // SCServiceChannelServicesMessagingRefrigerantTrackingPreferencesRequest | 

            try
            {
                // Update/Insert Leak Tracking Preferences
                Object result = apiInstance.Refrigeranttracking(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.Refrigeranttracking: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update/Insert Leak Tracking Preferences
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingRefrigerantTrackingPreferencesRequest**](SCServiceChannelServicesMessagingRefrigerantTrackingPreferencesRequest.md) |  |  |

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
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:                          &lt;br/&gt; 502 - No Update/Insert Leak Tracking Preferences; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              &lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingaddleakdetectoraudit"></a>
# **RefrigeranttrackingAddLeakDetectorAudit**
> Object RefrigeranttrackingAddLeakDetectorAudit (SCServiceChannelServicesMessagingRefrigerantTrackingLeakDetectorAuditAddUpdateRequest request)

Add leak detector audit

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingAddLeakDetectorAuditExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var request = new SCServiceChannelServicesMessagingRefrigerantTrackingLeakDetectorAuditAddUpdateRequest(); // SCServiceChannelServicesMessagingRefrigerantTrackingLeakDetectorAuditAddUpdateRequest | 

            try
            {
                // Add leak detector audit
                Object result = apiInstance.RefrigeranttrackingAddLeakDetectorAudit(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingAddLeakDetectorAudit: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingAddLeakDetectorAuditWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add leak detector audit
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingAddLeakDetectorAuditWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingAddLeakDetectorAuditWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingRefrigerantTrackingLeakDetectorAuditAddUpdateRequest**](SCServiceChannelServicesMessagingRefrigerantTrackingLeakDetectorAuditAddUpdateRequest.md) |  |  |

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
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:                          &lt;br/&gt; 502 - No Get leak Areas; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              &lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingaddorupdaterefrigerationtypes"></a>
# **RefrigeranttrackingAddOrUpdateRefrigerationTypes**
> Object RefrigeranttrackingAddOrUpdateRefrigerationTypes (List<SCServiceChannelServicesMessagingRefrigerantTrackingRefrigerantType> request)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingAddOrUpdateRefrigerationTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var request = new List<SCServiceChannelServicesMessagingRefrigerantTrackingRefrigerantType>(); // List<SCServiceChannelServicesMessagingRefrigerantTrackingRefrigerantType> | 

            try
            {
                Object result = apiInstance.RefrigeranttrackingAddOrUpdateRefrigerationTypes(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingAddOrUpdateRefrigerationTypes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingAddOrUpdateRefrigerationTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingAddOrUpdateRefrigerationTypesWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingAddOrUpdateRefrigerationTypesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**List&lt;SCServiceChannelServicesMessagingRefrigerantTrackingRefrigerantType&gt;**](SCServiceChannelServicesMessagingRefrigerantTrackingRefrigerantType.md) |  |  |

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
| **401** | Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingaddupdaterefrigerationdetailsequipmentidequipmentid"></a>
# **RefrigeranttrackingAddUpdateRefrigerationDetailsequipmentIdequipmentId**
> Object RefrigeranttrackingAddUpdateRefrigerationDetailsequipmentIdequipmentId (int equipmentId, SCServiceChannelServicesMessagingRefrigerantTrackingAssetRefrigerant model)

Add Update Refrigeration Details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingAddUpdateRefrigerationDetailsequipmentIdequipmentIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var equipmentId = 56;  // int | 
            var model = new SCServiceChannelServicesMessagingRefrigerantTrackingAssetRefrigerant(); // SCServiceChannelServicesMessagingRefrigerantTrackingAssetRefrigerant | 

            try
            {
                // Add Update Refrigeration Details
                Object result = apiInstance.RefrigeranttrackingAddUpdateRefrigerationDetailsequipmentIdequipmentId(equipmentId, model);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingAddUpdateRefrigerationDetailsequipmentIdequipmentId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingAddUpdateRefrigerationDetailsequipmentIdequipmentIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Update Refrigeration Details
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingAddUpdateRefrigerationDetailsequipmentIdequipmentIdWithHttpInfo(equipmentId, model);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingAddUpdateRefrigerationDetailsequipmentIdequipmentIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **equipmentId** | **int** |  |  |
| **model** | [**SCServiceChannelServicesMessagingRefrigerantTrackingAssetRefrigerant**](SCServiceChannelServicesMessagingRefrigerantTrackingAssetRefrigerant.md) |  |  |

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
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              &lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingbulkleakrecords"></a>
# **RefrigeranttrackingBulkLeakrecords**
> Object RefrigeranttrackingBulkLeakrecords (SCServiceChannelServicesMessagingRefrigerantTrackingLeakImmeasurableBulkChangeRequest request)

BulkLeakrecords

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingBulkLeakrecordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var request = new SCServiceChannelServicesMessagingRefrigerantTrackingLeakImmeasurableBulkChangeRequest(); // SCServiceChannelServicesMessagingRefrigerantTrackingLeakImmeasurableBulkChangeRequest | 

            try
            {
                // BulkLeakrecords
                Object result = apiInstance.RefrigeranttrackingBulkLeakrecords(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingBulkLeakrecords: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingBulkLeakrecordsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // BulkLeakrecords
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingBulkLeakrecordsWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingBulkLeakrecordsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingRefrigerantTrackingLeakImmeasurableBulkChangeRequest**](SCServiceChannelServicesMessagingRefrigerantTrackingLeakImmeasurableBulkChangeRequest.md) |  |  |

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
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **500** | Indicates that the server encountered an unexpected condition that prevented it from fulfilling the request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingchargedescriptions"></a>
# **RefrigeranttrackingChargeDescriptions**
> Object RefrigeranttrackingChargeDescriptions ()

Get Charge Descriptions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingChargeDescriptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);

            try
            {
                // Get Charge Descriptions
                Object result = apiInstance.RefrigeranttrackingChargeDescriptions();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingChargeDescriptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingChargeDescriptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Charge Descriptions
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingChargeDescriptionsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingChargeDescriptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

<a id="refrigeranttrackingcheckrefrigeranttrackingavailable"></a>
# **RefrigeranttrackingCheckRefrigerantTrackingAvailable**
> Object RefrigeranttrackingCheckRefrigerantTrackingAvailable (List<int> locationIds)

Check if Refrigerant Tracking Available for list of locations

GetLeakTrackingPreferences

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingCheckRefrigerantTrackingAvailableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var locationIds = new List<int>(); // List<int> | locationIds

            try
            {
                // Check if Refrigerant Tracking Available for list of locations
                Object result = apiInstance.RefrigeranttrackingCheckRefrigerantTrackingAvailable(locationIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingCheckRefrigerantTrackingAvailable: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingCheckRefrigerantTrackingAvailableWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check if Refrigerant Tracking Available for list of locations
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingCheckRefrigerantTrackingAvailableWithHttpInfo(locationIds);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingCheckRefrigerantTrackingAvailableWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationIds** | [**List&lt;int&gt;**](int.md) | locationIds |  |

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
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:                         &lt;br/&gt; 502 - No Get Leak Tracking Preferences; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              &lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingcheckrefrigeranttrackingavailablev1"></a>
# **RefrigeranttrackingCheckRefrigerantTrackingAvailableV1**
> Object RefrigeranttrackingCheckRefrigerantTrackingAvailableV1 (SCServiceChannelServicesCoreInternalRequestsRefrigerantTrackingCheckRefrigerantTrackingRequest request)

Check if Refrigerant Tracking Available for list of locations

GetLeakTrackingPreferences

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingCheckRefrigerantTrackingAvailableV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var request = new SCServiceChannelServicesCoreInternalRequestsRefrigerantTrackingCheckRefrigerantTrackingRequest(); // SCServiceChannelServicesCoreInternalRequestsRefrigerantTrackingCheckRefrigerantTrackingRequest | request

            try
            {
                // Check if Refrigerant Tracking Available for list of locations
                Object result = apiInstance.RefrigeranttrackingCheckRefrigerantTrackingAvailableV1(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingCheckRefrigerantTrackingAvailableV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingCheckRefrigerantTrackingAvailableV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check if Refrigerant Tracking Available for list of locations
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingCheckRefrigerantTrackingAvailableV1WithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingCheckRefrigerantTrackingAvailableV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesCoreInternalRequestsRefrigerantTrackingCheckRefrigerantTrackingRequest**](SCServiceChannelServicesCoreInternalRequestsRefrigerantTrackingCheckRefrigerantTrackingRequest.md) | request |  |

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
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:                         &lt;br/&gt; 502 - No Get Leak Tracking Preferences; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              &lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingcreatechargehistory"></a>
# **RefrigeranttrackingCreateChargeHistory**
> Object RefrigeranttrackingCreateChargeHistory (SCServiceChannelServicesMessagingRefrigerantTrackingChargeHistoryRequest model)

Create Charge History

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingCreateChargeHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var model = new SCServiceChannelServicesMessagingRefrigerantTrackingChargeHistoryRequest(); // SCServiceChannelServicesMessagingRefrigerantTrackingChargeHistoryRequest | 

            try
            {
                // Create Charge History
                Object result = apiInstance.RefrigeranttrackingCreateChargeHistory(model);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingCreateChargeHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingCreateChargeHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Charge History
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingCreateChargeHistoryWithHttpInfo(model);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingCreateChargeHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **model** | [**SCServiceChannelServicesMessagingRefrigerantTrackingChargeHistoryRequest**](SCServiceChannelServicesMessagingRefrigerantTrackingChargeHistoryRequest.md) |  |  |

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
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              &lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingcreateleakrecordfollowupwoleakrecordidleakrecordidcurrenttrackingnumbercurrenttrackingnumber"></a>
# **RefrigeranttrackingCreateLeakRecordFollowupWoleakRecordIdleakRecordIdcurrentTrackingNumbercurrentTrackingNumber**
> Object RefrigeranttrackingCreateLeakRecordFollowupWoleakRecordIdleakRecordIdcurrentTrackingNumbercurrentTrackingNumber (int leakRecordId, int currentTrackingNumber)

Creates Follow Up wo for non-closed leak records

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingCreateLeakRecordFollowupWoleakRecordIdleakRecordIdcurrentTrackingNumbercurrentTrackingNumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var leakRecordId = 56;  // int | 
            var currentTrackingNumber = 56;  // int | 

            try
            {
                // Creates Follow Up wo for non-closed leak records
                Object result = apiInstance.RefrigeranttrackingCreateLeakRecordFollowupWoleakRecordIdleakRecordIdcurrentTrackingNumbercurrentTrackingNumber(leakRecordId, currentTrackingNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingCreateLeakRecordFollowupWoleakRecordIdleakRecordIdcurrentTrackingNumbercurrentTrackingNumber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingCreateLeakRecordFollowupWoleakRecordIdleakRecordIdcurrentTrackingNumbercurrentTrackingNumberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates Follow Up wo for non-closed leak records
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingCreateLeakRecordFollowupWoleakRecordIdleakRecordIdcurrentTrackingNumbercurrentTrackingNumberWithHttpInfo(leakRecordId, currentTrackingNumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingCreateLeakRecordFollowupWoleakRecordIdleakRecordIdcurrentTrackingNumbercurrentTrackingNumberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **leakRecordId** | **int** |  |  |
| **currentTrackingNumber** | **int** |  |  |

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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:                          &lt;br/&gt; 502 - No Update/Insert Leak Tracking Preferences; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              &lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingdeleteleakrecordimmeasurableidid"></a>
# **RefrigeranttrackingDeleteLeakRecordImmeasurableidid**
> Object RefrigeranttrackingDeleteLeakRecordImmeasurableidid (int id)

Deactivated LeakImmeasurable

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingDeleteLeakRecordImmeasurableididExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var id = 56;  // int | 

            try
            {
                // Deactivated LeakImmeasurable
                Object result = apiInstance.RefrigeranttrackingDeleteLeakRecordImmeasurableidid(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingDeleteLeakRecordImmeasurableidid: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingDeleteLeakRecordImmeasurableididWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deactivated LeakImmeasurable
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingDeleteLeakRecordImmeasurableididWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingDeleteLeakRecordImmeasurableididWithHttpInfo: " + e.Message);
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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackinggetleakdetectorlastauditassetidassetidrecidrecid"></a>
# **RefrigeranttrackingGetLeakDetectorLastAuditassetIdassetIdrecIdrecId**
> Object RefrigeranttrackingGetLeakDetectorLastAuditassetIdassetIdrecIdrecId (int assetId, int recId)

get leak detector last audit

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingGetLeakDetectorLastAuditassetIdassetIdrecIdrecIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var assetId = 56;  // int | 
            var recId = 56;  // int | 

            try
            {
                // get leak detector last audit
                Object result = apiInstance.RefrigeranttrackingGetLeakDetectorLastAuditassetIdassetIdrecIdrecId(assetId, recId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingGetLeakDetectorLastAuditassetIdassetIdrecIdrecId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingGetLeakDetectorLastAuditassetIdassetIdrecIdrecIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get leak detector last audit
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingGetLeakDetectorLastAuditassetIdassetIdrecIdrecIdWithHttpInfo(assetId, recId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingGetLeakDetectorLastAuditassetIdassetIdrecIdrecIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetId** | **int** |  |  |
| **recId** | **int** |  |  |

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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:                          &lt;br/&gt; 502 - No Get leak Areas; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              &lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackinggetracktypelistitems"></a>
# **RefrigeranttrackingGetRackTypeListItems**
> Object RefrigeranttrackingGetRackTypeListItems ()

Get Rack Type List Items

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingGetRackTypeListItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);

            try
            {
                // Get Rack Type List Items
                Object result = apiInstance.RefrigeranttrackingGetRackTypeListItems();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingGetRackTypeListItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingGetRackTypeListItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Rack Type List Items
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingGetRackTypeListItemsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingGetRackTypeListItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingisrefrigeranttrackingavailablelocationid"></a>
# **RefrigeranttrackingIsRefrigerantTrackingAvailablelocationId**
> Object RefrigeranttrackingIsRefrigerantTrackingAvailablelocationId (int locationId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingIsRefrigerantTrackingAvailablelocationIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var locationId = 56;  // int | 

            try
            {
                Object result = apiInstance.RefrigeranttrackingIsRefrigerantTrackingAvailablelocationId(locationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingIsRefrigerantTrackingAvailablelocationId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingIsRefrigerantTrackingAvailablelocationIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingIsRefrigerantTrackingAvailablelocationIdWithHttpInfo(locationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingIsRefrigerantTrackingAvailablelocationIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:                          &lt;br/&gt; 502 - No Update/Insert Leak Tracking Preferences; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              &lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingleakinspectioncomplianceacknowledgement"></a>
# **RefrigeranttrackingLeakInspectionComplianceAcknowledgement**
> Object RefrigeranttrackingLeakInspectionComplianceAcknowledgement (SCServiceChannelServicesMessagingRefrigerantTrackingLeakInspectionComplianceAcknowledgement model)

Add Leak Inspection Compliance Acknowledgement

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingLeakInspectionComplianceAcknowledgementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var model = new SCServiceChannelServicesMessagingRefrigerantTrackingLeakInspectionComplianceAcknowledgement(); // SCServiceChannelServicesMessagingRefrigerantTrackingLeakInspectionComplianceAcknowledgement | 

            try
            {
                // Add Leak Inspection Compliance Acknowledgement
                Object result = apiInstance.RefrigeranttrackingLeakInspectionComplianceAcknowledgement(model);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingLeakInspectionComplianceAcknowledgement: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingLeakInspectionComplianceAcknowledgementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Leak Inspection Compliance Acknowledgement
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingLeakInspectionComplianceAcknowledgementWithHttpInfo(model);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingLeakInspectionComplianceAcknowledgementWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **model** | [**SCServiceChannelServicesMessagingRefrigerantTrackingLeakInspectionComplianceAcknowledgement**](SCServiceChannelServicesMessagingRefrigerantTrackingLeakInspectionComplianceAcknowledgement.md) |  |  |

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

<a id="refrigeranttrackingleaknote"></a>
# **RefrigeranttrackingLeakNote**
> Object RefrigeranttrackingLeakNote (SCServiceChannelServicesMessagingRefrigerantTrackingAddLeakNoteRequest request)

Add leak note

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingLeakNoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var request = new SCServiceChannelServicesMessagingRefrigerantTrackingAddLeakNoteRequest(); // SCServiceChannelServicesMessagingRefrigerantTrackingAddLeakNoteRequest | 

            try
            {
                // Add leak note
                Object result = apiInstance.RefrigeranttrackingLeakNote(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingLeakNote: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingLeakNoteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add leak note
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingLeakNoteWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingLeakNoteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingRefrigerantTrackingAddLeakNoteRequest**](SCServiceChannelServicesMessagingRefrigerantTrackingAddLeakNoteRequest.md) |  |  |

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
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:                          &lt;br/&gt; 502 - No Update/Insert Leak Tracking Preferences; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              &lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingleakrecordactioncodes"></a>
# **RefrigeranttrackingLeakRecordActionCodes**
> Object RefrigeranttrackingLeakRecordActionCodes ()

Retrieve leak record action codes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingLeakRecordActionCodesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);

            try
            {
                // Retrieve leak record action codes
                Object result = apiInstance.RefrigeranttrackingLeakRecordActionCodes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingLeakRecordActionCodes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingLeakRecordActionCodesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve leak record action codes
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingLeakRecordActionCodesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingLeakRecordActionCodesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

<a id="refrigeranttrackingleakrecordfaultcodes"></a>
# **RefrigeranttrackingLeakRecordFaultCodes**
> Object RefrigeranttrackingLeakRecordFaultCodes ()

Retrieve leak record fault codes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingLeakRecordFaultCodesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);

            try
            {
                // Retrieve leak record fault codes
                Object result = apiInstance.RefrigeranttrackingLeakRecordFaultCodes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingLeakRecordFaultCodes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingLeakRecordFaultCodesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve leak record fault codes
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingLeakRecordFaultCodesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingLeakRecordFaultCodesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

<a id="refrigeranttrackingleakrecordimmearusable"></a>
# **RefrigeranttrackingLeakRecordImmearusable**
> Object RefrigeranttrackingLeakRecordImmearusable (SCServiceChannelServicesMessagingRefrigerantTrackingUpdateLeakImmeasurable request)

Update entity to RT_LeakImmeasurable

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingLeakRecordImmearusableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var request = new SCServiceChannelServicesMessagingRefrigerantTrackingUpdateLeakImmeasurable(); // SCServiceChannelServicesMessagingRefrigerantTrackingUpdateLeakImmeasurable | 

            try
            {
                // Update entity to RT_LeakImmeasurable
                Object result = apiInstance.RefrigeranttrackingLeakRecordImmearusable(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingLeakRecordImmearusable: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingLeakRecordImmearusableWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update entity to RT_LeakImmeasurable
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingLeakRecordImmearusableWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingLeakRecordImmearusableWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingRefrigerantTrackingUpdateLeakImmeasurable**](SCServiceChannelServicesMessagingRefrigerantTrackingUpdateLeakImmeasurable.md) |  |  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingleakrecordimmearusable_0"></a>
# **RefrigeranttrackingLeakRecordImmearusable_0**
> Object RefrigeranttrackingLeakRecordImmearusable_0 (SCServiceChannelServicesMessagingRefrigerantTrackingAddLeakImmeasurableRequest request)

Add entity to RT_LeakImmeasurable

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingLeakRecordImmearusable_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var request = new SCServiceChannelServicesMessagingRefrigerantTrackingAddLeakImmeasurableRequest(); // SCServiceChannelServicesMessagingRefrigerantTrackingAddLeakImmeasurableRequest | 

            try
            {
                // Add entity to RT_LeakImmeasurable
                Object result = apiInstance.RefrigeranttrackingLeakRecordImmearusable_0(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingLeakRecordImmearusable_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingLeakRecordImmearusable_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add entity to RT_LeakImmeasurable
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingLeakRecordImmearusable_0WithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingLeakRecordImmearusable_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingRefrigerantTrackingAddLeakImmeasurableRequest**](SCServiceChannelServicesMessagingRefrigerantTrackingAddLeakImmeasurableRequest.md) |  |  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingleakrecordimmearusabletrackingnumberassetidassetid"></a>
# **RefrigeranttrackingLeakRecordImmearusabletrackingNumberassetidassetid**
> Object RefrigeranttrackingLeakRecordImmearusabletrackingNumberassetidassetid (int trackingNumber, int? assetid = null)

Get LeakImmeasurable by recId and assetID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingLeakRecordImmearusabletrackingNumberassetidassetidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var trackingNumber = 56;  // int | 
            var assetid = 56;  // int? |  (optional) 

            try
            {
                // Get LeakImmeasurable by recId and assetID
                Object result = apiInstance.RefrigeranttrackingLeakRecordImmearusabletrackingNumberassetidassetid(trackingNumber, assetid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingLeakRecordImmearusabletrackingNumberassetidassetid: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingLeakRecordImmearusabletrackingNumberassetidassetidWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get LeakImmeasurable by recId and assetID
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingLeakRecordImmearusabletrackingNumberassetidassetidWithHttpInfo(trackingNumber, assetid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingLeakRecordImmearusabletrackingNumberassetidassetidWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **trackingNumber** | **int** |  |  |
| **assetid** | **int?** |  | [optional]  |

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
| **500** | Indicates that the server encountered an unexpected condition that prevented it from fulfilling the request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingleakverificationmethods"></a>
# **RefrigeranttrackingLeakVerificationMethods**
> List&lt;SCServiceChannelServicesMessagingLeakRecordLeakVerifyMethod&gt; RefrigeranttrackingLeakVerificationMethods ()

Get Leak Verification Methods

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingLeakVerificationMethodsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);

            try
            {
                // Get Leak Verification Methods
                List<SCServiceChannelServicesMessagingLeakRecordLeakVerifyMethod> result = apiInstance.RefrigeranttrackingLeakVerificationMethods();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingLeakVerificationMethods: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingLeakVerificationMethodsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Leak Verification Methods
    ApiResponse<List<SCServiceChannelServicesMessagingLeakRecordLeakVerifyMethod>> response = apiInstance.RefrigeranttrackingLeakVerificationMethodsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingLeakVerificationMethodsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;SCServiceChannelServicesMessagingLeakRecordLeakVerifyMethod&gt;**](SCServiceChannelServicesMessagingLeakRecordLeakVerifyMethod.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **500** | Indicates that the server encountered an unexpected condition that prevented it from fulfilling the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingleakareas"></a>
# **RefrigeranttrackingLeakareas**
> Object RefrigeranttrackingLeakareas ()

Get leak areas

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingLeakareasExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);

            try
            {
                // Get leak areas
                Object result = apiInstance.RefrigeranttrackingLeakareas();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingLeakareas: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingLeakareasWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get leak areas
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingLeakareasWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingLeakareasWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:                          &lt;br/&gt; 502 - No Get leak Areas; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              &lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingleakrecord"></a>
# **RefrigeranttrackingLeakrecord**
> Object RefrigeranttrackingLeakrecord (SCServiceChannelServicesMessagingRefrigerantTrackingUpdateLeakRecordRequest request)

UpdateLeakRecord

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingLeakrecordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var request = new SCServiceChannelServicesMessagingRefrigerantTrackingUpdateLeakRecordRequest(); // SCServiceChannelServicesMessagingRefrigerantTrackingUpdateLeakRecordRequest | 

            try
            {
                // UpdateLeakRecord
                Object result = apiInstance.RefrigeranttrackingLeakrecord(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingLeakrecord: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingLeakrecordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpdateLeakRecord
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingLeakrecordWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingLeakrecordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingRefrigerantTrackingUpdateLeakRecordRequest**](SCServiceChannelServicesMessagingRefrigerantTrackingUpdateLeakRecordRequest.md) |  |  |

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
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:                          &lt;br/&gt; 502 - No Update Leak Record; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              &lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingleakrecordv1"></a>
# **RefrigeranttrackingLeakrecordV1**
> Object RefrigeranttrackingLeakrecordV1 (SCServiceChannelServicesMessagingRefrigerantTrackingUpdateLeakRecordRequest request)

UpdateLeakRecord With Returns Detail Operation Result

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingLeakrecordV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var request = new SCServiceChannelServicesMessagingRefrigerantTrackingUpdateLeakRecordRequest(); // SCServiceChannelServicesMessagingRefrigerantTrackingUpdateLeakRecordRequest | 

            try
            {
                // UpdateLeakRecord With Returns Detail Operation Result
                Object result = apiInstance.RefrigeranttrackingLeakrecordV1(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingLeakrecordV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingLeakrecordV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpdateLeakRecord With Returns Detail Operation Result
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingLeakrecordV1WithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingLeakrecordV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingRefrigerantTrackingUpdateLeakRecordRequest**](SCServiceChannelServicesMessagingRefrigerantTrackingUpdateLeakRecordRequest.md) |  |  |

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
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:                          &lt;br/&gt; 502 - No Update Leak Record; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              &lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingleakrecords"></a>
# **RefrigeranttrackingLeakrecords**
> Object RefrigeranttrackingLeakrecords (SCServiceChannelServicesMessagingRefrigerantTrackingGetPagedLeakRecordsByFilterRequest request)

Retrieve leak records by filter

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingLeakrecordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var request = new SCServiceChannelServicesMessagingRefrigerantTrackingGetPagedLeakRecordsByFilterRequest(); // SCServiceChannelServicesMessagingRefrigerantTrackingGetPagedLeakRecordsByFilterRequest | 

            try
            {
                // Retrieve leak records by filter
                Object result = apiInstance.RefrigeranttrackingLeakrecords(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingLeakrecords: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingLeakrecordsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve leak records by filter
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingLeakrecordsWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingLeakrecordsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingRefrigerantTrackingGetPagedLeakRecordsByFilterRequest**](SCServiceChannelServicesMessagingRefrigerantTrackingGetPagedLeakRecordsByFilterRequest.md) |  |  |

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

<a id="refrigeranttrackingleakrecordstrackingnumber"></a>
# **RefrigeranttrackingLeakrecordstrackingNumber**
> Object RefrigeranttrackingLeakrecordstrackingNumber (int trackingNumber)

Get LeakRecords with LeakImmeasurable

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingLeakrecordstrackingNumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var trackingNumber = 56;  // int | 

            try
            {
                // Get LeakRecords with LeakImmeasurable
                Object result = apiInstance.RefrigeranttrackingLeakrecordstrackingNumber(trackingNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingLeakrecordstrackingNumber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingLeakrecordstrackingNumberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get LeakRecords with LeakImmeasurable
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingLeakrecordstrackingNumberWithHttpInfo(trackingNumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingLeakrecordstrackingNumberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **trackingNumber** | **int** |  |  |

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
| **500** | Indicates that the server encountered an unexpected condition that prevented it from fulfilling the request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingoperationalstatuses"></a>
# **RefrigeranttrackingOperationalStatuses**
> Object RefrigeranttrackingOperationalStatuses ()

Get Operational Statuses

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingOperationalStatusesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);

            try
            {
                // Get Operational Statuses
                Object result = apiInstance.RefrigeranttrackingOperationalStatuses();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingOperationalStatuses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingOperationalStatusesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Operational Statuses
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingOperationalStatusesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingOperationalStatusesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingrack"></a>
# **RefrigeranttrackingRack**
> Object RefrigeranttrackingRack (SCServiceChannelServicesMessagingRefrigerantTrackingCreateUpdateRackConnectionRequest request)

Create/Update Rack Connection

Create/Update Rack Connection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingRackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var request = new SCServiceChannelServicesMessagingRefrigerantTrackingCreateUpdateRackConnectionRequest(); // SCServiceChannelServicesMessagingRefrigerantTrackingCreateUpdateRackConnectionRequest | 

            try
            {
                // Create/Update Rack Connection
                Object result = apiInstance.RefrigeranttrackingRack(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingRack: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingRackWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create/Update Rack Connection
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingRackWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingRackWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingRefrigerantTrackingCreateUpdateRackConnectionRequest**](SCServiceChannelServicesMessagingRefrigerantTrackingCreateUpdateRackConnectionRequest.md) |  |  |

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
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:                         &lt;br/&gt; 502 - No Get Rack Connection |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              &lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingrackidid"></a>
# **RefrigeranttrackingRackidid**
> Object RefrigeranttrackingRackidid (int id)

Get Rack Connection

Rack Connection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingRackididExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var id = 56;  // int | 

            try
            {
                // Get Rack Connection
                Object result = apiInstance.RefrigeranttrackingRackidid(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingRackidid: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingRackididWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Rack Connection
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingRackididWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingRackididWithHttpInfo: " + e.Message);
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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:                         &lt;br/&gt; 502 - No Get Rack Connection |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              &lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingrefrigeranttypessubscriberidsubscriberid"></a>
# **RefrigeranttrackingRefrigerantTypessubscriberIdsubscriberId**
> Object RefrigeranttrackingRefrigerantTypessubscriberIdsubscriberId (int subscriberId)

Get refrigerant types

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingRefrigerantTypessubscriberIdsubscriberIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var subscriberId = 56;  // int | 

            try
            {
                // Get refrigerant types
                Object result = apiInstance.RefrigeranttrackingRefrigerantTypessubscriberIdsubscriberId(subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingRefrigerantTypessubscriberIdsubscriberId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingRefrigerantTypessubscriberIdsubscriberIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get refrigerant types
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingRefrigerantTypessubscriberIdsubscriberIdWithHttpInfo(subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingRefrigerantTypessubscriberIdsubscriberIdWithHttpInfo: " + e.Message);
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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:                          &lt;br/&gt; 502 - No Get Refrigerant Types; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingretireretrofitplans"></a>
# **RefrigeranttrackingRetireretrofitplans**
> Object RefrigeranttrackingRetireretrofitplans (SCServiceChannelServicesMessagingRefrigerantTrackingGetPagedLeakRecordsByFilterRequest request)

Retrieve retire retrofit plans

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingRetireretrofitplansExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var request = new SCServiceChannelServicesMessagingRefrigerantTrackingGetPagedLeakRecordsByFilterRequest(); // SCServiceChannelServicesMessagingRefrigerantTrackingGetPagedLeakRecordsByFilterRequest | 

            try
            {
                // Retrieve retire retrofit plans
                Object result = apiInstance.RefrigeranttrackingRetireretrofitplans(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingRetireretrofitplans: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingRetireretrofitplansWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve retire retrofit plans
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingRetireretrofitplansWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingRetireretrofitplansWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingRefrigerantTrackingGetPagedLeakRecordsByFilterRequest**](SCServiceChannelServicesMessagingRefrigerantTrackingGetPagedLeakRecordsByFilterRequest.md) |  |  |

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

<a id="refrigeranttrackingsaverefrigerationdetails"></a>
# **RefrigeranttrackingSaveRefrigerationDetails**
> Object RefrigeranttrackingSaveRefrigerationDetails (SCServiceChannelServicesMessagingRefrigerantTrackingEditAssetRefrigerantRequest assetRefrigerant)

Add/Update Refrigeration Details for an asset

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingSaveRefrigerationDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var assetRefrigerant = new SCServiceChannelServicesMessagingRefrigerantTrackingEditAssetRefrigerantRequest(); // SCServiceChannelServicesMessagingRefrigerantTrackingEditAssetRefrigerantRequest | 

            try
            {
                // Add/Update Refrigeration Details for an asset
                Object result = apiInstance.RefrigeranttrackingSaveRefrigerationDetails(assetRefrigerant);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingSaveRefrigerationDetails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingSaveRefrigerationDetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add/Update Refrigeration Details for an asset
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingSaveRefrigerationDetailsWithHttpInfo(assetRefrigerant);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingSaveRefrigerationDetailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetRefrigerant** | [**SCServiceChannelServicesMessagingRefrigerantTrackingEditAssetRefrigerantRequest**](SCServiceChannelServicesMessagingRefrigerantTrackingEditAssetRefrigerantRequest.md) |  |  |

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

<a id="refrigeranttrackingsubscribers"></a>
# **RefrigeranttrackingSubscribers**
> Object RefrigeranttrackingSubscribers ()

Get SubscriberIds With RefrigerantTracking Feature Flag

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingSubscribersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);

            try
            {
                // Get SubscriberIds With RefrigerantTracking Feature Flag
                Object result = apiInstance.RefrigeranttrackingSubscribers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingSubscribers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingSubscribersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get SubscriberIds With RefrigerantTracking Feature Flag
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingSubscribersWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingSubscribersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:                          &lt;br/&gt; 502 - No Update/Insert Leak Tracking Preferences; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              &lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingsystemlocations"></a>
# **RefrigeranttrackingSystemLocations**
> Object RefrigeranttrackingSystemLocations ()

Get System Locations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingSystemLocationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);

            try
            {
                // Get System Locations
                Object result = apiInstance.RefrigeranttrackingSystemLocations();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingSystemLocations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingSystemLocationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get System Locations
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingSystemLocationsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingSystemLocationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingwoleakverification"></a>
# **RefrigeranttrackingWOLeakVerification**
> Object RefrigeranttrackingWOLeakVerification (SCServiceChannelServicesMessagingEquipmentsAddUpdatePmLeakVerificationsRequest request)

Update WOLeakVerification

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingWOLeakVerificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var request = new SCServiceChannelServicesMessagingEquipmentsAddUpdatePmLeakVerificationsRequest(); // SCServiceChannelServicesMessagingEquipmentsAddUpdatePmLeakVerificationsRequest | 

            try
            {
                // Update WOLeakVerification
                Object result = apiInstance.RefrigeranttrackingWOLeakVerification(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingWOLeakVerification: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingWOLeakVerificationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update WOLeakVerification
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingWOLeakVerificationWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingWOLeakVerificationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingEquipmentsAddUpdatePmLeakVerificationsRequest**](SCServiceChannelServicesMessagingEquipmentsAddUpdatePmLeakVerificationsRequest.md) |  |  |

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
| **200** | Indicates that the request succeeded. |  -  |
| **404** | Indicates that the recId is not found |  -  |
| **500** | Indicates that the server encountered an unexpected condition that prevented it from fulfilling the request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingwoleakverification_0"></a>
# **RefrigeranttrackingWOLeakVerification_0**
> Object RefrigeranttrackingWOLeakVerification_0 (SCServiceChannelServicesMessagingEquipmentsAddUpdatePmLeakVerificationsRequest request)

Add WOLeakVerification

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingWOLeakVerification_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var request = new SCServiceChannelServicesMessagingEquipmentsAddUpdatePmLeakVerificationsRequest(); // SCServiceChannelServicesMessagingEquipmentsAddUpdatePmLeakVerificationsRequest | 

            try
            {
                // Add WOLeakVerification
                Object result = apiInstance.RefrigeranttrackingWOLeakVerification_0(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingWOLeakVerification_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingWOLeakVerification_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add WOLeakVerification
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingWOLeakVerification_0WithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingWOLeakVerification_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingEquipmentsAddUpdatePmLeakVerificationsRequest**](SCServiceChannelServicesMessagingEquipmentsAddUpdatePmLeakVerificationsRequest.md) |  |  |

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
| **200** | Indicates that the request succeeded |  -  |
| **404** | Indicates that the recId is not found |  -  |
| **500** | Indicates that the server encountered an unexpected condition that prevented it from fulfilling the request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingwoleakverificationtrackingnumber"></a>
# **RefrigeranttrackingWOLeakVerificationtrackingNumber**
> SCServiceChannelApiModelRefrigerantTrackingWOLeakVerificationResponse RefrigeranttrackingWOLeakVerificationtrackingNumber (int trackingNumber)

Get WOLeakVerification by tracking number and assetId

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingWOLeakVerificationtrackingNumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var trackingNumber = 56;  // int | 

            try
            {
                // Get WOLeakVerification by tracking number and assetId
                SCServiceChannelApiModelRefrigerantTrackingWOLeakVerificationResponse result = apiInstance.RefrigeranttrackingWOLeakVerificationtrackingNumber(trackingNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingWOLeakVerificationtrackingNumber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingWOLeakVerificationtrackingNumberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get WOLeakVerification by tracking number and assetId
    ApiResponse<SCServiceChannelApiModelRefrigerantTrackingWOLeakVerificationResponse> response = apiInstance.RefrigeranttrackingWOLeakVerificationtrackingNumberWithHttpInfo(trackingNumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingWOLeakVerificationtrackingNumberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **trackingNumber** | **int** |  |  |

### Return type

[**SCServiceChannelApiModelRefrigerantTrackingWOLeakVerificationResponse**](SCServiceChannelApiModelRefrigerantTrackingWOLeakVerificationResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **404** | Indicates that the recId is not found |  -  |
| **500** | Indicates that the server encountered an unexpected condition that prevented it from fulfilling the request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttracking_0"></a>
# **Refrigeranttracking_0**
> Object Refrigeranttracking_0 (SCServiceChannelServicesMessagingEquipmentsGetAvailableRacksRequest request)

Get Rack Equipment

RackEquipment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class Refrigeranttracking_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var request = new SCServiceChannelServicesMessagingEquipmentsGetAvailableRacksRequest(); // SCServiceChannelServicesMessagingEquipmentsGetAvailableRacksRequest | 

            try
            {
                // Get Rack Equipment
                Object result = apiInstance.Refrigeranttracking_0(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.Refrigeranttracking_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Refrigeranttracking_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Rack Equipment
    ApiResponse<Object> response = apiInstance.Refrigeranttracking_0WithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.Refrigeranttracking_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingEquipmentsGetAvailableRacksRequest**](SCServiceChannelServicesMessagingEquipmentsGetAvailableRacksRequest.md) |  |  |

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
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:                         &lt;br/&gt; 502 - No Get Rack Equipments |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              &lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingassetidrefrigerantusagesummary"></a>
# **RefrigeranttrackingassetIdRefrigerantusagesummary**
> Object RefrigeranttrackingassetIdRefrigerantusagesummary (int assetId)

Get refrigerant usage summary

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingassetIdRefrigerantusagesummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var assetId = 56;  // int | 

            try
            {
                // Get refrigerant usage summary
                Object result = apiInstance.RefrigeranttrackingassetIdRefrigerantusagesummary(assetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingassetIdRefrigerantusagesummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingassetIdRefrigerantusagesummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get refrigerant usage summary
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingassetIdRefrigerantusagesummaryWithHttpInfo(assetId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingassetIdRefrigerantusagesummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetId** | **int** |  |  |

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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:                          &lt;br/&gt; 502 - No Update/Insert Leak Tracking Preferences; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              &lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingassettypeidgetrefrigerantusetypes"></a>
# **RefrigeranttrackingassetTypeIdGetRefrigerantUseTypes**
> Object RefrigeranttrackingassetTypeIdGetRefrigerantUseTypes (int assetTypeId)

Get refrigerant use types for equipment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingassetTypeIdGetRefrigerantUseTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var assetTypeId = 56;  // int | 

            try
            {
                // Get refrigerant use types for equipment
                Object result = apiInstance.RefrigeranttrackingassetTypeIdGetRefrigerantUseTypes(assetTypeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingassetTypeIdGetRefrigerantUseTypes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingassetTypeIdGetRefrigerantUseTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get refrigerant use types for equipment
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingassetTypeIdGetRefrigerantUseTypesWithHttpInfo(assetTypeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingassetTypeIdGetRefrigerantUseTypesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetTypeId** | **int** |  |  |

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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackinglocationidgetrefrigerantsettings"></a>
# **RefrigeranttrackinglocationIdGetRefrigerantSettings**
> Object RefrigeranttrackinglocationIdGetRefrigerantSettings (int locationId)

Get Refrigerant settings by locationId

GetRefrigerantSettingsByLocationId

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackinglocationIdGetRefrigerantSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var locationId = 56;  // int | Location Id

            try
            {
                // Get Refrigerant settings by locationId
                Object result = apiInstance.RefrigeranttrackinglocationIdGetRefrigerantSettings(locationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackinglocationIdGetRefrigerantSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackinglocationIdGetRefrigerantSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Refrigerant settings by locationId
    ApiResponse<Object> response = apiInstance.RefrigeranttrackinglocationIdGetRefrigerantSettingsWithHttpInfo(locationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackinglocationIdGetRefrigerantSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | Location Id |  |

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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:                         &lt;br/&gt; 502 - No Refrigerant Setings; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              &lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingsubscriberidgetrefrigerantusereasoncodes"></a>
# **RefrigeranttrackingsubscriberIdGetRefrigerantUseReasonCodes**
> Object RefrigeranttrackingsubscriberIdGetRefrigerantUseReasonCodes (int subscriberId)

Get Refrigerant Use Reason Codes

GetRefrigerantUseReasonCodes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingsubscriberIdGetRefrigerantUseReasonCodesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var subscriberId = 56;  // int | Subscriber Id

            try
            {
                // Get Refrigerant Use Reason Codes
                Object result = apiInstance.RefrigeranttrackingsubscriberIdGetRefrigerantUseReasonCodes(subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingsubscriberIdGetRefrigerantUseReasonCodes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingsubscriberIdGetRefrigerantUseReasonCodesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Refrigerant Use Reason Codes
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingsubscriberIdGetRefrigerantUseReasonCodesWithHttpInfo(subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingsubscriberIdGetRefrigerantUseReasonCodesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** | Subscriber Id |  |

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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:                         &lt;br/&gt; 502 - No Get Leak Tracking Preferences; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              &lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingsubscriberidleaklocations"></a>
# **RefrigeranttrackingsubscriberIdLeaklocations**
> Object RefrigeranttrackingsubscriberIdLeaklocations (int subscriberId)

Get leak locations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingsubscriberIdLeaklocationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var subscriberId = 56;  // int | 

            try
            {
                // Get leak locations
                Object result = apiInstance.RefrigeranttrackingsubscriberIdLeaklocations(subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingsubscriberIdLeaklocations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingsubscriberIdLeaklocationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get leak locations
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingsubscriberIdLeaklocationsWithHttpInfo(subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingsubscriberIdLeaklocationsWithHttpInfo: " + e.Message);
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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:                          &lt;br/&gt; 502 - No get Leak Locations; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              &lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingsubscriberidsubscriberid"></a>
# **RefrigeranttrackingsubscriberIdsubscriberId**
> Object RefrigeranttrackingsubscriberIdsubscriberId (int subscriberId)

Get Leak Tracking Preferences

GetLeakTrackingPreferences

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingsubscriberIdsubscriberIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var subscriberId = 56;  // int | Subscriber Id

            try
            {
                // Get Leak Tracking Preferences
                Object result = apiInstance.RefrigeranttrackingsubscriberIdsubscriberId(subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingsubscriberIdsubscriberId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingsubscriberIdsubscriberIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Leak Tracking Preferences
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingsubscriberIdsubscriberIdWithHttpInfo(subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingsubscriberIdsubscriberIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** | Subscriber Id |  |

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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:                         &lt;br/&gt; 502 - No Get Leak Tracking Preferences; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              &lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingtrackingnumberleakrecord"></a>
# **RefrigeranttrackingtrackingNumberLeakRecord**
> Object RefrigeranttrackingtrackingNumberLeakRecord (int trackingNumber)

Retrieve leak record by tracking number

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingtrackingNumberLeakRecordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var trackingNumber = 56;  // int | 

            try
            {
                // Retrieve leak record by tracking number
                Object result = apiInstance.RefrigeranttrackingtrackingNumberLeakRecord(trackingNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingtrackingNumberLeakRecord: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingtrackingNumberLeakRecordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve leak record by tracking number
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingtrackingNumberLeakRecordWithHttpInfo(trackingNumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingtrackingNumberLeakRecordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **trackingNumber** | **int** |  |  |

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

<a id="refrigeranttrackingworkorderidcheckrefrigerantwasusedisvalidforinvoiceablestatusesrefrigerantwasusedrefrigerantwasused"></a>
# **RefrigeranttrackingworkOrderIdCheckRefrigerantWasUsedIsValidForInvoiceableStatusesrefrigerantWasUsedrefrigerantWasUsed**
> Object RefrigeranttrackingworkOrderIdCheckRefrigerantWasUsedIsValidForInvoiceableStatusesrefrigerantWasUsedrefrigerantWasUsed (int workOrderId, string? refrigerantWasUsed = null)

Check If Used Refrigerant Is Valid For Invoiceble Statuses

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingworkOrderIdCheckRefrigerantWasUsedIsValidForInvoiceableStatusesrefrigerantWasUsedrefrigerantWasUsedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var workOrderId = 56;  // int | 
            var refrigerantWasUsed = "No";  // string? |  (optional) 

            try
            {
                // Check If Used Refrigerant Is Valid For Invoiceble Statuses
                Object result = apiInstance.RefrigeranttrackingworkOrderIdCheckRefrigerantWasUsedIsValidForInvoiceableStatusesrefrigerantWasUsedrefrigerantWasUsed(workOrderId, refrigerantWasUsed);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingworkOrderIdCheckRefrigerantWasUsedIsValidForInvoiceableStatusesrefrigerantWasUsedrefrigerantWasUsed: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingworkOrderIdCheckRefrigerantWasUsedIsValidForInvoiceableStatusesrefrigerantWasUsedrefrigerantWasUsedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check If Used Refrigerant Is Valid For Invoiceble Statuses
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingworkOrderIdCheckRefrigerantWasUsedIsValidForInvoiceableStatusesrefrigerantWasUsedrefrigerantWasUsedWithHttpInfo(workOrderId, refrigerantWasUsed);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingworkOrderIdCheckRefrigerantWasUsedIsValidForInvoiceableStatusesrefrigerantWasUsedrefrigerantWasUsedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrderId** | **int** |  |  |
| **refrigerantWasUsed** | **string?** |  | [optional]  |

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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingworkorderidcreateleakrecordfollowupwoforstatusupdate"></a>
# **RefrigeranttrackingworkOrderIdCreateLeakRecordFollowUpWoForStatusUpdate**
> Object RefrigeranttrackingworkOrderIdCreateLeakRecordFollowUpWoForStatusUpdate (int workOrderId)

Create Leak Record Follow Up WorkOrder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingworkOrderIdCreateLeakRecordFollowUpWoForStatusUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var workOrderId = 56;  // int | 

            try
            {
                // Create Leak Record Follow Up WorkOrder
                Object result = apiInstance.RefrigeranttrackingworkOrderIdCreateLeakRecordFollowUpWoForStatusUpdate(workOrderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingworkOrderIdCreateLeakRecordFollowUpWoForStatusUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingworkOrderIdCreateLeakRecordFollowUpWoForStatusUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Leak Record Follow Up WorkOrder
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingworkOrderIdCreateLeakRecordFollowUpWoForStatusUpdateWithHttpInfo(workOrderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingworkOrderIdCreateLeakRecordFollowUpWoForStatusUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrderId** | **int** |  |  |

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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refrigeranttrackingworkorderidiscompletedstatuseslimitedbyrtsetup"></a>
# **RefrigeranttrackingworkOrderIdIsCompletedStatusesLimitedByRTSetup**
> Object RefrigeranttrackingworkOrderIdIsCompletedStatusesLimitedByRTSetup (int workOrderId)

Check If WO Status Is Limited By RTSetup

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RefrigeranttrackingworkOrderIdIsCompletedStatusesLimitedByRTSetupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RefrigerantTrackingApi(config);
            var workOrderId = 56;  // int | 

            try
            {
                // Check If WO Status Is Limited By RTSetup
                Object result = apiInstance.RefrigeranttrackingworkOrderIdIsCompletedStatusesLimitedByRTSetup(workOrderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingworkOrderIdIsCompletedStatusesLimitedByRTSetup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefrigeranttrackingworkOrderIdIsCompletedStatusesLimitedByRTSetupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check If WO Status Is Limited By RTSetup
    ApiResponse<Object> response = apiInstance.RefrigeranttrackingworkOrderIdIsCompletedStatusesLimitedByRTSetupWithHttpInfo(workOrderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RefrigerantTrackingApi.RefrigeranttrackingworkOrderIdIsCompletedStatusesLimitedByRTSetupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrderId** | **int** |  |  |

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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

