using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Bl
{
    public static class RestSharpExtensions
    {
        public static IRestResponse<T> ExecuteUnzipped<T>(this RestClient restClient, RestRequest request) where T : new()
        {
            IRestResponse<T> response = restClient.Execute<T>(request);

            if (response.ContentEncoding.ToLower().Contains("gzip"))
            {
                response.Content = GZipHelper.Unzip(response.RawBytes);
                response.Data = JsonConvert.DeserializeObject<T>(response.Content);
            }

            return response;
        }
    }
}

