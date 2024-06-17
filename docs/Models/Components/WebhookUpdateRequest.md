# WebhookUpdateRequest


## Fields

| Field                                                                   | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `Event`                                                                 | [WebhookEventTypeEnum](../../Models/Components/WebhookEventTypeEnum.md) | :heavy_check_mark:                                                      | N/A                                                                     |
| `Url`                                                                   | *string*                                                                | :heavy_check_mark:                                                      | URL webhook events are sent to.                                         |
| `Active`                                                                | *bool*                                                                  | :heavy_minus_sign:                                                      | Determines whether the webhook is active or not.                        |
| `IsTest`                                                                | *bool*                                                                  | :heavy_minus_sign:                                                      | Determines whether the webhook is a test webhook or not.                |