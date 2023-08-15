# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingInvoicesInvoiceNumberRequirement
Invoice number requirements object.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | ID of the regular expression pattern used to validate the numbers of invoices created manually. | [optional] 
**SubscriberId** | **int** | Unique ID of the subscriber whose invoice number requirements are returned. | [optional] 
**Pattern** | **string** | Regular expression pattern used to validate the numbers of invoices created manually.&lt;br /&gt;A value is returned even if the selected &#x60;RestrictionType&#x60; is &#x60;0&#x60; — *None*. In this case, it’s the last pattern entered in the field. | [optional] 
**Comment** | **string** | Comment on the invoice number format displayed to a provider user in a tooltip when they try to submit an invoice whose number does not meet the specified restrictions. Invoice numbers are validated by the regular expression pattern specified in &#x60;Pattern&#x60;.&lt;br /&gt;A value is returned even if the selected &#x60;RestrictionType&#x60; is &#x60;0&#x60; — *None*. In this case, it’s the last comment entered in the field. | [optional] 
**RestrictionType** | **string** | Selected restriction for the numbers of invoices created manually. See &#x60;RestrictionTypesSelect&#x60; to identify which number (&#x60;Value&#x60;) corresponds to which restriction type. | [optional] 
**AutoGenerationType** | **string** | Selected rule for the numbers of invoices generated automatically. See &#x60;AutoGenerationTypesSelect&#x60; to identify which number (&#x60;Value&#x60;) corresponds to which rule. | [optional] 
**CreatedDate** | **DateTime** | Date and time when the invoice number requirements were created. | [optional] 
**UpdatedDate** | **DateTime** | Date and time when the invoice number requirements were last updated. | [optional] 
**CreatedByUserId** | **int** | Unique ID of the subscriber admin user who created the invoice number requirements. | [optional] 
**UpdatedByUserId** | **int** | Unique ID of the subscriber admin user who last updated the invoice number requirements. | [optional] 
**CreatedByUser** | **string** | Username of the subscriber admin who created the invoice number requirements. | [optional] 
**UpdatedByUser** | **string** | Username of the subscriber admin who last updated the invoice number requirements. The username appears in the **Invoice Number** section next to **Last modified**. | [optional] 
**ReuseInvoiceNumber** | **byte[]** | Reuse invoice number | [optional] 
**IsNew** | **bool** | Defines whether a default restriction pattern is used. | [optional] [readonly] [default to false]
**CreatedDateString** | **string** | Date when the invoice number requirements were created. | [optional] [readonly] 
**UpdatedDateString** | **string** | Date when the invoice number requirements were last updated. The date appears in the **Invoice Number** section next to **Last modified**. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

