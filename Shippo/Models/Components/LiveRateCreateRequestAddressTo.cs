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
    using Newtonsoft.Json.Linq;
    using Shippo.Models.Components;
    using Shippo.Utils;
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Reflection;
    

    public class LiveRateCreateRequestAddressToType
    {
        private LiveRateCreateRequestAddressToType(string value) { Value = value; }

        public string Value { get; private set; }
        public static LiveRateCreateRequestAddressToType Str { get { return new LiveRateCreateRequestAddressToType("str"); } }
        
        public static LiveRateCreateRequestAddressToType AddressCompleteCreateRequest { get { return new LiveRateCreateRequestAddressToType("AddressCompleteCreateRequest"); } }
        
        public static LiveRateCreateRequestAddressToType Null { get { return new LiveRateCreateRequestAddressToType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(LiveRateCreateRequestAddressToType v) { return v.Value; }
        public static LiveRateCreateRequestAddressToType FromString(string v) {
            switch(v) {
                case "str": return Str;
                case "AddressCompleteCreateRequest": return AddressCompleteCreateRequest;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for LiveRateCreateRequestAddressToType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((LiveRateCreateRequestAddressToType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    /// <summary>
    /// The recipient address, which includes the recipient&apos;s name, company name, street address, city, state, zip code, <br/>
    /// 
    /// <remarks>
    /// country, phone number, and email address (strings). Special characters should not be included in <br/>
    /// any address element, especially name, company, and email.
    /// </remarks>
    /// </summary>
    [JsonConverter(typeof(LiveRateCreateRequestAddressTo.LiveRateCreateRequestAddressToConverter))]
    public class LiveRateCreateRequestAddressTo {
        public LiveRateCreateRequestAddressTo(LiveRateCreateRequestAddressToType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public string? Str { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public AddressCompleteCreateRequest? AddressCompleteCreateRequest { get; set; }

        public LiveRateCreateRequestAddressToType Type { get; set; }


        public static LiveRateCreateRequestAddressTo CreateStr(string str) {
            LiveRateCreateRequestAddressToType typ = LiveRateCreateRequestAddressToType.Str;

            LiveRateCreateRequestAddressTo res = new LiveRateCreateRequestAddressTo(typ);
            res.Str = str;
            return res;
        }

        public static LiveRateCreateRequestAddressTo CreateAddressCompleteCreateRequest(AddressCompleteCreateRequest addressCompleteCreateRequest) {
            LiveRateCreateRequestAddressToType typ = LiveRateCreateRequestAddressToType.AddressCompleteCreateRequest;

            LiveRateCreateRequestAddressTo res = new LiveRateCreateRequestAddressTo(typ);
            res.AddressCompleteCreateRequest = addressCompleteCreateRequest;
            return res;
        }

        public static LiveRateCreateRequestAddressTo CreateNull() {
            LiveRateCreateRequestAddressToType typ = LiveRateCreateRequestAddressToType.Null;
            return new LiveRateCreateRequestAddressTo(typ);
        }

        public class LiveRateCreateRequestAddressToConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(LiveRateCreateRequestAddressTo);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            {
                var json = JRaw.Create(reader).ToString();
                if (json == "null")
                {
                    return null;
                }

                var fallbackCandidates = new List<(System.Type, object, string)>();

                try
                {
                    return new LiveRateCreateRequestAddressTo(LiveRateCreateRequestAddressToType.AddressCompleteCreateRequest)
                    {
                        AddressCompleteCreateRequest = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<AddressCompleteCreateRequest>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(AddressCompleteCreateRequest), new LiveRateCreateRequestAddressTo(LiveRateCreateRequestAddressToType.AddressCompleteCreateRequest), "AddressCompleteCreateRequest"));
                }
                catch (ResponseBodyDeserializer.DeserializationException)
                {
                    // try next option
                }
                catch (Exception)
                {
                    throw;
                }

                if (json[0] == '"' && json[^1] == '"'){
                    return new LiveRateCreateRequestAddressTo(LiveRateCreateRequestAddressToType.Str)
                    {
                        Str = json[1..^1]
                    };
                }

                if (fallbackCandidates.Count > 0)
                {
                    fallbackCandidates.Sort((a, b) => ResponseBodyDeserializer.CompareFallbackCandidates(a.Item1, b.Item1, json));
                    foreach(var (deserializationType, returnObject, propertyName) in fallbackCandidates)
                    {
                        try
                        {
                            return ResponseBodyDeserializer.DeserializeUndiscriminatedUnionFallback(deserializationType, returnObject, propertyName, json);
                        }
                        catch (ResponseBodyDeserializer.DeserializationException)
                        {
                            // try next fallback option
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }

                throw new InvalidOperationException("Could not deserialize into any supported types.");
            }

            public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
            {
                if (value == null) {
                    writer.WriteRawValue("null");
                    return;
                }
                LiveRateCreateRequestAddressTo res = (LiveRateCreateRequestAddressTo)value;
                if (LiveRateCreateRequestAddressToType.FromString(res.Type).Equals(LiveRateCreateRequestAddressToType.Null))
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