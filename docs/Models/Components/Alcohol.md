# Alcohol

Indicates that a shipment contains Alcohol (Fedex and UPS only).


## Fields

| Field                                                                           | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `ContainsAlcohol`                                                               | *bool*                                                                          | :heavy_minus_sign:                                                              | Mandatory for Fedex and UPS. Specifies that the package contains Alcohol.       |
| `RecipientType`                                                                 | [RecipientType](../../Models/Components/RecipientType.md)                       | :heavy_minus_sign:                                                              | Mandatory for Fedex only. License type of the recipient of the Alcohol Package. |