using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using ToluMSTestFramework.ComponentHelper;
using ToluMSTestFramework.Configuration;
using ToluMSTestFramework.Settings;

namespace ToluMSTestFramework
{
    [TestClass]
    public class ConfigTest
    {
        [TestMethod]
        [TestCategory("config")]
        public void TestMethod1()
        {

            //Console.WriteLine(ConfigurationManager.AppSettings.Get("Browser"));
            //IConfig config = new AppConfigReader();
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetDemoHome());
            MenuButtonHelper.SelectMenuButton(By.ClassName("caret"));
            MenuButtonHelper.SelectMenuButton(By.LinkText("Register"));
        }
    }
}
