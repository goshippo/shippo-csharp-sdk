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
    /// The incoterm reference of the shipment. FCA is available for DHL Express and FedEx only. <br/>
    /// 
    /// <remarks>
    /// eDAP is available for DPD UK only. DAP is available for DHL Express and DPD UK.<br/>
    /// If expecting DAP for other carriers, please use DDU.<br/>
    /// Allowed values available &lt;a href=&quot;#tag/Customs-Declaration-Incoterm&quot;&gt;here&lt;/a&gt;
    /// </remarks>
    /// </summary>
    public enum CustomsDeclarationIncotermEnum
    {
        [JsonProperty("DDP")]
        Ddp,
        [JsonProperty("DDU")]
        Ddu,
        [JsonProperty("FCA")]
        Fca,
        [JsonProperty("DAP")]
        Dap,
        [JsonProperty("eDAP")]
        Edap,
    }

    public static class CustomsDeclarationIncotermEnumExtension
    {
        public static string Value(this CustomsDeclarationIncotermEnum value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static CustomsDeclarationIncotermEnum ToEnum(this string value)
        {
            foreach(var field in typeof(CustomsDeclarationIncotermEnum).GetFields())
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

                    if (enumVal is CustomsDeclarationIncotermEnum)
                    {
                        return (CustomsDeclarationIncotermEnum)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum CustomsDeclarationIncotermEnum");
        }
    }

}