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
    

    public class LiveRateCreateRequestParcelType
    {
        private LiveRateCreateRequestParcelType(string value) { Value = value; }

        public string Value { get; private set; }
        public static LiveRateCreateRequestParcelType Str { get { return new LiveRateCreateRequestParcelType("str"); } }
        
        public static LiveRateCreateRequestParcelType Parcel { get { return new LiveRateCreateRequestParcelType("Parcel"); } }
        
        public static LiveRateCreateRequestParcelType Null { get { return new LiveRateCreateRequestParcelType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(LiveRateCreateRequestParcelType v) { return v.Value; }
        public static LiveRateCreateRequestParcelType FromString(string v) {
            switch(v) {
                case "str": return Str;
                case "Parcel": return Parcel;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for LiveRateCreateRequestParcelType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((LiveRateCreateRequestParcelType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
    
/// <summary>
/// Object ID for an existing User Parcel Template OR a fully formed Parcel object.
/// </summary>
    [JsonConverter(typeof(LiveRateCreateRequestParcel.LiveRateCreateRequestParcelConverter))]
    public class LiveRateCreateRequestParcel {
        public LiveRateCreateRequestParcel(LiveRateCreateRequestParcelType type) {
            Type = type;
        }
        public string? Str { get; set; } 
        public Parcel? Parcel { get; set; } 

        public LiveRateCreateRequestParcelType Type { get; set; }


        public static LiveRateCreateRequestParcel CreateStr(string str) {
            LiveRateCreateRequestParcelType typ = LiveRateCreateRequestParcelType.Str;

            LiveRateCreateRequestParcel res = new LiveRateCreateRequestParcel(typ);
            res.Str = str;
            return res;
        }

        public static LiveRateCreateRequestParcel CreateParcel(Parcel parcel) {
            LiveRateCreateRequestParcelType typ = LiveRateCreateRequestParcelType.Parcel;

            LiveRateCreateRequestParcel res = new LiveRateCreateRequestParcel(typ);
            res.Parcel = parcel;
            return res;
        }

        public static LiveRateCreateRequestParcel CreateNull() {
            LiveRateCreateRequestParcelType typ = LiveRateCreateRequestParcelType.Null;
            return new LiveRateCreateRequestParcel(typ);
        }

        public class LiveRateCreateRequestParcelConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(LiveRateCreateRequestParcel);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            { 
                var json = JRaw.Create(reader).ToString();

                if (json == "null") {
                    return null;
                }
                try
                {
                    Parcel? parcel = ResponseBodyDeserializer.Deserialize<Parcel>(json, missingMemberHandling: MissingMemberHandling.Error);
                    return new LiveRateCreateRequestParcel(LiveRateCreateRequestParcelType.Parcel) {
                        Parcel = parcel
                    };
                }
                catch (Exception ex)
                {
                    if (!(ex is Newtonsoft.Json.JsonReaderException || ex is Newtonsoft.Json.JsonSerializationException)) {
                        throw ex;
                    }
                }
                if (json[0] == '"' && json[^1] == '"'){
                    return new LiveRateCreateRequestParcel(LiveRateCreateRequestParcelType.Str) {
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
                LiveRateCreateRequestParcel res = (LiveRateCreateRequestParcel)value;
                if (LiveRateCreateRequestParcelType.FromString(res.Type).Equals(LiveRateCreateRequestParcelType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.Str != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Str));
                    return;
                }
                if (res.Parcel != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Parcel));
                    return;
                }

            }
        }

    }

}