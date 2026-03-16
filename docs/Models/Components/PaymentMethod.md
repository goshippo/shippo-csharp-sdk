# PaymentMethod

Secured funds include money orders, certified cheques and others (see 
<a href="https://www.ups.com/content/us/en/shipping/time/service/value_added/cod.html">UPS</a> for details). 
If no payment_method inputted the value defaults to "ANY".)

## Example Usage

```csharp
using Shippo.Models.Components;

var value = PaymentMethod.SecuredFunds;
```


## Values

| Name           | Value          |
| -------------- | -------------- |
| `SecuredFunds` | SECURED_FUNDS  |
| `Cash`         | CASH           |
| `Any`          | ANY            |