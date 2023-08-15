# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingCheckListDetailsCheckListQuestionOptionResponse
Answer option configured for a checklist question of the **Selector** type.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | ID of the answer option for a checklist question of the **Selector** type. | [optional] 
**Answer** | **string** | Answer option for a checklist question of the **Selector** type. A technician can select from a list of configured options when answering the question. | [optional] 
**Sequence** | **int** | Not applicable to checklists. | [optional] 
**IsConditionalFollowUp** | **bool** | Defines whether a technician is prompted to add a comment to the selected answer option. A comment is mandatory if answering the checklist question is required. | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

