using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToluMSTestFramework.ComponentHelper;
using ToluMSTestFramework.Settings;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace ToluMSTestFramework.Z_Randomscript
{
   [TestClass]
    public class Valtech
    {
        #region NAVIGATE TO THE WWW.VALTECH.COM HOMEPAGE. Assert that the "LATEST NEWS" section is displayed

        [TestMethod, TestCategory("VALTECH")]
         public void NavigateToHomePage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.valtech.com/");
            driver.Manage().Window.Maximize();
            //driver.FindElement(By.CssSelector("a#CybotCookiebotDialogBodyButtonAccept")).Click();
             IWebElement cookies = driver.FindElement(By.CssSelector("a#CybotCookiebotDialogBodyButtonAccept"));
            if (cookies.Displayed)
            {
                cookies.Click();
            }

            var expectedText = "LATEST NEWS";
            var actualText = driver.FindElement(By.CssSelector("#container > div:nth-child(2) > div:nth-child(3) > div.news-post__listing-header > header > h2")).Text;
            Assert.AreEqual(expectedText, actualText);
            driver.Quit();
            }
        #endregion

        #region Navigate to ABOUT, SERVICES & WORK via top navigation and assert that H1 tag in each is displaying a relevantpage name. eg: Service page is displaying "Service
        [TestMethod, TestCategory("VALTECH")]
        public void ABoutServiceWork()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.valtech.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.ClassName("icon-menu")).Click();
            driver.FindElement(By.XPath("//a[@href='/about/']")).Click();
            //var expectedAbout = "About";
            //var actualAbout = driver.FindElement(By.CssSelector(".page-header h1")).Text;
            //Assert.AreEqual(expectedAbout, actualAbout);
            //driver.FindElement(By.XPath("//a[@href='/services/']")).Click();
            //var expectedService = "Services";
            //var actualServices = driver.FindElement(By.CssSelector(".page-header h1")).Text;
            //Assert.AreEqual(expectedService, actualServices);
            //driver.FindElement(By.XPath("//a[@href='/work/']")).Click();
            //var expectedWork = "Work";
            //var actualWork = driver.FindElement(By.CssSelector(".page-header h1")).Text;
            //Assert.AreEqual(expectedWork, actualWork);
            //driver.Quit;
        }
        #endregion
       
        #region Navigate to Contact page and output how many offices in total
        [TestMethod, TestCategory("VALTECH")]
        public void ValtechOffices()
       {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.valtech.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.CssSelector("a#CybotCookiebotDialogBodyButtonAccept")).Click();
            driver.FindElement(By.ClassName("hamburger__flipper")).Click();
            var country = driver.FindElements(By.ClassName("list-item list-item--active"));
            var allCountry = country.Count;
            Console.WriteLine(allCountry);
            driver.Quit();
        }
        #endregion


    }
}
