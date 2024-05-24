# Batches
(*Batches*)

## Overview

A batch is a technique for creating multiple labels at once. Use the  batch object to create and purchase many shipments in two API calls. After creating the batch, retrieve the batch to verify that all shipments are valid. You can add and remove shipments after you have created the batch. When all shipments are valid you can purchase the batch and retrieve all the shipping labels.
<SchemaDefinition schemaRef="#/components/schemas/Batch"/>

# Batch Shipment
The batch shipment object is a wrapper around a shipment object, which include shipment-specific information 
for batch processing.

Note: batch shipments can only be created on the batch endpoint, either when creating a batch object or by through 
the `/batches/{BATCH_OBJECT_ID}/add_shipments` endpoint
<SchemaDefinition schemaRef="#/components/schemas/BatchShipment"/>

### Available Operations

* [Create](#create) - Create a batch
* [Get](#get) - Retrieve a batch
* [AddShipments](#addshipments) - Add shipments to a batch
* [Purchase](#purchase) - Purchase a batch
* [RemoveShipments](#removeshipments) - Remove shipments from a batch

## Create

Creates a new batch object for purchasing shipping labels for many shipments at once. Batches are created asynchronously. This means that the API response won't include your batch shipments yet. You need to retrieve the batch later to verify that all batch shipments are valid.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Components;
using Shippo.Models.Requests;
using System.Collections.Generic;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08");

var res = await sdk.Batches.CreateAsync(
    batchCreateRequest: new BatchCreateRequest() {
    DefaultCarrierAccount = "078870331023437cb917f5187429b093",
    DefaultServicelevelToken = "usps_priority",
    LabelFiletype = LabelFileTypeEnum.Pdf4x6,
    Metadata = "BATCH #1",
    BatchShipments = new List<BatchShipmentBase>() {
        new BatchShipmentBase() {
            CarrierAccount = "a4391cd4ab974f478f55dc08b5c8e3b3",
            Metadata = "SHIPMENT #1",
            ServicelevelToken = "fedex_ground",
            Shipment = new ShipmentCreateRequest() {
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
                AddressFrom = AddressFrom.CreateAddressFromAddressCreateRequest(
                        new AddressCreateRequest() {
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
                ),
                AddressReturn = AddressReturn.CreateAddressReturnAddressCreateRequest(
                        new AddressCreateRequest() {
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
                ),
                AddressTo = AddressTo.CreateAddressToStr(
                "d799c2679e644279b59fe661ac8fa489",
                ),
                CustomsDeclaration = ShipmentCreateRequestCustomsDeclaration.CreateShipmentCreateRequestCustomsDeclarationStr(
                "adcfdddf8ec64b84ad22772bce3ea37a",
                ),
                CarrierAccounts = new List<string>() {
                    "065a4a8c10d24a34ab932163a1b87f52",
                    "73f706f4bdb94b54a337563840ce52b0",
                },
                Parcels = new List<Models.Components.Parcels>() {
                    Parcels.CreateParcelsParcelCreateRequest(
                        new ParcelCreateRequest() {
                            DistanceUnit = Shippo.Models.Components.DistanceUnitEnum.In,
                            Height = "1",
                            Length = "1",
                            MassUnit = Shippo.Models.Components.WeightUnitEnum.Lb,
                            Weight = "1",
                            Width = "1",
                            Metadata = "Customer ID 123456",
                        },
                    ),
                },
            },
        },
    },
},
    shippoApiVersion: "2018-02-08");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `BatchCreateRequest`                                                | [BatchCreateRequest](../../Models/Components/BatchCreateRequest.md) | :heavy_check_mark:                                                  | Batch details.                                                      |                                                                     |
| `ShippoApiVersion`                                                  | *string*                                                            | :heavy_minus_sign:                                                  | String used to pick a non-default API version to use                | 2018-02-08                                                          |


### Response

**[Batch](../../Models/Components/Batch.md)**
### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |

## Get

Returns a batch using an object ID. <br> Batch shipments are displayed 100 at a time.  You can iterate 
through each `page` using the `?page= query` parameter.  You can also filter based on batch shipment 
status, for example, by passing a query param like `?object_results=creation_failed`. <br> 
For more details on filtering results, see our guide on <a href="https://docs.goshippo.com/docs/api_concepts/filtering/" target="blank"> filtering</a>.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Components;
using Shippo.Models.Requests;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08");

var res = await sdk.Batches.GetAsync(
    batchId: "<value>",
    shippoApiVersion: "2018-02-08");

// handle response
```

### Parameters

| Parameter                                            | Type                                                 | Required                                             | Description                                          | Example                                              |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| `BatchId`                                            | *string*                                             | :heavy_check_mark:                                   | Object ID of the batch                               |                                                      |
| `ShippoApiVersion`                                   | *string*                                             | :heavy_minus_sign:                                   | String used to pick a non-default API version to use | 2018-02-08                                           |


### Response

**[Batch](../../Models/Components/Batch.md)**
### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |

## AddShipments

Adds batch shipments to an existing batch.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Components;
using Shippo.Models.Requests;
using System.Collections.Generic;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08");

var res = await sdk.Batches.AddShipmentsAsync(
    batchId: "<value>",
    requestBody: new List<BatchShipmentBase>() {
    new BatchShipmentBase() {
        CarrierAccount = "a4391cd4ab974f478f55dc08b5c8e3b3",
        Metadata = "SHIPMENT #1",
        ServicelevelToken = "fedex_ground",
        Shipment = new ShipmentCreateRequest() {
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
            AddressFrom = AddressFrom.CreateAddressFromStr(
            "d799c2679e644279b59fe661ac8fa488",
            ),
            AddressReturn = AddressReturn.CreateAddressReturnStr(
            "d799c2679e644279b59fe661ac8fa488",
            ),
            AddressTo = AddressTo.CreateAddressToAddressCreateRequest(
                    new AddressCreateRequest() {
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
            ),
            CustomsDeclaration = ShipmentCreateRequestCustomsDeclaration.CreateShipmentCreateRequestCustomsDeclarationStr(
            "adcfdddf8ec64b84ad22772bce3ea37a",
            ),
            CarrierAccounts = new List<string>() {
                "065a4a8c10d24a34ab932163a1b87f52",
                "73f706f4bdb94b54a337563840ce52b0",
            },
            Parcels = new List<Models.Components.Parcels>() {
                Parcels.CreateParcelsParcelCreateRequest(
                    new ParcelCreateRequest() {
                        DistanceUnit = Shippo.Models.Components.DistanceUnitEnum.In,
                        Height = "1",
                        Length = "1",
                        MassUnit = Shippo.Models.Components.WeightUnitEnum.Lb,
                        Weight = "1",
                        Width = "1",
                        Metadata = "Customer ID 123456",
                    },
                ),
            },
        },
    },
},
    shippoApiVersion: "2018-02-08");

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             | Example                                                                 |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `BatchId`                                                               | *string*                                                                | :heavy_check_mark:                                                      | Object ID of the batch                                                  |                                                                         |
| `RequestBody`                                                           | List<[BatchShipmentBase](../../Models/Components/BatchShipmentBase.md)> | :heavy_check_mark:                                                      | Array of shipments to add to the batch                                  |                                                                         |
| `ShippoApiVersion`                                                      | *string*                                                                | :heavy_minus_sign:                                                      | String used to pick a non-default API version to use                    | 2018-02-08                                                              |


### Response

**[Batch](../../Models/Components/Batch.md)**
### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |

## Purchase

Purchases an existing batch with a status of `VALID`. 
Once you send a POST request to the purchase endpoint the batch status will change to `PURCHASING`. 
When all the shipments are purchased, the status will change to `PURCHASED` and you will receive a 
`batch_purchased` webhook indicating that the batch has been purchased

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Components;
using Shippo.Models.Requests;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08");

var res = await sdk.Batches.PurchaseAsync(
    batchId: "<value>",
    shippoApiVersion: "2018-02-08");

// handle response
```

### Parameters

| Parameter                                            | Type                                                 | Required                                             | Description                                          | Example                                              |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| `BatchId`                                            | *string*                                             | :heavy_check_mark:                                   | Object ID of the batch                               |                                                      |
| `ShippoApiVersion`                                   | *string*                                             | :heavy_minus_sign:                                   | String used to pick a non-default API version to use | 2018-02-08                                           |


### Response

**[Batch](../../Models/Components/Batch.md)**
### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |

## RemoveShipments

Removes shipments from an existing batch shipment.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Components;
using Shippo.Models.Requests;
using System.Collections.Generic;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08");

var res = await sdk.Batches.RemoveShipmentsAsync(
    batchId: "<value>",
    requestBody: new List<string>() {
    "<value>",
},
    shippoApiVersion: "2018-02-08");

// handle response
```

### Parameters

| Parameter                                              | Type                                                   | Required                                               | Description                                            | Example                                                |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| `BatchId`                                              | *string*                                               | :heavy_check_mark:                                     | Object ID of the batch                                 |                                                        |
| `RequestBody`                                          | List<*string*>                                         | :heavy_check_mark:                                     | Array of shipments object ids to remove from the batch |                                                        |
| `ShippoApiVersion`                                     | *string*                                               | :heavy_minus_sign:                                     | String used to pick a non-default API version to use   | 2018-02-08                                             |


### Response

**[Batch](../../Models/Components/Batch.md)**
### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |
