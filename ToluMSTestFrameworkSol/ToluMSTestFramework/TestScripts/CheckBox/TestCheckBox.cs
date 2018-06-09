using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using ToluMSTestFramework.ComponentHelper;
using ToluMSTestFramework.Settings;

namespace ToluMSTestFramework.TestScripts.CheckBox
{
    [TestClass]
    public class TestCheckBox
    {
        [TestMethod]
        [TestCategory("SELECT A CHECKBOX")]
        public void Testtextbox()
        {
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetDemoRegister());
            //IWebElement checkElement = ObjectRepository.driver.FindElement(By.Name("agree"));
            //checkElement.Click();
            CheckBoxHelper.IsCheckboxSelected(By.Name("agree"));
            CheckBoxHelper.ClickCheckBox(By.Name("agree"));


        }
    }
}
