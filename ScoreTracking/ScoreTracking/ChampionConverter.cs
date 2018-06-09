using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ScoreTracking
{
    public class ChampionConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(Champion));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jo = JObject.Load(reader);

            if (jo["Jogo"].Value<string>() == "HS")
                return jo.ToObject<Champion_HS>(serializer);

            if (jo["Jogo"].Value<string>() == "Paladins")
                return jo.ToObject<Champion_Paladins>(serializer);

            return null;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
