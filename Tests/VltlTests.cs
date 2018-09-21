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

    public class VltlTests:BaseTest
    {
        LandingPage LandingPage => PageFactory.GetPage<LandingPage>();
        LoginPage LoginPage => PageFactory.GetPage<LoginPage>();
        HomePage HomePage => PageFactory.GetPage<HomePage>();
        QuotePage QuotePage => PageFactory.GetPage<QuotePage>();


        [Test]
        public void VltlToggleDisplayed()
        {
            LandingPage.Open();

            LandingPage.SignIn();

            LoginPage.LogIn("kate.test21@gmail.com", "123456789");

            QuotePage.Open();

            AssertsAccumulator.Accumulate(() => Assert.IsFalse(QuotePage.IsLinearFeetPresent(), "Linear Feed displayed"));

            AssertsAccumulator.Accumulate(() => Assert.IsTrue(QuotePage.IsVltlTogglePresent()));

            QuotePage.SwitchVLTLToggle();

            AssertsAccumulator.Accumulate(() => Assert.IsTrue(QuotePage.IsLinearFeetPresent(), "Linear Feed hidden"));
        }

        [Test]
        public void VltlToggleHidden()
        {
            LandingPage.Open();

            LandingPage.SignIn();

            LoginPage.LogIn("cuswithoutVLTLcarrier@yopmail.com", "123456789");

            QuotePage.Open();

            Assert.IsFalse(QuotePage.IsVltlTogglePresent());
        }
    }
}
