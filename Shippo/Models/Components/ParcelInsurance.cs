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
    
    /// <summary>
    /// To add insurace to your parcel, specify `amount`, `content` and `currency`. &lt;br&gt;&lt;br&gt;If you do not want to add insurance to you parcel, do not set these parameters.
    /// </summary>
    public class ParcelInsurance
    {

        /// <summary>
        /// Declared value of the goods you want to insure.
        /// </summary>
        [JsonProperty("amount")]
        public string? Amount { get; set; }

        /// <summary>
        /// Description of parcel content.
        /// </summary>
        [JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Currency for the amount value. Currently only USD is supported for FedEx and UPS.
        /// </summary>
        [JsonProperty("currency")]
        public string? Currency { get; set; }

        /// <summary>
        /// To have insurance cover provided by a carrier directly instead of Shippo&apos;s provider (XCover), set provider to `FEDEX`, `UPS`, or `ONTRAC`.
        /// </summary>
        [JsonProperty("provider")]
        public ParcelInsuranceProvider? Provider { get; set; }
    }
}