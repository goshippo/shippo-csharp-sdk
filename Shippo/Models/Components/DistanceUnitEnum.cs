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
    /// The measure unit used for length, width and height.
    /// </summary>
    public enum DistanceUnitEnum
    {
        [JsonProperty("cm")]
        Cm,
        [JsonProperty("in")]
        In,
        [JsonProperty("ft")]
        Ft,
        [JsonProperty("m")]
        M,
        [JsonProperty("mm")]
        Mm,
        [JsonProperty("yd")]
        Yd,
    }

    public static class DistanceUnitEnumExtension
    {
        public static string Value(this DistanceUnitEnum value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static DistanceUnitEnum ToEnum(this string value)
        {
            foreach(var field in typeof(DistanceUnitEnum).GetFields())
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

                    if (enumVal is DistanceUnitEnum)
                    {
                        return (DistanceUnitEnum)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum DistanceUnitEnum");
        }
    }

}