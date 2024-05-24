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
    /// Used for some Service Levels to link to the more &quot;generic&quot; version of this Service Level - for example, <br/>
    /// 
    /// <remarks>
    /// if this Service Level is a variation specific to shipments to Europe(&quot;ups_saver_eu&quot;), the &quot;parent&quot; is <br/>
    /// the fully generic version (&quot;ups_saver&quot;). Helpful when displaying Service Levels to users. Has the same <br/>
    /// structure of the servicelevel - &quot;name&quot;, &quot;token&quot;, &quot;terms&quot;, and &quot;extended_token&quot;, or it is otherwise null.
    /// </remarks>
    /// </summary>
    public class ParentServicelevel
    {

        /// <summary>
        /// Name of the Rate&apos;s servicelevel, e.g. `International Priority` or `Standard Post`. <br/>
        /// 
        /// <remarks>
        /// A servicelevel commonly defines the transit time of a Shipment (e.g., Express vs. Standard), along with other properties. <br/>
        /// These names vary depending on the provider.
        /// </remarks>
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Further clarification of the service.
        /// </summary>
        [JsonProperty("terms")]
        public string? Terms { get; set; }

        /// <summary>
        /// Token of the Rate&apos;s servicelevel, e.g. `usps_priority` or `fedex_ground`. <br/>
        /// 
        /// <remarks>
        /// See &lt;a href=&quot;#tag/Service-Levels&quot;&gt;servicelevels&lt;/a&gt;.
        /// </remarks>
        /// </summary>
        [JsonProperty("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Unique, extended version of the Service Level &quot;token&quot;. <br/>
        /// 
        /// <remarks>
        /// Guaranteed to be unique across all Service Levels, and may help offer insight into the specific Service Level it describes.
        /// </remarks>
        /// </summary>
        [JsonProperty("extended_token")]
        public string? ExtendedToken { get; set; }
    }
}