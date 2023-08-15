# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingSiteAuditAuditReportExternal
The site audit report object. Depending on the features enabled for your company, the object structure may differ from the example below.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TemplateTypeName** | **string** | The site audit type. | [optional] 
**AuditId** | **int** | The numeric identifier of the site audit report. | [optional] 
**StoreId** | **string** | The internal identifier of the subscriber’s property. | [optional] 
**LocationName** | **string** | The name of the subscriber’s property. | [optional] 
**Region** | **string** | The region where the property is located. | [optional] 
**District** | **string** | The district where the property is located. | [optional] 
**AreaName** | **string** | The name of the audited area within the location. | [optional] 
**CheckListName** | **string** | The name of the checklist. | [optional] 
**CheckListItemName** | **string** | The name of the checklist item inspected by the auditor. | [optional] 
**CheckListItemDescription** | **string** | Detailed instructions for the auditor on how to check or rate the checklist item. | [optional] 
**Status** | **string** | This field is obsolete. Use field \&quot;Score\&quot; with \&quot;PassThreshold\&quot; and \&quot;RatingSystem\&quot; fields  please. | [optional] 
**Score** | **int** | The score that the auditor gave on the checklist item | [optional] 
**PassThreshold** | **int** | Pass threshold | [optional] 
**RatingSystem** | **string** | Rating system | [optional] 
**CheckListItemQuantity** | **string** | The quantity of the checklist item or its cost in dollars depending on the &#x60;Unit&#x60;. | [optional] 
**Unit** | **string** | The unit of measure of the checklist item: &#x60;Quantity&#x60; or &#x60;Dollars&#x60;. | [optional] 
**CheckListDate** | **DateTime** | The date and time when the auditor completed the audit of the checklist item. | [optional] 
**TimeOffset** | **int** | The UTC offset, or the difference in hours from the UTC time. | [optional] 
**UserName** | **string** | The username of the auditor who uploaded the completed audit. | [optional] 
**CheckListItemId** | **int** | The numeric identifier of the checklist item. | [optional] 
**AuditStartDate** | **DateTime** | The date and time when the auditor started the site audit. | [optional] 
**AuditFinishDate** | **DateTime** | The date and time when the auditor completed the site audit. | [optional] 
**AuditIssues** | [**List&lt;SCServiceChannelServicesMessagingSiteAuditAuditReportIssueExternal&gt;**](SCServiceChannelServicesMessagingSiteAuditAuditReportIssueExternal.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

