using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotetsApp.Gui.Framework
{
    public sealed class Provider
    {
        //public static IWebDriver WebDriver { get; private set; }
        //private static object syncRoot = new Object();

        //public static IWebDriver GetDriver()
        //{
        //    if (WebDriver == null)
        //    {
        //        lock (syncRoot)
        //        {
        //            if (WebDriver==null)
        //                WebDriver = new ChromeDriver("D:\\smart_csharp_mini\\resources");
        //                WebDriver.Manage().Window.Maximize();
        //        }
        //    }

        //    return WebDriver;
        //}


        private static Lazy<IWebDriver> webDriver = new Lazy<IWebDriver>(() =>
        {
            IWebDriver driver = new ChromeDriver("D:\\smart_csharp_mini\\resources");
            driver.Manage().Window.Maximize();
            return driver;
        });

        private Provider() { }

        public static IWebDriver Instance  // use a property, since this is C#...
        {
            get { return webDriver.Value; }
        }
    }
}
