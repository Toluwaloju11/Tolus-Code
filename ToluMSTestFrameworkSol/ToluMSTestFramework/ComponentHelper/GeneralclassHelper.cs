using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
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

       public static void TakeAScreenshot(string filename = "Screenshot")
       {
           /*
            * FOR THE STRING ARGUEMENT ABOVE, IF THE TAKEASCREENSHOT FUNTION IS CALLED BUT THE USER DOES NOT PROVIDE AN
            * ARGUEMENT FOR FILENAME, Screenshot" WILL BE USED AS DEFAULT. IF AN ARGUEMENT IS PROVIDED,
            * IT WILL OVERRIDE Screenshot 
            */
           Screenshot screenshot = ObjectRepository.driver.TakeScreenshot();
           if (filename.Equals("Screenshot"))
           {
               filename = filename + DateTime.UtcNow.ToString("yyyy MMMM dd") + ".jpeg";
                screenshot.SaveAsFile(filename, ScreenshotImageFormat.Jpeg);
                return;
           }
           else
           {
                filename = filename + ".jpeg";
                screenshot.SaveAsFile(filename, ScreenshotImageFormat.Jpeg);

            }

        }

    }
}
