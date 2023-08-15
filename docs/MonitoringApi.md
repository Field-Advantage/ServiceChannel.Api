# ServiceChannel.Api.Api.MonitoringApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**MonitoringCheckStorageAvalaibility**](MonitoringApi.md#monitoringcheckstorageavalaibility) | **GET** /monitoring/CheckStorageAvalaibility | This method checks the availability of files on the storage |

<a id="monitoringcheckstorageavalaibility"></a>
# **MonitoringCheckStorageAvalaibility**
> Object MonitoringCheckStorageAvalaibility ()

This method checks the availability of files on the storage

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class MonitoringCheckStorageAvalaibilityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MonitoringApi(config);

            try
            {
                // This method checks the availability of files on the storage
                Object result = apiInstance.MonitoringCheckStorageAvalaibility();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitoringApi.MonitoringCheckStorageAvalaibility: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MonitoringCheckStorageAvalaibilityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This method checks the availability of files on the storage
    ApiResponse<Object> response = apiInstance.MonitoringCheckStorageAvalaibilityWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MonitoringApi.MonitoringCheckStorageAvalaibilityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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
