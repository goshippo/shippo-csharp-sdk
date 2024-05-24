# Refund


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           | Example                                                                               |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `ObjectCreated`                                                                       | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_minus_sign:                                                                    | Date and time of object creation.                                                     |                                                                                       |
| `ObjectId`                                                                            | *string*                                                                              | :heavy_minus_sign:                                                                    | Unique identifier of the given object.                                                | adcfdddf8ec64b84ad22772bce3ea37a                                                      |
| `ObjectOwner`                                                                         | *string*                                                                              | :heavy_minus_sign:                                                                    | Username of the user who created the object.                                          | shippotle@shippo.com                                                                  |
| `ObjectUpdated`                                                                       | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_minus_sign:                                                                    | Date and time of last object update.                                                  |                                                                                       |
| `Status`                                                                              | [RefundStatus](../../Models/Components/RefundStatus.md)                               | :heavy_minus_sign:                                                                    | Indicates the status of the Refund.                                                   | SUCCESS                                                                               |
| `Test`                                                                                | *bool*                                                                                | :heavy_minus_sign:                                                                    | Indicates whether the object has been created in test mode.                           |                                                                                       |
| `Transaction`                                                                         | *string*                                                                              | :heavy_minus_sign:                                                                    | Object ID of the Transaction to be refunded.                                          | 915d94940ea54c3a80cbfa328722f5a1                                                      |