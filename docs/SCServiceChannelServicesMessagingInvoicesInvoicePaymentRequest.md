# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingInvoicesInvoicePaymentRequest
Request object to add a payment to an invoice.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaymentDate** | **DateTime** | Date and time when the specified invoice is paid. Cannot be a past date. | [optional] 
**PaymentNumber** | **string** | Order number of payment for the invoice. | [optional] 
**PaymentAmount** | **double** | Amount you want to pay. Cannot exceed the invoice total amount. If it’s a credited invoice, a single payment is required with a minus before the payment amount. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

