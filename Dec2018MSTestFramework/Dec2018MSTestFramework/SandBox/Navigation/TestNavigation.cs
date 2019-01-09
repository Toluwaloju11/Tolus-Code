using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dec2018MSTestFramework.ComponentHelper;
using Dec2018MSTestFramework.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Dec2018MSTestFramework.SandBox.Navigation
{
    [TestClass]
    public class TestNavigation
    {
        [TestMethod, TestCategory("Lunch Website")]
        public void NavigateToWebsite()
        {
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetWebsite());
        }
    }
}
