# Webhooks
(*Webhooks*)

## Overview

Webhooks are a way for Shippo to notify your application when a specific event occurs. For example, when a label is purchased or when a shipment tracking status has changed. You can use webhooks to trigger actions in your application, such as sending an email or updating a database.
<SchemaDefinition schemaRef="#/components/schemas/Webhook"/>

# Webhook Payload
The payload is the body of the POST request Shippo sends to the URL specified at the time of webhook registration.
<SchemaDefinition schemaRef="#/components/schemas/WebhookPayload"/>

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
    shippoApiVersion: "2018-02-08"
);

WebhookUpdateRequest req = new WebhookUpdateRequest() {
    Event = WebhookEventTypeEnum.BatchCreated,
    Url = "https://example.com/shippo-webhook",
    Active = true,
    IsTest = false,
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

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |

## ListWebhooks

Returns a list of all webhooks you have created.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

var res = await sdk.Webhooks.ListWebhooksAsync();

// handle response
```

### Response

**[WebhookPaginatedList](../../Models/Components/WebhookPaginatedList.md)**

### Errors

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |

## GetWebhook

Returns the details of a specific webhook using the webhook object ID.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

var res = await sdk.Webhooks.GetWebhookAsync(webhookId: "<id>");

// handle response
```

### Parameters

| Parameter                            | Type                                 | Required                             | Description                          |
| ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ |
| `WebhookId`                          | *string*                             | :heavy_check_mark:                   | Object ID of the webhook to retrieve |

### Response

**[Webhook](../../Models/Components/Webhook.md)**

### Errors

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |

## UpdateWebhook

Updates an existing webhook using the webhook object ID.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

var res = await sdk.Webhooks.UpdateWebhookAsync(
    webhookId: "<id>",
    webhookUpdateRequest: new WebhookUpdateRequest() {
        Event = WebhookEventTypeEnum.BatchCreated,
        Url = "https://example.com/shippo-webhook",
        Active = true,
        IsTest = false,
    }
);

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

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |

## DeleteWebhook

Deletes a specific webhook using the webhook object ID.

### Example Usage

```csharp
using Shippo;
using Shippo.Models.Components;

var sdk = new ShippoSDK(
    apiKeyHeader: "<YOUR_API_KEY_HERE>",
    shippoApiVersion: "2018-02-08"
);

await sdk.Webhooks.DeleteWebhookAsync(webhookId: "<id>");

// handle response
```

### Parameters

| Parameter                          | Type                               | Required                           | Description                        |
| ---------------------------------- | ---------------------------------- | ---------------------------------- | ---------------------------------- |
| `WebhookId`                        | *string*                           | :heavy_check_mark:                 | Object ID of the webhook to delete |

### Errors

| Error Type                        | Status Code                       | Content Type                      |
| --------------------------------- | --------------------------------- | --------------------------------- |
| Shippo.Models.Errors.SDKException | 4XX, 5XX                          | \*/\*                             |