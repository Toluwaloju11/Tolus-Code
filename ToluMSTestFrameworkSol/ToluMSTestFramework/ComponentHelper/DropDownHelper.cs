using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToluMSTestFramework.Settings;

namespace ToluMSTestFramework.ComponentHelper
{
    public class DropDownHelper
    {
        public static void SelectByIndex(By locator, int index)
        {
            IWebElement sortdropdown = ObjectRepository.driver.FindElement(locator);
            sortdropdown.Click();
            SelectElement selectpick = new SelectElement(sortdropdown);
            selectpick.SelectByIndex(index);
        }
        public static void SelectByText(By locator, string text)
        {
            IWebElement sortdropdown = ObjectRepository.driver.FindElement(locator);
            sortdropdown.Click();
            SelectElement selectpick = new SelectElement(sortdropdown);
            selectpick.SelectByText(text);
        }
    }
}
