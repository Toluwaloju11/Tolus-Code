using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ToluMSTestFramework.ComponentHelper;
using ToluMSTestFramework.Settings;
using OpenQA.Selenium.Support.PageObjects;

namespace ToluMSTestFramework.PageObjectModel
{
    public class Page3UserAccountPage
    {
        #region Element
        [FindsBy(How = How.LinkText, Using =  "Account")]
        private IWebElement _accountsLink;
        
        #endregion

        #region CONSTRUCTOR
        public  Page3UserAccountPage()
        {
            OpenQA.Selenium.Support.PageObjects.PageFactory.InitElements(ObjectRepository.driver, this);

        }
        #endregion

        #region Action
        public void NavigateToDownloadPage()
        {
            
        }
        #endregion

        #region Navigation
        public new Page4UserDetailsPage NavigateToUserDetailsPage()
        {
            _accountsLink.Click();
            return new Page4UserDetailsPage();
        }
        #endregion

    }
}
