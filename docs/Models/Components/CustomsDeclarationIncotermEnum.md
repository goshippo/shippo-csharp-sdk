# CustomsDeclarationIncotermEnum

The incoterm reference of the shipment. FCA is available for DHL Express and FedEx only.
eDAP is available for DPD UK only. DAP is available for DHL Express, FedEx, and DPD UK.
If expecting DAP for other carriers, please use DDU.
Allowed values available <a href="/shippoapi/public-api/customs-declaration-incoterm">here</a>
Carrier-specific restrictions are in the table below.

**Carrier-Specific Constraints:**
| Carrier | Constraints |
|:---|:---|
| FedEx | Must be one of DDP, DDU, FCA, DAP |

## Example Usage

```csharp
using Shippo.Models.Components;

var value = CustomsDeclarationIncotermEnum.Ddp;
```


## Values

| Name   | Value  |
| ------ | ------ |
| `Ddp`  | DDP    |
| `Ddu`  | DDU    |
| `Fca`  | FCA    |
| `Dap`  | DAP    |
| `Edap` | eDAP   |