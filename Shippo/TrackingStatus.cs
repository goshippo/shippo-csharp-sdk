//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
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
    /// &lt;p style=&quot;text-align: center; background-color: #F2F3F4;&quot;&gt;&lt;/br&gt;<br/>
    /// 
    /// <remarks>
    /// If you purchased your shipping label through Shippo, you can also get all the tracking details of your Shipment <br/>
    /// from the &lt;a href=&quot;#tag/Transactions&quot;&gt;Transaction&lt;/a&gt; object.<br/>
    /// &lt;/br&gt;&lt;/br&gt;&lt;/p&gt;<br/>
    /// A tracking status of a package is an indication of current location of a package in the supply chain. For example,  sorting, warehousing, or out for delivery. Use the tracking status object to track the location of your shipments.<br/>
    /// <br/>
    /// When using your &lt;a href=&quot;https://docs.goshippo.com/docs/guides_general/authentication/&quot;&gt;Test&lt;/a&gt; token for tracking, you need to use Shippo&apos;s <br/>
    /// predefined tokens for testing different tracking statuses. You can find more information in our <br/>
    /// &lt;a href=&quot;https://docs.goshippo.com/docs/tracking/tracking/&quot;&gt;Tracking tutorial&lt;/a&gt; on how to do this, and what the <br/>
    /// payloads look like.      <br/>
    /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/Track&quot;/&gt;
    /// </remarks>
    /// </summary>
    public interface ITrackingStatus
    {

        /// <summary>
        /// Register a tracking webhook
        /// 
        /// <remarks>
        /// Registers a webhook that will send HTTP notifications to you when the status of your tracked package changes. For more details on creating a webhook, see our guides on &lt;a href=&quot;https://docs.goshippo.com/docs/tracking/webhooks/&quot;&gt;Webhooks&lt;/a&gt; and &lt;a href=&quot;https://docs.goshippo.com/docs/tracking/tracking/&quot;&gt;Tracking&lt;/a&gt;.
        /// </remarks>
        /// </summary>
        Task<Track> CreateAsync(TracksRequest tracksRequest, string? shippoApiVersion = null);

        /// <summary>
        /// Get a tracking status
        /// 
        /// <remarks>
        /// Returns the tracking status of a shipment using a carrier name and a tracking number.
        /// </remarks>
        /// </summary>
        Task<Track> GetAsync(string trackingNumber, string carrier, string? shippoApiVersion = null);
    }

    /// <summary>
    /// &lt;p style=&quot;text-align: center; background-color: #F2F3F4;&quot;&gt;&lt;/br&gt;<br/>
    /// 
    /// <remarks>
    /// If you purchased your shipping label through Shippo, you can also get all the tracking details of your Shipment <br/>
    /// from the &lt;a href=&quot;#tag/Transactions&quot;&gt;Transaction&lt;/a&gt; object.<br/>
    /// &lt;/br&gt;&lt;/br&gt;&lt;/p&gt;<br/>
    /// A tracking status of a package is an indication of current location of a package in the supply chain. For example,  sorting, warehousing, or out for delivery. Use the tracking status object to track the location of your shipments.<br/>
    /// <br/>
    /// When using your &lt;a href=&quot;https://docs.goshippo.com/docs/guides_general/authentication/&quot;&gt;Test&lt;/a&gt; token for tracking, you need to use Shippo&apos;s <br/>
    /// predefined tokens for testing different tracking statuses. You can find more information in our <br/>
    /// &lt;a href=&quot;https://docs.goshippo.com/docs/tracking/tracking/&quot;&gt;Tracking tutorial&lt;/a&gt; on how to do this, and what the <br/>
    /// payloads look like.      <br/>
    /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/Track&quot;/&gt;
    /// </remarks>
    /// </summary>
    public class TrackingStatus: ITrackingStatus
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "5.0.0-beta.5";
        private const string _sdkGenVersion = "2.421.3";
        private const string _openapiDocVersion = "2018-02-08";
        private const string _userAgent = "speakeasy-sdk/csharp 5.0.0-beta.5 2.421.3 2018-02-08 Shippo";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _client;
        private Func<Shippo.Models.Components.Security>? _securitySource;

        public TrackingStatus(ISpeakeasyHttpClient client, Func<Shippo.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<Track> CreateAsync(TracksRequest tracksRequest, string? shippoApiVersion = null)
        {
            var request = new CreateTrackRequest()
            {
                TracksRequest = tracksRequest,
                ShippoApiVersion = shippoApiVersion,
            };
            request.ShippoApiVersion ??= SDKConfiguration.ShippoApiVersion;
            
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();

            var urlString = baseUrl + "/tracks";

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);

            var serializedBody = RequestBodySerializer.Serialize(request, "TracksRequest", "json", false, false);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("CreateTrack", null, _securitySource);

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
            if(responseStatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<Track>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    return obj!;
                }

                throw new Models.Errors.SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode == 400 || responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new Models.Errors.SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }

            throw new Models.Errors.SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
        }

        public async Task<Track> GetAsync(string trackingNumber, string carrier, string? shippoApiVersion = null)
        {
            var request = new GetTrackRequest()
            {
                TrackingNumber = trackingNumber,
                Carrier = carrier,
                ShippoApiVersion = shippoApiVersion,
            };
            request.ShippoApiVersion ??= SDKConfiguration.ShippoApiVersion;
            
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/tracks/{Carrier}/{TrackingNumber}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("GetTrack", null, _securitySource);

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
            if(responseStatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<Track>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    return obj!;
                }

                throw new Models.Errors.SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode == 400 || responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new Models.Errors.SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }

            throw new Models.Errors.SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
        }
    }
}