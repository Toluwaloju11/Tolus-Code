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
           
            //MethodBase.GetCurrentMethod().Name;
            //System.Reflection.MethodBase.GetCurrentMethod().DeclaringType;
            //ObjectRepository.Driver.TakeScreenshot();
            //var sortMenu = ObjectRepository.Driver.FindElement(By.Id("input-sort"));
            //try
            //{
            //    NavigationHelper.NavigateToURL(ObjectRepository.Config.GetWebsite());
            //    LinkHelper.ClickLink(By.LinkText("Desktops"));
            //    LinkHelper.ClickLink(By.LinkText("Mac (5)"));
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //    GenericHelper.TakeAScreenshot();
            //    throw;
            //}
           var met= MethodBase.GetCurrentMethod();
            Console.WriteLine(met);

        }
    }
}
