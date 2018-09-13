using Newtonsoft.Json;

namespace AutotestApp.Common.Models.Api.ResponseData.ErrorResponse
{
    public class ApiErrorResponseModel
    {
        [JsonProperty("ErrorCode")]
        public int ErrorCode { get; set; }

        [JsonProperty("Exception")]
        public string Exception { get; set; }
    }
}
