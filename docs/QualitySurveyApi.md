# ServiceChannel.Api.Api.QualitySurveyApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiQualitySurveyGetQualitySurveysubscriberIdsubscriberId**](QualitySurveyApi.md#apiqualitysurveygetqualitysurveysubscriberidsubscriberid) | **GET** /api/QualitySurvey/GetQualitySurvey | The get quality survey. |
| [**ApiQualitySurveyrecordIdrecordId**](QualitySurveyApi.md#apiqualitysurveyrecordidrecordid) | **GET** /api/QualitySurvey | The get. |
| [**ApiQualitySurveyrecordIdrecordIdrespondentrespondentcreatorcreatornotesnotes**](QualitySurveyApi.md#apiqualitysurveyrecordidrecordidrespondentrespondentcreatorcreatornotesnotes) | **PUT** /api/QualitySurvey | The put. |
| [**QualitySurveyrecordId**](QualitySurveyApi.md#qualitysurveyrecordid) | **GET** /QualitySurvey/{recordId} | The get. |
| [**QualitySurveyrecordIdrespondentrespondentcreatorcreatornotesnotes**](QualitySurveyApi.md#qualitysurveyrecordidrespondentrespondentcreatorcreatornotesnotes) | **PUT** /QualitySurvey/{recordId} | The put. |
| [**SubscriberssubscriberIdQualitySurvey**](QualitySurveyApi.md#subscriberssubscriberidqualitysurvey) | **GET** /subscribers/{subscriberId}/QualitySurvey | The get quality survey. |

<a id="apiqualitysurveygetqualitysurveysubscriberidsubscriberid"></a>
# **ApiQualitySurveyGetQualitySurveysubscriberIdsubscriberId**
> Object ApiQualitySurveyGetQualitySurveysubscriberIdsubscriberId (int subscriberId)

The get quality survey.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ApiQualitySurveyGetQualitySurveysubscriberIdsubscriberIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new QualitySurveyApi(config);
            var subscriberId = 56;  // int | The subscriber id.

            try
            {
                // The get quality survey.
                Object result = apiInstance.ApiQualitySurveyGetQualitySurveysubscriberIdsubscriberId(subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QualitySurveyApi.ApiQualitySurveyGetQualitySurveysubscriberIdsubscriberId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiQualitySurveyGetQualitySurveysubscriberIdsubscriberIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The get quality survey.
    ApiResponse<Object> response = apiInstance.ApiQualitySurveyGetQualitySurveysubscriberIdsubscriberIdWithHttpInfo(subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QualitySurveyApi.ApiQualitySurveyGetQualitySurveysubscriberIdsubscriberIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** | The subscriber id. |  |

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

<a id="apiqualitysurveyrecordidrecordid"></a>
# **ApiQualitySurveyrecordIdrecordId**
> Object ApiQualitySurveyrecordIdrecordId (int recordId)

The get.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ApiQualitySurveyrecordIdrecordIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new QualitySurveyApi(config);
            var recordId = 56;  // int | The record id.

            try
            {
                // The get.
                Object result = apiInstance.ApiQualitySurveyrecordIdrecordId(recordId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QualitySurveyApi.ApiQualitySurveyrecordIdrecordId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiQualitySurveyrecordIdrecordIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The get.
    ApiResponse<Object> response = apiInstance.ApiQualitySurveyrecordIdrecordIdWithHttpInfo(recordId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QualitySurveyApi.ApiQualitySurveyrecordIdrecordIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **recordId** | **int** | The record id. |  |

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

<a id="apiqualitysurveyrecordidrecordidrespondentrespondentcreatorcreatornotesnotes"></a>
# **ApiQualitySurveyrecordIdrecordIdrespondentrespondentcreatorcreatornotesnotes**
> Object ApiQualitySurveyrecordIdrecordIdrespondentrespondentcreatorcreatornotesnotes (int recordId, string respondent, string creator, string notes, List<int> answerIds)

The put.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ApiQualitySurveyrecordIdrecordIdrespondentrespondentcreatorcreatornotesnotesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new QualitySurveyApi(config);
            var recordId = 56;  // int | The record id.
            var respondent = "respondent_example";  // string | The respondent.
            var creator = "creator_example";  // string | The creator.
            var notes = "notes_example";  // string | The notes.
            var answerIds = new List<int>(); // List<int> | The answer ids.

            try
            {
                // The put.
                Object result = apiInstance.ApiQualitySurveyrecordIdrecordIdrespondentrespondentcreatorcreatornotesnotes(recordId, respondent, creator, notes, answerIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QualitySurveyApi.ApiQualitySurveyrecordIdrecordIdrespondentrespondentcreatorcreatornotesnotes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiQualitySurveyrecordIdrecordIdrespondentrespondentcreatorcreatornotesnotesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The put.
    ApiResponse<Object> response = apiInstance.ApiQualitySurveyrecordIdrecordIdrespondentrespondentcreatorcreatornotesnotesWithHttpInfo(recordId, respondent, creator, notes, answerIds);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QualitySurveyApi.ApiQualitySurveyrecordIdrecordIdrespondentrespondentcreatorcreatornotesnotesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **recordId** | **int** | The record id. |  |
| **respondent** | **string** | The respondent. |  |
| **creator** | **string** | The creator. |  |
| **notes** | **string** | The notes. |  |
| **answerIds** | [**List&lt;int&gt;**](int.md) | The answer ids. |  |

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

<a id="qualitysurveyrecordid"></a>
# **QualitySurveyrecordId**
> Object QualitySurveyrecordId (int recordId)

The get.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class QualitySurveyrecordIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new QualitySurveyApi(config);
            var recordId = 56;  // int | The record id.

            try
            {
                // The get.
                Object result = apiInstance.QualitySurveyrecordId(recordId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QualitySurveyApi.QualitySurveyrecordId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QualitySurveyrecordIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The get.
    ApiResponse<Object> response = apiInstance.QualitySurveyrecordIdWithHttpInfo(recordId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QualitySurveyApi.QualitySurveyrecordIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **recordId** | **int** | The record id. |  |

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

<a id="qualitysurveyrecordidrespondentrespondentcreatorcreatornotesnotes"></a>
# **QualitySurveyrecordIdrespondentrespondentcreatorcreatornotesnotes**
> Object QualitySurveyrecordIdrespondentrespondentcreatorcreatornotesnotes (int recordId, string respondent, string creator, string notes, List<int> answerIds)

The put.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class QualitySurveyrecordIdrespondentrespondentcreatorcreatornotesnotesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new QualitySurveyApi(config);
            var recordId = 56;  // int | The record id.
            var respondent = "respondent_example";  // string | The respondent.
            var creator = "creator_example";  // string | The creator.
            var notes = "notes_example";  // string | The notes.
            var answerIds = new List<int>(); // List<int> | The answer ids.

            try
            {
                // The put.
                Object result = apiInstance.QualitySurveyrecordIdrespondentrespondentcreatorcreatornotesnotes(recordId, respondent, creator, notes, answerIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QualitySurveyApi.QualitySurveyrecordIdrespondentrespondentcreatorcreatornotesnotes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QualitySurveyrecordIdrespondentrespondentcreatorcreatornotesnotesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The put.
    ApiResponse<Object> response = apiInstance.QualitySurveyrecordIdrespondentrespondentcreatorcreatornotesnotesWithHttpInfo(recordId, respondent, creator, notes, answerIds);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QualitySurveyApi.QualitySurveyrecordIdrespondentrespondentcreatorcreatornotesnotesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **recordId** | **int** | The record id. |  |
| **respondent** | **string** | The respondent. |  |
| **creator** | **string** | The creator. |  |
| **notes** | **string** | The notes. |  |
| **answerIds** | [**List&lt;int&gt;**](int.md) | The answer ids. |  |

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

<a id="subscriberssubscriberidqualitysurvey"></a>
# **SubscriberssubscriberIdQualitySurvey**
> Object SubscriberssubscriberIdQualitySurvey (int subscriberId)

The get quality survey.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SubscriberssubscriberIdQualitySurveyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new QualitySurveyApi(config);
            var subscriberId = 56;  // int | The subscriber id.

            try
            {
                // The get quality survey.
                Object result = apiInstance.SubscriberssubscriberIdQualitySurvey(subscriberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QualitySurveyApi.SubscriberssubscriberIdQualitySurvey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriberssubscriberIdQualitySurveyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The get quality survey.
    ApiResponse<Object> response = apiInstance.SubscriberssubscriberIdQualitySurveyWithHttpInfo(subscriberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QualitySurveyApi.SubscriberssubscriberIdQualitySurveyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriberId** | **int** | The subscriber id. |  |

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

