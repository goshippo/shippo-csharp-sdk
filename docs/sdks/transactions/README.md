# Transactions
(*Transactions*)

## Overview

A transaction is the purchase of a shipping label from a shipping provider for a specific service. You can print purchased labels and used them to ship a parcel with a carrier, such as USPS or FedEx.
<SchemaDefinition schemaRef="#/components/schemas/Transaction"/>

### Available Operations

* [List](#list) - List all shipping labels
* [Create](#create) - Create a shipping label
* [Get](#get) - Retrieve a shipping label

## List

Returns a list of all transaction objects.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Components;
using Shippo.Models.Requests;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08");

ListTransactionsRequest req = new ListTransactionsRequest() {
    ObjectStatus = TransactionStatusEnum.Success,
    TrackingStatus = TrackingStatusEnum.Delivered,
};

var res = await sdk.Transactions.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListTransactionsRequest](../../Models/Requests/ListTransactionsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |


### Response

**[TransactionPaginatedList](../../Models/Components/TransactionPaginatedList.md)**
### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |

## Create

Creates a new transaction object and purchases the shipping label using a rate object that has previously been created. <br> OR <br> Creates a new transaction object and purchases the shipping label instantly using shipment details, an existing carrier account, and an existing service level token.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Components;
using Shippo.Models.Requests;
using System.Collections.Generic;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08");

var res = await sdk.Transactions.CreateAsync(
    requestBody: CreateTransactionRequestBody.CreateCreateTransactionRequestBodyTransactionCreateRequest(
    new TransactionCreateRequest() {
        Async = false,
        LabelFileType = LabelFileTypeEnum.Pdf4x6,
        Metadata = "Order ID #12345",
        Rate = "ec9f0d3adc9441449c85d315f0997fd5",
    },
),
    shippoApiVersion: "2018-02-08");

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           | Example                                                                               |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `RequestBody`                                                                         | [CreateTransactionRequestBody](../../Models/Requests/CreateTransactionRequestBody.md) | :heavy_check_mark:                                                                    | Examples.                                                                             |                                                                                       |
| `ShippoApiVersion`                                                                    | *string*                                                                              | :heavy_minus_sign:                                                                    | String used to pick a non-default API version to use                                  | 2018-02-08                                                                            |


### Response

**[Transaction](../../Models/Components/Transaction.md)**
### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |

## Get

Returns an existing transaction using an object ID.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Components;
using Shippo.Models.Requests;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08");

var res = await sdk.Transactions.GetAsync(
    transactionId: "<value>",
    shippoApiVersion: "2018-02-08");

// handle response
```

### Parameters

| Parameter                                            | Type                                                 | Required                                             | Description                                          | Example                                              |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| `TransactionId`                                      | *string*                                             | :heavy_check_mark:                                   | Object ID of the transaction to update               |                                                      |
| `ShippoApiVersion`                                   | *string*                                             | :heavy_minus_sign:                                   | String used to pick a non-default API version to use | 2018-02-08                                           |


### Response

**[Transaction](../../Models/Components/Transaction.md)**
### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |
