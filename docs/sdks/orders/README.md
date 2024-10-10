# Orders
(*Orders*)

## Overview

An order is a request from a customer to purchase goods from a merchant. 
Use the orders object to load orders from your system to the Shippo dashboard.
You can use the orders object to create, retrieve, list, and manage orders programmatically. 
You can also retrieve shipping rates, purchase labels, and track shipments for each order.
<SchemaDefinition schemaRef="#/components/schemas/Order"/>

# Line Item
<p style="text-align: center; background-color: #F2F3F4;">
  </br>Line Items, and their corresponding abstract Products and Variants, might be exposed as a separate resource 
  in the future. Currently it's a nested object within the order resource.</br></br>
</p>
 A line item is an individual object in an order. For example, if your order contains a t-shirt, shorts, and a jacket, each item is represented by a line item.
<SchemaDefinition schemaRef="#/components/schemas/LineItem"/>

### Available Operations

* [List](#list) - List all orders
* [Create](#create) - Create a new order
* [Get](#get) - Retrieve an order

## List

Returns a list of all order objects.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Requests;
using System.Collections.Generic;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

ListOrdersRequest req = new ListOrdersRequest() {
    OrderStatus = new List<OrderStatusEnum>() {
        Shippo.Models.Components.OrderStatusEnum.Paid,
    },
    ShopApp = Shippo.Models.Components.OrderShopAppEnum.Shippo,
};

var res = await sdk.Orders.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [ListOrdersRequest](../../Models/Requests/ListOrdersRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |

### Response

**[OrderPaginatedList](../../Models/Components/OrderPaginatedList.md)**

### Errors

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |

## Create

Creates a new order object.

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

var res = await sdk.Orders.CreateAsync(
    orderCreateRequest: new OrderCreateRequest() {
        Currency = "USD",
        Notes = "This customer is a VIP",
        OrderNumber = "#1068",
        OrderStatus = Shippo.Models.Components.OrderStatusEnum.Paid,
        PlacedAt = "2016-09-23T01:28:12Z",
        ShippingCost = "12.83",
        ShippingCostCurrency = "USD",
        ShippingMethod = "USPS First Class Package",
        SubtotalPrice = "12.1",
        TotalPrice = "24.93",
        TotalTax = "0.0",
        Weight = "0.4",
        WeightUnit = Shippo.Models.Components.WeightUnitEnum.Lb,
        FromAddress = new AddressCreateRequest() {
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
        ToAddress = new AddressCreateRequest() {
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
        LineItems = new List<LineItemBase>() {
            new LineItemBase() {
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
            },
        },
    },
    shippoApiVersion: "2018-02-08"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                          | Type                                                                                                                                                               | Required                                                                                                                                                           | Description                                                                                                                                                        | Example                                                                                                                                                            |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `OrderCreateRequest`                                                                                                                                               | [OrderCreateRequest](../../Models/Components/OrderCreateRequest.md)                                                                                                | :heavy_check_mark:                                                                                                                                                 | Order details.                                                                                                                                                     |                                                                                                                                                                    |
| `ShippoApiVersion`                                                                                                                                                 | *string*                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                 | Optional string used to pick a non-default API version to use. See our <a href="https://docs.goshippo.com/docs/api_concepts/apiversioning/">API version</a> guide. | 2018-02-08                                                                                                                                                         |

### Response

**[Order](../../Models/Components/Order.md)**

### Errors

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |

## Get

Retrieves an existing order using an object ID.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Requests;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

var res = await sdk.Orders.GetAsync(
    orderId: "<id>",
    shippoApiVersion: "2018-02-08"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                          | Type                                                                                                                                                               | Required                                                                                                                                                           | Description                                                                                                                                                        | Example                                                                                                                                                            |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `OrderId`                                                                                                                                                          | *string*                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                 | Object ID of the order                                                                                                                                             |                                                                                                                                                                    |
| `ShippoApiVersion`                                                                                                                                                 | *string*                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                 | Optional string used to pick a non-default API version to use. See our <a href="https://docs.goshippo.com/docs/api_concepts/apiversioning/">API version</a> guide. | 2018-02-08                                                                                                                                                         |

### Response

**[Order](../../Models/Components/Order.md)**

### Errors

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |