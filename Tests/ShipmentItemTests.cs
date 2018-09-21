using AutotestsApp.Gui.Forms;
using AutotestsApp.Gui.Pages;
using AutotetsApp.Gui.Framework.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotetsApp.Gui.Tests
{ 
    public class ShipmentItemTests: BaseTest
    {
        LandingPage LandingPage => PageFactory.GetPage<LandingPage>();
        LoginPage LoginPage => PageFactory.GetPage<LoginPage>();
        HomePage HomePage => PageFactory.GetPage<HomePage>();
        QuotePage QuotePage => PageFactory.GetPage<QuotePage>();

        [Test]
        public void OnlyRequiredField()
        {
            LandingPage.Open();

            LandingPage.SignIn();

            LoginPage.LogIn("kate.test21@gmail.com", "123456789");

            QuotePage.Open().
                SetOriginallDropdownAddress("RT Rotisserie, 101 Oak Street, San Francisco, CA 94102, USA").
                SetDestinationAutocompleteAddress("Mizyak Test, 1202 Chalet Ln, Do Not Delete – Test Account, Pelham, AL 35124, USA");

            QuotePage.HandingUnit.SetL(QuoteConstants.DIMENSIONS_INTEGER).
                                  SetW(QuoteConstants.DIMENSIONS_INTEGER).
                                  SetH(QuoteConstants.DIMENSIONS_INTEGER);

            QuotePage.HandingUnit.Commodity.SetClass(QuoteConstants.CLASS).
                                            SetTotalWeight(QuoteConstants.TOTAL_WEIGHT);
            QuotePage.AddHandleUnit();

            QuotePage.ClickOnSelectCarrier();

        }

    }
}
