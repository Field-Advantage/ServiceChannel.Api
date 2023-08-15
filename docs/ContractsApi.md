# ServiceChannel.Api.Api.ContractsApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Contracts**](ContractsApi.md#contracts) | **POST** /contracts |  |
| [**ContractsRetire**](ContractsApi.md#contractsretire) | **PUT** /contracts/retire | Retire Provider Contract. When &#39;Trade&#39; and &#39;StoreId&#39; are not specified then provider is &#39;retired&#39; from all subscriber&#39;s stores. |
| [**ContractslocationIdlocationIdlocationDbIdlocationDbIdproviderIdproviderIdtradetradetradeIdtradeId**](ContractsApi.md#contractslocationidlocationidlocationdbidlocationdbidprovideridprovideridtradetradetradeidtradeid) | **GET** /contracts | Returns provider active contracts by providerId, locationId and trade |

<a id="contracts"></a>
# **Contracts**
> Object Contracts (SCServiceChannelServicesMessagingLocationAssignProviderRequest request)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ContractsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContractsApi(config);
            var request = new SCServiceChannelServicesMessagingLocationAssignProviderRequest(); // SCServiceChannelServicesMessagingLocationAssignProviderRequest | 

            try
            {
                Object result = apiInstance.Contracts(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContractsApi.Contracts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContractsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.ContractsWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContractsApi.ContractsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingLocationAssignProviderRequest**](SCServiceChannelServicesMessagingLocationAssignProviderRequest.md) |  |  |

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

<a id="contractsretire"></a>
# **ContractsRetire**
> Object ContractsRetire (SCServiceChannelServicesMessagingLocationRetireProviderRequest request)

Retire Provider Contract. When 'Trade' and 'StoreId' are not specified then provider is 'retired' from all subscriber's stores.

Available only for Subscriber Super Admin user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ContractsRetireExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContractsApi(config);
            var request = new SCServiceChannelServicesMessagingLocationRetireProviderRequest(); // SCServiceChannelServicesMessagingLocationRetireProviderRequest | 

            try
            {
                // Retire Provider Contract. When 'Trade' and 'StoreId' are not specified then provider is 'retired' from all subscriber's stores.
                Object result = apiInstance.ContractsRetire(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsRetire: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContractsRetireWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retire Provider Contract. When 'Trade' and 'StoreId' are not specified then provider is 'retired' from all subscriber's stores.
    ApiResponse<Object> response = apiInstance.ContractsRetireWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContractsApi.ContractsRetireWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingLocationRetireProviderRequest**](SCServiceChannelServicesMessagingLocationRetireProviderRequest.md) |  |  |

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
| **200** | Indicates that the request succeeded. When &#39;Trade&#39; and &#39;StoreId&#39; are not specified then provider is &#39;retired&#39; from all subscriber&#39;s stores. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="contractslocationidlocationidlocationdbidlocationdbidprovideridprovideridtradetradetradeidtradeid"></a>
# **ContractslocationIdlocationIdlocationDbIdlocationDbIdproviderIdproviderIdtradetradetradeIdtradeId**
> SCServiceChannelServicesMessagingContractsGetContractsResponse ContractslocationIdlocationIdlocationDbIdlocationDbIdproviderIdproviderIdtradetradetradeIdtradeId (string? locationId = null, int? locationDbId = null, int? providerId = null, string? trade = null, int? tradeId = null)

Returns provider active contracts by providerId, locationId and trade

Available only for Subscriber user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ContractslocationIdlocationIdlocationDbIdlocationDbIdproviderIdproviderIdtradetradetradeIdtradeIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContractsApi(config);
            var locationId = "locationId_example";  // string? |  (optional) 
            var locationDbId = 56;  // int? |  (optional) 
            var providerId = 56;  // int? |  (optional) 
            var trade = "trade_example";  // string? |  (optional) 
            var tradeId = 56;  // int? |  (optional) 

            try
            {
                // Returns provider active contracts by providerId, locationId and trade
                SCServiceChannelServicesMessagingContractsGetContractsResponse result = apiInstance.ContractslocationIdlocationIdlocationDbIdlocationDbIdproviderIdproviderIdtradetradetradeIdtradeId(locationId, locationDbId, providerId, trade, tradeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractslocationIdlocationIdlocationDbIdlocationDbIdproviderIdproviderIdtradetradetradeIdtradeId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContractslocationIdlocationIdlocationDbIdlocationDbIdproviderIdproviderIdtradetradetradeIdtradeIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns provider active contracts by providerId, locationId and trade
    ApiResponse<SCServiceChannelServicesMessagingContractsGetContractsResponse> response = apiInstance.ContractslocationIdlocationIdlocationDbIdlocationDbIdproviderIdproviderIdtradetradetradeIdtradeIdWithHttpInfo(locationId, locationDbId, providerId, trade, tradeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContractsApi.ContractslocationIdlocationIdlocationDbIdlocationDbIdproviderIdproviderIdtradetradetradeIdtradeIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **string?** |  | [optional]  |
| **locationDbId** | **int?** |  | [optional]  |
| **providerId** | **int?** |  | [optional]  |
| **trade** | **string?** |  | [optional]  |
| **tradeId** | **int?** |  | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingContractsGetContractsResponse**](SCServiceChannelServicesMessagingContractsGetContractsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested contracts are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              503 — Bad Request; locationId or locationDbId should be provided              503 — Location not found              503 — Trade not found              503 — Provider not found              503 — User does not have Location access to perform this operation |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **403** | The request is not allowed.              &lt;br/&gt;Error codes:              100 — Only for subscribers usage |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

