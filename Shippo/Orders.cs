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
    /// An order is a request from a customer to purchase goods from a merchant. <br/>
    /// 
    /// <remarks>
    /// Use the orders object to load orders from your system to the Shippo dashboard.<br/>
    /// You can use the orders object to create, retrieve, list, and manage orders programmatically. <br/>
    /// You can also retrieve shipping rates, purchase labels, and track shipments for each order.<br/>
    /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/Order&quot;/&gt;<br/>
    /// <br/>
    /// # Line Item<br/>
    /// &lt;p style=&quot;text-align: center; background-color: #F2F3F4;&quot;&gt;<br/>
    ///   &lt;/br&gt;Line Items, and their corresponding abstract Products and Variants, might be exposed as a separate resource <br/>
    ///   in the future. Currently it&apos;s a nested object within the order resource.&lt;/br&gt;&lt;/br&gt;<br/>
    /// &lt;/p&gt;<br/>
    ///  A line item is an individual object in an order. For example, if your order contains a t-shirt, shorts, and a jacket, each item is represented by a line item.<br/>
    /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/LineItem&quot;/&gt;
    /// </remarks>
    /// </summary>
    public interface IOrders
    {

        /// <summary>
        /// List all orders
        /// 
        /// <remarks>
        /// Returns a list of all order objects.
        /// </remarks>
        /// </summary>
        Task<ListOrdersResponse> ListAsync(long? page = null, long? results = null, string? shippoApiVersion = null);

        /// <summary>
        /// Create a new order
        /// 
        /// <remarks>
        /// Creates a new order object.
        /// </remarks>
        /// </summary>
        Task<CreateOrderResponse> CreateAsync(OrderCreateRequest orderCreateRequest, string? shippoApiVersion = null);

        /// <summary>
        /// Retrieve an order
        /// 
        /// <remarks>
        /// Retrieves an existing order using an object ID.
        /// </remarks>
        /// </summary>
        Task<GetOrderResponse> GetAsync(string orderId, string? shippoApiVersion = null);
    }

    /// <summary>
    /// An order is a request from a customer to purchase goods from a merchant. <br/>
    /// 
    /// <remarks>
    /// Use the orders object to load orders from your system to the Shippo dashboard.<br/>
    /// You can use the orders object to create, retrieve, list, and manage orders programmatically. <br/>
    /// You can also retrieve shipping rates, purchase labels, and track shipments for each order.<br/>
    /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/Order&quot;/&gt;<br/>
    /// <br/>
    /// # Line Item<br/>
    /// &lt;p style=&quot;text-align: center; background-color: #F2F3F4;&quot;&gt;<br/>
    ///   &lt;/br&gt;Line Items, and their corresponding abstract Products and Variants, might be exposed as a separate resource <br/>
    ///   in the future. Currently it&apos;s a nested object within the order resource.&lt;/br&gt;&lt;/br&gt;<br/>
    /// &lt;/p&gt;<br/>
    ///  A line item is an individual object in an order. For example, if your order contains a t-shirt, shorts, and a jacket, each item is represented by a line item.<br/>
    /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/LineItem&quot;/&gt;
    /// </remarks>
    /// </summary>
    public class Orders: IOrders
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.0.1";
        private const string _sdkGenVersion = "2.335.5";
        private const string _openapiDocVersion = "2018-02-08";
        private const string _userAgent = "speakeasy-sdk/csharp 0.0.1 2.335.5 2018-02-08 Shippo";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private Func<Security>? _securitySource;

        public Orders(ISpeakeasyHttpClient defaultClient, Func<Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<ListOrdersResponse> ListAsync(long? page = null, long? results = null, string? shippoApiVersion = null)
        {
            var request = new ListOrdersRequest()
            {
                Page = page,
                Results = results,
                ShippoApiVersion = shippoApiVersion,
            };
            request.ShippoApiVersion ??= SDKConfiguration.ShippoApiVersion;
            
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/orders", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("ListOrders", null, _securitySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await _defaultClient.SendAsync(httpRequest);
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
                    var obj = ResponseBodyDeserializer.Deserialize<OrderPaginatedList>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new ListOrdersResponse()
                    {
                      HttpMeta = new Models.Components.HTTPMetadata()
                        {
                            Response = httpResponse,
                            Request = httpRequest
                        }
                    };
                    response.OrderPaginatedList = obj;
                    return response;
                }
                else
                {
                    throw new SDKException("Unknown content type received", httpRequest, httpResponse);
                }
            }
            else if(responseStatusCode == 400 || responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new SDKException("API error occurred", httpRequest, httpResponse);
            }
            else
            {
                throw new SDKException("Unknown status code received", httpRequest, httpResponse);
            }
        }

        public async Task<CreateOrderResponse> CreateAsync(OrderCreateRequest orderCreateRequest, string? shippoApiVersion = null)
        {
            var request = new CreateOrderRequest()
            {
                OrderCreateRequest = orderCreateRequest,
                ShippoApiVersion = shippoApiVersion,
            };
            request.ShippoApiVersion ??= SDKConfiguration.ShippoApiVersion;
            
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();

            var urlString = baseUrl + "/orders";

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);

            var serializedBody = RequestBodySerializer.Serialize(request, "OrderCreateRequest", "json", false, false);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("CreateOrder", null, _securitySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await _defaultClient.SendAsync(httpRequest);
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
                    var obj = ResponseBodyDeserializer.Deserialize<Order>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new CreateOrderResponse()
                    {
                      HttpMeta = new Models.Components.HTTPMetadata()
                        {
                            Response = httpResponse,
                            Request = httpRequest
                        }
                    };
                    response.Order = obj;
                    return response;
                }
                else
                {
                    throw new SDKException("Unknown content type received", httpRequest, httpResponse);
                }
            }
            else if(responseStatusCode == 400 || responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new SDKException("API error occurred", httpRequest, httpResponse);
            }
            else
            {
                throw new SDKException("Unknown status code received", httpRequest, httpResponse);
            }
        }

        public async Task<GetOrderResponse> GetAsync(string orderId, string? shippoApiVersion = null)
        {
            var request = new GetOrderRequest()
            {
                OrderId = orderId,
                ShippoApiVersion = shippoApiVersion,
            };
            request.ShippoApiVersion ??= SDKConfiguration.ShippoApiVersion;
            
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/orders/{OrderId}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("GetOrder", null, _securitySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await _defaultClient.SendAsync(httpRequest);
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
                    var obj = ResponseBodyDeserializer.Deserialize<Order>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new GetOrderResponse()
                    {
                      HttpMeta = new Models.Components.HTTPMetadata()
                        {
                            Response = httpResponse,
                            Request = httpRequest
                        }
                    };
                    response.Order = obj;
                    return response;
                }
                else
                {
                    throw new SDKException("Unknown content type received", httpRequest, httpResponse);
                }
            }
            else if(responseStatusCode == 400 || responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new SDKException("API error occurred", httpRequest, httpResponse);
            }
            else
            {
                throw new SDKException("Unknown status code received", httpRequest, httpResponse);
            }
        }
    }
}