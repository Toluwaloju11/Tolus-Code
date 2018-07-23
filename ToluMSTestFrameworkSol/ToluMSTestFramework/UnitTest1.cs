using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using ToluMSTestFramework.ComponentHelper;
using ToluMSTestFramework.Settings;

namespace ToluMSTestFramework
{
    [TestClass]
    public class UnitTest1
    {
        private string _password = "coldfire";

        [TestMethod,TestCategory("AA")]
        public void TestMethod1()
        {
            string firstname = Faker.Name.First();
            string lastname = Faker.Name.Last();
            string email = Faker.Internet.Email(lastname);
            string phoneNumber = Faker.Phone.Number();

            //NavigationHelper.NavigateToURL(ObjectRepository.Config.GetDemoHome());
            //MenuButtonHelper.SelectMenuButton(By.CssSelector("a[title='My Account']"));
            //MenuButtonHelper.SelectMenuButton(
            //    By.CssSelector("#top-links > ul > li.dropdown.open > ul > li:nth-child(1) > a"));
            //TextBoxHelper.SendTextToTextbox(By.CssSelector("input[id='input-firstname']"), firstname);
            //TextBoxHelper.SendTextToTextbox(By.CssSelector("input[id='input-lastname']"), lastname);
            //TextBoxHelper.SendTextToTextbox(By.CssSelector("input[id='input-email']"), email);
            //TextBoxHelper.SendTextToTextbox(By.CssSelector("input[id='input-telephone']"), phoneNumber);
            //TextBoxHelper.SendTextToTextbox(By.CssSelector("input[id='input-password']"), _password);
            //TextBoxHelper.SendTextToTextbox(By.CssSelector("input[id='input-confirm']"), _password);
            //MenuButtonHelper.SelectMenuButton(By.CssSelector("input[type='radio'][value='1'][name='newsletter']"));
            //RadioButtonHelper.ClickOnOneRadiobutton(By.CssSelector("input[type='checkbox']"));
            //MenuButtonHelper.SelectMenuButton(By.CssSelector("input[type='submit']"));
            Console.WriteLine(email);
        }
    }
}
