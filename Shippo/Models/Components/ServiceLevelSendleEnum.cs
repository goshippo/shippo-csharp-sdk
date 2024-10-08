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
    /// |Token | Service name|<br/>
    /// 
    /// <remarks>
    /// |:---|:---|<br/>
    /// | sendle_parcel | Sendle Parcel|<br/>
    /// | sendle_standard_dropoff | Sendle Standard Dropoff|<br/>
    /// 
    /// </remarks>
    /// </summary>
    public enum ServiceLevelSendleEnum
    {
        [JsonProperty("sendle_parcel")]
        SendleParcel,
        [JsonProperty("sendle_standard_dropoff")]
        SendleStandardDropoff,
    }

    public static class ServiceLevelSendleEnumExtension
    {
        public static string Value(this ServiceLevelSendleEnum value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ServiceLevelSendleEnum ToEnum(this string value)
        {
            foreach(var field in typeof(ServiceLevelSendleEnum).GetFields())
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

                    if (enumVal is ServiceLevelSendleEnum)
                    {
                        return (ServiceLevelSendleEnum)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ServiceLevelSendleEnum");
        }
    }

}