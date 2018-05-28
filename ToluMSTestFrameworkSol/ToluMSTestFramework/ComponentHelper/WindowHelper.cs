using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using ToluMSTestFramework.Settings;

namespace ToluMSTestFramework.ComponentHelper
{
    class WindowHelper
    {
        public static string GetPageTitle()
        {
            return ObjectRepository.driver.Title;
        }
    }
}
