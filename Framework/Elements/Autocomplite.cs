using AutotestsApp.Gui.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AutotetsApp.Gui.Framework.Elements
{
    public class Autocomplite : BaseElement
    {
        private String _itemPath = "//md-option";

        public Autocomplite(By locator, string name, IWebDriver driver) : base(locator, name, driver)
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

        }

        public void InputValueToAutocomplete(String value)
        {

        }

        public Boolean IsDisplayed()
        {
            Span items = new Span(By.XPath(_itemPath), "AutocompleteItem", Driver);
            return items.IsPresent();
        }

    }
}
