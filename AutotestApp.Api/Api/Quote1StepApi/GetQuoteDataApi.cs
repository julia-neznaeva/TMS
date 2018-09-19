using AutotestApp.Bl;
using AutotestApp.Bl.Model.GetQuoteData;
using AutotestApp.Common.Api.InventoryApi;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Api.Api.Quote1StepApi
{
    public class GetQuoteDataApi: BaseApi
    {
        public GetQuoteDataApi(string token)
        {
            _request = new RestRequest(ApiUrl.GetQuoteData);
            _request.Method = Method.GET;
            _request.AddHeader("Authorization", $"Bearer {token}");
        }

        public QuoteResponse Request()
        {
            var responce = DearClient.ExecuteUnzipped<QuoteResponse>(_request);
            return responce.Data;
        }

    }
}
