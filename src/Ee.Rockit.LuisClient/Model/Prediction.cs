namespace Ee.Rockit.LuisClient.Model
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Collections.Generic;

    public class Prediction
    {
        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("topScoringIntent")]
        public TopScoringIntent TopScoringIntent { get; set; }

        [JsonProperty("entities")]
        List<Entity> Entities { get; set; }

    }

    public class TopScoringIntent
    {
        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }
    }

    public class Entity
    {
        [JsonProperty("entity")]
        public string EntityValue { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("startIndex")]
        public int StartIndex { get; set; }

        [JsonProperty("endIndex")]
        public int EndIndex { get; set; }

        [JsonProperty("resolution")]
        public JObject Resolution { get; set; }
    }
}
