# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingWorkordersCreateWoRequest
CreateWoRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Number** | **string** | Work Order Number | [optional] 
**PurchaseNumber** | **string** | Purchase Order Number | [optional] 
**HasTruncatedDescription** | **bool** | Optional | [optional] [default to false]
**ContractInfo** | [**SCServiceChannelServicesMessagingWorkordersContractInfo**](SCServiceChannelServicesMessagingWorkordersContractInfo.md) |  | 
**Comment** | **string** | Optional, Gets or sets the comment. Describes comments in work order | [optional] 
**SetupId** | **int** | Optional Dashboard Id, UID of dashboard from which this work order was created              must be bigger then zero and belong to existing dashboard | [optional] 
**AssetId** | **int** | Optional Asset, UID of asset, that will be repaired/reinstalled              must be present and correspond to valid asset if system finds that asset exists for specified LocationId,              TradeName, IssueRequest.EquipmentType params and asset is required for issue choice specified by IssueRequest,              SubscriberId and SetupId params | [optional] 
**ReplaceAsset** | **bool** | Optional | [optional] [default to false]
**CallerName** | **string** | Optional, can be empty Caller Name. Name of the person/organization who created work order | [optional] 
**Category** | **string** | Required, not empty Category must be valid category for specified subscriber. Describes what type of work will be performed.              This definition is broader then TradeName.              For example if TradeName is \&quot;FLOOR MAINTENANCE\&quot; then Category will be \&quot;Maintenance\&quot; | 
**CategoryId** | **int** |  | [optional] 
**Priority** | **string** | Required, not empty Priority must be valid priority for specified subscriber. Describes work order priority.              For example \&quot;Normal\&quot;, \&quot;Emergency\&quot; | 
**Nte** | **double** | Required Nte value; optional only for users that have no access to change NTE. (decimal number (e.g. 1.00)) - describes maximum amount of money to be spent on work order.              Must not exceed max amount defined by Subscriber.              If you specify ExtendedInfo.Tax, ExtendedInfo.Tax2 and ExtendedInfo.Price then Nte must be equal to sum of those three params | [optional] 
**CallDate** | **string** | Required, date when work order was created. | 
**ScheduledDate** | **string** | Optional, calculated based on CallDate and Priority by default. Date when provider will come to perform work order.              Must be an actual date (i.e. not 1/1/1900 or 1/1/3001) + must be bigger then CallDate and smaller then ExpirationDate | [optional] 
**CompletedDate** | **string** | Optional, WorkDate when its not completed status. | [optional] 
**ProblemSource** | **string** | Optional, source from which the problem came from | [optional] 
**Description** | **string** | Required problem description, Must not be empty. Overall description of a problem (e.g. \&quot;Coffee machines are broken all over the place - please help!\&quot;) | 
**ProblemCode** | **string** | Required, describes problem similar to Description attribute, but its value is predefined in subscriber&#39;s [IssueList]. | 
**RecallWorkOrder** | **int** | Optional,  UID of recalled work order. Work order is set as &#39;recalled&#39; when subscriber isn&#39;t satisfied with work that was done by provider | [optional] 
**ServiceNowId** | **string** | Optional, Service Now Id | [optional] 
**CurrencyId** | **int** | Optional, UID of currency used to pay for work order. Defaul value is &#39;1&#39; which corresponds to USD.              Must be bigger then 0 and correspond to valid currency in dashboard which is found by SetupId param | [optional] 
**FollowupWorkOrder** | **int** | Optional, UID of work order that is created if problem cannot be fully solved in terms of original work order | [optional] 
**ApprovalCode** | **string** | Optional | [optional] 
**IssueRequestInfo** | [**SCServiceChannelServicesMessagingWorkordersCreateWoRequestIssueRequest**](SCServiceChannelServicesMessagingWorkordersCreateWoRequestIssueRequest.md) |  | [optional] 
**DispatchSettingsInfo** | [**SCServiceChannelServicesMessagingWorkordersCreateWoRequestDispatchSettings**](SCServiceChannelServicesMessagingWorkordersCreateWoRequestDispatchSettings.md) |  | [optional] 
**Status** | [**SCServiceChannelServicesMessagingWorkordersWorkorderStatus**](SCServiceChannelServicesMessagingWorkordersWorkorderStatus.md) |  | [optional] 
**ExtendedInfo** | [**SCServiceChannelServicesMessagingWorkordersCreateWoRequestExtendedRequestInfo**](SCServiceChannelServicesMessagingWorkordersCreateWoRequestExtendedRequestInfo.md) |  | [optional] 
**Attachments** | [**List&lt;SCServiceChannelServicesMessagingAttachmentsAddAttachmentRequest&gt;**](SCServiceChannelServicesMessagingAttachmentsAddAttachmentRequest.md) | Optional, at least one attachement must be present in list if system finds that attachments are required for issue choice specified by IssueRequest,              SubscriberId and SetupId params | [optional] 
**IgnoreAttachmentsRequiredFlag** | **bool** |  | [optional] [default to false]
**ApiRequest** | **bool** |  | [optional] [default to false]
**Materials** | [**List&lt;SCServiceChannelServicesMessagingWorkordersCreateWoRequestMaterial&gt;**](SCServiceChannelServicesMessagingWorkordersCreateWoRequestMaterial.md) | Optional | [optional] 
**MaterialsUsed** | [**List&lt;SCServiceChannelServicesMessagingRefrigerantTrackingAddWorkOrderPartRefrigerantItem&gt;**](SCServiceChannelServicesMessagingRefrigerantTrackingAddWorkOrderPartRefrigerantItem.md) | Optional | [optional] 
**AdditionalFields** | [**List&lt;SCServiceChannelServicesMessagingWorkordersCreateWoRequestAdditionalField&gt;**](SCServiceChannelServicesMessagingWorkordersCreateWoRequestAdditionalField.md) | Interactive troubleshooting additional fileds | [optional] 
**IssueListHeaderId** | **int** | Optional. Id in dash_IssueListHeader table | [optional] 
**ProposedNte** | **double** | Optional | [optional] 
**NotifyProvider** | **bool** | Optional | [optional] [default to false]
**IsDashboardRequest** | **bool** | Optional | [optional] [default to false]
**FloorPlansImagePath** | **string** | Optional | [optional] 
**ProjectId** | **int** | Optional. Project Id from Project Tracker | [optional] 
**WeatherTypeId** | **int** | Optional. Associate with a specific weather type | [optional] 
**LabelId** | **int** | Optional, Label Id | [optional] 
**AdditionalApprovalCodes** | **Dictionary&lt;string, string&gt;** | Additional Approval Codes | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

