using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToluMSTestFramework.ComponentHelper;
using ToluMSTestFramework.PageObjectModel;
using ToluMSTestFramework.Settings;

namespace ToluMSTestFramework.DataDriven
{
    [TestClass]
   public class SampleDataDrivenTest
    {
        public TestContext TestContext { get; set;}

        [TestMethod]
        public void LoginToApp()
        {
           NavigationHelper.NavigateToURL(ObjectRepository.Config.GetDemoHome()); 
            var homepage = new Page1HomePage();
        }
    }
}
