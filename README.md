# ServiceChannel.OpenAPIGenerated.Api - ASP.NET Core 6.0 Server

The ServiceChannel API is a RESTful and stateless API. It accepts standard HTTP verbs and supports OAuth 2.0 for authorizing requests.
    Our API returns common HTTP status codes as well as JSON encapsulated data.
    See [API Overview](https://developer.servicechannel.com/basics/introduction/overview/) for the intro to ServiceChannel API.<br>
    <h3>Authentication and Authorization</h3>You should have a ServiceChannel account, register your application, and obtain `access_token` to integrate with our API.
    See [Authentication and Authorization](https://developer.servicechannel.com/basics/general/authentication/) for more information.
    To use this API playground, click **Authorize** and sign in to ServiceChannel.<br>
    <h3>Environment</h3> All calls in this API Reference point to the **SB2 environment**.
    See [Environments](https://developer.servicechannel.com/basics/general/environments/) for more information.<br>
    <h3>API Version</h3>The current stable version of the ServiceChannel API is `v3`. In the request URL, `v3` is a version prefix that should be present.
    When you omit the version prefix, calls point to the minimum supported version of the API.
    We recommend you to always specify the API version to avoid possible errors.

## Upgrade NuGet Packages

NuGet packages get frequently updated.

To upgrade this solution to the latest version of all NuGet packages, use the dotnet-outdated tool.


Install dotnet-outdated tool:

```
dotnet tool install --global dotnet-outdated-tool
```

Upgrade only to new minor versions of packages

```
dotnet outdated --upgrade --version-lock Major
```

Upgrade to all new versions of packages (more likely to include breaking API changes)

```
dotnet outdated --upgrade
```


## Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```
<a id="regenerating"></a>

## How to regenerate this project

There is a script in `/script` called `generateClient.sh` that will do all the heavy lifting for you. Check the config.json for options and run `./script/generateClient.sh` and bingo bango, you're good to go.