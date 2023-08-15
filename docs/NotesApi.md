# ServiceChannel.Api.Api.NotesApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetWorkOrderNote**](NotesApi.md#getworkordernote) | **GET** /odata/workorders({workorderId})/notes({noteId}) | Retrieve Work Order Note |
| [**GetWorkOrderNotes**](NotesApi.md#getworkordernotes) | **GET** /odata/workorders({workorderId})/notes | Retrieve Work Order Notes |
| [**WorkordersworkorderIdNotes**](NotesApi.md#workordersworkorderidnotes) | **POST** /workorders/{workorderId}/notes | Create a Work order Note |
| [**WorkordersworkorderIdNotesFollowers**](NotesApi.md#workordersworkorderidnotesfollowers) | **POST** /workorders/{workorderId}/notes/followers | Add Followers to Work order notes |
| [**WorkordersworkorderIdNotesFollowersemailemail**](NotesApi.md#workordersworkorderidnotesfollowersemailemail) | **DELETE** /workorders/{workorderId}/notes/followers | Remove Follower from Work order notes |
| [**WorkordersworkorderIdNotesRecipientsshowExcludedshowExcludednoteVisibilitynoteVisibility**](NotesApi.md#workordersworkorderidnotesrecipientsshowexcludedshowexcludednotevisibilitynotevisibility) | **GET** /workorders/{workorderId}/notes/recipients | Note email recipients |
| [**WorkordersworkorderIdNotespagingpaging**](NotesApi.md#workordersworkorderidnotespagingpaging) | **GET** /workorders/{workorderId}/notes | Work order Notes Collection |

<a id="getworkordernote"></a>
# **GetWorkOrderNote**
> List&lt;SCServiceChannelServicesMessagingNotesNote&gt; GetWorkOrderNote (int noteId, int workorderId, string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Retrieve Work Order Note

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetWorkOrderNoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotesApi(config);
            var noteId = 56;  // int | 
            var workorderId = 56;  // int | 
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Retrieve Work Order Note
                List<SCServiceChannelServicesMessagingNotesNote> result = apiInstance.GetWorkOrderNote(noteId, workorderId, expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotesApi.GetWorkOrderNote: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkOrderNoteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Work Order Note
    ApiResponse<List<SCServiceChannelServicesMessagingNotesNote>> response = apiInstance.GetWorkOrderNoteWithHttpInfo(noteId, workorderId, expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotesApi.GetWorkOrderNoteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **noteId** | **int** |  |  |
| **workorderId** | **int** |  |  |
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingNotesNote&gt;**](SCServiceChannelServicesMessagingNotesNote.md)

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

<a id="getworkordernotes"></a>
# **GetWorkOrderNotes**
> List&lt;SCServiceChannelServicesMessagingNotesNote&gt; GetWorkOrderNotes (int workorderId, string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Retrieve Work Order Notes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetWorkOrderNotesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotesApi(config);
            var workorderId = 56;  // int | 
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Retrieve Work Order Notes
                List<SCServiceChannelServicesMessagingNotesNote> result = apiInstance.GetWorkOrderNotes(workorderId, expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotesApi.GetWorkOrderNotes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkOrderNotesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Work Order Notes
    ApiResponse<List<SCServiceChannelServicesMessagingNotesNote>> response = apiInstance.GetWorkOrderNotesWithHttpInfo(workorderId, expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotesApi.GetWorkOrderNotesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** |  |  |
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingNotesNote&gt;**](SCServiceChannelServicesMessagingNotesNote.md)

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

<a id="workordersworkorderidnotes"></a>
# **WorkordersworkorderIdNotes**
> void WorkordersworkorderIdNotes (int workorderId, SCServiceChannelServicesMessagingWorkordersCreateWoNoteRequest noteRequest)

Create a Work order Note

Returns Note Id for successful request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdNotesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotesApi(config);
            var workorderId = 56;  // int | Numeric Id of the Work order to perform action with.
            var noteRequest = new SCServiceChannelServicesMessagingWorkordersCreateWoNoteRequest(); // SCServiceChannelServicesMessagingWorkordersCreateWoNoteRequest | The note request model.

            try
            {
                // Create a Work order Note
                apiInstance.WorkordersworkorderIdNotes(workorderId, noteRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotesApi.WorkordersworkorderIdNotes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdNotesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a Work order Note
    apiInstance.WorkordersworkorderIdNotesWithHttpInfo(workorderId, noteRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotesApi.WorkordersworkorderIdNotesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Numeric Id of the Work order to perform action with. |  |
| **noteRequest** | [**SCServiceChannelServicesMessagingWorkordersCreateWoNoteRequest**](SCServiceChannelServicesMessagingWorkordersCreateWoNoteRequest.md) | The note request model. |  |

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
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 100 - You don&#39;t have location access to perform this operation;              &lt;br/&gt; 503 - Validation fails. Invalid WorkOrder Id or Note value; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidnotesfollowers"></a>
# **WorkordersworkorderIdNotesFollowers**
> void WorkordersworkorderIdNotesFollowers (int workorderId, SCServiceChannelServicesMessagingWorkordersAddFollowersRequest request)

Add Followers to Work order notes

<para>Add Followers to Work order.</para>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdNotesFollowersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotesApi(config);
            var workorderId = 56;  // int | Numeric Id of the Work order to perform action with.
            var request = new SCServiceChannelServicesMessagingWorkordersAddFollowersRequest(); // SCServiceChannelServicesMessagingWorkordersAddFollowersRequest | The request model to perform action with.

            try
            {
                // Add Followers to Work order notes
                apiInstance.WorkordersworkorderIdNotesFollowers(workorderId, request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotesApi.WorkordersworkorderIdNotesFollowers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdNotesFollowersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Followers to Work order notes
    apiInstance.WorkordersworkorderIdNotesFollowersWithHttpInfo(workorderId, request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotesApi.WorkordersworkorderIdNotesFollowersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Numeric Id of the Work order to perform action with. |  |
| **request** | [**SCServiceChannelServicesMessagingWorkordersAddFollowersRequest**](SCServiceChannelServicesMessagingWorkordersAddFollowersRequest.md) | The request model to perform action with. |  |

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
| **400** | Bad Request - the request could not be understood or was missing required parameters.&lt;br&gt;Error codes:&lt;br&gt;503 - Request data is empty;&lt;br&gt;There is no followers in request;&lt;br&gt;Empty tracking number (workorder Id); |  -  |
| **404** | Indicates that the requested resource does not exist on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidnotesfollowersemailemail"></a>
# **WorkordersworkorderIdNotesFollowersemailemail**
> void WorkordersworkorderIdNotesFollowersemailemail (int workorderId, string email)

Remove Follower from Work order notes

<para>Remove Follower from Work order.</para>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdNotesFollowersemailemailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotesApi(config);
            var workorderId = 56;  // int | Numeric Id of the Work order to perform action with.
            var email = "email_example";  // string | The follower email address.

            try
            {
                // Remove Follower from Work order notes
                apiInstance.WorkordersworkorderIdNotesFollowersemailemail(workorderId, email);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotesApi.WorkordersworkorderIdNotesFollowersemailemail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdNotesFollowersemailemailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Follower from Work order notes
    apiInstance.WorkordersworkorderIdNotesFollowersemailemailWithHttpInfo(workorderId, email);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotesApi.WorkordersworkorderIdNotesFollowersemailemailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Numeric Id of the Work order to perform action with. |  |
| **email** | **string** | The follower email address. |  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.&lt;br&gt;Error codes:&lt;br&gt;503 - Request data is empty;&lt;br&gt;There is no followers in request;&lt;br&gt;Empty tracking number (workorder Id); |  -  |
| **404** | Indicates that the requested resource does not exist on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidnotesrecipientsshowexcludedshowexcludednotevisibilitynotevisibility"></a>
# **WorkordersworkorderIdNotesRecipientsshowExcludedshowExcludednoteVisibilitynoteVisibility**
> List&lt;SCServiceChannelServicesMessagingNotesEmailRecipientResponse&gt; WorkordersworkorderIdNotesRecipientsshowExcludedshowExcludednoteVisibilitynoteVisibility (int workorderId, bool? showExcluded = null, string? noteVisibility = null)

Note email recipients

<para>List of email recipients, who can be added to the list of note followers</para>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdNotesRecipientsshowExcludedshowExcludednoteVisibilitynoteVisibilityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotesApi(config);
            var workorderId = 56;  // int | Numeric Id of the Work order to perform action with.
            var showExcluded = false;  // bool? | If set to true, returns all recipients even those that have 'exclude from note recipient' flag in their setup. False by Default. (optional)  (default to false)
            var noteVisibility = "VisibleToEveryone";  // string? | NoteVisibility.Public is used by default (optional) 

            try
            {
                // Note email recipients
                List<SCServiceChannelServicesMessagingNotesEmailRecipientResponse> result = apiInstance.WorkordersworkorderIdNotesRecipientsshowExcludedshowExcludednoteVisibilitynoteVisibility(workorderId, showExcluded, noteVisibility);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotesApi.WorkordersworkorderIdNotesRecipientsshowExcludedshowExcludednoteVisibilitynoteVisibility: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdNotesRecipientsshowExcludedshowExcludednoteVisibilitynoteVisibilityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Note email recipients
    ApiResponse<List<SCServiceChannelServicesMessagingNotesEmailRecipientResponse>> response = apiInstance.WorkordersworkorderIdNotesRecipientsshowExcludedshowExcludednoteVisibilitynoteVisibilityWithHttpInfo(workorderId, showExcluded, noteVisibility);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotesApi.WorkordersworkorderIdNotesRecipientsshowExcludedshowExcludednoteVisibilitynoteVisibilityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Numeric Id of the Work order to perform action with. |  |
| **showExcluded** | **bool?** | If set to true, returns all recipients even those that have &#39;exclude from note recipient&#39; flag in their setup. False by Default. | [optional] [default to false] |
| **noteVisibility** | **string?** | NoteVisibility.Public is used by default | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingNotesEmailRecipientResponse&gt;**](SCServiceChannelServicesMessagingNotesEmailRecipientResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 917 - Invalid work order identifier. Returned if workorderId is &amp;lt;&#x3D; 0; |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **404** | The requested resource does not exist on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workordersworkorderidnotespagingpaging"></a>
# **WorkordersworkorderIdNotespagingpaging**
> SCServiceChannelServicesMessagingNotesGetNotesResponse WorkordersworkorderIdNotespagingpaging (int workorderId, string? paging = null)

Work order Notes Collection

Returns list of work order notes, sorted descending by creation date.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkordersworkorderIdNotespagingpagingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotesApi(config);
            var workorderId = 56;  // int | Numeric Id of the Work order to perform action with.
            var paging = "paging_example";  // string? | Paging of the collection. Format of the string is: 'pageNumber:pageSize', be advised that pageNumber starts with 1 not 0 Default: \"1:10\".              To get all notes specify page size as some big number which is 100% bigger then total notes count (9999 works for all cases) and page number as 1. (optional) 

            try
            {
                // Work order Notes Collection
                SCServiceChannelServicesMessagingNotesGetNotesResponse result = apiInstance.WorkordersworkorderIdNotespagingpaging(workorderId, paging);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotesApi.WorkordersworkorderIdNotespagingpaging: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkordersworkorderIdNotespagingpagingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Work order Notes Collection
    ApiResponse<SCServiceChannelServicesMessagingNotesGetNotesResponse> response = apiInstance.WorkordersworkorderIdNotespagingpagingWithHttpInfo(workorderId, paging);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotesApi.WorkordersworkorderIdNotespagingpagingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workorderId** | **int** | Numeric Id of the Work order to perform action with. |  |
| **paging** | **string?** | Paging of the collection. Format of the string is: &#39;pageNumber:pageSize&#39;, be advised that pageNumber starts with 1 not 0 Default: \&quot;1:10\&quot;.              To get all notes specify page size as some big number which is 100% bigger then total notes count (9999 works for all cases) and page number as 1. | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingNotesGetNotesResponse**](SCServiceChannelServicesMessagingNotesGetNotesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 917 - Invalid work order identifier. Returned if workorderId is &amp;lt;&#x3D; 0;              &lt;br/&gt; 922 - Invalid paging parameter. Returned if paging parameter doesn&#39;t correspond to valid format;              &lt;br/&gt; 100 - You don&#39;t have location access to perform this operation; |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

