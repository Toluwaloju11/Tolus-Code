using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ToluMSTestFramework.ComponentHelper;
using OpenQA.Selenium.Support.PageObjects;
using ToluMSTestFramework.Settings;

namespace ToluMSTestFramework.PageObjectModel
{
    //PAGE 1
   public class Page1HomePage
   {
        #region Element
        [FindsBy(How = How.CssSelector, Using = "a[title='My Account']")]
        private IWebElement _myAccountTab;
        [FindsBy(How = How.CssSelector, Using = "#top-links > ul > li.dropdown.open > ul > li:nth-child(1) > a")]
        private IWebElement _registerButton;
        #endregion Element

       public Page1HomePage()
       {
           OpenQA.Selenium.Support.PageObjects.PageFactory.InitElements(ObjectRepository.driver, this);
       }

        #region Actions
        public void ClickMyAccount()
       {
           NavigationHelper.NavigateToURL(ObjectRepository.Config.GetDemoHome());
            
        }
        #endregion

        #region Navigation
        public new Page2RegisterAccountPage NavigateToRegisterAccount()
       {
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetDemoHome());
            _myAccountTab.Click();
            _registerButton.Click();
            return new Page2RegisterAccountPage();
       }
        #endregion 
    }
}
