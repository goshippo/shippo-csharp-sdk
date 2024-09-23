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
    /// Specify billing details (UPS, FedEx, and DHL Germany only).
    /// </summary>
    public class Billing
    {

        /// <summary>
        /// Account number to be billed. (For DHL Germany, leave this field blank.)
        /// </summary>
        [JsonProperty("account")]
        public string? Account { get; set; }

        /// <summary>
        /// Country iso2 code of account number to be billed (required for UPS third party billing only).
        /// </summary>
        [JsonProperty("country")]
        public string? Country { get; set; }

        /// <summary>
        /// 2 digit code used to override your default participation code associated with your DHL Germany account.
        /// </summary>
        [JsonProperty("participation_code")]
        public string? ParticipationCode { get; set; }

        /// <summary>
        /// Party to be billed. (Leave blank for DHL Germany.)
        /// </summary>
        [JsonProperty("type")]
        public Models.Components.Type? Type { get; set; }

        /// <summary>
        /// ZIP code of account number to be billed (required for UPS if there is a zip on the billing account).
        /// </summary>
        [JsonProperty("zip")]
        public string? Zip { get; set; }
    }
}