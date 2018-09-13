using AutotestApp.Common.Api.InventoryApi;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Api.Api.Quote1StepApi
{
    public class GetCustomerBillingAddressApi: BaseApi
    {
        public GetCustomerBillingAddressApi()
        {
            _request = new RestRequest(ApiUrl.GetCustomerBillingAddress);
            _request.Method = Method.GET;
        }

        public void Request()
        {
            DearClient.Execute(_request);
        }
    }
}
