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
    using System;
    
    /// <summary>
    /// To have insurance cover provided by a carrier directly instead of Shippo&apos;s provider (XCover), set `provider` to `FEDEX`, `UPS`, or `ONTRAC`.
    /// </summary>
    public enum Provider
    {
        [JsonProperty("FEDEX")]
        Fedex,
        [JsonProperty("UPS")]
        Ups,
        [JsonProperty("ONTRAC")]
        Ontrac,
    }

    public static class ProviderExtension
    {
        public static string Value(this Provider value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static Provider ToEnum(this string value)
        {
            foreach(var field in typeof(Provider).GetFields())
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

                    if (enumVal is Provider)
                    {
                        return (Provider)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum Provider");
        }
    }

}