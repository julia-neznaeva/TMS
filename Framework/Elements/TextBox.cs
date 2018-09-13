using OpenQA.Selenium;
using System;

namespace AutotestsApp.Gui.Elements
{
    public class TextBox : BaseElement
    {
        public TextBox(By locator, String name) : base(locator, name){}

        public void SetText(String text)
        {
            WaitElementToBeVisible();
            GetElement().Click();
            GetElement().SendKeys(text);
            Log.Info(String.Format("{0} :: type text '{1}'", GetName(), text));
        }
    }
}
