using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using ToluMSTestFramework.ComponentHelper;
using ToluMSTestFramework.Settings;

namespace ToluMSTestFramework.TestScripts.PageNavigation
{
    [TestClass]
    public class TestNavigationPage
    {
        [TestMethod]
        [TestCategory("New Browser Launch")]
        public void OpenPage()
        {
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetWebsite());
        }

        [TestMethod]
        [TestCategory("Grocery Page launch")]
        public void OpenGroceriesPage()
        {
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetGroceries());
            Console.WriteLine(WindowHelper.GetPageTitle());

        }

    }
}
