# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingLocationGetLocationsSimpleRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique location identifier. | [optional] 
**StoreIdentifier** | **string** | Alphanumeric location identifier in the client’s system. Assigned by and unique per subscriber. | [optional] 
**Name** | **string** | Location name. | [optional] 
**LocationId** | [**List&lt;SCServiceChannelServicesMessagingFilterItemSystemInt32&gt;**](SCServiceChannelServicesMessagingFilterItemSystemInt32.md) | The unique store ID in the ServiceClick system | [optional] [readonly] 
**LocationName** | [**List&lt;SCServiceChannelServicesMessagingFilterItemSystemString&gt;**](SCServiceChannelServicesMessagingFilterItemSystemString.md) | Name of the location | [optional] [readonly] 
**StoreId** | [**List&lt;SCServiceChannelServicesMessagingFilterItemSystemString&gt;**](SCServiceChannelServicesMessagingFilterItemSystemString.md) |  | [optional] [readonly] 
**Sort** | **string** | Sort resources by the specified property in the response. | [optional] 
**Page** | **int** | Results page number. | [optional] 
**IsPageSizeDefault** | **bool** |  | [optional] [readonly] [default to false]
**PageSize** | **int** | Number of objects on the results page. The default and maximum per page is 50. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

