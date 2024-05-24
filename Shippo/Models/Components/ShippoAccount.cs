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
    using System;
    
    public class ShippoAccount
    {

        [JsonProperty("email")]
        public string Email { get; set; } = default!;

        [JsonProperty("first_name")]
        public string FirstName { get; set; } = default!;

        [JsonProperty("last_name")]
        public string LastName { get; set; } = default!;

        [JsonProperty("company_name")]
        public string? CompanyName { get; set; }

        [JsonProperty("object_created")]
        public DateTime? ObjectCreated { get; set; }

        [JsonProperty("object_id")]
        public string? ObjectId { get; set; }

        [JsonProperty("object_updated")]
        public DateTime? ObjectUpdated { get; set; }
    }
}