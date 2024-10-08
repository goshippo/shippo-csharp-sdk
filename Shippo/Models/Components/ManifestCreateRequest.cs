//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
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
    
    public class ManifestCreateRequest
    {

        /// <summary>
        /// ID of carrier account
        /// </summary>
        [JsonProperty("carrier_account")]
        public string CarrierAccount { get; set; } = default!;

        /// <summary>
        /// All shipments to be submitted on this day will be closed out. <br/>
        /// 
        /// <remarks>
        /// Must be in the format `2014-01-18T00:35:03.463Z` (ISO 8601 date).
        /// </remarks>
        /// </summary>
        [JsonProperty("shipment_date")]
        public string ShipmentDate { get; set; } = default!;

        /// <summary>
        /// IDs transactions to use. If you set this to null or not send this parameter, <br/>
        /// 
        /// <remarks>
        /// Shippo will automatically assign all applicable transactions.
        /// </remarks>
        /// </summary>
        [JsonProperty("transactions")]
        public List<string>? Transactions { get; set; }

        [JsonProperty("address_from")]
        public ManifestCreateRequestAddressFrom AddressFrom { get; set; } = default!;

        [JsonProperty("async")]
        public bool? Async { get; set; }
    }
}