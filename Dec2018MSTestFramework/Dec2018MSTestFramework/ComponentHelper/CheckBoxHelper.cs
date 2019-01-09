using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Dec2018MSTestFramework.ComponentHelper
{
    public class CheckBoxHelper
    {
        private static IWebElement _element;

        public static void CheckCheckBox(By locator)
        {
            _element = GenericHelper.GetElement(locator);
            _element.Click();
        }

        public static bool IsCheckBoxChecked(By locator)
        {
            _element = GenericHelper.GetElement(locator);
            var checkBox = _element.GetAttribute("type");

            if (checkBox == null)
            {
                return false;
            }
            else
            {
                return checkBox.Equals("checkbox") || checkBox.Equals("true");
            }
        }
    }
}

