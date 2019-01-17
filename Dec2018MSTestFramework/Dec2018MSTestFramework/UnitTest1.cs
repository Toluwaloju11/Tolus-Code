using System;
using System.Configuration;
using System.Reflection;
using System.Threading;
using Dec2018MSTestFramework.ComponentHelper;
using Dec2018MSTestFramework.Configuration;
using Dec2018MSTestFramework.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.Extensions;

namespace Dec2018MSTestFramework
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod, TestCategory("Tolu")]
        public void TestMethod1()
        {
           
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetWebsite());
            ButtonHelper.ClickButton(By.LinkText("Desktops"));
            ButtonHelper.ClickButton(By.LinkText("Mac (1)"));
            DropDownHelper.SelectElementByIndex(By.Id("input-sort"),3);
            DropDownHelper.SelectElementByIndex(By.Id("input-limit"),3);
            ButtonHelper.ClickButton(By.CssSelector("#content > div:nth-child(3) > div > div > div:nth-child(2) > div.button-group > button:nth-child(1) > span"));
            //ButtonHelper.ClickButton(By.LinkText("Add to Cart"));
            //ButtonHelper.ClickButton(By.LinkText("cart-total"));

    }
    }
}
