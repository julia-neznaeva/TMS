using AutotestApp.Common.Enums;
using NUnit.Framework;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace AutotestApp.Common
{
    public class BaseTest
    {
        private AssertsAccumulator _test;

        [OneTimeSetUp]
        public void TestMethod()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
        }

        [SetUp]
        public void RunBeforeEachTest()
        {
            Test.Clear();
        }

        [TearDown]
        public void RunAfterTest()
        {
            if (TestContext.CurrentContext.Test.Properties["Description"].Count() != 0)
            {
                Test.Info.Add(LogKey.TestDescription, TestContext.CurrentContext.Test.Properties["Description"].FirstOrDefault().ToString());
            }

            Test.Release();
        }

        public AssertsAccumulator Test => _test ?? (_test = new AssertsAccumulator());
    }
}
