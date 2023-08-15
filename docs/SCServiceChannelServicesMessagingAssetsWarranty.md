# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingAssetsWarranty
Object containing warranty parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExpirationDate** | **DateTime** | Warranty expiration date based on the warranty expiration settings. | [optional] 
**ProviderId** | **int** | ID of a provider who is in charge of warranty services. | [optional] 
**NTE** | **double** | Maximum amount of money to be spent on warranty services in USD. Value -1  means that the amount is not applicable. | [optional] 
**Priority** | **string** | Defines how quickly warranty services should be provided, for example, *Emergency-4 Hours*, *Normal-48 Hours*, *7 Days*. | [optional] 
**Category** | **string** | Warranty category, for example, *ADVISE ONLY*, *REPAIR*, *DISASTER*. | [optional] 
**Provider** | [**SCServiceChannelServicesMessagingAssetsWarrantyProvider**](SCServiceChannelServicesMessagingAssetsWarrantyProvider.md) |  | [optional] 
**Expiration** | [**SCServiceChannelServicesMessagingAssetsWarrantyExpiration**](SCServiceChannelServicesMessagingAssetsWarrantyExpiration.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

