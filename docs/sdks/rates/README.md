# Rates
(*Rates*)

## Overview

A rate is the cost to ship a parcel from a carrier. The rate object details the service level including the cost and transit time. 
<SchemaDefinition schemaRef="#/components/schemas/Rate"/>

### Available Operations

* [Get](#get) - Retrieve a rate
* [ListShipmentRates](#listshipmentrates) - Retrieve shipment rates
* [ListShipmentRatesByCurrencyCode](#listshipmentratesbycurrencycode) - Retrieve shipment rates in currency

## Get

Returns an existing rate using a rate object ID.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Requests;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

var res = await sdk.Rates.GetAsync(
    rateId: "<value>",
    shippoApiVersion: "2018-02-08"
);

// handle response
```

### Parameters

| Parameter                                            | Type                                                 | Required                                             | Description                                          | Example                                              |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| `RateId`                                             | *string*                                             | :heavy_check_mark:                                   | Object ID of the rate                                |                                                      |
| `ShippoApiVersion`                                   | *string*                                             | :heavy_minus_sign:                                   | String used to pick a non-default API version to use | 2018-02-08                                           |

### Response

**[Rate](../../Models/Components/Rate.md)**

### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |


## ListShipmentRates

Returns a paginated list of rates associated with a shipment

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Requests;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

ListShipmentRatesRequest req = new ListShipmentRatesRequest() {
    ShipmentId = "<value>",
};

var res = await sdk.Rates.ListShipmentRatesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListShipmentRatesRequest](../../Models/Requests/ListShipmentRatesRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[RatePaginatedList](../../Models/Components/RatePaginatedList.md)**

### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |


## ListShipmentRatesByCurrencyCode

Returns all available shipping rates for a shipment object.

When you create a new valid shipment object, Shippo automatically calculates all available rates. Depending on your shipment data, there may be none, one or multiple rates.

By default, the calculated rates will return the price in two currencies under the `amount` and `amount_local` keys, respectively. The `amount` key will contain the price of a rate expressed in the currency that is used in the country from where the parcel originates, and the `amount_local` key will contain the price expressed in the currency that is used in the country the parcel is shipped to. You can request rates with prices expressed in a different currency by adding the currency code to the end of the resource URL. The full list of supported currencies along with their codes can be viewed on <a href="http://openexchangerates.org/api/currencies.json">open exchange rates</a>.

Note: re-requesting the rates with a different currency code will re-queue the shipment (i.e. set the Shipment's `status` to `QUEUED`) and the converted currency rates will only be available when the Shipment's `status` is set to `SUCCESS`.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Requests;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

ListShipmentRatesByCurrencyCodeRequest req = new ListShipmentRatesByCurrencyCodeRequest() {
    ShipmentId = "<value>",
    CurrencyCode = "USD",
};

var res = await sdk.Rates.ListShipmentRatesByCurrencyCodeAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [ListShipmentRatesByCurrencyCodeRequest](../../Models/Requests/ListShipmentRatesByCurrencyCodeRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |

### Response

**[RatePaginatedList](../../Models/Components/RatePaginatedList.md)**

### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |
