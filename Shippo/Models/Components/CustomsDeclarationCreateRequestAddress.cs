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
    using Shippo.Utils;
    
    public class CustomsDeclarationCreateRequestAddress
    {

        /// <summary>
        /// Name of the party to be billed for duties.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Postal code of the party to be billed for duties.
        /// </summary>
        [JsonProperty("zip")]
        public string? Zip { get; set; }

        /// <summary>
        /// Country ISO code of account number to be billed.
        /// </summary>
        [JsonProperty("country")]
        public string? Country { get; set; }
    }
}