//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Shippo.Models.Requests
{
    using Newtonsoft.Json;
    using Shippo.Models.Components;
    using Shippo.Utils;
    
    public class ListCarrierAccountsResponse
    {

        [JsonProperty("-")]
        public HTTPMetadata HttpMeta { get; set; } = default!;

        public CarrierAccountPaginatedList? CarrierAccountPaginatedList { get; set; }
    }
}