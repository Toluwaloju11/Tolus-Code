using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Dec2018MSTestFramework.ComponentHelper
{
    public class DropDownHelper
    {
        private static SelectElement _select;

        public static void SelectElementByIndex(By locator, int index)
        {
            _select = new SelectElement(GenericHelper.GetElement(locator));
            _select.SelectByIndex(index);
        }
        public static void SelectElementByText(By locator, String indexText)
        {
            _select = new SelectElement(GenericHelper.GetElement(locator));
            _select.SelectByText(indexText);
        }
        public static void SelectElementByValue(By locator, String indexValue)
        {
            _select = new SelectElement(GenericHelper.GetElement(locator));
            _select.SelectByText(indexValue);
        }

        public static IList<string> AllDropdownMenuItem(By locator)
        {
            _select = new SelectElement(GenericHelper.GetElement(locator));
            return _select.Options.Select((x) => x.Text).ToList();
        }
    }
}
