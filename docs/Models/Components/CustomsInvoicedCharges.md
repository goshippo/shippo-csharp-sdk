# CustomsInvoicedCharges

Additional invoiced charges to be shown on the Customs Declaration Commercial Invoice.


## Fields

| Field                                                                   | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `Currency`                                                              | *string*                                                                | :heavy_check_mark:                                                      | Currency for the invoiced charges amounts incurred on the end consumer. |
| `TotalShipping`                                                         | *string*                                                                | :heavy_minus_sign:                                                      | Total shipping paid by the buyer.                                       |
| `TotalTaxes`                                                            | *string*                                                                | :heavy_minus_sign:                                                      | Total taxes paid by the buyer.                                          |
| `TotalDuties`                                                           | *string*                                                                | :heavy_minus_sign:                                                      | Total duties paid by the buyer.                                         |
| `OtherFees`                                                             | *string*                                                                | :heavy_minus_sign:                                                      | Other fees paid by the buyer.                                           |