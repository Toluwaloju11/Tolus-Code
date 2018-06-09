using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ToluMSTestFramework.ComponentHelper
{
    public class MenuButtonHelper
    {
        private static IWebElement _element;
        public static void SelectMenuButton(By locator)
        {
            _element = GeneralclassHelper.getElement(locator);
            _element.Click();
        }
        public static bool IsButtonenabled(By locator)
        {
            _element = GeneralclassHelper.getElement(locator);
            return _element.Enabled;

        }

        public static string GetButtontext(By locator)
        {
            _element = GeneralclassHelper.getElement(locator);
            //if (_element.GetAttribute("value") == null)
            //{
            //    return string.Empty;
            //}
            //else
            //{
            //    return _element.GetAttribute("value");
            //}

            return _element.GetAttribute("value") ?? string.Empty;
        }
    }
}
