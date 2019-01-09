using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dec2018MSTestFramework.Configuration;
using Dec2018MSTestFramework.CustomException;
using Dec2018MSTestFramework.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32.SafeHandles;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace Dec2018MSTestFramework.Base
{ [TestClass]
    public class BaseClass  
    {

#region BrowserOptions
        private static ChromeOptions GetChromeOptions()
        {
         ChromeOptions COptions = new ChromeOptions();
            COptions.AddArgument("--start-maximized");
            //OTHER AVALIABLE ARGUEMENTS
            //COptions.AddArgument("--ignore-certificate-errors");
            //COptions.AddArgument("--disable-popup-blocking");
            //COptions.AddArgument("--incognito");
            return COptions;
        }
        private static ChromeOptions GetMoreChromeOptions()
        {
            var MChromeOptions = new ChromeOptions();
            MChromeOptions.AddArgument("--headless");
            return MChromeOptions;
        }

        private static InternetExplorerOptions GetIEOptions()
        {
            var ieOptions = new InternetExplorerOptions();
            {
                ieOptions.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                ieOptions.EnsureCleanSession = true;
            }
            return ieOptions;
        }
        private static FirefoxProfile GetFirefoxOptions()
        {
            var fOptions = new FirefoxProfile();
            var fxManager = new FirefoxProfileManager();
            fOptions = fxManager.GetProfile("default");
            return fOptions;
        }
        #endregion
#region DriverInstance
        private static IWebDriver GetFirefoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }
        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver(GetChromeOptions());
            return driver;
        }
        private static IWebDriver GetIExplorerDriver()
        {
            IWebDriver driver = new InternetExplorerDriver(GetIEOptions());
            return driver;
        }

        private static IWebDriver GetExtraChromeDriver()
        {
            IWebDriver driver = new ChromeDriver(GetMoreChromeOptions());
            return driver;
        }
        #endregion
        [AssemblyInitialize]
        public static void InitWebDriver(TestContext testContext)
        {
            ObjectRepository.Config = new AppConfigReader();
            switch (ObjectRepository.Config.GetBrowser())
            {
                case BrowserType.Firefox:
                ObjectRepository.Driver = GetFirefoxDriver();
                break;

                case BrowserType.Chrome:
                    ObjectRepository.Driver = GetChromeDriver();
                    break;

                case BrowserType.ChromeHeadless:
                    ObjectRepository.Driver = GetExtraChromeDriver();
                    break;
                case BrowserType.Explorer:
                    ObjectRepository.Driver = GetIExplorerDriver();
                    break;

                default:
                    throw new NoSuitableDriverFound("Driver not Found {}", ObjectRepository.Config.GetBrowser());
            }
            //Implicit Wait
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            //PageLoad handles it better
            // ObjectRepository.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(15);
        }
#region BrowserTeardown
        [AssemblyCleanup]
    public static void TearDown()
    {
        if (ObjectRepository.Driver != null)
        ObjectRepository.Driver.Close();
        ObjectRepository.Driver.Quit();
        ObjectRepository.Driver.Dispose();
    }
#endregion
    }
}
