# WebhookPayloadBatch

Content of the webhook posted to the external URL


## Fields

| Field                                                                                                 | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `Event`                                                                                               | [WebhookEventTypeEnum](../../Models/Components/WebhookEventTypeEnum.md)                               | :heavy_minus_sign:                                                                                    | Type of event that triggered the webhook.                                                             |
| `Test`                                                                                                | *bool*                                                                                                | :heavy_minus_sign:                                                                                    | Determines whether the webhook is a test webhook or not.                                              |
| `Data`                                                                                                | *string*                                                                                              | :heavy_minus_sign:                                                                                    | A string containing the batch object ID, of the form 'batch {batchId} (created\|processing complete)'. |