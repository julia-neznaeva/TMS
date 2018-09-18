using AutotestApp.Api.Api.Quote1StepApi;
using AutotestApp.Api.Models.Api.ResponseData.CustomerBillingAddress;
using AutotestApp.Bl.QuoteServices;
using AutotestApp.Common.Api;
using AutotestApp.Dal;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ClassLibrary2
{
    [TestFixture]
    public class GetCustomerBillingAddressApiTests
    {
        private BillingAddressService _billingAdressService = new BillingAddressService();
        
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
            List<Client> client = new ClientRepository().GetClient();

            BilingAddressTemp apiResult =  getCustomerBillingAddressApi.Request();

            var element = _billingAdressService.GetBillingAddress("kate.test21@gmail.com"); 
        }

    }
}
