//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Shippo.Utils
{
    using System;
    using System.Linq;
    using System.Net.Http.Headers;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.Numerics;
    using Newtonsoft.Json;
    using NodaTime;
    using System.Collections;

    public class Utilities
    {
        public static JsonConverter[] GetDefaultJsonSerializers()
        {
            return new JsonConverter[]
            {
                new IsoDateTimeSerializer(),
                new EnumConverter()
            };
        }

        public static JsonConverter[] GetDefaultJsonDeserializers()
        {
            return new JsonConverter[] {
                new FlexibleObjectDeserializer(),
                new EnumConverter(),
                new AnyDeserializer()
            };
        }

        public static JsonSerializerSettings GetDefaultJsonSerializerSettings()
        {
            return new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore,
                Converters = GetDefaultJsonSerializers()
            };
        }

        public static JsonSerializerSettings GetDefaultJsonDeserializerSettings()
        {
            return new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore,
                Converters = GetDefaultJsonDeserializers()
            };
        }

        public static JsonConverter[] GetJsonSerializers(Type type, string format = "")
        {
            if (format == "string")
            {
                if (type == typeof(BigInteger))
                {
                    return new JsonConverter[] { new BigIntStrConverter() };
                }

                if (type == typeof(Decimal))
                {
                    return new JsonConverter[] { new DecimalStrConverter() };
                }
            }

            return GetDefaultJsonSerializers();
        }

        public static JsonConverter[] GetJsonDeserializers(Type type)
        {
            if (type == typeof(BigInteger))
            {
                return new JsonConverter[] { new BigIntStrConverter() };
            }

            if (type == typeof(Decimal))
            {
                return new JsonConverter[] { new DecimalStrConverter() };
            }

            return GetDefaultJsonDeserializers();
        }

        public static string SerializeJSON(object obj, string format = "")
        {
            var type = obj.GetType();
            if (IsList(obj))
            {
                type = type.GetGenericArguments().Single();
            }
            else if (IsDictionary(obj))
            {
                type = type.GetGenericArguments().Last();
            }

            return JsonConvert.SerializeObject(
                obj,
                new JsonSerializerSettings()
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    Converters = GetJsonSerializers(type, format)
                }
            );
        }

        public static bool IsDictionary(object? o)
        {
            if (o == null)
                return false;
            return o is IDictionary
                && o.GetType().IsGenericType
                && o.GetType().GetGenericTypeDefinition().IsAssignableFrom(typeof(Dictionary<,>));
        }

        public static bool IsList(object? o)
        {
            if (o == null)
                return false;
            return o is IList
                && o.GetType().IsGenericType
                && o.GetType().GetGenericTypeDefinition().IsAssignableFrom(typeof(List<>));
        }

        public static bool IsClass(object? o)
        {
            if (o == null)
                return false;
            return o.GetType().IsClass && (o.GetType().FullName ?? "").StartsWith("Shippo.Models");
        }

        // TODO: code review polyfilled for IsAssignableTo
        public static bool IsSameOrSubclass(Type potentialBase, Type potentialDescendant)
        {
            return potentialDescendant.IsSubclassOf(potentialBase)
                || potentialDescendant == potentialBase;
        }

        public static bool IsString(object? obj)
        {
            if (obj != null)
            {
                var type = obj.GetType();
                return IsSameOrSubclass(type, typeof(string));
            }
            else
            {
                return false;
            }
        }

        public static bool IsPrimitive(object? obj) => obj != null && obj.GetType().IsPrimitive;

        public static bool IsEnum(object? obj) => obj != null && obj.GetType().IsEnum;

        public static bool IsDate(object? obj) =>
            obj != null && (obj.GetType() == typeof(DateTime) || obj.GetType() == typeof(LocalDate));

        private static string StripSurroundingQuotes(string input)
        {
            Regex surroundingQuotesRegex = new Regex("^\"(.*)\"$");
            var match = surroundingQuotesRegex.Match(input);
            if(match.Groups.Values.Count() == 2)
            {
                return match.Groups.Values.Last().ToString();
            }
            return input;
        }

        public static string ValueToString(object? value)
        {
            if (value == null)
            {
                return "";
            }

            if (value.GetType() == typeof(DateTime))
            {
                return ((DateTime)value)
                    .ToUniversalTime()
                    .ToString("o", System.Globalization.CultureInfo.InvariantCulture);
            }
            else if (value.GetType() == typeof(LocalDate))
            {
                return ((LocalDate)value)
                    .ToDateTimeUnspecified()
                    .ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            }
            else if (value.GetType() == typeof(bool))
            {
                return (bool)value ? "true" : "false";
            }
            else if (IsEnum(value))
            {
                var method = Type.GetType(value.GetType().FullName + "Extension")
                    ?.GetMethod("Value");
                if (method == null)
                {
                    return Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()))?.ToString() ?? "";
                }
                return (string)(method.Invoke(null, new[] { value }) ?? "");
            }
            else if (IsDictionary(value))
            {
                return JsonConvert.SerializeObject(value, GetDefaultJsonSerializerSettings());
            }

            return value.ToString() ?? "";
        }

        public static string ToString(object? obj)
        {
            if (obj == null)
            {
                return "";
            }

            if (IsString(obj))
            {
                return obj.ToString() ?? "";
            }

            if (IsPrimitive(obj))
            {
                return JsonConvert.SerializeObject(obj);
            }

            if (IsEnum(obj))
            {
                var attributes = obj.GetType().GetMember(obj.ToString() ?? "").First().CustomAttributes;
                if (attributes.Count() == 0)
                {
                    return JsonConvert.SerializeObject(obj);
                }

                var args = attributes.First().ConstructorArguments;
                if (args.Count() == 0)
                {
                    return JsonConvert.SerializeObject(obj);
                }
                return StripSurroundingQuotes(args.First().ToString());
            }

            if (IsDate(obj))
            {
                return StripSurroundingQuotes(
                    JsonConvert.SerializeObject(obj, GetDefaultJsonSerializerSettings())
                );
            }

            return JsonConvert.SerializeObject(obj, GetDefaultJsonSerializerSettings());
        }

        public static bool IsContentTypeMatch(string expected, string? actual)
        {
            if (actual == null)
            {
                return false;
            }

            if (expected == actual || expected == "*" || expected == "*/*")
            {
                return true;
            }

            try
            {
                var mediaType = MediaTypeHeaderValue.Parse(actual).MediaType ?? "";

                if (expected == mediaType)
                {
                    return true;
                }

                var parts = mediaType.Split('/');
                if (parts.Length == 2)
                {
                    if (parts[0] + "/*" == expected || "*/" + parts[1] == expected)
                    {
                        return true;
                    }
                }
            }
            catch (Exception) { }

            return false;
        }

        public static string PrefixBearer(string authHeaderValue)
        {
            if (authHeaderValue.StartsWith("bearer ", StringComparison.InvariantCultureIgnoreCase))
            {
                return authHeaderValue;
            }

            return $"Bearer {authHeaderValue}";
        }
        public static string RemoveSuffix(string inputString, string suffix)
        {
            if (!String.IsNullOrEmpty(suffix) && inputString.EndsWith(suffix))
            {
                return inputString.Remove(inputString.Length - suffix.Length, suffix.Length);
            }
            return inputString;
        }
        public static string TemplateUrl(string template, Dictionary<string, string> paramDict)
        {
            foreach(KeyValuePair<string, string> entry in paramDict)
            {
                template = template.Replace('{' + entry.Key + '}', entry.Value);
            }
            return template;
        }
    }
}
