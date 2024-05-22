<!-- Start SDK Example Usage [usage] -->
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