# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingWorkordersWorkActivity
Work activity object.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The unique numeric identifier of the work activity. | [optional] 
**WorkOrderId** | **int** | The unique numeric identifier of the work order for which the work activity was reported. | [optional] 
**TimeIn** | **DateTime** | The date and time when the technician started work on the service request. | [optional] 
**TimeOut** | **DateTime** | The date and time when the technician finished work on the service request. | [optional] 
**IsTimeEdited** | **bool** | Indicates if the time of the labor performed was modified. | [optional] [default to false]
**User** | [**SCServiceChannelServicesMessagingUsersUserInfo**](SCServiceChannelServicesMessagingUsersUserInfo.md) |  | [optional] 
**CallerId** | **string** | Possible values:              a) The GPS coordinates of the location where the technician performed the most recent action — either check-in or check-out — via the ServiceChannel Provider mobile app.              b) The phone number of the technician from which they performed the most recent action — either check-in or check-out — using the IVR (Interactive Voice Response) system.              c) Null value if the work activity was entered manually. | [optional] 
**ResolutionCode** | **string** | The most recent status assigned to the work order by the technician. | [optional] 
**WorkType** | **string** | The type of activity performed: *Repair* or *Travel*. Other values may be returned if custom types are set up for the subscriber. | [optional] 
**HasCheckInInfo** | **bool** | Indicates if a check-in was performed for the work activity. | [optional] [default to false]
**HasCheckListResponse** | **bool** | Indicates if the technician answered checklist questions. | [optional] [default to false]
**TechsCount** | **int** | The number of technicians who performed the work. | [optional] 
**Name** | **string** | The technician performed the work. | [optional] 
**CreatedBy** | **int** | The user who created the labor. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

