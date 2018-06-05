using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using ToluMSTestFramework.ComponentHelper;
using ToluMSTestFramework.Settings;

namespace ToluMSTestFramework.TestScripts.TestLinkClick
{
    [TestClass]
     public class TestLink
    {
        [TestMethod,TestCategory("Click on a link")]
        public void ClickOnLink()
        {
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetWebsite());
            
            //This is to  help if there are more than 1 attribute with the same value
            //Check LinkHelper and GenericClass helper class

            LinkHelper.ClickLink(By.LinkText("Login"));
        }
       
    }
}
