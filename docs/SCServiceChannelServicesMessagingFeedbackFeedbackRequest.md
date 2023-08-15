# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingFeedbackFeedbackRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SetupId** | **int** | Dashboard SetupId (optional) | [optional] 
**LocationId** | **int** |  | [optional] 
**Answer** | **string** | Satisfactory answer.              Supported values: satisfactory, unsatisfactory | [optional] 
**Comment** | **string** | User text comment.              Required if answer is \&quot;unsatisfactory\&quot;.              Required if score lower than 3 | [optional] 
**StarScore** | **int** | Star scrore. The integer value from 1 to 5 (Required for satisfactory answer) | [optional] 
**SubscriberId** | **int** | Subscriber Id | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

