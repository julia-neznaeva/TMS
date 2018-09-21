using AutotestsApp.Gui.Elements;
using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Support.UI;

namespace AutotetsApp.Gui.Framework.Elements
{
    public class Dropdown : BaseElement
    {
        public Dropdown(By locator, String name, IWebDriver driver) : base(locator, name, driver)
        {
        }

        public List<String> GetDropdownValues()
        {
            List<String> result = new List<String>();
            IWebElement dropdown = Driver.FindElement(GetLocator());
            ReadOnlyCollection<IWebElement> items = dropdown.FindElements(By.XPath(".//li/span"));
            foreach (var item in items)
            {
                result.Add(item.Text);
            }
            return result;
        }

        public void SetDropdown(String value)
        {
            String xpath=$"//li//span[contains(text(), '{value}')]";  
            new WebDriverWait(Driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
            GetElement().FindElementByXPath(xpath).Click();
        }

        public Dropdown Open()
        {
            GetElement().Click();
            return this;
        }

    }
}
