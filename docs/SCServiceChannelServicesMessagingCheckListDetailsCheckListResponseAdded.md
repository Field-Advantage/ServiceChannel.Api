# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingCheckListDetailsCheckListResponseAdded
Checklist response object.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CheckListQuestionId** | **int** |  | [optional] 
**CheckListQuestionOptionId** | **int** |  | [optional] 
**ProviderId** | **int** |  | [optional] 
**TechnicianId** | **int** |  | [optional] 
**Id** | **int** | Checklist response ID. | [optional] 
**Answer** | **string** | Answer to a checklist question. | [optional] 
**FreeTextAnswer** | **string** | Comment to an answer option with the &#x60;IsConditionalFollowUp&#x60; attribute. Answer options are configured for questions of the **Selector** type. | [optional] 
**EntityId** | **int** | ID of the work order the response was submitted for. | [optional] 
**EntityTypeId** | **int** | ID of the entity the response was submitted for. 0 is returned for work orders. | [optional] 
**Attempt** | **int** | Order of a technician’s on-site visit when the response was submitted. | [optional] 
**UpdatedDate** | **DateTime** | Date and time when the response was last updated set in EST. The format is &#x60;YYYY-MM-DDThh:mm:ss.sss&#x60;. | [optional] 
**UpdatedDateStr** | **string** | Date and time when the response was last updated set in the location’s time zone. The format is &#x60;Month Day Year hh:mm&#x60;. | [optional] 
**UpdatedDateDto** | **DateTime** | Date and time when the response was last updated set in the location’s time zone with the UTC offset. The format is &#x60;YYYY-MM-DDThh:mm:ss.sss±hh:mm&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
