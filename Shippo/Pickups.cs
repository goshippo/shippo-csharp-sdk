//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Shippo
{
    using Newtonsoft.Json;
    using Shippo.Hooks;
    using Shippo.Models.Components;
    using Shippo.Models.Errors;
    using Shippo.Models.Requests;
    using Shippo.Utils.Retries;
    using Shippo.Utils;
    using System.Collections.Generic;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// A pickup is when you schedule a carrier to collect a package for delivery.<br/>
    /// 
    /// <remarks>
    /// Use Shippo’s pickups endpoint to schedule pickups with USPS and DHL Express for eligible shipments that you have already created.<br/>
    /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/Pickup&quot;/&gt;
    /// </remarks>
    /// </summary>
    public interface IPickups
    {

        /// <summary>
        /// Create a pickup
        /// 
        /// <remarks>
        /// Creates a pickup object. This request is for a carrier to come to a specified location to take a package for shipping.
        /// </remarks>
        /// </summary>
        Task<Pickup> CreateAsync(PickupBase pickupBase, string? shippoApiVersion = null);
    }

    /// <summary>
    /// A pickup is when you schedule a carrier to collect a package for delivery.<br/>
    /// 
    /// <remarks>
    /// Use Shippo’s pickups endpoint to schedule pickups with USPS and DHL Express for eligible shipments that you have already created.<br/>
    /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/Pickup&quot;/&gt;
    /// </remarks>
    /// </summary>
    public class Pickups: IPickups
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "4.0.1";
        private const string _sdkGenVersion = "2.339.1";
        private const string _openapiDocVersion = "2018-02-08";
        private const string _userAgent = "speakeasy-sdk/csharp 4.0.1 2.339.1 2018-02-08 Shippo";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _client;
        private Func<Security>? _securitySource;

        public Pickups(ISpeakeasyHttpClient client, Func<Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<Pickup> CreateAsync(PickupBase pickupBase, string? shippoApiVersion = null)
        {
            var request = new CreatePickupRequest()
            {
                PickupBase = pickupBase,
                ShippoApiVersion = shippoApiVersion,
            };
            request.ShippoApiVersion ??= SDKConfiguration.ShippoApiVersion;
            
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();

            var urlString = baseUrl + "/pickups";

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);

            var serializedBody = RequestBodySerializer.Serialize(request, "PickupBase", "json", false, false);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("CreatePickup", null, _securitySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await _client.SendAsync(httpRequest);
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode == 400 || _statusCode >= 400 && _statusCode < 500 || _statusCode >= 500 && _statusCode < 600)
                {
                    var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), httpResponse, null);
                    if (_httpResponse != null)
                    {
                        httpResponse = _httpResponse;
                    }
                }
            }
            catch (Exception error)
            {
                var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), null, error);
                if (_httpResponse != null)
                {
                    httpResponse = _httpResponse;
                }
                else
                {
                    throw;
                }
            }

            httpResponse = await this.SDKConfiguration.Hooks.AfterSuccessAsync(new AfterSuccessContext(hookCtx), httpResponse);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            int responseStatusCode = (int)httpResponse.StatusCode;
            if(responseStatusCode == 201)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<Pickup>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    return obj!;
                }
                throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode == 400 || responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else
            {
                throw new SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
        }
    }
}