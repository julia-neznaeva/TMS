using System;
using NUnit.Framework;
using AutotestsApp.Gui.Forms;
using AutotetsApp.Gui.Framework;

namespace AutotestsApp.Gui.Tests
{
    public class DemoTest : BaseTest
    {
        private readonly String username = RunConfigurator.GetValue("username");
        private readonly String password = RunConfigurator.GetValue("password");
        
        [Test]
        public void LoginSuccsesulyTest()
        {
            Log.Step(1);
            LandingPage landingPage = new LandingPage();

            Log.Step(2);
            landingPage.SignIn().
                LogIn("kate.test21@gmail.com", "123456789");

            Assert.AreEqual("http://mycarriertms.dotnet.itechcraft.com/customers/home", Provider.Instance.Url, "User was not dirrect on Home page");

            Log.Step(3);
        }

        [Test]
        public void RunTest1()
        {
            Log.Step(1);
            LandingPage landingPage = new LandingPage();

            Log.Step(2);
            landingPage.SignIn().
                LogIn("kate.test21@gmail.com", "123456789");

            Assert.AreEqual("http://mycarriertms.dotnet.itechcraft.com/customers/home", Provider.Instance.Url, "User was not dirrect on Home page");

            Log.Step(3);
        }
    }
}
