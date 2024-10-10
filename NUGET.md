# Shippo


<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using Shippo;
using Shippo.Models.Requests;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

var res = await sdk.Addresses.ListAsync(
    page: 1,
    results: 5,
    shippoApiVersion: "2018-02-08"
);

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Error Handling [errors] -->
## Error Handling

Handling errors in this SDK should largely match your expectations. All operations return a response object or throw an exception.

By default, an API error will raise a `Shippo.Models.Errors.SDKException` exception, which has the following properties:

| Property      | Type                  | Description           |
|---------------|-----------------------|-----------------------|
| `Message`     | *string*              | The error message     |
| `StatusCode`  | *int*                 | The HTTP status code  |
| `RawResponse` | *HttpResponseMessage* | The raw HTTP response |
| `Body`        | *string*              | The response content  |

When custom error responses are specified for an operation, the SDK may also throw their associated exceptions. You can refer to respective *Errors* tables in SDK docs for more details on possible exception types for each operation. For example, the `InitiateOauth2SigninAsync` method throws the following exceptions:

| Error Type                                                                   | Status Code                                                                  | Content Type                                                                 |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| Shippo.Models.Errors.InitiateOauth2SigninResponseBody                        | 400                                                                          | application/json                                                             |
| Shippo.Models.Errors.InitiateOauth2SigninCarrierAccountsResponseBody         | 401                                                                          | application/json                                                             |
| Shippo.Models.Errors.InitiateOauth2SigninCarrierAccountsResponseResponseBody | 404                                                                          | application/json                                                             |
| Shippo.Models.Errors.SDKException                                            | 4XX, 5XX                                                                     | \*/\*                                                                        |

### Example

```csharp
using Shippo;
using Shippo.Models.Requests;
using Shippo.Models.Components;
using System;
using Shippo.Models.Errors;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

try
{
    InitiateOauth2SigninRequest req = new InitiateOauth2SigninRequest() {
        CarrierAccountObjectId = "<id>",
        RedirectUri = "https://enlightened-mortise.com/",
    };

    var res = await sdk.CarrierAccounts.InitiateOauth2SigninAsync(req);

    // handle response
}
catch (Exception ex)
{
    if (ex is InitiateOauth2SigninResponseBody)
    {
        // Handle exception data
        throw;
    }
    else if (ex is InitiateOauth2SigninCarrierAccountsResponseBody)
    {
        // Handle exception data
        throw;
    }
    else if (ex is InitiateOauth2SigninCarrierAccountsResponseResponseBody)
    {
        // Handle exception data
        throw;
    }
    else if (ex is Shippo.Models.Errors.SDKException)
    {
        // Handle default exception
        throw;
    }
}
```
<!-- End Error Handling [errors] -->

<!-- Start Server Selection [server] -->
## Server Selection

### Select Server by Index

You can override the default server globally by passing a server index to the `serverIndex: number` optional parameter when initializing the SDK client instance. The selected server will then be used as the default on the operations that use it. This table lists the indexes associated with the available servers:

| # | Server | Variables |
| - | ------ | --------- |
| 0 | `https://api.goshippo.com` | None |




### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverUrl: str` optional parameter when initializing the SDK client instance. For example:
<!-- End Server Selection [server] -->

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name           | Type           | Scheme         |
| -------------- | -------------- | -------------- |
| `APIKeyHeader` | apiKey         | API key        |

To authenticate with the API the `APIKeyHeader` parameter must be set when initializing the SDK client instance. For example:
```csharp
using Shippo;
using Shippo.Models.Requests;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

var res = await sdk.Addresses.ListAsync(
    page: 1,
    results: 5,
    shippoApiVersion: "2018-02-08"
);

// handle response
```
<!-- End Authentication [security] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->