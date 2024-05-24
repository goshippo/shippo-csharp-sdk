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
    
    public class InstantTransactionCreateRequest
    {

        [JsonProperty("async")]
        public bool? Async { get; set; } = false;

        [JsonProperty("carrier_account")]
        public string CarrierAccount { get; set; } = default!;

        [JsonProperty("label_file_type")]
        public LabelFileType? LabelFileType { get; set; }

        [JsonProperty("metadata")]
        public string? Metadata { get; set; }

        [JsonProperty("servicelevel_token")]
        public string ServicelevelToken { get; set; } = default!;

        [JsonProperty("shipment")]
        public ShipmentCreateRequest Shipment { get; set; } = default!;
    }
}