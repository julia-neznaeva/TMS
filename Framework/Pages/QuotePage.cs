using AutotestsApp.Gui.Elements;
using AutotestsApp.Gui.Forms;
using AutotetsApp.Gui.Framework.Elements;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotetsApp.Gui.Framework.Pages
{
    public class QuotePage : BaseEntity
    {
        private IWebDriver _driver;
        private const String _url = "http://mycarriertms.dotnet.itechcraft.com/customers/quote";
        private Button _selectCarrier => new Button(By.XPath("//span[. = 'Select Carrier']//parent::button[@type = 'button']"), "SelectCarrier Button", _driver);
        private Validation _originValidation => new Validation(By.XPath("//qp-origin//span[@class = 'error long']"), "Validation Message Origin Field", _driver);
        private Validation _destinationValidation => new Validation(By.XPath("//qp-destination//span[@class = 'error long']"), "Validation Message Destination Field", _driver);
        private Link _addHandingUnit => new Link(By.XPath("//span[.= 'Add H/U']/parent::a"), "Add Hunding Unit", _driver);
        private Dropdown _originDropdown => new Dropdown(By.XPath("//qp-origin//div[contains( @class,'prime-dropdown-wrapper')]"), "Origin Dropdown", _driver);
        private Autocomplete _oridinAutocomplete => new Autocomplete(By.XPath("//qp-origin//input[@aria-autocomplete='list']"), "Origin Autocomplite", _driver);
        private Autocomplete _destinationAutocomlete => new Autocomplete(By.XPath("//qp-destination//input[@aria-autocomplete='list']"), "Destination Autocomplite", _driver);
        private Dropdown _destinationDropdown => new Dropdown(By.XPath("//qp-destination//div[contains( @class,'prime-dropdown-wrapper')]"), "Destination Dropdown", _driver);
        private Button _prepaid => new Button(By.XPath("//input[@name ='prepaid']/.."), "Prepaid Button", _driver);
        private Button _collect => new Button(By.XPath("//input[@name ='collect']/.."), "Collected Button", _driver);
        private Button _thirdPatry => new Button(By.XPath("//input[@name ='thirdParty']/.."), "Third Button", _driver);
        private Span _accessSettings => new Span(By.XPath("//div[@class='access-settings']"), "Access-settings popup", _driver);
        private Toggle _vltlToggle => new Toggle(By.XPath("//div[contains(@class, 'ltl-volume-toggler')]//md-slide-toggle"), "VLTL toggle", _driver);
        private TextBox _linearFeet => new TextBox(By.XPath("//input[@placeholder= 'Linear Feet']"), "Linear Feet", _driver);
        private TextBox _pickUp => new TextBox(By.XPath("//input[@placeholder  ='mm/dd/yyyy']"), "Pick up field", _driver);

        public  HandlingUnit HandingUnit => new HandlingUnit(By.XPath("//handling-unit//div[contains(@class, 'shipment-item')]"), "HandlingUnit", _driver); 

        public QuotePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public QuotePage ClickOnSelectCarrier()
        {
            _selectCarrier.Click();
            return this;
        }

        public QuotePage Open()
        {
            _driver.Url = _url;
            _driver.Navigate();
            new WebDriverWait(_driver, TimeSpan.FromSeconds(50)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlToBe(_url));
            return this;
        }

        public QuotePage AddHandleUnit()
        {
            _addHandingUnit.Click();
            return this;
        }

        public String GetOriginValidationMessage()
        {
            return _originValidation.GetValidationMessage();
        }

        public String GetDestinationValidationMessage()
        {
            return _destinationValidation.GetValidationMessage();
        }

        public List<String> GetOriginDropdownAddress()
        {
            return _originDropdown.Open().GetDropdownValues();
        }

        public QuotePage SetOriginallDropdownAddress(String term)
        {
             _originDropdown.Open().SetDropdown(term); 
            return this; 
        }

        public QuotePage SetOriginAutocompleteAddress(String term)
        {
            _oridinAutocomplete.Click();
            _oridinAutocomplete.InputValueToAutocomplete(term);
            _oridinAutocomplete.SelectFist();
            return this;

        }

        public QuotePage SetDestinationAutocompleteAddress(String term)
        {
            _destinationAutocomlete.InputValueToAutocomplete(term);
            _destinationAutocomlete.SelectFist();
            return this;

        }

        public QuotePage SetDestinationDropdownAddress(String term)
        {
            _destinationDropdown.Open().SetDropdown(term);
            return this;
        }

        public QuotePage CheckOnPrepaid()
        {
            _prepaid.Click();
            return this;
        }

        public QuotePage CheckOnInboundCollect()
        {
            _collect.Click();
            return this;
        }

        public QuotePage CheckOnThirdParty()
        {
            _thirdPatry.Click();
            return this;
        }

        public Boolean IsAccessSettingDisplayed()
        {
            return _accessSettings.IsPresent();
        }

        public String GetMessageFromAccessSettingDisplayed()
        {
            return _accessSettings.GetText();
        }

        public QuotePage SwitchVLTLToggle()
        {
            _vltlToggle.Switch();
            return this;
        }

        public Boolean IsVltlTogglePresent()
        {
            return _vltlToggle.IsPresent();
        }

        public Boolean IsLinearFeetPresent()
        {
            return _linearFeet.IsPresent();
        }

        public QuotePage InputPickupDate(DateTime date)
        {
            _pickUp.Clear();
            _pickUp.SetText(date.ToString("mm/dd/yyyy"));
            _pickUp.SetText(Keys.Tab);
            return this;
        }

        public DateTime GetDataFromInputPickUpDate()
        {
            DateTime result; 
            DateTime.TryParse( _pickUp.GetText(), out result);
            return result;
        }
    }
}
