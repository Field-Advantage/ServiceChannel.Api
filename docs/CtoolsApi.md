# ServiceChannel.Api.Api.CtoolsApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CtoolsRefrigerantcertificationsproviderIdproviderIdauthUserIdauthUserId**](CtoolsApi.md#ctoolsrefrigerantcertificationsprovideridprovideridauthuseridauthuserid) | **GET** /ctools/refrigerantcertifications | Get refrigerant certifications |
| [**CtoolsWorkorderworkOrderIdAcceptedtechnicians**](CtoolsApi.md#ctoolsworkorderworkorderidacceptedtechnicians) | **GET** /ctools/workorder/{workOrderId}/acceptedtechnicians | Retrieve technicians who accepted a work order |
| [**CtoolsWorkorderworkOrderIdAcceptuserIduserId**](CtoolsApi.md#ctoolsworkorderworkorderidacceptuseriduserid) | **PUT** /ctools/workorder/{workOrderId}/accept | Accept a work order on behalf of a technician |
| [**CtoolsWorkorderworkOrderIdAssignedtechnicians**](CtoolsApi.md#ctoolsworkorderworkorderidassignedtechnicians) | **GET** /ctools/workorder/{workOrderId}/assignedtechnicians | Retrieve technicians assigned to a work order |
| [**CtoolsWorkorderworkOrderIdAssigntechnicianuserIduserId**](CtoolsApi.md#ctoolsworkorderworkorderidassigntechnicianuseriduserid) | **POST** /ctools/workorder/{workOrderId}/assigntechnician | Assign a technician to a work order |
| [**CtoolsWorkorderworkOrderIdDeclineuserIduserId**](CtoolsApi.md#ctoolsworkorderworkorderiddeclineuseriduserid) | **PUT** /ctools/workorder/{workOrderId}/decline | Decline a work order on behalf of a technician |
| [**CtoolsWorkorderworkOrderIdRescindacceptanceuserIduserId**](CtoolsApi.md#ctoolsworkorderworkorderidrescindacceptanceuseriduserid) | **PUT** /ctools/workorder/{workOrderId}/rescindacceptance | Cancel the acceptance of a work order on behalf of a technician |
| [**CtoolsWorkorderworkOrderIdUnassigntechnicianuserIduserId**](CtoolsApi.md#ctoolsworkorderworkorderidunassigntechnicianuseriduserid) | **DELETE** /ctools/workorder/{workOrderId}/unassigntechnician | Unassign a technician from a work order |

<a id="ctoolsrefrigerantcertificationsprovideridprovideridauthuseridauthuserid"></a>
# **CtoolsRefrigerantcertificationsproviderIdproviderIdauthUserIdauthUserId**
> List&lt;SCServiceChannelServicesMessagingContractorToolsExtendedRefrigerantCertificationDTO&gt; CtoolsRefrigerantcertificationsproviderIdproviderIdauthUserIdauthUserId (int providerId, int? authUserId = null)

Get refrigerant certifications

Returns all refrigerant certifications for the specified provider for EPA compliance. You can also retrieve certifications for one technician only by specifying their `authUserId`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class CtoolsRefrigerantcertificationsproviderIdproviderIdauthUserIdauthUserIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CtoolsApi(config);
            var providerId = 56;  // int | Unique provider identifier.
            var authUserId = 56;  // int? | Technician’s single sign-on (SSO) ID. (optional) 

            try
            {
                // Get refrigerant certifications
                List<SCServiceChannelServicesMessagingContractorToolsExtendedRefrigerantCertificationDTO> result = apiInstance.CtoolsRefrigerantcertificationsproviderIdproviderIdauthUserIdauthUserId(providerId, authUserId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CtoolsApi.CtoolsRefrigerantcertificationsproviderIdproviderIdauthUserIdauthUserId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CtoolsRefrigerantcertificationsproviderIdproviderIdauthUserIdauthUserIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get refrigerant certifications
    ApiResponse<List<SCServiceChannelServicesMessagingContractorToolsExtendedRefrigerantCertificationDTO>> response = apiInstance.CtoolsRefrigerantcertificationsproviderIdproviderIdauthUserIdauthUserIdWithHttpInfo(providerId, authUserId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CtoolsApi.CtoolsRefrigerantcertificationsproviderIdproviderIdauthUserIdauthUserIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **providerId** | **int** | Unique provider identifier. |  |
| **authUserId** | **int?** | Technician’s single sign-on (SSO) ID. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingContractorToolsExtendedRefrigerantCertificationDTO&gt;**](SCServiceChannelServicesMessagingContractorToolsExtendedRefrigerantCertificationDTO.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested refrigerant certifications are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ctoolsworkorderworkorderidacceptedtechnicians"></a>
# **CtoolsWorkorderworkOrderIdAcceptedtechnicians**
> List&lt;SCServiceChannelServicesMessagingContractorToolsTechnicianDto&gt; CtoolsWorkorderworkOrderIdAcceptedtechnicians (int workOrderId)

Retrieve technicians who accepted a work order

Returns technicians who accepted the specified work order. Note that only Field Tech Manager (FTM) technicians can accept work orders.              <br />***Note:*** This method is only available to provider admins.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class CtoolsWorkorderworkOrderIdAcceptedtechniciansExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CtoolsApi(config);
            var workOrderId = 56;  // int | The unique numeric identifier of the work order for which you want to retrieve technicians who accepted it.

            try
            {
                // Retrieve technicians who accepted a work order
                List<SCServiceChannelServicesMessagingContractorToolsTechnicianDto> result = apiInstance.CtoolsWorkorderworkOrderIdAcceptedtechnicians(workOrderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CtoolsApi.CtoolsWorkorderworkOrderIdAcceptedtechnicians: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CtoolsWorkorderworkOrderIdAcceptedtechniciansWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve technicians who accepted a work order
    ApiResponse<List<SCServiceChannelServicesMessagingContractorToolsTechnicianDto>> response = apiInstance.CtoolsWorkorderworkOrderIdAcceptedtechniciansWithHttpInfo(workOrderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CtoolsApi.CtoolsWorkorderworkOrderIdAcceptedtechniciansWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrderId** | **int** | The unique numeric identifier of the work order for which you want to retrieve technicians who accepted it. |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingContractorToolsTechnicianDto&gt;**](SCServiceChannelServicesMessagingContractorToolsTechnicianDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The technicians who accepted the specified work order are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc. |  -  |
| **401** | The request is not authorized. |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ctoolsworkorderworkorderidacceptuseriduserid"></a>
# **CtoolsWorkorderworkOrderIdAcceptuserIduserId**
> void CtoolsWorkorderworkOrderIdAcceptuserIduserId (int workOrderId, int userId)

Accept a work order on behalf of a technician

Accepts a work order on behalf of the specified technician. Only Field Tech Manager (FTM) technicians can accept work orders.              <br />Once the work order is accepted, its status changes to *In Progress/Dispatch Confirmed*.              <br />***Note:*** This method is only available to provider admins.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class CtoolsWorkorderworkOrderIdAcceptuserIduserIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CtoolsApi(config);
            var workOrderId = 56;  // int | The unique numeric identifier of the work order you want to accept on behalf of a technician.
            var userId = 56;  // int | The ID of the technician — who accepts the work order — in the Authentication service.

            try
            {
                // Accept a work order on behalf of a technician
                apiInstance.CtoolsWorkorderworkOrderIdAcceptuserIduserId(workOrderId, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CtoolsApi.CtoolsWorkorderworkOrderIdAcceptuserIduserId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CtoolsWorkorderworkOrderIdAcceptuserIduserIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Accept a work order on behalf of a technician
    apiInstance.CtoolsWorkorderworkOrderIdAcceptuserIduserIdWithHttpInfo(workOrderId, userId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CtoolsApi.CtoolsWorkorderworkOrderIdAcceptuserIduserIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrderId** | **int** | The unique numeric identifier of the work order you want to accept on behalf of a technician. |  |
| **userId** | **int** | The ID of the technician — who accepts the work order — in the Authentication service. |  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The work order is successfully accepted by the specified technician. The response is intentionally blank. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc. |  -  |
| **401** | The request is not authorized. |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ctoolsworkorderworkorderidassignedtechnicians"></a>
# **CtoolsWorkorderworkOrderIdAssignedtechnicians**
> List&lt;SCServiceChannelServicesMessagingContractorToolsTechnicianDto&gt; CtoolsWorkorderworkOrderIdAssignedtechnicians (int workOrderId)

Retrieve technicians assigned to a work order

Returns technicians assigned to the specified work order.              <br />***Note:*** This method is only available to provider admins.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class CtoolsWorkorderworkOrderIdAssignedtechniciansExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CtoolsApi(config);
            var workOrderId = 56;  // int | The unique numeric identifier of the work order to retrieve assigned technicians for.

            try
            {
                // Retrieve technicians assigned to a work order
                List<SCServiceChannelServicesMessagingContractorToolsTechnicianDto> result = apiInstance.CtoolsWorkorderworkOrderIdAssignedtechnicians(workOrderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CtoolsApi.CtoolsWorkorderworkOrderIdAssignedtechnicians: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CtoolsWorkorderworkOrderIdAssignedtechniciansWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve technicians assigned to a work order
    ApiResponse<List<SCServiceChannelServicesMessagingContractorToolsTechnicianDto>> response = apiInstance.CtoolsWorkorderworkOrderIdAssignedtechniciansWithHttpInfo(workOrderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CtoolsApi.CtoolsWorkorderworkOrderIdAssignedtechniciansWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrderId** | **int** | The unique numeric identifier of the work order to retrieve assigned technicians for. |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingContractorToolsTechnicianDto&gt;**](SCServiceChannelServicesMessagingContractorToolsTechnicianDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The technicians assigned to the specified work order are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc. |  -  |
| **401** | The request is not authorized. |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ctoolsworkorderworkorderidassigntechnicianuseriduserid"></a>
# **CtoolsWorkorderworkOrderIdAssigntechnicianuserIduserId**
> void CtoolsWorkorderworkOrderIdAssigntechnicianuserIduserId (int workOrderId, int userId)

Assign a technician to a work order

Assigns a technician to the specified work order.              <br />***Note:*** This method is only available to provider admins.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class CtoolsWorkorderworkOrderIdAssigntechnicianuserIduserIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CtoolsApi(config);
            var workOrderId = 56;  // int | The unique numeric identifier of the work order to assign to a technician.
            var userId = 56;  // int | The ID of the technician in the Authentication service to assign the work order to.

            try
            {
                // Assign a technician to a work order
                apiInstance.CtoolsWorkorderworkOrderIdAssigntechnicianuserIduserId(workOrderId, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CtoolsApi.CtoolsWorkorderworkOrderIdAssigntechnicianuserIduserId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CtoolsWorkorderworkOrderIdAssigntechnicianuserIduserIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Assign a technician to a work order
    apiInstance.CtoolsWorkorderworkOrderIdAssigntechnicianuserIduserIdWithHttpInfo(workOrderId, userId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CtoolsApi.CtoolsWorkorderworkOrderIdAssigntechnicianuserIduserIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrderId** | **int** | The unique numeric identifier of the work order to assign to a technician. |  |
| **userId** | **int** | The ID of the technician in the Authentication service to assign the work order to. |  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The technician is successfully assigned to the specified work order. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc. |  -  |
| **401** | The request is not authorized. |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ctoolsworkorderworkorderiddeclineuseriduserid"></a>
# **CtoolsWorkorderworkOrderIdDeclineuserIduserId**
> void CtoolsWorkorderworkOrderIdDeclineuserIduserId (int workOrderId, int userId)

Decline a work order on behalf of a technician

Declines a work order on behalf of the specified technician. Only Field Tech Manager (FTM) technicians can decline work orders.              <br />If additional technician permissions are enabled for your company — “Technician”, “Supervising Tech”, and “Regional Manager” — the work order declined by a technician is automatically assigned to a Supervising Tech or Regional Manager or forwarded to the next ranked provider based on the configured auto-assignment rules. If these permissions are not enabled, the work order is either forwarded to the next ranked provider or moved to the *Open/Declined* status, depending on the setup. Learn more about [automating work order assignments and setting up forwarding rules](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/640582807/Automating+Work+Order+Assignments+and+Forwarding+Work+Orders) in ServiceChannel University.              <br />***Note:*** This method is only available to provider admins.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class CtoolsWorkorderworkOrderIdDeclineuserIduserIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CtoolsApi(config);
            var workOrderId = 56;  // int | The unique numeric identifier of the work order you want to decline on behalf of a technician.
            var userId = 56;  // int | The ID of the technician — who declines the work order — in the Authentication service.

            try
            {
                // Decline a work order on behalf of a technician
                apiInstance.CtoolsWorkorderworkOrderIdDeclineuserIduserId(workOrderId, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CtoolsApi.CtoolsWorkorderworkOrderIdDeclineuserIduserId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CtoolsWorkorderworkOrderIdDeclineuserIduserIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Decline a work order on behalf of a technician
    apiInstance.CtoolsWorkorderworkOrderIdDeclineuserIduserIdWithHttpInfo(workOrderId, userId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CtoolsApi.CtoolsWorkorderworkOrderIdDeclineuserIduserIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrderId** | **int** | The unique numeric identifier of the work order you want to decline on behalf of a technician. |  |
| **userId** | **int** | The ID of the technician — who declines the work order — in the Authentication service. |  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The work order is successfully declined by the specified technician. The response is intentionally blank. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc. |  -  |
| **401** | The request is not authorized. |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ctoolsworkorderworkorderidrescindacceptanceuseriduserid"></a>
# **CtoolsWorkorderworkOrderIdRescindacceptanceuserIduserId**
> void CtoolsWorkorderworkOrderIdRescindacceptanceuserIduserId (int workOrderId, int userId)

Cancel the acceptance of a work order on behalf of a technician

Removes a technician as accepted on the specified work order. Note that only Field Tech Manager (FTM) technicians can accept work orders.              <br />If the technician is currently checked into the work order, the request will fail.              <br />***Note:*** This method is only available to provider admins.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class CtoolsWorkorderworkOrderIdRescindacceptanceuserIduserIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CtoolsApi(config);
            var workOrderId = 56;  // int | The unique numeric identifier of the work order for which you want to cancel acceptance on behalf of a technician.
            var userId = 56;  // int | The ID of the technician in the Authentication service to cancel the work order acceptance for.

            try
            {
                // Cancel the acceptance of a work order on behalf of a technician
                apiInstance.CtoolsWorkorderworkOrderIdRescindacceptanceuserIduserId(workOrderId, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CtoolsApi.CtoolsWorkorderworkOrderIdRescindacceptanceuserIduserId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CtoolsWorkorderworkOrderIdRescindacceptanceuserIduserIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel the acceptance of a work order on behalf of a technician
    apiInstance.CtoolsWorkorderworkOrderIdRescindacceptanceuserIduserIdWithHttpInfo(workOrderId, userId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CtoolsApi.CtoolsWorkorderworkOrderIdRescindacceptanceuserIduserIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrderId** | **int** | The unique numeric identifier of the work order for which you want to cancel acceptance on behalf of a technician. |  |
| **userId** | **int** | The ID of the technician in the Authentication service to cancel the work order acceptance for. |  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The technician is removed as accepted on the specified work order. The response is intentionally blank. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc. |  -  |
| **401** | The request is not authorized. |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ctoolsworkorderworkorderidunassigntechnicianuseriduserid"></a>
# **CtoolsWorkorderworkOrderIdUnassigntechnicianuserIduserId**
> void CtoolsWorkorderworkOrderIdUnassigntechnicianuserIduserId (int workOrderId, int userId)

Unassign a technician from a work order

Unassigns a technician from the specified work order.              <br />***Note:*** This method is only available to provider admins.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class CtoolsWorkorderworkOrderIdUnassigntechnicianuserIduserIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CtoolsApi(config);
            var workOrderId = 56;  // int | The unique numeric identifier of the work order to unassign a technician from.
            var userId = 56;  // int | The ID of the technician in the Authentication service to unassign the work order from.

            try
            {
                // Unassign a technician from a work order
                apiInstance.CtoolsWorkorderworkOrderIdUnassigntechnicianuserIduserId(workOrderId, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CtoolsApi.CtoolsWorkorderworkOrderIdUnassigntechnicianuserIduserId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CtoolsWorkorderworkOrderIdUnassigntechnicianuserIduserIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unassign a technician from a work order
    apiInstance.CtoolsWorkorderworkOrderIdUnassigntechnicianuserIduserIdWithHttpInfo(workOrderId, userId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CtoolsApi.CtoolsWorkorderworkOrderIdUnassigntechnicianuserIduserIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrderId** | **int** | The unique numeric identifier of the work order to unassign a technician from. |  |
| **userId** | **int** | The ID of the technician in the Authentication service to unassign the work order from. |  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The technician is successfully unassigned from the specified work order. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc. |  -  |
| **401** | The request is not authorized. |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

