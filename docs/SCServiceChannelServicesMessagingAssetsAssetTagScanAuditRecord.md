# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingAssetsAssetTagScanAuditRecord
Holds information about scanned asset tags.  This class must be kept in sync with ContractorTools.BL.Models.AssetTagScanAuditRecord

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AssetID** | **int** | Asset/Equipment ID of asset whose tag was scanned | [optional] 
**TrackingNumber** | **int** | Tracking ID associated with work order | [optional] 
**WorkOrderID** | **string** | Work order number associated with this asset tag scan | [optional] 
**AssetTagStatus** | **string** | Asset tag validation status | [optional] 
**ManuallyEntered** | **bool** | Indicates whether or not asset tag was manually entered instead of being scanned | [optional] [default to false]
**AssetTagNotScannedReason** | **string** | Reason for asset tag not being scanned | [optional] 
**ValidationRequired** | **bool** | Indicates whether or not *this* asset needs its asset tag validated | [optional] [default to false]
**AssetValidated** | **bool** | The current validation status of *this* asset | [optional] [default to false]
**UnableToValidateReasonId** | **int** | Reason for asset tag not being validated | [optional] 
**OtherReason** | **string** | Custom reason for asset tag not being validated | [optional] 
**UnableToScanReasonId** | **int** | Reason for asset tag not being scanned | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

