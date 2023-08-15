# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingSiteAuditAuditReportIssueExternal
The details of issues created by the auditor for the inspected checklist item. Issues are also known as action items.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IssueType** | **string** | The type of the action item, either &#x60;WO&#x60; or &#x60;Comment&#x60;. | [optional] 
**IssueDescription** | **string** | &#x60;Comment type&#x60;: auditor&#39;s comment added to the action item or its attachment. &#x60;WO type&#x60;: work order description that includes the area, problem type, asset, problem, and auditor’s description of the problem. | [optional] 
**AttachmentPaths** | **List&lt;string&gt;** | The paths to the attachments added to the checklist item. | [optional] 
**IssueId** | **int** | &#x60;Comment type&#x60;: numeric identifier of the action item. &#x60;WO type&#x60;: numeric identifier of the work order, also known as WO tracking number. | [optional] 
**WorkOrderPriority** | **string** | The name of the work order priority if the action item belongs to the WO type. | [optional] 
**Date** | **DateTime** | The date and time when the auditor created the action item. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

