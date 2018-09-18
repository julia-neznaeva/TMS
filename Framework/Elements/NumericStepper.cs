using AutotestsApp.Gui.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutotetsApp.Gui.Framework.Elements
{
    public class NumericStepper : BaseElement
    {
        public NumericStepper(By locator, String name, IWebDriver driver) : base(locator, name, driver)
        {
        }



    }
}
