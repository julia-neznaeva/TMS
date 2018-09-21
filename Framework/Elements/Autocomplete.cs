using AutotestsApp.Gui.Elements;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AutotetsApp.Gui.Framework.Elements
{
    public class Autocomplete : BaseElement
    {
        private String _itemPath = "//md-option";

        public Autocomplete(By locator, string name, IWebDriver driver) : base(locator, name, driver)
        {
        }

        public List<String> GetAutocompleteItems()
        {
            List<String> result = new List<String>();
            IWebElement dropdown = Driver.FindElement(GetLocator());
            ReadOnlyCollection<IWebElement> items = dropdown.FindElements(By.XPath(_itemPath));
            foreach (var item in items)
            {
                result.Add(item.Text);
            }
            return result;
        }

        public void SelectItem(String value)
        {
            By xpathLocator = By.XPath($"//*[contains(text(), '{value}')]");
            new WebDriverWait(Driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(xpathLocator));
            Driver.FindElement(By.XPath($"//*[contains(text(), '{value}')]")) .Click();
        }

        public void InputValueToAutocomplete(String value)
        {
            GetElement().SendKeys(value);
        }

        public Boolean IsDisplayed()
        {
            Span items = new Span(By.XPath(_itemPath), "Autocomplete Item", Driver);
            return items.IsPresent();
        }

        public void SelectFist()
        {
            new WebDriverWait(Driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(_itemPath)));
            Driver.FindElement(By.XPath(_itemPath)).Click();
        }

    }
}
