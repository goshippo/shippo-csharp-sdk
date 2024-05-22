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
    using System;
    
    public class PickupBase
    {

        /// <summary>
        /// The object ID of your USPS or DHL Express carrier account. <br/>
        /// 
        /// <remarks>
        /// You can retrieve this from your Rate requests or our &lt;a href=&quot;#tag/Carrier-Accounts/&quot;&gt;Carrier Accounts&lt;/a&gt; endpoint.
        /// </remarks>
        /// </summary>
        [JsonProperty("carrier_account")]
        public string CarrierAccount { get; set; } = default!;

        /// <summary>
        /// Location where the parcel(s) will be picked up.
        /// </summary>
        [JsonProperty("location")]
        public Location Location { get; set; } = default!;

        /// <summary>
        /// A string of up to 100 characters that can be filled with any additional information you <br/>
        /// 
        /// <remarks>
        /// want to attach to the object.
        /// </remarks>
        /// </summary>
        [JsonProperty("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// The latest that you requested your parcels to be available for pickup. <br/>
        /// 
        /// <remarks>
        /// Expressed in the timezone specified in the response.
        /// </remarks>
        /// </summary>
        [JsonProperty("requested_end_time")]
        public DateTime RequestedEndTime { get; set; } = default!;

        /// <summary>
        /// The earliest that you requested your parcels to be ready for pickup. <br/>
        /// 
        /// <remarks>
        /// Expressed in the timezone specified in the response.
        /// </remarks>
        /// </summary>
        [JsonProperty("requested_start_time")]
        public DateTime RequestedStartTime { get; set; } = default!;

        /// <summary>
        /// The transaction(s) object ID(s) for the parcel(s) that need to be picked up.
        /// </summary>
        [JsonProperty("transactions")]
        public List<string> Transactions { get; set; } = default!;
    }
}