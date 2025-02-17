//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Shippo.Models.Requests
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using Shippo.Models.Components;
    using Shippo.Utils;
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Reflection;
    

    public class RegisterCarrierAccountRequestBodyType
    {
        private RegisterCarrierAccountRequestBodyType(string value) { Value = value; }

        public string Value { get; private set; }
        
        public static RegisterCarrierAccountRequestBodyType CanadaPost { get { return new RegisterCarrierAccountRequestBodyType("canada_post"); } }
        public static RegisterCarrierAccountRequestBodyType Chronopost { get { return new RegisterCarrierAccountRequestBodyType("chronopost"); } }
        public static RegisterCarrierAccountRequestBodyType Colissimo { get { return new RegisterCarrierAccountRequestBodyType("colissimo"); } }
        public static RegisterCarrierAccountRequestBodyType Correos { get { return new RegisterCarrierAccountRequestBodyType("correos"); } }
        public static RegisterCarrierAccountRequestBodyType DeutschePost { get { return new RegisterCarrierAccountRequestBodyType("deutsche_post"); } }
        public static RegisterCarrierAccountRequestBodyType DhlExpress { get { return new RegisterCarrierAccountRequestBodyType("dhl_express"); } }
        public static RegisterCarrierAccountRequestBodyType DpdDe { get { return new RegisterCarrierAccountRequestBodyType("dpd_de"); } }
        public static RegisterCarrierAccountRequestBodyType DpdUk { get { return new RegisterCarrierAccountRequestBodyType("dpd_uk"); } }
        public static RegisterCarrierAccountRequestBodyType Fedex { get { return new RegisterCarrierAccountRequestBodyType("fedex"); } }
        public static RegisterCarrierAccountRequestBodyType HermesUk { get { return new RegisterCarrierAccountRequestBodyType("hermes_uk"); } }
        public static RegisterCarrierAccountRequestBodyType MondialRelay { get { return new RegisterCarrierAccountRequestBodyType("mondial_relay"); } }
        public static RegisterCarrierAccountRequestBodyType PosteItaliane { get { return new RegisterCarrierAccountRequestBodyType("poste_italiane"); } }
        public static RegisterCarrierAccountRequestBodyType Ups { get { return new RegisterCarrierAccountRequestBodyType("ups"); } }
        public static RegisterCarrierAccountRequestBodyType Usps { get { return new RegisterCarrierAccountRequestBodyType("usps"); } }
        public static RegisterCarrierAccountRequestBodyType Sendle { get { return new RegisterCarrierAccountRequestBodyType("sendle"); } }
        public static RegisterCarrierAccountRequestBodyType Null { get { return new RegisterCarrierAccountRequestBodyType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(RegisterCarrierAccountRequestBodyType v) { return v.Value; }
        public static RegisterCarrierAccountRequestBodyType FromString(string v) {
            switch(v) {
                case "canada_post": return CanadaPost;
                case "chronopost": return Chronopost;
                case "colissimo": return Colissimo;
                case "correos": return Correos;
                case "deutsche_post": return DeutschePost;
                case "dhl_express": return DhlExpress;
                case "dpd_de": return DpdDe;
                case "dpd_uk": return DpdUk;
                case "fedex": return Fedex;
                case "hermes_uk": return HermesUk;
                case "mondial_relay": return MondialRelay;
                case "poste_italiane": return PosteItaliane;
                case "ups": return Ups;
                case "usps": return Usps;
                case "sendle": return Sendle;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for RegisterCarrierAccountRequestBodyType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((RegisterCarrierAccountRequestBodyType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    /// <summary>
    /// The body of the request.
    /// </summary>
    [JsonConverter(typeof(RegisterCarrierAccountRequestBody.RegisterCarrierAccountRequestBodyConverter))]
    public class RegisterCarrierAccountRequestBody {
        public RegisterCarrierAccountRequestBody(RegisterCarrierAccountRequestBodyType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public CarrierAccountCanadaPostCreateRequest? CarrierAccountCanadaPostCreateRequest { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public CarrierAccountChronopostCreateRequest? CarrierAccountChronopostCreateRequest { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public CarrierAccountColissimoCreateRequest? CarrierAccountColissimoCreateRequest { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public CarrierAccountCorreosCreateRequest? CarrierAccountCorreosCreateRequest { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public CarrierAccountDeutschePostCreateRequest? CarrierAccountDeutschePostCreateRequest { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public CarrierAccountDHLExpressCreateRequest? CarrierAccountDHLExpressCreateRequest { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public CarrierAccountDpdDeCreateRequest? CarrierAccountDpdDeCreateRequest { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public CarrierAccountDPDUKCreateRequest? CarrierAccountDPDUKCreateRequest { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public CarrierAccountFedExCreateRequest? CarrierAccountFedExCreateRequest { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public CarrierAccountHermesUKCreateRequest? CarrierAccountHermesUKCreateRequest { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public CarrierAccountMondialRelayCreateRequest? CarrierAccountMondialRelayCreateRequest { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public CarrierAccountPosteItalianeCreateRequest? CarrierAccountPosteItalianeCreateRequest { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public CarrierAccountUPSCreateRequest? CarrierAccountUPSCreateRequest { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public CarrierAccountUSPSCreateRequest? CarrierAccountUSPSCreateRequest { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public CarrierAccountSendleCreateRequest? CarrierAccountSendleCreateRequest { get; set; }

        public RegisterCarrierAccountRequestBodyType Type { get; set; }


        public static RegisterCarrierAccountRequestBody CreateCanadaPost(CarrierAccountCanadaPostCreateRequest canadaPost) {
            RegisterCarrierAccountRequestBodyType typ = RegisterCarrierAccountRequestBodyType.CanadaPost;
        
            RegisterCarrierAccountRequestBody res = new RegisterCarrierAccountRequestBody(typ);
            res.CarrierAccountCanadaPostCreateRequest = canadaPost;
            return res;
        }
        public static RegisterCarrierAccountRequestBody CreateChronopost(CarrierAccountChronopostCreateRequest chronopost) {
            RegisterCarrierAccountRequestBodyType typ = RegisterCarrierAccountRequestBodyType.Chronopost;
        
            RegisterCarrierAccountRequestBody res = new RegisterCarrierAccountRequestBody(typ);
            res.CarrierAccountChronopostCreateRequest = chronopost;
            return res;
        }
        public static RegisterCarrierAccountRequestBody CreateColissimo(CarrierAccountColissimoCreateRequest colissimo) {
            RegisterCarrierAccountRequestBodyType typ = RegisterCarrierAccountRequestBodyType.Colissimo;
        
            RegisterCarrierAccountRequestBody res = new RegisterCarrierAccountRequestBody(typ);
            res.CarrierAccountColissimoCreateRequest = colissimo;
            return res;
        }
        public static RegisterCarrierAccountRequestBody CreateCorreos(CarrierAccountCorreosCreateRequest correos) {
            RegisterCarrierAccountRequestBodyType typ = RegisterCarrierAccountRequestBodyType.Correos;
        
            RegisterCarrierAccountRequestBody res = new RegisterCarrierAccountRequestBody(typ);
            res.CarrierAccountCorreosCreateRequest = correos;
            return res;
        }
        public static RegisterCarrierAccountRequestBody CreateDeutschePost(CarrierAccountDeutschePostCreateRequest deutschePost) {
            RegisterCarrierAccountRequestBodyType typ = RegisterCarrierAccountRequestBodyType.DeutschePost;
        
            RegisterCarrierAccountRequestBody res = new RegisterCarrierAccountRequestBody(typ);
            res.CarrierAccountDeutschePostCreateRequest = deutschePost;
            return res;
        }
        public static RegisterCarrierAccountRequestBody CreateDhlExpress(CarrierAccountDHLExpressCreateRequest dhlExpress) {
            RegisterCarrierAccountRequestBodyType typ = RegisterCarrierAccountRequestBodyType.DhlExpress;
        
            RegisterCarrierAccountRequestBody res = new RegisterCarrierAccountRequestBody(typ);
            res.CarrierAccountDHLExpressCreateRequest = dhlExpress;
            return res;
        }
        public static RegisterCarrierAccountRequestBody CreateDpdDe(CarrierAccountDpdDeCreateRequest dpdDe) {
            RegisterCarrierAccountRequestBodyType typ = RegisterCarrierAccountRequestBodyType.DpdDe;
        
            RegisterCarrierAccountRequestBody res = new RegisterCarrierAccountRequestBody(typ);
            res.CarrierAccountDpdDeCreateRequest = dpdDe;
            return res;
        }
        public static RegisterCarrierAccountRequestBody CreateDpdUk(CarrierAccountDPDUKCreateRequest dpdUk) {
            RegisterCarrierAccountRequestBodyType typ = RegisterCarrierAccountRequestBodyType.DpdUk;
        
            RegisterCarrierAccountRequestBody res = new RegisterCarrierAccountRequestBody(typ);
            res.CarrierAccountDPDUKCreateRequest = dpdUk;
            return res;
        }
        public static RegisterCarrierAccountRequestBody CreateFedex(CarrierAccountFedExCreateRequest fedex) {
            RegisterCarrierAccountRequestBodyType typ = RegisterCarrierAccountRequestBodyType.Fedex;
        
            RegisterCarrierAccountRequestBody res = new RegisterCarrierAccountRequestBody(typ);
            res.CarrierAccountFedExCreateRequest = fedex;
            return res;
        }
        public static RegisterCarrierAccountRequestBody CreateHermesUk(CarrierAccountHermesUKCreateRequest hermesUk) {
            RegisterCarrierAccountRequestBodyType typ = RegisterCarrierAccountRequestBodyType.HermesUk;
        
            RegisterCarrierAccountRequestBody res = new RegisterCarrierAccountRequestBody(typ);
            res.CarrierAccountHermesUKCreateRequest = hermesUk;
            return res;
        }
        public static RegisterCarrierAccountRequestBody CreateMondialRelay(CarrierAccountMondialRelayCreateRequest mondialRelay) {
            RegisterCarrierAccountRequestBodyType typ = RegisterCarrierAccountRequestBodyType.MondialRelay;
        
            RegisterCarrierAccountRequestBody res = new RegisterCarrierAccountRequestBody(typ);
            res.CarrierAccountMondialRelayCreateRequest = mondialRelay;
            return res;
        }
        public static RegisterCarrierAccountRequestBody CreatePosteItaliane(CarrierAccountPosteItalianeCreateRequest posteItaliane) {
            RegisterCarrierAccountRequestBodyType typ = RegisterCarrierAccountRequestBodyType.PosteItaliane;
        
            RegisterCarrierAccountRequestBody res = new RegisterCarrierAccountRequestBody(typ);
            res.CarrierAccountPosteItalianeCreateRequest = posteItaliane;
            return res;
        }
        public static RegisterCarrierAccountRequestBody CreateUps(CarrierAccountUPSCreateRequest ups) {
            RegisterCarrierAccountRequestBodyType typ = RegisterCarrierAccountRequestBodyType.Ups;
        
            RegisterCarrierAccountRequestBody res = new RegisterCarrierAccountRequestBody(typ);
            res.CarrierAccountUPSCreateRequest = ups;
            return res;
        }
        public static RegisterCarrierAccountRequestBody CreateUsps(CarrierAccountUSPSCreateRequest usps) {
            RegisterCarrierAccountRequestBodyType typ = RegisterCarrierAccountRequestBodyType.Usps;
        
            RegisterCarrierAccountRequestBody res = new RegisterCarrierAccountRequestBody(typ);
            res.CarrierAccountUSPSCreateRequest = usps;
            return res;
        }
        public static RegisterCarrierAccountRequestBody CreateSendle(CarrierAccountSendleCreateRequest sendle) {
            RegisterCarrierAccountRequestBodyType typ = RegisterCarrierAccountRequestBodyType.Sendle;
        
            RegisterCarrierAccountRequestBody res = new RegisterCarrierAccountRequestBody(typ);
            res.CarrierAccountSendleCreateRequest = sendle;
            return res;
        }
        public static RegisterCarrierAccountRequestBody CreateNull() {
            RegisterCarrierAccountRequestBodyType typ = RegisterCarrierAccountRequestBodyType.Null;
            return new RegisterCarrierAccountRequestBody(typ);
        }

        public class RegisterCarrierAccountRequestBodyConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(RegisterCarrierAccountRequestBody);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            {
                JObject jo = JObject.Load(reader);
                string discriminator = jo.GetValue("carrier")?.ToString() ?? throw new ArgumentNullException("Could not find discriminator field.");
                if (discriminator == RegisterCarrierAccountRequestBodyType.CanadaPost.ToString())
                {
                    CarrierAccountCanadaPostCreateRequest? carrierAccountCanadaPostCreateRequest = ResponseBodyDeserializer.Deserialize<CarrierAccountCanadaPostCreateRequest>(jo.ToString());
                    return CreateCanadaPost(carrierAccountCanadaPostCreateRequest!);
                }
                if (discriminator == RegisterCarrierAccountRequestBodyType.Chronopost.ToString())
                {
                    CarrierAccountChronopostCreateRequest? carrierAccountChronopostCreateRequest = ResponseBodyDeserializer.Deserialize<CarrierAccountChronopostCreateRequest>(jo.ToString());
                    return CreateChronopost(carrierAccountChronopostCreateRequest!);
                }
                if (discriminator == RegisterCarrierAccountRequestBodyType.Colissimo.ToString())
                {
                    CarrierAccountColissimoCreateRequest? carrierAccountColissimoCreateRequest = ResponseBodyDeserializer.Deserialize<CarrierAccountColissimoCreateRequest>(jo.ToString());
                    return CreateColissimo(carrierAccountColissimoCreateRequest!);
                }
                if (discriminator == RegisterCarrierAccountRequestBodyType.Correos.ToString())
                {
                    CarrierAccountCorreosCreateRequest? carrierAccountCorreosCreateRequest = ResponseBodyDeserializer.Deserialize<CarrierAccountCorreosCreateRequest>(jo.ToString());
                    return CreateCorreos(carrierAccountCorreosCreateRequest!);
                }
                if (discriminator == RegisterCarrierAccountRequestBodyType.DeutschePost.ToString())
                {
                    CarrierAccountDeutschePostCreateRequest? carrierAccountDeutschePostCreateRequest = ResponseBodyDeserializer.Deserialize<CarrierAccountDeutschePostCreateRequest>(jo.ToString());
                    return CreateDeutschePost(carrierAccountDeutschePostCreateRequest!);
                }
                if (discriminator == RegisterCarrierAccountRequestBodyType.DhlExpress.ToString())
                {
                    CarrierAccountDHLExpressCreateRequest? carrierAccountDHLExpressCreateRequest = ResponseBodyDeserializer.Deserialize<CarrierAccountDHLExpressCreateRequest>(jo.ToString());
                    return CreateDhlExpress(carrierAccountDHLExpressCreateRequest!);
                }
                if (discriminator == RegisterCarrierAccountRequestBodyType.DpdDe.ToString())
                {
                    CarrierAccountDpdDeCreateRequest? carrierAccountDpdDeCreateRequest = ResponseBodyDeserializer.Deserialize<CarrierAccountDpdDeCreateRequest>(jo.ToString());
                    return CreateDpdDe(carrierAccountDpdDeCreateRequest!);
                }
                if (discriminator == RegisterCarrierAccountRequestBodyType.DpdUk.ToString())
                {
                    CarrierAccountDPDUKCreateRequest? carrierAccountDPDUKCreateRequest = ResponseBodyDeserializer.Deserialize<CarrierAccountDPDUKCreateRequest>(jo.ToString());
                    return CreateDpdUk(carrierAccountDPDUKCreateRequest!);
                }
                if (discriminator == RegisterCarrierAccountRequestBodyType.Fedex.ToString())
                {
                    CarrierAccountFedExCreateRequest? carrierAccountFedExCreateRequest = ResponseBodyDeserializer.Deserialize<CarrierAccountFedExCreateRequest>(jo.ToString());
                    return CreateFedex(carrierAccountFedExCreateRequest!);
                }
                if (discriminator == RegisterCarrierAccountRequestBodyType.HermesUk.ToString())
                {
                    CarrierAccountHermesUKCreateRequest? carrierAccountHermesUKCreateRequest = ResponseBodyDeserializer.Deserialize<CarrierAccountHermesUKCreateRequest>(jo.ToString());
                    return CreateHermesUk(carrierAccountHermesUKCreateRequest!);
                }
                if (discriminator == RegisterCarrierAccountRequestBodyType.MondialRelay.ToString())
                {
                    CarrierAccountMondialRelayCreateRequest? carrierAccountMondialRelayCreateRequest = ResponseBodyDeserializer.Deserialize<CarrierAccountMondialRelayCreateRequest>(jo.ToString());
                    return CreateMondialRelay(carrierAccountMondialRelayCreateRequest!);
                }
                if (discriminator == RegisterCarrierAccountRequestBodyType.PosteItaliane.ToString())
                {
                    CarrierAccountPosteItalianeCreateRequest? carrierAccountPosteItalianeCreateRequest = ResponseBodyDeserializer.Deserialize<CarrierAccountPosteItalianeCreateRequest>(jo.ToString());
                    return CreatePosteItaliane(carrierAccountPosteItalianeCreateRequest!);
                }
                if (discriminator == RegisterCarrierAccountRequestBodyType.Ups.ToString())
                {
                    CarrierAccountUPSCreateRequest? carrierAccountUPSCreateRequest = ResponseBodyDeserializer.Deserialize<CarrierAccountUPSCreateRequest>(jo.ToString());
                    return CreateUps(carrierAccountUPSCreateRequest!);
                }
                if (discriminator == RegisterCarrierAccountRequestBodyType.Usps.ToString())
                {
                    CarrierAccountUSPSCreateRequest? carrierAccountUSPSCreateRequest = ResponseBodyDeserializer.Deserialize<CarrierAccountUSPSCreateRequest>(jo.ToString());
                    return CreateUsps(carrierAccountUSPSCreateRequest!);
                }
                if (discriminator == RegisterCarrierAccountRequestBodyType.Sendle.ToString())
                {
                    CarrierAccountSendleCreateRequest? carrierAccountSendleCreateRequest = ResponseBodyDeserializer.Deserialize<CarrierAccountSendleCreateRequest>(jo.ToString());
                    return CreateSendle(carrierAccountSendleCreateRequest!);
                }

                throw new InvalidOperationException("Could not deserialize into any supported types.");
            }

            public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
            {
                if (value == null) {
                    writer.WriteRawValue("null");
                    return;
                }
                RegisterCarrierAccountRequestBody res = (RegisterCarrierAccountRequestBody)value;
                if (RegisterCarrierAccountRequestBodyType.FromString(res.Type).Equals(RegisterCarrierAccountRequestBodyType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.CarrierAccountCanadaPostCreateRequest != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.CarrierAccountCanadaPostCreateRequest));
                    return;
                }
                if (res.CarrierAccountChronopostCreateRequest != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.CarrierAccountChronopostCreateRequest));
                    return;
                }
                if (res.CarrierAccountColissimoCreateRequest != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.CarrierAccountColissimoCreateRequest));
                    return;
                }
                if (res.CarrierAccountCorreosCreateRequest != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.CarrierAccountCorreosCreateRequest));
                    return;
                }
                if (res.CarrierAccountDeutschePostCreateRequest != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.CarrierAccountDeutschePostCreateRequest));
                    return;
                }
                if (res.CarrierAccountDHLExpressCreateRequest != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.CarrierAccountDHLExpressCreateRequest));
                    return;
                }
                if (res.CarrierAccountDpdDeCreateRequest != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.CarrierAccountDpdDeCreateRequest));
                    return;
                }
                if (res.CarrierAccountDPDUKCreateRequest != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.CarrierAccountDPDUKCreateRequest));
                    return;
                }
                if (res.CarrierAccountFedExCreateRequest != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.CarrierAccountFedExCreateRequest));
                    return;
                }
                if (res.CarrierAccountHermesUKCreateRequest != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.CarrierAccountHermesUKCreateRequest));
                    return;
                }
                if (res.CarrierAccountMondialRelayCreateRequest != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.CarrierAccountMondialRelayCreateRequest));
                    return;
                }
                if (res.CarrierAccountPosteItalianeCreateRequest != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.CarrierAccountPosteItalianeCreateRequest));
                    return;
                }
                if (res.CarrierAccountUPSCreateRequest != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.CarrierAccountUPSCreateRequest));
                    return;
                }
                if (res.CarrierAccountUSPSCreateRequest != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.CarrierAccountUSPSCreateRequest));
                    return;
                }
                if (res.CarrierAccountSendleCreateRequest != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.CarrierAccountSendleCreateRequest));
                    return;
                }

            }

        }

    }
}