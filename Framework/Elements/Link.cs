using OpenQA.Selenium;
using System;

namespace AutotestsApp.Gui.Elements
{
    public class Link : BaseElement
    {
        public Link(By locator, String name, IWebDriver driver) : base(locator, name, driver) { }
    }
}
