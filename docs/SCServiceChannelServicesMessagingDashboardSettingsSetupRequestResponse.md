# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingDashboardSettingsSetupRequestResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SetupId** | **int** | Store Dashboard Setup ID. | [optional] 
**EnableRequestWizard** | **bool** | This flag enables/disables request wizard for the dashboard. | [optional] [default to false]
**ShowPrivateStoreNotes** | **bool** | Show/hide private store notes in the &#39;location notes&#39; field on the first step of the service request wizard page. | [optional] [default to false]
**ShowProviderPhoneNumber** | **bool** | Show/hide provider phone number on the confirmation step after an issue has been submitted. | [optional] [default to false]
**ShowLastServiceCall** | **bool** | Show last service call and last description in the body of alert email. | [optional] [default to false]
**SetOriginalVendorForRecalls** | **bool** | This option controls whether original vendor is assigned to the work order in case of a recall. | [optional] [default to false]
**NteToZeroForRecalls** | **bool** | Set NTE to zero if a new service request is marked as a recall. | [optional] [default to false]
**SendAlertToFM** | **bool** | This flag controls whether service request email will be sent to the facility managers or not. | [optional] [default to false]
**TurnOffDescription** | **bool** | Show/hide problem description field. | [optional] [default to false]
**DaysOfHistoryToDisplay** | **int** | How many days of work order history to display on the dublicates warning report. | [optional] 
**ShowStoreWarrantyStr** | **string** | There are three possible options: 1) &#39;none&#39; hides a StoreWarrantyMessage on the first step of the Request Wizard;              2) &#39;show&#39; shows a StoreWarrantyMessage on the first step of the Request Wizard;              3) &#39;stop&#39; shows a StoreWarrantyMessage without a possibility to move to the next step. | [optional] 
**StoreWarrantyMessage** | **string** | A store warranty message to show on the first step of the request wizard page. | [optional] 
**ConfirmationMessage** | **string** | This message is shown on the confirmation page after the user submits their request. | [optional] 
**ProviderNotFoundMessage** | **string** | An error message to show when provider is not found for the specified issue choice. | [optional] 
**EnableEquipment** | **bool** | Show equipment | [optional] [default to false]
**DuplicateFilters** | **List&lt;string&gt;** |  | [optional] 
**ExcludedCategoriesOpenDup** | **List&lt;string&gt;** |  | [optional] 
**ExcludedCategoriesClosedDup** | **List&lt;string&gt;** |  | [optional] 
**ExcludedStatuses** | **List&lt;string&gt;** |  | [optional] 
**ExcludedTradesOpenDup** | **List&lt;string&gt;** |  | [optional] 
**EnableEquipmentReplacementFlag** | **bool** |  | [optional] [default to false]
**EnableRequestWizardMobile** | **bool** | This flag enables/disables request wizard for the SC Mobile. | [optional] [default to false]
**EnableLocationNotes** | **bool** |  | [optional] [default to false]
**AlwaysShowLocationNotes** | **bool** |  | [optional] [default to false]
**SkipTroubleshootingStep** | **bool** |  | [optional] [default to false]
**HidePriority** | **bool** |  | [optional] [default to false]
**EnableIssueListKeywordSearch** | **bool** | This flag enables/disables the keyword search functionality on the request wizard.              When enabled, users can type keywords to more quickly identify issue list selections. | [optional] [default to false]
**HideGPSRadius** | **bool** |  | [optional] [default to false]
**AssetFirstWorkOrderCreation** | **bool** | Enables asset-first approach for work order creation. | [optional] [default to false]
**EnableEquipmentReplacement** | **bool** |  | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

