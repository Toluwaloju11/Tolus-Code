using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ToluMSTestFramework.ComponentHelper;
using ToluMSTestFramework.Settings;
using OpenQA.Selenium.Support.PageObjects;

namespace ToluMSTestFramework.PageObjectModel
{
   public class Page2RegisterAccountPage : RandomDataGenerator
   {
        #region Element

        [FindsBy(How = How.CssSelector, Using = "input[id='input-firstname']")]
        private IWebElement _firstName;
        [FindsBy(How = How.CssSelector, Using = "input[id='input-lastname']")]
        private IWebElement _lastName;
        [FindsBy(How = How.CssSelector, Using = "input[id='input-email']")]
        private IWebElement _email;
        [FindsBy(How = How.CssSelector, Using = "input[id='input-telephone']")]
        private IWebElement _telephone;
        [FindsBy(How = How.CssSelector, Using = "input[id='input-password']")]
        private IWebElement _password;
        [FindsBy(How = How.CssSelector, Using = "input[id='input-confirm']")]
        private IWebElement _confirmPassword;
        [FindsBy(How = How.CssSelector, Using = "input[type='radio'][value='1'][name='newsletter']")]
        private IWebElement _newsletterYes;
        [FindsBy(How = How.CssSelector, Using = "input[type='checkbox']")]
        private IWebElement _policyBox;
        [FindsBy(How = How.CssSelector, Using = "input[type='submit']")]
        private IWebElement _registerButton;
        #endregion Element

        #region CONSTRUCTOR
        public Page2RegisterAccountPage()
        {
            OpenQA.Selenium.Support.PageObjects.PageFactory.InitElements(ObjectRepository.driver, this);
        }
        #endregion

        #region Actions
        public void  RegisterNewAccount()
        {
            string firstName = Faker.Name.First();
            string lastName = Faker.Name.Last();
            string email = Faker.Internet.Email();
            string phoneNumber = Faker.Phone.Number();
            
            _firstName.SendKeys(firstName);
            _lastName.SendKeys(lastName);
            _email.SendKeys(email);
            _telephone.SendKeys(phoneNumber);
            _password.SendKeys(Password());
            _confirmPassword.SendKeys(Password());
            _newsletterYes.Click();
            _policyBox.Click();
        }
        #endregion

        #region Navigation
        public new Page3UserAccountPage NavigateToUserAccountPage()
       {
            
            _registerButton.Click();
            return new Page3UserAccountPage();
        }
        #endregion
    }
    
}
