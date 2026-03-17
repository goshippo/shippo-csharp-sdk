# Addresses

## Overview

Addresses are the locations a parcel is being shipped **from** and **to**. They represent company and residential places. Among other things, you can use address objects to create shipments, calculate shipping rates, and purchase shipping labels.

### Available Operations

* [List](#list) - List all addresses
* [Create](#create) - Create a new address
* [Get](#get) - Retrieve an address
* [Validate](#validate) - Validate an address

## List

Returns a list of all address objects that have been created in this account.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ListAddresses" method="get" path="/addresses" -->
```csharp
using Shippo;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    shippoApiVersion: "2018-02-08",
    apiKeyHeader: "<YOUR_API_KEY_HERE>"
);

var res = await sdk.Addresses.ListAsync(
    page: 1,
    results: 5
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                          | Type                                                                                                                                                               | Required                                                                                                                                                           | Description                                                                                                                                                        | Example                                                                                                                                                            |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `Page`                                                                                                                                                             | *long*                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                 | The page number you want to select                                                                                                                                 |                                                                                                                                                                    |
| `Results`                                                                                                                                                          | *long*                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                 | The number of results to return per page (max 100, default 5)                                                                                                      |                                                                                                                                                                    |
| `ShippoApiVersion`                                                                                                                                                 | *string*                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                 | Optional string used to pick a non-default API version to use. See our <a href="https://docs.goshippo.com/docs/api_concepts/apiversioning/">API version</a> guide. | 2018-02-08                                                                                                                                                         |

### Response

**[AddressPaginatedList](../../Models/Components/AddressPaginatedList.md)**

### Errors

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |

## Create

Creates a new address object. You can use address objects to create new shipments, calculate rates, and to create orders.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="CreateAddress" method="post" path="/addresses" -->
```csharp
using Shippo;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    shippoApiVersion: "2018-02-08",
    apiKeyHeader: "<YOUR_API_KEY_HERE>"
);

var res = await sdk.Addresses.CreateAsync(addressCreateRequest: new AddressCreateRequest() {
    Name = "Shwan Ippotle",
    Company = "Shippo",
    Street1 = "215 Clayton St.",
    Street3 = "",
    StreetNo = "",
    City = "San Francisco",
    State = "CA",
    Zip = "94117",
    Country = "US",
    Phone = "+1 555 341 9393",
    Email = "shippotle@shippo.com",
    IsResidential = true,
    Metadata = "Customer ID 123456",
    Validate = true,
});

// handle response
```

### Parameters

| Parameter                                                                                                                                                          | Type                                                                                                                                                               | Required                                                                                                                                                           | Description                                                                                                                                                        | Example                                                                                                                                                            |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AddressCreateRequest`                                                                                                                                             | [AddressCreateRequest](../../Models/Components/AddressCreateRequest.md)                                                                                            | :heavy_check_mark:                                                                                                                                                 | Address details.                                                                                                                                                   |                                                                                                                                                                    |
| `ShippoApiVersion`                                                                                                                                                 | *string*                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                 | Optional string used to pick a non-default API version to use. See our <a href="https://docs.goshippo.com/docs/api_concepts/apiversioning/">API version</a> guide. | 2018-02-08                                                                                                                                                         |

### Response

**[Address](../../Models/Components/Address.md)**

### Errors

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |

## Get

Returns an existing address using an object ID.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="GetAddress" method="get" path="/addresses/{AddressId}" -->
```csharp
using Shippo;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    shippoApiVersion: "2018-02-08",
    apiKeyHeader: "<YOUR_API_KEY_HERE>"
);

var res = await sdk.Addresses.GetAsync(addressId: "<id>");

// handle response
```

### Parameters

| Parameter                                                                                                                                                          | Type                                                                                                                                                               | Required                                                                                                                                                           | Description                                                                                                                                                        | Example                                                                                                                                                            |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AddressId`                                                                                                                                                        | *string*                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                 | Object ID of the address                                                                                                                                           |                                                                                                                                                                    |
| `ShippoApiVersion`                                                                                                                                                 | *string*                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                 | Optional string used to pick a non-default API version to use. See our <a href="https://docs.goshippo.com/docs/api_concepts/apiversioning/">API version</a> guide. | 2018-02-08                                                                                                                                                         |

### Response

**[Address](../../Models/Components/Address.md)**

### Errors

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |

## Validate

Validates an existing address using an object ID

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ValidateAddress" method="get" path="/addresses/{AddressId}/validate" -->
```csharp
using Shippo;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    shippoApiVersion: "2018-02-08",
    apiKeyHeader: "<YOUR_API_KEY_HERE>"
);

var res = await sdk.Addresses.ValidateAsync(addressId: "<id>");

// handle response
```

### Parameters

| Parameter                                                                                                                                                          | Type                                                                                                                                                               | Required                                                                                                                                                           | Description                                                                                                                                                        | Example                                                                                                                                                            |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `AddressId`                                                                                                                                                        | *string*                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                 | Object ID of the address                                                                                                                                           |                                                                                                                                                                    |
| `ShippoApiVersion`                                                                                                                                                 | *string*                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                 | Optional string used to pick a non-default API version to use. See our <a href="https://docs.goshippo.com/docs/api_concepts/apiversioning/">API version</a> guide. | 2018-02-08                                                                                                                                                         |

### Response

**[Address](../../Models/Components/Address.md)**

### Errors

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |