using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
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
    }
}
