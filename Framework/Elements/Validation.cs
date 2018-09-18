using AutotestsApp.Gui.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutotetsApp.Gui.Framework.Elements
{
    public class Validation : BaseElement
    {
        public Validation(By locator, String name, IWebDriver driver) : base(locator, name, driver)
        {
        }

        public String GetValidationMessage()
        {
            Log.Info($"Get Test of {GetName()}");
            return GetElement().Text;
        }

       
    }
}
