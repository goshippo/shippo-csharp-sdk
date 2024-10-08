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
    
    public class Pickup
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

        /// <summary>
        /// Date and time of Pickup creation.
        /// </summary>
        [JsonProperty("object_created")]
        public DateTime? ObjectCreated { get; set; }

        /// <summary>
        /// Unique identifier of the given Pickup object.
        /// </summary>
        [JsonProperty("object_id")]
        public string? ObjectId { get; set; }

        /// <summary>
        /// Date and time of last Pickup update.
        /// </summary>
        [JsonProperty("object_updated")]
        public DateTime? ObjectUpdated { get; set; }

        /// <summary>
        /// The earliest that your parcels will be ready for pickup, confirmed by the carrier. <br/>
        /// 
        /// <remarks>
        /// Expressed in the timezone specified in the response.
        /// </remarks>
        /// </summary>
        [JsonProperty("confirmed_start_time")]
        public string? ConfirmedStartTime { get; set; }

        /// <summary>
        /// The latest that your parcels will be available for pickup, confirmed by the carrier. <br/>
        /// 
        /// <remarks>
        /// Expressed in the timezone specified in the response.
        /// </remarks>
        /// </summary>
        [JsonProperty("confirmed_end_time")]
        public string? ConfirmedEndTime { get; set; }

        /// <summary>
        /// The latest time to cancel a pickup. Expressed in the timezone specified in the response. <br/>
        /// 
        /// <remarks>
        /// To cancel a pickup, you will need to contact the carrier directly. <br/>
        /// The ability to cancel a pickup through Shippo may be released in future iterations.
        /// </remarks>
        /// </summary>
        [JsonProperty("cancel_by_time")]
        public string? CancelByTime { get; set; }

        /// <summary>
        /// Indicates the status of the pickup.
        /// </summary>
        [JsonProperty("status")]
        public PickupStatus? Status { get; set; }

        /// <summary>
        /// Pickup&apos;s confirmation code returned by the carrier. <br/>
        /// 
        /// <remarks>
        /// To edit or cancel a pickup, you will need to contact USPS or DHL Express directly and provide your `confirmation_code`.
        /// </remarks>
        /// </summary>
        [JsonProperty("confirmation_code")]
        public string? ConfirmationCode { get; set; }

        /// <summary>
        /// The pickup time windows will be in the time zone specified here, not UTC.
        /// </summary>
        [JsonProperty("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// An array containing strings of any messages generated during validation.
        /// </summary>
        [JsonProperty("messages")]
        public List<string>? Messages { get; set; }

        /// <summary>
        /// Indicates whether the object has been created in test mode.
        /// </summary>
        [JsonProperty("is_test")]
        public bool? IsTest { get; set; }
    }
}