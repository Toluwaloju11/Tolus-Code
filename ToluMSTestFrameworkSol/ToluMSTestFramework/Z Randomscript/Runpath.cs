using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using ToluMSTestFramework.ComponentHelper;
using ToluMSTestFramework.Settings;
namespace ToluMSTestFramework.Z_Randomscript
{
    [TestClass]
   public class Runpath
        {
        [TestMethod, TestCategory("RUNPATH")]
       public void ValidatePageTitle()
        {
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetGoCompareHome());
            var expectedpageTitle = "Utilities from Go Compare";
            var actualtitle = ObjectRepository.driver.Title;
            Console.WriteLine(expectedpageTitle);
            Console.WriteLine(actualtitle);
            Assert.AreEqual(expectedpageTitle,actualtitle);
        }
        [TestMethod, TestCategory("RUNPATH")]
        public void ValidateMainHeader()
        {
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetGoCompareHome());
            var expectedHeader = "COMPARE GAS & ELECTRICITY";
            var actaulHeader1 = ObjectRepository.driver.FindElement(By.XPath
                ("//h1[contains(text(),'Switch today and ')]")).Text;
            var actaulHeader2 = ObjectRepository.driver.FindElement
                (By.XPath("//h2[contains(text(),'Need help switching')]")).Text;
            var actaulHeader3 = ObjectRepository.driver.FindElement
                (By.XPath("//h3[contains(text(),'About this service')]")).Text;
            //Console.WriteLine(actaulHeader1);
            Assert.AreNotEqual(expectedHeader,actaulHeader1);
            Assert.AreNotEqual(expectedHeader,actaulHeader2);
            Assert.AreNotEqual(expectedHeader,actaulHeader3);
          }
        [TestMethod, TestCategory("RUNPATH")]
        public void NoPostcodeTest()
        {
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetGoCompareHome());
            var expectedError = "Please provide your postcode, as different regions have different " +
                                "fuel prices.";
            Thread.Sleep(3000);
            MenuButtonHelper.SelectMenuButton(By.XPath("//button[@type='submit']"));
            var actualErrorMessage = ObjectRepository.driver.FindElement(By.XPath
            ("//div[contains(text(),'Please provide your postcode, as different " +
            "regions have different fuel prices.')]"))
            .Text;
            Assert.AreEqual(expectedError,actualErrorMessage);
        }
        [TestMethod, TestCategory("RUNPATH")]
        public void IvalidPostcodeTest()
        {
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetGoCompareHome());
            var expectedError = "Please provide a valid UK postcode.";
            Thread.Sleep(3000);
            //ObjectRepository.driver.FindElement(By.XPath("//input[@type='text'and @placeholder = 'Postcode']")).SendKeys("W30PN#");
            TextBoxHelper.SendTextToTextbox(By.XPath("//input[@type='text'and @placeholder = 'Postcode']"), "W30PN#");
            MenuButtonHelper.SelectMenuButton(By.XPath("//button[@type='submit']"));
            var actualErrorMessage = ObjectRepository.driver.FindElement(By.XPath("//div[contains(text()," +"'Please provide a valid UK postcode.')]")).Text;
            Assert.AreEqual(expectedError, actualErrorMessage);
            
        }
        [TestMethod, TestCategory("RUNPATH")]
        public void ValidPostcodeTest()
        {
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetGoCompareHome());
            var expectedHeader = "START YOUR SEARCH";
            var expectedURL = "https://energy.gocompare.com/gas-electricity/step1";
            Thread.Sleep(3000);
            TextBoxHelper.SendTextToTextbox(By.XPath("//input[@type='text'and @placeholder = 'Postcode']"), "W30PN");
            MenuButtonHelper.SelectMenuButton(By.XPath("//button[@type='submit']"));
            Thread.Sleep(3000);
            MenuButtonHelper.SelectMenuButton(By.XPath("//p[contains(text(),'British Gas')]"));
            Thread.Sleep(2000);
            MenuButtonHelper.SelectMenuButton(By.XPath("//button[@type='submit']"));
            Thread.Sleep(3000);
            var actualURL = ObjectRepository.driver.Url;
            //Console.WriteLine(actualURL);
            Assert.AreNotEqual(expectedURL,actualURL);
            Thread.Sleep(3000);
            var pageMainHeader = ObjectRepository.driver.FindElement(By.CssSelector
                ("#vanilla > div.c-header > div > div > div > header.quote > div > h1.runpath-logo > img")).Text;
            // #vanilla > div.c-header > div > div > div > header.quote > div > h1.runpath-logo > img
            Assert.IsFalse(pageMainHeader.Contains("YOUR SEARCH"));
        }
    }
}
