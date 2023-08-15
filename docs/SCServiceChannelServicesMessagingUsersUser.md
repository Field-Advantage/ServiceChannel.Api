# ServiceChannel.Api.Model.SCServiceChannelServicesMessagingUsersUser
User details object.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique user identifier. | [optional] 
**SubscriberId** | **int** | Unique subscriber ID. | [optional] 
**UserName** | **string** | Username of the user.&lt;br /&gt; • For subscriber users, the username appears as **User Id** on the \&quot;General Info\&quot; tab of the user profile page.&lt;br /&gt; • For provider users, the username is listed as **UserID** under \&quot;Access\&quot; on the \&quot;General\&quot; tab of the user profile page. | [optional] 
**FullName** | **string** | Full name of the user.&lt;br /&gt; • For subscriber users, the full name appears as **User Name** on the \&quot;General Info\&quot; tab of the user profile page.&lt;br /&gt; • For provider users, you can see their first and last name under \&quot;Basic\&quot; on the \&quot;General\&quot; tab of the user profile page. | [optional] 
**Email** | **string** | User’s email address. | [optional] 
**PsmEmail** | **string** | Email address through which a user can reset their password. | [optional] 
**Disabled** | **bool** | Defines if a user is deactivated. | [optional] [default to false]
**Roles** | **List&lt;string&gt;** | Secondary roles assigned to a subscriber user that determine their permissions and level of access to various Service Automation modules. | [optional] 
**Permissions** | **List&lt;string&gt;** | Permissions assigned to a subscriber user that determine whether they have full or read-only access to various Service Automation modules. | [optional] 
**UserType** | **string** | Subscriber user type defining their level of access to ServiceChannel:&lt;br /&gt; • &#x60;Corporate&#x60; — a user can work in Service Automation.&lt;br /&gt; • &#x60;Dashboard&#x60; — a user can only access the dashboard assigned to them.&lt;br /&gt;&#x60;0&#x60; is returned for provider users. | [optional] 
**Dashboard** | [**SCServiceChannelServicesMessagingUsersDashboardInfo**](SCServiceChannelServicesMessagingUsersDashboardInfo.md) |  | [optional] 
**Access** | [**SCServiceChannelServicesMessagingUsersAccessOptions**](SCServiceChannelServicesMessagingUsersAccessOptions.md) |  | [optional] 
**Limits** | [**SCServiceChannelServicesMessagingUsersLimitOptions**](SCServiceChannelServicesMessagingUsersLimitOptions.md) |  | [optional] 
**FeedRole** | **string** |  | [optional] 
**MliUserInfo** | [**SCServiceChannelServicesMessagingUsersMliUserInfo**](SCServiceChannelServicesMessagingUsersMliUserInfo.md) |  | [optional] 
**MlpUserInfo** | [**SCServiceChannelServicesMessagingUsersMlpUserInfo**](SCServiceChannelServicesMessagingUsersMlpUserInfo.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

