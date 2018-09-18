using AutotestApp.Common;
using AutotetsApp.Gui.Framework;
using AutotetsApp.Gui.Framework.Pages;
using NUnit.Framework;
using System.Diagnostics;


namespace AutotestsApp.Gui.Forms
{
    [TestFixture]
    [NonParallelizable]
    public class BaseTest : BaseEntity
    {
        protected PagesFactory PageFactory { get; private set; }
        protected AssertsAccumulator AssertsAccumulator = new AssertsAccumulator();

        [SetUp]
        public void SetUp()
        {
            PageFactory = new PagesFactory();
        }

        [TearDown]
        public void TearDown()
        {
            PageFactory.CloseDriver();

            var processes = Process.GetProcessesByName(Configuration.GetBrowser());
            foreach (var process in processes)
            {
                process.Kill();
            }
        }
    }
}
