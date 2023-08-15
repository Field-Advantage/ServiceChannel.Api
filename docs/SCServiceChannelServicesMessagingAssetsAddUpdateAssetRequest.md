# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingAssetsAddUpdateAssetRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OriginalTagId** | **string** | Tag Id of an existing asset. If is empty, it means a new Asset should be created | [optional] 
**NewTagId** | **string** | In case of asset update it should be a new Tag Id value              In case of asset creation it should be Tag ID of created asset | 
**LocationNoteHeaderName** | **string** |  | [optional] 
**LocationNoteHeaderValue** | **string** |  | 
**BrandId** | **int** |  | 
**BrandName** | **string** |  | 
**AssetTypeId** | **int** |  | 
**ApplyEmptyFields** | **bool** |  | [optional] [default to false]
**Warranty** | [**SCServiceChannelServicesMessagingAssetsWarrantyInfo**](SCServiceChannelServicesMessagingAssetsWarrantyInfo.md) |  | [optional] 
**CustomAttributes** | [**List&lt;SCServiceChannelServicesMessagingEquipmentsEquipmentAttributeDescription&gt;**](SCServiceChannelServicesMessagingEquipmentsEquipmentAttributeDescription.md) |  | [optional] 
**ModelNo** | **string** |  | [optional] 
**SerialNo** | **string** |  | [optional] 
**Area** | **string** |  | [optional] 
**WorkOrderArea** | **string** |  | [optional] 
**InstallDateStr** | **string** |  | [optional] 
**PurchaseDateStr** | **string** |  | [optional] 
**ManufacturedDateStr** | **string** |  | [optional] 
**EnergyEfficiency** | **string** |  | [optional] 
**Capacity** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**AssetTag** | **string** |  | [optional] 
**UsesRefrigerant** | **int** |  | [optional] 
**TradeId** | **int** |  | [optional] 
**LifeExpectancy** | **int** |  | [optional] 
**LeasePeriod** | **int** |  | [optional] 
**Condition** | **int** |  | [optional] 
**ParentId** | **int** |  | [optional] 
**Currency** | **int** |  | [optional] 
**OriginalValue** | **double** |  | [optional] 
**ClearAssetTag** | **bool** |  | [optional] [default to false]
**IsInspection** | **bool** |  | [optional] [default to false]
**ApplyCustom** | **bool** |  | [optional] [default to false]
**HasLeakDetector** | **bool** |  | [optional] [default to false]
**Active** | **bool** |  | [optional] [default to false]
**IsLeased** | **bool** |  | [optional] [default to false]
**HasComponents** | **bool** |  | [optional] [default to false]
**HasCircuits** | **bool** |  | [optional] [default to false]
**IsCarbReporting** | **bool** |  | [optional] [default to false]
**AssetUpdatesStatus** | **byte[]** |  | [optional] 
**ProcessDuplicatedAssetTag** | **bool** |  | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

