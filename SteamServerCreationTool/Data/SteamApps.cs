using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamServerCreationTool.Data
{
    public partial class SteamApps
    {
        [JsonProperty("appid")]
        public long Appid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subscriptionlinux")]
        public Subscription Subscriptionlinux { get; set; }

        [JsonProperty("linux")]
        public bool Linux { get; set; }

        [JsonProperty("subscriptionwindows")]
        public Subscription Subscriptionwindows { get; set; }

        [JsonProperty("windows")]
        public bool Windows { get; set; }
    }

    public enum Subscription { ReleasedSubscribedInvalidPlatformPermanent, ReleasedSubscribedPermanent, UnknownNoLicense, UnknownSubscribedInvalidPlatformPermanent };

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                SubscriptionConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class SubscriptionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Subscription) || t == typeof(Subscription?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "released (Subscribed,Invalid Platform,Permanent,)":
                    return Subscription.ReleasedSubscribedInvalidPlatformPermanent;
                case "released (Subscribed,Permanent,)":
                    return Subscription.ReleasedSubscribedPermanent;
                case "unknown (No License)":
                    return Subscription.UnknownNoLicense;
                case "unknown (Subscribed,Invalid Platform,Permanent,)":
                    return Subscription.UnknownSubscribedInvalidPlatformPermanent;
            }
            throw new Exception("Cannot unmarshal type Subscription");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Subscription)untypedValue;
            switch (value)
            {
                case Subscription.ReleasedSubscribedInvalidPlatformPermanent:
                    serializer.Serialize(writer, "released (Subscribed,Invalid Platform,Permanent,)");
                    return;
                case Subscription.ReleasedSubscribedPermanent:
                    serializer.Serialize(writer, "released (Subscribed,Permanent,)");
                    return;
                case Subscription.UnknownNoLicense:
                    serializer.Serialize(writer, "unknown (No License)");
                    return;
                case Subscription.UnknownSubscribedInvalidPlatformPermanent:
                    serializer.Serialize(writer, "unknown (Subscribed,Invalid Platform,Permanent,)");
                    return;
            }
            throw new Exception("Cannot marshal type Subscription");
        }

        public static readonly SubscriptionConverter Singleton = new SubscriptionConverter();
    }
}
