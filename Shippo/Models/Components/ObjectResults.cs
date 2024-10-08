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
    
    /// <summary>
    /// An object containing the following counts:&lt;br&gt;`creation_succeeded`&lt;br&gt;`creation_failed`&lt;br&gt;`purchase_succeeded`&lt;br&gt;`purchase_failed`
    /// </summary>
    public class ObjectResults
    {

        [JsonProperty("creation_failed")]
        public long CreationFailed { get; set; } = default!;

        [JsonProperty("creation_succeeded")]
        public long CreationSucceeded { get; set; } = default!;

        [JsonProperty("purchase_failed")]
        public long PurchaseFailed { get; set; } = default!;

        [JsonProperty("purchase_succeeded")]
        public long PurchaseSucceeded { get; set; } = default!;
    }
}