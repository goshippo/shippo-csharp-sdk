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
    
    public class ParcelCreateRequest
    {

        /// <summary>
        /// An object holding optional extra services to be requested for each parcel in a multi-piece shipment. <br/>
        /// 
        /// <remarks>
        /// See the &lt;a href=&quot;#section/Parcel-Extras&quot;&gt;Parcel Extra table below&lt;/a&gt; for all available services.
        /// </remarks>
        /// </summary>
        [JsonProperty("extra")]
        public ParcelExtra? Extra { get; set; }

        [JsonProperty("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// The unit used for weight.
        /// </summary>
        [JsonProperty("mass_unit")]
        public WeightUnitEnum MassUnit { get; set; } = default!;

        /// <summary>
        /// Weight of the parcel. Up to six digits in front and four digits after the decimal separator are accepted.
        /// </summary>
        [JsonProperty("weight")]
        public string Weight { get; set; } = default!;

        /// <summary>
        /// The measure unit used for length, width and height.
        /// </summary>
        [JsonProperty("distance_unit")]
        public DistanceUnitEnum DistanceUnit { get; set; } = default!;

        /// <summary>
        /// Height of the parcel. Up to six digits in front and four digits after the decimal separator are accepted.
        /// </summary>
        [JsonProperty("height")]
        public string Height { get; set; } = default!;

        /// <summary>
        /// Length of the Parcel. Up to six digits in front and four digits after the decimal separator are accepted.
        /// </summary>
        [JsonProperty("length")]
        public string Length { get; set; } = default!;

        /// <summary>
        /// Width of the Parcel. Up to six digits in front and four digits after the decimal separator are accepted.
        /// </summary>
        [JsonProperty("width")]
        public string Width { get; set; } = default!;
    }
}