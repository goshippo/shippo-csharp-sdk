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
    
    public class InstantTransactionCreateResponse
    {

        /// <summary>
        /// A URL pointing to the commercial invoice as a 8.5x11 inch PDF file. <br/>
        /// 
        /// <remarks>
        /// A value will only be returned if the Transactions has been processed successfully and if the shipment is international.
        /// </remarks>
        /// </summary>
        [JsonProperty("commercial_invoice_url")]
        public string? CommercialInvoiceUrl { get; set; }

        /// <summary>
        /// The estimated time of arrival according to the carrier.
        /// </summary>
        [JsonProperty("eta")]
        public string? Eta { get; set; }

        /// <summary>
        /// Print format of the &lt;a href=&quot;https://docs.goshippo.com/docs/shipments/shippinglabelsizes/&quot;&gt;label&lt;/a&gt;. If empty, will use the default format set from <br/>
        /// 
        /// <remarks>
        /// &lt;a href=&quot;https://apps.goshippo.com/settings/labels&quot;&gt;the Shippo dashboard.&lt;/a&gt;
        /// </remarks>
        /// </summary>
        [JsonProperty("label_file_type")]
        public LabelFileTypeEnum? LabelFileType { get; set; }

        /// <summary>
        /// A URL pointing directly to the label in the format you&apos;ve set in your settings. <br/>
        /// 
        /// <remarks>
        /// A value will only be returned if the Transactions has been processed successfully.
        /// </remarks>
        /// </summary>
        [JsonProperty("label_url")]
        public string? LabelUrl { get; set; }

        [JsonProperty("messages")]
        public List<ResponseMessage>? Messages { get; set; }

        /// <summary>
        /// A string of up to 100 characters that can be filled with any additional information you want to <br/>
        /// 
        /// <remarks>
        /// attach to the object.
        /// </remarks>
        /// </summary>
        [JsonProperty("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// Date and time of Transaction creation.
        /// </summary>
        [JsonProperty("object_created")]
        public DateTime? ObjectCreated { get; set; }

        /// <summary>
        /// Unique identifier of the given Transaction object.
        /// </summary>
        [JsonProperty("object_id")]
        public string? ObjectId { get; set; }

        /// <summary>
        /// Username of the user who created the Transaction object.
        /// </summary>
        [JsonProperty("object_owner")]
        public string? ObjectOwner { get; set; }

        /// <summary>
        /// Indicates the validity of the enclosing object
        /// </summary>
        [JsonProperty("object_state")]
        public ObjectStateEnum? ObjectState { get; set; }

        /// <summary>
        /// Date and time of last Transaction update.
        /// </summary>
        [JsonProperty("object_updated")]
        public DateTime? ObjectUpdated { get; set; }

        /// <summary>
        /// A URL pointing directly to the QR code in PNG format. <br/>
        /// 
        /// <remarks>
        /// A value will only be returned if requested using qr_code_requested flag and the carrier provides such an option.
        /// </remarks>
        /// </summary>
        [JsonProperty("qr_code_url")]
        public string? QrCodeUrl { get; set; }

        /// <summary>
        /// Indicates the status of the Transaction.
        /// </summary>
        [JsonProperty("status")]
        public TransactionStatusEnum? Status { get; set; }

        /// <summary>
        /// Indicates whether the object has been created in test mode.
        /// </summary>
        [JsonProperty("test")]
        public bool? Test { get; set; }

        /// <summary>
        /// The carrier-specific tracking number that can be used to track the Shipment. <br/>
        /// 
        /// <remarks>
        /// A value will only be returned if the Rate is for a trackable Shipment and if the Transactions has been processed successfully.
        /// </remarks>
        /// </summary>
        [JsonProperty("tracking_number")]
        public string? TrackingNumber { get; set; }

        /// <summary>
        /// Indicates the high level status of the shipment.
        /// </summary>
        [JsonProperty("tracking_status")]
        public TrackingStatusEnum? TrackingStatus { get; set; }

        /// <summary>
        /// A link to track this item on the carrier-provided tracking website. <br/>
        /// 
        /// <remarks>
        /// A value will only be returned if tracking is available and the carrier provides such a service.
        /// </remarks>
        /// </summary>
        [JsonProperty("tracking_url_provider")]
        public string? TrackingUrlProvider { get; set; }

        [JsonProperty("rate")]
        public InstantTransactionRate? Rate { get; set; }
    }
}