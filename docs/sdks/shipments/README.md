# Shipments
(*Shipments*)

## Overview

A shipment is the act of transporting goods. A shipment object contains **to** and **from** addresses, and the parcel details that you are shipping. You can use the shipment object to retrieve shipping rates and purchase a shipping label.
<SchemaDefinition schemaRef="#/components/schemas/Shipment"/>
 
# Shipment Extras
The following values are supported for the `extra` field of the shipment object.
<SchemaDefinition schemaRef="#/components/schemas/ShipmentExtra"/>

### Available Operations

* [List](#list) - List all shipments
* [Create](#create) - Create a new shipment
* [Get](#get) - Retrieve a shipment

## List

Returns a list of all shipment objects.<br><br>
In order to filter results, you must use the below path parameters. 
A maximum date range of 90 days is permitted. 
Provided dates should be ISO 8601 UTC dates (timezone offsets are currently not supported).<br><br>

Optional path parameters:<br>
  `object_created_gt`- object(s) created greater than a provided date time<br>
  `object_created_gte` - object(s) created greater than or equal to a provided date time<br>
  `object_created_lt` - object(s) created less than a provided date time<br>
  `object_created_lte` - object(s) created less than or equal to a provided date time<br>

  Date format examples:<br>
    `2017-01-01`<br>
    `2017-01-01T03:30:30` or `2017-01-01T03:30:30.5`<br>
    `2017-01-01T03:30:30Z`<br><br>

  Example URL:<br>
    `https://api.goshippo.com/shipments/?object_created_gte=2017-01-01T00:00:30&object_created_lt=2017-04-01T00:00:30`

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Requests;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

ListShipmentsRequest req = new ListShipmentsRequest() {};

var res = await sdk.Shipments.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [ListShipmentsRequest](../../Models/Requests/ListShipmentsRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[ShipmentPaginatedList](../../Models/Components/ShipmentPaginatedList.md)**

### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |


## Create

Creates a new shipment object.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Requests;
using Shippo.Models.Components;
using System.Collections.Generic;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

var res = await sdk.Shipments.CreateAsync(
    shipmentCreateRequest: new ShipmentCreateRequest() {
        Extra = new ShipmentExtra() {
            AccountsReceivableCustomerAccount = new UPSReferenceFields() {
                Prefix = "ABC",
                Value = "value",
                RefSort = 1,
            },
            AppropriationNumber = new UPSReferenceFields() {
                Prefix = "ABC",
                Value = "value",
                RefSort = 1,
            },
            BillOfLadingNumber = new UPSReferenceFields() {
                Prefix = "ABC",
                Value = "value",
                RefSort = 1,
            },
            Cod = new Cod() {
                Amount = "5.5",
                Currency = "USD",
                PaymentMethod = Shippo.Models.Components.PaymentMethod.Cash,
            },
            CodNumber = new UPSReferenceFields() {
                Prefix = "ABC",
                Value = "value",
                RefSort = 1,
            },
            CustomerReference = new CustomerReference() {
                RefSort = 1,
            },
            DealerOrderNumber = new UPSReferenceFields() {
                Prefix = "ABC",
                Value = "value",
                RefSort = 1,
            },
            DeptNumber = new DepartmentNumber() {
                RefSort = 3,
            },
            FdaProductCode = new UPSReferenceFields() {
                Prefix = "ABC",
                Value = "value",
                RefSort = 1,
            },
            Insurance = new Insurance() {
                Amount = "5.5",
                Currency = "USD",
            },
            InvoiceNumber = new InvoiceNumber() {
                RefSort = 2,
            },
            ManifestNumber = new UPSReferenceFields() {
                Prefix = "ABC",
                Value = "value",
                RefSort = 1,
            },
            ModelNumber = new UPSReferenceFields() {
                Prefix = "ABC",
                Value = "value",
                RefSort = 1,
            },
            PartNumber = new UPSReferenceFields() {
                Prefix = "ABC",
                Value = "value",
                RefSort = 1,
            },
            PoNumber = new PoNumber() {
                RefSort = 2,
            },
            ProductionCode = new UPSReferenceFields() {
                Prefix = "ABC",
                Value = "value",
                RefSort = 1,
            },
            PurchaseRequestNumber = new UPSReferenceFields() {
                Prefix = "ABC",
                Value = "value",
                RefSort = 1,
            },
            RmaNumber = new RmaNumber() {
                RefSort = 1,
            },
            SalespersonNumber = new UPSReferenceFields() {
                Prefix = "ABC",
                Value = "value",
                RefSort = 1,
            },
            SerialNumber = new UPSReferenceFields() {
                Prefix = "ABC",
                Value = "value",
                RefSort = 1,
            },
            StoreNumber = new UPSReferenceFields() {
                Prefix = "ABC",
                Value = "value",
                RefSort = 1,
            },
            TransactionReferenceNumber = new UPSReferenceFields() {
                Prefix = "ABC",
                Value = "value",
                RefSort = 1,
            },
        },
        Metadata = "Customer ID 123456",
        ShipmentDate = "2021-03-22T12:00:00Z",
        AddressFrom = AddressFrom.CreateAddressCreateRequest(
            new AddressCreateRequest() {
                Name = "Shwan Ippotle",
                Company = "Shippo",
                Street1 = "215 Clayton St.",
                Street3 = "",
                StreetNo = "",
                City = "San Francisco",
                State = "CA",
                Zip = "94117",
                Country = "US",
                Phone = "+1 555 341 9393",
                Email = "shippotle@shippo.com",
                IsResidential = true,
                Metadata = "Customer ID 123456",
                Validate = true,
            }
        ),
        AddressReturn = AddressReturn.CreateStr(
            "d799c2679e644279b59fe661ac8fa488"
        ),
        AddressTo = AddressTo.CreateAddressCreateRequest(
            new AddressCreateRequest() {
                Name = "Shwan Ippotle",
                Company = "Shippo",
                Street1 = "215 Clayton St.",
                Street3 = "",
                StreetNo = "",
                City = "San Francisco",
                State = "CA",
                Zip = "94117",
                Country = "US",
                Phone = "+1 555 341 9393",
                Email = "shippotle@shippo.com",
                IsResidential = true,
                Metadata = "Customer ID 123456",
                Validate = true,
            }
        ),
        CustomsDeclaration = ShipmentCreateRequestCustomsDeclaration.CreateCustomsDeclarationCreateRequest(
            new CustomsDeclarationCreateRequest() {
                B13aFilingOption = Shippo.Models.Components.CustomsDeclarationB13AFilingOptionEnum.FiledElectronically,
                Certify = true,
                CertifySigner = "Shawn Ippotle",
                ContentsExplanation = "T-Shirt purchase",
                DutiesPayor = new DutiesPayor() {
                    Account = "2323434543",
                    Type = Shippo.Models.Components.CustomsDeclarationCreateRequestType.ThirdParty,
                    Address = new CustomsDeclarationCreateRequestAddress() {
                        Name = "Patrick Kavanagh",
                        Zip = "80331",
                        Country = "DE",
                    },
                },
                ExporterIdentification = new CustomsExporterIdentification() {
                    EoriNumber = "PL123456790ABCDE",
                    TaxId = new CustomsTaxIdentification() {
                        Number = "123456789",
                        Type = Shippo.Models.Components.CustomsTaxIdentificationType.Ein,
                    },
                },
                Invoice = "#123123",
                Metadata = "Order ID #123123",
                AddressImporter = new AddressImporter() {
                    Name = "Shwan Ippotle",
                    Company = "Shippo",
                    Street1 = "Blumenstraße",
                    Street3 = "",
                    StreetNo = "22",
                    City = "München",
                    State = "CA",
                    Zip = "80331",
                    Country = "DE",
                    Phone = "80331",
                    Email = "shippotle@shippo.com",
                    IsResidential = true,
                },
                ContentsType = Shippo.Models.Components.CustomsDeclarationContentsTypeEnum.Merchandise,
                EelPfc = Shippo.Models.Components.CustomsDeclarationEelPfcEnum.Noeei3037A,
                Incoterm = Shippo.Models.Components.CustomsDeclarationIncotermEnum.Ddp,
                Items = new List<CustomsItemCreateRequest>() {
                    new CustomsItemCreateRequest() {
                        Description = "T-Shirt",
                        MassUnit = Shippo.Models.Components.WeightUnitEnum.Lb,
                        Metadata = "Order ID \"123454\"",
                        NetWeight = "5",
                        OriginCountry = "<value>",
                        Quantity = 20,
                        SkuCode = "HM-123",
                        HsCode = "0901.21",
                        ValueAmount = "200",
                        ValueCurrency = "USD",
                    },
                },
                NonDeliveryOption = Shippo.Models.Components.CustomsDeclarationNonDeliveryOptionEnum.Return,
                Test = true,
            }
        ),
        CarrierAccounts = new List<string>() {
            "065a4a8c10d24a34ab932163a1b87f52",
            "73f706f4bdb94b54a337563840ce52b0",
        },
        Parcels = new List<Models.Components.Parcels>() {
            Parcels.CreateParcelCreateRequest(
                new ParcelCreateRequest() {
                    Extra = new ParcelExtra() {
                        Cod = new Cod() {
                            Amount = "5.5",
                            Currency = "USD",
                            PaymentMethod = Shippo.Models.Components.PaymentMethod.Cash,
                        },
                        Insurance = new ParcelInsurance() {
                            Amount = "5.5",
                            Content = "Laptop",
                            Currency = "USD",
                            Provider = Shippo.Models.Components.ParcelInsuranceProvider.Ups,
                        },
                    },
                    Metadata = "Customer ID 123456",
                    MassUnit = Shippo.Models.Components.WeightUnitEnum.Lb,
                    Weight = "1",
                    DistanceUnit = Shippo.Models.Components.DistanceUnitEnum.In,
                    Height = "1",
                    Length = "1",
                    Width = "1",
                }
            ),
        },
    },
    shippoApiVersion: "2018-02-08"
);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               | Example                                                                   |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `ShipmentCreateRequest`                                                   | [ShipmentCreateRequest](../../Models/Components/ShipmentCreateRequest.md) | :heavy_check_mark:                                                        | Shipment details and contact info.                                        |                                                                           |
| `ShippoApiVersion`                                                        | *string*                                                                  | :heavy_minus_sign:                                                        | String used to pick a non-default API version to use                      | 2018-02-08                                                                |

### Response

**[Shipment](../../Models/Components/Shipment.md)**

### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |


## Get

Returns an existing shipment using an object ID

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Requests;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

var res = await sdk.Shipments.GetAsync(
    shipmentId: "<value>",
    shippoApiVersion: "2018-02-08"
);

// handle response
```

### Parameters

| Parameter                                            | Type                                                 | Required                                             | Description                                          | Example                                              |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| `ShipmentId`                                         | *string*                                             | :heavy_check_mark:                                   | Object ID of the shipment to update                  |                                                      |
| `ShippoApiVersion`                                   | *string*                                             | :heavy_minus_sign:                                   | String used to pick a non-default API version to use | 2018-02-08                                           |

### Response

**[Shipment](../../Models/Components/Shipment.md)**

### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |
