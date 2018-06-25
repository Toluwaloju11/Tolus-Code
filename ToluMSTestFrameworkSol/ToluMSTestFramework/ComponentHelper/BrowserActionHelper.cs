using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToluMSTestFramework.Settings;

namespace ToluMSTestFramework.ComponentHelper
{
    public class BrowserActionHelper
    {
        public static void MaximiseBrowser()
        {
            ObjectRepository.driver.Manage().Window.Maximize();
        }
        public static void BackButton()
        {
            ObjectRepository.driver.Navigate().Back();
        }
        public static void ForwardButton()
        {
            ObjectRepository.driver.Navigate().Forward();
        }
        public static void RefreshButton()
        {
            ObjectRepository.driver.Navigate().Refresh();
        }
    }
}
