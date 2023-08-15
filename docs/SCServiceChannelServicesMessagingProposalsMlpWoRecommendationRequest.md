# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingProposalsMlpWoRecommendationRequest
The request object to escalate a proposal.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **string** | Proposal escalation action. **Valid values**: *Approve*, *Reject*, *OnHold*, *Return*. | 
**WoType** | **int** | Work order type. **Valid values**: 0 — *Origin*, 1 — *New*, 2 — *Existing*. | [optional] 
**TrackingNumber** | **int** | The unique numeric identifier of the work order. Required if the &#x60;WoType&#x60; is 2 — *Existing*. | [optional] 
**PoNumber** | **string** | Purchase order number. | [optional] 
**ExistingPoNumber** | **string** | The existing purchase order number. If the &#x60;PoNumber&#x60; parameter is passed, its value is used instead of &#x60;ExistingPoNumber&#x60;. | [optional] 
**Category** | **string** | The overall classification of a WO, such as *Maintenance*, *Repair*, or *CAPEX*. Required if the &#x60;WoType&#x60; is 1 — *New*.              The value you enter must be a valid category. | [optional] 
**CategoryId** | **int** | Numeric identifier of the category. | [optional] 
**ApprovalCode** | **string** | Approval code, or GL code, used when approving an invoice. | [optional] 
**Priority** | **string** | Period during which a service provider should check in to perform the requested service. Required if the &#x60;WoType&#x60; is 1 — *New*.              The value you enter must be a valid priority. | [optional] 
**Comment** | **string** | Your comment describing why you are escalating the proposal. | [optional] 
**RejectReasonCodeId** | **int** | Numeric identifier of the reason for rejecting the proposal. Don’t pass when escalating the proposal. | [optional] 
**ReasonString** | **string** | Reason for approving the proposal. | [optional] 
**EmailsToNotify** | **string** | The email address of the user to notify about the proposal escalation. When entering multiple addresses, separate them with a comma or semicolon. | [optional] 
**EmailMyself** | **bool** | Defines if the proposal escalation notification is sent to the current user. | [optional] [default to false]
**MyEmail** | **string** | The email address of the current user to which a proposal escalation notification is sent. | [optional] 
**ProposalId** | **int** | The unique numeric identifier of the proposal to escalate. | [optional] 
**WorkOrderLabel** | [**SCServiceChannelApiModelLabel**](SCServiceChannelApiModelLabel.md) |  | [optional] 
**DeleteLabel** | **bool** | Is WorkOrder Label to delete. | [optional] [default to false]
**Actor** | **string** | The Actor is added to the work order note. | [optional] 
**AdditionalApprovalCodes** | [**List&lt;SCServiceChannelServicesMessagingApprovalCodesAdditionalApprovalCode&gt;**](SCServiceChannelServicesMessagingApprovalCodesAdditionalApprovalCode.md) | The Additional Approval Codes. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

