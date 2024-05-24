# ParcelInsurance

To add insurace to your parcel, specify `amount`, `content` and `currency`. <br><br>If you do not want to add insurance to you parcel, do not set these parameters.


## Fields

| Field                                                                                                                                      | Type                                                                                                                                       | Required                                                                                                                                   | Description                                                                                                                                | Example                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------ |
| `Amount`                                                                                                                                   | *string*                                                                                                                                   | :heavy_minus_sign:                                                                                                                         | Declared value of the goods you want to insure.                                                                                            | 5.5                                                                                                                                        |
| `Content`                                                                                                                                  | *string*                                                                                                                                   | :heavy_minus_sign:                                                                                                                         | Description of parcel content.                                                                                                             | Laptop                                                                                                                                     |
| `Currency`                                                                                                                                 | *string*                                                                                                                                   | :heavy_minus_sign:                                                                                                                         | Currency for the amount value. Currently only USD is supported for FedEx and UPS.                                                          | USD                                                                                                                                        |
| `Provider`                                                                                                                                 | [ParcelInsuranceProvider](../../Models/Components/ParcelInsuranceProvider.md)                                                              | :heavy_minus_sign:                                                                                                                         | To have insurance cover provided by a carrier directly instead of Shippo's provider (XCover), set provider to `FEDEX`, `UPS`, or `ONTRAC`. | UPS                                                                                                                                        |