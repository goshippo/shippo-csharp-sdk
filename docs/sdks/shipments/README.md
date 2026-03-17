# Shipments

## Overview

A shipment is the act of transporting goods. A shipment object contains **to** and **from** addresses, and the parcel details that you are shipping. You can use the shipment object to retrieve shipping rates and purchase a shipping label.

### Available Operations

* [List](#list) - List all shipments
* [Create](#create) - Create a new shipment
* [Get](#get) - Retrieve a shipment

## List

Returns a list of all shipment objects.<br><br>
In order to filter results, you must use the below path parameters. 
A maximum date range of 90 days is permitted. 
Provided dates should be ISO 8601 UTC dates (timezone offsets are currently not supported).<br><br>

Optional path parameters:<br>
  `object_created_gt`- object(s) created greater than a provided date time<br>
  `object_created_gte` - object(s) created greater than or equal to a provided date time<br>
  `object_created_lt` - object(s) created less than a provided date time<br>
  `object_created_lte` - object(s) created less than or equal to a provided date time<br>

  Date format examples:<br>
    `2017-01-01`<br>
    `2017-01-01T03:30:30` or `2017-01-01T03:30:30.5`<br>
    `2017-01-01T03:30:30Z`<br><br>

  Example URL:<br>
    `https://api.goshippo.com/shipments/?object_created_gte=2017-01-01T00:00:30&object_created_lt=2017-04-01T00:00:30`

### Example Usage

<!-- UsageSnippet language="csharp" operationID="ListShipments" method="get" path="/shipments" -->
```csharp
using Shippo;
using Shippo.Models.Components;
using Shippo.Models.Requests;

var sdk = new ShippoSDK(
    shippoApiVersion: "2018-02-08",
    apiKeyHeader: "<YOUR_API_KEY_HERE>"
);

ListShipmentsRequest req = new ListShipmentsRequest() {};

var res = await sdk.Shipments.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [ListShipmentsRequest](../../Models/Requests/ListShipmentsRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[ShipmentPaginatedList](../../Models/Components/ShipmentPaginatedList.md)**

### Errors

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |

## Create

Creates a new shipment object.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="CreateShipment" method="post" path="/shipments" -->
```csharp
using Shippo;
using Shippo.Models.Components;
using System.Collections.Generic;

var sdk = new ShippoSDK(
    shippoApiVersion: "2018-02-08",
    apiKeyHeader: "<YOUR_API_KEY_HERE>"
);

var res = await sdk.Shipments.CreateAsync(shipmentCreateRequest: new ShipmentCreateRequest() {
    Extra = new ShipmentExtra() {
        AccountsReceivableCustomerAccount = new UPSReferenceFields() {
            Prefix = "ABC",
            Value = "value",
            RefSort = 1,
        },
        AppropriationNumber = new UPSReferenceFields() {
            Prefix = "ABC",
            Value = "value",
            RefSort = 1,
        },
        BillOfLadingNumber = new UPSReferenceFields() {
            Prefix = "ABC",
            Value = "value",
            RefSort = 1,
        },
        Cod = new Cod() {
            Amount = "5.5",
            Currency = "USD",
            PaymentMethod = PaymentMethod.Cash,
        },
        CodNumber = new UPSReferenceFields() {
            Prefix = "ABC",
            Value = "value",
            RefSort = 1,
        },
        CustomerReference = new CustomerReference() {
            RefSort = 1,
        },
        DealerOrderNumber = new UPSReferenceFields() {
            Prefix = "ABC",
            Value = "value",
            RefSort = 1,
        },
        DeptNumber = new DepartmentNumber() {
            RefSort = 3,
        },
        FdaProductCode = new UPSReferenceFields() {
            Prefix = "ABC",
            Value = "value",
            RefSort = 1,
        },
        Insurance = new Insurance() {
            Amount = "5.5",
            Currency = "USD",
        },
        InvoiceNumber = new InvoiceNumber() {
            RefSort = 2,
        },
        ManifestNumber = new UPSReferenceFields() {
            Prefix = "ABC",
            Value = "value",
            RefSort = 1,
        },
        ModelNumber = new UPSReferenceFields() {
            Prefix = "ABC",
            Value = "value",
            RefSort = 1,
        },
        PartNumber = new UPSReferenceFields() {
            Prefix = "ABC",
            Value = "value",
            RefSort = 1,
        },
        PoNumber = new PoNumber() {
            RefSort = 2,
        },
        ProductionCode = new UPSReferenceFields() {
            Prefix = "ABC",
            Value = "value",
            RefSort = 1,
        },
        PurchaseRequestNumber = new UPSReferenceFields() {
            Prefix = "ABC",
            Value = "value",
            RefSort = 1,
        },
        RmaNumber = new RmaNumber() {
            RefSort = 1,
        },
        SalespersonNumber = new UPSReferenceFields() {
            Prefix = "ABC",
            Value = "value",
            RefSort = 1,
        },
        SerialNumber = new UPSReferenceFields() {
            Prefix = "ABC",
            Value = "value",
            RefSort = 1,
        },
        StoreNumber = new UPSReferenceFields() {
            Prefix = "ABC",
            Value = "value",
            RefSort = 1,
        },
        TransactionReferenceNumber = new UPSReferenceFields() {
            Prefix = "ABC",
            Value = "value",
            RefSort = 1,
        },
    },
    Metadata = "Customer ID 123456",
    ShipmentDate = "2021-03-22T12:00:00Z",
    AddressFrom = AddressFrom.CreateStr(
        "d799c2679e644279b59fe661ac8fa488"
    ),
    AddressReturn = AddressReturn.CreateStr(
        "d799c2679e644279b59fe661ac8fa488"
    ),
    AddressTo = AddressTo.CreateStr(
        "d799c2679e644279b59fe661ac8fa489"
    ),
    CustomsDeclaration = ShipmentCreateRequestCustomsDeclaration.CreateStr(
        "adcfdddf8ec64b84ad22772bce3ea37a"
    ),
    CarrierAccounts = new List<string>() {
        "065a4a8c10d24a34ab932163a1b87f52",
        "73f706f4bdb94b54a337563840ce52b0",
    },
    Parcels = new List<Shippo.Models.Components.Parcels>() {
        Shippo.Models.Components.Parcels.CreateStr(
            "<value>"
        ),
    },
});

// handle response
```

### Parameters

| Parameter                                                                                                                                                          | Type                                                                                                                                                               | Required                                                                                                                                                           | Description                                                                                                                                                        | Example                                                                                                                                                            |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ShipmentCreateRequest`                                                                                                                                            | [ShipmentCreateRequest](../../Models/Components/ShipmentCreateRequest.md)                                                                                          | :heavy_check_mark:                                                                                                                                                 | Shipment details and contact info.                                                                                                                                 |                                                                                                                                                                    |
| `ShippoApiVersion`                                                                                                                                                 | *string*                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                 | Optional string used to pick a non-default API version to use. See our <a href="https://docs.goshippo.com/docs/api_concepts/apiversioning/">API version</a> guide. | 2018-02-08                                                                                                                                                         |

### Response

**[Shipment](../../Models/Components/Shipment.md)**

### Errors

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |

## Get

Returns an existing shipment using an object ID

### Example Usage

<!-- UsageSnippet language="csharp" operationID="GetShipment" method="get" path="/shipments/{ShipmentId}" -->
```csharp
using Shippo;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    shippoApiVersion: "2018-02-08",
    apiKeyHeader: "<YOUR_API_KEY_HERE>"
);

var res = await sdk.Shipments.GetAsync(shipmentId: "<id>");

// handle response
```

### Parameters

| Parameter                                                                                                                                                          | Type                                                                                                                                                               | Required                                                                                                                                                           | Description                                                                                                                                                        | Example                                                                                                                                                            |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ShipmentId`                                                                                                                                                       | *string*                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                 | Object ID of the shipment to update                                                                                                                                |                                                                                                                                                                    |
| `ShippoApiVersion`                                                                                                                                                 | *string*                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                 | Optional string used to pick a non-default API version to use. See our <a href="https://docs.goshippo.com/docs/api_concepts/apiversioning/">API version</a> guide. | 2018-02-08                                                                                                                                                         |

### Response

**[Shipment](../../Models/Components/Shipment.md)**

### Errors

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |