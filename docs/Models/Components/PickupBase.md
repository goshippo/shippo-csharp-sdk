# PickupBase


## Fields

| Field                                                                                                                                                                            | Type                                                                                                                                                                             | Required                                                                                                                                                                         | Description                                                                                                                                                                      | Example                                                                                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `CarrierAccount`                                                                                                                                                                 | *string*                                                                                                                                                                         | :heavy_check_mark:                                                                                                                                                               | The object ID of your USPS or DHL Express carrier account. <br/>You can retrieve this from your Rate requests or our <a href="#tag/Carrier-Accounts/">Carrier Accounts</a> endpoint. | adcfdddf8ec64b84ad22772bce3ea37a                                                                                                                                                 |
| `Location`                                                                                                                                                                       | [Location](../../Models/Components/Location.md)                                                                                                                                  | :heavy_check_mark:                                                                                                                                                               | Location where the parcel(s) will be picked up.                                                                                                                                  |                                                                                                                                                                                  |
| `Metadata`                                                                                                                                                                       | *string*                                                                                                                                                                         | :heavy_minus_sign:                                                                                                                                                               | A string of up to 100 characters that can be filled with any additional information you <br/>want to attach to the object.                                                       |                                                                                                                                                                                  |
| `RequestedEndTime`                                                                                                                                                               | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0)                                                                                            | :heavy_check_mark:                                                                                                                                                               | The latest that you requested your parcels to be available for pickup. <br/>Expressed in the timezone specified in the response.                                                 |                                                                                                                                                                                  |
| `RequestedStartTime`                                                                                                                                                             | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0)                                                                                            | :heavy_check_mark:                                                                                                                                                               | The earliest that you requested your parcels to be ready for pickup. <br/>Expressed in the timezone specified in the response.                                                   |                                                                                                                                                                                  |
| `Transactions`                                                                                                                                                                   | List<*string*>                                                                                                                                                                   | :heavy_check_mark:                                                                                                                                                               | The transaction(s) object ID(s) for the parcel(s) that need to be picked up.                                                                                                     | [<br/>"adcfdddf8ec64b84ad22772bce3ea37a"<br/>]                                                                                                                                   |