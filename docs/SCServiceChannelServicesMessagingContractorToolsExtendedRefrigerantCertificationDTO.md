# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingContractorToolsExtendedRefrigerantCertificationDTO
Object containing the details of a refrigerant certification.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Numeric identifier of the certificate in the system. | [optional] 
**CertificationNumber** | **string** | Unique certificate number given by the party that granted the certificate. | [optional] 
**CertificationExpirationDateTime** | **DateTime** | Date and time when the certificate expires. | [optional] 
**Description** | **string** | Comment added to the attached file. | [optional] 
**FileUrl** | **string** | Path of the attached file. | [optional] 
**FileName** | **string** | Name of the attached file. | [optional] 
**TechnicianFullName** | **string** | First and last name of the technician who received the refrigerant certification. | [optional] 
**AuthUserId** | **long** | Single sign-on (SSO) ID of the technician who received the refrigerant certification. | [optional] 
**CertificationDateTime** | **DateTime** | Date and time when the refrigerant certification becomes valid. | [optional] 
**CertificationLevelId** | **int** | Type ID of EPA 608 Technician Certification. Possible values: 1 - Type I, 2 - Type II , 3 - Type III, 4 - Universal. | [optional] 
**CertificationLevel** | **string** | Type of EPA Section 608 Technician Certification. Possible values: Type Ⅰ - service of small appliances containing 5 lbs or less of refrigerant; Type Ⅱ - service or disposal of high- or very high-pressure appliances (containing more than 5 lbs of refrigerant); Type Ⅲ - service or disposal of low-pressure appliances; Universal - service of refrigerated appliances of all types. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

