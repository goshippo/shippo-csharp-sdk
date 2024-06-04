# Addresses
(*Addresses*)

## Overview

Addresses are the locations a parcel is being shipped **from** and **to**. They represent company and residential places. Among other things, you can use address objects to create shipments, calculate shipping rates, and purchase shipping labels.
<SchemaDefinition schemaRef="#/components/schemas/Address"/>

### Available Operations

* [List](#list) - List all addresses
* [Create](#create) - Create a new address
* [Get](#get) - Retrieve an address
* [Validate](#validate) - Validate an address

## List

Returns a list of all address objects that have been created in this account.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Components;
using Shippo.Models.Requests;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08");

var res = await sdk.Addresses.ListAsync(
    page: 1,
    results: 5,
    shippoApiVersion: "2018-02-08");

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   | Example                                                       |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `Page`                                                        | *long*                                                        | :heavy_minus_sign:                                            | The page number you want to select                            |                                                               |
| `Results`                                                     | *long*                                                        | :heavy_minus_sign:                                            | The number of results to return per page (max 100, default 5) |                                                               |
| `ShippoApiVersion`                                            | *string*                                                      | :heavy_minus_sign:                                            | String used to pick a non-default API version to use          | 2018-02-08                                                    |


### Response

**[AddressPaginatedList](../../Models/Components/AddressPaginatedList.md)**
### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |

## Create

Creates a new address object. You can use address objects to create new shipments, calculate rates, and to create orders.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Components;
using Shippo.Models.Requests;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08");

var res = await sdk.Addresses.CreateAsync(
    addressCreateRequest: new AddressCreateRequest() {
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
},
    shippoApiVersion: "2018-02-08");

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             | Example                                                                 |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `AddressCreateRequest`                                                  | [AddressCreateRequest](../../Models/Components/AddressCreateRequest.md) | :heavy_check_mark:                                                      | Address details.                                                        |                                                                         |
| `ShippoApiVersion`                                                      | *string*                                                                | :heavy_minus_sign:                                                      | String used to pick a non-default API version to use                    | 2018-02-08                                                              |


### Response

**[Address](../../Models/Components/Address.md)**
### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |

## Get

Returns an existing address using an object ID.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Components;
using Shippo.Models.Requests;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08");

var res = await sdk.Addresses.GetAsync(
    addressId: "<value>",
    shippoApiVersion: "2018-02-08");

// handle response
```

### Parameters

| Parameter                                            | Type                                                 | Required                                             | Description                                          | Example                                              |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| `AddressId`                                          | *string*                                             | :heavy_check_mark:                                   | Object ID of the address                             |                                                      |
| `ShippoApiVersion`                                   | *string*                                             | :heavy_minus_sign:                                   | String used to pick a non-default API version to use | 2018-02-08                                           |


### Response

**[Address](../../Models/Components/Address.md)**
### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |

## Validate

Validates an existing address using an object ID

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Components;
using Shippo.Models.Requests;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08");

var res = await sdk.Addresses.ValidateAsync(
    addressId: "<value>",
    shippoApiVersion: "2018-02-08");

// handle response
```

### Parameters

| Parameter                                            | Type                                                 | Required                                             | Description                                          | Example                                              |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| `AddressId`                                          | *string*                                             | :heavy_check_mark:                                   | Object ID of the address                             |                                                      |
| `ShippoApiVersion`                                   | *string*                                             | :heavy_minus_sign:                                   | String used to pick a non-default API version to use | 2018-02-08                                           |


### Response

**[Address](../../Models/Components/Address.md)**
### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |
