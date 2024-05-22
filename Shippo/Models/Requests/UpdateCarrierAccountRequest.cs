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
    using Shippo.Models.Components;
    using Shippo.Utils;
    
    public class UpdateCarrierAccountRequest
    {

        /// <summary>
        /// Object ID of the carrier account
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=CarrierAccountId")]
        public string CarrierAccountId { get; set; } = default!;

        /// <summary>
        /// String used to pick a non-default API version to use
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=SHIPPO-API-VERSION")]
        public string? ShippoApiVersion { get; set; }

        /// <summary>
        /// Examples.
        /// </summary>
        [SpeakeasyMetadata("request:mediaType=application/json")]
        public CarrierAccountBase? CarrierAccountBase { get; set; }
    }
}