# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingRfpCreateRfpRequest
The request object to create an RFP.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Number** | **string** | The non-unique RFP identifier. The value is generated automatically if not provided. It cannot be modified. | [optional] 
**PONumber** | **string** | Purchase order number. | [optional] 
**WONumber** | **string** | Work order number. | [optional] 
**TradeId** | **int** | The unique trade identifier. | 
**Description** | **string** | RFP description. | 
**Status** | **string** | RFP status. | [optional] 
**Date** | **DateTime** | The RFP creation date and time. The format is &#x60;YYYY-MM-DDThh:mm:ss.sssZ&#x60;. The default is the current date and time. | [optional] 
**DateString** | **string** |  | [optional] 
**DueHrs** | **double** | Due time in hours for the provider to respond to the RFP and submit a proposal. The default is 48 hours unless a different value is specified in the &#x60;UiCreationRfpDefaultTime&#x60; settings group. | [optional] 
**DueDate** | **DateTime** | Due date and time for the provider to respond to the RFP and submit a proposal. The format is &#x60;YYYY-MM-DDThh:mm:ss.sssZ&#x60;. If &#x60;DueHrs&#x60; is passed, the &#x60;DueDate&#x60; value is &#x60;Date&#x60; plus &#x60;DueHrs&#x60;.              The default is the current date and time plus 48 hours unless a different value is specified in the &#x60;UiCreationRfpDefaultTime&#x60; settings group. | [optional] 
**DueDateString** | **string** |  | [optional] 
**Location** | [**SCServiceChannelServicesMessagingLocationLocationIdentity**](SCServiceChannelServicesMessagingLocationLocationIdentity.md) |  | 
**Language** | **string** |  | [optional] 
**ProviderId** | **int** | The unique provider identifier. | 
**ResponseDate** | **DateTime** | Obsolete. | [optional] 
**ProposalNotificationEmail** | **string** | The email address to send the proposal notification to. The default is the email address of the current user specified in the &#x60;PropTeamEmail&#x60; settings group. | [optional] 
**ProviderEmail** | **string** | The email address of the provider. The default is the email address of the specified provider. | [optional] 
**ProposalTemplateId** | **int** | Obsolete. | [optional] 
**WorkOrderId** | **int** | The unique numeric identifier of the work order. | [optional] 
**ProjectId** | **int** | The unique numeric identifier of the project. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

