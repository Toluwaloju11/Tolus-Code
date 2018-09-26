using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ToluMSTestFramework.ComponentHelper;
using ToluMSTestFramework.Settings;
namespace AndreMSTestFramework.TestScripts.DataDriven
{
    [TestClass]
    public class RegisterAccountPageCopy
    {
        public TestContext TestContext { get; set; }
        public object TextboxHelper { get; private set; }
        public object CheckboxHelper { get; private set; }

        private readonly By _firstname = By.Id("input-firstname");
        private readonly By _lastname = By.Id("input-lastname");
        private readonly By _email = By.Id("input-email");
        private readonly By _phone = By.Id("input-telephone");
        private readonly By _password = By.Id("input-password");
        private readonly By _confirmPassword = By.Id("input-confirm");
        private readonly By _newsletterYes = By.XPath("//*[@id=\"content\"]/form/fieldset[3]/div/div/label[1]/input");
        private readonly By _policyBox = By.XPath("//*[@id=\"content\"]/form/div/div/input[1]");
        private readonly By _continueButton = By.ClassName("btn-primary");
        private readonly By _accountPageLink = By.LinkText("Account");
        private readonly By _myAccountTab = By.XPath("//*[@id=\"top-links\"]/ul/li[2]/a/span[1]");
        private readonly By _registerButton = By.XPath("//*[@id=\"top-links\"]/ul/li[2]/ul/li[1]/a");
        private readonly By _logoutButton = By.XPath("//*[@id=\"top-links\"]/ul/li[2]/ul/li[5]/a");

        [TestMethod, TestCategory("CSV READER")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            //@"C:\Users\Andre\Documents\RandomRepo\RandomFilesGitLearning\AndreMSTestFrameworkSol\AndreMSTestFramework\DataFiles\UserDataNew.csv",
            //"UserDataNew#csv",
            @"C:\Users\Tester\Automation\Tolus-Code\ToluMSTestFrameworkSol\ToluMSTestFramework\DataFiles\Transfer.csv",
            "Transfer#csv",
            //C:\Users\Tester\Automation\Tolus-Code\ToluMSTestFrameworkSol\ToluMSTestFramework\DataFiles
            DataAccessMethod.Sequential)]
        public void RegisterNewAccountDdt()
        {
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetDemoRegister());

            MenuButtonHelper.SelectMenuButton(_myAccountTab);
            MenuButtonHelper.SelectMenuButton(_registerButton);
            TextboxHelper.SendTextToTextbox(_firstname, TestContext.DataRow["FIRSTNAME"].ToString());
            TextboxHelper.SendTextToTextbox(_lastname, TestContext.DataRow["LASTNAME"].ToString());
            TextboxHelper.SendTextToTextbox(_email, TestContext.DataRow["EMAIL"].ToString());
            TextboxHelper.SendTextToTextbox(_phone, TestContext.DataRow["PHONE"].ToString());
            TextboxHelper.SendTextToTextbox(_password, TestContext.DataRow["PASSWORD"].ToString());
            TextboxHelper.SendTextToTextbox(_confirmPassword, TestContext.DataRow["CONFIRMPASSWORD"].ToString());
            RadioButtonHelper.ClickOnOneRadioButton(_newsletterYes);
            CheckboxHelper.ClickCheckbox(_policyBox);
            MenuButtonHelper.SelectMenuButton(_continueButton);
            MenuButtonHelper.SelectMenuButton(_myAccountTab);
            MenuButtonHelper.SelectMenuButton(_logoutButton);
        }

        [TestMethod, TestCategory("EXCEL READER")]
        [DataSource("System.Data.Odbc",
            @"Dsn=Excel Files;dbq=C:\Users\Andre\Documents\RandomRepo\RandomFilesGitLearning\AndreMSTestFrameworkSol\AndreMSTestFramework\DataFiles\UserDataNewExcel.xlsx;",
            "UserData$",
            DataAccessMethod.Sequential)]
        public void ReadFromExcelFile()
        {
            //NavigationHelper.
            //    NavigateToURL(ObjectRepository.
            //    Config.
            //    GetWebsite());

            MenuButtonHelper.SelectMenuButton(_myAccountTab);
            MenuButtonHelper.SelectMenuButton(_registerButton);

            TextboxHelper.SendTextToTextbox(_firstname, TestContext.DataRow["FirstName"].ToString());
            TextboxHelper.SendTextToTextbox(_lastname, TestContext.DataRow["LastName"].ToString());
            TextboxHelper.SendTextToTextbox(_email, TestContext.DataRow["Email"].ToString());
            TextboxHelper.SendTextToTextbox(_phone, TestContext.DataRow["Phone"].ToString());
            TextboxHelper.SendTextToTextbox(_password, TestContext.DataRow["Password"].ToString());
            TextboxHelper.SendTextToTextbox(_confirmPassword, TestContext.DataRow["ConfirmPassword"].ToString());
            RadioButtonHelper.ClickOnOneRadioButton(_newsletterYes);
            CheckboxHelper.ClickCheckbox(_policyBox);
            MenuButtonHelper.SelectMenuButton(_continueButton);
            MenuButtonHelper.SelectMenuButton(_myAccountTab);
            MenuButtonHelper.SelectMenuButton(_logoutButton);
        }

        [TestMethod, TestCategory("XML READER")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            @"C:\Users\Andre\Documents\RandomRepo\RandomFilesGitLearning\AndreMSTestFrameworkSol\AndreMSTestFramework\DataFiles\UserDataXML.xml",
            "Student",
            DataAccessMethod.Sequential)]
        public void ReadFromXMLFile()
        {
            NavigationHelper.
                NavigateToURL(ObjectRepository.
                    Config.
                    GetWebsite());

            MenuButtonHelper.SelectMenuButton(_myAccountTab);
            MenuButtonHelper.SelectMenuButton(_registerButton);

            TextboxHelper.SendTextToTextbox(_firstname, TestContext.DataRow["FirstName"].ToString());
            TextboxHelper.SendTextToTextbox(_lastname, TestContext.DataRow["LastName"].ToString());
            TextboxHelper.SendTextToTextbox(_email, TestContext.DataRow["Email"].ToString());
            TextboxHelper.SendTextToTextbox(_phone, TestContext.DataRow["Phone"].ToString());
            TextboxHelper.SendTextToTextbox(_password, TestContext.DataRow["Password"].ToString());
            TextboxHelper.SendTextToTextbox(_confirmPassword, TestContext.DataRow["ConfirmPassword"].ToString());
            RadioButtonHelper.ClickOnOneRadioButton(_newsletterYes);
            CheckboxHelper.ClickCheckbox(_policyBox);
            MenuButtonHelper.SelectMenuButton(_continueButton);
            MenuButtonHelper.SelectMenuButton(_myAccountTab);
            MenuButtonHelper.SelectMenuButton(_logoutButton);
        }

        [TestMethod]
        public void NavigateToAccountPageOne()
        {
            MenuButtonHelper.SelectMenuButton(_accountPageLink);
        }
    }
}
