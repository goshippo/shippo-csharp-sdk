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

public class TestHttpClient : SpeakeasyHttpClient
{
    public TestHttpClient() : base()
    {
    }

    private JsonSerializerOptions serializerOptions = new JsonSerializerOptions()
    {
        WriteIndented = true
    };

    private string delimiter = new string('~', 79);

    public override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
    {
        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.AppendLine(delimiter);
        stringBuilder.AppendLine("request:");
        stringBuilder.AppendLine(request.ToString());
        if ((request.Content != null) && (request.Content!.Headers.ContentLength > 0))
        {
            stringBuilder.AppendLine("content:");
            string content = await request.Content.ReadAsStringAsync();
            if (request.Content!.Headers.ContentType?.MediaType == "application/json")
            {
                try
                {
                    content = JsonSerializer.Serialize(
                        JsonDocument.Parse(content), serializerOptions);
                }
                catch (JsonException e)
                {
                    stringBuilder.AppendLine($"-- ERROR: {e.Message}");
                }
            }
            stringBuilder.AppendLine(content);
        }

        HttpResponseMessage response = await base.SendAsync(request);

        stringBuilder.AppendLine("response:");
        stringBuilder.AppendLine(response.ToString());
        if ((response.Content != null) && (response.Content!.Headers.ContentLength > 0))
        {
            stringBuilder.AppendLine("content:");
            string content = await response.Content.ReadAsStringAsync();
            if (response.Content!.Headers.ContentType?.MediaType == "application/json")
            {
                try
                {
                    content = JsonSerializer.Serialize(
                        JsonDocument.Parse(content), serializerOptions);
                }
                catch (JsonException e)
                {
                    stringBuilder.AppendLine($"-- ERROR: {e.Message}");
                }
            }
            stringBuilder.AppendLine(content);
        }

        stringBuilder.AppendLine(delimiter);
        Console.Write(stringBuilder.ToString());

        return response;
    }
}
