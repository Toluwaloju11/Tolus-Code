using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ToluMSTestFramework.Settings;

namespace ToluMSTestFramework.ComponentHelper
{

    //This is to help when there are more than one elements with same value
   public class GeneralclassHelper
    {
       public static bool IsElementPresent(By locator)
       {
           try
           {
                return ObjectRepository.driver.FindElements(locator).Count == 1;

            }
            catch (Exception)
           {
               
               return false;
           }
       }

       public static IWebElement getElement(By locator)
       {
           if (IsElementPresent(locator))
           {
               return ObjectRepository.driver.FindElement(locator);
           }
           {
               throw new NoSuchElementException("Element is not present" + locator);
           }

       }
    }
}
