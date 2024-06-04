namespace Shippo.Hooks;

using AuthenticationHeaderValue = System.Net.Http.Headers.AuthenticationHeaderValue;
using HttpRequestMessage = System.Net.Http.HttpRequestMessage;
using Task = System.Threading.Tasks.Task;
using TaskHttpRequestMessage =
    System.Threading.Tasks.Task<System.Net.Http.HttpRequestMessage>;

/// <summary>
/// Hook Registration File.
/// </summary>

public class ShippoAuthBeforeRequestHook : IBeforeRequestHook
{
    public const string SCHEME = "ShippoToken";

    public async TaskHttpRequestMessage BeforeRequestAsync(
        BeforeRequestContext hookCtx, HttpRequestMessage request)
    {
        return await Task.Run(() =>
        {
            string scheme = request.Headers.Authorization?.Scheme ?? "";
            if (scheme.StartsWith("shippo_"))
            {
                request.Headers.Authorization =
                    new AuthenticationHeaderValue(SCHEME, scheme);
            }
            return request;
        });
    }
}

public static class HookRegistration
{
    /// <summary>
    /// Initializes hooks.
    /// </summary>
    public static void InitHooks(IHooks hooks)
    {
        hooks.RegisterBeforeRequestHook(new ShippoAuthBeforeRequestHook());
    }
}
