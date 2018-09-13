using Newtonsoft.Json;

namespace AutotestApp.Common.Models.Api.ResponseData.ProductApi
{
    public class BillOfMaterialsService
    {
        [JsonProperty("ComponentProductID")]
        public string ComponentProductId { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Quantity")]
        public long Quantity { get; set; }

        [JsonProperty("ExpenseAccount")]
        public string ExpenseAccount { get; set; }

        [JsonProperty("PriceTier")]
        public long PriceTier { get; set; }
    }
}
