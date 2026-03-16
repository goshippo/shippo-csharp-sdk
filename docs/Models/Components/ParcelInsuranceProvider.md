# ParcelInsuranceProvider

To have insurance cover provided by a carrier directly instead of Shippo's provider (XCover), set provider to `FEDEX`, `UPS`, or `ONTRAC`.

## Example Usage

```csharp
using Shippo.Models.Components;

var value = ParcelInsuranceProvider.Fedex;
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Fedex`  | FEDEX    |
| `Ups`    | UPS      |
| `Ontrac` | ONTRAC   |