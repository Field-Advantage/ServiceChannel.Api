# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingWorkordersCreateWoNoteRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Note** | **string** | Required, Note text | 
**MailedTo** | **string** | E-mail address(es) | [optional] 
**ActionRequired** | **bool** | Action requred flag | [optional] [default to false]
**ScheduledDate** | **DateTime** | Scheduled Date and Time | [optional] 
**FollowUpDate** | **DateTime** |  | [optional] 
**IsFollowUpDateChanged** | **bool** |  | [optional] [default to false]
**AttachmentsIds** | **List&lt;int&gt;** |  | [optional] 
**Visibility** | **int** | Defines which parties can view the note. Visibility also works in Universal Connector where there are three primary parties: Subscriber, External Subscriber, and Provider.               Possible values:              &#x60;0&#x60; — Visible to everyone (Subscriber, External Subscriber, Provider),              &#x60;1&#x60; — Not visible to External Subscriber. Visible to Subscriber and Provider,              &#x60;2&#x60; — Not visible to Provider. Visible to Subscriber and External Subscriber.              &#x60;3&#x60; — Visible to Subscriber only. | [optional] 
**Actor** | **string** | Actor | [optional] 
**NotifyFollowers** | **bool** | If true email alert will be sent to WO Followers | [optional] [default to false]
**DoNotSendEmail** | **bool** |  | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

