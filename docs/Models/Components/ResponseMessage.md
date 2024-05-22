# ResponseMessage

Message returned with supporting information from a request. In some cases this can be an error message, 
for example a timeout from a carrier. If available, the origin of the message is displayed in `source`.


## Fields

| Field                                                       | Type                                                        | Required                                                    | Description                                                 | Example                                                     |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `Source`                                                    | *string*                                                    | :heavy_minus_sign:                                          | Origin of message                                           | UPS                                                         |
| `Code`                                                      | *string*                                                    | :heavy_minus_sign:                                          | Classification of message                                   | carrier_timeout                                             |
| `Text`                                                      | *string*                                                    | :heavy_minus_sign:                                          | Message content                                             | UPS API did not respond. Please try again in a few minutes. |