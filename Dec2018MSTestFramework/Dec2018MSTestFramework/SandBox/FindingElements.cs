using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Dec2018MSTestFramework.ComponentHelper;
using Dec2018MSTestFramework.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Dec2018MSTestFramework.SandBox
{
    [TestClass]
    public class FindingElements
    {
        [TestMethod,TestCategory("TagName")]
        public void MultipleElements()
        {

            //This is for finding an element with mutiple tag names
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetWebsite());
            var tagList = ObjectRepository.Driver.FindElements(By.TagName("class"));
            foreach (var tagValue in tagList)
            {
                if (tagValue.GetAttribute("value").Equals("container"))
                {
                    tagValue.Click(); 
                    Thread.Sleep(4000);
                    break;
                }
            }

        }
    }
}
