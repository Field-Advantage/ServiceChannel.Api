# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingInvoicesInvoiceLabor
Information on labor. Add a separate object for each worker. When two or more workers have the same `SkillLevel`,`LaborType`, and `HourlyRate`, use one object and specify `NumOfTech`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [optional] 
**InvoiceId** | **int** | Invoice identifier. | [optional] 
**SkillLevel** | **byte[]** | The skill level of a worker. Valid values: &#x60;1&#x60; - Supervisor, &#x60;2&#x60; - Technician, &#x60;3&#x60; - Helper. | [optional] 
**LaborType** | **byte[]** | The type of the pay rate. Valid values: &#x60;1&#x60; - Regular, &#x60;2&#x60; - Overtime, &#x60;3&#x60; - Double time. | [optional] 
**NumOfTech** | **byte[]** | Number of workers. | [optional] 
**HourlyRate** | **double** | Worker hourly rate. | [optional] 
**Hours** | **double** | Total hours the worker spent to complete the work order. | [optional] 
**Amount** | **double** | The amount of the labor charge. The sum of all &#x60;Amount&#x60; parameters in the &#x60;Labors&#x60; array must equal &#x60;InvoiceAmountsDetails.LaborAmount&#x60;. | [optional] 
**IsOffShore** | **bool** | Type of the shore (&#x60;1&#x60; - Onshore, &#x60;2&#x60; - Offshore). | [optional] [default to false]
**ServiceType** | **byte[]** | Type of the service (&#x60;1&#x60; - Design Engineering, Architecture, Technical Service, &#x60;2&#x60; - Installation and Supervision, &#x60;3&#x60; - Survey and Troubleshooting). | [optional] 
**CityPerformed** | **string** | City where services are performed. | [optional] 
**RateDiscrepancyReason** | **string** | Rate discrepancy reason. | [optional] 
**AgreedRate** | **double** | Agreed rate. | [optional] 
**ApprovalCodeGroup** | [**SCServiceChannelServicesMessagingInvoicesInvoiceApprovalCodeGroup**](SCServiceChannelServicesMessagingInvoicesInvoiceApprovalCodeGroup.md) |  | [optional] 
**IsRateDiscrepancy** | **bool** |  | [optional] [readonly] [default to false]
**IsNontaxableVATEU** | **bool** |  | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

