# ServiceChannel.Api.Api.SiteAuditApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SubscribersCurrentLocationsAuditInfo**](SiteAuditApi.md#subscriberscurrentlocationsauditinfo) | **POST** /subscribers/current/locations/auditInfo | Save completed audit to the database |
| [**SubscribersCurrentLocationsAuditinfoChecklistTemplatestemplateIdtemplateId**](SiteAuditApi.md#subscriberscurrentlocationsauditinfochecklisttemplatestemplateidtemplateid) | **GET** /subscribers/current/locations/auditinfo/checklist/templates | Get checklist templates by audit template. |
| [**SubscribersCurrentLocationsAuditinfoChecklistitemTemplatestemplateIdtemplateIdcheckListTemplateIdcheckListTemplateId**](SiteAuditApi.md#subscriberscurrentlocationsauditinfochecklistitemtemplatestemplateidtemplateidchecklisttemplateidchecklisttemplateid) | **GET** /subscribers/current/locations/auditinfo/checklistitem/templates | Get checklistitem templates by audit template. |
| [**SubscribersCurrentLocationsAuditinfolocationIdlocationIdtemplateIdtemplateId**](SiteAuditApi.md#subscriberscurrentlocationsauditinfolocationidlocationidtemplateidtemplateid) | **GET** /subscribers/current/locations/auditinfo | Get audit data for specified location and audit type without template information |
| [**SubscribersCurrentLocationslocationIdSiteauditTemplateTypes**](SiteAuditApi.md#subscriberscurrentlocationslocationidsiteaudittemplatetypes) | **GET** /subscribers/current/locations/{locationId}/siteaudit/templateTypes | Get available audit types for specified location |
| [**SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfo**](SiteAuditApi.md#subscriberscurrentlocationslocationidsiteaudittemplatetypestemplatetypeidauditinfo) | **GET** /subscribers/current/locations/{locationId}/siteaudit/templateTypes/{templateTypeId}/auditInfo | Get audit data for specified location and audit type |
| [**SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfoWeighted**](SiteAuditApi.md#subscriberscurrentlocationslocationidsiteaudittemplatetypestemplatetypeidauditinfoweighted) | **GET** /subscribers/current/locations/{locationId}/siteaudit/templateTypes/{templateTypeId}/auditInfoWeighted | Get audit data for specified location and audit type for new templates |
| [**SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfoWeighted_0**](SiteAuditApi.md#subscriberscurrentlocationslocationidsiteaudittemplatetypestemplatetypeidauditinfoweighted_0) | **POST** /subscribers/current/locations/{locationId}/siteaudit/templateTypes/{templateTypeId}/auditInfoWeighted | Post (save) completed audit of new type to the database |
| [**SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfo_0**](SiteAuditApi.md#subscriberscurrentlocationslocationidsiteaudittemplatetypestemplatetypeidauditinfo_0) | **POST** /subscribers/current/locations/{locationId}/siteaudit/templateTypes/{templateTypeId}/auditInfo | Post (save) completed audit to the database |
| [**SubscribersCurrentSiteauditAuditsCompleteddaysPerioddaysPeriod**](SiteAuditApi.md#subscriberscurrentsiteauditauditscompleteddaysperioddaysperiod) | **GET** /subscribers/current/siteaudit/audits/completed | Get list of completed audits for current subscriber |
| [**SubscribersCurrentSiteauditCheckListItemscheckListItemId**](SiteAuditApi.md#subscriberscurrentsiteauditchecklistitemschecklistitemid) | **GET** /subscribers/current/siteaudit/checkListItems/{checkListItemId} | Get details for specified checklist item |
| [**SubscribersCurrentSiteauditCompleted**](SiteAuditApi.md#subscriberscurrentsiteauditcompleted) | **PUT** /subscribers/current/siteaudit/completed | Update completed audit info |
| [**SubscribersCurrentSiteauditCompletedauditId**](SiteAuditApi.md#subscriberscurrentsiteauditcompletedauditid) | **GET** /subscribers/current/siteaudit/completed/{auditId} | Get completed audit info |
| [**SubscribersCurrentSiteauditReportauditIdauditIdfromDatefromDatetoDatetoDatecountrycountrylocationIdlocationIdareaarea**](SiteAuditApi.md#subscriberscurrentsiteauditreportauditidauditidfromdatefromdatetodatetodatecountrycountrylocationidlocationidareaarea) | **GET** /subscribers/current/siteaudit/report | Get site audit reports |

<a id="subscriberscurrentlocationsauditinfo"></a>
# **SubscribersCurrentLocationsAuditInfo**
> SCServiceChannelServicesMessagingSiteAuditSaveAuditDataResponse SubscribersCurrentLocationsAuditInfo (SCServiceChannelServicesMessagingSiteAuditAuditDataExternal request)

Save completed audit to the database

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscribersCurrentLocationsAuditInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SiteAuditApi(config);
            var request = new SCServiceChannelServicesMessagingSiteAuditAuditDataExternal(); // SCServiceChannelServicesMessagingSiteAuditAuditDataExternal | Request object

            try
            {
                // Save completed audit to the database
                SCServiceChannelServicesMessagingSiteAuditSaveAuditDataResponse result = apiInstance.SubscribersCurrentLocationsAuditInfo(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteAuditApi.SubscribersCurrentLocationsAuditInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribersCurrentLocationsAuditInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Save completed audit to the database
    ApiResponse<SCServiceChannelServicesMessagingSiteAuditSaveAuditDataResponse> response = apiInstance.SubscribersCurrentLocationsAuditInfoWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteAuditApi.SubscribersCurrentLocationsAuditInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingSiteAuditAuditDataExternal**](SCServiceChannelServicesMessagingSiteAuditAuditDataExternal.md) | Request object |  |

### Return type

[**SCServiceChannelServicesMessagingSiteAuditSaveAuditDataResponse**](SCServiceChannelServicesMessagingSiteAuditSaveAuditDataResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The audit info for the requested location is provided in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              1010 - Invalid site audit parameters |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 - Missing or incorrect authentication credentials |  -  |
| **500** | The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 - Unspecified internal server error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscriberscurrentlocationsauditinfochecklisttemplatestemplateidtemplateid"></a>
# **SubscribersCurrentLocationsAuditinfoChecklistTemplatestemplateIdtemplateId**
> List&lt;SCServiceChannelServicesMessagingSiteAuditCheckListTemplateExternal&gt; SubscribersCurrentLocationsAuditinfoChecklistTemplatestemplateIdtemplateId (int templateId)

Get checklist templates by audit template.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscribersCurrentLocationsAuditinfoChecklistTemplatestemplateIdtemplateIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SiteAuditApi(config);
            var templateId = 56;  // int | Audit type identifier

            try
            {
                // Get checklist templates by audit template.
                List<SCServiceChannelServicesMessagingSiteAuditCheckListTemplateExternal> result = apiInstance.SubscribersCurrentLocationsAuditinfoChecklistTemplatestemplateIdtemplateId(templateId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteAuditApi.SubscribersCurrentLocationsAuditinfoChecklistTemplatestemplateIdtemplateId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribersCurrentLocationsAuditinfoChecklistTemplatestemplateIdtemplateIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get checklist templates by audit template.
    ApiResponse<List<SCServiceChannelServicesMessagingSiteAuditCheckListTemplateExternal>> response = apiInstance.SubscribersCurrentLocationsAuditinfoChecklistTemplatestemplateIdtemplateIdWithHttpInfo(templateId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteAuditApi.SubscribersCurrentLocationsAuditinfoChecklistTemplatestemplateIdtemplateIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **int** | Audit type identifier |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingSiteAuditCheckListTemplateExternal&gt;**](SCServiceChannelServicesMessagingSiteAuditCheckListTemplateExternal.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Checklist templates are provided in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              1010 - Invalid site audit parameters |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 - Missing or incorrect authentication credentials |  -  |
| **500** | The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 - Unspecified internal server error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscriberscurrentlocationsauditinfochecklistitemtemplatestemplateidtemplateidchecklisttemplateidchecklisttemplateid"></a>
# **SubscribersCurrentLocationsAuditinfoChecklistitemTemplatestemplateIdtemplateIdcheckListTemplateIdcheckListTemplateId**
> List&lt;SCServiceChannelServicesMessagingSiteAuditCheckListItemExternal&gt; SubscribersCurrentLocationsAuditinfoChecklistitemTemplatestemplateIdtemplateIdcheckListTemplateIdcheckListTemplateId (int templateId, int? checkListTemplateId = null)

Get checklistitem templates by audit template.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscribersCurrentLocationsAuditinfoChecklistitemTemplatestemplateIdtemplateIdcheckListTemplateIdcheckListTemplateIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SiteAuditApi(config);
            var templateId = 56;  // int | Audit type identifier
            var checkListTemplateId = 56;  // int? | Check list template identifier (optional) 

            try
            {
                // Get checklistitem templates by audit template.
                List<SCServiceChannelServicesMessagingSiteAuditCheckListItemExternal> result = apiInstance.SubscribersCurrentLocationsAuditinfoChecklistitemTemplatestemplateIdtemplateIdcheckListTemplateIdcheckListTemplateId(templateId, checkListTemplateId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteAuditApi.SubscribersCurrentLocationsAuditinfoChecklistitemTemplatestemplateIdtemplateIdcheckListTemplateIdcheckListTemplateId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribersCurrentLocationsAuditinfoChecklistitemTemplatestemplateIdtemplateIdcheckListTemplateIdcheckListTemplateIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get checklistitem templates by audit template.
    ApiResponse<List<SCServiceChannelServicesMessagingSiteAuditCheckListItemExternal>> response = apiInstance.SubscribersCurrentLocationsAuditinfoChecklistitemTemplatestemplateIdtemplateIdcheckListTemplateIdcheckListTemplateIdWithHttpInfo(templateId, checkListTemplateId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteAuditApi.SubscribersCurrentLocationsAuditinfoChecklistitemTemplatestemplateIdtemplateIdcheckListTemplateIdcheckListTemplateIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **int** | Audit type identifier |  |
| **checkListTemplateId** | **int?** | Check list template identifier | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingSiteAuditCheckListItemExternal&gt;**](SCServiceChannelServicesMessagingSiteAuditCheckListItemExternal.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Checklist templates are provided in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              1010 - Invalid site audit parameters |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 - Missing or incorrect authentication credentials |  -  |
| **500** | The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 - Unspecified internal server error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscriberscurrentlocationsauditinfolocationidlocationidtemplateidtemplateid"></a>
# **SubscribersCurrentLocationsAuditinfolocationIdlocationIdtemplateIdtemplateId**
> SCServiceChannelServicesMessagingSiteAuditGetAuditInfo SubscribersCurrentLocationsAuditinfolocationIdlocationIdtemplateIdtemplateId (int locationId, int templateId)

Get audit data for specified location and audit type without template information

Setup data for areas-checklist-checklistItems relationship data are not provided in this method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscribersCurrentLocationsAuditinfolocationIdlocationIdtemplateIdtemplateIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SiteAuditApi(config);
            var locationId = 56;  // int | Location identifier
            var templateId = 56;  // int | Audit type identifier

            try
            {
                // Get audit data for specified location and audit type without template information
                SCServiceChannelServicesMessagingSiteAuditGetAuditInfo result = apiInstance.SubscribersCurrentLocationsAuditinfolocationIdlocationIdtemplateIdtemplateId(locationId, templateId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteAuditApi.SubscribersCurrentLocationsAuditinfolocationIdlocationIdtemplateIdtemplateId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribersCurrentLocationsAuditinfolocationIdlocationIdtemplateIdtemplateIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get audit data for specified location and audit type without template information
    ApiResponse<SCServiceChannelServicesMessagingSiteAuditGetAuditInfo> response = apiInstance.SubscribersCurrentLocationsAuditinfolocationIdlocationIdtemplateIdtemplateIdWithHttpInfo(locationId, templateId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteAuditApi.SubscribersCurrentLocationsAuditinfolocationIdlocationIdtemplateIdtemplateIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | Location identifier |  |
| **templateId** | **int** | Audit type identifier |  |

### Return type

[**SCServiceChannelServicesMessagingSiteAuditGetAuditInfo**](SCServiceChannelServicesMessagingSiteAuditGetAuditInfo.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The audit info for the requested location is provided in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              1010 - Invalid site audit parameters |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 - Missing or incorrect authentication credentials |  -  |
| **500** | The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 - Unspecified internal server error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscriberscurrentlocationslocationidsiteaudittemplatetypes"></a>
# **SubscribersCurrentLocationslocationIdSiteauditTemplateTypes**
> Object SubscribersCurrentLocationslocationIdSiteauditTemplateTypes (int locationId)

Get available audit types for specified location

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscribersCurrentLocationslocationIdSiteauditTemplateTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SiteAuditApi(config);
            var locationId = 56;  // int | Location identifier

            try
            {
                // Get available audit types for specified location
                Object result = apiInstance.SubscribersCurrentLocationslocationIdSiteauditTemplateTypes(locationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteAuditApi.SubscribersCurrentLocationslocationIdSiteauditTemplateTypes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribersCurrentLocationslocationIdSiteauditTemplateTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get available audit types for specified location
    ApiResponse<Object> response = apiInstance.SubscribersCurrentLocationslocationIdSiteauditTemplateTypesWithHttpInfo(locationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteAuditApi.SubscribersCurrentLocationslocationIdSiteauditTemplateTypesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | Location identifier |  |

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscriberscurrentlocationslocationidsiteaudittemplatetypestemplatetypeidauditinfo"></a>
# **SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfo**
> Object SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfo (int locationId, int templateTypeId)

Get audit data for specified location and audit type

Audit can be created from:              - completed audit data              - setup (templates) data              - mixed completed + setup              How audit data is combined depends on the loaded setup file to the system and/or availability               of previous finished audit data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SiteAuditApi(config);
            var locationId = 56;  // int | Location identifier
            var templateTypeId = 56;  // int | Audit type identifier

            try
            {
                // Get audit data for specified location and audit type
                Object result = apiInstance.SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfo(locationId, templateTypeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteAuditApi.SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get audit data for specified location and audit type
    ApiResponse<Object> response = apiInstance.SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfoWithHttpInfo(locationId, templateTypeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteAuditApi.SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | Location identifier |  |
| **templateTypeId** | **int** | Audit type identifier |  |

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscriberscurrentlocationslocationidsiteaudittemplatetypestemplatetypeidauditinfoweighted"></a>
# **SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfoWeighted**
> Object SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfoWeighted (int locationId, int templateTypeId)

Get audit data for specified location and audit type for new templates

Audit can be created from:              - completed audit data              - setup (templates) data              - mixed completed + setup              How audit data is combined depends on the loaded setup file to the system and/or availability               of previous finished audit data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfoWeightedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SiteAuditApi(config);
            var locationId = 56;  // int | Location identifier
            var templateTypeId = 56;  // int | Audit type identifier

            try
            {
                // Get audit data for specified location and audit type for new templates
                Object result = apiInstance.SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfoWeighted(locationId, templateTypeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteAuditApi.SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfoWeighted: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfoWeightedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get audit data for specified location and audit type for new templates
    ApiResponse<Object> response = apiInstance.SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfoWeightedWithHttpInfo(locationId, templateTypeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteAuditApi.SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfoWeightedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | Location identifier |  |
| **templateTypeId** | **int** | Audit type identifier |  |

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscriberscurrentlocationslocationidsiteaudittemplatetypestemplatetypeidauditinfoweighted_0"></a>
# **SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfoWeighted_0**
> Object SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfoWeighted_0 (int locationId, int templateTypeId, SCServiceChannelServicesMessagingSiteAuditAuditDataWeightedExternal request)

Post (save) completed audit of new type to the database

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfoWeighted_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SiteAuditApi(config);
            var locationId = 56;  // int | Location identifier
            var templateTypeId = 56;  // int | Audit type identifier
            var request = new SCServiceChannelServicesMessagingSiteAuditAuditDataWeightedExternal(); // SCServiceChannelServicesMessagingSiteAuditAuditDataWeightedExternal | Completed audit data

            try
            {
                // Post (save) completed audit of new type to the database
                Object result = apiInstance.SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfoWeighted_0(locationId, templateTypeId, request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteAuditApi.SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfoWeighted_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfoWeighted_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Post (save) completed audit of new type to the database
    ApiResponse<Object> response = apiInstance.SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfoWeighted_0WithHttpInfo(locationId, templateTypeId, request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteAuditApi.SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfoWeighted_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | Location identifier |  |
| **templateTypeId** | **int** | Audit type identifier |  |
| **request** | [**SCServiceChannelServicesMessagingSiteAuditAuditDataWeightedExternal**](SCServiceChannelServicesMessagingSiteAuditAuditDataWeightedExternal.md) | Completed audit data |  |

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscriberscurrentlocationslocationidsiteaudittemplatetypestemplatetypeidauditinfo_0"></a>
# **SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfo_0**
> Object SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfo_0 (int locationId, int templateTypeId, SCServiceChannelServicesMessagingSiteAuditAuditDataExternalOld request)

Post (save) completed audit to the database

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfo_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SiteAuditApi(config);
            var locationId = 56;  // int | Location identifier
            var templateTypeId = 56;  // int | Audit type identifier
            var request = new SCServiceChannelServicesMessagingSiteAuditAuditDataExternalOld(); // SCServiceChannelServicesMessagingSiteAuditAuditDataExternalOld | Completed audit data

            try
            {
                // Post (save) completed audit to the database
                Object result = apiInstance.SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfo_0(locationId, templateTypeId, request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteAuditApi.SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfo_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfo_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Post (save) completed audit to the database
    ApiResponse<Object> response = apiInstance.SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfo_0WithHttpInfo(locationId, templateTypeId, request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteAuditApi.SubscribersCurrentLocationslocationIdSiteauditTemplateTypestemplateTypeIdAuditInfo_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** | Location identifier |  |
| **templateTypeId** | **int** | Audit type identifier |  |
| **request** | [**SCServiceChannelServicesMessagingSiteAuditAuditDataExternalOld**](SCServiceChannelServicesMessagingSiteAuditAuditDataExternalOld.md) | Completed audit data |  |

### Return type

**Object**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscriberscurrentsiteauditauditscompleteddaysperioddaysperiod"></a>
# **SubscribersCurrentSiteauditAuditsCompleteddaysPerioddaysPeriod**
> SCServiceChannelServicesMessagingSiteAuditCompletedAuditListResponse SubscribersCurrentSiteauditAuditsCompleteddaysPerioddaysPeriod (int? daysPeriod = null)

Get list of completed audits for current subscriber

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscribersCurrentSiteauditAuditsCompleteddaysPerioddaysPeriodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SiteAuditApi(config);
            var daysPeriod = 56;  // int? | Number of days in the past from now (optional) 

            try
            {
                // Get list of completed audits for current subscriber
                SCServiceChannelServicesMessagingSiteAuditCompletedAuditListResponse result = apiInstance.SubscribersCurrentSiteauditAuditsCompleteddaysPerioddaysPeriod(daysPeriod);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteAuditApi.SubscribersCurrentSiteauditAuditsCompleteddaysPerioddaysPeriod: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribersCurrentSiteauditAuditsCompleteddaysPerioddaysPeriodWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get list of completed audits for current subscriber
    ApiResponse<SCServiceChannelServicesMessagingSiteAuditCompletedAuditListResponse> response = apiInstance.SubscribersCurrentSiteauditAuditsCompleteddaysPerioddaysPeriodWithHttpInfo(daysPeriod);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteAuditApi.SubscribersCurrentSiteauditAuditsCompleteddaysPerioddaysPeriodWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **daysPeriod** | **int?** | Number of days in the past from now | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingSiteAuditCompletedAuditListResponse**](SCServiceChannelServicesMessagingSiteAuditCompletedAuditListResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested completed audit list is in the response. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 - Missing or incorrect authentication credentials |  -  |
| **500** | The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 - Unspecified internal server error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscriberscurrentsiteauditchecklistitemschecklistitemid"></a>
# **SubscribersCurrentSiteauditCheckListItemscheckListItemId**
> SCServiceChannelServicesMessagingSiteAuditCheckListItemDetailsResponse SubscribersCurrentSiteauditCheckListItemscheckListItemId (int checkListItemId)

Get details for specified checklist item

Details include:              - comments with attachments              - workorders              - quantity

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscribersCurrentSiteauditCheckListItemscheckListItemIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SiteAuditApi(config);
            var checkListItemId = 56;  // int | Identifier of checklist item

            try
            {
                // Get details for specified checklist item
                SCServiceChannelServicesMessagingSiteAuditCheckListItemDetailsResponse result = apiInstance.SubscribersCurrentSiteauditCheckListItemscheckListItemId(checkListItemId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteAuditApi.SubscribersCurrentSiteauditCheckListItemscheckListItemId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribersCurrentSiteauditCheckListItemscheckListItemIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get details for specified checklist item
    ApiResponse<SCServiceChannelServicesMessagingSiteAuditCheckListItemDetailsResponse> response = apiInstance.SubscribersCurrentSiteauditCheckListItemscheckListItemIdWithHttpInfo(checkListItemId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteAuditApi.SubscribersCurrentSiteauditCheckListItemscheckListItemIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **checkListItemId** | **int** | Identifier of checklist item |  |

### Return type

[**SCServiceChannelServicesMessagingSiteAuditCheckListItemDetailsResponse**](SCServiceChannelServicesMessagingSiteAuditCheckListItemDetailsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested completed audit list is in the response. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 - Missing or incorrect authentication credentials |  -  |
| **500** | The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 - Unspecified internal server error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscriberscurrentsiteauditcompleted"></a>
# **SubscribersCurrentSiteauditCompleted**
> SCServiceChannelServicesMessagingSiteAuditUpdatedCompletedAuditResponse SubscribersCurrentSiteauditCompleted (SCServiceChannelApiModelSiteAuditCompletedAuditInfo request)

Update completed audit info

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscribersCurrentSiteauditCompletedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SiteAuditApi(config);
            var request = new SCServiceChannelApiModelSiteAuditCompletedAuditInfo(); // SCServiceChannelApiModelSiteAuditCompletedAuditInfo | Completed audit info

            try
            {
                // Update completed audit info
                SCServiceChannelServicesMessagingSiteAuditUpdatedCompletedAuditResponse result = apiInstance.SubscribersCurrentSiteauditCompleted(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteAuditApi.SubscribersCurrentSiteauditCompleted: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribersCurrentSiteauditCompletedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update completed audit info
    ApiResponse<SCServiceChannelServicesMessagingSiteAuditUpdatedCompletedAuditResponse> response = apiInstance.SubscribersCurrentSiteauditCompletedWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteAuditApi.SubscribersCurrentSiteauditCompletedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelApiModelSiteAuditCompletedAuditInfo**](SCServiceChannelApiModelSiteAuditCompletedAuditInfo.md) | Completed audit info |  |

### Return type

[**SCServiceChannelServicesMessagingSiteAuditUpdatedCompletedAuditResponse**](SCServiceChannelServicesMessagingSiteAuditUpdatedCompletedAuditResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The site audit info is successfully updated. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              608 - Do not have access to the location.              1007 - Template type is inactive.              1009 - Unexpected error |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 - Missing or incorrect authentication credentials |  -  |
| **404** | The requested resource does not exist on the server.              &lt;br/&gt;Error codes:              1008 - Audit not found |  -  |
| **500** | The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 - Unspecified internal server error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscriberscurrentsiteauditcompletedauditid"></a>
# **SubscribersCurrentSiteauditCompletedauditId**
> SCServiceChannelApiModelSiteAuditCompletedAuditInfoExternal SubscribersCurrentSiteauditCompletedauditId (int auditId)

Get completed audit info

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscribersCurrentSiteauditCompletedauditIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SiteAuditApi(config);
            var auditId = 56;  // int | The numeric identifier of the site audit info to return.

            try
            {
                // Get completed audit info
                SCServiceChannelApiModelSiteAuditCompletedAuditInfoExternal result = apiInstance.SubscribersCurrentSiteauditCompletedauditId(auditId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteAuditApi.SubscribersCurrentSiteauditCompletedauditId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribersCurrentSiteauditCompletedauditIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get completed audit info
    ApiResponse<SCServiceChannelApiModelSiteAuditCompletedAuditInfoExternal> response = apiInstance.SubscribersCurrentSiteauditCompletedauditIdWithHttpInfo(auditId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteAuditApi.SubscribersCurrentSiteauditCompletedauditIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **auditId** | **int** | The numeric identifier of the site audit info to return. |  |

### Return type

[**SCServiceChannelApiModelSiteAuditCompletedAuditInfoExternal**](SCServiceChannelApiModelSiteAuditCompletedAuditInfoExternal.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested site audit info is in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              608 - Do not have access to the location |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 - Missing or incorrect authentication credentials |  -  |
| **404** | The requested resource does not exist on the server.              &lt;br/&gt;Error codes:              1008 - Audit not found |  -  |
| **500** | The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 - Unspecified internal server error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscriberscurrentsiteauditreportauditidauditidfromdatefromdatetodatetodatecountrycountrylocationidlocationidareaarea"></a>
# **SubscribersCurrentSiteauditReportauditIdauditIdfromDatefromDatetoDatetoDatecountrycountrylocationIdlocationIdareaarea**
> List&lt;SCServiceChannelServicesMessagingSiteAuditAuditReportExternal&gt; SubscribersCurrentSiteauditReportauditIdauditIdfromDatefromDatetoDatetoDatecountrycountrylocationIdlocationIdareaarea (int? auditId = null, DateTime? fromDate = null, DateTime? toDate = null, string? country = null, int? locationId = null, string? area = null)

Get site audit reports

Returns a site audit report, its part, or several reports for the current subscriber.              <br />**Required parameters:**               • **Option 1**. `auditId`. Use to get a site audit report by ID.               • **Option 2**. The combination of `fromDate` and `toDate`. Use to get site audit reports for a specific period.              <br />***Note:*** Site audit reports are also known as *site planning reports* or just *audits*. See [Site Planning Manager](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/551059548/Site+Planning+Manager) for more info.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscribersCurrentSiteauditReportauditIdauditIdfromDatefromDatetoDatetoDatecountrycountrylocationIdlocationIdareaareaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SiteAuditApi(config);
            var auditId = 56;  // int? | The numeric identifier of the site audit report to return. (optional) 
            var fromDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | The date from which you want to return site audit reports. The format is `YYYY-MM-DDThh:mm:ss.sssZ`. (optional) 
            var toDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | The date until which you want to return site audit reports. The format is `YYYY-MM-DDThh:mm:ss.sssZ`. (optional) 
            var country = "country_example";  // string? | The two-letter [ISO 3166-1 code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) of the location country. (optional) 
            var locationId = 56;  // int? | The numeric identifier of the subscriber's property. (optional) 
            var area = "area_example";  // string? | The audited area within the location. (optional) 

            try
            {
                // Get site audit reports
                List<SCServiceChannelServicesMessagingSiteAuditAuditReportExternal> result = apiInstance.SubscribersCurrentSiteauditReportauditIdauditIdfromDatefromDatetoDatetoDatecountrycountrylocationIdlocationIdareaarea(auditId, fromDate, toDate, country, locationId, area);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SiteAuditApi.SubscribersCurrentSiteauditReportauditIdauditIdfromDatefromDatetoDatetoDatecountrycountrylocationIdlocationIdareaarea: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribersCurrentSiteauditReportauditIdauditIdfromDatefromDatetoDatetoDatecountrycountrylocationIdlocationIdareaareaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get site audit reports
    ApiResponse<List<SCServiceChannelServicesMessagingSiteAuditAuditReportExternal>> response = apiInstance.SubscribersCurrentSiteauditReportauditIdauditIdfromDatefromDatetoDatetoDatecountrycountrylocationIdlocationIdareaareaWithHttpInfo(auditId, fromDate, toDate, country, locationId, area);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SiteAuditApi.SubscribersCurrentSiteauditReportauditIdauditIdfromDatefromDatetoDatetoDatecountrycountrylocationIdlocationIdareaareaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **auditId** | **int?** | The numeric identifier of the site audit report to return. | [optional]  |
| **fromDate** | **DateTime?** | The date from which you want to return site audit reports. The format is &#x60;YYYY-MM-DDThh:mm:ss.sssZ&#x60;. | [optional]  |
| **toDate** | **DateTime?** | The date until which you want to return site audit reports. The format is &#x60;YYYY-MM-DDThh:mm:ss.sssZ&#x60;. | [optional]  |
| **country** | **string?** | The two-letter [ISO 3166-1 code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) of the location country. | [optional]  |
| **locationId** | **int?** | The numeric identifier of the subscriber&#39;s property. | [optional]  |
| **area** | **string?** | The audited area within the location. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingSiteAuditAuditReportExternal&gt;**](SCServiceChannelServicesMessagingSiteAuditAuditReportExternal.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested site audit reports are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              1010 - Invalid site audit parameters |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 - Missing or incorrect authentication credentials |  -  |
| **500** | The server was unable to complete the request due to an internal error.              &lt;br/&gt;Error codes:              501 - Unspecified internal server error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

