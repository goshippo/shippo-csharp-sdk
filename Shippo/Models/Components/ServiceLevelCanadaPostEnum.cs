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
    
    /// <summary>
    /// |Token | Service name|<br/>
    /// 
    /// <remarks>
    /// |:---|:---|<br/>
    /// | canada_post_regular_parcel | Regular Parcel|<br/>
    /// | canada_post_expedited_parcel | Expedited Parcel|<br/>
    /// | canada_post_priority | Priority|<br/>
    /// | canada_post_xpresspost | Xpresspost|<br/>
    /// | canada_post_xpresspost_international | Xpresspost International|<br/>
    /// | canada_post_xpresspost_usa | Xpresspost USA|<br/>
    /// | canada_post_expedited_parcel_usa | Expedited Parcel USA|<br/>
    /// | canada_post_tracked_packet_usa | Tracked Packet USA|<br/>
    /// | canada_post_small_packet_usa_air | Small Packet USA Air|<br/>
    /// | canada_post_tracked_packet_international | Tracked Packet International|<br/>
    /// | canada_post_small_packet_international_air | Small Package International Air|<br/>
    /// 
    /// </remarks>
    /// </summary>
    public enum ServiceLevelCanadaPostEnum
    {
        [JsonProperty("canada_post_regular_parcel")]
        CanadaPostRegularParcel,
        [JsonProperty("canada_post_expedited_parcel")]
        CanadaPostExpeditedParcel,
        [JsonProperty("canada_post_priority")]
        CanadaPostPriority,
        [JsonProperty("canada_post_xpresspost")]
        CanadaPostXpresspost,
        [JsonProperty("canada_post_xpresspost_international")]
        CanadaPostXpresspostInternational,
        [JsonProperty("canada_post_xpresspost_usa")]
        CanadaPostXpresspostUsa,
        [JsonProperty("canada_post_expedited_parcel_usa")]
        CanadaPostExpeditedParcelUsa,
        [JsonProperty("canada_post_tracked_packet_usa")]
        CanadaPostTrackedPacketUsa,
        [JsonProperty("canada_post_small_packet_usa_air")]
        CanadaPostSmallPacketUsaAir,
        [JsonProperty("canada_post_tracked_packet_international")]
        CanadaPostTrackedPacketInternational,
        [JsonProperty("canada_post_small_packet_international_air")]
        CanadaPostSmallPacketInternationalAir,
    }

    public static class ServiceLevelCanadaPostEnumExtension
    {
        public static string Value(this ServiceLevelCanadaPostEnum value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ServiceLevelCanadaPostEnum ToEnum(this string value)
        {
            foreach(var field in typeof(ServiceLevelCanadaPostEnum).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is ServiceLevelCanadaPostEnum)
                    {
                        return (ServiceLevelCanadaPostEnum)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ServiceLevelCanadaPostEnum");
        }
    }

}