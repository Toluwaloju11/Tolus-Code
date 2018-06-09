using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ToluMSTestFramework.ComponentHelper
{
    public class CheckBoxHelper
    {
        private static IWebElement _element;

        public static void ClickCheckBox(By locator)
        {
           _element = GeneralclassHelper.getElement(locator);
            _element.Click();
        }

        public static bool IsCheckboxSelected(By locator)
        {
            _element = GeneralclassHelper.getElement(locator);
           string CheckBoxstatus = _element.GetAttribute("agree");
            if (CheckBoxstatus != null)
                return CheckBoxstatus.Equals("true") ||CheckBoxstatus.Equals("checked");
            return false;
            

        }
    }
}
