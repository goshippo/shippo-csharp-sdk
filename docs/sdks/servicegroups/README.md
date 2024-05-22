# ServiceGroups
(*ServiceGroups*)

## Overview

A service group is a set of service levels grouped together. 
Rates at checkout uses services groups to present available shipping options to customers in their shopping basket.
<SchemaDefinition schemaRef="#/components/schemas/ServiceGroup"/>

### Available Operations

* [List](#list) - List all service groups
* [Create](#create) - Create a new service group
* [Update](#update) - Update an existing service group
* [Delete](#delete) - Delete a service group

## List

Returns a list of service group objects.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Components;
using Shippo.Models.Requests;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08");

var res = await sdk.ServiceGroups.ListAsync(shippoApiVersion: "2018-02-08");

// handle response
```

### Parameters

| Parameter                                            | Type                                                 | Required                                             | Description                                          | Example                                              |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| `ShippoApiVersion`                                   | *string*                                             | :heavy_minus_sign:                                   | String used to pick a non-default API version to use | 2018-02-08                                           |


### Response

**[ListServiceGroupsResponse](../../Models/Requests/ListServiceGroupsResponse.md)**
### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |

## Create

Creates a new service group.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Components;
using Shippo.Models.Requests;
using System.Collections.Generic;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08");

var res = await sdk.ServiceGroups.CreateAsync(
    serviceGroupCreateRequest: new ServiceGroupCreateRequest() {
    Description = "USPS shipping options",
    FlatRate = "5",
    FlatRateCurrency = "USD",
    FreeShippingThresholdCurrency = "USD",
    FreeShippingThresholdMin = "5",
    Name = "USPS Shipping",
    RateAdjustment = 15,
    Type = Shippo.Models.Components.ServiceGroupTypeEnum.FlatRate,
    ServiceLevels = new List<ServiceGroupAccountAndServiceLevel>() {
        new ServiceGroupAccountAndServiceLevel() {
            AccountObjectId = "80feb1633d4a43c898f0058506cfd82d",
            ServiceLevelToken = "ups_next_day_air_saver",
        },
    },
},
    shippoApiVersion: "2018-02-08");

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       | Example                                                                           |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `ServiceGroupCreateRequest`                                                       | [ServiceGroupCreateRequest](../../Models/Components/ServiceGroupCreateRequest.md) | :heavy_check_mark:                                                                | N/A                                                                               |                                                                                   |
| `ShippoApiVersion`                                                                | *string*                                                                          | :heavy_minus_sign:                                                                | String used to pick a non-default API version to use                              | 2018-02-08                                                                        |


### Response

**[CreateServiceGroupResponse](../../Models/Requests/CreateServiceGroupResponse.md)**
### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |

## Update

Updates an existing service group object. <br>The object_id cannot be updated as it is the unique identifier for the object.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Components;
using Shippo.Models.Requests;
using System.Collections.Generic;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08");

var res = await sdk.ServiceGroups.UpdateAsync(
    shippoApiVersion: "2018-02-08",
    serviceGroupUpdateRequest: new ServiceGroupUpdateRequest() {
    Description = "USPS shipping options",
    FlatRate = "5",
    FlatRateCurrency = "USD",
    FreeShippingThresholdCurrency = "USD",
    FreeShippingThresholdMin = "5",
    Name = "USPS Shipping",
    RateAdjustment = 15,
    Type = Shippo.Models.Components.ServiceGroupTypeEnum.FlatRate,
    ObjectId = "80feb1633d4a43c898f005850",
    IsActive = true,
    ServiceLevels = new List<ServiceGroupAccountAndServiceLevel>() {
        new ServiceGroupAccountAndServiceLevel() {
            AccountObjectId = "80feb1633d4a43c898f0058506cfd82d",
            ServiceLevelToken = "ups_next_day_air_saver",
        },
    },
});

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       | Example                                                                           |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `ShippoApiVersion`                                                                | *string*                                                                          | :heavy_minus_sign:                                                                | String used to pick a non-default API version to use                              | 2018-02-08                                                                        |
| `ServiceGroupUpdateRequest`                                                       | [ServiceGroupUpdateRequest](../../Models/Components/ServiceGroupUpdateRequest.md) | :heavy_minus_sign:                                                                | N/A                                                                               |                                                                                   |


### Response

**[UpdateServiceGroupResponse](../../Models/Requests/UpdateServiceGroupResponse.md)**
### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |

## Delete

Deletes an existing service group using an object ID.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Components;
using Shippo.Models.Requests;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08");

var res = await sdk.ServiceGroups.DeleteAsync(
    serviceGroupId: "<value>",
    shippoApiVersion: "2018-02-08");

// handle response
```

### Parameters

| Parameter                                            | Type                                                 | Required                                             | Description                                          | Example                                              |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| `ServiceGroupId`                                     | *string*                                             | :heavy_check_mark:                                   | Object ID of the service group                       |                                                      |
| `ShippoApiVersion`                                   | *string*                                             | :heavy_minus_sign:                                   | String used to pick a non-default API version to use | 2018-02-08                                           |


### Response

**[DeleteServiceGroupResponse](../../Models/Requests/DeleteServiceGroupResponse.md)**
### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |
