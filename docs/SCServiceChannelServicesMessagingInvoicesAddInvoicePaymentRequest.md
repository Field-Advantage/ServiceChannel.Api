# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingInvoicesAddInvoicePaymentRequest
Object details to add payment to an invoice.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvoiceId** | **int** | Unique numeric invoice identifier. | [optional] 
**PaymentDate** | **DateTime** | Date and time when the specified invoice is paid. Cannot be prior to the invoice creation date. | [optional] 
**PaymentNumber** | **string** | Number provided by a user when adding a payment record. | [optional] 
**PaymentAmount** | **double** | Amount of the payment. Cannot exceed the total amount of the invoice. If it’s a credited invoice, a single payment is required with a minus before the payment amount. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

