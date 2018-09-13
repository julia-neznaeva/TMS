using Newtonsoft.Json;

namespace AutotestApp.Common.Models.Api.RequestData.ProductApi
{
    public class Supplier
    {
        [JsonProperty("SupplierID")]
        public string SupplierID { get; set; }

        [JsonProperty("SupplierName")]
        public string SupplierName { get; set; }

        [JsonProperty("SupplierInventoryCode")]
        public string SupplierInventoryCode { get; set; }

        [JsonProperty("SupplierProductName")]
        public string SupplierProductName { get; set; }

        [JsonProperty("Cost")]
        public int Cost { get; set; }

        [JsonProperty("FixedCost")]
        public int FixedCost { get; set; }

        [JsonProperty("Currency")]
        public string Currency { get; set; }

        [JsonProperty("DropShip")]
        public bool DropShip { get; set; }

        [JsonProperty("URL")]
        public string URL { get; set; }
    }
}
