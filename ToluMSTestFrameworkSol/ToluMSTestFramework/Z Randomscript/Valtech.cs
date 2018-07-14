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


namespace ToluMSTestFramework.Z_Randomscript
{
   [TestClass]
    public class Valtech
    {
      [TestMethod, TestCategory("VALTECH")]
      //NAVIGATE TO THE WWW.VALTECH.COM HOMEPAGE. Assert that the "LATEST NEWS" section is displayed
        public void NavigateToHomePAge()
        {
            NavigationHelper.NavigateToURL("https://www.valtech.com/");
            var expectedText = "LATEST NEWS";
            var actualText = ObjectRepository.driver.FindElement(By.CssSelector
            ("#container > div:nth-child(2) > div:nth-child(3) > div.news-post__listing-header > header > h2")).Text;
            //h2[contains(text()," +"'Latest news')]
            Assert.AreEqual(expectedText, actualText);
        }
        [TestMethod, TestCategory("VALTECH")]
        //Navigate to ABOUT, SERVICES & WORK via top navigation and assert that H1 tag in each is displaying a relevantpage name. eg: Service page is displaying "Service"
        public void ABoutServiceWork()
       {
            NavigationHelper.NavigateToURL("https://www.valtech.com/");
            var expectedAbout   = "About";
            var expectedService = "Services";
            var expectedWork    = "Work";
          
            MenuButtonHelper.SelectMenuButton(By.XPath("//a[@href='/about/']"));
            var actualAbout = ObjectRepository.driver.FindElement(By.CssSelector(".page-header h1")).Text;
            Assert.AreEqual(expectedAbout, actualAbout);

            MenuButtonHelper.SelectMenuButton(By.XPath("//a[@href='/services/']"));
            var actualServices = ObjectRepository.driver.FindElement(By.CssSelector(".page-header h1")).Text;
            Assert.AreEqual(expectedService,actualServices);

            MenuButtonHelper.SelectMenuButton(By.XPath("//a[@href='/work/']"));
            var actualWork = ObjectRepository.driver.FindElement(By.CssSelector(".page-header h1")).Text;
            Assert.AreEqual(expectedWork, actualWork);
        }
        [TestMethod, TestCategory("VALTECH")]
        //Navigate to Contact page and output how many offices in total
        public void ValtechOffices()
       {
            NavigationHelper.NavigateToURL("https://www.valtech.com/");
            var allOffices = ObjectRepository.driver.FindElement(By.ClassName("foot__offices")).Text;
            var allofficesCollection = allOffices.Split(',');
            var numberOfOffices = allofficesCollection.Length-1;


            Console.WriteLine(numberOfOffices);
       }

    }
}
