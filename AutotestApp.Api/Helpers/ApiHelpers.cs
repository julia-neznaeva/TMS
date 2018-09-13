using AutotestApp.Common.Models.Api;
using AutotestApp.Common.Сonstants;
using RestSharp;

namespace AutotestApp.Common.Helpers
{
    public static class ApiHelpers
    {
        public static void AddCredentialsToHeader(this RestRequest request, Credentials сredentials)
        {
            request.AddHeader(HeaderConstants.API_AUTH_ACCOUNTID, сredentials.Accountid);
            request.AddHeader(HeaderConstants.API_AUTH_APPLICATIONKEY, сredentials.Applicationkey);
        }
    }
}
