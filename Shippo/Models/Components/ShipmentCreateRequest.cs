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
    
    public class ShipmentCreateRequest
    {

        /// <summary>
        /// An object holding optional extra services to be requested.
        /// </summary>
        [JsonProperty("extra")]
        public ShipmentExtra? Extra { get; set; }

        /// <summary>
        /// A string of up to 100 characters that can be filled with any additional information you want to attach to the object.
        /// </summary>
        [JsonProperty("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// Date the shipment will be tendered to the carrier. Must be in the format `2014-01-18T00:35:03.463Z`. <br/>
        /// 
        /// <remarks>
        /// Defaults to current date and time if no value is provided. Please note that some carriers require this value to<br/>
        /// be in the future, on a working day, or similar.
        /// </remarks>
        /// </summary>
        [JsonProperty("shipment_date")]
        public string? ShipmentDate { get; set; }

        [JsonProperty("address_from")]
        public AddressFrom AddressFrom { get; set; } = default!;

        [JsonProperty("address_return")]
        public AddressReturn? AddressReturn { get; set; }

        [JsonProperty("address_to")]
        public AddressTo AddressTo { get; set; } = default!;

        [JsonProperty("customs_declaration")]
        public ShipmentCreateRequestCustomsDeclaration? CustomsDeclaration { get; set; }

        [JsonProperty("async")]
        public bool? Async { get; set; }

        /// <summary>
        /// List of &lt;a href=&quot;#tag/Carrier-Accounts/&quot;&gt;Carrier Accounts&lt;/a&gt; `object_id`s used to filter <br/>
        /// 
        /// <remarks>
        /// the returned rates.  If set, only rates from these carriers will be returned.
        /// </remarks>
        /// </summary>
        [JsonProperty("carrier_accounts")]
        public List<string>? CarrierAccounts { get; set; }

        [JsonProperty("parcels")]
        public List<Models.Components.Parcels> Parcels { get; set; } = default!;
    }
}