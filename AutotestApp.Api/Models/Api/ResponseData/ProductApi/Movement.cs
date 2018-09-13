using Newtonsoft.Json;
using System;

namespace AutotestApp.Common.Models.Api.ResponseData.ProductApi
{
    public class Movement
    {
        [JsonProperty("TaskID")]
        public string TaskId { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("Number")]
        public string Number { get; set; }

        [JsonProperty("Quantity")]
        public long Quantity { get; set; }

        [JsonProperty("Amount")]
        public long Amount { get; set; }

        [JsonProperty("Location")]
        public string Location { get; set; }

        [JsonProperty("BatchSN")]
        public long BatchSn { get; set; }

        [JsonProperty("ExpiryDate")]
        public DateTimeOffset ExpiryDate { get; set; }

        [JsonProperty("FromTo")]
        public string FromTo { get; set; }
    }
}
