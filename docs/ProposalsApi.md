# ServiceChannel.Api.Api.ProposalsApi

All URIs are relative to *https://sb2api.servicechannel.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetProposalCategories**](ProposalsApi.md#getproposalcategories) | **GET** /odata/proposals({proposalId})/Service.Categories() | Retrieve Proposal Categories |
| [**GetProposals**](ProposalsApi.md#getproposals) | **GET** /odata/proposals | Retrieve Proposals |
| [**GetProposalsForRfp**](ProposalsApi.md#getproposalsforrfp) | **GET** /odata/rfps({rfpId})/proposals | Retrieve Rfp Proposals |
| [**ProposalsAddUserToMlpLeveluserNameuserNamelevelNamelevelName**](ProposalsApi.md#proposalsaddusertomlplevelusernameusernamelevelnamelevelname) | **PUT** /proposals/AddUserToMlpLevel | Add a user to an MLP level |
| [**ProposalsApprovalReasonsTradeTradeCategoryCategory**](ProposalsApi.md#proposalsapprovalreasonstradetradecategorycategory) | **GET** /proposals/ApprovalReasons | Retrieve proposal approval reasons |
| [**ProposalsAssignLocationToMlpUseruserNameuserNamelocationlocation**](ProposalsApi.md#proposalsassignlocationtomlpuserusernameusernamelocationlocation) | **PUT** /proposals/AssignLocationToMlpUser | Add a location to a user’s MLP level |
| [**ProposalsAssignProjectIdToProposalAndRfpproposalIdproposalIdprojectIdprojectId**](ProposalsApi.md#proposalsassignprojectidtoproposalandrfpproposalidproposalidprojectidprojectid) | **PUT** /proposals/AssignProjectIdToProposalAndRfp | Assign a ProjectId to a ProposalId and Rfp |
| [**ProposalsAssignReasonsTradeTradeCategoryCategory**](ProposalsApi.md#proposalsassignreasonstradetradecategorycategory) | **GET** /proposals/AssignReasons | Retrieve the reasons for assigning a proposal |
| [**ProposalsGetMlpLevelsForSubscriber**](ProposalsApi.md#proposalsgetmlplevelsforsubscriber) | **GET** /proposals/GetMlpLevelsForSubscriber | Get MLP levels for a subscriber |
| [**ProposalsGetProposals**](ProposalsApi.md#proposalsgetproposals) | **POST** /proposals/GetProposals | Get Proposals |
| [**ProposalsGetProposalsAssociatedWithWorkOderExceptRfptrackingNumbertrackingNumber**](ProposalsApi.md#proposalsgetproposalsassociatedwithworkoderexceptrfptrackingnumbertrackingnumber) | **GET** /proposals/GetProposalsAssociatedWithWorkOderExceptRfp |  |
| [**ProposalsGetProposalsAssociatedWithWorkOrderAsynctrackingNumbertrackingNumber**](ProposalsApi.md#proposalsgetproposalsassociatedwithworkorderasynctrackingnumbertrackingnumber) | **GET** /proposals/GetProposalsAssociatedWithWorkOrderAsync | Get proposals associated with work order by tracking number. Only for Subscriber |
| [**ProposalsGetProposalsToRejecttrackingNumbertrackingNumber**](ProposalsApi.md#proposalsgetproposalstorejecttrackingnumbertrackingnumber) | **GET** /proposals/GetProposalsToReject | Retrieve proposals that can be reject |
| [**ProposalsGetUsersByLevelNamelevelNamelevelName**](ProposalsApi.md#proposalsgetusersbylevelnamelevelnamelevelname) | **GET** /proposals/GetUsersByLevelName | Get users by level name |
| [**ProposalsProposalIdsproposalIds0proposalIds0proposalIds1proposalIds1**](ProposalsApi.md#proposalsproposalidsproposalids0proposalids0proposalids1proposalids1) | **GET** /proposals/proposalIds | Get proposal actions by ID |
| [**ProposalsProposalsReject**](ProposalsApi.md#proposalsproposalsreject) | **PUT** /proposals/ProposalsReject | Reject proposals |
| [**ProposalsRejectionReasons**](ProposalsApi.md#proposalsrejectionreasons) | **GET** /proposals/RejectionReasons | Retrieve proposal rejection reasons |
| [**ProposalsRemoveLocationFromMlpUseruserNameuserNamelocationlocation**](ProposalsApi.md#proposalsremovelocationfrommlpuserusernameusernamelocationlocation) | **PUT** /proposals/RemoveLocationFromMlpUser | Remove a location from a user’s MLP level |
| [**ProposalsRemoveMlpUserValidationAsyncuserIduserId**](ProposalsApi.md#proposalsremovemlpuservalidationasyncuseriduserid) | **PUT** /proposals/RemoveMlpUserValidationAsync | Whether the user can be deleted from MLP level. |
| [**ProposalsRemoveUserFromMlpLeveluserNameuserName**](ProposalsApi.md#proposalsremoveuserfrommlplevelusernameusername) | **PUT** /proposals/RemoveUserFromMlpLevel | Remove a user from an MLP level |
| [**ProposalsStatisticsdaysPerioddaysPeriod**](ProposalsApi.md#proposalsstatisticsdaysperioddaysperiod) | **GET** /proposals/statistics | Retrieve statistics on RFPs and proposals |
| [**ProposalsproposalIdApprove**](ProposalsApi.md#proposalsproposalidapprove) | **PUT** /proposals/{proposalId}/approve | Approve a proposal |
| [**ProposalsproposalIdAssignUser**](ProposalsApi.md#proposalsproposalidassignuser) | **PUT** /proposals/{proposalId}/assignUser | Assign a proposal to a user |
| [**ProposalsproposalIdAssignWOisFromProjectsModuleisFromProjectsModule**](ProposalsApi.md#proposalsproposalidassignwoisfromprojectsmoduleisfromprojectsmodule) | **PUT** /proposals/{proposalId}/assignWO | Attach a work order to a proposal |
| [**ProposalsproposalIdEscalate**](ProposalsApi.md#proposalsproposalidescalate) | **PUT** /proposals/{proposalId}/escalate | Escalate a proposal |
| [**ProposalsproposalIdOnhold**](ProposalsApi.md#proposalsproposalidonhold) | **PUT** /proposals/{proposalId}/onhold | Put a proposal on hold |
| [**ProposalsproposalIdOpen**](ProposalsApi.md#proposalsproposalidopen) | **PUT** /proposals/{proposalId}/open | Open a proposal |
| [**ProposalsproposalIdRecipients**](ProposalsApi.md#proposalsproposalidrecipients) | **GET** /proposals/{proposalId}/recipients | Retrieve users who can be added to the list of email recipients to notify of a proposal approval or rejection |
| [**ProposalsproposalIdRejectuseProposalAlertEmailsuseProposalAlertEmails**](ProposalsApi.md#proposalsproposalidrejectuseproposalalertemailsuseproposalalertemails) | **PUT** /proposals/{proposalId}/reject | Reject a proposal |
| [**ProposalsproposalIdUsers**](ProposalsApi.md#proposalsproposalidusers) | **GET** /proposals/{proposalId}/users | Retrieve users who can be assigned a proposal |
| [**ProposalsproposalIdValidate**](ProposalsApi.md#proposalsproposalidvalidate) | **GET** /proposals/{proposalId}/validate | Validate a proposal |
| [**ProposalsrfpId**](ProposalsApi.md#proposalsrfpid) | **PUT** /proposals/{rfpId} | Delete Proposal and Rfp reference with projectId by rfpId |
| [**ProposalsstatusesstatusesassignedToassignedToskipskiptoptop**](ProposalsApi.md#proposalsstatusesstatusesassignedtoassignedtoskipskiptoptop) | **GET** /proposals | Retrieve proposals |

<a id="getproposalcategories"></a>
# **GetProposalCategories**
> List&lt;SCServiceChannelServicesMessagingProposalsProposalCategory&gt; GetProposalCategories (int proposalId, string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Retrieve Proposal Categories

Retrieve Proposal Categories

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetProposalCategoriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProposalsApi(config);
            var proposalId = 56;  // int | 
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Retrieve Proposal Categories
                List<SCServiceChannelServicesMessagingProposalsProposalCategory> result = apiInstance.GetProposalCategories(proposalId, expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProposalsApi.GetProposalCategories: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProposalCategoriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Proposal Categories
    ApiResponse<List<SCServiceChannelServicesMessagingProposalsProposalCategory>> response = apiInstance.GetProposalCategoriesWithHttpInfo(proposalId, expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProposalsApi.GetProposalCategoriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **proposalId** | **int** |  |  |
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingProposalsProposalCategory&gt;**](SCServiceChannelServicesMessagingProposalsProposalCategory.md)

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

<a id="getproposals"></a>
# **GetProposals**
> List&lt;SCServiceChannelServicesMessagingProposalsProposalInfo&gt; GetProposals (string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Retrieve Proposals

Retrieve Proposals              <br />The filter expressions by defaul is \"$filter CreatedDate ge (Now-90 days)\".              <br />The maximum CreatedDate value is 365 days even if provided.              <br />Dates without 'Dto' endings return UTC date format.              <br />Dates without 'Dto' endings are not recommended for using.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetProposalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProposalsApi(config);
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Retrieve Proposals
                List<SCServiceChannelServicesMessagingProposalsProposalInfo> result = apiInstance.GetProposals(expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProposalsApi.GetProposals: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProposalsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Proposals
    ApiResponse<List<SCServiceChannelServicesMessagingProposalsProposalInfo>> response = apiInstance.GetProposalsWithHttpInfo(expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProposalsApi.GetProposalsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingProposalsProposalInfo&gt;**](SCServiceChannelServicesMessagingProposalsProposalInfo.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Indicates that the requested Proposal is in void status. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getproposalsforrfp"></a>
# **GetProposalsForRfp**
> List&lt;SCServiceChannelServicesMessagingProposalsProposalInfo&gt; GetProposalsForRfp (int rfpId, string? expand = null, string? select = null, string? filter = null, string? orderby = null, int? top = null, int? skip = null, bool? count = null)

Retrieve Rfp Proposals

Retrieve Rfp Proposals

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class GetProposalsForRfpExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProposalsApi(config);
            var rfpId = 56;  // int | 
            var expand = "expand_example";  // string? | Expand a navigation property. (optional) 
            var select = "select_example";  // string? | Select a set of properties to return. (optional) 
            var filter = "filter_example";  // string? | Filter a collection of resources addressed by a request URL. (optional) 
            var orderby = "orderby_example";  // string? | Order resources by the specified property in the response. (optional) 
            var top = 56;  // int? | Return the specified number of items in the response. (optional) 
            var skip = 56;  // int? | Skip the specified number of items in the response. (optional) 
            var count = true;  // bool? | Include the count of the matching resources in the response. (optional) 

            try
            {
                // Retrieve Rfp Proposals
                List<SCServiceChannelServicesMessagingProposalsProposalInfo> result = apiInstance.GetProposalsForRfp(rfpId, expand, select, filter, orderby, top, skip, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProposalsApi.GetProposalsForRfp: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProposalsForRfpWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Rfp Proposals
    ApiResponse<List<SCServiceChannelServicesMessagingProposalsProposalInfo>> response = apiInstance.GetProposalsForRfpWithHttpInfo(rfpId, expand, select, filter, orderby, top, skip, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProposalsApi.GetProposalsForRfpWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **rfpId** | **int** |  |  |
| **expand** | **string?** | Expand a navigation property. | [optional]  |
| **select** | **string?** | Select a set of properties to return. | [optional]  |
| **filter** | **string?** | Filter a collection of resources addressed by a request URL. | [optional]  |
| **orderby** | **string?** | Order resources by the specified property in the response. | [optional]  |
| **top** | **int?** | Return the specified number of items in the response. | [optional]  |
| **skip** | **int?** | Skip the specified number of items in the response. | [optional]  |
| **count** | **bool?** | Include the count of the matching resources in the response. | [optional]  |

### Return type

[**List&lt;SCServiceChannelServicesMessagingProposalsProposalInfo&gt;**](SCServiceChannelServicesMessagingProposalsProposalInfo.md)

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

<a id="proposalsaddusertomlplevelusernameusernamelevelnamelevelname"></a>
# **ProposalsAddUserToMlpLeveluserNameuserNamelevelNamelevelName**
> void ProposalsAddUserToMlpLeveluserNameuserNamelevelNamelevelName (string userName, string levelName)

Add a user to an MLP level

Assigns a user to an existing MLP level. Get a username by sending the [GET /users](https://developer.servicechannel.com/swagger/ui/index?version=3#/Users/GETv3_users_subscriberId__subscriberId__startIndex__startIndex__maxCount__maxCount_) request.              <br />Once you assign a user to an MLP level, you can assign a location to the user and MLP level by using the [PUT /proposals/AddLocationToUserLevel](https://developer.servicechannel.com/swagger/ui/index?version=3#/Proposals/PUTv3_proposals_AddLocationToUserLevel_userName__userName__location__location_) method.              <br />***Note***: Each user can be added to only one MLP level. If a user should be assigned to another level, you first need to [remove this user from the MLP level](https://developer.servicechannel.com/swagger/ui/index?version=3#/Proposals/PUTv3_proposals_RemoveUserFromLevel_userName__userName__location__location_) they currently belong to.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProposalsAddUserToMlpLeveluserNameuserNamelevelNamelevelNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProposalsApi(config);
            var userName = "userName_example";  // string | Username to log into the system. The field is case sensitive.
            var levelName = "levelName_example";  // string | MLP level name.

            try
            {
                // Add a user to an MLP level
                apiInstance.ProposalsAddUserToMlpLeveluserNameuserNamelevelNamelevelName(userName, levelName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProposalsApi.ProposalsAddUserToMlpLeveluserNameuserNamelevelNamelevelName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProposalsAddUserToMlpLeveluserNameuserNamelevelNamelevelNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a user to an MLP level
    apiInstance.ProposalsAddUserToMlpLeveluserNameuserNamelevelNamelevelNameWithHttpInfo(userName, levelName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProposalsApi.ProposalsAddUserToMlpLeveluserNameuserNamelevelNamelevelNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userName** | **string** | Username to log into the system. The field is case sensitive. |  |
| **levelName** | **string** | MLP level name. |  |

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
| **200** | The specified user is assigned to the MLP level. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              400 — Bad Request              503 — Request is empty or null              3401 — The user has already been assigned |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="proposalsapprovalreasonstradetradecategorycategory"></a>
# **ProposalsApprovalReasonsTradeTradeCategoryCategory**
> void ProposalsApprovalReasonsTradeTradeCategoryCategory (string trade, string category)

Retrieve proposal approval reasons

Returns the reasons for approving a proposal for the current subscriber.              <br />Admin users can manage proposal approval reasons in Service Automation in **Admin** &gt; **Proposals** &gt; **Proposal Approve Reasons** if the subscriber has this feature enabled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProposalsApprovalReasonsTradeTradeCategoryCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProposalsApi(config);
            var trade = "trade_example";  // string | The type of work a provider performs. Has a narrower definition than `Category`.
            var category = "category_example";  // string | The overall classification of the performed work.

            try
            {
                // Retrieve proposal approval reasons
                apiInstance.ProposalsApprovalReasonsTradeTradeCategoryCategory(trade, category);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProposalsApi.ProposalsApprovalReasonsTradeTradeCategoryCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProposalsApprovalReasonsTradeTradeCategoryCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve proposal approval reasons
    apiInstance.ProposalsApprovalReasonsTradeTradeCategoryCategoryWithHttpInfo(trade, category);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProposalsApi.ProposalsApprovalReasonsTradeTradeCategoryCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **trade** | **string** | The type of work a provider performs. Has a narrower definition than &#x60;Category&#x60;. |  |
| **category** | **string** | The overall classification of the performed work. |  |

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
| **200** | Proposal approval reasons are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **403** | The requested resource is not allowed for the current user. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="proposalsassignlocationtomlpuserusernameusernamelocationlocation"></a>
# **ProposalsAssignLocationToMlpUseruserNameuserNamelocationlocation**
> void ProposalsAssignLocationToMlpUseruserNameuserNamelocationlocation (string userName, string location)

Add a location to a user’s MLP level

Assigns a particular location to the specified user along with the MLP level.              <br />You can remove a location from the user and MLP level by using the [PUT /proposals/RemoveLocationFromUserLevel](https://developer.servicechannel.com/swagger/ui/index?version=3#/Proposals/PUTv3_proposals_RemoveLocationFromUserLevel_userName__userName__location__location_) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProposalsAssignLocationToMlpUseruserNameuserNamelocationlocationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProposalsApi(config);
            var userName = "userName_example";  // string | Username to log into the system.
            var location = "location_example";  // string | Alphanumeric location identifier in the client’s system.

            try
            {
                // Add a location to a user’s MLP level
                apiInstance.ProposalsAssignLocationToMlpUseruserNameuserNamelocationlocation(userName, location);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProposalsApi.ProposalsAssignLocationToMlpUseruserNameuserNamelocationlocation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProposalsAssignLocationToMlpUseruserNameuserNamelocationlocationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a location to a user’s MLP level
    apiInstance.ProposalsAssignLocationToMlpUseruserNameuserNamelocationlocationWithHttpInfo(userName, location);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProposalsApi.ProposalsAssignLocationToMlpUseruserNameuserNamelocationlocationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userName** | **string** | Username to log into the system. |  |
| **location** | **string** | Alphanumeric location identifier in the client’s system. |  |

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
| **200** | The location is assigned to the specified user and MLP level. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              400 — Bad Request              503 — Request is empty or null              3401 — The location doesn&#39;t exist |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="proposalsassignprojectidtoproposalandrfpproposalidproposalidprojectidprojectid"></a>
# **ProposalsAssignProjectIdToProposalAndRfpproposalIdproposalIdprojectIdprojectId**
> void ProposalsAssignProjectIdToProposalAndRfpproposalIdproposalIdprojectIdprojectId (int proposalId, int projectId)

Assign a ProjectId to a ProposalId and Rfp

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProposalsAssignProjectIdToProposalAndRfpproposalIdproposalIdprojectIdprojectIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProposalsApi(config);
            var proposalId = 56;  // int | 
            var projectId = 56;  // int | 

            try
            {
                // Assign a ProjectId to a ProposalId and Rfp
                apiInstance.ProposalsAssignProjectIdToProposalAndRfpproposalIdproposalIdprojectIdprojectId(proposalId, projectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProposalsApi.ProposalsAssignProjectIdToProposalAndRfpproposalIdproposalIdprojectIdprojectId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProposalsAssignProjectIdToProposalAndRfpproposalIdproposalIdprojectIdprojectIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Assign a ProjectId to a ProposalId and Rfp
    apiInstance.ProposalsAssignProjectIdToProposalAndRfpproposalIdproposalIdprojectIdprojectIdWithHttpInfo(proposalId, projectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProposalsApi.ProposalsAssignProjectIdToProposalAndRfpproposalIdproposalIdprojectIdprojectIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **proposalId** | **int** |  |  |
| **projectId** | **int** |  |  |

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
| **200** | Assign a ProjectId to a ProposalId and Rfp |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              400 - Bad Request              503 — Request is empty or null |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="proposalsassignreasonstradetradecategorycategory"></a>
# **ProposalsAssignReasonsTradeTradeCategoryCategory**
> void ProposalsAssignReasonsTradeTradeCategoryCategory (string trade, string? category = null)

Retrieve the reasons for assigning a proposal

Returns the reasons for assigning a proposal to another user in the subscriber’s organization.              <br />Admin users can manage the reasons for assigning proposals in Service Automation in **Admin** &gt; **Proposals** &gt; **Proposal Assign Reasons** if the subscriber has this feature enabled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProposalsAssignReasonsTradeTradeCategoryCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProposalsApi(config);
            var trade = "trade_example";  // string | The type of work a provider performs. Has a narrower definition than `Category`.
            var category = "category_example";  // string? | The overall classification of the performed work. (optional) 

            try
            {
                // Retrieve the reasons for assigning a proposal
                apiInstance.ProposalsAssignReasonsTradeTradeCategoryCategory(trade, category);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProposalsApi.ProposalsAssignReasonsTradeTradeCategoryCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProposalsAssignReasonsTradeTradeCategoryCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve the reasons for assigning a proposal
    apiInstance.ProposalsAssignReasonsTradeTradeCategoryCategoryWithHttpInfo(trade, category);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProposalsApi.ProposalsAssignReasonsTradeTradeCategoryCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **trade** | **string** | The type of work a provider performs. Has a narrower definition than &#x60;Category&#x60;. |  |
| **category** | **string?** | The overall classification of the performed work. | [optional]  |

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
| **200** | The reasons for assigning a proposal are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **403** | The requested resource is not allowed for the current user. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="proposalsgetmlplevelsforsubscriber"></a>
# **ProposalsGetMlpLevelsForSubscriber**
> void ProposalsGetMlpLevelsForSubscriber ()

Get MLP levels for a subscriber

Returns all MLP levels with their information for the current subscriber.              <br />To retrieve all users assigned to a particular level, use the [GET /proposals/GetUsersByLevelName](https://developer.servicechannel.com/swagger/ui/index?version=3#/Proposals/GETv3_proposals_GetUsersByLevelName_levelName__levelName_) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProposalsGetMlpLevelsForSubscriberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProposalsApi(config);

            try
            {
                // Get MLP levels for a subscriber
                apiInstance.ProposalsGetMlpLevelsForSubscriber();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProposalsApi.ProposalsGetMlpLevelsForSubscriber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProposalsGetMlpLevelsForSubscriberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get MLP levels for a subscriber
    apiInstance.ProposalsGetMlpLevelsForSubscriberWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProposalsApi.ProposalsGetMlpLevelsForSubscriberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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
| **200** | The MLP levels for the current subscriber are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              400 - Bad Request |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="proposalsgetproposals"></a>
# **ProposalsGetProposals**
> void ProposalsGetProposals (SCServiceChannelServicesMessagingProposalsSearchProposalModel proposalModel)

Get Proposals

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProposalsGetProposalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProposalsApi(config);
            var proposalModel = new SCServiceChannelServicesMessagingProposalsSearchProposalModel(); // SCServiceChannelServicesMessagingProposalsSearchProposalModel | 

            try
            {
                // Get Proposals
                apiInstance.ProposalsGetProposals(proposalModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProposalsApi.ProposalsGetProposals: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProposalsGetProposalsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Proposals
    apiInstance.ProposalsGetProposalsWithHttpInfo(proposalModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProposalsApi.ProposalsGetProposalsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **proposalModel** | [**SCServiceChannelServicesMessagingProposalsSearchProposalModel**](SCServiceChannelServicesMessagingProposalsSearchProposalModel.md) |  |  |

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
| **200** | Indicates that the request succeeded and that the requested information is in the response. |  -  |
| **400** | Bad Request - the request could not be understood or was missing required parameters.              &lt;br/&gt;Error codes:              &lt;br&gt; 400 - Bad Request              &lt;br/&gt; 503 - Request should not be null |  -  |
| **401** | Indicates that the requested resource requires authentication.              &lt;br/&gt;Error codes:              &lt;br/&gt; 504 - API call rejected by security permissions              &lt;br/&gt;User does not have Location or Trade access to perform this operation |  -  |
| **500** | Indicates that a generic error has occurred on the server. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="proposalsgetproposalsassociatedwithworkoderexceptrfptrackingnumbertrackingnumber"></a>
# **ProposalsGetProposalsAssociatedWithWorkOderExceptRfptrackingNumbertrackingNumber**
> void ProposalsGetProposalsAssociatedWithWorkOderExceptRfptrackingNumbertrackingNumber (int trackingNumber)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProposalsGetProposalsAssociatedWithWorkOderExceptRfptrackingNumbertrackingNumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProposalsApi(config);
            var trackingNumber = 56;  // int | 

            try
            {
                apiInstance.ProposalsGetProposalsAssociatedWithWorkOderExceptRfptrackingNumbertrackingNumber(trackingNumber);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProposalsApi.ProposalsGetProposalsAssociatedWithWorkOderExceptRfptrackingNumbertrackingNumber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProposalsGetProposalsAssociatedWithWorkOderExceptRfptrackingNumbertrackingNumberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ProposalsGetProposalsAssociatedWithWorkOderExceptRfptrackingNumbertrackingNumberWithHttpInfo(trackingNumber);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProposalsApi.ProposalsGetProposalsAssociatedWithWorkOderExceptRfptrackingNumbertrackingNumberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **trackingNumber** | **int** |  |  |

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
| **200** | Get all proposals for a work order based on tracking numbers that are not associated with an RFP. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              400 - Bad Request              503 — Request is empty or null |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="proposalsgetproposalsassociatedwithworkorderasynctrackingnumbertrackingnumber"></a>
# **ProposalsGetProposalsAssociatedWithWorkOrderAsynctrackingNumbertrackingNumber**
> void ProposalsGetProposalsAssociatedWithWorkOrderAsynctrackingNumbertrackingNumber (int trackingNumber)

Get proposals associated with work order by tracking number. Only for Subscriber

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProposalsGetProposalsAssociatedWithWorkOrderAsynctrackingNumbertrackingNumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProposalsApi(config);
            var trackingNumber = 56;  // int | 

            try
            {
                // Get proposals associated with work order by tracking number. Only for Subscriber
                apiInstance.ProposalsGetProposalsAssociatedWithWorkOrderAsynctrackingNumbertrackingNumber(trackingNumber);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProposalsApi.ProposalsGetProposalsAssociatedWithWorkOrderAsynctrackingNumbertrackingNumber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProposalsGetProposalsAssociatedWithWorkOrderAsynctrackingNumbertrackingNumberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get proposals associated with work order by tracking number. Only for Subscriber
    apiInstance.ProposalsGetProposalsAssociatedWithWorkOrderAsynctrackingNumbertrackingNumberWithHttpInfo(trackingNumber);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProposalsApi.ProposalsGetProposalsAssociatedWithWorkOrderAsynctrackingNumbertrackingNumberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **trackingNumber** | **int** |  |  |

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
| **200** | Get proposals associated with work order by tracking number. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              400 - Bad Request              503 — Request is empty or null |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="proposalsgetproposalstorejecttrackingnumbertrackingnumber"></a>
# **ProposalsGetProposalsToRejecttrackingNumbertrackingNumber**
> List&lt;SCServiceChannelServicesMessagingNotesEmailRecipientResponse&gt; ProposalsGetProposalsToRejecttrackingNumbertrackingNumber (int trackingNumber)

Retrieve proposals that can be reject

Returns list of the proposals that can be reject.              <br />***Note:*** This method is only available to subscriber users.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProposalsGetProposalsToRejecttrackingNumbertrackingNumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProposalsApi(config);
            var trackingNumber = 56;  // int | The unique numeric identifier of the WO.

            try
            {
                // Retrieve proposals that can be reject
                List<SCServiceChannelServicesMessagingNotesEmailRecipientResponse> result = apiInstance.ProposalsGetProposalsToRejecttrackingNumbertrackingNumber(trackingNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProposalsApi.ProposalsGetProposalsToRejecttrackingNumbertrackingNumber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProposalsGetProposalsToRejecttrackingNumbertrackingNumberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve proposals that can be reject
    ApiResponse<List<SCServiceChannelServicesMessagingNotesEmailRecipientResponse>> response = apiInstance.ProposalsGetProposalsToRejecttrackingNumbertrackingNumberWithHttpInfo(trackingNumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProposalsApi.ProposalsGetProposalsToRejecttrackingNumbertrackingNumberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **trackingNumber** | **int** | The unique numeric identifier of the WO. |  |

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
| **200** | Users that can be added to the list of email recipients to notify when a proposal is approved or rejected are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              502 — Proposals to Reject not found              502 — Cannot find proposal data              503 — Invalid WO identifier |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="proposalsgetusersbylevelnamelevelnamelevelname"></a>
# **ProposalsGetUsersByLevelNamelevelNamelevelName**
> void ProposalsGetUsersByLevelNamelevelNamelevelName (string levelName)

Get users by level name

Returns the usernames of employees appointed to the specified MLP level.              <br />You can get MLP levels information for the current subscriber by sending the [GET /proposals/GetMlpLevelsForSubscriber](https://developer.servicechannel.com/swagger/ui/index?version=3#/Proposals/GETv3_proposals_GetMlpLevelsForSubscriber) request.              <br />Refer to ServiceChannel University to learn more about [how to configure MLP levels](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/621282301/Configuring+MLP+Levels).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProposalsGetUsersByLevelNamelevelNamelevelNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProposalsApi(config);
            var levelName = "levelName_example";  // string | MLP level name.

            try
            {
                // Get users by level name
                apiInstance.ProposalsGetUsersByLevelNamelevelNamelevelName(levelName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProposalsApi.ProposalsGetUsersByLevelNamelevelNamelevelName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProposalsGetUsersByLevelNamelevelNamelevelNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get users by level name
    apiInstance.ProposalsGetUsersByLevelNamelevelNamelevelNameWithHttpInfo(levelName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProposalsApi.ProposalsGetUsersByLevelNamelevelNamelevelNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **levelName** | **string** | MLP level name. |  |

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
| **200** | The users assigned to the specified level are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              400 — Bad Request              503 — Request is empty or null              3401 — The level doesn&#39;t exist |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="proposalsproposalidsproposalids0proposalids0proposalids1proposalids1"></a>
# **ProposalsProposalIdsproposalIds0proposalIds0proposalIds1proposalIds1**
> void ProposalsProposalIdsproposalIds0proposalIds0proposalIds1proposalIds1 (List<int> proposalIds)

Get proposal actions by ID

Returns available actions for the specified proposals:               • **Edit.** Proposals that can be changed by your client.               • **Open.** Proposals that haven't been reviewed by your client.               • **On hold.** Proposals that require your client’s further review before being approved or rejected.               • **Approve.** Proposals that have been already approved by your client.               • **Reject.** Proposals that have been rejected by your client.               • **Assign.** Proposals that have not been assigned by your client.              <br />In ServiceChannel University, you can find out more about [taking action on proposals](https://servicechannel.atlassian.net/wiki/spaces/SCU/pages/560103501/Taking+Action+on+Proposals).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProposalsProposalIdsproposalIds0proposalIds0proposalIds1proposalIds1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProposalsApi(config);
            var proposalIds = new List<int>(); // List<int> | Unique numeric identifier of the proposal.

            try
            {
                // Get proposal actions by ID
                apiInstance.ProposalsProposalIdsproposalIds0proposalIds0proposalIds1proposalIds1(proposalIds);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProposalsApi.ProposalsProposalIdsproposalIds0proposalIds0proposalIds1proposalIds1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProposalsProposalIdsproposalIds0proposalIds0proposalIds1proposalIds1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get proposal actions by ID
    apiInstance.ProposalsProposalIdsproposalIds0proposalIds0proposalIds1proposalIds1WithHttpInfo(proposalIds);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProposalsApi.ProposalsProposalIdsproposalIds0proposalIds0proposalIds1proposalIds1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **proposalIds** | [**List&lt;int&gt;**](int.md) | Unique numeric identifier of the proposal. |  |

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
| **200** | The available proposal actions are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="proposalsproposalsreject"></a>
# **ProposalsProposalsReject**
> void ProposalsProposalsReject (List<SCServiceChannelServicesMessagingProposalsUpdateProposalsStatusRequest> data)

Reject proposals

Updates the status of the specified proposal to *Rejected*.              <br />***Note:*** This method is only available to subscriber users.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProposalsProposalsRejectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProposalsApi(config);
            var data = new List<SCServiceChannelServicesMessagingProposalsUpdateProposalsStatusRequest>(); // List<SCServiceChannelServicesMessagingProposalsUpdateProposalsStatusRequest> | 

            try
            {
                // Reject proposals
                apiInstance.ProposalsProposalsReject(data);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProposalsApi.ProposalsProposalsReject: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProposalsProposalsRejectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reject proposals
    apiInstance.ProposalsProposalsRejectWithHttpInfo(data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProposalsApi.ProposalsProposalsRejectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **data** | [**List&lt;SCServiceChannelServicesMessagingProposalsUpdateProposalsStatusRequest&gt;**](SCServiceChannelServicesMessagingProposalsUpdateProposalsStatusRequest.md) |  |  |

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
| **204** | The proposal status is set to *Rejected*, users are notified based on the passed parameters, and the values of the specified parameters are updated.&lt;br/&gt;The response is intentionally blank. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:               100 — Proposal was already rejected              100 — User has no rights to perform this action              401 — Invalid subscriber id              502 — Wrong Proposal Id              502 — Proposal not found              502 — Cannot find proposal data              502 — Cannot find assigned Work Order              502 — Proposal not has WO              502 — Proposals are linked to a different Work Order              502 — You don&#39;t have permissions to process Proposal              502 — Proposal is not MLP and cannot be rejected by an MLP user              502 — Proposal is already rejected              502 — Couldn’t find Proposals to Reject              502 — Couldn&#39;t find the Provider for Proposal              502 — Escalation can&#39;t be performed as all upper levels are empty              502 — Rule set not found              503 — Wrong Work Order Id              503 — More information Required              503 — Proposal requires a Reason for Rejection              503 — The request contains proposals with the same Proposal ID              503 — Request is empty or null |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="proposalsrejectionreasons"></a>
# **ProposalsRejectionReasons**
> void ProposalsRejectionReasons ()

Retrieve proposal rejection reasons

Returns numeric identifiers and descriptions of the reasons for rejecting a proposal.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProposalsRejectionReasonsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProposalsApi(config);

            try
            {
                // Retrieve proposal rejection reasons
                apiInstance.ProposalsRejectionReasons();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProposalsApi.ProposalsRejectionReasons: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProposalsRejectionReasonsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve proposal rejection reasons
    apiInstance.ProposalsRejectionReasonsWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProposalsApi.ProposalsRejectionReasonsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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
| **200** | Proposal rejection reasons are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              400 — Bad Request |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |
| **500** | The server was unable to complete the request due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="proposalsremovelocationfrommlpuserusernameusernamelocationlocation"></a>
# **ProposalsRemoveLocationFromMlpUseruserNameuserNamelocationlocation**
> void ProposalsRemoveLocationFromMlpUseruserNameuserNamelocationlocation (string userName, string location)

Remove a location from a user’s MLP level

Removes the specified location from the user and user’s MLP level.              <br />To add a location, send the [PUT /proposals/AddLocationToUserLevel](https://developer.servicechannel.com/swagger/ui/index?version=3#/Proposals/PUTv3_proposals_AddLocationToUserLevel_userName__userName__location__location_) request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProposalsRemoveLocationFromMlpUseruserNameuserNamelocationlocationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProposalsApi(config);
            var userName = "userName_example";  // string | Username to log into the system.
            var location = "location_example";  // string | Alphanumeric location identifier in the client’s system.

            try
            {
                // Remove a location from a user’s MLP level
                apiInstance.ProposalsRemoveLocationFromMlpUseruserNameuserNamelocationlocation(userName, location);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProposalsApi.ProposalsRemoveLocationFromMlpUseruserNameuserNamelocationlocation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProposalsRemoveLocationFromMlpUseruserNameuserNamelocationlocationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove a location from a user’s MLP level
    apiInstance.ProposalsRemoveLocationFromMlpUseruserNameuserNamelocationlocationWithHttpInfo(userName, location);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProposalsApi.ProposalsRemoveLocationFromMlpUseruserNameuserNamelocationlocationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userName** | **string** | Username to log into the system. |  |
| **location** | **string** | Alphanumeric location identifier in the client’s system. |  |

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
| **200** | The location is successfully removed from the user and MLP level. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              400 — Bad Request              503 — Request is empty or null              3401 — The location doesn&#39;t exist |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="proposalsremovemlpuservalidationasyncuseriduserid"></a>
# **ProposalsRemoveMlpUserValidationAsyncuserIduserId**
> void ProposalsRemoveMlpUserValidationAsyncuserIduserId (int userId)

Whether the user can be deleted from MLP level.

Whether the user can be deleted from MLP level.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProposalsRemoveMlpUserValidationAsyncuserIduserIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProposalsApi(config);
            var userId = 56;  // int | The User Id.

            try
            {
                // Whether the user can be deleted from MLP level.
                apiInstance.ProposalsRemoveMlpUserValidationAsyncuserIduserId(userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProposalsApi.ProposalsRemoveMlpUserValidationAsyncuserIduserId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProposalsRemoveMlpUserValidationAsyncuserIduserIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Whether the user can be deleted from MLP level.
    apiInstance.ProposalsRemoveMlpUserValidationAsyncuserIduserIdWithHttpInfo(userId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProposalsApi.ProposalsRemoveMlpUserValidationAsyncuserIduserIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **int** | The User Id. |  |

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
| **200** | Whether the user can be deleted from MLP level. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              400 — Bad Request              503 — Request is empty or null              3401 — The user has already been assigned |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="proposalsremoveuserfrommlplevelusernameusername"></a>
# **ProposalsRemoveUserFromMlpLeveluserNameuserName**
> void ProposalsRemoveUserFromMlpLeveluserNameuserName (string userName)

Remove a user from an MLP level

Removes the specified user from the assigned MLP level.              <br />To assign a user to an MLP level, use the [PUT /proposals/AddUserToMlpLevel](https://developer.servicechannel.com/swagger/ui/index?version=3#/Proposals/PUTv3_proposals_AddUserToLevelLocation) method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProposalsRemoveUserFromMlpLeveluserNameuserNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProposalsApi(config);
            var userName = "userName_example";  // string | Username to log into the system.

            try
            {
                // Remove a user from an MLP level
                apiInstance.ProposalsRemoveUserFromMlpLeveluserNameuserName(userName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProposalsApi.ProposalsRemoveUserFromMlpLeveluserNameuserName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProposalsRemoveUserFromMlpLeveluserNameuserNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove a user from an MLP level
    apiInstance.ProposalsRemoveUserFromMlpLeveluserNameuserNameWithHttpInfo(userName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProposalsApi.ProposalsRemoveUserFromMlpLeveluserNameuserNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userName** | **string** | Username to log into the system. |  |

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
| **200** | The user is successfully removed from the MLP level. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              400 — Bad Request              503 — Request is empty or null              3401 — The user has already been assigned |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="proposalsstatisticsdaysperioddaysperiod"></a>
# **ProposalsStatisticsdaysPerioddaysPeriod**
> SCServiceChannelServicesMessagingProposalsProposalStatisticsResponse ProposalsStatisticsdaysPerioddaysPeriod (int? daysPeriod = null)

Retrieve statistics on RFPs and proposals

Returns statistics on requests for proposals (RFPs) and proposals for the specified time period for the current provider:               • RFPs awaiting response               • Open proposals               • Approved proposals               • Proposals in the _On Hold_ and _Reviewed_ statuses               • Rejected proposals

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProposalsStatisticsdaysPerioddaysPeriodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProposalsApi(config);
            var daysPeriod = 56;  // int? | Time period set as the number of days prior to the current date for which statistics on RFPs and proposals are returned. The default is 30. (optional) 

            try
            {
                // Retrieve statistics on RFPs and proposals
                SCServiceChannelServicesMessagingProposalsProposalStatisticsResponse result = apiInstance.ProposalsStatisticsdaysPerioddaysPeriod(daysPeriod);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProposalsApi.ProposalsStatisticsdaysPerioddaysPeriod: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProposalsStatisticsdaysPerioddaysPeriodWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve statistics on RFPs and proposals
    ApiResponse<SCServiceChannelServicesMessagingProposalsProposalStatisticsResponse> response = apiInstance.ProposalsStatisticsdaysPerioddaysPeriodWithHttpInfo(daysPeriod);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProposalsApi.ProposalsStatisticsdaysPerioddaysPeriodWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **daysPeriod** | **int?** | Time period set as the number of days prior to the current date for which statistics on RFPs and proposals are returned. The default is 30. | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingProposalsProposalStatisticsResponse**](SCServiceChannelServicesMessagingProposalsProposalStatisticsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Statistics on RFPs and proposals for the requested time period are returned in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              503 — Only for providers usage |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="proposalsproposalidapprove"></a>
# **ProposalsproposalIdApprove**
> void ProposalsproposalIdApprove (int proposalId, SCServiceChannelServicesMessagingProposalsUpdateProposalStatusRequest request)

Approve a proposal

Updates the status of the specified proposal to *Approved*.              <br />***Note:*** This method is only available to subscriber users.              <br />**Example Request**                                PUT /proposals/{proposalId}/approve                  {                     \"Comments\": \"The project starts earlier than expected\",                     \"ProviderEmail\": \"\",                     \"UserEmail\": \"\",                     \"RejectReasonCodeId\": 0,                     \"ActionSource\": \"Standard\",                     \"ReasonString\": \"Best fit for the job and scope\"                  }

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProposalsproposalIdApproveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProposalsApi(config);
            var proposalId = 56;  // int | The unique numeric identifier of the proposal to approve.
            var request = new SCServiceChannelServicesMessagingProposalsUpdateProposalStatusRequest(); // SCServiceChannelServicesMessagingProposalsUpdateProposalStatusRequest | The request to update the proposal status to *Approved*.

            try
            {
                // Approve a proposal
                apiInstance.ProposalsproposalIdApprove(proposalId, request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProposalsApi.ProposalsproposalIdApprove: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProposalsproposalIdApproveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Approve a proposal
    apiInstance.ProposalsproposalIdApproveWithHttpInfo(proposalId, request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProposalsApi.ProposalsproposalIdApproveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **proposalId** | **int** | The unique numeric identifier of the proposal to approve. |  |
| **request** | [**SCServiceChannelServicesMessagingProposalsUpdateProposalStatusRequest**](SCServiceChannelServicesMessagingProposalsUpdateProposalStatusRequest.md) | The request to update the proposal status to *Approved*. |  |

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
| **204** | The proposal status is set to *Approved*, users are notified based on the passed parameters, and the values of the specified parameters are updated.&lt;br/&gt;The response is intentionally blank. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              100 — Proposal amount exceeds user’s NTE limit              401 — Invalid subscriber id              502 — Proposal not found              503 — The proposal status is already Approved              503 — Cannot Approve Proposal that is not assigned to Work Order              503 — Cannot Approve Proposal. The Work Order this proposal is linked to has already been invoiced              503 — The user is MLP user              503 — Request is empty or null |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="proposalsproposalidassignuser"></a>
# **ProposalsproposalIdAssignUser**
> void ProposalsproposalIdAssignUser (int proposalId, SCServiceChannelServicesMessagingProposalsAssignUserToProposalRequest request)

Assign a proposal to a user

Assigns the proposal to the specified user in the subscriber’s organization. If the proposal already has an assignee, the appointed user is updated.              <br />***Note:*** You cannot [assign a proposal](https://developer.servicechannel.com/guides/proposals/assign-or-escalate-a-proposal/#assign-a-proposal-to-a-user) in the *Approved* or *Rejected* status.              <br />**Example Request**                                PUT /proposals/{proposalId}/assignUser                  {                     \"UserId\": 1417703,                     \"Comments\": \"Proposal reassigned at the request of the Store Manager\",                     \"UserEmail\": \"\",                     \"ReasonString\": \"\",                     \"Note\": \"\"                  }

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProposalsproposalIdAssignUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProposalsApi(config);
            var proposalId = 56;  // int | The unique numeric identifier of the proposal to assign to the specified user.
            var request = new SCServiceChannelServicesMessagingProposalsAssignUserToProposalRequest(); // SCServiceChannelServicesMessagingProposalsAssignUserToProposalRequest | The request to assign the proposal to the specified user.

            try
            {
                // Assign a proposal to a user
                apiInstance.ProposalsproposalIdAssignUser(proposalId, request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProposalsApi.ProposalsproposalIdAssignUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProposalsproposalIdAssignUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Assign a proposal to a user
    apiInstance.ProposalsproposalIdAssignUserWithHttpInfo(proposalId, request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProposalsApi.ProposalsproposalIdAssignUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **proposalId** | **int** | The unique numeric identifier of the proposal to assign to the specified user. |  |
| **request** | [**SCServiceChannelServicesMessagingProposalsAssignUserToProposalRequest**](SCServiceChannelServicesMessagingProposalsAssignUserToProposalRequest.md) | The request to assign the proposal to the specified user. |  |

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
| **204** | The proposal is assigned to the specified user, and the response is intentionally blank. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:               502 — Proposal not found              503 — Request is empty or null              503 — Wrong User Id              503 — Selected proposal has been finalized              503 — Selected user has no required rights              503 — Selected user doesn&#39;t have Location or Trade access |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="proposalsproposalidassignwoisfromprojectsmoduleisfromprojectsmodule"></a>
# **ProposalsproposalIdAssignWOisFromProjectsModuleisFromProjectsModule**
> void ProposalsproposalIdAssignWOisFromProjectsModuleisFromProjectsModule (int proposalId, int workorderId, bool? isFromProjectsModule = null)

Attach a work order to a proposal

Links the specified work order to the proposal. If the proposal already has a linked service request, the attached work order is updated. See [Link a WO to a Proposal](https://developer.servicechannel.com/guides/proposals/link-a-WO-to-a-proposal/) for more information.              <br />***Note:*** This method is only available to subscriber users.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProposalsproposalIdAssignWOisFromProjectsModuleisFromProjectsModuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProposalsApi(config);
            var proposalId = 56;  // int | The unique numeric identifier of the proposal to attach the work order to.
            var workorderId = 56;  // int | The unique numeric identifier of the work order to link to the proposal.
            var isFromProjectsModule = false;  // bool? | Is request from projects module. (optional)  (default to false)

            try
            {
                // Attach a work order to a proposal
                apiInstance.ProposalsproposalIdAssignWOisFromProjectsModuleisFromProjectsModule(proposalId, workorderId, isFromProjectsModule);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProposalsApi.ProposalsproposalIdAssignWOisFromProjectsModuleisFromProjectsModule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProposalsproposalIdAssignWOisFromProjectsModuleisFromProjectsModuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Attach a work order to a proposal
    apiInstance.ProposalsproposalIdAssignWOisFromProjectsModuleisFromProjectsModuleWithHttpInfo(proposalId, workorderId, isFromProjectsModule);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProposalsApi.ProposalsproposalIdAssignWOisFromProjectsModuleisFromProjectsModuleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **proposalId** | **int** | The unique numeric identifier of the proposal to attach the work order to. |  |
| **workorderId** | **int** | The unique numeric identifier of the work order to link to the proposal. |  |
| **isFromProjectsModule** | **bool?** | Is request from projects module. | [optional] [default to false] |

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
| **204** | The specified work order is attached to the proposal, and the response is intentionally blank. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              401 — Invalid subscriber id              502 — Proposal not found              503 — Request is empty or null              503 — Proposal already approved              503 — Workorder doesn&#39;t match              503 — The user is MLP user              917 — Invalid WO Identifier |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="proposalsproposalidescalate"></a>
# **ProposalsproposalIdEscalate**
> void ProposalsproposalIdEscalate (int proposalId, SCServiceChannelServicesMessagingProposalsMlpWoRecommendationRequest request)

Escalate a proposal

Escalates the specified proposal to another user in the subscriber’s multi-level proposal (MLP) approval hierarchy. The proposal can be approved, rejected, put on hold, or returned upon escalation. You can attach an existing work order or create a new one while submitting the request.              <br />***Note:*** This method is only available to subscribers with the MLP setting enabled.              <br />MLP users can [escalate a proposal](https://developer.servicechannel.com/guides/proposals/assign-or-escalate-a-proposal/#escalate-a-proposal-for-mlp-users) if the following conditions are met:               • The user's approval level corresponds to the proposal level.               • The Override option is enabled for the user in case their level is higher than the proposal level.              <br />**Example Request**                                PUT /proposals/{proposalId}/escalate                  {                     \"Action\": \"Approve\",                     \"WoType\": 2,                     \"TrackingNumber\": 140324907,                     \"PoNumber\": \"\",                     \"ExistingPoNumber\": \"\",                     \"Category\": \"\",                     \"CategoryId\": ,                     \"ApprovalCode\": \"\",                     \"Priority\": \"\",                     \"Comment\": \"Escalating proposal to the General Manager\",                     \"RejectReasonCodeId\": 0,                     \"ReasonString\": \"\",                     \"EmailsToNotify\": \"john.smith@domain.com\",                     \"EmailMyself\": false,                     \"MyEmail\": \"\",                     \"ProposalId\": 10010836                  }

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProposalsproposalIdEscalateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProposalsApi(config);
            var proposalId = 56;  // int | The unique numeric identifier of the proposal to escalate.
            var request = new SCServiceChannelServicesMessagingProposalsMlpWoRecommendationRequest(); // SCServiceChannelServicesMessagingProposalsMlpWoRecommendationRequest | The request to escalate the proposal to another user in the MLP hierarchy.

            try
            {
                // Escalate a proposal
                apiInstance.ProposalsproposalIdEscalate(proposalId, request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProposalsApi.ProposalsproposalIdEscalate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProposalsproposalIdEscalateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Escalate a proposal
    apiInstance.ProposalsproposalIdEscalateWithHttpInfo(proposalId, request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProposalsApi.ProposalsproposalIdEscalateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **proposalId** | **int** | The unique numeric identifier of the proposal to escalate. |  |
| **request** | [**SCServiceChannelServicesMessagingProposalsMlpWoRecommendationRequest**](SCServiceChannelServicesMessagingProposalsMlpWoRecommendationRequest.md) | The request to escalate the proposal to another user in the MLP hierarchy. |  |

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
| **204** | The specified proposal is escalated and updated with the passed parameters. The response is intentionally blank. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              401 — Invalid subscriber id              502 — Proposal not found              503 — Request is empty or null              503 — The user is not MLP user              503 — Invalid WO Tracking Number              503 — Invalid WO Tracking Number in Proposal              503 — Invalid Wo Type              503 — There is no WO recommendation              503 — Action not found in rules              503 — User level less than Proposal level              503 — ForwardTo item is empty              503 — There is no the action in next rule              503 — Invalid Level              503 — Override flag is false              503 — EndStatus item is empty              503 — Invalid Action |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="proposalsproposalidonhold"></a>
# **ProposalsproposalIdOnhold**
> void ProposalsproposalIdOnhold (int proposalId, SCServiceChannelServicesMessagingProposalsUpdateProposalStatusRequest request)

Put a proposal on hold

Updates the status of the specified proposal to *On Hold*.              <br />***Note:*** This method is only available to subscriber users.              <br />**Example Request**                                PUT /proposals/{proposalId}/onhold                  {                     \"Comments\": \"The proposal needs further review\",                     \"ProviderEmail\": \"\",                     \"UserEmail\": \"\",                     \"RejectReasonCodeId\": 0,                     \"ActionSource\": \"Standard\",                     \"ReasonString\": \"\"                      }

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProposalsproposalIdOnholdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProposalsApi(config);
            var proposalId = 56;  // int | The unique numeric identifier of the proposal to put on hold.
            var request = new SCServiceChannelServicesMessagingProposalsUpdateProposalStatusRequest(); // SCServiceChannelServicesMessagingProposalsUpdateProposalStatusRequest | The request to update the proposal status to *On Hold*.

            try
            {
                // Put a proposal on hold
                apiInstance.ProposalsproposalIdOnhold(proposalId, request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProposalsApi.ProposalsproposalIdOnhold: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProposalsproposalIdOnholdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Put a proposal on hold
    apiInstance.ProposalsproposalIdOnholdWithHttpInfo(proposalId, request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProposalsApi.ProposalsproposalIdOnholdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **proposalId** | **int** | The unique numeric identifier of the proposal to put on hold. |  |
| **request** | [**SCServiceChannelServicesMessagingProposalsUpdateProposalStatusRequest**](SCServiceChannelServicesMessagingProposalsUpdateProposalStatusRequest.md) | The request to update the proposal status to *On Hold*. |  |

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
| **204** | The proposal status is set to *On Hold*, users are notified based on the passed parameters, and the values of the specified parameters are updated.&lt;br/&gt;The response is intentionally blank. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              401 — Invalid subscriber id              502 — Proposal not found              503 — The proposal status is already On Hold              503 — The user is MLP user              503 — Request is empty or null |  -  |
| **401** | The request is not authorized.              &lt;br&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="proposalsproposalidopen"></a>
# **ProposalsproposalIdOpen**
> void ProposalsproposalIdOpen (int proposalId, SCServiceChannelServicesMessagingProposalsUpdateProposalStatusRequest request)

Open a proposal

Updates the status of the specified proposal to *Open*.              <br />***Note:*** This method is only available to subscriber users.              <br />**Example Request**                                PUT /proposals/{proposalId}/open                  {                     \"Comments\": \"The project is resumed\",                     \"ProviderEmail\": \"\",                     \"UserEmail\": \"\",                     \"RejectReasonCodeId\": 0,                     \"ActionSource\": \"Standard\",                     \"ReasonString\": \"\"                      }

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProposalsproposalIdOpenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProposalsApi(config);
            var proposalId = 56;  // int | The unique numeric identifier of the proposal to open.
            var request = new SCServiceChannelServicesMessagingProposalsUpdateProposalStatusRequest(); // SCServiceChannelServicesMessagingProposalsUpdateProposalStatusRequest | The request to update the proposal status to *Open*.

            try
            {
                // Open a proposal
                apiInstance.ProposalsproposalIdOpen(proposalId, request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProposalsApi.ProposalsproposalIdOpen: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProposalsproposalIdOpenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Open a proposal
    apiInstance.ProposalsproposalIdOpenWithHttpInfo(proposalId, request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProposalsApi.ProposalsproposalIdOpenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **proposalId** | **int** | The unique numeric identifier of the proposal to open. |  |
| **request** | [**SCServiceChannelServicesMessagingProposalsUpdateProposalStatusRequest**](SCServiceChannelServicesMessagingProposalsUpdateProposalStatusRequest.md) | The request to update the proposal status to *Open*. |  |

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
| **204** | The proposal status is set to *Open*, users are notified based on the passed parameters, and the values of the specified parameters are updated.&lt;br/&gt;The response is intentionally blank. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              401 — Invalid subscriber id              502 — Proposal not found              503 — The proposal status is already Open              503 — The user is MLP user              503 — Request is empty or null |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="proposalsproposalidrecipients"></a>
# **ProposalsproposalIdRecipients**
> List&lt;SCServiceChannelServicesMessagingNotesEmailRecipientResponse&gt; ProposalsproposalIdRecipients (int proposalId)

Retrieve users who can be added to the list of email recipients to notify of a proposal approval or rejection

Returns users who can be added to the list of email recipients to notify when the specified proposal is approved or rejected.              <br />***Note:*** This method is only available to subscriber users.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProposalsproposalIdRecipientsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProposalsApi(config);
            var proposalId = 56;  // int | The unique numeric identifier of the proposal.

            try
            {
                // Retrieve users who can be added to the list of email recipients to notify of a proposal approval or rejection
                List<SCServiceChannelServicesMessagingNotesEmailRecipientResponse> result = apiInstance.ProposalsproposalIdRecipients(proposalId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProposalsApi.ProposalsproposalIdRecipients: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProposalsproposalIdRecipientsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve users who can be added to the list of email recipients to notify of a proposal approval or rejection
    ApiResponse<List<SCServiceChannelServicesMessagingNotesEmailRecipientResponse>> response = apiInstance.ProposalsproposalIdRecipientsWithHttpInfo(proposalId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProposalsApi.ProposalsproposalIdRecipientsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **proposalId** | **int** | The unique numeric identifier of the proposal. |  |

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
| **200** | Users who can be added to the list of email recipients to notify when a proposal is approved or rejected are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              503 — Invalid proposal identifier              503 — Request is empty or null |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="proposalsproposalidrejectuseproposalalertemailsuseproposalalertemails"></a>
# **ProposalsproposalIdRejectuseProposalAlertEmailsuseProposalAlertEmails**
> void ProposalsproposalIdRejectuseProposalAlertEmailsuseProposalAlertEmails (int proposalId, SCServiceChannelServicesMessagingProposalsUpdateProposalStatusRequest request, bool? useProposalAlertEmails = null)

Reject a proposal

Updates the status of the specified proposal to *Rejected*.              <br />You can send a proposal rejection notification to a specific user or to all users from the **Proposals/Proposal Alerts** list.               • `ProviderEmail` and `UserEmail`. Use these parameters to send a proposal rejection notification to a specific user. If passed, any of these parameters prevails over `useProposalAlertEmails`. In case you pass a value to the `ProviderEmail` or `UserEmail` parameter in the request body and set `useProposalAlertEmails` to `true`, a notification is sent to the specified email address, while users from the **Proposals/Proposal Alerts** list are not notified.               • `useProposalAlertEmails`. Set this parameter to `true` to send proposal rejection notifications to all users listed in the **Proposals/Proposal Alerts** section of **Dispatch Preferences**.              <br />***Note:*** This method is only available to subscriber users.              <br />**Example Request**                                PUT /proposals/{proposalId}/reject                  {                     \"Comments\": \"The project is canceled\",                     \"ProviderEmail\": \"\",                     \"UserEmail\": \"\",                     \"RejectReasonCodeId\": 7,                     \"ActionSource\": \"Standard\",                     \"ReasonString\": \"\"                      }

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProposalsproposalIdRejectuseProposalAlertEmailsuseProposalAlertEmailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProposalsApi(config);
            var proposalId = 56;  // int | The unique numeric identifier of the proposal to reject.
            var request = new SCServiceChannelServicesMessagingProposalsUpdateProposalStatusRequest(); // SCServiceChannelServicesMessagingProposalsUpdateProposalStatusRequest | The request to update the proposal status to *Rejected*.
            var useProposalAlertEmails = false;  // bool? | Defines if a proposal rejection notification is sent to all users listed in the **Proposals/Proposal Alerts** section of **Dispatch Preferences**.              If the parameter value is `true`, users from the **Proposals/Proposal Alerts** list get a notification if the `ProviderEmail` and `UserEmail` parameters are not passed. If set to `false` or not passed, this parameter is ignored. (optional)  (default to false)

            try
            {
                // Reject a proposal
                apiInstance.ProposalsproposalIdRejectuseProposalAlertEmailsuseProposalAlertEmails(proposalId, request, useProposalAlertEmails);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProposalsApi.ProposalsproposalIdRejectuseProposalAlertEmailsuseProposalAlertEmails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProposalsproposalIdRejectuseProposalAlertEmailsuseProposalAlertEmailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reject a proposal
    apiInstance.ProposalsproposalIdRejectuseProposalAlertEmailsuseProposalAlertEmailsWithHttpInfo(proposalId, request, useProposalAlertEmails);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProposalsApi.ProposalsproposalIdRejectuseProposalAlertEmailsuseProposalAlertEmailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **proposalId** | **int** | The unique numeric identifier of the proposal to reject. |  |
| **request** | [**SCServiceChannelServicesMessagingProposalsUpdateProposalStatusRequest**](SCServiceChannelServicesMessagingProposalsUpdateProposalStatusRequest.md) | The request to update the proposal status to *Rejected*. |  |
| **useProposalAlertEmails** | **bool?** | Defines if a proposal rejection notification is sent to all users listed in the **Proposals/Proposal Alerts** section of **Dispatch Preferences**.              If the parameter value is &#x60;true&#x60;, users from the **Proposals/Proposal Alerts** list get a notification if the &#x60;ProviderEmail&#x60; and &#x60;UserEmail&#x60; parameters are not passed. If set to &#x60;false&#x60; or not passed, this parameter is ignored. | [optional] [default to false] |

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
| **204** | The proposal status is set to *Rejected*, users are notified based on the passed parameters, and the values of the specified parameters are updated.&lt;br/&gt;The response is intentionally blank. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              401 — Invalid subscriber id              502 — Proposal not found              503 — The proposal status is already Rejected              503 — The user is MLP user              503 — Request is empty or null |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="proposalsproposalidusers"></a>
# **ProposalsproposalIdUsers**
> SCServiceChannelServicesMessagingUsersUserInfo ProposalsproposalIdUsers (int proposalId)

Retrieve users who can be assigned a proposal

Returns a list of users in the subscriber’s organization who can be assigned the specified proposal. You can send this request to retrieve the user ID before [assigning a proposal](https://developer.servicechannel.com/guides/proposals/assign-or-escalate-a-proposal/#assign-a-proposal-to-a-user).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProposalsproposalIdUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProposalsApi(config);
            var proposalId = 56;  // int | The unique numeric identifier of the proposal.

            try
            {
                // Retrieve users who can be assigned a proposal
                SCServiceChannelServicesMessagingUsersUserInfo result = apiInstance.ProposalsproposalIdUsers(proposalId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProposalsApi.ProposalsproposalIdUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProposalsproposalIdUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve users who can be assigned a proposal
    ApiResponse<SCServiceChannelServicesMessagingUsersUserInfo> response = apiInstance.ProposalsproposalIdUsersWithHttpInfo(proposalId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProposalsApi.ProposalsproposalIdUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **proposalId** | **int** | The unique numeric identifier of the proposal. |  |

### Return type

[**SCServiceChannelServicesMessagingUsersUserInfo**](SCServiceChannelServicesMessagingUsersUserInfo.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Users who can be assigned the specified proposal are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              502 — Proposal not found |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="proposalsproposalidvalidate"></a>
# **ProposalsproposalIdValidate**
> void ProposalsproposalIdValidate (int proposalId)

Validate a proposal

Checks if the specified proposal exists for the current user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProposalsproposalIdValidateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProposalsApi(config);
            var proposalId = 56;  // int | The unique numeric identifier of the proposal to validate.

            try
            {
                // Validate a proposal
                apiInstance.ProposalsproposalIdValidate(proposalId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProposalsApi.ProposalsproposalIdValidate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProposalsproposalIdValidateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Validate a proposal
    apiInstance.ProposalsproposalIdValidateWithHttpInfo(proposalId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProposalsApi.ProposalsproposalIdValidateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **proposalId** | **int** | The unique numeric identifier of the proposal to validate. |  |

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
| **200** | The specified proposal exists for the current user. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              502 — Proposal not found |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="proposalsrfpid"></a>
# **ProposalsrfpId**
> void ProposalsrfpId (int rfpId)

Delete Proposal and Rfp reference with projectId by rfpId

Delete Proposal and Rfp reference with projectId by rfpId

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProposalsrfpIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProposalsApi(config);
            var rfpId = 56;  // int | The unique numeric identifier of the RFP.

            try
            {
                // Delete Proposal and Rfp reference with projectId by rfpId
                apiInstance.ProposalsrfpId(rfpId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProposalsApi.ProposalsrfpId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProposalsrfpIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Proposal and Rfp reference with projectId by rfpId
    apiInstance.ProposalsrfpIdWithHttpInfo(rfpId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProposalsApi.ProposalsrfpIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **rfpId** | **int** | The unique numeric identifier of the RFP. |  |

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
| **200** | The projectId reference is successfully removed from proposal and rfp. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc.              &lt;br/&gt;Error codes:              400 — Bad Request              503 — Request is empty or null |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="proposalsstatusesstatusesassignedtoassignedtoskipskiptoptop"></a>
# **ProposalsstatusesstatusesassignedToassignedToskipskiptoptop**
> SCServiceChannelServicesMessagingProposalsProposalStatisticsResponse ProposalsstatusesstatusesassignedToassignedToskipskiptoptop (string? statuses = null, int? assignedTo = null, int? skip = null, int? top = null)

Retrieve proposals

Returns proposals based on the specified input parameters for the current subscriber.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ServiceChannel.Api.Api;
using ServiceChannel.Api.Client;
using ServiceChannel.Api.Model;

namespace Example
{
    public class ProposalsstatusesstatusesassignedToassignedToskipskiptoptopExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sb2api.servicechannel.com/v3";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProposalsApi(config);
            var statuses = "statuses_example";  // string? | Proposal statuses separated by commas. Valid values: *Open*, *On Hold*, *Approved*, *Rejected*, *Void*, *Reviewed*.              Proposals in all statuses are returned if the value is not passed. (optional) 
            var assignedTo = 56;  // int? | The unique numeric identifier of the user who is assigned the proposals. (optional) 
            var skip = 56;  // int? | The number of entries to skip in the response (starting from the first one). (optional) 
            var top = 56;  // int? | The number of entries to return. The default value is 50. (optional) 

            try
            {
                // Retrieve proposals
                SCServiceChannelServicesMessagingProposalsProposalStatisticsResponse result = apiInstance.ProposalsstatusesstatusesassignedToassignedToskipskiptoptop(statuses, assignedTo, skip, top);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProposalsApi.ProposalsstatusesstatusesassignedToassignedToskipskiptoptop: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProposalsstatusesstatusesassignedToassignedToskipskiptoptopWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve proposals
    ApiResponse<SCServiceChannelServicesMessagingProposalsProposalStatisticsResponse> response = apiInstance.ProposalsstatusesstatusesassignedToassignedToskipskiptoptopWithHttpInfo(statuses, assignedTo, skip, top);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProposalsApi.ProposalsstatusesstatusesassignedToassignedToskipskiptoptopWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **statuses** | **string?** | Proposal statuses separated by commas. Valid values: *Open*, *On Hold*, *Approved*, *Rejected*, *Void*, *Reviewed*.              Proposals in all statuses are returned if the value is not passed. | [optional]  |
| **assignedTo** | **int?** | The unique numeric identifier of the user who is assigned the proposals. | [optional]  |
| **skip** | **int?** | The number of entries to skip in the response (starting from the first one). | [optional]  |
| **top** | **int?** | The number of entries to return. The default value is 50. | [optional]  |

### Return type

[**SCServiceChannelServicesMessagingProposalsProposalStatisticsResponse**](SCServiceChannelServicesMessagingProposalsProposalStatisticsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested proposals are in the response. |  -  |
| **400** | The request is not accepted due to bad syntax, missing parameters, insufficient data, etc. |  -  |
| **401** | The request is not authorized.              &lt;br/&gt;Error codes:              504 — API call rejected by security permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

