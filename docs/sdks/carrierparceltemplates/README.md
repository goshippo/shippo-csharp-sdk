# CarrierParcelTemplates
(*CarrierParcelTemplates*)

## Overview

A carrier parcel template represents a package used for shipping that has preset dimensions defined by a carrier. Some examples of a carrier parcel template include USPS Flat Rate Box and Fedex Small Pak. When using a carrier parcel template, the rates returned may be limited to the carrier that provides the box. You can create user parcel templates using a carrier parcel template. Shippo takes the dimensions of the carrier parcel template but you must configure the weight.

<SchemaDefinition schemaRef="#/components/schemas/CarrierParcelTemplate"/>

### Available Operations

* [List](#list) - List all carrier parcel templates
* [Get](#get) - Retrieve a carrier parcel templates

## List

List all carrier parcel template objects. <br> Use the following query string params to filter the results as needed. <br>
<ul>
<li>`include=all` (the default). Includes templates from all carriers </li>
<li>`include=user`. Includes templates only from carriers which the user has added (whether or not they're currently enabled) </li>
<li>`include=enabled`. includes templates only for carriers which the user has added and enabled </li>
<li>`carrier=*token*`. filter by specific carrier, e.g. fedex, usps </li>
</ul>

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Requests;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

var res = await sdk.CarrierParcelTemplates.ListAsync(
    include: Shippo.Models.Requests.Include.Enabled,
    carrier: "fedex",
    shippoApiVersion: "2018-02-08"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                          | Type                                                                                                                                                               | Required                                                                                                                                                           | Description                                                                                                                                                        | Example                                                                                                                                                            |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `Include`                                                                                                                                                          | [Include](../../Models/Requests/Include.md)                                                                                                                        | :heavy_minus_sign:                                                                                                                                                 | filter by user or enabled                                                                                                                                          |                                                                                                                                                                    |
| `Carrier`                                                                                                                                                          | *string*                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                 | filter by specific carrier                                                                                                                                         | fedex                                                                                                                                                              |
| `ShippoApiVersion`                                                                                                                                                 | *string*                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                 | Optional string used to pick a non-default API version to use. See our <a href="https://docs.goshippo.com/docs/api_concepts/apiversioning/">API version</a> guide. | 2018-02-08                                                                                                                                                         |

### Response

**[CarrierParcelTemplateList](../../Models/Components/CarrierParcelTemplateList.md)**

### Errors

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |

## Get

Fetches the parcel template information for a specific carrier parcel template, identified by the token.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Requests;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

var res = await sdk.CarrierParcelTemplates.GetAsync(
    carrierParcelTemplateToken: "<value>",
    shippoApiVersion: "2018-02-08"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                          | Type                                                                                                                                                               | Required                                                                                                                                                           | Description                                                                                                                                                        | Example                                                                                                                                                            |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CarrierParcelTemplateToken`                                                                                                                                       | *string*                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                 | The unique string representation of the carrier parcel template                                                                                                    |                                                                                                                                                                    |
| `ShippoApiVersion`                                                                                                                                                 | *string*                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                 | Optional string used to pick a non-default API version to use. See our <a href="https://docs.goshippo.com/docs/api_concepts/apiversioning/">API version</a> guide. | 2018-02-08                                                                                                                                                         |

### Response

**[CarrierParcelTemplate](../../Models/Components/CarrierParcelTemplate.md)**

### Errors

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |