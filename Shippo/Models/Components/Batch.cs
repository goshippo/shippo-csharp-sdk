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
    
    public class Batch
    {

        /// <summary>
        /// ID of the Carrier Account object to use as the default for all shipments in this Batch. <br/>
        /// 
        /// <remarks>
        /// The carrier account can be changed on a per-shipment basis by changing the carrier_account in the <br/>
        /// corresponding BatchShipment object.
        /// </remarks>
        /// </summary>
        [JsonProperty("default_carrier_account")]
        public string DefaultCarrierAccount { get; set; } = default!;

        /// <summary>
        /// Token of the service level to use as the default for all shipments in this Batch. <br/>
        /// 
        /// <remarks>
        /// The servicelevel can be changed on a per-shipment basis by changing the servicelevel_token in the <br/>
        /// corresponding BatchShipment object. &lt;a href=&quot;#tag/Service-Levels&quot;&gt;Servicelevel tokens can be found here.&lt;/a&gt;
        /// </remarks>
        /// </summary>
        [JsonProperty("default_servicelevel_token")]
        public string DefaultServicelevelToken { get; set; } = default!;

        /// <summary>
        /// Print format of the &lt;a href=&quot;https://docs.goshippo.com/docs/shipments/shippinglabelsizes/&quot;&gt;label&lt;/a&gt;. If empty, will use the default format set from <br/>
        /// 
        /// <remarks>
        /// &lt;a href=&quot;https://apps.goshippo.com/settings/labels&quot;&gt;the Shippo dashboard.&lt;/a&gt;
        /// </remarks>
        /// </summary>
        [JsonProperty("label_filetype")]
        public LabelFileTypeEnum? LabelFiletype { get; set; }

        /// <summary>
        /// A string of up to 100 characters that can be filled with any additional information you want to attach to the object.
        /// </summary>
        [JsonProperty("metadata")]
        public string? Metadata { get; set; }

        [JsonProperty("batch_shipments")]
        public BatchShipmentPaginatedList BatchShipments { get; set; } = default!;

        /// <summary>
        /// An array of URLs each pointing to a merged file of 100 labels each
        /// </summary>
        [JsonProperty("label_url")]
        public List<string> LabelUrl { get; set; } = default!;

        /// <summary>
        /// Date and time of Batch creation
        /// </summary>
        [JsonProperty("object_created")]
        public string ObjectCreated { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the given Batch object
        /// </summary>
        [JsonProperty("object_id")]
        public string ObjectId { get; set; } = default!;

        /// <summary>
        /// Username of the user who created the Address object.
        /// </summary>
        [JsonProperty("object_owner")]
        public string ObjectOwner { get; set; } = default!;

        /// <summary>
        /// An object containing the following counts:&lt;br&gt;`creation_succeeded`&lt;br&gt;`creation_failed`&lt;br&gt;`purchase_succeeded`&lt;br&gt;`purchase_failed`
        /// </summary>
        [JsonProperty("object_results")]
        public ObjectResults ObjectResults { get; set; } = default!;

        /// <summary>
        /// Date and time of last update to the Batch
        /// </summary>
        [JsonProperty("object_updated")]
        public string ObjectUpdated { get; set; } = default!;

        /// <summary>
        /// Batches that are `VALIDATING` are being created and validated&lt;br&gt;<br/>
        /// 
        /// <remarks>
        /// `VALID` batches can be purchased&lt;br&gt;<br/>
        /// `INVALID` batches cannot be purchased, `INVALID` BatchShipments must be removed&lt;br&gt;<br/>
        /// Batches that are in the `PURCHASING` state are being purchased&lt;br&gt;<br/>
        /// `PURCHASED` batches are finished purchasing.
        /// </remarks>
        /// </summary>
        [JsonProperty("status")]
        public BatchStatus Status { get; set; } = default!;

        [JsonProperty("test")]
        public bool? Test { get; set; }
    }
}