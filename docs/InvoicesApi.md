# ServiceChannel.Api.Api.InvoicesApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetInvoices**](InvoicesApi.md#getinvoices) | **GET** /odata/invoices | Retrieve Invoices |
| [**Invoices**](InvoicesApi.md#invoices) | **POST** /invoices | Add an invoice to a work order |
| [**InvoicesPayments**](InvoicesApi.md#invoicespayments) | **POST** /invoices/Payments | Add payment records to invoices |
| [**InvoicesPingserviceName**](InvoicesApi.md#invoicespingservicename) | **GET** /invoices/ping/{serviceName} | Checks state of a service for invoice. |
| [**InvoicesStatisticsdaysPerioddaysPeriodapprovedInThePastDaysPeriodapprovedInThePastDaysPeriod**](InvoicesApi.md#invoicesstatisticsdaysperioddaysperiodapprovedinthepastdaysperiodapprovedinthepastdaysperiod) | **GET** /invoices/statistics | Retrieve statistics of all invoices |
| [**InvoicesWorkorderstrackingNumberPayment**](InvoicesApi.md#invoicesworkorderstrackingnumberpayment) | **POST** /invoices/Workorders/{trackingNumber}/Payment | Add a payment record to an invoice by a tracking number |
| [**InvoicesinvoiceId**](InvoicesApi.md#invoicesinvoiceid) | **GET** /invoices/{invoiceId} | Get an invoice |
| [**InvoicesinvoiceIdApproveapprovalCodeapprovalCodecommentscommentscategorycategory**](InvoicesApi.md#invoicesinvoiceidapproveapprovalcodeapprovalcodecommentscommentscategorycategory) | **PUT** /invoices/{invoiceId}/approve | Allows approve non-MLI(Multilevel Invoice Approval) invoice |
| [**InvoicesinvoiceIdDiscrepancy**](InvoicesApi.md#invoicesinvoiceiddiscrepancy) | **GET** /invoices/{invoiceId}/discrepancy | Get rates discrepancy |
| [**InvoicesinvoiceIdDiscrepancyExtended**](InvoicesApi.md#invoicesinvoiceiddiscrepancyextended) | **GET** /invoices/{invoiceId}/discrepancyExtended | Get rates discrepancy |
| [**InvoicesinvoiceIdOnholdcommentscomments**](InvoicesApi.md#invoicesinvoiceidonholdcommentscomments) | **PUT** /invoices/{invoiceId}/onhold | Allows put invoice on hold for non-MLI(Multilevel Invoice Approval) invoice |
| [**InvoicesinvoiceIdPayment**](InvoicesApi.md#invoicesinvoiceidpayment) | **POST** /invoices/{invoiceId}/Payment | Add a payment to an invoice |
| [**InvoicesinvoiceIdRejectcommentscomments**](InvoicesApi.md#invoicesinvoiceidrejectcommentscomments) | **PUT** /invoices/{invoiceId}/reject | Allows reject non-MLI(Multilevel Invoice Approval) invoice |
| [**InvoicessubscriberIdInvoiceRejectionReasons**](InvoicesApi.md#invoicessubscriberidinvoicerejectionreasons) | **GET** /invoices/{subscriberId}/InvoiceRejectionReasons | Retrieve invoice rejection reasons for a subscriber |
| [**InvoicessubscriberIdInvoiceRequirements**](InvoicesApi.md#invoicessubscriberidinvoicerequirements) | **GET** /invoices/{subscriberId}/InvoiceRequirements | Retrieve general invoice settings for a subscriber |
| [**SubscriberssubscriberIdInvoicesinvoiceIdApproveorderIdorderIduserIduserIdapprovalCodeapprovalCodeorganizationPermissionIdorganizationPermissionIdcategorycategorycommentcommentoverrideUserIdoverrideUserId**](InvoicesApi.md#subscriberssubscriberidinvoicesinvoiceidapproveorderidorderiduseriduseridapprovalcodeapprovalcodeorganizationpermissionidorganizationpermissionidcategorycategorycommentcommentoverrideuseridoverrideuserid) | **GET** /subscribers/{subscriberId}/invoices/{invoiceId}/approve |  |

<a id="getinvoices"></a>
# **GetInvoices**
> List&lt;SCServiceChannelServicesMessagingInvoicesInvoice&gt; GetInvoices (string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Retrieve Invoices

Returns a list of invoices posted within the last 90 days if not specified otherwise in `$filter`. The maximum date range between the invoice `PostedDate` and the current date is 365 days.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetInvoicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(config);
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Retrieve Invoices
                List<SCServiceChannelServicesMessagingInvoicesInvoice> result = apiInstance.GetInvoices(expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvoicesApi.GetInvoices: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInvoicesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Invoices
    ApiResponse<List<SCServiceChannelServicesMessagingInvoicesInvoice>> response = apiInstance.GetInvoicesWithHttpInfo(expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvoicesApi.GetInvoicesWithHttpInfo: " + e.Message);
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

[**List&lt;SCServiceChannelServicesMessagingInvoicesInvoice&gt;**](SCServiceChannelServicesMessagingInvoicesInvoice.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested invoices are in the response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="invoices"></a>
# **Invoices**
> void Invoices (SCServiceChannelServicesMessagingInvoicesCreateInvoiceRequest request)

Add an invoice to a work order

Creates an invoice in the *Open* status for the specified work order.              <br />Find out more about [creating an invoice](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/2205811424/Creating+an+Invoice) in ServiceChannel University.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class InvoicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(config);
            var request = new SCServiceChannelServicesMessagingInvoicesCreateInvoiceRequest(); // SCServiceChannelServicesMessagingInvoicesCreateInvoiceRequest | Request model to create an invoice for the specified work order.              <br />**Required parameters**:               • **InvoiceNumber**. Invoice number created by a user.               • **WoIdentifier**. Unique work order identifier (can be *TrackingNumber* or *WorkOrderNumber* for Contractor and *TrackingNumber* or *PurchaseNumber* for Client).              <br />If there is no need to specify any details in *Labors*, *Materials*, *Travels*, and *Others* objects, you can send the request without them.               <br />**Note**: Work Order should be in the *Completed* status to successfully create an invoice.

            try
            {
                // Add an invoice to a work order
                apiInstance.Invoices(request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvoicesApi.Invoices: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoicesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add an invoice to a work order
    apiInstance.InvoicesWithHttpInfo(request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvoicesApi.InvoicesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingInvoicesCreateInvoiceRequest**](SCServiceChannelServicesMessagingInvoicesCreateInvoiceRequest.md) | Request model to create an invoice for the specified work order.              &lt;br /&gt;**Required parameters**:               • **InvoiceNumber**. Invoice number created by a user.               • **WoIdentifier**. Unique work order identifier (can be *TrackingNumber* or *WorkOrderNumber* for Contractor and *TrackingNumber* or *PurchaseNumber* for Client).              &lt;br /&gt;If there is no need to specify any details in *Labors*, *Materials*, *Travels*, and *Others* objects, you can send the request without them.               &lt;br /&gt;**Note**: Work Order should be in the *Completed* status to successfully create an invoice. |  |

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
| **201** | The ID of the created invoice is in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              503 — Request should not be null              601 — Location not found              607 — Empty Location State              904 — Invalid WO Status. WO must be in &#39;COMPLETED&#39; status with empty extended status or &#39;COMPLETED&#39; status with &#39;CONFIRMED&#39; extended status              914 — Invalid &#39;Currency&#39; value              917 — Invalid Tracking Number              1100 — Invalid Other Amount Description              1101 — Invalid Tax2 name              1103 — Invalid Total              1104 — Invoice Total &gt; NTE              1105 — Invoice exists              1106 — Invoice Creation Error              1107 — Duplicate Invoice number              1108 — Total is null              1109 — Completed Date is null              1110 — Invoice Date &lt; Completed Date              1111 — This invoice is set to auto-invoice              1112 — Electronic Signature Agreement Required              1113 — Work order not found              1114 — Wrong Work Order currency              1115 — Work order currency not found              1116 — Invoicing is disabled. Invoicing might be disabled if your company account is currently in an inactive state in Fixxbook              1117 — Invoice creation Unexpected Result              1119 — Invoice labor amount is not equals summary labor items               1120 — Invoice material amount is not equals summary material items amounts              1121 — Invoice Date is older than X day(s) from today              1122 — Invoice Date is greater than X day(s) from today              1123 — Invoice material description length overflow              1124 — Invoice material part number length overflow              1125 — Tax validation error: X              1126 — Sales Tax should be 0 - X location              1127 — Invalid Invoice Number              1135 — Locations can&#39;t have GST tax              1136 — Locations can&#39;t have tax2. Only Canadian or European Location can have the Tax2Details array. Tax2Details is only applicable for locations in countries that have some form of a value-added tax              1145 — You have an outstanding balance with ServiceChannel.  In order to invoice, please login to Fixxbook.com and update your Payment Method.  Once your payment Method is updated you will be able to invoice.;              1146 — Invoice doesn&#39;t have Taxes Breakdown              1147 — Invoice Taxes Breakdown has incorrect sum              1151 — Labor Line Items Required              1152 — Material Line Items Required              1159 — Invoice material unit type is invalid (should be from 1 to 7)              1163 — Resolution text required in Invoice Text field              1180 — Invoice Number is not correct              1194 - Invoice labor skill level is invalid (should be from 1 to 3)              1195 — Invoice labor type is invalid (should be from 1 to 3)              1196 — Invoice technician quantity is invalid (should be &gt; 0)              1198 — The explanation of Dispute status is empty |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="invoicespayments"></a>
# **InvoicesPayments**
> SCServiceChannelServicesMessagingInvoicesInvoicePaymentBulkResponse InvoicesPayments (SCServiceChannelServicesMessagingInvoicesInvoicePaymentBulkRequest request)

Add payment records to invoices

Creates payment records for the invoices in the *Approved* status in bulk.               <br />**Note**: Method is available to users with the *SC Admin*, *Master Admin*, or *Invoice Admin* roles and with the *InvoiceChangeToPaid* feature flag enabled.               <br />**Example Request**                                  POST /invoices/{invoiceId}/Payment                   {                     \"Payments\": [                       {                         \"InvoiceId\": 96814318,                         \"PaymentDate\": \"2021-12-13T06:12:22.820Z\",                         \"PaymentNumber\": \"456858\",                         \"PaymentAmount\": 756                       },                       {                         \"InvoiceId\": 4988659,                         \"PaymentDate\": \"2021-12-13T06:12:22.820Z\",                         \"PaymentNumber\": \"97027818\",                         \"PaymentAmount\": 1250.55                       }                       ]                   }

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class InvoicesPaymentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(config);
            var request = new SCServiceChannelServicesMessagingInvoicesInvoicePaymentBulkRequest(); // SCServiceChannelServicesMessagingInvoicesInvoicePaymentBulkRequest | Request model to add payment records in bulk.

            try
            {
                // Add payment records to invoices
                SCServiceChannelServicesMessagingInvoicesInvoicePaymentBulkResponse result = apiInstance.InvoicesPayments(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvoicesApi.InvoicesPayments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoicesPaymentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add payment records to invoices
    ApiResponse<SCServiceChannelServicesMessagingInvoicesInvoicePaymentBulkResponse> response = apiInstance.InvoicesPaymentsWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvoicesApi.InvoicesPaymentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingInvoicesInvoicePaymentBulkRequest**](SCServiceChannelServicesMessagingInvoicesInvoicePaymentBulkRequest.md) | Request model to add payment records in bulk. |  |

### Return type

[**SCServiceChannelServicesMessagingInvoicesInvoicePaymentBulkResponse**](SCServiceChannelServicesMessagingInvoicesInvoicePaymentBulkResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The payments are successfully added.              &lt;br/&gt;Error codes:              503 — Request is invalid              1178 — Invoice cannot be paid before the invoice creation date              1178 — Invoice has already been paid              1178 — No invoice ID              1178 — Only approved invoices may be paid              1178 — Payment amount exceeds the actual invoice amount              1178 — Payment amount should be more than zero              1178 — Payment is not allowed for this subscriber              1178 — Payment number cannot exceed 100 characters |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              503 — Request is empty or null |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **403** | You are not authorized to request this resource, or the resource is unavailable for some reason.              &lt;br/&gt;Error codes:              100 — User has no permissions to perform this action |  -  |
| **500** | The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 — Error updating invoices payments in bulk mode |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="invoicespingservicename"></a>
# **InvoicesPingserviceName**
> Object InvoicesPingserviceName (string serviceName)

Checks state of a service for invoice.

The method allow check some service for invoice for availability state.<br />Responses: 'Success' or 'Fail'.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class InvoicesPingserviceNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(config);
            var serviceName = "serviceName_example";  // string | Service Name identifier: The value of parameter is 'TWUtilityManager' or 'TWCalculationManager'  in currently.

            try
            {
                // Checks state of a service for invoice.
                Object result = apiInstance.InvoicesPingserviceName(serviceName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvoicesApi.InvoicesPingserviceName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoicesPingserviceNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Checks state of a service for invoice.
    ApiResponse<Object> response = apiInstance.InvoicesPingserviceNameWithHttpInfo(serviceName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvoicesApi.InvoicesPingserviceNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serviceName** | **string** | Service Name identifier: The value of parameter is &#39;TWUtilityManager&#39; or &#39;TWCalculationManager&#39;  in currently. |  |

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
| **200** | Indicates that the request succeeded. Specified service is available. |  -  |
| **400** | Indicates that the request failed. Action parameter is mismatched or missed. |  -  |
| **401** | An unauthorized request. |  -  |
| **503** | Indicates that the request failed. Specified service is unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="invoicesstatisticsdaysperioddaysperiodapprovedinthepastdaysperiodapprovedinthepastdaysperiod"></a>
# **InvoicesStatisticsdaysPerioddaysPeriodapprovedInThePastDaysPeriodapprovedInThePastDaysPeriod**
> SCServiceChannelServicesMessagingInvoicesInvoiceStatisticsResponse InvoicesStatisticsdaysPerioddaysPeriodapprovedInThePastDaysPeriodapprovedInThePastDaysPeriod (int? daysPeriod = null, int? approvedInThePastDaysPeriod = null)

Retrieve statistics of all invoices

Retrieves statistics of all invoices. Returns the statistics of all invoices for successful request.              <br /><br />Only for providers usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class InvoicesStatisticsdaysPerioddaysPeriodapprovedInThePastDaysPeriodapprovedInThePastDaysPeriodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(config);
            var daysPeriod = 56;  // int? | Period in days, last X days for which Invoices statistics was collected (30 by Default). (optional) 
            var approvedInThePastDaysPeriod = 56;  // int? | Period in days, last X days during which Invoices are approved (3 by Default). (optional) 

            try
            {
                // Retrieve statistics of all invoices
                SCServiceChannelServicesMessagingInvoicesInvoiceStatisticsResponse result = apiInstance.InvoicesStatisticsdaysPerioddaysPeriodapprovedInThePastDaysPeriodapprovedInThePastDaysPeriod(daysPeriod, approvedInThePastDaysPeriod);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvoicesApi.InvoicesStatisticsdaysPerioddaysPeriodapprovedInThePastDaysPeriodapprovedInThePastDaysPeriod: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoicesStatisticsdaysPerioddaysPeriodapprovedInThePastDaysPeriodapprovedInThePastDaysPeriodWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve statistics of all invoices
    ApiResponse<SCServiceChannelServicesMessagingInvoicesInvoiceStatisticsResponse> response = apiInstance.InvoicesStatisticsdaysPerioddaysPeriodapprovedInThePastDaysPeriodapprovedInThePastDaysPeriodWithHttpInfo(daysPeriod, approvedInThePastDaysPeriod);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvoicesApi.InvoicesStatisticsdaysPerioddaysPeriodapprovedInThePastDaysPeriodapprovedInThePastDaysPeriodWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **daysPeriod** | **int?** | Period in days, last X days for which Invoices statistics was collected (30 by Default). | [optional]  |
| **approvedInThePastDaysPeriod** | **int?** | Period in days, last X days during which Invoices are approved (3 by Default). | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingInvoicesInvoiceStatisticsResponse**](SCServiceChannelServicesMessagingInvoicesInvoiceStatisticsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 503 - Only for providers usage; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="invoicesworkorderstrackingnumberpayment"></a>
# **InvoicesWorkorderstrackingNumberPayment**
> void InvoicesWorkorderstrackingNumberPayment (int trackingNumber, SCServiceChannelServicesMessagingInvoicesInvoicePaymentRequest payment)

Add a payment record to an invoice by a tracking number

Creates a payment record for the invoice in the *Approved* status by specifying the tracking number of the work order the invoice was created for.              <br />Learn [how subscribers can mark invoices as paid](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/621936646/Marking+Invoices+as+Paid) in ServiceChannel University.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class InvoicesWorkorderstrackingNumberPaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(config);
            var trackingNumber = 56;  // int | Tracking number of the work order you want to add the invoice payment record for.
            var payment = new SCServiceChannelServicesMessagingInvoicesInvoicePaymentRequest(); // SCServiceChannelServicesMessagingInvoicesInvoicePaymentRequest | Invoice payment record request model.

            try
            {
                // Add a payment record to an invoice by a tracking number
                apiInstance.InvoicesWorkorderstrackingNumberPayment(trackingNumber, payment);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvoicesApi.InvoicesWorkorderstrackingNumberPayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoicesWorkorderstrackingNumberPaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a payment record to an invoice by a tracking number
    apiInstance.InvoicesWorkorderstrackingNumberPaymentWithHttpInfo(trackingNumber, payment);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvoicesApi.InvoicesWorkorderstrackingNumberPaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **trackingNumber** | **int** | Tracking number of the work order you want to add the invoice payment record for. |  |
| **payment** | [**SCServiceChannelServicesMessagingInvoicesInvoicePaymentRequest**](SCServiceChannelServicesMessagingInvoicesInvoicePaymentRequest.md) | Invoice payment record request model. |  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The payment record is added to a particular invoice created for the specified work order.  |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt; Error codes:              503 — Request is invalid              1178 — Invoice cannot be paid before invoice dates              1178 — Invoice has already  paid              1178 — Only approved invoices may pay              1178 — Payment amount exceeds the actual amount              1178 — Payment amount should be more than zero              1178 — Pay not allowed for this subscriber              2602 — Invalid WO Tracking Number |  -  |
| **401** | The request is not authorized.              &lt;br/&gt; Error codes:              504 — API call rejected by security permissions |  -  |
| **403** | You are not authorized to request this resource, or the resource is unavailable for some reason.              &lt;br/&gt; Error codes:              100 — User has no rights to perform this action |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="invoicesinvoiceid"></a>
# **InvoicesinvoiceId**
> SCServiceChannelServicesMessagingInvoicesApiGetInvoiceResponse InvoicesinvoiceId (int invoiceId)

Get an invoice

Returns the details of the specified invoice.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class InvoicesinvoiceIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(config);
            var invoiceId = 56;  // int | Numeric identifier of the invoice to get the details for.

            try
            {
                // Get an invoice
                SCServiceChannelServicesMessagingInvoicesApiGetInvoiceResponse result = apiInstance.InvoicesinvoiceId(invoiceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvoicesApi.InvoicesinvoiceId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoicesinvoiceIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an invoice
    ApiResponse<SCServiceChannelServicesMessagingInvoicesApiGetInvoiceResponse> response = apiInstance.InvoicesinvoiceIdWithHttpInfo(invoiceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvoicesApi.InvoicesinvoiceIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **invoiceId** | **int** | Numeric identifier of the invoice to get the details for. |  |

### Return type

[**SCServiceChannelServicesMessagingInvoicesApiGetInvoiceResponse**](SCServiceChannelServicesMessagingInvoicesApiGetInvoiceResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The specified invoice is in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 — API call rejected by security permissions |  -  |
| **404** | The requested resource does not exist on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="invoicesinvoiceidapproveapprovalcodeapprovalcodecommentscommentscategorycategory"></a>
# **InvoicesinvoiceIdApproveapprovalCodeapprovalCodecommentscommentscategorycategory**
> void InvoicesinvoiceIdApproveapprovalCodeapprovalCodecommentscommentscategorycategory (int invoiceId, string approvalCode, string comments, string category)

Allows approve non-MLI(Multilevel Invoice Approval) invoice

<para>Allows approve non-MLI(Multilevel Invoice Approval) invoice</para>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class InvoicesinvoiceIdApproveapprovalCodeapprovalCodecommentscommentscategorycategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(config);
            var invoiceId = 56;  // int | Invoice Identifier
            var approvalCode = "approvalCode_example";  // string | Approval Code
            var comments = "comments_example";  // string | Comments
            var category = "category_example";  // string | Category

            try
            {
                // Allows approve non-MLI(Multilevel Invoice Approval) invoice
                apiInstance.InvoicesinvoiceIdApproveapprovalCodeapprovalCodecommentscommentscategorycategory(invoiceId, approvalCode, comments, category);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvoicesApi.InvoicesinvoiceIdApproveapprovalCodeapprovalCodecommentscommentscategorycategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoicesinvoiceIdApproveapprovalCodeapprovalCodecommentscommentscategorycategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Allows approve non-MLI(Multilevel Invoice Approval) invoice
    apiInstance.InvoicesinvoiceIdApproveapprovalCodeapprovalCodecommentscommentscategorycategoryWithHttpInfo(invoiceId, approvalCode, comments, category);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvoicesApi.InvoicesinvoiceIdApproveapprovalCodeapprovalCodecommentscommentscategorycategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **invoiceId** | **int** | Invoice Identifier |  |
| **approvalCode** | **string** | Approval Code |  |
| **comments** | **string** | Comments |  |
| **category** | **string** | Category |  |

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
| **204** | Indicates that the request succeeded |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 502 - Wrong Invoice Id              &lt;br/&gt; 503 - MLI(Multilevel Invoice Approval) enabled |  -  |
| **401** | Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="invoicesinvoiceiddiscrepancy"></a>
# **InvoicesinvoiceIdDiscrepancy**
> List&lt;SCServiceChannelServicesMessagingInvoicesRateDiscrepancy&gt; InvoicesinvoiceIdDiscrepancy (int invoiceId)

Get rates discrepancy

Retrieves Invoice rates discrepancy information. Returns the labor list with rates discrepancy for the specified invoice.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class InvoicesinvoiceIdDiscrepancyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(config);
            var invoiceId = 56;  // int | Invoice identifier.

            try
            {
                // Get rates discrepancy
                List<SCServiceChannelServicesMessagingInvoicesRateDiscrepancy> result = apiInstance.InvoicesinvoiceIdDiscrepancy(invoiceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvoicesApi.InvoicesinvoiceIdDiscrepancy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoicesinvoiceIdDiscrepancyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get rates discrepancy
    ApiResponse<List<SCServiceChannelServicesMessagingInvoicesRateDiscrepancy>> response = apiInstance.InvoicesinvoiceIdDiscrepancyWithHttpInfo(invoiceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvoicesApi.InvoicesinvoiceIdDiscrepancyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **invoiceId** | **int** | Invoice identifier. |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingInvoicesRateDiscrepancy&gt;**](SCServiceChannelServicesMessagingInvoicesRateDiscrepancy.md)

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
| **404** | Indicates that the requested resource does not exist on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="invoicesinvoiceiddiscrepancyextended"></a>
# **InvoicesinvoiceIdDiscrepancyExtended**
> SCServiceChannelServicesMessagingInvoicesInvoiceDiscrepancy InvoicesinvoiceIdDiscrepancyExtended (int invoiceId)

Get rates discrepancy

Retrieves Invoice rates discrepancy information. Returns the labor list with rates discrepancy for the specified invoice.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class InvoicesinvoiceIdDiscrepancyExtendedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(config);
            var invoiceId = 56;  // int | Invoice identifier.

            try
            {
                // Get rates discrepancy
                SCServiceChannelServicesMessagingInvoicesInvoiceDiscrepancy result = apiInstance.InvoicesinvoiceIdDiscrepancyExtended(invoiceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvoicesApi.InvoicesinvoiceIdDiscrepancyExtended: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoicesinvoiceIdDiscrepancyExtendedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get rates discrepancy
    ApiResponse<SCServiceChannelServicesMessagingInvoicesInvoiceDiscrepancy> response = apiInstance.InvoicesinvoiceIdDiscrepancyExtendedWithHttpInfo(invoiceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvoicesApi.InvoicesinvoiceIdDiscrepancyExtendedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **invoiceId** | **int** | Invoice identifier. |  |

### Return type

[**SCServiceChannelServicesMessagingInvoicesInvoiceDiscrepancy**](SCServiceChannelServicesMessagingInvoicesInvoiceDiscrepancy.md)

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
| **404** | Indicates that the requested resource does not exist on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="invoicesinvoiceidonholdcommentscomments"></a>
# **InvoicesinvoiceIdOnholdcommentscomments**
> void InvoicesinvoiceIdOnholdcommentscomments (int invoiceId, string comments)

Allows put invoice on hold for non-MLI(Multilevel Invoice Approval) invoice

<para>Allows put invoice on hold for non-MLI(Multilevel Invoice Approval) invoice</para>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class InvoicesinvoiceIdOnholdcommentscommentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(config);
            var invoiceId = 56;  // int | Invoice Identifier
            var comments = "comments_example";  // string | Comments

            try
            {
                // Allows put invoice on hold for non-MLI(Multilevel Invoice Approval) invoice
                apiInstance.InvoicesinvoiceIdOnholdcommentscomments(invoiceId, comments);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvoicesApi.InvoicesinvoiceIdOnholdcommentscomments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoicesinvoiceIdOnholdcommentscommentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Allows put invoice on hold for non-MLI(Multilevel Invoice Approval) invoice
    apiInstance.InvoicesinvoiceIdOnholdcommentscommentsWithHttpInfo(invoiceId, comments);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvoicesApi.InvoicesinvoiceIdOnholdcommentscommentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **invoiceId** | **int** | Invoice Identifier |  |
| **comments** | **string** | Comments |  |

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
| **204** | Indicates that the request succeeded |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 502 - Wrong Invoice Id               &lt;br/&gt; 503 - MLI(Multilevel Invoice Approval) enabled |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="invoicesinvoiceidpayment"></a>
# **InvoicesinvoiceIdPayment**
> void InvoicesinvoiceIdPayment (int invoiceId, SCServiceChannelServicesMessagingInvoicesInvoicePaymentRequest payment)

Add a payment to an invoice

Creates a payment record for the specified invoice in the *Approved* status.              <br />Send this request [GET/odata/invoices](https://developer.servicechannel.com/swagger/ui/index?version=3#/Invoices/Invoices_GetInvoices) to get the invoice ID.              <br />Learn [how subscribers can mark invoices as paid](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/621936646/Marking+Invoices+as+Paid) in ServiceChannel University.              <br />**Example Request**                                POST /invoices/{invoiceId}/Payment                  {                   \"PaymentDate\": \"2021-06-10T07:40:47.881Z\",                   \"PaymentNumber\": \"25469833\",                   \"PaymentAmount\": 850                  }

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class InvoicesinvoiceIdPaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(config);
            var invoiceId = 56;  // int | Unique numeric identifier of the invoice to add a payment to.
            var payment = new SCServiceChannelServicesMessagingInvoicesInvoicePaymentRequest(); // SCServiceChannelServicesMessagingInvoicesInvoicePaymentRequest | Request to add a payment to the specified invoice.

            try
            {
                // Add a payment to an invoice
                apiInstance.InvoicesinvoiceIdPayment(invoiceId, payment);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvoicesApi.InvoicesinvoiceIdPayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoicesinvoiceIdPaymentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a payment to an invoice
    apiInstance.InvoicesinvoiceIdPaymentWithHttpInfo(invoiceId, payment);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvoicesApi.InvoicesinvoiceIdPaymentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **invoiceId** | **int** | Unique numeric identifier of the invoice to add a payment to. |  |
| **payment** | [**SCServiceChannelServicesMessagingInvoicesInvoicePaymentRequest**](SCServiceChannelServicesMessagingInvoicesInvoicePaymentRequest.md) | Request to add a payment to the specified invoice. |  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | A payment record is added to the specified invoice.  |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt; Error codes:              503 — Request is invalid              1178 — Invoice cannot be paid before invoice dates              1178 — Invoice has already  paid              1178 — Only approved invoices may pay              1178 — Payment amount exceeds the actual amount              1178 — Payment amount should be more than zero              1178 — Pay not allowed for this subscriber |  -  |
| **401** | The request is not authorized.              &lt;br/&gt; Error codes:              504 — API call rejected by security permissions |  -  |
| **403** | You are not authorized to request this resource, or the resource is unavailable for some reason.              &lt;br/&gt; Error codes:              100 — User has no rights to perform this action |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="invoicesinvoiceidrejectcommentscomments"></a>
# **InvoicesinvoiceIdRejectcommentscomments**
> void InvoicesinvoiceIdRejectcommentscomments (int invoiceId, string comments)

Allows reject non-MLI(Multilevel Invoice Approval) invoice

<para>Allows reject non-MLI(Multilevel Invoice Approval) invoice</para>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class InvoicesinvoiceIdRejectcommentscommentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(config);
            var invoiceId = 56;  // int | Invoice Identifier
            var comments = "comments_example";  // string | Comments

            try
            {
                // Allows reject non-MLI(Multilevel Invoice Approval) invoice
                apiInstance.InvoicesinvoiceIdRejectcommentscomments(invoiceId, comments);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvoicesApi.InvoicesinvoiceIdRejectcommentscomments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoicesinvoiceIdRejectcommentscommentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Allows reject non-MLI(Multilevel Invoice Approval) invoice
    apiInstance.InvoicesinvoiceIdRejectcommentscommentsWithHttpInfo(invoiceId, comments);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvoicesApi.InvoicesinvoiceIdRejectcommentscommentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **invoiceId** | **int** | Invoice Identifier |  |
| **comments** | **string** | Comments |  |

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
| **204** | Indicates that the request succeeded |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 502 - Wrong Invoice Id               &lt;br/&gt; 503 - MLI(Multilevel Invoice Approval) enabled |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="invoicessubscriberidinvoicerejectionreasons"></a>
# **InvoicessubscriberIdInvoiceRejectionReasons**
> List&lt;SCServiceChannelServicesMessagingInvoicesInvoiceRejectionReasonResponse&gt; InvoicessubscriberIdInvoiceRejectionReasons (int subscriberId)

Retrieve invoice rejection reasons for a subscriber

Returns invoice rejection reasons for a subscriber              <br />Both subscribers and providers can use this method.               • **Subscribers** should enter their subscriber ID.               • **Providers** need to pass the ID of the subscriber they have a contract with.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class InvoicessubscriberIdInvoiceRejectionReasonsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(config);
            var subscriberId = 56;  // int | Unique numeric identifier of the subscriber to return invoice rejection reasons for.

            try
            {
                // Retrieve invoice rejection reasons for a subscriber
                List<SCServiceChannelServicesMessagingInvoicesInvoiceRejectionReasonResponse> result = apiInstance.InvoicessubscriberIdInvoiceRejectionReasons(subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvoicesApi.InvoicessubscriberIdInvoiceRejectionReasons: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoicessubscriberIdInvoiceRejectionReasonsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve invoice rejection reasons for a subscriber
    ApiResponse<List<SCServiceChannelServicesMessagingInvoicesInvoiceRejectionReasonResponse>> response = apiInstance.InvoicessubscriberIdInvoiceRejectionReasonsWithHttpInfo(subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvoicesApi.InvoicessubscriberIdInvoiceRejectionReasonsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** | Unique numeric identifier of the subscriber to return invoice rejection reasons for. |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingInvoicesInvoiceRejectionReasonResponse&gt;**](SCServiceChannelServicesMessagingInvoicesInvoiceRejectionReasonResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Invoice rejection reasons for the specified subscriber are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              503 — The provider has no contract with the requested subscriber              503 — No access. Please check if the SubscriberId is valid |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="invoicessubscriberidinvoicerequirements"></a>
# **InvoicessubscriberIdInvoiceRequirements**
> SCServiceChannelServicesMessagingInvoicesInvoiceSettingsGeneral InvoicessubscriberIdInvoiceRequirements (int subscriberId)

Retrieve general invoice settings for a subscriber

Returns general invoice settings for the specified subscriber.              <br />Both subscribers and providers can use this method.               • **Subscribers** should enter their subscriber ID.               • **Providers** need to pass the ID of the subscriber they have a contract with.              <br />Subscriber users with the *Super Admin* secondary role set up general invoice parameters in **Admin** &gt; **Invoices** &gt; **General**, where they configure when invoices can be created, if providers should enter a resolution before submitting invoices, and whether any restrictions should apply to invoice numbers. Other parameters may be available if the corresponding features are turned on for the subscriber. Learn more about [configuring general invoice settings](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/557220138/General+Invoice+Configuration) in ServiceChannel University.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class InvoicessubscriberIdInvoiceRequirementsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(config);
            var subscriberId = 56;  // int | Unique numeric identifier of the subscriber to return general invoice settings for.

            try
            {
                // Retrieve general invoice settings for a subscriber
                SCServiceChannelServicesMessagingInvoicesInvoiceSettingsGeneral result = apiInstance.InvoicessubscriberIdInvoiceRequirements(subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvoicesApi.InvoicessubscriberIdInvoiceRequirements: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvoicessubscriberIdInvoiceRequirementsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve general invoice settings for a subscriber
    ApiResponse<SCServiceChannelServicesMessagingInvoicesInvoiceSettingsGeneral> response = apiInstance.InvoicessubscriberIdInvoiceRequirementsWithHttpInfo(subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvoicesApi.InvoicessubscriberIdInvoiceRequirementsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** | Unique numeric identifier of the subscriber to return general invoice settings for. |  |

### Return type

[**SCServiceChannelServicesMessagingInvoicesInvoiceSettingsGeneral**](SCServiceChannelServicesMessagingInvoicesInvoiceSettingsGeneral.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | General invoice settings for the specified subscriber are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              503 — The provider has no contract with the requested subscriber              503 — No access. Please check if the SubscriberId is valid |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscriberssubscriberidinvoicesinvoiceidapproveorderidorderiduseriduseridapprovalcodeapprovalcodeorganizationpermissionidorganizationpermissionidcategorycategorycommentcommentoverrideuseridoverrideuserid"></a>
# **SubscriberssubscriberIdInvoicesinvoiceIdApproveorderIdorderIduserIduserIdapprovalCodeapprovalCodeorganizationPermissionIdorganizationPermissionIdcategorycategorycommentcommentoverrideUserIdoverrideUserId**
> string SubscriberssubscriberIdInvoicesinvoiceIdApproveorderIdorderIduserIduserIdapprovalCodeapprovalCodeorganizationPermissionIdorganizationPermissionIdcategorycategorycommentcommentoverrideUserIdoverrideUserId (int orderId, int invoiceId, int userId, string approvalCode, int organizationPermissionId, int subscriberId, string? category = null, string? comment = null, int? overrideUserId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscriberssubscriberIdInvoicesinvoiceIdApproveorderIdorderIduserIduserIdapprovalCodeapprovalCodeorganizationPermissionIdorganizationPermissionIdcategorycategorycommentcommentoverrideUserIdoverrideUserIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesApi(config);
            var orderId = 56;  // int | 
            var invoiceId = 56;  // int | 
            var userId = 56;  // int | 
            var approvalCode = "approvalCode_example";  // string | 
            var organizationPermissionId = 56;  // int | 
            var subscriberId = 56;  // int | 
            var category = "category_example";  // string? |  (optional) 
            var comment = "comment_example";  // string? |  (optional) 
            var overrideUserId = 56;  // int? |  (optional) 

            try
            {
                string result = apiInstance.SubscriberssubscriberIdInvoicesinvoiceIdApproveorderIdorderIduserIduserIdapprovalCodeapprovalCodeorganizationPermissionIdorganizationPermissionIdcategorycategorycommentcommentoverrideUserIdoverrideUserId(orderId, invoiceId, userId, approvalCode, organizationPermissionId, subscriberId, category, comment, overrideUserId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvoicesApi.SubscriberssubscriberIdInvoicesinvoiceIdApproveorderIdorderIduserIduserIdapprovalCodeapprovalCodeorganizationPermissionIdorganizationPermissionIdcategorycategorycommentcommentoverrideUserIdoverrideUserId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriberssubscriberIdInvoicesinvoiceIdApproveorderIdorderIduserIduserIdapprovalCodeapprovalCodeorganizationPermissionIdorganizationPermissionIdcategorycategorycommentcommentoverrideUserIdoverrideUserIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.SubscriberssubscriberIdInvoicesinvoiceIdApproveorderIdorderIduserIduserIdapprovalCodeapprovalCodeorganizationPermissionIdorganizationPermissionIdcategorycategorycommentcommentoverrideUserIdoverrideUserIdWithHttpInfo(orderId, invoiceId, userId, approvalCode, organizationPermissionId, subscriberId, category, comment, overrideUserId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvoicesApi.SubscriberssubscriberIdInvoicesinvoiceIdApproveorderIdorderIduserIduserIdapprovalCodeapprovalCodeorganizationPermissionIdorganizationPermissionIdcategorycategorycommentcommentoverrideUserIdoverrideUserIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderId** | **int** |  |  |
| **invoiceId** | **int** |  |  |
| **userId** | **int** |  |  |
| **approvalCode** | **string** |  |  |
| **organizationPermissionId** | **int** |  |  |
| **subscriberId** | **int** |  |  |
| **category** | **string?** |  | [optional]  |
| **comment** | **string?** |  | [optional]  |
| **overrideUserId** | **int?** |  | [optional]  |

### Return type

**string**

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

