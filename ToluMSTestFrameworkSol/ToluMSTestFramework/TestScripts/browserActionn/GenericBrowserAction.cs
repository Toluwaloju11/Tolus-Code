using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ToluMSTestFramework.ComponentHelper;
using ToluMSTestFramework.Settings;

namespace ToluMSTestFramework.TestScripts.browserActionn
{
    [TestClass]
    public class GenericBrowserAction
    {
        [TestMethod, TestCategory("Browser Action")]
        public void SimulateAction()
        {
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetDemoHome());
             //IMPLICIT WAIT
           // ObjectRepository.driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(15);
            Console.WriteLine("The page tittle is {0}:", WindowHelper.GetPageTitle());
            MenuButtonHelper.SelectMenuButton(By.ClassName("fa-search"));
            Console.WriteLine("The page tittle is {0}:", WindowHelper.GetPageTitle());
            //ObjectRepository.driver.Navigate().Back();
            BrowserActionHelper.BackButton();
            Console.WriteLine("The page tittle is {0}:", WindowHelper.GetPageTitle());
            //ObjectRepository.driver.Navigate().Forward();
            BrowserActionHelper.ForwardButton();
            Console.WriteLine("The page tittle is {0}:", WindowHelper.GetPageTitle());
            //ObjectRepository.driver.Navigate().Refresh();
            BrowserActionHelper.RefreshButton();
            Console.WriteLine("The page tittle is {0}:", WindowHelper.GetPageTitle());
         
        }

        [TestMethod, TestCategory("Explicit Wait")]
        public void TestExplicitWait()
        {
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetDemoHome());
            var  wait = new WebDriverWait(ObjectRepository.driver, TimeSpan.FromSeconds(15))
            {
                PollingInterval = TimeSpan.FromMilliseconds(250)
            };
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException),typeof(NoSuchElementException));
            //wait.Until(WaitForElement());
            wait.Until(WaitForString());
            wait.Until(WaitForElementTwo());
        }
        private static Func<IWebDriver, bool> WaitForElement()
        {
            Console.WriteLine("Waiting to select the search button");
            return (x) => x.FindElements(By.ClassName("Btn-default")).Count == 1;
        }
        private static Func<IWebDriver, string> WaitForString()
        {
            Console.WriteLine("Waiting to select the search button");
            return (x) => x.Title.Contains("") ? x.Title : null;
        }
        private static Func<IWebDriver, IWebElement> WaitForElementTwo()
        {
            Console.WriteLine("Waiting to select the search button");
            return
                (x) =>
                    x.FindElements(By.ClassName("Btn-default")).Count == 1
                        ? x.FindElement(By.ClassName("Btn-default"))
                        : null;
        }

    }
}
