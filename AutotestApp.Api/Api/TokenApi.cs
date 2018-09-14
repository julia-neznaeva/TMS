using AutotestApp.Api;
using AutotestApp.Common.Api.InventoryApi;
using AutotestApp.Bl;
using RestSharp;
using RestSharp.Authenticators;
using System;
using AutotestApp.Api.Models.Api.ResponseData.Token;

namespace AutotestApp.Common.Api
{
    public class TokenApi : BaseApi
    {
        public TokenApi()
        {
            _request = new RestRequest(ApiUrl.Token);
            _request.Method = Method.POST;
            DearClient.Authenticator = new SimpleAuthenticator("username", "kate.test21@gmail.com", "password", "123456789");
        }

        public TokenModel GetToken()
        {
            var response = DearClient.ExecuteUnzipped<TokenModel>(_request);
            return response.Data;
        }

        public void SetToken(String token)
        {
            Token = $"Bearer {token}";
        }
    }
}
  