# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingProposalsUpdateProposalStatusRequest
The request object to update a proposal status.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Comment** | **string** | Comment on the proposal status update. The comment is added to the work order note. | [optional] 
**ProviderEmail** | **string** | Provider’s email address to which a notification about the proposal status change is sent. The default is the email address of the provider the proposal is assigned to. | [optional] 
**UserEmail** | **string** | User’s email address to which a notification about the proposal status change is sent. The default is the email address of the current user. | [optional] 
**RejectReasonCodeId** | **int** | Numeric identifier of the reason for rejecting the proposal.              Pass value to this parameter when sending the *PUT /proposals/{proposalId}/reject* request. To retrieve a list of rejection reason codes and their descriptions, use the *GET /proposals/RejectionReasons* method. | [optional] 
**ActionSource** | **string** |  | [optional] 
**ReasonString** | **string** | Reason for approving the proposal.              Pass value to this parameter when sending the *PUT /proposals/{proposalId}/approve* request. The entered reason is added to the work order note. | [optional] 
**Actor** | **string** | The Actor is added to the work order note. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

