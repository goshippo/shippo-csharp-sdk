# CustomsItems
(*CustomsItems*)

## Overview

Customs declarations are relevant information, including one or multiple customs items, you need to provide for customs clearance for your international shipments.
<SchemaDefinition schemaRef="#/components/schemas/CustomsItem"/>

### Available Operations

* [List](#list) - List all customs items
* [Create](#create) - Create a new customs item
* [Get](#get) - Retrieve a customs item

## List

Returns a list all customs items objects.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Components;
using Shippo.Models.Requests;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08");

var res = await sdk.CustomsItems.ListAsync(
    page: 1,
    results: 25,
    shippoApiVersion: "2018-02-08");

// handle response
```

### Parameters

| Parameter                                            | Type                                                 | Required                                             | Description                                          | Example                                              |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| `Page`                                               | *long*                                               | :heavy_minus_sign:                                   | The page number you want to select                   |                                                      |
| `Results`                                            | *long*                                               | :heavy_minus_sign:                                   | The number of results to return per page (max 100)   |                                                      |
| `ShippoApiVersion`                                   | *string*                                             | :heavy_minus_sign:                                   | String used to pick a non-default API version to use | 2018-02-08                                           |


### Response

**[CustomsItemPaginatedList](../../Models/Components/CustomsItemPaginatedList.md)**
### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |

## Create

Creates a new customs item object.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Components;
using Shippo.Models.Requests;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08");

var res = await sdk.CustomsItems.CreateAsync(
    customsItemCreateRequest: new CustomsItemCreateRequest() {
    Description = "T-Shirt",
    MassUnit = Shippo.Models.Components.WeightUnitEnum.Lb,
    Metadata = "Order ID \"123454\"",
    NetWeight = "5",
    OriginCountry = "<value>",
    Quantity = 20,
    SkuCode = "HM-123",
    HsCode = "0901.21",
    ValueAmount = "200",
    ValueCurrency = "USD",
},
    shippoApiVersion: "2018-02-08");

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     | Example                                                                         |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `CustomsItemCreateRequest`                                                      | [CustomsItemCreateRequest](../../Models/Components/CustomsItemCreateRequest.md) | :heavy_check_mark:                                                              | CustomsItem details.                                                            |                                                                                 |
| `ShippoApiVersion`                                                              | *string*                                                                        | :heavy_minus_sign:                                                              | String used to pick a non-default API version to use                            | 2018-02-08                                                                      |


### Response

**[CustomsItem](../../Models/Components/CustomsItem.md)**
### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |

## Get

Returns an existing customs item using an object ID

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Components;
using Shippo.Models.Requests;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08");

var res = await sdk.CustomsItems.GetAsync(
    customsItemId: "<value>",
    page: 1,
    shippoApiVersion: "2018-02-08");

// handle response
```

### Parameters

| Parameter                                            | Type                                                 | Required                                             | Description                                          | Example                                              |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| `CustomsItemId`                                      | *string*                                             | :heavy_check_mark:                                   | Object ID of the customs item                        |                                                      |
| `Page`                                               | *long*                                               | :heavy_minus_sign:                                   | The page number you want to select                   |                                                      |
| `ShippoApiVersion`                                   | *string*                                             | :heavy_minus_sign:                                   | String used to pick a non-default API version to use | 2018-02-08                                           |


### Response

**[CustomsItem](../../Models/Components/CustomsItem.md)**
### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |
