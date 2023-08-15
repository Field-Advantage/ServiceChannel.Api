# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingWorkordersReassignWORequest
Reassign WorkOrder To other Provider

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WorkorderId** | **int** | Work order id. | [optional] 
**Trade** | **string** | Trade | [optional] 
**Problem** | **string** | Problem Description. | [optional] 
**ProblemCode** | **string** | Problem Code. | [optional] 
**CurrencyId** | **int** | Optional, by default current Work Order Currency | [optional] 
**Nte** | **double** | Optional Nte value, by default current Work Order NTE | [optional] 
**GlCode** | **string** | Optional GL code value | [optional] 
**ReasonId** | **int** | Required, Reassignment reason Id. | 
**ProviderId** | **int** | Required, Provider id to assign. | 
**Category** | **string** | Category. | [optional] 
**Priority** | **string** | Priority | [optional] 
**Note** | **string** | Note | [optional] 
**ProcessName** | **string** | ProcessName | [optional] 
**RequestEmail** | **string** | Request email | [optional] 
**RequestEmailCopy** | **string** | Request email copy to | [optional] 
**NotifyProvider** | **bool** | Notify Provider: send email if true | [optional] [default to false]
**AdditionalApprovalCodes** | [**List&lt;SCServiceChannelServicesMessagingApprovalCodesAdditionalApprovalCode&gt;**](SCServiceChannelServicesMessagingApprovalCodesAdditionalApprovalCode.md) | Additional approval codes | [optional] 
**ScheduledDate** | **DateTime** | Work order scheduled date | [optional] 
**OriginalETA** | **DateTime** | Original ETA | [optional] 
**RefreshApprovalCodes** | **bool** | If true: update Approval Codes | [optional] [default to false]
**RecallWorkOrderId** | **int** | Original work order Id | [optional] 
**LocationId** | **int** | WO location id | [optional] 
**PurchaseOrder** | **string** | Purchase Order | [optional] 
**ApiRequest** | **bool** | API request | [optional] [default to false]
**Actor** | **string** | Optional, Actor | [optional] 
**LabelId** | **int** |  | [optional] 
**Label** | **string** |  | [optional] 
**DeleteLabel** | **bool** |  | [optional] [default to false]
**CategoryId** | **int** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

