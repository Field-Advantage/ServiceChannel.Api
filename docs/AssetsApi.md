# ServiceChannel.Api.Api.AssetsApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Assets**](AssetsApi.md#assets) | **PUT** /assets | Update an asset |
| [**AssetsActivation**](AssetsApi.md#assetsactivation) | **POST** /assets/Activation | Activates or deactivates an asset depending on passed parameter. |
| [**AssetsAddUpdateAsset**](AssetsApi.md#assetsaddupdateasset) | **POST** /assets/AddUpdateAsset | Add Update Asset |
| [**AssetsAssetMeter**](AssetsApi.md#assetsassetmeter) | **POST** /assets/AssetMeter | Add asset meters |
| [**AssetsAssetMeterReading**](AssetsApi.md#assetsassetmeterreading) | **PUT** /assets/AssetMeterReading | Update an asset meter reading |
| [**AssetsAssetMeterReading_0**](AssetsApi.md#assetsassetmeterreading_0) | **POST** /assets/AssetMeterReading |  |
| [**AssetsAssetMeterReadingsassetIdlastMeterReadingValuesOnlylastMeterReadingValuesOnly**](AssetsApi.md#assetsassetmeterreadingsassetidlastmeterreadingvaluesonlylastmeterreadingvaluesonly) | **GET** /assets/AssetMeterReadings/{assetId} | Get asset readings |
| [**AssetsAssetMetersassetMeterIdassetMeterIdassetIdassetId**](AssetsApi.md#assetsassetmetersassetmeteridassetmeteridassetidassetid) | **GET** /assets/AssetMeters | Get asset meters |
| [**AssetsAssetcomponents**](AssetsApi.md#assetsassetcomponents) | **POST** /assets/assetcomponents | Get circuits and components |
| [**AssetsAssetrepairstatusassetIdassetId**](AssetsApi.md#assetsassetrepairstatusassetidassetid) | **GET** /assets/assetrepairstatus | Get Asset Repair Status By AssetId |
| [**AssetsAssetsforreplacement**](AssetsApi.md#assetsassetsforreplacement) | **POST** /assets/assetsforreplacement | Get Assets For Replacement |
| [**AssetsAssetstatushistoryassetIdassetId**](AssetsApi.md#assetsassetstatushistoryassetidassetid) | **GET** /assets/assetstatushistory | Get Asset Status History By AssetId |
| [**AssetsAssociateAssetCode**](AssetsApi.md#assetsassociateassetcode) | **POST** /assets/AssociateAssetCode | Associate Asset Code |
| [**AssetsBrands**](AssetsApi.md#assetsbrands) | **GET** /assets/Brands | Get Brands |
| [**AssetsCanCreateAssetassetTypeId**](AssetsApi.md#assetscancreateassetassettypeid) | **GET** /assets/CanCreateAsset/{assetTypeId} | Getting permission for provider for create new asset |
| [**AssetsCanManageAttachmentssubscriberIdsubscriberId**](AssetsApi.md#assetscanmanageattachmentssubscriberidsubscriberid) | **PUT** /assets/canManageAttachments | Check if provider is allowed to manage attachments |
| [**AssetsCanProviderCreateAssetForTradetradeId**](AssetsApi.md#assetscanprovidercreateassetfortradetradeid) | **GET** /assets/CanProviderCreateAssetForTrade/{tradeId} | Getting permission for provider for create new asset |
| [**AssetsCanUserEditAssetassetTypeIdassetTypeId**](AssetsApi.md#assetscanusereditassetassettypeidassettypeid) | **GET** /assets/CanUserEditAsset | Getting permission for edit asset |
| [**AssetsCreateAssetMeterReadingsBulk**](AssetsApi.md#assetscreateassetmeterreadingsbulk) | **POST** /assets/CreateAssetMeterReadingsBulk | Asset meter readings bulk create |
| [**AssetsGetAssetTypeGroupsByAssetsIds**](AssetsApi.md#assetsgetassettypegroupsbyassetsids) | **POST** /assets/GetAssetTypeGroupsByAssetsIds | Get asset type groups by assetsIds |
| [**AssetsGetAssetValidationHistoryByTrackingNumber**](AssetsApi.md#assetsgetassetvalidationhistorybytrackingnumber) | **POST** /assets/GetAssetValidationHistoryByTrackingNumber | Returns asset tag validation information for the specified assets and the work order |
| [**AssetsGetAssetValidationInformation**](AssetsApi.md#assetsgetassetvalidationinformation) | **POST** /assets/GetAssetValidationInformation | Returns asset tag validation information for the specified list of assets |
| [**AssetsGetPrimaryAttachmentsForAssetList**](AssetsApi.md#assetsgetprimaryattachmentsforassetlist) | **POST** /assets/getPrimaryAttachmentsForAssetList | Get primary attachments for asset list |
| [**AssetsGetPrimaryAttachmentsForAssetListV1**](AssetsApi.md#assetsgetprimaryattachmentsforassetlistv1) | **POST** /assets/getPrimaryAttachmentsForAssetList_v1 | Get primary attachments for asset list |
| [**AssetsGetValidationStatusesForMultipleWorkOrders**](AssetsApi.md#assetsgetvalidationstatusesformultipleworkorders) | **POST** /assets/GetValidationStatusesForMultipleWorkOrders | Gets list of asset validation statuses for multiple work order. |
| [**AssetsGetassetwohistoryworkOrdersCountworkOrdersCount**](AssetsApi.md#assetsgetassetwohistoryworkorderscountworkorderscount) | **POST** /assets/getassetwohistory | Get Assets WorkOrders |
| [**AssetsGetfilteredassetleaks**](AssetsApi.md#assetsgetfilteredassetleaks) | **POST** /assets/getfilteredassetleaks | Ge tFiltered Asset Leaks |
| [**AssetsGetfilteredassets**](AssetsApi.md#assetsgetfilteredassets) | **POST** /assets/getfilteredassets | Get Filtered Assets |
| [**AssetsGetfilteredassetsV1providerIdproviderId**](AssetsApi.md#assetsgetfilteredassetsv1provideridproviderid) | **POST** /assets/getfilteredassetsV1 | Get Filtered Assets V1 |
| [**AssetsGetwoassettrackingwoIdwoId**](AssetsApi.md#assetsgetwoassettrackingwoidwoid) | **POST** /assets/getwoassettracking | Get Wo Asset Tracking |
| [**AssetsHasAssetBeenValidated**](AssetsApi.md#assetshasassetbeenvalidated) | **POST** /assets/HasAssetBeenValidated | Determines if the specified asset has had its tag validated or not |
| [**AssetsLocationAssetsTreelocationIdlocationIdtradetrade**](AssetsApi.md#assetslocationassetstreelocationidlocationidtradetrade) | **POST** /assets/locationAssetsTree |  |
| [**AssetsLocationslocationIdtradetrade**](AssetsApi.md#assetslocationslocationidtradetrade) | **GET** /assets/locations/{locationId} | Get assets |
| [**AssetsRecordScannedAsset**](AssetsApi.md#assetsrecordscannedasset) | **POST** /assets/RecordScannedAsset | Records an audit record for the asset tag that was scanned |
| [**AssetsSearchassets**](AssetsApi.md#assetssearchassets) | **POST** /assets/searchassets | Search Assets |
| [**AssetsSearchassetsByGroupId**](AssetsApi.md#assetssearchassetsbygroupid) | **POST** /assets/searchassetsByGroupId | Get list of assets grouped by AsseTypeGroupID |
| [**AssetsUnableToAddReasons**](AssetsApi.md#assetsunabletoaddreasons) | **GET** /assets/UnableToAddReasons | Gets list of unable to add reasons. |
| [**AssetsUnableToAddReasons_0**](AssetsApi.md#assetsunabletoaddreasons_0) | **POST** /assets/UnableToAddReasons | Creates wo_UnableToAddAssetHistory. |
| [**AssetsUnableToScanReasons**](AssetsApi.md#assetsunabletoscanreasons) | **POST** /assets/UnableToScanReasons | Creates wo_UnableToScanAssetHistory. |
| [**AssetsUnableToScanReasonsNotAttachedAsset**](AssetsApi.md#assetsunabletoscanreasonsnotattachedasset) | **GET** /assets/UnableToScanReasonsNotAttachedAsset | Gets list of unable to scan reasons not attached assets. |
| [**AssetsUnableToScanReasonssubscriberIdsubscriberId**](AssetsApi.md#assetsunabletoscanreasonssubscriberidsubscriberid) | **GET** /assets/UnableToScanReasons | Gets list of unable to scan reasons. |
| [**AssetsUnableToValidateReasons**](AssetsApi.md#assetsunabletovalidatereasons) | **GET** /assets/UnableToValidateReasons | Gets list of unable to validate reasons. |
| [**AssetsUnableToValidateReasonsNotAttachedAsset**](AssetsApi.md#assetsunabletovalidatereasonsnotattachedasset) | **GET** /assets/UnableToValidateReasonsNotAttachedAsset | Gets list of unable to validate reasons not attached assets. |
| [**AssetsUnableToValidateReasons_0**](AssetsApi.md#assetsunabletovalidatereasons_0) | **POST** /assets/UnableToValidateReasons | Creates wo_UnableToValidateAssetHistory. |
| [**AssetsUpdateAssetLocationassetIdassetIdlocationIdlocationId**](AssetsApi.md#assetsupdateassetlocationassetidassetidlocationidlocationid) | **PUT** /assets/updateAssetLocation | Update asset location |
| [**AssetsUpdateAssetMeterReadingsBulk**](AssetsApi.md#assetsupdateassetmeterreadingsbulk) | **PUT** /assets/UpdateAssetMeterReadingsBulk | Asset meter readings bulk update |
| [**AssetsUpdateAssetStatus**](AssetsApi.md#assetsupdateassetstatus) | **PUT** /assets/updateAssetStatus | Update Asset Status By AssetId |
| [**AssetsUpdateAssetsStatuses**](AssetsApi.md#assetsupdateassetsstatuses) | **PUT** /assets/updateAssetsStatuses | Update Assets Statuses |
| [**AssetsUpdateassetrepairstatus**](AssetsApi.md#assetsupdateassetrepairstatus) | **PUT** /assets/updateassetrepairstatus | Update Asset Repair Status By AssetId |
| [**AssetsV2BrandskeywordkeywordstartIndexstartIndexpageSizepageSize**](AssetsApi.md#assetsv2brandskeywordkeywordstartindexstartindexpagesizepagesize) | **GET** /assets/v2/Brands | Get Brands (ver.2) |
| [**AssetsValidationRulesForMultipleSubscribers**](AssetsApi.md#assetsvalidationrulesformultiplesubscribers) | **POST** /assets/ValidationRulesForMultipleSubscribers | Gets the asset tag validation settings for multiple subscribers. |
| [**AssetsWorkorderAreassubscriberId**](AssetsApi.md#assetsworkorderareassubscriberid) | **GET** /assets/WorkorderAreas/{subscriberId} | Get Work Orders Area list |
| [**AssetsWorkordersAttachassets**](AssetsApi.md#assetsworkordersattachassets) | **PUT** /assets/workorders/attachassets | Add assets |
| [**AssetsWorkordersRemoveassets**](AssetsApi.md#assetsworkordersremoveassets) | **POST** /assets/workorders/removeassets | Remove specified assets from specified work order |
| [**AssetsWorkordersSetupassets**](AssetsApi.md#assetsworkorderssetupassets) | **PUT** /assets/workorders/setupassets | Add and replace assets |
| [**AssetsWorkordersworkorderIdAttach**](AssetsApi.md#assetsworkordersworkorderidattach) | **PUT** /assets/workorders/{workorderId}/attach | Attach an asset |
| [**AssetsWorkordersworkorderIdDetach**](AssetsApi.md#assetsworkordersworkorderiddetach) | **PUT** /assets/workorders/{workorderId}/detach | Remove assets |
| [**AssetsWorkrequestRemove**](AssetsApi.md#assetsworkrequestremove) | **POST** /assets/workrequest/remove | Remove specified assets from specified work request |
| [**AssetsWorkrequestSetup**](AssetsApi.md#assetsworkrequestsetup) | **PUT** /assets/workrequest/setup | Setup assets to the work request |
| [**AssetsWorkrequestworkRequestId**](AssetsApi.md#assetsworkrequestworkrequestid) | **GET** /assets/workrequest/{workRequestId} | Setup assets to the specified work order |
| [**Assets_0**](AssetsApi.md#assets_0) | **POST** /assets | Add an asset |
| [**AssetsassetIdlocationIdlocationIdstoreIdstoreIdtagIdtagIdtrackingNumbertrackingNumber**](AssetsApi.md#assetsassetidlocationidlocationidstoreidstoreidtagidtagidtrackingnumbertrackingnumber) | **GET** /assets/{assetId} | Get an asset |
| [**AssetsassetidAssetwohistory**](AssetsApi.md#assetsassetidassetwohistory) | **GET** /assets/{assetid}/assetwohistory | Get asset workorder history |
| [**AssetsbrandNameAddBrand**](AssetsApi.md#assetsbrandnameaddbrand) | **POST** /assets/{brandName}/AddBrand | Add Brand |
| [**AssetssubscriberIdValidationRules**](AssetsApi.md#assetssubscriberidvalidationrules) | **GET** /assets/{subscriberId}/ValidationRules | Gets the asset tag validation settings for the specified subscriber. |
| [**AssetstrackingNumberIsValidationRequired**](AssetsApi.md#assetstrackingnumberisvalidationrequired) | **GET** /assets/{trackingNumber}/IsValidationRequired | Get Scan Method |
| [**AssetstradeIdGetAssetTypeGroupsByTradeId**](AssetsApi.md#assetstradeidgetassettypegroupsbytradeid) | **GET** /assets/{tradeId}/getAssetTypeGroupsByTradeId | Get asset type groups by tradeId |
| [**AssociateAssetCode**](AssetsApi.md#associateassetcode) | **GET** /odata/assets/Service.AssociateAssetCode(equipmentId&#x3D;{equipmentId},code&#x3D;{code},processDuplicatedAssetTag&#x3D;{processDuplicatedAssetTag}) |  |
| [**FindAssets**](AssetsApi.md#findassets) | **GET** /odata/assets/Service.FindAssets(searchCriteria&#x3D;{searchCriteria}) | Finds assets using the supplied search criteria.  The following fields will be searched for a match to the search criteria:  tag ID, asset type, brand, serial Number |
| [**FindAssetsByLocation**](AssetsApi.md#findassetsbylocation) | **GET** /odata/assets/Service.FindAssetsByLocation(searchCriteria&#x3D;{searchCriteria},locationId&#x3D;{locationId}) |  |
| [**FindAssetsBySubscriber**](AssetsApi.md#findassetsbysubscriber) | **GET** /odata/assets/Service.FindAssetsBySubscriber(searchCriteria&#x3D;{searchCriteria},subscriberId&#x3D;{subscriberId}) | Finds assets using the supplied search criteria.  The following fields will be searched for a match to the search criteria:  tag ID, asset type, brand, serial Number |
| [**GetAsset**](AssetsApi.md#getasset) | **GET** /odata/assets({assetId}) | Get an asset |
| [**SearchAssets**](AssetsApi.md#searchassets) | **GET** /odata/assets/Service.Search(locationId&#x3D;{locationId},code&#x3D;{code}) | Get assets by &#x60;locationId&#x60; and &#x60;code&#x60; |

<a id="assets"></a>
# **Assets**
> Object Assets (SCServiceChannelServicesMessagingAssetsUpdateAssetRequest assetRequest)

Update an asset

Modifies the details of an existing asset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var assetRequest = new SCServiceChannelServicesMessagingAssetsUpdateAssetRequest(); // SCServiceChannelServicesMessagingAssetsUpdateAssetRequest | Request model to update an asset.              <br />The following parameters are required in the request:               • **Id**: Unique numeric identification number of an asset you want to update.               • **Tag**: Alphanumeric asset identifier assigned by the client, aka **Tag ID**.               • **Manufacturer**: Company brand that produces an asset and exists in the system.               • **StoreId**: Alphanumeric identifier of the existing location.               • **Trade**: The line of work an asset is used for. For example, *ELECTRICAL*, *CARPENTRY*, *CCTV*.               • **Type**: Type of an asset. For example, *Refrigerator*, *Computer Monitor*.              <br />***Note***. The `Tag` and `Location` parameters should remain unchanged.

            try
            {
                // Update an asset
                Object result = apiInstance.Assets(assetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.Assets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an asset
    ApiResponse<Object> response = apiInstance.AssetsWithHttpInfo(assetRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetRequest** | [**SCServiceChannelServicesMessagingAssetsUpdateAssetRequest**](SCServiceChannelServicesMessagingAssetsUpdateAssetRequest.md) | Request model to update an asset.              &lt;br /&gt;The following parameters are required in the request:               • **Id**: Unique numeric identification number of an asset you want to update.               • **Tag**: Alphanumeric asset identifier assigned by the client, aka **Tag ID**.               • **Manufacturer**: Company brand that produces an asset and exists in the system.               • **StoreId**: Alphanumeric identifier of the existing location.               • **Trade**: The line of work an asset is used for. For example, *ELECTRICAL*, *CARPENTRY*, *CCTV*.               • **Type**: Type of an asset. For example, *Refrigerator*, *Computer Monitor*.              &lt;br /&gt;***Note***. The &#x60;Tag&#x60; and &#x60;Location&#x60; parameters should remain unchanged. |  |

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
| **200** | The ID of the updated asset is in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              502 — No asset to update              502 — Asset is not found              503 — Unknown Brand name              503 — Request is empty or null              503 — Do not have rights for editing Asset              503 — Unknown Equipment type              503 — &#39;Uses Refrigerant&#39; attribute can not be changed              503 — Asset location can not be changed: There are active PM services for this asset. |  -  |
| **401** | The request is not authorized.              &lt;br&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | The server was unable to complete the request due to an internal error.              &lt;br&gt;Error codes:              501 — Object reference is not set to an instance of an object. |  -  |
| **502** | The server, while acting as a gateway or proxy, received an invalid response from the upstream server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsactivation"></a>
# **AssetsActivation**
> Object AssetsActivation (SCServiceChannelServicesMessagingEquipmentsActivateAssetRequest request)

Activates or deactivates an asset depending on passed parameter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsActivationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var request = new SCServiceChannelServicesMessagingEquipmentsActivateAssetRequest(); // SCServiceChannelServicesMessagingEquipmentsActivateAssetRequest | A set of values to indicate asset and action.              IsActive \"true\" means that asset must be activated.              IsActive \"false\" means that asset must be inactivated.

            try
            {
                // Activates or deactivates an asset depending on passed parameter.
                Object result = apiInstance.AssetsActivation(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsActivation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsActivationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Activates or deactivates an asset depending on passed parameter.
    ApiResponse<Object> response = apiInstance.AssetsActivationWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsActivationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingEquipmentsActivateAssetRequest**](SCServiceChannelServicesMessagingEquipmentsActivateAssetRequest.md) | A set of values to indicate asset and action.              IsActive \&quot;true\&quot; means that asset must be activated.              IsActive \&quot;false\&quot; means that asset must be inactivated. |  |

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
| **401** | Indicates that the requested resource requires authentication. |  -  |
| **403** | Forbidden - the data could not be processed by security reasons. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsaddupdateasset"></a>
# **AssetsAddUpdateAsset**
> Object AssetsAddUpdateAsset (SCServiceChannelServicesMessagingAssetsAddUpdateAssetRequest request)

Add Update Asset

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsAddUpdateAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var request = new SCServiceChannelServicesMessagingAssetsAddUpdateAssetRequest(); // SCServiceChannelServicesMessagingAssetsAddUpdateAssetRequest | 

            try
            {
                // Add Update Asset
                Object result = apiInstance.AssetsAddUpdateAsset(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsAddUpdateAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsAddUpdateAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Update Asset
    ApiResponse<Object> response = apiInstance.AssetsAddUpdateAssetWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsAddUpdateAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingAssetsAddUpdateAssetRequest**](SCServiceChannelServicesMessagingAssetsAddUpdateAssetRequest.md) |  |  |

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
| **200** | The ID of the updated asset is in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              502 — No asset to update              502 — Asset is not found              503 — Unknown Brand name              503 — Request is empty or null              503 — Do not have rights for editing Asset              503 — Unknown Equipment type              503 — &#39;Uses Refrigerant&#39; attribute can not be changed              503 — Asset location can not be changed: There are active PM services for this asset. |  -  |
| **401** | The request is not authorized.              &lt;br&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | The server was unable to complete the request due to an internal error.              &lt;br&gt;Error codes:              501 — Object reference is not set to an instance of an object. |  -  |
| **502** | The server, while acting as a gateway or proxy, received an invalid response from the upstream server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsassetmeter"></a>
# **AssetsAssetMeter**
> void AssetsAssetMeter (SCServiceChannelServicesMessagingAssetsAddAssetMeterRequest request)

Add asset meters

Attaches an asset meter to a certain asset by specifying a particular asset type meter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsAssetMeterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var request = new SCServiceChannelServicesMessagingAssetsAddAssetMeterRequest(); // SCServiceChannelServicesMessagingAssetsAddAssetMeterRequest | Request to add an asset meter to the existing asset.

            try
            {
                // Add asset meters
                apiInstance.AssetsAssetMeter(request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsAssetMeter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsAssetMeterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add asset meters
    apiInstance.AssetsAssetMeterWithHttpInfo(request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsAssetMeterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingAssetsAddAssetMeterRequest**](SCServiceChannelServicesMessagingAssetsAddAssetMeterRequest.md) | Request to add an asset meter to the existing asset. |  |

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
| **200** | The asset meter is successfully added. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              Failed to add an asset meter |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsassetmeterreading"></a>
# **AssetsAssetMeterReading**
> void AssetsAssetMeterReading (SCServiceChannelServicesMessagingAssetsUpdateAssetMeterReadingRequest request)

Update an asset meter reading

Updates information of a particular asset meter reading.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsAssetMeterReadingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var request = new SCServiceChannelServicesMessagingAssetsUpdateAssetMeterReadingRequest(); // SCServiceChannelServicesMessagingAssetsUpdateAssetMeterReadingRequest | Request to update the existing asset meter reading.

            try
            {
                // Update an asset meter reading
                apiInstance.AssetsAssetMeterReading(request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsAssetMeterReading: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsAssetMeterReadingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an asset meter reading
    apiInstance.AssetsAssetMeterReadingWithHttpInfo(request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsAssetMeterReadingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingAssetsUpdateAssetMeterReadingRequest**](SCServiceChannelServicesMessagingAssetsUpdateAssetMeterReadingRequest.md) | Request to update the existing asset meter reading. |  |

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
| **200** | The asset meter reading is successfully updated. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              Failed to Update Asset Meter Reading |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsassetmeterreading_0"></a>
# **AssetsAssetMeterReading_0**
> void AssetsAssetMeterReading_0 (SCServiceChannelServicesMessagingAssetsAddAssetMeterReadingRequest request)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsAssetMeterReading_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var request = new SCServiceChannelServicesMessagingAssetsAddAssetMeterReadingRequest(); // SCServiceChannelServicesMessagingAssetsAddAssetMeterReadingRequest | 

            try
            {
                apiInstance.AssetsAssetMeterReading_0(request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsAssetMeterReading_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsAssetMeterReading_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AssetsAssetMeterReading_0WithHttpInfo(request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsAssetMeterReading_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingAssetsAddAssetMeterReadingRequest**](SCServiceChannelServicesMessagingAssetsAddAssetMeterReadingRequest.md) |  |  |

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
| **200** | The asset meter reading is successfully added. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              Failed to add asset meter reading. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsassetmeterreadingsassetidlastmeterreadingvaluesonlylastmeterreadingvaluesonly"></a>
# **AssetsAssetMeterReadingsassetIdlastMeterReadingValuesOnlylastMeterReadingValuesOnly**
> List&lt;SCServiceChannelServicesMessagingAssetsAssetMeterReadingResponseItem&gt; AssetsAssetMeterReadingsassetIdlastMeterReadingValuesOnlylastMeterReadingValuesOnly (int assetId, bool? lastMeterReadingValuesOnly = null)

Get asset readings

Returns asset meter readings details of the specified asset for the current subscriber.              <br />Send the [PUT /assets/AssetMeterReadings](https://developer.servicechannel.com/swagger/ui/index?version=3#/Assets/PUTv3_assets_AssetMeterReading) request to edit a particular asset meter reading.              <br />Refer to ServiceChannel University to learn more about [asset meter readings](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/834469973/Asset+Meter+Reading).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsAssetMeterReadingsassetIdlastMeterReadingValuesOnlylastMeterReadingValuesOnlyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var assetId = 56;  // int | Unique numeric asset identifier you want to retrieve asset meter readings for.
            var lastMeterReadingValuesOnly = false;  // bool? | When it is true the response should contain one last AssetMeterReading entry for each AssetTypeMeter. (optional)  (default to false)

            try
            {
                // Get asset readings
                List<SCServiceChannelServicesMessagingAssetsAssetMeterReadingResponseItem> result = apiInstance.AssetsAssetMeterReadingsassetIdlastMeterReadingValuesOnlylastMeterReadingValuesOnly(assetId, lastMeterReadingValuesOnly);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsAssetMeterReadingsassetIdlastMeterReadingValuesOnlylastMeterReadingValuesOnly: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsAssetMeterReadingsassetIdlastMeterReadingValuesOnlylastMeterReadingValuesOnlyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get asset readings
    ApiResponse<List<SCServiceChannelServicesMessagingAssetsAssetMeterReadingResponseItem>> response = apiInstance.AssetsAssetMeterReadingsassetIdlastMeterReadingValuesOnlylastMeterReadingValuesOnlyWithHttpInfo(assetId, lastMeterReadingValuesOnly);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsAssetMeterReadingsassetIdlastMeterReadingValuesOnlylastMeterReadingValuesOnlyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetId** | **int** | Unique numeric asset identifier you want to retrieve asset meter readings for. |  |
| **lastMeterReadingValuesOnly** | **bool?** | When it is true the response should contain one last AssetMeterReading entry for each AssetTypeMeter. | [optional] [default to false] |

### Return type

[**List&lt;SCServiceChannelServicesMessagingAssetsAssetMeterReadingResponseItem&gt;**](SCServiceChannelServicesMessagingAssetsAssetMeterReadingResponseItem.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The asset meter readings details are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **404** | The resource you are looking for has been removed, had its name changed, or is temporarily unavailable. / The request URI is incorrect, or the resource does not exist. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsassetmetersassetmeteridassetmeteridassetidassetid"></a>
# **AssetsAssetMetersassetMeterIdassetMeterIdassetIdassetId**
> List&lt;SCServiceChannelServicesMessagingAssetsAssetMeter&gt; AssetsAssetMetersassetMeterIdassetMeterIdassetIdassetId (int? assetMeterId = null, int? assetId = null)

Get asset meters

Returns the details of an asset meter by sending the `assetMeterId` parameter  or the details of one or several asset meters by using the `assetId` parameter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsAssetMetersassetMeterIdassetMeterIdassetIdassetIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var assetMeterId = 56;  // int? | Unique numeric asset meter identifier you want to get the details of. (optional) 
            var assetId = 56;  // int? | Unique numeric asset identifier you want to retrieve asset meter details for. (optional) 

            try
            {
                // Get asset meters
                List<SCServiceChannelServicesMessagingAssetsAssetMeter> result = apiInstance.AssetsAssetMetersassetMeterIdassetMeterIdassetIdassetId(assetMeterId, assetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsAssetMetersassetMeterIdassetMeterIdassetIdassetId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsAssetMetersassetMeterIdassetMeterIdassetIdassetIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get asset meters
    ApiResponse<List<SCServiceChannelServicesMessagingAssetsAssetMeter>> response = apiInstance.AssetsAssetMetersassetMeterIdassetMeterIdassetIdassetIdWithHttpInfo(assetMeterId, assetId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsAssetMetersassetMeterIdassetMeterIdassetIdassetIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetMeterId** | **int?** | Unique numeric asset meter identifier you want to get the details of. | [optional]  |
| **assetId** | **int?** | Unique numeric asset identifier you want to retrieve asset meter details for. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingAssetsAssetMeter&gt;**](SCServiceChannelServicesMessagingAssetsAssetMeter.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The asset meter details are in the response. |  -  |
| **400** | The request was not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              AssetId and Id can&#39;t be both null |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsassetcomponents"></a>
# **AssetsAssetcomponents**
> void AssetsAssetcomponents (SCServiceChannelServicesMessagingEquipmentsAssetComponentsRequest request)

Get circuits and components

Retrieves all circuits and components added to the specified parent assets.              <br />Learn more about [updating assets on work orders](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/1484194012/Updating+Assets+on+Work+Orders) in ServiceChannel University.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsAssetcomponentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var request = new SCServiceChannelServicesMessagingEquipmentsAssetComponentsRequest(); // SCServiceChannelServicesMessagingEquipmentsAssetComponentsRequest | Request to get circuits and components for the specified parent assets.              <br />Request parameters:               • **ParentIds**. Add one or several asset IDs you want to get circuits and components for.               • **OnlyRefrigerantTrackingAssets**. Enter `true` to retrieve only circuits and components that contain refrigerant and F-gases.

            try
            {
                // Get circuits and components
                apiInstance.AssetsAssetcomponents(request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsAssetcomponents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsAssetcomponentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get circuits and components
    apiInstance.AssetsAssetcomponentsWithHttpInfo(request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsAssetcomponentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingEquipmentsAssetComponentsRequest**](SCServiceChannelServicesMessagingEquipmentsAssetComponentsRequest.md) | Request to get circuits and components for the specified parent assets.              &lt;br /&gt;Request parameters:               • **ParentIds**. Add one or several asset IDs you want to get circuits and components for.               • **OnlyRefrigerantTrackingAssets**. Enter &#x60;true&#x60; to retrieve only circuits and components that contain refrigerant and F-gases. |  |

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
| **200** | The circuits and components for the specified parent assets are in the response. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 — Object reference is not set to an instance of an object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsassetrepairstatusassetidassetid"></a>
# **AssetsAssetrepairstatusassetIdassetId**
> string AssetsAssetrepairstatusassetIdassetId (int assetId)

Get Asset Repair Status By AssetId

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsAssetrepairstatusassetIdassetIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var assetId = 56;  // int | 

            try
            {
                // Get Asset Repair Status By AssetId
                string result = apiInstance.AssetsAssetrepairstatusassetIdassetId(assetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsAssetrepairstatusassetIdassetId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsAssetrepairstatusassetIdassetIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Asset Repair Status By AssetId
    ApiResponse<string> response = apiInstance.AssetsAssetrepairstatusassetIdassetIdWithHttpInfo(assetId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsAssetrepairstatusassetIdassetIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetId** | **int** |  |  |

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
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              503 — User info should not be null;              SubscriberId is null; |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsassetsforreplacement"></a>
# **AssetsAssetsforreplacement**
> Object AssetsAssetsforreplacement (SCServiceChannelServicesMessagingAssetsGetAssetsForReplacementRequest request)

Get Assets For Replacement

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsAssetsforreplacementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var request = new SCServiceChannelServicesMessagingAssetsGetAssetsForReplacementRequest(); // SCServiceChannelServicesMessagingAssetsGetAssetsForReplacementRequest | 

            try
            {
                // Get Assets For Replacement
                Object result = apiInstance.AssetsAssetsforreplacement(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsAssetsforreplacement: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsAssetsforreplacementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Assets For Replacement
    ApiResponse<Object> response = apiInstance.AssetsAssetsforreplacementWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsAssetsforreplacementWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingAssetsGetAssetsForReplacementRequest**](SCServiceChannelServicesMessagingAssetsGetAssetsForReplacementRequest.md) |  |  |

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

<a id="assetsassetstatushistoryassetidassetid"></a>
# **AssetsAssetstatushistoryassetIdassetId**
> SCServiceChannelServicesMessagingAssetsAssetStatusHistoryResponse AssetsAssetstatushistoryassetIdassetId (int assetId)

Get Asset Status History By AssetId

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsAssetstatushistoryassetIdassetIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var assetId = 56;  // int | 

            try
            {
                // Get Asset Status History By AssetId
                SCServiceChannelServicesMessagingAssetsAssetStatusHistoryResponse result = apiInstance.AssetsAssetstatushistoryassetIdassetId(assetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsAssetstatushistoryassetIdassetId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsAssetstatushistoryassetIdassetIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Asset Status History By AssetId
    ApiResponse<SCServiceChannelServicesMessagingAssetsAssetStatusHistoryResponse> response = apiInstance.AssetsAssetstatushistoryassetIdassetIdWithHttpInfo(assetId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsAssetstatushistoryassetIdassetIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetId** | **int** |  |  |

### Return type

[**SCServiceChannelServicesMessagingAssetsAssetStatusHistoryResponse**](SCServiceChannelServicesMessagingAssetsAssetStatusHistoryResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              503 — User info should not be null;              SubscriberId is null; |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsassociateassetcode"></a>
# **AssetsAssociateAssetCode**
> Object AssetsAssociateAssetCode (SCServiceChannelServicesMessagingEquipmentsAssociateAssetRequest request)

Associate Asset Code

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsAssociateAssetCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var request = new SCServiceChannelServicesMessagingEquipmentsAssociateAssetRequest(); // SCServiceChannelServicesMessagingEquipmentsAssociateAssetRequest | 

            try
            {
                // Associate Asset Code
                Object result = apiInstance.AssetsAssociateAssetCode(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsAssociateAssetCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsAssociateAssetCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Associate Asset Code
    ApiResponse<Object> response = apiInstance.AssetsAssociateAssetCodeWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsAssociateAssetCodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingEquipmentsAssociateAssetRequest**](SCServiceChannelServicesMessagingEquipmentsAssociateAssetRequest.md) |  |  |

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

<a id="assetsbrands"></a>
# **AssetsBrands**
> List&lt;SCServiceChannelServicesMessagingAssetsManufacturer&gt; AssetsBrands ()

Get Brands

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsBrandsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);

            try
            {
                // Get Brands
                List<SCServiceChannelServicesMessagingAssetsManufacturer> result = apiInstance.AssetsBrands();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsBrands: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsBrandsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Brands
    ApiResponse<List<SCServiceChannelServicesMessagingAssetsManufacturer>> response = apiInstance.AssetsBrandsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsBrandsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;SCServiceChannelServicesMessagingAssetsManufacturer&gt;**](SCServiceChannelServicesMessagingAssetsManufacturer.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              503 — User info should not be null;              SubscriberId is null; |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetscancreateassetassettypeid"></a>
# **AssetsCanCreateAssetassetTypeId**
> Object AssetsCanCreateAssetassetTypeId (int assetTypeId)

Getting permission for provider for create new asset

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsCanCreateAssetassetTypeIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var assetTypeId = 56;  // int | 

            try
            {
                // Getting permission for provider for create new asset
                Object result = apiInstance.AssetsCanCreateAssetassetTypeId(assetTypeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsCanCreateAssetassetTypeId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsCanCreateAssetassetTypeIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Getting permission for provider for create new asset
    ApiResponse<Object> response = apiInstance.AssetsCanCreateAssetassetTypeIdWithHttpInfo(assetTypeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsCanCreateAssetassetTypeIdWithHttpInfo: " + e.Message);
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetscanmanageattachmentssubscriberidsubscriberid"></a>
# **AssetsCanManageAttachmentssubscriberIdsubscriberId**
> void AssetsCanManageAttachmentssubscriberIdsubscriberId (int subscriberId)

Check if provider is allowed to manage attachments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsCanManageAttachmentssubscriberIdsubscriberIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var subscriberId = 56;  // int | 

            try
            {
                // Check if provider is allowed to manage attachments
                apiInstance.AssetsCanManageAttachmentssubscriberIdsubscriberId(subscriberId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsCanManageAttachmentssubscriberIdsubscriberId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsCanManageAttachmentssubscriberIdsubscriberIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check if provider is allowed to manage attachments
    apiInstance.AssetsCanManageAttachmentssubscriberIdsubscriberIdWithHttpInfo(subscriberId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsCanManageAttachmentssubscriberIdsubscriberIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** |  |  |

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
| **200** | IsAllowed value is successfully retured. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetscanprovidercreateassetfortradetradeid"></a>
# **AssetsCanProviderCreateAssetForTradetradeId**
> Object AssetsCanProviderCreateAssetForTradetradeId (int tradeId)

Getting permission for provider for create new asset

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsCanProviderCreateAssetForTradetradeIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var tradeId = 56;  // int | 

            try
            {
                // Getting permission for provider for create new asset
                Object result = apiInstance.AssetsCanProviderCreateAssetForTradetradeId(tradeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsCanProviderCreateAssetForTradetradeId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsCanProviderCreateAssetForTradetradeIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Getting permission for provider for create new asset
    ApiResponse<Object> response = apiInstance.AssetsCanProviderCreateAssetForTradetradeIdWithHttpInfo(tradeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsCanProviderCreateAssetForTradetradeIdWithHttpInfo: " + e.Message);
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetscanusereditassetassettypeidassettypeid"></a>
# **AssetsCanUserEditAssetassetTypeIdassetTypeId**
> Object AssetsCanUserEditAssetassetTypeIdassetTypeId (int? assetTypeId = null)

Getting permission for edit asset

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsCanUserEditAssetassetTypeIdassetTypeIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var assetTypeId = 56;  // int? |  (optional) 

            try
            {
                // Getting permission for edit asset
                Object result = apiInstance.AssetsCanUserEditAssetassetTypeIdassetTypeId(assetTypeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsCanUserEditAssetassetTypeIdassetTypeId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsCanUserEditAssetassetTypeIdassetTypeIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Getting permission for edit asset
    ApiResponse<Object> response = apiInstance.AssetsCanUserEditAssetassetTypeIdassetTypeIdWithHttpInfo(assetTypeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsCanUserEditAssetassetTypeIdassetTypeIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetTypeId** | **int?** |  | [optional]  |

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

<a id="assetscreateassetmeterreadingsbulk"></a>
# **AssetsCreateAssetMeterReadingsBulk**
> List&lt;SCServiceChannelServicesMessagingAssetsAssetMeterReadingResponseItem&gt; AssetsCreateAssetMeterReadingsBulk (List<SCServiceChannelServicesMessagingAssetsAddAssetMeterReadingRequestItem> request)

Asset meter readings bulk create

Creates asset meter readings.              <br />Learn more about [adding asset meter reading](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/988840218/Adding+Asset+s+Meter+Reading+Data) in ServiceChannel University.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsCreateAssetMeterReadingsBulkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var request = new List<SCServiceChannelServicesMessagingAssetsAddAssetMeterReadingRequestItem>(); // List<SCServiceChannelServicesMessagingAssetsAddAssetMeterReadingRequestItem> | Request to create asset readings.

            try
            {
                // Asset meter readings bulk create
                List<SCServiceChannelServicesMessagingAssetsAssetMeterReadingResponseItem> result = apiInstance.AssetsCreateAssetMeterReadingsBulk(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsCreateAssetMeterReadingsBulk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsCreateAssetMeterReadingsBulkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Asset meter readings bulk create
    ApiResponse<List<SCServiceChannelServicesMessagingAssetsAssetMeterReadingResponseItem>> response = apiInstance.AssetsCreateAssetMeterReadingsBulkWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsCreateAssetMeterReadingsBulkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**List&lt;SCServiceChannelServicesMessagingAssetsAddAssetMeterReadingRequestItem&gt;**](SCServiceChannelServicesMessagingAssetsAddAssetMeterReadingRequestItem.md) | Request to create asset readings. |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingAssetsAssetMeterReadingResponseItem&gt;**](SCServiceChannelServicesMessagingAssetsAssetMeterReadingResponseItem.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The asset meter readings details are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              Failed to create asset meter readings. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **404** | The request URI is incorrect, or the resource does not exist.              &lt;br/&gt;Error codes:              502 — Asset is not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsgetassettypegroupsbyassetsids"></a>
# **AssetsGetAssetTypeGroupsByAssetsIds**
> Dictionary&lt;string, SCServiceChannelServicesMessagingAssetTypesAssetTypeGroup&gt; AssetsGetAssetTypeGroupsByAssetsIds (SCServiceChannelServicesMessagingAssetTypesGetAssetTypeGroupsRequest request)

Get asset type groups by assetsIds

Adds assetsids. Returns list of assetTypeGroup for successful request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsGetAssetTypeGroupsByAssetsIdsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var request = new SCServiceChannelServicesMessagingAssetTypesGetAssetTypeGroupsRequest(); // SCServiceChannelServicesMessagingAssetTypesGetAssetTypeGroupsRequest | 

            try
            {
                // Get asset type groups by assetsIds
                Dictionary<string, SCServiceChannelServicesMessagingAssetTypesAssetTypeGroup> result = apiInstance.AssetsGetAssetTypeGroupsByAssetsIds(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsGetAssetTypeGroupsByAssetsIds: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsGetAssetTypeGroupsByAssetsIdsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get asset type groups by assetsIds
    ApiResponse<Dictionary<string, SCServiceChannelServicesMessagingAssetTypesAssetTypeGroup>> response = apiInstance.AssetsGetAssetTypeGroupsByAssetsIdsWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsGetAssetTypeGroupsByAssetsIdsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingAssetTypesGetAssetTypeGroupsRequest**](SCServiceChannelServicesMessagingAssetTypesGetAssetTypeGroupsRequest.md) |  |  |

### Return type

[**Dictionary&lt;string, SCServiceChannelServicesMessagingAssetTypesAssetTypeGroup&gt;**](SCServiceChannelServicesMessagingAssetTypesAssetTypeGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              503 — Request Data should not be null.              User info should not be null.              SubscriberId is null.              Unknown Asset type; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsgetassetvalidationhistorybytrackingnumber"></a>
# **AssetsGetAssetValidationHistoryByTrackingNumber**
> List&lt;SCServiceChannelServicesMessagingAssetsAssetTagScanAuditRecord&gt; AssetsGetAssetValidationHistoryByTrackingNumber (SCServiceChannelServicesCoreInternalRequestsAssetsGetAssetValidationHistoryRequestInternal request)

Returns asset tag validation information for the specified assets and the work order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsGetAssetValidationHistoryByTrackingNumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var request = new SCServiceChannelServicesCoreInternalRequestsAssetsGetAssetValidationHistoryRequestInternal(); // SCServiceChannelServicesCoreInternalRequestsAssetsGetAssetValidationHistoryRequestInternal | 

            try
            {
                // Returns asset tag validation information for the specified assets and the work order
                List<SCServiceChannelServicesMessagingAssetsAssetTagScanAuditRecord> result = apiInstance.AssetsGetAssetValidationHistoryByTrackingNumber(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsGetAssetValidationHistoryByTrackingNumber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsGetAssetValidationHistoryByTrackingNumberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns asset tag validation information for the specified assets and the work order
    ApiResponse<List<SCServiceChannelServicesMessagingAssetsAssetTagScanAuditRecord>> response = apiInstance.AssetsGetAssetValidationHistoryByTrackingNumberWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsGetAssetValidationHistoryByTrackingNumberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesCoreInternalRequestsAssetsGetAssetValidationHistoryRequestInternal**](SCServiceChannelServicesCoreInternalRequestsAssetsGetAssetValidationHistoryRequestInternal.md) |  |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingAssetsAssetTagScanAuditRecord&gt;**](SCServiceChannelServicesMessagingAssetsAssetTagScanAuditRecord.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded |  -  |
| **400** | Request did NOT succeed and the error information is in the response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsgetassetvalidationinformation"></a>
# **AssetsGetAssetValidationInformation**
> List&lt;SCServiceChannelServicesMessagingAssetsAssetTagScanAuditRecord&gt; AssetsGetAssetValidationInformation (List<SCServiceChannelServicesMessagingAssetsAssetTagScanAuditRecord> auditRequests)

Returns asset tag validation information for the specified list of assets

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsGetAssetValidationInformationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var auditRequests = new List<SCServiceChannelServicesMessagingAssetsAssetTagScanAuditRecord>(); // List<SCServiceChannelServicesMessagingAssetsAssetTagScanAuditRecord> | 

            try
            {
                // Returns asset tag validation information for the specified list of assets
                List<SCServiceChannelServicesMessagingAssetsAssetTagScanAuditRecord> result = apiInstance.AssetsGetAssetValidationInformation(auditRequests);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsGetAssetValidationInformation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsGetAssetValidationInformationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns asset tag validation information for the specified list of assets
    ApiResponse<List<SCServiceChannelServicesMessagingAssetsAssetTagScanAuditRecord>> response = apiInstance.AssetsGetAssetValidationInformationWithHttpInfo(auditRequests);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsGetAssetValidationInformationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **auditRequests** | [**List&lt;SCServiceChannelServicesMessagingAssetsAssetTagScanAuditRecord&gt;**](SCServiceChannelServicesMessagingAssetsAssetTagScanAuditRecord.md) |  |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingAssetsAssetTagScanAuditRecord&gt;**](SCServiceChannelServicesMessagingAssetsAssetTagScanAuditRecord.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded |  -  |
| **400** | Request did NOT succeed and the error information is in the response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsgetprimaryattachmentsforassetlist"></a>
# **AssetsGetPrimaryAttachmentsForAssetList**
> List&lt;SCServiceChannelServicesMessagingAssetsAssetPrimaryAttachment&gt; AssetsGetPrimaryAttachmentsForAssetList (List<int> listOfAssetIds)

Get primary attachments for asset list

Adds new asset. Returns list of attachments for successful request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsGetPrimaryAttachmentsForAssetListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var listOfAssetIds = new List<int>(); // List<int> | 

            try
            {
                // Get primary attachments for asset list
                List<SCServiceChannelServicesMessagingAssetsAssetPrimaryAttachment> result = apiInstance.AssetsGetPrimaryAttachmentsForAssetList(listOfAssetIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsGetPrimaryAttachmentsForAssetList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsGetPrimaryAttachmentsForAssetListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get primary attachments for asset list
    ApiResponse<List<SCServiceChannelServicesMessagingAssetsAssetPrimaryAttachment>> response = apiInstance.AssetsGetPrimaryAttachmentsForAssetListWithHttpInfo(listOfAssetIds);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsGetPrimaryAttachmentsForAssetListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listOfAssetIds** | [**List&lt;int&gt;**](int.md) |  |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingAssetsAssetPrimaryAttachment&gt;**](SCServiceChannelServicesMessagingAssetsAssetPrimaryAttachment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              503 — Request Data should not be null.              User info should not be null.              SubscriberId is null.              Unknown Asset type; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsgetprimaryattachmentsforassetlistv1"></a>
# **AssetsGetPrimaryAttachmentsForAssetListV1**
> List&lt;SCServiceChannelServicesMessagingAssetsAssetPrimaryAttachment&gt; AssetsGetPrimaryAttachmentsForAssetListV1 (SCServiceChannelServicesWebApiModelsAssetAttachmentsRequest assetAttachmentsRequest)

Get primary attachments for asset list

Adds new asset. Returns list of attachments for successful request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsGetPrimaryAttachmentsForAssetListV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var assetAttachmentsRequest = new SCServiceChannelServicesWebApiModelsAssetAttachmentsRequest(); // SCServiceChannelServicesWebApiModelsAssetAttachmentsRequest | 

            try
            {
                // Get primary attachments for asset list
                List<SCServiceChannelServicesMessagingAssetsAssetPrimaryAttachment> result = apiInstance.AssetsGetPrimaryAttachmentsForAssetListV1(assetAttachmentsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsGetPrimaryAttachmentsForAssetListV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsGetPrimaryAttachmentsForAssetListV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get primary attachments for asset list
    ApiResponse<List<SCServiceChannelServicesMessagingAssetsAssetPrimaryAttachment>> response = apiInstance.AssetsGetPrimaryAttachmentsForAssetListV1WithHttpInfo(assetAttachmentsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsGetPrimaryAttachmentsForAssetListV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetAttachmentsRequest** | [**SCServiceChannelServicesWebApiModelsAssetAttachmentsRequest**](SCServiceChannelServicesWebApiModelsAssetAttachmentsRequest.md) |  |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingAssetsAssetPrimaryAttachment&gt;**](SCServiceChannelServicesMessagingAssetsAssetPrimaryAttachment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              503 — Request Data should not be null.              User info should not be null.              SubscriberId is null.              Unknown Asset type; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsgetvalidationstatusesformultipleworkorders"></a>
# **AssetsGetValidationStatusesForMultipleWorkOrders**
> SCServiceChannelServicesMessagingAssetsWorkOrderAssetsCommonValidationResponse AssetsGetValidationStatusesForMultipleWorkOrders (SCServiceChannelServicesMessagingGetByIdsRequest request)

Gets list of asset validation statuses for multiple work order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsGetValidationStatusesForMultipleWorkOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var request = new SCServiceChannelServicesMessagingGetByIdsRequest(); // SCServiceChannelServicesMessagingGetByIdsRequest | 

            try
            {
                // Gets list of asset validation statuses for multiple work order.
                SCServiceChannelServicesMessagingAssetsWorkOrderAssetsCommonValidationResponse result = apiInstance.AssetsGetValidationStatusesForMultipleWorkOrders(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsGetValidationStatusesForMultipleWorkOrders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsGetValidationStatusesForMultipleWorkOrdersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets list of asset validation statuses for multiple work order.
    ApiResponse<SCServiceChannelServicesMessagingAssetsWorkOrderAssetsCommonValidationResponse> response = apiInstance.AssetsGetValidationStatusesForMultipleWorkOrdersWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsGetValidationStatusesForMultipleWorkOrdersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingGetByIdsRequest**](SCServiceChannelServicesMessagingGetByIdsRequest.md) |  |  |

### Return type

[**SCServiceChannelServicesMessagingAssetsWorkOrderAssetsCommonValidationResponse**](SCServiceChannelServicesMessagingAssetsWorkOrderAssetsCommonValidationResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and response contains list of validation statuses |  -  |
| **400** | Request did NOT succeed and response contains error information |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsgetassetwohistoryworkorderscountworkorderscount"></a>
# **AssetsGetassetwohistoryworkOrdersCountworkOrdersCount**
> Dictionary&lt;string, List&lt;SCServiceChannelServicesMessagingWorkordersWorkOrder&gt;&gt; AssetsGetassetwohistoryworkOrdersCountworkOrdersCount (int workOrdersCount, List<int> assetIds)

Get Assets WorkOrders

This method allows to get WorkOrder objects by Asset Ids.<br />

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsGetassetwohistoryworkOrdersCountworkOrdersCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var workOrdersCount = 56;  // int | 
            var assetIds = new List<int>(); // List<int> | 

            try
            {
                // Get Assets WorkOrders
                Dictionary<string, List<SCServiceChannelServicesMessagingWorkordersWorkOrder>> result = apiInstance.AssetsGetassetwohistoryworkOrdersCountworkOrdersCount(workOrdersCount, assetIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsGetassetwohistoryworkOrdersCountworkOrdersCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsGetassetwohistoryworkOrdersCountworkOrdersCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Assets WorkOrders
    ApiResponse<Dictionary<string, List<SCServiceChannelServicesMessagingWorkordersWorkOrder>>> response = apiInstance.AssetsGetassetwohistoryworkOrdersCountworkOrdersCountWithHttpInfo(workOrdersCount, assetIds);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsGetassetwohistoryworkOrdersCountworkOrdersCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrdersCount** | **int** |  |  |
| **assetIds** | [**List&lt;int&gt;**](int.md) |  |  |

### Return type

**Dictionary<string, List<SCServiceChannelServicesMessagingWorkordersWorkOrder>>**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              503 — User info should not be null;              SubscriberId is null; |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsgetfilteredassetleaks"></a>
# **AssetsGetfilteredassetleaks**
> Object AssetsGetfilteredassetleaks (SCServiceChannelServicesMessagingAssetsGetFilteredAssetsRequest request)

Ge tFiltered Asset Leaks

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsGetfilteredassetleaksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var request = new SCServiceChannelServicesMessagingAssetsGetFilteredAssetsRequest(); // SCServiceChannelServicesMessagingAssetsGetFilteredAssetsRequest | 

            try
            {
                // Ge tFiltered Asset Leaks
                Object result = apiInstance.AssetsGetfilteredassetleaks(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsGetfilteredassetleaks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsGetfilteredassetleaksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Ge tFiltered Asset Leaks
    ApiResponse<Object> response = apiInstance.AssetsGetfilteredassetleaksWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsGetfilteredassetleaksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingAssetsGetFilteredAssetsRequest**](SCServiceChannelServicesMessagingAssetsGetFilteredAssetsRequest.md) |  |  |

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

<a id="assetsgetfilteredassets"></a>
# **AssetsGetfilteredassets**
> Object AssetsGetfilteredassets (SCServiceChannelServicesMessagingAssetsGetFilteredAssetsRequest request)

Get Filtered Assets

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsGetfilteredassetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var request = new SCServiceChannelServicesMessagingAssetsGetFilteredAssetsRequest(); // SCServiceChannelServicesMessagingAssetsGetFilteredAssetsRequest | 

            try
            {
                // Get Filtered Assets
                Object result = apiInstance.AssetsGetfilteredassets(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsGetfilteredassets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsGetfilteredassetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Filtered Assets
    ApiResponse<Object> response = apiInstance.AssetsGetfilteredassetsWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsGetfilteredassetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingAssetsGetFilteredAssetsRequest**](SCServiceChannelServicesMessagingAssetsGetFilteredAssetsRequest.md) |  |  |

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

<a id="assetsgetfilteredassetsv1provideridproviderid"></a>
# **AssetsGetfilteredassetsV1providerIdproviderId**
> Object AssetsGetfilteredassetsV1providerIdproviderId (SCServiceChannelServicesMessagingAssetsGetFilteredAssetsRequest request, int? providerId = null)

Get Filtered Assets V1

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsGetfilteredassetsV1providerIdproviderIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var request = new SCServiceChannelServicesMessagingAssetsGetFilteredAssetsRequest(); // SCServiceChannelServicesMessagingAssetsGetFilteredAssetsRequest | The request to perform action with.
            var providerId = 56;  // int? | The provider identifier. Required for sub-contractor request. [Required Special permissions] (optional) 

            try
            {
                // Get Filtered Assets V1
                Object result = apiInstance.AssetsGetfilteredassetsV1providerIdproviderId(request, providerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsGetfilteredassetsV1providerIdproviderId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsGetfilteredassetsV1providerIdproviderIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Filtered Assets V1
    ApiResponse<Object> response = apiInstance.AssetsGetfilteredassetsV1providerIdproviderIdWithHttpInfo(request, providerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsGetfilteredassetsV1providerIdproviderIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingAssetsGetFilteredAssetsRequest**](SCServiceChannelServicesMessagingAssetsGetFilteredAssetsRequest.md) | The request to perform action with. |  |
| **providerId** | **int?** | The provider identifier. Required for sub-contractor request. [Required Special permissions] | [optional]  |

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

<a id="assetsgetwoassettrackingwoidwoid"></a>
# **AssetsGetwoassettrackingwoIdwoId**
> Object AssetsGetwoassettrackingwoIdwoId (int woId)

Get Wo Asset Tracking

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsGetwoassettrackingwoIdwoIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var woId = 56;  // int | 

            try
            {
                // Get Wo Asset Tracking
                Object result = apiInstance.AssetsGetwoassettrackingwoIdwoId(woId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsGetwoassettrackingwoIdwoId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsGetwoassettrackingwoIdwoIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Wo Asset Tracking
    ApiResponse<Object> response = apiInstance.AssetsGetwoassettrackingwoIdwoIdWithHttpInfo(woId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsGetwoassettrackingwoIdwoIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **woId** | **int** |  |  |

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

<a id="assetshasassetbeenvalidated"></a>
# **AssetsHasAssetBeenValidated**
> bool AssetsHasAssetBeenValidated (SCServiceChannelServicesMessagingAssetsAssetTagScanAuditRecord auditRequest)

Determines if the specified asset has had its tag validated or not

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsHasAssetBeenValidatedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var auditRequest = new SCServiceChannelServicesMessagingAssetsAssetTagScanAuditRecord(); // SCServiceChannelServicesMessagingAssetsAssetTagScanAuditRecord | 

            try
            {
                // Determines if the specified asset has had its tag validated or not
                bool result = apiInstance.AssetsHasAssetBeenValidated(auditRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsHasAssetBeenValidated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsHasAssetBeenValidatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Determines if the specified asset has had its tag validated or not
    ApiResponse<bool> response = apiInstance.AssetsHasAssetBeenValidatedWithHttpInfo(auditRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsHasAssetBeenValidatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **auditRequest** | [**SCServiceChannelServicesMessagingAssetsAssetTagScanAuditRecord**](SCServiceChannelServicesMessagingAssetsAssetTagScanAuditRecord.md) |  |  |

### Return type

**bool**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded |  -  |
| **400** | Request did NOT succeed and the error information is in the response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetslocationassetstreelocationidlocationidtradetrade"></a>
# **AssetsLocationAssetsTreelocationIdlocationIdtradetrade**
> List&lt;SCServiceChannelServicesMessagingAssetsAssetsResponseTreeNode&gt; AssetsLocationAssetsTreelocationIdlocationIdtradetrade (int locationId, string? trade = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsLocationAssetsTreelocationIdlocationIdtradetradeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var locationId = 56;  // int | 
            var trade = "trade_example";  // string? |  (optional) 

            try
            {
                List<SCServiceChannelServicesMessagingAssetsAssetsResponseTreeNode> result = apiInstance.AssetsLocationAssetsTreelocationIdlocationIdtradetrade(locationId, trade);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsLocationAssetsTreelocationIdlocationIdtradetrade: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsLocationAssetsTreelocationIdlocationIdtradetradeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<SCServiceChannelServicesMessagingAssetsAssetsResponseTreeNode>> response = apiInstance.AssetsLocationAssetsTreelocationIdlocationIdtradetradeWithHttpInfo(locationId, trade);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsLocationAssetsTreelocationIdlocationIdtradetradeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** |  |  |
| **trade** | **string?** |  | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingAssetsAssetsResponseTreeNode&gt;**](SCServiceChannelServicesMessagingAssetsAssetsResponseTreeNode.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              503 — User info should not be null;              SubscriberId is null; |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetslocationslocationidtradetrade"></a>
# **AssetsLocationslocationIdtradetrade**
> SCServiceChannelServicesMessagingAssetsAssetsInfoResponse AssetsLocationslocationIdtradetrade (int locationId, string? trade = null)

Get assets

Returns a list of assets with all details for the specified location. Enter the `trade` parameter to make your request more specific.               <br />               You can use the [GET/assets/{assetId}](https://developer.servicechannel.com/swagger/ui/index?version=3#/Assets/GETv3_assets__assetId__locationId__locationId__storeId__storeId__tagId__tagId__trackingNumber__trackingNumber_) method to get the details of a particular asset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsLocationslocationIdtradetradeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var locationId = 56;  // int | Unique numeric identifier of the location you want to retrieve assets details of.
            var trade = "trade_example";  // string? | Trade of an asset type the asset is assigned to, for example, *CARPENTRY* or *PLUMBING*. (optional) 

            try
            {
                // Get assets
                SCServiceChannelServicesMessagingAssetsAssetsInfoResponse result = apiInstance.AssetsLocationslocationIdtradetrade(locationId, trade);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsLocationslocationIdtradetrade: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsLocationslocationIdtradetradeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get assets
    ApiResponse<SCServiceChannelServicesMessagingAssetsAssetsInfoResponse> response = apiInstance.AssetsLocationslocationIdtradetradeWithHttpInfo(locationId, trade);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsLocationslocationIdtradetradeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | Unique numeric identifier of the location you want to retrieve assets details of. |  |
| **trade** | **string?** | Trade of an asset type the asset is assigned to, for example, *CARPENTRY* or *PLUMBING*. | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingAssetsAssetsInfoResponse**](SCServiceChannelServicesMessagingAssetsAssetsInfoResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The assets for the specified location are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **404** | The request URI is incorrect, or the resource does not exist. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsrecordscannedasset"></a>
# **AssetsRecordScannedAsset**
> bool AssetsRecordScannedAsset (SCServiceChannelServicesMessagingAssetsAssetTagScanAuditRecord auditRequest)

Records an audit record for the asset tag that was scanned

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsRecordScannedAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var auditRequest = new SCServiceChannelServicesMessagingAssetsAssetTagScanAuditRecord(); // SCServiceChannelServicesMessagingAssetsAssetTagScanAuditRecord | 

            try
            {
                // Records an audit record for the asset tag that was scanned
                bool result = apiInstance.AssetsRecordScannedAsset(auditRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsRecordScannedAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsRecordScannedAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Records an audit record for the asset tag that was scanned
    ApiResponse<bool> response = apiInstance.AssetsRecordScannedAssetWithHttpInfo(auditRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsRecordScannedAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **auditRequest** | [**SCServiceChannelServicesMessagingAssetsAssetTagScanAuditRecord**](SCServiceChannelServicesMessagingAssetsAssetTagScanAuditRecord.md) |  |  |

### Return type

**bool**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded |  -  |
| **400** | Request did NOT succeed and the error information is in the response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetssearchassets"></a>
# **AssetsSearchassets**
> Object AssetsSearchassets (SCServiceChannelServicesMessagingEquipmentsSearchAssetRequest request)

Search Assets

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsSearchassetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var request = new SCServiceChannelServicesMessagingEquipmentsSearchAssetRequest(); // SCServiceChannelServicesMessagingEquipmentsSearchAssetRequest | 

            try
            {
                // Search Assets
                Object result = apiInstance.AssetsSearchassets(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsSearchassets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsSearchassetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search Assets
    ApiResponse<Object> response = apiInstance.AssetsSearchassetsWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsSearchassetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingEquipmentsSearchAssetRequest**](SCServiceChannelServicesMessagingEquipmentsSearchAssetRequest.md) |  |  |

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

<a id="assetssearchassetsbygroupid"></a>
# **AssetsSearchassetsByGroupId**
> List&lt;SCServiceChannelServicesMessagingAssetsAssetsGroupedByCategoriesResponse&gt; AssetsSearchassetsByGroupId (SCServiceChannelServicesMessagingEquipmentsSearchAssetsByGroupIDRequest request)

Get list of assets grouped by AsseTypeGroupID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsSearchassetsByGroupIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var request = new SCServiceChannelServicesMessagingEquipmentsSearchAssetsByGroupIDRequest(); // SCServiceChannelServicesMessagingEquipmentsSearchAssetsByGroupIDRequest | 

            try
            {
                // Get list of assets grouped by AsseTypeGroupID
                List<SCServiceChannelServicesMessagingAssetsAssetsGroupedByCategoriesResponse> result = apiInstance.AssetsSearchassetsByGroupId(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsSearchassetsByGroupId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsSearchassetsByGroupIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get list of assets grouped by AsseTypeGroupID
    ApiResponse<List<SCServiceChannelServicesMessagingAssetsAssetsGroupedByCategoriesResponse>> response = apiInstance.AssetsSearchassetsByGroupIdWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsSearchassetsByGroupIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingEquipmentsSearchAssetsByGroupIDRequest**](SCServiceChannelServicesMessagingEquipmentsSearchAssetsByGroupIDRequest.md) |  |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingAssetsAssetsGroupedByCategoriesResponse&gt;**](SCServiceChannelServicesMessagingAssetsAssetsGroupedByCategoriesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              503 — User info should not be null;              SubscriberId is null; |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsunabletoaddreasons"></a>
# **AssetsUnableToAddReasons**
> SCServiceChannelServicesMessagingAdministrationAssetRulesUnableToAddReason AssetsUnableToAddReasons ()

Gets list of unable to add reasons.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsUnableToAddReasonsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);

            try
            {
                // Gets list of unable to add reasons.
                SCServiceChannelServicesMessagingAdministrationAssetRulesUnableToAddReason result = apiInstance.AssetsUnableToAddReasons();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsUnableToAddReasons: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsUnableToAddReasonsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets list of unable to add reasons.
    ApiResponse<SCServiceChannelServicesMessagingAdministrationAssetRulesUnableToAddReason> response = apiInstance.AssetsUnableToAddReasonsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsUnableToAddReasonsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SCServiceChannelServicesMessagingAdministrationAssetRulesUnableToAddReason**](SCServiceChannelServicesMessagingAdministrationAssetRulesUnableToAddReason.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and response contains list of unable to add reasons |  -  |
| **400** | Request did NOT succeed and response contains error information |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsunabletoaddreasons_0"></a>
# **AssetsUnableToAddReasons_0**
> SCServiceChannelServicesMessagingAssetsUnableToAddAssetReasonRequest AssetsUnableToAddReasons_0 (SCServiceChannelServicesMessagingAssetsUnableToAddAssetReasonRequest model)

Creates wo_UnableToAddAssetHistory.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsUnableToAddReasons_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var model = new SCServiceChannelServicesMessagingAssetsUnableToAddAssetReasonRequest(); // SCServiceChannelServicesMessagingAssetsUnableToAddAssetReasonRequest | 

            try
            {
                // Creates wo_UnableToAddAssetHistory.
                SCServiceChannelServicesMessagingAssetsUnableToAddAssetReasonRequest result = apiInstance.AssetsUnableToAddReasons_0(model);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsUnableToAddReasons_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsUnableToAddReasons_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates wo_UnableToAddAssetHistory.
    ApiResponse<SCServiceChannelServicesMessagingAssetsUnableToAddAssetReasonRequest> response = apiInstance.AssetsUnableToAddReasons_0WithHttpInfo(model);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsUnableToAddReasons_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **model** | [**SCServiceChannelServicesMessagingAssetsUnableToAddAssetReasonRequest**](SCServiceChannelServicesMessagingAssetsUnableToAddAssetReasonRequest.md) |  |  |

### Return type

[**SCServiceChannelServicesMessagingAssetsUnableToAddAssetReasonRequest**](SCServiceChannelServicesMessagingAssetsUnableToAddAssetReasonRequest.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded |  -  |
| **400** | Request did NOT succeed and response contains error information |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsunabletoscanreasons"></a>
# **AssetsUnableToScanReasons**
> SCServiceChannelServicesMessagingAssetsUnableToScanAssetReasonRequest AssetsUnableToScanReasons (SCServiceChannelServicesMessagingAssetsUnableToScanAssetReasonRequest model)

Creates wo_UnableToScanAssetHistory.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsUnableToScanReasonsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var model = new SCServiceChannelServicesMessagingAssetsUnableToScanAssetReasonRequest(); // SCServiceChannelServicesMessagingAssetsUnableToScanAssetReasonRequest | 

            try
            {
                // Creates wo_UnableToScanAssetHistory.
                SCServiceChannelServicesMessagingAssetsUnableToScanAssetReasonRequest result = apiInstance.AssetsUnableToScanReasons(model);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsUnableToScanReasons: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsUnableToScanReasonsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates wo_UnableToScanAssetHistory.
    ApiResponse<SCServiceChannelServicesMessagingAssetsUnableToScanAssetReasonRequest> response = apiInstance.AssetsUnableToScanReasonsWithHttpInfo(model);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsUnableToScanReasonsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **model** | [**SCServiceChannelServicesMessagingAssetsUnableToScanAssetReasonRequest**](SCServiceChannelServicesMessagingAssetsUnableToScanAssetReasonRequest.md) |  |  |

### Return type

[**SCServiceChannelServicesMessagingAssetsUnableToScanAssetReasonRequest**](SCServiceChannelServicesMessagingAssetsUnableToScanAssetReasonRequest.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded |  -  |
| **400** | Request did NOT succeed and response contains error information |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsunabletoscanreasonsnotattachedasset"></a>
# **AssetsUnableToScanReasonsNotAttachedAsset**
> SCServiceChannelServicesMessagingAdministrationAssetRulesUnableToScanReasonsNotAttachedAsset AssetsUnableToScanReasonsNotAttachedAsset ()

Gets list of unable to scan reasons not attached assets.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsUnableToScanReasonsNotAttachedAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);

            try
            {
                // Gets list of unable to scan reasons not attached assets.
                SCServiceChannelServicesMessagingAdministrationAssetRulesUnableToScanReasonsNotAttachedAsset result = apiInstance.AssetsUnableToScanReasonsNotAttachedAsset();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsUnableToScanReasonsNotAttachedAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsUnableToScanReasonsNotAttachedAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets list of unable to scan reasons not attached assets.
    ApiResponse<SCServiceChannelServicesMessagingAdministrationAssetRulesUnableToScanReasonsNotAttachedAsset> response = apiInstance.AssetsUnableToScanReasonsNotAttachedAssetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsUnableToScanReasonsNotAttachedAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SCServiceChannelServicesMessagingAdministrationAssetRulesUnableToScanReasonsNotAttachedAsset**](SCServiceChannelServicesMessagingAdministrationAssetRulesUnableToScanReasonsNotAttachedAsset.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and response contains list of unable to scan reasons not attached assets |  -  |
| **400** | Request did NOT succeed and response contains error information |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsunabletoscanreasonssubscriberidsubscriberid"></a>
# **AssetsUnableToScanReasonssubscriberIdsubscriberId**
> SCServiceChannelServicesMessagingAdministrationAssetRulesUnableToScanReason AssetsUnableToScanReasonssubscriberIdsubscriberId (int? subscriberId = null)

Gets list of unable to scan reasons.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsUnableToScanReasonssubscriberIdsubscriberIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var subscriberId = 56;  // int? | Subscriber unique indentifier (optional) 

            try
            {
                // Gets list of unable to scan reasons.
                SCServiceChannelServicesMessagingAdministrationAssetRulesUnableToScanReason result = apiInstance.AssetsUnableToScanReasonssubscriberIdsubscriberId(subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsUnableToScanReasonssubscriberIdsubscriberId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsUnableToScanReasonssubscriberIdsubscriberIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets list of unable to scan reasons.
    ApiResponse<SCServiceChannelServicesMessagingAdministrationAssetRulesUnableToScanReason> response = apiInstance.AssetsUnableToScanReasonssubscriberIdsubscriberIdWithHttpInfo(subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsUnableToScanReasonssubscriberIdsubscriberIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int?** | Subscriber unique indentifier | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingAdministrationAssetRulesUnableToScanReason**](SCServiceChannelServicesMessagingAdministrationAssetRulesUnableToScanReason.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and response contains list of unable to scan reasons |  -  |
| **400** | Request did NOT succeed and response contains error information |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsunabletovalidatereasons"></a>
# **AssetsUnableToValidateReasons**
> SCServiceChannelServicesMessagingAdministrationAssetRulesUnableToValidateReason AssetsUnableToValidateReasons ()

Gets list of unable to validate reasons.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsUnableToValidateReasonsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);

            try
            {
                // Gets list of unable to validate reasons.
                SCServiceChannelServicesMessagingAdministrationAssetRulesUnableToValidateReason result = apiInstance.AssetsUnableToValidateReasons();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsUnableToValidateReasons: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsUnableToValidateReasonsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets list of unable to validate reasons.
    ApiResponse<SCServiceChannelServicesMessagingAdministrationAssetRulesUnableToValidateReason> response = apiInstance.AssetsUnableToValidateReasonsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsUnableToValidateReasonsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SCServiceChannelServicesMessagingAdministrationAssetRulesUnableToValidateReason**](SCServiceChannelServicesMessagingAdministrationAssetRulesUnableToValidateReason.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and response contains list of unable to validate reasons |  -  |
| **400** | Request did NOT succeed and response contains error information |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsunabletovalidatereasonsnotattachedasset"></a>
# **AssetsUnableToValidateReasonsNotAttachedAsset**
> SCServiceChannelServicesMessagingAdministrationAssetRulesUnableToValidateReasonsNotAttachedAsset AssetsUnableToValidateReasonsNotAttachedAsset ()

Gets list of unable to validate reasons not attached assets.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsUnableToValidateReasonsNotAttachedAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);

            try
            {
                // Gets list of unable to validate reasons not attached assets.
                SCServiceChannelServicesMessagingAdministrationAssetRulesUnableToValidateReasonsNotAttachedAsset result = apiInstance.AssetsUnableToValidateReasonsNotAttachedAsset();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsUnableToValidateReasonsNotAttachedAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsUnableToValidateReasonsNotAttachedAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets list of unable to validate reasons not attached assets.
    ApiResponse<SCServiceChannelServicesMessagingAdministrationAssetRulesUnableToValidateReasonsNotAttachedAsset> response = apiInstance.AssetsUnableToValidateReasonsNotAttachedAssetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsUnableToValidateReasonsNotAttachedAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SCServiceChannelServicesMessagingAdministrationAssetRulesUnableToValidateReasonsNotAttachedAsset**](SCServiceChannelServicesMessagingAdministrationAssetRulesUnableToValidateReasonsNotAttachedAsset.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and response contains list of unable to validate reasons not attached assets |  -  |
| **400** | Request did NOT succeed and response contains error information |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsunabletovalidatereasons_0"></a>
# **AssetsUnableToValidateReasons_0**
> SCServiceChannelServicesMessagingAssetsUnableToValidateAssetReasonRequest AssetsUnableToValidateReasons_0 (SCServiceChannelServicesMessagingAssetsUnableToValidateAssetReasonRequest model)

Creates wo_UnableToValidateAssetHistory.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsUnableToValidateReasons_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var model = new SCServiceChannelServicesMessagingAssetsUnableToValidateAssetReasonRequest(); // SCServiceChannelServicesMessagingAssetsUnableToValidateAssetReasonRequest | 

            try
            {
                // Creates wo_UnableToValidateAssetHistory.
                SCServiceChannelServicesMessagingAssetsUnableToValidateAssetReasonRequest result = apiInstance.AssetsUnableToValidateReasons_0(model);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsUnableToValidateReasons_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsUnableToValidateReasons_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates wo_UnableToValidateAssetHistory.
    ApiResponse<SCServiceChannelServicesMessagingAssetsUnableToValidateAssetReasonRequest> response = apiInstance.AssetsUnableToValidateReasons_0WithHttpInfo(model);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsUnableToValidateReasons_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **model** | [**SCServiceChannelServicesMessagingAssetsUnableToValidateAssetReasonRequest**](SCServiceChannelServicesMessagingAssetsUnableToValidateAssetReasonRequest.md) |  |  |

### Return type

[**SCServiceChannelServicesMessagingAssetsUnableToValidateAssetReasonRequest**](SCServiceChannelServicesMessagingAssetsUnableToValidateAssetReasonRequest.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded |  -  |
| **400** | Request did NOT succeed and response contains error information |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsupdateassetlocationassetidassetidlocationidlocationid"></a>
# **AssetsUpdateAssetLocationassetIdassetIdlocationIdlocationId**
> Object AssetsUpdateAssetLocationassetIdassetIdlocationIdlocationId (int assetId, int locationId)

Update asset location

Updates asset location

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsUpdateAssetLocationassetIdassetIdlocationIdlocationIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var assetId = 56;  // int | Asset update id
            var locationId = 56;  // int | New location id

            try
            {
                // Update asset location
                Object result = apiInstance.AssetsUpdateAssetLocationassetIdassetIdlocationIdlocationId(assetId, locationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsUpdateAssetLocationassetIdassetIdlocationIdlocationId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsUpdateAssetLocationassetIdassetIdlocationIdlocationIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update asset location
    ApiResponse<Object> response = apiInstance.AssetsUpdateAssetLocationassetIdassetIdlocationIdlocationIdWithHttpInfo(assetId, locationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsUpdateAssetLocationassetIdassetIdlocationIdlocationIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetId** | **int** | Asset update id |  |
| **locationId** | **int** | New location id |  |

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
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              503 — Request Data should not be null;              User info should not be null;              SubscriberId is null;              Asset ID is absent;              502 — No asset or location to update; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              504 — API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsupdateassetmeterreadingsbulk"></a>
# **AssetsUpdateAssetMeterReadingsBulk**
> List&lt;SCServiceChannelServicesMessagingAssetsAssetMeterReadingResponseItem&gt; AssetsUpdateAssetMeterReadingsBulk (List<SCServiceChannelServicesMessagingAssetsUpdateAssetMeterReadingRequestItem> request)

Asset meter readings bulk update

Updates information about asset meter readings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsUpdateAssetMeterReadingsBulkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var request = new List<SCServiceChannelServicesMessagingAssetsUpdateAssetMeterReadingRequestItem>(); // List<SCServiceChannelServicesMessagingAssetsUpdateAssetMeterReadingRequestItem> | Request to update the existing asset meter readings.

            try
            {
                // Asset meter readings bulk update
                List<SCServiceChannelServicesMessagingAssetsAssetMeterReadingResponseItem> result = apiInstance.AssetsUpdateAssetMeterReadingsBulk(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsUpdateAssetMeterReadingsBulk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsUpdateAssetMeterReadingsBulkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Asset meter readings bulk update
    ApiResponse<List<SCServiceChannelServicesMessagingAssetsAssetMeterReadingResponseItem>> response = apiInstance.AssetsUpdateAssetMeterReadingsBulkWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsUpdateAssetMeterReadingsBulkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**List&lt;SCServiceChannelServicesMessagingAssetsUpdateAssetMeterReadingRequestItem&gt;**](SCServiceChannelServicesMessagingAssetsUpdateAssetMeterReadingRequestItem.md) | Request to update the existing asset meter readings. |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingAssetsAssetMeterReadingResponseItem&gt;**](SCServiceChannelServicesMessagingAssetsAssetMeterReadingResponseItem.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The asset meter readings details are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              Failed to update asset meter readings. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsupdateassetstatus"></a>
# **AssetsUpdateAssetStatus**
> bool AssetsUpdateAssetStatus (SCServiceChannelServicesMessagingAssetsUpdateAssetStatusRequest request)

Update Asset Status By AssetId

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsUpdateAssetStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var request = new SCServiceChannelServicesMessagingAssetsUpdateAssetStatusRequest(); // SCServiceChannelServicesMessagingAssetsUpdateAssetStatusRequest | 

            try
            {
                // Update Asset Status By AssetId
                bool result = apiInstance.AssetsUpdateAssetStatus(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsUpdateAssetStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsUpdateAssetStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Asset Status By AssetId
    ApiResponse<bool> response = apiInstance.AssetsUpdateAssetStatusWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsUpdateAssetStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingAssetsUpdateAssetStatusRequest**](SCServiceChannelServicesMessagingAssetsUpdateAssetStatusRequest.md) |  |  |

### Return type

**bool**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The asset status is successfully updated. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              503 — Asset ID is absent; |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions; |  -  |
| **404** | The request URI is incorrect, or the resource does not exist.              &lt;br/&gt;Error codes:              502 — Asset is not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsupdateassetsstatuses"></a>
# **AssetsUpdateAssetsStatuses**
> void AssetsUpdateAssetsStatuses (SCServiceChannelServicesMessagingAssetsUpdateAssetsStatusesRequest request)

Update Assets Statuses

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsUpdateAssetsStatusesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var request = new SCServiceChannelServicesMessagingAssetsUpdateAssetsStatusesRequest(); // SCServiceChannelServicesMessagingAssetsUpdateAssetsStatusesRequest | 

            try
            {
                // Update Assets Statuses
                apiInstance.AssetsUpdateAssetsStatuses(request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsUpdateAssetsStatuses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsUpdateAssetsStatusesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Assets Statuses
    apiInstance.AssetsUpdateAssetsStatusesWithHttpInfo(request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsUpdateAssetsStatusesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingAssetsUpdateAssetsStatusesRequest**](SCServiceChannelServicesMessagingAssetsUpdateAssetsStatusesRequest.md) |  |  |

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
| **200** | Assets statuses is successfully updated. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              503 — Asset ID is absent; |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions; |  -  |
| **404** | The request URI is incorrect, or the resource does not exist.              &lt;br/&gt;Error codes:              502 — Asset is not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsupdateassetrepairstatus"></a>
# **AssetsUpdateassetrepairstatus**
> bool AssetsUpdateassetrepairstatus (SCServiceChannelServicesMessagingAssetsUpdateAssetRepairStatusRequest request)

Update Asset Repair Status By AssetId

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsUpdateassetrepairstatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var request = new SCServiceChannelServicesMessagingAssetsUpdateAssetRepairStatusRequest(); // SCServiceChannelServicesMessagingAssetsUpdateAssetRepairStatusRequest | 

            try
            {
                // Update Asset Repair Status By AssetId
                bool result = apiInstance.AssetsUpdateassetrepairstatus(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsUpdateassetrepairstatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsUpdateassetrepairstatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Asset Repair Status By AssetId
    ApiResponse<bool> response = apiInstance.AssetsUpdateassetrepairstatusWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsUpdateassetrepairstatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingAssetsUpdateAssetRepairStatusRequest**](SCServiceChannelServicesMessagingAssetsUpdateAssetRepairStatusRequest.md) |  |  |

### Return type

**bool**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              503 — User info should not be null;              SubscriberId is null; |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsv2brandskeywordkeywordstartindexstartindexpagesizepagesize"></a>
# **AssetsV2BrandskeywordkeywordstartIndexstartIndexpageSizepageSize**
> SCServiceChannelServicesMessagingAssetsManufacturersResponce AssetsV2BrandskeywordkeywordstartIndexstartIndexpageSizepageSize (string? keyword = null, int? startIndex = null, int? pageSize = null)

Get Brands (ver.2)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsV2BrandskeywordkeywordstartIndexstartIndexpageSizepageSizeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var keyword = "keyword_example";  // string? |  (optional) 
            var startIndex = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 

            try
            {
                // Get Brands (ver.2)
                SCServiceChannelServicesMessagingAssetsManufacturersResponce result = apiInstance.AssetsV2BrandskeywordkeywordstartIndexstartIndexpageSizepageSize(keyword, startIndex, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsV2BrandskeywordkeywordstartIndexstartIndexpageSizepageSize: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsV2BrandskeywordkeywordstartIndexstartIndexpageSizepageSizeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Brands (ver.2)
    ApiResponse<SCServiceChannelServicesMessagingAssetsManufacturersResponce> response = apiInstance.AssetsV2BrandskeywordkeywordstartIndexstartIndexpageSizepageSizeWithHttpInfo(keyword, startIndex, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsV2BrandskeywordkeywordstartIndexstartIndexpageSizepageSizeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **keyword** | **string?** |  | [optional]  |
| **startIndex** | **int?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingAssetsManufacturersResponce**](SCServiceChannelServicesMessagingAssetsManufacturersResponce.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              503 — User info should not be null;              SubscriberId is null; |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsvalidationrulesformultiplesubscribers"></a>
# **AssetsValidationRulesForMultipleSubscribers**
> SCServiceChannelServicesMessagingAdministrationAssetRulesAssetTagging AssetsValidationRulesForMultipleSubscribers (SCServiceChannelServicesCoreInternalRequestsAdministrationGetAssetTagValidationRequest request)

Gets the asset tag validation settings for multiple subscribers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsValidationRulesForMultipleSubscribersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var request = new SCServiceChannelServicesCoreInternalRequestsAdministrationGetAssetTagValidationRequest(); // SCServiceChannelServicesCoreInternalRequestsAdministrationGetAssetTagValidationRequest | request

            try
            {
                // Gets the asset tag validation settings for multiple subscribers.
                SCServiceChannelServicesMessagingAdministrationAssetRulesAssetTagging result = apiInstance.AssetsValidationRulesForMultipleSubscribers(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsValidationRulesForMultipleSubscribers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsValidationRulesForMultipleSubscribersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the asset tag validation settings for multiple subscribers.
    ApiResponse<SCServiceChannelServicesMessagingAdministrationAssetRulesAssetTagging> response = apiInstance.AssetsValidationRulesForMultipleSubscribersWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsValidationRulesForMultipleSubscribersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesCoreInternalRequestsAdministrationGetAssetTagValidationRequest**](SCServiceChannelServicesCoreInternalRequestsAdministrationGetAssetTagValidationRequest.md) | request |  |

### Return type

[**SCServiceChannelServicesMessagingAdministrationAssetRulesAssetTagging**](SCServiceChannelServicesMessagingAdministrationAssetRulesAssetTagging.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and response contains asset tag validation exception information |  -  |
| **400** | Request did NOT succeed and response contains error information |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsworkorderareassubscriberid"></a>
# **AssetsWorkorderAreassubscriberId**
> List&lt;SCSystemCollectionsGenericKeyValuePairSystemInt32SystemString&gt; AssetsWorkorderAreassubscriberId (int subscriberId)

Get Work Orders Area list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsWorkorderAreassubscriberIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var subscriberId = 56;  // int | 

            try
            {
                // Get Work Orders Area list
                List<SCSystemCollectionsGenericKeyValuePairSystemInt32SystemString> result = apiInstance.AssetsWorkorderAreassubscriberId(subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsWorkorderAreassubscriberId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsWorkorderAreassubscriberIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Work Orders Area list
    ApiResponse<List<SCSystemCollectionsGenericKeyValuePairSystemInt32SystemString>> response = apiInstance.AssetsWorkorderAreassubscriberIdWithHttpInfo(subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsWorkorderAreassubscriberIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** |  |  |

### Return type

[**List&lt;SCSystemCollectionsGenericKeyValuePairSystemInt32SystemString&gt;**](SCSystemCollectionsGenericKeyValuePairSystemInt32SystemString.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt; Request data should not be null.              &lt;br/&gt; Subscriber User can obtain only own Areas |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsworkordersattachassets"></a>
# **AssetsWorkordersAttachassets**
> Object AssetsWorkordersAttachassets (SCServiceChannelServicesMessagingAssetsUpdateAssetsInWORequest request)

Add assets

Assigns several assets to the specified work order at a time. The *MultipleAssetsPerWorkOrder* FF should be enabled for the method to work properly.              <br />***Note***: Assets added before will remain attached to the work order along with the new ones.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsWorkordersAttachassetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var request = new SCServiceChannelServicesMessagingAssetsUpdateAssetsInWORequest(); // SCServiceChannelServicesMessagingAssetsUpdateAssetsInWORequest | Request to add one or several assets to a particular work order.

            try
            {
                // Add assets
                Object result = apiInstance.AssetsWorkordersAttachassets(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsWorkordersAttachassets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsWorkordersAttachassetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add assets
    ApiResponse<Object> response = apiInstance.AssetsWorkordersAttachassetsWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsWorkordersAttachassetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingAssetsUpdateAssetsInWORequest**](SCServiceChannelServicesMessagingAssetsUpdateAssetsInWORequest.md) | Request to add one or several assets to a particular work order. |  |

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
| **200** | The specified assets are attached to the work order. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              502 — Asset is not found |  -  |
| **401** | The request is not authorized.              &lt;br&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsworkordersremoveassets"></a>
# **AssetsWorkordersRemoveassets**
> Object AssetsWorkordersRemoveassets (SCServiceChannelServicesMessagingAssetsRemoveAssetsFromWORequest request)

Remove specified assets from specified work order

Remove Assets from Work Order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsWorkordersRemoveassetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var request = new SCServiceChannelServicesMessagingAssetsRemoveAssetsFromWORequest(); // SCServiceChannelServicesMessagingAssetsRemoveAssetsFromWORequest | The work order identity and assets ids.

            try
            {
                // Remove specified assets from specified work order
                Object result = apiInstance.AssetsWorkordersRemoveassets(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsWorkordersRemoveassets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsWorkordersRemoveassetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove specified assets from specified work order
    ApiResponse<Object> response = apiInstance.AssetsWorkordersRemoveassetsWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsWorkordersRemoveassetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingAssetsRemoveAssetsFromWORequest**](SCServiceChannelServicesMessagingAssetsRemoveAssetsFromWORequest.md) | The work order identity and assets ids. |  |

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
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              503 — Request Data should not be null;              User info should not be null;              Asset identity is absent;              Work Order identity is absent;              502 — No asset to update; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              504 — API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsworkorderssetupassets"></a>
# **AssetsWorkordersSetupassets**
> Object AssetsWorkordersSetupassets (SCServiceChannelServicesMessagingAssetsUpdateAssetsInWORequest request)

Add and replace assets

Assigns several assets to the specified work order at a time. The *MultipleAssetsPerWorkOrder* FF should be enabled for the method to work properly.              <br />***Note***. Existing assets will be replaced with the new ones.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsWorkordersSetupassetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var request = new SCServiceChannelServicesMessagingAssetsUpdateAssetsInWORequest(); // SCServiceChannelServicesMessagingAssetsUpdateAssetsInWORequest | Request to add one or several assets to a particular work order.

            try
            {
                // Add and replace assets
                Object result = apiInstance.AssetsWorkordersSetupassets(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsWorkordersSetupassets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsWorkordersSetupassetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add and replace assets
    ApiResponse<Object> response = apiInstance.AssetsWorkordersSetupassetsWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsWorkordersSetupassetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingAssetsUpdateAssetsInWORequest**](SCServiceChannelServicesMessagingAssetsUpdateAssetsInWORequest.md) | Request to add one or several assets to a particular work order. |  |

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
| **200** | The specified assets are attached to the work order. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              502 — Asset is not found |  -  |
| **401** | The request is not authorized.              &lt;br&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsworkordersworkorderidattach"></a>
# **AssetsWorkordersworkorderIdAttach**
> Object AssetsWorkordersworkorderIdAttach (int workorderId, SCServiceChannelServicesMessagingAssetsAttachAssetRequest attachAssetRequest)

Attach an asset

Assigns the specified asset to a particular work order. You can attach multiple assets to one work order by sending several requests.              <br />***Note***: A work order and an asset you want to attach should belong to the same trade and location.              <br />***Note***: Assets added do not replace existing assets.              <br />Refer to ServiceChannel University to learn more about [updating assets on work orders](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/1484194012/Updating+Assets+on+Work+Orders).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsWorkordersworkorderIdAttachExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var workorderId = 56;  // int | Unique numeric identifier of the work order you want to assign an asset to. To retrieve IDs of work orders, use the [GET /workorders](https://developer.servicechannel.com/swagger/ui/index?version=3#/WorkOrders/GETv3_workorders_locationId__locationId__storeId__storeId_) method.
            var attachAssetRequest = new SCServiceChannelServicesMessagingAssetsAttachAssetRequest(); // SCServiceChannelServicesMessagingAssetsAttachAssetRequest | Request to assign the specified asset

            try
            {
                // Attach an asset
                Object result = apiInstance.AssetsWorkordersworkorderIdAttach(workorderId, attachAssetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsWorkordersworkorderIdAttach: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsWorkordersworkorderIdAttachWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Attach an asset
    ApiResponse<Object> response = apiInstance.AssetsWorkordersworkorderIdAttachWithHttpInfo(workorderId, attachAssetRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsWorkordersworkorderIdAttachWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Unique numeric identifier of the work order you want to assign an asset to. To retrieve IDs of work orders, use the [GET /workorders](https://developer.servicechannel.com/swagger/ui/index?version&#x3D;3#/WorkOrders/GETv3_workorders_locationId__locationId__storeId__storeId_) method. |  |
| **attachAssetRequest** | [**SCServiceChannelServicesMessagingAssetsAttachAssetRequest**](SCServiceChannelServicesMessagingAssetsAttachAssetRequest.md) | Request to assign the specified asset |  |

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
| **200** | The ID of the asset attached to the work order is in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              502 — Asset is not found or Asset Location/Trade does not correspond to WO Location/Trade              502 — Work order is not found |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **403** | You are not authorized to request this resource, or the resource is unavailable for some reason.              &lt;br/&gt;Error codes:              100 — Current Asset has already been assigned to the work order RecId: workorderId              100 — Work Order either has connection with a leak record or is a Leak Inspection. |  -  |
| **500** | The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 — Object reference is not set to an instance of an object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsworkordersworkorderiddetach"></a>
# **AssetsWorkordersworkorderIdDetach**
> Object AssetsWorkordersworkorderIdDetach (int workorderId)

Remove assets

Removes all assets assigned to the specified work order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsWorkordersworkorderIdDetachExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var workorderId = 56;  // int | Unique numeric identifier of the work order you want to remove assets from. To retrieve IDs of work orders, use the [GET /workorders](https://developer.servicechannel.com/swagger/ui/index?version=3#/WorkOrders/GETv3_workorders_locationId__locationId__storeId__storeId_) method.

            try
            {
                // Remove assets
                Object result = apiInstance.AssetsWorkordersworkorderIdDetach(workorderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsWorkordersworkorderIdDetach: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsWorkordersworkorderIdDetachWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove assets
    ApiResponse<Object> response = apiInstance.AssetsWorkordersworkorderIdDetachWithHttpInfo(workorderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsWorkordersworkorderIdDetachWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Unique numeric identifier of the work order you want to remove assets from. To retrieve IDs of work orders, use the [GET /workorders](https://developer.servicechannel.com/swagger/ui/index?version&#x3D;3#/WorkOrders/GETv3_workorders_locationId__locationId__storeId__storeId_) method. |  |

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
| **200** | The assets are successfully removed from the specified work order. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              502 — Work order is not found |  -  |
| **401** | The request is not authorized.              &lt;br&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsworkrequestremove"></a>
# **AssetsWorkrequestRemove**
> Object AssetsWorkrequestRemove (SCServiceChannelServicesMessagingAssetsRemoveAssetsWorkRequest request)

Remove specified assets from specified work request

*In limited availability phase.*              <br />Remove Assets from Work Request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsWorkrequestRemoveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var request = new SCServiceChannelServicesMessagingAssetsRemoveAssetsWorkRequest(); // SCServiceChannelServicesMessagingAssetsRemoveAssetsWorkRequest | The work request identity and assets ids.

            try
            {
                // Remove specified assets from specified work request
                Object result = apiInstance.AssetsWorkrequestRemove(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsWorkrequestRemove: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsWorkrequestRemoveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove specified assets from specified work request
    ApiResponse<Object> response = apiInstance.AssetsWorkrequestRemoveWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsWorkrequestRemoveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingAssetsRemoveAssetsWorkRequest**](SCServiceChannelServicesMessagingAssetsRemoveAssetsWorkRequest.md) | The work request identity and assets ids. |  |

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
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              503 — Request Data should not be null;              User info should not be null;                          Asset identity is absent;              Work Request identity is absent;              502 — No asset to update; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              504 — API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsworkrequestsetup"></a>
# **AssetsWorkrequestSetup**
> Object AssetsWorkrequestSetup (SCServiceChannelServicesMessagingAssetsAssetsWorkRequest request)

Setup assets to the work request

*In limited availability phase.*              <br />Setup Assets to Work Request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsWorkrequestSetupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var request = new SCServiceChannelServicesMessagingAssetsAssetsWorkRequest(); // SCServiceChannelServicesMessagingAssetsAssetsWorkRequest | The work request identity and assets ids.

            try
            {
                // Setup assets to the work request
                Object result = apiInstance.AssetsWorkrequestSetup(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsWorkrequestSetup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsWorkrequestSetupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Setup assets to the work request
    ApiResponse<Object> response = apiInstance.AssetsWorkrequestSetupWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsWorkrequestSetupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingAssetsAssetsWorkRequest**](SCServiceChannelServicesMessagingAssetsAssetsWorkRequest.md) | The work request identity and assets ids. |  |

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
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              502 — Asset is not found;              Invalid Work Request Identifier; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              504 — API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsworkrequestworkrequestid"></a>
# **AssetsWorkrequestworkRequestId**
> Object AssetsWorkrequestworkRequestId (int workRequestId)

Setup assets to the specified work order

*In limited availability phase.*              <br />Setup Assets to Work Order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsWorkrequestworkRequestIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var workRequestId = 56;  // int | 

            try
            {
                // Setup assets to the specified work order
                Object result = apiInstance.AssetsWorkrequestworkRequestId(workRequestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsWorkrequestworkRequestId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsWorkrequestworkRequestIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Setup assets to the specified work order
    ApiResponse<Object> response = apiInstance.AssetsWorkrequestworkRequestIdWithHttpInfo(workRequestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsWorkrequestworkRequestIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workRequestId** | **int** |  |  |

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
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              503 — Request Data should not be null;              User info should not be null;                          Asset identity is absent;              Work Request identity is absent;              502 — No asset to update; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              504 — API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assets_0"></a>
# **Assets_0**
> void Assets_0 (SCServiceChannelServicesMessagingAssetsAddAssetRequest assetRequest)

Add an asset

Creates a new asset for the existing asset type. Since you need to specify which type an asset will belong to, you can:              <br /> • use the [GET /AssetTypes](https://developer.servicechannel.com/swagger/ui/index?version=3#/AssetTypes/GETv3_AssetTypes) method to get a list of asset types of the current provider.              <br /> • create a new asset type by sending the [POST /AssetTypes](https://developer.servicechannel.com/swagger/ui/index?version=3#/AssetTypes/POSTv3_AssetTypes) request.              <br />You can learn more about [adding and editing assets](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/573178120/Adding+and+Editing+Assets) in ServiceChannel University.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class Assets_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var assetRequest = new SCServiceChannelServicesMessagingAssetsAddAssetRequest(); // SCServiceChannelServicesMessagingAssetsAddAssetRequest | Request to create a new asset.              <br />Required parameters:              <br /> • **Tag** (aka **Tag ID**). Create an alphanumeric identifier for your asset, for example, AD-3421              <br /> • **Manufacturer**. Enter the brand name that exists in the system.              <br /> • **StoreId**. Specify the alphanumeric identifier of the existing location.              <br /> • **Trade**. Define the line of work an asset is used for, for example, *Electrical*, *Plumbing*, *Carpentry*.              <br /> • **Type**. Enter the type of an asset, for example, *Refrigerator*, *Computer Monitor*.

            try
            {
                // Add an asset
                apiInstance.Assets_0(assetRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.Assets_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Assets_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add an asset
    apiInstance.Assets_0WithHttpInfo(assetRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.Assets_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetRequest** | [**SCServiceChannelServicesMessagingAssetsAddAssetRequest**](SCServiceChannelServicesMessagingAssetsAddAssetRequest.md) | Request to create a new asset.              &lt;br /&gt;Required parameters:              &lt;br /&gt; • **Tag** (aka **Tag ID**). Create an alphanumeric identifier for your asset, for example, AD-3421              &lt;br /&gt; • **Manufacturer**. Enter the brand name that exists in the system.              &lt;br /&gt; • **StoreId**. Specify the alphanumeric identifier of the existing location.              &lt;br /&gt; • **Trade**. Define the line of work an asset is used for, for example, *Electrical*, *Plumbing*, *Carpentry*.              &lt;br /&gt; • **Type**. Enter the type of an asset, for example, *Refrigerator*, *Computer Monitor*. |  |

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
| **201** | The created asset ID is in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              503 — Unknown Brand name              503 — Asset Tag ID is empty              503 — Request is empty or null              503 — No Store ID in the request              503 — Trade not found               503 — Unknown Equipment type              503 — Unknown Store ID              503 — Other Trade in Asset Type |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsassetidlocationidlocationidstoreidstoreidtagidtagidtrackingnumbertrackingnumber"></a>
# **AssetsassetIdlocationIdlocationIdstoreIdstoreIdtagIdtagIdtrackingNumbertrackingNumber**
> SCServiceChannelServicesMessagingAssetsAssetResponse AssetsassetIdlocationIdlocationIdstoreIdstoreIdtagIdtagIdtrackingNumbertrackingNumber (int assetId, int? locationId = null, string? storeId = null, string? tagId = null, int? trackingNumber = null)

Get an asset

Returns the details of the specified asset for the current subscriber.<br />              Send the [GET/ assets/locations/{locationId}](https://developer.servicechannel.com/swagger/ui/index?version=3#/Assets/GETv3_assets_locations__locationId__trade__trade_) request to retrieve assets for a particular location.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsassetIdlocationIdlocationIdstoreIdstoreIdtagIdtagIdtrackingNumbertrackingNumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var assetId = 56;  // int | Unique numeric asset identifier you want to get information of.
            var locationId = 56;  // int? | Unique numeric location identifier. Should be paired with the `tagId` parameter to work correctly. (optional) 
            var storeId = "storeId_example";  // string? | Alphanumeric location identifier in the client’s system. Should be paired with the `tagId` parameter to work correctly. (optional) 
            var tagId = "tagId_example";  // string? | Alphanumeric asset identifier assigned by the client. Should be paired with either `locationId` or `storeId` to work correctly. (optional) 
            var trackingNumber = 56;  // int? | Unique ID of the work order. Use the parameter to get asset validation attributes: `AssetValidated`, `ValidationRequired`. (optional) 

            try
            {
                // Get an asset
                SCServiceChannelServicesMessagingAssetsAssetResponse result = apiInstance.AssetsassetIdlocationIdlocationIdstoreIdstoreIdtagIdtagIdtrackingNumbertrackingNumber(assetId, locationId, storeId, tagId, trackingNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsassetIdlocationIdlocationIdstoreIdstoreIdtagIdtagIdtrackingNumbertrackingNumber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsassetIdlocationIdlocationIdstoreIdstoreIdtagIdtagIdtrackingNumbertrackingNumberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an asset
    ApiResponse<SCServiceChannelServicesMessagingAssetsAssetResponse> response = apiInstance.AssetsassetIdlocationIdlocationIdstoreIdstoreIdtagIdtagIdtrackingNumbertrackingNumberWithHttpInfo(assetId, locationId, storeId, tagId, trackingNumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsassetIdlocationIdlocationIdstoreIdstoreIdtagIdtagIdtrackingNumbertrackingNumberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetId** | **int** | Unique numeric asset identifier you want to get information of. |  |
| **locationId** | **int?** | Unique numeric location identifier. Should be paired with the &#x60;tagId&#x60; parameter to work correctly. | [optional]  |
| **storeId** | **string?** | Alphanumeric location identifier in the client’s system. Should be paired with the &#x60;tagId&#x60; parameter to work correctly. | [optional]  |
| **tagId** | **string?** | Alphanumeric asset identifier assigned by the client. Should be paired with either &#x60;locationId&#x60; or &#x60;storeId&#x60; to work correctly. | [optional]  |
| **trackingNumber** | **int?** | Unique ID of the work order. Use the parameter to get asset validation attributes: &#x60;AssetValidated&#x60;, &#x60;ValidationRequired&#x60;. | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingAssetsAssetResponse**](SCServiceChannelServicesMessagingAssetsAssetResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The details of the requested asset are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **404** | The request URI is incorrect, or the resource does not exist.              &lt;br/&gt;Error codes:              502 — Asset is not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsassetidassetwohistory"></a>
# **AssetsassetidAssetwohistory**
> List&lt;SCServiceChannelApiModelEquipmentsAssetWorkHistory&gt; AssetsassetidAssetwohistory (int assetid)

Get asset workorder history

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsassetidAssetwohistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var assetid = 56;  // int | 

            try
            {
                // Get asset workorder history
                List<SCServiceChannelApiModelEquipmentsAssetWorkHistory> result = apiInstance.AssetsassetidAssetwohistory(assetid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsassetidAssetwohistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsassetidAssetwohistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get asset workorder history
    ApiResponse<List<SCServiceChannelApiModelEquipmentsAssetWorkHistory>> response = apiInstance.AssetsassetidAssetwohistoryWithHttpInfo(assetid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsassetidAssetwohistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetid** | **int** |  |  |

### Return type

[**List&lt;SCServiceChannelApiModelEquipmentsAssetWorkHistory&gt;**](SCServiceChannelApiModelEquipmentsAssetWorkHistory.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              503 — User info should not be null;              SubscriberId is null; |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsbrandnameaddbrand"></a>
# **AssetsbrandNameAddBrand**
> int AssetsbrandNameAddBrand (string brandName)

Add Brand

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsbrandNameAddBrandExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var brandName = "brandName_example";  // string | 

            try
            {
                // Add Brand
                int result = apiInstance.AssetsbrandNameAddBrand(brandName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetsbrandNameAddBrand: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsbrandNameAddBrandWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Brand
    ApiResponse<int> response = apiInstance.AssetsbrandNameAddBrandWithHttpInfo(brandName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetsbrandNameAddBrandWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **brandName** | **string** |  |  |

### Return type

**int**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              503 — User info should not be null;              SubscriberId is null; |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetssubscriberidvalidationrules"></a>
# **AssetssubscriberIdValidationRules**
> SCServiceChannelServicesMessagingAdministrationAssetRulesAssetTagging AssetssubscriberIdValidationRules (int subscriberId)

Gets the asset tag validation settings for the specified subscriber.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetssubscriberIdValidationRulesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var subscriberId = 56;  // int | 

            try
            {
                // Gets the asset tag validation settings for the specified subscriber.
                SCServiceChannelServicesMessagingAdministrationAssetRulesAssetTagging result = apiInstance.AssetssubscriberIdValidationRules(subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetssubscriberIdValidationRules: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetssubscriberIdValidationRulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the asset tag validation settings for the specified subscriber.
    ApiResponse<SCServiceChannelServicesMessagingAdministrationAssetRulesAssetTagging> response = apiInstance.AssetssubscriberIdValidationRulesWithHttpInfo(subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetssubscriberIdValidationRulesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** |  |  |

### Return type

[**SCServiceChannelServicesMessagingAdministrationAssetRulesAssetTagging**](SCServiceChannelServicesMessagingAdministrationAssetRulesAssetTagging.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and response contains asset tag validation exception information |  -  |
| **400** | Request did NOT succeed and response contains error information |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetstrackingnumberisvalidationrequired"></a>
# **AssetstrackingNumberIsValidationRequired**
> Object AssetstrackingNumberIsValidationRequired (int trackingNumber)

Get Scan Method

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetstrackingNumberIsValidationRequiredExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var trackingNumber = 56;  // int | Tracking Number

            try
            {
                // Get Scan Method
                Object result = apiInstance.AssetstrackingNumberIsValidationRequired(trackingNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetstrackingNumberIsValidationRequired: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetstrackingNumberIsValidationRequiredWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Scan Method
    ApiResponse<Object> response = apiInstance.AssetstrackingNumberIsValidationRequiredWithHttpInfo(trackingNumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetstrackingNumberIsValidationRequiredWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **trackingNumber** | **int** | Tracking Number |  |

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
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              503 — Request Data should not be null; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br&gt;Error codes:              504 — API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetstradeidgetassettypegroupsbytradeid"></a>
# **AssetstradeIdGetAssetTypeGroupsByTradeId**
> List&lt;SCServiceChannelServicesMessagingAssetTypesAssetTypeGroup&gt; AssetstradeIdGetAssetTypeGroupsByTradeId (int tradeId)

Get asset type groups by tradeId

Adds tradeId. Returns list of assetTypeGroup for successful request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetstradeIdGetAssetTypeGroupsByTradeIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var tradeId = 56;  // int | 

            try
            {
                // Get asset type groups by tradeId
                List<SCServiceChannelServicesMessagingAssetTypesAssetTypeGroup> result = apiInstance.AssetstradeIdGetAssetTypeGroupsByTradeId(tradeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssetstradeIdGetAssetTypeGroupsByTradeId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetstradeIdGetAssetTypeGroupsByTradeIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get asset type groups by tradeId
    ApiResponse<List<SCServiceChannelServicesMessagingAssetTypesAssetTypeGroup>> response = apiInstance.AssetstradeIdGetAssetTypeGroupsByTradeIdWithHttpInfo(tradeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssetstradeIdGetAssetTypeGroupsByTradeIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tradeId** | **int** |  |  |

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
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              503 — Request Data should not be null.              User info should not be null.              SubscriberId is null.              Unknown Asset type; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="associateassetcode"></a>
# **AssociateAssetCode**
> void AssociateAssetCode (bool processDuplicatedAssetTag, string code, int equipmentId, string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssociateAssetCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var processDuplicatedAssetTag = true;  // bool | 
            var code = "code_example";  // string | 
            var equipmentId = 56;  // int | 
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                apiInstance.AssociateAssetCode(processDuplicatedAssetTag, code, equipmentId, expand, select, filter, orderby, top, skip, count);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.AssociateAssetCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssociateAssetCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AssociateAssetCodeWithHttpInfo(processDuplicatedAssetTag, code, equipmentId, expand, select, filter, orderby, top, skip, count);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.AssociateAssetCodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **processDuplicatedAssetTag** | **bool** |  |  |
| **code** | **string** |  |  |
| **equipmentId** | **int** |  |  |
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="findassets"></a>
# **FindAssets**
> List&lt;SCServiceChannelServicesMessagingAssetsAssetResponse&gt; FindAssets (string searchCriteria, string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Finds assets using the supplied search criteria.  The following fields will be searched for a match to the search criteria:  tag ID, asset type, brand, serial Number

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class FindAssetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var searchCriteria = "searchCriteria_example";  // string | 
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Finds assets using the supplied search criteria.  The following fields will be searched for a match to the search criteria:  tag ID, asset type, brand, serial Number
                List<SCServiceChannelServicesMessagingAssetsAssetResponse> result = apiInstance.FindAssets(searchCriteria, expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.FindAssets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindAssetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Finds assets using the supplied search criteria.  The following fields will be searched for a match to the search criteria:  tag ID, asset type, brand, serial Number
    ApiResponse<List<SCServiceChannelServicesMessagingAssetsAssetResponse>> response = apiInstance.FindAssetsWithHttpInfo(searchCriteria, expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.FindAssetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **searchCriteria** | **string** |  |  |
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingAssetsAssetResponse&gt;**](SCServiceChannelServicesMessagingAssetsAssetResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Indicates that the request DID NOT succeed and that the related error information is in the response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="findassetsbylocation"></a>
# **FindAssetsByLocation**
> List&lt;SCServiceChannelServicesMessagingAssetsAssetResponse&gt; FindAssetsByLocation (int locationId, string searchCriteria, string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class FindAssetsByLocationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var locationId = 56;  // int | 
            var searchCriteria = "searchCriteria_example";  // string | 
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                List<SCServiceChannelServicesMessagingAssetsAssetResponse> result = apiInstance.FindAssetsByLocation(locationId, searchCriteria, expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.FindAssetsByLocation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindAssetsByLocationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<SCServiceChannelServicesMessagingAssetsAssetResponse>> response = apiInstance.FindAssetsByLocationWithHttpInfo(locationId, searchCriteria, expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.FindAssetsByLocationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** |  |  |
| **searchCriteria** | **string** |  |  |
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingAssetsAssetResponse&gt;**](SCServiceChannelServicesMessagingAssetsAssetResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Indicates that the request DID NOT succeed and that the related error information is in the response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="findassetsbysubscriber"></a>
# **FindAssetsBySubscriber**
> List&lt;SCServiceChannelServicesMessagingAssetsAssetResponse&gt; FindAssetsBySubscriber (int subscriberId, string searchCriteria, string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Finds assets using the supplied search criteria.  The following fields will be searched for a match to the search criteria:  tag ID, asset type, brand, serial Number

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class FindAssetsBySubscriberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var subscriberId = 56;  // int | 
            var searchCriteria = "searchCriteria_example";  // string | 
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Finds assets using the supplied search criteria.  The following fields will be searched for a match to the search criteria:  tag ID, asset type, brand, serial Number
                List<SCServiceChannelServicesMessagingAssetsAssetResponse> result = apiInstance.FindAssetsBySubscriber(subscriberId, searchCriteria, expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.FindAssetsBySubscriber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindAssetsBySubscriberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Finds assets using the supplied search criteria.  The following fields will be searched for a match to the search criteria:  tag ID, asset type, brand, serial Number
    ApiResponse<List<SCServiceChannelServicesMessagingAssetsAssetResponse>> response = apiInstance.FindAssetsBySubscriberWithHttpInfo(subscriberId, searchCriteria, expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.FindAssetsBySubscriberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** |  |  |
| **searchCriteria** | **string** |  |  |
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingAssetsAssetResponse&gt;**](SCServiceChannelServicesMessagingAssetsAssetResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Indicates that the request DID NOT succeed and that the related error information is in the response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getasset"></a>
# **GetAsset**
> SCServiceChannelServicesMessagingAssetsAssetResponse GetAsset (int assetId, string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Get an asset

Returns the details of the specified asset for the current subscriber.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var assetId = 56;  // int | Unique numeric asset identifier you want to get the details of.
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Get an asset
                SCServiceChannelServicesMessagingAssetsAssetResponse result = apiInstance.GetAsset(assetId, expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.GetAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an asset
    ApiResponse<SCServiceChannelServicesMessagingAssetsAssetResponse> response = apiInstance.GetAssetWithHttpInfo(assetId, expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.GetAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetId** | **int** | Unique numeric asset identifier you want to get the details of. |  |
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingAssetsAssetResponse**](SCServiceChannelServicesMessagingAssetsAssetResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested asset with its details is in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc. |  -  |
| **404** | The request URI is incorrect, or the resource does not exist. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchassets"></a>
# **SearchAssets**
> List&lt;SCServiceChannelServicesMessagingAssetsAssetResponse&gt; SearchAssets (string code, int locationId, string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Get assets by `locationId` and `code`

Returns a list of assets for the current subscriber based on the specified `locationId` and `code` parameters. You can narrow the search by applying other filter parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SearchAssetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi(config);
            var code = "code_example";  // string | Also known as AssetTag. The value must be entered in '29182-A'
            var locationId = 56;  // int | Unique numeric identifier of the location you want to get assets of.
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Get assets by `locationId` and `code`
                List<SCServiceChannelServicesMessagingAssetsAssetResponse> result = apiInstance.SearchAssets(code, locationId, expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.SearchAssets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchAssetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get assets by `locationId` and `code`
    ApiResponse<List<SCServiceChannelServicesMessagingAssetsAssetResponse>> response = apiInstance.SearchAssetsWithHttpInfo(code, locationId, expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.SearchAssetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | Also known as AssetTag. The value must be entered in &#39;29182-A&#39; |  |
| **locationId** | **int** | Unique numeric identifier of the location you want to get assets of. |  |
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingAssetsAssetResponse&gt;**](SCServiceChannelServicesMessagingAssetsAssetResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested assets are in the response. |  -  |
| **401** | The request is not authorized.&lt;br/&gt;&lt;br/&gt;Error codes:&lt;br/&gt; 504 � API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

