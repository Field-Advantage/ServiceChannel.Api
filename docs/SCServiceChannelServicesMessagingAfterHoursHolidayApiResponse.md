# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingAfterHoursHolidayApiResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HolidayName** | **string** | Holiday name. | [optional] 
**StartDate** | **DateTime** | Holiday date. | [optional] 
**OpenTime** | **string** | Location opening hours. | [optional] 
**CloseTime** | **string** | Location closing hours. | [optional] 
**ClosedAllDay** | **bool** | Defines whether the location is closed on the specified day. | [optional] [default to false]
**Frequency** | **string** | Defines how often the holiday occurs. Valid values: Singular, Weekly, Monthly, Yearly. | [optional] 
**RepeatEvery** | **byte[]** | Defines intervals for the holiday to repeat. Valid values: a number from 1 to 60. Used in combination with the &#x60;Frequency&#x60; values: Yearly, Monthly, Weekly. | [optional] 
**RepeatBy** | **string** | Defines whether the holiday repeats on days of the month or week. Valid values: DaysOfWeek, DaysOfMonth. | [optional] 
**RepeatOnDays** | **List&lt;string&gt;** | Days when the holiday occurs. Used in combination with the &#x60;Frequency&#x60; value ‘Weekly’. | [optional] 
**RepeatOnMonths** | **List&lt;string&gt;** | Months when the holiday occurs. Used in combination with the &#x60;Frequency&#x60; value ‘Yearly’. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

