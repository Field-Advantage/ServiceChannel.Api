# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingResolutionCodesWorkOrderRootCause
Root cause object.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **int** | Root cause identifier. | [optional] 
**Value** | **string** | Root cause name. | [optional] 
**HasFreeText** | **bool** | Defines whether a user can enter a comment explaining their understanding of the root cause and specifying the reason why the problem occurred. | [optional] [default to false]
**Text** | **string** | Comment that a technician enters to provide their understanding of the root cause of a work order explaining the reason why the problem occurred.              Comments are enabled for root causes with the &#x60;HasFreeText&#x60; attribute. | [optional] 
**AssetCategoryId** | **int** | Asset category ID specified by a user with access to asset categories. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

