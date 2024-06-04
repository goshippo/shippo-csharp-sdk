namespace ShippoTests.Docs;

class UserGuides
{
    /// <remarks>
    /// Snippets from https://docs.goshippo.com
    /// They are part of the test project to verify that they compile successfully.
    /// </remarks>

    /// <remarks>
    /// https://docs.goshippo.com/docs/addresses/addressvalidation/#C
    /// </remarks>
    private async void addressvalidation1()
    {
        var sdk = new ShippoSDK();
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Address address = await sdk.Addresses.CreateAsync(
            new AddressCreateRequest()
            {
                Name = "Shawn Ippotle",
                Company = "Shippo",
                Street1 = "215 Clayton St.",
                City = "San Francisco",
                State = "CA",
                Zip = "94117",
                Country = "US",
                Email = "shippotle@shippo.com",
                Validate = true,
            }
        );
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    }
    private async void addressvalidation2()
    {
        var sdk = new ShippoSDK();
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        await sdk.Addresses.ValidateAsync("d799c2679e644279b59fe661ac8fa488");
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    }

    /// <remarks>
    /// https://docs.goshippo.com/docs/api_concepts/apiversioning/#C
    /// </remarks>
    private void apiversioning()
    {
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // using Shippo;
        ShippoSDK sdk = new ShippoSDK(
            apiKeyHeader: "<API_Token>",
            shippoApiVersion: "YYYY-MM-DD"
        );
        // now all subsequent requests use the API version "YYYY-MM-DD"
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    }

    /// <remarks>
    /// https://docs.goshippo.com/docs/guides_general/api_quickstart/#C
    /// </remarks>
    private async void api_quickstart()
    {
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // using Shippo;
        // using Shippo.Models.Components;
        ShippoSDK sdk = new ShippoSDK(apiKeyHeader: "<API_TOKEN>");
        Address address = await sdk.Addresses.CreateAsync(
            new AddressCreateRequest()
            {
                Name = "Shawn Ippotle",
                Company = "Shippo",
                Street1 = "215 Clayton St.",
                City = "San Francisco",
                State = "CA",
                Zip = "94117",
                Country = "US",
                Phone = "+1 555 341 9393",
                Email = "shippotle@shippo.com",
            }
        );
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    }

    /// <remarks>
    /// https://docs.goshippo.com/docs/carriers/carrieraccounts/#C
    /// </remarks>
    private async void carrieraccounts1()
    {
        var sdk = new ShippoSDK();
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        CarrierAccount fedexAccount = await sdk.CarrierAccounts.CreateAsync(
            new ConnectExistingOwnAccountRequest()
            {
                Carrier = CarriersEnum.Fedex.Value(),
                AccountId = "<YOUR-FEDEX-ACCOUNT-NUMBER>",
                Parameters = ConnectExistingOwnAccountRequestParameters.CreateFedExConnectExistingOwnAccountParameters(
                    new FedExConnectExistingOwnAccountParameters()
                    {
                        FirstName = "<YOUR_FIRST_NAME>",
                        LastName = "<YOUR_LAST_NAME>",
                        PhoneNumber = "<YOUR_PHONE_NUMBER>",
                        FromAddressSt = "<YOUR_STREET_ADDRESS>",
                        FromAddressCity = "<YOUR_CITY>",
                        FromAddressState = "<YOUR_STATE>",
                        FromAddressZip = "<YOUR_ZIP>",
                        FromAddressCountryIso2 = "<YOUR_COUNTRY>",
                    }
                ),
                Active = true,
                Test = false,
            }
        );
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    }
    private async void carrieraccounts2()
    {
        var sdk = new ShippoSDK();
        var addressFrom = AddressFrom.CreateAddressCreateRequest(new AddressCreateRequest() { });
        var addressTo = AddressTo.CreateAddressCreateRequest(new AddressCreateRequest() { });
        var parcel = Shippo.Models.Components.Parcels.CreateParcelCreateRequest(new ParcelCreateRequest() { });
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Shipment shipment = await sdk.Shipments.CreateAsync(
            new ShipmentCreateRequest()
            {
                AddressFrom = addressFrom,
                AddressTo = addressTo,
                Parcels = new List<Shippo.Models.Components.Parcels>() { parcel },
                CarrierAccounts = new List<string>() { "b741b99f95e841639b54272834bc478c" },
                Async = false,
            }
        );
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    }
    private async void carrieraccounts3()
    {
        var sdk = new ShippoSDK();
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        await sdk.CarrierAccounts.ListAsync(
            new ListCarrierAccountsRequest()
            {
                Carrier = CarriersEnum.Fedex,
            }
        );
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    }

    /// <remarks>
    /// https://docs.goshippo.com/docs/guides_general/generate_shipping_label/#C
    /// </remarks>
    private async void generate_shipping_label1()
    {
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // using Shippo;
        // using Shippo.Models.Components;
        ShippoSDK sdk = new ShippoSDK(apiKeyHeader: "<API_TOKEN>");
        AddressFrom addressFrom = AddressFrom.CreateAddressCreateRequest(
            new AddressCreateRequest()
            {
                Name = "Shawn Ippotle",
                Street1 = "215 Clayton St.",
                City = "San Francisco",
                State = "CA",
                Zip = "94117",
                Country = "US",
            }
        );
        AddressTo addressTo = AddressTo.CreateAddressCreateRequest(
            new AddressCreateRequest()
            {
                Name = "Mr Hippo",
                Street1 = "Broadway 1",
                City = "New York",
                State = "NY",
                Zip = "10007",
                Country = "US",
            }
        );
        Shippo.Models.Components.Parcels parcel = Shippo.Models.Components.Parcels.CreateParcelCreateRequest(
            new ParcelCreateRequest()
            {
                Length = "5",
                Width = "5",
                Height = "5",
                DistanceUnit = DistanceUnitEnum.In,
                Weight = "2",
                MassUnit = WeightUnitEnum.Lb,
            }
        );
        Shipment shipment = await sdk.Shipments.CreateAsync(
            new ShipmentCreateRequest()
            {
                AddressFrom = addressFrom,
                AddressTo = addressTo,
                Parcels = new List<Shippo.Models.Components.Parcels>() { parcel },
                Async = false,
            }
        );
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    }
    private async void generate_shipping_label2()
    {
        var sdk = new ShippoSDK();
        var shipment = await sdk.Shipments.CreateAsync(new ShipmentCreateRequest() { });
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Get the first rate in the rates results.
        // Customize this based on your business logic.
        Rate rate = shipment.Rates[0];
        Transaction transaction = await sdk.Transactions.CreateAsync(
            CreateTransactionRequestBody.CreateTransactionCreateRequest(
                new TransactionCreateRequest()
                {
                    Rate = rate.ObjectId,
                    LabelFileType = LabelFileTypeEnum.Pdf,
                    Async = false,
                }
            )
        );
        if (transaction.Status == TransactionStatusEnum.Success)
        {
            Console.WriteLine($"{transaction.LabelUrl}");
            Console.WriteLine($"{transaction.TrackingNumber}");
        }
        else
        {
            Console.WriteLine($"{transaction.Messages}");
        }
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    }
    private async void generate_shipping_label3()
    {
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // using Shippo;
        // using Shippo.Models.Components;
        ShippoSDK sdk = new ShippoSDK(apiKeyHeader: "<API_Token>");
        AddressFrom addressFrom = AddressFrom.CreateAddressCreateRequest(
            new AddressCreateRequest()
            {
                Name = "Shawn Ippotle",
                Company = "Shippo",
                Street1 = "215 Clayton St.",
                City = "San Francisco",
                State = "CA",
                Zip = "94117",
                Country = "US",
                Phone = "+1 555 341 9393",
                Email = "shippotle@shippo.com",
            }
        );
        AddressTo addressTo = AddressTo.CreateAddressCreateRequest(
            new AddressCreateRequest()
            {
                Name = "Mr Hippo",
                Street1 = "Broadway 1",
                City = "New York",
                State = "NY",
                Zip = "10007",
                Country = "US",
                Phone = "+1 555 341 9393",
                Email = "mrhippo@shippo.com",
                Metadata = "Priority Customer",
            }
        );
        Shippo.Models.Components.Parcels parcel = Shippo.Models.Components.Parcels.CreateParcelCreateRequest(
            new ParcelCreateRequest()
            {
                Length = "5",
                Width = "5",
                Height = "5",
                DistanceUnit = DistanceUnitEnum.In,
                Weight = "2",
                MassUnit = WeightUnitEnum.Lb,
            }
        );
        ShipmentCreateRequest shipmentCreateRequest = new ShipmentCreateRequest()
        {
            AddressFrom = addressFrom,
            AddressTo = addressTo,
            Parcels = new List<Shippo.Models.Components.Parcels>() { parcel },
        };
        Transaction transaction = await sdk.Transactions.CreateAsync(
            CreateTransactionRequestBody.CreateInstantTransactionCreateRequest(
                new InstantTransactionCreateRequest()
                {
                    Shipment = shipmentCreateRequest,
                    CarrierAccount = "b741b99f95e841639b54272834bc478c",
                    ServicelevelToken = ServiceLevelUSPSEnum.UspsPriority.Value(),
                }
            )
        );
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    }

    /// <remarks>
    /// https://docs.goshippo.com/docs/international_shipping/internationalshipping/#C
    /// </remarks>
    private async void internationalshipping1()
    {
        var sdk = new ShippoSDK();
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        CustomsItemCreateRequest customsItemCreateRequest = new CustomsItemCreateRequest()
        {
            Description = "T-Shirt",
            Quantity = 20,
            NetWeight = "1",
            MassUnit = WeightUnitEnum.Lb,
            ValueAmount = "200",
            ValueCurrency = "USD",
            OriginCountry = "US",
        };
        CustomsDeclaration customsDeclaration = await sdk.CustomsDeclarations.CreateAsync(
            new CustomsDeclarationCreateRequest()
            {
                ContentsType = CustomsDeclarationContentsTypeEnum.Merchandise,
                ContentsExplanation = "T-Shirt purchase",
                NonDeliveryOption = CustomsDeclarationNonDeliveryOptionEnum.Return,
                Certify = true,
                CertifySigner = "Simon Kreuz",
                Items = new List<CustomsItemCreateRequest>() { customsItemCreateRequest },
            }
        );
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    }
    private async void internationalshipping2()
    {
        ShippoSDK sdk = new ShippoSDK();
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Shipment shipment = await sdk.Shipments.CreateAsync(
            new ShipmentCreateRequest()
            {
                AddressFrom = AddressFrom.CreateStr("d799c2679e644279b59fe661ac8fa488"),
                AddressTo = AddressTo.CreateStr("42236bcf36214f62bcc6d7f12f02a849"),
                Parcels = new List<Shippo.Models.Components.Parcels>()
                {
                    Shippo.Models.Components.Parcels.CreateStr("7df2ecf8b4224763ab7c71fae7ec8274")
                },
                CustomsDeclaration = ShipmentCreateRequestCustomsDeclaration.CreateStr("b741b99f95e841639b54272834bc478c"),
                Async = false,
            }
        );
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    }
    private async void internationalshipping3()
    {
        var sdk = new ShippoSDK();
        var shipment = await sdk.Shipments.CreateAsync(new ShipmentCreateRequest() { });
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Get the first rate in the rates results.
        // Customize this based on your own business logic.
        Rate rate = shipment.Rates[0];
        Transaction transaction = await sdk.Transactions.CreateAsync(
            CreateTransactionRequestBody.CreateTransactionCreateRequest(
                new TransactionCreateRequest()
                {
                    Rate = rate.ObjectId,
                    LabelFileType = LabelFileTypeEnum.Pdf,
                    Async = false,
                }
            )
        );
        if (transaction.Status == TransactionStatusEnum.Success)
        {
            Console.WriteLine($"{transaction.LabelUrl}");
            Console.WriteLine($"{transaction.TrackingNumber}");
        }
        else
        {
            Console.WriteLine($"{transaction.Messages}");
        }
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    }

    /// <remarks>
    /// https://docs.goshippo.com/docs/manifests_and_pickups/manifestandscanforms/#C
    /// </remarks>
    private async void manifestandscanforms()
    {
        var sdk = new ShippoSDK();
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Manifest manifest = await sdk.Manifests.CreateAsync(
            new ManifestCreateRequest()
            {
                CarrierAccount = "b741b99f95e841639b54272834bc478c",
                AddressFrom = ManifestCreateRequestAddressFrom.CreateStr("28828839a2b04e208ac2aa4945fbca9a"),
                ShipmentDate = "2014-05-16T23:59:59Z",
                Transactions = new List<string> {
                    "64bba01845ef40d29374032599f22588",
                    "c169aa586a844cc49da00d0272b590e1",
                },
            }
        );
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    }

    /// <remarks>
    /// https://docs.goshippo.com/docs/shipments/multipieceshipment/#C
    /// </remarks>
    private async void multipieceshipment1()
    {
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // using Shippo;
        // using Shippo.Models.Components;
        ShippoSDK sdk = new ShippoSDK(apiKeyHeader: "<API_TOKEN>");
        AddressFrom addressFrom = AddressFrom.CreateAddressCreateRequest(
            new AddressCreateRequest()
            {
                Name = "Shawn Ippotle",
                Street1 = "215 Clayton St.",
                City = "San Francisco",
                State = "CA",
                Zip = "94117",
                Country = "US",
                Phone = "+1 555 341 9393",
                Email = "shippotle@shippo.com",
            }
        );
        AddressTo addressTo = AddressTo.CreateAddressCreateRequest(
            new AddressCreateRequest()
            {
                Name = "Mr Hippo",
                Street1 = "Broadway 1",
                City = "New York",
                State = "NY",
                Zip = "10007",
                Country = "US",
                Phone = "+1 555 341 9393",
                Email = "mrhippo@shippo.com",
            }
        );
        Shippo.Models.Components.Parcels parcel1 = Shippo.Models.Components.Parcels.CreateParcelCreateRequest(
            new ParcelCreateRequest()
            {
                Length = "5",
                Width = "5",
                Height = "5",
                DistanceUnit = DistanceUnitEnum.In,
                Weight = "2",
                MassUnit = WeightUnitEnum.Lb,
            }
        );
        Shippo.Models.Components.Parcels parcel2 = Shippo.Models.Components.Parcels.CreateParcelCreateRequest(
            new ParcelCreateRequest()
            {
                Length = "10",
                Width = "10",
                Height = "10",
                DistanceUnit = DistanceUnitEnum.In,
                Weight = "2",
                MassUnit = WeightUnitEnum.Lb,
            }
        );
        Shipment shipment = await sdk.Shipments.CreateAsync(
            shipmentCreateRequest: new ShipmentCreateRequest()
            {
                AddressFrom = addressFrom,
                AddressTo = addressTo,
                Parcels = new List<Shippo.Models.Components.Parcels>() { parcel1, parcel2 },
            }
        );
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    }
    private async void multipieceshipment2()
    {
        var sdk = new ShippoSDK();
        var shipment = await sdk.Shipments.CreateAsync(new ShipmentCreateRequest() { });
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Get the first rate in the rates results.
        // Customize this based on your business logic.
        Rate rate = shipment.Rates[0];
        Transaction transaction = await sdk.Transactions.CreateAsync(
            CreateTransactionRequestBody.CreateTransactionCreateRequest(
                new TransactionCreateRequest()
                {
                    Rate = rate.ObjectId,
                    LabelFileType = LabelFileTypeEnum.Pdf,
                }
            )
        );
        if (transaction.Status == TransactionStatusEnum.Success)
        {
            Console.WriteLine($"{transaction.LabelUrl}");
            Console.WriteLine($"{transaction.TrackingNumber}");
        }
        else
        {
            Console.WriteLine($"{transaction.Messages}");
        }
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    }

    /// <remarks>
    /// https://docs.goshippo.com/docs/billing_and_invoices/refundinglabels/#C
    /// </remarks>
    private async void refundinglabels()
    {
        var sdk = new ShippoSDK();
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Refund refund = await sdk.Refunds.CreateAsync(
            new RefundRequestBody()
            {
                Async = false,
                Transaction = "35ed59f23a514ecfa2faeaed93a00086",
            }
        );
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    }

    /// <remarks>
    /// https://docs.goshippo.com/docs/shipments/returns/#C
    /// </remarks>
    private async void returns1()
    {
        var sdk = new ShippoSDK();
        var addressFrom = AddressFrom.CreateAddressCreateRequest(new AddressCreateRequest() { });
        var addressTo = AddressTo.CreateAddressCreateRequest(new AddressCreateRequest() { });
        var parcel = Shippo.Models.Components.Parcels.CreateParcelCreateRequest(new ParcelCreateRequest() { });
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Shipment shipmentReturn = await sdk.Shipments.CreateAsync(
            new ShipmentCreateRequest()
            {
                AddressFrom = addressFrom,
                AddressTo = addressTo,
                Parcels = new List<Shippo.Models.Components.Parcels>() { parcel },
                Extra = new ShipmentExtra()
                {
                    IsReturn = true
                },
                Async = false,
            }
        );
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    }
    private async void returns2()
    {
        var sdk = new ShippoSDK();
        var addressFrom = AddressFrom.CreateAddressCreateRequest(new AddressCreateRequest() { });
        var addressTo = AddressTo.CreateAddressCreateRequest(new AddressCreateRequest() { });
        var addressReturn = AddressReturn.CreateAddressCreateRequest(new AddressCreateRequest() { });
        var parcel = Shippo.Models.Components.Parcels.CreateParcelCreateRequest(new ParcelCreateRequest() { });
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Create addressFrom, addressTo, addressReturn and parcel variables first
        Shipment shipmentReturn = await sdk.Shipments.CreateAsync(
            new ShipmentCreateRequest()
            {
                AddressFrom = addressFrom,
                AddressTo = addressTo,
                AddressReturn = addressReturn,
                Parcels = new List<Shippo.Models.Components.Parcels>() { parcel },
                Async = false,
            }
        );
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    }

    /// <remarks>
    /// https://docs.goshippo.com/docs/shipments/shippinginsurance/#C
    /// </remarks>
    private async void shippinginsurance1()
    {
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // using Shippo;
        // using Shippo.Models.Components;
        ShippoSDK sdk = new ShippoSDK(apiKeyHeader: "<API_Token>");
        AddressFrom addressFrom = AddressFrom.CreateAddressCreateRequest(
            new AddressCreateRequest()
            {
                Name = "Shawn Ippotle",
                Street1 = "215 Clayton St.",
                City = "San Francisco",
                State = "CA",
                Zip = "94117",
                Country = "US",
                Phone = "+1 555 341 9393",
                Email = "shippotle@shippo.com",
            }
        );
        AddressTo addressTo = AddressTo.CreateAddressCreateRequest(
            new AddressCreateRequest()
            {
                Name = "Mr Hippo",
                Street1 = "Broadway 1",
                City = "New York",
                State = "NY",
                Zip = "10007",
                Country = "US",
                Phone = "+1 555 341 9393",
                Email = "mrhippo@shippo.com",
            }
        );
        Shippo.Models.Components.Parcels parcel = Shippo.Models.Components.Parcels.CreateParcelCreateRequest(
            new ParcelCreateRequest()
            {
                Length = "5",
                Width = "5",
                Height = "5",
                DistanceUnit = DistanceUnitEnum.In,
                Weight = "2",
                MassUnit = WeightUnitEnum.Lb,
            }
        );
        Insurance insurance = new Insurance()
        {
            Amount = "200",
            Currency = "USD",
            Content = "t-shirts",
        };
        Shipment shipment = await sdk.Shipments.CreateAsync(
            new ShipmentCreateRequest()
            {
                AddressFrom = addressFrom,
                AddressTo = addressTo,
                Parcels = new List<Shippo.Models.Components.Parcels>() { parcel },
                Extra = new ShipmentExtra()
                {
                    Insurance = insurance,
                },
                Async = false,
            }
        );
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    }
    private async void shippinginsurance2()
    {
        var sdk = new ShippoSDK();
        var shipment = await sdk.Shipments.CreateAsync(new ShipmentCreateRequest() { });
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Transaction transaction = await sdk.Transactions.CreateAsync(
            CreateTransactionRequestBody.CreateTransactionCreateRequest(
                new TransactionCreateRequest()
                {
                    Rate = shipment.Rates[0].ObjectId,
                    LabelFileType = LabelFileTypeEnum.Pdf,
                    Async = false,
                }
            )
        );
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    }

    /// <remarks>
    /// https://docs.goshippo.com/docs/guides_general/single_call/#C
    /// </remarks>
    private async void single_call()
    {
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // using Shippo;
        // using Shippo.Models.Components;
        ShippoSDK sdk = new ShippoSDK(apiKeyHeader: "<API_Token>");
        AddressFrom addressFrom = AddressFrom.CreateAddressCreateRequest(
            new AddressCreateRequest()
            {
                Name = "Shawn Ippotle",
                Company = "Shippo",
                Street1 = "215 Clayton St.",
                City = "San Francisco",
                State = "CA",
                Zip = "94117",
                Country = "US",
                Phone = "+1 555 341 9393",
                Email = "shippotle@shippo.com",
            }
        );
        AddressTo addressTo = AddressTo.CreateAddressCreateRequest(
            new AddressCreateRequest()
            {
                Name = "Mr Hippo",
                Company = "",
                Street1 = "Broadway 1",
                Street2 = "",
                City = "New York",
                State = "NY",
                Zip = "10007",
                Country = "US",
                Phone = "+1 555 341 9393",
                Email = "mrhippo@shippo.com",
                Metadata = "Hippos dont lie",
            }
        );
        Shippo.Models.Components.Parcels parcel = Shippo.Models.Components.Parcels.CreateParcelCreateRequest(
            new ParcelCreateRequest()
            {
                Length = "5",
                Width = "5",
                Height = "5",
                DistanceUnit = DistanceUnitEnum.In,
                Weight = "2",
                MassUnit = WeightUnitEnum.Lb,
            }
        );
        ShipmentCreateRequest shipmentCreateRequest = new ShipmentCreateRequest()
        {
            AddressFrom = addressFrom,
            AddressTo = addressTo,
            Parcels = new List<Shippo.Models.Components.Parcels>() { parcel },
        };
        Transaction transaction = await sdk.Transactions.CreateAsync(
            CreateTransactionRequestBody.CreateInstantTransactionCreateRequest(
                new InstantTransactionCreateRequest()
                {
                    Shipment = shipmentCreateRequest,
                    CarrierAccount = "b741b99f95e841639b54272834bc478c",
                    ServicelevelToken = ServiceLevelUSPSEnum.UspsPriority.Value(),
                }
            )
        );
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    }

    /// <remarks>
    /// https://docs.goshippo.com/docs/guides_general/testing/#C
    /// </remarks>
    private async void testing()
    {
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // using Shippo;
        // using Shippo.Models.Components;
        ShippoSDK sdk = new ShippoSDK(apiKeyHeader: "<API_TOKEN>");
        Address address = await sdk.Addresses.CreateAsync(
            new AddressCreateRequest()
            {
                Name = "Shawn Ippotle",
                Company = "Shippo",
                Street1 = "215 Clayton St.",
                City = "San Francisco",
                State = "CA",
                Zip = "94117",
                Country = "US",
                Phone = "+1 555 341 9393",
                Email = "shippotle@shippo.com",
            }
        );
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    }
}
