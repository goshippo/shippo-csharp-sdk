# WebhookPaginatedList


## Fields

| Field                                               | Type                                                | Required                                            | Description                                         | Example                                             |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| `Next`                                              | *string*                                            | :heavy_minus_sign:                                  | N/A                                                 | baseurl?page=3&results=10                           |
| `Previous`                                          | *string*                                            | :heavy_minus_sign:                                  | N/A                                                 | baseurl?page=1&results=10                           |
| `Count`                                             | *long*                                              | :heavy_minus_sign:                                  | N/A                                                 |                                                     |
| `Results`                                           | List<[Webhook](../../Models/Components/Webhook.md)> | :heavy_minus_sign:                                  | N/A                                                 |                                                     |