# ServiceChannel.Api.Api.AttachmentsApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AssetsGetattachmentsbyassetids**](AttachmentsApi.md#assetsgetattachmentsbyassetids) | **POST** /assets/getattachmentsbyassetids | Get Asset Attachments |
| [**AssetsGetattachmentsbyassetidsV1**](AttachmentsApi.md#assetsgetattachmentsbyassetidsv1) | **POST** /assets/getattachmentsbyassetids_v1 | Get Asset Attachments |
| [**AssetsUpdateAssetAttachmentattachmentIdattachmentIdfileNamefileNamedescriptiondescription**](AttachmentsApi.md#assetsupdateassetattachmentattachmentidattachmentidfilenamefilenamedescriptiondescription) | **PUT** /assets/updateAssetAttachment | Update asset attachment by id |
| [**AssetsassetAttachmentIdDeleteAttachment**](AttachmentsApi.md#assetsassetattachmentiddeleteattachment) | **POST** /assets/{assetAttachmentId}/deleteAttachment | Delete Asset Attachment |
| [**AssetsassetIdAttachmentsisDefaultisDefault**](AttachmentsApi.md#assetsassetidattachmentsisdefaultisdefault) | **POST** /assets/{assetId}/attachments | Add Attachments to Asset |
| [**AssetsassetIdAttachmentsproviderIdproviderId**](AttachmentsApi.md#assetsassetidattachmentsprovideridproviderid) | **GET** /assets/{assetId}/attachments | Get Asset Attachments |
| [**GetProposalAttachmentThumbnail**](AttachmentsApi.md#getproposalattachmentthumbnail) | **GET** /odata/proposals({proposalId})/attachments({attachmentId})/Service.GetThumbnail(width&#x3D;{width},height&#x3D;{height},mode&#x3D;{mode},imageFormat&#x3D;{imageFormat}) | Retrieve Attachment Thumbnail |
| [**GetProposalAttachments**](AttachmentsApi.md#getproposalattachments) | **GET** /odata/proposals({proposalId})/attachments | Retrieve Proposal Attachments |
| [**GetRFPAttachments**](AttachmentsApi.md#getrfpattachments) | **GET** /odata/rfps({rfpId})/attachments | Retrieve Rfp Attachments |
| [**GetWorkOrderAttachments**](AttachmentsApi.md#getworkorderattachments) | **GET** /odata/workorders({workorderId})/attachments | Retrieve Workorders Attachments |
| [**GetWorkOrderNotesAttachments**](AttachmentsApi.md#getworkordernotesattachments) | **GET** /odata/workorders({workorderId})/notes({noteId})/attachments | Retrieve Workorder Note Attachments |
| [**GetWorkorderAttachmentThumbnail**](AttachmentsApi.md#getworkorderattachmentthumbnail) | **GET** /odata/workorders({workorderId})/attachments({attachmentId})/Service.GetThumbnail(width&#x3D;{width},height&#x3D;{height},mode&#x3D;{mode},imageFormat&#x3D;{imageFormat}) | Retrieve Attachment Thumbnail |
| [**RfpsidAttachments**](AttachmentsApi.md#rfpsidattachments) | **POST** /rfps/{id}/attachments | Add attchment to RFP |
| [**SiteauditCommentscommentIdAttachments**](AttachmentsApi.md#siteauditcommentscommentidattachments) | **GET** /siteaudit/comments/{commentId}/attachments | Returns list of attachment ids and urls. |
| [**SiteauditCommentscommentIdAttachments_0**](AttachmentsApi.md#siteauditcommentscommentidattachments_0) | **POST** /siteaudit/comments/{commentId}/attachments | Add attchment to Comment |
| [**SiteauditCommentscommentIdAttachmentsattachmentId**](AttachmentsApi.md#siteauditcommentscommentidattachmentsattachmentid) | **GET** /siteaudit/comments/{commentId}/attachments/{attachmentId} | Retrieve original attchment from Comment |
| [**SiteauditCommentscommentIdAttachmentsattachmentIdThumbnailwidthwidthheightheightmodemodeimageFormatimageFormat**](AttachmentsApi.md#siteauditcommentscommentidattachmentsattachmentidthumbnailwidthwidthheightheightmodemodeimageformatimageformat) | **GET** /siteaudit/comments/{commentId}/attachments/{attachmentId}/thumbnail | Retrieve resized attchment from Comment |
| [**WorkordersAttachmentAsBase64**](AttachmentsApi.md#workordersattachmentasbase64) | **POST** /workorders/attachmentAsBase64 |  |
| [**WorkorderspoNumberAttachmentsByPoNumberactoractor**](AttachmentsApi.md#workordersponumberattachmentsbyponumberactoractor) | **POST** /workorders/{poNumber}/attachmentsByPoNumber | Add attachments to a work order by PO number |
| [**WorkordersworkorderIdAttachmentsactoractor**](AttachmentsApi.md#workordersworkorderidattachmentsactoractor) | **POST** /workorders/{workorderId}/attachments | Add attachments to a work order |
| [**WorkordersworkorderIdAttachmentsattachmentIdThumbnailwidthwidthheightheightmodemodeimageFormatimageFormat**](AttachmentsApi.md#workordersworkorderidattachmentsattachmentidthumbnailwidthwidthheightheightmodemodeimageformatimageformat) | **GET** /workorders/{workorderId}/attachments/{attachmentId}/thumbnail |  |
| [**WorkordersworkorderIdNotesnoteIdAttachments**](AttachmentsApi.md#workordersworkorderidnotesnoteidattachments) | **POST** /workorders/{workorderId}/notes/{noteId}/attachments | Add Attachments to Work Order Note |
| [**WorkrequestWorkRequestIdNotesNoteIdAttachments**](AttachmentsApi.md#workrequestworkrequestidnotesnoteidattachments) | **GET** /workrequest({workRequestId})/notes({noteId})/attachments | Get WorkRequest Note Attachments |
| [**WorkrequestworkRequestIdAttachments**](AttachmentsApi.md#workrequestworkrequestidattachments) | **GET** /workrequest/{workRequestId}/attachments | Get WorkRequest Attachments |
| [**WorkrequestworkRequestIdAttachmentsactoractor**](AttachmentsApi.md#workrequestworkrequestidattachmentsactoractor) | **POST** /workrequest/{workRequestId}/attachments | Add attachments to a WorkRequest |
| [**WorkrequestworkRequestIdNotesnoteIdAttachments**](AttachmentsApi.md#workrequestworkrequestidnotesnoteidattachments) | **POST** /workrequest/{workRequestId}/notes/{noteId}/attachments | Add Attachments to Work Request Note |

<a id="assetsgetattachmentsbyassetids"></a>
# **AssetsGetattachmentsbyassetids**
> Dictionary&lt;string, List&lt;SCServiceChannelServicesMessagingAssetsAssetAttachment&gt;&gt; AssetsGetattachmentsbyassetids (List<int> assetIds)

Get Asset Attachments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsGetattachmentsbyassetidsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttachmentsApi(config);
            var assetIds = new List<int>(); // List<int> | 

            try
            {
                // Get Asset Attachments
                Dictionary<string, List<SCServiceChannelServicesMessagingAssetsAssetAttachment>> result = apiInstance.AssetsGetattachmentsbyassetids(assetIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.AssetsGetattachmentsbyassetids: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsGetattachmentsbyassetidsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Asset Attachments
    ApiResponse<Dictionary<string, List<SCServiceChannelServicesMessagingAssetsAssetAttachment>>> response = apiInstance.AssetsGetattachmentsbyassetidsWithHttpInfo(assetIds);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.AssetsGetattachmentsbyassetidsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetIds** | [**List&lt;int&gt;**](int.md) |  |  |

### Return type

**Dictionary<string, List<SCServiceChannelServicesMessagingAssetsAssetAttachment>>**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be executed or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 503 - User info should not be null;              &lt;br/&gt;SubscriberId is null; |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsgetattachmentsbyassetidsv1"></a>
# **AssetsGetattachmentsbyassetidsV1**
> Dictionary&lt;string, List&lt;SCServiceChannelServicesMessagingAssetsAssetAttachment&gt;&gt; AssetsGetattachmentsbyassetidsV1 (SCServiceChannelServicesWebApiModelsAssetAttachmentsRequest assetAttachmentsRequest)

Get Asset Attachments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsGetattachmentsbyassetidsV1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttachmentsApi(config);
            var assetAttachmentsRequest = new SCServiceChannelServicesWebApiModelsAssetAttachmentsRequest(); // SCServiceChannelServicesWebApiModelsAssetAttachmentsRequest | 

            try
            {
                // Get Asset Attachments
                Dictionary<string, List<SCServiceChannelServicesMessagingAssetsAssetAttachment>> result = apiInstance.AssetsGetattachmentsbyassetidsV1(assetAttachmentsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.AssetsGetattachmentsbyassetidsV1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsGetattachmentsbyassetidsV1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Asset Attachments
    ApiResponse<Dictionary<string, List<SCServiceChannelServicesMessagingAssetsAssetAttachment>>> response = apiInstance.AssetsGetattachmentsbyassetidsV1WithHttpInfo(assetAttachmentsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.AssetsGetattachmentsbyassetidsV1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetAttachmentsRequest** | [**SCServiceChannelServicesWebApiModelsAssetAttachmentsRequest**](SCServiceChannelServicesWebApiModelsAssetAttachmentsRequest.md) |  |  |

### Return type

**Dictionary<string, List<SCServiceChannelServicesMessagingAssetsAssetAttachment>>**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be executed or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 503 - User info should not be null;              &lt;br/&gt;SubscriberId is null; |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsupdateassetattachmentattachmentidattachmentidfilenamefilenamedescriptiondescription"></a>
# **AssetsUpdateAssetAttachmentattachmentIdattachmentIdfileNamefileNamedescriptiondescription**
> Object AssetsUpdateAssetAttachmentattachmentIdattachmentIdfileNamefileNamedescriptiondescription (int attachmentId, string? fileName = null, string? description = null)

Update asset attachment by id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsUpdateAssetAttachmentattachmentIdattachmentIdfileNamefileNamedescriptiondescriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttachmentsApi(config);
            var attachmentId = 56;  // int | Attachment identifier
            var fileName = "fileName_example";  // string? | New file name (optional) 
            var description = "description_example";  // string? | New file description(comment) (optional) 

            try
            {
                // Update asset attachment by id
                Object result = apiInstance.AssetsUpdateAssetAttachmentattachmentIdattachmentIdfileNamefileNamedescriptiondescription(attachmentId, fileName, description);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.AssetsUpdateAssetAttachmentattachmentIdattachmentIdfileNamefileNamedescriptiondescription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsUpdateAssetAttachmentattachmentIdattachmentIdfileNamefileNamedescriptiondescriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update asset attachment by id
    ApiResponse<Object> response = apiInstance.AssetsUpdateAssetAttachmentattachmentIdattachmentIdfileNamefileNamedescriptiondescriptionWithHttpInfo(attachmentId, fileName, description);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.AssetsUpdateAssetAttachmentattachmentIdattachmentIdfileNamefileNamedescriptiondescriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **attachmentId** | **int** | Attachment identifier |  |
| **fileName** | **string?** | New file name | [optional]  |
| **description** | **string?** | New file description(comment) | [optional]  |

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
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 503 - FileName or Description is required; |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsassetattachmentiddeleteattachment"></a>
# **AssetsassetAttachmentIdDeleteAttachment**
> Object AssetsassetAttachmentIdDeleteAttachment (int assetAttachmentId)

Delete Asset Attachment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsassetAttachmentIdDeleteAttachmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttachmentsApi(config);
            var assetAttachmentId = 56;  // int | 

            try
            {
                // Delete Asset Attachment
                Object result = apiInstance.AssetsassetAttachmentIdDeleteAttachment(assetAttachmentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.AssetsassetAttachmentIdDeleteAttachment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsassetAttachmentIdDeleteAttachmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Asset Attachment
    ApiResponse<Object> response = apiInstance.AssetsassetAttachmentIdDeleteAttachmentWithHttpInfo(assetAttachmentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.AssetsassetAttachmentIdDeleteAttachmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetAttachmentId** | **int** |  |  |

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
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be executed or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 503 - User info should not be null;              &lt;br/&gt;SubscriberId is null; |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsassetidattachmentsisdefaultisdefault"></a>
# **AssetsassetIdAttachmentsisDefaultisDefault**
> List&lt;SCServiceChannelServicesMessagingAssetsAddAssetAttachmentResponse&gt; AssetsassetIdAttachmentsisDefaultisDefault (int assetId, System.IO.Stream file, bool? isDefault = null, Object? addAttachmentsRequest = null)

Add Attachments to Asset

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsassetIdAttachmentsisDefaultisDefaultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttachmentsApi(config);
            var assetId = 56;  // int | 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | File to attach to workorder
            var isDefault = false;  // bool? |  (optional)  (default to false)
            var addAttachmentsRequest = new Object?(); // Object? | Required Descriptor for file(s) (optional) 

            try
            {
                // Add Attachments to Asset
                List<SCServiceChannelServicesMessagingAssetsAddAssetAttachmentResponse> result = apiInstance.AssetsassetIdAttachmentsisDefaultisDefault(assetId, file, isDefault, addAttachmentsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.AssetsassetIdAttachmentsisDefaultisDefault: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsassetIdAttachmentsisDefaultisDefaultWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Attachments to Asset
    ApiResponse<List<SCServiceChannelServicesMessagingAssetsAddAssetAttachmentResponse>> response = apiInstance.AssetsassetIdAttachmentsisDefaultisDefaultWithHttpInfo(assetId, file, isDefault, addAttachmentsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.AssetsassetIdAttachmentsisDefaultisDefaultWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetId** | **int** |  |  |
| **file** | **System.IO.Stream****System.IO.Stream** | File to attach to workorder |  |
| **isDefault** | **bool?** |  | [optional] [default to false] |
| **addAttachmentsRequest** | [**Object?**](Object?.md) | Required Descriptor for file(s) | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingAssetsAddAssetAttachmentResponse&gt;**](SCServiceChannelServicesMessagingAssetsAddAssetAttachmentResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Created indicates that the request resulted in a new resource created before the response was sent. |  -  |
| **400** | Bad Request - the request could not be executed or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 502 - Asset Not found;              &lt; br/&gt; 503 - Bad Request; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="assetsassetidattachmentsprovideridproviderid"></a>
# **AssetsassetIdAttachmentsproviderIdproviderId**
> List&lt;SCServiceChannelServicesMessagingAssetsAssetAttachment&gt; AssetsassetIdAttachmentsproviderIdproviderId (int assetId, int? providerId = null)

Get Asset Attachments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class AssetsassetIdAttachmentsproviderIdproviderIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttachmentsApi(config);
            var assetId = 56;  // int | Asset Identifier
            var providerId = 56;  // int? | The provider identifier. Required for sub-contractor request. [Required Special permissions] (optional) 

            try
            {
                // Get Asset Attachments
                List<SCServiceChannelServicesMessagingAssetsAssetAttachment> result = apiInstance.AssetsassetIdAttachmentsproviderIdproviderId(assetId, providerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.AssetsassetIdAttachmentsproviderIdproviderId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssetsassetIdAttachmentsproviderIdproviderIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Asset Attachments
    ApiResponse<List<SCServiceChannelServicesMessagingAssetsAssetAttachment>> response = apiInstance.AssetsassetIdAttachmentsproviderIdproviderIdWithHttpInfo(assetId, providerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.AssetsassetIdAttachmentsproviderIdproviderIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetId** | **int** | Asset Identifier |  |
| **providerId** | **int?** | The provider identifier. Required for sub-contractor request. [Required Special permissions] | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingAssetsAssetAttachment&gt;**](SCServiceChannelServicesMessagingAssetsAssetAttachment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be executed or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 503 - User info should not be null;              &lt;br/&gt;SubscriberId is null; |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getproposalattachmentthumbnail"></a>
# **GetProposalAttachmentThumbnail**
> SCSystemNetHttpByteArrayContent GetProposalAttachmentThumbnail (string imageFormat, string mode, int height, int width, int attachmentId, int proposalId, string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Retrieve Attachment Thumbnail

Retrieve Attachment Thumbnail

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetProposalAttachmentThumbnailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttachmentsApi(config);
            var imageFormat = "imageFormat_example";  // string | 
            var mode = "mode_example";  // string | 
            var height = 56;  // int | 
            var width = 56;  // int | 
            var attachmentId = 56;  // int | Attachment Identifier
            var proposalId = 56;  // int | Proposal Identifier
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Retrieve Attachment Thumbnail
                SCSystemNetHttpByteArrayContent result = apiInstance.GetProposalAttachmentThumbnail(imageFormat, mode, height, width, attachmentId, proposalId, expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.GetProposalAttachmentThumbnail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProposalAttachmentThumbnailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Attachment Thumbnail
    ApiResponse<SCSystemNetHttpByteArrayContent> response = apiInstance.GetProposalAttachmentThumbnailWithHttpInfo(imageFormat, mode, height, width, attachmentId, proposalId, expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.GetProposalAttachmentThumbnailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **imageFormat** | **string** |  |  |
| **mode** | **string** |  |  |
| **height** | **int** |  |  |
| **width** | **int** |  |  |
| **attachmentId** | **int** | Attachment Identifier |  |
| **proposalId** | **int** | Proposal Identifier |  |
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**SCSystemNetHttpByteArrayContent**](SCSystemNetHttpByteArrayContent.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getproposalattachments"></a>
# **GetProposalAttachments**
> List&lt;SCServiceChannelServicesMessagingAttachmentsAttachment&gt; GetProposalAttachments (int proposalId, string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Retrieve Proposal Attachments

Retrieve Proposal Attachments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetProposalAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttachmentsApi(config);
            var proposalId = 56;  // int | Proposal Identifier
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Retrieve Proposal Attachments
                List<SCServiceChannelServicesMessagingAttachmentsAttachment> result = apiInstance.GetProposalAttachments(proposalId, expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.GetProposalAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProposalAttachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Proposal Attachments
    ApiResponse<List<SCServiceChannelServicesMessagingAttachmentsAttachment>> response = apiInstance.GetProposalAttachmentsWithHttpInfo(proposalId, expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.GetProposalAttachmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **proposalId** | **int** | Proposal Identifier |  |
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingAttachmentsAttachment&gt;**](SCServiceChannelServicesMessagingAttachmentsAttachment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrfpattachments"></a>
# **GetRFPAttachments**
> List&lt;SCServiceChannelServicesMessagingAttachmentsAttachment&gt; GetRFPAttachments (int rfpId, string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Retrieve Rfp Attachments

Retrieve Rfp Attachments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetRFPAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttachmentsApi(config);
            var rfpId = 56;  // int | Rfp Identifier
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Retrieve Rfp Attachments
                List<SCServiceChannelServicesMessagingAttachmentsAttachment> result = apiInstance.GetRFPAttachments(rfpId, expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.GetRFPAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRFPAttachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Rfp Attachments
    ApiResponse<List<SCServiceChannelServicesMessagingAttachmentsAttachment>> response = apiInstance.GetRFPAttachmentsWithHttpInfo(rfpId, expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.GetRFPAttachmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **rfpId** | **int** | Rfp Identifier |  |
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingAttachmentsAttachment&gt;**](SCServiceChannelServicesMessagingAttachmentsAttachment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getworkorderattachments"></a>
# **GetWorkOrderAttachments**
> List&lt;SCServiceChannelServicesMessagingAttachmentsAttachment&gt; GetWorkOrderAttachments (int workorderId, string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Retrieve Workorders Attachments

Retrieve Workorders Attachments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetWorkOrderAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttachmentsApi(config);
            var workorderId = 56;  // int | Workorder Identifier
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Retrieve Workorders Attachments
                List<SCServiceChannelServicesMessagingAttachmentsAttachment> result = apiInstance.GetWorkOrderAttachments(workorderId, expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.GetWorkOrderAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkOrderAttachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Workorders Attachments
    ApiResponse<List<SCServiceChannelServicesMessagingAttachmentsAttachment>> response = apiInstance.GetWorkOrderAttachmentsWithHttpInfo(workorderId, expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.GetWorkOrderAttachmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Workorder Identifier |  |
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingAttachmentsAttachment&gt;**](SCServiceChannelServicesMessagingAttachmentsAttachment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getworkordernotesattachments"></a>
# **GetWorkOrderNotesAttachments**
> List&lt;SCServiceChannelServicesMessagingAttachmentsAttachment&gt; GetWorkOrderNotesAttachments (int noteId, int workorderId, string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Retrieve Workorder Note Attachments

Retrieve Workorder Note Attachments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetWorkOrderNotesAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttachmentsApi(config);
            var noteId = 56;  // int | Note Identifier
            var workorderId = 56;  // int | Workorder Identifier
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Retrieve Workorder Note Attachments
                List<SCServiceChannelServicesMessagingAttachmentsAttachment> result = apiInstance.GetWorkOrderNotesAttachments(noteId, workorderId, expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.GetWorkOrderNotesAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkOrderNotesAttachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Workorder Note Attachments
    ApiResponse<List<SCServiceChannelServicesMessagingAttachmentsAttachment>> response = apiInstance.GetWorkOrderNotesAttachmentsWithHttpInfo(noteId, workorderId, expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.GetWorkOrderNotesAttachmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **noteId** | **int** | Note Identifier |  |
| **workorderId** | **int** | Workorder Identifier |  |
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingAttachmentsAttachment&gt;**](SCServiceChannelServicesMessagingAttachmentsAttachment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getworkorderattachmentthumbnail"></a>
# **GetWorkorderAttachmentThumbnail**
> SCSystemNetHttpByteArrayContent GetWorkorderAttachmentThumbnail (string imageFormat, string mode, int height, int width, int attachmentId, int workorderId, string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Retrieve Attachment Thumbnail

Retrieve Attachment Thumbnail

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetWorkorderAttachmentThumbnailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttachmentsApi(config);
            var imageFormat = "imageFormat_example";  // string | 
            var mode = "mode_example";  // string | 
            var height = 56;  // int | 
            var width = 56;  // int | 
            var attachmentId = 56;  // int | Attachment Identifier
            var workorderId = 56;  // int | Workorder Identifier
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Retrieve Attachment Thumbnail
                SCSystemNetHttpByteArrayContent result = apiInstance.GetWorkorderAttachmentThumbnail(imageFormat, mode, height, width, attachmentId, workorderId, expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.GetWorkorderAttachmentThumbnail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkorderAttachmentThumbnailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Attachment Thumbnail
    ApiResponse<SCSystemNetHttpByteArrayContent> response = apiInstance.GetWorkorderAttachmentThumbnailWithHttpInfo(imageFormat, mode, height, width, attachmentId, workorderId, expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.GetWorkorderAttachmentThumbnailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **imageFormat** | **string** |  |  |
| **mode** | **string** |  |  |
| **height** | **int** |  |  |
| **width** | **int** |  |  |
| **attachmentId** | **int** | Attachment Identifier |  |
| **workorderId** | **int** | Workorder Identifier |  |
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**SCSystemNetHttpByteArrayContent**](SCSystemNetHttpByteArrayContent.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="rfpsidattachments"></a>
# **RfpsidAttachments**
> void RfpsidAttachments (int id, System.IO.Stream file)

Add attchment to RFP

<para>Adds attchment to RFP. Returns RFP attachment Id for successful request.</para>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class RfpsidAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttachmentsApi(config);
            var id = 56;  // int | Rfp ID to perform action with.
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | File to attach to RFP

            try
            {
                // Add attchment to RFP
                apiInstance.RfpsidAttachments(id, file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.RfpsidAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RfpsidAttachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add attchment to RFP
    apiInstance.RfpsidAttachmentsWithHttpInfo(id, file);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.RfpsidAttachmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Rfp ID to perform action with. |  |
| **file** | **System.IO.Stream****System.IO.Stream** | File to attach to RFP |  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created indicates that the request resulted in a new resource created before the response was sent. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 501 - Failed to upload attachment;              &lt;br/&gt; 502 - Data not found. Returned if target Rfp is not found;              &lt;br/&gt; 503 - Request data is empty;              &lt;br/&gt;Invalid Attachment Request;              &lt;br/&gt;User info should not be null;              &lt;br/&gt;SubscriberId is null;              &lt;br/&gt;Cannot accept file(s) of this type;              &lt;br/&gt;The file that you&#39;re trying to attach has name that exceed the maximum allowable name length;              &lt;br/&gt;The file that you&#39;re trying to attach has length that exceed the maximum allowable length;              &lt;br/&gt;Empty Location or Store ID;              &lt;br/&gt;Empty Provider ID;              &lt;br/&gt;Provider is not valid; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="siteauditcommentscommentidattachments"></a>
# **SiteauditCommentscommentIdAttachments**
> List&lt;SCServiceChannelApiModelSiteAuditAttachmentInComment&gt; SiteauditCommentscommentIdAttachments (int commentId)

Returns list of attachment ids and urls.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SiteauditCommentscommentIdAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttachmentsApi(config);
            var commentId = 56;  // int | Numeric Id of the Comment which Attachment belongs to.

            try
            {
                // Returns list of attachment ids and urls.
                List<SCServiceChannelApiModelSiteAuditAttachmentInComment> result = apiInstance.SiteauditCommentscommentIdAttachments(commentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.SiteauditCommentscommentIdAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SiteauditCommentscommentIdAttachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns list of attachment ids and urls.
    ApiResponse<List<SCServiceChannelApiModelSiteAuditAttachmentInComment>> response = apiInstance.SiteauditCommentscommentIdAttachmentsWithHttpInfo(commentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.SiteauditCommentscommentIdAttachmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **commentId** | **int** | Numeric Id of the Comment which Attachment belongs to. |  |

### Return type

[**List&lt;SCServiceChannelApiModelSiteAuditAttachmentInComment&gt;**](SCServiceChannelApiModelSiteAuditAttachmentInComment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be executed or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 503 - validation fails; |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **404** | The requested resource does not exist on the server.              &lt;br/&gt;Error codes:              502 — Data not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="siteauditcommentscommentidattachments_0"></a>
# **SiteauditCommentscommentIdAttachments_0**
> void SiteauditCommentscommentIdAttachments_0 (int commentId, System.IO.Stream file)

Add attchment to Comment

Adds attchment to Comment. If Comment is not created yet specify {commentId} = -1.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SiteauditCommentscommentIdAttachments_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttachmentsApi(config);
            var commentId = 56;  // int | Numeric Id of the Comment to perform action with.
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | File to attach to Comment

            try
            {
                // Add attchment to Comment
                apiInstance.SiteauditCommentscommentIdAttachments_0(commentId, file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.SiteauditCommentscommentIdAttachments_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SiteauditCommentscommentIdAttachments_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add attchment to Comment
    apiInstance.SiteauditCommentscommentIdAttachments_0WithHttpInfo(commentId, file);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.SiteauditCommentscommentIdAttachments_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **commentId** | **int** | Numeric Id of the Comment to perform action with. |  |
| **file** | **System.IO.Stream****System.IO.Stream** | File to attach to Comment |  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created indicates that the request resulted in a new resource created before the response was sent. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 501 - Failed to upload attachment;              &lt;br/&gt; 502 - Data not found. Returned if target Comment is not found;              &lt;br/&gt; 503 - Request data is empty; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="siteauditcommentscommentidattachmentsattachmentid"></a>
# **SiteauditCommentscommentIdAttachmentsattachmentId**
> Object SiteauditCommentscommentIdAttachmentsattachmentId (int commentId, int attachmentId)

Retrieve original attchment from Comment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SiteauditCommentscommentIdAttachmentsattachmentIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttachmentsApi(config);
            var commentId = 56;  // int | Numeric Id of the Comment which Attachment belongs to.
            var attachmentId = 56;  // int | Numeric Id of the Attachment to perform action with.

            try
            {
                // Retrieve original attchment from Comment
                Object result = apiInstance.SiteauditCommentscommentIdAttachmentsattachmentId(commentId, attachmentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.SiteauditCommentscommentIdAttachmentsattachmentId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SiteauditCommentscommentIdAttachmentsattachmentIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve original attchment from Comment
    ApiResponse<Object> response = apiInstance.SiteauditCommentscommentIdAttachmentsattachmentIdWithHttpInfo(commentId, attachmentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.SiteauditCommentscommentIdAttachmentsattachmentIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **commentId** | **int** | Numeric Id of the Comment which Attachment belongs to. |  |
| **attachmentId** | **int** | Numeric Id of the Attachment to perform action with. |  |

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

<a id="siteauditcommentscommentidattachmentsattachmentidthumbnailwidthwidthheightheightmodemodeimageformatimageformat"></a>
# **SiteauditCommentscommentIdAttachmentsattachmentIdThumbnailwidthwidthheightheightmodemodeimageFormatimageFormat**
> Object SiteauditCommentscommentIdAttachmentsattachmentIdThumbnailwidthwidthheightheightmodemodeimageFormatimageFormat (int commentId, int attachmentId, int? width = null, int? height = null, string? mode = null, string? imageFormat = null)

Retrieve resized attchment from Comment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SiteauditCommentscommentIdAttachmentsattachmentIdThumbnailwidthwidthheightheightmodemodeimageFormatimageFormatExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttachmentsApi(config);
            var commentId = 56;  // int | Numeric Id of the Comment which Attachment belongs to.
            var attachmentId = 56;  // int | Numeric Id of the Attachment to perform action with.
            var width = 56;  // int? | Width of the output file. (optional) 
            var height = 56;  // int? | Height of the output file. (optional) 
            var mode = "None";  // string? | How to resolve aspect ratio differences between the requested size and the               original image's size: Max = 1, Pad = 2, Crop = 3, Carve = 4, Stretch = 5. (optional) 
            var imageFormat = "imageFormat_example";  // string? | The desired image format, like 'jpg', 'gif', or 'png'. Do not specify               if you want to preserve the original format. (optional) 

            try
            {
                // Retrieve resized attchment from Comment
                Object result = apiInstance.SiteauditCommentscommentIdAttachmentsattachmentIdThumbnailwidthwidthheightheightmodemodeimageFormatimageFormat(commentId, attachmentId, width, height, mode, imageFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.SiteauditCommentscommentIdAttachmentsattachmentIdThumbnailwidthwidthheightheightmodemodeimageFormatimageFormat: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SiteauditCommentscommentIdAttachmentsattachmentIdThumbnailwidthwidthheightheightmodemodeimageFormatimageFormatWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve resized attchment from Comment
    ApiResponse<Object> response = apiInstance.SiteauditCommentscommentIdAttachmentsattachmentIdThumbnailwidthwidthheightheightmodemodeimageFormatimageFormatWithHttpInfo(commentId, attachmentId, width, height, mode, imageFormat);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.SiteauditCommentscommentIdAttachmentsattachmentIdThumbnailwidthwidthheightheightmodemodeimageFormatimageFormatWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **commentId** | **int** | Numeric Id of the Comment which Attachment belongs to. |  |
| **attachmentId** | **int** | Numeric Id of the Attachment to perform action with. |  |
| **width** | **int?** | Width of the output file. | [optional]  |
| **height** | **int?** | Height of the output file. | [optional]  |
| **mode** | **string?** | How to resolve aspect ratio differences between the requested size and the               original image&#39;s size: Max &#x3D; 1, Pad &#x3D; 2, Crop &#x3D; 3, Carve &#x3D; 4, Stretch &#x3D; 5. | [optional]  |
| **imageFormat** | **string?** | The desired image format, like &#39;jpg&#39;, &#39;gif&#39;, or &#39;png&#39;. Do not specify               if you want to preserve the original format. | [optional]  |

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

<a id="workordersattachmentasbase64"></a>
# **WorkordersAttachmentAsBase64**
> void WorkordersAttachmentAsBase64 (SCServiceChannelServicesMessagingAttachmentsAddBase64AttachmentsRequest request)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersAttachmentAsBase64Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttachmentsApi(config);
            var request = new SCServiceChannelServicesMessagingAttachmentsAddBase64AttachmentsRequest(); // SCServiceChannelServicesMessagingAttachmentsAddBase64AttachmentsRequest | 

            try
            {
                apiInstance.WorkordersAttachmentAsBase64(request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.WorkordersAttachmentAsBase64: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersAttachmentAsBase64WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.WorkordersAttachmentAsBase64WithHttpInfo(request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.WorkordersAttachmentAsBase64WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**SCServiceChannelServicesMessagingAttachmentsAddBase64AttachmentsRequest**](SCServiceChannelServicesMessagingAttachmentsAddBase64AttachmentsRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created indicates that the request resulted in a new resource created before the response was sent. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 502 - Work Order not found;              &lt;br/&gt; 503 - Only for subscribers usage;                      &lt;br/&gt; 920 - Purchase number cannot be empty;              &lt;br/&gt; 946 - Work Order attachments size exceeded;              &lt;br/&gt; 9100 - There are multiple work orders with the same PO number; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersponumberattachmentsbyponumberactoractor"></a>
# **WorkorderspoNumberAttachmentsByPoNumberactoractor**
> void WorkorderspoNumberAttachmentsByPoNumberactoractor (string poNumber, string? actor = null, Object? addAttachmentsRequest = null, System.IO.Stream? file = null)

Add attachments to a work order by PO number

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkorderspoNumberAttachmentsByPoNumberactoractorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttachmentsApi(config);
            var poNumber = "poNumber_example";  // string | Purchase Order
            var actor = "actor_example";  // string? | On whose behalf the attachment is adding (optional) 
            var addAttachmentsRequest = new Object?(); // Object? |  (optional) 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream? | File to attach to the work order. (optional) 

            try
            {
                // Add attachments to a work order by PO number
                apiInstance.WorkorderspoNumberAttachmentsByPoNumberactoractor(poNumber, actor, addAttachmentsRequest, file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.WorkorderspoNumberAttachmentsByPoNumberactoractor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkorderspoNumberAttachmentsByPoNumberactoractorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add attachments to a work order by PO number
    apiInstance.WorkorderspoNumberAttachmentsByPoNumberactoractorWithHttpInfo(poNumber, actor, addAttachmentsRequest, file);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.WorkorderspoNumberAttachmentsByPoNumberactoractorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **poNumber** | **string** | Purchase Order |  |
| **actor** | **string?** | On whose behalf the attachment is adding | [optional]  |
| **addAttachmentsRequest** | [**Object?**](Object?.md) |  | [optional]  |
| **file** | **System.IO.Stream?****System.IO.Stream?** | File to attach to the work order. | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created indicates that the request resulted in a new resource created before the response was sent. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 502 - Work Order not found;              &lt;br/&gt; 503 - Only for subscribers usage;                      &lt;br/&gt; 920 - Purchase number cannot be empty;              &lt;br/&gt; 9100 - There are multiple work orders with the same PO number; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidattachmentsactoractor"></a>
# **WorkordersworkorderIdAttachmentsactoractor**
> void WorkordersworkorderIdAttachmentsactoractor (int workorderId, string? actor = null, Object? addAttachmentsRequest = null, System.IO.Stream? file = null)

Add attachments to a work order

Adds attachments to the specified work order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdAttachmentsactoractorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttachmentsApi(config);
            var workorderId = 56;  // int | Numeric ID of the work order to add attachments to.
            var actor = "actor_example";  // string? |  (optional) 
            var addAttachmentsRequest = new Object?(); // Object? |  (optional) 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream? | File to attach to the work order. (optional) 

            try
            {
                // Add attachments to a work order
                apiInstance.WorkordersworkorderIdAttachmentsactoractor(workorderId, actor, addAttachmentsRequest, file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.WorkordersworkorderIdAttachmentsactoractor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdAttachmentsactoractorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add attachments to a work order
    apiInstance.WorkordersworkorderIdAttachmentsactoractorWithHttpInfo(workorderId, actor, addAttachmentsRequest, file);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.WorkordersworkorderIdAttachmentsactoractorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Numeric ID of the work order to add attachments to. |  |
| **actor** | **string?** |  | [optional]  |
| **addAttachmentsRequest** | [**Object?**](Object?.md) |  | [optional]  |
| **file** | **System.IO.Stream?****System.IO.Stream?** | File to attach to the work order. | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created indicates that the request resulted in a new resource created before the response was sent. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 502 - Work Order not found; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidattachmentsattachmentidthumbnailwidthwidthheightheightmodemodeimageformatimageformat"></a>
# **WorkordersworkorderIdAttachmentsattachmentIdThumbnailwidthwidthheightheightmodemodeimageFormatimageFormat**
> Object WorkordersworkorderIdAttachmentsattachmentIdThumbnailwidthwidthheightheightmodemodeimageFormatimageFormat (int workorderId, int attachmentId, int? width = null, int? height = null, string? mode = null, string? imageFormat = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdAttachmentsattachmentIdThumbnailwidthwidthheightheightmodemodeimageFormatimageFormatExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttachmentsApi(config);
            var workorderId = 56;  // int | 
            var attachmentId = 56;  // int | 
            var width = 56;  // int? |  (optional) 
            var height = 56;  // int? |  (optional) 
            var mode = "None";  // string? |  (optional) 
            var imageFormat = "imageFormat_example";  // string? |  (optional) 

            try
            {
                Object result = apiInstance.WorkordersworkorderIdAttachmentsattachmentIdThumbnailwidthwidthheightheightmodemodeimageFormatimageFormat(workorderId, attachmentId, width, height, mode, imageFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.WorkordersworkorderIdAttachmentsattachmentIdThumbnailwidthwidthheightheightmodemodeimageFormatimageFormat: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdAttachmentsattachmentIdThumbnailwidthwidthheightheightmodemodeimageFormatimageFormatWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.WorkordersworkorderIdAttachmentsattachmentIdThumbnailwidthwidthheightheightmodemodeimageFormatimageFormatWithHttpInfo(workorderId, attachmentId, width, height, mode, imageFormat);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.WorkordersworkorderIdAttachmentsattachmentIdThumbnailwidthwidthheightheightmodemodeimageFormatimageFormatWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** |  |  |
| **attachmentId** | **int** |  |  |
| **width** | **int?** |  | [optional]  |
| **height** | **int?** |  | [optional]  |
| **mode** | **string?** |  | [optional]  |
| **imageFormat** | **string?** |  | [optional]  |

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

<a id="workordersworkorderidnotesnoteidattachments"></a>
# **WorkordersworkorderIdNotesnoteIdAttachments**
> void WorkordersworkorderIdNotesnoteIdAttachments (int workorderId, int noteId, System.IO.Stream file, Object? addAttachmentsRequest = null)

Add Attachments to Work Order Note

<para>Add Attachments to Work Order Note. Returns list of attachments Id for successful request.</para>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdNotesnoteIdAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttachmentsApi(config);
            var workorderId = 56;  // int | Numeric Id of the Work order to perform action with.
            var noteId = 56;  // int | Numeric Id of the Note to perform action with.
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | File to attach to note
            var addAttachmentsRequest = new Object?(); // Object? | Optional Descriptor for file(s) (optional) 

            try
            {
                // Add Attachments to Work Order Note
                apiInstance.WorkordersworkorderIdNotesnoteIdAttachments(workorderId, noteId, file, addAttachmentsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.WorkordersworkorderIdNotesnoteIdAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdNotesnoteIdAttachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Attachments to Work Order Note
    apiInstance.WorkordersworkorderIdNotesnoteIdAttachmentsWithHttpInfo(workorderId, noteId, file, addAttachmentsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.WorkordersworkorderIdNotesnoteIdAttachmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Numeric Id of the Work order to perform action with. |  |
| **noteId** | **int** | Numeric Id of the Note to perform action with. |  |
| **file** | **System.IO.Stream****System.IO.Stream** | File to attach to note |  |
| **addAttachmentsRequest** | [**Object?**](Object?.md) | Optional Descriptor for file(s) | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created indicates that the request resulted in a new resource created before the response was sent. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 503 - Validation fails;              &lt;br/&gt; 917 - InvalidWoIdentifier; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workrequestworkrequestidnotesnoteidattachments"></a>
# **WorkrequestWorkRequestIdNotesNoteIdAttachments**
> List&lt;SCServiceChannelServicesMessagingAttachmentsAttachment&gt; WorkrequestWorkRequestIdNotesNoteIdAttachments (int workRequestId, int noteId)

Get WorkRequest Note Attachments

*In limited availability phase.*

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkrequestWorkRequestIdNotesNoteIdAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttachmentsApi(config);
            var workRequestId = 56;  // int | WorkRequest Identifier
            var noteId = 56;  // int | Note Identifier

            try
            {
                // Get WorkRequest Note Attachments
                List<SCServiceChannelServicesMessagingAttachmentsAttachment> result = apiInstance.WorkrequestWorkRequestIdNotesNoteIdAttachments(workRequestId, noteId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.WorkrequestWorkRequestIdNotesNoteIdAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkrequestWorkRequestIdNotesNoteIdAttachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get WorkRequest Note Attachments
    ApiResponse<List<SCServiceChannelServicesMessagingAttachmentsAttachment>> response = apiInstance.WorkrequestWorkRequestIdNotesNoteIdAttachmentsWithHttpInfo(workRequestId, noteId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.WorkrequestWorkRequestIdNotesNoteIdAttachmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workRequestId** | **int** | WorkRequest Identifier |  |
| **noteId** | **int** | Note Identifier |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingAttachmentsAttachment&gt;**](SCServiceChannelServicesMessagingAttachmentsAttachment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workrequestworkrequestidattachments"></a>
# **WorkrequestworkRequestIdAttachments**
> List&lt;SCServiceChannelServicesMessagingAttachmentsAttachment&gt; WorkrequestworkRequestIdAttachments (int workRequestId)

Get WorkRequest Attachments

*In limited availability phase.*

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkrequestworkRequestIdAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttachmentsApi(config);
            var workRequestId = 56;  // int | WorkRequest Identifier

            try
            {
                // Get WorkRequest Attachments
                List<SCServiceChannelServicesMessagingAttachmentsAttachment> result = apiInstance.WorkrequestworkRequestIdAttachments(workRequestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.WorkrequestworkRequestIdAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkrequestworkRequestIdAttachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get WorkRequest Attachments
    ApiResponse<List<SCServiceChannelServicesMessagingAttachmentsAttachment>> response = apiInstance.WorkrequestworkRequestIdAttachmentsWithHttpInfo(workRequestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.WorkrequestworkRequestIdAttachmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workRequestId** | **int** | WorkRequest Identifier |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingAttachmentsAttachment&gt;**](SCServiceChannelServicesMessagingAttachmentsAttachment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workrequestworkrequestidattachmentsactoractor"></a>
# **WorkrequestworkRequestIdAttachmentsactoractor**
> void WorkrequestworkRequestIdAttachmentsactoractor (int workRequestId, System.IO.Stream file, string? actor = null, Object? addAttachmentsRequest = null)

Add attachments to a WorkRequest

*In limited availability phase.*              <br />Adds attachments to the specified WorkRequest.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkrequestworkRequestIdAttachmentsactoractorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttachmentsApi(config);
            var workRequestId = 56;  // int | Numeric ID of the WorkRequest to add attachments to.
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | File to attach to the work request.
            var actor = "actor_example";  // string? | Name of the person on whose behalf you are performing the action (optional) 
            var addAttachmentsRequest = new Object?(); // Object? |  (optional) 

            try
            {
                // Add attachments to a WorkRequest
                apiInstance.WorkrequestworkRequestIdAttachmentsactoractor(workRequestId, file, actor, addAttachmentsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.WorkrequestworkRequestIdAttachmentsactoractor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkrequestworkRequestIdAttachmentsactoractorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add attachments to a WorkRequest
    apiInstance.WorkrequestworkRequestIdAttachmentsactoractorWithHttpInfo(workRequestId, file, actor, addAttachmentsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.WorkrequestworkRequestIdAttachmentsactoractorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workRequestId** | **int** | Numeric ID of the WorkRequest to add attachments to. |  |
| **file** | **System.IO.Stream****System.IO.Stream** | File to attach to the work request. |  |
| **actor** | **string?** | Name of the person on whose behalf you are performing the action | [optional]  |
| **addAttachmentsRequest** | [**Object?**](Object?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created indicates that the request resulted in a new resource created before the response was sent. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 502 - Work Request not found; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workrequestworkrequestidnotesnoteidattachments"></a>
# **WorkrequestworkRequestIdNotesnoteIdAttachments**
> void WorkrequestworkRequestIdNotesnoteIdAttachments (int workRequestId, int noteId, System.IO.Stream file, Object? addAttachmentsRequest = null)

Add Attachments to Work Request Note

*In limited availability phase.*              <br />Add Attachments to Work Request Note. Returns list of attachments Id for successful request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkrequestworkRequestIdNotesnoteIdAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttachmentsApi(config);
            var workRequestId = 56;  // int | Numeric Id of the Work Request to perform action with.
            var noteId = 56;  // int | Numeric Id of the Note to perform action with.
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | File to attach to note
            var addAttachmentsRequest = new Object?(); // Object? | Optional Descriptor for file(s) (optional) 

            try
            {
                // Add Attachments to Work Request Note
                apiInstance.WorkrequestworkRequestIdNotesnoteIdAttachments(workRequestId, noteId, file, addAttachmentsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.WorkrequestworkRequestIdNotesnoteIdAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkrequestworkRequestIdNotesnoteIdAttachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Attachments to Work Request Note
    apiInstance.WorkrequestworkRequestIdNotesnoteIdAttachmentsWithHttpInfo(workRequestId, noteId, file, addAttachmentsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.WorkrequestworkRequestIdNotesnoteIdAttachmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workRequestId** | **int** | Numeric Id of the Work Request to perform action with. |  |
| **noteId** | **int** | Numeric Id of the Note to perform action with. |  |
| **file** | **System.IO.Stream****System.IO.Stream** | File to attach to note |  |
| **addAttachmentsRequest** | [**Object?**](Object?.md) | Optional Descriptor for file(s) | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created indicates that the request resulted in a new resource created before the response was sent. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 503 - Validation fails;              &lt;br/&gt; 8020 - InvalidWorkRequestIdentifier; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

