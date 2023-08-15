# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingInvoicesAddInvoicePaymentResponse
Object details of the added payment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaymentDate** | **DateTime** | Date and time when the specified invoice is paid. | [optional] 
**PaymentId** | **int** | Unique numeric invoice payment ID. | [optional] 
**Error** | [**SCServiceChannelServicesMessagingInvoicesResponseError**](SCServiceChannelServicesMessagingInvoicesResponseError.md) |  | [optional] 
**InvoiceId** | **int** | Unique numeric invoice identifier. | [optional] 
**PaymentNumber** | **string** | Number provided by a user when adding a payment record. | [optional] 
**PaymentAmount** | **double** | Amount of the payment. Cannot exceed the total amount of the invoice. If it’s a credited invoice, a single payment is required with a minus before the payment amount. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

