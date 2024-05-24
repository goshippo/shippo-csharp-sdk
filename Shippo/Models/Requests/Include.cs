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
    using Newtonsoft.Json;
    using Shippo.Utils;
    using System;
    
    /// <summary>
    /// filter by user or enabled
    /// </summary>
    public enum Include
    {
        [JsonProperty("all")]
        All,
        [JsonProperty("user")]
        User,
        [JsonProperty("enabled")]
        Enabled,
    }

    public static class IncludeExtension
    {
        public static string Value(this Include value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static Include ToEnum(this string value)
        {
            foreach(var field in typeof(Include).GetFields())
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

                    if (enumVal is Include)
                    {
                        return (Include)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum Include");
        }
    }

}