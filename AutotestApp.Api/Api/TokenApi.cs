using AutotestApp.Api;
using AutotestApp.Common.Api.InventoryApi;
using RestSharp;
using RestSharp.Authenticators;


namespace AutotestApp.Common.Api
{
    public class TokenApi : BaseApi
    {
        public TokenApi()
        {
            _request = new RestRequest(ApiUrl.Token);
            _request.Method = Method.POST;
            DearClient.Authenticator = new SimpleAuthenticator("username", "", "password", "");
        }

        public void GetToken()
        {
            DearClient.Execute(_request);
        }
    }
}
