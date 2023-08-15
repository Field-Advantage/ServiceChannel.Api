# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingDashboardSettingsSetupNoteResponse
Settings for Dashboard Notes

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SetupId** | **int** | Store Dashboard Setup ID. | [optional] 
**AllowAddingNotes** | **bool** | Enable / disable an ability to add workorder notes. | [optional] [default to false]
**AllowAddingNotesForCompletedWorkorders** | **bool** | Enable / disable an ability to add notes for workorders with status \&quot;completed\&quot;. | [optional] [default to false]
**MaskMoney** | **bool** | Parse a work order description and a note text in order to mask money. | [optional] [default to false]
**MaskPhone** | **bool** | Parse a work order description and a note text in order to mask phone numbers. | [optional] [default to false]
**MaskEmail** | **bool** | Parse a work order description and a note text in order to mask email. | [optional] [default to false]
**ShowProviderRecipients** | **bool** | Show provider recipients as wo note recipients. | [optional] [default to false]
**ShowSubscriberRecipients** | **bool** | Show subscriber recipients as wo note recipients. | [optional] [default to false]
**ShowPublicUserEmailsOnly** | **bool** | Show only users with public emails as wo note recipients. | [optional] [default to false]
**ShowUniversalRecipients** | **bool** | Show universal users as wo note recipients. | [optional] [default to false]
**LocationNotesAsRecipients** | **string** | Show emails from location notes as wo note recipients. | [optional] 
**AutoCopyContractorNotes** | **bool** | Specify custom addressees to show as wo note recipients. | [optional] [default to false]
**CustomNoteRecipients** | **string** | Specify custom addressees to show as wo note recipients. | [optional] 
**Statuses** | **List&lt;string&gt;** |  | [optional] 
**DisableNotes** | **bool** |  | [optional] [default to false]
**NoteEmails** | **List&lt;string&gt;** | Get addresses without dublicates. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

