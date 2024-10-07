# CustomsDeclarations
(*CustomsDeclarations*)

## Overview

Customs declarations are relevant information, including one or multiple customs items, you need to provide for 
customs clearance for your international shipments.
<SchemaDefinition schemaRef="#/components/schemas/CustomsDeclaration"/>

### Available Operations

* [List](#list) - List all customs declarations
* [Create](#create) - Create a new customs declaration
* [Get](#get) - Retrieve a customs declaration

## List

Returns a a list of all customs declaration objects

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Requests;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

var res = await sdk.CustomsDeclarations.ListAsync(
    page: 1,
    results: 5,
    shippoApiVersion: "2018-02-08"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                          | Type                                                                                                                                                               | Required                                                                                                                                                           | Description                                                                                                                                                        | Example                                                                                                                                                            |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `Page`                                                                                                                                                             | *long*                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                 | The page number you want to select                                                                                                                                 |                                                                                                                                                                    |
| `Results`                                                                                                                                                          | *long*                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                 | The number of results to return per page (max 100, default 5)                                                                                                      |                                                                                                                                                                    |
| `ShippoApiVersion`                                                                                                                                                 | *string*                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                 | Optional string used to pick a non-default API version to use. See our <a href="https://docs.goshippo.com/docs/api_concepts/apiversioning/">API version</a> guide. | 2018-02-08                                                                                                                                                         |

### Response

**[CustomsDeclarationPaginatedList](../../Models/Components/CustomsDeclarationPaginatedList.md)**

### Errors

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |

## Create

Creates a new customs declaration object

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

var res = await sdk.CustomsDeclarations.CreateAsync(
    customsDeclarationCreateRequest: new CustomsDeclarationCreateRequest() {
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
    },
    shippoApiVersion: "2018-02-08"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                          | Type                                                                                                                                                               | Required                                                                                                                                                           | Description                                                                                                                                                        | Example                                                                                                                                                            |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CustomsDeclarationCreateRequest`                                                                                                                                  | [CustomsDeclarationCreateRequest](../../Models/Components/CustomsDeclarationCreateRequest.md)                                                                      | :heavy_check_mark:                                                                                                                                                 | CustomsDeclaration details.                                                                                                                                        |                                                                                                                                                                    |
| `ShippoApiVersion`                                                                                                                                                 | *string*                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                 | Optional string used to pick a non-default API version to use. See our <a href="https://docs.goshippo.com/docs/api_concepts/apiversioning/">API version</a> guide. | 2018-02-08                                                                                                                                                         |

### Response

**[CustomsDeclaration](../../Models/Components/CustomsDeclaration.md)**

### Errors

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |

## Get

Returns an existing customs declaration using an object ID

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Requests;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

var res = await sdk.CustomsDeclarations.GetAsync(
    customsDeclarationId: "<id>",
    page: 1,
    shippoApiVersion: "2018-02-08"
);

// handle response
```

### Parameters

| Parameter                                                                                                                                                          | Type                                                                                                                                                               | Required                                                                                                                                                           | Description                                                                                                                                                        | Example                                                                                                                                                            |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `CustomsDeclarationId`                                                                                                                                             | *string*                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                 | Object ID of the customs declaration                                                                                                                               |                                                                                                                                                                    |
| `Page`                                                                                                                                                             | *long*                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                 | The page number you want to select                                                                                                                                 |                                                                                                                                                                    |
| `ShippoApiVersion`                                                                                                                                                 | *string*                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                 | Optional string used to pick a non-default API version to use. See our <a href="https://docs.goshippo.com/docs/api_concepts/apiversioning/">API version</a> guide. | 2018-02-08                                                                                                                                                         |

### Response

**[CustomsDeclaration](../../Models/Components/CustomsDeclaration.md)**

### Errors

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |