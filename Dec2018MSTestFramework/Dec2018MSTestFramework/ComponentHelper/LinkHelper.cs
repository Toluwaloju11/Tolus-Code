﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Dec2018MSTestFramework.ComponentHelper
{
    public class LinkHelper
    {
        private static IWebElement _element;

        public static void ClickLink(By locator)
        {
            _element = GenericHelper.GetElement(locator);
            _element.Click();
        }
    }
}
