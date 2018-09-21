using AutotestsApp.Gui.Forms;
using AutotetsApp.Gui.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutotestsApp.Gui.Elements
{
    public class BaseElement : BaseEntity
    {
        private readonly String _name;
        private readonly By _locator;
        private readonly IWebDriver _driver;
        protected IWebDriver Driver => _driver;

        protected BaseElement(By locator, String name, IWebDriver driver)
        {
            this._name = name;
            this._locator = locator;
            _driver = driver;
        }

        protected RemoteWebElement GetElement()
        {   
            WaitForElementPresent();
            return (RemoteWebElement)Driver.FindElement(_locator); 
        }

        protected RemoteWebElement GetLastElement()
        {
            Int32 size =Driver.FindElements(_locator).Count;
            return (RemoteWebElement)Driver.FindElements(_locator)[size-1];
        }

        protected String GetName()
        {
            return _name;
        }

        protected By GetLocator()
        {
            return _locator;
        }

        public void Click()
        {
            WaitElementToBeClickable();
            GetElement().Click();
            Log.Info(String.Format("{0} :: click", GetName()));
        }

        public String GetText()
        {
            return GetElement().Text;
        }

        public Boolean IsPresent()
        {
            bool isPresent = Driver.FindElements(_locator).Count > 0;
            Log.Info(GetName() + " : is present : " + isPresent);
            return isPresent;
        }

        protected void WaitForElementPresent()
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromMilliseconds(Convert.ToDouble(Configuration.GetTimeout())));
            try
            {
                wait.Until(waiting =>
                {
                    var webElements = Driver.FindElements(_locator);
                    return webElements.Count != 0;
                });
            }
            catch (TimeoutException)
            {
                Log.Fatal(string.Format("Element with locator: '{0}' does not exists!", _locator));
            }
        }

        protected void WaitElementToBeClickable()
        {
            new WebDriverWait(Driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(_locator));
        }

        protected void WaitElementToBeVisible()
        {
            new WebDriverWait(Driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(_locator));
        }

        public  void WaitForElementPresent(By locator, String name)
        {
            var wait = new WebDriverWait(new PagesFactory().Driver, TimeSpan.FromMilliseconds(Convert.ToDouble(Configuration.GetTimeout())));
            try
            {
                wait.Until(waiting =>
                {
                    try
                    {
                        var webElements = Driver.FindElements(locator);
                        return webElements.Count != 0;
                    }
                    catch (Exception )
                    {
                        return false;
                    }
                });
            }
            catch (TimeoutException)
            {
                Log.Fatal(string.Format("Element with locator: '{0}' does not exists!", locator));
            }
        }
    }
}
