using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ToluMSTestFramework.Settings;

namespace ToluMSTestFramework.PageFactory
{
    public class HomePageFactory
    {
        #region WebElement
        [FindsBy(How = How.LinkText, Using = "My Account")]
        private IWebElement myAccountMenu;
        [FindsBy(How = How.LinkText, Using = "Register")]
        private IWebElement registerButton;
        #endregion

        public HomePageFactory()
        {
            OpenQA.Selenium.Support.PageObjects.PageFactory.InitElements(ObjectRepository.driver, this);
        }
        /*
         * //The reason for creating the above constructor is to inititialise the elements as soon
         *   as soon as an object of the class is created
         */
#region Actions
        public void NavigateToRegister()
        {
            myAccountMenu.Click();
        }
        #endregion

#region Navigation
        public RegistrationPageFactory Registrationpage()
        {
            registerButton.Click();
            return new RegistrationPageFactory();
        }
#endregion
    }
}
