using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ToluMSTestFramework.ComponentHelper;
using ToluMSTestFramework.Settings;

namespace ToluMSTestFramework.PageObjectModel
{
   public class RegisterAccountPage
   {
        #region Element
        private readonly By _firstName       = By.Id("input-firstname");
       private readonly By _lastName        = By.Id("input-lastname");
       private readonly By _email           = By.Id("input-email");
       private readonly By _telephone       = By.Id("input-telephone");
       private readonly By _password        = By.Id("input-password");
       private readonly By _confirmPassword = By.Id("input-confirm");
       private readonly By _newsletterYes   = By.XPath("//*[@id=\"content\"]/form/fieldset[3]/div/div/label[1]/input");
       private readonly By _policyBox       = By.XPath("//*[@id=\"content\"]/form/div/div/input[1]");
       private readonly By _registerButton  = By.ClassName("btn-primary");
        #endregion Element

        #region Actions
        public void  RegisterNewAccount()
        {
            
            }
        #endregion

        #region Navigation
        public new UserAccountPage NavigateToUserAccountPage()
       {
            TextBoxHelper.SendTextToTextbox(_firstName, "Tolu");
            TextBoxHelper.SendTextToTextbox(_lastName, "Wright");
            TextBoxHelper.SendTextToTextbox(_email, "a12uskkd4@yahoo.com");
            TextBoxHelper.SendTextToTextbox(_telephone, "0123444566789");
            TextBoxHelper.SendTextToTextbox(_password, "goodguy");
            TextBoxHelper.SendTextToTextbox(_confirmPassword, "goodguy");
            RadioButtonHelper.ClickOnOneRadiobutton(_newsletterYes);
            CheckBoxHelper.ClickCheckBox(_policyBox);
            MenuButtonHelper.SelectMenuButton(_registerButton);
            return new UserAccountPage();
        }
        #endregion
    }
    //public UserAccountPage RegisterNewAccount()
    
}
