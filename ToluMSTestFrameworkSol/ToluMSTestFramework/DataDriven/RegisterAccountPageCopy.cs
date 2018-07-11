using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace ToluMSTestFramework.DataDriven
{
    [TestClass]
    public class RegisterAccountPageCopy
    {
        public TestContext testcontext { get; set; }
        private readonly By _firstName = By.Id("input-firstname");
        private readonly By _lastName = By.Id("input-lastname");
        private readonly By _email = By.Id("input-email");
        private readonly By _telephone = By.Id("input-telephone");
        private readonly By _password = By.Id("input-password");
        private readonly By _confirmPassword = By.Id("input-confirm");
        private readonly By _newsletterYes = By.XPath("//*[@id=\"content\"]/form/fieldset[3]/div/div/label[1]/input");
        private readonly By _policyBox = By.XPath("//*[@id=\"content\"]/form/div/div/input[1]");
        private readonly By _registerButton = By.ClassName("btn-primary");
        private readonly By _myAccountTab = By.ClassName("//span[contains(text(),'My Account')]");

        [TestMethod, TestCategory("CSV-READER")]
        [DataSource("Microsoft.Visualstudio.Testtools.datasource.csv",
            @"C:\Users\Tester\Documents\MySeleniumCode\SeleniumTestData\datadriven.csv",
            "datadriven#csv", DataAccessMethod.Sequential)]
        public void RegisterNewAccount()
        {
            
        }
    }
}
