# ListShipmentRatesRequest


## Fields

| Field                                                | Type                                                 | Required                                             | Description                                          | Example                                              |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| `ShipmentId`                                         | *string*                                             | :heavy_check_mark:                                   | Object ID of the shipment to update                  |                                                      |
| `Page`                                               | *long*                                               | :heavy_minus_sign:                                   | The page number you want to select                   |                                                      |
| `Results`                                            | *long*                                               | :heavy_minus_sign:                                   | The number of results to return per page (max 100)   |                                                      |
| `ShippoApiVersion`                                   | *string*                                             | :heavy_minus_sign:                                   | String used to pick a non-default API version to use | 2018-02-08                                           |