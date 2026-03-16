# CarrierAccounts

## Overview

Carriers are the companies who deliver your package. Shippo uses Carrier account objects as credentials to retrieve shipping rates and purchase labels from shipping Carriers.

### Available Operations

* [List](#list) - List all carrier accounts
* [Create](#create) - Create a new carrier account
* [Get](#get) - Retrieve a carrier account
* [Update](#update) - Update a carrier account
* [InitiateOauth2Signin](#initiateoauth2signin) - Connect an existing carrier account using OAuth 2.0
* [Register](#register) - Add a Shippo carrier account
* [GetRegistrationStatus](#getregistrationstatus) - Get Carrier Registration status

## List

Returns a list of all carrier accounts connected to your Shippo account. These carrier accounts include both Shippo carrier accounts and your own carrier accounts that you have connected to your Shippo account.

Additionally, you can get information about the service levels associated with each carrier account by passing in the `?service_levels=true` query parameter. <br>
Using it appends the property `service_levels` to each carrier account. <br>
By default, if the query parameter is omitted, the `service_levels` property will not be included in the response.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ListCarrierAccounts" method="get" path="/carrier_accounts" -->
```csharp
using Shippo;
using Shippo.Models.Components;
using Shippo.Models.Requests;

var sdk = new ShippoSDK(
    shippoApiVersion: "2018-02-08",
    apiKeyHeader: "<YOUR_API_KEY_HERE>"
);

ListCarrierAccountsRequest req = new ListCarrierAccountsRequest() {};

var res = await sdk.CarrierAccounts.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListCarrierAccountsRequest](../../Models/Requests/ListCarrierAccountsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[CarrierAccountPaginatedList](../../Models/Components/CarrierAccountPaginatedList.md)**

### Errors

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |

## Create

Creates a new carrier account or connects an existing carrier account to the Shippo account.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="CreateCarrierAccount" method="post" path="/carrier_accounts" -->
```csharp
using Shippo;
using Shippo.Models.Components;
using System.Collections.Generic;

var sdk = new ShippoSDK(
    shippoApiVersion: "2018-02-08",
    apiKeyHeader: "<YOUR_API_KEY_HERE>"
);

var res = await sdk.CarrierAccounts.CreateAsync(connectExistingOwnAccountRequest: new ConnectExistingOwnAccountRequest() {
    AccountId = "321123",
    Carrier = "fedex",
    Metadata = "FEDEX Account",
    Parameters = ConnectExistingOwnAccountRequestParameters.CreateMapOfAny(
        new Dictionary<string, object>() {
            { "first_name", "Abdullah" },
            { "last_name", "Ward" },
            { "phone_number", "915-577-4415 x207" },
            { "from_address_st", "<value>" },
            { "from_address_city", "<value>" },
            { "from_address_state", "<value>" },
            { "from_address_zip", "<value>" },
            { "from_address_country_iso2", "<value>" },
            { "use_multi_factor_registration", true },
            { "verification_option", "INVOICE" },
            { "verification_invoice_amount", "340" },
            { "verification_invoice_date", "2024-03-09" },
            { "verification_invoice_currency", "USD" },
        }
    ),
    Test = false,
});

// handle response
```

### Parameters

| Parameter                                                                                                                                                          | Type                                                                                                                                                               | Required                                                                                                                                                           | Description                                                                                                                                                        | Example                                                                                                                                                            |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ConnectExistingOwnAccountRequest`                                                                                                                                 | [ConnectExistingOwnAccountRequest](../../Models/Components/ConnectExistingOwnAccountRequest.md)                                                                    | :heavy_check_mark:                                                                                                                                                 | Examples.                                                                                                                                                          |                                                                                                                                                                    |
| `ShippoApiVersion`                                                                                                                                                 | *string*                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                 | Optional string used to pick a non-default API version to use. See our <a href="https://docs.goshippo.com/docs/api_concepts/apiversioning/">API version</a> guide. | 2018-02-08                                                                                                                                                         |

### Response

**[CarrierAccount](../../Models/Components/CarrierAccount.md)**

### Errors

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |

## Get

Returns an existing carrier account using an object ID.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="GetCarrierAccount" method="get" path="/carrier_accounts/{CarrierAccountId}" -->
```csharp
using Shippo;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    shippoApiVersion: "2018-02-08",
    apiKeyHeader: "<YOUR_API_KEY_HERE>"
);

var res = await sdk.CarrierAccounts.GetAsync(carrierAccountId: "<id>");

// handle response
```

### Parameters

| Parameter                                                                                                                                                          | Type                                                                                                                                                               | Required                                                                                                                                                           | Description                                                                                                                                                        | Example                                                                                                                                                            |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CarrierAccountId`                                                                                                                                                 | *string*                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                 | Object ID of the carrier account                                                                                                                                   |                                                                                                                                                                    |
| `ShippoApiVersion`                                                                                                                                                 | *string*                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                 | Optional string used to pick a non-default API version to use. See our <a href="https://docs.goshippo.com/docs/api_concepts/apiversioning/">API version</a> guide. | 2018-02-08                                                                                                                                                         |

### Response

**[CarrierAccount](../../Models/Components/CarrierAccount.md)**

### Errors

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |

## Update

Updates an existing carrier account object. The account_id and carrier can't be updated. This is because they form the unique identifier together.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="UpdateCarrierAccount" method="put" path="/carrier_accounts/{CarrierAccountId}" -->
```csharp
using Shippo;
using Shippo.Models.Components;
using System.Collections.Generic;

var sdk = new ShippoSDK(
    shippoApiVersion: "2018-02-08",
    apiKeyHeader: "<YOUR_API_KEY_HERE>"
);

var res = await sdk.CarrierAccounts.UpdateAsync(
    carrierAccountId: "<id>",
    carrierAccountBase: new CarrierAccountBase() {
        AccountId = "****",
        Carrier = "usps",
        Parameters = CarrierAccountBaseParameters.CreateMapOfAny(
            new Dictionary<string, object>() {
                { "first_name", "Eldora" },
                { "last_name", "Weber" },
                { "phone_number", "1-505-428-6798" },
                { "from_address_st", "<value>" },
                { "from_address_city", "<value>" },
                { "from_address_state", "<value>" },
                { "from_address_zip", "<value>" },
                { "from_address_country_iso2", "<value>" },
                { "use_multi_factor_registration", true },
                { "verification_option", "CALL" },
                { "verification_invoice_amount", "340" },
                { "verification_invoice_date", "2024-03-09" },
                { "verification_invoice_currency", "USD" },
            }
        ),
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                          | Type                                                                                                                                                               | Required                                                                                                                                                           | Description                                                                                                                                                        | Example                                                                                                                                                            |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CarrierAccountId`                                                                                                                                                 | *string*                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                 | Object ID of the carrier account                                                                                                                                   |                                                                                                                                                                    |
| `ShippoApiVersion`                                                                                                                                                 | *string*                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                 | Optional string used to pick a non-default API version to use. See our <a href="https://docs.goshippo.com/docs/api_concepts/apiversioning/">API version</a> guide. | 2018-02-08                                                                                                                                                         |
| `CarrierAccountBase`                                                                                                                                               | [CarrierAccountBase](../../Models/Components/CarrierAccountBase.md)                                                                                                | :heavy_minus_sign:                                                                                                                                                 | Examples.                                                                                                                                                          |                                                                                                                                                                    |

### Response

**[CarrierAccount](../../Models/Components/CarrierAccount.md)**

### Errors

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |

## InitiateOauth2Signin

Used by client applications to setup or reconnect an existing carrier account with carriers that support OAuth 2.0

### Example Usage

<!-- UsageSnippet language="csharp" operationID="InitiateOauth2Signin" method="get" path="/carrier_accounts/{CarrierAccountObjectId}/signin/initiate" -->
```csharp
using Shippo;
using Shippo.Models.Components;
using Shippo.Models.Requests;

var sdk = new ShippoSDK(
    shippoApiVersion: "2018-02-08",
    apiKeyHeader: "<YOUR_API_KEY_HERE>"
);

InitiateOauth2SigninRequest req = new InitiateOauth2SigninRequest() {
    CarrierAccountObjectId = "<id>",
    RedirectUri = "https://ashamed-reporter.biz",
};

var res = await sdk.CarrierAccounts.InitiateOauth2SigninAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [InitiateOauth2SigninRequest](../../Models/Requests/InitiateOauth2SigninRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[InitiateOauth2SigninResponse](../../Models/Requests/InitiateOauth2SigninResponse.md)**

### Errors

| Error Type                                                                   | Status Code                                                                  | Content Type                                                                 |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| Shippo.Models.Errors.InitiateOauth2SigninResponseBody                        | 400                                                                          | application/json                                                             |
| Shippo.Models.Errors.InitiateOauth2SigninCarrierAccountsResponseResponseBody | 401                                                                          | application/json                                                             |
| Shippo.Models.Errors.InitiateOauth2SigninCarrierAccountsResponseBody         | 404                                                                          | application/json                                                             |
| Shippo.Models.Errors.SDKException                                            | 4XX, 5XX                                                                     | \*/\*                                                                        |

## Register

Adds a Shippo carrier account

### Example Usage

<!-- UsageSnippet language="csharp" operationID="RegisterCarrierAccount" method="post" path="/carrier_accounts/register/new" -->
```csharp
using Shippo;
using Shippo.Models.Components;
using Shippo.Models.Requests;

var sdk = new ShippoSDK(
    shippoApiVersion: "2018-02-08",
    apiKeyHeader: "<YOUR_API_KEY_HERE>"
);

var res = await sdk.CarrierAccounts.RegisterAsync(requestBody: RegisterCarrierAccountRequestBody.CreateDeutschePost(
    new CarrierAccountDeutschePostCreateRequest() {
        Parameters = new CarrierAccountDeutschePostCreateRequestParameters() {},
    }
));

// handle response
```

### Parameters

| Parameter                                                                                                                                                          | Type                                                                                                                                                               | Required                                                                                                                                                           | Description                                                                                                                                                        | Example                                                                                                                                                            |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `RequestBody`                                                                                                                                                      | [RegisterCarrierAccountRequestBody](../../Models/Requests/RegisterCarrierAccountRequestBody.md)                                                                    | :heavy_check_mark:                                                                                                                                                 | The body of the request.                                                                                                                                           |                                                                                                                                                                    |
| `ShippoApiVersion`                                                                                                                                                 | *string*                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                 | Optional string used to pick a non-default API version to use. See our <a href="https://docs.goshippo.com/docs/api_concepts/apiversioning/">API version</a> guide. | 2018-02-08                                                                                                                                                         |

### Response

**[CarrierAccount](../../Models/Components/CarrierAccount.md)**

### Errors

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |

## GetRegistrationStatus

Returns the registration status for the given account for the given carrier

### Example Usage

<!-- UsageSnippet language="csharp" operationID="GetCarrierRegistrationStatus" method="get" path="/carrier_accounts/reg-status" -->
```csharp
using Shippo;
using Shippo.Models.Components;
using Shippo.Models.Requests;

var sdk = new ShippoSDK(
    shippoApiVersion: "2018-02-08",
    apiKeyHeader: "<YOUR_API_KEY_HERE>"
);

var res = await sdk.CarrierAccounts.GetRegistrationStatusAsync(carrier: Carrier.Ups);

// handle response
```

### Parameters

| Parameter                                                                                                                                                          | Type                                                                                                                                                               | Required                                                                                                                                                           | Description                                                                                                                                                        | Example                                                                                                                                                            |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `Carrier`                                                                                                                                                          | [Carrier](../../Models/Requests/Carrier.md)                                                                                                                        | :heavy_check_mark:                                                                                                                                                 | filter by specific carrier                                                                                                                                         |                                                                                                                                                                    |
| `ShippoApiVersion`                                                                                                                                                 | *string*                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                 | Optional string used to pick a non-default API version to use. See our <a href="https://docs.goshippo.com/docs/api_concepts/apiversioning/">API version</a> guide. | 2018-02-08                                                                                                                                                         |

### Response

**[CarrierAccountRegistrationStatus](../../Models/Components/CarrierAccountRegistrationStatus.md)**

### Errors

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |