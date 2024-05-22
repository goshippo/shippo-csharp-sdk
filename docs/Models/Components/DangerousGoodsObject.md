# DangerousGoodsObject

Container for specifying the presence of dangerous materials. This is specific to USPS, and if any contents
are provided, only certain USPS service levels will be eligible. For more information, see our
<a href="https://docs.goshippo.com/docs/shipments/hazmat/">guide on hazardous or dangerous materials shipping</a>.


## Fields

| Field                                                                                           | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `Contains`                                                                                      | *bool*                                                                                          | :heavy_minus_sign:                                                                              | Indicates if the shipment contains dangerous goods.                                             |
| `BiologicalMaterial`                                                                            | [DangerousGoodsBiologicalMaterial](../../Models/Components/DangerousGoodsBiologicalMaterial.md) | :heavy_minus_sign:                                                                              | Container for specifying the presence of biological material.                                   |
| `LithiumBatteries`                                                                              | [DangerousGoodsLithiumBatteries](../../Models/Components/DangerousGoodsLithiumBatteries.md)     | :heavy_minus_sign:                                                                              | Container for specifying the presence of lithium batteries.                                     |