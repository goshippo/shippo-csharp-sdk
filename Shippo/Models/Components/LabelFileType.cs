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
    
    public enum LabelFileType
    {
        [JsonProperty("PNG")]
        Png,
        [JsonProperty("PNG_2.3x7.5")]
        Png23x75,
        [JsonProperty("PDF")]
        Pdf,
        [JsonProperty("PDF_2.3x7.5")]
        Pdf23x75,
        [JsonProperty("PDF_4x6")]
        Pdf4x6,
        [JsonProperty("PDF_4x8")]
        Pdf4x8,
        [JsonProperty("PDF_A4")]
        PdfA4,
        [JsonProperty("PDF_A6")]
        PdfA6,
        [JsonProperty("ZPLII")]
        Zplii,
    }

    public static class LabelFileTypeExtension
    {
        public static string Value(this LabelFileType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static LabelFileType ToEnum(this string value)
        {
            foreach(var field in typeof(LabelFileType).GetFields())
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

                    if (enumVal is LabelFileType)
                    {
                        return (LabelFileType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum LabelFileType");
        }
    }

}