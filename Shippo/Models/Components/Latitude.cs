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
    using Shippo.Utils;
    using System.Numerics;
    using System;
    

    public class LatitudeType
    {
        private LatitudeType(string value) { Value = value; }

        public string Value { get; private set; }
        public static LatitudeType Number { get { return new LatitudeType("number"); } }
        
        public static LatitudeType Str { get { return new LatitudeType("str"); } }
        
        public static LatitudeType Null { get { return new LatitudeType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(LatitudeType v) { return v.Value; }
        public static LatitudeType FromString(string v) {
            switch(v) {
                case "number": return Number;
                case "str": return Str;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for LatitudeType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((LatitudeType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
    

    [JsonConverter(typeof(Latitude.LatitudeConverter))]
    public class Latitude {
        public Latitude(LatitudeType type) {
            Type = type;
        }
        public double? Number { get; set; } 
        public string? Str { get; set; } 

        public LatitudeType Type { get; set; }


        public static Latitude CreateNumber(double number) {
            LatitudeType typ = LatitudeType.Number;

            Latitude res = new Latitude(typ);
            res.Number = number;
            return res;
        }

        public static Latitude CreateStr(string str) {
            LatitudeType typ = LatitudeType.Str;

            Latitude res = new Latitude(typ);
            res.Str = str;
            return res;
        }

        public static Latitude CreateNull() {
            LatitudeType typ = LatitudeType.Null;
            return new Latitude(typ);
        }

        public class LatitudeConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(Latitude);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            { 
                var json = JRaw.Create(reader).ToString();

                if (json == "null") {
                    return null;
                } 
                try {
                    var converted = Convert.ToDouble(json);
                    return new Latitude(LatitudeType.Number) {
                        Number = converted
                    };
                } catch (System.FormatException) {
                    // try next option
                }
                if (json[0] == '"' && json[^1] == '"'){
                    return new Latitude(LatitudeType.Str) {
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
                Latitude res = (Latitude)value;
                if (LatitudeType.FromString(res.Type).Equals(LatitudeType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.Number != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Number));
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