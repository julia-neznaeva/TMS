using AutotestsApp.Gui.Forms;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutotestsApp.Gui.Pages
{
    public class HomePage : BaseEntity
    {
        private const String _url = "http://mycarriertms.dotnet.itechcraft.com/customers/home";
        private IWebDriver _driver;

        public HomePage()
        {
            Log.Info(String.Format("Moving to home page"));
        }

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public Boolean IsLoad()
        {
            new WebDriverWait(_driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlToBe(_url));
            return (_driver.Url.Equals(_url));
        }
    }
}