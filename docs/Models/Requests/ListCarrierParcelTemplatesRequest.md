# ListCarrierParcelTemplatesRequest


## Fields

| Field                                                | Type                                                 | Required                                             | Description                                          | Example                                              |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| `Include`                                            | [Include](../../Models/Requests/Include.md)          | :heavy_minus_sign:                                   | filter by user or enabled                            |                                                      |
| `Carrier`                                            | *string*                                             | :heavy_minus_sign:                                   | filter by specific carrier                           | fedex                                                |
| `ShippoApiVersion`                                   | *string*                                             | :heavy_minus_sign:                                   | String used to pick a non-default API version to use | 2018-02-08                                           |