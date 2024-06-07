# Shippo

<div align="left">
    <a href="https://speakeasyapi.dev/"><img src="https://custom-icon-badges.demolab.com/badge/-Built%20By%20Speakeasy-212015?style=for-the-badge&logoColor=FBE331&logo=speakeasy&labelColor=545454" /></a>
    <a href="https://opensource.org/licenses/MIT">
        <img src="https://img.shields.io/badge/License-MIT-blue.svg" style="width: 100px; height: 28px;" />
    </a>
</div>

<!-- Start SDK Installation [installation] -->
## SDK Installation

### Nuget

```bash
dotnet add package Shippo
```
<!-- End SDK Installation [installation] -->

<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using Shippo;
using Shippo.Models.Components;
using Shippo.Models.Requests;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08");

var res = await sdk.Addresses.ListAsync(
    page: 1,
    results: 5,
    shippoApiVersion: "2018-02-08");

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

### [Addresses](docs/sdks/addresses/README.md)

* [List](docs/sdks/addresses/README.md#list) - List all addresses
* [Create](docs/sdks/addresses/README.md#create) - Create a new address
* [Get](docs/sdks/addresses/README.md#get) - Retrieve an address
* [Validate](docs/sdks/addresses/README.md#validate) - Validate an address

### [Batches](docs/sdks/batches/README.md)

* [Create](docs/sdks/batches/README.md#create) - Create a batch
* [Get](docs/sdks/batches/README.md#get) - Retrieve a batch
* [AddShipments](docs/sdks/batches/README.md#addshipments) - Add shipments to a batch
* [Purchase](docs/sdks/batches/README.md#purchase) - Purchase a batch
* [RemoveShipments](docs/sdks/batches/README.md#removeshipments) - Remove shipments from a batch

### [CarrierAccounts](docs/sdks/carrieraccounts/README.md)

* [List](docs/sdks/carrieraccounts/README.md#list) - List all carrier accounts
* [Create](docs/sdks/carrieraccounts/README.md#create) - Create a new carrier account
* [Get](docs/sdks/carrieraccounts/README.md#get) - Retrieve a carrier account
* [Update](docs/sdks/carrieraccounts/README.md#update) - Update a carrier account
* [InitiateOauth2Signin](docs/sdks/carrieraccounts/README.md#initiateoauth2signin) - Connect an existing carrier account using OAuth 2.0
* [Register](docs/sdks/carrieraccounts/README.md#register) - Add a Shippo carrier account
* [GetRegistrationStatus](docs/sdks/carrieraccounts/README.md#getregistrationstatus) - Get Carrier Registration status

### [CustomsDeclarations](docs/sdks/customsdeclarations/README.md)

* [List](docs/sdks/customsdeclarations/README.md#list) - List all customs declarations
* [Create](docs/sdks/customsdeclarations/README.md#create) - Create a new customs declaration
* [Get](docs/sdks/customsdeclarations/README.md#get) - Retrieve a customs declaration

### [CustomsItems](docs/sdks/customsitems/README.md)

* [List](docs/sdks/customsitems/README.md#list) - List all customs items
* [Create](docs/sdks/customsitems/README.md#create) - Create a new customs item
* [Get](docs/sdks/customsitems/README.md#get) - Retrieve a customs item

### [RatesAtCheckout](docs/sdks/ratesatcheckout/README.md)

* [Create](docs/sdks/ratesatcheckout/README.md#create) - Generate a live rates request
* [GetDefaultParcelTemplate](docs/sdks/ratesatcheckout/README.md#getdefaultparceltemplate) - Show current default parcel template
* [UpdateDefaultParcelTemplate](docs/sdks/ratesatcheckout/README.md#updatedefaultparceltemplate) - Update default parcel template
* [DeleteDefaultParcelTemplate](docs/sdks/ratesatcheckout/README.md#deletedefaultparceltemplate) - Clear current default parcel template

### [Manifests](docs/sdks/manifests/README.md)

* [List](docs/sdks/manifests/README.md#list) - List all manifests
* [Create](docs/sdks/manifests/README.md#create) - Create a new manifest
* [Get](docs/sdks/manifests/README.md#get) - Retrieve a manifest

### [Orders](docs/sdks/orders/README.md)

* [List](docs/sdks/orders/README.md#list) - List all orders
* [Create](docs/sdks/orders/README.md#create) - Create a new order
* [Get](docs/sdks/orders/README.md#get) - Retrieve an order

### [CarrierParcelTemplates](docs/sdks/carrierparceltemplates/README.md)

* [List](docs/sdks/carrierparceltemplates/README.md#list) - List all carrier parcel templates
* [Get](docs/sdks/carrierparceltemplates/README.md#get) - Retrieve a carrier parcel templates

### [Parcels](docs/sdks/parcels/README.md)

* [List](docs/sdks/parcels/README.md#list) - List all parcels
* [Create](docs/sdks/parcels/README.md#create) - Create a new parcel
* [Get](docs/sdks/parcels/README.md#get) - Retrieve an existing parcel

### [Pickups](docs/sdks/pickups/README.md)

* [Create](docs/sdks/pickups/README.md#create) - Create a pickup

### [Rates](docs/sdks/rates/README.md)

* [Get](docs/sdks/rates/README.md#get) - Retrieve a rate
* [ListShipmentRates](docs/sdks/rates/README.md#listshipmentrates) - Retrieve shipment rates
* [ListShipmentRatesByCurrencyCode](docs/sdks/rates/README.md#listshipmentratesbycurrencycode) - Retrieve shipment rates in currency

### [Refunds](docs/sdks/refunds/README.md)

* [Create](docs/sdks/refunds/README.md#create) - Create a refund
* [List](docs/sdks/refunds/README.md#list) - List all refunds
* [Get](docs/sdks/refunds/README.md#get) - Retrieve a refund

### [ServiceGroups](docs/sdks/servicegroups/README.md)

* [List](docs/sdks/servicegroups/README.md#list) - List all service groups
* [Create](docs/sdks/servicegroups/README.md#create) - Create a new service group
* [Update](docs/sdks/servicegroups/README.md#update) - Update an existing service group
* [Delete](docs/sdks/servicegroups/README.md#delete) - Delete a service group

### [Shipments](docs/sdks/shipments/README.md)

* [List](docs/sdks/shipments/README.md#list) - List all shipments
* [Create](docs/sdks/shipments/README.md#create) - Create a new shipment
* [Get](docs/sdks/shipments/README.md#get) - Retrieve a shipment

### [TrackingStatus](docs/sdks/trackingstatus/README.md)

* [Create](docs/sdks/trackingstatus/README.md#create) - Register a tracking webhook
* [Get](docs/sdks/trackingstatus/README.md#get) - Get a tracking status

### [Transactions](docs/sdks/transactions/README.md)

* [List](docs/sdks/transactions/README.md#list) - List all shipping labels
* [Create](docs/sdks/transactions/README.md#create) - Create a shipping label
* [Get](docs/sdks/transactions/README.md#get) - Retrieve a shipping label

### [UserParcelTemplates](docs/sdks/userparceltemplates/README.md)

* [List](docs/sdks/userparceltemplates/README.md#list) - List all user parcel templates
* [Create](docs/sdks/userparceltemplates/README.md#create) - Create a new user parcel template
* [Delete](docs/sdks/userparceltemplates/README.md#delete) - Delete a user parcel template
* [Get](docs/sdks/userparceltemplates/README.md#get) - Retrieves a user parcel template
* [Update](docs/sdks/userparceltemplates/README.md#update) - Update an existing user parcel template

### [ShippoAccounts](docs/sdks/shippoaccounts/README.md)

* [List](docs/sdks/shippoaccounts/README.md#list) - List all Shippo Accounts
* [Create](docs/sdks/shippoaccounts/README.md#create) - Create a Shippo Account
* [Get](docs/sdks/shippoaccounts/README.md#get) - Retrieve a Shippo Account
* [Update](docs/sdks/shippoaccounts/README.md#update) - Update a Shippo Account
<!-- End Available Resources and Operations [operations] -->

<!-- Start Global Parameters [global-parameters] -->
## Global Parameters

## Global Parameters

A parameter is configured globally. This parameter may be set on the SDK client instance itself during initialization. When configured as an option during SDK initialization, This global value will be used as the default on the operations that use it. When such operations are called, there is a place in each to override the global value, if needed.

For example, you can set `SHIPPO-API-VERSION` to `"2018-02-08"` at SDK initialization and then you do not have to pass the same value on calls to operations like `List`. But if you want to do so you may, which will locally override the global setting. See the example code below for a demonstration.


### Available Globals

The following global parameter is available.

| Name | Type | Required | Description |
| ---- | ---- |:--------:| ----------- |
| shippoApiVersion | string |  | String used to pick a non-default API version to use |


### Example

```csharp
using Shippo;
using Shippo.Models.Components;
using Shippo.Models.Requests;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08");

var res = await sdk.Addresses.ListAsync(
    page: 1,
    results: 5,
    shippoApiVersion: "2018-02-08");

// handle response
```
<!-- End Global Parameters [global-parameters] -->

<!-- Start Error Handling [errors] -->
## Error Handling

Handling errors in this SDK should largely match your expectations.  All operations return a response object or thow an exception.  If Error objects are specified in your OpenAPI Spec, the SDK will raise the appropriate type.

| Error Object                                                                 | Status Code                                                                  | Content Type                                                                 |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| Shippo.Models.Errors.InitiateOauth2SigninResponseBody                        | 400                                                                          | application/json                                                             |
| Shippo.Models.Errors.InitiateOauth2SigninCarrierAccountsResponseBody         | 401                                                                          | application/json                                                             |
| Shippo.Models.Errors.InitiateOauth2SigninCarrierAccountsResponseResponseBody | 404                                                                          | application/json                                                             |
| Shippo.Models.Errors.SDKException                                            | 4xx-5xx                                                                      | */*                                                                          |

### Example

```csharp
using Shippo;
using Shippo.Models.Components;
using System;
using Shippo.Models.Errors;
using Shippo.Models.Requests;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08");

InitiateOauth2SigninRequest req = new InitiateOauth2SigninRequest() {
    CarrierAccountObjectId = "<value>",
    RedirectUri = "http://fine-cummerbund.biz",
};

try
{
    var res = await sdk.CarrierAccounts.InitiateOauth2SigninAsync(req);
    // handle response
}
catch (Exception ex)
{
    if (ex is InitiateOauth2SigninResponseBody)
    {
        // handle exception
    }
    else if (ex is InitiateOauth2SigninCarrierAccountsResponseBody)
    {
        // handle exception
    }
    else if (ex is InitiateOauth2SigninCarrierAccountsResponseResponseBody)
    {
        // handle exception
    }
    else if (ex is Shippo.Models.Errors.SDKException)
    {
        // handle exception
    }
}

```
<!-- End Error Handling [errors] -->

<!-- Start Server Selection [server] -->
## Server Selection

### Select Server by Index

You can override the default server globally by passing a server index to the `serverIndex: number` optional parameter when initializing the SDK client instance. The selected server will then be used as the default on the operations that use it. This table lists the indexes associated with the available servers:

| # | Server | Variables |
| - | ------ | --------- |
| 0 | `https://api.goshippo.com` | None |




### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverUrl: str` optional parameter when initializing the SDK client instance. For example:
<!-- End Server Selection [server] -->

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name           | Type           | Scheme         |
| -------------- | -------------- | -------------- |
| `APIKeyHeader` | apiKey         | API key        |

To authenticate with the API the `APIKeyHeader` parameter must be set when initializing the SDK client instance. For example:
```csharp
using Shippo;
using Shippo.Models.Components;
using Shippo.Models.Requests;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08");

var res = await sdk.Addresses.ListAsync(
    page: 1,
    results: 5,
    shippoApiVersion: "2018-02-08");

// handle response
```
<!-- End Authentication [security] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->

# Development

## Contributions

While we value open-source contributions to this SDK, this library is generated programmatically.
Feel free to open a PR or a Github issue as a proof of concept and we'll do our best to include it in a future release!

### SDK Created by [Speakeasy](https://docs.speakeasyapi.dev/docs/using-speakeasy/client-sdks)
