namespace ShippoTests.Integration;

public class Helpers
{
    public async static Task<CarrierAccountWithExtraInfo?> GetCarrierAccount(
        ShippoSDK sdk, CarriersEnum carrier)
    {
        return (await GetCarrierAccounts(sdk, carrier))?[0];
    }

    public async static Task<List<CarrierAccountWithExtraInfo>?> GetCarrierAccounts(
        ShippoSDK sdk, CarriersEnum carrier)
    {
        return (await sdk.CarrierAccounts.ListAsync(
            new ListCarrierAccountsRequest()
            {
                Carrier = carrier
            }
        )).Results;
    }
}
