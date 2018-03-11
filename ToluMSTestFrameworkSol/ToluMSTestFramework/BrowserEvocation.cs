using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ToluMSTestFramework
{
    [TestClass]
    public class BrowserEvocation
    {
        [TestMethod]
        [TestCategory("Selenium")]
        public void TestMethod1()
        {
          IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://uk.yahoo.com/?p=us");
            driver.Quit();
            Thread.Sleep(5000);
            
        }
    }
}
