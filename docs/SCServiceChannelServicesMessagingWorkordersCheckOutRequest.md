# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingWorkordersCheckOutRequest
Check-out request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WorkTypeId** | **int** | The unique ID of the work type.              **Possible values:** &#x60;1&#x60; — Repair, &#x60;2&#x60; — Travel. Other values are possible when custom types are set up for the subscriber.              **Default value:** 1. | [optional] 
**PrimaryStatus** | **string** | The status that is set for the WO when checking out.              Required for the Repair type. Ignored for the Travel and custom types as well when &#x60;ActionStatus&#x60; &#x3D; &#x60;Cancel&#x60;.              **Default value:** NoStatusChange. | [optional] 
**ExtendedStatus** | **string** | The extended status that is set for the WO when checking out.              Optional for the Repair type. Ignored for the Travel and custom types, when &#x60;ActionStatus&#x60; &#x3D; &#x60;Cancel&#x60;, and for &#39;Completed&#39; PrimaryStatus (generated automatically).              Refrigerant WO with &#39;Completed&#39; PrimaryStatus — special case by RefrigerationTracking feature. | [optional] 
**ActionStatus** | **string** | The status of the activity.              **Possible values:** &#x60;Complete&#x60;, &#x60;Cancel&#x60;. Both values result in recording a check-out.              &#x60;Complete&#x60; means that the technician has finished the activity. &#x60;Cancel&#x60; means the technician needs to pause the activity, for example, to have a break outside of the location. GPS coordinates are not required.              **Default value:** Complete. | [optional] 
**Resolution** | **string** | The comment entered when checking out. Usually describes what was done during the recorded time. Ignored for the Travel and custom types as well as when &#x60;ActionStatus&#x60; &#x3D; &#x60;Cancel&#x60;.              **Default value:** empty. | [optional] 
**UserId** | **int** | The user ID of the technician that is checking out. Use the same &#x60;UserId&#x60; for one pair of check-in and check-out records.              **Default value:** ID of the current user. | [optional] 
**TechsCount** | **int** | The number of technicians that are checking out.              **Default value:** 1. | [optional] 
**Latitude** | **double** | The latitude of the technician’s current position.              Required for the Repair and Travel type. Not required for custom types, for the Repair and Travel types when the [XML check-in/out permission](https://developer.servicechannel.com/guides/checkin/before-you-start/#xml-check-inout-permission) is enabled, and when &#x60;ActionStatus&#x60; &#x3D; &#x60;Cancel&#x60;. | 
**Longitude** | **double** | The longitude of the technician’s current position.              Required for the Repair and Travel type. Not required for custom types, for the Repair and Travel types when the [XML check-in/out permission](https://developer.servicechannel.com/guides/checkin/before-you-start/#xml-check-inout-permission) is enabled, and when &#x60;ActionStatus&#x60; &#x3D; &#x60;Cancel&#x60;. | 
**CheckOutTime** | **DateTime** | The date and time of the check-out. Either indicate in UTC or pass the current time and add the UTC offset.              You can pass this value only when the [XML check-in/out permission](https://developer.servicechannel.com/guides/checkin/before-you-start/#xml-check-inout-permission) is enabled.              **Default value:** current date and time. | [optional] 
**CheckoutAll** | **bool** |  | [optional] [default to false]
**Actor** | **string** | Optional, Actor | [optional] 
**SignatureAttachmentId** | **int** | Optional, SignatureAttachmentId              **Default value:** null | [optional] 
**UnableObtainSignatureNoteId** | **int** | Optional, UnableObtainSignatureNoteId              **Default value:** null | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

