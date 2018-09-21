using AutotestApp.Bl.Model.GetQuoteData;
using AutotestApp.Bl.QuoteServices;
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
    public class PickupTests: BaseTest
    {
        LandingPage LandingPage => PageFactory.GetPage<LandingPage>();
        LoginPage LoginPage => PageFactory.GetPage<LoginPage>();
        HomePage HomePage => PageFactory.GetPage<HomePage>();
        QuotePage QuotePage => PageFactory.GetPage<QuotePage>();
        QuoteService _quoteService = new QuoteService();

        [Test]
        public void CheckHandleInput()
        {
            LandingPage.Open();

            LandingPage.SignIn();

            LoginPage.LogIn("kate.test21@gmail.com", "123456789");

            QuotePage.Open().InputPickupDate(DateTime.Today);

            //Assert.AreEqual(DateTime.Today, QuotePage.GetDataFromInputPickUpDate(), "There is an unexpected date in pick up input field"); 
        }

        [Test]
        public void HolidayDayAreDisabled()
        {
            List<DisabledDate> disablesDateFromDB = _quoteService.GetDisabledDates();

            DateTime randomDeliveryDate = disablesDateFromDB[Random.Next(0, disablesDateFromDB.Count)].to.Value;

            LandingPage.Open();

            LandingPage.SignIn();

            LoginPage.LogIn("kate.test21@gmail.com", "123456789");
        }

    }
}
