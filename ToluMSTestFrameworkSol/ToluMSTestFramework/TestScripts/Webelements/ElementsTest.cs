using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using ToluMSTestFramework.ComponentHelper;
using ToluMSTestFramework.Settings;

namespace ToluMSTestFramework.TestScripts.Webelements
{
    [TestClass]
    public class ElementsTest
    {
        [TestMethod]
        [TestCategory("WEB ELEMENTS")]
        public void WebElement()
        {
            try
            {
                NavigationHelper.NavigateToURL(ObjectRepository.Config.GetWebsite());
                ObjectRepository.driver.FindElement(By.Id("hero"));
                ObjectRepository.driver.FindElement(By.ClassName("visible-xs-block"));
                ObjectRepository.driver.FindElement(By.TagName("a"));
                ObjectRepository.driver.FindElement(By.XPath("//*[@id=\"feature\"]/div[3]"));
                ObjectRepository.driver.FindElement(By.LinkText("View Demo")); 
                ObjectRepository.driver.FindElement(By.PartialLinkText("View")); 
                ObjectRepository.driver.FindElement(By.
                    CssSelector("#navbar-collapse-header > ul > li:nth-child(1) > a"));
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e); 
            }
          
        }
        [TestMethod, TestCategory("List Test")]
        public void MultipleWebelements()
        {
            NavigationHelper.NavigateToURL(ObjectRepository.Config.GetWebsite());

            IList<string> list = new List<string>();
            list.Add("Object one");
            list.Add("Object two");
            list.Add("Object three");
            Console.WriteLine("The size of the list is {0}",list.Count);
            list.RemoveAt(2);
            Console.WriteLine("The size of the list is now {0}", list.Count);
            Console.WriteLine("List index 1 is {0}", list[0]);
            Console.WriteLine("List index 2 is {0}", list[1]);
            list.Clear();
            Console.WriteLine("The size of the list is {0}", list.Count);
            
            IReadOnlyCollection<IWebElement> listcoll = 
                ObjectRepository.driver.FindElements(By.TagName("div"));
            Console.WriteLine("the size of listcoll is {0}",listcoll.Count);
            Console.WriteLine("the first element is {0}",listcoll.ElementAt(0));
        
        }
    }
}
