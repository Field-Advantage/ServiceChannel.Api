# ServiceChannel.Api.Model.SCServiceChannelServicesWebApiModelsUpdateDispatchSettingModel
The model for update isDoNotDispatch value for providers.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SubscriberId** | **int** | The id of a calling subscriber.              This id is the one who sets isDoNotDispatch value or is an aggregator of other subscribers.              If it is the aggregator then subscriberId and subscriberIds from SubscriberProviders pairs do not match. | [optional] 
**DoNotDispatch** | **bool** | The flag to set isDoNotDispatch value for providers. | [optional] [default to false]
**SubscriberIdProviderIds** | [**List&lt;SCServiceChannelServicesWebApiModelsSubscriberIdProviderIdsPair&gt;**](SCServiceChannelServicesWebApiModelsSubscriberIdProviderIdsPair.md) | The list of pairs subscriber and providers to set isDoNotDispatch value. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

