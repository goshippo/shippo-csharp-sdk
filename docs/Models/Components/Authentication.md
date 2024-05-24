# Authentication


## Fields

| Field                                                                                                                                                                                                      | Type                                                                                                                                                                                                       | Required                                                                                                                                                                                                   | Description                                                                                                                                                                                                |
| ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `Type`                                                                                                                                                                                                     | [CarrierAccountWithExtraInfoType](../../Models/Components/CarrierAccountWithExtraInfoType.md)                                                                                                              | :heavy_minus_sign:                                                                                                                                                                                         | Authentication method used by this account.                                                                                                                                                                |
| `Status`                                                                                                                                                                                                   | [CarrierAccountWithExtraInfoStatus](../../Models/Components/CarrierAccountWithExtraInfoStatus.md)                                                                                                          | :heavy_minus_sign:                                                                                                                                                                                         | Current authentication status. Possible values: 'disconnected' (authorization lost, reconnect needed), 'connected' (authorized and active), 'authorization_pending' (awaiting initial authorization flow). |