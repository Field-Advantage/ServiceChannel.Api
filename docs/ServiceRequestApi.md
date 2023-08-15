# ServiceChannel.Api.Api.ServiceRequestApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ProvidersCurrentSubscriberssubscriberIdApplicationissuechoiceServicerequestInfoAreaNameAreaNameProblemTypeProblemTypeEquipmentTypeEquipmentTypeProblemCodeProblemCodeLocationIdLocationIdSetupIdSetupIdCallDateCallDate**](ServiceRequestApi.md#providerscurrentsubscriberssubscriberidapplicationissuechoiceservicerequestinfoareanameareanameproblemtypeproblemtypeequipmenttypeequipmenttypeproblemcodeproblemcodelocationidlocationidsetupidsetupidcalldatecalldate) | **GET** /providers/current/subscribers/{subscriberId}/applicationissuechoice/servicerequest/info |  |
| [**ProvidersCurrentSubscribersubscriberIdLocationlocationIdApplicationissuechoiceServicerequestInfo**](ServiceRequestApi.md#providerscurrentsubscribersubscriberidlocationlocationidapplicationissuechoiceservicerequestinfo) | **GET** /providers/current/subscriber/{subscriberId}/location/{locationId}/applicationissuechoice/servicerequest/info |  |
| [**ServicerequestProviderslocationIdlocationIdtradetradeequipmentTypeequipmentTypeproviderRankproviderRankequipmentIdequipmentId**](ServiceRequestApi.md#servicerequestproviderslocationidlocationidtradetradeequipmenttypeequipmenttypeproviderrankproviderrankequipmentidequipmentid) | **GET** /servicerequest/providers | Get list of providers per service request |
| [**SubscribersCurrentServicerequestAddressesSubscriberIdSubscriberIdSetupIdSetupIdLocationIdLocationIdProviderIdProviderIdTradeTrade**](ServiceRequestApi.md#subscriberscurrentservicerequestaddressessubscriberidsubscriberidsetupidsetupidlocationidlocationidprovideridprovideridtradetrade) | **GET** /subscribers/current/servicerequest/addresses |  |
| [**SubscribersCurrentServicerequestInfoAreaNameAreaNameProblemTypeProblemTypeEquipmentTypeEquipmentTypeProblemCodeProblemCodeLocationIdLocationIdSetupIdSetupIdCallDateCallDate**](ServiceRequestApi.md#subscriberscurrentservicerequestinfoareanameareanameproblemtypeproblemtypeequipmenttypeequipmenttypeproblemcodeproblemcodelocationidlocationidsetupidsetupidcalldatecalldate) | **GET** /subscribers/current/servicerequest/info | Get Service Request Info |
| [**SubscribersCurrentServicerequestInfoNosettingsAreaNameAreaNameProblemTypeProblemTypeEquipmentTypeEquipmentTypeProblemCodeProblemCodeLocationIdLocationIdSetupIdSetupIdCallDateCallDate**](ServiceRequestApi.md#subscriberscurrentservicerequestinfonosettingsareanameareanameproblemtypeproblemtypeequipmenttypeequipmenttypeproblemcodeproblemcodelocationidlocationidsetupidsetupidcalldatecalldate) | **GET** /subscribers/current/servicerequest/info/nosettings | Get Service Request Info Without Dashboard Settings |

<a id="providerscurrentsubscriberssubscriberidapplicationissuechoiceservicerequestinfoareanameareanameproblemtypeproblemtypeequipmenttypeequipmenttypeproblemcodeproblemcodelocationidlocationidsetupidsetupidcalldatecalldate"></a>
# **ProvidersCurrentSubscriberssubscriberIdApplicationissuechoiceServicerequestInfoAreaNameAreaNameProblemTypeProblemTypeEquipmentTypeEquipmentTypeProblemCodeProblemCodeLocationIdLocationIdSetupIdSetupIdCallDateCallDate**
> SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoRequest ProvidersCurrentSubscriberssubscriberIdApplicationissuechoiceServicerequestInfoAreaNameAreaNameProblemTypeProblemTypeEquipmentTypeEquipmentTypeProblemCodeProblemCodeLocationIdLocationIdSetupIdSetupIdCallDateCallDate (int subscriberId, string? areaName = null, string? problemType = null, string? equipmentType = null, string? problemCode = null, int? locationId = null, int? setupId = null, DateTime? callDate = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProvidersCurrentSubscriberssubscriberIdApplicationissuechoiceServicerequestInfoAreaNameAreaNameProblemTypeProblemTypeEquipmentTypeEquipmentTypeProblemCodeProblemCodeLocationIdLocationIdSetupIdSetupIdCallDateCallDateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ServiceRequestApi(config);
            var subscriberId = 56;  // int | 
            var areaName = "areaName_example";  // string? | Name of the area (optional) 
            var problemType = "problemType_example";  // string? | Problem type (optional) 
            var equipmentType = "equipmentType_example";  // string? | Equipment type (optional) 
            var problemCode = "problemCode_example";  // string? | Problem name (optional) 
            var locationId = 56;  // int? | ID of a location (optional) 
            var setupId = 56;  // int? | SetupId (optional) 
            var callDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Call Date (optional) 

            try
            {
                SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoRequest result = apiInstance.ProvidersCurrentSubscriberssubscriberIdApplicationissuechoiceServicerequestInfoAreaNameAreaNameProblemTypeProblemTypeEquipmentTypeEquipmentTypeProblemCodeProblemCodeLocationIdLocationIdSetupIdSetupIdCallDateCallDate(subscriberId, areaName, problemType, equipmentType, problemCode, locationId, setupId, callDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceRequestApi.ProvidersCurrentSubscriberssubscriberIdApplicationissuechoiceServicerequestInfoAreaNameAreaNameProblemTypeProblemTypeEquipmentTypeEquipmentTypeProblemCodeProblemCodeLocationIdLocationIdSetupIdSetupIdCallDateCallDate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProvidersCurrentSubscriberssubscriberIdApplicationissuechoiceServicerequestInfoAreaNameAreaNameProblemTypeProblemTypeEquipmentTypeEquipmentTypeProblemCodeProblemCodeLocationIdLocationIdSetupIdSetupIdCallDateCallDateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoRequest> response = apiInstance.ProvidersCurrentSubscriberssubscriberIdApplicationissuechoiceServicerequestInfoAreaNameAreaNameProblemTypeProblemTypeEquipmentTypeEquipmentTypeProblemCodeProblemCodeLocationIdLocationIdSetupIdSetupIdCallDateCallDateWithHttpInfo(subscriberId, areaName, problemType, equipmentType, problemCode, locationId, setupId, callDate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceRequestApi.ProvidersCurrentSubscriberssubscriberIdApplicationissuechoiceServicerequestInfoAreaNameAreaNameProblemTypeProblemTypeEquipmentTypeEquipmentTypeProblemCodeProblemCodeLocationIdLocationIdSetupIdSetupIdCallDateCallDateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** |  |  |
| **areaName** | **string?** | Name of the area | [optional]  |
| **problemType** | **string?** | Problem type | [optional]  |
| **equipmentType** | **string?** | Equipment type | [optional]  |
| **problemCode** | **string?** | Problem name | [optional]  |
| **locationId** | **int?** | ID of a location | [optional]  |
| **setupId** | **int?** | SetupId | [optional]  |
| **callDate** | **DateTime?** | Call Date | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoRequest**](SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoRequest.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="providerscurrentsubscribersubscriberidlocationlocationidapplicationissuechoiceservicerequestinfo"></a>
# **ProvidersCurrentSubscribersubscriberIdLocationlocationIdApplicationissuechoiceServicerequestInfo**
> Object ProvidersCurrentSubscribersubscriberIdLocationlocationIdApplicationissuechoiceServicerequestInfo (int subscriberId, int locationId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProvidersCurrentSubscribersubscriberIdLocationlocationIdApplicationissuechoiceServicerequestInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ServiceRequestApi(config);
            var subscriberId = 56;  // int | 
            var locationId = 56;  // int | 

            try
            {
                Object result = apiInstance.ProvidersCurrentSubscribersubscriberIdLocationlocationIdApplicationissuechoiceServicerequestInfo(subscriberId, locationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceRequestApi.ProvidersCurrentSubscribersubscriberIdLocationlocationIdApplicationissuechoiceServicerequestInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProvidersCurrentSubscribersubscriberIdLocationlocationIdApplicationissuechoiceServicerequestInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.ProvidersCurrentSubscribersubscriberIdLocationlocationIdApplicationissuechoiceServicerequestInfoWithHttpInfo(subscriberId, locationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceRequestApi.ProvidersCurrentSubscribersubscriberIdLocationlocationIdApplicationissuechoiceServicerequestInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** |  |  |
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
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="servicerequestproviderslocationidlocationidtradetradeequipmenttypeequipmenttypeproviderrankproviderrankequipmentidequipmentid"></a>
# **ServicerequestProviderslocationIdlocationIdtradetradeequipmentTypeequipmentTypeproviderRankproviderRankequipmentIdequipmentId**
> SCServiceChannelServicesMessagingProvidersGetServiceRequestProvidersResponse ServicerequestProviderslocationIdlocationIdtradetradeequipmentTypeequipmentTypeproviderRankproviderRankequipmentIdequipmentId (int? locationId = null, string? trade = null, string? equipmentType = null, int? providerRank = null, int? equipmentId = null)

Get list of providers per service request

Returns providers for specified location and trade or equipment. If no location, trade specified in request equipment values are used.              <br /><br />Available for provider and subscriber usage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ServicerequestProviderslocationIdlocationIdtradetradeequipmentTypeequipmentTypeproviderRankproviderRankequipmentIdequipmentIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ServiceRequestApi(config);
            var locationId = 56;  // int? | Location Id (optional) 
            var trade = "trade_example";  // string? | Trade (optional) 
            var equipmentType = "equipmentType_example";  // string? | Equipment type (optional) 
            var providerRank = 56;  // int? | Sets default provider with specified rank (optional) 
            var equipmentId = 56;  // int? | Sets default provider for specified equipment id (optional) 

            try
            {
                // Get list of providers per service request
                SCServiceChannelServicesMessagingProvidersGetServiceRequestProvidersResponse result = apiInstance.ServicerequestProviderslocationIdlocationIdtradetradeequipmentTypeequipmentTypeproviderRankproviderRankequipmentIdequipmentId(locationId, trade, equipmentType, providerRank, equipmentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceRequestApi.ServicerequestProviderslocationIdlocationIdtradetradeequipmentTypeequipmentTypeproviderRankproviderRankequipmentIdequipmentId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ServicerequestProviderslocationIdlocationIdtradetradeequipmentTypeequipmentTypeproviderRankproviderRankequipmentIdequipmentIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get list of providers per service request
    ApiResponse<SCServiceChannelServicesMessagingProvidersGetServiceRequestProvidersResponse> response = apiInstance.ServicerequestProviderslocationIdlocationIdtradetradeequipmentTypeequipmentTypeproviderRankproviderRankequipmentIdequipmentIdWithHttpInfo(locationId, trade, equipmentType, providerRank, equipmentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceRequestApi.ServicerequestProviderslocationIdlocationIdtradetradeequipmentTypeequipmentTypeproviderRankproviderRankequipmentIdequipmentIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int?** | Location Id | [optional]  |
| **trade** | **string?** | Trade | [optional]  |
| **equipmentType** | **string?** | Equipment type | [optional]  |
| **providerRank** | **int?** | Sets default provider with specified rank | [optional]  |
| **equipmentId** | **int?** | Sets default provider for specified equipment id | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingProvidersGetServiceRequestProvidersResponse**](SCServiceChannelServicesMessagingProvidersGetServiceRequestProvidersResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscriberscurrentservicerequestaddressessubscriberidsubscriberidsetupidsetupidlocationidlocationidprovideridprovideridtradetrade"></a>
# **SubscribersCurrentServicerequestAddressesSubscriberIdSubscriberIdSetupIdSetupIdLocationIdLocationIdProviderIdProviderIdTradeTrade**
> void SubscribersCurrentServicerequestAddressesSubscriberIdSubscriberIdSetupIdSetupIdLocationIdLocationIdProviderIdProviderIdTradeTrade (int subscriberId, int setupId, int locationId, int providerId, string trade)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscribersCurrentServicerequestAddressesSubscriberIdSubscriberIdSetupIdSetupIdLocationIdLocationIdProviderIdProviderIdTradeTradeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ServiceRequestApi(config);
            var subscriberId = 56;  // int | 
            var setupId = 56;  // int | 
            var locationId = 56;  // int | 
            var providerId = 56;  // int | 
            var trade = "trade_example";  // string | 

            try
            {
                apiInstance.SubscribersCurrentServicerequestAddressesSubscriberIdSubscriberIdSetupIdSetupIdLocationIdLocationIdProviderIdProviderIdTradeTrade(subscriberId, setupId, locationId, providerId, trade);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceRequestApi.SubscribersCurrentServicerequestAddressesSubscriberIdSubscriberIdSetupIdSetupIdLocationIdLocationIdProviderIdProviderIdTradeTrade: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribersCurrentServicerequestAddressesSubscriberIdSubscriberIdSetupIdSetupIdLocationIdLocationIdProviderIdProviderIdTradeTradeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SubscribersCurrentServicerequestAddressesSubscriberIdSubscriberIdSetupIdSetupIdLocationIdLocationIdProviderIdProviderIdTradeTradeWithHttpInfo(subscriberId, setupId, locationId, providerId, trade);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceRequestApi.SubscribersCurrentServicerequestAddressesSubscriberIdSubscriberIdSetupIdSetupIdLocationIdLocationIdProviderIdProviderIdTradeTradeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** |  |  |
| **setupId** | **int** |  |  |
| **locationId** | **int** |  |  |
| **providerId** | **int** |  |  |
| **trade** | **string** |  |  |

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
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 503 - Request data is empty; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **404** | Indicates that the requested resource does not exist on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscriberscurrentservicerequestinfoareanameareanameproblemtypeproblemtypeequipmenttypeequipmenttypeproblemcodeproblemcodelocationidlocationidsetupidsetupidcalldatecalldate"></a>
# **SubscribersCurrentServicerequestInfoAreaNameAreaNameProblemTypeProblemTypeEquipmentTypeEquipmentTypeProblemCodeProblemCodeLocationIdLocationIdSetupIdSetupIdCallDateCallDate**
> SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoResponse SubscribersCurrentServicerequestInfoAreaNameAreaNameProblemTypeProblemTypeEquipmentTypeEquipmentTypeProblemCodeProblemCodeLocationIdLocationIdSetupIdSetupIdCallDateCallDate (string? areaName = null, string? problemType = null, string? equipmentType = null, string? problemCode = null, int? locationId = null, int? setupId = null, DateTime? callDate = null)

Get Service Request Info

Retrieves supporting info for \"Create Work Order\" operation.              <br /><br />This method can only be used for subscriber's users that have assigned dashboard.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscribersCurrentServicerequestInfoAreaNameAreaNameProblemTypeProblemTypeEquipmentTypeEquipmentTypeProblemCodeProblemCodeLocationIdLocationIdSetupIdSetupIdCallDateCallDateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ServiceRequestApi(config);
            var areaName = "areaName_example";  // string? | Name of the area (optional) 
            var problemType = "problemType_example";  // string? | Problem type (optional) 
            var equipmentType = "equipmentType_example";  // string? | Equipment type (optional) 
            var problemCode = "problemCode_example";  // string? | Problem name (optional) 
            var locationId = 56;  // int? | ID of a location (optional) 
            var setupId = 56;  // int? | SetupId (optional) 
            var callDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Call Date (optional) 

            try
            {
                // Get Service Request Info
                SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoResponse result = apiInstance.SubscribersCurrentServicerequestInfoAreaNameAreaNameProblemTypeProblemTypeEquipmentTypeEquipmentTypeProblemCodeProblemCodeLocationIdLocationIdSetupIdSetupIdCallDateCallDate(areaName, problemType, equipmentType, problemCode, locationId, setupId, callDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceRequestApi.SubscribersCurrentServicerequestInfoAreaNameAreaNameProblemTypeProblemTypeEquipmentTypeEquipmentTypeProblemCodeProblemCodeLocationIdLocationIdSetupIdSetupIdCallDateCallDate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribersCurrentServicerequestInfoAreaNameAreaNameProblemTypeProblemTypeEquipmentTypeEquipmentTypeProblemCodeProblemCodeLocationIdLocationIdSetupIdSetupIdCallDateCallDateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Service Request Info
    ApiResponse<SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoResponse> response = apiInstance.SubscribersCurrentServicerequestInfoAreaNameAreaNameProblemTypeProblemTypeEquipmentTypeEquipmentTypeProblemCodeProblemCodeLocationIdLocationIdSetupIdSetupIdCallDateCallDateWithHttpInfo(areaName, problemType, equipmentType, problemCode, locationId, setupId, callDate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceRequestApi.SubscribersCurrentServicerequestInfoAreaNameAreaNameProblemTypeProblemTypeEquipmentTypeEquipmentTypeProblemCodeProblemCodeLocationIdLocationIdSetupIdSetupIdCallDateCallDateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **areaName** | **string?** | Name of the area | [optional]  |
| **problemType** | **string?** | Problem type | [optional]  |
| **equipmentType** | **string?** | Equipment type | [optional]  |
| **problemCode** | **string?** | Problem name | [optional]  |
| **locationId** | **int?** | ID of a location | [optional]  |
| **setupId** | **int?** | SetupId | [optional]  |
| **callDate** | **DateTime?** | Call Date | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoResponse**](SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 917 - Invalid work order identifier. Returned if workorderId is &amp;lt;&#x3D; 0; |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscriberscurrentservicerequestinfonosettingsareanameareanameproblemtypeproblemtypeequipmenttypeequipmenttypeproblemcodeproblemcodelocationidlocationidsetupidsetupidcalldatecalldate"></a>
# **SubscribersCurrentServicerequestInfoNosettingsAreaNameAreaNameProblemTypeProblemTypeEquipmentTypeEquipmentTypeProblemCodeProblemCodeLocationIdLocationIdSetupIdSetupIdCallDateCallDate**
> SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoResponse SubscribersCurrentServicerequestInfoNosettingsAreaNameAreaNameProblemTypeProblemTypeEquipmentTypeEquipmentTypeProblemCodeProblemCodeLocationIdLocationIdSetupIdSetupIdCallDateCallDate (string? areaName = null, string? problemType = null, string? equipmentType = null, string? problemCode = null, int? locationId = null, int? setupId = null, DateTime? callDate = null)

Get Service Request Info Without Dashboard Settings

Retrieves supporting info for \"Create Work Order\" operation.              <br /><br />This method can only be used for subscriber's users that have assigned dashboard.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscribersCurrentServicerequestInfoNosettingsAreaNameAreaNameProblemTypeProblemTypeEquipmentTypeEquipmentTypeProblemCodeProblemCodeLocationIdLocationIdSetupIdSetupIdCallDateCallDateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ServiceRequestApi(config);
            var areaName = "areaName_example";  // string? | Name of the area (optional) 
            var problemType = "problemType_example";  // string? | Problem type (optional) 
            var equipmentType = "equipmentType_example";  // string? | Equipment type (optional) 
            var problemCode = "problemCode_example";  // string? | Problem name (optional) 
            var locationId = 56;  // int? | ID of a location (optional) 
            var setupId = 56;  // int? | SetupId (optional) 
            var callDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Call Date (optional) 

            try
            {
                // Get Service Request Info Without Dashboard Settings
                SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoResponse result = apiInstance.SubscribersCurrentServicerequestInfoNosettingsAreaNameAreaNameProblemTypeProblemTypeEquipmentTypeEquipmentTypeProblemCodeProblemCodeLocationIdLocationIdSetupIdSetupIdCallDateCallDate(areaName, problemType, equipmentType, problemCode, locationId, setupId, callDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceRequestApi.SubscribersCurrentServicerequestInfoNosettingsAreaNameAreaNameProblemTypeProblemTypeEquipmentTypeEquipmentTypeProblemCodeProblemCodeLocationIdLocationIdSetupIdSetupIdCallDateCallDate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribersCurrentServicerequestInfoNosettingsAreaNameAreaNameProblemTypeProblemTypeEquipmentTypeEquipmentTypeProblemCodeProblemCodeLocationIdLocationIdSetupIdSetupIdCallDateCallDateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Service Request Info Without Dashboard Settings
    ApiResponse<SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoResponse> response = apiInstance.SubscribersCurrentServicerequestInfoNosettingsAreaNameAreaNameProblemTypeProblemTypeEquipmentTypeEquipmentTypeProblemCodeProblemCodeLocationIdLocationIdSetupIdSetupIdCallDateCallDateWithHttpInfo(areaName, problemType, equipmentType, problemCode, locationId, setupId, callDate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceRequestApi.SubscribersCurrentServicerequestInfoNosettingsAreaNameAreaNameProblemTypeProblemTypeEquipmentTypeEquipmentTypeProblemCodeProblemCodeLocationIdLocationIdSetupIdSetupIdCallDateCallDateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **areaName** | **string?** | Name of the area | [optional]  |
| **problemType** | **string?** | Problem type | [optional]  |
| **equipmentType** | **string?** | Equipment type | [optional]  |
| **problemCode** | **string?** | Problem name | [optional]  |
| **locationId** | **int?** | ID of a location | [optional]  |
| **setupId** | **int?** | SetupId | [optional]  |
| **callDate** | **DateTime?** | Call Date | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoResponse**](SCServiceChannelServicesMessagingWorkordersGetServiceRequestInfoResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 917 - Invalid work order identifier. Returned if workorderId is &amp;lt;&#x3D; 0; |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

