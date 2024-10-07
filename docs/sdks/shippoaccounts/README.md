# ShippoAccounts
(*ShippoAccounts*)

## Overview

Shippo Accounts are used by Shippo Platform Accounts to create and manage Managed Shippo Accounts. 
Managed Shippo Accounts are headless accounts that represent your customers. They are opaque to your end customers, meaning customers do not need to create their own Shippo login or have a billing relationship with Shippo. 
They can be used by marketplaces, e-commerce platforms, and third-party logistics providers who want to offer, seamless, built-in shipping functionality to their customers. See our <a href="https://docs.goshippo.com/docs/platformaccounts/platform_accounts/">guide</a> for more details.
<SchemaDefinition schemaRef="#/components/schemas/ShippoAccount"/>

### Available Operations

* [List](#list) - List all Shippo Accounts
* [Create](#create) - Create a Shippo Account
* [Get](#get) - Retrieve a Shippo Account
* [Update](#update) - Update a Shippo Account

## List

Returns a list of Shippo Managed Accounts objects.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Requests;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

var res = await sdk.ShippoAccounts.ListAsync(
    page: 1,
    results: 25,
    shippoApiVersion: "2018-02-08"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                          | Type                                                                                                                                                               | Required                                                                                                                                                           | Description                                                                                                                                                        | Example                                                                                                                                                            |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `Page`                                                                                                                                                             | *long*                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                 | The page number you want to select                                                                                                                                 |                                                                                                                                                                    |
| `Results`                                                                                                                                                          | *long*                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                 | The number of results to return per page (max 100)                                                                                                                 |                                                                                                                                                                    |
| `ShippoApiVersion`                                                                                                                                                 | *string*                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                 | Optional string used to pick a non-default API version to use. See our <a href="https://docs.goshippo.com/docs/api_concepts/apiversioning/">API version</a> guide. | 2018-02-08                                                                                                                                                         |

### Response

**[ShippoAccountPaginatedList](../../Models/Components/ShippoAccountPaginatedList.md)**

### Errors

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |

## Create

Creates a new <a href="https://docs.goshippo.com/docs/platformaccounts/platform_using_accounts/">Shippo Managed Account</a>.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Requests;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

var res = await sdk.ShippoAccounts.CreateAsync(
    shippoAccountUpdateRequest: new ShippoAccountUpdateRequest() {
        Email = "hippo@shippo.com",
        FirstName = "Shippo",
        LastName = "Meister",
        CompanyName = "Acme",
    },
    shippoApiVersion: "2018-02-08"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                          | Type                                                                                                                                                               | Required                                                                                                                                                           | Description                                                                                                                                                        | Example                                                                                                                                                            |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ShippoAccountUpdateRequest`                                                                                                                                       | [ShippoAccountUpdateRequest](../../Models/Components/ShippoAccountUpdateRequest.md)                                                                                | :heavy_check_mark:                                                                                                                                                 | N/A                                                                                                                                                                |                                                                                                                                                                    |
| `ShippoApiVersion`                                                                                                                                                 | *string*                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                 | Optional string used to pick a non-default API version to use. See our <a href="https://docs.goshippo.com/docs/api_concepts/apiversioning/">API version</a> guide. | 2018-02-08                                                                                                                                                         |

### Response

**[ShippoAccount](../../Models/Components/ShippoAccount.md)**

### Errors

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |

## Get

Returns a Shippo Managed Account using an object ID.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Requests;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

var res = await sdk.ShippoAccounts.GetAsync(
    shippoAccountId: "<id>",
    shippoApiVersion: "2018-02-08"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                          | Type                                                                                                                                                               | Required                                                                                                                                                           | Description                                                                                                                                                        | Example                                                                                                                                                            |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ShippoAccountId`                                                                                                                                                  | *string*                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                 | Object ID of the ShippoAccount                                                                                                                                     |                                                                                                                                                                    |
| `ShippoApiVersion`                                                                                                                                                 | *string*                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                 | Optional string used to pick a non-default API version to use. See our <a href="https://docs.goshippo.com/docs/api_concepts/apiversioning/">API version</a> guide. | 2018-02-08                                                                                                                                                         |

### Response

**[ShippoAccount](../../Models/Components/ShippoAccount.md)**

### Errors

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |

## Update

Updates a Shippo Managed Account using an object ID.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Requests;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

var res = await sdk.ShippoAccounts.UpdateAsync(
    shippoAccountId: "<id>",
    shippoApiVersion: "2018-02-08",
    shippoAccountUpdateRequest: new ShippoAccountUpdateRequest() {
        Email = "hippo@shippo.com",
        FirstName = "Shippo",
        LastName = "Meister",
        CompanyName = "Acme",
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                          | Type                                                                                                                                                               | Required                                                                                                                                                           | Description                                                                                                                                                        | Example                                                                                                                                                            |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ShippoAccountId`                                                                                                                                                  | *string*                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                 | Object ID of the ShippoAccount                                                                                                                                     |                                                                                                                                                                    |
| `ShippoApiVersion`                                                                                                                                                 | *string*                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                 | Optional string used to pick a non-default API version to use. See our <a href="https://docs.goshippo.com/docs/api_concepts/apiversioning/">API version</a> guide. | 2018-02-08                                                                                                                                                         |
| `ShippoAccountUpdateRequest`                                                                                                                                       | [ShippoAccountUpdateRequest](../../Models/Components/ShippoAccountUpdateRequest.md)                                                                                | :heavy_minus_sign:                                                                                                                                                 | N/A                                                                                                                                                                |                                                                                                                                                                    |

### Response

**[ShippoAccount](../../Models/Components/ShippoAccount.md)**

### Errors

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |