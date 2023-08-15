# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingWorkordersWorkActivityPostRequest
Request object to create a work activity.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WorkTypeId** | **int** | The type of activity performed: 1 — *Repair*, 2 — *Travel*. You can pass other values if custom types are set up for the subscriber. | [optional] 
**CheckInDate** | **DateTime** | The date and time when a technician started work on the service request. The format is &#x60;YYYY-MM-DDThh:mm:ss.sssZ&#x60;. The default is the current date and time. | [optional] 
**CheckOutDate** | **DateTime** | The date and time when a technician finished work on the service request. The format is &#x60;YYYY-MM-DDThh:mm:ss.sssZ&#x60;. The default is the current date and time. | [optional] 
**Name** | **string** | (*Optional*) The name of technician who worked on the service request. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

