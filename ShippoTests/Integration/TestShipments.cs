namespace ShippoTests.Integration;

using Parcels = Shippo.Models.Components.Parcels;

[Collection("Integration")]
public class Shipments
{
    SDKFixture sdkFixture;

    public Shipments(SDKFixture sdkFixture)
    {
        this.sdkFixture = sdkFixture;
    }

    [Fact]
    public async void TestInternationalLabel()
    {
        var addressFromTask = sdkFixture.SDK.Addresses.CreateAsync(
            new AddressCreateRequest()
            {
                Name = "Sarah",
                Company = "We Sell Guitars",
                Street1 = "215 Clayton St.",
                City = "San Francisco",
                State = "CA",
                Zip = "94117",
                Country = "US",
                Phone = "+1 555 341 9393",
                Email = "sarah@wesellguitars.net",
                IsResidential = false,
                Metadata = "We Sell Guitars HQ",
            }
        );
        var customsDeclarationTask = sdkFixture.SDK.CustomsDeclarations.CreateAsync(
            new CustomsDeclarationCreateRequest()
            {
                ContentsType = CustomsDeclarationContentsTypeEnum.Merchandise,
                NonDeliveryOption = CustomsDeclarationNonDeliveryOptionEnum.Return,
                Certify = true,
                CertifySigner = "Tom Marks",
                Incoterm = CustomsDeclarationIncotermEnum.Ddp,
                Items = new List<CustomsItemCreateRequest>()
                {
                    new CustomsItemCreateRequest()
                    {
                        Description = "Guitar Pedal",
                        Quantity = 1,
                        NetWeight = "5",
                        MassUnit = WeightUnitEnum.Lb,
                        ValueAmount = "200",
                        ValueCurrency = "USD",
                        OriginCountry = "US",
                    }
                }
            }
        );
        await Task.WhenAll(addressFromTask, customsDeclarationTask);
        Address addressFrom = await addressFromTask;
        CustomsDeclaration customsDeclaration = await customsDeclarationTask;
        addressFrom.ObjectId.Should().NotBeNullOrEmpty();
        customsDeclaration.ObjectId.Should().NotBeNullOrEmpty();

        Shipment shipment = await sdkFixture.SDK.Shipments.CreateAsync(
            new ShipmentCreateRequest()
            {
                AddressFrom = AddressFrom.CreateStr(addressFrom.ObjectId!),
                AddressTo = AddressTo.CreateAddressCreateRequest(
                    new AddressCreateRequest()
                    {
                        Name = "Tom Marks",
                        Street1 = "159 Broadhurst Gardens",
                        City = "London",
                        Zip = "NW6 3AU",
                        Country = "GB",
                        Phone = "4159876543",
                        Email = "tommarks@gmmail.com",
                    }
                ),
                Parcels = new List<Parcels>()
                {
                    Parcels.CreateParcelCreateRequest(
                        new ParcelCreateRequest()
                        {
                            Weight = "5",
                            Length = "10",
                            Width = "5",
                            Height = "4",
                            DistanceUnit = DistanceUnitEnum.In,
                            MassUnit = WeightUnitEnum.Lb,
                        }
                    )
                },
                CustomsDeclaration = ShipmentCreateRequestCustomsDeclaration.CreateStr(
                    customsDeclaration.ObjectId!),
                Extra = new ShipmentExtra()
                {
                    Insurance = new Insurance()
                    {
                        Amount = "200",
                        Currency = "USD",
                        Content = "guitar pedal",
                    }
                },
            }
        );
        shipment.Should().NotBeNull();
    }
}
