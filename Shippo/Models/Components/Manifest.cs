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
    using System;
    
    public class Manifest
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

        /// <summary>
        /// ID of the Address object that should be used as pickup address for the scan form. <br/>
        /// 
        /// <remarks>
        /// The USPS will validate this address before creating the scan form.
        /// </remarks>
        /// </summary>
        [JsonProperty("address_from")]
        public string AddressFrom { get; set; } = default!;

        /// <summary>
        /// An array containing the URLs to all returned manifest documents.
        /// </summary>
        [JsonProperty("documents")]
        public List<string> Documents { get; set; } = default!;

        /// <summary>
        /// An array of codes and messages describing the error that occurred if any.
        /// </summary>
        [JsonProperty("errors")]
        public List<string>? Errors { get; set; }

        /// <summary>
        /// Date and time of object creation.
        /// </summary>
        [JsonProperty("object_created")]
        public DateTime ObjectCreated { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the given object.
        /// </summary>
        [JsonProperty("object_id")]
        public string ObjectId { get; set; } = default!;

        /// <summary>
        /// Username of the user who created the object.
        /// </summary>
        [JsonProperty("object_owner")]
        public string ObjectOwner { get; set; } = default!;

        /// <summary>
        /// Date and time of last object update.
        /// </summary>
        [JsonProperty("object_updated")]
        public DateTime ObjectUpdated { get; set; } = default!;

        /// <summary>
        /// Indicates the status of the manifest.
        /// </summary>
        [JsonProperty("status")]
        public ManifestStatus Status { get; set; } = default!;
    }
}