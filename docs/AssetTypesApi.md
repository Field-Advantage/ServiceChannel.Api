# ServiceChannel.Api.Api.AssetTypesApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AssetTypes**](AssetTypesApi.md#assettypes) | **GET** /AssetTypes |  |
| [**AssetTypesAsettypesAssetTypesForCreatetradeIdtradeId**](AssetTypesApi.md#assettypesasettypesassettypesforcreatetradeidtradeid) | **GET** /AssetTypes/asettypes/AssetTypesForCreate | Get Asset Types For Create By TradeId |
| [**AssetTypesAsettypesGetAssetTypeBrandsAsyncassetTypeId**](AssetTypesApi.md#assettypesasettypesgetassettypebrandsasyncassettypeid) | **GET** /AssetTypes/asettypes/GetAssetTypeBrandsAsync/{assetTypeId} | Get Asset Type Brands |
| [**AssetTypesAsettypesGetAssetTypesWithCreatePermissionsubscriberIdsubscriberIdtradeIdtradeId**](AssetTypesApi.md#assettypesasettypesgetassettypeswithcreatepermissionsubscriberidsubscriberidtradeidtradeid) | **GET** /AssetTypes/asettypes/GetAssetTypesWithCreatePermission | Get Asset Types With Create Permission |
| [**AssetTypesAsettypesGetPrimaryAssetTypeBrandsAsyncprimaryAssetTypeId**](AssetTypesApi.md#assettypesasettypesgetprimaryassettypebrandsasyncprimaryassettypeid) | **GET** /AssetTypes/asettypes/GetPrimaryAssetTypeBrandsAsync/{primaryAssetTypeId} | Get Primary Asset Type Brands |
| [**AssetTypesAsettypesGetPrimaryAssetTypesAsync**](AssetTypesApi.md#assettypesasettypesgetprimaryassettypesasync) | **GET** /AssetTypes/asettypes/GetPrimaryAssetTypesAsync | Get Primary Asset Types |
| [**AssetTypesAssetTypeMeter**](AssetTypesApi.md#assettypesassettypemeter) | **PUT** /AssetTypes/AssetTypeMeter | Update an asset type meter |
| [**AssetTypesAssetTypeMeter_0**](AssetTypesApi.md#assettypesassettypemeter_0) | **POST** /AssetTypes/AssetTypeMeter | Add an asset type meter |
| [**AssetTypesAssetTypeMeterassetTypeMeterId**](AssetTypesApi.md#assettypesassettypemeterassettypemeterid) | **GET** /AssetTypes/AssetTypeMeter/{assetTypeMeterId} | Get an asset type meter details |
| [**AssetTypesAssetTypeMetersassetTypeId**](AssetTypesApi.md#assettypesassettypemetersassettypeid) | **GET** /AssetTypes/AssetTypeMeters/{assetTypeId} | Get asset type meters |
| [**AssetTypesAssetTypesAssetCategoriesByTradeIdtradeId**](AssetTypesApi.md#assettypesassettypesassetcategoriesbytradeidtradeid) | **GET** /AssetTypes/AssetTypes/AssetCategoriesByTradeId/{tradeId} | Get asset categories by tradeId |
| [**AssetTypesAssetsassetGroupIdGroupattachments**](AssetTypesApi.md#assettypesassetsassetgroupidgroupattachments) | **POST** /AssetTypes/assets/{assetGroupId}/groupattachments | Add AssetTypeGroup Attachments |
| [**AssetTypesByidsids0ids0ids1ids1**](AssetTypesApi.md#assettypesbyidsids0ids0ids1ids1) | **GET** /AssetTypes/byids |  |
| [**AssetTypesGetAssetTypeAttributesassetTypeId**](AssetTypesApi.md#assettypesgetassettypeattributesassettypeid) | **GET** /AssetTypes/GetAssetTypeAttributes/{assetTypeId} |  |
| [**AssetTypesGetAssetTypeCategoriesByAssetIds**](AssetTypesApi.md#assettypesgetassettypecategoriesbyassetids) | **POST** /AssetTypes/GetAssetTypeCategoriesByAssetIds | Get asset categories by AssetIds |
| [**AssetTypesGetAssetTypeCategoriesByIds**](AssetTypesApi.md#assettypesgetassettypecategoriesbyids) | **POST** /AssetTypes/GetAssetTypeCategoriesByIds | Get asset categories by Ids |
| [**AssetTypesGetAssetTypeGroupssubscriberIdsubscriberId**](AssetTypesApi.md#assettypesgetassettypegroupssubscriberidsubscriberid) | **GET** /AssetTypes/GetAssetTypeGroups | Get asset type groups by SubscriberId |
| [**AssetTypesGetAssetTypeTradesassetTypeId**](AssetTypesApi.md#assettypesgetassettypetradesassettypeid) | **GET** /AssetTypes/GetAssetTypeTrades/{assetTypeId} |  |
| [**AssetTypesGetAssetTypesAvailableForSubscribersubscriberIdtradeIdtradeId**](AssetTypesApi.md#assettypesgetassettypesavailableforsubscribersubscriberidtradeidtradeid) | **GET** /AssetTypes/GetAssetTypesAvailableForSubscriber/{subscriberId} |  |
| [**AssetTypesGetAssetTypesByLocation**](AssetTypesApi.md#assettypesgetassettypesbylocation) | **POST** /AssetTypes/GetAssetTypesByLocation |  |
| [**AssetTypesGetSubscriberAssetTypeCategories**](AssetTypesApi.md#assettypesgetsubscriberassettypecategories) | **POST** /AssetTypes/GetSubscriberAssetTypeCategories | Get asset categories by SubscriberId and TradeNames |
| [**AssetTypes_0**](AssetTypesApi.md#assettypes_0) | **POST** /AssetTypes |  |
| [**AssetTypesassetTypeId**](AssetTypesApi.md#assettypesassettypeid) | **GET** /AssetTypes/{assetTypeId} |  |
| [**AssetTypesassetTypeId_0**](AssetTypesApi.md#assettypesassettypeid_0) | **PUT** /AssetTypes/{assetTypeId} |  |
| [**AssetTypesassetTypeId_1**](AssetTypesApi.md#assettypesassettypeid_1) | **DELETE** /AssetTypes/{assetTypeId} |  |

<a id="assettypes"></a>
# **AssetTypes**
> List&lt;SCServiceChannelServicesMessagingAssetsAssetType&gt; AssetTypes ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetTypesApi(config);

            try
            {
                List<SCServiceChannelServicesMessagingAssetsAssetType> result = apiInstance.AssetTypes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetTypesApi.AssetTypes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<SCServiceChannelServicesMessagingAssetsAssetType>> response = apiInstance.AssetTypesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetTypesApi.AssetTypesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;SCServiceChannelServicesMessagingAssetsAssetType&gt;**](SCServiceChannelServicesMessagingAssetsAssetType.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assettypesasettypesassettypesforcreatetradeidtradeid"></a>
# **AssetTypesAsettypesAssetTypesForCreatetradeIdtradeId**
> Object AssetTypesAsettypesAssetTypesForCreatetradeIdtradeId (int tradeId)

Get Asset Types For Create By TradeId

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetTypesAsettypesAssetTypesForCreatetradeIdtradeIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetTypesApi(config);
            var tradeId = 56;  // int | 

            try
            {
                // Get Asset Types For Create By TradeId
                Object result = apiInstance.AssetTypesAsettypesAssetTypesForCreatetradeIdtradeId(tradeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetTypesApi.AssetTypesAsettypesAssetTypesForCreatetradeIdtradeId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetTypesAsettypesAssetTypesForCreatetradeIdtradeIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Asset Types For Create By TradeId
    ApiResponse<Object> response = apiInstance.AssetTypesAsettypesAssetTypesForCreatetradeIdtradeIdWithHttpInfo(tradeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetTypesApi.AssetTypesAsettypesAssetTypesForCreatetradeIdtradeIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tradeId** | **int** |  |  |

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
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assettypesasettypesgetassettypebrandsasyncassettypeid"></a>
# **AssetTypesAsettypesGetAssetTypeBrandsAsyncassetTypeId**
> Object AssetTypesAsettypesGetAssetTypeBrandsAsyncassetTypeId (int assetTypeId)

Get Asset Type Brands

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetTypesAsettypesGetAssetTypeBrandsAsyncassetTypeIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetTypesApi(config);
            var assetTypeId = 56;  // int | 

            try
            {
                // Get Asset Type Brands
                Object result = apiInstance.AssetTypesAsettypesGetAssetTypeBrandsAsyncassetTypeId(assetTypeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetTypesApi.AssetTypesAsettypesGetAssetTypeBrandsAsyncassetTypeId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetTypesAsettypesGetAssetTypeBrandsAsyncassetTypeIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Asset Type Brands
    ApiResponse<Object> response = apiInstance.AssetTypesAsettypesGetAssetTypeBrandsAsyncassetTypeIdWithHttpInfo(assetTypeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetTypesApi.AssetTypesAsettypesGetAssetTypeBrandsAsyncassetTypeIdWithHttpInfo: " + e.Message);
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
| **200** | OK |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assettypesasettypesgetassettypeswithcreatepermissionsubscriberidsubscriberidtradeidtradeid"></a>
# **AssetTypesAsettypesGetAssetTypesWithCreatePermissionsubscriberIdsubscriberIdtradeIdtradeId**
> Object AssetTypesAsettypesGetAssetTypesWithCreatePermissionsubscriberIdsubscriberIdtradeIdtradeId (int subscriberId, int? tradeId = null)

Get Asset Types With Create Permission

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetTypesAsettypesGetAssetTypesWithCreatePermissionsubscriberIdsubscriberIdtradeIdtradeIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetTypesApi(config);
            var subscriberId = 56;  // int | 
            var tradeId = 56;  // int? |  (optional) 

            try
            {
                // Get Asset Types With Create Permission
                Object result = apiInstance.AssetTypesAsettypesGetAssetTypesWithCreatePermissionsubscriberIdsubscriberIdtradeIdtradeId(subscriberId, tradeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetTypesApi.AssetTypesAsettypesGetAssetTypesWithCreatePermissionsubscriberIdsubscriberIdtradeIdtradeId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetTypesAsettypesGetAssetTypesWithCreatePermissionsubscriberIdsubscriberIdtradeIdtradeIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Asset Types With Create Permission
    ApiResponse<Object> response = apiInstance.AssetTypesAsettypesGetAssetTypesWithCreatePermissionsubscriberIdsubscriberIdtradeIdtradeIdWithHttpInfo(subscriberId, tradeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetTypesApi.AssetTypesAsettypesGetAssetTypesWithCreatePermissionsubscriberIdsubscriberIdtradeIdtradeIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** |  |  |
| **tradeId** | **int?** |  | [optional]  |

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
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assettypesasettypesgetprimaryassettypebrandsasyncprimaryassettypeid"></a>
# **AssetTypesAsettypesGetPrimaryAssetTypeBrandsAsyncprimaryAssetTypeId**
> Object AssetTypesAsettypesGetPrimaryAssetTypeBrandsAsyncprimaryAssetTypeId (int primaryAssetTypeId)

Get Primary Asset Type Brands

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetTypesAsettypesGetPrimaryAssetTypeBrandsAsyncprimaryAssetTypeIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetTypesApi(config);
            var primaryAssetTypeId = 56;  // int | 

            try
            {
                // Get Primary Asset Type Brands
                Object result = apiInstance.AssetTypesAsettypesGetPrimaryAssetTypeBrandsAsyncprimaryAssetTypeId(primaryAssetTypeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetTypesApi.AssetTypesAsettypesGetPrimaryAssetTypeBrandsAsyncprimaryAssetTypeId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetTypesAsettypesGetPrimaryAssetTypeBrandsAsyncprimaryAssetTypeIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Primary Asset Type Brands
    ApiResponse<Object> response = apiInstance.AssetTypesAsettypesGetPrimaryAssetTypeBrandsAsyncprimaryAssetTypeIdWithHttpInfo(primaryAssetTypeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetTypesApi.AssetTypesAsettypesGetPrimaryAssetTypeBrandsAsyncprimaryAssetTypeIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **primaryAssetTypeId** | **int** |  |  |

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
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assettypesasettypesgetprimaryassettypesasync"></a>
# **AssetTypesAsettypesGetPrimaryAssetTypesAsync**
> Object AssetTypesAsettypesGetPrimaryAssetTypesAsync ()

Get Primary Asset Types

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetTypesAsettypesGetPrimaryAssetTypesAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetTypesApi(config);

            try
            {
                // Get Primary Asset Types
                Object result = apiInstance.AssetTypesAsettypesGetPrimaryAssetTypesAsync();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetTypesApi.AssetTypesAsettypesGetPrimaryAssetTypesAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetTypesAsettypesGetPrimaryAssetTypesAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Primary Asset Types
    ApiResponse<Object> response = apiInstance.AssetTypesAsettypesGetPrimaryAssetTypesAsyncWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetTypesApi.AssetTypesAsettypesGetPrimaryAssetTypesAsyncWithHttpInfo: " + e.Message);
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
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assettypesassettypemeter"></a>
# **AssetTypesAssetTypeMeter**
> void AssetTypesAssetTypeMeter (SCServiceChannelServicesMessagingAssetsAssetTypeMeterRequestItem request)

Update an asset type meter

Modifies information of an already existing asset type meter.              <br />**Note**. All request parameters should be filled out: those you want to add or edit along with the parameters you want to leave unchanged.              <br />**Example Request**                                   PUT /AssetTypes/AssetTypeMeter                     {                         \"Id\": 16,                         \"Name\": \"Music System\",                         \"MaxValue\": \"500.00\",                         \"Notes\": ,                         \"Inactive\": false,                         \"EditOnWO\": true,                         \"AssetTypeId\": 7632,                         \"UnitOfMeasure\": 250                     }

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetTypesAssetTypeMeterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetTypesApi(config);
            var request = new SCServiceChannelServicesMessagingAssetsAssetTypeMeterRequestItem(); // SCServiceChannelServicesMessagingAssetsAssetTypeMeterRequestItem | Request to add or update the asset type meter details.

            try
            {
                // Update an asset type meter
                apiInstance.AssetTypesAssetTypeMeter(request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetTypesApi.AssetTypesAssetTypeMeter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetTypesAssetTypeMeterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an asset type meter
    apiInstance.AssetTypesAssetTypeMeterWithHttpInfo(request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetTypesApi.AssetTypesAssetTypeMeterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingAssetsAssetTypeMeterRequestItem**](SCServiceChannelServicesMessagingAssetsAssetTypeMeterRequestItem.md) | Request to add or update the asset type meter details. |  |

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
| **200** | The asset type meter is successfully updated. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt; Failed to Update Asset Type Meter |  -  |
| **500** | The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 — Object reference not set to an instance of an object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assettypesassettypemeter_0"></a>
# **AssetTypesAssetTypeMeter_0**
> void AssetTypesAssetTypeMeter_0 (SCServiceChannelServicesMessagingAssetsAssetTypeMeterRequestItem request)

Add an asset type meter

Creates a new asset type meter for a particular asset type for the current subscriber.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetTypesAssetTypeMeter_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetTypesApi(config);
            var request = new SCServiceChannelServicesMessagingAssetsAssetTypeMeterRequestItem(); // SCServiceChannelServicesMessagingAssetsAssetTypeMeterRequestItem | Request to add an asset type meter.               <br />Pass the following parameters in the request:              <br /> • **Id** (*Required*). Enter 0 or null so that when the asset type meter is created the system can assign a unique numeric ID to it.              <br /> • **Name** (*Required*). Name of an asset type meter.              <br /> • **Notes**. Comments provided by a user who added the asset type meter.              <br /> • **Inactive**. Set the asset type meter to the active on inactive status. Valid values: *true*, *false* or 1 - true, 0 - false.              <br /> • **EditOnWO**. Define whether technicians are allowed to enter data on work orders for the asset. Valid values: *true*, *false* or 1 - true, 0 - false.              <br /> • **AssetTypeId** (*Required*). ID of an asset type to assign the meter to.              <br /> • **UnitOfMeasure** (*Required*). Unique numeric identifier of a unit of measurement in the system.

            try
            {
                // Add an asset type meter
                apiInstance.AssetTypesAssetTypeMeter_0(request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetTypesApi.AssetTypesAssetTypeMeter_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetTypesAssetTypeMeter_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add an asset type meter
    apiInstance.AssetTypesAssetTypeMeter_0WithHttpInfo(request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetTypesApi.AssetTypesAssetTypeMeter_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingAssetsAssetTypeMeterRequestItem**](SCServiceChannelServicesMessagingAssetsAssetTypeMeterRequestItem.md) | Request to add an asset type meter.               &lt;br /&gt;Pass the following parameters in the request:              &lt;br /&gt; • **Id** (*Required*). Enter 0 or null so that when the asset type meter is created the system can assign a unique numeric ID to it.              &lt;br /&gt; • **Name** (*Required*). Name of an asset type meter.              &lt;br /&gt; • **Notes**. Comments provided by a user who added the asset type meter.              &lt;br /&gt; • **Inactive**. Set the asset type meter to the active on inactive status. Valid values: *true*, *false* or 1 - true, 0 - false.              &lt;br /&gt; • **EditOnWO**. Define whether technicians are allowed to enter data on work orders for the asset. Valid values: *true*, *false* or 1 - true, 0 - false.              &lt;br /&gt; • **AssetTypeId** (*Required*). ID of an asset type to assign the meter to.              &lt;br /&gt; • **UnitOfMeasure** (*Required*). Unique numeric identifier of a unit of measurement in the system. |  |

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
| **200** | The asset type meter is successfully added. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt; Failed to Create Asset Type Meter |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 — Object reference not set to an instance of an object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assettypesassettypemeterassettypemeterid"></a>
# **AssetTypesAssetTypeMeterassetTypeMeterId**
> SCServiceChannelServicesMessagingAssetsAssetTypeMeterResponseItem AssetTypesAssetTypeMeterassetTypeMeterId (int assetTypeMeterId)

Get an asset type meter details

Returns the details of the specified asset type meter for the current subscriber.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetTypesAssetTypeMeterassetTypeMeterIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetTypesApi(config);
            var assetTypeMeterId = 56;  // int | Unique numeric identifier of the asset type meter you want to get the details of.              <br />Pass the [GET /AssetTypes/AssetTypeMeters/{assetTypeId}](https://developer.servicechannel.com/swagger/ui/index?version=3#/AssetTypes/GETv3_AssetTypes_AssetTypeMeters__assetTypeId_) method to acquire an ID of an asset type meter.

            try
            {
                // Get an asset type meter details
                SCServiceChannelServicesMessagingAssetsAssetTypeMeterResponseItem result = apiInstance.AssetTypesAssetTypeMeterassetTypeMeterId(assetTypeMeterId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetTypesApi.AssetTypesAssetTypeMeterassetTypeMeterId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetTypesAssetTypeMeterassetTypeMeterIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an asset type meter details
    ApiResponse<SCServiceChannelServicesMessagingAssetsAssetTypeMeterResponseItem> response = apiInstance.AssetTypesAssetTypeMeterassetTypeMeterIdWithHttpInfo(assetTypeMeterId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetTypesApi.AssetTypesAssetTypeMeterassetTypeMeterIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetTypeMeterId** | **int** | Unique numeric identifier of the asset type meter you want to get the details of.              &lt;br /&gt;Pass the [GET /AssetTypes/AssetTypeMeters/{assetTypeId}](https://developer.servicechannel.com/swagger/ui/index?version&#x3D;3#/AssetTypes/GETv3_AssetTypes_AssetTypeMeters__assetTypeId_) method to acquire an ID of an asset type meter. |  |

### Return type

[**SCServiceChannelServicesMessagingAssetsAssetTypeMeterResponseItem**](SCServiceChannelServicesMessagingAssetsAssetTypeMeterResponseItem.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The asset type meter details are in the response. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **404** | The request URI is incorrect, or the resource does not exist. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assettypesassettypemetersassettypeid"></a>
# **AssetTypesAssetTypeMetersassetTypeId**
> List&lt;SCServiceChannelServicesMessagingAssetsAssetTypeMeterResponseItem&gt; AssetTypesAssetTypeMetersassetTypeId (int assetTypeId)

Get asset type meters

Returns a list of meters and their parameters associated with an asset type and created by the current subscriber.              <br />You can get the details for a particular level by using the [GET/AssetTypes/AssetTypeMeter/{assetTypeMeterId}](https://developer.servicechannel.com/swagger/ui/index?version=3#/AssetTypes/GETv3_AssetTypes_AssetTypeMeter__assetTypeMeterId_) method.              <br />Learn more about [asset meter reading](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/834469973/Asset+Meter+Reading) in ServiceChannel University.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetTypesAssetTypeMetersassetTypeIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetTypesApi(config);
            var assetTypeId = 56;  // int | Unique numeric identifier of the asset type you want to get information on. Send the [GET /AssetTypes](https://developer.servicechannel.com/swagger/ui/index?version=3#/AssetTypes/GETv3_AssetTypes) request to get an asset type ID.

            try
            {
                // Get asset type meters
                List<SCServiceChannelServicesMessagingAssetsAssetTypeMeterResponseItem> result = apiInstance.AssetTypesAssetTypeMetersassetTypeId(assetTypeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetTypesApi.AssetTypesAssetTypeMetersassetTypeId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetTypesAssetTypeMetersassetTypeIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get asset type meters
    ApiResponse<List<SCServiceChannelServicesMessagingAssetsAssetTypeMeterResponseItem>> response = apiInstance.AssetTypesAssetTypeMetersassetTypeIdWithHttpInfo(assetTypeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetTypesApi.AssetTypesAssetTypeMetersassetTypeIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetTypeId** | **int** | Unique numeric identifier of the asset type you want to get information on. Send the [GET /AssetTypes](https://developer.servicechannel.com/swagger/ui/index?version&#x3D;3#/AssetTypes/GETv3_AssetTypes) request to get an asset type ID. |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingAssetsAssetTypeMeterResponseItem&gt;**](SCServiceChannelServicesMessagingAssetsAssetTypeMeterResponseItem.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested asset type meters are in the response. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **404** | The request URI is incorrect, or the resource does not exist. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assettypesassettypesassetcategoriesbytradeidtradeid"></a>
# **AssetTypesAssetTypesAssetCategoriesByTradeIdtradeId**
> List&lt;SCServiceChannelServicesMessagingAssetsAssetTypeCategory&gt; AssetTypesAssetTypesAssetCategoriesByTradeIdtradeId (int tradeId)

Get asset categories by tradeId

Returns a list of asset categories associated with the specified trade.              <br />              ***Note***:  This method retrieves asset categories from the standardized list, that is why asset categories may contain asset types and may not. To get asset categories containing asset types that belong to the certain trade, pass the [POST /AssetTypes/GetSubscriberAssetTypeCategories](https://developer.servicechannel.com/swagger/ui/index?version=3#/AssetTypes/POSTv3_AssetTypes_GetSubscriberAssetTypeCategories) method.              <br />              For more information, refer to [Adding Asset Category and Asset Types](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/2523693743/Adding+Asset+Category+and+Asset+Types) in ServiceChannel University.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetTypesAssetTypesAssetCategoriesByTradeIdtradeIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetTypesApi(config);
            var tradeId = 56;  // int | Unique numeric identifier of the trade.               Pass the [GET / AssetTypes](https://developer.servicechannel.com/swagger/ui/index?version=3#/AssetTypes/GETv3_AssetTypes) or [GET /assets/{assetId}](https://developer.servicechannel.com/swagger/ui/index?version=3#/Assets/GETv3_assets__assetId__locationId__locationId__storeId__storeId__tagId__tagId__trackingNumber__trackingNumber_) method to retrieve `tradeId`.

            try
            {
                // Get asset categories by tradeId
                List<SCServiceChannelServicesMessagingAssetsAssetTypeCategory> result = apiInstance.AssetTypesAssetTypesAssetCategoriesByTradeIdtradeId(tradeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetTypesApi.AssetTypesAssetTypesAssetCategoriesByTradeIdtradeId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetTypesAssetTypesAssetCategoriesByTradeIdtradeIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get asset categories by tradeId
    ApiResponse<List<SCServiceChannelServicesMessagingAssetsAssetTypeCategory>> response = apiInstance.AssetTypesAssetTypesAssetCategoriesByTradeIdtradeIdWithHttpInfo(tradeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetTypesApi.AssetTypesAssetTypesAssetCategoriesByTradeIdtradeIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tradeId** | **int** | Unique numeric identifier of the trade.               Pass the [GET / AssetTypes](https://developer.servicechannel.com/swagger/ui/index?version&#x3D;3#/AssetTypes/GETv3_AssetTypes) or [GET /assets/{assetId}](https://developer.servicechannel.com/swagger/ui/index?version&#x3D;3#/Assets/GETv3_assets__assetId__locationId__locationId__storeId__storeId__tagId__tagId__trackingNumber__trackingNumber_) method to retrieve &#x60;tradeId&#x60;. |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingAssetsAssetTypeCategory&gt;**](SCServiceChannelServicesMessagingAssetsAssetTypeCategory.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Asset categories are in the response. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **404** | The request URI is incorrect, or the resource does not exist. |  -  |
| **500** | Something went wrong, and the server was unable to complete your request.              &lt;br/&gt;Error codes:              501 — Object reference is not set to an instance of an object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assettypesassetsassetgroupidgroupattachments"></a>
# **AssetTypesAssetsassetGroupIdGroupattachments**
> SCServiceChannelServicesMessagingAssetsAddAssetTypeGroupAttachmentResponse AssetTypesAssetsassetGroupIdGroupattachments (int assetGroupId, System.IO.Stream file)

Add AssetTypeGroup Attachments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetTypesAssetsassetGroupIdGroupattachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetTypesApi(config);
            var assetGroupId = 56;  // int | 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | File to attach to AssetTypeGroup

            try
            {
                // Add AssetTypeGroup Attachments
                SCServiceChannelServicesMessagingAssetsAddAssetTypeGroupAttachmentResponse result = apiInstance.AssetTypesAssetsassetGroupIdGroupattachments(assetGroupId, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetTypesApi.AssetTypesAssetsassetGroupIdGroupattachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetTypesAssetsassetGroupIdGroupattachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add AssetTypeGroup Attachments
    ApiResponse<SCServiceChannelServicesMessagingAssetsAddAssetTypeGroupAttachmentResponse> response = apiInstance.AssetTypesAssetsassetGroupIdGroupattachmentsWithHttpInfo(assetGroupId, file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetTypesApi.AssetTypesAssetsassetGroupIdGroupattachmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetGroupId** | **int** |  |  |
| **file** | **System.IO.Stream****System.IO.Stream** | File to attach to AssetTypeGroup |  |

### Return type

[**SCServiceChannelServicesMessagingAssetsAddAssetTypeGroupAttachmentResponse**](SCServiceChannelServicesMessagingAssetsAddAssetTypeGroupAttachmentResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Created indicates that the request resulted in a new resource created before the response was sent. |  -  |
| **400** | Bad Request - the request could not be executed or was missing required parameters.              &lt;br/&gt;Error codes:              502 — AssetTypeGroup Not found;              503 — Bad Request; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assettypesbyidsids0ids0ids1ids1"></a>
# **AssetTypesByidsids0ids0ids1ids1**
> SCServiceChannelServicesMessagingAssetsAssetType AssetTypesByidsids0ids0ids1ids1 (List<int> ids)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetTypesByidsids0ids0ids1ids1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetTypesApi(config);
            var ids = new List<int>(); // List<int> | 

            try
            {
                SCServiceChannelServicesMessagingAssetsAssetType result = apiInstance.AssetTypesByidsids0ids0ids1ids1(ids);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetTypesApi.AssetTypesByidsids0ids0ids1ids1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetTypesByidsids0ids0ids1ids1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SCServiceChannelServicesMessagingAssetsAssetType> response = apiInstance.AssetTypesByidsids0ids0ids1ids1WithHttpInfo(ids);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetTypesApi.AssetTypesByidsids0ids0ids1ids1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ids** | [**List&lt;int&gt;**](int.md) |  |  |

### Return type

[**SCServiceChannelServicesMessagingAssetsAssetType**](SCServiceChannelServicesMessagingAssetsAssetType.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assettypesgetassettypeattributesassettypeid"></a>
# **AssetTypesGetAssetTypeAttributesassetTypeId**
> List&lt;SCServiceChannelServicesMessagingAssetsAssetTypeAttributeExternal&gt; AssetTypesGetAssetTypeAttributesassetTypeId (int assetTypeId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetTypesGetAssetTypeAttributesassetTypeIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetTypesApi(config);
            var assetTypeId = 56;  // int | 

            try
            {
                List<SCServiceChannelServicesMessagingAssetsAssetTypeAttributeExternal> result = apiInstance.AssetTypesGetAssetTypeAttributesassetTypeId(assetTypeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetTypesApi.AssetTypesGetAssetTypeAttributesassetTypeId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetTypesGetAssetTypeAttributesassetTypeIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<SCServiceChannelServicesMessagingAssetsAssetTypeAttributeExternal>> response = apiInstance.AssetTypesGetAssetTypeAttributesassetTypeIdWithHttpInfo(assetTypeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetTypesApi.AssetTypesGetAssetTypeAttributesassetTypeIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetTypeId** | **int** |  |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingAssetsAssetTypeAttributeExternal&gt;**](SCServiceChannelServicesMessagingAssetsAssetTypeAttributeExternal.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions; |  -  |
| **404** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              502 — Asset Type not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assettypesgetassettypecategoriesbyassetids"></a>
# **AssetTypesGetAssetTypeCategoriesByAssetIds**
> Dictionary&lt;string, SCServiceChannelServicesMessagingAssetsAssetTypeCategory&gt; AssetTypesGetAssetTypeCategoriesByAssetIds (SCServiceChannelServicesMessagingGetByIdsRequest request)

Get asset categories by AssetIds

Returns an asset category that contains the specified asset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetTypesGetAssetTypeCategoriesByAssetIdsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetTypesApi(config);
            var request = new SCServiceChannelServicesMessagingGetByIdsRequest(); // SCServiceChannelServicesMessagingGetByIdsRequest | Request model to retrieve a list of asset categories.

            try
            {
                // Get asset categories by AssetIds
                Dictionary<string, SCServiceChannelServicesMessagingAssetsAssetTypeCategory> result = apiInstance.AssetTypesGetAssetTypeCategoriesByAssetIds(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetTypesApi.AssetTypesGetAssetTypeCategoriesByAssetIds: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetTypesGetAssetTypeCategoriesByAssetIdsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get asset categories by AssetIds
    ApiResponse<Dictionary<string, SCServiceChannelServicesMessagingAssetsAssetTypeCategory>> response = apiInstance.AssetTypesGetAssetTypeCategoriesByAssetIdsWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetTypesApi.AssetTypesGetAssetTypeCategoriesByAssetIdsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingGetByIdsRequest**](SCServiceChannelServicesMessagingGetByIdsRequest.md) | Request model to retrieve a list of asset categories. |  |

### Return type

[**Dictionary&lt;string, SCServiceChannelServicesMessagingAssetsAssetTypeCategory&gt;**](SCServiceChannelServicesMessagingAssetsAssetTypeCategory.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Asset categories are in the response. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | Something went wrong, and the server was unable to complete your request.              &lt;br/&gt;Error codes:              501 — Object reference not set to an instance of an object              501 — Unable to create a null constant value. Only entity types, enumeration types, or primitive types are supported in this context |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assettypesgetassettypecategoriesbyids"></a>
# **AssetTypesGetAssetTypeCategoriesByIds**
> SCServiceChannelServicesMessagingAssetsAssetTypeCategory AssetTypesGetAssetTypeCategoriesByIds (SCServiceChannelServicesMessagingGetByIdsRequest request)

Get asset categories by Ids

Returns asset categories names based on their numeric identifiers.              <br />              ***Note***: To get all asset categories, send the request without specifying any Id. Asset categories from the list may contain asset types or may be empty, as this method retrieves asset categories from the standardized list.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetTypesGetAssetTypeCategoriesByIdsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetTypesApi(config);
            var request = new SCServiceChannelServicesMessagingGetByIdsRequest(); // SCServiceChannelServicesMessagingGetByIdsRequest | Request model to retrieve asset categories names.

            try
            {
                // Get asset categories by Ids
                SCServiceChannelServicesMessagingAssetsAssetTypeCategory result = apiInstance.AssetTypesGetAssetTypeCategoriesByIds(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetTypesApi.AssetTypesGetAssetTypeCategoriesByIds: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetTypesGetAssetTypeCategoriesByIdsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get asset categories by Ids
    ApiResponse<SCServiceChannelServicesMessagingAssetsAssetTypeCategory> response = apiInstance.AssetTypesGetAssetTypeCategoriesByIdsWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetTypesApi.AssetTypesGetAssetTypeCategoriesByIdsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingGetByIdsRequest**](SCServiceChannelServicesMessagingGetByIdsRequest.md) | Request model to retrieve asset categories names. |  |

### Return type

[**SCServiceChannelServicesMessagingAssetsAssetTypeCategory**](SCServiceChannelServicesMessagingAssetsAssetTypeCategory.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Asset categories names are in the response. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | Something went wrong, and the server was unable to complete your request.              &lt;br/&gt;Error codes:              501 — Object reference is not set to an instance of an object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assettypesgetassettypegroupssubscriberidsubscriberid"></a>
# **AssetTypesGetAssetTypeGroupssubscriberIdsubscriberId**
> List&lt;SCServiceChannelServicesMessagingAssetTypesAssetTypeGroup&gt; AssetTypesGetAssetTypeGroupssubscriberIdsubscriberId (int? subscriberId = null)

Get asset type groups by SubscriberId

Returns a list of asset type groups for the specified subscriber.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetTypesGetAssetTypeGroupssubscriberIdsubscriberIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetTypesApi(config);
            var subscriberId = 56;  // int? | Unique numeric identifier of the subscriber. (optional) 

            try
            {
                // Get asset type groups by SubscriberId
                List<SCServiceChannelServicesMessagingAssetTypesAssetTypeGroup> result = apiInstance.AssetTypesGetAssetTypeGroupssubscriberIdsubscriberId(subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetTypesApi.AssetTypesGetAssetTypeGroupssubscriberIdsubscriberId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetTypesGetAssetTypeGroupssubscriberIdsubscriberIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get asset type groups by SubscriberId
    ApiResponse<List<SCServiceChannelServicesMessagingAssetTypesAssetTypeGroup>> response = apiInstance.AssetTypesGetAssetTypeGroupssubscriberIdsubscriberIdWithHttpInfo(subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetTypesApi.AssetTypesGetAssetTypeGroupssubscriberIdsubscriberIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int?** | Unique numeric identifier of the subscriber. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingAssetTypesAssetTypeGroup&gt;**](SCServiceChannelServicesMessagingAssetTypesAssetTypeGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Asset type groups are in the response. |  -  |
| **400** | The request was not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              503 — Bad Request |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | Something went wrong, and the server was unable to complete your request.              &lt;br/&gt;Error codes:              501 — Object reference is not set to an instance of an object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assettypesgetassettypetradesassettypeid"></a>
# **AssetTypesGetAssetTypeTradesassetTypeId**
> Object AssetTypesGetAssetTypeTradesassetTypeId (int assetTypeId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetTypesGetAssetTypeTradesassetTypeIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetTypesApi(config);
            var assetTypeId = 56;  // int | 

            try
            {
                Object result = apiInstance.AssetTypesGetAssetTypeTradesassetTypeId(assetTypeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetTypesApi.AssetTypesGetAssetTypeTradesassetTypeId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetTypesGetAssetTypeTradesassetTypeIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.AssetTypesGetAssetTypeTradesassetTypeIdWithHttpInfo(assetTypeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetTypesApi.AssetTypesGetAssetTypeTradesassetTypeIdWithHttpInfo: " + e.Message);
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
| **200** | OK |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions; |  -  |
| **404** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              502 — Asset Type not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assettypesgetassettypesavailableforsubscribersubscriberidtradeidtradeid"></a>
# **AssetTypesGetAssetTypesAvailableForSubscribersubscriberIdtradeIdtradeId**
> List&lt;SCServiceChannelServicesMessagingAssetsAssetType&gt; AssetTypesGetAssetTypesAvailableForSubscribersubscriberIdtradeIdtradeId (int subscriberId, int? tradeId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetTypesGetAssetTypesAvailableForSubscribersubscriberIdtradeIdtradeIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetTypesApi(config);
            var subscriberId = 56;  // int | 
            var tradeId = 56;  // int? |  (optional) 

            try
            {
                List<SCServiceChannelServicesMessagingAssetsAssetType> result = apiInstance.AssetTypesGetAssetTypesAvailableForSubscribersubscriberIdtradeIdtradeId(subscriberId, tradeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetTypesApi.AssetTypesGetAssetTypesAvailableForSubscribersubscriberIdtradeIdtradeId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetTypesGetAssetTypesAvailableForSubscribersubscriberIdtradeIdtradeIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<SCServiceChannelServicesMessagingAssetsAssetType>> response = apiInstance.AssetTypesGetAssetTypesAvailableForSubscribersubscriberIdtradeIdtradeIdWithHttpInfo(subscriberId, tradeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetTypesApi.AssetTypesGetAssetTypesAvailableForSubscribersubscriberIdtradeIdtradeIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** |  |  |
| **tradeId** | **int?** |  | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingAssetsAssetType&gt;**](SCServiceChannelServicesMessagingAssetsAssetType.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions; |  -  |
| **404** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              502 — Asset Types not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assettypesgetassettypesbylocation"></a>
# **AssetTypesGetAssetTypesByLocation**
> Object AssetTypesGetAssetTypesByLocation (SCServiceChannelServicesCoreInternalRequestsAssetsGetAssetTypesByLocationRequestInternal request)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetTypesGetAssetTypesByLocationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetTypesApi(config);
            var request = new SCServiceChannelServicesCoreInternalRequestsAssetsGetAssetTypesByLocationRequestInternal(); // SCServiceChannelServicesCoreInternalRequestsAssetsGetAssetTypesByLocationRequestInternal | 

            try
            {
                Object result = apiInstance.AssetTypesGetAssetTypesByLocation(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetTypesApi.AssetTypesGetAssetTypesByLocation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetTypesGetAssetTypesByLocationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.AssetTypesGetAssetTypesByLocationWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetTypesApi.AssetTypesGetAssetTypesByLocationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesCoreInternalRequestsAssetsGetAssetTypesByLocationRequestInternal**](SCServiceChannelServicesCoreInternalRequestsAssetsGetAssetTypesByLocationRequestInternal.md) |  |  |

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
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions; |  -  |
| **404** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              502 — Asset Type not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assettypesgetsubscriberassettypecategories"></a>
# **AssetTypesGetSubscriberAssetTypeCategories**
> SCServiceChannelServicesMessagingAssetsAssetTypeCategory AssetTypesGetSubscriberAssetTypeCategories (SCServiceChannelServicesMessagingAssetsGetSubscriberAssetCategoriesRequest request)

Get asset categories by SubscriberId and TradeNames

Returns an asset category containing asset types that belong to the specified trade for the specified subscriber.              <br />              ***Note***: `TradeNames` is an optional parameter. When you skip it, the response shows all asset categories containing asset types.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetTypesGetSubscriberAssetTypeCategoriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetTypesApi(config);
            var request = new SCServiceChannelServicesMessagingAssetsGetSubscriberAssetCategoriesRequest(); // SCServiceChannelServicesMessagingAssetsGetSubscriberAssetCategoriesRequest | Request model to retrieve a list of asset categories.

            try
            {
                // Get asset categories by SubscriberId and TradeNames
                SCServiceChannelServicesMessagingAssetsAssetTypeCategory result = apiInstance.AssetTypesGetSubscriberAssetTypeCategories(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetTypesApi.AssetTypesGetSubscriberAssetTypeCategories: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetTypesGetSubscriberAssetTypeCategoriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get asset categories by SubscriberId and TradeNames
    ApiResponse<SCServiceChannelServicesMessagingAssetsAssetTypeCategory> response = apiInstance.AssetTypesGetSubscriberAssetTypeCategoriesWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetTypesApi.AssetTypesGetSubscriberAssetTypeCategoriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingAssetsGetSubscriberAssetCategoriesRequest**](SCServiceChannelServicesMessagingAssetsGetSubscriberAssetCategoriesRequest.md) | Request model to retrieve a list of asset categories. |  |

### Return type

[**SCServiceChannelServicesMessagingAssetsAssetTypeCategory**](SCServiceChannelServicesMessagingAssetsAssetTypeCategory.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Asset categories are in the response. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | Something went wrong, and the server was unable to complete your request.              &lt;br/&gt;Error codes:              501 — Object reference is not set to an instance of an object              501 — Value cannot be null |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assettypes_0"></a>
# **AssetTypes_0**
> SCServiceChannelServicesMessagingAssetsAddAssetTypeResponse AssetTypes_0 (SCServiceChannelServicesMessagingAssetsAddAssetTypeRequest req)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetTypes_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetTypesApi(config);
            var req = new SCServiceChannelServicesMessagingAssetsAddAssetTypeRequest(); // SCServiceChannelServicesMessagingAssetsAddAssetTypeRequest | 

            try
            {
                SCServiceChannelServicesMessagingAssetsAddAssetTypeResponse result = apiInstance.AssetTypes_0(req);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetTypesApi.AssetTypes_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetTypes_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SCServiceChannelServicesMessagingAssetsAddAssetTypeResponse> response = apiInstance.AssetTypes_0WithHttpInfo(req);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetTypesApi.AssetTypes_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **req** | [**SCServiceChannelServicesMessagingAssetsAddAssetTypeRequest**](SCServiceChannelServicesMessagingAssetsAddAssetTypeRequest.md) |  |  |

### Return type

[**SCServiceChannelServicesMessagingAssetsAddAssetTypeResponse**](SCServiceChannelServicesMessagingAssetsAddAssetTypeResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              3100 — Asset Type Name is already in use.              3106 — Asset Type Name is Missing.              703 — Primary trade not found. |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assettypesassettypeid"></a>
# **AssetTypesassetTypeId**
> SCServiceChannelServicesMessagingAssetsAssetType AssetTypesassetTypeId (int assetTypeId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetTypesassetTypeIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetTypesApi(config);
            var assetTypeId = 56;  // int | 

            try
            {
                SCServiceChannelServicesMessagingAssetsAssetType result = apiInstance.AssetTypesassetTypeId(assetTypeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetTypesApi.AssetTypesassetTypeId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetTypesassetTypeIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SCServiceChannelServicesMessagingAssetsAssetType> response = apiInstance.AssetTypesassetTypeIdWithHttpInfo(assetTypeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetTypesApi.AssetTypesassetTypeIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetTypeId** | **int** |  |  |

### Return type

[**SCServiceChannelServicesMessagingAssetsAssetType**](SCServiceChannelServicesMessagingAssetsAssetType.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions; |  -  |
| **404** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              502 — Asset Type not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assettypesassettypeid_0"></a>
# **AssetTypesassetTypeId_0**
> void AssetTypesassetTypeId_0 (int assetTypeId, SCServiceChannelServicesMessagingAssetsAssetType type)



Update Asset Type              Don't specify AdditiolanTrades if no changes in Additiolan Trades needed              Set AdditiolanTrades = [] to delete existing Additiolan Trades for asset type              If AdditiolanTrades contains records then these trades will be set as Additional Trades to asset type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetTypesassetTypeId_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetTypesApi(config);
            var assetTypeId = 56;  // int | 
            var type = new SCServiceChannelServicesMessagingAssetsAssetType(); // SCServiceChannelServicesMessagingAssetsAssetType | 

            try
            {
                apiInstance.AssetTypesassetTypeId_0(assetTypeId, type);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetTypesApi.AssetTypesassetTypeId_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetTypesassetTypeId_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AssetTypesassetTypeId_0WithHttpInfo(assetTypeId, type);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetTypesApi.AssetTypesassetTypeId_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetTypeId** | **int** |  |  |
| **type** | [**SCServiceChannelServicesMessagingAssetsAssetType**](SCServiceChannelServicesMessagingAssetsAssetType.md) |  |  |

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
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              3101 — Asset Type Doesn&#39;t Exist!.              3102 — Asset Type already contains assets. Refrigerant Purpose can not be changed!              703 — Trade not found. |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assettypesassettypeid_1"></a>
# **AssetTypesassetTypeId_1**
> void AssetTypesassetTypeId_1 (int assetTypeId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetTypesassetTypeId_1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetTypesApi(config);
            var assetTypeId = 56;  // int | 

            try
            {
                apiInstance.AssetTypesassetTypeId_1(assetTypeId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetTypesApi.AssetTypesassetTypeId_1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetTypesassetTypeId_1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AssetTypesassetTypeId_1WithHttpInfo(assetTypeId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetTypesApi.AssetTypesassetTypeId_1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetTypeId** | **int** |  |  |

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
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              502 — Asset Type not found.              3103 — Failed to delete asset type              3104 — Failed to delete asset type. Existing assets found.              3108 — Failed to delete asset type. Existing proposals found.              3105 — Cant modify asset type ParentId.              504 — API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

