# TrackingStatus
(*TrackingStatus*)

## Overview

<p style="text-align: center; background-color: #F2F3F4;"></br>
If you purchased your shipping label through Shippo, you can also get all the tracking details of your Shipment 
from the <a href="#tag/Transactions">Transaction</a> object.
</br></br></p>
A tracking status of a package is an indication of current location of a package in the supply chain. For example,  sorting, warehousing, or out for delivery. Use the tracking status object to track the location of your shipments.

When using your <a href="https://docs.goshippo.com/docs/guides_general/authentication/">Test</a> token for tracking, you need to use Shippo's 
predefined tokens for testing different tracking statuses. You can find more information in our 
<a href="https://docs.goshippo.com/docs/tracking/tracking/">Tracking tutorial</a> on how to do this, and what the 
payloads look like.      
<SchemaDefinition schemaRef="#/components/schemas/Track"/>

### Available Operations

* [Create](#create) - Register a tracking webhook
* [Get](#get) - Get a tracking status

## Create

Registers a webhook that will send HTTP notifications to you when the status of your tracked package changes. For more details on creating a webhook, see our guides on <a href="https://docs.goshippo.com/docs/tracking/webhooks/">Webhooks</a> and <a href="https://docs.goshippo.com/docs/tracking/tracking/">Tracking</a>.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Requests;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

var res = await sdk.TrackingStatus.CreateAsync(
    tracksRequest: new TracksRequest() {
        Carrier = "usps",
        Metadata = "Order 000123",
        TrackingNumber = "9205590164917312751089",
    },
    shippoApiVersion: "2018-02-08"
);

// handle response
```

### Parameters

| Parameter                                                 | Type                                                      | Required                                                  | Description                                               | Example                                                   |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `TracksRequest`                                           | [TracksRequest](../../Models/Components/TracksRequest.md) | :heavy_check_mark:                                        | N/A                                                       |                                                           |
| `ShippoApiVersion`                                        | *string*                                                  | :heavy_minus_sign:                                        | String used to pick a non-default API version to use      | 2018-02-08                                                |

### Response

**[Track](../../Models/Components/Track.md)**

### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |


## Get

Returns the tracking status of a shipment using a carrier name and a tracking number.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Requests;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

var res = await sdk.TrackingStatus.GetAsync(
    trackingNumber: "<value>",
    carrier: "<value>",
    shippoApiVersion: "2018-02-08"
);

// handle response
```

### Parameters

| Parameter                                            | Type                                                 | Required                                             | Description                                          | Example                                              |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| `TrackingNumber`                                     | *string*                                             | :heavy_check_mark:                                   | Tracking number                                      |                                                      |
| `Carrier`                                            | *string*                                             | :heavy_check_mark:                                   | Name of the carrier                                  |                                                      |
| `ShippoApiVersion`                                   | *string*                                             | :heavy_minus_sign:                                   | String used to pick a non-default API version to use | 2018-02-08                                           |

### Response

**[Track](../../Models/Components/Track.md)**

### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |
