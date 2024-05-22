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
    
    public class Track
    {

        /// <summary>
        /// The sender address with city, state, zip and country information.
        /// </summary>
        [JsonProperty("address_from")]
        public TrackingStatusLocationBase? AddressFrom { get; set; }

        /// <summary>
        /// The recipient address with city, state, zip and country information.
        /// </summary>
        [JsonProperty("address_to")]
        public TrackingStatusLocationBase? AddressTo { get; set; }

        /// <summary>
        /// Name of the carrier of the shipment to track. See &lt;a href=&quot;#tag/Carriers&quot;&gt;Carriers&lt;/a&gt;.
        /// </summary>
        [JsonProperty("carrier")]
        public string Carrier { get; set; } = default!;

        /// <summary>
        /// The estimated time of arrival according to the carrier, this might be updated by carriers during the life of the shipment.
        /// </summary>
        [JsonProperty("eta")]
        public DateTime? Eta { get; set; }

        [JsonProperty("messages")]
        public List<string> Messages { get; set; } = default!;

        /// <summary>
        /// A string of up to 100 characters that can be filled with any additional information you want to attach to the object.
        /// </summary>
        [JsonProperty("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// The estimated time of arrival according to the carrier at the time the shipment first entered the system.
        /// </summary>
        [JsonProperty("original_eta")]
        public DateTime? OriginalEta { get; set; }

        [JsonProperty("servicelevel")]
        public ServiceLevelWithParent? Servicelevel { get; set; }

        /// <summary>
        /// A list of tracking events, following the same structure as &lt;code&gt;tracking_status&lt;/code&gt;. <br/>
        /// 
        /// <remarks>
        /// It contains a full history of all tracking statuses, starting with the earlier tracking event first.
        /// </remarks>
        /// </summary>
        [JsonProperty("tracking_history")]
        public List<Models.Components.TrackingStatus> TrackingHistory { get; set; } = default!;

        /// <summary>
        /// Tracking number to track.
        /// </summary>
        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; } = default!;

        /// <summary>
        /// The latest tracking information of this shipment.
        /// </summary>
        [JsonProperty("tracking_status")]
        public Models.Components.TrackingStatus? TrackingStatus { get; set; }

        /// <summary>
        /// The &lt;code&gt;object_id&lt;/code&gt; of the transaction associated with this tracking object. <br/>
        /// 
        /// <remarks>
        /// This field is visible only to the object owner of the transaction.
        /// </remarks>
        /// </summary>
        [JsonProperty("transaction")]
        public string? Transaction { get; set; }
    }
}