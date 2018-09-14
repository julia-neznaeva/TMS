using AutotestApp.Api.Api.Quote1StepApi;
using AutotestApp.Api.Models.Api.ResponseData.CustomerBillingAddress;
using AutotestApp.Common.Api;
using AutotestApp.Common.Api.InventoryApi;
using AutotestApp.Dal;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ClassLibrary2
{
    [TestFixture]
    public class GetCustomerBillingAddressApiTests
    {
        [OneTimeSetUp]
        public void SetToken()
        {
            TokenApi tokenApi = new TokenApi();
            String token = tokenApi.GetToken().Token;
            tokenApi.SetToken(token);
        }


        [Test]
        public void FirstTest()
        {
            TokenApi tokenApi = new TokenApi();
            tokenApi.GetToken();

            GetCustomerBillingAddressApi getCustomerBillingAddressApi = new GetCustomerBillingAddressApi();

            BilingAddressTemp result =  getCustomerBillingAddressApi.Request();

            //List<Client> clients = new ClientRepository().GetClient();

        }

    }
}
