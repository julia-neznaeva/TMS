using Newtonsoft.Json;

namespace AutotestApp.Common.Models.Api.ResponseData.ProductApi
{
    public class BillOfMaterialsProduct
    {
        [JsonProperty("ComponentProductID")]
        public string ComponentProductId { get; set; }

        [JsonProperty("ProductCode")]
        public string ProductCode { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Quantity")]
        public long Quantity { get; set; }

        [JsonProperty("WastagePercent")]
        public long WastagePercent { get; set; }

        [JsonProperty("WastageQuantity")]
        public long WastageQuantity { get; set; }

        [JsonProperty("CostPercentage")]
        public long CostPercentage { get; set; }
    }
}
