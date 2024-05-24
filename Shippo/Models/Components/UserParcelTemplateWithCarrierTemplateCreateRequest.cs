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
    
    public class UserParcelTemplateWithCarrierTemplateCreateRequest
    {

        /// <summary>
        /// The object representing the carrier parcel template
        /// </summary>
        [JsonProperty("template")]
        public string? Template { get; set; }

        /// <summary>
        /// The weight of the package, in units specified by the weight_unit attribute.
        /// </summary>
        [JsonProperty("weight")]
        public string? Weight { get; set; }

        /// <summary>
        /// The unit used for weight.
        /// </summary>
        [JsonProperty("weight_unit")]
        public WeightUnitEnum? WeightUnit { get; set; }
    }
}