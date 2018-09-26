using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ToluMSTestFramework.ComponentHelper
{
   public  class RadioButtonHelper
   {
       private static IWebElement _element;

        public static void ClickOnOneRadiobutton(By locator)
        {
            _element = GeneralclassHelper.getElement(locator);
            _element.Click();
        }
        public static void ClickRadiobutton(By locator)
        {
            _element = GeneralclassHelper.getElement(locator);
            _element.Click();
        }

        public static bool IsradioButtonSelected(By locator)
        {
            _element = GeneralclassHelper.getElement(locator);
            var RadioButtonstatus = _element.GetAttribute("checked");
            if (RadioButtonstatus != null)
            return RadioButtonstatus.Equals("true") 
                || RadioButtonstatus.Equals("checked");
            return false;
        }

        internal static void ClickOnOneRadioButton(By _newsletterYes)
        {
            throw new NotImplementedException();
        }
    }
}
