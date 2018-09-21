using AutotestApp.Common;
using AutotetsApp.Gui.Framework;
using AutotetsApp.Gui.Framework.Pages;
using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Globalization;

namespace AutotestsApp.Gui.Forms
{
    [TestFixture]
    [NonParallelizable]
    public class BaseTest : BaseEntity
    {
        protected PagesFactory PageFactory { get; private set; }
        protected AssertsAccumulator AssertsAccumulator = new AssertsAccumulator();
        protected static System.Globalization.CultureInfo CurrentCulture => new CultureInfo("en-UA");
        protected Random Random = new Random(Environment.TickCount);

        [SetUp]
        public void SetUp()
        {
            PageFactory = new PagesFactory();
        }

        [TearDown]
        public void TearDown()
        {
            AssertsAccumulator.Release();
            PageFactory.CloseDriver();

            var processes = Process.GetProcessesByName(Configuration.GetBrowser());
            foreach (var process in processes)
            {
                process.Kill();
            }
        }
    }
}
