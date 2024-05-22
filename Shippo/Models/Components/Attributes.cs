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
    
    public enum Attributes
    {
        [JsonProperty("BESTVALUE")]
        Bestvalue,
        [JsonProperty("CHEAPEST")]
        Cheapest,
        [JsonProperty("FASTEST")]
        Fastest,
    }

    public static class AttributesExtension
    {
        public static string Value(this Attributes value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static Attributes ToEnum(this string value)
        {
            foreach(var field in typeof(Attributes).GetFields())
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

                    if (enumVal is Attributes)
                    {
                        return (Attributes)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum Attributes");
        }
    }

}