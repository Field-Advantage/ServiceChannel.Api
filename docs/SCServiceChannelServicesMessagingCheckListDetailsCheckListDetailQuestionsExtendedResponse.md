# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingCheckListDetailsCheckListDetailQuestionsExtendedResponse
Checklist question details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CheckListCreatedDate** | **DateTime** | Date and time when the checklist was created. | [optional] 
**CheckListName** | **string** | Name of the checklist the question belongs to. | [optional] 
**Id** | **int** | Checklist question ID. | [optional] 
**CheckListId** | **int** | ID of the checklist the question belongs to. | [optional] 
**Question** | **string** | Checklist question that a technician is prompted to answer when working on a service request. | [optional] 
**ShortDescription** | **string** | Not applicable to checklists. | [optional] 
**AnswerRequired** | **bool** | Defines whether answering this checklist question is mandatory. | [optional] [default to false]
**PictureFlag** | **string** | Defines whether a technician is required to upload an attachment when answering the question:               • 0 — Adding an attachment is optional.               • 1 — An attachment is not required.               • 2 — Uploading an attachment is mandatory. | [optional] 
**Sequence** | **int** | Not applicable to checklists. | [optional] 
**QuestionType** | **string** | [Checklist question type](https://developer.servicechannel.com/guides/checklists/types-of-checklist-questions/):               • 0 — **Acknowledgement**: Represents an on/off toggle prompting a technician to give a positive or negative response to a question.               • 1 — **Selector**: Provides multiple configured answer options to choose from.               • 2 — **Text Entry**: Allows entering a text answer.               • 4 — **Numeric Input**: Prompts to submit a number as a response. | [optional] 
**CheckListQuestionOptions** | [**List&lt;SCServiceChannelServicesMessagingCheckListDetailsCheckListQuestionOptionResponse&gt;**](SCServiceChannelServicesMessagingCheckListDetailsCheckListQuestionOptionResponse.md) | Answer options for questions of the Selector type. | [optional] 
**AnswerCanPersist** | **bool** | Defines whether the answer to this question can persist. If the answer is persistent, the last submitted response populates on the question. A technician can either opt for the current response or update it. | [optional] [default to false]
**CheckListTimingType** | **string** | Defines the checklist segment the question belongs to: 1 — check-in segment, 2 — check-out segment. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

