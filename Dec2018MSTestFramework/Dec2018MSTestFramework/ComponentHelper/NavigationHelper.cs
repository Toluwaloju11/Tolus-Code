using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dec2018MSTestFramework.Settings;
using OpenQA.Selenium.Remote;

namespace Dec2018MSTestFramework.ComponentHelper
{
    public class NavigationHelper
    {
        public static void NavigateToURL(string url)
        {
            ObjectRepository.Driver.Navigate().GoToUrl(url);
            //ObjectRepository.Driver.Dispose();
        }
    }
}
