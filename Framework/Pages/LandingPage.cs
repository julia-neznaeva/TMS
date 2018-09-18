using AutotestApp.Common;
using AutotestsApp.Gui.Elements;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutotestsApp.Gui.Forms
{
    public class LandingPage: BaseEntity
    {
        public Link SignInLink => new Link(By.XPath("//ul[@class = 'header-menu']//li[.='Sign In']"), "SignIn Link", _driver);
        private IWebDriver _driver;
        private String _url => $"{Config.Instance.BaseUrl}/landing";


        public LandingPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public LandingPage SignIn()
        {
            SignInLink.Click();
            return this;
        }

        public LandingPage Open()
        {
            _driver.Url = _url;
            _driver.Navigate();
            new WebDriverWait(_driver, TimeSpan.FromSeconds(50)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlToBe(_url));
            return this;
        }
    }
}
