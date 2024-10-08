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
    /// Current state of the order. See the &lt;a href=&quot;https://docs.goshippo.com/docs/orders/orders/&quot;&gt;orders tutorial&lt;/a&gt; <br/>
    /// 
    /// <remarks>
    /// for the logic of how the status is handled.
    /// </remarks>
    /// </summary>
    public enum OrderStatusEnum
    {
        [JsonProperty("UNKNOWN")]
        Unknown,
        [JsonProperty("AWAITPAY")]
        Awaitpay,
        [JsonProperty("PAID")]
        Paid,
        [JsonProperty("REFUNDED")]
        Refunded,
        [JsonProperty("CANCELLED")]
        Cancelled,
        [JsonProperty("PARTIALLY_FULFILLED")]
        PartiallyFulfilled,
        [JsonProperty("SHIPPED")]
        Shipped,
    }

    public static class OrderStatusEnumExtension
    {
        public static string Value(this OrderStatusEnum value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static OrderStatusEnum ToEnum(this string value)
        {
            foreach(var field in typeof(OrderStatusEnum).GetFields())
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

                    if (enumVal is OrderStatusEnum)
                    {
                        return (OrderStatusEnum)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum OrderStatusEnum");
        }
    }

}