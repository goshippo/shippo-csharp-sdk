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
    using System;
    using System.Collections.Generic;
    
    /// <summary>
    /// Shipment represents the parcel as retrieved from the database
    /// </summary>
    public class Shipment
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
        public string Metadata { get; set; } = default!;

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

        /// <summary>
        /// &lt;a href=&quot;#tag/Addresses&quot;&gt;Address&lt;/a&gt; object of the sender / seller. Will be returned expanded by default.
        /// </summary>
        [JsonProperty("address_from")]
        public Address AddressFrom { get; set; } = default!;

        /// <summary>
        /// ID of the Address object where the shipment will be sent back to if it is not delivered <br/>
        /// 
        /// <remarks>
        /// (Only available for UPS, USPS, and Fedex shipments). &lt;br/&gt; <br/>
        /// If this field is not set, your shipments will be returned to the address_from.
        /// </remarks>
        /// </summary>
        [JsonProperty("address_return")]
        public Address? AddressReturn { get; set; }

        /// <summary>
        /// &lt;a href=&quot;#tag/Addresses&quot;&gt;Address&lt;/a&gt; object of the recipient / buyer. Will be returned expanded by default.
        /// </summary>
        [JsonProperty("address_to")]
        public Address AddressTo { get; set; } = default!;

        /// <summary>
        /// An array of object_ids of the carrier account objects to be used for getting shipping rates for this shipment. <br/>
        /// 
        /// <remarks>
        /// If no carrier account object_ids are set in this field, Shippo will attempt to generate rates using all the <br/>
        /// carrier accounts that have the `active` field set.
        /// </remarks>
        /// </summary>
        [JsonProperty("carrier_accounts")]
        public List<string> CarrierAccounts { get; set; } = default!;

        [JsonProperty("customs_declaration")]
        public CustomsDeclaration? CustomsDeclaration { get; set; }

        [JsonProperty("messages")]
        public List<ResponseMessage> Messages { get; set; } = default!;

        /// <summary>
        /// Date and time of Shipment creation.
        /// </summary>
        [JsonProperty("object_created")]
        public DateTime ObjectCreated { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the given Shipment object.
        /// </summary>
        [JsonProperty("object_id")]
        public string ObjectId { get; set; } = default!;

        /// <summary>
        /// Username of the user who created the Shipment object.
        /// </summary>
        [JsonProperty("object_owner")]
        public string ObjectOwner { get; set; } = default!;

        /// <summary>
        /// Date and time of last Shipment update.
        /// </summary>
        [JsonProperty("object_updated")]
        public DateTime ObjectUpdated { get; set; } = default!;

        /// <summary>
        /// List of Parcel objects to be shipped.
        /// </summary>
        [JsonProperty("parcels")]
        public List<Parcel> Parcels { get; set; } = default!;

        /// <summary>
        /// An array with all available rates. If &lt;code&gt;async&lt;/code&gt; has been set to &lt;code&gt;false&lt;/code&gt; in the request,<br/>
        /// 
        /// <remarks>
        /// this will be populated with all available rates in the response. Otherwise rates will be created<br/>
        /// asynchronously and this array will initially be empty.
        /// </remarks>
        /// </summary>
        [JsonProperty("rates")]
        public List<Rate> Rates { get; set; } = default!;

        /// <summary>
        /// `Waiting` shipments have been successfully submitted but not yet been processed. <br/>
        /// 
        /// <remarks>
        /// `Queued` shipments are currently being processed. <br/>
        /// `Success` shipments have been processed successfully, meaning that rate generation has concluded. <br/>
        /// `Error` does not occur currently and is reserved for future use.
        /// </remarks>
        /// </summary>
        [JsonProperty("status")]
        public ShipmentStatus Status { get; set; } = default!;

        /// <summary>
        /// Indicates whether the object has been created in test mode.
        /// </summary>
        [JsonProperty("test")]
        public bool? Test { get; set; }
    }
}