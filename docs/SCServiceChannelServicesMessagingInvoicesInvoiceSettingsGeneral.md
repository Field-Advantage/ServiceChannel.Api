# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingInvoicesInvoiceSettingsGeneral
General invoice settings object.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DaysBeforePostingDate** | **int** | The number of days prior to the invoice posting date within which the invoice creation date can be set. Providers can not create invoices for a date in the past that is older than the specified number of days from the invoice posting date. | [optional] 
**MaxDaysAfterPostingDate** | **int** | The number of days after the invoice posting date within which the invoice creation date can be set. Providers can not generate invoices for a date in the future that is greater than the specified number of days from the invoice posting date. | [optional] 
**RequireResolutionText** | **bool** | Defines whether providers are required to enter a resolution when creating an invoice. | [optional] [default to false]
**RequireApprovalText** | **bool** | Defines whether subscriber’s employees are required to enter a comment when approving invoices. | [optional] [default to false]
**IsInvoiceApprovalCommentFeatureEnabled** | **bool** | Defines whether the feature that prompts subscriber’s employees to enter a comment when approving invoices is turned on. | [optional] [default to false]
**IsInvoiceNumberValidationFeatureEnabled** | **bool** | Defines whether the feature that enables the invoice number validation is turned on. | [optional] [default to false]
**IsInvoiceNegativeFeatureEnabled** | **bool** | Defines whether the feature that enables the invoice negative amounts for the required line items. | [optional] [default to false]
**IsInvoiceZeroVATEU** | **bool** | Use Us UI model in international locations. | [optional] [default to false]
**AvailableTrades** | **string** | A list of trades configured for the subscriber. The following parameters are returned for each trade:&lt;br /&gt; • &#x60;Id&#x60; — trade ID.&lt;br /&gt; • &#x60;Name&#x60; — trade name.&lt;br /&gt; • &#x60;PrimaryTradeName&#x60; — name of the primary trade for this trade. | [optional] 
**AvailableCategories** | **string** | A list of categories set up for the subscriber. The following parameters are returned for each category:&lt;br /&gt; • &#x60;Id&#x60; — category ID.&lt;br /&gt; • &#x60;SubscriberId&#x60; — subscriber ID.&lt;br /&gt; • &#x60;Name&#x60; — category name.&lt;br /&gt; • &#x60;HasDependency&#x60; — defines whether the category has dependent categories.&lt;br /&gt; • &#x60;PrimaryCategoryID&#x60; — ID of the primary category for this category.&lt;br /&gt; • &#x60;PrimaryCategoryName&#x60; — name of the primary category for this category. | [optional] 
**LaborTradeIds** | **List&lt;int&gt;** | Trade IDs for which providers must itemize Labor charges when creating a line-item invoice. | [optional] 
**MaterialsTradeIds** | **List&lt;int&gt;** | Trade IDs for which providers must itemize Material charges when creating a line-item invoice. | [optional] 
**TravelTradeIds** | **List&lt;int&gt;** | Trade IDs for which providers must itemize Travel charges when creating a line-item invoice. | [optional] 
**OtherTradeIds** | **List&lt;int&gt;** | Trade IDs for which providers must itemize Other charges when creating a line-item invoice. | [optional] 
**LaborCategoryIds** | **List&lt;int&gt;** | Category IDs for which providers must itemize Labor charges when creating a line-item invoice. | [optional] 
**MaterialsCategoryIds** | **List&lt;int&gt;** | Category IDs for which providers must itemize Material charges when creating a line-item invoice. | [optional] 
**TravelCategoryIds** | **List&lt;int&gt;** | Category IDs for which providers must itemize Travel charges when creating a line-item invoice. | [optional] 
**OtherCategoryIds** | **List&lt;int&gt;** | Category IDs for which providers must itemize Other charges when creating a line-item invoice. | [optional] 
**NumberRequirementsModel** | [**SCServiceChannelServicesMessagingInvoicesNumberRequirementsModel**](SCServiceChannelServicesMessagingInvoicesNumberRequirementsModel.md) |  | [optional] 
**IsProviderAbleToAddSalesTax** | **bool** | Defines whether the provider can add sales tax to its ivoices | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

