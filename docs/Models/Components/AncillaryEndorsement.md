# AncillaryEndorsement

Specify an ancillary service endorsement to provide the USPS with instructions on how to handle undeliverable-as-addressed pieces (DHL eCommerce only).

## Example Usage

```csharp
using Shippo.Models.Components;

var value = AncillaryEndorsement.ForwardingServiceRequested;
```


## Values

| Name                         | Value                        |
| ---------------------------- | ---------------------------- |
| `ForwardingServiceRequested` | FORWARDING_SERVICE_REQUESTED |
| `ReturnServiceRequested`     | RETURN_SERVICE_REQUESTED     |