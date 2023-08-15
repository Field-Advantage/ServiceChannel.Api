# ServiceChannel.Api.Api.SurveyQuestionsApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SurveyquestionsAddanswerslocationId**](SurveyQuestionsApi.md#surveyquestionsaddanswerslocationid) | **POST** /surveyquestions/addanswers/{locationId} | Submit answered questions. |
| [**SurveyquestionsGetwithanswerslocationId**](SurveyQuestionsApi.md#surveyquestionsgetwithanswerslocationid) | **GET** /surveyquestions/getwithanswers/{locationId} | Get questions with possible answers for specific location |
| [**SurveyquestionsWorkorderanswersworkOrderId**](SurveyQuestionsApi.md#surveyquestionsworkorderanswersworkorderid) | **GET** /surveyquestions/workorderanswers/{workOrderId} | Get workorder survey answers with questions. |

<a id="surveyquestionsaddanswerslocationid"></a>
# **SurveyquestionsAddanswerslocationId**
> void SurveyquestionsAddanswerslocationId (int locationId, List<SCServiceChannelApiModelEntitiesSurveyQuestionsSurveyAnsweredQuestion> surveyAnsweredQuestions)

Submit answered questions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SurveyquestionsAddanswerslocationIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SurveyQuestionsApi(config);
            var locationId = 56;  // int | 
            var surveyAnsweredQuestions = new List<SCServiceChannelApiModelEntitiesSurveyQuestionsSurveyAnsweredQuestion>(); // List<SCServiceChannelApiModelEntitiesSurveyQuestionsSurveyAnsweredQuestion> | 

            try
            {
                // Submit answered questions.
                apiInstance.SurveyquestionsAddanswerslocationId(locationId, surveyAnsweredQuestions);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SurveyQuestionsApi.SurveyquestionsAddanswerslocationId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SurveyquestionsAddanswerslocationIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Submit answered questions.
    apiInstance.SurveyquestionsAddanswerslocationIdWithHttpInfo(locationId, surveyAnsweredQuestions);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SurveyQuestionsApi.SurveyquestionsAddanswerslocationIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** |  |  |
| **surveyAnsweredQuestions** | [**List&lt;SCServiceChannelApiModelEntitiesSurveyQuestionsSurveyAnsweredQuestion&gt;**](SCServiceChannelApiModelEntitiesSurveyQuestionsSurveyAnsweredQuestion.md) |  |  |

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
| **201** | Indicates that the request succeeded and that new Answers are added. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Indicates that the requested resource requires authentication.&lt;br&gt;Error codes:&lt;br&gt; 504 - API call rejected by security permissions; |  -  |
| **500** | Indicates that an error has occured wile creation of a new Subscriber. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="surveyquestionsgetwithanswerslocationid"></a>
# **SurveyquestionsGetwithanswerslocationId**
> List&lt;SCServiceChannelApiModelEntitiesSurveyQuestionsSurveyQuestionWithAnswers&gt; SurveyquestionsGetwithanswerslocationId (int locationId)

Get questions with possible answers for specific location

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SurveyquestionsGetwithanswerslocationIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SurveyQuestionsApi(config);
            var locationId = 56;  // int | 

            try
            {
                // Get questions with possible answers for specific location
                List<SCServiceChannelApiModelEntitiesSurveyQuestionsSurveyQuestionWithAnswers> result = apiInstance.SurveyquestionsGetwithanswerslocationId(locationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SurveyQuestionsApi.SurveyquestionsGetwithanswerslocationId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SurveyquestionsGetwithanswerslocationIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get questions with possible answers for specific location
    ApiResponse<List<SCServiceChannelApiModelEntitiesSurveyQuestionsSurveyQuestionWithAnswers>> response = apiInstance.SurveyquestionsGetwithanswerslocationIdWithHttpInfo(locationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SurveyQuestionsApi.SurveyquestionsGetwithanswerslocationIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **int** |  |  |

### Return type

[**List&lt;SCServiceChannelApiModelEntitiesSurveyQuestionsSurveyQuestionWithAnswers&gt;**](SCServiceChannelApiModelEntitiesSurveyQuestionsSurveyQuestionWithAnswers.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="surveyquestionsworkorderanswersworkorderid"></a>
# **SurveyquestionsWorkorderanswersworkOrderId**
> List&lt;SCServiceChannelServicesMessagingSurveyQuestionWorkorderAnsweredQuestionResponse&gt; SurveyquestionsWorkorderanswersworkOrderId (int workOrderId)

Get workorder survey answers with questions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class SurveyquestionsWorkorderanswersworkOrderIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SurveyQuestionsApi(config);
            var workOrderId = 56;  // int | 

            try
            {
                // Get workorder survey answers with questions.
                List<SCServiceChannelServicesMessagingSurveyQuestionWorkorderAnsweredQuestionResponse> result = apiInstance.SurveyquestionsWorkorderanswersworkOrderId(workOrderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SurveyQuestionsApi.SurveyquestionsWorkorderanswersworkOrderId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SurveyquestionsWorkorderanswersworkOrderIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get workorder survey answers with questions.
    ApiResponse<List<SCServiceChannelServicesMessagingSurveyQuestionWorkorderAnsweredQuestionResponse>> response = apiInstance.SurveyquestionsWorkorderanswersworkOrderIdWithHttpInfo(workOrderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SurveyQuestionsApi.SurveyquestionsWorkorderanswersworkOrderIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workOrderId** | **int** |  |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingSurveyQuestionWorkorderAnsweredQuestionResponse&gt;**](SCServiceChannelServicesMessagingSurveyQuestionWorkorderAnsweredQuestionResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters. |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

