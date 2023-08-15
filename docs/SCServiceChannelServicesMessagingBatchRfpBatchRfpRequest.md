# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingBatchRfpBatchRfpRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BatchCreateRfps** | [**List&lt;SCServiceChannelServicesMessagingBatchRfpBatchCreateRfp&gt;**](SCServiceChannelServicesMessagingBatchRfpBatchCreateRfp.md) | Required, BatchCreateRfp to create the batch of Rfp&#39;s | 
**CallbackUri** | **string** | Required, URL where callback method will post the result | 
**BatchName** | **string** | Optional Batch Name, project module&#39;s Name from which this Rfp was created | 
**BatchNumber** | **string** | Optional Batch Number, project module&#39;s GUID from which this Rfp was created | 
**BatchTemplateFileName** | **string** | Origin file name | 
**BatchTemplateRemotePath** | **string** | Path to blob | 
**Attachments** | [**List&lt;SCServiceChannelApiModelEntitiesBatchRfpAttachment&gt;**](SCServiceChannelApiModelEntitiesBatchRfpAttachment.md) | Optional, Attachments. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

