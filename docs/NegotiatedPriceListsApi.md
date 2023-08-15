# ServiceChannel.Api.Api.NegotiatedPriceListsApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**NegotiatedpricelistsNegotiatedpricelistspriceListNamepriceListNameproviderIdproviderIdlocationIdlocationIdapplyDatesFilterapplyDatesFilterisReturnDeletedisReturnDeleted**](NegotiatedPriceListsApi.md#negotiatedpricelistsnegotiatedpricelistspricelistnamepricelistnameprovideridprovideridlocationidlocationidapplydatesfilterapplydatesfilterisreturndeletedisreturndeleted) | **GET** /negotiatedpricelists/negotiatedpricelists | Get negotiated pricelists |

<a id="negotiatedpricelistsnegotiatedpricelistspricelistnamepricelistnameprovideridprovideridlocationidlocationidapplydatesfilterapplydatesfilterisreturndeletedisreturndeleted"></a>
# **NegotiatedpricelistsNegotiatedpricelistspriceListNamepriceListNameproviderIdproviderIdlocationIdlocationIdapplyDatesFilterapplyDatesFilterisReturnDeletedisReturnDeleted**
> SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList NegotiatedpricelistsNegotiatedpricelistspriceListNamepriceListNameproviderIdproviderIdlocationIdlocationIdapplyDatesFilterapplyDatesFilterisReturnDeletedisReturnDeleted (string? priceListName = null, int? providerId = null, int? locationId = null, bool? applyDatesFilter = null, bool? isReturnDeleted = null)

Get negotiated pricelists

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class NegotiatedpricelistsNegotiatedpricelistspriceListNamepriceListNameproviderIdproviderIdlocationIdlocationIdapplyDatesFilterapplyDatesFilterisReturnDeletedisReturnDeletedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NegotiatedPriceListsApi(config);
            var priceListName = "priceListName_example";  // string? | Unique Price List Identifier (optional) 
            var providerId = 56;  // int? | Unique Provider Identifier (optional) 
            var locationId = 56;  // int? | Unique Location Identifier (optional) 
            var applyDatesFilter = false;  // bool? | true: Current date between priceList.EffectiveDate and priceList.ExpirationDate; false: date filter is disabled (optional)  (default to false)
            var isReturnDeleted = false;  // bool? | Return deleted items PriceList Parts and PriceList Other Charges (optional)  (default to false)

            try
            {
                // Get negotiated pricelists
                SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList result = apiInstance.NegotiatedpricelistsNegotiatedpricelistspriceListNamepriceListNameproviderIdproviderIdlocationIdlocationIdapplyDatesFilterapplyDatesFilterisReturnDeletedisReturnDeleted(priceListName, providerId, locationId, applyDatesFilter, isReturnDeleted);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NegotiatedPriceListsApi.NegotiatedpricelistsNegotiatedpricelistspriceListNamepriceListNameproviderIdproviderIdlocationIdlocationIdapplyDatesFilterapplyDatesFilterisReturnDeletedisReturnDeleted: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NegotiatedpricelistsNegotiatedpricelistspriceListNamepriceListNameproviderIdproviderIdlocationIdlocationIdapplyDatesFilterapplyDatesFilterisReturnDeletedisReturnDeletedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get negotiated pricelists
    ApiResponse<SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList> response = apiInstance.NegotiatedpricelistsNegotiatedpricelistspriceListNamepriceListNameproviderIdproviderIdlocationIdlocationIdapplyDatesFilterapplyDatesFilterisReturnDeletedisReturnDeletedWithHttpInfo(priceListName, providerId, locationId, applyDatesFilter, isReturnDeleted);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NegotiatedPriceListsApi.NegotiatedpricelistsNegotiatedpricelistspriceListNamepriceListNameproviderIdproviderIdlocationIdlocationIdapplyDatesFilterapplyDatesFilterisReturnDeletedisReturnDeletedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **priceListName** | **string?** | Unique Price List Identifier | [optional]  |
| **providerId** | **int?** | Unique Provider Identifier | [optional]  |
| **locationId** | **int?** | Unique Location Identifier | [optional]  |
| **applyDatesFilter** | **bool?** | true: Current date between priceList.EffectiveDate and priceList.ExpirationDate; false: date filter is disabled | [optional] [default to false] |
| **isReturnDeleted** | **bool?** | Return deleted items PriceList Parts and PriceList Other Charges | [optional] [default to false] |

### Return type

[**SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList**](SCServiceChannelServicesMessagingNegotiatedPriceListNegotiatedPriceList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              401 — Invalid subsriber ID              804 — User has no permissions to perform this action |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **404** | The requested resource does not exist on the server. |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

