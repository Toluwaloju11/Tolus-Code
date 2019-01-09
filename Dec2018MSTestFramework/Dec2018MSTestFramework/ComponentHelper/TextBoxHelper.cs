using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Dec2018MSTestFramework.ComponentHelper
{
    public class TextBoxHelper
    {

        private static IWebElement _element;
        public static void SendText(By locator, string text)
        {
            _element = GenericHelper.GetElement(locator);
            _element.SendKeys(text);
        }

        public static void ClearText(By locator)
        {
            _element = GenericHelper.GetElement(locator);
            _element.Clear();
        }
    }
}
