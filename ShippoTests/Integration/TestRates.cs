namespace ShippoTests.Integration;

public class SetupFixture
{
    public SetupFixture()
    {
        Initialization = DeleteAllServiceGroups();
    }

    public Task Initialization { get; private set; }

    async Task DeleteAllServiceGroups()
    {
        ShippoSDK sdk = new SDKFixture().SDK;
        List<ServiceGroup> serviceGroups = await sdk.ServiceGroups.ListAsync();
        await Task.WhenAll(
            serviceGroups.Select(
                async serviceGroup => await
                    sdk.ServiceGroups.DeleteAsync(serviceGroup.ObjectId)
            ).ToList()
        );
    }
}

[Collection("Integration")]
public class Rates : IClassFixture<SetupFixture>
{
    SDKFixture sdkFixture;
    SetupFixture setupFixture;

    public Rates(SDKFixture sdkFixture, SetupFixture setupFixture)
    {
        this.sdkFixture = sdkFixture;
        this.setupFixture = setupFixture;
    }

    [Fact]
    public async void TestAtCheckout()
    {
        await setupFixture.Initialization;

        CarrierAccountWithExtraInfo carrierAccount = (
            await Helpers.GetCarrierAccount(sdkFixture.SDK, CarriersEnum.Ups)
        )!;
        carrierAccount.Should().NotBeNull();
        string accountId = carrierAccount.ObjectId!;
        accountId.Should().NotBeNullOrEmpty();

        List<ServiceLevelUPSEnum> availableServiceLevels = new List<ServiceLevelUPSEnum>
        {
            ServiceLevelUPSEnum.UpsGround, ServiceLevelUPSEnum.UpsNextDayAirSaver
        };

        List<ServiceGroupAccountAndServiceLevel> serviceLevels =
            availableServiceLevels.Select(
            availableServiceLevel => new ServiceGroupAccountAndServiceLevel()
            {
                AccountObjectId = accountId,
                ServiceLevelToken = availableServiceLevel.Value(),
            }
        ).ToList();

        ServiceGroup serviceGroup = await sdkFixture.SDK.ServiceGroups.CreateAsync(
            new ServiceGroupCreateRequest()
            {
                Name = "UPS shipping",
                Description = "UPS shipping options",
                FlatRate = "5",
                FlatRateCurrency = "USD",
                Type = ServiceGroupTypeEnum.LiveRate,
                ServiceLevels = serviceLevels,
            }
        );
        serviceGroup.Should().NotBeNull();

        LiveRatePaginatedList liveRates =
            await sdkFixture.SDK.RatesAtCheckout.CreateAsync(
            new LiveRateCreateRequest()
            {
                AddressFrom =
                LiveRateCreateRequestAddressFrom.CreateAddressCompleteCreateRequest(
                    new AddressCompleteCreateRequest()
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
                AddressTo =
                LiveRateCreateRequestAddressTo.CreateAddressCompleteCreateRequest(
                    new AddressCompleteCreateRequest()
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
                LineItems = new List<LineItem>()
                {
                    new LineItem()
                    {
                        Quantity = 1,
                        TotalPrice = "12.00",
                        Currency = "USD",
                        Weight = "1.0",
                        WeightUnit = WeightUnitEnum.Lb,
                        Title = "Hippo Snax",
                        ManufactureCountry = "US",
                        Sku = "HM-123",
                    }
                },
                Parcel = LiveRateCreateRequestParcel.CreateParcel(
                    new Parcel()
                    {
                        Length = "10",
                        Width = "15",
                        Height = "10",
                        DistanceUnit = DistanceUnitEnum.In,
                        Weight = "1",
                        MassUnit = WeightUnitEnum.Lb,
                    }
                ),
            }
        );
        liveRates.Should().NotBeNull();
        liveRates.Results.Should().NotBeNullOrEmpty();
        foreach (LiveRate liveRate in liveRates.Results!)
        {
            liveRate.Title.Should().Be(serviceGroup.Name);
        }
    }
}
