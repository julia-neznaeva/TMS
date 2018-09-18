using AutotestApp.Api.Models.Api.ResponseData.CustomerBillingAddress;
using AutotestApp.Bl;
using AutotestApp.Common.Api.InventoryApi;
using RestSharp;


namespace AutotestApp.Api.Api.Quote1StepApi
{
    public class GetCustomerBillingAddressApi: BaseApi
    {
        public GetCustomerBillingAddressApi()
        {
            _request = new RestRequest(ApiUrl.GetCustomerBillingAddress);
            _request.Method = Method.GET;
            _request.AddHeader("Authorization", Token);
        }

        public BilingAddressTemp Request()
        {
            var responce =  DearClient.ExecuteUnzipped<BilingAddressTemp>(_request);
            return responce.Data;
        }
    }
}
