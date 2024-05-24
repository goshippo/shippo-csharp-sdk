namespace ShippoTests.Unit;

using AuthenticationHeaderValue = System.Net.Http.Headers.AuthenticationHeaderValue;

public class Hooks
{
    [Theory]
    [InlineData(false)]
    [InlineData(false, $"{ShippoAuthBeforeRequestHook.SCHEME}", "shippo_test_12345")]
    [InlineData(false, "JWT", "eyJ12345")]
    [InlineData(true, "shippo_test_12345")]
    [InlineData(true, "shippo_live_12345")]
    public async void TestShippoAuthBeforeRequest(
        bool shouldAddPrefix, string? scheme = null, string? parameter = null)
    {
        ShippoAuthBeforeRequestHook hook = new ShippoAuthBeforeRequestHook();
        BeforeRequestContext hookCtx = new BeforeRequestContext(
            new HookContext("test", null, null));
        HttpRequestMessage request = new HttpRequestMessage();

        if (scheme == null)
        {
            request = await hook.BeforeRequestAsync(hookCtx, request);
            request.Headers.Authorization.Should().BeNull();
        }
        else
        {
            AuthenticationHeaderValue authHeader =
                new AuthenticationHeaderValue(scheme, parameter)!;
            request.Headers.Authorization = authHeader;
            request = await hook.BeforeRequestAsync(hookCtx, request);
            authHeader = request.Headers.Authorization!;
            authHeader.Should().NotBeNull();

            if (shouldAddPrefix)
            {
                authHeader.Scheme.Should().Be(ShippoAuthBeforeRequestHook.SCHEME);
                authHeader.Parameter.Should().Be(scheme);
            }
            else
            {
                authHeader.Scheme.Should().Be(scheme);
                authHeader.Parameter.Should().Be(parameter);
            }
        }
    }
}
