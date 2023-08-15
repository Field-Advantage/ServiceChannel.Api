# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingNotesNote

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | UID of work order note, can be null | [optional] 
**Number** | **int** | Note number | [optional] 
**NoteData** | **string** | Note data | [optional] 
**DateCreated** | **DateTime** | Date when Note was created | [optional] 
**ScheduledDate** | **DateTime** |  | [optional] 
**FollowUpDate** | **DateTime** |  | [optional] 
**ActionRequired** | **bool** | Action Required | [optional] [default to false]
**MailedTo** | **string** | Email | [optional] 
**CreatedBy** | **string** | Describes who created the Note | [optional] 
**CompanyName** | **string** | Subscriber or Provider short name | [optional] 
**Attachments** | [**List&lt;SCServiceChannelServicesMessagingAttachmentsAttachment&gt;**](SCServiceChannelServicesMessagingAttachmentsAttachment.md) | Collection of note attachments | [optional] 
**Visibility** | **byte[]** |  | [optional] 
**NoteType** | **string** |  | [optional] 
**IsAttachmentNote** | **bool** |  | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

