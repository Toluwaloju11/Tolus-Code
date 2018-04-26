using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using ToluMSTestFramework.Configuration;
using ToluMSTestFramework.CustomException;
using ToluMSTestFramework.Settings;

namespace ToluMSTestFramework.BaseClasses
{
    [TestClass]
    public class Baseclass
    {
        private static IWebDriver GetFirefoxBrowser()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }
        private static IWebDriver GetChromeBrowser()
        {
            IWebDriver driver = new ChromeDriver();
            return driver;
        }

        private static IWebDriver GetIEBrowser()
        {
            IWebDriver driver = new InternetExplorerDriver();
            return driver;
        }
        [AssemblyInitialize]
        public static void InitWebDriver(TestContext tc)
        {
            ObjectRepository.Config = new AppConfigReader();

            switch (ObjectRepository.Config.GetBrowser())
            {
                case BrowserType.Firefox:
                    ObjectRepository.driver = GetFirefoxBrowser();
                    break;

                case BrowserType.Chrome:
                    ObjectRepository.driver = GetChromeBrowser();
                    break;

                case BrowserType.IExplorer:
                    ObjectRepository.driver = GetIEBrowser();
                    break;

                default: 
                    throw  new UnknownBrowser("Browser is unknown:" +
                        ObjectRepository.Config.GetBrowser().ToString());

            }
        }

    }
}
