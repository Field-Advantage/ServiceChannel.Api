# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingPrioritiesPriorityResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | UID of priority. Can be null | [optional] 
**Name** | **string** | Priority name | [optional] 
**SubscriberId** | **int** | UID of subscriber. Can be null | [optional] 
**Eta** | **string** | ETA | [optional] 
**SkipNights** | **bool** | Skip nights while calculating scheduled date | [optional] [default to false]
**SkipWeekends** | **bool** | Skip weekends while calculating scheduled date | [optional] [default to false]
**LocationId** | **int** | If priority is associated with location - assiciated location | [optional] 
**Trade** | **string** | If priority is associated with trade - assiciated trade | [optional] 
**ScheduledDate** | **DateTime** | Calculated WO Scheduled Date | [optional] 
**ScheduledDateDTO** | **DateTime** | Calculated WO Scheduled Date with time zone offset | [optional] 
**IsSelectable** | **bool** | IsSelectable | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

