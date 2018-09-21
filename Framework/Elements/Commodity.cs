using AutotestsApp.Gui.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutotetsApp.Gui.Framework.Elements
{
    public class Commodity : BaseElement
    {
        private String rootElementXpath;
        public Int32 CountUnit = 1;

        private Autocomplete _commodityDescription => new Autocomplete(By.XPath($"({rootElementXpath}//itm-list[1])//input"), "Commodity Description", Driver);

    private TextBox _nmfc => new TextBox(By.XPath($"{rootElementXpath}//input[@placeholder= 'NMFC']"), "NMFC", Driver);
        private Span _nmfcValidator => new Span(By.XPath($"{rootElementXpath}//input[@placeholder= 'NMFC']//following-sibling::span[@class = 'error long']"), "NMFC ValidationMessage", Driver);

        private TextBox _sub => new TextBox(By.XPath($"{rootElementXpath}//input[@placeholder= 'SUB']"), "SUB", Driver);
        private Span _subValidator => new Span(By.XPath($"{rootElementXpath}//input[@placeholder= 'SUB']//following-sibling::span[@class = 'error long']"), "Sub ValidationMessage", Driver);

        private Dropdown _class => new Dropdown(By.XPath($"{rootElementXpath}//div[contains(@class, 'itm-list') and not( contains(@class, 'autocomplete') )]"), "Class", Driver);
        private Span _classValidator => new Span(By.XPath($"{rootElementXpath}//div[contains(@class, 'itm-list') and not( contains(@class, 'autocomplete') )]//following-sibling::span[@class = 'error long']"), "Class ValidationMessage", Driver);

        private NumericStepper _pieces => new NumericStepper(By.XPath($"{rootElementXpath}//input[@formcontrolname= 'commodityTotalPieces']"), "Piese", Driver);
        private Span _piecesValidator => new Span(By.XPath($"{rootElementXpath}//input[@formcontrolname= 'commodityTotalPieces']//following-sibling::span[@class = 'error long']"), "Pieces ValidationMessage", Driver);

        private TextBox _totalWeight => new TextBox(By.XPath($"{rootElementXpath}//input[@formcontrolname= 'commodityTotalWeight']"), "Piese", Driver);
        private Span _totalValidator => new Span(By.XPath($"{rootElementXpath}//input[@formcontrolname= 'commodityTotalWeight']//following-sibling::span[@class = 'error long']"), "Pieces ValidationMessage", Driver);

        private CheckBox _hazMat => new CheckBox(By.XPath($"{rootElementXpath}//md-checkbox[@formcontrolname ='commodityIsHazardous']"), "HazMat" , Driver);

        private Button _delete => new Button(By.XPath($"{rootElementXpath}//div[contains(@class, 'remove-item')]"), "Delete Comodity", Driver);

        public Commodity(By locator, string name, IWebDriver driver) : base(locator, name, driver)
        {
            rootElementXpath = $"//commodity[1]";
        }

        public Commodity(By locator, string name, IWebDriver driver, Int32 index) : base(locator, name, driver)
        {
            CountUnit = index;
            rootElementXpath = $"//commodity[{CountUnit}]";
        }

        public String GetNMFCValidationMessage()
        {
            return _nmfcValidator.GetText();
        }

        public String GetSUBValidationMessage()
        {
            return _subValidator.GetText();
        }

        public String GetClassValidationMessage()
        {
            return _classValidator.GetText();
        }

        public String GetPiecesValidationMessage()
        {
            return _piecesValidator.GetText();
        }

        public String GetTotalWeightValidationMessage()
        {
            return _totalValidator.GetText();
        }

        public Commodity SetClass(Int32 value)
        {
            _class.Open();
            _class.SetDropdown(value.ToString());
            return this;
        }

        public Commodity SetTotalWeight(Decimal value)
        {
            _totalWeight.SetText(value.ToString());
            return this;
        }

        public Commodity SetTotalWeight(String value)
        {
            _totalWeight.SetText(value);
            return this;
        }

        public Commodity SetNMFC(Decimal value)
        {
            _nmfc.SetText(value.ToString());
            return this;
        }

        public Commodity SetNMFC(String value)
        {
            _nmfc.SetText(value);
            return this;
        }

        public Commodity SetSub(Decimal value)
        {
            _sub.SetText(value.ToString());
            return this;
        }

        public Commodity SetSub(String value)
        {
            _sub.SetText(value);
            return this;
        }

        public Commodity SetPieces(Decimal value)
        {
            _pieces.SetText(value.ToString());
            return this;
        }

        public Commodity SetPieces(String value)
        {
            _pieces.SetText(value);
            return this;
        }

        public Commodity CheckHazMat()
        {
            _hazMat.Click();
            return this;
        }

        public Commodity SetCommodity(String value)
      {
            _commodityDescription.Click();
            _commodityDescription.InputValueToAutocomplete(value);
            _commodityDescription.SelectItem(value);
            return this;


        }

        public void Delete()
        {
            _delete.Click();
        }

    }
}
