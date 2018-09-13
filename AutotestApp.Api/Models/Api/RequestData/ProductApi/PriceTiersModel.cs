using Newtonsoft.Json;

namespace AutotestApp.Common.Models.Api.RequestData.ProductApi
{
    public class PriceTiersModel
    {
        [JsonProperty("Tier 1")]
        public string Tier1 { get; set; }

        [JsonProperty("Tier 2")]
        public string Tier2 { get; set; }

        [JsonProperty("Tier 3")]
        public string Tier3 { get; set; }

        [JsonProperty("Tier 4")]
        public string Tier4 { get; set; }

        [JsonProperty("Tier 5")]
        public string Tier5 { get; set; }

        [JsonProperty("Tier 6")]
        public string Tier6 { get; set; }

        [JsonProperty("Tier 7")]
        public string Tier7 { get; set; }

        [JsonProperty("Tier 8")]
        public string Tier8 { get; set; }

        [JsonProperty("Tier 9")]
        public string Tier9 { get; set; }

        [JsonProperty("Tier 10")]
        public string Tier10 { get; set; }
    }
}
