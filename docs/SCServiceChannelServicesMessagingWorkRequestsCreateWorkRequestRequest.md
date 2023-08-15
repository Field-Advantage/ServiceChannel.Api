# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestRequest
Request to create a work request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SubscriberId** | **int** | Subscriber Id | [optional] 
**ProviderId** | **int** | Provider Id | [optional] 
**EventId** | **string** | Optional. Guid of IoT event. For example, B216E711-420F-4D32-9080-762CBFD4E732 | [optional] 
**LocationId** | **int** | Location Id | [optional] 
**StatusId** | **int** | WorkRequest status Id | [optional] 
**ExtendedStatusId** | **int** | WorkRequest extended status Id | [optional] 
**Description** | **string** | Description. Free text. | [optional] 
**TradeId** | **int** | Trade Id | [optional] 
**CategoryId** | **int** | Catgory Id | [optional] 
**PriorityId** | **int** | Priority Id | [optional] 
**Caller** | **string** | Optional. Caller | [optional] 
**CallDate** | **string** | Call date. In UTC | [optional] 
**ScheduledDate** | **string** | Optional. Scheduled date. In UTC | [optional] 
**AssetId** | **int** | Optional. Asset Id | [optional] 
**Nte** | [**SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestNteRequest**](SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestNteRequest.md) |  | [optional] 
**Issue** | [**SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestIssueRequest**](SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestIssueRequest.md) |  | [optional] 
**Attachments** | [**List&lt;SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestAttachmentRequest&gt;**](SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestAttachmentRequest.md) | Optional. Attachments | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

