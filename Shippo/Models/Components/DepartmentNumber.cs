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
    
    /// <summary>
    /// Specify the department number field on the label (FedEx and UPS only).
    /// </summary>
    public class DepartmentNumber
    {

        /// <summary>
        /// Custom prefix for department number field (ZPL labels only). Up to 11 characters, including trailing <br/>
        /// 
        /// <remarks>
        /// spaces. Empty string indicates removal of default prefix. To use the default prefix, do not include<br/>
        /// this property.
        /// </remarks>
        /// </summary>
        [JsonProperty("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// Optional text to be printed on the shipping label for department number. Up to 40 characters.
        /// </summary>
        [JsonProperty("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Order UPS reference fields are printed on ZPL labels. For UPS shipments, if you choose to set `ref_sort` for one reference, you must set `ref_sort` for all other supported UPS references using unique integers.
        /// </summary>
        [JsonProperty("ref_sort")]
        public long? RefSort { get; set; }
    }
}