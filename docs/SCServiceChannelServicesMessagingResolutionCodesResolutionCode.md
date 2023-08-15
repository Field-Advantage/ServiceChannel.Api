# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingResolutionCodesResolutionCode
Resolution code object.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **int** | Resolution code identifier. | [optional] 
**Value** | **string** | Resolution code name. | [optional] 
**HasFreeText** | **bool** | Defines whether a user can enter a comment explaining their understanding of the resolution code and specifying what was done on site to solve the issue. | [optional] [default to false]
**Order** | **int** | Order of appearance of a resolution code. | [optional] 
**AssetCategoryIds** | **List&lt;int&gt;** | Asset category ID. A value populates only if two or more categories are specified in assetCategoryIds in the filter. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

