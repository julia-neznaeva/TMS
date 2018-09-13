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
        //private readonly RemoteWebElement _element;
        private readonly String _name;
        private readonly By _locator;
        private  Browser _browser=> new Browser().GetInstance();

        protected BaseElement(By locator, String name)
        {
            this._name = name;
            this._locator = locator;
        }

        protected RemoteWebElement GetElement()
        {   
            WaitForElementPresent();
            return (RemoteWebElement)_browser.GetDriver().FindElement(_locator); ;
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
            //Browser.WaitForPageToLoad();
            Log.Info(String.Format("{0} :: click", GetName()));
        }

        public Boolean IsPresent()
        {
            bool isPresent = _browser.GetDriver().FindElements(_locator).Count > 0;
            Log.Info(GetName() + " : is present : " + isPresent);
            return isPresent;
        }

        protected void WaitForElementPresent()
        {
            var wait = new WebDriverWait(_browser.GetDriver(), TimeSpan.FromMilliseconds(Convert.ToDouble(Configuration.GetTimeout())));
            try
            {
                wait.Until(waiting =>
                {
                    var webElements = _browser.GetDriver().FindElements(_locator);
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
            new WebDriverWait(_browser.GetDriver(), TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(_locator));
        }

        protected void WaitElementToBeVisible()
        {
            new WebDriverWait(_browser.GetDriver(), TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(_locator));
        }

        public  void WaitForElementPresent(By locator, String name)
        {
            var wait = new WebDriverWait(Provider.Instance, TimeSpan.FromMilliseconds(Convert.ToDouble(Configuration.GetTimeout())));
            try
            {
                wait.Until(waiting =>
                {
                    try
                    {
                        var webElements = _browser.GetDriver().FindElements(locator);
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
