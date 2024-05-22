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
    /// | same_day | Next Day|<br/>
    /// | next_day | Next Day|<br/>
    /// 
    /// </remarks>
    /// </summary>
    public enum ServiceLevelSwyftEnum
    {
        [JsonProperty("same_day")]
        SameDay,
        [JsonProperty("next_day")]
        NextDay,
    }

    public static class ServiceLevelSwyftEnumExtension
    {
        public static string Value(this ServiceLevelSwyftEnum value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ServiceLevelSwyftEnum ToEnum(this string value)
        {
            foreach(var field in typeof(ServiceLevelSwyftEnum).GetFields())
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

                    if (enumVal is ServiceLevelSwyftEnum)
                    {
                        return (ServiceLevelSwyftEnum)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ServiceLevelSwyftEnum");
        }
    }

}