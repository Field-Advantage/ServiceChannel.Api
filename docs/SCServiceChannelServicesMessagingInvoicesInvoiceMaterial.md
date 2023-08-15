# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingInvoicesInvoiceMaterial
Information on the materials used. Add a separate object for each material.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [optional] 
**InvoiceId** | **int** | Invoice identifier. | [optional] 
**Description** | **string** | Name or description of the material. Length limit is 100 symbols. | [optional] 
**PartNum** | **string** | Part, serial, or manufacturer number of the material. Length limit is 100 symbols. | [optional] 
**UnitType** | **byte[]** | Unit of measurement. Valid values: 1 — Each; 2 — Box; 3 — Feet; 4 — Sqft; 5 — Lbs; 6 — Gal; 7 — Oz. Default value: 1. | [optional] 
**UnitPrice** | **double** | Price per unit. | [optional] 
**PartName** | **string** | Part name. | [optional] 
**MarkUpPercent** | **double** | Markup percent. | [optional] 
**AgreedMarkUpPercent** | **double** | Agreed markup percent. | [optional] 
**MarkUpDiscrepancyReason** | **string** | Mark up discrepancy reason. | [optional] 
**AgreedPartPrice** | **double** | Agreed part price. | [optional] 
**Quantity** | **double** | Quantity of the material. | [optional] 
**Amount** | **double** | The amount of the material cost. The sum of all &#x60;Amount&#x60; parameters in the &#x60;Materials&#x60; array must equal &#x60;InvoiceAmountsDetails.MaterialAmount&#x60;. | [optional] 
**ApprovalCodeGroup** | [**SCServiceChannelServicesMessagingInvoicesInvoiceApprovalCodeGroup**](SCServiceChannelServicesMessagingInvoicesInvoiceApprovalCodeGroup.md) |  | [optional] 
**IsMarkUpDiscrepancy** | **bool** | Markup discrepancy. | [optional] [default to false]
**IsPartPriceDiscrepancy** | **bool** | Part price discrepancy. | [optional] [default to false]
**PriceDiscrepancyReason** | **string** | Price discrepancy reason. | [optional] 
**IsRateDiscrepancy** | **bool** |  | [optional] [readonly] [default to false]
**IsNontaxableVATEU** | **bool** |  | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

