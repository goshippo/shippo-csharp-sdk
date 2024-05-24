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
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json;
    using Shippo.Models.Components;
    using Shippo.Utils;
    using System.Numerics;
    using System;
    

    public class LiveRateCreateRequestAddressFromType
    {
        private LiveRateCreateRequestAddressFromType(string value) { Value = value; }

        public string Value { get; private set; }
        public static LiveRateCreateRequestAddressFromType Str { get { return new LiveRateCreateRequestAddressFromType("str"); } }
        
        public static LiveRateCreateRequestAddressFromType AddressCompleteCreateRequest { get { return new LiveRateCreateRequestAddressFromType("AddressCompleteCreateRequest"); } }
        
        public static LiveRateCreateRequestAddressFromType Null { get { return new LiveRateCreateRequestAddressFromType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(LiveRateCreateRequestAddressFromType v) { return v.Value; }
        public static LiveRateCreateRequestAddressFromType FromString(string v) {
            switch(v) {
                case "str": return Str;
                case "AddressCompleteCreateRequest": return AddressCompleteCreateRequest;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for LiveRateCreateRequestAddressFromType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((LiveRateCreateRequestAddressFromType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
    
/// <summary>
/// The sender address, which includes your name, company name, street address, city, state, zip code, <br/>
/// 
/// <remarks>
/// country, phone number, and email address (strings). Special characters should not be included in <br/>
/// any address element, especially name, company, and email.
/// </remarks>
/// </summary>
    [JsonConverter(typeof(LiveRateCreateRequestAddressFrom.LiveRateCreateRequestAddressFromConverter))]
    public class LiveRateCreateRequestAddressFrom {
        public LiveRateCreateRequestAddressFrom(LiveRateCreateRequestAddressFromType type) {
            Type = type;
        }
        public string? Str { get; set; } 
        public AddressCompleteCreateRequest? AddressCompleteCreateRequest { get; set; } 

        public LiveRateCreateRequestAddressFromType Type { get; set; }


        public static LiveRateCreateRequestAddressFrom CreateStr(string str) {
            LiveRateCreateRequestAddressFromType typ = LiveRateCreateRequestAddressFromType.Str;

            LiveRateCreateRequestAddressFrom res = new LiveRateCreateRequestAddressFrom(typ);
            res.Str = str;
            return res;
        }

        public static LiveRateCreateRequestAddressFrom CreateAddressCompleteCreateRequest(AddressCompleteCreateRequest addressCompleteCreateRequest) {
            LiveRateCreateRequestAddressFromType typ = LiveRateCreateRequestAddressFromType.AddressCompleteCreateRequest;

            LiveRateCreateRequestAddressFrom res = new LiveRateCreateRequestAddressFrom(typ);
            res.AddressCompleteCreateRequest = addressCompleteCreateRequest;
            return res;
        }

        public static LiveRateCreateRequestAddressFrom CreateNull() {
            LiveRateCreateRequestAddressFromType typ = LiveRateCreateRequestAddressFromType.Null;
            return new LiveRateCreateRequestAddressFrom(typ);
        }

        public class LiveRateCreateRequestAddressFromConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(LiveRateCreateRequestAddressFrom);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            { 
                var json = JRaw.Create(reader).ToString();

                if (json == "null") {
                    return null;
                }
                try
                {
                    AddressCompleteCreateRequest? addressCompleteCreateRequest = ResponseBodyDeserializer.Deserialize<AddressCompleteCreateRequest>(json, missingMemberHandling: MissingMemberHandling.Error);
                    return new LiveRateCreateRequestAddressFrom(LiveRateCreateRequestAddressFromType.AddressCompleteCreateRequest) {
                        AddressCompleteCreateRequest = addressCompleteCreateRequest
                    };
                }
                catch (Exception ex)
                {
                    if (!(ex is Newtonsoft.Json.JsonReaderException || ex is Newtonsoft.Json.JsonSerializationException)) {
                        throw ex;
                    }
                }
                if (json[0] == '"' && json[^1] == '"'){
                    return new LiveRateCreateRequestAddressFrom(LiveRateCreateRequestAddressFromType.Str) {
                        Str = json[1..^1]
                    };
                }

                throw new InvalidOperationException("Could not deserialize into any supported types.");
            }

            public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
            {
                if (value == null) {
                    writer.WriteRawValue("null");
                    return;
                }
                LiveRateCreateRequestAddressFrom res = (LiveRateCreateRequestAddressFrom)value;
                if (LiveRateCreateRequestAddressFromType.FromString(res.Type).Equals(LiveRateCreateRequestAddressFromType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.Str != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Str));
                    return;
                }
                if (res.AddressCompleteCreateRequest != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.AddressCompleteCreateRequest));
                    return;
                }

            }
        }

    }

}