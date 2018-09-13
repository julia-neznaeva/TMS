using AutotestApp.Api.Api.Quote1StepApi;
using AutotestApp.Common.Api;
using AutotestApp.Common.Api.InventoryApi;
using AutotestApp.Dal;
using NUnit.Framework;
using System.Collections.Generic;

namespace ClassLibrary2
{
    [TestFixture]
    public class GetCustomerBillingAddressApiTests
    {
        [Test]
        public void FirstTest()
        {
            TokenApi tokenApi = new TokenApi();
            tokenApi.GetToken();

            GetCustomerBillingAddressApi getCustomerBillingAddressApi = new GetCustomerBillingAddressApi();
            getCustomerBillingAddressApi.Request();

            //List<Client> clients = new ClientRepository().GetClient();

        }

    }
}
