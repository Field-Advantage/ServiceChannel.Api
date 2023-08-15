# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingAssetTypesAssetTypeGroup
Asset type group object.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique numeric identifier of the asset type group. | [optional] 
**SubscriberId** | **int** | Unique numeric identifier of the subscriber. | [optional] 
**Name** | **string** | The name of the asset type group. | [optional] 
**FileName** | **string** | The file name of the image attached to the asset type group. For example, *audioequipment.png* or *AEE323FF8091.jpeg*. | [optional] 
**FilePath** | **string** | Path snippet to the full-size image version attached to the asset type group. For example, *#assets/6cb4f87b-3d5f-49ba-9971-11442dcf3d1e*. | [optional] 
**ThumbnailPath** | **string** | Path snippet to the reduced-size image version attached to the asset type group. For example, *#assets/7bc49564-5ac4-4002-9ffc-2282483e6df8*. | [optional] 
**AssetTypeIds** | **List&lt;int&gt;** | A list of unique numeric identifiers of the asset types. | [optional] 
**ImgPath** | **string** | Path to the cloud location of the full-size image version attached to the asset type group. | [optional] [readonly] 
**Uri** | **string** | The URI of the full-size image version attached to the asset type group. | [optional] 
**ThumbnailUri** | **string** | The URI of the reduced-size image version attached to the asset type group. | [optional] 
**AssetTypeCategoryId** | **int** | Unique numeric identifier of the asset category. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

