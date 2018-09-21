using AutotestApp.Common;
using AutotestsApp.Gui.Elements;
using AutotetsApp.Gui.Framework.Elements;
using OpenQA.Selenium;
using System;

namespace AutotetsApp.Gui.Framework.Pages
{
    public class HandlingUnit : BaseElement
    {
        private String rootElementXpath;
        public Int32 CountUnit = 1;

        public HandlingUnit(By locator, string name, IWebDriver driver) : base(locator, name, driver)
        {
            rootElementXpath = $"//handling-unit[1]";
        }       

         public HandlingUnit(By locator, string name, IWebDriver driver, Int32 index) : base(locator, name, driver)
        {
            CountUnit = index;
            rootElementXpath= $"//handling-unit[{CountUnit}]";
        }

        private Dropdown _type => new Dropdown(By.XPath($"{rootElementXpath}//p-dropdown"), "Type", Driver);
        private NumericStepper _count => new NumericStepper(By.XPath($"{rootElementXpath}//div[contains(@class, 'count-item')]//input"), "Count", Driver);
        private Span _countValidator => new Span(By.XPath($"{rootElementXpath}//div[contains(@class, 'count-item')]//input/following-sibling::span[@class = 'error long']"), "Count Validation Message", Driver);
        private TextBox _dimensionsL => new TextBox(By.XPath($"{rootElementXpath}//input[@placeholder= 'L']"), "L", Driver);
        private Span _dimensionsLValidator => new Span(By.XPath($"{rootElementXpath}//input[@placeholder= 'L']/following-sibling::span[@class = 'error long']"), "LValidationMessage", Driver);
        private TextBox _dimensionsW => new TextBox(By.XPath($"{rootElementXpath}//input[@placeholder= 'W']"), "W", Driver);
        private Span _dimensionsWValidator => new Span(By.XPath($"{rootElementXpath}//input[@placeholder= 'W']/following-sibling::span[@class = 'error long']"), "WValidationMessage", Driver);
        private TextBox _dimensionsH => new TextBox(By.XPath($"{rootElementXpath}//input[@placeholder= 'H']"), "H", Driver);
        private Span _dimensionsHValidator => new Span(By.XPath($"{rootElementXpath}//input[@placeholder= 'H']/following-sibling::span[@class = 'error long']"), "HValidationMessage", Driver);
        private CheckBox _stackable => new CheckBox(By.XPath($"{rootElementXpath}//md-checkbox[@formcontrolname = 'handlingUnitIsStackable']"), "Stackable", Driver);
        private Button _delete => new Button(By.XPath($"{rootElementXpath}//i[contains(@class, 'remove ')]"), "Delete Shipment Button", Driver);
        private Button _addCommodity => new Button(By.XPath($"{rootElementXpath}//div[@class = 'commodity-action']/a"),"Add Commodity", Driver ); 

        public Commodity Commodity => new Commodity(By.XPath(""), "Commodity", Driver); 
        

        public String GetDimensionsLValidationMessage()
        {
            return _dimensionsLValidator.GetText();
        }

        public String GetDimensionsWValidationMessage()
        {
            return _dimensionsWValidator.GetText();
        }

        public String GetDimensionsHValidationMessage()
        {
            return _dimensionsHValidator.GetText();
        }

        public String GetCountValidationMessage()
        {
            return _countValidator.GetText();
        }

        public void Delete()
        {
            _delete.Click();
        }

        public HandlingUnit SetL(Decimal value)
        {
            _dimensionsL.SetText(value.ToString());
            return this;
        }

        public HandlingUnit SetW(Decimal value)
        {
            _dimensionsW.SetText(value.ToString());
            return this;
        }

        public HandlingUnit SetH(Decimal value)
        {
            _dimensionsH.SetText(value.ToString());
            return this;
        }

        public HandlingUnit SetType(String type)
        {
            _type.Open().SetDropdown(type);
            return this;
        }

        public HandlingUnit SetCount(Decimal value)
        {
            _count.SetText(value.ToString("0.0"));
            return this;
        }

        public HandlingUnit SetCount(String value)
        {
            _count.SetText(value);
            return this;
        }

        public HandlingUnit CheckStackable()
        {
            _stackable.Click();
            return this;
        }

        public Commodity AddCommodity()
        {
            _addCommodity.Click();
            Commodity.CountUnit++;
            return new Commodity(By.XPath($"{rootElementXpath}//commodity)]"), "Commodity Section", Driver, Commodity.CountUnit + 1);
        }


    }
}