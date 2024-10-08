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
    /// Object that represents the address of the importer
    /// </summary>
    public class AddressImporter
    {

        /// <summary>
        /// First and Last Name of the addressee
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Company Name
        /// </summary>
        [JsonProperty("company")]
        public string? Company { get; set; }

        /// <summary>
        /// First street line, 35 character limit. Usually street number and street name (except for DHL Germany, see street_no).
        /// </summary>
        [JsonProperty("street1")]
        public string? Street1 { get; set; }

        /// <summary>
        /// Second street line, 35 character limit.
        /// </summary>
        [JsonProperty("street2")]
        public string? Street2 { get; set; }

        /// <summary>
        /// Third street line, 35 character limit. <br/>
        /// 
        /// <remarks>
        /// Only accepted for USPS international shipments, UPS domestic and UPS international shipments.
        /// </remarks>
        /// </summary>
        [JsonProperty("street3")]
        public string? Street3 { get; set; }

        /// <summary>
        /// Street number of the addressed building. <br/>
        /// 
        /// <remarks>
        /// This field can be included in street1 for all carriers except for DHL Germany.
        /// </remarks>
        /// </summary>
        [JsonProperty("street_no")]
        public string? StreetNo { get; set; }

        /// <summary>
        /// Name of a city
        /// </summary>
        [JsonProperty("city")]
        public string? City { get; set; }

        /// <summary>
        /// **required for purchase for some countries**&lt;br&gt;<br/>
        /// 
        /// <remarks>
        /// State/Province values are required for shipments from/to the US, AU, and CA. UPS requires province for some <br/>
        /// countries (i.e Ireland). To receive more accurate quotes, passing this field is recommended. Most carriers <br/>
        /// only accept two or three character state abbreviations.
        /// </remarks>
        /// </summary>
        [JsonProperty("state")]
        public string? State { get; set; }

        /// <summary>
        /// Postal code of an Address.
        /// </summary>
        [JsonProperty("zip")]
        public string? Zip { get; set; }

        /// <summary>
        /// Example: `US` or `DE`. All accepted values can be found on the <br/>
        /// 
        /// <remarks>
        /// &lt;a href=&quot;http://www.iso.org/&quot; target=&quot;blank&quot;&gt;Official ISO Website&lt;/a&gt;.<br/>
        /// Sending a country is always required.
        /// </remarks>
        /// </summary>
        [JsonProperty("country")]
        public string? Country { get; set; }

        /// <summary>
        /// Addresses containing a phone number allow carriers to call the recipient when delivering the Parcel. This <br/>
        /// 
        /// <remarks>
        /// increases the probability of delivery and helps to avoid accessorial charges after a Parcel has been shipped.    
        /// </remarks>
        /// </summary>
        [JsonProperty("phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// E-mail address of the contact person, RFC3696/5321-compliant.
        /// </summary>
        [JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Indicates whether the address provided is a residential address or not.
        /// </summary>
        [JsonProperty("is_residential")]
        public bool? IsResidential { get; set; }
    }
}