# ServiceChannel.Api.Api.WorkRequestNoteApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**WorkrequestsworkrequestIdNotes**](WorkRequestNoteApi.md#workrequestsworkrequestidnotes) | **POST** /workrequests/{workrequestId}/notes | Creates a work request note |
| [**WorkrequestsworkrequestIdNotesFollowers**](WorkRequestNoteApi.md#workrequestsworkrequestidnotesfollowers) | **POST** /workrequests/{workrequestId}/notes/followers | Add Followers to Work request |
| [**WorkrequestsworkrequestIdNotesFollowersemailemail**](WorkRequestNoteApi.md#workrequestsworkrequestidnotesfollowersemailemail) | **DELETE** /workrequests/{workrequestId}/notes/followers | Remove Follower from Work request |
| [**WorkrequestsworkrequestIdNotespageNumberpageNumberpageSizepageSize**](WorkRequestNoteApi.md#workrequestsworkrequestidnotespagenumberpagenumberpagesizepagesize) | **GET** /workrequests/{workrequestId}/notes | Work request Notes Collection |

<a id="workrequestsworkrequestidnotes"></a>
# **WorkrequestsworkrequestIdNotes**
> void WorkrequestsworkrequestIdNotes (int workrequestId, SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestNoteRequest noteRequest)

Creates a work request note

*In limited availability phase.*              <br />Returns Note Id for successful request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkrequestsworkrequestIdNotesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkRequestNoteApi(config);
            var workrequestId = 56;  // int | Numeric Id of the Work request to perform action with.
            var noteRequest = new SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestNoteRequest(); // SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestNoteRequest | The note request model.

            try
            {
                // Creates a work request note
                apiInstance.WorkrequestsworkrequestIdNotes(workrequestId, noteRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkRequestNoteApi.WorkrequestsworkrequestIdNotes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkrequestsworkrequestIdNotesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a work request note
    apiInstance.WorkrequestsworkrequestIdNotesWithHttpInfo(workrequestId, noteRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkRequestNoteApi.WorkrequestsworkrequestIdNotesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workrequestId** | **int** | Numeric Id of the Work request to perform action with. |  |
| **noteRequest** | [**SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestNoteRequest**](SCServiceChannelServicesMessagingWorkRequestsCreateWorkRequestNoteRequest.md) | The note request model. |  |

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
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 100 - You don&#39;t have location access to perform this operation;              &lt;br/&gt; 503 - Validation fails. Invalid WorkRequest Id or Note value;              &lt;br/&gt; 8020 - Invalid work request identifier.Returned if workrequestId is &amp;lt;&#x3D; 0; |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workrequestsworkrequestidnotesfollowers"></a>
# **WorkrequestsworkrequestIdNotesFollowers**
> void WorkrequestsworkrequestIdNotesFollowers (int workrequestId, SCServiceChannelServicesMessagingWorkRequestsAddWorkRequestNoteFollowersRequest request)

Add Followers to Work request

*In limited availability phase.*              <br />Returns status \"OK\" for successful request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkrequestsworkrequestIdNotesFollowersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkRequestNoteApi(config);
            var workrequestId = 56;  // int | Numeric Id of the Work request to perform action with.
            var request = new SCServiceChannelServicesMessagingWorkRequestsAddWorkRequestNoteFollowersRequest(); // SCServiceChannelServicesMessagingWorkRequestsAddWorkRequestNoteFollowersRequest | The request model to perform action with.

            try
            {
                // Add Followers to Work request
                apiInstance.WorkrequestsworkrequestIdNotesFollowers(workrequestId, request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkRequestNoteApi.WorkrequestsworkrequestIdNotesFollowers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkrequestsworkrequestIdNotesFollowersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Followers to Work request
    apiInstance.WorkrequestsworkrequestIdNotesFollowersWithHttpInfo(workrequestId, request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkRequestNoteApi.WorkrequestsworkrequestIdNotesFollowersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workrequestId** | **int** | Numeric Id of the Work request to perform action with. |  |
| **request** | [**SCServiceChannelServicesMessagingWorkRequestsAddWorkRequestNoteFollowersRequest**](SCServiceChannelServicesMessagingWorkRequestsAddWorkRequestNoteFollowersRequest.md) | The request model to perform action with. |  |

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
| **200** | Created indicates that the request resulted in a new resource created before the response was sent. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.&lt;br&gt;Error codes:&lt;br&gt;503 - Request data is empty;&lt;br&gt;There is no followers in request;&lt;br&gt;Empty tracking number (workrequest Id); |  -  |
| **404** | Indicates that the requested resource does not exist on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="workrequestsworkrequestidnotesfollowersemailemail"></a>
# **WorkrequestsworkrequestIdNotesFollowersemailemail**
> void WorkrequestsworkrequestIdNotesFollowersemailemail (int workrequestId, string email)

Remove Follower from Work request

*In limited availability phase.*              <br />Returns status \"OK\" for successful request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkrequestsworkrequestIdNotesFollowersemailemailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkRequestNoteApi(config);
            var workrequestId = 56;  // int | Numeric Id of the Work request to perform action with.
            var email = "email_example";  // string | Follower email.

            try
            {
                // Remove Follower from Work request
                apiInstance.WorkrequestsworkrequestIdNotesFollowersemailemail(workrequestId, email);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkRequestNoteApi.WorkrequestsworkrequestIdNotesFollowersemailemail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkrequestsworkrequestIdNotesFollowersemailemailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Follower from Work request
    apiInstance.WorkrequestsworkrequestIdNotesFollowersemailemailWithHttpInfo(workrequestId, email);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkRequestNoteApi.WorkrequestsworkrequestIdNotesFollowersemailemailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workrequestId** | **int** | Numeric Id of the Work request to perform action with. |  |
| **email** | **string** | Follower email. |  |

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

<a id="workrequestsworkrequestidnotespagenumberpagenumberpagesizepagesize"></a>
# **WorkrequestsworkrequestIdNotespageNumberpageNumberpageSizepageSize**
> void WorkrequestsworkrequestIdNotespageNumberpageNumberpageSizepageSize (int workrequestId, int pageNumber, int pageSize)

Work request Notes Collection

*In limited availability phase.*              <br />Returns list of work request notes, sorted descending by creation date.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class WorkrequestsworkrequestIdNotespageNumberpageNumberpageSizepageSizeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkRequestNoteApi(config);
            var workrequestId = 56;  // int | Numeric Id of the Work request to perform action with.
            var pageNumber = 56;  // int | Page number.
            var pageSize = 56;  // int | Page size.

            try
            {
                // Work request Notes Collection
                apiInstance.WorkrequestsworkrequestIdNotespageNumberpageNumberpageSizepageSize(workrequestId, pageNumber, pageSize);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkRequestNoteApi.WorkrequestsworkrequestIdNotespageNumberpageNumberpageSizepageSize: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkrequestsworkrequestIdNotespageNumberpageNumberpageSizepageSizeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Work request Notes Collection
    apiInstance.WorkrequestsworkrequestIdNotespageNumberpageNumberpageSizepageSizeWithHttpInfo(workrequestId, pageNumber, pageSize);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkRequestNoteApi.WorkrequestsworkrequestIdNotespageNumberpageNumberpageSizepageSizeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workrequestId** | **int** | Numeric Id of the Work request to perform action with. |  |
| **pageNumber** | **int** | Page number. |  |
| **pageSize** | **int** | Page size. |  |

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
| **200** | Request succeeded and the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 8020 - Invalid work request identifier. Returned if workrequestId is &amp;lt;&#x3D; 0;              &lt;br/&gt; 922 - Invalid paging parameter. Returned if paging parameter doesn&#39;t correspond to valid format;              &lt;br/&gt; 100 - You don&#39;t have location access to perform this operation; |  -  |
| **401** | Unauthorized indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

