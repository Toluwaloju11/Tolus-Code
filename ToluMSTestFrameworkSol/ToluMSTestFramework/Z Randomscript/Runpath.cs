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
using OpenQA.Selenium.Support.UI;
using ToluMSTestFramework.TestScripts.DropDownMenu;

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
            var actaulHeader1 = ObjectRepository.driver.FindElement(By.XPath
                ("//h1[contains(text(),'Switch today and ')]")).Text;
            var actaulHeader2 = ObjectRepository.driver.FindElement
                (By.XPath("//h2[contains(text(),'Need help switching')]")).Text;
            var actaulHeader3 = ObjectRepository.driver.FindElement
                (By.XPath("//h3[contains(text(),'About this service')]")).Text;
            Assert.AreNotEqual("COMPARE GAS & ELECTRICITY", actaulHeader1);
            Assert.AreNotEqual("COMPARE GAS & ELECTRICITY", actaulHeader2);
            Assert.AreNotEqual("COMPARE GAS & ELECTRICITY", actaulHeader3);
          }
        [TestMethod, TestCategory("RUNPATH")]
        public void NoPostcodeTest()
        {
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetGoCompareHome());
            Thread.Sleep(5000);
            ObjectRepository.driver.FindElement(By.CssSelector("a[id='AddressLookup_SearchButton']")).Click();
            Thread.Sleep(3000);
            var actualErrorMessage = ObjectRepository.driver.FindElement(By.CssSelector("div[class*='message']")).Text;
            Assert.AreEqual("Please provide a valid postcode.", actualErrorMessage);
            Console.WriteLine(actualErrorMessage);
        }
        [TestMethod, TestCategory("RUNPATH")]
        public void IvalidPostcodeTest()
        {
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetGoCompareHome());
            Thread.Sleep(5000);
            TextBoxHelper.SendTextToTextbox(By.CssSelector("#AddressLookup_Postcode"), "W30");
            ObjectRepository.driver.FindElement(By.CssSelector("a[id='AddressLookup_SearchButton']")).Click();
            Thread.Sleep(3000);
            var actualErrorMessage = ObjectRepository.driver.FindElement(By.CssSelector("div[class*='message']")).Text;
            Assert.AreEqual("Please provide a valid postcode.", actualErrorMessage, "Values are not equal");
            Console.WriteLine(actualErrorMessage);
           }
        [TestMethod, TestCategory("RUNPATH")]
        public void ValidPostcodeTest()
        {
            //ObjectRepository.driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(1));
            WebDriverWait wait = new WebDriverWait(ObjectRepository.driver, TimeSpan.FromSeconds(50));
            wait.PollingInterval = TimeSpan.FromMilliseconds(250);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetGoCompareHome());
            Thread.Sleep(1000);
            TextBoxHelper.SendTextToTextbox(By.CssSelector("#AddressLookup_Postcode"), "W30PN");
            Thread.Sleep(1000);
            MenuButtonHelper.SelectMenuButton(By.CssSelector("a[id='AddressLookup_SearchButton']"));
            Thread.Sleep(1000);
            MenuButtonHelper.SelectMenuButton(By.CssSelector("#AddressLookup_AddressList li:nth-child(1)"));
            Thread.Sleep(1000);
            MenuButtonHelper.SelectMenuButton(By.CssSelector("label[for='Both gas and electricity']"));
            Thread.Sleep(1000);
            MenuButtonHelper.SelectMenuButton(By.CssSelector("label[for='IsDualFuel_Yes']"));
            Thread.Sleep(1000);
            MenuButtonHelper.SelectMenuButton(By.CssSelector("label[for='dual-British Gas']"));
            Thread.Sleep(1000);
            MenuButtonHelper.SelectMenuButton(By.CssSelector("label[for='dual-Monthly Direct Debit']"));
            Thread.Sleep(1000);
            MenuButtonHelper.SelectMenuButton(By.CssSelector("label[for='DualFuelIsEconomy7_Yes']"));
            Thread.Sleep(1000);
            MenuButtonHelper.SelectMenuButton(By.CssSelector("label[for='dual-Paper']"));
            Thread.Sleep(1000);
            MenuButtonHelper.SelectMenuButton(By.CssSelector("#DualFuelTariff_EnabledDropdown"));
            Thread.Sleep(1000);
            //DropDownHelper.SelectByIndex(By.CssSelector("#DualFuelTariff_EnabledDropdown"),1);
            DropDownHelper.SelectByText(By.CssSelector("#DualFuelTariff_EnabledDropdown"), "Fixed Price July 2018");
            //MenuButtonHelper.SelectMenuButton(By.CssSelector("span[class='continue__text']"));
            //MenuButtonHelper.SelectMenuButton(By.CssSelector("//p[contains(text(),'British Gas')]"));
            //MenuButtonHelper.SelectMenuButton(By.XPath("//button[@type='submit']"));
            //Assert.AreNotEqual("https://energy.gocompare.com/gas-electricity/step1", ObjectRepository.driver.Url);
            //Thread.Sleep(2000);
            //var pageMainHeader = ObjectRepository.driver.FindElement(By.CssSelector
            //    ("")).Text;
            //Assert.IsFalse(pageMainHeader.Contains("YOUR SEARCH"));
        }
    }
}
