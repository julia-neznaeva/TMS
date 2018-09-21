using AutotestsApp.Gui.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutotetsApp.Gui.Framework.Elements
{
    public class Toggle : BaseElement
    {
        public Toggle(By locator, string name, IWebDriver driver) : base(locator, name, driver)
        {
        }

        public void Switch()
        {
            GetElement().Click();
            Log.Info(String.Format("{0} :: switch'", GetName()));
        }


    }
}
