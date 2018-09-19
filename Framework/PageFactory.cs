using AutotestApp.Common;
using AutotestsApp.Gui.Forms;
using AutotestsApp.Gui.Pages;
using AutotetsApp.Gui.Framework.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotetsApp.Gui.Framework
{

    public sealed class PagesFactory
    {
        private IWebDriver _driver;
        private IDictionary<Object, Object> _pages;
        public IWebDriver Driver => _driver;

        public PagesFactory()
        {

            ChromeOptions options = new ChromeOptions();
            options.AddArguments("chrome.switches", "–disable-extensions");
            String isUseGrid = "false";//ConfigurationManager.AppSettings["IsUseGrid"];
            if (Boolean.Parse(isUseGrid))
            {
                String url = String.Empty;
                _driver = new RemoteWebDriver(new Uri(url), options.ToCapabilities(), TimeSpan.FromSeconds(60));
                //_driver = new RemoteWebDriver(new Uri("{}http://192.168.16.78/wd/hub"), options.ToCapabilities(), TimeSpan.FromSeconds(30000));
            }
            else
            {
                ChromeDriverService service = ChromeDriverService.CreateDefaultService(Config.Instance.ResourcePath);
                 _driver = new ChromeDriver(service, options, TimeSpan.FromSeconds(60));
                 _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            }
             _driver.Manage().Window.Maximize();
            _pages = new Dictionary<Object, Object>();

            _pages.Add(typeof(HomePage), new HomePage(_driver));
            _pages.Add(typeof(LandingPage), new LandingPage(_driver));
            _pages.Add(typeof(LoginPage), new LoginPage(_driver));
            _pages.Add(typeof(QuotePage), new QuotePage(_driver));
        }

        public T GetPage<T>()
        {
            try
            {
                return (T)_pages[typeof(T)];
            }
            catch (KeyNotFoundException)
            {
                throw new ApplicationException("The requested service is not registered");
            }
        }

        public void CloseDriver()
        {
            Driver.Quit();
        }
    }
}
