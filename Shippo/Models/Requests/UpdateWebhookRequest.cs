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
    
    public class UpdateWebhookRequest
    {

        /// <summary>
        /// Object ID of the webhook to retrieve
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=webhookId")]
        public string WebhookId { get; set; } = default!;

        [SpeakeasyMetadata("request:mediaType=application/json")]
        public WebhookUpdateRequest WebhookUpdateRequest { get; set; } = default!;
    }
}