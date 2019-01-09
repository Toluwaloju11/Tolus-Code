using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dec2018MSTestFramework.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Dec2018MSTestFramework.ComponentHelper
{
    public class WaitHelper
    {
        //Explicit waits
        private static IWebElement _element;
        public static void WaitForElement(By locator)
        {
            var wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(15));
            _element = wait.Until(d => d.FindElement(locator));
        }

        }
}