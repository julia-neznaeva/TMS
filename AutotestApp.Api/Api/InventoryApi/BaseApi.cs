using AutotestApp.Api;
using AutotestApp.Common.Сonstants;
using NUnit.Framework;
using RestSharp;
using System;
using System.Net;
using System.Reflection;

namespace AutotestApp.Common.Api.InventoryApi
{
    public class BaseApi : BaseTest
    {
        private RestClient _restClient;

        protected static String Token; 

        protected RestClient DearClient => _restClient ?? (_restClient = new RestClient(ApiUrl.ApiBaseUrl));

        protected RestRequest _request;

        private void CheckResponseStatusCode<T>(HttpStatusCode statusCode, IRestResponse<T> response, RestRequest request)
        {
            Assert.AreEqual(statusCode, response.StatusCode,
                $@"Response StatusCode is '{response.StatusCode}'.
                   Requested url: - {response.Request.Resource}'.
                   Method: {response.Request.Method}");
        }

        protected T DoGet<T>(RestRequest request, object bodyModel = null, HttpStatusCode statusCode = HttpStatusCode.OK) where T : new()
        {
            request.Method = Method.GET;

            request.RequestFormat = DataFormat.Json;

            //foreach (PropertyInfo property in bodyModel.GetType().GetProperties())
            //{
            //    request.AddOrUpdateParameter(property.Name, property.GetValue(bodyModel), ParameterType.QueryString);
            //}

            var response = DearClient.Execute<T>(request);

            CheckResponseStatusCode(statusCode, response, request);

            return response.Data;
        }

        protected T DoPost<T>(RestRequest request, object bodyModel = null, HttpStatusCode statusCode = HttpStatusCode.OK) where T : new()
        {
            DearClient.CookieContainer = new CookieContainer();

            request.Method = Method.POST;

           // request.AddOrUpdateJsonBody(bodyModel);

            var response = DearClient.Execute<T>(request);

            CheckResponseStatusCode(statusCode, response, request);

            return response.Data;
        }

        protected T DoPut<T>(RestRequest request, object bodyModel = null, HttpStatusCode statusCode = HttpStatusCode.OK) where T : new()
        {
            request.Parameters.RemoveAll(x => x.Name != HeaderConstants.API_AUTH_ACCOUNTID && x.Name != HeaderConstants.API_AUTH_APPLICATIONKEY);

            request.Method = Method.PUT;

           //request.AddOrUpdateJsonBody(bodyModel);

            var response = DearClient.Execute<T>(request);

            CheckResponseStatusCode(statusCode, response, request);

            return response.Data;
        }
    }
}
