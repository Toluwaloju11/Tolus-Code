using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ToluMSTestFramework.ComponentHelper;
using OpenQA.Selenium.Support.PageObjects;

namespace ToluMSTestFramework.PageObjectModel
{
   public class HomePage
   {
        #region Element
        private readonly By _myAccountTab   = By.ClassName("caret");
        private readonly By _registerButton =
           By.LinkText("Register");
        //   [FindsBy(How = How.ClassName, Using = "caret")] private IWebElement _myAccountTab2;
        #endregion Element

        #region Actions
        public void ClickMyAccount()
       {
           // MenuButtonHelper.SelectMenuButton(_myAccountTab);
       }
        #endregion
        #region Navigation
        public new RegisterAccountPage NavigateToRegisterAccount()
       {
            MenuButtonHelper.SelectMenuButton(_myAccountTab);
            MenuButtonHelper.SelectMenuButton(_registerButton);
            return new RegisterAccountPage();
       }
        #endregion 

    }
}
