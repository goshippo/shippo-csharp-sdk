# BatchShipmentPaginatedList

Array of <a href="#section/Batch-Shipment">BatchShipment</a> objects. 
The response keeps the same order as in the request array.


## Fields

| Field                                                           | Type                                                            | Required                                                        | Description                                                     | Example                                                         |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `Next`                                                          | *string*                                                        | :heavy_minus_sign:                                              | N/A                                                             | baseurl?page=3&results=10                                       |
| `Previous`                                                      | *string*                                                        | :heavy_minus_sign:                                              | N/A                                                             | baseurl?page=1&results=10                                       |
| `Results`                                                       | List<[BatchShipment](../../Models/Components/BatchShipment.md)> | :heavy_minus_sign:                                              | N/A                                                             |                                                                 |