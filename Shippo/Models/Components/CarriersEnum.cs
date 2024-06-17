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
    /// |Token | Carrier name|<br/>
    /// 
    /// <remarks>
    /// |:---|:---|<br/>
    /// | airterra | Airterra |<br/>
    /// | apc_postal | APC Postal|<br/>
    /// | apg | APG|<br/>
    /// | aramex | Aramex|<br/>
    /// | asendia_us | Asendia US|<br/>
    /// | australia_post | Australia Post (also used for Startrack)|<br/>
    /// | axlehire | Jitsu|<br/>
    /// | better_trucks | BetterTrucks|<br/>
    /// | borderguru | BorderGuru|<br/>
    /// | boxberry | Boxberry|<br/>
    /// | bring | Bring (also used for Posten Norge)|<br/>
    /// | canada_post | Canada Post|<br/>
    /// | cdl | CDL|<br/>
    /// | chronopost | Chronopost|<br/>
    /// | collect_plus | CollectPlus|<br/>
    /// | correios_br | CorreiosBR|<br/>
    /// | correos_espana | Correos España |<br/>
    /// | couriersplease | Couriers Please|<br/>
    /// | colissimo | Colissimo|<br/>
    /// | deutsche_post | Deutsche Post|<br/>
    /// | dhl_benelux | DHL Benelux|<br/>
    /// | dhl_ecommerce | DHL eCommerce|<br/>
    /// | dhl_express | DHL Express|<br/>
    /// | dhl_germany_c2c | DHL Germany C2C|<br/>
    /// | dhl_germany | DHL Germany|<br/>
    /// | dpd_de | DPD GERMANY|<br/>
    /// | dpd_uk | DPD UK|<br/>
    /// | estafeta | Estafeta|<br/>
    /// | fastway_australia | Aramex|<br/>
    /// | fedex | FedEx|<br/>
    /// | globegistics | Globegistics (now Asendia)|<br/>
    /// | gls_us | GLS US|<br/>
    /// | gophr | Gophr|<br/>
    /// | gso | GSO|<br/>
    /// | hermes_germany_b2c | Hermes Germany B2C|<br/>
    /// | hermes_uk | Evri UK |<br/>
    /// | hongkong_post | Hongkong Post|<br/>
    /// | lasership | LaserShip|<br/>
    /// | lso | LSO|<br/>
    /// | mondial_relay | Mondial Relay|<br/>
    /// | new_zealand_post | New Zealand Post (also used for Pace and CourierPost)|<br/>
    /// | nippon_express | Nippon Express|<br/>
    /// | ontrac | OnTrac|<br/>
    /// | orangeds | OrangeDS|<br/>
    /// | parcelforce | Parcelforce|<br/>
    /// | parcel | Parcel|<br/>
    /// | passport | Passport|<br/>
    /// | pcf | PCF|<br/>
    /// | poste_italiane | Poste Italiane |<br/>
    /// | posti | Posti|<br/>
    /// | purolator | Purolator|<br/>
    /// | royal_mail | Royal Mail|<br/>
    /// | rr_donnelley | ePost Global|<br/>
    /// | russian_post | Russian Post|<br/>
    /// | sendle | Sendle|<br/>
    /// | skypostal | SkyPostal|<br/>
    /// | stuart | Stuart|<br/>
    /// | swyft | Swyft|<br/>
    /// | uds | UDS (United Delivery Service)|<br/>
    /// | ups | UPS|<br/>
    /// | usps | USPS|<br/>
    /// | veho | Veho |<br/>
    /// | x_delivery | X Delivery (now Maergo)|<br/>
    /// | yodel | Yodel|<br/>
    /// 
    /// </remarks>
    /// </summary>
    public enum CarriersEnum
    {
        [JsonProperty("airterra")]
        Airterra,
        [JsonProperty("apc_postal")]
        ApcPostal,
        [JsonProperty("apg")]
        Apg,
        [JsonProperty("aramex")]
        Aramex,
        [JsonProperty("asendia_us")]
        AsendiaUs,
        [JsonProperty("australia_post")]
        AustraliaPost,
        [JsonProperty("axlehire")]
        Axlehire,
        [JsonProperty("better_trucks")]
        BetterTrucks,
        [JsonProperty("borderguru")]
        Borderguru,
        [JsonProperty("boxberry")]
        Boxberry,
        [JsonProperty("bring")]
        Bring,
        [JsonProperty("canada_post")]
        CanadaPost,
        [JsonProperty("cdl")]
        Cdl,
        [JsonProperty("chronopost")]
        Chronopost,
        [JsonProperty("collect_plus")]
        CollectPlus,
        [JsonProperty("correios_br")]
        CorreiosBr,
        [JsonProperty("correos_espana")]
        CorreosEspana,
        [JsonProperty("couriersplease")]
        Couriersplease,
        [JsonProperty("colissimo")]
        Colissimo,
        [JsonProperty("deutsche_post")]
        DeutschePost,
        [JsonProperty("dhl_benelux")]
        DhlBenelux,
        [JsonProperty("dhl_ecommerce")]
        DhlEcommerce,
        [JsonProperty("dhl_express")]
        DhlExpress,
        [JsonProperty("dhl_germany_c2c")]
        DhlGermanyC2c,
        [JsonProperty("dhl_germany")]
        DhlGermany,
        [JsonProperty("dpd_de")]
        DpdDe,
        [JsonProperty("dpd_uk")]
        DpdUk,
        [JsonProperty("estafeta")]
        Estafeta,
        [JsonProperty("fastway_australia")]
        FastwayAustralia,
        [JsonProperty("fedex")]
        Fedex,
        [JsonProperty("globegistics")]
        Globegistics,
        [JsonProperty("gls_us")]
        GlsUs,
        [JsonProperty("gophr")]
        Gophr,
        [JsonProperty("gso")]
        Gso,
        [JsonProperty("hermes_germany_b2c")]
        HermesGermanyB2c,
        [JsonProperty("hermes_uk")]
        HermesUk,
        [JsonProperty("hongkong_post")]
        HongkongPost,
        [JsonProperty("lasership")]
        Lasership,
        [JsonProperty("lso")]
        Lso,
        [JsonProperty("mondial_relay")]
        MondialRelay,
        [JsonProperty("new_zealand_post")]
        NewZealandPost,
        [JsonProperty("nippon_express")]
        NipponExpress,
        [JsonProperty("ontrac")]
        Ontrac,
        [JsonProperty("orangeds")]
        Orangeds,
        [JsonProperty("parcelforce")]
        Parcelforce,
        [JsonProperty("parcel")]
        Parcel,
        [JsonProperty("passport")]
        Passport,
        [JsonProperty("pcf")]
        Pcf,
        [JsonProperty("poste_italiane")]
        PosteItaliane,
        [JsonProperty("posti")]
        Posti,
        [JsonProperty("purolator")]
        Purolator,
        [JsonProperty("royal_mail")]
        RoyalMail,
        [JsonProperty("rr_donnelley")]
        RrDonnelley,
        [JsonProperty("russian_post")]
        RussianPost,
        [JsonProperty("sendle")]
        Sendle,
        [JsonProperty("skypostal")]
        Skypostal,
        [JsonProperty("stuart")]
        Stuart,
        [JsonProperty("swyft")]
        Swyft,
        [JsonProperty("uds")]
        Uds,
        [JsonProperty("ups")]
        Ups,
        [JsonProperty("usps")]
        Usps,
        [JsonProperty("veho")]
        Veho,
        [JsonProperty("x_delivery")]
        XDelivery,
        [JsonProperty("yodel")]
        Yodel,
    }

    public static class CarriersEnumExtension
    {
        public static string Value(this CarriersEnum value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static CarriersEnum ToEnum(this string value)
        {
            foreach(var field in typeof(CarriersEnum).GetFields())
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

                    if (enumVal is CarriersEnum)
                    {
                        return (CarriersEnum)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum CarriersEnum");
        }
    }

}