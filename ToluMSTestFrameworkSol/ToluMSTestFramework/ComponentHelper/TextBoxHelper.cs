using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ToluMSTestFramework.ComponentHelper
{
   public class TextBoxHelper
   {
       private static IWebElement element;

       public static void SendTextToTextbox(By locator, string text)
       {
           element = GeneralclassHelper.getElement(locator);
            element.SendKeys(text);
       }
        public static void ClearTextBox(By locator)
        {
            element = GeneralclassHelper.getElement(locator);
            element.Clear();
        }
    }
}
