# CarrierAccounts
(*CarrierAccounts*)

## Overview

Carriers are the companies who deliver your package. Shippo uses Carrier account objects as credentials to retrieve shipping rates and purchase labels from shipping Carriers.

<SchemaDefinition schemaRef="#/components/schemas/CarrierAccount"/>

### Available Operations

* [List](#list) - List all carrier accounts
* [Create](#create) - Create a new carrier account
* [Get](#get) - Retrieve a carrier account
* [Update](#update) - Update a carrier account
* [InitiateOauth2Signin](#initiateoauth2signin) - Connect an existing carrier account using OAuth 2.0
* [Register](#register) - Add a Shippo carrier account
* [GetRegistrationStatus](#getregistrationstatus) - Get Carrier Registration status

## List

Returns a list of all carrier accounts connected to your Shippo account. These carrier accounts include both Shippo carrier accounts and your own carrier accounts that you have connected to your Shippo account.

Additionally, you can get information about the service levels associated with each carrier account by passing in the `?service_levels=true` query parameter. <br>
Using it appends the property `service_levels` to each carrier account. <br>
By default, if the query parameter is omitted, the `service_levels` property will not be included in the response.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Requests;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

ListCarrierAccountsRequest req = new ListCarrierAccountsRequest() {};

var res = await sdk.CarrierAccounts.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListCarrierAccountsRequest](../../Models/Requests/ListCarrierAccountsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[CarrierAccountPaginatedList](../../Models/Components/CarrierAccountPaginatedList.md)**

### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |


## Create

Creates a new carrier account or connects an existing carrier account to the Shippo account.

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

var res = await sdk.CarrierAccounts.CreateAsync(
    connectExistingOwnAccountRequest: new ConnectExistingOwnAccountRequest() {
        AccountId = "321123",
        Carrier = "fedex",
        Metadata = "FEDEX Account",
        Parameters = ConnectExistingOwnAccountRequestParameters.CreateFedExConnectExistingOwnAccountParameters(
            new FedExConnectExistingOwnAccountParameters() {
                FirstName = "Loyal",
                LastName = "Collier",
                PhoneNumber = "(890) 307-8579",
                FromAddressSt = "<value>",
                FromAddressCity = "<value>",
                FromAddressState = "<value>",
                FromAddressZip = "<value>",
                FromAddressCountryIso2 = "<value>",
            }
        ),
        Test = false,
    },
    shippoApiVersion: "2018-02-08"
);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     | Example                                                                                         |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `ConnectExistingOwnAccountRequest`                                                              | [ConnectExistingOwnAccountRequest](../../Models/Components/ConnectExistingOwnAccountRequest.md) | :heavy_check_mark:                                                                              | Examples.                                                                                       |                                                                                                 |
| `ShippoApiVersion`                                                                              | *string*                                                                                        | :heavy_minus_sign:                                                                              | String used to pick a non-default API version to use                                            | 2018-02-08                                                                                      |

### Response

**[CarrierAccount](../../Models/Components/CarrierAccount.md)**

### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |


## Get

Returns an existing carrier account using an object ID.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Requests;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

var res = await sdk.CarrierAccounts.GetAsync(
    carrierAccountId: "<value>",
    shippoApiVersion: "2018-02-08"
);

// handle response
```

### Parameters

| Parameter                                            | Type                                                 | Required                                             | Description                                          | Example                                              |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| `CarrierAccountId`                                   | *string*                                             | :heavy_check_mark:                                   | Object ID of the carrier account                     |                                                      |
| `ShippoApiVersion`                                   | *string*                                             | :heavy_minus_sign:                                   | String used to pick a non-default API version to use | 2018-02-08                                           |

### Response

**[CarrierAccount](../../Models/Components/CarrierAccount.md)**

### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |


## Update

Updates an existing carrier account object. The account_id and carrier can't be updated. This is because they form the unique identifier together.

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

var res = await sdk.CarrierAccounts.UpdateAsync(
    carrierAccountId: "<value>",
    shippoApiVersion: "2018-02-08",
    carrierAccountBase: new CarrierAccountBase() {
        AccountId = "****",
        Carrier = "usps",
        Parameters = CarrierAccountBaseParameters.CreateUPSConnectExistingOwnAccountParameters(
            new UPSConnectExistingOwnAccountParameters() {
                AccountNumber = "94567e",
                AiaCountryIso2 = "US",
                BillingAddressCity = "San Francisco",
                BillingAddressCountryIso2 = "US",
                BillingAddressState = "CA",
                BillingAddressStreet1 = "731 Market St",
                BillingAddressStreet2 = "STE 200",
                BillingAddressZip = "94103",
                CollecCountryIso2 = "US",
                CollecZip = "94103",
                Company = "Shippo",
                CurrencyCode = "USD",
                Email = "hippo@shippo.com",
                FullName = "Shippo Meister",
                HasInvoice = false,
                InvoiceControlid = "1234",
                InvoiceDate = "20210529",
                InvoiceNumber = "1112234",
                InvoiceValue = "11.23",
                Phone = "1112223333",
                Title = "Manager",
                UpsAgreements = false,
            }
        ),
    }
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `CarrierAccountId`                                                  | *string*                                                            | :heavy_check_mark:                                                  | Object ID of the carrier account                                    |                                                                     |
| `ShippoApiVersion`                                                  | *string*                                                            | :heavy_minus_sign:                                                  | String used to pick a non-default API version to use                | 2018-02-08                                                          |
| `CarrierAccountBase`                                                | [CarrierAccountBase](../../Models/Components/CarrierAccountBase.md) | :heavy_minus_sign:                                                  | Examples.                                                           |                                                                     |

### Response

**[CarrierAccount](../../Models/Components/CarrierAccount.md)**

### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |


## InitiateOauth2Signin

Used by client applications to setup or reconnect an existing carrier account with carriers that support OAuth 2.0

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Requests;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

InitiateOauth2SigninRequest req = new InitiateOauth2SigninRequest() {
    CarrierAccountObjectId = "<value>",
    RedirectUri = "https://enlightened-mortise.com/",
};

var res = await sdk.CarrierAccounts.InitiateOauth2SigninAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [InitiateOauth2SigninRequest](../../Models/Requests/InitiateOauth2SigninRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[InitiateOauth2SigninResponse](../../Models/Requests/InitiateOauth2SigninResponse.md)**

### Errors

| Error Object                                                                 | Status Code                                                                  | Content Type                                                                 |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| Shippo.Models.Errors.InitiateOauth2SigninResponseBody                        | 400                                                                          | application/json                                                             |
| Shippo.Models.Errors.InitiateOauth2SigninCarrierAccountsResponseBody         | 401                                                                          | application/json                                                             |
| Shippo.Models.Errors.InitiateOauth2SigninCarrierAccountsResponseResponseBody | 404                                                                          | application/json                                                             |
| Shippo.Models.Errors.SDKException                                            | 4xx-5xx                                                                      | */*                                                                          |


## Register

Adds a Shippo carrier account

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Requests;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

var res = await sdk.CarrierAccounts.RegisterAsync(
    requestBody: RegisterCarrierAccountRequestBody.CreateCarrierAccountCorreosCreateRequest(
        new CarrierAccountCorreosCreateRequest() {
            Carrier = "correos",
            Parameters = new CarrierAccountCorreosCreateRequestParameters() {},
        }
    ),
    shippoApiVersion: "2018-02-08"
);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     | Example                                                                                         |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `RequestBody`                                                                                   | [RegisterCarrierAccountRequestBody](../../Models/Requests/RegisterCarrierAccountRequestBody.md) | :heavy_check_mark:                                                                              | Examples.                                                                                       |                                                                                                 |
| `ShippoApiVersion`                                                                              | *string*                                                                                        | :heavy_minus_sign:                                                                              | String used to pick a non-default API version to use                                            | 2018-02-08                                                                                      |

### Response

**[CarrierAccount](../../Models/Components/CarrierAccount.md)**

### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |


## GetRegistrationStatus

Returns the registration status for the given account for the given carrier

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Requests;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

var res = await sdk.CarrierAccounts.GetRegistrationStatusAsync(
    carrier: Shippo.Models.Requests.Carrier.Usps,
    shippoApiVersion: "2018-02-08"
);

// handle response
```

### Parameters

| Parameter                                            | Type                                                 | Required                                             | Description                                          | Example                                              |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| `Carrier`                                            | [Carrier](../../Models/Requests/Carrier.md)          | :heavy_check_mark:                                   | filter by specific carrier                           |                                                      |
| `ShippoApiVersion`                                   | *string*                                             | :heavy_minus_sign:                                   | String used to pick a non-default API version to use | 2018-02-08                                           |

### Response

**[CarrierAccountRegistrationStatus](../../Models/Components/CarrierAccountRegistrationStatus.md)**

### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |
