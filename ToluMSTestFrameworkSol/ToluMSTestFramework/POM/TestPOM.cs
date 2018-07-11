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
            //Long Winded way of POM
            //NavigationHelper.NavigateToURL(ObjectRepository.Config.GetDemoHome());
            //HomePage homePage = new HomePage();
            //RegisterAccountPage registerAccountPage = homePage.SelectRegisterAccountPage();
            //UserAccountPage userAccountPage = registerAccountPage.RegisterNewAccount();
            //DownloadPage downloadPage = userAccountPage.NavigateToDownloadPage();
            //downloadPage.DownloadsPageView();

            //Short method of POM
                var homePage = new HomePage();
           RegisterAccountPage registerAccountPage = homePage.NavigateToRegisterAccount();
           UserAccountPage userAccountPage = registerAccountPage.NavigateToUserAccountPage();
           UserDetailsPage userDetailsPage =  userAccountPage.NavigateToUserDetailsPage();
           DownloadPage downloadPage = userDetailsPage.ClickDownloadLink();
            // .NavigateToUserAccountPage();
            //NavigateToUserDetailsPage().
            //ClickDownloadLink().
            //DownloadButton();









        }
    }
}
