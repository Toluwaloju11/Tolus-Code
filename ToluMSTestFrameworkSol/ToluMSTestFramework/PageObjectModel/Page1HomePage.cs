using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        private readonly By _myAccountTab   = By.ClassName("caret");
        private readonly By _registerButton = By.LinkText("Register");

        //private readonly By _registerButton = By.XPath("//a[contains(text(),'Register')]");
        #endregion Element

        #region Actions
        public void ClickMyAccount()
       {
           //NavigationHelper.NavigateToURL(ObjectRepository.Config.GetDemoHome());
           //MenuButtonHelper.SelectMenuButton(_myAccountTab);
           //MenuButtonHelper.SelectMenuButton(_registerButton);
        }
        #endregion

        #region Navigation
        public new Page2RegisterAccountPage NavigateToRegisterAccount()
       {
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetDemoHome());
            MenuButtonHelper.SelectMenuButton(_myAccountTab);
            MenuButtonHelper.SelectMenuButton(_registerButton);

            return new Page2RegisterAccountPage();
       }
        #endregion 

    }
}
