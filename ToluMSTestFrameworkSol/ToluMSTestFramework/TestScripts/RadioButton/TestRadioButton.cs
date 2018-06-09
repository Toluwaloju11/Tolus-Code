using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using ToluMSTestFramework.ComponentHelper;
using ToluMSTestFramework.Settings;

namespace ToluMSTestFramework.TestScripts.RadioButton
{ 
    [TestClass]
    public class TestRadioButton
    {
        [TestMethod, TestCategory("RADIO BUTTON")]
        public void RadioButtonTest()
        {
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetDemoRegister());
            RadioButtonHelper.ClickOnOneRadiobutton(By.XPath
            ("//*[@id=\"content\"]/form/fieldset[3]/div/div/label[2]/input"));
            //This is used when there is no unique identifier so an input identifier is used
            //IList<IWebElement> radio = ObjectRepository.driver.FindElements(By.TagName("input"));
            //foreach (var radioOption in radio)
            //{
            //    if (radioOption.GetAttribute("value").Equals("0"))
            //    {
            //        radioOption.Click();
            //    }
            //}
        }
    }
}
