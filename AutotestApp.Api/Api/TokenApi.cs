using AutotestApp.Api;
using AutotestApp.Common.Api.InventoryApi;
using RestSharp;
using RestSharp.Authenticators;
using System;
using AutotestApp.Api.Models.Api.ResponseData.Token;
using AutotestApp.Bl;

namespace AutotestApp.Common.Api
{
    public class TokenApi : BaseApi
    {
        public TokenApi()
        {
            _request = new RestRequest(ApiUrl.Token);
            _request.Method = Method.POST;
        }

        //"kate.test21@gmail.com"
        // "123456789"
        public TokenModel GetToken(String email, String password)
        {
            DearClient.Authenticator = new SimpleAuthenticator("username", email, "password", password);
            var response = DearClient.ExecuteUnzipped<TokenModel>(_request);
            return response.Data;
        }

        public void SetToken(String token)
        {
            Token = $"Bearer {token}";
        }
    }
}
  