using AutotetsApp.Gui.Framework;
using NUnit.Framework;
using System.Diagnostics;


namespace AutotestsApp.Gui.Forms
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class BaseTest : BaseEntity
    {
        public Browser Browser = new Browser();
        [SetUp]
        public void SetUp()
       {
            Provider.Instance.Navigate().GoToUrl(Configuration.GetBaseUrl());
        }

        [TearDown]
        public void TearDown()
        {
            var processes = Process.GetProcessesByName(Configuration.GetBrowser());
            foreach (var process in processes)
            {
                process.Kill();
            }
            //Browser.GetDriver().Quit();
        }
    }
}
