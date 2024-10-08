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
    /// Indicates the status of the pickup.
    /// </summary>
    public enum PickupStatus
    {
        [JsonProperty("PENDING")]
        Pending,
        [JsonProperty("CONFIRMED")]
        Confirmed,
        [JsonProperty("ERROR")]
        Error,
        [JsonProperty("CANCELLED")]
        Cancelled,
    }

    public static class PickupStatusExtension
    {
        public static string Value(this PickupStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static PickupStatus ToEnum(this string value)
        {
            foreach(var field in typeof(PickupStatus).GetFields())
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

                    if (enumVal is PickupStatus)
                    {
                        return (PickupStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum PickupStatus");
        }
    }

}