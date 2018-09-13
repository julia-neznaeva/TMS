using Newtonsoft.Json;
using System.Collections.Generic;

namespace AutotestApp.Common.Models.Api.ResponseData.ProductApi
{
    public class ProductResponse
    {
        [JsonProperty("Total")]
        public long Total { get; set; }

        [JsonProperty("Page")]
        public long Page { get; set; }

        [JsonProperty("Products")]
        public List<ProductElement> Products { get; set; }
    }
}
