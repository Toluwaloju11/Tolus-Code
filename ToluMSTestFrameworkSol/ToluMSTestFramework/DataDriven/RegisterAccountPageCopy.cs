﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ToluMSTestFramework.ComponentHelper;
using ToluMSTestFramework.Settings;

namespace ToluMSTestFramework.DataDriven
{
    [TestClass]
    public class RegisterAccountPageCopy
    {
        public TestContext Testcontext { get; set; }
        private readonly By _myAccountTab = By.ClassName("caret");
        private readonly By _registerButton = By.LinkText("Register");
        private readonly By _firstName = By.Id("input-firstname");
        private readonly By _lastName = By.Id("input-lastname");
        private readonly By _email = By.Id("input-email");
        private readonly By _telephone = By.Id("input-telephone");
        private readonly By _password = By.Id("input-password");
        private readonly By _confirmPassword = By.Id("input-confirm");
        private readonly By _newsletterYes = By.XPath("//*[@id=\"content\"]/form/fieldset[3]/div/div/label[1]/input");
        private readonly By _policyBox = By.XPath("//*[@id=\"content\"]/form/div/div/input[1]");
        private readonly By _createAccountButton = By.ClassName("btn-primary");
        private readonly By _logoutButton = By.LinkText("Logout");
        private readonly By _loginTab = By.LinkText("Login");
        private readonly By _loginEmail = By.Id("input-email");
        private readonly By _loginPassword = By.Id("input-password");
        private readonly By _loginUserButton = By.XPath("//input[@type='submit']");



        [TestMethod, TestCategory("CSV-READER")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"C:\Users\Tester\Automation\Tolus-Code\ToluMSTestFrameworkSol\ToluMSTestFramework\DataFiles\CreateAccount.csv",
            "CreateAccount#csv", DataAccessMethod.Sequential)]
        public void RegisterNewAccount()
        {
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetDemoHome());
            MenuButtonHelper.SelectMenuButton(_myAccountTab);
            MenuButtonHelper.SelectMenuButton(_registerButton);
            TextBoxHelper.SendTextToTextbox(_firstName,Testcontext.DataRow["FIRSTNAME"].ToString());
            TextBoxHelper.SendTextToTextbox(_lastName,Testcontext.DataRow["LASTNAME"].ToString());
            TextBoxHelper.SendTextToTextbox(_email,Testcontext.DataRow["EMAIL"].ToString());
            TextBoxHelper.SendTextToTextbox(_telephone,Testcontext.DataRow["TELEPHONE"].ToString());
            TextBoxHelper.SendTextToTextbox(_password,Testcontext.DataRow["PASSWORD"].ToString());
            TextBoxHelper.SendTextToTextbox(_confirmPassword,Testcontext.DataRow["CONFIRMPASSWORD"].ToString());
            RadioButtonHelper.ClickOnOneRadiobutton(_newsletterYes);
            CheckBoxHelper.ClickCheckBox(_policyBox);
            MenuButtonHelper.SelectMenuButton(_createAccountButton);
            MenuButtonHelper.SelectMenuButton(_myAccountTab);
            MenuButtonHelper.SelectMenuButton(_logoutButton);
            }
        [TestMethod, TestCategory("CSV-READER")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"C:\Users\Tester\Automation\Tolus-Code\ToluMSTestFrameworkSol\ToluMSTestFramework\DataFiles\Login.csv",
            "Login#csv", DataAccessMethod.Sequential)]
        public void AccountLogin()
        {
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetDemoHome());
            MenuButtonHelper.SelectMenuButton(_myAccountTab);
            MenuButtonHelper.SelectMenuButton(_loginTab);
            TextBoxHelper.SendTextToTextbox(_loginEmail, Testcontext.DataRow["EMAIL"].ToString());
            TextBoxHelper.SendTextToTextbox(_loginPassword, Testcontext.DataRow["PASSWORD"].ToString());
            MenuButtonHelper.SelectMenuButton(_loginUserButton);
            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://demo.opencart.com/");
            //driver.Manage().Window.Maximize();
            //driver.FindElement(_myAccountTab).Click();
            //driver.FindElement(_loginTab).Click();
            //driver.FindElement(_loginEmail).SendKeys(Testcontext.DataRow["EMAIL"].ToString());
            //driver.FindElement(_loginPassword).SendKeys(Testcontext.DataRow["PASSWORD"].ToString());
            //driver.FindElement(_loginUserButton).Click();
            //driver.Quit();
        }
        [TestMethod, TestCategory("XML-READER")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            @"C:\Users\Tester\Automation\Tolus-Code\ToluMSTestFrameworkSol\ToluMSTestFramework\DataFiles\TestData.XML",
            "Row", DataAccessMethod.Sequential)]
        public void XMLRegisterNewAccount()
        {
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetDemoHome());
            MenuButtonHelper.SelectMenuButton(_myAccountTab);
            MenuButtonHelper.SelectMenuButton(_registerButton);
            TextBoxHelper.SendTextToTextbox(_firstName, Testcontext.DataRow["Firstname"].ToString());
            TextBoxHelper.SendTextToTextbox(_lastName, Testcontext.DataRow["Lastname"].ToString());
            TextBoxHelper.SendTextToTextbox(_email, Testcontext.DataRow["Email"].ToString());
            TextBoxHelper.SendTextToTextbox(_telephone, Testcontext.DataRow["Telephone"].ToString());
            TextBoxHelper.SendTextToTextbox(_password, Testcontext.DataRow["Password"].ToString());
            TextBoxHelper.SendTextToTextbox(_confirmPassword, Testcontext.DataRow["ConfirmPassword"].ToString());
            RadioButtonHelper.ClickOnOneRadiobutton(_newsletterYes);
            CheckBoxHelper.ClickCheckBox(_policyBox);
            MenuButtonHelper.SelectMenuButton(_createAccountButton);
            MenuButtonHelper.SelectMenuButton(_myAccountTab);
            MenuButtonHelper.SelectMenuButton(_logoutButton);
        }

    }
}
