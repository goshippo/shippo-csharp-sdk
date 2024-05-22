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
    using Shippo.Utils;
    
    public class CarrierAccountCanadaPostCreateParameters
    {

        /// <summary>
        /// Whether or not the user agrees to Canada Post&apos;s terms. If passed in as false, request will fail with error 400
        /// </summary>
        [JsonProperty("canada_post_terms")]
        public bool CanadaPostTerms { get; set; } = default!;

        [JsonProperty("company")]
        public string Company { get; set; } = default!;

        [JsonProperty("email")]
        public string Email { get; set; } = default!;

        [JsonProperty("full_name")]
        public string FullName { get; set; } = default!;

        /// <summary>
        /// Needs to be a valid phone number and cannot be null
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; } = default!;
    }
}