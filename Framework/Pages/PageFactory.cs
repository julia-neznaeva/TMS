using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotetsApp.Gui.Framework.Pages
{
    public class PageFactory
    {
        private IWebDriver _driver;

        public PageFactory()
        {
            String isUseGrid = String.Empty;
            //new DriverManager().SetUpDriver(new ChromeConfig());
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("chrome.switches", "–disable-extensions");

            if (Boolean.Parse(isUseGrid))
            {
                String url = String.Empty;
                _driver = new RemoteWebDriver(new Uri(url), options.ToCapabilities(), TimeSpan.FromSeconds(60));
            }
            else
            {
                ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                _driver = new ChromeDriver(service, options, TimeSpan.FromSeconds(60));
                _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            }
            _driver.Manage().Window.Maximize();

            _pages = new Dictionary<Object, Object>();

        }
            

        private IDictionary<Object, Object> _pages;

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

        public void Close()
        {
            _driver.Close();
        }
    }
}
