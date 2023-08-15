# ServiceChannel.Api.Api.DocumentsApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiDocumentsGetTempLinkattachmentIdattachmentIdoverrideFileNameoverrideFileNamesignaturesignature**](DocumentsApi.md#apidocumentsgettemplinkattachmentidattachmentidoverridefilenameoverridefilenamesignaturesignature) | **GET** /api/documents/GetTempLink | GET example: https://localhost:1871/api/s3?attachmentId&#x3D;tests/S3Test/ef7031654d5b4259b260586300660352.txt |
| [**DocumentsGetTempLinkattachmentIdattachmentIdoverrideFileNameoverrideFileNamesignaturesignature**](DocumentsApi.md#documentsgettemplinkattachmentidattachmentidoverridefilenameoverridefilenamesignaturesignature) | **GET** /documents/GetTempLink | GET example: https://localhost:1871/api/s3?attachmentId&#x3D;tests/S3Test/ef7031654d5b4259b260586300660352.txt |

<a id="apidocumentsgettemplinkattachmentidattachmentidoverridefilenameoverridefilenamesignaturesignature"></a>
# **ApiDocumentsGetTempLinkattachmentIdattachmentIdoverrideFileNameoverrideFileNamesignaturesignature**
> Object ApiDocumentsGetTempLinkattachmentIdattachmentIdoverrideFileNameoverrideFileNamesignaturesignature (string attachmentId, string? overrideFileName = null, string? signature = null)

GET example: https://localhost:1871/api/s3?attachmentId=tests/S3Test/ef7031654d5b4259b260586300660352.txt

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ApiDocumentsGetTempLinkattachmentIdattachmentIdoverrideFileNameoverrideFileNamesignaturesignatureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DocumentsApi(config);
            var attachmentId = "attachmentId_example";  // string | The attachment Id.
            var overrideFileName = "overrideFileName_example";  // string? | The override file name. (optional) 
            var signature = "signature_example";  // string? | The override file name. (optional) 

            try
            {
                // GET example: https://localhost:1871/api/s3?attachmentId=tests/S3Test/ef7031654d5b4259b260586300660352.txt
                Object result = apiInstance.ApiDocumentsGetTempLinkattachmentIdattachmentIdoverrideFileNameoverrideFileNamesignaturesignature(attachmentId, overrideFileName, signature);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentsApi.ApiDocumentsGetTempLinkattachmentIdattachmentIdoverrideFileNameoverrideFileNamesignaturesignature: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDocumentsGetTempLinkattachmentIdattachmentIdoverrideFileNameoverrideFileNamesignaturesignatureWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET example: https://localhost:1871/api/s3?attachmentId=tests/S3Test/ef7031654d5b4259b260586300660352.txt
    ApiResponse<Object> response = apiInstance.ApiDocumentsGetTempLinkattachmentIdattachmentIdoverrideFileNameoverrideFileNamesignaturesignatureWithHttpInfo(attachmentId, overrideFileName, signature);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DocumentsApi.ApiDocumentsGetTempLinkattachmentIdattachmentIdoverrideFileNameoverrideFileNamesignaturesignatureWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **attachmentId** | **string** | The attachment Id. |  |
| **overrideFileName** | **string?** | The override file name. | [optional]  |
| **signature** | **string?** | The override file name. | [optional]  |

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

<a id="documentsgettemplinkattachmentidattachmentidoverridefilenameoverridefilenamesignaturesignature"></a>
# **DocumentsGetTempLinkattachmentIdattachmentIdoverrideFileNameoverrideFileNamesignaturesignature**
> Object DocumentsGetTempLinkattachmentIdattachmentIdoverrideFileNameoverrideFileNamesignaturesignature (string attachmentId, string? overrideFileName = null, string? signature = null)

GET example: https://localhost:1871/api/s3?attachmentId=tests/S3Test/ef7031654d5b4259b260586300660352.txt

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class DocumentsGetTempLinkattachmentIdattachmentIdoverrideFileNameoverrideFileNamesignaturesignatureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DocumentsApi(config);
            var attachmentId = "attachmentId_example";  // string | The attachment Id.
            var overrideFileName = "overrideFileName_example";  // string? | The override file name. (optional) 
            var signature = "signature_example";  // string? | The override file name. (optional) 

            try
            {
                // GET example: https://localhost:1871/api/s3?attachmentId=tests/S3Test/ef7031654d5b4259b260586300660352.txt
                Object result = apiInstance.DocumentsGetTempLinkattachmentIdattachmentIdoverrideFileNameoverrideFileNamesignaturesignature(attachmentId, overrideFileName, signature);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsGetTempLinkattachmentIdattachmentIdoverrideFileNameoverrideFileNamesignaturesignature: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DocumentsGetTempLinkattachmentIdattachmentIdoverrideFileNameoverrideFileNamesignaturesignatureWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET example: https://localhost:1871/api/s3?attachmentId=tests/S3Test/ef7031654d5b4259b260586300660352.txt
    ApiResponse<Object> response = apiInstance.DocumentsGetTempLinkattachmentIdattachmentIdoverrideFileNameoverrideFileNamesignaturesignatureWithHttpInfo(attachmentId, overrideFileName, signature);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DocumentsApi.DocumentsGetTempLinkattachmentIdattachmentIdoverrideFileNameoverrideFileNamesignaturesignatureWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **attachmentId** | **string** | The attachment Id. |  |
| **overrideFileName** | **string?** | The override file name. | [optional]  |
| **signature** | **string?** | The override file name. | [optional]  |

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

