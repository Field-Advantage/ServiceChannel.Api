# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingWorkordersCheckInRequest
Check-in request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WorkTypeId** | **int** | The unique ID of the work type.              **Possible values:** &#x60;1&#x60; — Repair, &#x60;2&#x60; — Travel. Other values are possible when custom types are set up for the subscriber.              **Default value:** 1. | [optional] 
**UserId** | **int** | The user ID of the technician that is checking in. Use the same &#x60;UserId&#x60; for one pair of check-in and check-out records.              **Default value:** ID of the current user. | [optional] 
**TechsCount** | **int** | The number of technicians that are checking in.              **Default value:** 1. | [optional] 
**Latitude** | **double** | The latitude of the technician’s current position.              Required for the Repair type. Not required for the Travel and custom types as well as for the Repair type when the [XML check-in/out permission](https://developer.servicechannel.com/guides/checkin/before-you-start/#xml-check-inout-permission) is enabled. | 
**Longitude** | **double** | The longitude of the technician’s current position.              Required for the Repair type. Not required for the Travel and custom types as well as for the Repair type when the [XML check-in/out permission](https://developer.servicechannel.com/guides/checkin/before-you-start/#xml-check-inout-permission) is enabled. | 
**CheckInTime** | **DateTime** | The date and time of the check-in. Either indicate in UTC or pass the current time and add the UTC offset.              You can pass this value only when the [XML check-in/out permission](https://developer.servicechannel.com/guides/checkin/before-you-start/#xml-check-inout-permission) is enabled.              **Default value:** current date and time. | [optional] 
**Actor** | **string** | Optional, Actor | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

