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
        private Autocomplete _commodityDescription => new Autocomplete(By.XPath("//div[contains(@class, 'itm-list' and contains(@class, 'autocomplete'))]"), "Commodity Description", Driver);

        private TextBox _nmfc => new TextBox(By.XPath("//input[@placeholder= 'NMFC']"), "NMFC", Driver);
        private Span _nmfcValidator => new Span(By.XPath("//input[@placeholder= 'NMFC']//following-sibling::span[@class = 'error long']"), "NMFC ValidationMessage", Driver);

        private TextBox _sub => new TextBox(By.XPath("//input[@placeholder= 'SUB']"), "SUB", Driver);
        private Span _subValidator => new Span(By.XPath("//input[@placeholder= 'SUB']//following-sibling::span[@class = 'error long']"), "Sub ValidationMessage", Driver);

        private Dropdown _class => new Dropdown(By.XPath("//div[contains(@class, 'itm-list') and not( contains(@class, 'autocomplete') )]"), "Class", Driver);
        private Span _classValidator => new Span(By.XPath("//div[contains(@class, 'itm-list') and not( contains(@class, 'autocomplete') )]//following-sibling::span[@class = 'error long']"), "Class ValidationMessage", Driver);

        private NumericStepper _pieces => new NumericStepper(By.XPath("//input[@formcontrolname= 'commodityTotalPieces']"), "Piese", Driver);
        private Span _piecesValidator => new Span(By.XPath("//input[@formcontrolname= 'commodityTotalPieces']//following-sibling::span[@class = 'error long']"), "Pieces ValidationMessage", Driver);

        private TextBox _totalWeight => new TextBox(By.XPath("//input[@formcontrolname= 'commodityTotalWeight']"), "Piese", Driver);
        private Span _totalValidator => new Span(By.XPath("//input[@formcontrolname= 'commodityTotalWeight']//following-sibling::span[@class = 'error long']"), "Pieces ValidationMessage", Driver);

        private CheckBox _hazMat => new CheckBox(By.XPath("//md-checkbox[@formcontrolname ='commodityIsHazardous']"), "HazMat" , Driver);

        private Button Delete => new Button(By.XPath(""), "Delete Comodity", Driver);

        public Commodity(By locator, string name, IWebDriver driver) : base(locator, name, driver)
        {
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

    }
}
