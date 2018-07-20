using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ToluMSTestFramework.ComponentHelper;

namespace ToluMSTestFramework.PageObjectModel
{
    public class Page3UserAccountPage
    {
        #region Element
        private readonly By _accountsLink = By.LinkText("Account");
        #endregion

        #region Action
        public void NavigateToDownloadPage()
        {
            
        }
        #endregion

        #region Navigation
        public new Page4UserDetailsPage NavigateToUserDetailsPage()
        {
            LinkHelper.ClickLink(_accountsLink);
            return new Page4UserDetailsPage();
        }
        #endregion

    }
}
