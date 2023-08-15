# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingInvoicesNumberRequirementsModel
Invoice number requirements object.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AutoGenerationTypesSelect** | [**List&lt;SCServiceChannelServicesMessagingInvoicesSelectItem&gt;**](SCServiceChannelServicesMessagingInvoicesSelectItem.md) | A list of options in the \&quot;Generation uniqueness rule\&quot; drop-down list a subscriber admin can choose from when configuring invoice number rules for automatically generated invoices. | [optional] 
**RestrictionTypesSelect** | [**List&lt;SCServiceChannelServicesMessagingInvoicesSelectItem&gt;**](SCServiceChannelServicesMessagingInvoicesSelectItem.md) | A list of options in the \&quot;Restrictions\&quot; drop-down list a subscriber admin can choose from when configuring invoice number restrictions for manually created invoices. | [optional] 
**ReuseInvoiceNumbersSelect** | [**List&lt;SCServiceChannelServicesMessagingInvoicesSelectItem&gt;**](SCServiceChannelServicesMessagingInvoicesSelectItem.md) | A list of options in the \&quot;ReuseInvoiceNumber\&quot; drop-down list a subscriber admin can choose from when configuring invoice number. | [optional] 
**InvoiceNumberRequirement** | [**SCServiceChannelServicesMessagingInvoicesInvoiceNumberRequirement**](SCServiceChannelServicesMessagingInvoicesInvoiceNumberRequirement.md) |  | [optional] 
**DefaultRestrictionComments** | **Dictionary&lt;string, string&gt;** | A list of default explanatory comments on the invoice number format for the corresponding restrictions. A comment is displayed to a provider user in a tooltip when they try to submit an invoice whose number does not meet the restrictions specified by their subscriber. See &#x60;RestrictionTypesSelect&#x60; to identify which number (&#x60;Value&#x60;) corresponds to which restriction type: &#x60;2&#x60; — *Digits Only*, &#x60;3&#x60; — *Alphanumeric Only*. | [optional] 
**DefaultRestrictionPatterns** | **Dictionary&lt;string, string&gt;** | A list of default regular expressions that define search patterns used to validate the number format of invoices created manually. See &#x60;RestrictionTypesSelect&#x60; to identify which number (&#x60;Value&#x60;) corresponds to which restriction type: &#x60;2&#x60; — *Digits Only*, &#x60;3&#x60; — *Alphanumeric Only*. | [optional] 
**Resources** | [**SCServiceChannelServicesMessagingInvoicesLocalizations**](SCServiceChannelServicesMessagingInvoicesLocalizations.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

