using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToluMSTestFramework.Configuration;

namespace ToluMSTestFramework
{
    [TestClass]
    public class ConfigTest
    {
        [TestMethod]
        [TestCategory("config")]
        public void TestMethod1()
        {
    
            Console.WriteLine(ConfigurationManager.AppSettings.Get("Browser"));
           //IConfig config = new AppConfigReader();
        }
    }
}
