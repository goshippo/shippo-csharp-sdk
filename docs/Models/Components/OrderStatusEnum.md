# OrderStatusEnum

Current state of the order. See the <a href="https://docs.goshippo.com/docs/orders/orders/">orders tutorial</a> 
for the logic of how the status is handled.

## Example Usage

```csharp
using Shippo.Models.Components;

var value = OrderStatusEnum.Unknown;
```


## Values

| Name                 | Value                |
| -------------------- | -------------------- |
| `Unknown`            | UNKNOWN              |
| `Awaitpay`           | AWAITPAY             |
| `Paid`               | PAID                 |
| `Refunded`           | REFUNDED             |
| `Cancelled`          | CANCELLED            |
| `PartiallyFulfilled` | PARTIALLY_FULFILLED  |
| `Shipped`            | SHIPPED              |