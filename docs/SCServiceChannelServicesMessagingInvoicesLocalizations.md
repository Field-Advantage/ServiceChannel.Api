# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingInvoicesLocalizations
The object for UI labels that appear in the \"Invoice Number\" section on the \"General\" tab of the \"Admin - Invoices\" page in Service Automation. Note that only subscriber users with the Super Admin secondary role can access this page.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvoiceNumberLabel** | **string** | Label for the \&quot;Invoice Number\&quot; section name. | [optional] 
**LastModifiedLabel** | **string** | The \&quot;Last modified\&quot; label for details about who last updated the invoice requirements and when. | [optional] 
**RestrictionLabel** | **string** | Label for the \&quot;Restrictions\&quot; drop-down list where a subscriber admin selects which restriction should apply to the numbers of manually created invoices. | [optional] 
**GenerationRuleLabel** | **string** | Label for the \&quot;Generation uniqueness rule\&quot; drop-down list where a subscriber admin selects which rule should apply to the numbers of automatically generated invoices. | [optional] 
**HelpStringLabel** | **string** | The \&quot;Help string (to show vendors)\&quot; label for the field containing comments shown to a provider when they try to submit an invoice whose number does not meet the restrictions specified by a subscriber. | [optional] 
**PatternPlaceHolder** | **string** | A placeholder text shown in the field where a subscriber admin enters a regular expression pattern to set restrictions for the numbers of manually created invoices. | [optional] 
**CommentPlaceHolder** | **string** | A placeholder text shown in the field where a subscriber admin enters a comment for the restriction applied to the numbers of manually created invoices based on the selected restriction type. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

