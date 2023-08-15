# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingInvoicesInvoiceTravel
Information on the trip.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [optional] 
**InvoiceId** | **int** | Invoice identifier. | [optional] 
**Description** | **string** | Description of the trip. | [optional] 
**UnitType** | **byte[]** | Unit of measurement. | [optional] 
**UnitPrice** | **double** | Price per unit. | [optional] 
**Quantity** | **double** | Quantity. | [optional] 
**Amount** | **double** | The amount of the trip cost. The sum of all &#x60;Amount&#x60; parameters in the &#x60;Travels&#x60; array must equal &#x60;InvoiceAmountsDetails.TravelAmount&#x60;. | [optional] 
**IsOffShore** | **bool** | Type of the shore (&#x60;1&#x60; - Onshore, &#x60;2&#x60; - Offshore). | [optional] [default to false]
**ApprovalCodeGroup** | [**SCServiceChannelServicesMessagingInvoicesInvoiceApprovalCodeGroup**](SCServiceChannelServicesMessagingInvoicesInvoiceApprovalCodeGroup.md) |  | [optional] 
**IsNontaxableVATEU** | **bool** |  | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

