# RatesAtCheckout
(*RatesAtCheckout*)

## Overview

Rates at checkout is a tool for merchants to display up-to-date shipping estimates based on what's in their customers cart and where they’re shipping to.
Merchants set up curated shipping options for customers in the checkout flow based on data in the shopping cart. The request must include the **to** address and item information. Optional fields are the **from** address and package information. If the optional fields are not included, the service will use the default address and/or package configured for rates at checkout. The response is a list of shipping options based on the Service Group configuration.
(see <a href="#tag/Service-Groups">Service Group configuration</a> for details).
<SchemaDefinition schemaRef="#/components/schemas/LiveRate"/>


# Default Parcel Template
Assign one of your user parcel templates to be the default used when generating Live Rates. This template will be used by default when generating Live Rates, unless you explicitly provide a parcel in the Live Rates request.
<SchemaDefinition schemaRef="#/components/schemas/UserParcelTemplate"/>

### Available Operations

* [Create](#create) - Generate a live rates request
* [GetDefaultParcelTemplate](#getdefaultparceltemplate) - Show current default parcel template
* [UpdateDefaultParcelTemplate](#updatedefaultparceltemplate) - Update default parcel template
* [DeleteDefaultParcelTemplate](#deletedefaultparceltemplate) - Clear current default parcel template

## Create

Initiates a live rates request. Include either the object ID for
an existing address record or a fully formed address object when entering
an address value. You can also enter the object ID of an existing user parcel
template or a fully formed user parcel template object as the parcel value.

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

var res = await sdk.RatesAtCheckout.CreateAsync(
    liveRateCreateRequest: new LiveRateCreateRequest() {
        AddressFrom = LiveRateCreateRequestAddressFrom.CreateStr(
            "<value>"
        ),
        AddressTo = LiveRateCreateRequestAddressTo.CreateAddressCompleteCreateRequest(
            new AddressCompleteCreateRequest() {
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
            }
        ),
        LineItems = new List<LineItem>() {
            new LineItem() {
                Currency = "USD",
                ManufactureCountry = "US",
                MaxDeliveryTime = System.DateTime.Parse("2016-07-23T00:00:00Z"),
                MaxShipTime = System.DateTime.Parse("2016-07-23T00:00:00Z"),
                Quantity = 20,
                Sku = "HM-123",
                Title = "Hippo Magazines",
                TotalPrice = "12.1",
                VariantTitle = "June Edition",
                Weight = "0.4",
                WeightUnit = Shippo.Models.Components.WeightUnitEnum.Lb,
                ObjectId = "abf7d5675d744b6ea9fdb6f796b28f28",
            },
        },
        Parcel = LiveRateCreateRequestParcel.CreateStr(
            "5df144dca289442cv7a06"
        ),
    },
    shippoApiVersion: "2018-02-08"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                          | Type                                                                                                                                                               | Required                                                                                                                                                           | Description                                                                                                                                                        | Example                                                                                                                                                            |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `LiveRateCreateRequest`                                                                                                                                            | [LiveRateCreateRequest](../../Models/Components/LiveRateCreateRequest.md)                                                                                          | :heavy_check_mark:                                                                                                                                                 | Generate rates at checkout                                                                                                                                         |                                                                                                                                                                    |
| `ShippoApiVersion`                                                                                                                                                 | *string*                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                 | Optional string used to pick a non-default API version to use. See our <a href="https://docs.goshippo.com/docs/api_concepts/apiversioning/">API version</a> guide. | 2018-02-08                                                                                                                                                         |

### Response

**[LiveRatePaginatedList](../../Models/Components/LiveRatePaginatedList.md)**

### Errors

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |

## GetDefaultParcelTemplate

Retrieve and display the currently configured default parcel template for live rates.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Requests;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

var res = await sdk.RatesAtCheckout.GetDefaultParcelTemplateAsync(shippoApiVersion: "2018-02-08");

// handle response
```

### Parameters

| Parameter                                                                                                                                                          | Type                                                                                                                                                               | Required                                                                                                                                                           | Description                                                                                                                                                        | Example                                                                                                                                                            |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ShippoApiVersion`                                                                                                                                                 | *string*                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                 | Optional string used to pick a non-default API version to use. See our <a href="https://docs.goshippo.com/docs/api_concepts/apiversioning/">API version</a> guide. | 2018-02-08                                                                                                                                                         |

### Response

**[DefaultParcelTemplate](../../Models/Components/DefaultParcelTemplate.md)**

### Errors

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |

## UpdateDefaultParcelTemplate

Update the currently configured default parcel template for live rates. The object_id in the request payload should identify the user parcel template to be the new default.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Requests;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

var res = await sdk.RatesAtCheckout.UpdateDefaultParcelTemplateAsync(
    shippoApiVersion: "2018-02-08",
    defaultParcelTemplateUpdateRequest: new DefaultParcelTemplateUpdateRequest() {
        ObjectId = "b958d3690bb04bb8b2986724872750f5",
    }
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                          | Type                                                                                                                                                               | Required                                                                                                                                                           | Description                                                                                                                                                        | Example                                                                                                                                                            |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ShippoApiVersion`                                                                                                                                                 | *string*                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                 | Optional string used to pick a non-default API version to use. See our <a href="https://docs.goshippo.com/docs/api_concepts/apiversioning/">API version</a> guide. | 2018-02-08                                                                                                                                                         |
| `DefaultParcelTemplateUpdateRequest`                                                                                                                               | [DefaultParcelTemplateUpdateRequest](../../Models/Components/DefaultParcelTemplateUpdateRequest.md)                                                                | :heavy_minus_sign:                                                                                                                                                 | N/A                                                                                                                                                                |                                                                                                                                                                    |

### Response

**[DefaultParcelTemplate](../../Models/Components/DefaultParcelTemplate.md)**

### Errors

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |

## DeleteDefaultParcelTemplate

Clears the currently configured default parcel template for live rates.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Requests;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

await sdk.RatesAtCheckout.DeleteDefaultParcelTemplateAsync(shippoApiVersion: "2018-02-08");

// handle response
```

### Parameters

| Parameter                                                                                                                                                          | Type                                                                                                                                                               | Required                                                                                                                                                           | Description                                                                                                                                                        | Example                                                                                                                                                            |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `ShippoApiVersion`                                                                                                                                                 | *string*                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                 | Optional string used to pick a non-default API version to use. See our <a href="https://docs.goshippo.com/docs/api_concepts/apiversioning/">API version</a> guide. | 2018-02-08                                                                                                                                                         |

### Errors

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |