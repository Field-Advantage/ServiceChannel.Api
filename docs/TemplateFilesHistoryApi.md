# ServiceChannel.Api.Api.TemplateFilesHistoryApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TemplateFilesHistoryGetHistory**](TemplateFilesHistoryApi.md#templatefileshistorygethistory) | **GET** /TemplateFilesHistory/GetHistory |  |

<a id="templatefileshistorygethistory"></a>
# **TemplateFilesHistoryGetHistory**
> SCServiceChannelServicesMessagingTemplateGetTemplateFilesHistoriesResponse TemplateFilesHistoryGetHistory (List<int>? fileTypeIds = null, string? sort = null, int? page = null, int? pageSize = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class TemplateFilesHistoryGetHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TemplateFilesHistoryApi(config);
            var fileTypeIds = new List<int>?(); // List<int>? | Gets or sets FileTypeId. (optional) 
            var sort = "sort_example";  // string? | Sort resources by the specified property in the response. (optional) 
            var page = 56;  // int? | Results page number. (optional) 
            var pageSize = 56;  // int? | Number of objects on the results page. The default and maximum per page is 50. (optional) 

            try
            {
                SCServiceChannelServicesMessagingTemplateGetTemplateFilesHistoriesResponse result = apiInstance.TemplateFilesHistoryGetHistory(fileTypeIds, sort, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemplateFilesHistoryApi.TemplateFilesHistoryGetHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TemplateFilesHistoryGetHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SCServiceChannelServicesMessagingTemplateGetTemplateFilesHistoriesResponse> response = apiInstance.TemplateFilesHistoryGetHistoryWithHttpInfo(fileTypeIds, sort, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemplateFilesHistoryApi.TemplateFilesHistoryGetHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileTypeIds** | [**List&lt;int&gt;?**](int.md) | Gets or sets FileTypeId. | [optional]  |
| **sort** | **string?** | Sort resources by the specified property in the response. | [optional]  |
| **page** | **int?** | Results page number. | [optional]  |
| **pageSize** | **int?** | Number of objects on the results page. The default and maximum per page is 50. | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingTemplateGetTemplateFilesHistoriesResponse**](SCServiceChannelServicesMessagingTemplateGetTemplateFilesHistoriesResponse.md)

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

