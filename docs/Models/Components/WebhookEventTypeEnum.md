# WebhookEventTypeEnum

Type of event that triggered the webhook.

## Example Usage

```csharp
using Shippo.Models.Components;

var value = WebhookEventTypeEnum.TransactionCreated;
```


## Values

| Name                 | Value                |
| -------------------- | -------------------- |
| `TransactionCreated` | transaction_created  |
| `TransactionUpdated` | transaction_updated  |
| `TrackUpdated`       | track_updated        |
| `BatchCreated`       | batch_created        |
| `BatchPurchased`     | batch_purchased      |
| `All`                | all                  |