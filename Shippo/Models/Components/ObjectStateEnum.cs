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
    /// Indicates the validity of the enclosing object
    /// </summary>
    public enum ObjectStateEnum
    {
        [JsonProperty("VALID")]
        Valid,
        [JsonProperty("INVALID")]
        Invalid,
    }

    public static class ObjectStateEnumExtension
    {
        public static string Value(this ObjectStateEnum value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ObjectStateEnum ToEnum(this string value)
        {
            foreach(var field in typeof(ObjectStateEnum).GetFields())
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

                    if (enumVal is ObjectStateEnum)
                    {
                        return (ObjectStateEnum)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ObjectStateEnum");
        }
    }

}