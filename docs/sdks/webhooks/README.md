# Webhooks
(*Webhooks*)

## Overview

Webhooks are a way for Shippo to notify your application when a specific event occurs. For example, when a label is purchased or when a shipment tracking status has changed. You can use webhooks to trigger actions in your application, such as sending an email or updating a database.
<SchemaDefinition schemaRef="#/components/schemas/Webhook"/>

### Available Operations

* [CreateWebhook](#createwebhook) - Create a new webhook
* [ListWebhooks](#listwebhooks) - List all webhooks
* [GetWebhook](#getwebhook) - Retrieve a specific webhook
* [UpdateWebhook](#updatewebhook) - Update an existing webhook
* [DeleteWebhook](#deletewebhook) - Delete a specific webhook

## CreateWebhook

Creates a new webhook to send notifications to a URL when a specific event occurs.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08");

WebhookUpdateRequest req = new WebhookUpdateRequest() {
    Event = Shippo.Models.Components.WebhookEventTypeEnum.TrackUpdated,
    Url = "https://wobbly-marmalade.org",
};

var res = await sdk.Webhooks.CreateWebhookAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [WebhookUpdateRequest](../../Models/Components/WebhookUpdateRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[Webhook](../../Models/Components/Webhook.md)**
### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |

## ListWebhooks

Returns a list of all webhooks you have created.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08");

var res = await sdk.Webhooks.ListWebhooksAsync();

// handle response
```


### Response

**[WebhookPaginatedList](../../Models/Components/WebhookPaginatedList.md)**
### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |

## GetWebhook

Returns the details of a specific webhook using the webhook object ID.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Components;
using Shippo.Models.Requests;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08");

var res = await sdk.Webhooks.GetWebhookAsync(webhookId: "<value>");

// handle response
```

### Parameters

| Parameter                            | Type                                 | Required                             | Description                          |
| ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ |
| `WebhookId`                          | *string*                             | :heavy_check_mark:                   | Object ID of the webhook to retrieve |


### Response

**[Webhook](../../Models/Components/Webhook.md)**
### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |

## UpdateWebhook

Updates an existing webhook using the webhook object ID.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Components;
using Shippo.Models.Requests;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08");

var res = await sdk.Webhooks.UpdateWebhookAsync(
    webhookId: "<value>",
    webhookUpdateRequest: new WebhookUpdateRequest() {
    Event = Shippo.Models.Components.WebhookEventTypeEnum.TrackUpdated,
    Url = "https://small-cock.info",
});

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `WebhookId`                                                             | *string*                                                                | :heavy_check_mark:                                                      | Object ID of the webhook to retrieve                                    |
| `WebhookUpdateRequest`                                                  | [WebhookUpdateRequest](../../Models/Components/WebhookUpdateRequest.md) | :heavy_check_mark:                                                      | N/A                                                                     |


### Response

**[Webhook](../../Models/Components/Webhook.md)**
### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |

## DeleteWebhook

Deletes a specific webhook using the webhook object ID.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Components;
using Shippo.Models.Requests;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08");

await sdk.Webhooks.DeleteWebhookAsync(webhookId: "<value>");


```

### Parameters

| Parameter                          | Type                               | Required                           | Description                        |
| ---------------------------------- | ---------------------------------- | ---------------------------------- | ---------------------------------- |
| `WebhookId`                        | *string*                           | :heavy_check_mark:                 | Object ID of the webhook to delete |

### Errors

| Error Object                      | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4xx-5xx                           | */*                               |
