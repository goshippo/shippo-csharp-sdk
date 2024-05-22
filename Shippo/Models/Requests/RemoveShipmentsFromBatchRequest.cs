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
    using Shippo.Utils;
    using System.Collections.Generic;
    
    public class RemoveShipmentsFromBatchRequest
    {

        /// <summary>
        /// Object ID of the batch
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=BatchId")]
        public string BatchId { get; set; } = default!;

        /// <summary>
        /// Array of shipments object ids to remove from the batch
        /// </summary>
        [SpeakeasyMetadata("request:mediaType=application/json")]
        public List<string> RequestBody { get; set; } = default!;

        /// <summary>
        /// String used to pick a non-default API version to use
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=SHIPPO-API-VERSION")]
        public string? ShippoApiVersion { get; set; }
    }
}