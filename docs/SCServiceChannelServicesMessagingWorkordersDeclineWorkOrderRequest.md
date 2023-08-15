# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingWorkordersDeclineWorkOrderRequest
Request model to add information about the work order decline

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeclineReasonId** | **int** | Unique numeric identifier of the work order decline reason.               &lt;br /&gt;**Possible values**: &#x60;1&#x60; - Can&#39;t make ETA, &#x60;2&#x60; -  Trade not serviced, &#x60;3&#x60; - Location not serviced, &#x60;4&#x60; - Not under warranty, &#x60;5&#x60; - Other, &#x60;6&#x60; - NTE too low.               &lt;br /&gt;***Note***: The parameter is required when the *DeclineHistoryWO* feature flag is on. | [optional] 
**CustomDeclineReason** | **string** | Text explaining the reason for the work order decline.               &lt;br /&gt;***Note***: The parameter is required when the decline reason has AskCustomReason&#x3D;true. | [optional] 
**Note** | **string** | *Optional*. Note text. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

