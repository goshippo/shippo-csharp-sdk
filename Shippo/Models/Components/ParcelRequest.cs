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
    
    public class ParcelRequest
    {

        /// <summary>
        /// The measure unit used for length, width and height.
        /// </summary>
        [JsonProperty("distance_unit")]
        public DistanceUnitEnum DistanceUnit { get; set; } = default!;

        /// <summary>
        /// An object holding optional extra services to be requested for each parcel in a multi-piece shipment. <br/>
        /// 
        /// <remarks>
        /// See the &lt;a href=&quot;#section/Parcel-Extras&quot;&gt;Parcel Extra table below&lt;/a&gt; for all available services.
        /// </remarks>
        /// </summary>
        [JsonProperty("extra")]
        public ParcelExtra? Extra { get; set; }

        /// <summary>
        /// Required if template is not specified. Height of the parcel. Up to six digits in front and four digits after the decimal separator are accepted.
        /// </summary>
        [JsonProperty("height")]
        public string Height { get; set; } = default!;

        /// <summary>
        /// Required if template is not specified. Length of the Parcel. Up to six digits in front and four digits after the decimal separator are accepted.
        /// </summary>
        [JsonProperty("length")]
        public string Length { get; set; } = default!;

        /// <summary>
        /// The unit used for weight.
        /// </summary>
        [JsonProperty("mass_unit")]
        public WeightUnitEnum MassUnit { get; set; } = default!;

        /// <summary>
        /// A string of up to 100 characters that can be filled with any additional information you want to attach to the object.
        /// </summary>
        [JsonProperty("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// If template is passed, `length`, `width`, `height`, and `distance_unit` are not required
        /// </summary>
        [JsonProperty("template")]
        public ParcelTemplateEnumSet? Template { get; set; }

        /// <summary>
        /// Indicates whether the object has been created in test mode.
        /// </summary>
        [JsonProperty("test")]
        public bool? Test { get; set; }

        /// <summary>
        /// Weight of the parcel. Up to six digits in front and four digits after the decimal separator are accepted.
        /// </summary>
        [JsonProperty("weight")]
        public string Weight { get; set; } = default!;

        /// <summary>
        /// Required if template is not specified. Width of the Parcel. Up to six digits in front and four digits after the decimal separator are accepted.
        /// </summary>
        [JsonProperty("width")]
        public string Width { get; set; } = default!;
    }
}