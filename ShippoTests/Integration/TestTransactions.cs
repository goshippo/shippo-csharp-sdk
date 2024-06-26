namespace ShippoTests.Integration;

using Parcels = Shippo.Models.Components.Parcels;

[Collection("Integration")]
public class Transactions
{
    SDKFixture sdkFixture;

    public Transactions(SDKFixture sdkFixture)
    {
        this.sdkFixture = sdkFixture;
    }

    [Fact]
    public async void TestInstalabel()
    {
        CarrierAccountWithExtraInfo carrierAccount = (
            await Helpers.GetCarrierAccount(sdkFixture.SDK, CarriersEnum.Usps)
        )!;
        carrierAccount.Should().NotBeNull();
        string carrierAccountObjectId = carrierAccount.ObjectId!;
        carrierAccountObjectId.Should().NotBeNull();

        var servicelevelToken = ServiceLevelUSPSEnum.UspsGroundAdvantage.Value();

        Transaction transaction =
            await sdkFixture.SDK.Transactions.CreateAsync(
            CreateTransactionRequestBody.CreateInstantTransactionCreateRequest(
                new InstantTransactionCreateRequest()
                {
                    CarrierAccount = carrierAccountObjectId,
                    ServicelevelToken = servicelevelToken,
                    Shipment = new ShipmentCreateRequest()
                    {
                        AddressFrom = AddressFrom.CreateAddressCreateRequest(
                            new AddressCreateRequest()
                            {
                                Name = "Rachael",
                                Street1 = "1092 Indian Summer Ct",
                                City = "San Jose",
                                State = "CA",
                                Zip = "95122",
                                Country = "US",
                                Phone = "4159876543",
                                Email = "rachael@alltheyarnz.com",
                            }
                        ),
                        AddressTo = AddressTo.CreateAddressCreateRequest(
                            new AddressCreateRequest()
                            {
                                Name = "Mr Hippo",
                                Street1 = "965 Mission St #572",
                                City = "San Francisco",
                                State = "CA",
                                Zip = "94103",
                                Country = "US",
                                Phone = "4151234567",
                                Email = "mrhippo@shippo.com",
                            }
                        ),
                        Parcels = new List<Parcels>()
                        {
                            Parcels.CreateParcelCreateRequest(
                                new ParcelCreateRequest()
                                {
                                    Length = "5",
                                    Width = "5",
                                    Height = "5",
                                    DistanceUnit = DistanceUnitEnum.Cm,
                                    Weight = "2",
                                    MassUnit = WeightUnitEnum.Lb,
                                }
                            )
                        },
                    },
                }
            )
        );
        transaction.Should().NotBeNull();
        transaction.Rate.Should().NotBeNull();
    }

    [Fact]
    public async void TestTwoStepLabelSingleCall()
    {
        Shipment shipment = await sdkFixture.SDK.Shipments.CreateAsync(
            new ShipmentCreateRequest()
            {
                AddressFrom = AddressFrom.CreateAddressCreateRequest(
                    new AddressCreateRequest()
                    {
                        Name = "Rachael",
                        Street1 = "1092 Indian Summer Ct",
                        City = "San Jose",
                        State = "CA",
                        Zip = "95122",
                        Country = "US",
                        Phone = "4159876543",
                        Email = "rachael@alltheyarnz.com",
                    }
                ),
                AddressTo = AddressTo.CreateAddressCreateRequest(
                    new AddressCreateRequest()
                    {
                        Name = "Mr Hippo",
                        Street1 = "965 Mission St #572",
                        City = "San Francisco",
                        State = "CA",
                        Zip = "94103",
                        Country = "US",
                        Phone = "4151234567",
                        Email = "mrhippo@shippo.com",
                    }
                ),
                Parcels = new List<Parcels>()
                {
                    Parcels.CreateParcelCreateRequest(
                        new ParcelCreateRequest()
                        {
                            Length = "5",
                            Width = "5",
                            Height = "5",
                            DistanceUnit = DistanceUnitEnum.Cm,
                            Weight = "2",
                            MassUnit = WeightUnitEnum.Lb,
                        }
                    )
                },
            }
        );
        shipment.Should().NotBeNull();
        shipment.Rates[0].ObjectId.Should().NotBeNullOrEmpty();

        Transaction transaction =
            await sdkFixture.SDK.Transactions.CreateAsync(
            CreateTransactionRequestBody.CreateTransactionCreateRequest(
                new TransactionCreateRequest()
                {
                    Rate = shipment.Rates[0].ObjectId,
                }
            )
        );
        transaction.Should().NotBeNull();
    }

    [Fact]
    public async void TestTwoStepLabelWithReferenceIds()
    {
        var addressFromTask = sdkFixture.SDK.Addresses.CreateAsync(
            new AddressCreateRequest()
            {
                Name = "Rachael",
                Street1 = "1092 Indian Summer Ct",
                City = "San Jose",
                State = "CA",
                Zip = "95122",
                Country = "US",
                Phone = "4159876543",
                Email = "rachael@alltheyarnz.com",
            }
        );
        var addressToTask = sdkFixture.SDK.Addresses.CreateAsync(
            new AddressCreateRequest()
            {
                Name = "Mr Hippo",
                Street1 = "965 Mission St #572",
                City = "San Francisco",
                State = "CA",
                Zip = "94103",
                Country = "US",
                Phone = "4151234567",
                Email = "mrhippo@shippo.com",
            }
        );
        var parcelTask = sdkFixture.SDK.Parcels.CreateAsync(
            CreateParcelRequestBody.CreateParcelCreateRequest(
                new ParcelCreateRequest()
                {
                    Length = "5",
                    Width = "5",
                    Height = "5",
                    DistanceUnit = DistanceUnitEnum.Cm,
                    Weight = "2",
                    MassUnit = WeightUnitEnum.Lb,
                    Metadata = "Wool Box1",
                }
            )
        );
        await Task.WhenAll(addressFromTask, addressToTask, parcelTask);
        Address addressFrom = await addressFromTask;
        Address addressTo = await addressToTask;
        Parcel parcel = await parcelTask;
        addressFrom.ObjectId.Should().NotBeNullOrEmpty();
        addressTo.ObjectId.Should().NotBeNullOrEmpty();
        parcel.ObjectId.Should().NotBeNullOrEmpty();

        Shipment shipment = await sdkFixture.SDK.Shipments.CreateAsync(
            new ShipmentCreateRequest()
            {
                AddressFrom = AddressFrom.CreateStr(addressFrom.ObjectId!),
                AddressReturn = AddressReturn.CreateStr(addressFrom.ObjectId!),
                AddressTo = AddressTo.CreateStr(addressTo.ObjectId!),
                Parcels = new List<Parcels>()
                {
                    Parcels.CreateStr(parcel.ObjectId!)
                },
            }
        );
        shipment.Should().NotBeNull();

        shipment.AddressFrom.ObjectId.Should().Be(addressFrom.ObjectId);
        shipment.AddressTo.ObjectId.Should().Be(addressTo.ObjectId);
        shipment.AddressReturn!.ObjectId.Should().Be(addressFrom.ObjectId);
        shipment.Rates[0].ObjectId.Should().NotBeNullOrEmpty();

        Transaction transaction =
            await sdkFixture.SDK.Transactions.CreateAsync(
            CreateTransactionRequestBody.CreateTransactionCreateRequest(
                new TransactionCreateRequest()
                {
                    Rate = shipment.Rates[0].ObjectId,
                }
            )
        );
        transaction.Should().NotBeNull();
        transaction.Rate.Should().NotBeNull();
    }
}
