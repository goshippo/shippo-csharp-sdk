//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Shippo.Models.Requests
{
    using Shippo.Utils;
    
    public class GetUserParcelTemplateRequest
    {

        /// <summary>
        /// Object ID of the user parcel template
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=UserParcelTemplateObjectId")]
        public string UserParcelTemplateObjectId { get; set; } = default!;

        /// <summary>
        /// Optional string used to pick a non-default API version to use. See our &lt;a href=&quot;https://docs.goshippo.com/docs/api_concepts/apiversioning/&quot;&gt;API version&lt;/a&gt; guide.
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=SHIPPO-API-VERSION")]
        public string? ShippoApiVersion { get; set; }
    }
}