using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToluMSTestFramework.Settings;

namespace ToluMSTestFramework.ComponentHelper
{
    public class NavigationHelper
    {
        public static void NavigateToURL(string URL)
        {
            //INavigation page = ObjectRepository.driver.Navigate();
            //page.GoToUrl(ObjectRepository.Config.GetWebsite());
            ObjectRepository.driver.Navigate().GoToUrl(URL);

        }


    }
}
