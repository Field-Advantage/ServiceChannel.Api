# ServiceChannel.Api.Api.ScConnectorApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ScConnectorCheckInOut**](ScConnectorApi.md#scconnectorcheckinout) | **POST** /ScConnector/CheckInOut | Called when subcontractor workorder CheckInOut |
| [**ScConnectorSubContractorWorkorderCreated**](ScConnectorApi.md#scconnectorsubcontractorworkordercreated) | **POST** /ScConnector/SubContractorWorkorderCreated | XmlIntegration callout. Called when subcontractor workorder created |
| [**ScConnectorSubContractorWorkorderUpdated**](ScConnectorApi.md#scconnectorsubcontractorworkorderupdated) | **POST** /ScConnector/SubContractorWorkorderUpdated | XmlIntegration callout. Called when subcontractor workorder updated |
| [**ScConnectorSyncAssets**](ScConnectorApi.md#scconnectorsyncassets) | **POST** /ScConnector/SyncAssets | Connector sync asset process |
| [**ScConnectorSyncAssetsValidation**](ScConnectorApi.md#scconnectorsyncassetsvalidation) | **POST** /ScConnector/SyncAssetsValidation | Connector sync asset validation process |
| [**ScConnectorSyncNotes**](ScConnectorApi.md#scconnectorsyncnotes) | **POST** /ScConnector/SyncNotes | Connector sync notes process |
| [**ScConnectorSyncResolutionCodes**](ScConnectorApi.md#scconnectorsyncresolutioncodes) | **POST** /ScConnector/SyncResolutionCodes | Connector sync Resolution codes process |
| [**ScConnectorWorkorderCreated**](ScConnectorApi.md#scconnectorworkordercreated) | **POST** /ScConnector/WorkorderCreated | XmlIntegration callout. Called when workorder created |
| [**ScConnectorWorkorderUpdated**](ScConnectorApi.md#scconnectorworkorderupdated) | **POST** /ScConnector/WorkorderUpdated | XmlIntegration callout. Called when workorder updated |

<a id="scconnectorcheckinout"></a>
# **ScConnectorCheckInOut**
> Object ScConnectorCheckInOut (SCServiceChannelServicesWebApiModelsCheckInOutNotificationObject checkinActivity)

Called when subcontractor workorder CheckInOut

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ScConnectorCheckInOutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScConnectorApi(config);
            var checkinActivity = new SCServiceChannelServicesWebApiModelsCheckInOutNotificationObject(); // SCServiceChannelServicesWebApiModelsCheckInOutNotificationObject | CheckInOut

            try
            {
                // Called when subcontractor workorder CheckInOut
                Object result = apiInstance.ScConnectorCheckInOut(checkinActivity);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScConnectorApi.ScConnectorCheckInOut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScConnectorCheckInOutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Called when subcontractor workorder CheckInOut
    ApiResponse<Object> response = apiInstance.ScConnectorCheckInOutWithHttpInfo(checkinActivity);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScConnectorApi.ScConnectorCheckInOutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **checkinActivity** | [**SCServiceChannelServicesWebApiModelsCheckInOutNotificationObject**](SCServiceChannelServicesWebApiModelsCheckInOutNotificationObject.md) | CheckInOut |  |

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

<a id="scconnectorsubcontractorworkordercreated"></a>
# **ScConnectorSubContractorWorkorderCreated**
> Object ScConnectorSubContractorWorkorderCreated (SCServiceChannelServicesWebApiControllersScConnectorControllerData msg)

XmlIntegration callout. Called when subcontractor workorder created

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ScConnectorSubContractorWorkorderCreatedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScConnectorApi(config);
            var msg = new SCServiceChannelServicesWebApiControllersScConnectorControllerData(); // SCServiceChannelServicesWebApiControllersScConnectorControllerData | 

            try
            {
                // XmlIntegration callout. Called when subcontractor workorder created
                Object result = apiInstance.ScConnectorSubContractorWorkorderCreated(msg);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScConnectorApi.ScConnectorSubContractorWorkorderCreated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScConnectorSubContractorWorkorderCreatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // XmlIntegration callout. Called when subcontractor workorder created
    ApiResponse<Object> response = apiInstance.ScConnectorSubContractorWorkorderCreatedWithHttpInfo(msg);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScConnectorApi.ScConnectorSubContractorWorkorderCreatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **msg** | [**SCServiceChannelServicesWebApiControllersScConnectorControllerData**](SCServiceChannelServicesWebApiControllersScConnectorControllerData.md) |  |  |

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

<a id="scconnectorsubcontractorworkorderupdated"></a>
# **ScConnectorSubContractorWorkorderUpdated**
> Object ScConnectorSubContractorWorkorderUpdated (SCServiceChannelServicesWebApiControllersScConnectorControllerData msg)

XmlIntegration callout. Called when subcontractor workorder updated

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ScConnectorSubContractorWorkorderUpdatedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScConnectorApi(config);
            var msg = new SCServiceChannelServicesWebApiControllersScConnectorControllerData(); // SCServiceChannelServicesWebApiControllersScConnectorControllerData | 

            try
            {
                // XmlIntegration callout. Called when subcontractor workorder updated
                Object result = apiInstance.ScConnectorSubContractorWorkorderUpdated(msg);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScConnectorApi.ScConnectorSubContractorWorkorderUpdated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScConnectorSubContractorWorkorderUpdatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // XmlIntegration callout. Called when subcontractor workorder updated
    ApiResponse<Object> response = apiInstance.ScConnectorSubContractorWorkorderUpdatedWithHttpInfo(msg);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScConnectorApi.ScConnectorSubContractorWorkorderUpdatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **msg** | [**SCServiceChannelServicesWebApiControllersScConnectorControllerData**](SCServiceChannelServicesWebApiControllersScConnectorControllerData.md) |  |  |

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

<a id="scconnectorsyncassets"></a>
# **ScConnectorSyncAssets**
> Object ScConnectorSyncAssets (SCServiceChannelServicesMessagingWorkordersWorkorderNotificationObject notificationObject)

Connector sync asset process

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ScConnectorSyncAssetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScConnectorApi(config);
            var notificationObject = new SCServiceChannelServicesMessagingWorkordersWorkorderNotificationObject(); // SCServiceChannelServicesMessagingWorkordersWorkorderNotificationObject | 

            try
            {
                // Connector sync asset process
                Object result = apiInstance.ScConnectorSyncAssets(notificationObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScConnectorApi.ScConnectorSyncAssets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScConnectorSyncAssetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Connector sync asset process
    ApiResponse<Object> response = apiInstance.ScConnectorSyncAssetsWithHttpInfo(notificationObject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScConnectorApi.ScConnectorSyncAssetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **notificationObject** | [**SCServiceChannelServicesMessagingWorkordersWorkorderNotificationObject**](SCServiceChannelServicesMessagingWorkordersWorkorderNotificationObject.md) |  |  |

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

<a id="scconnectorsyncassetsvalidation"></a>
# **ScConnectorSyncAssetsValidation**
> Object ScConnectorSyncAssetsValidation (SCServiceChannelServicesMessagingWorkordersWorkorderNotificationObject notificationObject)

Connector sync asset validation process

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ScConnectorSyncAssetsValidationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScConnectorApi(config);
            var notificationObject = new SCServiceChannelServicesMessagingWorkordersWorkorderNotificationObject(); // SCServiceChannelServicesMessagingWorkordersWorkorderNotificationObject | 

            try
            {
                // Connector sync asset validation process
                Object result = apiInstance.ScConnectorSyncAssetsValidation(notificationObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScConnectorApi.ScConnectorSyncAssetsValidation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScConnectorSyncAssetsValidationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Connector sync asset validation process
    ApiResponse<Object> response = apiInstance.ScConnectorSyncAssetsValidationWithHttpInfo(notificationObject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScConnectorApi.ScConnectorSyncAssetsValidationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **notificationObject** | [**SCServiceChannelServicesMessagingWorkordersWorkorderNotificationObject**](SCServiceChannelServicesMessagingWorkordersWorkorderNotificationObject.md) |  |  |

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

<a id="scconnectorsyncnotes"></a>
# **ScConnectorSyncNotes**
> Object ScConnectorSyncNotes ()

Connector sync notes process

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ScConnectorSyncNotesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScConnectorApi(config);

            try
            {
                // Connector sync notes process
                Object result = apiInstance.ScConnectorSyncNotes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScConnectorApi.ScConnectorSyncNotes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScConnectorSyncNotesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Connector sync notes process
    ApiResponse<Object> response = apiInstance.ScConnectorSyncNotesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScConnectorApi.ScConnectorSyncNotesWithHttpInfo: " + e.Message);
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

<a id="scconnectorsyncresolutioncodes"></a>
# **ScConnectorSyncResolutionCodes**
> Object ScConnectorSyncResolutionCodes (SCServiceChannelServicesMessagingWorkordersWorkorderNotificationObject notificationObject)

Connector sync Resolution codes process

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ScConnectorSyncResolutionCodesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScConnectorApi(config);
            var notificationObject = new SCServiceChannelServicesMessagingWorkordersWorkorderNotificationObject(); // SCServiceChannelServicesMessagingWorkordersWorkorderNotificationObject | 

            try
            {
                // Connector sync Resolution codes process
                Object result = apiInstance.ScConnectorSyncResolutionCodes(notificationObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScConnectorApi.ScConnectorSyncResolutionCodes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScConnectorSyncResolutionCodesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Connector sync Resolution codes process
    ApiResponse<Object> response = apiInstance.ScConnectorSyncResolutionCodesWithHttpInfo(notificationObject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScConnectorApi.ScConnectorSyncResolutionCodesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **notificationObject** | [**SCServiceChannelServicesMessagingWorkordersWorkorderNotificationObject**](SCServiceChannelServicesMessagingWorkordersWorkorderNotificationObject.md) |  |  |

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

<a id="scconnectorworkordercreated"></a>
# **ScConnectorWorkorderCreated**
> Object ScConnectorWorkorderCreated (SCServiceChannelServicesWebApiControllersScConnectorControllerData msg)

XmlIntegration callout. Called when workorder created

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ScConnectorWorkorderCreatedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScConnectorApi(config);
            var msg = new SCServiceChannelServicesWebApiControllersScConnectorControllerData(); // SCServiceChannelServicesWebApiControllersScConnectorControllerData | Created workorder

            try
            {
                // XmlIntegration callout. Called when workorder created
                Object result = apiInstance.ScConnectorWorkorderCreated(msg);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScConnectorApi.ScConnectorWorkorderCreated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScConnectorWorkorderCreatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // XmlIntegration callout. Called when workorder created
    ApiResponse<Object> response = apiInstance.ScConnectorWorkorderCreatedWithHttpInfo(msg);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScConnectorApi.ScConnectorWorkorderCreatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **msg** | [**SCServiceChannelServicesWebApiControllersScConnectorControllerData**](SCServiceChannelServicesWebApiControllersScConnectorControllerData.md) | Created workorder |  |

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

<a id="scconnectorworkorderupdated"></a>
# **ScConnectorWorkorderUpdated**
> Object ScConnectorWorkorderUpdated (SCServiceChannelServicesWebApiControllersScConnectorControllerData msg)

XmlIntegration callout. Called when workorder updated

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ScConnectorWorkorderUpdatedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScConnectorApi(config);
            var msg = new SCServiceChannelServicesWebApiControllersScConnectorControllerData(); // SCServiceChannelServicesWebApiControllersScConnectorControllerData | 

            try
            {
                // XmlIntegration callout. Called when workorder updated
                Object result = apiInstance.ScConnectorWorkorderUpdated(msg);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScConnectorApi.ScConnectorWorkorderUpdated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScConnectorWorkorderUpdatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // XmlIntegration callout. Called when workorder updated
    ApiResponse<Object> response = apiInstance.ScConnectorWorkorderUpdatedWithHttpInfo(msg);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScConnectorApi.ScConnectorWorkorderUpdatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **msg** | [**SCServiceChannelServicesWebApiControllersScConnectorControllerData**](SCServiceChannelServicesWebApiControllersScConnectorControllerData.md) |  |  |

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

