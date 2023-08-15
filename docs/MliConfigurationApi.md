# ServiceChannel.Api.Api.MliConfigurationApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**MliConfigurationLevels**](MliConfigurationApi.md#mliconfigurationlevels) | **GET** /mliConfiguration/Levels | Get MLI levels |
| [**MliConfigurationLevelslevelIdUsers**](MliConfigurationApi.md#mliconfigurationlevelslevelidusers) | **GET** /mliConfiguration/Levels/{levelId}/Users | Get MLI level users |
| [**MliConfigurationLevelslevelIdUsersuserId**](MliConfigurationApi.md#mliconfigurationlevelslevelidusersuserid) | **POST** /MliConfiguration/Levels/{levelId}/Users/{userId} | Add a user to an MLI level |
| [**MliConfigurationLevelslevelIdUsersuserIdLocationslocationId**](MliConfigurationApi.md#mliconfigurationlevelslevelidusersuseridlocationslocationid) | **POST** /MliConfiguration/Levels/{levelId}/Users/{userId}/Locations/{locationId} | Add a location to a user’s MLI level |
| [**MliConfigurationLevelslevelIdUsersuserIdLocationslocationId_0**](MliConfigurationApi.md#mliconfigurationlevelslevelidusersuseridlocationslocationid_0) | **DELETE** /MliConfiguration/Levels/{levelId}/Users/{userId}/Locations/{locationId} | Remove a location from a user’s MLI level |
| [**MliConfigurationLevelslevelIdUsersuserId_0**](MliConfigurationApi.md#mliconfigurationlevelslevelidusersuserid_0) | **DELETE** /mliConfiguration/Levels/{levelId}/Users/{userId} | Remove a user from an MLI level |

<a id="mliconfigurationlevels"></a>
# **MliConfigurationLevels**
> List&lt;SCServiceChannelServicesMessagingMliConfigurationApiMLILevel&gt; MliConfigurationLevels ()

Get MLI levels

Returns IDs and names of all MLI levels of the current subscriber.              <br />Learn more about [MLI levels configuration](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/601555312/Configuring+MLI+Levels) in ServiceChannel University.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class MliConfigurationLevelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MliConfigurationApi(config);

            try
            {
                // Get MLI levels
                List<SCServiceChannelServicesMessagingMliConfigurationApiMLILevel> result = apiInstance.MliConfigurationLevels();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MliConfigurationApi.MliConfigurationLevels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MliConfigurationLevelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get MLI levels
    ApiResponse<List<SCServiceChannelServicesMessagingMliConfigurationApiMLILevel>> response = apiInstance.MliConfigurationLevelsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MliConfigurationApi.MliConfigurationLevelsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;SCServiceChannelServicesMessagingMliConfigurationApiMLILevel&gt;**](SCServiceChannelServicesMessagingMliConfigurationApiMLILevel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | MLI levels are in the response. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt; Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="mliconfigurationlevelslevelidusers"></a>
# **MliConfigurationLevelslevelIdUsers**
> List&lt;SCServiceChannelServicesMessagingUserApiAssignedUser&gt; MliConfigurationLevelslevelIdUsers (int levelId)

Get MLI level users

Returns the users assigned to the specified level. The response body is empty if no user has been assigned to this level.              <br />You can use the [GET /mliConfiguration/Levels](https://developer.servicechannel.com/swagger/ui/index?version=3#/MliConfiguration/GETv3_mliConfiguration_Levels) method to get the MLI levels IDs. Send the [POST /MliConfiguration/Levels/{levelId}/Users/{userId}](https://developer.servicechannel.com/swagger/ui/index?version=3#/MliConfiguration/POSTv3_MliConfiguration_Levels__levelId__Users__userId_) request to assign users to the MLI level.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class MliConfigurationLevelslevelIdUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MliConfigurationApi(config);
            var levelId = 56;  // int | Numeric identifier of the MLI level.

            try
            {
                // Get MLI level users
                List<SCServiceChannelServicesMessagingUserApiAssignedUser> result = apiInstance.MliConfigurationLevelslevelIdUsers(levelId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MliConfigurationApi.MliConfigurationLevelslevelIdUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MliConfigurationLevelslevelIdUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get MLI level users
    ApiResponse<List<SCServiceChannelServicesMessagingUserApiAssignedUser>> response = apiInstance.MliConfigurationLevelslevelIdUsersWithHttpInfo(levelId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MliConfigurationApi.MliConfigurationLevelslevelIdUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **levelId** | **int** | Numeric identifier of the MLI level. |  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingUserApiAssignedUser&gt;**](SCServiceChannelServicesMessagingUserApiAssignedUser.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The users assigned to the specified MLI level are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt; Error codes:              1128 — Approval levels getting error |  -  |
| **401** | The request is not authorized.              &lt;br/&gt; Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="mliconfigurationlevelslevelidusersuserid"></a>
# **MliConfigurationLevelslevelIdUsersuserId**
> void MliConfigurationLevelslevelIdUsersuserId (int levelId, int userId)

Add a user to an MLI level

Assigns a user to an existing MLI level. Get users’ IDs by sending the [GET /users](https://developer.servicechannel.com/swagger/ui/index?version=3#/Users/GETv3_users_subscriberId__subscriberId__startIndex__startIndex__maxCount__maxCount_) request.              <br />You can assign a user to an existing location by using the [POST /MliConfiguration/Levels/{levelId}/Users/{userId}/Locations/{locationId}](https://developer.servicechannel.com/swagger/ui/index?version=3#/MliConfiguration/POSTv3_MliConfiguration_Levels__levelId__Users__userId__Locations__locationId_) method.              <br />***Note***: Each user can be added to only one MLI level. If a user should be assigned to another MLI level, you first need to [remove this user from the MLI level](https://developer.servicechannel.com/swagger/ui/index?version=3#/MliConfiguration/DELETEv3_mliConfiguration_Levels__levelId__Users__userId_) they currently belong to.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class MliConfigurationLevelslevelIdUsersuserIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MliConfigurationApi(config);
            var levelId = 56;  // int | Numeric identifier of the MLI level.
            var userId = 56;  // int | Unique numeric identifier of the user.

            try
            {
                // Add a user to an MLI level
                apiInstance.MliConfigurationLevelslevelIdUsersuserId(levelId, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MliConfigurationApi.MliConfigurationLevelslevelIdUsersuserId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MliConfigurationLevelslevelIdUsersuserIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a user to an MLI level
    apiInstance.MliConfigurationLevelslevelIdUsersuserIdWithHttpInfo(levelId, userId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MliConfigurationApi.MliConfigurationLevelslevelIdUsersuserIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **levelId** | **int** | Numeric identifier of the MLI level. |  |
| **userId** | **int** | Unique numeric identifier of the user. |  |

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
| **200** | Returns the created user ID from table dat_Division_User. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt; Error codes:              1129 — Err: failed to assign users              1131 — Err: Approval level doesn’t exist              1149 — User has already been assigned to another level              1150 — User does not exist |  -  |
| **401** | The request is not authorized.              &lt;br/&gt; Error codes:              504 — API call rejected by security permissions |  -  |
| **403** | You are not authorized to request this resource, or the resource is unavailable for some reason.              &lt;br/&gt; Error codes:              100 — User has no rights to perform this action |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="mliconfigurationlevelslevelidusersuseridlocationslocationid"></a>
# **MliConfigurationLevelslevelIdUsersuserIdLocationslocationId**
> void MliConfigurationLevelslevelIdUsersuserIdLocationslocationId (int levelId, int userId, int locationId)

Add a location to a user’s MLI level

Assigns the specified location to a particular user and user’s MLI level. A location can be removed from a user by sending the [DELETE /MliConfiguration/Levels/{levelId}/Users/{userId}/Locations/{locationId}](https://developer.servicechannel.com/swagger/ui/index?version=3#/MliConfiguration/DELETEv3_MliConfiguration_Levels__levelId__Users__userId__Locations__locationId_) request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class MliConfigurationLevelslevelIdUsersuserIdLocationslocationIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MliConfigurationApi(config);
            var levelId = 56;  // int | Numeric identifier of the MLI level.
            var userId = 56;  // int | Unique numeric identifier of the user.
            var locationId = 56;  // int | Unique numeric identifier of the location.

            try
            {
                // Add a location to a user’s MLI level
                apiInstance.MliConfigurationLevelslevelIdUsersuserIdLocationslocationId(levelId, userId, locationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MliConfigurationApi.MliConfigurationLevelslevelIdUsersuserIdLocationslocationId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MliConfigurationLevelslevelIdUsersuserIdLocationslocationIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a location to a user’s MLI level
    apiInstance.MliConfigurationLevelslevelIdUsersuserIdLocationslocationIdWithHttpInfo(levelId, userId, locationId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MliConfigurationApi.MliConfigurationLevelslevelIdUsersuserIdLocationslocationIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **levelId** | **int** | Numeric identifier of the MLI level. |  |
| **userId** | **int** | Unique numeric identifier of the user. |  |
| **locationId** | **int** | Unique numeric identifier of the location. |  |

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
| **200** | Returns the created location ID from table dat_Location_Division. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt; Error codes:              1128 — Err: Approval level doesn’t exist              1130 — Failed to assign the location to the user              1130 — User is not assigned to the level              1130 — Err: Failed to assign locations to the approval level              1130 — Location doesn’t exist for the current subscriber              1150 — User does not exist              1301 — Request parameters are empty |  -  |
| **401** | The request is not authorized.              &lt;br/&gt; Error codes:              504 — API call rejected by security permissions |  -  |
| **403** | You are not authorized to request this resource, or the resource is unavailable for some reason.              &lt;br/&gt; Error codes:              100 — User has no rights to perform this action |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="mliconfigurationlevelslevelidusersuseridlocationslocationid_0"></a>
# **MliConfigurationLevelslevelIdUsersuserIdLocationslocationId_0**
> void MliConfigurationLevelslevelIdUsersuserIdLocationslocationId_0 (int levelId, int userId, int locationId)

Remove a location from a user’s MLI level

Removes the specified location from a particular user and MLI level. To assign a location to a user and MLI level, send the [POST /MliConfiguration/Levels/{levelId}/Users/{userId}/Locations/{locationId}](https://developer.servicechannel.com/swagger/ui/index?version=3#/MliConfiguration/POSTv3_MliConfiguration_Levels__levelId__Users__userId__Locations__locationId_) request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class MliConfigurationLevelslevelIdUsersuserIdLocationslocationId_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MliConfigurationApi(config);
            var levelId = 56;  // int | Numeric identifier of the MLI level.
            var userId = 56;  // int | Unique numeric identifier of the user.
            var locationId = 56;  // int | Unique numeric identifier of the location.

            try
            {
                // Remove a location from a user’s MLI level
                apiInstance.MliConfigurationLevelslevelIdUsersuserIdLocationslocationId_0(levelId, userId, locationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MliConfigurationApi.MliConfigurationLevelslevelIdUsersuserIdLocationslocationId_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MliConfigurationLevelslevelIdUsersuserIdLocationslocationId_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove a location from a user’s MLI level
    apiInstance.MliConfigurationLevelslevelIdUsersuserIdLocationslocationId_0WithHttpInfo(levelId, userId, locationId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MliConfigurationApi.MliConfigurationLevelslevelIdUsersuserIdLocationslocationId_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **levelId** | **int** | Numeric identifier of the MLI level. |  |
| **userId** | **int** | Unique numeric identifier of the user. |  |
| **locationId** | **int** | Unique numeric identifier of the location. |  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The specified location is successfully removed from the user’s MLI level. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt; Error codes:              1130 — Location is not assigned to the user              1130 — Approval level doesn’t exist              1130 — User is not assigned to the level              1130 — Location doesn’t exist for the current subscriber              1150 — User doesn’t exist              1301 — Request parameters are empty |  -  |
| **401** | The request is not authorized.              &lt;br/&gt; Error codes:              504 — API call rejected by security permissions |  -  |
| **403** | You are not authorized to request this resource, or the resource is unavailable for some reason.              &lt;br/&gt; Error codes:              100 — User has no rights to perform this action |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="mliconfigurationlevelslevelidusersuserid_0"></a>
# **MliConfigurationLevelslevelIdUsersuserId_0**
> void MliConfigurationLevelslevelIdUsersuserId_0 (int levelId, int userId)

Remove a user from an MLI level

Removes the specified user from a particular MLI level. To unassign a user from an existing location, send the [DELETE /MliConfiguration/Levels/{levelId}/Users/{userId}/Locations/{locationId}](https://developer.servicechannel.com/swagger/ui/index?version=3#/MliConfiguration/DELETEv3_MliConfiguration_Levels__levelId__Users__userId__Locations__locationId_) request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class MliConfigurationLevelslevelIdUsersuserId_0Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MliConfigurationApi(config);
            var levelId = 56;  // int | Numeric identifier of the MLI level.
            var userId = 56;  // int | Unique numeric identifier of the user.

            try
            {
                // Remove a user from an MLI level
                apiInstance.MliConfigurationLevelslevelIdUsersuserId_0(levelId, userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MliConfigurationApi.MliConfigurationLevelslevelIdUsersuserId_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MliConfigurationLevelslevelIdUsersuserId_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove a user from an MLI level
    apiInstance.MliConfigurationLevelslevelIdUsersuserId_0WithHttpInfo(levelId, userId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MliConfigurationApi.MliConfigurationLevelslevelIdUsersuserId_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **levelId** | **int** | Numeric identifier of the MLI level. |  |
| **userId** | **int** | Unique numeric identifier of the user. |  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The specified user is successfully removed from the MLI level. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt; Error codes:              1130 — Err: Approval level doesn’t exist              1130 — User is not assigned to the level              1150 — User does not exist |  -  |
| **401** | The request is not authorized.              &lt;br/&gt; Error codes:              504 — API call rejected by security permissions |  -  |
| **403** | You are not authorized to request this resource, or the resource is unavailable for some reason.              &lt;br/&gt; Error codes:              100 — User has no rights to perform this action |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

