# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingInvoicesSelectItem
Object containing options a subscriber admin can choose from when configuring restrictions and rules for invoice numbers.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | **int** | Number indicating the order of the option in the corresponding drop-down list for configuring invoice number restrictions and rules. The count starts from 0.&lt;br /&gt; • Check &#x60;RestrictionTypesSelect&#x60; to find out which options are available in the \&quot;Restrictions\&quot; drop-down list where a subscriber admin can set up number restrictions for manually created invoices.&lt;br /&gt; • See &#x60;AutoGenerationTypesSelect&#x60; for options in the \&quot;Generation uniqueness rule\&quot; drop-down list used for configuring number generation rules for automatically created invoices. | [optional] 
**Name** | **string** | Name of the option in the corresponding drop-down list — \&quot;Restrictions\&quot; or \&quot;Generation uniqueness rule\&quot;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

