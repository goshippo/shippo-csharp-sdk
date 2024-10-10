# Pickups
(*Pickups*)

## Overview

A pickup is when you schedule a carrier to collect a package for delivery.
Use Shippo’s pickups endpoint to schedule pickups with USPS and DHL Express for eligible shipments that you have already created.
<SchemaDefinition schemaRef="#/components/schemas/Pickup"/>

### Available Operations

* [Create](#create) - Create a pickup

## Create

Creates a pickup object. This request is for a carrier to come to a specified location to take a package for shipping.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Requests;
using Shippo.Models.Components;
using System.Collections.Generic;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

var res = await sdk.Pickups.CreateAsync(
    pickupBase: new PickupBase() {
        CarrierAccount = "adcfdddf8ec64b84ad22772bce3ea37a",
        Location = new Location() {
            Address = new AddressCompleteCreateRequest() {
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
            BuildingLocationType = Shippo.Models.Components.BuildingLocationType.FrontDoor,
            BuildingType = Shippo.Models.Components.BuildingType.Apartment,
            Instructions = "Behind screen door",
        },
        RequestedEndTime = System.DateTime.Parse("2023-06-18T07:14:55.338Z"),
        RequestedStartTime = System.DateTime.Parse("2023-12-01T17:06:07.804Z"),
        Transactions = new List<string>() {
            "adcfdddf8ec64b84ad22772bce3ea37a",
        },
    },
    shippoApiVersion: "2018-02-08"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                          | Type                                                                                                                                                               | Required                                                                                                                                                           | Description                                                                                                                                                        | Example                                                                                                                                                            |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `PickupBase`                                                                                                                                                       | [PickupBase](../../Models/Components/PickupBase.md)                                                                                                                | :heavy_check_mark:                                                                                                                                                 | Shippo’s pickups endpoint allows you to schedule pickups with USPS and DHL Express for eligible shipments that you have already created.                           |                                                                                                                                                                    |
| `ShippoApiVersion`                                                                                                                                                 | *string*                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                 | Optional string used to pick a non-default API version to use. See our <a href="https://docs.goshippo.com/docs/api_concepts/apiversioning/">API version</a> guide. | 2018-02-08                                                                                                                                                         |

### Response

**[Pickup](../../Models/Components/Pickup.md)**

### Errors

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |