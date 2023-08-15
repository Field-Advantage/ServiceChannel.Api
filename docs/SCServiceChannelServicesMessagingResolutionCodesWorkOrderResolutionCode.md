# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingResolutionCodesWorkOrderResolutionCode
Resolution code object.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **int** | Resolution code identifier. | [optional] 
**Value** | **string** | Resolution code name. | [optional] 
**HasFreeText** | **bool** | Defines whether a user can enter a comment explaining their understanding of the resolution code and specifying what was done on site to solve the issue. | [optional] [default to false]
**Text** | **string** | Comment that a technician enters to provide their understanding of the resolution code of a work order explaining what was done on site to solve the issue.              Comments are enabled for resolution codes with the &#x60;HasFreeText&#x60; attribute. | [optional] 
**AssetCategoryId** | **int** | Asset category ID specified by a user with access to asset categories. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

