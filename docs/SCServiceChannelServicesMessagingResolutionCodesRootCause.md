# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingResolutionCodesRootCause
Root cause object.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **int** | Root cause identifier. | [optional] 
**Value** | **string** | Root cause name. | [optional] 
**HasFreeText** | **bool** | Defines whether a user can enter a comment explaining their understanding of the root cause and specifying the reason why the problem occurred. | [optional] [default to false]
**Order** | **int** | Order of appearance of a root cause. | [optional] 
**AssetCategoryIds** | **List&lt;int&gt;** | Asset category ID. A value populates only if two or more categories are specified in assetCategoryIds in the filter. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

