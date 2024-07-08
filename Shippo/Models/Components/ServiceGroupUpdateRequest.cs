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
    
    public class ServiceGroupUpdateRequest
    {

        /// <summary>
        /// Description for the service group
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// String representation of an amount to be returned as the flat rate<br/>
        /// 
        /// <remarks>
        /// if 1. The service group is of type `LIVE_RATE` and no matching rates<br/>
        /// were found; or 2. The service group is of type `FLAT_RATE`. Either<br/>
        /// integers or decimals are accepted. Required unless type is<br/>
        /// `FREE_SHIPPING`
        /// </remarks>
        /// </summary>
        [JsonProperty("flat_rate")]
        public string? FlatRate { get; set; }

        /// <summary>
        /// required unless type is `FREE_SHIPPING`. (ISO 4217 currency)
        /// </summary>
        [JsonProperty("flat_rate_currency")]
        public string? FlatRateCurrency { get; set; }

        /// <summary>
        /// optional unless type is `FREE_SHIPPING`. (ISO 4217 currency)
        /// </summary>
        [JsonProperty("free_shipping_threshold_currency")]
        public string? FreeShippingThresholdCurrency { get; set; }

        /// <summary>
        /// For service groups of type `FREE_SHIPPING`, this field must be required to configure the minimum <br/>
        /// 
        /// <remarks>
        /// cart total (total cost of items in the cart) for this service group to be returned for rates at <br/>
        /// checkout. Optional unless type is `FREE_SHIPPING`
        /// </remarks>
        /// </summary>
        [JsonProperty("free_shipping_threshold_min")]
        public string? FreeShippingThresholdMin { get; set; }

        /// <summary>
        /// Name for the service group that will be shown to customers in the response
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The amount in percent (%) that the service group&apos;s returned rate should be adjusted. For example, if this field is set to 5 and the matched rate price is $5.00, the returned value of the service group will be $5.25. Negative integers are also accepted and will discount the rate price by the defined percentage amount.
        /// </summary>
        [JsonProperty("rate_adjustment")]
        public long? RateAdjustment { get; set; }

        /// <summary>
        /// The type of the service group.&lt;br&gt; <br/>
        /// 
        /// <remarks>
        /// `LIVE_RATE` - Shippo will make a rating request and return real-time rates for the shipping group, only falling back to the specified flat rate amount if no rates match a service level in the service group.&lt;br&gt; <br/>
        /// `FLAT_RATE` - Returns a shipping option with the specified flat rate amount.&lt;br&gt; <br/>
        /// `FREE_SHIPPING` - Returns a shipping option with a price of $0 only if the total cost of items exceeds the amount defined by `free_shipping_threshold_min`
        /// </remarks>
        /// </summary>
        [JsonProperty("type")]
        public ServiceGroupTypeEnum Type { get; set; } = default!;

        /// <summary>
        /// The unique identifier of the given Service Group object.
        /// </summary>
        [JsonProperty("object_id")]
        public string ObjectId { get; set; } = default!;

        /// <summary>
        /// True if the service group is enabled, false otherwise.
        /// </summary>
        [JsonProperty("is_active")]
        public bool IsActive { get; set; } = default!;

        [JsonProperty("service_levels")]
        public List<ServiceGroupAccountAndServiceLevel> ServiceLevels { get; set; } = default!;
    }
}