<!-- Start SDK Example Usage [usage] -->
```csharp
using Shippo;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    shippoApiVersion: "2018-02-08",
    apiKeyHeader: "<YOUR_API_KEY_HERE>"
);

var res = await sdk.Addresses.ListAsync(
    page: 1,
    results: 5
);

// handle response
```
<!-- End SDK Example Usage [usage] -->