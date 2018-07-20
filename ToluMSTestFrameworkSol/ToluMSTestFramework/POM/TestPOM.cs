using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToluMSTestFramework.ComponentHelper;
using ToluMSTestFramework.PageObjectModel;
using ToluMSTestFramework.Settings;

namespace ToluMSTestFramework.POM
{
    [TestClass]
   public class TestPOM
    {
        [TestMethod, TestCategory("PAGE OBJECT MODEL")]
        public void RunFirstPOMTest()
        {
            //LONG METHOD
            //var homePage = new Page1HomePage();
            //Page2RegisterAccountPage registerAccountPage = homePage.NavigateToRegisterAccount();
            //Page3UserAccountPage userAccountPage = registerAccountPage.NavigateToUserAccountPage();
            //Page4UserDetailsPage userDetailsPage = userAccountPage.NavigateToUserDetailsPage();
            //Page5DownloadPage downloadPage = userDetailsPage.ClickDownloadLink();

            //SHORT
            var homePage = new Page1HomePage();
            homePage.NavigateToRegisterAccount()
                .NavigateToUserAccountPage()
                .NavigateToUserDetailsPage()
                .ClickDownloadLink().NoNavigation();
        }
    }
}
