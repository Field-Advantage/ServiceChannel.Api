# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingProposalsAssignUserToProposalRequest
The request object to assign a proposal to a user.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserId** | **int** | The unique numeric identifier of the user to assign the proposal to. | 
**Comments** | **string** | Your comment describing why you are assigning or reassigning the proposal to the specified user. | [optional] 
**UserEmail** | **string** | The email address to send a notification about the assigned proposal to. The default is the email address of the user who is assigned the proposal. | [optional] 
**ReasonString** | **string** | Reason for approving the proposal. Don’t pass when assigning the proposal to a user. | [optional] 
**Note** | **string** | Note added upon assigning or reassigning the proposal. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

