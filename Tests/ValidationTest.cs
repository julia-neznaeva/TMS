using System;
using NUnit.Framework;
using AutotestsApp.Gui.Forms;
using AutotestsApp.Gui.Pages;
using AutotetsApp.Gui.Framework.Pages;

namespace AutotestsApp.Gui.Tests
{
    public class DemoTest : BaseTest
    {
        LandingPage LandingPage => PageFactory.GetPage<LandingPage>();
        LoginPage LoginPage => PageFactory.GetPage<LoginPage>();
        HomePage HomePage => PageFactory.GetPage<HomePage>();
        QuotePage QuotePage => PageFactory.GetPage<QuotePage>();

        private const String ORIGINAL_VALIDATION_MESSAGE = "Origin address is required";
        private const String DESTINATION_VALIDATION_MESSAGE = "Destination address is required";

        [Test]
        public void AllEmpyFieldValidation()
        {
            LandingPage.Open();

            LandingPage.SignIn();

            LoginPage.LogIn("kate.test21@gmail.com", "123456789");

            QuotePage.Open().ClickOnSelectCarrier();

            AssertsAccumulator.Accumulate(() => Assert.AreEqual(ORIGINAL_VALIDATION_MESSAGE, QuotePage.GetOriginValidationMessage()));

            AssertsAccumulator.Accumulate(() => Assert.AreEqual(DESTINATION_VALIDATION_MESSAGE, QuotePage.GetDestinationValidationMessage()));


        }



        [Test]
        public void AllEmpyFieldValidation1()
        {
            LandingPage.Open();

            LandingPage.SignIn();

            LoginPage.LogIn("kate.test21@gmail.com", "123456789");

            QuotePage.Open().ClickOnSelectCarrier().SetOriginallAddress("RT Rotisserie, 101 Oak Street, San Francisco, CA 94102, USA");

      }

    }
}
