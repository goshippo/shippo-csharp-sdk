namespace Shippo.Hooks;

using AuthenticationHeaderValue = System.Net.Http.Headers.AuthenticationHeaderValue;
using HttpRequestMessage = System.Net.Http.HttpRequestMessage;
using System.Threading.Tasks;

/// <summary>
/// Hook Registration File.
/// </summary>
/// <remarks>
/// This file is only ever generated once on the first generation and then is free to be modified.
/// Any hooks you wish to add should be registered in the InitHooks function. Feel free to define them
/// in this file or in separate files in the Hooks folder.
/// </remarks>

public class ShippoAuthBeforeRequestHook : IBeforeRequestHook
{
    public const string SCHEME = "ShippoToken";

    public async Task<HttpRequestMessage> BeforeRequestAsync(
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
    /// <remarks>
    /// Add hooks by calling `Shippo.Hooks.Register&lt;HookInterface&gt;(myHook);`
    /// where `I&lt;HookInterface&gt;` is one of the following interfaces defined in HookTypes.cs:
    ///   - ISDKInitHook
    ///   - IBeforeRequestHook
    ///   - IAfterSuccess
    ///   - IAfterError
    /// and `myHook` an instance that implements that specific interface.
    /// </remarks>
    public static void InitHooks(IHooks hooks)
    {
        hooks.RegisterBeforeRequestHook(new ShippoAuthBeforeRequestHook());
    }
}
