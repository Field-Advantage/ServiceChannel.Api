# ServiceChannel.Api.Api.FeatureApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FeaturesGlobalfeaturefeatureId**](FeatureApi.md#featuresglobalfeaturefeatureid) | **GET** /features/globalfeature/{featureId} | Get Feature |
| [**FeaturesGlobalfeaturefeatureId_0**](FeatureApi.md#featuresglobalfeaturefeatureid_0) | **PUT** /features/globalfeature/{featureId} |  |

<a id="featuresglobalfeaturefeatureid"></a>
# **FeaturesGlobalfeaturefeatureId**
> Object FeaturesGlobalfeaturefeatureId (string featureId)

Get Feature

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class FeaturesGlobalfeaturefeatureIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FeatureApi(config);
            var featureId = "featureId_example";  // string | Feature Name

            try
            {
                // Get Feature
                Object result = apiInstance.FeaturesGlobalfeaturefeatureId(featureId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeatureApi.FeaturesGlobalfeaturefeatureId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FeaturesGlobalfeaturefeatureIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Feature
    ApiResponse<Object> response = apiInstance.FeaturesGlobalfeaturefeatureIdWithHttpInfo(featureId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeatureApi.FeaturesGlobalfeaturefeatureIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **featureId** | **string** | Feature Name |  |

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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br/&gt; 502 -  &#39;FeatureId&#39; feature doesn&#39;t exist; |  -  |
| **404** | Indicates that the requested resource does not exist on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="featuresglobalfeaturefeatureid_0"></a>
# **FeaturesGlobalfeaturefeatureId_0**
> Object FeaturesGlobalfeaturefeatureId_0 (int featureId, SCServiceChannelServicesMessagingFeaturesSetFeatureRequest feature)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class FeaturesGlobalfeaturefeatureId_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FeatureApi(config);
            var featureId = 56;  // int | 
            var feature = new SCServiceChannelServicesMessagingFeaturesSetFeatureRequest(); // SCServiceChannelServicesMessagingFeaturesSetFeatureRequest | 

            try
            {
                Object result = apiInstance.FeaturesGlobalfeaturefeatureId_0(featureId, feature);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeatureApi.FeaturesGlobalfeaturefeatureId_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FeaturesGlobalfeaturefeatureId_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.FeaturesGlobalfeaturefeatureId_0WithHttpInfo(featureId, feature);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeatureApi.FeaturesGlobalfeaturefeatureId_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **featureId** | **int** |  |  |
| **feature** | [**SCServiceChannelServicesMessagingFeaturesSetFeatureRequest**](SCServiceChannelServicesMessagingFeaturesSetFeatureRequest.md) |  |  |

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

