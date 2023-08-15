# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingWorkordersWorkOrderAnalyticsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IVR** | **bool** | Indicates whether the work order has both Check-In and Check-Out records and completes with a Check-Out. **Possible values**: *true*, *false*. | [optional] [default to false]
**SLA** | **bool** | Indicates whether the work order met the original ETA. **Possible values**: *true*, *false*, or *null* (if the &#x60;Original ETA&#x60; or &#x60;CheckInTime&#x60; is not populated in source data). | [optional] [default to false]
**FirstTimeCompletionFlag** | **int** | Indicates whether the work order was completed on the first visit. **Possible values**: &#x60;1&#x60; - *Yes*, &#x60;0&#x60; - *No*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

