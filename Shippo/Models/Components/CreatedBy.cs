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
    /// An object with details about the user who created the Transaction (purchased the label).<br/>
    /// 
    /// <remarks>
    /// A value will be returned only for Transactions that can be associated with a specific user, e.g. when a logged-in<br/>
    /// user purchases a label via the Shippo Web application; but not for Transactions purchased e.g. via the API using a ShippoToken,<br/>
    /// which is associated with the account but not any specific user.
    /// </remarks>
    /// </summary>
    public class CreatedBy
    {

        [JsonProperty("first_name")]
        public string? FirstName { get; set; }

        [JsonProperty("last_name")]
        public string? LastName { get; set; }

        [JsonProperty("username")]
        public string? Username { get; set; }
    }
}