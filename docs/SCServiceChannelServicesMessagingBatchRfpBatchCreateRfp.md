# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingBatchRfpBatchCreateRfp

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RfpNumber** | **string** | The non-unique RFP identifier. The value is generated automatically if not provided. It cannot be modified. | [optional] 
**TradeId** | **int** | The unique trade identifier. | 
**Description** | **string** | RFP description. | 
**Date** | **DateTime** | The RFP creation date and time. The format is &#x60;YYYY-MM-DDThh:mm:ss.sssZ&#x60;. The default is the current date and time. | [optional] 
**DueHrs** | **double** | Due time in hours for the provider to respond to the RFP and submit a proposal. The default is 48 hours unless a different value is specified in the &#x60;UiCreationRfpDefaultTime&#x60; settings group. | [optional] 
**DueDate** | **DateTime** | Due date and time for the provider to respond to the RFP and submit a proposal. The format is &#x60;YYYY-MM-DDThh:mm:ss.sssZ&#x60;. If &#x60;DueHrs&#x60; is passed, the &#x60;DueDate&#x60; value is &#x60;Date&#x60; plus &#x60;DueHrs&#x60;.              The default is the current date and time plus 48 hours unless a different value is specified in the &#x60;UiCreationRfpDefaultTime&#x60; settings group. | [optional] 
**LocationId** | **int** | Location identifier | 
**CreateRequestId** | **string** | Create Request Id from project module | [optional] 
**LocationName** | **string** | Store ID | 
**ProviderId** | **int** | The unique provider identifier. | 
**ProjectId** | **int** | The unique project identifier. | [optional] 
**PurchaseOrder** | **string** | The Purchase Order. | [optional] 
**ProviderEmail** | **string** | Provider&#39;s email | [optional] 
**WaitingForPrpEmail** | **string** | User&#39;s email | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

