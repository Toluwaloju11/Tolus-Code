using System;
using System.Configuration;
using Dec2018MSTestFramework.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dec2018MSTestFramework
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod, TestCategory("Tolu")]
        public void TestMethod1()
        {
           //String conf = ConfigurationManager.AppSettings.Get("Browser");
           // Console.WriteLine(conf);
           // Console.WriteLine(BrowserType.Chrome);
        }
    }
}
