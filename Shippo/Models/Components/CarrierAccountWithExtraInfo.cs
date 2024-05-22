//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Shippo.Models.Components
{
    using Newtonsoft.Json;
    using Shippo.Models.Components;
    using Shippo.Utils;
    using System.Collections.Generic;
    
    public class CarrierAccountWithExtraInfo
    {

        /// <summary>
        /// Unique identifier of the account. Please check the &lt;a href=&quot;https://docs.goshippo.com/docs/carriers/carrieraccounts/&quot;&gt;carrier accounts tutorial&lt;/a&gt; <br/>
        /// 
        /// <remarks>
        /// page for the `account_id` per carrier.&lt;br&gt; <br/>
        /// To protect account information, this field will be masked in any API response.
        /// </remarks>
        /// </summary>
        [JsonProperty("account_id")]
        public string AccountId { get; set; } = default!;

        /// <summary>
        /// Determines whether the account is active. When creating a shipment, if no `carrier_accounts` are explicitly <br/>
        /// 
        /// <remarks>
        /// passed Shippo will query all carrier accounts that have this field set. By default, this is set to True.
        /// </remarks>
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Carrier token, see &lt;a href=&quot;#tag/Carriers&quot;&gt;Carriers&lt;/a&gt;&lt;br&gt;<br/>
        /// 
        /// <remarks>
        /// Please check the &lt;a href=&quot;https://docs.goshippo.com/docs/carriers/carrieraccounts/&quot;&gt;carrier accounts tutorial&lt;/a&gt; page for all supported carriers.
        /// </remarks>
        /// </summary>
        [JsonProperty("carrier")]
        public string Carrier { get; set; } = default!;

        [JsonProperty("parameters")]
        public Parameters? Parameters { get; set; }

        /// <summary>
        /// Carrier name, see &lt;a href=&quot;#tag/Carriers&quot;&gt;Carriers&lt;/a&gt;&lt;br&gt;
        /// </summary>
        [JsonProperty("carrier_name")]
        public object? CarrierName { get; set; }

        [JsonProperty("is_shippo_account")]
        public bool? IsShippoAccount { get; set; }

        [JsonProperty("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// Unique identifier of the carrier account object.
        /// </summary>
        [JsonProperty("object_id")]
        public string? ObjectId { get; set; }

        /// <summary>
        /// Username of the user who created the carrier account object.
        /// </summary>
        [JsonProperty("object_owner")]
        public string? ObjectOwner { get; set; }

        [JsonProperty("service_levels")]
        public List<CarrierAccountServiceLevel>? ServiceLevels { get; set; }

        /// <summary>
        /// Indicates whether the object has been created in test mode.
        /// </summary>
        [JsonProperty("test")]
        public bool? Test { get; set; }

        /// <summary>
        /// Holds internal state relevant to users.
        /// </summary>
        [JsonProperty("object_info")]
        public ObjectInfo? ObjectInfo { get; set; }
    }
}