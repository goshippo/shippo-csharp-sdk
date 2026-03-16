# CarrierAccountWithExtraInfoStatus

Current authentication status. Possible values: 'disconnected' (authorization lost, reconnect needed), 'connected' (authorized and active), 'authorization_pending' (awaiting initial authorization flow).

## Example Usage

```csharp
using Shippo.Models.Components;

var value = CarrierAccountWithExtraInfoStatus.Disconnected;
```


## Values

| Name                   | Value                  |
| ---------------------- | ---------------------- |
| `Disconnected`         | disconnected           |
| `Connected`            | connected              |
| `AuthorizationPending` | authorization_pending  |