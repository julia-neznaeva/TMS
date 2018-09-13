using Newtonsoft.Json;

namespace AutotestApp.Common.Models.Api.ResponseData.ProductApi
{
    public class ReorderLevel
    {
        [JsonProperty("LocationID")]
        public string LocationId { get; set; }

        [JsonProperty("LocationName")]
        public string LocationName { get; set; }

        [JsonProperty("MinimumBeforeReorder")]
        public long MinimumBeforeReorder { get; set; }

        [JsonProperty("ReorderQuantity")]
        public long ReorderQuantity { get; set; }

        [JsonProperty("StockLocator")]
        public long StockLocator { get; set; }

        [JsonProperty("PickZones")]
        public string PickZones { get; set; }
    }
}
