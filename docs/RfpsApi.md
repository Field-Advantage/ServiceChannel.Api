# ServiceChannel.Api.Api.RfpsApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetRfp**](RfpsApi.md#getrfp) | **GET** /odata/rfps({rfpId}) | Retrieve Rfp |
| [**GetRfps**](RfpsApi.md#getrfps) | **GET** /odata/rfps | Retrieve Rfps |
| [**Rfps**](RfpsApi.md#rfps) | **POST** /rfps | Create an RFP |
| [**Rfpsid**](RfpsApi.md#rfpsid) | **DELETE** /rfps/{id} | Delete an RFP by ID |
| [**RfpsnumberLocationslocationId**](RfpsApi.md#rfpsnumberlocationslocationid) | **DELETE** /rfps/{number}/locations/{locationId} | Delete an RFP by the RFP number and location ID |
| [**RfpsrfpIdAssign**](RfpsApi.md#rfpsrfpidassign) | **PUT** /rfps/{rfpId}/assign | Assign an RFP to another provider |

<a id="getrfp"></a>
# **GetRfp**
> List&lt;SCServiceChannelServicesMessagingRfpRfp&gt; GetRfp (int rfpId, string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Retrieve Rfp

Retrieve Rfp

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetRfpExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RfpsApi(config);
            var rfpId = 56;  // int | 
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Retrieve Rfp
                List<SCServiceChannelServicesMessagingRfpRfp> result = apiInstance.GetRfp(rfpId, expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RfpsApi.GetRfp: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRfpWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Rfp
    ApiResponse<List<SCServiceChannelServicesMessagingRfpRfp>> response = apiInstance.GetRfpWithHttpInfo(rfpId, expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RfpsApi.GetRfpWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **rfpId** | **int** |  |  |
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingRfpRfp&gt;**](SCServiceChannelServicesMessagingRfpRfp.md)

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

<a id="getrfps"></a>
# **GetRfps**
> List&lt;SCServiceChannelServicesMessagingRfpRfp&gt; GetRfps (string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Retrieve Rfps

Retrieve Rfps              <br /> Dates without 'Dto' endings return UTC date format.              <br /> Dates without 'Dto' endings are not recommended for using.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetRfpsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RfpsApi(config);
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Retrieve Rfps
                List<SCServiceChannelServicesMessagingRfpRfp> result = apiInstance.GetRfps(expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RfpsApi.GetRfps: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRfpsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Rfps
    ApiResponse<List<SCServiceChannelServicesMessagingRfpRfp>> response = apiInstance.GetRfpsWithHttpInfo(expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RfpsApi.GetRfpsWithHttpInfo: " + e.Message);
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

[**List&lt;SCServiceChannelServicesMessagingRfpRfp&gt;**](SCServiceChannelServicesMessagingRfpRfp.md)

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

<a id="rfps"></a>
# **Rfps**
> void Rfps (SCServiceChannelServicesMessagingRfpCreateRfpRequest request)

Create an RFP

Creates a request for proposal (RFP). Returns a unique RFP ID for a successful request.              <br />***Note:*** Subscribers can create RFPs [using the API](https://developer.servicechannel.com/guides/proposals/create-and-manage-RFPs/#create-an-rfp) or via [Service Automation](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/560300086/Creating+an+RFP).              <br />**Example Request**                                POST /rfps                  {                     \"Number\": \"\",                     \"PONumber\": \"\",                     \"WONumber\": \"\",                     \"TradeId\": 90480,                     \"Description\": \"New doors for the office\",                     \"Date\": \"\",                     \"DueHrs\": 48,                     \"DueDate\": \"\",                     \"Location\": {                        \"Id\": 2006071467,                        \"StoreId\": \"\"                     },                     \"ProviderId\": 2000090505,                     \"ResponseDate\": \"\",                     \"ProposalNotificationEmail\": \"LFAlways1776@gmail.com\",                     \"ProviderEmail\": \"\",                     \"ProposalTemplateId\": 0,                     \"WorkOrderId\": 0,                     \"ProjectId\": 0                  }

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RfpsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RfpsApi(config);
            var request = new SCServiceChannelServicesMessagingRfpCreateRfpRequest(); // SCServiceChannelServicesMessagingRfpCreateRfpRequest | The request to create an RFP.

            try
            {
                // Create an RFP
                apiInstance.Rfps(request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RfpsApi.Rfps: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RfpsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an RFP
    apiInstance.RfpsWithHttpInfo(request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RfpsApi.RfpsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingRfpCreateRfpRequest**](SCServiceChannelServicesMessagingRfpCreateRfpRequest.md) | The request to create an RFP. |  |

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
| **201** | The RFP is created, and a unique RFP ID is returned in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              503 — Request is empty or null              503 — Provider is not valid              503 — Empty E-Mail address (&#39;ProposalNotificationEmail&#39;)              503 — TradeId is not valid              503 — Empty Description              503 — Empty Location or Store ID              503 — Invalid location Id for current user              503 — Active contract for current trade, provider, locationId not found              503 — Empty Provider E-Mail address (&#39;ProviderEmail&#39;) |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions              504 — User does not have Location or Trade access to perform this operation |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="rfpsid"></a>
# **Rfpsid**
> void Rfpsid (int id)

Delete an RFP by ID

Permanently deletes the specified RFP by its ID. It cannot be undone. Find out more about [deleting RFPs via the API](https://developer.servicechannel.com/guides/proposals/create-and-manage-RFPs/#delete-an-rfp).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RfpsidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RfpsApi(config);
            var id = 56;  // int | The unique numeric identifier of the RFP to delete.

            try
            {
                // Delete an RFP by ID
                apiInstance.Rfpsid(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RfpsApi.Rfpsid: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RfpsidWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an RFP by ID
    apiInstance.RfpsidWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RfpsApi.RfpsidWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The unique numeric identifier of the RFP to delete. |  |

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
| **204** | The RFP is deleted, and the response is intentionally blank. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              502 — RFP not found              503 — RFP can only be deleted, if none of the proposals are approved |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **404** | The requested resource does not exist on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="rfpsnumberlocationslocationid"></a>
# **RfpsnumberLocationslocationId**
> void RfpsnumberLocationslocationId (string number, int locationId)

Delete an RFP by the RFP number and location ID

Permanently deletes the RFP by the specified RFP number and location ID. It cannot be undone.              <br />***Note:*** The RFP number is not unique. If multiple RFPs with the same number were created for a location, all of them are deleted when you pass the request.              <br />Learn more about [deleting RFPs via the API](https://developer.servicechannel.com/guides/proposals/create-and-manage-RFPs/#delete-an-rfp).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RfpsnumberLocationslocationIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RfpsApi(config);
            var number = "number_example";  // string | The non-unique identifier of the RFP to delete.
            var locationId = 56;  // int | The unique numeric identifier of the location for which the RFP was created.

            try
            {
                // Delete an RFP by the RFP number and location ID
                apiInstance.RfpsnumberLocationslocationId(number, locationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RfpsApi.RfpsnumberLocationslocationId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RfpsnumberLocationslocationIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an RFP by the RFP number and location ID
    apiInstance.RfpsnumberLocationslocationIdWithHttpInfo(number, locationId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RfpsApi.RfpsnumberLocationslocationIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **number** | **string** | The non-unique identifier of the RFP to delete. |  |
| **locationId** | **int** | The unique numeric identifier of the location for which the RFP was created. |  |

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
| **204** | The RFP is deleted, and the response is intentionally blank. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              502 — RFP not found              503 — RFP can only be deleted, if none of the proposals are approved |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **404** | The requested resource does not exist on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="rfpsrfpidassign"></a>
# **RfpsrfpIdAssign**
> void RfpsrfpIdAssign (int rfpId, SCServiceChannelServicesMessagingRfpAssignRfpRequest request)

Assign an RFP to another provider

Assigns the RFP to the specified provider. Returns a unique RFP ID for a successful request.              <br />***Note:*** The provider you want to assign the RFP to should have access to the location and trade for which the RFP was created.              <br />Learn more about [assigning an RFP to another provider](https://developer.servicechannel.com/guides/proposals/create-and-manage-RFPs/#assign-an-rfp-to-another-provider).              <br />**Example Request**                                PUT /rfps/{rfpId}/assign                  {                     \"ProviderId\": 2000090505,                     \"ProviderEmail\": \"\"                  }

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RfpsrfpIdAssignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RfpsApi(config);
            var rfpId = 56;  // int | The unique numeric identifier of the RFP to assign to the specified provider.
            var request = new SCServiceChannelServicesMessagingRfpAssignRfpRequest(); // SCServiceChannelServicesMessagingRfpAssignRfpRequest | The request to assign the RFP to another provider.

            try
            {
                // Assign an RFP to another provider
                apiInstance.RfpsrfpIdAssign(rfpId, request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RfpsApi.RfpsrfpIdAssign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RfpsrfpIdAssignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Assign an RFP to another provider
    apiInstance.RfpsrfpIdAssignWithHttpInfo(rfpId, request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RfpsApi.RfpsrfpIdAssignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **rfpId** | **int** | The unique numeric identifier of the RFP to assign to the specified provider. |  |
| **request** | [**SCServiceChannelServicesMessagingRfpAssignRfpRequest**](SCServiceChannelServicesMessagingRfpAssignRfpRequest.md) | The request to assign the RFP to another provider. |  |

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
| **200** | The RFP is assigned to the specified provider, and a unique RFP ID is returned in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              502 — RFP not found              503 — Request is empty or null              503 — Provider is not valid              503 — Empty Provider E-Mail address (&#39;ProviderEmail&#39;) |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

