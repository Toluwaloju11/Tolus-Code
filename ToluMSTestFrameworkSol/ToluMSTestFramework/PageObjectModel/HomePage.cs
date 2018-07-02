using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ToluMSTestFramework.ComponentHelper;

namespace ToluMSTestFramework.PageObjectModel
{
   public class HomePage
   {
        //The start of the web element region
       private readonly By _myAccountTab   = By.ClassName("caret");
       private readonly By _registerButton = By.LinkText("Register");
        //The end of the web element region

            //This is the start of the action region
       public RegisterAccountPage SelectRegisterAccountPage()
        {
           MenuButtonHelper.SelectMenuButton(_myAccountTab);
           MenuButtonHelper.SelectMenuButton(_registerButton);
            return new RegisterAccountPage();
       }
        //This is the start of the action region

    }
}
