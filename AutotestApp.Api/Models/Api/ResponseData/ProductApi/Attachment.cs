using Newtonsoft.Json;

namespace AutotestApp.Common.Models.Api.ResponseData.ProductApi
{
    public class Attachment
    {
        [JsonProperty("ID")]
        public string Id { get; set; }

        [JsonProperty("ContentType")]
        public string ContentType { get; set; }

        [JsonProperty("FileName")]
        public string FileName { get; set; }

        [JsonProperty("DownloadUrl")]
        public string DownloadUrl { get; set; }
    }
}
