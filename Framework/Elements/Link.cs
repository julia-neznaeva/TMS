using OpenQA.Selenium;
using System;

namespace AutotestsApp.Gui.Elements
{
    public class Link : BaseElement
    {
        public Link(By locator, String name) : base(locator, name) { }

        public Link(By locator) : base(locator, String.Empty) { }
    }
}
