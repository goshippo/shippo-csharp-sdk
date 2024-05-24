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
    using Shippo.Utils.Retries;
    using Shippo.Utils;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// Shippo external API.: Use this API to integrate with the Shippo service
    /// </summary>
    public interface IShippoSDK
    {

        /// <summary>
        /// Addresses are the locations a parcel is being shipped **from** and **to**. They represent company and residential places. Among other things, you can use address objects to create shipments, calculate shipping rates, and purchase shipping labels.<br/>
        /// 
        /// <remarks>
        /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/Address&quot;/&gt;
        /// </remarks>
        /// </summary>
        public IAddresses Addresses { get; }

        /// <summary>
        /// A batch is a technique for creating multiple labels at once. Use the  batch object to create and purchase many shipments in two API calls. After creating the batch, retrieve the batch to verify that all shipments are valid. You can add and remove shipments after you have created the batch. When all shipments are valid you can purchase the batch and retrieve all the shipping labels.<br/>
        /// 
        /// <remarks>
        /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/Batch&quot;/&gt;<br/>
        /// <br/>
        /// # Batch Shipment<br/>
        /// The batch shipment object is a wrapper around a shipment object, which include shipment-specific information <br/>
        /// for batch processing.<br/>
        /// <br/>
        /// Note: batch shipments can only be created on the batch endpoint, either when creating a batch object or by through <br/>
        /// the `/batches/{BATCH_OBJECT_ID}/add_shipments` endpoint<br/>
        /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/BatchShipment&quot;/&gt;
        /// </remarks>
        /// </summary>
        public IBatches Batches { get; }

        /// <summary>
        /// Carriers are the companies who deliver your package. Shippo uses Carrier account objects as credentials to retrieve shipping rates and purchase labels from shipping Carriers.<br/>
        /// 
        /// <remarks>
        /// <br/>
        /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/CarrierAccount&quot;/&gt;
        /// </remarks>
        /// </summary>
        public ICarrierAccounts CarrierAccounts { get; }

        /// <summary>
        /// Customs declarations are relevant information, including one or multiple customs items, you need to provide for <br/>
        /// 
        /// <remarks>
        /// customs clearance for your international shipments.<br/>
        /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/CustomsDeclaration&quot;/&gt;
        /// </remarks>
        /// </summary>
        public ICustomsDeclarations CustomsDeclarations { get; }

        /// <summary>
        /// Customs declarations are relevant information, including one or multiple customs items, you need to provide for customs clearance for your international shipments.<br/>
        /// 
        /// <remarks>
        /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/CustomsItem&quot;/&gt;
        /// </remarks>
        /// </summary>
        public ICustomsItems CustomsItems { get; }

        /// <summary>
        /// Rates at checkout is a tool for merchants to display up-to-date shipping estimates based on what&apos;s in their customers cart and where they’re shipping to.<br/>
        /// 
        /// <remarks>
        /// Merchants set up curated shipping options for customers in the checkout flow based on data in the shopping cart. The request must include the **to** address and item information. Optional fields are the **from** address and package information. If the optional fields are not included, the service will use the default address and/or package configured for rates at checkout. The response is a list of shipping options based on the Service Group configuration.<br/>
        /// (see &lt;a href=&quot;#tag/Service-Groups&quot;&gt;Service Group configuration&lt;/a&gt; for details).<br/>
        /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/LiveRate&quot;/&gt;<br/>
        /// <br/>
        /// <br/>
        /// # Default Parcel Template<br/>
        /// Assign one of your user parcel templates to be the default used when generating Live Rates. This template will be used by default when generating Live Rates, unless you explicitly provide a parcel in the Live Rates request.<br/>
        /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/UserParcelTemplate&quot;/&gt;
        /// </remarks>
        /// </summary>
        public IRatesAtCheckout RatesAtCheckout { get; }

        /// <summary>
        /// A manifest is a single-page document with a barcode that carriers can scan to accept all packages into transit without the need to scan each item individually. <br/>
        /// 
        /// <remarks>
        /// They are close-outs of shipping labels of a certain day. Some carriers require manifests to  process the shipments.<br/>
        /// <br/>
        /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/Manifest&quot;/&gt;<br/>
        /// <br/>
        /// # Manifest Errors<br/>
        /// The following codes and messages are the possible errors that may occur when creating Manifests.<br/>
        /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/ManifestErrors&quot;/&gt;
        /// </remarks>
        /// </summary>
        public IManifests Manifests { get; }

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
        public IOrders Orders { get; }

        /// <summary>
        /// A carrier parcel template represents a package used for shipping that has preset dimensions defined by a carrier. Some examples of a carrier parcel template include USPS Flat Rate Box and Fedex Small Pak. When using a carrier parcel template, the rates returned may be limited to the carrier that provides the box. You can create user parcel templates using a carrier parcel template. Shippo takes the dimensions of the carrier parcel template but you must configure the weight.<br/>
        /// 
        /// <remarks>
        /// <br/>
        /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/CarrierParcelTemplate&quot;/&gt;
        /// </remarks>
        /// </summary>
        public ICarrierParcelTemplates CarrierParcelTemplates { get; }

        /// <summary>
        /// A parcel is an item you are shipping. The parcel object includes details about its physical make-up of the parcel. It includes dimensions and weight that Shippo uses to calculate rates. <br/>
        /// 
        /// <remarks>
        /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/Parcel&quot;/&gt;<br/>
        /// <br/>
        /// # Parcel Extras<br/>
        /// The following values are supported for the `extra` field of the parcel object.<br/>
        /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/ParcelExtra&quot;/&gt;
        /// </remarks>
        /// </summary>
        public IParcels Parcels { get; }

        /// <summary>
        /// A pickup is when you schedule a carrier to collect a package for delivery.<br/>
        /// 
        /// <remarks>
        /// Use Shippo’s pickups endpoint to schedule pickups with USPS and DHL Express for eligible shipments that you have already created.<br/>
        /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/Pickup&quot;/&gt;
        /// </remarks>
        /// </summary>
        public IPickups Pickups { get; }

        /// <summary>
        /// A rate is the cost to ship a parcel from a carrier. The rate object details the service level including the cost and transit time. <br/>
        /// 
        /// <remarks>
        /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/Rate&quot;/&gt;
        /// </remarks>
        /// </summary>
        public IRates Rates { get; }

        /// <summary>
        /// Refunds are reimbursements for successfully created but unused shipping labels or other charges.<br/>
        /// 
        /// <remarks>
        /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/Refund&quot;/&gt;
        /// </remarks>
        /// </summary>
        public IRefunds Refunds { get; }

        /// <summary>
        /// A service group is a set of service levels grouped together. <br/>
        /// 
        /// <remarks>
        /// Rates at checkout uses services groups to present available shipping options to customers in their shopping basket.<br/>
        /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/ServiceGroup&quot;/&gt;
        /// </remarks>
        /// </summary>
        public IServiceGroups ServiceGroups { get; }

        /// <summary>
        /// A shipment is the act of transporting goods. A shipment object contains **to** and **from** addresses, and the parcel details that you are shipping. You can use the shipment object to retrieve shipping rates and purchase a shipping label.<br/>
        /// 
        /// <remarks>
        /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/Shipment&quot;/&gt;<br/>
        ///  <br/>
        /// # Shipment Extras<br/>
        /// The following values are supported for the `extra` field of the shipment object.<br/>
        /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/ShipmentExtra&quot;/&gt;
        /// </remarks>
        /// </summary>
        public IShipments Shipments { get; }

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
        public ITrackingStatus TrackingStatus { get; }

        /// <summary>
        /// A transaction is the purchase of a shipping label from a shipping provider for a specific service. You can print purchased labels and used them to ship a parcel with a carrier, such as USPS or FedEx.<br/>
        /// 
        /// <remarks>
        /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/Transaction&quot;/&gt;
        /// </remarks>
        /// </summary>
        public ITransactions Transactions { get; }

        /// <summary>
        /// A user parcel template represents a package used for shipping that has preset dimensions and attributes defined <br/>
        /// 
        /// <remarks>
        /// by you. They are useful for capturing attributes of parcel-types you frequently use for shipping, allowing <br/>
        /// them to be defined once and then used for many shipments. These parcel templates can also be used for live rates.<br/>
        /// <br/>
        /// User parcel templates can also be created using a carrier parcel template, where the dimensions will be copied from <br/>
        /// the carrier presets, but the weight can be configured by you.<br/>
        /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/UserParcelTemplate&quot;/&gt;
        /// </remarks>
        /// </summary>
        public IUserParcelTemplates UserParcelTemplates { get; }

        /// <summary>
        /// Shippo Accounts are used by Shippo Platform Accounts to create and manage Managed Shippo Accounts. <br/>
        /// 
        /// <remarks>
        /// Managed Shippo Accounts are headless accounts that represent your customers. They are opaque to your end customers, meaning customers do not need to create their own Shippo login or have a billing relationship with Shippo. <br/>
        /// They can be used by marketplaces, e-commerce platforms, and third-party logistics providers who want to offer, seamless, built-in shipping functionality to their customers. <br/>
        /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/ShippoAccount&quot;/&gt;
        /// </remarks>
        /// </summary>
        public IShippoAccounts ShippoAccounts { get; }
    }

    public class SDKConfig
    {
        /// <summary>
        /// List of server URLs available to the SDK.
        /// </summary>
        public static readonly string[] ServerList = {
            "https://api.goshippo.com",
        };

        public string ServerUrl = "";
        public int ServerIndex = 0;
        public string? ShippoApiVersion;
        public SDKHooks Hooks = new SDKHooks();
        public RetryConfig? RetryConfig = null;

        public string GetTemplatedServerUrl()
        {
            if (!String.IsNullOrEmpty(this.ServerUrl))
            {
                return Utilities.TemplateUrl(Utilities.RemoveSuffix(this.ServerUrl, "/"), new Dictionary<string, string>());
            }
            return Utilities.TemplateUrl(SDKConfig.ServerList[this.ServerIndex], new Dictionary<string, string>());
        }

        public ISpeakeasyHttpClient InitHooks(ISpeakeasyHttpClient client)
        {
            string preHooksUrl = GetTemplatedServerUrl();
            var (postHooksUrl, postHooksClient) = this.Hooks.SDKInit(preHooksUrl, client);
            if (preHooksUrl != postHooksUrl)
            {
                this.ServerUrl = postHooksUrl;
            }
            return postHooksClient;
        }
    }

    /// <summary>
    /// Shippo external API.: Use this API to integrate with the Shippo service
    /// </summary>
    public class ShippoSDK: IShippoSDK
    {
        public SDKConfig SDKConfiguration { get; private set; }

        private const string _language = "csharp";
        private const string _sdkVersion = "0.1.0";
        private const string _sdkGenVersion = "2.337.1";
        private const string _openapiDocVersion = "2018-02-08";
        private const string _userAgent = "speakeasy-sdk/csharp 0.1.0 2.337.1 2018-02-08 Shippo";
        private string _serverUrl = "";
        private int _serverIndex = 0;
        private ISpeakeasyHttpClient _defaultClient;
        private Func<Security>? _securitySource;
        public IAddresses Addresses { get; private set; }
        public IBatches Batches { get; private set; }
        public ICarrierAccounts CarrierAccounts { get; private set; }
        public ICustomsDeclarations CustomsDeclarations { get; private set; }
        public ICustomsItems CustomsItems { get; private set; }
        public IRatesAtCheckout RatesAtCheckout { get; private set; }
        public IManifests Manifests { get; private set; }
        public IOrders Orders { get; private set; }
        public ICarrierParcelTemplates CarrierParcelTemplates { get; private set; }
        public IParcels Parcels { get; private set; }
        public IPickups Pickups { get; private set; }
        public IRates Rates { get; private set; }
        public IRefunds Refunds { get; private set; }
        public IServiceGroups ServiceGroups { get; private set; }
        public IShipments Shipments { get; private set; }
        public ITrackingStatus TrackingStatus { get; private set; }
        public ITransactions Transactions { get; private set; }
        public IUserParcelTemplates UserParcelTemplates { get; private set; }
        public IShippoAccounts ShippoAccounts { get; private set; }

        public ShippoSDK(string? apiKeyHeader = null, Func<string>? apiKeyHeaderSource = null, string? shippoApiVersion = null, int? serverIndex = null, string? serverUrl = null, Dictionary<string, string>? urlParams = null, ISpeakeasyHttpClient? client = null, RetryConfig? retryConfig = null)
        {
            if (serverIndex != null)
            {
                if (serverIndex.Value < 0 || serverIndex.Value >= SDKConfig.ServerList.Length)
                {
                    throw new Exception($"Invalid server index {serverIndex.Value}");
                }
                _serverIndex = serverIndex.Value;
            }

            if (serverUrl != null)
            {
                if (urlParams != null)
                {
                    serverUrl = Utilities.TemplateUrl(serverUrl, urlParams);
                }
                _serverUrl = serverUrl;
            }

            _defaultClient = new SpeakeasyHttpClient(client);

            if(apiKeyHeaderSource != null)
            {
                _securitySource = () => new Security() { APIKeyHeader = apiKeyHeaderSource() };
            }
            else if(apiKeyHeader != null)
            {
                _securitySource = () => new Security() { APIKeyHeader = apiKeyHeader };
            }
            else
            {
                throw new Exception("apiKeyHeader and apiKeyHeaderSource cannot both be null");
            }

            SDKConfiguration = new SDKConfig()
            {
                ShippoApiVersion = shippoApiVersion,
                ServerIndex = _serverIndex,
                ServerUrl = _serverUrl,
                RetryConfig = retryConfig
            };

            _defaultClient = SDKConfiguration.InitHooks(_defaultClient);


            Addresses = new Addresses(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);


            Batches = new Batches(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);


            CarrierAccounts = new CarrierAccounts(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);


            CustomsDeclarations = new CustomsDeclarations(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);


            CustomsItems = new CustomsItems(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);


            RatesAtCheckout = new RatesAtCheckout(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);


            Manifests = new Manifests(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);


            Orders = new Orders(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);


            CarrierParcelTemplates = new CarrierParcelTemplates(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);


            Parcels = new Parcels(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);


            Pickups = new Pickups(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);


            Rates = new Rates(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);


            Refunds = new Refunds(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);


            ServiceGroups = new ServiceGroups(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);


            Shipments = new Shipments(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);


            TrackingStatus = new TrackingStatus(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);


            Transactions = new Transactions(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);


            UserParcelTemplates = new UserParcelTemplates(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);


            ShippoAccounts = new ShippoAccounts(_defaultClient, _securitySource, _serverUrl, SDKConfiguration);
        }
    }
}