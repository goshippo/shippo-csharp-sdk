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
    

    public class ManifestCreateRequestAddressFromType
    {
        private ManifestCreateRequestAddressFromType(string value) { Value = value; }

        public string Value { get; private set; }
        public static ManifestCreateRequestAddressFromType AddressCreateRequest { get { return new ManifestCreateRequestAddressFromType("AddressCreateRequest"); } }
        
        public static ManifestCreateRequestAddressFromType Str { get { return new ManifestCreateRequestAddressFromType("str"); } }
        
        public static ManifestCreateRequestAddressFromType Null { get { return new ManifestCreateRequestAddressFromType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(ManifestCreateRequestAddressFromType v) { return v.Value; }
        public static ManifestCreateRequestAddressFromType FromString(string v) {
            switch(v) {
                case "AddressCreateRequest": return AddressCreateRequest;
                case "str": return Str;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for ManifestCreateRequestAddressFromType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((ManifestCreateRequestAddressFromType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
    

    [JsonConverter(typeof(ManifestCreateRequestAddressFrom.ManifestCreateRequestAddressFromConverter))]
    public class ManifestCreateRequestAddressFrom {
        public ManifestCreateRequestAddressFrom(ManifestCreateRequestAddressFromType type) {
            Type = type;
        }
        public AddressCreateRequest? AddressCreateRequest { get; set; } 
        public string? Str { get; set; } 

        public ManifestCreateRequestAddressFromType Type { get; set; }


        public static ManifestCreateRequestAddressFrom CreateAddressCreateRequest(AddressCreateRequest addressCreateRequest) {
            ManifestCreateRequestAddressFromType typ = ManifestCreateRequestAddressFromType.AddressCreateRequest;

            ManifestCreateRequestAddressFrom res = new ManifestCreateRequestAddressFrom(typ);
            res.AddressCreateRequest = addressCreateRequest;
            return res;
        }

        public static ManifestCreateRequestAddressFrom CreateStr(string str) {
            ManifestCreateRequestAddressFromType typ = ManifestCreateRequestAddressFromType.Str;

            ManifestCreateRequestAddressFrom res = new ManifestCreateRequestAddressFrom(typ);
            res.Str = str;
            return res;
        }

        public static ManifestCreateRequestAddressFrom CreateNull() {
            ManifestCreateRequestAddressFromType typ = ManifestCreateRequestAddressFromType.Null;
            return new ManifestCreateRequestAddressFrom(typ);
        }

        public class ManifestCreateRequestAddressFromConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(ManifestCreateRequestAddressFrom);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            { 
                var json = JRaw.Create(reader).ToString();

                if (json == "null") {
                    return null;
                }
                try
                {
                    AddressCreateRequest? addressCreateRequest = ResponseBodyDeserializer.Deserialize<AddressCreateRequest>(json, missingMemberHandling: MissingMemberHandling.Error);
                    return new ManifestCreateRequestAddressFrom(ManifestCreateRequestAddressFromType.AddressCreateRequest) {
                        AddressCreateRequest = addressCreateRequest
                    };
                }
                catch (Exception ex)
                {
                    if (!(ex is Newtonsoft.Json.JsonReaderException || ex is Newtonsoft.Json.JsonSerializationException)) {
                        throw ex;
                    }
                }
                if (json[0] == '"' && json[^1] == '"'){
                    return new ManifestCreateRequestAddressFrom(ManifestCreateRequestAddressFromType.Str) {
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
                ManifestCreateRequestAddressFrom res = (ManifestCreateRequestAddressFrom)value;
                if (ManifestCreateRequestAddressFromType.FromString(res.Type).Equals(ManifestCreateRequestAddressFromType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.AddressCreateRequest != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.AddressCreateRequest));
                    return;
                }
                if (res.Str != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Str));
                    return;
                }

            }
        }

    }

}