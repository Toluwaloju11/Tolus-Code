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
       private readonly By _firstName       = By.Id("input-firstname");
       private readonly By _lastName        = By.Id("input-lastname");
       private readonly By _email           = By.Id("input-email");
       private readonly By _telephone       = By.Id("input-telephone");
       private readonly By _password        = By.Id("input-password");
       private readonly By _confirmPassword = By.Id("input-confirm");
       private readonly By _newsletterYes   = By.Name("newsletter");
       private readonly By _policyBox       = By.ClassName("agree");
       private readonly By _registerButton  = By.ClassName("btn btn-primary");
        public UserAccountPage RegisterNewAccount()
        {
            TextBoxHelper.SendTextToTextbox(_firstName, "Tolu");
            TextBoxHelper.SendTextToTextbox(_lastName, "Wright");
            TextBoxHelper.SendTextToTextbox(_email, "Twright2008@yahoo.com");
            TextBoxHelper.SendTextToTextbox(_telephone, "0123444566789");
            TextBoxHelper.SendTextToTextbox(_password, "goodguy");
            TextBoxHelper.SendTextToTextbox(_confirmPassword, "goodguy");
            RadioButtonHelper.ClickOnOneRadiobutton(_newsletterYes);
            CheckBoxHelper.ClickCheckBox(_policyBox);
            MenuButtonHelper.SelectMenuButton(_registerButton);
            return new UserAccountPage();

        }
    }
    //public UserAccountPage RegisterNewAccount()
    
}
