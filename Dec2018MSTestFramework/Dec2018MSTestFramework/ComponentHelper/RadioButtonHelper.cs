using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Dec2018MSTestFramework.ComponentHelper
{
    public class RadioButtonHelper
    {
        private static IWebElement _element;

        public static bool IsRadioButtonEnabled(By locator)
        {
            _element = GenericHelper.GetElement(locator);
            //checked will only work if there is "Checked" in the locator
            var radioButtonStatus = _element.GetAttribute("checked");
            if (radioButtonStatus != null)
            {
                return radioButtonStatus.Equals("true") || radioButtonStatus.Equals("checked");
            }
            else
            {
                return false;
            }
            
        }
        public static void ClicRadiokButton(By locator)
        {
            _element = GenericHelper.GetElement(locator);
            _element.Click();
        }
    }
}
