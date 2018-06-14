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
        private static IWebDriver GetChromeBrowser()
        {
            IWebDriver driver = new ChromeDriver(GetChromeOptions());
            return driver;
        }
        private static ChromeOptions GetChromeOptions()
        {
            var cOptions = new ChromeOptions();
            cOptions.AddArgument("start-maximized");
            return cOptions;
        }

        private static ChromeOptions getMoreChromeOptions()
        {
            var moreCOption = new ChromeOptions();
            moreCOption.AddArgument("--headless");
            return moreCOption;
        }
        private static IWebDriver GetChromeBrowserExtra()
        {
            IWebDriver driver = new ChromeDriver(getMoreChromeOptions());
            return driver;
        }
        
        private static InternetExplorerOptions GetIEOptions()
        {
            var ieOptions = new InternetExplorerOptions();
            ieOptions.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            ieOptions.EnsureCleanSession = true;
            return ieOptions;
        }

        private static FirefoxProfile GetFirefoxOption()
        {
            var FProfile = new FirefoxProfile();
            FirefoxProfileManager fxManager = new FirefoxProfileManager();
            FProfile = fxManager.GetProfile("default");
            return FProfile;
        }
        
        private static IWebDriver GetFirefoxBrowser()
        {
            IWebDriver driver = new FirefoxDriver(GetFirefoxOption());
            return driver;
        }
        private static IWebDriver GetIEBrowser()
        {
            IWebDriver driver = new InternetExplorerDriver(GetIEOptions());
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
                case BrowserType.ChromeHeadless:
                    ObjectRepository.driver = GetChromeBrowserExtra();
                    break;
                case BrowserType.IExplorer:
                    ObjectRepository.driver = GetIEBrowser();
                    break;

                default: 
                    throw  new UnknownBrowser("Browser is unknown:" +
                        ObjectRepository.Config.GetBrowser().ToString());

            }
        }

        [AssemblyCleanup]
        public static void Teardown()
        {
            if (ObjectRepository.driver ==null)return;
            ObjectRepository.driver.Close();
            ObjectRepository.driver.Quit();
        }
    }
}
