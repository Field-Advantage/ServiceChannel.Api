# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingInvoicesCreateInvoiceRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvoiceNumber** | **string** | Invoice identifier. Must be unique for each invoice. | 
**InvoiceDate** | **DateTime** | Date and time when the invoice was issued. | [optional] 
**InvoiceDateDTO** | **DateTime** | Date and time when the invoice was issued. Indicated with the UTC offset. | [optional] 
**WoIdentifier** | **string** |  | 
**InvoiceTax** | **double** | The amount of the tax. | [optional] 
**PostedTaxRate** | **float** |  | [optional] 
**NonTaxableLabor** | **int** |  | [optional] 
**NonTaxableTravel** | **int** |  | [optional] 
**NonTaxableMaterial** | **int** |  | [optional] 
**NonTaxableFreight** | **int** |  | [optional] 
**NonTaxableOther** | **int** |  | [optional] 
**WithMismatchedRates** | **bool** |  | [optional] [default to false]
**InvoiceTotal** | **double** |  | [optional] 
**InvoiceText** | **string** | Detailed description of the work completed. Subscriber can change this field to &#x60;required&#x60;. | [optional] 
**InvoiceAmountsDetails** | [**SCServiceChannelServicesMessagingInvoicesInvoiceAmountsDetails**](SCServiceChannelServicesMessagingInvoicesInvoiceAmountsDetails.md) |  | [optional] 
**InvoiceTaxesDetails** | [**SCServiceChannelServicesMessagingInvoicesInvoiceTaxesDetails**](SCServiceChannelServicesMessagingInvoicesInvoiceTaxesDetails.md) |  | [optional] 
**Tax2Details** | [**SCServiceChannelServicesMessagingInvoicesTax2Details**](SCServiceChannelServicesMessagingInvoicesTax2Details.md) |  | [optional] 
**TaxIncluded** | [**SCServiceChannelServicesMessagingInvoicesCreatingInvoiceTaxIncludedRequest**](SCServiceChannelServicesMessagingInvoicesCreatingInvoiceTaxIncludedRequest.md) |  | [optional] 
**Labors** | [**List&lt;SCServiceChannelServicesMessagingInvoicesInvoiceLabor&gt;**](SCServiceChannelServicesMessagingInvoicesInvoiceLabor.md) | Get or set the labors description (Subscriber can change this field to required). | [optional] 
**Materials** | [**List&lt;SCServiceChannelServicesMessagingInvoicesInvoiceMaterial&gt;**](SCServiceChannelServicesMessagingInvoicesInvoiceMaterial.md) | Get or set the materials description (Subscriber can change this field to required). | [optional] 
**Travels** | [**List&lt;SCServiceChannelServicesMessagingInvoicesInvoiceTravel&gt;**](SCServiceChannelServicesMessagingInvoicesInvoiceTravel.md) | Get or set the materials description (Subscriber can change this field to required). | [optional] 
**Others** | [**List&lt;SCServiceChannelServicesMessagingInvoicesInvoiceOther&gt;**](SCServiceChannelServicesMessagingInvoicesInvoiceOther.md) | Get or set the others description (Subscriber can change this field to required). | [optional] 
**ExplainDispute** | **string** | Gets or sets the explain dispute. | [optional] 
**SubmitDisputed** | **bool** |  | [optional] [default to false]
**VendorId** | **int** | Gets or sets vendor payee identifier. | [optional] 
**Terms** | **string** | Invoice Terms | [optional] 
**Attachments** | [**List&lt;SCAddInvoiceAttachmentRequest&gt;**](SCAddInvoiceAttachmentRequest.md) | Optional | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

