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
        //Navigate to ABOUT, SERVICES & ABOUT via top navigation and assert that H1 tag in each is displaying a relevantpage name. eg: Service page is displaying "Service"
        public void ABoutServiceWork()
       {
            NavigationHelper.NavigateToURL("https://www.valtech.com/");
            var expectedAboutText   = "ABOUT";
            var expectedServiceText = "SERVICES";
            var expectedWorkText    = "WORK";
            var actualAboutText = ObjectRepository.driver.FindElement(By.XPath("//a[@href='/about/']")).Text;
            Thread.Sleep(3000);
            MenuButtonHelper.SelectMenuButton(By.XPath("//a[@href='/services/']"));
            //ObjectRepository.driver.FindElement(By.XPath("//a[@href='/services/']")).Click();
            //ObjectRepository.driver.FindElement(By.CssSelector("#navigationMenuWrapper > div > ul > li:nth-child(3) > a > span")).Click();
            //var actualServiceText = ObjectRepository.driver.FindElement(By.XPath("//a[@href='/services/']")).Text;
            //ObjectRepository.driver.FindElement(By.XPath("//a[@href='/work/']")).Click();
            //var actualWorkText = ObjectRepository.driver.FindElement(By.XPath("//a[@href='/work/']")).Text;
            //Assert.AreEqual(expectedAboutText, actualAboutText);
            //Assert.AreEqual(expectedServiceText, actualServiceText);
            //Assert.AreEqual(expectedWorkText, actualWorkText);
            //Console.WriteLine(expectedAboutText);
            Console.WriteLine(actualAboutText);

           // var expectedAboutText =  ObjectRepository.driver.FindElement(By.XPath("//span[@itemprop='title']")).Text;


            //MenuButtonHelper.SelectMenuButton(By.XPath("//a[@href='about']"));
           // "//button[@type='submit']"
            //var aboutText = ObjectRepository.driver.FindElement(By.XPath("//a[@href='/about/']")).Text;
            // Assert.AreSame(aboutText.Contains("About"));
           // "//div[contains(text()," + "'Please provide a valid UK postcode.')]"
        }
        [TestMethod, TestCategory("VALTECH")]
        //Navigate to Contact page and output how many offices in total
       public void ValtechOffice()
       {
            NavigationHelper.NavigateToURL("https://www.valtech.com/");
        }

    }
}
