using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ToluMSTestFramework.ComponentHelper;
using ToluMSTestFramework.Settings;

namespace ToluMSTestFramework.TestScripts.TextBoxTest
{
    [TestClass]
    public class TestTextBox
    {
        [TestMethod, TestCategory("Basic Code")]
        public void TextBox()
        {
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetDemowebsite());
            LinkHelper.ClickLink(By.Id("input-email"));
            //IWebElement EmaiBoxField = ObjectRepository.driver.FindElement(By.Name("email"));
            //EmaiBoxField.Clear();
            TextBoxHelper.ClearTextBox(By.Id("input-email"));
            TextBoxHelper.SendTextToTextbox(By.Id("input-email"),ObjectRepository.Config.GetEmail());
            TextBoxHelper.ClearTextBox(By.Id("input-password"));
            TextBoxHelper.SendTextToTextbox(By.Id("input-password"),ObjectRepository.Config.GetPassword());




        }
    }
}
