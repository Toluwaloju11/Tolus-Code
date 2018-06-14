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
using ToluMSTestFramework.TestScripts.MenuButton;

namespace ToluMSTestFramework.TestScripts.DropDownMenu
{
    [TestClass]
    public class TestDropdownMenu
    {
        [TestMethod, TestCategory("SELECT A MENU ")]
        public void SelectMenuButton()
        {
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetDemoHome());
            IWebElement dropdown = ObjectRepository.driver.FindElement(By.LinkText("Tablets"));
            dropdown.Click();
            IWebElement sortdropdown = ObjectRepository.driver.FindElement(By.Id("input-sort"));
            sortdropdown.Click();
            //The below is an avalable class used to select
            SelectElement selectpick = new SelectElement(sortdropdown);
            selectpick.SelectByIndex(1);


        }
    }
}
