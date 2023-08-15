# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingWorkordersContractInfo
ContractInfo (composite object) - describes who, where and what will perform as well as the one who requested work

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SubscriberId** | **int** | Required for provider request (for subscriber request filled authomatically), must belong to existing subscriber | 
**LocationId** | **int** | Required if &#39;StoreId&#39; not passed, must belong to existing location for specified subscriber.              Can be Optional, if EquipmentId is supplied in the request, system picks LocationId of the location that equipment belongs to | 
**StoreId** | **string** | Optional, can be used instead of &#39;LocationId&#39;.              If &#39;LocationId&#39; not passed system will attempt to find location based on &#39;SubscriberId&#39; and &#39;StoreId&#39;              (&#39;StoreId&#39; is required in this case), it is possible that system won&#39;t be able to find location which results in error.              Many locations can have similar StoreId but LocationId is always unique | [optional] 
**ProviderId** | **int** | Optional (for provider request filled authomatically), if provided - must correspond to a valid provider that has contract              for specified Subscriber, Location and Trade.              If not specified the system will attempt to find default provider based on Location,               Trade and Equipment (if specified). It is possible that system won&#39;t be able to find provider which results in error | [optional] 
**TradeName** | **string** | Required, must be a valid trade for specified subscriber.              Can be Optional if EquipmentId is supplied in the request, system picks TradeName of the trade that equipment belongs to.              This definition is narrower then Category. For example if Category is \&quot;Maintenance\&quot; then TradeName will be \&quot;FLOOR MAINTENANCE\&quot; | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

