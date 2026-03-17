# WebhookPayload

The payload is the body of the POST request Shippo sends to the URL specified at the time of webhook registration.


## Supported Types

### TrackUpdated

```csharp
WebhookPayload.CreateTrackUpdated(/* values here */);
```

### BatchCreated

```csharp
WebhookPayload.CreateBatchCreated(/* values here */);
```

### BatchPurchased

```csharp
WebhookPayload.CreateBatchPurchased(/* values here */);
```

### TransactionCreated

```csharp
WebhookPayload.CreateTransactionCreated(/* values here */);
```

### TransactionUpdated

```csharp
WebhookPayload.CreateTransactionUpdated(/* values here */);
```
