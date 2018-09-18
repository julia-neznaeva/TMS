using OpenQA.Selenium;
using System;

namespace AutotestsApp.Gui.Elements
{
    public class Button : BaseElement
    {
        public Button(By locator, String name, IWebDriver driver) : base(locator, name, driver) { }
    }
}
