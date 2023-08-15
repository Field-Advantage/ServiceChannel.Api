# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingProposalsProposalStatisticsResponse
Object of statistics on RFPs and proposals.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DaysPeriod** | **int** | Time period set as the number of days prior to the current date for which statistics on RFPs and proposals are returned. | [optional] 
**RFPsWaitingForApproval** | **int** | The total number of RFPs awaiting response for the specified time period. | [optional] 
**OpenProposals** | **int** | The total number of proposals in the _Open_ status for the specified time period. | [optional] 
**ApprovedProposalsDaysPeriod** | **int** | Time period set as the number of days prior to the current date for which statistics on approved proposals are returned in &#x60;ApprovedProposals&#x60;. | [optional] 
**ApprovedProposals** | **int** | The total number of proposals in the _Approved_ status for the specified time period. | [optional] 
**WaitingReviewProposals** | **int** | The total number of proposals in the _On Hold_ and _Reviewed_ statuses for the specified time period. | [optional] 
**RejectedProposals** | **int** | The total number of proposals in the _Rejected_ status for the specified time period. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

