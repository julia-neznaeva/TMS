using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using AutotetsApp.Gui.Framework;

namespace AutotestsApp.Gui.Forms
{

    public class Browser : BaseEntity
    {
        protected Browser _browser;
        private IWebDriver _driver;

        public  Browser GetInstance()
        {
            _driver = Provider.Instance;


            return this;
        }

        public IWebDriver GetDriver()
        {
            return _driver;
        }

        public void WaitForPageToLoad()
        {
            var wait = new WebDriverWait(GetDriver(), TimeSpan.FromMilliseconds(Convert.ToDouble(Configuration.GetTimeout())));
            try
            {
                wait.Until<Boolean>(waiting =>
                {
                    try
                    {
                        var result = ((IJavaScriptExecutor)GetDriver()).ExecuteScript("return document['readyState'] ? 'complete' == document.readyState : true");
                        return result != null && result is Boolean && (Boolean)result;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                });
            }
            catch (Exception)
            {
            }
        }

        public void WaitForPageToLoad(String url)
        {
            new WebDriverWait(Provider.Instance, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlToBe(url));

        }
    }
}
