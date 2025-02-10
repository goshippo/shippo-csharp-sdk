# <img src="https://docs.goshippo.com/images/Logo.png" width="30" alt="Shippo logo"> Shippo C# SDK

Shippo is a shipping API that connects you with [multiple shipping carriers](https://goshippo.com/carriers) (such as USPS, UPS, DHL, Canada Post, Australia Post, and many others) through one interface.

You must register for a [Shippo account](https://apps.goshippo.com/join) to use our API. It's free to sign up. Only pay to print a live label, test labels are free.

To use the API, you must generate an [API Token](https://docs.goshippo.com/docs/guides_general/authentication/). In the following examples, replace `<YOUR_API_KEY_HERE>` with your own token.

For example.

```
apiKeyHeader:"shippo_test_595d9cb0c0e14497bf07e75ecfec6c6d"
```


<!-- Start Summary [summary] -->
## Summary

Shippo external API.: Use this API to integrate with the Shippo service
<!-- End Summary [summary] -->

<!-- Start Table of Contents [toc] -->
## Table of Contents
<!-- $toc-max-depth=2 -->
* [<img src="https://docs.goshippo.com/images/Logo.png" width="30" alt="Shippo logo"> Shippo C# SDK](#img-srchttpsdocsgoshippocomimageslogopng-width30-altshippo-logo-shippo-c-sdk)
  * [SDK Installation](#sdk-installation)
  * [SDK Example Usage](#sdk-example-usage)
  * [Custom HTTP Client](#custom-http-client)
  * [Documentation](#documentation)
  * [Available Resources and Operations](#available-resources-and-operations)
* [Development](#development)
  * [Contributions](#contributions)
  * [About Shippo](#about-shippo)

<!-- End Table of Contents [toc] -->

<!-- Start SDK Installation [installation] -->
## SDK Installation

### NuGet

To add the [NuGet](https://www.nuget.org/) package to a .NET project:
```bash
dotnet add package Shippo
```

### Locally

To add a reference to a local instance of the SDK in a .NET project:
```bash
dotnet add reference Shippo/Shippo.csproj
```
<!-- End SDK Installation [installation] -->

<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using Shippo;
using Shippo.Models.Components;

var sdk = new ShippoSDK(shippoApiVersion: "2018-02-08");

WebhookPayloadBatch req = new WebhookPayloadBatch() {};

await sdk.BatchAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Custom HTTP Client [http-client] -->
## Custom HTTP Client

The following is taken from [Speakeasy's C# design](https://www.speakeasyapi.dev/docs/sdk-design/csharp/methodology-csharp#http-client):

> By default the C# SDK will instantiate its own `SpeakeasyHttpClient`, which uses the
`System.Net.HttpClient` under the hood. The default client can be overridden by passing
a custom HTTP client when initializing the SDK:

```csharp
var sdk = new ShippoSDK(client: new CustomHttpClient());
```

> The provided HTTP Client must implement the `ISpeakeasyHttpClient` interface as defined
in `Utils.SpeakeasyHttpClient.cs`: ...

> This can be useful if you want to use a custom HTTP Client that supports a proxy or
other custom configuration.

> Below is an example of custom client that inherits from the internal
`SpeakeasyHttpClient` class, which itself implements the `ISpekeasyHttpClient` interface.
This client simply adds a header to all requests before sending them:

```csharp
using Shippo.Utils;

public class CustomHttpClient : SpeakeasyHttpClient
{
    public CustomHttpClient() {}

    public override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
    {
        request.Headers.Add("X-Custom-Header", "custom value");
        return await base.SendAsync(request);
    }
}
```

A further example is included in the `ShippoTests` project in this repo.
<!-- End Custom HTTP Client [http-client] -->

## Documentation
Review our full guides and references at [https://docs.goshippo.com/](https://docs.goshippo.com/).



<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

<details open>
<summary>Available methods</summary>

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

### [CarrierParcelTemplates](docs/sdks/carrierparceltemplates/README.md)

* [List](docs/sdks/carrierparceltemplates/README.md#list) - List all carrier parcel templates
* [Get](docs/sdks/carrierparceltemplates/README.md#get) - Retrieve a carrier parcel templates

### [CustomsDeclarations](docs/sdks/customsdeclarations/README.md)

* [List](docs/sdks/customsdeclarations/README.md#list) - List all customs declarations
* [Create](docs/sdks/customsdeclarations/README.md#create) - Create a new customs declaration
* [Get](docs/sdks/customsdeclarations/README.md#get) - Retrieve a customs declaration

### [CustomsItems](docs/sdks/customsitems/README.md)

* [List](docs/sdks/customsitems/README.md#list) - List all customs items
* [Create](docs/sdks/customsitems/README.md#create) - Create a new customs item
* [Get](docs/sdks/customsitems/README.md#get) - Retrieve a customs item

### [Manifests](docs/sdks/manifests/README.md)

* [List](docs/sdks/manifests/README.md#list) - List all manifests
* [Create](docs/sdks/manifests/README.md#create) - Create a new manifest
* [Get](docs/sdks/manifests/README.md#get) - Retrieve a manifest

### [Orders](docs/sdks/orders/README.md)

* [List](docs/sdks/orders/README.md#list) - List all orders
* [Create](docs/sdks/orders/README.md#create) - Create a new order
* [Get](docs/sdks/orders/README.md#get) - Retrieve an order

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

### [RatesAtCheckout](docs/sdks/ratesatcheckout/README.md)

* [Create](docs/sdks/ratesatcheckout/README.md#create) - Generate a live rates request
* [GetDefaultParcelTemplate](docs/sdks/ratesatcheckout/README.md#getdefaultparceltemplate) - Show current default parcel template
* [UpdateDefaultParcelTemplate](docs/sdks/ratesatcheckout/README.md#updatedefaultparceltemplate) - Update default parcel template
* [DeleteDefaultParcelTemplate](docs/sdks/ratesatcheckout/README.md#deletedefaultparceltemplate) - Clear current default parcel template

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

### [ShippoAccounts](docs/sdks/shippoaccounts/README.md)

* [List](docs/sdks/shippoaccounts/README.md#list) - List all Shippo Accounts
* [Create](docs/sdks/shippoaccounts/README.md#create) - Create a Shippo Account
* [Get](docs/sdks/shippoaccounts/README.md#get) - Retrieve a Shippo Account
* [Update](docs/sdks/shippoaccounts/README.md#update) - Update a Shippo Account


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

### [Webhooks](docs/sdks/webhooks/README.md)

* [CreateWebhook](docs/sdks/webhooks/README.md#createwebhook) - Create a new webhook
* [ListWebhooks](docs/sdks/webhooks/README.md#listwebhooks) - List all webhooks
* [GetWebhook](docs/sdks/webhooks/README.md#getwebhook) - Retrieve a specific webhook
* [UpdateWebhook](docs/sdks/webhooks/README.md#updatewebhook) - Update an existing webhook
* [DeleteWebhook](docs/sdks/webhooks/README.md#deletewebhook) - Delete a specific webhook

</details>
<!-- End Available Resources and Operations [operations] -->





<!-- No Error Handling [errors] -->
<!-- No Server Selection [server] -->
<!-- No Authentication [security] -->
<!-- No Global Parameters [global-parameters] -->




<!-- Placeholder for Future Speakeasy SDK Sections -->

# Development

## Contributions

While we value open-source contributions to this SDK, this library is generated programmatically.
Feel free to open a PR or a Github issue as a proof of concept and we'll do our best to include it in a future release!

## About Shippo
Connect with multiple different carriers, get discounted shipping labels, track parcels, and much more with just one integration. You can use your own carrier accounts or take advantage of our discounted rates with the Shippo carrier accounts. Using Shippo makes it easy to deal with multiple carrier integrations, rate shopping, tracking and other parts of the shipping workflow. We provide the API and web app for all your shipping needs.