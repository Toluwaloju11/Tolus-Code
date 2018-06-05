using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ToluMSTestFramework.ComponentHelper
{
    public class LinkHelper
    {
        private static IWebElement _Element;

        public static void ClickLink(By locator)
        {
            _Element = GeneralclassHelper.getElement(locator);
            _Element.Click();
        }
    }
}
