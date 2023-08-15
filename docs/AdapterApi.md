# ServiceChannel.Api.Api.AdapterApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AdapterCheckInOutworkorders**](AdapterApi.md#adaptercheckinoutworkorders) | **POST** /adapter/checkInOutworkorders | CheckIn/checkOut of work order |
| [**AdapterProviderAssignments**](AdapterApi.md#adapterproviderassignments) | **POST** /adapter/providerAssignments | Assign provider |
| [**AdapterUpdateProposalStatus**](AdapterApi.md#adapterupdateproposalstatus) | **POST** /adapter/UpdateProposalStatus | Update proposal status |
| [**AdapterUpdatelocationnotes**](AdapterApi.md#adapterupdatelocationnotes) | **POST** /adapter/updatelocationnotes | Update location notes |
| [**AdapterUpdateworkorders**](AdapterApi.md#adapterupdateworkorders) | **POST** /adapter/updateworkorders | Update work order |
| [**AdapterWorkorders**](AdapterApi.md#adapterworkorders) | **POST** /adapter/workorders | Create a new work order |

<a id="adaptercheckinoutworkorders"></a>
# **AdapterCheckInOutworkorders**
> SCServiceChannelServicesBrokerModelsProcessingWorkOrderResponse AdapterCheckInOutworkorders (SCServiceChannelServicesMessagingNotificationMessageServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrderCheckInOut message)

CheckIn/checkOut of work order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AdapterCheckInOutworkordersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdapterApi(config);
            var message = new SCServiceChannelServicesMessagingNotificationMessageServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrderCheckInOut(); // SCServiceChannelServicesMessagingNotificationMessageServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrderCheckInOut | 

            try
            {
                // CheckIn/checkOut of work order
                SCServiceChannelServicesBrokerModelsProcessingWorkOrderResponse result = apiInstance.AdapterCheckInOutworkorders(message);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdapterApi.AdapterCheckInOutworkorders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdapterCheckInOutworkordersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CheckIn/checkOut of work order
    ApiResponse<SCServiceChannelServicesBrokerModelsProcessingWorkOrderResponse> response = apiInstance.AdapterCheckInOutworkordersWithHttpInfo(message);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AdapterApi.AdapterCheckInOutworkordersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **message** | [**SCServiceChannelServicesMessagingNotificationMessageServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrderCheckInOut**](SCServiceChannelServicesMessagingNotificationMessageServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrderCheckInOut.md) |  |  |

### Return type

[**SCServiceChannelServicesBrokerModelsProcessingWorkOrderResponse**](SCServiceChannelServicesBrokerModelsProcessingWorkOrderResponse.md)

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
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="adapterproviderassignments"></a>
# **AdapterProviderAssignments**
> void AdapterProviderAssignments (SCServiceChannelServicesMessagingLocationProviderTradeAssignmentNotificationObject message)

Assign provider

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AdapterProviderAssignmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdapterApi(config);
            var message = new SCServiceChannelServicesMessagingLocationProviderTradeAssignmentNotificationObject(); // SCServiceChannelServicesMessagingLocationProviderTradeAssignmentNotificationObject | 

            try
            {
                // Assign provider
                apiInstance.AdapterProviderAssignments(message);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdapterApi.AdapterProviderAssignments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdapterProviderAssignmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Assign provider
    apiInstance.AdapterProviderAssignmentsWithHttpInfo(message);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AdapterApi.AdapterProviderAssignmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **message** | [**SCServiceChannelServicesMessagingLocationProviderTradeAssignmentNotificationObject**](SCServiceChannelServicesMessagingLocationProviderTradeAssignmentNotificationObject.md) |  |  |

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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="adapterupdateproposalstatus"></a>
# **AdapterUpdateProposalStatus**
> SCServiceChannelServicesBrokerModelsProcessingProposalResponse AdapterUpdateProposalStatus (SCServiceChannelServicesMessagingLocationNoteProposalNotificationObject message)

Update proposal status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AdapterUpdateProposalStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdapterApi(config);
            var message = new SCServiceChannelServicesMessagingLocationNoteProposalNotificationObject(); // SCServiceChannelServicesMessagingLocationNoteProposalNotificationObject | 

            try
            {
                // Update proposal status
                SCServiceChannelServicesBrokerModelsProcessingProposalResponse result = apiInstance.AdapterUpdateProposalStatus(message);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdapterApi.AdapterUpdateProposalStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdapterUpdateProposalStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update proposal status
    ApiResponse<SCServiceChannelServicesBrokerModelsProcessingProposalResponse> response = apiInstance.AdapterUpdateProposalStatusWithHttpInfo(message);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AdapterApi.AdapterUpdateProposalStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **message** | [**SCServiceChannelServicesMessagingLocationNoteProposalNotificationObject**](SCServiceChannelServicesMessagingLocationNoteProposalNotificationObject.md) |  |  |

### Return type

[**SCServiceChannelServicesBrokerModelsProcessingProposalResponse**](SCServiceChannelServicesBrokerModelsProcessingProposalResponse.md)

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
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="adapterupdatelocationnotes"></a>
# **AdapterUpdatelocationnotes**
> void AdapterUpdatelocationnotes (SCServiceChannelServicesMessagingLocationNoteLocationNotesNotificationObject message)

Update location notes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AdapterUpdatelocationnotesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdapterApi(config);
            var message = new SCServiceChannelServicesMessagingLocationNoteLocationNotesNotificationObject(); // SCServiceChannelServicesMessagingLocationNoteLocationNotesNotificationObject | 

            try
            {
                // Update location notes
                apiInstance.AdapterUpdatelocationnotes(message);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdapterApi.AdapterUpdatelocationnotes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdapterUpdatelocationnotesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update location notes
    apiInstance.AdapterUpdatelocationnotesWithHttpInfo(message);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AdapterApi.AdapterUpdatelocationnotesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **message** | [**SCServiceChannelServicesMessagingLocationNoteLocationNotesNotificationObject**](SCServiceChannelServicesMessagingLocationNoteLocationNotesNotificationObject.md) |  |  |

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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="adapterupdateworkorders"></a>
# **AdapterUpdateworkorders**
> SCServiceChannelServicesBrokerModelsProcessingWorkOrderResponse AdapterUpdateworkorders (SCServiceChannelServicesMessagingNotificationMessageServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrder message)

Update work order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AdapterUpdateworkordersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdapterApi(config);
            var message = new SCServiceChannelServicesMessagingNotificationMessageServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrder(); // SCServiceChannelServicesMessagingNotificationMessageServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrder | Message envelope containing a body and describes an event type and the body version              <br />Expect the Object of type **ServiceChannel.Notifications.Objects.WorkOrder** for the following EventType values:               • **WorkOrderStatusChanged**.               • **RefrigerantWasUsedChanged**.               • **WorkOrderCertifiedTechnicianAssigned**.               • **WorkOrderAttachmentAdded**.               • **WorkOrderTradeChanged**.               • **WorkOrderIssueChoiceChanged**.               • **WorkOrderNteChanged**.               • **WorkOrderScheduledDateChanged**.               • **WorkOrderPriorityChanged**.               • **WorkOrderCategoryChanged**.               • **WorkOrderDescriptionChanged**.               • **WorkOrderAssetAttached**.               • **WorkOrderAssetDetached**.               • **WorkOrderAssetValidated**.               • **WorkOrderRootCauseCodeUpdated**.               • **WorkOrderResolutionCodeUpdated**.               • **WorkOrderResolutionCreated**.               • **WorkOrderResolutionUpdated**.               • **WorkOrderLabelAdded**.               • **WorkOrderLabelDeleted**.               • **WorkOrderNoteAdded**.

            try
            {
                // Update work order
                SCServiceChannelServicesBrokerModelsProcessingWorkOrderResponse result = apiInstance.AdapterUpdateworkorders(message);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdapterApi.AdapterUpdateworkorders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdapterUpdateworkordersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update work order
    ApiResponse<SCServiceChannelServicesBrokerModelsProcessingWorkOrderResponse> response = apiInstance.AdapterUpdateworkordersWithHttpInfo(message);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AdapterApi.AdapterUpdateworkordersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **message** | [**SCServiceChannelServicesMessagingNotificationMessageServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrder**](SCServiceChannelServicesMessagingNotificationMessageServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrder.md) | Message envelope containing a body and describes an event type and the body version              &lt;br /&gt;Expect the Object of type **ServiceChannel.Notifications.Objects.WorkOrder** for the following EventType values:               • **WorkOrderStatusChanged**.               • **RefrigerantWasUsedChanged**.               • **WorkOrderCertifiedTechnicianAssigned**.               • **WorkOrderAttachmentAdded**.               • **WorkOrderTradeChanged**.               • **WorkOrderIssueChoiceChanged**.               • **WorkOrderNteChanged**.               • **WorkOrderScheduledDateChanged**.               • **WorkOrderPriorityChanged**.               • **WorkOrderCategoryChanged**.               • **WorkOrderDescriptionChanged**.               • **WorkOrderAssetAttached**.               • **WorkOrderAssetDetached**.               • **WorkOrderAssetValidated**.               • **WorkOrderRootCauseCodeUpdated**.               • **WorkOrderResolutionCodeUpdated**.               • **WorkOrderResolutionCreated**.               • **WorkOrderResolutionUpdated**.               • **WorkOrderLabelAdded**.               • **WorkOrderLabelDeleted**.               • **WorkOrderNoteAdded**. |  |

### Return type

[**SCServiceChannelServicesBrokerModelsProcessingWorkOrderResponse**](SCServiceChannelServicesBrokerModelsProcessingWorkOrderResponse.md)

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
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="adapterworkorders"></a>
# **AdapterWorkorders**
> SCServiceChannelServicesBrokerModelsProcessingWorkOrderResponse AdapterWorkorders (SCServiceChannelServicesMessagingNotificationMessageServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrder message)

Create a new work order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AdapterWorkordersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdapterApi(config);
            var message = new SCServiceChannelServicesMessagingNotificationMessageServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrder(); // SCServiceChannelServicesMessagingNotificationMessageServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrder | Message envelope containing a body and describes an event type and the body version.              Expects EventType WorkOrderCreated

            try
            {
                // Create a new work order
                SCServiceChannelServicesBrokerModelsProcessingWorkOrderResponse result = apiInstance.AdapterWorkorders(message);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdapterApi.AdapterWorkorders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdapterWorkordersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new work order
    ApiResponse<SCServiceChannelServicesBrokerModelsProcessingWorkOrderResponse> response = apiInstance.AdapterWorkordersWithHttpInfo(message);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AdapterApi.AdapterWorkordersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **message** | [**SCServiceChannelServicesMessagingNotificationMessageServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrder**](SCServiceChannelServicesMessagingNotificationMessageServiceChannelServicesBrokerModelsContextsRequestBrokerWorkOrder.md) | Message envelope containing a body and describes an event type and the body version.              Expects EventType WorkOrderCreated |  |

### Return type

[**SCServiceChannelServicesBrokerModelsProcessingWorkOrderResponse**](SCServiceChannelServicesBrokerModelsProcessingWorkOrderResponse.md)

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
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

