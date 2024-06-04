namespace ShippoTests.Integration;

public class SDKFixture
{
    public ShippoSDK SDK { get; private set; }

    public SDKFixture()
    {
        SDK = new ShippoSDK(
            apiKeyHeader: Environment.GetEnvironmentVariable("SHIPPO_TOKEN"),
            serverUrl: Environment.GetEnvironmentVariable("SHIPPO_URL"),
            shippoApiVersion: Environment.GetEnvironmentVariable("SHIPPO_API_VERSION")
        );
    }
}

[CollectionDefinition("Integration")]
public class TestsCollection : ICollectionFixture<SDKFixture>
{
}
