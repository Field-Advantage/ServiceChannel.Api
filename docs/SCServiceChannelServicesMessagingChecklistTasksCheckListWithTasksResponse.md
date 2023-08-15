# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingChecklistTasksCheckListWithTasksResponse
Parameters of a checklist with asset tasks.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChecklistName** | **string** | Checklist name. | [optional] 
**Id** | **int** | Checklist ID. | [optional] 
**IsActive** | **bool** | Defines whether the checklist is active or not. | [optional] [default to false]
**CreatedDate** | **DateTime** | Date and time when the checklist was created. | [optional] 
**UpdatedDate** | **DateTime** | Date and time when the checklist was last updated. | [optional] 
**CreatedBy** | **int** | User ID of the employee who created the checklist. | [optional] 
**UpdatedBy** | **int** | User ID of the employee who last updated the checklist. | [optional] 
**Tasks** | [**List&lt;SCServiceChannelServicesMessagingChecklistTasksChecklistTaskResponse&gt;**](SCServiceChannelServicesMessagingChecklistTasksChecklistTaskResponse.md) | A list of asset-related tasks configured for the checklist. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

