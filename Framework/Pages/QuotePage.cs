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
        private HandlingUnit _handingUnits => new HandlingUnit(By.XPath("////handling-unit//div[contains(@class, 'shipment-item')]"), "HandlingUnit", _driver); 

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

        public QuotePage SetOriginallAddress(String term)
        {
             _originDropdown.Open().SetDropdown(term); 
            return this; 
        }
    }
}
