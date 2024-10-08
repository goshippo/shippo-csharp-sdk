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
    /// |Token | Name | Dimensions|<br/>
    /// 
    /// <remarks>
    /// |:---|:---|:---|<br/>
    /// | UPS_Box_10kg | Box 10kg | 410.00 x 335.00 x 265.00 mm|<br/>
    /// | UPS_Box_25kg | Box 25kg | 484.00 x 433.00 x 350.00 mm|<br/>
    /// | UPS_Express_Box | Express Box | 460.00 x 315.00 x 95.00 mm|<br/>
    /// | UPS_Express_Box_Large | Express Box Large | 18.00 x 13.00 x 3.00 in|<br/>
    /// | UPS_Express_Box_Medium | Express Box Medium | 15.00 x 11.00 x 3.00 in|<br/>
    /// | UPS_Express_Box_Small | Express Box Small | 13.00 x 11.00 x 2.00 in|<br/>
    /// | UPS_Express_Envelope | Express Envelope | 12.50 x 9.50 x 2.00 in|<br/>
    /// | UPS_Express_Hard_Pak | Express Hard Pak | 14.75 x 11.50 x 2.00 in|<br/>
    /// | UPS_Express_Legal_Envelope | Express Legal Envelope | 15.00 x 9.50 x 2.00 in|<br/>
    /// | UPS_Express_Pak | Express Pak | 16.00 x 12.75 x 2.00 in|<br/>
    /// | UPS_Express_Tube | Express Tube | 970.00 x 190.00 x 165.00 mm|<br/>
    /// | UPS_Laboratory_Pak | Laboratory Pak | 17.25 x 12.75 x 2.00 in|<br/>
    /// | UPS_MI_BPM | BPM (Mail Innovations - Domestic &amp;amp; International) | 0.00 x 0.00 x 0.00 in|<br/>
    /// | UPS_MI_BPM_Flat | BPM Flat (Mail Innovations - Domestic &amp;amp; International) | 0.00 x 0.00 x 0.00 in|<br/>
    /// | UPS_MI_BPM_Parcel | BPM Parcel (Mail Innovations - Domestic &amp;amp; International) | 0.00 x 0.00 x 0.00 in|<br/>
    /// | UPS_MI_First_Class | First Class (Mail Innovations - Domestic only) | 0.00 x 0.00 x 0.00 in|<br/>
    /// | UPS_MI_Flat | Flat (Mail Innovations - Domestic only) | 0.00 x 0.00 x 0.00 in|<br/>
    /// | UPS_MI_Irregular | Irregular (Mail Innovations - Domestic only) | 0.00 x 0.00 x 0.00 in|<br/>
    /// | UPS_MI_Machinable | Machinable (Mail Innovations - Domestic only) | 0.00 x 0.00 x 0.00 in|<br/>
    /// | UPS_MI_MEDIA_MAIL | Media Mail (Mail Innovations - Domestic only) | 0.00 x 0.00 x 0.00 in|<br/>
    /// | UPS_MI_Parcel_Post | Parcel Post (Mail Innovations - Domestic only) | 0.00 x 0.00 x 0.00 in|<br/>
    /// | UPS_MI_Priority | Priority (Mail Innovations - Domestic only) | 0.00 x 0.00 x 0.00 in|<br/>
    /// | UPS_MI_Standard_Flat | Standard Flat (Mail Innovations - Domestic only) | 0.00 x 0.00 x 0.00 in|<br/>
    /// | UPS_Pad_Pak | Pad Pak | 14.75 x 11.00 x 2.00 in|<br/>
    /// | UPS_Pallet | Pallet | 120.00 x 80.00 x 200.00 cm|<br/>
    /// 
    /// </remarks>
    /// </summary>
    public enum ParcelTemplateUPSEnum
    {
        [JsonProperty("UPS_Box_10kg")]
        UPSBox10kg,
        [JsonProperty("UPS_Box_25kg")]
        UPSBox25kg,
        [JsonProperty("UPS_Express_Box")]
        UPSExpressBox,
        [JsonProperty("UPS_Express_Box_Large")]
        UPSExpressBoxLarge,
        [JsonProperty("UPS_Express_Box_Medium")]
        UPSExpressBoxMedium,
        [JsonProperty("UPS_Express_Box_Small")]
        UPSExpressBoxSmall,
        [JsonProperty("UPS_Express_Envelope")]
        UPSExpressEnvelope,
        [JsonProperty("UPS_Express_Hard_Pak")]
        UPSExpressHardPak,
        [JsonProperty("UPS_Express_Legal_Envelope")]
        UPSExpressLegalEnvelope,
        [JsonProperty("UPS_Express_Pak")]
        UPSExpressPak,
        [JsonProperty("UPS_Express_Tube")]
        UPSExpressTube,
        [JsonProperty("UPS_Laboratory_Pak")]
        UPSLaboratoryPak,
        [JsonProperty("UPS_MI_BPM")]
        UpsMiBpm,
        [JsonProperty("UPS_MI_BPM_Flat")]
        UPSMIBPMFlat,
        [JsonProperty("UPS_MI_BPM_Parcel")]
        UPSMIBPMParcel,
        [JsonProperty("UPS_MI_First_Class")]
        UPSMIFirstClass,
        [JsonProperty("UPS_MI_Flat")]
        UPSMIFlat,
        [JsonProperty("UPS_MI_Irregular")]
        UPSMIIrregular,
        [JsonProperty("UPS_MI_Machinable")]
        UPSMIMachinable,
        [JsonProperty("UPS_MI_MEDIA_MAIL")]
        UpsMiMediaMail,
        [JsonProperty("UPS_MI_Parcel_Post")]
        UPSMIParcelPost,
        [JsonProperty("UPS_MI_Priority")]
        UPSMIPriority,
        [JsonProperty("UPS_MI_Standard_Flat")]
        UPSMIStandardFlat,
        [JsonProperty("UPS_Pad_Pak")]
        UPSPadPak,
        [JsonProperty("UPS_Pallet")]
        UPSPallet,
    }

    public static class ParcelTemplateUPSEnumExtension
    {
        public static string Value(this ParcelTemplateUPSEnum value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ParcelTemplateUPSEnum ToEnum(this string value)
        {
            foreach(var field in typeof(ParcelTemplateUPSEnum).GetFields())
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

                    if (enumVal is ParcelTemplateUPSEnum)
                    {
                        return (ParcelTemplateUPSEnum)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ParcelTemplateUPSEnum");
        }
    }

}