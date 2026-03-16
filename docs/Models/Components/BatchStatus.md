# BatchStatus

Batches that are `VALIDATING` are being created and validated<br>
`VALID` batches can be purchased<br>
`INVALID` batches cannot be purchased, `INVALID` BatchShipments must be removed<br>
Batches that are in the `PURCHASING` state are being purchased<br>
`PURCHASED` batches are finished purchasing.

## Example Usage

```csharp
using Shippo.Models.Components;

var value = BatchStatus.Validating;
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Validating` | VALIDATING   |
| `Valid`      | VALID        |
| `Invalid`    | INVALID      |
| `Purchasing` | PURCHASING   |
| `Purchased`  | PURCHASED    |