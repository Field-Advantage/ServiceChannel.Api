# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingAssetsUpdateAssetRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The unique Equipment ID in Service Click system | [optional] 
**NeedUpdateParentId** | **bool** | Flag Need Update ParenId | [optional] [default to false]
**ProcessDuplicatedAssetTag** | **bool** |  | [optional] [default to false]
**Tag** | **string** | Required, Should be unique for subscriber | 
**ParentAssetTagId** | **string** |  | [optional] 
**Manufacturer** | **string** | Required, Must be existing manufacturer name | 
**ModelNo** | **string** | Model Number of asset | [optional] 
**SerialNo** | **string** | Serial Number of asset | [optional] 
**LocationId** | **int** | ID of location, Ignored. Use StoreId to setup Location | [optional] 
**Area** | **string** |  | [optional] 
**WorkOrderArea** | **string** |  | [optional] 
**StoreId** | **string** | Required, Should be unique for subscriber | 
**Trade** | **string** | Trade of asset. Examples: HVAC, DOORS, ELECTRICAL | [optional] 
**TradeId** | **int** |  | [optional] 
**Type** | **string** | Required, Type of asset. Examples: Refrigerator, Computer Monitor and etc | 
**AssetTypeId** | **int** |  | [optional] 
**BrandId** | **int** |  | [optional] 
**Active** | **bool** |  | [optional] [default to false]
**InstallDate** | **string** | If not specified the current date is taken | [optional] 
**PurchaseDate** | **string** | If not specified the current date is taken | [optional] 
**ManufacturedDate** | **string** | If not specified the current date is taken | [optional] 
**Warranty** | [**SCServiceChannelServicesMessagingAssetsWarrantyInfo**](SCServiceChannelServicesMessagingAssetsWarrantyInfo.md) |  | [optional] 
**UsesRefrigerant** | **int** | Refrigerant Usage options | [optional] 
**IsLeased** | **bool** | Is Leased | [optional] [default to false]
**LifeExpectancy** | **int** | Life Expectancy | [optional] 
**OriginalValue** | **double** | Original Value | [optional] 
**LeaseDate** | **string** | Lease Date | [optional] 
**LeasePeriod** | **int** | Lease Period | [optional] 
**Condition** | **int** |  | [optional] 
**EnergyEfficiency** | **string** |  | [optional] 
**Capacity** | **string** |  | [optional] 
**HasLeakDetector** | **bool** | Has Leak Detector | [optional] [default to false]
**ParentId** | **int** | Parent Id | [optional] 
**Description** | **string** |  | [optional] 
**HasComponents** | **bool** |  | [optional] [default to false]
**HasCircuits** | **bool** |  | [optional] [default to false]
**ClearAssetTag** | **bool** |  | [optional] [default to false]
**AssetTag** | **string** |  | [optional] 
**IsInspection** | **bool** |  | [optional] [default to false]
**IsCarbReporting** | **bool** |  | [optional] [default to false]
**ApplyCustom** | **bool** |  | [optional] [default to false]
**CustomAttributes** | [**List&lt;SCServiceChannelServicesMessagingEquipmentsEquipmentAttributeDescription&gt;**](SCServiceChannelServicesMessagingEquipmentsEquipmentAttributeDescription.md) |  | [optional] 
**AssetUpdatesStatus** | **byte[]** |  | [optional] 
**LocationNoteHeader** | **string** | Location Note Header | [optional] 
**LocationNoteValue** | **string** | Location Note Value | [optional] 
**Currency** | **int** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

