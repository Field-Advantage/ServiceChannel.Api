# ServiceChannel.Api.Api.TradesApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetTrades**](TradesApi.md#gettrades) | **GET** /odata/trades | Trades Collection |
| [**GetTradesByLocation**](TradesApi.md#gettradesbylocation) | **GET** /odata/locations({locationId})/trades | Location Trades |
| [**Trades**](TradesApi.md#trades) | **POST** /trades |  |
| [**TradesBatch**](TradesApi.md#tradesbatch) | **POST** /trades/batch |  |
| [**TradesGetPrimaryTradesubscriberIdsubscriberIdtradeNametradeNametradeIdtradeId**](TradesApi.md#tradesgetprimarytradesubscriberidsubscriberidtradenametradenametradeidtradeid) | **POST** /trades/GetPrimaryTrade | Get Primary Trade For Provider |
| [**TradesIsRefrigerantsubscriberIdsubscriberIdtradeNametradeName**](TradesApi.md#tradesisrefrigerantsubscriberidsubscriberidtradenametradename) | **POST** /trades/IsRefrigerant |  |
| [**TradesLocationProviderTrades**](TradesApi.md#tradeslocationprovidertrades) | **POST** /trades/LocationProviderTrades |  |

<a id="gettrades"></a>
# **GetTrades**
> List&lt;SCServiceChannelServicesMessagingTradeTrade&gt; GetTrades (string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Trades Collection

List trades.              <br /><br />Available for provider and subscriber usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetTradesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TradesApi(config);
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Trades Collection
                List<SCServiceChannelServicesMessagingTradeTrade> result = apiInstance.GetTrades(expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradesApi.GetTrades: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTradesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Trades Collection
    ApiResponse<List<SCServiceChannelServicesMessagingTradeTrade>> response = apiInstance.GetTradesWithHttpInfo(expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TradesApi.GetTradesWithHttpInfo: " + e.Message);
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

[**List&lt;SCServiceChannelServicesMessagingTradeTrade&gt;**](SCServiceChannelServicesMessagingTradeTrade.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettradesbylocation"></a>
# **GetTradesByLocation**
> List&lt;SCServiceChannelServicesMessagingTradeTrade&gt; GetTradesByLocation (int locationId, string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Location Trades

List Location Trades. Method returns trades for specified location which have providers with rank 1 and higher.              <br /><br />Available for subscriber and provider usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetTradesByLocationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TradesApi(config);
            var locationId = 56;  // int | Numeric id of the Location to perform action with.
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Location Trades
                List<SCServiceChannelServicesMessagingTradeTrade> result = apiInstance.GetTradesByLocation(locationId, expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradesApi.GetTradesByLocation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTradesByLocationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Location Trades
    ApiResponse<List<SCServiceChannelServicesMessagingTradeTrade>> response = apiInstance.GetTradesByLocationWithHttpInfo(locationId, expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TradesApi.GetTradesByLocationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | Numeric id of the Location to perform action with. |  |
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingTradeTrade&gt;**](SCServiceChannelServicesMessagingTradeTrade.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="trades"></a>
# **Trades**
> SCServiceChannelServicesMessagingTradeAddTradeRequest Trades (SCServiceChannelServicesMessagingTradeAddTradeRequest request)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class TradesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TradesApi(config);
            var request = new SCServiceChannelServicesMessagingTradeAddTradeRequest(); // SCServiceChannelServicesMessagingTradeAddTradeRequest | 

            try
            {
                SCServiceChannelServicesMessagingTradeAddTradeRequest result = apiInstance.Trades(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradesApi.Trades: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TradesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SCServiceChannelServicesMessagingTradeAddTradeRequest> response = apiInstance.TradesWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TradesApi.TradesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingTradeAddTradeRequest**](SCServiceChannelServicesMessagingTradeAddTradeRequest.md) |  |  |

### Return type

[**SCServiceChannelServicesMessagingTradeAddTradeRequest**](SCServiceChannelServicesMessagingTradeAddTradeRequest.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions              &lt;br/&gt; 710 - Trade already exists              &lt;br/&gt; 711 - Invalid NTE |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="tradesbatch"></a>
# **TradesBatch**
> List&lt;SCServiceChannelServicesMessagingTradeAddTradeResponse&gt; TradesBatch (List<SCServiceChannelServicesMessagingTradeAddTradeRequest> request)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class TradesBatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TradesApi(config);
            var request = new List<SCServiceChannelServicesMessagingTradeAddTradeRequest>(); // List<SCServiceChannelServicesMessagingTradeAddTradeRequest> | 

            try
            {
                List<SCServiceChannelServicesMessagingTradeAddTradeResponse> result = apiInstance.TradesBatch(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradesApi.TradesBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TradesBatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<SCServiceChannelServicesMessagingTradeAddTradeResponse>> response = apiInstance.TradesBatchWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TradesApi.TradesBatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**List&lt;SCServiceChannelServicesMessagingTradeAddTradeRequest&gt;**](SCServiceChannelServicesMessagingTradeAddTradeRequest.md) |  |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingTradeAddTradeResponse&gt;**](SCServiceChannelServicesMessagingTradeAddTradeResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions              &lt;br/&gt; 710 - Trade already exists              &lt;br/&gt; 711 - Invalid NTE |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="tradesgetprimarytradesubscriberidsubscriberidtradenametradenametradeidtradeid"></a>
# **TradesGetPrimaryTradesubscriberIdsubscriberIdtradeNametradeNametradeIdtradeId**
> SCServiceChannelServicesMessagingTradeTradeWithPrimaryTrade TradesGetPrimaryTradesubscriberIdsubscriberIdtradeNametradeNametradeIdtradeId (int subscriberId, string? tradeName = null, int? tradeId = null)

Get Primary Trade For Provider

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class TradesGetPrimaryTradesubscriberIdsubscriberIdtradeNametradeNametradeIdtradeIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TradesApi(config);
            var subscriberId = 56;  // int | 
            var tradeName = "tradeName_example";  // string? |  (optional) 
            var tradeId = 56;  // int? |  (optional) 

            try
            {
                // Get Primary Trade For Provider
                SCServiceChannelServicesMessagingTradeTradeWithPrimaryTrade result = apiInstance.TradesGetPrimaryTradesubscriberIdsubscriberIdtradeNametradeNametradeIdtradeId(subscriberId, tradeName, tradeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradesApi.TradesGetPrimaryTradesubscriberIdsubscriberIdtradeNametradeNametradeIdtradeId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TradesGetPrimaryTradesubscriberIdsubscriberIdtradeNametradeNametradeIdtradeIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Primary Trade For Provider
    ApiResponse<SCServiceChannelServicesMessagingTradeTradeWithPrimaryTrade> response = apiInstance.TradesGetPrimaryTradesubscriberIdsubscriberIdtradeNametradeNametradeIdtradeIdWithHttpInfo(subscriberId, tradeName, tradeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TradesApi.TradesGetPrimaryTradesubscriberIdsubscriberIdtradeNametradeNametradeIdtradeIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** |  |  |
| **tradeName** | **string?** |  | [optional]  |
| **tradeId** | **int?** |  | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingTradeTradeWithPrimaryTrade**](SCServiceChannelServicesMessagingTradeTradeWithPrimaryTrade.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:                          &lt;br/&gt; 503 - tradeName and tradeId cannot be both empty or null and less than 1 and null respectively.              &lt;br/&gt; 401 - Invalid subscriber id |  -  |
| **401** | Indicates that the requested resource requires authentication. |  -  |
| **404** | The requested resource does not exist on the server.              &lt;br/&gt;Error codes:              &lt;br/&gt; 5010 - Trade is not found |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="tradesisrefrigerantsubscriberidsubscriberidtradenametradename"></a>
# **TradesIsRefrigerantsubscriberIdsubscriberIdtradeNametradeName**
> List&lt;SCServiceChannelServicesMessagingTradeTrade&gt; TradesIsRefrigerantsubscriberIdsubscriberIdtradeNametradeName (int subscriberId, string tradeName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class TradesIsRefrigerantsubscriberIdsubscriberIdtradeNametradeNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TradesApi(config);
            var subscriberId = 56;  // int | 
            var tradeName = "tradeName_example";  // string | 

            try
            {
                List<SCServiceChannelServicesMessagingTradeTrade> result = apiInstance.TradesIsRefrigerantsubscriberIdsubscriberIdtradeNametradeName(subscriberId, tradeName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradesApi.TradesIsRefrigerantsubscriberIdsubscriberIdtradeNametradeName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TradesIsRefrigerantsubscriberIdsubscriberIdtradeNametradeNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<SCServiceChannelServicesMessagingTradeTrade>> response = apiInstance.TradesIsRefrigerantsubscriberIdsubscriberIdtradeNametradeNameWithHttpInfo(subscriberId, tradeName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TradesApi.TradesIsRefrigerantsubscriberIdsubscriberIdtradeNametradeNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** |  |  |
| **tradeName** | **string** |  |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingTradeTrade&gt;**](SCServiceChannelServicesMessagingTradeTrade.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 100 - User has no permissions to perform this action. Not Allowed Subscriber Id(s): ..;..; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="tradeslocationprovidertrades"></a>
# **TradesLocationProviderTrades**
> SCServiceChannelServicesMessagingTradeGetLocationProviderTradesRequest TradesLocationProviderTrades (SCServiceChannelServicesMessagingTradeGetLocationProviderTradesRequest request)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class TradesLocationProviderTradesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TradesApi(config);
            var request = new SCServiceChannelServicesMessagingTradeGetLocationProviderTradesRequest(); // SCServiceChannelServicesMessagingTradeGetLocationProviderTradesRequest | 

            try
            {
                SCServiceChannelServicesMessagingTradeGetLocationProviderTradesRequest result = apiInstance.TradesLocationProviderTrades(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradesApi.TradesLocationProviderTrades: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TradesLocationProviderTradesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SCServiceChannelServicesMessagingTradeGetLocationProviderTradesRequest> response = apiInstance.TradesLocationProviderTradesWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TradesApi.TradesLocationProviderTradesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingTradeGetLocationProviderTradesRequest**](SCServiceChannelServicesMessagingTradeGetLocationProviderTradesRequest.md) |  |  |

### Return type

[**SCServiceChannelServicesMessagingTradeGetLocationProviderTradesRequest**](SCServiceChannelServicesMessagingTradeGetLocationProviderTradesRequest.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Indicates that the requested resource requires authentication. |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

