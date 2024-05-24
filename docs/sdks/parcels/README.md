# Parcels
(*Parcels*)

## Overview

A parcel is an item you are shipping. The parcel object includes details about its physical make-up of the parcel. It includes dimensions and weight that Shippo uses to calculate rates. 
<SchemaDefinition schemaRef="#/components/schemas/Parcel"/>

# Parcel Extras
The following values are supported for the `extra` field of the parcel object.
<SchemaDefinition schemaRef="#/components/schemas/ParcelExtra"/>

### Available Operations

* [List](#list) - List all parcels
* [Create](#create) - Create a new parcel
* [Get](#get) - Retrieve an existing parcel

## List

Returns a list of all parcel objects.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Components;
using Shippo.Models.Requests;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08");

var res = await sdk.Parcels.ListAsync(
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

**[ParcelPaginatedList](../../Models/Components/ParcelPaginatedList.md)**
### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |

## Create

Creates a new parcel object.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Components;
using Shippo.Models.Requests;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08");

var res = await sdk.Parcels.CreateAsync(
    parcelRequest: new ParcelRequest() {
    DistanceUnit = Shippo.Models.Components.DistanceUnitEnum.In,
    Extra = new ParcelExtra() {
        Cod = new Cod() {
            Amount = "5.5",
            Currency = "USD",
            PaymentMethod = PaymentMethod.Cash,
        },
        Insurance = new ParcelInsurance() {
            Amount = "5.5",
            Content = "Laptop",
            Currency = "USD",
            Provider = ParcelInsuranceProvider.Ups,
        },
    },
    Height = "1",
    Length = "1",
    MassUnit = Shippo.Models.Components.WeightUnitEnum.Lb,
    Weight = "1",
    Width = "1",
},
    shippoApiVersion: "2018-02-08");

// handle response
```

### Parameters

| Parameter                                                 | Type                                                      | Required                                                  | Description                                               | Example                                                   |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `ParcelRequest`                                           | [ParcelRequest](../../Models/Components/ParcelRequest.md) | :heavy_check_mark:                                        | Parcel details.                                           |                                                           |
| `ShippoApiVersion`                                        | *string*                                                  | :heavy_minus_sign:                                        | String used to pick a non-default API version to use      | 2018-02-08                                                |


### Response

**[Parcel](../../Models/Components/Parcel.md)**
### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |

## Get

Returns parcel details using an existing parcel object ID (this will not return parcel details associated with un-purchased shipment/rate parcel object IDs).

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Components;
using Shippo.Models.Requests;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08");

var res = await sdk.Parcels.GetAsync(
    parcelId: "<value>",
    shippoApiVersion: "2018-02-08");

// handle response
```

### Parameters

| Parameter                                            | Type                                                 | Required                                             | Description                                          | Example                                              |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| `ParcelId`                                           | *string*                                             | :heavy_check_mark:                                   | Object ID of the parcel                              |                                                      |
| `ShippoApiVersion`                                   | *string*                                             | :heavy_minus_sign:                                   | String used to pick a non-default API version to use | 2018-02-08                                           |


### Response

**[Parcel](../../Models/Components/Parcel.md)**
### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |
