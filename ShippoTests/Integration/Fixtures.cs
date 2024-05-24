namespace ShippoTests.Integration;

public class SDKFixture
{
    public SDKFixture()
    {
        SDK = new ShippoSDK(
            apiKeyHeader: Environment.GetEnvironmentVariable("SHIPPO_TOKEN"),
            serverUrl: Environment.GetEnvironmentVariable("SHIPPO_URL"),
            shippoApiVersion: Environment.GetEnvironmentVariable("SHIPPO_API_VERSION")
        );
    }

    public ShippoSDK SDK { get; private set; }
}

[CollectionDefinition("Integration")]
public class TestsCollection : ICollectionFixture<SDKFixture>
{
}
