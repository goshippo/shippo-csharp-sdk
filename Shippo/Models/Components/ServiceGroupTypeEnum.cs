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
    /// The type of the service group.&lt;br&gt; `LIVE_RATE` - Shippo will make a rating request and return real-time rates for the shipping group, only falling back to the specified flat rate amount if no rates match a service level in the service group.&lt;br&gt; `FLAT_RATE` - Returns a shipping option with the specified flat rate amount.&lt;br&gt; `FREE_SHIPPING` - Returns a shipping option with a price of $0 only if the total cost of items exceeds the amount defined by `free_shipping_threshold_min`
    /// </summary>
    public enum ServiceGroupTypeEnum
    {
        [JsonProperty("LIVE_RATE")]
        LiveRate,
        [JsonProperty("FLAT_RATE")]
        FlatRate,
        [JsonProperty("FREE_SHIPPING")]
        FreeShipping,
    }

    public static class ServiceGroupTypeEnumExtension
    {
        public static string Value(this ServiceGroupTypeEnum value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ServiceGroupTypeEnum ToEnum(this string value)
        {
            foreach(var field in typeof(ServiceGroupTypeEnum).GetFields())
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

                    if (enumVal is ServiceGroupTypeEnum)
                    {
                        return (ServiceGroupTypeEnum)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ServiceGroupTypeEnum");
        }
    }

}