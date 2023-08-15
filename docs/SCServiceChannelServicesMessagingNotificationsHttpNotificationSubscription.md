# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingNotificationsHttpNotificationSubscription

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The unique subscription ID. Generated automatically and cannot be modified. | [optional] 
**Url** | **string** | The URL to which the events should be delivered. | 
**Enabled** | **bool** | Defines if the subscription is active or inactive. | [optional] [default to false]
**Name** | **string** | The user-friendly name for the subscription. | 
**EventTypes** | **List&lt;SCServiceChannelServicesMessagingNotificationsHttpNotificationSubscription.EventTypesEnum&gt;** | The list of events to subscribe to. Events within one subscription should belong to one object. | 
**Rules** | [**SCServiceChannelServicesMessagingNotificationsNotificationSubscriptionsRules**](SCServiceChannelServicesMessagingNotificationsNotificationSubscriptionsRules.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

