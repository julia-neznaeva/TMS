using AutotestApp.Api.Api.Quote1StepApi;
using AutotestApp.Api.Models.Api.ResponseData.CustomerBillingAddress;
using AutotestApp.ApiTest;
using AutotestApp.Bl.Mapper;
using AutotestApp.Bl.QuoteServices;
using AutotestApp.Common;
using AutotestApp.Common.Api;
using AutotestApp.Dal;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ClassLibrary2
{
    [TestFixture]
    public class GetCustomerBillingAddressApiTests: BaseApiTest
    {
        private QuoteService _billingAdressService;


        [OneTimeSetUp]
        public void SetToken()
        {
            AutomapperFactory.Initialize();
            _billingAdressService = new QuoteService();
        }

        [TestCase("kate.test21@gmail.com", "123456789", TestName ="Get Billing address")]
        [TestCase("cuswithoutVLTLcarrier@yopmail.com", "123456789", TestName = "Get Dedicated address")]
        public void GetBillingAddress(String email, String password)
        {
            TokenApi tokenApi = new TokenApi();
            String token = tokenApi.GetToken(email, password).Token;
            tokenApi.SetToken(token);

            GetCustomerBillingAddressApi getCustomerBillingAddressApi = new GetCustomerBillingAddressApi();
            List<Client> client = new ClientRepository().GetClient();

            BilingAddressTemp apiResultBillingAddress = getCustomerBillingAddressApi.Request();

            Address billingAddressFromBD = _billingAdressService.GetBillingAddress("kate.test21@gmail.com");

            AssertsAccumulator.Accumulate(() => Assert.AreEqual(billingAddressFromBD.AddressAccessorials, apiResultBillingAddress.BillingAddress.AddressAccessorials, "Assesorials are not equel"));
            AssertsAccumulator.Accumulate(() => Assert.AreEqual(billingAddressFromBD.AddressId, apiResultBillingAddress.BillingAddress.AddressId, "AddressId are not equel"));
            AssertsAccumulator.Accumulate(() => Assert.AreEqual(billingAddressFromBD.City, apiResultBillingAddress.BillingAddress.City, "Citys are not equel"));
            AssertsAccumulator.Accumulate(() => Assert.AreEqual(billingAddressFromBD.CommercialType, apiResultBillingAddress.BillingAddress.CommercialType, "CommercialType are not equel"));
            AssertsAccumulator.Accumulate(() => Assert.AreEqual(billingAddressFromBD.CompanyName, apiResultBillingAddress.BillingAddress.CompanyName, "CompanyName are not equel"));
            AssertsAccumulator.Accumulate(() => Assert.AreEqual(billingAddressFromBD.Country, apiResultBillingAddress.BillingAddress.Country, "Country are not equel"));
            AssertsAccumulator.Accumulate(() => Assert.AreEqual(billingAddressFromBD.DeliveryFromTime, apiResultBillingAddress.BillingAddress.DeliveryFromTime, "DeliveryFromTime are not equel"));
            AssertsAccumulator.Accumulate(() => Assert.AreEqual(billingAddressFromBD.DeliveryInstructions, apiResultBillingAddress.BillingAddress.DeliveryInstructions, "DeliveryInstructions are not equel"));
            AssertsAccumulator.Accumulate(() => Assert.AreEqual(billingAddressFromBD.DeliveryToTime, apiResultBillingAddress.BillingAddress.DeliveryToTime, "DeliveryToTime are not equel"));
            AssertsAccumulator.Accumulate(() => Assert.AreEqual(billingAddressFromBD.IsCanada, apiResultBillingAddress.BillingAddress.IsCanada, "IsCanada are not equel"));
            AssertsAccumulator.Accumulate(() => Assert.AreEqual(billingAddressFromBD.Lat, apiResultBillingAddress.BillingAddress.Lat, "Lat are not equel"));
            AssertsAccumulator.Accumulate(() => Assert.AreEqual(billingAddressFromBD.Long, apiResultBillingAddress.BillingAddress.Long, "Long are not equel"));
            AssertsAccumulator.Accumulate(() => Assert.AreEqual(billingAddressFromBD.PickUpInstructions, apiResultBillingAddress.BillingAddress.PickUpInstructions, "PickUpInstructions are not equel"));
            AssertsAccumulator.Accumulate(() => Assert.AreEqual(billingAddressFromBD.PostalCode, apiResultBillingAddress.BillingAddress.PostalCode, "PostalCode are not equel"));
            AssertsAccumulator.Accumulate(() => Assert.AreEqual(billingAddressFromBD.ShippingFromTime, apiResultBillingAddress.BillingAddress.ShippingFromTime, "ShippingFromTime are not equel"));
            AssertsAccumulator.Accumulate(() => Assert.AreEqual(billingAddressFromBD.ShippingToTime, apiResultBillingAddress.BillingAddress.ShippingToTime, "ShippingToTime are not equel"));
            AssertsAccumulator.Accumulate(() => Assert.AreEqual(billingAddressFromBD.State, apiResultBillingAddress.BillingAddress.State, "State are not equel"));
            AssertsAccumulator.Accumulate(() => Assert.AreEqual(billingAddressFromBD.StateCode, apiResultBillingAddress.BillingAddress.StateCode, "StateCode are not equel"));
            AssertsAccumulator.Accumulate(() => Assert.AreEqual(billingAddressFromBD.StreetLine1, apiResultBillingAddress.BillingAddress.StreetLine1, "StreetLine1 are not equel"));
            AssertsAccumulator.Accumulate(() => Assert.AreEqual(billingAddressFromBD.StreetLine2, apiResultBillingAddress.BillingAddress.StreetLine2, "StreetLine2 are not equel"));
            AssertsAccumulator.Accumulate(() => Assert.AreEqual(billingAddressFromBD.ContactPerson.AddressContactId, apiResultBillingAddress.BillingAddress.ContactPerson.AddressContactId, "AddressContactId in Contact are not equel"));
            AssertsAccumulator.Accumulate(() => Assert.AreEqual(billingAddressFromBD.ContactPerson.Email, apiResultBillingAddress.BillingAddress.ContactPerson.Email, "Email in Contact are not equel"));
            AssertsAccumulator.Accumulate(() => Assert.AreEqual(billingAddressFromBD.ContactPerson.Ext, apiResultBillingAddress.BillingAddress.ContactPerson.Ext, "Ext in Contact are not equel"));
            AssertsAccumulator.Accumulate(() => Assert.AreEqual(billingAddressFromBD.ContactPerson.FirstName, apiResultBillingAddress.BillingAddress.ContactPerson.FirstName, "FirstName in Contact are not equel"));
            AssertsAccumulator.Accumulate(() => Assert.AreEqual(billingAddressFromBD.ContactPerson.isPrimary, apiResultBillingAddress.BillingAddress.ContactPerson.isPrimary, "isPrimary in Contact are not equel"));
            AssertsAccumulator.Accumulate(() => Assert.AreEqual(billingAddressFromBD.ContactPerson.LastName, apiResultBillingAddress.BillingAddress.ContactPerson.LastName, "LastName in Contact are not equel"));
            AssertsAccumulator.Accumulate(() => Assert.AreEqual(billingAddressFromBD.ContactPerson.Phone, apiResultBillingAddress.BillingAddress.ContactPerson.Phone, "Phone in Contact are not equel"));
            AssertsAccumulator.Accumulate(() => Assert.AreEqual(billingAddressFromBD.ContactPerson.Position, apiResultBillingAddress.BillingAddress.ContactPerson.Position, "Position in Contact are not equel"));

            if (billingAddressFromBD.Location != null && apiResultBillingAddress.BillingAddress.Location != null)
            {
                AssertsAccumulator.Accumulate(() => Assert.AreEqual(billingAddressFromBD.Location.AddressId, apiResultBillingAddress.BillingAddress.Location.AddressId, "AddressId in Location are not equel"));
                AssertsAccumulator.Accumulate(() => Assert.AreEqual(billingAddressFromBD.Location.IsDefault, apiResultBillingAddress.BillingAddress.Location.IsDefault, "IsDefault in Location are not equel"));
                AssertsAccumulator.Accumulate(() => Assert.AreEqual(billingAddressFromBD.Location.Name, apiResultBillingAddress.BillingAddress.Location.Name, "Position in Location are not equel"));
            }
        }
    }
}
