# TransactionRate

ID of the Rate object for which a Label has to be obtained.  
If you purchase a label by calling the transaction endpoint without a rate (instalabel), 
this field will be a simplified Rate object in the Transaction model returned from the POST request.
</br>Note, only rates less than 7 days old can be purchased to ensure up-to-date pricing.


## Supported Types

### CoreRate

```csharp
TransactionRate.CreateCoreRate(/* values here */);
```

### Str

```csharp
TransactionRate.CreateStr(/* values here */);
```
